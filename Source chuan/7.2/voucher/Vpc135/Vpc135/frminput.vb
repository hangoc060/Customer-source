Public Class frminput

    Dim isloaded As Boolean = False
    Dim t_thue, t_thue_nt, t_tien, t_tien_nt As Double
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
        RemoveHandler Voucher.Tabdetails("vtdttco").gridDetailKeyin.CellBeginEdit, AddressOf grddetailhd_CellBeginEdit
        RemoveHandler Voucher.Tabdetails("vvatvao").gridDetailKeyin.CellEndEdit, AddressOf grdvat_CellEndEdit
    End Sub

    Private Sub frminput_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        For Each dvtab As ClsSV31.TabDetail20 In Voucher.Tabdetails.Values
            AddHandler dvtab.AfterCalcOnCell, AddressOf tinh_tong_tien
        Next

        AddHandler Voucher.Tabdetails("vtdttco").gridDetailKeyin.CellBeginEdit, AddressOf grddetailhd_CellBeginEdit
        AddHandler Voucher.Tabdetails("vvatvao").gridDetailKeyin.CellEndEdit, AddressOf grdvat_CellEndEdit
    End Sub
    Private Sub frminput_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Dim dvr As DataRowView = cbbma_nt.SelectedItem

        hide_show_control(dvr("ma_nt"))
        isloaded = True
        If Voucher.Action = ClsSV31.Voucher20.Actions.ADD Then
            Txtty_gia.Value = conn.GetValue("exec getty_gia " & conn.ConvertToSQLType(cbbma_nt.SelectedValue.trim) & "," & conn.ConvertToSQLType(Txtngay_ct.Value))     'dvr("ty_gia")
        End If
        '
        If isloaded Then
            Try
                If cbbma_gd.SelectedValue = 1 Then

                    Voucher.Tabdetails("vtdttco").status = True
                    Voucher.Tabdetails("vdpc1").status = False
                    Voucher.Tabdetails("vvatvao").status = False


                    btngethoadon.Visible = True
                Else
                    Voucher.Tabdetails("vtdttco").status = False
                    Voucher.Tabdetails("vdpc1").status = True
                    Voucher.Tabdetails("vvatvao").status = True
                    btngethoadon.Visible = False
                End If
                Voucher.CreateFormKeyIn(True)
                hide_show_control(cbbma_nt.SelectedValue)
            Catch ex As Exception

            End Try
        End If
    End Sub
#Region "lay ty gia tu dong"
    Dim ngay_ctold As Date
    Private Sub Txtngay_ct_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtngay_ct.Validated
        If ngay_ctold <> Txtngay_ct.Value Then
            If isloaded Then
                If Voucher.Action = ClsSV31.Voucher20.Actions.ADD Then
                    Txtty_gia.Value = conn.GetValue("exec getty_gia " & conn.ConvertToSQLType(cbbma_nt.SelectedValue.trim) & "," & conn.ConvertToSQLType(Txtngay_ct.Value))     'dvr("ty_gia")
                End If
            End If
        End If
    End Sub
    Private Sub Txtngay_ct_endter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtngay_ct.Enter
        ngay_ctold = Txtngay_ct.Value
    End Sub
