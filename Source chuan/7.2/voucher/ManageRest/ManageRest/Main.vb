Module Main
    Public conn As New Clsql.SQL
    Public olan As Collection
    Public dt As DataTable
    Public cprint As ClPrint.Print
    Public checkright As ClsRight.CheckRight
    Public kv_ht As StpPan.ResItemArea
    Public ma_res As String
    Public mainform As New Form1
    Public fChooseRes As New formChooseRes
    Public stt_rec As ClsVno.SttRec
    Public dtvt As DataTable = Nothing
    Public nh_vt1s As DataTable = Nothing
    Public ma_ct As String = "PBL"
    Public so_ca As String = "CA1"
    Public ma_may_ban_le As String = "01"
    Public info_may_ban_le As DataRow
    Sub Main()
        If Clsql.Reg.GetValue("SLG") = 0 Then
            Application.Exit()
            Return
        End If
        'check right
        Dim ma_cn As String = conn.GetValue("select id from " & Clsql.Others.Options("cmd_table", conn) & " where ma_cn ='" & Clsql.Others.GetArgu(1) & "'")
        If ma_cn Is Nothing Or ma_cn Is DBNull.Value Then
            Application.Exit()
            Return
        End If

        checkright = New ClsRight.CheckRight(conn, ma_cn)
        If Not checkright.ViewRight Then
            Application.Exit()
            Return
        End If
        'choose restaurent
        Dim imglist As New ImageList
        imglist.ColorDepth = ColorDepth.Depth32Bit
        imglist.ImageSize = New Size(48, 48)

        Dim file As New IO.FileInfo("Images\qlnh\res.png")
        If file.Exists Then
            imglist.Images.Add("res", Image.FromFile("Images\qlnh\res.png"))
        End If

        fChooseRes.listRes.SmallImageList = imglist
        fChooseRes.listRes.LargeImageList = imglist
        Dim dtres As DataTable = conn.GetDatatable("select * from res_dmres where trang_thai=1")
        For Each r As DataRow In dtres.Rows
            Dim item As New ListViewItem
            item.Name = r("ma_res")
            If conn.Lang = Clsql.SQL.Language.Vietnamese Then
                item.Text = r("ten_res")
            Else
                item.Text = r("ten_res2")
            End If
            item.ImageIndex = 0
            fChooseRes.listRes.Items.Add(item)

        Next
        If fChooseRes.ShowDialog <> DialogResult.OK Or fChooseRes.listRes.SelectedItems.Count = 0 Then
            Return
        End If
        stt_rec = New ClsVno.SttRec(conn, ma_ct)
        ma_res = fChooseRes.listRes.SelectedItems(0).Name
        
        mainform.ShowDialog()
    End Sub
    
    Public Sub refreshTable(ByVal tb As StpPan.ResItemTable)
        Dim status As Integer = conn.GetValue("select status from res_dmban where ma_ban ='" & tb.Name & "'")
        tb.Status = status
        If tb.Status = 2 Then
            Dim dt As DataTable = conn.GetDatatable("select t_phai_thu,t_so_luong from mpbl where stt_rec ='" & tb.stt_rec & "'")
            Dim t_sl As Double = 0
            Dim t_phai_thu As Double = 0
            If dt.Rows.Count > 0 Then
                t_sl = dt.Rows(0)("t_so_luong")
                t_phai_thu = dt.Rows(0)("t_phai_thu")
            End If
            tb.setMessage("SL: " & Strings.FormatNumber(t_sl, 0) & "; PT: " & Strings.FormatNumber(t_phai_thu, 0))
        End If
    End Sub

    Public Sub table_click(ByVal tb As StpPan.ResItemTable)
        Dim status As Integer = tb.Status
        Select Case status
            Case 0 'mo ban moi
                Dim f As New formOpenTable
                f.Icon = mainform.Icon
                If f.ShowDialog() = DialogResult.OK Then
                    tb.Status = 2
                    tb.ma_nv_phuc_vu = f.txtma_nv.Text
                    tb.so_khach = f.txtso_kh.Value
                    tb.stt_rec = stt_rec.GetNextSttRec()
                    stt_rec.UpdateSttRec()
                    conn.Execute("update res_dmban set status = 2,so_khach=" & tb.so_khach & ",ma_nv ='" & tb.ma_nv_phuc_vu & "',stt_rec ='" & tb.stt_rec & "' where ma_ban ='" & tb.Name & "'")
                    Dim op As New formMTable
                    op.Icon = mainform.Icon
                    op.tb = tb
                    refreshTable(tb)
                    op.ShowDialog()
                End If
                Exit Select
            Case 1 'mo ban da dat truoc
                Dim f As New formPreOrder
                f.Icon = mainform.Icon
                If f.ShowDialog() = DialogResult.OK Then
                    tb.ma_nv_phuc_vu = f.txtma_nv.Text
                    tb.so_khach = f.txtso_kh.Value
                    tb.Status = 2
                    tb.stt_rec = stt_rec.GetNextSttRec()
                    stt_rec.UpdateSttRec()
                    conn.Execute("update res_dmban set status = 2,so_khach=" & tb.so_khach & ",ma_nv ='" & tb.ma_nv_phuc_vu & "',stt_rec ='" & tb.stt_rec & "' where ma_ban ='" & tb.Name & "'")
                    Dim op As New formMTable
                    op.Icon = mainform.Icon
                    op.tb = tb
                    refreshTable(tb)
                    op.ShowDialog()
                End If
                Exit Select
            Case 2 'xem ban dang co khach
                Dim f As New formMTable
                f.Icon = mainform.Icon
                f.tb = tb
                f.ShowDialog()
                Exit Select
        End Select
    End Sub
End Module
