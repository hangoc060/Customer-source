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

        progressbar.Visible = False
        If Txttu_ky.Value = 0 Then
            Txttu_ky.Value = Now.Month
            Txtden_ky.Value = Now.Month
            Txtnam.Value = Now.Year

        End If
        Dim vt As New ClsLookup.AutoCompleteLookup(conn, "dmvt", Txtma_vt, "ma_vt", False)
        'ncc.cKey = "ma_loai_kh='NCC'"
        ap_gia_tri_cl_pxc = Clsql.Others.Options("ap_cl_pxc", conn).ToString.Trim


        If Clsql.Reg.GetValue("Language") = "Vi" Then
            vt.SetValue("ten_vt", lblten_vt)

        Else
            vt.SetValue("ten_vt2", lblten_vt)

        End If
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

        Clsql.Reg.SetValue("tu_ky", Txttu_ky.Value)
        Clsql.Reg.SetValue("den_ky", Txtden_ky.Value)
        Clsql.Reg.SetValue("nam", Txtnam.Value)

        BackgroundWorker1.RunWorkerAsync()
    End Sub
    Sub Exec()
        btnOK.Enabled = False
        btnCancel.Enabled = True
        progressbar.Visible = True
        btnerrordetail.Visible = False
        error_msg = ""
        lblstatus.Text = "Đang tính giá trung bình..."
        calc()
    End Sub
    Private Sub calc()
        Dim ds As New DataSet
        Dim query As String = "Exec tinhgiatb "
        query = query & conn.ConvertToSQLType(New DateTime(Txtnam.Value, Txttu_ky.Value, 1))
        query = query & "," & conn.ConvertToSQLType(Clsql.Others.EndDateOfMonth(Txtden_ky.Value, Txtnam.Value))
        query = query & "," & conn.ConvertToSQLType(Txtma_vt.Text)
        query = query & "," & conn.ConvertToSQLType(cbbma_kho.SelectedValue)
        query = query & "," & conn.ConvertToSQLType(chbTaoPXCL.Checked)

        ds = conn.GetDataSet(query)
        Dim collect_detail As New Dictionary(Of String, String)
        Dim collect_master As New Dictionary(Of String, String)

        lblstatus.Text = "Xử lý chênh lệch..."
        If ds.Tables(0).Rows.Count > 0 Then
            For Each r As DataRow In ds.Tables(0).Rows
                Dim stt_rec As String = r.Item("stt_rec")
                If stt_rec <> "" Then
                    lblstatus.Text = "Xử lý chênh lệch cho " & r.Item("ma_vt") & "..."
                    Dim ma_ct As String = stt_rec.Substring(1, 3)
                    Dim dtable, mtable As String
                    If collect_detail.ContainsKey(ma_ct) Then
                        dtable = collect_detail.Item(ma_ct)
                        mtable = collect_master.Item(ma_ct)
                    Else
                        Dim d As DataTable = conn.GetDatatable("select detailtable,mastertable from voucherinfo where voucherid ='" & ma_ct & "'")
                        If d.Rows.Count = 0 Then
                            Continue For
                        End If
                        dtable = d.Rows(0).Item("detailtable")
                        mtable = d.Rows(0).Item("mastertable")
                        collect_detail.Add(ma_ct, dtable)
                        collect_master.Add(ma_ct, mtable)
                    End If
                    query = "select top 1 line from  " & dtable & " where stt_rec ='" & stt_rec & "' and ma_vt ='" & r.Item("ma_vt").ToString.Trim & "' and ma_kho ='" & r.Item("ma_kho").ToString.Trim & "'"
                    Dim line As Integer = conn.GetValue(query)
                    query = "update " & dtable & " set tien_xuat = tien_xuat + " & r.Item("du") & ",tien_xuat_nt = tien_xuat_nt + " & r.Item("du") & " where line =" & line & " and  stt_rec ='" & stt_rec & "' and ma_vt ='" & r.Item("ma_vt").ToString.Trim & "' and ma_kho ='" & r.Item("ma_kho").ToString.Trim & "'"
                    Try
                        conn.Execute(query)
                    Catch ex As Exception

                    End Try

                    ClsSV31.Functions.PostRealTime(conn, ma_ct, mtable, stt_rec, 5)
                End If

            Next

        End If

        '
        ds.Dispose()
        lblstatus.Text = "Đã hoàn thành"
    End Sub
    Dim error_msg As String = ""

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnerrordetail.Click
        Dim f As New frmError
        f.Icon = Me.Icon
        f.RichTextBox1.Text = error_msg
        f.ShowDialog(Me)
    End Sub
    Private Sub BackgroundWorker1_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            Exec()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

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
