Imports ClsLookup

Public Class frminput

    Dim isloaded As Boolean = False
    Dim t_tien, t_tien_nt As Double

    Private Sub frminput_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If isloaded = False Then
            Me.txtso_ct.Focus()
            Me.txtso_ct.SelectionStart = txtso_ct.Text.Length
            txtma_kh.ReadOnly = False
            cbbma_gd.Enabled = True
        End If
    End Sub
    Private Sub frminput_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        isloaded = False
        For Each dvtab As ClsSV31.TabDetail20 In Voucher.Tabdetails.Values
            RemoveHandler dvtab.AfterCalcOnCell, AddressOf tinh_tong_tien
        Next
        RemoveHandler Voucher.Tabdetails("tdttno").gridDetailKeyin.CellBeginEdit, AddressOf grddetailhd_CellBeginEdit

    End Sub

    Private Sub frminput_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        For Each dvtab As ClsSV31.TabDetail20 In Voucher.Tabdetails.Values
            AddHandler dvtab.AfterCalcOnCell, AddressOf tinh_tong_tien
        Next

        AddHandler Voucher.Tabdetails("tdttno").gridDetailKeyin.CellBeginEdit, AddressOf grddetailhd_CellBeginEdit

    End Sub
    Private Sub frminput_show(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Dim dvr As DataRowView = cbbma_nt.SelectedItem

        hide_show_control(dvr("ma_nt"))
        isloaded = True
        If Voucher.Action = ClsSV31.Voucher20.Actions.ADD Then
            Txtty_gia.Value = conn.GetValue("exec getty_gia " & conn.ConvertToSQLType(cbbma_nt.SelectedValue.trim) & "," & conn.ConvertToSQLType(Txtngay_ct.Value))
        End If

        If cbbma_gd.SelectedValue = 1 Then
            Voucher.Tabdetails("vdpt1").status = False

            Voucher.Tabdetails("tdttno").status = True

            btngethoadon.Visible = True

        Else
            Voucher.Tabdetails("vdpt1").status = True

            Voucher.Tabdetails("tdttno").status = False
            btngethoadon.Visible = False

        End If
        Voucher.CreateFormKeyIn(True)

    End Sub
#Region "lay ty gia tu dong"
    Dim ngay_ctold As Date
    Private Sub Txtngay_ct_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtngay_ct.Validated
        If ngay_ctold <> Txtngay_ct.Value Then
            If isloaded Then
                If Voucher.Action = ClsSV31.Voucher20.Actions.ADD Then
                    Txtty_gia.Value = conn.GetValue("exec getty_gia " & conn.ConvertToSQLType(cbbma_nt.SelectedValue.trim) & "," & conn.ConvertToSQLType(Txtngay_ct.Value))
                End If
            End If
        End If
    End Sub
    Private Sub Txtngay_ct_endter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtngay_ct.Enter
        ngay_ctold = Txtngay_ct.Value
    End Sub
#End Region



    Private Sub grddetailhd_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs)
        Voucher.Tabdetails("tdttno").gridDetailKeyin.Item("stt_rec", e.RowIndex).Value = Voucher.Stt_rec
        Voucher.Tabdetails("tdttno").gridDetailKeyin.Item("ma_ct", e.RowIndex).Value = Voucherid
        Voucher.Tabdetails("tdttno").gridDetailKeyin.Item("loai_tt", e.RowIndex).Value = 1

    End Sub

    Private Sub btnLuu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLuu.Click
        If save() = False Then
            Exit Sub
        End If
        If cbbma_gd.SelectedValue = 1 Then
            formtask.btncopy.Enabled = False
        Else
            formtask.btncopy.Enabled = True
        End If
        formtask.btnnew.Enabled = Voucher.rights.NewRight
        If formtask.btncopy.Enabled = True Then
            formtask.btncopy.Enabled = Voucher.rights.NewRight
        End If
        formtask.btnprint.Enabled = Voucher.rights.PrintRight
        formtask.ShowDialog(Me)
        Select Case formtask.task
            Case ClsSV31.frmTask.Tasks.AddNew
                Me.BindingContext(Voucher.BindingSource).EndCurrentEdit()
                Voucher.Mdatatable.AcceptChanges()
                Voucher.News2()
                cbbma_gd.Enabled = True
                txtma_kh.Enabled = True
            Case ClsSV31.frmTask.Tasks.Copy

                Voucher.Copy()
            Case ClsSV31.frmTask.Tasks.Print
                For Each r As DataRow In Voucher.Mdatatable.Select("sel=true")
                    r("sel") = False
                Next
                Voucher.BindingSource.Current("sel") = True
                'printF()
                oPrint.Print()
                Me.Close()
            Case ClsSV31.frmTask.Tasks.Close
                Me.DialogResult = DialogResult.OK
                Me.Close()
        End Select
    End Sub
    Function save() As Boolean
        'kiem tra so chung tu
        If Voucher.CheckSoCT(Txtngay_ct.Value, txtso_ct.Text) = False Then
            Return False
            Exit Function
        End If

        'ket thuc nhap lieu
        Voucher.BindingSource.EndEdit()

        'xoa cac hoa don khong thanh toan
        For Each r As DataRow In Voucher.Tabdetails("tdttno").Datatable.Select("tien_nt =0")
            r.Delete()
        Next

        'kiem tra da nhap chi tiet chua
        If Voucher.CheckKeyIn = False Then
            Return False
        End If
        'dien cac gia tri cu m vao d
        Voucher.SynMD()
        '
        For Each detail As ClsSV31.TabDetail20 In Voucher.Tabdetails.Values
            detail.bindingsource.DataSource = Nothing
            For Each r As DataRow In detail.Datatable.Rows
                If cbbma_gd.SelectedValue <> 1 Then
                    If detail.Datatable.Columns.Contains("ty_gia_gs_co") Then
                        If chbtg_gs_dd_yn.Checked = False Then
                            If r("loai_cl_co") = 1 Then
                                r("ty_gia_gs_co") = 0
                            End If
                        End If
                    End If
                End If
            Next
            detail.bindingsource.DataSource = detail.Datatable
        Next
        '
        querytt = getQuerytattoan()
        If Voucher.Action = ClsSV31.Voucher20.Actions.ADD Then
            Voucher.Insert()
        Else
            Voucher.Update()
        End If

        'post detail trong truong hop thanh toan theo hoa don
        Dim sqltattoan As String = ""
        If Voucher.Tabdetails("vdpt1").status = False Then
            sqltattoan = conn.GetInsertQueryFromDatatable(Voucher.Tabdetails("tdttno").Datatable, Voucher.Tabdetails("vdpt1").TableName)
            conn.Execute(sqltattoan)
            Dim tbdetail As DataTable = conn.GetDatatable("select * from vdpt1 where stt_rec ='" & Voucher.Stt_rec & "'")
            '  Clsql.Data.CopyTable(Voucher.Tabdetails("tdttno").Datatable, Voucher.Tabdetails("vdpt1").DatatableView, "1=1", "stt_rec='" & Voucher.Stt_rec & "'")
            Clsql.Data.CopyTable(tbdetail, Voucher.Tabdetails("vdpt1").DatatableView, "1=1", "stt_rec='" & Voucher.Stt_rec & "'")
            tbdetail.Dispose()
        End If
        'post
        ClsSV31.Functions.Post(conn, Voucherid, Voucher.Mviewname, Voucher.Stt_rec, cbbstatus.SelectedValue)
        '
        Voucher.refreshMaster()
        Return True
    End Function
    Sub tinh_tong_tien()
        If isloaded = False Then
            Return
        End If
        If Voucher.Tabdetails("vdpt1").status Then
            t_tien_nt = ClsControl2.PropertyOfGrid.Sum(Voucher.Tabdetails("vdpt1").gridDetailKeyin, "tien_nt")
            t_tien = ClsControl2.PropertyOfGrid.Sum(Voucher.Tabdetails("vdpt1").gridDetailKeyin, "tien")

        Else
            t_tien = ClsControl2.PropertyOfGrid.Sum(Voucher.Tabdetails("tdttno").gridDetailKeyin, "tien")
            t_tien_nt = ClsControl2.PropertyOfGrid.Sum(Voucher.Tabdetails("tdttno").gridDetailKeyin, "tien_nt")
        End If

        Txtt_tien_nt.Value = t_tien_nt
        Txtt_tien.Value = t_tien
    End Sub

    Private Sub btnluuandmoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnluuandmoi.Click
        If save() = False Then
            Exit Sub
        End If
        Me.BindingContext(Voucher.BindingSource).EndCurrentEdit()
        Voucher.Mdatatable.AcceptChanges()
        Voucher.News2()
        Txtty_gia.Value = conn.GetValue("exec getty_gia " & conn.ConvertToSQLType(cbbma_nt.SelectedValue.trim) & "," & conn.ConvertToSQLType(Txtngay_ct.Value))
        txtso_ct.Focus()
    End Sub

    Private Sub btnhuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhuy.Click
        'If Voucher.Action = 1 Then
        '    Voucher.Mdatatable.Rows.Remove(Voucher.CurrentVoucher)


        'End If
        isloaded = False
    End Sub


    Private Sub cbbma_nt_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbbma_nt.SelectedValueChanged
        If isloaded = False Then
            Exit Sub
        End If
        Try
            TabControl1.SelectedTab = TabControl1.TabPages(0)
            If cbbma_nt.SelectedItem IsNot Nothing Then
                Dim dvr As DataRowView = cbbma_nt.SelectedItem

                Txtty_gia.Value = conn.GetValue("exec getty_gia " & conn.ConvertToSQLType(cbbma_nt.SelectedValue.trim) & "," & conn.ConvertToSQLType(Txtngay_ct.Value))
                hide_show_control(dvr("ma_nt"))
            End If

        Catch ex As Exception

        End Try
    End Sub



    Private Sub cbbma_gd_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbbma_gd.SelectedValueChanged

        Try

            If isloaded Then
                If cbbma_gd.SelectedValue = 1 Then
                    Voucher.Tabdetails("vdpt1").status = False

                    Voucher.Tabdetails("tdttno").status = True

                    btngethoadon.Visible = True
                    TSDropDownGetdata.Visible = False

                Else
                    Voucher.Tabdetails("vdpt1").status = True

                    Voucher.Tabdetails("tdttno").status = False
                    btngethoadon.Visible = False
                    TSDropDownGetdata.Visible = True

                End If
                Voucher.CreateFormKeyIn(True)
            End If

        Catch ex As Exception

        End Try

    End Sub
    'Dim ma_khold As String
    'Private Sub txtma_kh_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtma_kh.Enter, cbbma_gd.Enter
    '    ma_khold = txtma_kh.Text.Trim
    '    cbbma_gd.Enabled = True
    '    txtma_kh.ReadOnly = False
    '    For Each r As DataGridViewRow In Voucher.Tabdetails("tdttno").gridDetailKeyin.Rows
    '        If Not r.IsNewRow Then
    '            If r.Cells("stt_rec_tt").Value <> "" Then
    '                txtma_kh.ReadOnly = True
    '                cbbma_gd.Enabled = False
    '                Exit For
    '            End If
    '        End If
    '    Next

    'End Sub

    'Private Sub txtma_kh_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtma_kh.Validated
    '    If ma_khold.ToUpper <> txtma_kh.Text.Trim.ToUpper Then
    '        ma_khold = txtma_kh.Text
    '    End If

    'End Sub

    Sub hide_show_control(ByVal ma_nt As String)
        For Each t As ClsSV31.TabDetail20 In Voucher.Tabdetails.Values
            t.ma_nt = ma_nt
        Next
        If ma_nt.Trim.ToUpper = Clsql.Others.Options("a_dtht", conn) Then

            Voucher.Tabdetails("vdpt1").gridDetailKeyin.Columns("ty_gia_gs_co").Visible = False

            Txtty_gia.ReadOnly = True
            Txtt_tien.Hide() 'Visible = False
            Ltien.Hide() 'Visible = False
            chbtg_gs_dd_yn.Hide()

            Txtt_tien_nt.NumberDecimalDigits = Clsql.Others.Options("f_tien", conn)

        Else

            Voucher.Tabdetails("vdpt1").gridDetailKeyin.Columns("ty_gia_gs_co").Visible = True
            Txtty_gia.ReadOnly = False
            Txtt_tien.Show() 'Visible = True
            Ltien.Show() 'Visible = True
            chbtg_gs_dd_yn.Show()

            Txtt_tien_nt.NumberDecimalDigits = Clsql.Others.Options("f_tien_nt", conn)
            tinh_tong_tien()
        End If
    End Sub

    Private Sub btngethoadon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngethoadon.Click
        If layhd.Show("Exec GetInvoice4Rec " & conn.ConvertToSQLType(txtma_kh.Text) & "," & conn.ConvertToSQLType(Txtngay_ct.Value) & "," & Voucher.Action & ",'" & Voucher.Stt_rec & "'") = Windows.Forms.DialogResult.OK Then

            Voucher.Tabdetails("tdttno").bindingsource.DataSource = Nothing
            Voucher.Tabdetails("tdttno").Datatable.Clear()

            'For Each r As DataRow In layhd.DataView.Table.Select("sel = false")
            '    r.Delete()
            'Next
            Clsql.Data.CopyTableSame(layhd.DataView.Table, Voucher.Tabdetails("tdttno").Datatable, "sel=true")
            'Voucher.Tabdetails("tdttno").Datatable = layhd.DataView.Table
            Voucher.Tabdetails("tdttno").bindingsource.DataSource = Voucher.Tabdetails("tdttno").Datatable

            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub laydulieutuhoadonToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngetdatafromhd.Click


        Dim layhd As GetDataByStoreMD
        layhd = New GetDataByStoreMD(Voucher.conn, "MHD2_BL", "dpt1", , "xhd")
        Dim fdkloc As New frmdklayhd
        ClsControl2.PropertyOfForm.SetLable(Voucher.oLan, fdkloc)
        fdkloc.Icon = Me.Icon
        fdkloc.StartPosition = FormStartPosition.CenterParent
        If fdkloc.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            If layhd.Show("Exec GetXHD4PT1 " & conn.ConvertToSQLType(fdkloc.Txttu_ngay.Value) & "," & conn.ConvertToSQLType(fdkloc.TxtDen_ngay.Value) & "," & conn.ConvertToSQLType(txtma_kh.Text) & "," & conn.ConvertToSQLType(Voucher.Stt_rec) & "," & conn.ConvertToSQLType(fdkloc.txtso_hd.Text)) = Windows.Forms.DialogResult.OK Then
                'For Each r As DataRow In layhd.MDataView.Table.Select("sel = false")
                '    For Each r2 As DataRow In layhd.DDataView.Table.Select("stt_rec = '" & r("stt_rec") & "'")
                '        r2.Delete()
                '    Next

                'Next

                'For Each r As DataRow In layhd.DDataView.Table.Select("sel = false")
                '    r.Delete()
                'Next



                Voucher.Tabdetails(Voucher.TabFirst).bindingsource.DataSource = Nothing

                Clsql.Data.CopyTable(layhd.DDataView.Table, Voucher.Tabdetails(Voucher.TabFirst).Datatable, "sel=true")

                Voucher.Tabdetails(Voucher.TabFirst).bindingsource.DataSource = Voucher.Tabdetails(Voucher.TabFirst).Datatable
                'lay cac gia tri phan thong tin chung
                For Each r As DataRow In layhd.MDataView.Table.Select("sel = true")
                    Voucher.CurrentVoucher("ma_kh") = r("ma_kh")
                    Voucher.CurrentVoucher("ong_ba") = r("ong_ba")

                    txtma_kh.Focus()
                    Voucher.Tabdetails(Voucher.TabFirst).gridDetailKeyin.Focus()
                    Exit For
                Next
                tinh_tong_tien()


            End If
        End If
    End Sub
End Class