#End Region





    Private Sub grddetailhd_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs)
        Voucher.Tabdetails("vtdttco").gridDetailKeyin.Item("stt_rec", e.RowIndex).Value = Voucher.Stt_rec
        Voucher.Tabdetails("vtdttco").gridDetailKeyin.Item("ma_ct", e.RowIndex).Value = Voucherid
        Voucher.Tabdetails("vtdttco").gridDetailKeyin.Item("loai_tt", e.RowIndex).Value = 1

    End Sub


    Private Sub grdvat_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs)


    End Sub
    Private Sub grdvat_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

        Dim ty_gia As Double = Txtty_gia.Value
        If sender.Rows(e.RowIndex).IsNewRow = False Then
            Select Case sender.Columns(e.ColumnIndex).Name
                Case "so_seri"
                    sender.Item("so_seri", e.RowIndex).Value = sender.Item("so_seri", e.RowIndex).Value.ToString.ToUpper
                Case "so_hd"
                    sender.Item("so_hd", e.RowIndex).Value = sender.Item("so_hd", e.RowIndex).Value.ToString.ToUpper


                    Dim tien As Double = 0
                    Dim tien_nt As Double = 0

                    For Each r As DataGridViewRow In Voucher.Tabdetails("vdpc1").gridDetailKeyin.Rows
                        If Not r.IsNewRow Then
                            If r.Cells("so_hd").Value.ToString.Trim.ToLower = sender.Item("so_hd", e.RowIndex).Value.ToString.Trim.ToLower Then
                                tien = tien + r.Cells("tien").Value
                                tien_nt = tien_nt + r.Cells("tien_nt").Value
                                sender.Item("t_tien", e.RowIndex).Value = tien
                                sender.Item("t_tien_nt", e.RowIndex).Value = tien_nt
                                sender.Item("t_thue_nt", e.RowIndex).Value = tien_nt * sender.Item("thue_suat", e.RowIndex).Value / 100
                                sender.Item("t_thue", e.RowIndex).Value = tien * sender.Item("thue_suat", e.RowIndex).Value / 100
                                sender.Item("ngay_hd", e.RowIndex).Value = Txtngay_ct.Value
                                sender.Item("tk_du", e.RowIndex).Value = r.Cells("tk_co").Value
                                sender.Item("ty_gia_gs_co", e.RowIndex).Value = r.Cells("ty_gia_gs_co").Value
                            End If
                        End If
                    Next
                    tien = Nothing
                    tien_nt = Nothing

                    tinh_tong_tien()

            End Select
        End If
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
            Case ClsSV31.frmTask.Tasks.Copy
                Voucher.Copy()
            Case ClsSV31.frmTask.Tasks.Print
                For Each r As DataRow In Voucher.Mdatatable.Select("sel=true")
                    r("sel") = False
                Next
                Voucher.BindingSource.Current("sel") = True
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
        Voucher.BindingSource.EndEdit()

        For Each r As DataRow In Voucher.Tabdetails("vtdttco").Datatable.Select("tien_nt =0")
            r.Delete()
        Next

        'kiem tra cap nhat
        If Voucher.CheckKeyIn() = False Then
            Return False
        End If

        'dien cac gia tri cu m vao d
        Dim sqltattoan As String = ""
        Voucher.SynMD()
        querytt = getQuerytattoan()
        If Voucher.Action = 1 Then

            Voucher.Insert()
        Else
            Voucher.Update()
        End If
        'post detail trong truong hop thanh toan theo hoa don
        If Voucher.Tabdetails("vdpc1").status = False Then
            sqltattoan = conn.GetInsertQueryFromDatatable(Voucher.Tabdetails("vtdttco").Datatable, Voucher.Tabdetails("vdpc1").TableName)
            conn.Execute(sqltattoan)

            'Clsql.Data.CopyTable(Voucher.Tabdetails("vtdttco").Datatable, Voucher.Tabdetails("vdpc1").DatatableView, "1=1", "stt_rec='" & Voucher.Stt_rec & "'")
            Dim tbdetail As DataTable = conn.GetDatatable("select * from vdpc1 where stt_rec ='" & Voucher.Stt_rec & "'")
            Clsql.Data.CopyTable(tbdetail, Voucher.Tabdetails("vdpc1").DatatableView, "1=1", "stt_rec='" & Voucher.Stt_rec & "'")
            tbdetail.Dispose()
        End If
        'post
        ClsSV31.Functions.Post(conn, Voucherid, Voucher.Mviewname, Voucher.Stt_rec, cbbstatus.SelectedValue)
        Voucher.refreshMaster()
        Return True
    End Function
    Sub tinh_tong_tien()
        If isloaded = False Then
            Return
        End If
        t_thue = ClsControl2.PropertyOfGrid.Sum(Voucher.Tabdetails("vvatvao").gridDetailKeyin, "t_thue")
        t_thue_nt = ClsControl2.PropertyOfGrid.Sum(Voucher.Tabdetails("vvatvao").gridDetailKeyin, "t_thue_nt")


        txtt_thue_nt.Value = t_thue_nt
        txtt_thue.Value = t_thue
        If cbbma_gd.SelectedValue = 1 Then
            t_tien = ClsControl2.PropertyOfGrid.Sum(Voucher.Tabdetails("vtdttco").gridDetailKeyin, "tien")

            t_tien_nt = ClsControl2.PropertyOfGrid.Sum(Voucher.Tabdetails("vtdttco").gridDetailKeyin, "tien_nt")


        Else
            t_tien = ClsControl2.PropertyOfGrid.Sum(Voucher.Tabdetails("vdpc1").gridDetailKeyin, "tien")
            t_tien_nt = ClsControl2.PropertyOfGrid.Sum(Voucher.Tabdetails("vdpc1").gridDetailKeyin, "tien_nt")

        End If

        Txtt_tien_nt.Value = t_tien_nt
        Txtt_tien.Value = t_tien

        txtt_tt_nt.Value = t_thue_nt + t_tien_nt
        txtt_tt.Value = t_thue + t_tien

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
        If isloaded Then
            Try
                If cbbma_gd.SelectedValue = 1 Then

                    Voucher.Tabdetails("vtdttco").status = True
                    Voucher.Tabdetails("vdpc1").status = False
                    Voucher.Tabdetails("vvatvao").status = False


                    btngethoadon.Visible = True
                Else
                    Voucher.Tabdetails("vtdttco").status = False
                    Voucher.Tabdetails("vdpc1").status = True
                    Voucher.Tabdetails("vvatvao").status = True
                    btngethoadon.Visible = False
                End If
                Voucher.CreateFormKeyIn(True)
                hide_show_control(cbbma_nt.SelectedValue)
            Catch ex As Exception

            End Try
        End If
        
    End Sub

    Dim ma_khold As String
    Private Sub txtma_kh_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtma_kh.Enter, cbbma_gd.Enter
        ma_khold = txtma_kh.Text.Trim
        cbbma_gd.Enabled = True
        txtma_kh.ReadOnly = False
        If Voucher.Tabdetails("vtdttco").status = True Then
            For Each r As DataGridViewRow In Voucher.Tabdetails("vtdttco").gridDetailKeyin.Rows
                If Not r.IsNewRow Then
                    If r.Cells("stt_rec_tt").Value <> "" Then
                        txtma_kh.ReadOnly = True
                        cbbma_gd.Enabled = False
                        Exit For
                    End If
                End If
            Next
        End If

    End Sub

    Private Sub txtma_kh_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtma_kh.Validated
        If ma_khold.ToUpper <> txtma_kh.Text.Trim.ToUpper Then
            ma_khold = txtma_kh.Text
            If cbbma_gd.SelectedValue = 1 Then
                'Tabdetailhd.Datatable = conn.GetDatatable("Exec GetInvoice4Paid " & conn.ConvertToSQLType(txtma_kh.Text) & "," & conn.ConvertToSQLType(Txtngay_ct.Value) & "," & Voucher.Action)
                '   Tabdetailhd.bindingsource.DataSource = Tabdetailhd.Datatable
                '  Txtt_tien_nt.Value = ClsControl2.PropertyOfGrid.Sum(grddetailhd, "tien_nt")
                ' Txtt_tien.Value = ClsControl2.PropertyOfGrid.Sum(grddetailhd, "tien")
                'txtt_tt.Value = Txtt_tien.Value
                'txtt_tt_nt.Value = Txtt_tien_nt.Value
            End If
        End If

    End Sub

    Sub hide_show_control(ByVal ma_nt As String)

        Ltienthue.Visible = True
        Ltongthanhtoan.Visible = True
        txtt_thue.Visible = True
        txtt_thue_nt.Visible = True
        txtt_tt_nt.Visible = True
        txtt_tt.Visible = True
        For Each t As ClsSV31.TabDetail20 In Voucher.Tabdetails.Values
            t.ma_nt = ma_nt
        Next
        If ma_nt.Trim.ToUpper = dtht.Trim.ToUpper Then
            Voucher.Tabdetails("vdpc1").gridDetailKeyin.Columns("ty_gia_gs_co").Visible = False
            Voucher.Tabdetails("vdpc1").gridDetailKeyin.Columns("ty_gia_gs_no").Visible = False
            Txtty_gia.ReadOnly = True
            Txtt_tien.Visible = False
            txtt_thue.Visible = False
            txtt_tt.Visible = False
            chbtg_gs_dd_yn.Hide()
            '
            Txtt_tien_nt.NumberDecimalDigits = Clsql.Others.Options("f_tien", conn)
            txtt_thue_nt.NumberDecimalDigits = Clsql.Others.Options("f_tien", conn)
            txtt_tt_nt.NumberDecimalDigits = Clsql.Others.Options("f_tien", conn)
        Else
            Voucher.Tabdetails("vdpc1").gridDetailKeyin.Columns("ty_gia_gs_co").Visible = True
            Voucher.Tabdetails("vdpc1").gridDetailKeyin.Columns("ty_gia_gs_no").Visible = True
            Txtty_gia.ReadOnly = False
            Txtt_tien.Visible = True
            txtt_thue.Visible = True
            txtt_tt.Visible = True
            chbtg_gs_dd_yn.Show()
            '
            Txtt_tien_nt.NumberDecimalDigits = Clsql.Others.Options("f_tien_nt", conn)
            txtt_thue_nt.NumberDecimalDigits = Clsql.Others.Options("f_tien_nt", conn)
            txtt_tt_nt.NumberDecimalDigits = Clsql.Others.Options("f_tien_nt", conn)
            tinh_tong_tien()
        End If

        If cbbma_gd.SelectedValue = 1 Then
            Ltienthue.Visible = False
            Ltongthanhtoan.Visible = False
            txtt_thue.Visible = False
            txtt_thue_nt.Visible = False
            txtt_tt_nt.Visible = False
            txtt_tt.Visible = False
        End If
    End Sub

    Private Sub lay_hoa_don_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngethoadon.Click
        If layhd.Show("Exec GetInvoice4Paid " & conn.ConvertToSQLType(txtma_kh.Text) & "," & conn.ConvertToSQLType(Txtngay_ct.Value) & "," & Voucher.Action & ",'" & Voucher.Stt_rec & "'") = Windows.Forms.DialogResult.OK Then
            'If Voucher.Action = ClsSV31.Voucher.Actions.EDIT Then
            '    querytt = ""
            '    Dim dt As DataTable = conn.GetDatatable("select stt_rec_tt,ma_ct_tt from vtdttco where stt_rec ='" & Voucher.Stt_rec & "'")
            '    For Each r As DataRow In dt.Rows
            '        querytt = querytt & Chr(13) & "EXEC Tatoanco '" & r("stt_rec_tt") & "','" & r("ma_ct_tt") & "'"
            '    Next
            'End If


            Voucher.Tabdetails("vtdttco").Datatable.Clear()
            For Each r As DataRow In layhd.DataView.Table.Select("sel = false")
                r.Delete()
            Next
            Voucher.Tabdetails("vtdttco").Datatable = layhd.DataView.Table
            Voucher.Tabdetails("vtdttco").bindingsource.DataSource = Voucher.Tabdetails("vtdttco").Datatable
            'If layhd.DataView.Table.Select("sel = true").Count > 0 Then
            '    txtma_kh.ReadOnly = True
            '    cbbma_gd.Enabled = False
            'Else
            '    txtma_kh.ReadOnly = False
            '    cbbma_gd.Enabled = True
            'End If
        End If
        SendKeys.Send("{tab}")
    End Sub




    Private Sub chbtg_gs_dd_yn_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chbtg_gs_dd_yn.CheckedChanged
        'grddetail.Columns("ty_gia_gs_co").Visible = chbtg_gs_dd_yn.Checked
        'grddetailhd.Columns("ty_gia_gs_co").Visible = chbtg_gs_dd_yn.Checked
        'grdvat.Columns("ty_gia_gs_co").Visible = chbtg_gs_dd_yn.Checked


    End Sub


End Class