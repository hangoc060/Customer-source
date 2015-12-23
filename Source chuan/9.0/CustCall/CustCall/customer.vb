Imports ClsStpService

Public Class customer
    Dim rowCust As DataRow
    Dim action As Clsql.Actions.Action
    Public id_call As String = 0
    Public row As DataRow
    Public dien_thoai As String
    Private ma_loai_kh_def As String = ""
    Private load_yn As Boolean = False
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        load_yn = True
        btnAddNewCust.Enabled = False
        btnOrder.Enabled = False
        btnordertmp.Enabled = False
        btnGhi_chu.Enabled = False
        'load loai khach hang
        If ds_loaikh IsNot Nothing Then
            cbbma_loai_kh.DataSource = ds_loaikh.Tables(0)
            cbbma_loai_kh.DisplayMember = "ten"
            cbbma_loai_kh.ValueMember = "ma_loai_kh"
        End If
        cbbma_loai_kh.SelectedValue = ma_loai_kh_def


        ClsControl2.PropertyOfForm.KeyEnter(Me)
        txtma_kh.Text = "<customer code>"
        history()
        txtma_kh.Text = ""
    End Sub

    Private Delegate Sub invokedienthoai(dien_thoai As String, id_call As Integer)
    Public Sub setCustomer()
        txtma_kh.Text = rowCust("ma_kh")
        txtten_kh.Text = rowCust("ten_kh")
        txtdia_chi.Text = rowCust("dia_chi")
        txtghi_chu.Text = rowCust("ghi_chu")
        txtdien_thoai.Text = rowCust("dien_thoai")
        txtdien_thoai2.Text = rowCust("dien_thoai2")
        txtdien_thoai3.Text = rowCust("dien_thoai3")
        txtdien_thoai4.Text = rowCust("dien_thoai4")
        txtdien_thoai5.Text = rowCust("dien_thoai5")

        row("ma_kh") = rowCust("ma_kh")
        row("ten_kh") = rowCust("ten_kh")

        If txtdien_thoai.Text = "" OrElse txtdien_thoai.Text = dien_thoai_current.Text Then
            txtdien_thoai.Text = dien_thoai_current.Text
        Else
            If txtdien_thoai2.Text = "" OrElse txtdien_thoai2.Text = dien_thoai_current.Text Then
                txtdien_thoai2.Text = dien_thoai_current.Text
            Else
                If txtdien_thoai3.Text = "" OrElse txtdien_thoai3.Text = dien_thoai_current.Text Then
                    txtdien_thoai3.Text = dien_thoai_current.Text
                Else
                    If txtdien_thoai4.Text = "" OrElse txtdien_thoai4.Text = dien_thoai_current.Text Then
                        txtdien_thoai4.Text = dien_thoai_current.Text
                    Else
                        If txtdien_thoai5.Text = "" OrElse txtdien_thoai5.Text = dien_thoai_current.Text Then
                            txtdien_thoai5.Text = dien_thoai_current.Text
                        End If

                    End If
                End If
            End If
        End If

        cbbma_loai_kh.SelectedValue = rowCust("ma_loai_kh")
        rowCust("nguoi_sua") = Clsql.Reg.GetValue("id")
        rowCust("ngay_sua") = Now
        action = Clsql.Actions.Action.Edit
        btnOrder.Enabled = True
        btnordertmp.Enabled = True
        btnGhi_chu.Enabled = True
        'show history
        Dim threadh As New Threading.Thread(AddressOf history)
        threadh.Start()
    End Sub
    Public Sub getCustomer(dien_thoai As String, id_call As String)
        Me.dien_thoai = dien_thoai
        Me.id_call = id_call
        If Me.InvokeRequired Then
            Dim invoker As New invokedienthoai(AddressOf getCustomer)
            Me.Invoke(invoker, dien_thoai)
            Return
        End If

        DataGridView1.DataSource = Nothing
        dien_thoai_current.Text = dien_thoai
        btnAddNewCust.Enabled = False
        btnOrder.Enabled = False
        btnordertmp.Enabled = False
        btnGhi_chu.Enabled = False
        txtma_kh.Text = dien_thoai
        txtten_kh.Text = ""
        txtdien_thoai.Text = ""
        txtdien_thoai2.Text = ""
        txtdien_thoai3.Text = ""
        txtdien_thoai4.Text = ""
        txtdien_thoai5.Text = ""
        txtdia_chi.Text = ""
        txtghi_chu.Text = ""
        cbbma_loai_kh.SelectedValue = ma_loai_kh_def

        rowCust = Nothing
        If dtCust Is Nothing OrElse dtCust.Rows.Count = 0 Then
            Try
                dtCust = conn.GetDatatable("select top 1 * from dkh with (index(IX_dkh_dien_thoai)) where dien_thoai like '%" & dien_thoai & "' or dien_thoai2 like '%" & dien_thoai & "' or dien_thoai3 like '%" & dien_thoai & "' or dien_thoai4 like '%" & dien_thoai & "' or dien_thoai5 like '%" & dien_thoai & "'")
                If dtCust.Rows.Count > 0 Then
                    rowCust = dtCust.Rows(0)
                End If
            Catch ex As Exception

            End Try


        Else

            Dim r As DataRow() = dtCust.Select("dien_thoai like '%" & dien_thoai & "' or dien_thoai2 like '%" & dien_thoai & "' or dien_thoai3 like '%" & dien_thoai & "' or dien_thoai4 like '%" & dien_thoai & "' or dien_thoai5 like '%" & dien_thoai & "'")
            If r.Length > 0 Then
                rowCust = r(0)
            Else
                Try
                    Dim _dtCust As DataTable = conn.GetDatatable("select top 1 * from dkh with (index(IX_dkh_dien_thoai)) where dien_thoai like '%" & dien_thoai & "' or dien_thoai2 like '%" & dien_thoai & "' or dien_thoai3 like '%" & dien_thoai & "' or dien_thoai4 like '%" & dien_thoai & "' or dien_thoai5 like '%" & dien_thoai & "'")
                    If _dtCust.Rows.Count > 0 Then
                        rowCust = dtCust.NewRow
                        For Each c As DataColumn In dtCust.Columns
                            If (_dtCust.Columns.Contains(c.ColumnName)) Then
                                rowCust(c) = _dtCust.Rows(0)(c.ColumnName)
                            End If
                        Next
                        dtCust.Rows.Add(rowCust)
                    End If
                Catch ex As Exception

                End Try
            End If
        End If

        If rowCust IsNot Nothing Then
            btnselectkh.Enabled = False
            setCustomer()
            action = Clsql.Actions.Action.EDIT
        Else
            txtdien_thoai.Text = dien_thoai_current.Text
            If dtCust IsNot Nothing Then
                btnselectkh.Enabled = True
                rowCust = dtCust.NewRow
                rowCust("dien_thoai") = dien_thoai
                rowCust("dien_thoai2") = txtdien_thoai2.Text
                rowCust("dien_thoai3") = txtdien_thoai3.Text
                rowCust("dien_thoai4") = txtdien_thoai4.Text
                rowCust("dien_thoai5") = txtdien_thoai5.Text

                rowCust("nguoi_tao") = Clsql.Reg.GetValue("id")
                rowCust("ngay_tao") = Now
                rowCust("users_have_right") = Clsql.Reg.GetValue("id")
                rowCust("ma_loai_kh") = ma_loai_kh_def
                rowCust("trang_thai") = True

                action = Clsql.Actions.Action.Add
                btnOrder.Enabled = False
                btnordertmp.Enabled = False
            End If

        End If
        If rowCust IsNot Nothing Then
            btnAddNewCust.Enabled = True
        End If
    End Sub
    Private Delegate Sub invokeHistory()
    Private Sub history()
        If DataGridView1.InvokeRequired Then
            Dim inv As New invokeHistory(AddressOf history)
            DataGridView1.Invoke(inv)
            Return
        End If
        If ma_ct IsNot Nothing Then
            Try
                Dim query As String = "exec history_sale '" + txtma_kh.Text + "','" + ma_ct + "'"
                Dim dt As DataTable = conn.GetDatatable(query)
                If DataGridView1.ColumnCount = 0 Then
                    ClsControl2.PropertyOfGrid.FillGrid(conn, "history_sale", DataGridView1, dt.DefaultView)
                Else
                    DataGridView1.DataSource = dt
                End If

            Catch ex As Exception

            End Try

        End If

    End Sub

    Dim vno As ClsVno.AutoCreateCode
    Dim rights As ClsRight.CheckRight = Nothing
    Private Sub btnAddNewCust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNewCust.Click
        If rowCust Is Nothing Then
            Return
        End If
        If txtten_kh.Text = "" Then
            MsgBox("Tên khách hàng.", MsgBoxStyle.Critical, Clsql.AboutMe.Name)
            Return
        End If
        If rights Is Nothing Then
            Try
                rights = (New ClsList.RightOfList(conn, list_id_permistion, Clsql.Reg.GetValue("id"), Clsql.Reg.GetValue("unit"), Clsql.Others.Options("cmd_table", conn))).getRight()
            Catch ex As Exception
                Return
            End Try

        End If
        If action = Clsql.Actions.Action.Add AndAlso txtma_kh.Text = "" Then
            If (vno Is Nothing) Then
                vno = New ClsVno.AutoCreateCode(conn, list_id)
            End If
            Try
                txtma_kh.Text = vno.GetNextCode("dkh", "ma_kh")
                vno.UpdateCode(txtma_kh.Text)
            Catch ex As Exception
                MsgBox("Không thể tạo khách hàng mới do chương trình không thể kết nối với máy chủ", MsgBoxStyle.Critical, Clsql.AboutMe.Name)
                Return
            End Try
        End If

        'save
        rowCust("ma_kh") = txtma_kh.Text
        rowCust("ten_kh") = txtten_kh.Text
        rowCust("dia_chi") = txtdia_chi.Text
        rowCust("ghi_chu") = txtghi_chu.Text
        rowCust("ma_loai_kh") = cbbma_loai_kh.SelectedValue

        rowCust("dien_thoai") = txtdien_thoai.Text
        rowCust("dien_thoai2") = txtdien_thoai2.Text
        rowCust("dien_thoai3") = txtdien_thoai3.Text
        rowCust("dien_thoai4") = txtdien_thoai4.Text
        rowCust("dien_thoai5") = txtdien_thoai5.Text

        row("ma_kh") = txtma_kh.Text
        row("ten_kh") = txtten_kh.Text

        ''
        Clsql.Data.ClearNullValue(dtCust)
        If action = Clsql.Actions.Action.Add Then
            dtCust.Rows.Add(rowCust)
            Try
                If Not rights.NewRight() Then
                    MsgBox("Bạn không có quyền thêm mới khách hàng", MsgBoxStyle.Critical, Clsql.AboutMe.Name)
                    Return
                End If

                Dim query As String = conn.GetInsertQueryFromDataRow(rowCust, "dkh")
                conn.Execute(query)

            Catch ex As Exception
                'MsgBox("Không thể lưu thông tin khách hàng này", MsgBoxStyle.Critical, Clsql.AboutMe.Name)
                'Return
                'save offline
                saveOffKh()
            End Try

        Else
            rowCust("nguoi_sua") = Clsql.Reg.GetValue("id")
            rowCust("ngay_sua") = Now
            Try
                If Not rights.EditRight() Then
                    MsgBox("Bạn không có quyền cập nhật thông tin khách hàng này", MsgBoxStyle.Critical, Clsql.AboutMe.Name)
                    Return
                End If
                Dim query As String = conn.GetUpdateQueryFromDatarow(rowCust, "dkh")
                conn.Execute(query)
            Catch ex As Exception
                'MsgBox("Không thể lưu thông tin khách hàng này", MsgBoxStyle.Critical, Clsql.AboutMe.Name)
                'Return
                'save offline
                saveOffKh()
            End Try

        End If
        Dim thread As New Threading.Thread(AddressOf savelocal)
        thread.Start()
        MsgBox("Thông tin khách hàng đã được cập nhật", , Clsql.AboutMe.Name)
        ds_history.WriteXml(flog, XmlWriteMode.WriteSchema)
        btnOrder.Enabled = True
        btnordertmp.Enabled = True
        btnGhi_chu.Enabled = True
    End Sub
    Private Sub saveOffKh()
        If Not IO.Directory.Exists(dirKH) Then
            IO.Directory.CreateDirectory(dirKH)
        End If
        Dim file_kh As String = dirKH & "\" & rowCust("ma_kh") & ".xml"
        If IO.File.Exists(file_kh) Then
            IO.File.Delete(file_kh)
        End If
        Dim ds_o As New DataSet
        Dim dt_o As DataTable = rowCust.Table.Clone
        ds_o.Tables.Add(dt_o)
        Dim r_o As DataRow = dt_o.NewRow
        For Each c As DataColumn In dt_o.Columns
            r_o(c) = rowCust(c)
        Next
        dt_o.Rows.Add(r_o)
        ds_o.AcceptChanges()
        ds_o.WriteXml(file_kh, XmlWriteMode.WriteSchema)
    End Sub
    Private Sub savelocal()
        Try
            conn.Execute("exec UpdateCustomer '" & txtma_kh.Text & "'," & IIf(action = Clsql.Actions.Action.Add, "'ADD'", "'EDIT'"))

        Catch ex As Exception

        End Try
        Try

            conn.Execute("exec CreateSyncList 'dmkh','ma_kh=''" & txtma_kh.Text & "'''")
        Catch ex As Exception

        End Try

        Dim file As String = Application.StartupPath + "\AppData\" + Clsql.Reg.GetValue("id") + "\dmkh.xml"
        dtCust.DataSet.WriteXml(file, XmlWriteMode.WriteSchema)
    End Sub
    Private Sub btnOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrder.Click
        If Clsql.Reg.GetValue("SLG") <> 1 Then
            MsgBox("Bạn phải đăng nhập chương trình để sử dụng tính năng này",, Clsql.AboutMe.Name)
            Return
        End If
        Try
            If ct_custcall = Nothing Then
                ct_custcall = Clsql.Others.Options("ct_custcall", conn)
                Dim cs As String() = ct_custcall.Split("#")
                If cs.Length > 1 Then
                    exe = cs(0)
                    ma_ct = cs(1)
                Else
                    exe = "vso1.exe"
                    ma_ct = "SO1"
                End If
            End If
            Dim path As String = Application.StartupPath & "\" & exe
            If IO.File.Exists(path) Then
                Dim args As String = ma_ct & " -ADD ma_kh:" & txtma_kh.Text.Trim & " id_call:" & id_call & " ong_ba:" & txtten_kh.Text.Replace(" ", "%s")
                Dim p As Process = Process.Start(path, args)
                ' Me.Hide()
                ' Me.FindForm.Hide()
            End If
        Catch ex As Exception
            MsgBox("Không thể kết nối với máy chủ",, Clsql.AboutMe.Name)
        End Try

    End Sub

    Private Sub btnGhi_chu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGhi_chu.Click
        Dim path As String = Application.StartupPath & "\Lnotes.exe"
        If IO.File.Exists(path) Then
            Dim args As String = "NOTES <!add> ma_kh:" & txtma_kh.Text
            Dim p As Process = Process.Start(path, args)
            ' p.WaitForExit()
        End If


    End Sub

    Private Sub btnselectkh_Click(sender As Object, e As EventArgs) Handles btnselectkh.Click
        Dim f As New frmlistkh
        f.Icon = Me.FindForm.Icon
        If f.ShowDialog(Me) = DialogResult.OK Then
            For Each c As DataColumn In f.row_selected.Table.Columns
                If dtCust.Columns.Contains(c.ColumnName) Then
                    rowCust(c.ColumnName) = f.row_selected(c.ColumnName)
                End If
            Next
            setCustomer()
        End If
    End Sub

    Private Sub btnsp_Click(sender As Object, e As EventArgs)
        Dim f As New frmselector
        f.ShowDialog()
    End Sub
    Dim f As frmordertmp
    Private Sub btnordertmp_Click(sender As Object, e As EventArgs) Handles btnordertmp.Click
        If txtma_kh.Text <> "" AndAlso txtten_kh.Text <> "" Then
            If f Is Nothing OrElse f.IsDisposed Then
                f = New frmordertmp
                f.id_call_tmp = id_call
                f.rowCust = rowCust
                f.txtma_kh.Text = txtma_kh.Text
                f.lblten_kh.Text = txtten_kh.Text
                f.dia_chi = txtdia_chi.Text
                f.dien_thoai = dien_thoai_current.Text
                f.Icon = Me.FindForm.Icon
                f.StartPosition = FormStartPosition.CenterScreen
                f.add()
            End If
            f.Activate()
        End If

    End Sub
End Class
