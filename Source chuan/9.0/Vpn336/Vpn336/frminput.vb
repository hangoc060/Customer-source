Imports ClsLookup

Public Class frminput

    Dim isloaded As Boolean = False

    Private Sub frminput_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If isloaded = False Then
            Me.txtso_ct.Focus()
            Me.txtso_ct.SelectionStart = txtso_ct.Text.Length
        End If
    End Sub

    Private Sub frminput_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        isloaded = False
        For Each dvtab As ClsSV31.TabDetail20 In Voucher.Tabdetails.Values
            RemoveHandler dvtab.AfterCalcOnCell, AddressOf tinh_tong_tien
        Next
        RemoveHandler Voucher.Tabdetails("vvatvao").gridDetailKeyin.CellEndEdit, AddressOf grdvat_CellEndEdit
        RemoveHandler Voucher.Tabdetails("vvatvao").gridDetailKeyin.CellBeginEdit, AddressOf grdvat_CellBeginEdit

    End Sub

    Private Sub frminput_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        For Each dvtab As ClsSV31.TabDetail20 In Voucher.Tabdetails.Values
            AddHandler dvtab.AfterCalcOnCell, AddressOf tinh_tong_tien
        Next
        AddHandler Voucher.Tabdetails("vvatvao").gridDetailKeyin.CellEndEdit, AddressOf grdvat_CellEndEdit

        AddHandler Voucher.Tabdetails("vvatvao").gridDetailKeyin.CellBeginEdit, AddressOf grdvat_CellBeginEdit

    End Sub

    Private Sub frminput_show(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Dim dvr As DataRowView = cbbma_nt.SelectedItem

        hide_show_control(dvr("ma_nt"))
        isloaded = True
        If Voucher.Action = ClsSV31.Voucher20.Actions.ADD Then
            Txtty_gia.Value = conn.GetValue("exec getty_gia " & conn.ConvertToSQLType(cbbma_nt.SelectedValue.trim) & "," & conn.ConvertToSQLType(Txtngay_ct.Value))
            Voucher.BindingSource.EndEdit()
        End If
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
    
    Private Sub grdvat_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs)
        If String.IsNullOrEmpty(Voucher.Tabdetails("vvatvao").gridDetailKeyin.Item("tk_du", e.RowIndex).Value.ToString) Then
            Try
                Voucher.Tabdetails("vvatvao").gridDetailKeyin.Item("tk_du", e.RowIndex).Value = Voucher.Tabdetails(Voucher.TabFirst).gridDetailKeyin.Item("tk_du", 0).Value
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub grdvat_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

        Dim ty_gia As Double = Txtty_gia.Value
        If sender.Rows(e.RowIndex).IsNewRow = False Then
            Select Case sender.Columns(e.ColumnIndex).Name
                Case "so_seri"
                    sender.Item("so_seri", e.RowIndex).Value = sender.Item("so_seri", e.RowIndex).Value.ToString.ToUpper

                Case "so_hd"
                    Dim t_tien As Double = 0
                    Dim t_tien_nt As Double = 0
                    Dim ten_vt As String = ""
                    For Each r As DataGridViewRow In Voucher.Tabdetails(Voucher.TabFirst).gridDetailKeyin.Rows
                        If Not r.IsNewRow Then
                            If r.Cells("so_hd").Value.ToString.Trim.ToLower = sender.Item("so_hd", e.RowIndex).Value.ToString.Trim.ToLower Then
                                t_tien = t_tien + r.Cells("tien_phi").Value
                                t_tien_nt = t_tien_nt + r.Cells("tien_phi_nt").Value
                                ten_vt = r.Cells("ten_vt").Value

                                sender.Item("t_tien", e.RowIndex).Value = t_tien
                                sender.Item("t_tien_nt", e.RowIndex).Value = t_tien_nt
                                sender.Item("ten_vt", e.RowIndex).Value = ten_vt
                                sender.Item("t_thue_nt", e.RowIndex).Value = t_tien_nt * sender.Item("thue_suat", e.RowIndex).Value / 100
                                sender.Item("t_thue", e.RowIndex).Value = t_tien * sender.Item("thue_suat", e.RowIndex).Value / 100
                                sender.Item("ngay_hd", e.RowIndex).Value = Txtngay_ct.Value
                                sender.Item("tk_du", e.RowIndex).Value = r.Cells("tk_du").Value
                            End If
                        End If
                    Next
                    t_tien = Nothing
                    t_tien_nt = Nothing
                    ten_vt = Nothing
                    tinh_tong_tien()

            End Select
        End If
    End Sub
  

    Private Sub btnLuu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLuu.Click
        If save() = False Then
            Exit Sub
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

        End If
        TabControl1.SelectedTab = TabControl1.TabPages(0)
        Voucher.BindingSource.EndEdit()
        If conn.GetValue("if  exists(select stt_rec from tdttco where status = 5 and stt_rec_tt='" & Voucher.Stt_rec & "') select 0 else select 1 ") = False Then
            MsgBox(Voucher.oLan("417"), MsgBoxStyle.Exclamation, Text)
            Return False

        End If
        'kiem tra nhap lieu
        If Voucher.CheckKeyIn = False Then
            Return False
        End If
        'dien cac gia tri cu m vao d
        Voucher.SynMD()
        'cap nhat vao database
        If Voucher.Action = 1 Then
            Voucher.Insert()
        Else
            Voucher.Update()
        End If
        'post
        ClsSV31.Functions.Post(conn, Voucherid, Voucher.Mviewname, Voucher.Stt_rec, cbbstatus.SelectedValue)
        '
        Return True
    End Function
    
    Dim t_tien, t_ck, t_thue, t_tt, t_cp, t_sl, t_tien_von, t_tien_nt, t_ck_nt, t_thue_nt, t_tt_nt, t_sl_nt, t_tien_von_nt, t_cp_nt As Double

    Sub tinh_tong_tien()
        If isloaded = False Then
            Return
        End If
        t_cp_nt = ClsControl2.PropertyOfGrid.Sum(Voucher.Tabdetails(Voucher.TabFirst).gridDetailKeyin, "tien_phi_nt")
        t_cp = ClsControl2.PropertyOfGrid.Sum(Voucher.Tabdetails(Voucher.TabFirst).gridDetailKeyin, "tien_phi")

        t_thue_nt = ClsControl2.PropertyOfGrid.Sum(Voucher.Tabdetails("vvatvao").gridDetailKeyin, "t_thue_nt")
        t_thue = ClsControl2.PropertyOfGrid.Sum(Voucher.Tabdetails("vvatvao").gridDetailKeyin, "t_thue")

        t_tt_nt = t_cp_nt + t_thue_nt
        t_tt = t_cp + t_thue
        '
        txtt_cp_nt.Value = t_cp_nt
        txtt_cp.Value = t_cp

        txtt_thue_nt.Value = t_thue_nt
        txtt_thue.Value = t_thue

        txtt_tt_nt.Value = t_tt_nt
        txtt_tt.Value = t_tt

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
        If Voucher.Action = 1 Then
            Voucher.Mdatatable.Rows.Remove(Voucher.CurrentVoucher)
        End If
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



    Sub hide_show_control(ByVal ma_nt As String)

        For Each t As ClsSV31.TabDetail20 In Voucher.Tabdetails.Values
            t.ma_nt = ma_nt
        Next

        If ma_nt.Trim.ToUpper = ma_nt_ht.Trim.ToUpper Then

            Txtty_gia.ReadOnly = True

            txtt_thue.Hide() 'Visible = False
            txtt_cp.Hide() 'Visible = False
            txtt_tt.Hide() 'Visible = False


            txtt_cp_nt.NumberDecimalDigits = Clsql.Others.Options("f_tien", conn)
            txtt_thue_nt.NumberDecimalDigits = Clsql.Others.Options("f_tien", conn)
            txtt_tt_nt.NumberDecimalDigits = Clsql.Others.Options("f_tien", conn)

        Else

            Txtty_gia.ReadOnly = False

            txtt_thue.Show() 'Visible = True
            txtt_cp.Show() 'Visible = True
            txtt_tt.Show() 'Visible = True

            txtt_cp_nt.NumberDecimalDigits = Clsql.Others.Options("f_tien_nt", conn)
            txtt_thue_nt.NumberDecimalDigits = Clsql.Others.Options("f_tien_nt", conn)
            txtt_tt_nt.NumberDecimalDigits = Clsql.Others.Options("f_tien_nt", conn)
            tinh_tong_tien()

        End If
    End Sub


    Private Sub btngethoadon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngethoadon.Click
        Dim fdkloc As New frmdklayhd
        ClsControl2.PropertyOfForm.SetLable(Voucher.oLan, fdkloc)
        fdkloc.Icon = Me.Icon
        fdkloc.StartPosition = FormStartPosition.CenterParent
        If fdkloc.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            If layhd.Show("Exec GetInvoice4NCP " & conn.ConvertToSQLType(txtma_kh.Text) & "," & conn.ConvertToSQLType(fdkloc.Txttu_ngay.Value) & "," & conn.ConvertToSQLType(fdkloc.TxtDen_ngay.Value)) = Windows.Forms.DialogResult.OK Then

                For Each r As DataRow In layhd.MDataView.Table.Select("sel = false")
                    For Each r2 As DataRow In layhd.DDataView.Table.Select("stt_rec = '" & r("stt_rec") & "'")
                        r2.Delete()
                    Next
                Next

                For Each r As DataRow In layhd.DDataView.Table.Select("sel = false")
                    r.Delete()
                Next
                'tinh tien hang quy doi
                Dim ty_gia As Double = Txtty_gia.Value
                If ty_gia = 0 Then ty_gia = 1
                For Each r As DataRow In layhd.DDataView.Table.Select("sel = true")
                    If r.Item("ma_nt_hd") = cbbma_nt.SelectedValue Then
                        r.Item("tien_hang_qd") = r.Item("tien_hang_nt")
                        r.Item("tien_nhap_nt") = r.Item("tien_hang_qd") + r.Item("tien_phi_nt")
                    Else
                        r.Item("tien_hang_qd") = r.Item("tien_hang") / ty_gia
                        r.Item("tien_nhap_nt") = r.Item("tien_hang_qd") + r.Item("tien_phi_nt") 'r.Item("tien_nhap_nt")
                    End If

                Next
                '
                Clsql.Data.CopyTable(layhd.DDataView.Table, Voucher.Tabdetails(Voucher.TabFirst).Datatable)

                Voucher.Tabdetails(Voucher.TabFirst).bindingsource.DataSource = Voucher.Tabdetails(Voucher.TabFirst).Datatable
            End If
        End If

        SendKeys.Send("{tab}")
    End Sub

    Sub Phan_bo_chi_phi()
        If cbbkieu_pb.SelectedItem Is Nothing Then
            Return
        End If
        Dim ma_nt As String = cbbma_nt.SelectedValue
        Dim col, col2 As String
        col = cbbkieu_pb.SelectedItem.row("val")
        col2 = cbbkieu_pb.SelectedItem.row("val2")

        Dim t_tien As Double = ClsControl2.PropertyOfGrid.Sum(Voucher.Tabdetails(Voucher.TabFirst).gridDetailKeyin, col)
        Dim t_tien_nt As Double = ClsControl2.PropertyOfGrid.Sum(Voucher.Tabdetails(Voucher.TabFirst).gridDetailKeyin, col2)

        Dim cp As Double = ClsControl2.PropertyOfGrid.Sum(Voucher.Tabdetails("vsophi").gridDetailKeyin, "tien")
        Dim cp_nt As Double = ClsControl2.PropertyOfGrid.Sum(Voucher.Tabdetails("vsophi").gridDetailKeyin, "tien_nt")
        If t_tien <> 0 Then
            Dim row_first As DataGridViewRow = Nothing
            For Each r As DataGridViewRow In Voucher.Tabdetails(Voucher.TabFirst).gridDetailKeyin.Rows
                If Not r.IsNewRow Then
                    If row_first Is Nothing Then
                        row_first = r
                    End If

                    r.Cells("tien_phi").Value = Math.Round((r.Cells(col).Value / t_tien) * cp, 0)
                    If ma_nt.Trim.ToUpper = ma_nt_ht.Trim.ToUpper Then
                        r.Cells("tien_phi_nt").Value = Math.Round((r.Cells(col2).Value / t_tien_nt) * cp_nt, 0)
                    Else
                        r.Cells("tien_phi_nt").Value = Math.Round((r.Cells(col2).Value / t_tien_nt) * cp_nt, 2)
                    End If


                    r.Cells("tien_nhap_nt").Value = r.Cells("tien_hang_qd").Value + r.Cells("tien_phi_nt").Value
                    r.Cells("tien_nhap").Value = r.Cells("tien_hang").Value + r.Cells("tien_phi").Value

                End If
            Next

            tinh_tong_tien()
            If row_first IsNot Nothing AndAlso cp_nt <> txtt_cp_nt.Value Then
                row_first.Cells("tien_phi_nt").Value = row_first.Cells("tien_phi_nt").Value + (-txtt_cp_nt.Value + cp_nt)
                row_first.Cells("tien_phi").Value = row_first.Cells("tien_phi").Value + (-txtt_cp.Value + cp)

                row_first.Cells("tien_nhap_nt").Value = row_first.Cells("tien_hang_qd").Value + row_first.Cells("tien_phi_nt").Value
                row_first.Cells("tien_nhap").Value = row_first.Cells("tien_hang").Value + row_first.Cells("tien_phi").Value

                tinh_tong_tien()
            End If
        End If
    End Sub
    Private Sub btnphan_bo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnphan_bo.Click
        'If chbpb_cp_gt.Checked = True Then
        '    Phan_bo_theo_gia_tri()
        'End If
        'If chbpb_cp_sl.Checked = True Then
        '    Phan_bo_theo_so_luong()
        'End If
        Phan_bo_chi_phi()
    End Sub

End Class