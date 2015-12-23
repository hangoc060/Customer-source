Imports ClsStpService

Public Class frmMain

    'Dim ma_khLookup As ClsLookup.AutoCompleteLookup
    'Dim ma_vtLookup As ClsLookup.AutoCompleteLookup
    Dim dataDetail As DataTable
    Dim dataDetailTmp As DataTable
    Dim dataMaster As DataTable
    Dim dataThegiamgia As DataTable
    Dim dataMasterTmp As DataTable
    Dim currentMaster As DataRow
    Dim hd_count As Integer = 0
    Dim stt_rec As Integer = 0
    Dim s_stt_rec As String = ""
    Dim info_may_ban_le As DataRow
    Dim mastertable As String = "mpbl"
    Dim detailtable As String = "dpbl"
    Dim giamgiatable As String = "ctgiamgia"
    Dim fprint As frmPrint
    Dim cprint As ClPrint.Print
    Dim vno As ClsVno.SttRec
    Dim WithEvents timer_ngay_gio As New Timer
    Public Enum buoc
        HOA_DON_MOI
        NHAP_MA_KH
        NHAP_MA_VT
        SO_LUONG
        SUA_GIA_BAN
        SUA_TL_CK
        THANH_TOAN
        TIEN_MAT
        TRA_SAU
        HOAN_THANH
        CHIET_KHAU
        LUU_PHIEU

    End Enum
    Public current_b As buoc = buoc.HOA_DON_MOI
    Public pre_b As buoc = buoc.HOA_DON_MOI
    Public b_sua_tl_ck As Boolean = False
    Public lookups As New Dictionary(Of String, ClsLookup.AutoCompleteLookup)
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If saved = False AndAlso gridsanpham.Rows.Count > 0 Then
            If MsgBox(olan("800"), MsgBoxStyle.YesNo, Clsql.AboutMe.Name) = MsgBoxResult.Yes Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If



        End If
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.E Then
            btnexit.PerformClick()
            Return
        End If
        If e.KeyCode = Keys.Up AndAlso gridsanpham.Rows.Count > 0 Then
            gridsanpham.Focus()
            Return
        End If

        If (gridsanpham.Focused AndAlso e.KeyCode = Keys.Enter) _
        Or (e.KeyCode = Keys.Down AndAlso gridsanpham.Focused AndAlso gridsanpham.CurrentRow.Index = gridsanpham.Rows.Count - 1) Then
            If txtma_vt.Visible Then
                txtma_vt.Focus()
            End If
            If txtMa_kh.Visible Then
                txtMa_kh.Focus()
            End If
            If txtSo_luong.Visible Then
                txtSo_luong.Focus()
            End If
            If txttien.Visible Then
                txttien.Focus()
            End If
            Return
        End If
        'save and in nhanh
        If current_b = buoc.NHAP_MA_VT AndAlso e.Control AndAlso (e.KeyCode = Keys.S OrElse e.KeyCode = Keys.N OrElse e.KeyCode = Keys.P) Then
            tinhchietkhautheohoadon()
            txttien.Visible = True
            txttien.Value = txtt_phai_thu.Value
            thanhtoantienmat()
            setBuoc(buoc.LUU_PHIEU)
            current_b = buoc.HOAN_THANH
            If e.KeyCode = Keys.S Then
                Dim t As New Threading.Thread(AddressOf inHoaDon)
                t.Start()
                Return
            End If

            If e.KeyCode = Keys.P Then
                'chon mau in 
                xemphieu()
                Return
            End If
            Return
        End If



        Select Case e.KeyCode
            Case Keys.Escape
                btnBack.PerformClick()
                Exit Select
            Case Keys.F2
                btnF2.PerformClick()
                Exit Select
            Case Keys.F3
                btnF3.PerformClick()
                Exit Select
            Case Keys.F4
                btnF4.PerformClick()
                Exit Select
            Case Keys.F5
                btnF5.PerformClick()
                Exit Select
            Case Keys.F6
                btnF6.PerformClick()
                Exit Select
            Case Keys.F7
                btnF7.PerformClick()
                Exit Select
            Case Keys.F8
                btnF8.PerformClick()
                Exit Select
            Case Keys.F9
                btnF9.PerformClick()
                Exit Select
            Case Keys.F10
                btnF10.PerformClick()
                Exit Select
            Case Keys.F12
                btnmanager.PerformClick()
                Exit Select
        End Select
    End Sub
    Public Sub setup()
        ClsControl2.PropertyOfForm.KeyEnter(Me)
        txtuser.Text = Clsql.Reg.GetValue("ID")
        txtserver.Text = conn.IP
        txtten_chuong_trinh.Text = Clsql.AboutMe.Name
        txtstatus.Text = ""
        txtdatabase.Text = conn.database
        olan = ClsControl2.PropertyOfForm.SetLable(conn, Me, ma_ct)
        ClsControl2.PropertyOfForm.SetLable(olan, Me)
        Me.Icon = fchonca.Icon
        lookups = ClsControl2.PropertyOfForm.Lookups(conn, Me, "PBL")
        'lookup
        'ma_khLookup = New ClsLookup.AutoCompleteLookup(conn, "dmkh", txtMa_kh, "ma_kh", False)
        'ma_khLookup.Height_Max_Suggest = 200
        lookups.Item("txtma_kh").Height_Max_Suggest = 200
        AddHandler lookups.Item("txtma_kh").AfterLookup, AddressOf addKhachHang

        'ma_vtLookup = New ClsLookup.AutoCompleteLookup(conn, "dmvt", txtma_vt, "ma_vt", False)
        'ma_vtLookup.Height_Max_Suggest = 200
        lookups.Item("txtma_vt").Height_Max_Suggest = 200
        AddHandler lookups.Item("txtma_vt").AfterLookup, AddressOf addHangHoa
        AddHandler lookups.Item("txtma_vt").BeforeValid, AddressOf SanPhamBanTheoKy
        'grid
        dataDetail = conn.GetDatatable("select *,cast('' as varchar(32)) as sort from vdpbl where 1=0")
        dataDetailTmp = conn.GetDatatable("select *,cast('' as varchar(32)) as sort from vdpbl where 1=0")

        dataMaster = conn.GetDatatable("select * from vmpbl where 1=0")
        dataMasterTmp = conn.GetDatatable("select * from vmpbl where 1=0")

        dataThegiamgia = conn.GetDatatable("select * from ctgiamgia where 1=0")

        ClsControl2.PropertyOfGrid.FillGrid(conn, "dpbl", gridsanpham, dataDetail.DefaultView)
        For Each c As DataGridViewColumn In gridsanpham.Columns
            If c.Name = "sort" Then
                c.SortMode = DataGridViewColumnSortMode.Automatic
            Else
                c.SortMode = DataGridViewColumnSortMode.NotSortable
            End If

        Next

        'thong tin may ban le
        info_may_ban_le = conn.GetDatatable("select * from dmmaybanle where ma_may='" & ma_may_ban_le & "'").Rows(0)
        lblquay_so.Text = olan("004") & " " & info_may_ban_le.Item("ma_may")
        'print
        fprint = New frmPrint
        ClsControl2.PropertyOfForm.SetLable(olan, fprint)
        cprint = New ClPrint.Print(conn, ma_ct, fprint.cbbmau, fprint.txttieu_de)
        '
        Dim ma_qct As String = Clsql.Others.Options("qct_bl", conn)
        If ma_qct = "" Then
            ma_qct = ma_ct
        End If
        Clsql.Reg.SetValue("QCT" & ma_ct, ma_qct)

        vno = New ClsVno.SttRec(conn, ma_ct)

        setBuoc(buoc.HOA_DON_MOI)
        ClsControl2.PropertyOfForm.SetImage4PictureBox("splashscreen.png", logo, PictureBoxSizeMode.Zoom)
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblngay.Text = Strings.Format(Now(), "dd/MM/yyyy")
        lblgio.Text = Strings.Format(Now(), "hh:mm:ss")
        timer_ngay_gio.Interval = 1000
        timer_ngay_gio.Enabled = True


        '
        Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Public Sub setBuoc(ByVal b As buoc)
        Me.keyPanel.BackColor = Color.Green  'System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        For Each ctr As Control In functuionPanel.Controls
            If ctr.Name <> btnexit.Name AndAlso ctr.Name <> btnmanager.Name Then
                ctr.Text = ""
                ctr.Enabled = False
            End If

        Next

        txtMa_kh.Enabled = False
        txtMa_kh.Visible = False

        txtma_vt.Enabled = False
        txtma_vt.Visible = False

        txtSo_luong.Enabled = False
        txtSo_luong.Visible = False

        txttien.Enabled = False
        txttien.Visible = False

        txtma_so_ck.Enabled = False
        txtma_so_ck.Visible = False

        txtgia_ban.Enabled = False
        txtgia_ban.Visible = False

        Select Case b
            Case buoc.HOA_DON_MOI
                If Me.current_b <> b Then
                    pre_b = Me.current_b
                    Me.current_b = b
                End If

                lblma_kh.Text = ""
                lblten_kh.Text = ""

                txtt_hoa_don.Value = 0
                txtt_so_luong.Value = 0
                txtt_giam_gia.Value = 0
                txtt_phai_thu.Value = 0
                txtt_thu.Value = 0
                txtt_tra_lai.Value = 0
                txtt_tien_ck_hd.Value = 0

                txttien.Value = 0
                txtSo_luong.Value = 1

                txtMa_kh.Text = ""
                txtma_vt.Text = ""
                txtma_so_ck.Text = ""

                addHoaDonMoi()
                setBuoc(buoc.NHAP_MA_KH)
                If Clsql.Others.Options("show_ma_kh", conn) = "0" Then
                    setBuoc(buoc.NHAP_MA_VT)
                End If
                Exit Select
            Case buoc.NHAP_MA_KH
                If Me.current_b <> b Then
                    pre_b = Me.current_b
                    Me.current_b = b
                End If

                txtMa_kh.Enabled = True
                txtMa_kh.Visible = True
                txtMa_kh.Focus()
                txtMa_kh.Text = ""


                lblfunction.Text = olan("500") ' "Nhập mã khách hàng"



                btnF2.Text = olan("502") '"Tìm khách hàng"
                btnF2.Enabled = True

                btnF3.Text = olan("503") '"Khôi phục HĐ"
                btnF3.Enabled = True

                btnF4.Text = olan("504") '"Bỏ qua"
                btnF4.Enabled = True

                btnBack.Text = olan("501") '"Quay lại"
                btnBack.Enabled = (current_b <> pre_b AndAlso pre_b <> buoc.HOA_DON_MOI)
                Exit Select
            Case buoc.NHAP_MA_VT
                If Me.current_b <> b Then
                    pre_b = Me.current_b
                    Me.current_b = b
                End If

                txtma_vt.Text = ""

                txtma_vt.Visible = True
                txtma_vt.Enabled = True
                txtma_vt.Focus()


                lblfunction.Text = olan("505") '"Nhập mã hàng hóa"



                btnF2.Text = olan("506") '"Tìm hàng hóa"
                btnF2.Enabled = True

                btnF3.Text = olan("507") '"Số lượng"
                btnF3.Enabled = True

                btnF4.Text = olan("508") '"Xóa hàng"
                btnF4.Enabled = True

                If checkright.Right("SG") Then
                    btnF5.Text = olan("530") '"Sửa giá bán"
                    btnF5.Enabled = True
                End If


                btnF6.Text = olan("509") '"Thẻ giảm giá"
                btnF6.Enabled = True

                btnF7.Text = olan("510") '"Thoát tạm"
                btnF7.Enabled = True

                btnF8.Text = olan("511") ' "Nhập mã khách"
                btnF8.Enabled = True

                btnF9.Text = olan("512") '"Thanh toán"
                btnF9.Enabled = True


                If checkright.Right("SCK") Then
                    btnF10.Text = olan("Z02") '"Sửa tỷ lệ CK"
                    btnF10.Enabled = True
                End If

                btnBack.Text = olan("501") '"Quay lại"
                btnBack.Enabled = (current_b <> pre_b AndAlso pre_b <> buoc.HOA_DON_MOI)
                Exit Select
            Case buoc.SO_LUONG
                Me.keyPanel.BackColor = Color.Gray
                pre_b = buoc.NHAP_MA_VT

                txtSo_luong.Visible = True
                txtSo_luong.Enabled = True
                txtSo_luong.Focus()


                lblfunction.Text = olan("513") '"Cập nhật số lượng"



                btnF9.Text = olan("512") '"Thanh toán"
                btnF9.Enabled = True
                btnBack.Text = olan("501") '"Quay lại"
                btnBack.Enabled = True
                Exit Select
            Case buoc.SUA_GIA_BAN
                Me.keyPanel.BackColor = Color.Red
                pre_b = buoc.NHAP_MA_VT

                If gridsanpham.CurrentRow.Cells("gia_chua_gom_vat").Value = True Then
                    txtgia_ban.Value = gridsanpham.CurrentRow.Cells("gia_ban").Value
                Else
                    txtgia_ban.Value = gridsanpham.CurrentRow.Cells("gia_ban2").Value
                End If


                txtgia_ban.Enabled = True
                txtgia_ban.Visible = True
                txtgia_ban.Focus()
                lblfunction.Text = olan("530") '"Sua gia ban"



                btnF9.Text = olan("512") '"Thanh toán"
                btnF9.Enabled = True
                btnBack.Text = olan("501") '"Quay lại"
                btnBack.Enabled = True
                Exit Select
            Case buoc.SUA_TL_CK
                Me.keyPanel.BackColor = Color.Chocolate
                pre_b = buoc.NHAP_MA_VT
                b_sua_tl_ck = True
                txtgia_ban.Value = gridsanpham.CurrentRow.Cells("ty_le_ck").Value

                txtgia_ban.Enabled = True
                txtgia_ban.Visible = True
                txtgia_ban.Focus()
                lblfunction.Text = olan("Z02") '"Sua gia ban"



                btnF9.Text = olan("512") '"Thanh toán"
                btnF9.Enabled = True
                btnBack.Text = olan("501") '"Quay lại"
                btnBack.Enabled = True
                Exit Select
            Case buoc.THANH_TOAN
                If gridsanpham.Rows.Count = 0 Then
                    MsgBox(olan("514"), , Clsql.AboutMe.Name) '("Bạn chưa nhập sản phẩm nào")
                    setBuoc(buoc.NHAP_MA_VT)
                    Return
                End If

                If Me.current_b <> b Then
                    pre_b = Me.current_b
                    Me.current_b = b
                End If

                lblfunction.Text = olan("515") '"Chọn phương thức thanh toán"

                If checkright.Right("TM") Then
                    btnF2.Text = olan("516") '"Tiền mặt"
                    btnF2.Enabled = True
                End If

                If checkright.Right("NH") Then
                    btnF3.Text = olan("517") '"Thẻ Visa/Master"
                    btnF3.Enabled = True
                End If

                If checkright.Right("BC") Then
                    btnF4.Text = olan("518") '"Trả sau"
                    btnF4.Enabled = True
                End If

                btnF5.Text = olan("522") '"Nhập mã sản phẩm"
                btnF5.Enabled = True

                btnF6.Text = olan("509") '"Thẻ giảm giá"
                btnF6.Enabled = True

                btnF7.Text = olan("510") '"Thoát tạm"
                btnF7.Enabled = True

                btnF8.Text = olan("511") ' "Nhập mã khách"
                btnF8.Enabled = True

                btnBack.Text = olan("501") '"Quay lại"
                btnBack.Enabled = (current_b <> pre_b AndAlso pre_b <> buoc.HOA_DON_MOI)
                tinhchietkhautheohoadon()

                If pre_b <> buoc.TIEN_MAT Then
                    Select Case Clsql.Others.Options("pt_tt_def", conn)
                        Case "TM"
                            pre_b = buoc.NHAP_MA_VT
                            btnF2.PerformClick()
                            Exit Select
                        Case "NH"
                            btnF3.PerformClick()
                            Exit Select
                        Case "TS"
                            btnF4.PerformClick()
                            Exit Select
                    End Select
                End If

                Exit Select
            Case buoc.TIEN_MAT
                If Me.current_b <> b Then
                    If pre_b <> buoc.NHAP_MA_VT Then
                        pre_b = Me.current_b
                    End If
                    Me.current_b = b
                End If


                Me.keyPanel.BackColor = Color.Blue

                txttien.Visible = True
                txttien.Enabled = True
                txttien.Focus()


                lblfunction.Text = olan("519") '"Nhập số tiền"



                btnF2.Text = "000"
                btnF2.Enabled = True

                btnF3.Text = "00,000"
                btnF3.Enabled = True

                btnF4.Text = "000,000"
                btnF4.Enabled = True

                btnF5.Text = "0,000,000"
                btnF5.Enabled = True


                btnF6.Text = olan("509") '"Thẻ giảm giá"
                btnF6.Enabled = True

                btnF7.Text = olan("510") '"Thoát tạm"
                btnF7.Enabled = True

                btnF8.Text = olan("511") '"Nhập mã khách"
                btnF8.Enabled = True

                'btnF9.Text = olan("520") '"Lưu phiếu"
                'btnF9.Enabled = True

                btnF10.Text = olan("PTT")
                btnF10.Enabled = True

                btnBack.Text = olan("501") '"Quay lại"
                btnBack.Enabled = (current_b <> pre_b AndAlso pre_b <> buoc.HOA_DON_MOI)
                Exit Select

            Case buoc.CHIET_KHAU

                If Me.current_b <> b Then
                    pre_b = Me.current_b
                    Me.current_b = b
                End If
                Me.keyPanel.BackColor = Color.Chocolate

                lblfunction.Text = olan("521") ' "Nhập mã số Thẻ giảm giá/chiết khấu"

                txtma_so_ck.Enabled = True
                txtma_so_ck.Visible = True
                txtma_so_ck.Focus()



                btnF5.Text = olan("522") '"Nhập mã sản phẩm"
                btnF5.Enabled = True

                btnF9.Text = olan("512") '"Thanh toán"
                btnF9.Enabled = True

                btnBack.Text = olan("501") ' "Quay lại"
                btnBack.Enabled = (current_b <> pre_b AndAlso pre_b <> buoc.HOA_DON_MOI)
                Exit Select
            Case buoc.LUU_PHIEU
                If Me.current_b <> b Then
                    pre_b = Me.current_b
                    Me.current_b = b
                End If

                lblfunction.Text = olan("523") '"In phiếu tính tiền"

                btnF2.Text = olan("524") ' "Phiếu mới"
                btnF2.Enabled = True


                btnF3.Text = olan("503") ' "Khoi phuc hoa don"
                btnF3.Enabled = True

                If checkright.Right("InAn") Then
                    btnF8.Text = olan("525") '"Xem phiếu"
                    btnF8.Enabled = True

                    btnF9.Text = olan("526") '"In phiếu"
                    btnF9.Enabled = True
                End If
                'save
                Try
                    saveHoaDon()
                Catch ex As Exception
                    MsgBox("Không thể lưu phiếu bán lẻ này", MsgBoxStyle.Critical, Me.Text)
                    conn.Server.writeLog("Save PBL at " & Now.ToString & Chr(13) & ex.ToString, "error")
                    Return
                End Try
                Exit Select
            Case buoc.HOAN_THANH


                If Me.current_b <> b Then
                    pre_b = Me.current_b
                    Me.current_b = b
                End If

                lblfunction.Text = olan("523") '"In phiếu tính tiền"

                btnF2.Text = olan("524") ' "Phiếu mới"
                btnF2.Enabled = True

                btnF3.Text = olan("503") ' "Khoi phuc hoa don"
                btnF3.Enabled = True

                If checkright.Right("InAn") Then
                    btnF8.Text = olan("525") '"Xem phiếu"
                    btnF8.Enabled = True

                    btnF9.Text = olan("526") '"In phiếu"
                    btnF9.Enabled = True
                End If
                'save
                Try
                    saveHoaDon()
                Catch ex As Exception
                    MsgBox("Không thể lưu phiếu bán lẻ này", MsgBoxStyle.Critical, Me.Text)
                    conn.Server.writeLog("Save PBL at " & Now.ToString & Chr(13) & ex.ToString, "error")
                    Return
                End Try

                'auto print 
                If Clsql.Others.Options("auto_print_tt", conn) = 1 Then
                    btnF9.PerformClick()
                End If
                'tu dong them phieu moi
                If Clsql.Others.Options("auto_add_new", conn) = 1 Then
                    setBuoc(buoc.HOA_DON_MOI)
                End If
                Exit Select

        End Select
    End Sub
    Dim new_line As Integer = 0
    Private Sub addHoaDonMoi()
        new_line = 0
        btnBack.Enabled = False
        saved = False
        pre_b = buoc.HOA_DON_MOI
        current_b = buoc.HOA_DON_MOI
        hd_count += 1
        stt_rec = hd_count
        dataDetail.Rows.Clear()
        dataThegiamgia.Rows.Clear()
        currentMaster = dataMaster.NewRow()
        currentMaster.Item("stt_rec") = stt_rec
        currentMaster.Item("status") = 0
        currentMaster.Item("ma_nt") = "VND"
        currentMaster.Item("ty_gia") = 1
        currentMaster.Item("ma_ct") = ma_ct
        currentMaster.Item("ngay_ct") = conn.Server.GetDate()
        currentMaster.Item("so_ct") = hd_count
        currentMaster.Item("ma_kh") = ""
        currentMaster.Item("ten_kh") = ""
        currentMaster.Item("ma_dvcs") = Clsql.Reg.GetValue("unit")
        currentMaster.Item("nguoi_tao") = Clsql.Reg.GetValue("ID")
        currentMaster.Item("ngay_tao") = conn.Server.GetDate()
        currentMaster.Item("tk_giam_gia") = info_may_ban_le.Item("tk_giam_gia")
        currentMaster.Item("tk_chiet_khau") = info_may_ban_le.Item("tk_ck")

        currentMaster.Item("tk_giam_gia") = info_may_ban_le.Item("tk_giam_gia")
        currentMaster.Item("ma_ca") = so_ca
        currentMaster.Item("ma_may") = ma_may_ban_le

        currentMaster.Item("ma_nv") = conn.GetValue("select ma_nv from dmnsd where id='" & Clsql.Reg.GetValue("ID") & "'")
        dataMaster.Rows.Add(currentMaster)

    End Sub
    Private Sub khoiphuchoadon()
        Dim f As New formrestore()
        f.Icon = Me.Icon
        ClsControl2.PropertyOfForm.SetLable(olan, f)
        ClsControl2.PropertyOfGrid.FillGrid(conn, "mpbl", f.gridMaster, dataMasterTmp.DefaultView)
        If f.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr As DataGridViewRow = f.gridMaster.CurrentRow
            If dr IsNot Nothing Then
                dataDetail.Rows.Clear()
                dataThegiamgia.Rows.Clear()
                stt_rec = dr.Cells("stt_rec").Value
                For Each r As DataRow In dataMaster.Rows
                    If r.Item("stt_rec") = stt_rec.ToString Then
                        currentMaster = r
                        Clsql.Data.CopyTable(dataDetailTmp, dataDetail, "stt_rec='" & stt_rec & "'")
                        lblma_kh.Text = r.Item("ma_kh")
                        lblten_kh.Text = r.Item("ten_kh")

                        f.gridMaster.Rows.Remove(dr)
                        For Each r_tmp As DataRow In dataDetailTmp.Rows
                            If r_tmp.Item("stt_rec") = stt_rec Then
                                r_tmp.Delete()
                            End If

                        Next
                        'tinh tong cong
                        txtt_so_luong.Value = ClsControl2.PropertyOfGrid.Sum(gridsanpham, "sl_xuat")
                        ''txtt_hoa_don.Value = ClsControl2.PropertyOfGrid.Sum(gridsanpham, "tien") - ClsControl2.PropertyOfGrid.Sum(gridsanpham, "tien_ck") + ClsControl2.PropertyOfGrid.Sum(gridsanpham, "tien_thue")
                        txtt_hoa_don.Value = ClsControl2.PropertyOfGrid.Sum(gridsanpham, "tien2") - ClsControl2.PropertyOfGrid.Sum(gridsanpham, "tien_ck") ''+ ClsControl2.PropertyOfGrid.Sum(gridsanpham, "tien_thue")
                        txtt_phai_thu.Value = txtt_hoa_don.Value - txtt_giam_gia.Value - txtt_tien_ck_hd.Value

                        setBuoc(buoc.NHAP_MA_VT)
                        Exit For
                    End If

                Next

                formatRowOfGridSanPham()

            End If
        Else
            txtMa_kh.Focus()
        End If
    End Sub

    Private Sub inHoaDon()
        'in
        Try
            txtstatus.Text = "Printing..."
            Dim query As String = cprint.Store & " '" & s_stt_rec & "'"
            Dim ds As DataSet = conn.GetDataSet(query)
            ds.Tables(0).TableName = "master"
            ds.Tables(1).TableName = "detail"
            cprint.Dataset = ds
            cprint.Print()
            txtstatus.Text = ""
        Catch ex As Exception
            MsgBox("Đã có lỗi khi in phiếu bán lẻ này. Kiểm tra file log trên server để biết lỗi", MsgBoxStyle.Exclamation, Me.Text)
            conn.Server.writeLog("Print PBL at " & Now.ToString & Chr(13) & ex.ToString, "error")
            txtstatus.Text = ""
        End Try
        


    End Sub
    Private Sub xemphieu()
        fprint.Icon = Me.Icon
        If fprint.ShowDialog(Me) = Windows.Forms.DialogResult.Yes Then
            Dim query As String = cprint.Store & " '" & s_stt_rec & "'"
            Dim ds As DataSet = conn.GetDataSet(query)
            ds.Tables(0).TableName = "master"
            ds.Tables(1).TableName = "detail"
            cprint.Dataset = ds
            cprint.RefreshReport()
            cprint.PrintRPT.ShowDialog(Me)
            'hoa don moi
            ''setBuoc(buoc.HOA_DON_MOI)
        End If

    End Sub
    Private Sub thoattam()
        Clsql.Data.CopyTable(dataMaster, dataMasterTmp, "stt_rec='" & stt_rec & "'", "1=0")
        Clsql.Data.CopyTable(dataDetail, dataDetailTmp, "stt_rec='" & stt_rec & "'", "1=0")
        setBuoc(buoc.HOA_DON_MOI)
    End Sub
    Private Sub addKhachHang(ByVal row As StpTableRow)
        lblma_kh.Text = row.Cell("ma_kh")
        lblten_kh.Text = row.Cell("ten_kh")
        currentMaster.Item("ma_kh") = row.Cell("ma_kh")
        currentMaster.Item("ten_kh") = row.Cell("ten_kh")


        If pre_b = buoc.TRA_SAU Then
            trasau()
            Return
        End If

        If pre_b > buoc.NHAP_MA_VT Then
            setBuoc(pre_b)
        Else
            setBuoc(buoc.NHAP_MA_VT)
        End If
    End Sub
    Private Sub tinhtienhang(ByVal DataRow As DataRow)
        
        DataRow("tien1") = Math.Round(DataRow("sl_xuat") * DataRow("gia_ban"), 0)
        DataRow("tien_nt1") = DataRow("tien1")

        DataRow("tien2") = Math.Round(DataRow("sl_xuat") * DataRow("gia_ban2"), 0)
        DataRow("tien_nt2") = DataRow("tien2")

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
        'tinh tong cong tien
        txtt_hoa_don.Value = ClsControl2.PropertyOfGrid.Sum(gridsanpham, "t_hd") ''ClsControl2.PropertyOfGrid.Sum(gridsanpham, "tien2") - ClsControl2.PropertyOfGrid.Sum(gridsanpham, "tien_ck")
        'tinh tien giam gia theo ty le dua vao the giam gia
        TinhTienGiamGiaTheoTyLe()
        txtt_phai_thu.Value = txtt_hoa_don.Value - txtt_giam_gia.Value - txtt_tien_ck_hd.Value
    End Sub
    Private Sub tinhtienhang2(ByVal DataRow As DataGridViewRow)
        DataRow.Cells("tien").Value = DataRow.Cells("sl_xuat").Value * DataRow.Cells("gia_ban").Value
        DataRow.Cells("tien_nt").Value = DataRow.Cells("tien").Value

        DataRow.Cells("tien2").Value = DataRow.Cells("sl_xuat").Value * DataRow.Cells("gia_ban2").Value
        DataRow.Cells("tien_nt2").Value = DataRow.Cells("tien2").Value

        'If DataRow.Cells("ty_le_ck").Value <> 0 Then
        '    DataRow.Cells("tien_ck").Value = DataRow.Cells("tien").Value * DataRow.Cells("ty_le_ck").Value / 100
        'Else
        '    DataRow.Cells("tien_ck").Value = DataRow.Cells("tien_giam").Value '* DataRow.Cells("sl_xuat").Value
        'End If

        If DataRow.Cells("ty_le_ck").Value <> 0 Then
            DataRow.Cells("tien_ck").Value = DataRow.Cells("tien2").Value * DataRow.Cells("ty_le_ck").Value / 100
        Else
            DataRow.Cells("tien_ck").Value = DataRow.Cells("tien_giam").Value '* DataRow.Cells("sl_xuat").Value
        End If

        DataRow.Cells("tien_ck_nt").Value = DataRow.Cells("tien_ck").Value

        'DataRow.Cells("tien_thue").Value = Math.Round((DataRow.Cells("tien").Value - DataRow.Cells("tien_ck").Value) * DataRow.Cells("thue_suat").Value / 100, 0)
        'DataRow.Cells("tien_thue_nt").Value = DataRow.Cells("tien_thue").Value

        DataRow.Cells("tien_thue").Value = Math.Round((DataRow.Cells("tien").Value) * DataRow.Cells("thue_suat").Value / 100, 0)
        DataRow.Cells("tien_thue_nt").Value = DataRow.Cells("tien_thue").Value

        'DataRow.Cells("t_hd").Value = DataRow.Cells("tien").Value - DataRow.Cells("tien_ck").Value + DataRow.Cells("tien_thue").Value
        'DataRow.Cells("t_hd_nt").Value = DataRow.Cells("tien_nt").Value - DataRow.Cells("tien_ck_nt").Value + DataRow.Cells("tien_thue_nt").Value

        DataRow.Cells("t_hd").Value = DataRow.Cells("tien2").Value - DataRow.Cells("tien_ck").Value
        DataRow.Cells("t_hd_nt").Value = DataRow.Cells("tien_nt2").Value - DataRow.Cells("tien_ck_nt").Value

        'tinh tong cong tien
        ''txtt_hoa_don.Value = ClsControl2.PropertyOfGrid.Sum(gridsanpham, "tien") - ClsControl2.PropertyOfGrid.Sum(gridsanpham, "tien_ck") + ClsControl2.PropertyOfGrid.Sum(gridsanpham, "tien_thue")
        txtt_hoa_don.Value = ClsControl2.PropertyOfGrid.Sum(gridsanpham, "tien2") - ClsControl2.PropertyOfGrid.Sum(gridsanpham, "tien_ck")
        'tinh tien giam gia theo ty le dua vao the giam gia
        TinhTienGiamGiaTheoTyLe()
        txtt_phai_thu.Value = txtt_hoa_don.Value - txtt_giam_gia.Value - txtt_tien_ck_hd.Value
    End Sub
    Private Sub tinhgiaban(ByVal DataRow As DataRow)
        'neu san pham nay da sua gia ban thi khong tu tinh lai
        If Not IsDBNull(DataRow("sua_gia_ban_yn")) AndAlso DataRow("sua_gia_ban_yn") = True Then
            Return
        End If
        'tinh gia ban
        Dim query As String = "exec get_giaban_le '" & DataRow("ma_vt") & "',N'" & DataRow("ma_dvt") & "','" & lblma_kh.Text & "'," & conn.ConvertToSQLType(info_may_ban_le.Item("ma_kho")) & "," & DataRow("sl_xuat")
        Dim dt As DataTable = conn.GetDatatable(query)
        If dt.Rows.Count = 1 Then
            Dim loai_gia As Integer = info_may_ban_le.Item("loai_gia_ban")
            Select Case loai_gia
                Case 0
                    If dt.Rows(0).Item("gia_chua_gom_vat") = True Then
                        DataRow("gia_ban") = dt.Rows(0).Item("gia_ban_le")
                        DataRow("gia_ban2") = dt.Rows(0).Item("gia_ban_le") * (1 + DataRow("thue_suat") / 100)
                    Else
                        DataRow("gia_ban") = Math.Round(dt.Rows(0)("gia_ban_le") / (1 + DataRow("thue_suat") / 100), 5) 'tien_nt/(1+thue_suat/100)
                        DataRow("gia_ban2") = dt.Rows(0).Item("gia_ban_le")
                    End If

                    Exit Select
                Case 1
                    If dt.Rows(0).Item("gia_chua_gom_vat") = True Then
                        DataRow("gia_ban") = dt.Rows(0).Item("gia_ban_buon1")
                        DataRow("gia_ban2") = dt.Rows(0).Item("gia_ban_buon1") * (1 + DataRow("thue_suat") / 100)
                    Else
                        DataRow("gia_ban") = Math.Round(dt.Rows(0).Item("gia_ban_buon1") / (1 + DataRow("thue_suat") / 100), 5) 'tien_nt/(1+thue_suat/100)
                        DataRow("gia_ban2") = dt.Rows(0).Item("gia_ban_buon1")
                    End If

                    Exit Select
                Case 2
                    If dt.Rows(0).Item("gia_chua_gom_vat") = True Then
                        DataRow("gia_ban") = dt.Rows(0).Item("gia_ban_buon2")
                        DataRow("gia_ban2") = dt.Rows(0).Item("gia_ban_buon2") * (1 + DataRow("thue_suat") / 100)
                    Else

                        DataRow("gia_ban") = Math.Round(dt.Rows(0).Item("gia_ban_buon2") / (1 + DataRow("thue_suat") / 100), 5) 'tien_nt/(1+thue_suat/100)
                        DataRow("gia_ban2") = dt.Rows(0).Item("gia_ban_buon2")
                    End If

                    Exit Select
                Case 3
                    If dt.Rows(0).Item("gia_chua_gom_vat") = True Then
                        DataRow("gia_ban") = dt.Rows(0).Item("gia_ban_buon3")
                        DataRow("gia_ban2") = dt.Rows(0).Item("gia_ban_buon3") * (1 + DataRow("thue_suat") / 100)
                    Else
                        DataRow("gia_ban") = Math.Round(dt.Rows(0).Item("gia_ban_buon3") / (1 + DataRow("thue_suat") / 100), 5) 'tien_nt/(1+thue_suat/100)
                        DataRow("gia_ban2") = dt.Rows(0).Item("gia_ban_buon3")
                    End If

                    Exit Select
                Case 4
                    If dt.Rows(0).Item("gia_chua_gom_vat") = True Then
                        DataRow("gia_ban") = dt.Rows(0).Item("gia_ban_buon4")
                        DataRow("gia_ban2") = dt.Rows(0).Item("gia_ban_buon4") * (1 + DataRow("thue_suat") / 100)
                    Else
                        DataRow("gia_ban") = Math.Round(dt.Rows(0).Item("gia_ban_buon4") / (1 + DataRow("thue_suat") / 100), 5) 'tien_nt/(1+thue_suat/100)
                        DataRow("gia_ban2") = dt.Rows(0).Item("gia_ban_buon4")
                    End If
                    Exit Select
            End Select
            If DataRow("gia_ban2") = 0 Then
                Try
                    Dim gb As Double = conn.GetValue("select gia_ban_le from dmvt where ma_vt ='" & DataRow("ma_vt") & "'")
                    If dt.Rows(0).Item("gia_chua_gom_vat") = True Then
                        DataRow("gia_ban") = gb
                        DataRow("gia_ban2") = gb * (1 + DataRow("thue_suat") / 100)
                    Else
                        DataRow("gia_ban") = Math.Round(gb / (1 + DataRow("thue_suat") / 100), 5) 'tien_nt/(1+thue_suat/100)
                        DataRow("gia_ban2") = gb
                    End If
                Catch ex As Exception

                End Try


            End If
            DataRow("gia_ban_nt") = DataRow("gia_ban")
            DataRow("gia_ban_nt2") = DataRow("gia_ban2")
            DataRow("ty_le_ck") = dt.Rows(0).Item("ty_le_giam_gia")
            DataRow("tien_giam") = dt.Rows(0).Item("tien_giam")
            DataRow("gia_chua_gom_vat") = dt.Rows(0).Item("gia_chua_gom_vat")
            DataRow.AcceptChanges()
        End If
    End Sub
    Private Sub SanPhamBanTheoKy(ByVal barcode As String, ByVal lookup As ClsLookup.AutoCompleteLookup)
        Dim sp_ban_ky As String = Clsql.Others.Options("sp_ban_ky", conn)
        If sp_ban_ky.Trim <> "" AndAlso barcode.StartsWith(sp_ban_ky) Then
            Try
                Dim ma_vt As String = barcode.Substring(0, 7)
                Dim sl As Double = barcode.Substring(7, 5) 'gam

                lookup.continueValid = False
                Dim rowlookup As StpTableRow = lookup.GetRowLookup(ma_vt)
                If rowlookup IsNot Nothing Then
                    If rowlookup("ma_dvt").ToString.Trim.ToLower = "kg" Then
                        sl = sl / 1000
                    End If
                    addHangHoa(rowlookup, sl)
                End If
            Catch ex As Exception
                MsgBox("Sản phẩm bán theo ký này không tồn tại", MsgBoxStyle.Critical, Clsql.AboutMe.Name)
            End Try

        End If
    End Sub
    Private Sub addHangHoa(ByVal row As StpTableRow)
        addHangHoa(row, 1)
    End Sub
    Private Sub addHangHoa(ByVal row As StpTableRow, ByVal sl_add As Double)
        'cap nhat san pham cu
        Dim ma_vt As String = row.Cell("ma_vt").ToString.ToLower.Trim

        Dim i As Integer = 0
        gridsanpham.EndEdit()
        For Each r As DataGridViewRow In gridsanpham.Rows

            If r.Cells("ma_vt").Value.ToString.ToLower.Trim = ma_vt AndAlso r.Cells("sp_km_of").Value.ToString.Trim = "" Then
                Dim sl As Double = r.Cells("sl_xuat").Value
                sl = sl + sl_add
                updateSoluong(r, sl)

                gridsanpham.Rows(i).Selected = True
                gridsanpham.CurrentCell = gridsanpham.Rows(i).Cells(0)
                setBuoc(buoc.NHAP_MA_VT)
                Return
            End If
            i += 1
        Next
        'them san pham moi
        Dim dataRow As DataRow = dataDetail.NewRow()
        dataRow.Item("px_gia_dd") = False
        dataRow.Item("ma_vt") = row.Cell("ma_vt")
        dataRow.Item("ten_vt") = row.Cell("ten_vt")
        dataRow.Item("ma_dvt") = row.Cell("ma_dvt")
        dataRow.Item("ma_kho") = info_may_ban_le.Item("ma_kho")
        dataRow.Item("sl_xuat") = sl_add
        dataRow.Item("gia_ban") = 0
        dataRow.Item("ty_le_ck") = 0
        dataRow.Item("tien_giam") = 0
        dataRow.Item("tien") = 0
        dataRow.Item("tien_thue") = 0
        dataRow.Item("tien_ck") = 0
        dataRow.Item("sp_km_of") = ""
        new_line += 1
        dataRow.Item("line") = new_line
        dataRow.Item("sort") = Strings.Format((gridsanpham.Rows.Count + 1), "00000") & row.Cell("ma_vt")
        dataRow.Item("sua_gia_ban_yn") = False

        Dim ton_tt As Object = conn.GetValue("select ton_tt from tontucthoi where ma_vt='" & row.Cell("ma_vt") & "' and ma_kho ='" & info_may_ban_le.Item("ma_kho") & "' ")
        If ton_tt.ToString <> "" Then
            dataRow.Item("ton_tt") = ton_tt
        Else
            dataRow.Item("ton_tt") = 0
        End If



        dataRow.Item("tk_dt") = row.Cell("tk_dt")
        If dataRow.Item("tk_dt") = "" Then
            dataRow.Item("tk_dt") = info_may_ban_le.Item("tk_dt")
        End If

        dataRow.Item("tk_no") = info_may_ban_le.Item("tk_tien_mat")

        dataRow.Item("tk_ck") = row.Cell("tk_ck")
        If dataRow.Item("tk_ck") = "" Then
            dataRow.Item("tk_ck") = info_may_ban_le.Item("tk_ck")
        End If




        dataRow.Item("tk_vt") = row.Cell("tk_vt")

        dataRow.Item("tk_gv") = row.Cell("tk_gv")
        If dataRow.Item("tk_gv") = "" Then
            dataRow.Item("tk_gv") = info_may_ban_le.Item("tk_gv")
        End If


        dataRow.Item("ma_thue") = row.Cell("ma_thue")
        dataRow.Item("thue_suat") = row.Cell("thue_suat")
        dataRow.Item("tk_thue_co") = row.Cell("tk_thue_co")
        dataRow.Item("tk_du") = info_may_ban_le.Item("tk_tien_mat")

        dataRow.Item("stt_rec") = stt_rec

        'san pham ban ho
        If Not IsDBNull(row.Cell("sp_dl")) AndAlso row.Cell("sp_dl") = True Then
            If info_may_ban_le.Item("ma_kho_ban_ho") <> "" Then
                dataRow.Item("ma_kho") = info_may_ban_le.Item("ma_kho_ban_ho")
            End If

        End If
        '

        dataDetail.Rows.Add(dataRow)

        txtt_so_luong.Value = ClsControl2.PropertyOfGrid.Sum(gridsanpham, "sl_xuat")
        gridsanpham.ClearSelection()

        gridsanpham.Rows(gridsanpham.Rows.Count - 1).Selected = True
        gridsanpham.CurrentCell = gridsanpham.Rows(gridsanpham.Rows.Count - 1).Cells(0)
        tinhgiaban(dataRow)
        tinhtienhang(dataRow)
        'tinh san pham duoc khuyen mai
        tinhsanphamduockhuyenmai(gridsanpham.CurrentRow)
        setBuoc(buoc.NHAP_MA_VT)
    End Sub
    Private Sub updateSoluong()
        Dim currentRow As DataGridViewRow = gridsanpham.CurrentRow
        If currentRow Is Nothing Then
            Return
        End If
        updateSoluong(currentRow, txtSo_luong.Value)
    End Sub

    Private Sub updateSoluong(ByVal currentRow As DataGridViewRow, ByVal sl As Double)
        currentRow.Cells("sl_xuat").Value = sl
        tinhgiaban(currentRow.DataBoundItem.row)
        tinhtienhang(currentRow.DataBoundItem.row)
        tinhsanphamduockhuyenmai(currentRow)
        txtt_so_luong.Value = ClsControl2.PropertyOfGrid.Sum(gridsanpham, "sl_xuat")
        txtSo_luong.Value = 1
    End Sub
    Private Sub updateGiaban()
        Dim currentRow As DataGridViewRow = gridsanpham.CurrentRow
        If currentRow Is Nothing Then
            Return
        End If
        currentRow.Cells("sua_gia_ban_yn").Value = True
        
        If currentRow.Cells("gia_chua_gom_vat").Value = True Then
            currentRow.Cells("gia_ban").Value = txtgia_ban.Value
            currentRow.Cells("gia_ban2").Value = txtgia_ban.Value * (1 + currentRow.Cells("thue_suat").Value / 100)
        Else
            currentRow.Cells("gia_ban").Value = Math.Round(txtgia_ban.Value / (1 + currentRow.Cells("thue_suat").Value / 100), 0)
            currentRow.Cells("gia_ban2").Value = txtgia_ban.Value
        End If
        currentRow.Cells("gia_ban_nt").Value = currentRow.Cells("gia_ban").Value
        currentRow.Cells("gia_ban_nt2").Value = currentRow.Cells("gia_ban2").Value
        tinhtienhang(currentRow.DataBoundItem.row)
    End Sub
    Private Sub updateTyLeCK()
        Dim currentRow As DataGridViewRow = gridsanpham.CurrentRow
        If currentRow Is Nothing Then
            Return
        End If
        currentRow.Cells("ty_le_ck").Value = txtgia_ban.Value
        tinhtienhang(currentRow.DataBoundItem.row)

    End Sub

    Private Sub tinhchietkhautheohoadon()
        'chiet khau theo hoa don
        Dim query As String = "exec get_ck_tong_hd "
        query = query & conn.ConvertToSQLType(txtt_hoa_don.Value)
        query = query & "," & conn.ConvertToSQLType(info_may_ban_le.Item("ma_kho"))
        query = query & "," & conn.ConvertToSQLType(lblma_kh.Text)
        Dim ck_hdTable As DataTable = conn.GetDatatable(query)
        If ck_hdTable.Rows.Count > 0 Then
            txtt_tien_ck_hd.Value = ck_hdTable.Rows(0).Item("tien_ck")
            txtt_phai_thu.Value = txtt_hoa_don.Value - txtt_giam_gia.Value - txtt_tien_ck_hd.Value
        End If
    End Sub
    Private Sub tinhsanphamduockhuyenmai(ByVal DataRow As DataGridViewRow)

        Dim ma_vt As String = DataRow.Cells("ma_vt").Value
        Dim sort As String = DataRow.Cells("sort").Value
        Dim query As String = "exec get_sanphamkhuyenmai '" & ma_vt & "',N'" & DataRow.Cells("ma_dvt").Value & "','" & lblma_kh.Text & "'," & conn.ConvertToSQLType(info_may_ban_le.Item("ma_kho")) & "," & DataRow.Cells("sl_xuat").Value
        Dim dt As DataTable = conn.GetDatatable(query)

        If dt.Rows.Count > 0 Then
            Clsql.Data.CopyTable(dt, dataDetail, "1=1", "sp_km_of='" & ma_vt & "'")

            For Each r As DataGridViewRow In gridsanpham.Rows
                'set stt_rec cho san pham chiet khau
                If IsDBNull(r.Cells("stt_rec").Value) OrElse r.Cells("stt_rec").Value = "" Then
                    r.Cells("stt_rec").Value = stt_rec
                End If

                '
                If r.Cells("sp_km_of").Value = ma_vt Then
                    r.Cells("sort").Value = sort
                End If
                If r.Cells("tk_dt").Value = "" Then
                    r.Cells("tk_dt").Value = info_may_ban_le.Item("tk_dt")
                End If
                If r.Cells("tk_gv").Value = "" Then
                    r.Cells("tk_gv").Value = info_may_ban_le.Item("tk_gv")
                End If

            Next
            'gridsanpham.Sort(gridsanpham.Columns("sort"), System.ComponentModel.ListSortDirection.Ascending)
            'gridsanpham.EndEdit()
            'ClsControl2.PropertyOfGrid.FormatRowNotEq(gridsanpham, "sp_km_of=", gridsanpham.Font.Size - 2, FontStyle.Italic, Color.Gray, gridsanpham.BackgroundColor)
            formatRowOfGridSanPham()
            For Each r As DataGridViewRow In gridsanpham.Rows
                If r.Cells("ma_vt").Value = ma_vt AndAlso r.Cells("sp_km_of").Value = "" Then
                    gridsanpham.Rows(r.Index).Selected = True
                    gridsanpham.CurrentCell = gridsanpham.Rows(r.Index).Cells(0)
                End If

            Next

        Else
            'xoa cac san pham khuyen mai cua san pham nay
            For Each r As DataGridViewRow In gridsanpham.Rows
                If r.Cells("sp_km_of").Value = ma_vt Then
                    gridsanpham.Rows.Remove(r)
                End If
            Next
        End If
    End Sub
    Private Sub formatRowOfGridSanPham()
        gridsanpham.Sort(gridsanpham.Columns("sort"), System.ComponentModel.ListSortDirection.Ascending)
        gridsanpham.EndEdit()
        ClsControl2.PropertyOfGrid.FormatRowNotEq(gridsanpham, "sp_km_of=", gridsanpham.Font.Size - 2, FontStyle.Italic, Color.Gray, gridsanpham.BackgroundColor)

    End Sub

    Private Sub thanhtoantienmat()
        txtt_thu.Value = txttien.Value
        txtt_tra_lai.Value = txtt_thu.Value - txtt_phai_thu.Value

        currentMaster.Item("hinh_thuc_tt") = "TM"
        currentMaster.Item("chu_the") = ""
        currentMaster.Item("so_the") = ""
        currentMaster.Item("t_thu") = txtt_thu.Value
        currentMaster.Item("t_tra_lai") = txtt_tra_lai.Value

        For Each r As DataGridViewRow In gridsanpham.Rows
            r.Cells("tk_no").Value = info_may_ban_le.Item("tk_tien_mat")
            r.Cells("tk_du").Value = info_may_ban_le.Item("tk_tien_mat")
        Next

        If txtt_tra_lai.Value < 0 Then
            MsgBox(olan("210"), , Clsql.AboutMe.Name)
            Return
        End If
    End Sub
    Private Sub thanhtoanbangVisa()
        Dim f As New frnVisa
        f.Icon = Me.Icon
        ClsControl2.PropertyOfForm.SetLable(olan, f)
