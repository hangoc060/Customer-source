
Public Class Form1
    Dim conn As New Clsql.SQL
    Dim ap_gia_tri_cl_pxc As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        txtdatabase.Text = conn.database
        txtserver.Text = conn.IP
        Txttu_ky.Value = Clsql.Reg.GetValue("tu_ky")
        Txtden_ky.Value = Clsql.Reg.GetValue("den_ky")
        Txtnam.Value = Clsql.Reg.GetValue("nam")
        txttk_cl.Text = Clsql.Reg.GetValue("tk_cl")
        Txttao_px_cl.Value = Clsql.Reg.GetValue("tao_cl")

        progressbar.Visible = False
        If Txttu_ky.Value = 0 Then
            Txttu_ky.Value = Now.Month
            Txtden_ky.Value = Now.Month
            Txtnam.Value = Now.Year
            txttk_cl.Text = "6321"
            Txttao_px_cl.Value = 1
        End If
        Dim vt As New ClsLookup.AutoCompleteLookup(conn, "dmvt", Txtma_vt, "ma_vt", False)
        Dim ncc As New ClsLookup.GetMultiValueFromList(conn, "dmkh", "ma_kh", txtnha_cung_cap)
        'ncc.cKey = "ma_loai_kh='NCC'"
        ap_gia_tri_cl_pxc = Clsql.Others.Options("ap_cl_pxc", conn).ToString.Trim

        Dim tk As New ClsLookup.AutoCompleteLookup(conn, "dmtk", txttk_cl, "tk")
        If Clsql.Reg.GetValue("Language") = "Vi" Then
            vt.SetValue("ten_vt", lblten_vt)
            tk.SetValue("ten_tk", lblten_tk)
        Else
            vt.SetValue("ten_vt2", lblten_vt)
            tk.SetValue("ten_tk2", lblten_tk)
        End If


        ClsLookup.AddItems.AddItemCbbGotBlank(conn, "select ma_nhom,ten_nhom from dmnhomvt where loai_nhom = 1", cbbnh_vt, "Ten_nhom", "ma_nhom")
        ClsLookup.AddItems.AddItemCbbGotBlank(conn, "select ma_loai_vt,ten_loai_vt from dmloaivt ", cbbloai_vt, "ten_loai_vt", "ma_loai_vt")
        ClsLookup.AddItems.AddItemCbbGotBlank(conn, "select ma_kho,ten_kho from dmkho ", cbbma_kho, "ten_kho", "ma_kho")
        olan = ClsControl2.PropertyOfForm.SetLable(conn, Me, Clsql.Others.GetArgu(1))
        ClsControl2.PropertyOfForm.KeyEnter(Me)

    End Sub
    Dim olan As Collection
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        BackgroundWorker1.CancelAsync()
        Application.Exit()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        If Txttu_ky.Value < 1 Or Txttu_ky.Value > 12 Then
            MsgBox(Clsql.Others.Msgs("0011", conn), MsgBoxStyle.Exclamation, Me.Text)
            Txttu_ky.Focus()
            Return
        End If

        If Txtden_ky.Value < 1 Or Txtden_ky.Value > 12 Then
            MsgBox(Clsql.Others.Msgs("0011", conn), MsgBoxStyle.Exclamation, Me.Text)
            Txtden_ky.Focus()
            Return
        End If

        If Txttu_ky.Value > Txtden_ky.Value Then
            MsgBox(Clsql.Others.Msgs("0011", conn), MsgBoxStyle.Exclamation, Me.Text)
            Txttu_ky.Focus()
            Return
        End If


        If Txtnam.Value < 1000 Then
            MsgBox(Clsql.Others.Msgs("0012", conn), MsgBoxStyle.Exclamation, Me.Text)
            Txtnam.Focus()
            Return
        End If
        'kiem tra ngay khoa so
        Dim ngay_ks As Date = conn.GetValue("select ngay_ks from dmstt")
        If ngay_ks >= New DateTime(Txtnam.Value, Txttu_ky.Value, 1) Then
            MsgBox(Clsql.Others.Msgs("0010", conn).Replace("%n", ngay_ks), MsgBoxStyle.Exclamation, Me.Text)
            Return
        End If
        '
        Clsql.Reg.SetValue("tk_cl", txttk_cl.Text)
        Clsql.Reg.SetValue("tu_ky", Txttu_ky.Value)
        Clsql.Reg.SetValue("den_ky", Txtden_ky.Value)
        Clsql.Reg.SetValue("nam", Txtnam.Value)
        Clsql.Reg.SetValue("tao_cl", Txttao_px_cl.Value)
        BackgroundWorker1.RunWorkerAsync()
    End Sub
    Dim sl_da_tinh As Integer = 0
    Dim t_sl_vt As Integer = 0
    Sub Exec()
        Dim ds_ma_vt As String = Txtma_vt.Text
        sl_da_tinh = 0
        lblstatus.Text = "Lấy danh sách vật tư..."
        btnOK.Enabled = False
        btnCancel.Enabled = True
        progressbar.Visible = True
        btnerrordetail.Visible = False
        error_msg = ""
        Dim query As String = "select ma_vt from dmvt where trang_thai=1 and gia_ton =1"
        If Txtma_vt.Text.Trim <> "" Then
            query = query & " and ma_vt='" & Txtma_vt.Text & "'"
        End If
        If cbbloai_vt.SelectedValue.ToString.Trim <> "" Then
            query = query & " and loai_vt='" & cbbloai_vt.SelectedValue.ToString.Trim & "'"
        End If
        If cbbnh_vt.SelectedValue.ToString.Trim <> "" Then
            query = query & " and nh_vt1='" & cbbnh_vt.SelectedValue.ToString.Trim & "'"
        End If
        If txtnha_cung_cap.Text.ToString.Trim <> "" Then
            query = query & " and dbo.einstr(nha_cung_cap,'" & txtnha_cung_cap.Text.ToString.Trim & "')=1"
        End If
        dsvt = conn.GetDatatable(query)
        t_sl_vt = dsvt.Rows.Count
        lblstatus.Text = "Bắt đầu tính..."
        For Each row As DataRow In dsvt.Rows
            lblstatus.Text = "Đang tính " & (sl_da_tinh + 1) & "/" & t_sl_vt & "..."
            calc(row)
            sl_da_tinh = sl_da_tinh + 1
        Next
    End Sub
    Dim dsvt As DataTable

    Private Sub calc(ByVal row As DataRow)

        Dim vt As String = row("ma_vt")
        Try
            Dim ds As New DataSet
            Dim query As String = "Exec TinhGiaXuatKho "
            query = query & conn.ConvertToSQLType(New DateTime(Txtnam.Value, Txttu_ky.Value, 1))
            query = query & "," & conn.ConvertToSQLType(Clsql.Others.EndDateOfMonth(Txtden_ky.Value, Txtnam.Value))
            query = query & "," & conn.ConvertToSQLType(cbbma_kho.SelectedValue)
            query = query & "," & conn.ConvertToSQLType(vt)
            query = query & "," & conn.ConvertToSQLType(cbbnh_vt.SelectedValue)
            query = query & "," & conn.ConvertToSQLType(cbbloai_vt.SelectedValue)
            query = query & "," & conn.ConvertToSQLType(Clsql.Others.GetArgu(2)) 'kieu tinh gia
            query = query & "," & conn.ConvertToSQLType(Txttao_px_cl.Value)
            query = query & "," & conn.ConvertToSQLType(txttk_cl.Text)
            query = query & "," & conn.ConvertToSQLType(Clsql.Reg.GetValue("ID"))
            ds = conn.GetDataSet(query)

            If ds.Tables(0).Rows.Count > 0 Then
                'ap chenh lech vao phieu xuat cuoi
                If ap_gia_tri_cl_pxc = "1" Then
                    Try
                        query = "select max(stt_rec) as stt_rec from sokho where px_gia_dd=0 and ma_ct <>'PXZ' and nxt ='2' and  ma_vt ='" & vt & "' and ngay_ct between " & conn.ConvertToSQLType(New DateTime(Txtnam.Value, Txttu_ky.Value, 1)) & " and " & conn.ConvertToSQLType(Clsql.Others.EndDateOfMonth(Txtden_ky.Value, Txtnam.Value))
                        Dim stt_rec_c As String = conn.GetValue(query)

                        If Not String.IsNullOrEmpty(stt_rec_c) Then

                            Dim gt_cl As Double = ds.Tables(0).Rows(0)("tien_xuat")

                            Dim ma_ct As String = stt_rec_c.Substring(1, 3)
                            Dim dtable As String = "d" & ma_ct
                            Dim mtable As String = "m" & ma_ct
                            Dim status As String
                            query = "select top 1 a.line,b.status from " & dtable & " a left join " & mtable & " b on a.stt_rec = b.stt_rec where a.stt_rec='" & stt_rec_c & "' and a.ma_vt ='" & vt & "'"
                            Dim tb As DataTable = conn.GetDatatable(query)
                            status = tb.Rows(0)("status")
                            Dim line As Integer = tb.Rows(0)("line")
                            query = "update " & dtable & " set tien_xuat =tien_xuat + " & gt_cl & ",tien_xuat_nt=tien_xuat_nt + " & gt_cl & " where stt_rec ='" & stt_rec_c & "' and ma_vt='" & vt & "' and line =" & line

                            conn.Execute(query)
                            ClsSV31.Functions.PostRealTime(conn, ma_ct, mtable, stt_rec_c, status)
                        Else

                            'tinh chenh lech
                            query = conn.GetInsertQueryFromDatatable(ds.Tables(0), "sokho")
                            query = query & ChrW(13) & conn.GetInsertQueryFromDatatable(ds.Tables(1), "socai")

                            If query <> "" Then
                                conn.Execute(query)
                            End If
                        End If
                    Catch ex As Exception

                        'tinh chenh lech
                        query = conn.GetInsertQueryFromDatatable(ds.Tables(0), "sokho")
                        query = query & ChrW(13) & conn.GetInsertQueryFromDatatable(ds.Tables(1), "socai")

                        If query <> "" Then
                            conn.Execute(query)
                        End If
                    End Try



                Else

                    'tinh chenh lech
                    query = conn.GetInsertQueryFromDatatable(ds.Tables(0), "sokho")
                    query = query & ChrW(13) & conn.GetInsertQueryFromDatatable(ds.Tables(1), "socai")

                    If query <> "" Then
                        conn.Execute(query)
                    End If
                End If

            End If


            '
            ds.Dispose()
        Catch ex As Exception
            If error_msg = "" Then
                error_msg = vt
            Else
                error_msg = error_msg & "," & vt
            End If
        End Try


    End Sub
    Dim error_msg As String = ""

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnerrordetail.Click
        Dim f As New frmError
        f.Icon = Me.Icon
        f.RichTextBox1.Text = error_msg
        f.ShowDialog(Me)
    End Sub
    Private Sub BackgroundWorker1_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Exec()
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        progressbar.Visible = False
        btnOK.Enabled = True
        btnCancel.Enabled = False
        MsgBox("Chương trình đã thực hiện xong", , Clsql.AboutMe.Name)
        If error_msg <> "" Then
            btnerrordetail.Visible = True
        End If
    End Sub
End Class
