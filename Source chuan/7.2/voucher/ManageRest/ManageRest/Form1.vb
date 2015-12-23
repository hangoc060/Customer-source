Public Class Form1
   
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        txtuser.Text = Clsql.Reg.GetValue("ID")
        If olan Is Nothing Then
            olan = ClsControl2.PropertyOfForm.SetLable(conn, Me, Clsql.Others.GetArgu(1))
        Else
            ClsControl2.PropertyOfForm.SetLable(olan, Me)
            Me.Icon = mainform.Icon
        End If
        ClsControl2.PropertyOfForm.KeyEnter(Me)
        'load ds khu vuc
        Dim dtkhvuc As DataTable = conn.GetDatatable("select * from res_dmkv where trang_thai=1 and ma_res ='" & ma_res & "' order by stt")
        For Each r As DataRow In dtkhvuc.Rows
            Dim kv As New StpPan.ResItemArea()
            If conn.Lang = Clsql.SQL.Language.Vietnamese Then
                kv.Title = r("ten_kv")
            Else
                kv.Title = r("ten_kv2")
            End If
            kv.Name = r("ma_kv")
            AddHandler kv.ResItemSelected, AddressOf area_click
            PanelArea.Controls.Add(kv)
        Next
        For Each kv As StpPan.ResItemArea In PanelArea.Controls
            kv.Selected()
            Exit For
        Next

    End Sub
    Public Sub area_click(ByVal s As StpPan.ResItemArea)
        kv_ht = s
        'load danh sach ban cua khu vuc
        PanelTable.Controls.Clear()
        Dim dt As DataTable = conn.GetDatatable("select * from res_dmban where trang_thai=1 and ma_kv ='" & s.Name & "'")
        For Each r As DataRow In dt.Rows
            If r("ma_loai_ban") = "L02" Then
                loadTable(r)
            Else
                loadOther(r)
            End If
        Next
    End Sub
    Public Sub loadTable(ByVal r As DataRow)
        Dim tb As New StpPan.ResItemTable
        tb.Name = r("ma_ban")
        tb.Title = r("ten_ban")
        tb.Type = r("ma_loai_ban")
        tb.Location = New Point(r("x"), r("y"))
        tb.Width = r("width")
        tb.Height = r("height")
        tb.AllowDrap = False
        tb.AllowDrop = False
        tb.AllowResize = False
        If IsDBNull(r("stt_rec")) Then
            tb.stt_rec = ""
        Else
            tb.stt_rec = r("stt_rec")
        End If

        tb.AllowOptions = False
        tb.AllowUserDelete = False
        tb.TimeAutoRefresh = 30 * 1000
        tb.BackColor = Color.FromArgb(r("backcolor"))
        tb.ForeColor = Color.FromArgb(r("forecolor"))
        tb.UnSelectColor = Color.FromArgb(r("backcolor"))
        tb.Status = r("status")
        If IsDBNull(r("so_khach")) Then
            tb.so_khach = 0
        Else
            tb.so_khach = r("so_khach")
        End If


        If IsDBNull(r("ma_nv")) Then
            tb.ma_nv_phuc_vu = ""
        Else
            tb.ma_nv_phuc_vu = r("ma_nv")
        End If
        If doiban_yn Then
            AddHandler tb.SelectedEvent, AddressOf doiban
        Else
            AddHandler tb.Refreshing, AddressOf refreshTable
            AddHandler tb.SelectedEvent, AddressOf table_click
        End If
        refreshTable(tb)
        PanelTable.Controls.Add(tb)
    End Sub
    Public doiban_yn As Boolean = False
    Public ban_doi As StpPan.ResItemTable = Nothing
    Public Sub doiban(ByVal tb As StpPan.ResItemTable)
        If tb.Status <> 0 Then
            MsgBox("Bàn này đang có khách hoặc đã được đặt trước", MsgBoxStyle.Critical, Clsql.AboutMe.Name)
            Return
        End If
        ban_doi = tb
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
    Public Sub loadOther(ByVal r As DataRow)
        Dim tb As New StpPan.ResItemOther
        tb.Name = r("ma_ban")
        tb.Title = r("ten_ban")
        tb.Type = r("ma_loai_ban")
        tb.Location = New Point(r("x"), r("y"))
        tb.Width = r("width")
        tb.Height = r("height")
        tb.AllowDrap = False
        tb.AllowResize = False
        tb.AllowOptions = False
        tb.AllowUserDelete = False
        tb.BackColor = Color.FromArgb(r("backcolor"))
        tb.ForeColor = Color.FromArgb(r("forecolor"))
        tb.UnSelectColor = Color.FromArgb(r("backcolor"))

        PanelTable.Controls.Add(tb)
    End Sub


   

   

   
    
    
End Class