s:
        If f.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            txtt_thu.Value = f.txtso_tien.Value
            txtt_tra_lai.Value = txtt_thu.Value - txtt_phai_thu.Value
            currentMaster.Item("hinh_thuc_tt") = "NH"
            currentMaster.Item("chu_the") = f.txtchu_the.Text
            currentMaster.Item("so_the") = f.txtso_the.Text
            currentMaster.Item("t_thu") = f.txtso_tien.Value
            currentMaster.Item("t_tra_lai") = txtt_tra_lai.Value
            For Each r As DataGridViewRow In gridsanpham.Rows
                r.Cells("tk_no").Value = info_may_ban_le.Item("tk_tien_nh")
                r.Cells("tk_du").Value = info_may_ban_le.Item("tk_tien_nh")
            Next
            If txtt_tra_lai.Value < 0 Then
                MsgBox(olan("210"), , Clsql.AboutMe.Name)
                GoTo s
            End If

            setBuoc(buoc.HOAN_THANH)
        End If

    End Sub

    Private Sub trasau()
        If MsgBox(olan("803"), MsgBoxStyle.YesNo, Clsql.AboutMe.Name) = MsgBoxResult.No Then
            Return
        End If
        If lblma_kh.Text = "" Then
            setBuoc(buoc.NHAP_MA_KH)
            pre_b = buoc.TRA_SAU
            Return
        End If
        txtt_thu.Value = 0
        txtt_tra_lai.Value = 0
        currentMaster.Item("hinh_thuc_tt") = "TS"
        currentMaster.Item("chu_the") = ""
        currentMaster.Item("so_the") = ""
        currentMaster.Item("t_thu") = txtt_thu.Value
        currentMaster.Item("t_tra_lai") = txtt_tra_lai.Value

        For Each r As DataGridViewRow In gridsanpham.Rows
            r.Cells("tk_no").Value = info_may_ban_le.Item("tk_tra_sau")
            r.Cells("tk_du").Value = info_may_ban_le.Item("tk_tra_sau")
        Next
        setBuoc(buoc.HOAN_THANH)
    End Sub

    Private Sub deleteHangHoa()
        Dim currentRow As DataGridViewRow = gridsanpham.CurrentRow
        If currentRow Is Nothing Then
            Return
        End If
        If currentRow.Cells("sp_km_of").Value <> "" Then
            Return
        End If
        If MsgBox(olan("529"), MsgBoxStyle.YesNo, Clsql.AboutMe.Name) = MsgBoxResult.Yes Then

            Dim ma_vt As String = currentRow.Cells("ma_vt").Value
            'xoa san pham nay
            gridsanpham.Rows.RemoveAt(currentRow.Index)
            'xoa cac san pham khuyen mai cua san pham nay
            For Each r As DataGridViewRow In gridsanpham.Rows
                If r.Cells("sp_km_of").Value = ma_vt Then
                    gridsanpham.Rows.Remove(r)
                End If
            Next
            txtt_so_luong.Value = ClsControl2.PropertyOfGrid.Sum(gridsanpham, "sl_xuat")
            ''txtt_hoa_don.Value = ClsControl2.PropertyOfGrid.Sum(gridsanpham, "tien") - ClsControl2.PropertyOfGrid.Sum(gridsanpham, "tien_ck") + ClsControl2.PropertyOfGrid.Sum(gridsanpham, "tien_thue")
            txtt_hoa_don.Value = ClsControl2.PropertyOfGrid.Sum(gridsanpham, "tien2") - ClsControl2.PropertyOfGrid.Sum(gridsanpham, "tien_ck")
            'tinh tien giam gia theo ty le dua vao the giam gia
            TinhTienGiamGiaTheoTyLe()
            '
            txtt_phai_thu.Value = txtt_hoa_don.Value - txtt_giam_gia.Value - txtt_tien_ck_hd.Value
        End If

    End Sub

    Private saved As Boolean = False
    Private Sub saveHoaDon()
        If saved Then
            Return
        End If
        'get stt_rec
        s_stt_rec = vno.GetNextSttRec
        vno.UpdateSttRec()
        Dim so_ct As String = vno.GetNextSoCt(mastertable)
        vno.CheckSoCt(Now, so_ct, s_stt_rec, mastertable)
        vno.UpdateSoCt()
        '
        currentMaster.Item("status") = 0
        If checkright.Right("Csk") Then
            currentMaster.Item("status") = 4
        End If
        If checkright.Right("Csc") Then
            currentMaster.Item("status") = 5
        End If

        currentMaster.Item("t_so_luong") = txtt_so_luong.Value
        currentMaster.Item("t_hoa_don") = txtt_hoa_don.Value
        currentMaster.Item("t_tien_ck_hd") = txtt_tien_ck_hd.Value
        currentMaster.Item("t_giam_gia") = txtt_giam_gia.Value
        currentMaster.Item("t_phai_thu") = txtt_phai_thu.Value
        currentMaster.Item("t_thu") = txtt_thu.Value
        currentMaster.Item("t_tra_lai") = txtt_tra_lai.Value
        currentMaster.Item("stt_rec") = s_stt_rec
        currentMaster.Item("so_ct") = so_ct
        currentMaster.Item("gio_ca") = soca("tu_gio")
        'save master
        Dim query As String = conn.GetInsertQueryFromDataRow(currentMaster, mastertable)
        conn.Execute(query)
        Dim line As Integer = 0
        'save detail
        For Each r As DataRow In dataDetail.Rows
            If r.RowState = DataRowState.Deleted Then
                Continue For
            End If
            For Each c As DataColumn In dataDetail.Columns
                If currentMaster.Table.Columns.Contains(c.ColumnName) AndAlso c.ColumnName <> "ten_vt" Then
                    r.Item(c) = currentMaster.Item(c.ColumnName)
                End If
            Next
            r.Item("line") = line
            line += 1
        Next
        query = conn.GetInsertQueryFromDatatable(dataDetail, detailtable)
        conn.Execute(query)
        'save phieu giam gia
        For Each r As DataRow In dataThegiamgia.Rows
            r.Item("stt_rec") = s_stt_rec
        Next
        query = conn.GetInsertQueryFromDatatable(dataThegiamgia, giamgiatable)
        conn.Execute(query)
        'post
        ClsSV31.Functions.Post(conn, ma_ct, mastertable, s_stt_rec, currentMaster.Item("status"))
        If soca("so_ct_tu") = "" Then
            soca("so_ct_tu") = so_ct
        End If
        soca("so_ct_den") = so_ct
        'update ca
        conn.Execute("delete from soca where " & query_where_soca & " and tu_gio ='" & soca("tu_gio") & "'")
        conn.WriteToServer(soca.Table, "soca")

        saved = True
    End Sub

    Private Sub btnF2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnF2.Click
        Select Case current_b
            Case buoc.NHAP_MA_KH
                'ma_khLookup.ShowFormLookupToSelect()
                lookups.Item("txtma_kh").ShowFormLookupToSelect()
                Exit Select
            Case buoc.NHAP_MA_VT
                'ma_vtLookup.ShowFormLookupToSelect()
                lookups.Item("txtma_vt").ShowFormLookupToSelect()
                Exit Select
            Case buoc.THANH_TOAN  'thanh toan tien mat
                setBuoc(buoc.TIEN_MAT)
                Exit Select
            Case buoc.TIEN_MAT
                txttien.Value = txttien.Value & btnF2.Text.Replace(",", "")
                txttien.Focus()
                Exit Select
            Case buoc.HOAN_THANH
                setBuoc(buoc.HOA_DON_MOI)
                Exit Select
        End Select
    End Sub

    Private Sub btnF3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnF3.Click
        Select Case current_b
            Case buoc.NHAP_MA_KH 'khoi phuc hoa don
                khoiphuchoadon()
                Exit Select
            Case buoc.HOAN_THANH, buoc.LUU_PHIEU  'them hoa don moi va khoi phuc hoa don
                setBuoc(buoc.HOA_DON_MOI)
                khoiphuchoadon()
                Exit Select
            Case buoc.NHAP_MA_VT 'sua so luong
                If gridsanpham.CurrentRow Is Nothing Then
                    Return
                End If
                If gridsanpham.CurrentRow.Cells("sp_km_of").Value <> "" Then
                    Return
                End If
                txtSo_luong.Value = gridsanpham.CurrentRow.Cells("sl_xuat").Value
                setBuoc(buoc.SO_LUONG)
                Exit Select
            Case buoc.TIEN_MAT
                txttien.Value = txttien.Value & btnF3.Text.Replace(",", "")
                txttien.Focus()
                Exit Select
            Case buoc.THANH_TOAN  'thanh toan visa
                thanhtoanbangVisa()
                Exit Select
        End Select

    End Sub

    Private Sub btnF4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnF4.Click
        Select Case current_b
            Case buoc.NHAP_MA_KH 'bo qua buoc nhap ma khach
                setBuoc(buoc.NHAP_MA_VT)
            Case buoc.TIEN_MAT
                txttien.Value = txttien.Value & btnF4.Text.Replace(",", "")
                txttien.Focus()
                Exit Select
            Case buoc.NHAP_MA_VT
                deleteHangHoa()
                Exit Select
            Case buoc.THANH_TOAN 'tra sau
                trasau()
                Exit Select
        End Select
    End Sub

    Private Sub btnF5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnF5.Click
        Select Case current_b
            Case buoc.TIEN_MAT
                txttien.Value = txttien.Value & btnF5.Text.Replace(",", "")
                txttien.Focus()
                Exit Select
            Case buoc.NHAP_MA_VT
                Dim currentRow As DataGridViewRow = gridsanpham.CurrentRow
                If currentRow Is Nothing Then
                    Return
                End If
                setBuoc(buoc.SUA_GIA_BAN)
                Exit Select
            Case buoc.THANH_TOAN, buoc.CHIET_KHAU 'nhap hang hoa
                setBuoc(buoc.NHAP_MA_VT)
                Exit Select
        End Select
    End Sub

    Private Sub btnF6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnF6.Click
        Select Case current_b
            Case buoc.TIEN_MAT, buoc.NHAP_MA_VT, buoc.THANH_TOAN  'chiet khau thuong mai
                setBuoc(buoc.CHIET_KHAU)
                Exit Select
        End Select
    End Sub

    Private Sub btnF7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnF7.Click
        Select Case current_b
            Case buoc.TIEN_MAT, buoc.NHAP_MA_VT, buoc.THANH_TOAN
                thoattam()
                Exit Select
        End Select
    End Sub

    Private Sub btnF8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnF8.Click
        Select Case current_b
            Case buoc.NHAP_MA_VT, buoc.TIEN_MAT, buoc.THANH_TOAN 'cap nhat ma khach hang
                setBuoc(buoc.NHAP_MA_KH)
                Exit Select
            Case buoc.HOAN_THANH 'xem phieu
                xemphieu()
                Exit Select

        End Select
    End Sub

    Private Sub btnF9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnF9.Click
        Select Case current_b
            Case buoc.NHAP_MA_VT, buoc.SO_LUONG, buoc.CHIET_KHAU, buoc.SUA_GIA_BAN   'thanh toan
                setBuoc(buoc.THANH_TOAN)
                Exit Select
            Case buoc.TIEN_MAT
                setBuoc(buoc.HOAN_THANH)
                Exit Select
            Case buoc.HOAN_THANH
                '' inHoaDon()
                Dim t As New Threading.Thread(AddressOf inHoaDon)
                t.Start()
                Exit Select
        End Select
    End Sub

    Private Sub btnF10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF10.Click
        Select Case current_b
            Case buoc.NHAP_MA_VT
                Dim currentRow As DataGridViewRow = gridsanpham.CurrentRow
                If currentRow Is Nothing Then
                    Return
                End If
                setBuoc(buoc.SUA_TL_CK)
                Exit Select
            Case buoc.TIEN_MAT
                setBuoc(buoc.THANH_TOAN)
                Exit Select
        End Select
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        If pre_b = buoc.HOA_DON_MOI Then
            Return
        End If
        setBuoc(pre_b)
    End Sub

    Private Sub txtma_kh_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMa_kh.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtt_so_luong.Focus()
            txtMa_kh.Focus()

            If txtMa_kh.Text = "" Then
                If pre_b = buoc.TRA_SAU Then
                    MsgBox(olan("008"))
                    Return
                End If

                If pre_b > buoc.NHAP_MA_VT Then
                    setBuoc(pre_b)
                Else
                    setBuoc(buoc.NHAP_MA_VT)
                End If
            End If
        End If

    End Sub
    Private Sub txtma_vt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtma_vt.KeyDown

        If e.KeyCode = Keys.Enter Then
            If txtma_vt.Text = "" Then
                Return
            End If
            txtt_so_luong.Focus()
            txtma_vt.Focus()

        End If

    End Sub
    Private Sub txtSo_luong_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSo_luong.KeyDown
        If e.KeyCode = Keys.Enter Then
            updateSoluong()
            setBuoc(buoc.NHAP_MA_VT)
        End If
    End Sub
    Private Sub txtgia_ban_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtgia_ban.KeyDown
        If e.KeyCode = Keys.Enter Then
            If b_sua_tl_ck Then
                updateTyLeCK()
                b_sua_tl_ck = False
            Else

                updateGiaban()
            End If

            setBuoc(buoc.NHAP_MA_VT)
        End If
    End Sub

    Private Sub txttien_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txttien.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txttien.Value = 0 Then
                Return
            End If
            thanhtoantienmat()
            setBuoc(buoc.HOAN_THANH)
        End If
    End Sub

    Private Sub TinhTienGiamGiaTheoTyLe()
        Dim ty_le As Double = 0
        For Each r As DataRow In dataThegiamgia.Rows
            If r.Item("menh_gia") = 0 Then
                ty_le = r.Item("ty_le")
                If ty_le <> 0 Then
                    Exit For
                End If
            End If
        Next
        If ty_le <> 0 Then
            txtt_giam_gia.Value = txtt_hoa_don.Value * ty_le / 100
            txtt_phai_thu.Value = txtt_hoa_don.Value - txtt_giam_gia.Value - txtt_tien_ck_hd.Value
        End If
    End Sub
    Private Sub TinhTienGiamGiaTheoMenhGia()
        Dim t_ck As Double = 0
        For Each r As DataRow In dataThegiamgia.Rows
            t_ck = t_ck + r.Item("menh_gia")
        Next
        txtt_giam_gia.Value = t_ck
        txtt_phai_thu.Value = txtt_hoa_don.Value - txtt_giam_gia.Value - txtt_tien_ck_hd.Value
    End Sub

    Private Sub txtma_so_ck_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtma_so_ck.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtma_so_ck.Text = "" Then
                Return
            End If
            dataThegiamgia.Rows.Clear() 'chi chap nhan mot the giam gia mot lan giao dich
            For Each r As DataRow In dataThegiamgia.Rows
                If r.Item("ma_the") = txtma_so_ck.Text Then
                    MsgBox(olan("527"), , Clsql.AboutMe.Name)
                    Return
                End If
            Next

            Dim query = "exec get_thegiamgia '" + txtma_so_ck.Text + "'"
            Dim dt As DataTable = conn.GetDatatable(query)
            If dt.Rows.Count = 1 Then

                Dim nr As DataRow = dataThegiamgia.NewRow
                nr.Item("stt_rec") = stt_rec
                nr.Item("ma_the") = dt.Rows(0).Item("ma_the")
                nr.Item("menh_gia") = dt.Rows(0).Item("menh_gia")
                nr.Item("ty_le") = dt.Rows(0).Item("ty_le")
                nr.Item("ma_kh") = dt.Rows(0).Item("ma_kh")
                If nr.Item("ma_kh") <> "" Then
                    If currentMaster.Item("ma_kh") = "" Then
                        Dim ten_kh As String = conn.GetValue("select ten_kh from dkh where ma_kh='" & nr.Item("ma_kh") & "'")
                        lblma_kh.Text = nr.Item("ma_kh")
                        lblten_kh.Text = ten_kh
                        currentMaster.Item("ma_kh") = nr.Item("ma_kh")
                        currentMaster.Item("ten_kh") = ten_kh
                    Else
                        If currentMaster.Item("ma_kh") <> nr.Item("ma_kh") Then
                            MsgBox(olan("Z03").ToString.Replace("%s", lblten_kh.Text), MsgBoxStyle.Critical, Clsql.AboutMe.Name)
                            Return
                        End If
                    End If

                End If
                dataThegiamgia.Rows.Add(nr)


                TinhTienGiamGiaTheoMenhGia()
                TinhTienGiamGiaTheoTyLe()

                setBuoc(pre_b)
            Else
                MsgBox(olan("528"), , Clsql.AboutMe.Name)
            End If
            txtma_so_ck.Text = ""
        End If
    End Sub

    Private Sub txtt_phai_thu_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtt_phai_thu.TextChanged
        If txtt_phai_thu.Value < 0 Then
            txtt_phai_thu.Value = 0
        End If
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub btnmanager_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmanager.Click
        Clsql.Others.Exec(Application.StartupPath & "\vqpbl.exe", "PBL")
    End Sub




    Private Sub timer_ngay_gio_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timer_ngay_gio.Tick
        lblngay.Text = Strings.Format(Now(), "dd/MM/yyyy")
        lblgio.Text = Strings.Format(Now(), "hh:mm:ss")
    End Sub

    Private Sub workerPrint_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs)
        inHoaDon()
    End Sub

    Private Sub btnbangiao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbangiao.Click
        If saved = False AndAlso gridsanpham.Rows.Count > 0 Then
            MsgBox("Phiếu bán hàng hiện tại chưa hoàn tất", MsgBoxStyle.Critical, Clsql.AboutMe.Name)
            Return
        End If
        Dim f As New frmBanGiao
        ClsControl2.PropertyOfForm.SetLable(olan, f)
        f.Icon = Me.Icon
        f.StartPosition = FormStartPosition.CenterParent
        If f.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim fprintBanGiao As New frmPrint

            ClsControl2.PropertyOfForm.SetLable(olan, fprintBanGiao)
            Dim cprintBanGiao As New ClPrint.Print(conn, "pbl_bangiao", fprintBanGiao.cbbmau, fprintBanGiao.txttieu_de)
            fprintBanGiao.Icon = Me.Icon
            If fprintBanGiao.ShowDialog(Me) = Windows.Forms.DialogResult.Yes Then
                soca("nhan_vien") = f.txtnhan_vien.Text
                soca("ma_ca") = f.txtma_ca.Text
                soca("ma_may") = f.txtma_may.Text
                cprintBanGiao.Dataset = soca.Table.DataSet
                cprintBanGiao.RefreshReport()
                cprintBanGiao.PrintRPT.ShowDialog(Me)
            End If
            Me.Close()
        End If
    End Sub
End Class

