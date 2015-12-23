Imports System.ComponentModel
Imports ClsLookup

Public Class frminput

    Dim isloaded As Boolean = False

    Private Sub frminput_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If isloaded = False Then
            Me.txtso_ct.Focus()
            Me.txtso_ct.SelectionStart = txtso_ct.Text.Length
        End If
    End Sub
    Private Sub frminput_show(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        Dim dvr As DataRowView = cbbma_nt.SelectedItem


        hide_show_control(dvr("ma_nt"))
        isloaded = True
        If Voucher.Action = ClsSV31.Voucher20.Actions.ADD Then
            Txtty_gia.Value = conn.GetValue("exec getty_gia " & conn.ConvertToSQLType(cbbma_nt.SelectedValue.trim) & "," & conn.ConvertToSQLType(Txtngay_ct.Value))
        End If

    End Sub

    Private Sub frminput_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        isloaded = False
        For Each dvtab As ClsSV31.TabDetail20 In Voucher.Tabdetails.Values
            RemoveHandler dvtab.AfterCalcOnCell, AddressOf tinh_tong_tien
        Next
    End Sub

    Private Sub frminput_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        For Each dvtab As ClsSV31.TabDetail20 In Voucher.Tabdetails.Values
            AddHandler dvtab.AfterCalcOnCell, AddressOf tinh_tong_tien
        Next

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
        '
        Voucher.BindingSource.Current("t_tien_nt") = t_tien_nt
        Voucher.BindingSource.Current("t_tien") = t_tien
        Voucher.BindingSource.Current("t_sl") = t_sl
        'kiem tra da nhap chi tiet chua
        If Voucher.CheckKeyIn = False Then
            Return False
        End If
        'kiem tra so chung tu
        If Voucher.CheckSoCT(Txtngay_ct.Value, txtso_ct.Text) = False Then
            Return False
        End If

        Voucher.BindingSource.EndEdit()
        'dien cac gia tri cu m vao d
        Voucher.SynMD()
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
        t_tien_nt = ClsControl2.PropertyOfGrid.Sum(Voucher.Tabdetails(Voucher.TabFirst).gridDetailKeyin, "tien_xuat_nt")
        t_tien = ClsControl2.PropertyOfGrid.Sum(Voucher.Tabdetails(Voucher.TabFirst).gridDetailKeyin, "tien_xuat")
        t_sl = ClsControl2.PropertyOfGrid.Sum(Voucher.Tabdetails(Voucher.TabFirst).gridDetailKeyin, "sl_xuat")
        '
        Txtt_tien_nt.Value = t_tien_nt
        Txtt_tien.Value = t_tien
        Txtt_sl.Value = t_sl


    End Sub
    Private Sub btnluuandmoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnluuandmoi.Click
        If save() = False Then
            Exit Sub
        End If
        Me.BindingContext(Voucher.BindingSource).EndCurrentEdit()
        Voucher.Mdatatable.AcceptChanges()
        Voucher.News2()
        ' Dim dvr As DataRowView = cbbma_nt.SelectedItem
        Txtty_gia.Value = conn.GetValue("exec getty_gia " & conn.ConvertToSQLType(cbbma_nt.SelectedValue.trim) & "," & conn.ConvertToSQLType(Txtngay_ct.Value))
        txtso_ct.Focus()

    End Sub

    'Private Sub btnhuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhuy.Click
    '    If Voucher.Action = 1 Then
    '        Voucher.Mdatatable.Rows.Remove(Voucher.CurrentVoucher)
    '    End If
    'End Sub

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
            Txtt_tien.Hide() 'Visible = False
            Txtt_tien_nt.NumberDecimalDigits = Clsql.Others.Options("f_tien", conn)
        Else
            Txtty_gia.ReadOnly = False
            Txtt_tien.Show() 'Visible = True
            Txtt_tien_nt.NumberDecimalDigits = Clsql.Others.Options("f_tien_nt", conn)
            tinh_tong_tien()
        End If
    End Sub

    Private Sub btnByDinhMucNVL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnByDinhMucNVL.Click
        Dim fdkloc As New frmFindHD2
        fdkloc.Txttu_ngay.Value = Clsql.Reg.GetValue("tu_ngay")
        fdkloc.TxtDen_ngay.Value = Clsql.Reg.GetValue("den_ngay")
        ClsControl2.PropertyOfForm.Lookups(conn, fdkloc, Voucherid)
        fdkloc.StartPosition = FormStartPosition.CenterParent
        ClsControl2.PropertyOfForm.SetLable(Voucher.oLan, fdkloc)
        fdkloc.Text = btnByDinhMucNVL.Text
        fdkloc.Icon = Me.Icon
        If fdkloc.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim layhd As GetDataByStoreMD
            layhd = New GetDataByStoreMD(Voucher.conn, "mhd2", "dphd2_get4pxk", , "PXK")
            If layhd.Show("Exec GetHD24PXK " & conn.ConvertToSQLType(fdkloc.Txttu_ngay.Value) & "," & conn.ConvertToSQLType(fdkloc.TxtDen_ngay.Value) & "," & conn.ConvertToSQLType(fdkloc.txtso_ct.Text) & "," & conn.ConvertToSQLType(Voucher.Stt_rec)) = Windows.Forms.DialogResult.OK Then
                For Each r As DataRow In layhd.MDataView.Table.Select("sel = false")
                    For Each r2 As DataRow In layhd.DDataView.Table.Select("stt_rec = '" & r("stt_rec") & "'")
                        r2.Delete()
                    Next

                Next
                For Each r As DataRow In layhd.DDataView.Table.Select("sel = false")
                    r.Delete()
                Next
                'create phieu xuat
                Voucher.Tabdetails(Voucher.TabFirst).Datatable.Rows.Clear()
                Dim query As String
                For Each rhd As DataRow In layhd.DDataView.Table.Rows
                    If rhd.RowState <> DataRowState.Deleted Then
                        If rhd.Item("sl_xuat") = 0 Then
                            Continue For
                        End If
                        query = "exec GetNVLBYDM " & conn.ConvertToSQLType(fdkloc.txtma_nvu.Text)
                        query = query & "," & conn.ConvertToSQLType(Me.Txtngay_ct.Value)
                        query = query & "," & conn.ConvertToSQLType(fdkloc.txtma_kho.Text)
                        query = query & "," & conn.ConvertToSQLType(fdkloc.txtma_bp.Text)
                        query = query & "," & conn.ConvertToSQLType(rhd.Item("ma_vt"))
                        query = query & "," & conn.ConvertToSQLType(rhd.Item("ma_dvt"))
                        query = query & "," & conn.ConvertToSQLType(rhd.Item("sl_xuat"))
                        query = query & "," & conn.ConvertToSQLType(rhd.Item("stt_rec"))
                        Dim dtx As DataTable = conn.GetDatatable(query)
                        If dtx.Rows.Count > 0 Then
                            Clsql.Data.CopyTable(dtx, Voucher.Tabdetails(Voucher.TabFirst).Datatable, "1=1", "1=0")
                        Else
                            MsgBox("Chưa khai báo định mức NVL cho sản phẩm " & rhd.Item("ma_vt").ToString.Trim & " - " & rhd.Item("ten_vt"), MsgBoxStyle.Critical, "Chưa khai báo định mức")
                        End If
                    End If
                Next

                ' Voucher.chitiet.Datatable = layhd.DDataView.Table
                Voucher.Tabdetails(Voucher.TabFirst).bindingsource.DataSource = Voucher.Tabdetails(Voucher.TabFirst).Datatable

                tinh_tong_tien()


            End If
        End If
    End Sub

    Private Sub btnbypn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbypn.Click
        Dim fdkloc As New frmFindHD2
        fdkloc.Txttu_ngay.Value = Clsql.Reg.GetValue("tu_ngay")
        fdkloc.TxtDen_ngay.Value = Clsql.Reg.GetValue("den_ngay")
        ClsControl2.PropertyOfForm.Lookups(conn, fdkloc, Voucherid)
        fdkloc.StartPosition = FormStartPosition.CenterParent
        ClsControl2.PropertyOfForm.SetLable(Voucher.oLan, fdkloc)
        fdkloc.Text = btnByDinhMucNVL.Text
        fdkloc.Icon = Me.Icon
        If fdkloc.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim layhd As GetDataByStoreMD
            layhd = New GetDataByStoreMD(Voucher.conn, "mpnk", "dphd2_get4pxk", , "PXK")
            If layhd.Show("Exec GetPNK4PXK " & conn.ConvertToSQLType(fdkloc.Txttu_ngay.Value) & "," & conn.ConvertToSQLType(fdkloc.TxtDen_ngay.Value) & "," & conn.ConvertToSQLType(fdkloc.txtso_ct.Text) & "," & conn.ConvertToSQLType(Voucher.Stt_rec)) = Windows.Forms.DialogResult.OK Then
                For Each r As DataRow In layhd.MDataView.Table.Select("sel = false")
                    For Each r2 As DataRow In layhd.DDataView.Table.Select("stt_rec = '" & r("stt_rec") & "'")
                        r2.Delete()
                    Next

                Next
                For Each r As DataRow In layhd.DDataView.Table.Select("sel = false")
                    r.Delete()
                Next
                'create phieu xuat
                Voucher.Tabdetails(Voucher.TabFirst).Datatable.Rows.Clear()
                Dim query As String
                For Each rhd As DataRow In layhd.DDataView.Table.Rows
                    If rhd.RowState <> DataRowState.Deleted Then
                        If rhd.Item("sl_xuat") = 0 Then
                            Continue For
                        End If
                        query = "exec GetNVLBYDM " & conn.ConvertToSQLType(fdkloc.txtma_nvu.Text)
                        query = query & "," & conn.ConvertToSQLType(Me.Txtngay_ct.Value)
                        query = query & "," & conn.ConvertToSQLType(fdkloc.txtma_kho.Text)
                        query = query & "," & conn.ConvertToSQLType(fdkloc.txtma_bp.Text)
                        query = query & "," & conn.ConvertToSQLType(rhd.Item("ma_vt"))
                        query = query & "," & conn.ConvertToSQLType(rhd.Item("ma_dvt"))
                        query = query & "," & conn.ConvertToSQLType(rhd.Item("sl_xuat"))
                        query = query & "," & conn.ConvertToSQLType(rhd.Item("stt_rec"))
                        Dim dtx As DataTable = conn.GetDatatable(query)
                        If dtx.Rows.Count > 0 Then
                            Clsql.Data.CopyTable(dtx, Voucher.Tabdetails(Voucher.TabFirst).Datatable, "1=1", "1=0")
                        Else
                            MsgBox("Chưa khai báo định mức NVL cho sản phẩm " & rhd.Item("ma_vt").ToString.Trim & " - " & rhd.Item("ten_vt"), MsgBoxStyle.Critical, "Chưa khai báo định mức")
                        End If
                    End If
                Next

                ' Voucher.chitiet.Datatable = layhd.DDataView.Table
                Voucher.Tabdetails(Voucher.TabFirst).bindingsource.DataSource = Voucher.Tabdetails(Voucher.TabFirst).Datatable

                tinh_tong_tien()


            End If
        End If
    End Sub
End Class