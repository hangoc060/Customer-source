Imports Clsql
Imports ClsControl2
Imports ClsLookup
Imports ClsGoogleSync

Public Class Frmmain
    Dim bindingattendee As New BindingSource
    Dim dtattendee As DataTable
    Dim dtml As DataTable
    Dim email As String = ""
    Dim auto_syn As Boolean = False
    Dim authentication_Code, refresh_token, access_token As String
    Dim last_synced As DateTime = Nothing
    Public WithEvents list As ClsList.List1
    Private Sub dmload(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ClsControl2.PropertyOfForm.CheckRegister = False Then
            Me.Close()
        End If
        listid = "nkcv"
        list = New ClsList.List1(listid, grd, frmin, True, "1=0")
        list.AddToolStripFind(ToolStrip1)
        ToolStrip1.Items.Add(New ToolStripSeparator)
        list.AddToolStripMain(ToolStrip1)

        list.AddMenuItem(mnfile)
        list.AddContextMenu()
        AddHandler frmin.btnLuu.Click, AddressOf list.Save
        AddHandler frmin.btnhuy.Click, AddressOf list.Cancel
        AddHandler list.BeforeAddItem, AddressOf Me.list_AddItem
        AddHandler list.BeforeEditItem, AddressOf Me.list_editItem
        AddHandler list.AfterAddItem, AddressOf Me.afteradditem
        AddHandler list.AfterEditItem, AddressOf Me.afteredititem
        AddHandler list.AfterDeleteItem, AddressOf Me.AfterDeleteItem
        AddHandler list.AfterFind, AddressOf Me.tim
        Me.ContextMenuStrip = list.Contextmenu
        conn = list.conn
        If Not (list.onlyEdit Or list.onlyAdd Or list.onlyDelete) Then
            PropertyOfForm.SetLable(list.oLable, Me)
            Me.Icon = frmin.Icon
            user.Text = Clsql.Reg.GetValue("ID")
            lblcty.Text = Clsql.Others.Options("cty_name", conn)
            PropertyOfForm.SetImage4Control("user.bmp", user)
        End If
        
        'setupdat attendee
        Dim ogrid As New ClsControl2.OnGrid(frmin.gridattendee)
        loadAttendee("")
        dtml = ClsControl2.PropertyOfGrid.SetMaxLength(conn, frmin.gridattendee, "attendees")
        '
        setlookup()
        'create auto sync
        Dim dttoken As DataTable = conn.GetDatatable("select * from dmnsd where id ='" & Reg.GetValue("id") & "'")
        authentication_Code = dttoken.Rows(0)("authentication_code")
        refresh_token = dttoken.Rows(0)("refresh_token")
        email = dttoken.Rows(0)("email")
        access_token = dttoken.Rows(0)("access_token")
        auto_syn = dttoken.Rows(0)("sync_yn")
        Try
            last_synced = dttoken.Rows(0)("last_synced")
        Catch ex As Exception

        End Try

        If dttoken.Rows(0)("confirmed_auto") = False Then
            If MsgBox("Bạn có muốn tự động đồng bộ lịch làm việc của bạn với lịch làm việc trên google không?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
                auto_syn = True
                createGoogleSync()
                sync()
            End If
            conn.Execute("update dmnsd set sync_yn =" & conn.ConvertToSQLType(auto_syn) & ",confirmed_auto=1 where id ='" & Reg.GetValue("id") & "'")
        Else
            If auto_syn Then
                createGoogleSync()
                If Not (list.onlyAdd Or list.onlyDelete Or list.onlyEdit) Then
                    sync()
                End If

            End If
        End If
        
        '
        LoadLNV()
        Calendar1.FillMonth(Now.Month, Now.Year)
    End Sub
    Private Sub loadAttendee(ByVal stt_rec As String)
        dtattendee = conn.GetDatatable("select * from attendees where stt_rec ='" & stt_rec & "'")
        bindingattendee.DataSource = dtattendee
        If frmin.gridattendee.ColumnCount = 0 Then
            ClsControl2.PropertyOfGrid.FillGrid(conn, "attendees", frmin.gridattendee, bindingattendee)
        End If
    End Sub
    Private Sub deleteAttendees(ByVal stt_rec As String)
        Dim query As String = "delete from attendees where stt_rec ='" & stt_rec & "'"
        conn.Execute(query)
    End Sub
    Private Sub saveAttendees(ByVal stt_rec As String)
        deleteAttendees(stt_rec)
        For Each r As DataGridViewRow In frmin.gridattendee.Rows
            If r.IsNewRow = False Then
                If r.Cells("email").Value.ToString.Trim = "" Then
                    frmin.gridattendee.Rows.Remove(r)
                End If
            End If

        Next
        bindingattendee.EndEdit()
        For Each r As DataRow In dtattendee.Rows
            If r.RowState <> DataRowState.Deleted Then

                r("stt_rec") = stt_rec
            End If
        Next
        dtattendee.AcceptChanges()
        conn.WriteTableToServer(dtattendee, "attendees")
    End Sub
    Private Sub thoat(ByVal sender As Object, ByVal e As System.EventArgs)
        list = Nothing
        Me.Close()
    End Sub
    Private Sub list_AddItem()
        Dim defaultvalue As New Collection
        Dim stt_rec As String = Strings.Format(Now, "yyyyMMddhhmmss")
        defaultvalue.Add(stt_rec, "stt_rec")
        defaultvalue.Add(Calendar1.CurrentDate, "ngay")
        defaultvalue.Add(conn.Server.getdate(), "ngay_sua")
        list.SetKeys = defaultvalue
        'set value default
        Dim defaults As New Collection
        defaults.Add(Strings.Format(Calendar1.CurrentDate, "HH:mm:ss"), "start_time")
        defaults.Add(Strings.Format(Calendar1.CurrentDate, "HH:mm:ss"), "finish_time")
        defaults.Add(Calendar1.CurrentDate, "start")
        defaults.Add(Calendar1.CurrentDate, "finish")
        If list.onlyAdd Then
            defaults.Add(Reg.GetValue("id"), "ma_nv")
        Else
            defaults.Add(TreeNV.SelectedNode.Tag, "ma_nv")
        End If

        list.ValueDefaults = defaults
        loadAttendee(stt_rec)
    End Sub
    Private Sub list_editItem()
        Dim stt_rec As String = grd.CurrentRow.Cells("stt_rec").Value.ToString
        loadAttendee(stt_rec)
    End Sub
    Private Sub afteradditem(ByVal row As DataRow)
        Dim rm As DataRow
        rm = dtngay.NewRow
        rm(0) = row("start")
        dtngay.Rows.Add(rm)
        saveAttendees(row("stt_rec"))
        If googlesync IsNot Nothing Then
            Try
                Dim ev As EventObj = googlesync.rowToEvent(conn, row)
                ev = googlesync.addEvent(email, ev)
                row("id") = ev.id
                Dim query As String = "update nkcv set id ='" & ev.id & "' where stt_rec ='" & row("stt_rec") & "'"
                conn.Execute(query)
            Catch ex As Exception
                googlesync = Nothing
            End Try

        End If
    End Sub
    Private Sub afteredititem(ByVal row As DataRow)
        Dim rm As DataRow
        rm = dtngay.NewRow
        rm(0) = row("start")
        dtngay.Rows.Add(rm)
        saveAttendees(row("stt_rec"))
        If row("id").ToString <> "" AndAlso googlesync IsNot Nothing AndAlso row("ma_nv") = Reg.GetValue("id") Then
            Try
                Dim ev As EventObj = googlesync.rowToEvent(conn, row)
                ev.id = row("id")
                ev = googlesync.updateEvent(email, ev)
                row("id") = ev.id
                Dim query As String = "update nkcv set id ='" & ev.id & "' where stt_rec ='" & row("stt_rec") & "'"
                conn.Execute(query)
            Catch ex As Exception
                googlesync = Nothing
            End Try

        End If
    End Sub
    Private Sub AfterDeleteItem(ByVal e As DataRow)
        Dim query As String = "select start from " & list.tablename & " where " & list.CSearch
        dtngay = conn.GetDatatable(query)
        deleteAttendees(e("stt_rec"))
        'add to events deleted table
        query = conn.GetInsertQueryFromDataRow(e, "eventsdeleted")
        conn.Execute(query)
        'delete from google
        If e("id").ToString <> "" AndAlso googlesync IsNot Nothing AndAlso e("ma_nv") = Reg.GetValue("id") Then
            Try
                googlesync.deleteEvent(email, e("id").ToString)
            Catch ex As Exception
                googlesync = Nothing
            End Try

        End If
    End Sub
    Sub LoadLNV()
        TreeNV.Nodes.Clear()
        Dim imagelist As New ImageList
        TreeNV.ImageList = imagelist
        If IO.File.Exists(Application.StartupPath & "\images\user.bmp") Then
            Dim im As System.Drawing.Image
            im = System.Drawing.Image.FromFile(Application.StartupPath & "\images\user.bmp")
            imagelist.Images.Add(im)
        End If
        'all
        Dim nodall As New TreeNode
        If conn.Lang = SQL.Language.Vietnamese Then
            nodall.Text = "<Tất cả>"
        Else
            nodall.Text = "<All>"
        End If

        nodall.Tag = ""
        nodall.ImageIndex = 0
        TreeNV.Nodes.Add(nodall)
        '
        Dim dt As DataTable
        If list.rights.Right("XNK") = False Then
            dt = conn.GetDatatable("select id as ma_nv,idname as ten_nv from dmnsd where trang_thai =1 and id='" & Clsql.Reg.GetValue("ID") & "'")
        Else
            dt = conn.GetDatatable("select id as ma_nv,idname as ten_nv from dmnsd where trang_thai =1")
        End If

        For Each r As DataRow In dt.Rows
            Dim nod As New TreeNode
            nod.Text = r("ten_nv")
            nod.Tag = r("ma_nv")
            nod.ImageIndex = 0
            TreeNV.Nodes.Add(nod)
            If r("ma_nv").ToString.Trim.ToUpper = Reg.GetValue("ID").Trim.ToUpper Then
                TreeNV.SelectedNode = nod
            End If
        Next

    End Sub
    Private Sub loadEvents(ByVal ma_nv As String, ByVal ngay As DateTime)

        Dim dkma_nv As String
        If ma_nv = "" Then
            list.moi.Enabled = False

            dkma_nv = "ma_nv like '%%'"
        Else
            list.moi.Enabled = True

            dkma_nv = "ma_nv ='" & ma_nv & "'"
        End If
        lblthongtin.Text = Strings.Format(ngay, "dd/MM/yyyy")
        list.CSearch = "(1=1)"
        list.LoadData(dkma_nv & " and start =" & conn.ConvertToSQLType(ngay))
        list.CSearch = "(" & dkma_nv & " and month(start) = " & ngay.Month & " and year(start) = " & ngay.Year & ")"

        If ma_nv = "" Then
            list.moi.Enabled = False

        Else
            list.moi.Enabled = True
        End If

        formatCalender()
    End Sub



    Sub tim()
        lblthongtin.Text = list.txtdktim.Text
    End Sub


    Private Sub Calendar1_DateSelected(ByVal e As Date) Handles Calendar1.DateSelected
        If list IsNot Nothing AndAlso Me.Enabled = True Then
            If TreeNV.SelectedNode IsNot Nothing Then
                list.moi.Enabled = True
                loadEvents(TreeNV.SelectedNode.Tag, Calendar1.CurrentDate)
            Else
                loadEvents("", Calendar1.CurrentDate)
            End If

        End If

    End Sub
    Private Sub formatCalender()
        Calendar1.BackColor4Date = Calendar1.BackColor
        If list IsNot Nothing Then
            Dim query As String = "select start from " & list.tablename & " where " & list.CSearch & " group by start"
            dtngay = conn.GetDatatable(query)
            For Each r As DataRow In dtngay.Rows
                Calendar1.FormatDate(r(0), Color.YellowGreen, Application.StartupPath & "\images\plan.bmp")
            Next
        End If
    End Sub
    Dim dtngay As DataTable
    Private Sub MonthChanged(ByVal month As Integer, ByVal year As Integer) Handles Calendar1.MonthChanged
        formatCalender()
    End Sub
    Sub setlookup()
        'set combobox
        If Clsql.Reg.GetValue("Language") = "Vi" Then
            ClsLookup.AddItems.AddItemCbb(conn, "select trang_thai_xl,ten from dxl where trang_thai =1", frmin.cbbma_tien_do, "ten", "trang_thai_xl")
            Calendar1.Language = clsCalendar.Calendar.Languages.Vietnamese
        Else
            ClsLookup.AddItems.AddItemCbb(conn, "select trang_thai_xl,ten2 from dxl where trang_thai =1", frmin.cbbma_tien_do, "ten2", "trang_thai_xl")
            Calendar1.Language = clsCalendar.Calendar.Languages.English
        End If
        Dim oKH As New AutoCompleteLookup(conn, "dmkh", frmin.txtma_kh, "ma_kh", False)
        oKH.SetValue("ten_kh", frmin.lblten_kh)
        Dim oNCC As New ClsLookup.AutoCompleteLookup(conn, "dmnsd", frmin.Txtma_nv, "id", True)
        oNCC.SetValue("idname", frmin.ten_nv)

    End Sub

    Dim old_ma_nv As String = ""
    Private Sub TreeNV_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeNV.AfterSelect
        If old_ma_nv = e.Node.Tag Then
            Return
        End If
        old_ma_nv = e.Node.Tag
        For Each nod As TreeNode In TreeNV.Nodes
            If nod.Tag = e.Node.Tag Then
                e.Node.BackColor = Color.Blue 'AntiqueWhite
            Else
                nod.BackColor = TreeNV.BackColor
            End If

        Next
        If Me.Enabled Then
            loadEvents(e.Node.Tag, Calendar1.CurrentDate)
        End If
    End Sub
    Dim googlesync As ClsGoogleSync.Calendar = Nothing
    Function getNewSttRec() As String
        Dim stt_rec As Double = 0
        stt_rec = Strings.Format(Now, "yyyyMMddHHmmss")
check:
        Dim dtcheck As DataTable = conn.GetDatatable("select 1 from nkcv where stt_rec ='" & stt_rec & "'")
        If dtcheck.Rows.Count > 0 Then
            stt_rec = stt_rec + 1
            GoTo check
        End If
        Return stt_rec
    End Function
    Private Sub updateAuthentication(ByVal code As String)
        conn.Execute("update dmnsd set authentication_code ='" & code & "' where id ='" & Reg.GetValue("id") & "'")
    End Sub
    Private Sub updateRefreshToken(ByVal token As String)
        conn.Execute("update dmnsd set refresh_token ='" & token & "' where id ='" & Reg.GetValue("id") & "'")
    End Sub
    Private Sub updateAccessToken(ByVal token As String)
        conn.Execute("update dmnsd set access_token ='" & token & "' where id ='" & Reg.GetValue("id") & "'")
    End Sub
    Private Sub createGoogleSync()
        If googlesync Is Nothing Then
            Try
                googlesync = New ClsGoogleSync.Calendar(email, authentication_Code, refresh_token)
                If googlesync IsNot Nothing Then
                    AddHandler googlesync.oAuth20.ObtainNewAccessToken, AddressOf updateAccessToken
                    AddHandler googlesync.oAuth20.ObtainNewAuthenticationCode, AddressOf updateAuthentication
                    AddHandler googlesync.oAuth20.ObtainNewRefreshToken, AddressOf updateRefreshToken
                    '
                    googlesync.oAuth20.token = access_token
                    googlesync.oAuth20.getToken()
                    Dim tk As TokenInfo = googlesync.oAuth20.getTokenInfo
                    If tk IsNot Nothing Then
                        If email <> tk.email AndAlso email <> "" Then
                            googlesync = Nothing
                        Else
                            If email = "" Then
                                email = tk.email
                                conn.Execute("update dmnsd set email ='" & email & "' where id ='" & Reg.GetValue("id") & "'")
                            End If
                            googlesync.email = email
                            authentication_Code = googlesync.oAuth20.authentication_code
                            refresh_token = googlesync.oAuth20.refresh_token
                        End If
                    Else
                        googlesync = Nothing
                    End If
                End If
            Catch ex As Exception
                googlesync = Nothing
            End Try
            
        End If
    End Sub
    Private Function sync() As Boolean
        If googlesync Is Nothing Then
            Return False
        End If
        Try
            Dim kq As Boolean = googlesync.sync(conn, Reg.GetValue("id"), last_synced)
            Return kq
        Catch ex As Exception
            googlesync = Nothing
        End Try
        
    End Function
    Private Sub btnGoogleSync_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoogleSync.Click
        If googlesync Is Nothing Then
            createGoogleSync()
        End If
        If sync() Then
            loadEvents(TreeNV.SelectedNode.Tag, Calendar1.CurrentDate)
            MsgBox("Chương trình đã đồng bộ thành công", , Me.Text)
        Else
            MsgBox("Chương trình không thể đồng bộ lịch với Google calendar", , Me.Text)
        End If
    End Sub

    Private Sub list_SaveClick() Handles list.SaveClick
        If ClsControl2.PropertyOfGrid.CheckFieldsBlank(frmin.gridattendee, dtml) Then
            list.ContinueSave = False
        End If
        list.CurrentRow("finish") = list.CurrentRow("start")
        Dim v As String() = frmin.txtfinish_time.Text.ToString.Split(":")
        If v(0) < frmin.txtstart_time.Text.ToLower.Split(":")(0) Then
            frmin.txtfinish_time.Focus()
            list.ContinueSave = False
        End If
    End Sub
End Class
