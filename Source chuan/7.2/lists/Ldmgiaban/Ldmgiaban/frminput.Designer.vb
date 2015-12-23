<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frminput
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnLuu = New System.Windows.Forms.Button
        Me.btnhuy = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chbgia_chua_gom_vat = New System.Windows.Forms.CheckBox
        Me.txtnh_kh1 = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtma_kh = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtnh_vt1 = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtnganh_hang = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.chbtrang_thai = New System.Windows.Forms.CheckBox
        Me.Label39 = New System.Windows.Forms.Label
        Me.txtgia_ban_buon3 = New ClsControl2.TxtNumeric
        Me.Label34 = New System.Windows.Forms.Label
        Me.txttien_giam = New ClsControl2.TxtNumeric
        Me.Label33 = New System.Windows.Forms.Label
        Me.txtty_le_giam_gia = New ClsControl2.TxtNumeric
        Me.Label32 = New System.Windows.Forms.Label
        Me.txtgia_ban_buon2 = New ClsControl2.TxtNumeric
        Me.Label31 = New System.Windows.Forms.Label
        Me.txtgia_ban_buon1 = New ClsControl2.TxtNumeric
        Me.Label30 = New System.Windows.Forms.Label
        Me.txtgia_ban_buon = New ClsControl2.TxtNumeric
        Me.Label29 = New System.Windows.Forms.Label
        Me.txtgia_ban_le = New ClsControl2.TxtNumeric
        Me.ten_tt5 = New System.Windows.Forms.Label
        Me.ten_tt4 = New System.Windows.Forms.Label
        Me.ten_tt3 = New System.Windows.Forms.Label
        Me.ten_tt2 = New System.Windows.Forms.Label
        Me.ten_tt1 = New System.Windows.Forms.Label
        Me.ten_dvt = New System.Windows.Forms.Label
        Me.ten_vt = New System.Windows.Forms.Label
        Me.txtden_ngay = New ClsControl2.TxtDate
        Me.txttu_ngay = New ClsControl2.TxtDate
        Me.txtma_tt5 = New System.Windows.Forms.TextBox
        Me.txtma_tt4 = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtma_tt3 = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtma_tt2 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtma_tt1 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtma_dvt = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtma_vt = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtnguoi_tao = New System.Windows.Forms.Label
        Me.txtngay_tao = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtngay_sua = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtnguoi_sua = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtma_kho = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLuu
        '
        Me.btnLuu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLuu.Location = New System.Drawing.Point(3, 496)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(54, 28)
        Me.btnLuu.TabIndex = 90
        Me.btnLuu.Tag = "094"
        Me.btnLuu.Text = "Luu"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'btnhuy
        '
        Me.btnhuy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnhuy.CausesValidation = False
        Me.btnhuy.Location = New System.Drawing.Point(59, 496)
        Me.btnhuy.Name = "btnhuy"
        Me.btnhuy.Size = New System.Drawing.Size(54, 28)
        Me.btnhuy.TabIndex = 91
        Me.btnhuy.Tag = "095"
        Me.btnhuy.Text = "Huy"
        Me.btnhuy.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.txtma_kho)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.chbgia_chua_gom_vat)
        Me.GroupBox1.Controls.Add(Me.txtnh_kh1)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtma_kh)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtnh_vt1)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtnganh_hang)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.chbtrang_thai)
        Me.GroupBox1.Controls.Add(Me.Label39)
        Me.GroupBox1.Controls.Add(Me.txtgia_ban_buon3)
        Me.GroupBox1.Controls.Add(Me.Label34)
        Me.GroupBox1.Controls.Add(Me.txttien_giam)
        Me.GroupBox1.Controls.Add(Me.Label33)
        Me.GroupBox1.Controls.Add(Me.txtty_le_giam_gia)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.txtgia_ban_buon2)
        Me.GroupBox1.Controls.Add(Me.Label31)
        Me.GroupBox1.Controls.Add(Me.txtgia_ban_buon1)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.txtgia_ban_buon)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.txtgia_ban_le)
        Me.GroupBox1.Controls.Add(Me.ten_tt5)
        Me.GroupBox1.Controls.Add(Me.ten_tt4)
        Me.GroupBox1.Controls.Add(Me.ten_tt3)
        Me.GroupBox1.Controls.Add(Me.ten_tt2)
        Me.GroupBox1.Controls.Add(Me.ten_tt1)
        Me.GroupBox1.Controls.Add(Me.ten_dvt)
        Me.GroupBox1.Controls.Add(Me.ten_vt)
        Me.GroupBox1.Controls.Add(Me.txtden_ngay)
        Me.GroupBox1.Controls.Add(Me.txttu_ngay)
        Me.GroupBox1.Controls.Add(Me.txtma_tt5)
        Me.GroupBox1.Controls.Add(Me.txtma_tt4)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtma_tt3)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtma_tt2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtma_tt1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtma_dvt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtma_vt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(-7, -7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(563, 490)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'chbgia_chua_gom_vat
        '
        Me.chbgia_chua_gom_vat.AutoSize = True
        Me.chbgia_chua_gom_vat.Location = New System.Drawing.Point(166, 437)
        Me.chbgia_chua_gom_vat.Name = "chbgia_chua_gom_vat"
        Me.chbgia_chua_gom_vat.Size = New System.Drawing.Size(143, 17)
        Me.chbgia_chua_gom_vat.TabIndex = 21
        Me.chbgia_chua_gom_vat.Tag = "315"
        Me.chbgia_chua_gom_vat.Text = "Gia chua gom the GTGT"
        Me.chbgia_chua_gom_vat.UseVisualStyleBackColor = True
        '
        'txtnh_kh1
        '
        Me.txtnh_kh1.Location = New System.Drawing.Point(166, 254)
        Me.txtnh_kh1.MaxLength = 64
        Me.txtnh_kh1.Name = "txtnh_kh1"
        Me.txtnh_kh1.Size = New System.Drawing.Size(353, 20)
        Me.txtnh_kh1.TabIndex = 11
        Me.txtnh_kh1.Tag = "B"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 258)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 13)
        Me.Label14.TabIndex = 220
        Me.Label14.Tag = "314"
        Me.Label14.Text = "Nhom khach"
        '
        'txtma_kh
        '
        Me.txtma_kh.Location = New System.Drawing.Point(166, 230)
        Me.txtma_kh.MaxLength = 64
        Me.txtma_kh.Name = "txtma_kh"
        Me.txtma_kh.Size = New System.Drawing.Size(353, 20)
        Me.txtma_kh.TabIndex = 10
        Me.txtma_kh.Tag = "B"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(12, 234)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(54, 13)
        Me.Label17.TabIndex = 218
        Me.Label17.Tag = "313"
        Me.Label17.Text = "ma khach"
        '
        'txtnh_vt1
        '
        Me.txtnh_vt1.Location = New System.Drawing.Point(166, 207)
        Me.txtnh_vt1.MaxLength = 64
        Me.txtnh_vt1.Name = "txtnh_vt1"
        Me.txtnh_vt1.Size = New System.Drawing.Size(353, 20)
        Me.txtnh_vt1.TabIndex = 9
        Me.txtnh_vt1.Tag = "B"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(12, 209)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 13)
        Me.Label16.TabIndex = 215
        Me.Label16.Tag = "312"
        Me.Label16.Text = "Nhom hang"
        '
        'txtnganh_hang
        '
        Me.txtnganh_hang.Location = New System.Drawing.Point(166, 182)
        Me.txtnganh_hang.MaxLength = 64
        Me.txtnganh_hang.Name = "txtnganh_hang"
        Me.txtnganh_hang.Size = New System.Drawing.Size(353, 20)
        Me.txtnganh_hang.TabIndex = 8
        Me.txtnganh_hang.Tag = "B"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(12, 184)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 13)
        Me.Label15.TabIndex = 212
        Me.Label15.Tag = "311"
        Me.Label15.Text = "nganh hang"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(304, 403)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 13)
        Me.Label12.TabIndex = 210
        Me.Label12.Tag = "310"
        Me.Label12.Text = "Den ngay"
        '
        'chbtrang_thai
        '
        Me.chbtrang_thai.AutoSize = True
        Me.chbtrang_thai.Location = New System.Drawing.Point(166, 460)
        Me.chbtrang_thai.Name = "chbtrang_thai"
        Me.chbtrang_thai.Size = New System.Drawing.Size(74, 17)
        Me.chbtrang_thai.TabIndex = 22
        Me.chbtrang_thai.Tag = "089"
        Me.chbtrang_thai.Text = "Trang thai"
        Me.chbtrang_thai.UseVisualStyleBackColor = True
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(12, 356)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(80, 13)
        Me.Label39.TabIndex = 208
        Me.Label39.Tag = "306"
        Me.Label39.Text = "Gia ban buon 4"
        '
        'txtgia_ban_buon3
        '
        Me.txtgia_ban_buon3.Location = New System.Drawing.Point(166, 352)
        Me.txtgia_ban_buon3.MaxLength = 18
        Me.txtgia_ban_buon3.Name = "txtgia_ban_buon3"
        Me.txtgia_ban_buon3.NumberDecimalDigits = 2
        Me.txtgia_ban_buon3.Size = New System.Drawing.Size(123, 20)
        Me.txtgia_ban_buon3.TabIndex = 16
        Me.txtgia_ban_buon3.Text = "0.00"
        Me.txtgia_ban_buon3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtgia_ban_buon3.Value = 0
        Me.txtgia_ban_buon3.Value2 = 0
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(304, 379)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(53, 13)
        Me.Label34.TabIndex = 207
        Me.Label34.Tag = "308"
        Me.Label34.Text = "Tien giam"
        '
        'txttien_giam
        '
        Me.txttien_giam.Location = New System.Drawing.Point(405, 375)
        Me.txttien_giam.MaxLength = 18
        Me.txttien_giam.Name = "txttien_giam"
        Me.txttien_giam.NumberDecimalDigits = 2
        Me.txttien_giam.Size = New System.Drawing.Size(114, 20)
        Me.txttien_giam.TabIndex = 18
        Me.txttien_giam.Text = "0.00"
        Me.txttien_giam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txttien_giam.Value = 0
        Me.txttien_giam.Value2 = 0
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(12, 379)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(55, 13)
        Me.Label33.TabIndex = 206
        Me.Label33.Tag = "307"
        Me.Label33.Text = "Ty le giam"
        '
        'txtty_le_giam_gia
        '
        Me.txtty_le_giam_gia.Location = New System.Drawing.Point(166, 375)
        Me.txtty_le_giam_gia.MaxLength = 18
        Me.txtty_le_giam_gia.Name = "txtty_le_giam_gia"
        Me.txtty_le_giam_gia.NumberDecimalDigits = 2
        Me.txtty_le_giam_gia.Size = New System.Drawing.Size(122, 20)
        Me.txtty_le_giam_gia.TabIndex = 17
        Me.txtty_le_giam_gia.Text = "0.00"
        Me.txtty_le_giam_gia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtty_le_giam_gia.Value = 0
        Me.txtty_le_giam_gia.Value2 = 0
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(304, 332)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(80, 13)
        Me.Label32.TabIndex = 205
        Me.Label32.Tag = "305"
        Me.Label32.Text = "Gia ban buon 3"
        '
        'txtgia_ban_buon2
        '
        Me.txtgia_ban_buon2.Location = New System.Drawing.Point(405, 328)
        Me.txtgia_ban_buon2.MaxLength = 18
        Me.txtgia_ban_buon2.Name = "txtgia_ban_buon2"
        Me.txtgia_ban_buon2.NumberDecimalDigits = 2
        Me.txtgia_ban_buon2.Size = New System.Drawing.Size(114, 20)
        Me.txtgia_ban_buon2.TabIndex = 15
        Me.txtgia_ban_buon2.Text = "0.00"
        Me.txtgia_ban_buon2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtgia_ban_buon2.Value = 0
        Me.txtgia_ban_buon2.Value2 = 0
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(12, 332)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(80, 13)
        Me.Label31.TabIndex = 204
        Me.Label31.Tag = "304"
        Me.Label31.Text = "Gia ban buon 2"
        '
        'txtgia_ban_buon1
        '
        Me.txtgia_ban_buon1.Location = New System.Drawing.Point(166, 328)
        Me.txtgia_ban_buon1.MaxLength = 18
        Me.txtgia_ban_buon1.Name = "txtgia_ban_buon1"
        Me.txtgia_ban_buon1.NumberDecimalDigits = 2
        Me.txtgia_ban_buon1.Size = New System.Drawing.Size(122, 20)
        Me.txtgia_ban_buon1.TabIndex = 14
        Me.txtgia_ban_buon1.Text = "0.00"
        Me.txtgia_ban_buon1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtgia_ban_buon1.Value = 0
        Me.txtgia_ban_buon1.Value2 = 0
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(304, 308)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(80, 13)
        Me.Label30.TabIndex = 203
        Me.Label30.Tag = "303"
        Me.Label30.Text = "Gia ban buon 1"
        '
        'txtgia_ban_buon
        '
        Me.txtgia_ban_buon.Location = New System.Drawing.Point(405, 304)
        Me.txtgia_ban_buon.MaxLength = 18
        Me.txtgia_ban_buon.Name = "txtgia_ban_buon"
        Me.txtgia_ban_buon.NumberDecimalDigits = 2
        Me.txtgia_ban_buon.Size = New System.Drawing.Size(114, 20)
        Me.txtgia_ban_buon.TabIndex = 13
        Me.txtgia_ban_buon.Text = "0.00"
        Me.txtgia_ban_buon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtgia_ban_buon.Value = 0
        Me.txtgia_ban_buon.Value2 = 0
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(12, 308)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(55, 13)
        Me.Label29.TabIndex = 202
        Me.Label29.Tag = "302"
        Me.Label29.Text = "Gia ban le"
        '
        'txtgia_ban_le
        '
        Me.txtgia_ban_le.Location = New System.Drawing.Point(166, 304)
        Me.txtgia_ban_le.MaxLength = 18
        Me.txtgia_ban_le.Name = "txtgia_ban_le"
        Me.txtgia_ban_le.NumberDecimalDigits = 2
        Me.txtgia_ban_le.Size = New System.Drawing.Size(122, 20)
        Me.txtgia_ban_le.TabIndex = 13
        Me.txtgia_ban_le.Text = "0.00"
        Me.txtgia_ban_le.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtgia_ban_le.Value = 0
        Me.txtgia_ban_le.Value2 = 0
        '
        'ten_tt5
        '
        Me.ten_tt5.AutoSize = True
        Me.ten_tt5.Location = New System.Drawing.Point(304, 160)
        Me.ten_tt5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ten_tt5.Name = "ten_tt5"
        Me.ten_tt5.Size = New System.Drawing.Size(40, 13)
        Me.ten_tt5.TabIndex = 109
        Me.ten_tt5.Text = "ten_tt5"
        '
        'ten_tt4
        '
        Me.ten_tt4.AutoSize = True
        Me.ten_tt4.Location = New System.Drawing.Point(304, 136)
        Me.ten_tt4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ten_tt4.Name = "ten_tt4"
        Me.ten_tt4.Size = New System.Drawing.Size(40, 13)
        Me.ten_tt4.TabIndex = 109
        Me.ten_tt4.Text = "ten_tt4"
        '
        'ten_tt3
        '
        Me.ten_tt3.AutoSize = True
        Me.ten_tt3.Location = New System.Drawing.Point(304, 111)
        Me.ten_tt3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ten_tt3.Name = "ten_tt3"
        Me.ten_tt3.Size = New System.Drawing.Size(40, 13)
        Me.ten_tt3.TabIndex = 109
        Me.ten_tt3.Text = "ten_tt3"
        '
        'ten_tt2
        '
        Me.ten_tt2.AutoSize = True
        Me.ten_tt2.Location = New System.Drawing.Point(304, 87)
        Me.ten_tt2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ten_tt2.Name = "ten_tt2"
        Me.ten_tt2.Size = New System.Drawing.Size(40, 13)
        Me.ten_tt2.TabIndex = 109
        Me.ten_tt2.Text = "ten_tt2"
        '
        'ten_tt1
        '
        Me.ten_tt1.AutoSize = True
        Me.ten_tt1.Location = New System.Drawing.Point(304, 63)
        Me.ten_tt1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ten_tt1.Name = "ten_tt1"
        Me.ten_tt1.Size = New System.Drawing.Size(40, 13)
        Me.ten_tt1.TabIndex = 109
        Me.ten_tt1.Text = "ten_tt1"
        '
        'ten_dvt
        '
        Me.ten_dvt.AutoSize = True
        Me.ten_dvt.Location = New System.Drawing.Point(304, 38)
        Me.ten_dvt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ten_dvt.Name = "ten_dvt"
        Me.ten_dvt.Size = New System.Drawing.Size(43, 13)
        Me.ten_dvt.TabIndex = 109
        Me.ten_dvt.Text = "ten_dvt"
        '
        'ten_vt
        '
        Me.ten_vt.AutoSize = True
        Me.ten_vt.Location = New System.Drawing.Point(304, 14)
        Me.ten_vt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ten_vt.Name = "ten_vt"
        Me.ten_vt.Size = New System.Drawing.Size(37, 13)
        Me.ten_vt.TabIndex = 108
        Me.ten_vt.Text = "ten_vt"
        '
        'txtden_ngay
        '
        Me.txtden_ngay.Location = New System.Drawing.Point(405, 399)
        Me.txtden_ngay.Margin = New System.Windows.Forms.Padding(2)
        Me.txtden_ngay.Mask = "00/00/0000"
        Me.txtden_ngay.Name = "txtden_ngay"
        Me.txtden_ngay.Size = New System.Drawing.Size(114, 20)
        Me.txtden_ngay.TabIndex = 20
        Me.txtden_ngay.Text = "01011910"
        Me.txtden_ngay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtden_ngay.Value = New Date(1910, 1, 1, 0, 0, 0, 0)
        '
        'txttu_ngay
        '
        Me.txttu_ngay.Location = New System.Drawing.Point(166, 399)
        Me.txttu_ngay.Margin = New System.Windows.Forms.Padding(2)
        Me.txttu_ngay.Mask = "00/00/0000"
        Me.txttu_ngay.Name = "txttu_ngay"
        Me.txttu_ngay.Size = New System.Drawing.Size(122, 20)
        Me.txttu_ngay.TabIndex = 19
        Me.txttu_ngay.Text = "01011910"
        Me.txttu_ngay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txttu_ngay.Value = New Date(1910, 1, 1, 0, 0, 0, 0)
        '
        'txtma_tt5
        '
        Me.txtma_tt5.Location = New System.Drawing.Point(166, 158)
        Me.txtma_tt5.MaxLength = 64
        Me.txtma_tt5.Name = "txtma_tt5"
        Me.txtma_tt5.Size = New System.Drawing.Size(123, 20)
        Me.txtma_tt5.TabIndex = 7
        '
        'txtma_tt4
        '
        Me.txtma_tt4.Location = New System.Drawing.Point(166, 133)
        Me.txtma_tt4.MaxLength = 64
        Me.txtma_tt4.Name = "txtma_tt4"
        Me.txtma_tt4.Size = New System.Drawing.Size(123, 20)
        Me.txtma_tt4.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 403)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 13)
        Me.Label13.TabIndex = 15
        Me.Label13.Tag = "309"
        Me.Label13.Text = "hieu luc tu ngay"
        '
        'txtma_tt3
        '
        Me.txtma_tt3.Location = New System.Drawing.Point(166, 109)
        Me.txtma_tt3.MaxLength = 64
        Me.txtma_tt3.Name = "txtma_tt3"
        Me.txtma_tt3.Size = New System.Drawing.Size(123, 20)
        Me.txtma_tt3.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 160)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 13)
        Me.Label11.TabIndex = 15
        Me.Label11.Tag = "007"
        Me.Label11.Text = "ma tt5"
        '
        'txtma_tt2
        '
        Me.txtma_tt2.Location = New System.Drawing.Point(166, 84)
        Me.txtma_tt2.MaxLength = 64
        Me.txtma_tt2.Name = "txtma_tt2"
        Me.txtma_tt2.Size = New System.Drawing.Size(123, 20)
        Me.txtma_tt2.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Tag = "006"
        Me.Label9.Text = "ma tt4"
        '
        'txtma_tt1
        '
        Me.txtma_tt1.Location = New System.Drawing.Point(166, 60)
        Me.txtma_tt1.MaxLength = 64
        Me.txtma_tt1.Name = "txtma_tt1"
        Me.txtma_tt1.Size = New System.Drawing.Size(123, 20)
        Me.txtma_tt1.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Tag = "005"
        Me.Label7.Text = "ma tt3"
        '
        'txtma_dvt
        '
        Me.txtma_dvt.Location = New System.Drawing.Point(166, 36)
        Me.txtma_dvt.MaxLength = 64
        Me.txtma_dvt.Name = "txtma_dvt"
        Me.txtma_dvt.Size = New System.Drawing.Size(123, 20)
        Me.txtma_dvt.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Tag = "004"
        Me.Label2.Text = "ma tt2"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 38)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 107
        Me.Label10.Tag = "002"
        Me.Label10.Text = "ma dvt"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Tag = "003"
        Me.Label4.Text = "ma tt1"
        '
        'txtma_vt
        '
        Me.txtma_vt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtma_vt.Location = New System.Drawing.Point(166, 11)
        Me.txtma_vt.MaxLength = 16
        Me.txtma_vt.Name = "txtma_vt"
        Me.txtma_vt.Size = New System.Drawing.Size(123, 20)
        Me.txtma_vt.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Tag = "001"
        Me.Label1.Text = "ma vt"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(0, 533)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Tag = "090"
        Me.Label3.Text = "Nguoi tao:"
        '
        'txtnguoi_tao
        '
        Me.txtnguoi_tao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtnguoi_tao.AutoSize = True
        Me.txtnguoi_tao.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtnguoi_tao.Location = New System.Drawing.Point(67, 533)
        Me.txtnguoi_tao.Name = "txtnguoi_tao"
        Me.txtnguoi_tao.Size = New System.Drawing.Size(51, 13)
        Me.txtnguoi_tao.TabIndex = 14
        Me.txtnguoi_tao.Text = "nguoi tao"
        '
        'txtngay_tao
        '
        Me.txtngay_tao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtngay_tao.AutoSize = True
        Me.txtngay_tao.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtngay_tao.Location = New System.Drawing.Point(225, 533)
        Me.txtngay_tao.Name = "txtngay_tao"
        Me.txtngay_tao.Size = New System.Drawing.Size(48, 13)
        Me.txtngay_tao.TabIndex = 16
        Me.txtngay_tao.Text = "ngay tao"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(158, 533)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Tag = "092"
        Me.Label6.Text = "Ngay tao:"
        '
        'txtngay_sua
        '
        Me.txtngay_sua.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtngay_sua.AutoSize = True
        Me.txtngay_sua.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtngay_sua.Location = New System.Drawing.Point(225, 548)
        Me.txtngay_sua.Name = "txtngay_sua"
        Me.txtngay_sua.Size = New System.Drawing.Size(50, 13)
        Me.txtngay_sua.TabIndex = 20
        Me.txtngay_sua.Text = "ngay sua"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(158, 548)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Tag = "093"
        Me.Label5.Text = "Ngay sua:"
        '
        'txtnguoi_sua
        '
        Me.txtnguoi_sua.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtnguoi_sua.AutoSize = True
        Me.txtnguoi_sua.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtnguoi_sua.Location = New System.Drawing.Point(67, 548)
        Me.txtnguoi_sua.Name = "txtnguoi_sua"
        Me.txtnguoi_sua.Size = New System.Drawing.Size(53, 13)
        Me.txtnguoi_sua.TabIndex = 18
        Me.txtnguoi_sua.Text = "nguoi sua"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(0, 548)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Tag = "091"
        Me.Label8.Text = "Nguoi sua:"
        '
        'txtma_kho
        '
        Me.txtma_kho.Location = New System.Drawing.Point(166, 278)
        Me.txtma_kho.MaxLength = 64
        Me.txtma_kho.Name = "txtma_kho"
        Me.txtma_kho.Size = New System.Drawing.Size(353, 20)
        Me.txtma_kho.TabIndex = 12
        Me.txtma_kho.Tag = "B"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(12, 282)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(26, 13)
        Me.Label18.TabIndex = 222
        Me.Label18.Tag = "KHO"
        Me.Label18.Text = "Kho"
        '
        'frminput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 567)
        Me.Controls.Add(Me.txtngay_sua)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtnguoi_sua)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtngay_tao)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtnguoi_tao)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnhuy)
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frminput"
        Me.Tag = "000"
        Me.Text = "frminput"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLuu As System.Windows.Forms.Button
    Friend WithEvents btnhuy As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtnguoi_tao As System.Windows.Forms.Label
    Friend WithEvents txtngay_tao As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtngay_sua As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtnguoi_sua As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtma_vt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtma_tt1 As System.Windows.Forms.TextBox
    Friend WithEvents txtma_dvt As System.Windows.Forms.TextBox
    Friend WithEvents txtma_tt5 As System.Windows.Forms.TextBox
    Friend WithEvents txtma_tt4 As System.Windows.Forms.TextBox
    Friend WithEvents txtma_tt3 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtma_tt2 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtden_ngay As ClsControl2.TxtDate
    Friend WithEvents txttu_ngay As ClsControl2.TxtDate
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ten_dvt As System.Windows.Forms.Label
    Friend WithEvents ten_vt As System.Windows.Forms.Label
    Friend WithEvents ten_tt1 As System.Windows.Forms.Label
    Friend WithEvents ten_tt2 As System.Windows.Forms.Label
    Friend WithEvents ten_tt5 As System.Windows.Forms.Label
    Friend WithEvents ten_tt4 As System.Windows.Forms.Label
    Friend WithEvents ten_tt3 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents txtgia_ban_buon3 As ClsControl2.TxtNumeric
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txttien_giam As ClsControl2.TxtNumeric
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtty_le_giam_gia As ClsControl2.TxtNumeric
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtgia_ban_buon2 As ClsControl2.TxtNumeric
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtgia_ban_buon1 As ClsControl2.TxtNumeric
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtgia_ban_buon As ClsControl2.TxtNumeric
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtgia_ban_le As ClsControl2.TxtNumeric
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents chbtrang_thai As System.Windows.Forms.CheckBox
    Friend WithEvents txtnganh_hang As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtma_kh As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtnh_vt1 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtnh_kh1 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents chbgia_chua_gom_vat As System.Windows.Forms.CheckBox
    Friend WithEvents txtma_kho As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
End Class
