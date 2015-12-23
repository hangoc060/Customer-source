Imports ClsLookup

Public Class frminput

    Dim isloaded As Boolean = False
    Dim t_tien, t_ck, t_thue, t_tt, t_sl, t_tien_von, t_tien_nt, t_ck_nt, t_thue_nt, t_tt_nt, t_sl_nt, t_tien_von_nt As Double
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
            Case ClsSV31.frmTask.Tasks.TD1
                Dim f As New frmThuTien
                f.Icon = Me.Icon
                f.Text = formtask.TD1.Text
                f.StartPosition = FormStartPosition.CenterParent
                f.txtma_kh.Text = txtma_kh.Text
                f.ten_kh.Text = txtten_kh.Text
                f.txttien_hd.Value = Voucher.CurrentVoucher.Item("t_tt")
                f.txtma_nt.Text = cbbma_nt.SelectedValue
                f.txtty_gia.Value = Txtty_gia.Value
                Dim dtpc As DataTable = conn.GetDatatable("select * from mpt1 where stt_rec_goc_hd ='" & Voucher.Stt_rec & "'")
                If dtpc.Rows.Count > 0 Then
                    f.txtty_gia.Value = dtpc.Rows(0).Item("ty_gia")
                    f.txtma_nt.Text = dtpc.Rows(0).Item("ma_nt")
                    f.txttien_nt.Value = conn.GetValue("select sum(tien_nt) from dpt1 where stt_rec='" & dtpc.Rows(0).Item("stt_rec") & "'")
                    f.txttien.Value = conn.GetValue("select sum(tien) from dpt1 where stt_rec='" & dtpc.Rows(0).Item("stt_rec") & "'")
                End If
                
                If f.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    Dim query As String
                    Dim query_tt As String = ""
                    'xoa phieu thu cu
                    If dtpc.Rows.Count > 0 Then
                        Dim stt_rec_pc As String = dtpc.Rows(0).Item("stt_rec")
                        query = "delete from dpt1 where stt_rec='" & stt_rec_pc & "'"
                        query = query & ChrW(13) & "GO" & ChrW(13) & "delete from mpt1 where stt_rec='" & stt_rec_pc & "'"
                        conn.ExecuteWithMultiQuery(query)
                        'xoa post
                        ClsSV31.Functions.deletePost(conn, dtpc.Rows(0).Item("ma_ct"), dtpc.Rows(0))
                    End If
                    'tao phieu chi
                    query = "select * from mpt1 where 1=0"
                    query = query & ChrW(13) & "select * from dpt1 where 1=0"
                    Dim dspc As DataSet = conn.GetDataSet(query)
                    'get new stt_rec pt
                    Dim stt_rec_pt As String = conn.GetValue("select dbo.getnewsttrec('PT1')")
                    conn.Execute("update Dmct set stt_rec_ht = right('" & stt_rec_pt & "',9)  where ma_ct = 'PT1'")
                    'create master
                    Clsql.Data.CopyTable(Voucher.Mdatatable, dspc.Tables(0), "stt_rec='" & Voucher.Stt_rec & "'")
                    dspc.Tables(0).Rows(0).Item("ma_ct") = "PT1"
                    dspc.Tables(0).Rows(0).Item("ma_gd") = 0
                    dspc.Tables(0).Rows(0).Item("stt_rec") = stt_rec_pt
                    dspc.Tables(0).Rows(0).Item("ma_nt") = f.txtma_nt.Text
                    dspc.Tables(0).Rows(0).Item("ty_gia") = f.txtty_gia.Value
                    dspc.Tables(0).Rows(0).Item("stt_rec_goc_hd") = Voucher.Stt_rec
                    'create detail
                    Clsql.Data.CopyTable(dspc.Tables(0), dspc.Tables(1))
                    dspc.Tables(1).Rows(0).Item("ma_nvu") = f.txtma_nvu.Text
                    dspc.Tables(1).Rows(0).Item("tien_nt") = f.txttien_nt.Value
                    dspc.Tables(1).Rows(0).Item("tien") = f.txttien.Value
                    Dim nghvu As DataTable = conn.GetDatatable("select * from dmnvu where ma_nvu='" & f.txtma_nvu.Text & "'")
                    dspc.Tables(1).Rows(0).Item("tk_no") = nghvu.Rows(0).Item("tk_no")
                    dspc.Tables(1).Rows(0).Item("tk_co") = nghvu.Rows(0).Item("tk_co")
                    'create tdttno
                    Dim rowtdttno As DataRow = Nothing
                    If f.chbttthd.Checked Then
                        query = "Exec GetInvoice4Rec "
                        query = query & conn.ConvertToSQLType(Me.txtma_kh.Text)
                        query = query & "," & conn.ConvertToSQLType(Me.Txtngay_ct.Value)
                        If Voucher.Action = ClsSV31.Voucher20.Actions.ADD Then
                            query = query & ",1"
                        Else
                            query = query & ",2"
                        End If
                        query = query & "," & conn.ConvertToSQLType(Voucher.Stt_rec)
                        Dim tdttno As DataTable = conn.GetDatatable(query)

                        For Each r As DataRow In tdttno.Rows
                            If r.Item("stt_rec").ToString.Substring(0, 1) & r.Item("ma_ct").ToString & r.Item("stt_rec").ToString.Substring(4) = Voucher.Stt_rec Then
                                r.Item("stt_rec") = stt_rec_pt
                                r.Item("ma_ct") = "PT1"
                                r.Item("loai_tt") = "1"
                                r.Item("ngay_ct") = Me.Txtngay_ct.Value
                                r.Item("so_ct") = Me.txtso_ct.Text
                                r.Item("status") = Me.cbbstatus.SelectedValue
                                r.Item("tk_no") = nghvu.Rows(0).Item("tk_no")
                                r.Item("ma_nvu") = f.txtma_nvu.Text
                                dspc.Tables(1).Rows(0).Item("tk_co") = r.Item("tk_co")
                                dspc.Tables(0).Rows(0).Item("ma_gd") = 1
                                r.Item("ma_nt") = f.txtma_nt.Text
                                r.Item("ty_gia") = f.txtty_gia.Value
                                r.Item("tien_nt") = f.txttien_nt.Value
                                r.Item("tien") = f.txttien.Value
                                r.Item("tt_qd") = f.txttien.Value / r.Item("ty_gia_tt")
                                rowtdttno = r
                                If r.Item("tt_qd") >= r.Item("con_lai_nt") Then
                                    query_tt = "EXEC Tatoanno " & conn.ConvertToSQLType(r.Item("stt_rec_tt")) & "," & "'" & r.Item("ma_ct_tt") & "'"
                                End If

                                Exit For
                            End If
                        Next
                    End If
                    'run
                    query = conn.GetInsertQueryFromDatatable(dspc.Tables(0), "mpt1")
                    query = query & ChrW(13) & "GO" & conn.GetInsertQueryFromDatatable(dspc.Tables(1), "dpt1")
                    If rowtdttno IsNot Nothing Then
                        query = query & ChrW(13) & "GO" & conn.GetInsertQueryFromDataRow(rowtdttno, "tdttno")
                    End If
                    conn.ExecuteWithMultiQuery(query)
                    'post phieu chi
                    ClsSV31.Functions.Post(conn, dspc.Tables(0).Rows(0).Item("ma_ct"), "vmpt1", dspc.Tables(0).Rows(0).Item("stt_rec"), cbbstatus.SelectedValue)
                    'tat toan
                    If query_tt <> "" Then
                        conn.Execute(query_tt)
                    End If
                End If
                Me.Close()
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
        If conn.GetValue("if  exists(select stt_rec from tdttno where status = 5 and stt_rec_tt='" & Voucher.Stt_rec & "') select 0 else select 1 ") = False Then
            MsgBox(Voucher.oLan("417"), MsgBoxStyle.Exclamation, Text)
            Return False
        End If
        'kiem tra nhap lieu
        If Voucher.CheckKeyIn = False Then
            Return False
        End If
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
    Dim t_ck_hd_nt, t_ck_hd, t_thue_ck_hd_nt, t_thue_ck_hd As Double
    Sub tinh_tong_tien()
        If isloaded = False Then
            Return
        End If

        t_tien_nt = ClsControl2.PropertyOfGrid.Sum(Voucher.Tabdetails(Voucher.TabFirst).gridDetailKeyin, "tien_nt1")
        t_tien = ClsControl2.PropertyOfGrid.Sum(Voucher.Tabdetails(Voucher.TabFirst).gridDetailKeyin, "tien1")
        t_ck_nt = ClsControl2.PropertyOfGrid.Sum(Voucher.Tabdetails(Voucher.TabFirst).gridDetailKeyin, "tien_ck_ct_nt")
        t_ck = ClsControl2.PropertyOfGrid.Sum(Voucher.Tabdetails(Voucher.TabFirst).gridDetailKeyin, "tien_ck_ct")

        t_ck_hd_nt = ClsControl2.PropertyOfGrid.Sum(Voucher.Tabdetails(Voucher.TabFirst).gridDetailKeyin, "tien_ck_hd_ct_nt")
        t_ck_hd = ClsControl2.PropertyOfGrid.Sum(Voucher.Tabdetails(Voucher.TabFirst).gridDetailKeyin, "tien_ck_hd_ct")


        t_thue_nt = ClsControl2.PropertyOfGrid.Sum(Voucher.Tabdetails(Voucher.TabFirst).gridDetailKeyin, "tien_thue_nt")
        t_thue = ClsControl2.PropertyOfGrid.Sum(Voucher.Tabdetails(Voucher.TabFirst).gridDetailKeyin, "tien_thue")

        t_thue_ck_hd_nt = ClsControl2.PropertyOfGrid.Sum(Voucher.Tabdetails(Voucher.TabFirst).gridDetailKeyin, "tien_thue_ck_hd_nt")
        t_thue_ck_hd = ClsControl2.PropertyOfGrid.Sum(Voucher.Tabdetails(Voucher.TabFirst).gridDetailKeyin, "tien_thue_ck_hd")


        t_sl = ClsControl2.PropertyOfGrid.Sum(Voucher.Tabdetails(Voucher.TabFirst).gridDetailKeyin, "sl_xuat")
        t_tien_von = ClsControl2.PropertyOfGrid.Sum(Voucher.Tabdetails(Voucher.TabFirst).gridDetailKeyin, "tien_xuat")


        

        Txtt_tien_nt.Value = t_tien_nt
        Txtt_tien.Value = t_tien

        Txtt_ck_nt.Value = t_ck_nt
        Txtt_ck.Value = t_ck

        Txtt_ck_hd_nt.Value = t_ck_hd_nt
        Txtt_ck_hd.Value = t_ck_hd

        txtt_thue_nt.Value = t_thue_nt - t_thue_ck_hd_nt 't_thue_nt + t_thue_ck_hd_nt
        txtt_thue.Value = t_thue - t_thue_ck_hd 't_thue + t_thue_ck_hd


        t_tt_nt = t_tien_nt - t_ck_nt - t_ck_hd_nt + t_thue_nt - t_thue_ck_hd_nt
        t_tt = t_tien - t_ck - t_ck_hd + t_thue - t_thue_ck_hd


        txtt_tt_nt.Value = t_tt_nt
        txtt_tt.Value = t_tt

        Txtt_sl.Value = t_sl
        Txtt_tien_von.Value = t_tien_von
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
            '-0--
            Txtty_gia.ReadOnly = True
            Txtt_tien.Hide() 'Visible = False
            Txtt_ck.Hide() 'Visible = False
            txtt_thue.Hide() 'Visible = False
            txtt_tt.Hide() 'Visible = False
            Txtt_ck_hd.Hide()

            Txtt_tien_nt.NumberDecimalDigits = Clsql.Others.Options("f_tien", conn)
            Txtt_ck_nt.NumberDecimalDigits = Clsql.Others.Options("f_tien", conn)
            txtt_thue_nt.NumberDecimalDigits = Clsql.Others.Options("f_tien", conn)
            txtt_tt_nt.NumberDecimalDigits = Clsql.Others.Options("f_tien", conn)
            Txtt_ck_hd_nt.NumberDecimalDigits = Clsql.Others.Options("f_tien", conn)
        Else
            '-0--
            Txtty_gia.ReadOnly = False
            Txtt_tien.Show() 'Visible = True
            Txtt_ck.Show() 'Visible = True
            txtt_thue.Show() 'Visible = True
            txtt_tt.Show() 'Visible = True
            Txtt_ck_hd.Show()

            Txtt_tien_nt.NumberDecimalDigits = Clsql.Others.Options("f_tien_nt", conn)
            Txtt_ck_nt.NumberDecimalDigits = Clsql.Others.Options("f_tien_nt", conn)
            txtt_thue_nt.NumberDecimalDigits = Clsql.Others.Options("f_tien_nt", conn)
            txtt_tt_nt.NumberDecimalDigits = Clsql.Others.Options("f_tien_nt", conn)
            Txtt_ck_hd_nt.NumberDecimalDigits = Clsql.Others.Options("f_tien_nt", conn)
            tinh_tong_tien()
        End If
    End Sub

    Private Sub btnlaydulieutudonhang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlaydulieutudonhang.Click
        Dim layhd As GetDataByStoreMD
        layhd = New GetDataByStoreMD(Voucher.conn, "MHD2_BL", "dpbl_get4xhd", , "xhd")
        Dim fdkloc As New frmdklayhd
        ClsControl2.PropertyOfForm.SetLable(Voucher.oLan, fdkloc)
        fdkloc.Icon = Me.Icon
        fdkloc.StartPosition = FormStartPosition.CenterParent
        If fdkloc.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            If layhd.Show("Exec GetPBL4XHD " & conn.ConvertToSQLType(fdkloc.Txttu_ngay.Value) & "," & conn.ConvertToSQLType(fdkloc.TxtDen_ngay.Value) & "," & conn.ConvertToSQLType(txtma_kh.Text) & "," & conn.ConvertToSQLType(Voucher.Stt_rec) & "," & conn.ConvertToSQLType(fdkloc.txtma_thue.Text) & "," & conn.ConvertToSQLType(fdkloc.txttk_vt.Text) & "," & conn.ConvertToSQLType(fdkloc.txttk_dt.Text) & "," & conn.ConvertToSQLType(fdkloc.txttk_tien.Text) & "," & conn.ConvertToSQLType(fdkloc.txttk_ck.Text) & "," & conn.ConvertToSQLType(fdkloc.chbck.Checked) & "," & conn.ConvertToSQLType(fdkloc.chbnock.Checked)) = Windows.Forms.DialogResult.OK Then
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
                    Voucher.CurrentVoucher("tk_chiet_khau") = r("tk_chiet_khau")
                    txtma_kh.Focus()
                    Voucher.Tabdetails(Voucher.TabFirst).gridDetailKeyin.Focus()
                    Exit For
                Next
                tinh_tong_tien()


            End If
        End If
    End Sub

   
End Class