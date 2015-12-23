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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frminput))
        Me.btnLuu = New System.Windows.Forms.Button
        Me.btnhuy = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.btnphan_bo = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cbbstatus = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.TSgetdata = New System.Windows.Forms.ToolStrip
        Me.TSDropDownGetdata = New System.Windows.Forms.ToolStripDropDownButton
        Me.btnlaydulieutudonhang = New System.Windows.Forms.ToolStripMenuItem
        Me.LayDuLieuTuPhieuNhapHangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.Txtty_gia = New ClsControl2.TxtNumeric
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtdia_chi = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtong_ba = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtten_kh = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtma_kh = New System.Windows.Forms.TextBox
        Me.Txtngay_ct = New ClsControl2.TxtDate
        Me.Label11 = New System.Windows.Forms.Label
        Me.cbbma_nt = New System.Windows.Forms.ComboBox
        Me.txtdien_giai = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtso_ct = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtnguoi_tao = New System.Windows.Forms.Label
        Me.txtngay_tao = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtngay_sua = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtnguoi_sua = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnluuandmoi = New System.Windows.Forms.Button
        Me.txtt_tt_nt = New ClsControl2.TxtNumeric
        Me.txtt_tt = New ClsControl2.TxtNumeric
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtt_thue_nt = New ClsControl2.TxtNumeric
        Me.txtt_thue = New ClsControl2.TxtNumeric
        Me.Label10 = New System.Windows.Forms.Label
        Me.Txtt_tien_nt = New ClsControl2.TxtNumeric
        Me.Ltien = New System.Windows.Forms.Label
        Me.Txtt_tien = New ClsControl2.TxtNumeric
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtt_cp_nt = New ClsControl2.TxtNumeric
        Me.txtt_cp = New ClsControl2.TxtNumeric
        Me.Label25 = New System.Windows.Forms.Label
        Me.Txtt_sl = New ClsControl2.TxtNumeric
        Me.Label17 = New System.Windows.Forms.Label
        Me.Txtt_thue_nk_nt = New ClsControl2.TxtNumeric
        Me.Txtt_thue_nk = New ClsControl2.TxtNumeric
        Me.cbbkieu_pb = New System.Windows.Forms.ComboBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TSgetdata.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLuu
        '
        Me.btnLuu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLuu.Location = New System.Drawing.Point(3, 391)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(81, 48)
        Me.btnLuu.TabIndex = 99
        Me.btnLuu.Tag = "094"
        Me.btnLuu.Text = "Luu"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'btnhuy
        '
        Me.btnhuy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnhuy.CausesValidation = False
        Me.btnhuy.Location = New System.Drawing.Point(173, 391)
        Me.btnhuy.Name = "btnhuy"
        Me.btnhuy.Size = New System.Drawing.Size(78, 48)
        Me.btnhuy.TabIndex = 200
        Me.btnhuy.Tag = "095"
        Me.btnhuy.Text = "Huy"
        Me.btnhuy.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Controls.Add(Me.Txtty_gia)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Txtngay_ct)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cbbma_nt)
        Me.GroupBox1.Controls.Add(Me.txtdien_giai)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtso_ct)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(-6, -8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(982, 336)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.cbbkieu_pb)
        Me.GroupBox4.Controls.Add(Me.btnphan_bo)
        Me.GroupBox4.Location = New System.Drawing.Point(11, 113)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(448, 53)
        Me.GroupBox4.TabIndex = 212
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Tag = "205"
        Me.GroupBox4.Text = "Phan bo chi phi"
        '
        'btnphan_bo
        '
        Me.btnphan_bo.Location = New System.Drawing.Point(367, 19)
        Me.btnphan_bo.Name = "btnphan_bo"
        Me.btnphan_bo.Size = New System.Drawing.Size(75, 23)
        Me.btnphan_bo.TabIndex = 4
        Me.btnphan_bo.TabStop = False
        Me.btnphan_bo.Tag = "202"
        Me.btnphan_bo.Text = "Phan bo"
        Me.btnphan_bo.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.MediumAquamarine
        Me.GroupBox3.Controls.Add(Me.cbbstatus)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.TSgetdata)
        Me.GroupBox3.Location = New System.Drawing.Point(2, -7)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(991, 42)
        Me.GroupBox3.TabIndex = 211
        Me.GroupBox3.TabStop = False
        '
        'cbbstatus
        '
        Me.cbbstatus.FormattingEnabled = True
        Me.cbbstatus.Location = New System.Drawing.Point(152, 17)
        Me.cbbstatus.Name = "cbbstatus"
        Me.cbbstatus.Size = New System.Drawing.Size(273, 21)
        Me.cbbstatus.TabIndex = 10
        Me.cbbstatus.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(90, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 13)
        Me.Label12.TabIndex = 202
        Me.Label12.Tag = "303"
        Me.Label12.Text = "trang thai"
        '
        'TSgetdata
        '
        Me.TSgetdata.BackColor = System.Drawing.Color.MediumAquamarine
        Me.TSgetdata.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.TSgetdata.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSDropDownGetdata, Me.ToolStripSeparator1})
        Me.TSgetdata.Location = New System.Drawing.Point(3, 16)
        Me.TSgetdata.Name = "TSgetdata"
        Me.TSgetdata.Size = New System.Drawing.Size(985, 25)
        Me.TSgetdata.TabIndex = 209
        Me.TSgetdata.Text = "ToolStrip1"
        '
        'TSDropDownGetdata
        '
        Me.TSDropDownGetdata.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.TSDropDownGetdata.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnlaydulieutudonhang, Me.LayDuLieuTuPhieuNhapHangToolStripMenuItem})
        Me.TSDropDownGetdata.Image = CType(resources.GetObject("TSDropDownGetdata.Image"), System.Drawing.Image)
        Me.TSDropDownGetdata.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSDropDownGetdata.Name = "TSDropDownGetdata"
        Me.TSDropDownGetdata.Size = New System.Drawing.Size(77, 22)
        Me.TSDropDownGetdata.Tag = "200"
        Me.TSDropDownGetdata.Text = "Lay du lieu"
        '
        'btnlaydulieutudonhang
        '
        Me.btnlaydulieutudonhang.Name = "btnlaydulieutudonhang"
        Me.btnlaydulieutudonhang.Size = New System.Drawing.Size(238, 22)
        Me.btnlaydulieutudonhang.Tag = "201"
        Me.btnlaydulieutudonhang.Text = "Lay du lieu tu don hang"
        '
        'LayDuLieuTuPhieuNhapHangToolStripMenuItem
        '
        Me.LayDuLieuTuPhieuNhapHangToolStripMenuItem.Name = "LayDuLieuTuPhieuNhapHangToolStripMenuItem"
        Me.LayDuLieuTuPhieuNhapHangToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.LayDuLieuTuPhieuNhapHangToolStripMenuItem.Tag = "009"
        Me.LayDuLieuTuPhieuNhapHangToolStripMenuItem.Text = "Lay du lieu tu phieu nhap hang"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Location = New System.Drawing.Point(4, 185)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(976, 151)
        Me.TabControl1.TabIndex = 40
        Me.TabControl1.TabStop = False
        '
        'Txtty_gia
        '
        Me.Txtty_gia.Location = New System.Drawing.Point(292, 86)
        Me.Txtty_gia.MaxLength = 18
        Me.Txtty_gia.Name = "Txtty_gia"
        Me.Txtty_gia.NumberDecimalDigits = 0
        Me.Txtty_gia.Size = New System.Drawing.Size(167, 20)
        Me.Txtty_gia.TabIndex = 4
        Me.Txtty_gia.Text = "0"
        Me.Txtty_gia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtty_gia.Value = 0
        Me.Txtty_gia.Value2 = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtdia_chi)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtong_ba)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtten_kh)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtma_kh)
        Me.GroupBox2.Location = New System.Drawing.Point(481, 36)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(492, 116)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Tag = "217"
        Me.GroupBox2.Text = "Khach hang"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(10, 66)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 13)
        Me.Label15.TabIndex = 11
        Me.Label15.Tag = "005"
        Me.Label15.Text = "Dia chi"
        '
        'txtdia_chi
        '
        Me.txtdia_chi.Location = New System.Drawing.Point(130, 63)
        Me.txtdia_chi.Name = "txtdia_chi"
        Me.txtdia_chi.ReadOnly = True
        Me.txtdia_chi.Size = New System.Drawing.Size(355, 20)
        Me.txtdia_chi.TabIndex = 6
        Me.txtdia_chi.TabStop = False
        Me.txtdia_chi.Tag = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(10, 90)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(101, 13)
        Me.Label14.TabIndex = 9
        Me.Label14.Tag = "218"
        Me.Label14.Text = "Ten nguoi giao dich"
        '
        'txtong_ba
        '
        Me.txtong_ba.Location = New System.Drawing.Point(130, 87)
        Me.txtong_ba.Name = "txtong_ba"
        Me.txtong_ba.Size = New System.Drawing.Size(355, 20)
        Me.txtong_ba.TabIndex = 7
        Me.txtong_ba.Tag = "F"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(10, 42)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 13)
        Me.Label13.TabIndex = 7
        Me.Label13.Tag = "002"
        Me.Label13.Text = "Ten khach hang"
        '
        'txtten_kh
        '
        Me.txtten_kh.Location = New System.Drawing.Point(130, 39)
        Me.txtten_kh.Name = "txtten_kh"
        Me.txtten_kh.ReadOnly = True
        Me.txtten_kh.Size = New System.Drawing.Size(355, 20)
        Me.txtten_kh.TabIndex = 5
        Me.txtten_kh.TabStop = False
        Me.txtten_kh.Tag = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Tag = "001"
        Me.Label4.Text = "Ma khach"
        '
        'txtma_kh
        '
        Me.txtma_kh.Location = New System.Drawing.Point(130, 15)
        Me.txtma_kh.Name = "txtma_kh"
        Me.txtma_kh.Size = New System.Drawing.Size(159, 20)
        Me.txtma_kh.TabIndex = 4
        Me.txtma_kh.Tag = ""
        '
        'Txtngay_ct
        '
        Me.Txtngay_ct.Location = New System.Drawing.Point(315, 38)
        Me.Txtngay_ct.Mask = "00/00/0000"
        Me.Txtngay_ct.Name = "Txtngay_ct"
        Me.Txtngay_ct.Size = New System.Drawing.Size(144, 20)
        Me.Txtngay_ct.TabIndex = 1
        Me.Txtngay_ct.Text = "01011910"
        Me.Txtngay_ct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtngay_ct.Value = New Date(1910, 1, 1, 0, 0, 0, 0)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 86)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 37
        Me.Label11.Tag = "215"
        Me.Label11.Text = "ngoai te"
        '
        'cbbma_nt
        '
        Me.cbbma_nt.FormattingEnabled = True
        Me.cbbma_nt.Location = New System.Drawing.Point(126, 86)
        Me.cbbma_nt.Name = "cbbma_nt"
        Me.cbbma_nt.Size = New System.Drawing.Size(159, 21)
        Me.cbbma_nt.TabIndex = 3
        '
        'txtdien_giai
        '
        Me.txtdien_giai.Location = New System.Drawing.Point(126, 62)
        Me.txtdien_giai.Name = "txtdien_giai"
        Me.txtdien_giai.Size = New System.Drawing.Size(333, 20)
        Me.txtdien_giai.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Tag = "214"
        Me.Label7.Text = "Dien giai"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(234, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Tag = "221"
        Me.Label2.Text = "ngay ct"
        '
        'txtso_ct
        '
        Me.txtso_ct.Location = New System.Drawing.Point(126, 38)
        Me.txtso_ct.Name = "txtso_ct"
        Me.txtso_ct.Size = New System.Drawing.Size(100, 20)
        Me.txtso_ct.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Tag = "220"
        Me.Label1.Text = "So chung tu"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(0, 439)
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
        Me.txtnguoi_tao.Location = New System.Drawing.Point(67, 439)
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
        Me.txtngay_tao.Location = New System.Drawing.Point(225, 439)
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
        Me.Label6.Location = New System.Drawing.Point(158, 439)
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
        Me.txtngay_sua.Location = New System.Drawing.Point(225, 454)
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
        Me.Label5.Location = New System.Drawing.Point(158, 454)
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
        Me.txtnguoi_sua.Location = New System.Drawing.Point(67, 454)
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
        Me.Label8.Location = New System.Drawing.Point(0, 454)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Tag = "091"
        Me.Label8.Text = "Nguoi sua:"
        '
        'btnluuandmoi
        '
        Me.btnluuandmoi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnluuandmoi.Location = New System.Drawing.Point(87, 391)
        Me.btnluuandmoi.Name = "btnluuandmoi"
        Me.btnluuandmoi.Size = New System.Drawing.Size(82, 48)
        Me.btnluuandmoi.TabIndex = 100
        Me.btnluuandmoi.Tag = "219"
        Me.btnluuandmoi.Text = "Luu va them moi"
        Me.btnluuandmoi.UseVisualStyleBackColor = True
        '
        'txtt_tt_nt
        '
        Me.txtt_tt_nt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtt_tt_nt.Location = New System.Drawing.Point(702, 427)
        Me.txtt_tt_nt.MaxLength = 0
        Me.txtt_tt_nt.Name = "txtt_tt_nt"
        Me.txtt_tt_nt.NumberDecimalDigits = 2
        Me.txtt_tt_nt.ReadOnly = True
        Me.txtt_tt_nt.Size = New System.Drawing.Size(130, 20)
        Me.txtt_tt_nt.TabIndex = 210
        Me.txtt_tt_nt.Text = "0.00"
        Me.txtt_tt_nt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtt_tt_nt.Value = 0
        Me.txtt_tt_nt.Value2 = 0
        '
        'txtt_tt
        '
        Me.txtt_tt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtt_tt.Location = New System.Drawing.Point(838, 427)
        Me.txtt_tt.MaxLength = 0
        Me.txtt_tt.Name = "txtt_tt"
        Me.txtt_tt.NumberDecimalDigits = 0
        Me.txtt_tt.ReadOnly = True
        Me.txtt_tt.Size = New System.Drawing.Size(130, 20)
        Me.txtt_tt.TabIndex = 211
        Me.txtt_tt.Text = "0"
        Me.txtt_tt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtt_tt.Value = 0
        Me.txtt_tt.Value2 = 0
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(603, 430)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(82, 13)
        Me.Label16.TabIndex = 212
        Me.Label16.Tag = "411"
        Me.Label16.Text = "tong thanh toan"
        '
        'txtt_thue_nt
        '
        Me.txtt_thue_nt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtt_thue_nt.Location = New System.Drawing.Point(702, 403)
        Me.txtt_thue_nt.MaxLength = 0
        Me.txtt_thue_nt.Name = "txtt_thue_nt"
        Me.txtt_thue_nt.NumberDecimalDigits = 2
        Me.txtt_thue_nt.ReadOnly = True
        Me.txtt_thue_nt.Size = New System.Drawing.Size(130, 20)
        Me.txtt_thue_nt.TabIndex = 208
        Me.txtt_thue_nt.Text = "0.00"
        Me.txtt_thue_nt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtt_thue_nt.Value = 0
        Me.txtt_thue_nt.Value2 = 0
        '
        'txtt_thue
        '
        Me.txtt_thue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtt_thue.Location = New System.Drawing.Point(838, 403)
        Me.txtt_thue.MaxLength = 0
        Me.txtt_thue.Name = "txtt_thue"
        Me.txtt_thue.NumberDecimalDigits = 0
        Me.txtt_thue.ReadOnly = True
        Me.txtt_thue.Size = New System.Drawing.Size(130, 20)
        Me.txtt_thue.TabIndex = 209
        Me.txtt_thue.Text = "0"
        Me.txtt_thue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtt_thue.Value = 0
        Me.txtt_thue.Value2 = 0
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(603, 336)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 13)
        Me.Label10.TabIndex = 206
        Me.Label10.Tag = "409"
        Me.Label10.Text = "Tien chua thue"
        '
        'Txtt_tien_nt
        '
        Me.Txtt_tien_nt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtt_tien_nt.Location = New System.Drawing.Point(702, 332)
        Me.Txtt_tien_nt.MaxLength = 0
        Me.Txtt_tien_nt.Name = "Txtt_tien_nt"
        Me.Txtt_tien_nt.NumberDecimalDigits = 2
        Me.Txtt_tien_nt.ReadOnly = True
        Me.Txtt_tien_nt.Size = New System.Drawing.Size(130, 20)
        Me.Txtt_tien_nt.TabIndex = 205
        Me.Txtt_tien_nt.Text = "0.00"
        Me.Txtt_tien_nt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtt_tien_nt.Value = 0
        Me.Txtt_tien_nt.Value2 = 0
        '
        'Ltien
        '
        Me.Ltien.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Ltien.AutoSize = True
        Me.Ltien.Location = New System.Drawing.Point(603, 406)
        Me.Ltien.Name = "Ltien"
        Me.Ltien.Size = New System.Drawing.Size(52, 13)
        Me.Ltien.TabIndex = 204
        Me.Ltien.Tag = "410"
        Me.Ltien.Text = "Tien thue"
        '
        'Txtt_tien
        '
        Me.Txtt_tien.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtt_tien.Location = New System.Drawing.Point(838, 332)
        Me.Txtt_tien.MaxLength = 0
        Me.Txtt_tien.Name = "Txtt_tien"
        Me.Txtt_tien.NumberDecimalDigits = 0
        Me.Txtt_tien.ReadOnly = True
        Me.Txtt_tien.Size = New System.Drawing.Size(130, 20)
        Me.Txtt_tien.TabIndex = 207
        Me.Txtt_tien.Text = "0"
        Me.Txtt_tien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtt_tien.Value = 0
        Me.Txtt_tien.Value2 = 0
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(603, 383)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 214
        Me.Label9.Tag = "419"
        Me.Label9.Text = "chi phi"
        '
        'txtt_cp_nt
        '
        Me.txtt_cp_nt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtt_cp_nt.Location = New System.Drawing.Point(702, 379)
        Me.txtt_cp_nt.MaxLength = 0
        Me.txtt_cp_nt.Name = "txtt_cp_nt"
        Me.txtt_cp_nt.NumberDecimalDigits = 2
        Me.txtt_cp_nt.ReadOnly = True
        Me.txtt_cp_nt.Size = New System.Drawing.Size(130, 20)
        Me.txtt_cp_nt.TabIndex = 213
        Me.txtt_cp_nt.Text = "0.00"
        Me.txtt_cp_nt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtt_cp_nt.Value = 0
        Me.txtt_cp_nt.Value2 = 0
        '
        'txtt_cp
        '
        Me.txtt_cp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtt_cp.Location = New System.Drawing.Point(838, 379)
        Me.txtt_cp.MaxLength = 0
        Me.txtt_cp.Name = "txtt_cp"
        Me.txtt_cp.NumberDecimalDigits = 0
        Me.txtt_cp.ReadOnly = True
        Me.txtt_cp.Size = New System.Drawing.Size(130, 20)
        Me.txtt_cp.TabIndex = 215
        Me.txtt_cp.Text = "0"
        Me.txtt_cp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtt_cp.Value = 0
        Me.txtt_cp.Value2 = 0
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(355, 336)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(75, 13)
        Me.Label25.TabIndex = 217
        Me.Label25.Tag = "418"
        Me.Label25.Text = "Tong so luong"
        '
        'Txtt_sl
        '
        Me.Txtt_sl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtt_sl.Location = New System.Drawing.Point(442, 332)
        Me.Txtt_sl.MaxLength = 0
        Me.Txtt_sl.Name = "Txtt_sl"
        Me.Txtt_sl.NumberDecimalDigits = 2
        Me.Txtt_sl.ReadOnly = True
        Me.Txtt_sl.Size = New System.Drawing.Size(129, 20)
        Me.Txtt_sl.TabIndex = 216
        Me.Txtt_sl.Text = "0.00"
        Me.Txtt_sl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtt_sl.Value = 0
        Me.Txtt_sl.Value2 = 0
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(603, 360)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(43, 13)
        Me.Label17.TabIndex = 219
        Me.Label17.Tag = "013"
        Me.Label17.Text = "thue nk"
        '
        'Txtt_thue_nk_nt
        '
        Me.Txtt_thue_nk_nt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtt_thue_nk_nt.Location = New System.Drawing.Point(702, 356)
        Me.Txtt_thue_nk_nt.MaxLength = 0
        Me.Txtt_thue_nk_nt.Name = "Txtt_thue_nk_nt"
        Me.Txtt_thue_nk_nt.NumberDecimalDigits = 2
        Me.Txtt_thue_nk_nt.ReadOnly = True
        Me.Txtt_thue_nk_nt.Size = New System.Drawing.Size(130, 20)
        Me.Txtt_thue_nk_nt.TabIndex = 218
        Me.Txtt_thue_nk_nt.Text = "0.00"
        Me.Txtt_thue_nk_nt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtt_thue_nk_nt.Value = 0
        Me.Txtt_thue_nk_nt.Value2 = 0
        '
        'Txtt_thue_nk
        '
        Me.Txtt_thue_nk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtt_thue_nk.Location = New System.Drawing.Point(838, 356)
        Me.Txtt_thue_nk.MaxLength = 0
        Me.Txtt_thue_nk.Name = "Txtt_thue_nk"
        Me.Txtt_thue_nk.NumberDecimalDigits = 0
        Me.Txtt_thue_nk.ReadOnly = True
        Me.Txtt_thue_nk.Size = New System.Drawing.Size(130, 20)
        Me.Txtt_thue_nk.TabIndex = 220
        Me.Txtt_thue_nk.Text = "0"
        Me.Txtt_thue_nk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtt_thue_nk.Value = 0
        Me.Txtt_thue_nk.Value2 = 0
        '
        'cbbkieu_pb
        '
        Me.cbbkieu_pb.FormattingEnabled = True
        Me.cbbkieu_pb.Location = New System.Drawing.Point(115, 20)
        Me.cbbkieu_pb.Name = "cbbkieu_pb"
        Me.cbbkieu_pb.Size = New System.Drawing.Size(246, 21)
        Me.cbbkieu_pb.TabIndex = 0
        Me.cbbkieu_pb.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(12, 24)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(70, 13)
        Me.Label18.TabIndex = 213
        Me.Label18.Tag = "206"
        Me.Label18.Text = "Kieu phan bo"
        '
        'frminput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 473)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Txtt_thue_nk_nt)
        Me.Controls.Add(Me.Txtt_thue_nk)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Txtt_sl)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtt_cp_nt)
        Me.Controls.Add(Me.txtt_cp)
        Me.Controls.Add(Me.txtt_tt_nt)
        Me.Controls.Add(Me.txtt_tt)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtt_thue_nt)
        Me.Controls.Add(Me.txtt_thue)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Txtt_tien_nt)
        Me.Controls.Add(Me.Ltien)
        Me.Controls.Add(Me.Txtt_tien)
        Me.Controls.Add(Me.btnluuandmoi)
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
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TSgetdata.ResumeLayout(False)
        Me.TSgetdata.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
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
    Friend WithEvents txtma_kh As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtso_ct As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtdien_giai As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbbma_nt As System.Windows.Forms.ComboBox
    Friend WithEvents Txtngay_ct As ClsControl2.TxtDate
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtdia_chi As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtong_ba As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtten_kh As System.Windows.Forms.TextBox
    Friend WithEvents btnluuandmoi As System.Windows.Forms.Button
    Friend WithEvents Txtty_gia As ClsControl2.TxtNumeric
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents txtt_tt_nt As ClsControl2.TxtNumeric
    Friend WithEvents txtt_tt As ClsControl2.TxtNumeric
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtt_thue_nt As ClsControl2.TxtNumeric
    Friend WithEvents txtt_thue As ClsControl2.TxtNumeric
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Txtt_tien_nt As ClsControl2.TxtNumeric
    Friend WithEvents Ltien As System.Windows.Forms.Label
    Friend WithEvents Txtt_tien As ClsControl2.TxtNumeric
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cbbstatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtt_cp_nt As ClsControl2.TxtNumeric
    Friend WithEvents txtt_cp As ClsControl2.TxtNumeric
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Txtt_sl As ClsControl2.TxtNumeric
    Friend WithEvents btnphan_bo As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Txtt_thue_nk_nt As ClsControl2.TxtNumeric
    Friend WithEvents Txtt_thue_nk As ClsControl2.TxtNumeric
    Friend WithEvents TSgetdata As System.Windows.Forms.ToolStrip
    Friend WithEvents TSDropDownGetdata As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents btnlaydulieutudonhang As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LayDuLieuTuPhieuNhapHangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cbbkieu_pb As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
End Class
