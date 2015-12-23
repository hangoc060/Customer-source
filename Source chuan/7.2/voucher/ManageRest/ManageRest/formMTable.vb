Public Class formMTable
    Public detail As DataTable
    Public master As DataTable
    Public tb As StpPan.ResItemTable
    Private Sub resetTable()
        tb.ma_nv_phuc_vu = ""
        tb.stt_rec = ""
        tb.so_khach = 0
        tb.Status = 0
        conn.Execute("update res_dmban set status = 0,stt_rec='',ma_nv ='',so_khach=0 where ma_ban ='" & tb.Name & "'")
    End Sub
    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub
    Dim load_yn As Boolean = False
    Private Sub loadItemForList(ByVal list As ListView, ByVal nh_vt1 As String)
        list.Clear()
        Dim imglist As New ImageList
        imglist.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        imglist.ImageSize = New Size(64, 64)
        Dim imageindex As Integer = -1
        If IO.File.Exists(Application.StartupPath & "\images\no_img.gif") Then
            imageindex = 0
            imglist.Images.Add(Image.FromFile(Application.StartupPath & "\images\no_img.gif"))
        End If

        For Each r As DataRow In dtvt.Select("nh_vt1='" & nh_vt1 & "'")
            Dim item As New ListViewItem(r("ten_vt").ToString)
            item.Name = r("ma_vt")
            item.Tag = r("gia_ban_le")
            If Not IsDBNull(r.Item("Image")) Then
                imageindex += 1
                imglist.Images.Add(Clsql.Data.GetImageFromDB(r("Image")))
                item.ImageIndex = imageindex
            Else
                item.ImageIndex = 0
            End If
            list.Items.Add(item)
        Next
        list.View = View.LargeIcon
        list.LargeImageList = imglist
    End Sub
    Sub createTab()
        TabControl1.TabPages.Clear()
        If nh_vt1s Is Nothing Then
            nh_vt1s = conn.GetDatatable("select ma_nhom,ten_nhom from dmnhomvt where trang_thai=1 and loai_nhom=1 and ma_nhom in (select nh_vt1 from dmvt where trang_thai =1 and loai_vt in ('HH','TP'))")
        End If
        Dim tab As TabPage
        Dim listview As ListView
        'da phan nhom
        For Each r As DataRow In nh_vt1s.Rows
            tab = New TabPage(r("ten_nhom"))
            tab.Name = r("ma_nhom")
            TabControl1.TabPages.Add(tab)
            listview = New ListView
            listview.Dock = DockStyle.Fill
            tab.Controls.Add(listview)
            loadItemForList(listview, r("ma_nhom"))
            AddHandler listview.Click, AddressOf ds_mon_an_Click
        Next
        'chua phan nhom
        tab = New TabPage("Chưa phân nhóm")
        tab.Name = ""
        TabControl1.TabPages.Add(tab)
        listview = New ListView
        listview.Dock = DockStyle.Fill
        tab.Controls.Add(listview)
        loadItemForList(listview, "")
        AddHandler listview.Click, AddressOf ds_mon_an_Click
    End Sub
    Private Sub formMTable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Bàn:" & tb.Title & "-" & tb.Name
        If info_may_ban_le Is Nothing Then
            info_may_ban_le = conn.GetDatatable("select * from dmmaybanle where ma_may='" & ma_may_ban_le & "'").Rows(0)
        End If

        Dim ma_qct As String = Clsql.Others.Options("qct_bl", conn)
        If ma_qct = "" Then
            ma_qct = ma_ct
        End If
        Clsql.Reg.SetValue("QCT" & ma_ct, ma_qct)

        '
        If cprint Is Nothing Then
            Dim fprint As New frmPrint
            ClsControl2.PropertyOfForm.SetLable(olan, fprint)
            cprint = New ClPrint.Print(conn, ma_ct, fprint.cbbmau, fprint.txttieu_de)
        End If
        'load ds mon an
        If dtvt Is Nothing Then
            dtvt = conn.GetDatatable("select * from dmvt where trang_thai =1 and loai_vt in ('HH','TP')")
        End If
        'create tab
        createTab()
        'open table
        master = conn.GetDatatable("select * from vmpbl where stt_rec ='" & tb.stt_rec & "'")
        If master.Rows.Count = 0 Then
            Dim r As DataRow = master.NewRow
            r.Item("stt_rec") = tb.stt_rec
            r.Item("ma_dvcs") = Clsql.Reg.GetValue("unit")
            r.Item("so_ct") = "#"
            r.Item("ngay_ct") = conn.Server.GetDate
            r.Item("ngay_tao") = conn.Server.GetDate
            r.Item("nguoi_tao") = Clsql.Reg.GetValue("id")
            r.Item("ty_gia") = 1
            r.Item("ma_nt") = "VND"
            r.Item("status") = 0
            r.Item("ma_ct") = ma_ct

            r.Item("tk_giam_gia") = info_may_ban_le.Item("tk_giam_gia")
            r.Item("tk_chiet_khau") = info_may_ban_le.Item("tk_ck")

            r.Item("tk_giam_gia") = info_may_ban_le.Item("tk_giam_gia")
            r.Item("ma_ca") = so_ca
            r.Item("ma_may") = ma_may_ban_le

            r.Item("ma_nv") = conn.GetValue("select ma_nv from dmnsd where id='" & Clsql.Reg.GetValue("ID") & "'")
            r.Item("ma_nv_phuc_vu") = tb.ma_nv_phuc_vu
            r.Item("ma_ban") = tb.Name
            r.Item("ty_le_ck_hd") = 0
            r.Item("t_tien_ck_hd") = 0
            r.Item("t_hoa_don") = 0
            r.Item("t_phai_thu") = 0
            r.Item("so_khach") = tb.so_khach
            master.Rows.Add(r)
            conn.WriteToServer(master, "mpbl")
        End If


        detail = conn.GetDatatable("select cast(null as varbinary(MAX)) as col_del,* from vdpbl where stt_rec ='" & tb.stt_rec & "'")

        Dim converter As New ImageConverter
        img_del = converter.ConvertTo(ImageList1.Images(0), GetType(Byte()))

        For Each rs As DataRow In detail.Rows
            rs.Item("col_del") = img_del
        Next
        ClsControl2.PropertyOfGrid.FillGrid(conn, "res_dpbl", gridInvoice, detail.DefaultView)

        txtt_hoa_don.Value = master.Rows(0)("t_hoa_don")
        txtt_tien_ck_hd.Value = master.Rows(0)("t_tien_ck_hd")
        txtty_le_ck_hd.Value = master.Rows(0)("ty_le_ck_hd")
        lbltong_tien.Text = Strings.FormatNumber(master.Rows(0)("t_phai_thu"), 0)

        load_yn = True
    End Sub

    Dim img_del As Byte()
    Private Sub btnthanh_toan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnthanh_toan.Click
        If detail.Rows.Count = 0 Then
            MsgBox("Hóa đơn trống", MsgBoxStyle.Critical, Clsql.AboutMe.Name)
            Return
        End If
        Dim so_ct As String = stt_rec.GetNextSoCt("mpbl", True)
        master.Rows(0).Item("so_ct") = so_ct
        'update master
        conn.Execute("update mpbl set so_ct ='" & so_ct & "',status = '5',hinh_thuc_tt ='TM' where stt_rec ='" & tb.stt_rec & "'")
        'insert detail
        Dim line As Integer = 0
        For Each r As DataRow In detail.Rows
            If r.RowState <> DataRowState.Deleted Then
                r.Item("line") = line
                For Each col As DataColumn In master.Columns
                    If detail.Columns.Contains(col.ColumnName) Then
                        r(col.ColumnName) = master.Rows(0).Item(col.ColumnName)
                    End If
                Next
            End If
        Next
        Dim query As String = "delete from dpbl where stt_rec ='" & tb.stt_rec & "'"
        query = query & Chr(13) & conn.GetInsertQueryFromDatatable(detail, "dpbl")
        conn.Execute(query)
        'post
        ClsSV31.Functions.Post(conn, ma_ct, "mpbl", tb.stt_rec, 5)
        'print
        If MsgBox("Bạn có muốn in phiếu tính tiền không?", MsgBoxStyle.YesNo, Clsql.AboutMe.Name) = MsgBoxResult.Yes Then
            Dim t As New Threading.Thread(AddressOf inHoaDon)
            t.Start()
        Else
            resetTable()
        End If
        Me.Close()
    End Sub

    Private Sub ds_mon_an_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        If sender.SelectedItems.Count > 0 Then
            Dim r As DataRow
            Dim q = From rs As DataRow In detail.Rows Where rs.Item("ma_vt") = sender.SelectedItems(0).Name
            If q.Count = 0 Then

                r = detail.NewRow
                r.Item("stt_rec") = tb.stt_rec
                r.Item("ma_vt") = sender.SelectedItems(0).Name
                r.Item("ten_vt") = sender.SelectedItems(0).Text

                r.Item("sl_xuat") = 1
                r.Item("line") = detail.Rows.Count
                r.Item("ty_gia") = 1
                r.Item("ma_nt") = "VND"
                r.Item("col_del") = img_del
                r.Item("px_gia_dd") = False

                Dim sp As DataRow = conn.GetDatatable("select * from dmvt where ma_vt='" & r.Item("ma_vt") & "'").Rows(0)

                r.Item("ma_dvt") = sp("ma_dvt")
                r.Item("ma_kho") = info_may_ban_le.Item("ma_kho")
                r.Item("ty_le_ck") = 0
                r.Item("tien_giam") = 0
                r.Item("tien") = 0
                r.Item("tien_thue") = 0
                r.Item("tien_ck") = 0
                r.Item("sp_km_of") = ""

                r.Item("tk_dt") = sp("tk_dt")
                If r.Item("tk_dt") = "" Then
                    r.Item("tk_dt") = info_may_ban_le.Item("tk_dt")
                End If

                r.Item("tk_no") = info_may_ban_le.Item("tk_tien_mat")

                r.Item("tk_ck") = sp("tk_ck")
                If r.Item("tk_ck") = "" Then
                    r.Item("tk_ck") = info_may_ban_le.Item("tk_ck")
                End If




                r.Item("tk_vt") = sp("tk_vt")

                r.Item("tk_gv") = sp("tk_gv")
                If r.Item("tk_gv") = "" Then
                    r.Item("tk_gv") = info_may_ban_le.Item("tk_gv")
                End If

                If sp("ma_thue") <> "" Then
                    Dim thue As DataRow = conn.GetDatatable("select * from dvat where ma_thue ='" & sp("ma_thue") & "'").Rows(0)
                    r.Item("ma_thue") = sp("ma_thue")
                    r.Item("thue_suat") = thue("thue_suat")
                    r.Item("tk_thue_co") = thue("tk_thue_co")
                    r.Item("tk_du") = info_may_ban_le.Item("tk_tien_mat")
                Else
                    r.Item("ma_thue") = ""
                    r.Item("thue_suat") = 0
                    r.Item("tk_thue_co") = ""
                    r.Item("tk_du") = ""
                End If


                If sp.Item("gia_chua_thue") = True Then
                    r("gia_ban") = sp.Item("gia_ban_le")
                    r("gia_ban2") = sp.Item("gia_ban_le") * (1 + r("thue_suat") / 100)
                Else
                    r("gia_ban") = Math.Round(sp("gia_ban_le") / (1 + r("thue_suat") / 100), 5) 'tien_nt/(1+thue_suat/100)
                    r("gia_ban2") = sp.Item("gia_ban_le")
                End If

                r("gia_ban_nt") = r.Item("gia_ban")
                r("gia_ban_nt2") = r.Item("gia_ban2")
                detail.Rows.Add(r)
            Else
                r = q(0)
                r.Item("sl_xuat") += 1
            End If
            tinhlaitienvaluu(r)

            For Each rg As DataGridViewRow In gridInvoice.Rows
                If rg.Cells("ma_vt").Value = r("ma_vt") Then
                    rg.Selected = True
                    gridInvoice.CurrentCell = rg.Cells("ten_vt")
                End If
            Next
        End If
    End Sub

    Private Sub gridInvoice_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridInvoice.CellClick
        If gridInvoice.Columns(e.ColumnIndex).Name = "col_del" Then
            If MsgBox("Có chắc chắn xóa dòng này không?", MsgBoxStyle.YesNo, Clsql.AboutMe.Name) = MsgBoxResult.Yes Then
                Dim query As String = "delete from dpbl where stt_rec ='" & tb.stt_rec & "' and ma_vt ='" & gridInvoice.Rows(e.RowIndex).Cells("ma_vt").Value & "'"
                conn.Execute(query)
                detail.Rows.Remove(gridInvoice.Rows(e.RowIndex).DataBoundItem.row)
                tinhtongtien()
                If detail.Rows.Count > 0 Then
                    gridInvoice.Rows(gridInvoice.Rows.Count - 1).Selected = True
                    gridInvoice.CurrentCell = gridInvoice.Rows(gridInvoice.Rows.Count - 1).Cells("ten_vt")
                End If
            End If
            
        End If
    End Sub

    Private Sub gridInvoice_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridInvoice.CellEnter
        txtso_luong.Value = gridInvoice.CurrentRow.Cells("sl_xuat").Value
        txtso_luong.Tag = gridInvoice.CurrentRow.Cells("ma_vt").Value
    End Sub

    Sub tinhlaitienvaluu(ByVal DataRow As DataRow)
        Dim del_query As String = "delete from dpbl where stt_rec ='" & tb.stt_rec & "' and ma_vt ='" & DataRow.Item("ma_vt") & "'"
        conn.Execute(del_query)
        If DataRow("sl_xuat") = 0 Then
            detail.Rows.Remove(DataRow)
            tinhtongtien()
            Return
        End If
        DataRow("tien2") = Math.Round(DataRow("sl_xuat") * DataRow("gia_ban2"), 0)
        DataRow("tien_nt2") = DataRow("tien2")

        DataRow("tien1") = Math.Round(DataRow("sl_xuat") * DataRow("gia_ban"), 0)
        DataRow("tien_nt1") = DataRow("tien1")


        'chiet khau
        If DataRow("ty_le_ck") <> 0 Then
            DataRow("tien_ck") = Math.Round(DataRow("tien2") * DataRow("ty_le_ck") / 100, 0)
            DataRow("tien_ck_ct") = Math.Round(DataRow("tien1") * DataRow("ty_le_ck") / 100, 0)
        Else
            DataRow("tien_ck") = DataRow("tien_giam")
            DataRow("tien_ck_ct") = Math.Round(DataRow("tien_ck") / (1 + DataRow("thue_suat") / 100), 0)
        End If

        DataRow("tien_ck_nt") = DataRow("tien_ck")
        DataRow("tien_ck_ct_nt") = DataRow("tien_ck_ct")
        'thue
        DataRow("tien") = Math.Round(DataRow("tien1") - DataRow("tien_ck_ct"), 0)
        DataRow("tien_nt") = DataRow("tien")


        DataRow("tien_thue") = Math.Round(DataRow("tien") * DataRow("thue_suat") / 100, 0)
        DataRow("tien_thue_nt") = DataRow("tien_thue")

        'tien phai thu
        DataRow("t_hd") = DataRow("tien2") - DataRow("tien_ck")
        DataRow("t_hd_nt") = DataRow("tien_nt2") - DataRow("tien_ck_nt")

        DataRow.AcceptChanges()

        tinhtongtien()
        'save to database
        Dim query As String = conn.GetInsertQueryFromDataRow(DataRow, "dpbl")
        conn.Execute(query)
        ''
    End Sub
    Sub tinhtongtien()
        Dim t_hoa_don As Decimal = ClsControl2.PropertyOfGrid.Sum(gridInvoice, "tien2")
        txtt_hoa_don.Value = t_hoa_don

        If txtty_le_ck_hd.Value <> 0 Then
            txtt_tien_ck_hd.Value = t_hoa_don * txtty_le_ck_hd.Value / 100
        End If
        Dim t_phai_thu As Decimal = t_hoa_don - txtt_tien_ck_hd.Value

        Dim t_sl As Decimal = ClsControl2.PropertyOfGrid.Sum(gridInvoice, "sl_xuat")
        master.Rows(0).Item("t_so_luong") = t_sl

        lbltong_tien.Text = Strings.FormatNumber(t_phai_thu, 0)
        master.Rows(0).Item("t_hoa_don") = t_hoa_don
        master.Rows(0).Item("t_phai_thu") = t_phai_thu
        master.Rows(0).Item("ty_le_ck_hd") = txtty_le_ck_hd.Value
        conn.Execute("update mpbl set t_so_luong =" & t_sl & ", t_hoa_don =" & t_hoa_don & ",t_phai_thu=" & t_phai_thu & ",ty_le_ck_hd =" & txtty_le_ck_hd.Value & ",t_tien_ck_hd =" & txtt_tien_ck_hd.Value & " where stt_rec='" & tb.stt_rec & "'")
        Main.refreshTable(tb)
    End Sub
    Private Sub btplus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btbplus.Click
        If gridInvoice.CurrentRow IsNot Nothing Then
            txtso_luong.Value += 1
            Dim r As DataRow = gridInvoice.CurrentRow.DataBoundItem.row
            r("sl_xuat") = txtso_luong.Value
            tinhlaitienvaluu(r)
        End If
    End Sub

    Private Sub btnminus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubtract.Click
        If gridInvoice.CurrentRow IsNot Nothing AndAlso txtso_luong.Value > 0 Then
            txtso_luong.Value -= 1
            Dim r As DataRow = gridInvoice.CurrentRow.DataBoundItem.row
            r("sl_xuat") = txtso_luong.Value
            tinhlaitienvaluu(r)
        End If
    End Sub

    Private Sub txtty_le_ck_hd_ValueChanged() Handles txtty_le_ck_hd.TextChanged
        If load_yn = False Or txtty_le_ck_hd.Focused = False Then
            Return
        End If

        txtt_tien_ck_hd.Value = txtty_le_ck_hd.Value * txtt_hoa_don.Value / 100
        tinhtongtien()
    End Sub


    Private Sub txtt_tien_ck_hd_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtt_tien_ck_hd.TextChanged
        If load_yn = False Then
            Return
        End If
        If txtt_tien_ck_hd.Focused Then
            txtty_le_ck_hd.Value = 0
            tinhtongtien()
        End If
        
    End Sub
    Private Sub inHoaDon()
        'in
        Try
            tb.setMessage("Printing...")
            Dim query As String = cprint.Store & " '" & tb.stt_rec & "'"
            Dim ds As DataSet = conn.GetDataSet(query)
            ds.Tables(0).TableName = "master"
            ds.Tables(1).TableName = "detail"
            cprint.Dataset = ds
            cprint.Print()
            'reset status
            resetTable()
        Catch ex As Exception
            MsgBox("Đã có lỗi khi in phiếu bán lẻ này. Kiểm tra file log trên server để biết lỗi", MsgBoxStyle.Exclamation, Me.Text)
            conn.Server.writeLog("Print PBL at " & Now.ToString & Chr(13) & ex.ToString, "error")
        End Try
    End Sub

    Private Sub btntra_ban_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntra_ban.Click
        If MsgBox("Có chắc chắn trả bàn này không?", MsgBoxStyle.YesNo, Clsql.AboutMe.Name) = MsgBoxResult.Yes Then
            Dim query As String = "delete from dpbl where stt_rec ='" & tb.stt_rec & "'"
            query = query & Chr(13) & "delete from mpbl where stt_rec ='" & tb.stt_rec & "'"
            conn.Execute(query)
            resetTable()
            Me.Close()
        End If
    End Sub

    Private Sub btndoi_ban_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndoi_ban.Click
        Dim db As New Form1
        db.doiban_yn = True
        If db.ShowDialog() = Windows.Forms.DialogResult.OK Then
            db.ban_doi.stt_rec = tb.stt_rec
            db.ban_doi.so_khach = tb.so_khach
            db.ban_doi.ma_nv_phuc_vu = tb.ma_nv_phuc_vu
            db.ban_doi.Status = tb.Status
            resetTable()
            tb = Nothing
            For Each c As Object In mainform.PanelTable.Controls
                If c.Name = db.ban_doi.Name Then
                    tb = c
                    Exit For
                End If
            Next
            If tb IsNot Nothing Then
                tb.stt_rec = db.ban_doi.stt_rec
                tb.so_khach = db.ban_doi.so_khach
                tb.ma_nv_phuc_vu = db.ban_doi.ma_nv_phuc_vu
                tb.Status = db.ban_doi.Status
            Else
                tb = db.ban_doi
            End If
            conn.Execute("update res_dmban set status = 2,so_khach=" & tb.so_khach & ",ma_nv ='" & tb.ma_nv_phuc_vu & "',stt_rec ='" & tb.stt_rec & "' where ma_ban ='" & tb.Name & "'")
            conn.Execute("update mpbl set ma_ban ='" & tb.Name & "' where stt_rec ='" & tb.stt_rec & "'")
            Me.Text = "Bàn:" & tb.Title & "-" & tb.Name
            Main.refreshTable(tb)
        End If

    End Sub

   
End Class