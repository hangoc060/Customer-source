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
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.txtten_vt = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtso_seri = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtngay_hd = New ClsControl2.TxtDate
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtso_hd = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Txtty_gia = New ClsControl2.TxtNumeric
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ma_thue = New System.Windows.Forms.Label
        Me.txtma_so_thue = New System.Windows.Forms.TextBox
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
        Me.cbbstatus = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtnguoi_tao = New System.Windows.Forms.Label
        Me.txtngay_tao = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtngay_sua = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtnguoi_sua = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.btnluuandmoi = New System.Windows.Forms.Button
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtt_tt_nt = New ClsControl2.TxtNumeric
        Me.txtt_tt = New ClsControl2.TxtNumeric
        Me.txtt_thue_nt = New ClsControl2.TxtNumeric
        Me.txtt_thue = New ClsControl2.TxtNumeric
        Me.Txtt_ck_nt = New ClsControl2.TxtNumeric
        Me.Txtt_ck = New ClsControl2.TxtNumeric
        Me.Txtt_tien_nt = New ClsControl2.TxtNumeric
        Me.Txtt_tien = New ClsControl2.TxtNumeric
        Me.toolbar = New System.Windows.Forms.ToolStrip
        Me.TSDropDownGetdata = New System.Windows.Forms.ToolStripDropDownButton
        Me.btnlaydulieutudonhang = New System.Windows.Forms.ToolStripMenuItem
        Me.Txtt_sl = New ClsControl2.TxtNumeric
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Txtt_tien_von = New ClsControl2.TxtNumeric
        Me.Label9 = New System.Windows.Forms.Label
        Me.Txtt_ck_hd_nt = New ClsControl2.TxtNumeric
        Me.Txtt_ck_hd = New ClsControl2.TxtNumeric
        Me.txtky_hieu_hoa_don = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtma_hoa_don = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.toolbar.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLuu
        '
        Me.btnLuu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLuu.Location = New System.Drawing.Point(3, 389)
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
        Me.btnhuy.Location = New System.Drawing.Point(173, 389)
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
        Me.GroupBox1.Controls.Add(Me.txtky_hieu_hoa_don)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.txtma_hoa_don)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Controls.Add(Me.txtten_vt)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.txtso_seri)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtngay_hd)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtso_hd)
        Me.GroupBox1.Controls.Add(Me.Label17)
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
        Me.GroupBox1.Location = New System.Drawing.Point(-5, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(992, 346)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Location = New System.Drawing.Point(3, 149)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(963, 197)
        Me.TabControl1.TabIndex = 216
        Me.TabControl1.TabStop = False
        '
        'txtten_vt
        '
        Me.txtten_vt.Location = New System.Drawing.Point(126, 102)
        Me.txtten_vt.Name = "txtten_vt"
        Me.txtten_vt.Size = New System.Drawing.Size(445, 20)
        Me.txtten_vt.TabIndex = 8
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 106)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(62, 13)
        Me.Label20.TabIndex = 210
        Me.Label20.Tag = "411"
        Me.Label20.Text = "Nhom hang"
        '
        'txtso_seri
        '
        Me.txtso_seri.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtso_seri.Location = New System.Drawing.Point(315, 60)
        Me.txtso_seri.Name = "txtso_seri"
        Me.txtso_seri.Size = New System.Drawing.Size(101, 20)
        Me.txtso_seri.TabIndex = 5
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(230, 64)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(37, 13)
        Me.Label18.TabIndex = 208
        Me.Label18.Tag = "409"
        Me.Label18.Text = "so seri"
        '
        'txtngay_hd
        '
        Me.txtngay_hd.Location = New System.Drawing.Point(483, 60)
        Me.txtngay_hd.Mask = "00/00/0000"
        Me.txtngay_hd.Name = "txtngay_hd"
        Me.txtngay_hd.Size = New System.Drawing.Size(88, 20)
        Me.txtngay_hd.TabIndex = 6
        Me.txtngay_hd.Text = "01011910"
        Me.txtngay_hd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtngay_hd.Value = New Date(1910, 1, 1, 0, 0, 0, 0)
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(419, 64)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 13)
        Me.Label16.TabIndex = 206
        Me.Label16.Tag = "410"
        Me.Label16.Text = "ngay hd"
        '
        'txtso_hd
        '
        Me.txtso_hd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtso_hd.Location = New System.Drawing.Point(126, 60)
        Me.txtso_hd.Name = "txtso_hd"
        Me.txtso_hd.Size = New System.Drawing.Size(100, 20)
        Me.txtso_hd.TabIndex = 4
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 64)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(62, 13)
        Me.Label17.TabIndex = 204
        Me.Label17.Tag = "408"
        Me.Label17.Text = "So hoa don"
        '
        'Txtty_gia
        '
        Me.Txtty_gia.Location = New System.Drawing.Point(291, 123)
        Me.Txtty_gia.MaxLength = 18
        Me.Txtty_gia.Name = "Txtty_gia"
        Me.Txtty_gia.NumberDecimalDigits = 0
        Me.Txtty_gia.Size = New System.Drawing.Size(101, 20)
        Me.Txtty_gia.TabIndex = 10
        Me.Txtty_gia.Text = "0"
        Me.Txtty_gia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtty_gia.Value = 0
        Me.Txtty_gia.Value2 = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.ma_thue)
        Me.GroupBox2.Controls.Add(Me.txtma_so_thue)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtdia_chi)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtong_ba)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtten_kh)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtma_kh)
        Me.GroupBox2.Location = New System.Drawing.Point(585, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(381, 175)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Tag = "217"
        Me.GroupBox2.Text = "Khach hang"
        '
        'ma_thue
        '
        Me.ma_thue.AutoSize = True
        Me.ma_thue.Location = New System.Drawing.Point(10, 81)
        Me.ma_thue.Name = "ma_thue"
        Me.ma_thue.Size = New System.Drawing.Size(59, 13)
        Me.ma_thue.TabIndex = 13
        Me.ma_thue.Tag = "203"
        Me.ma_thue.Text = "ma so thue"
        '
        'txtma_so_thue
        '
        Me.txtma_so_thue.Location = New System.Drawing.Point(130, 78)
        Me.txtma_so_thue.Name = "txtma_so_thue"
        Me.txtma_so_thue.Size = New System.Drawing.Size(246, 20)
        Me.txtma_so_thue.TabIndex = 8
        Me.txtma_so_thue.TabStop = False
        Me.txtma_so_thue.Tag = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(10, 60)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 13)
        Me.Label15.TabIndex = 11
        Me.Label15.Tag = "005"
        Me.Label15.Text = "Dia chi"
        '
        'txtdia_chi
        '
        Me.txtdia_chi.Location = New System.Drawing.Point(130, 57)
        Me.txtdia_chi.Name = "txtdia_chi"
        Me.txtdia_chi.ReadOnly = True
        Me.txtdia_chi.Size = New System.Drawing.Size(246, 20)
        Me.txtdia_chi.TabIndex = 7
        Me.txtdia_chi.TabStop = False
        Me.txtdia_chi.Tag = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(10, 102)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(101, 13)
        Me.Label14.TabIndex = 9
        Me.Label14.Tag = "218"
        Me.Label14.Text = "Ten nguoi giao dich"
        '
        'txtong_ba
        '
        Me.txtong_ba.Location = New System.Drawing.Point(130, 99)
        Me.txtong_ba.Name = "txtong_ba"
        Me.txtong_ba.Size = New System.Drawing.Size(246, 20)
        Me.txtong_ba.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(10, 39)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 13)
        Me.Label13.TabIndex = 7
        Me.Label13.Tag = "002"
        Me.Label13.Text = "Ten khach hang"
        '
        'txtten_kh
        '
        Me.txtten_kh.Location = New System.Drawing.Point(130, 36)
        Me.txtten_kh.Name = "txtten_kh"
        Me.txtten_kh.ReadOnly = True
        Me.txtten_kh.Size = New System.Drawing.Size(246, 20)
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
        Me.txtma_kh.Size = New System.Drawing.Size(109, 20)
        Me.txtma_kh.TabIndex = 4
        Me.txtma_kh.Tag = ""
        '
        'Txtngay_ct
        '
        Me.Txtngay_ct.Location = New System.Drawing.Point(315, 18)
        Me.Txtngay_ct.Mask = "00/00/0000"
        Me.Txtngay_ct.Name = "Txtngay_ct"
        Me.Txtngay_ct.Size = New System.Drawing.Size(101, 20)
        Me.Txtngay_ct.TabIndex = 1
        Me.Txtngay_ct.Text = "01011910"
        Me.Txtngay_ct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtngay_ct.Value = New Date(1910, 1, 1, 0, 0, 0, 0)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 127)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 37
        Me.Label11.Tag = "215"
        Me.Label11.Text = "ngoai te"
        '
        'cbbma_nt
        '
        Me.cbbma_nt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbma_nt.FormattingEnabled = True
        Me.cbbma_nt.Location = New System.Drawing.Point(126, 123)
        Me.cbbma_nt.Name = "cbbma_nt"
        Me.cbbma_nt.Size = New System.Drawing.Size(159, 21)
        Me.cbbma_nt.TabIndex = 9
        '
        'txtdien_giai
        '
        Me.txtdien_giai.Location = New System.Drawing.Point(126, 81)
        Me.txtdien_giai.Name = "txtdien_giai"
        Me.txtdien_giai.Size = New System.Drawing.Size(445, 20)
        Me.txtdien_giai.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Tag = "214"
        Me.Label7.Text = "Dien giai"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(230, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Tag = "221"
        Me.Label2.Text = "ngay ct"
        '
        'txtso_ct
        '
        Me.txtso_ct.Location = New System.Drawing.Point(126, 18)
        Me.txtso_ct.Name = "txtso_ct"
        Me.txtso_ct.Size = New System.Drawing.Size(100, 20)
        Me.txtso_ct.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Tag = "220"
        Me.Label1.Text = "So chung tu"
        '
        'cbbstatus
        '
        Me.cbbstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbstatus.FormattingEnabled = True
        Me.cbbstatus.Location = New System.Drawing.Point(94, 2)
        Me.cbbstatus.Name = "cbbstatus"
        Me.cbbstatus.Size = New System.Drawing.Size(188, 21)
        Me.cbbstatus.TabIndex = 10
        Me.cbbstatus.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Label12.Location = New System.Drawing.Point(6, 6)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 13)
        Me.Label12.TabIndex = 202
        Me.Label12.Tag = "303"
        Me.Label12.Text = "trang thai"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(0, 437)
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
        Me.txtnguoi_tao.Location = New System.Drawing.Point(67, 437)
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
        Me.txtngay_tao.Location = New System.Drawing.Point(225, 437)
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
        Me.Label6.Location = New System.Drawing.Point(158, 437)
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
        Me.txtngay_sua.Location = New System.Drawing.Point(225, 452)
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
        Me.Label5.Location = New System.Drawing.Point(158, 452)
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
        Me.txtnguoi_sua.Location = New System.Drawing.Point(67, 452)
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
        Me.Label8.Location = New System.Drawing.Point(0, 452)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Tag = "091"
        Me.Label8.Text = "Nguoi sua:"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(544, 368)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 13)
        Me.Label10.TabIndex = 108
        Me.Label10.Tag = "412"
        Me.Label10.Text = "Tien"
        '
        'btnluuandmoi
        '
        Me.btnluuandmoi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnluuandmoi.Location = New System.Drawing.Point(87, 389)
        Me.btnluuandmoi.Name = "btnluuandmoi"
        Me.btnluuandmoi.Size = New System.Drawing.Size(82, 48)
        Me.btnluuandmoi.TabIndex = 100
        Me.btnluuandmoi.Tag = "219"
        Me.btnluuandmoi.Text = "Luu va them moi"
        Me.btnluuandmoi.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(544, 389)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(43, 13)
        Me.Label21.TabIndex = 203
        Me.Label21.Tag = "413"
        Me.Label21.Text = "Tien ck"
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(544, 430)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(52, 13)
        Me.Label22.TabIndex = 206
        Me.Label22.Tag = "414"
        Me.Label22.Text = "Tien thue"
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(544, 451)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(82, 13)
        Me.Label23.TabIndex = 209
        Me.Label23.Tag = "415"
        Me.Label23.Text = "tong thanh toan"
        '
        'txtt_tt_nt
        '
        Me.txtt_tt_nt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtt_tt_nt.Location = New System.Drawing.Point(692, 448)
        Me.txtt_tt_nt.MaxLength = 0
        Me.txtt_tt_nt.Name = "txtt_tt_nt"
        Me.txtt_tt_nt.NumberDecimalDigits = 2
        Me.txtt_tt_nt.ReadOnly = True
        Me.txtt_tt_nt.Size = New System.Drawing.Size(130, 20)
        Me.txtt_tt_nt.TabIndex = 114
        Me.txtt_tt_nt.Text = "0.00"
        Me.txtt_tt_nt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtt_tt_nt.Value = 0
        Me.txtt_tt_nt.Value2 = 0
        '
        'txtt_tt
        '
        Me.txtt_tt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtt_tt.Location = New System.Drawing.Point(826, 448)
        Me.txtt_tt.MaxLength = 0
        Me.txtt_tt.Name = "txtt_tt"
        Me.txtt_tt.NumberDecimalDigits = 0
        Me.txtt_tt.ReadOnly = True
        Me.txtt_tt.Size = New System.Drawing.Size(130, 20)
        Me.txtt_tt.TabIndex = 115
        Me.txtt_tt.Text = "0"
        Me.txtt_tt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtt_tt.Value = 0
        Me.txtt_tt.Value2 = 0
        '
        'txtt_thue_nt
        '
        Me.txtt_thue_nt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtt_thue_nt.Location = New System.Drawing.Point(692, 427)
        Me.txtt_thue_nt.MaxLength = 0
        Me.txtt_thue_nt.Name = "txtt_thue_nt"
        Me.txtt_thue_nt.NumberDecimalDigits = 2
        Me.txtt_thue_nt.ReadOnly = True
        Me.txtt_thue_nt.Size = New System.Drawing.Size(130, 20)
        Me.txtt_thue_nt.TabIndex = 112
        Me.txtt_thue_nt.Text = "0.00"
        Me.txtt_thue_nt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtt_thue_nt.Value = 0
        Me.txtt_thue_nt.Value2 = 0
        '
        'txtt_thue
        '
        Me.txtt_thue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtt_thue.Location = New System.Drawing.Point(826, 427)
        Me.txtt_thue.MaxLength = 0
        Me.txtt_thue.Name = "txtt_thue"
        Me.txtt_thue.NumberDecimalDigits = 0
        Me.txtt_thue.ReadOnly = True
        Me.txtt_thue.Size = New System.Drawing.Size(130, 20)
        Me.txtt_thue.TabIndex = 113
        Me.txtt_thue.Text = "0"
        Me.txtt_thue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtt_thue.Value = 0
        Me.txtt_thue.Value2 = 0
        '
        'Txtt_ck_nt
        '
        Me.Txtt_ck_nt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtt_ck_nt.Location = New System.Drawing.Point(692, 385)
        Me.Txtt_ck_nt.MaxLength = 0
        Me.Txtt_ck_nt.Name = "Txtt_ck_nt"
        Me.Txtt_ck_nt.NumberDecimalDigits = 2
        Me.Txtt_ck_nt.ReadOnly = True
        Me.Txtt_ck_nt.Size = New System.Drawing.Size(130, 20)
        Me.Txtt_ck_nt.TabIndex = 109
        Me.Txtt_ck_nt.Text = "0.00"
        Me.Txtt_ck_nt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtt_ck_nt.Value = 0
        Me.Txtt_ck_nt.Value2 = 0
        '
        'Txtt_ck
        '
        Me.Txtt_ck.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtt_ck.Location = New System.Drawing.Point(826, 385)
        Me.Txtt_ck.MaxLength = 0
        Me.Txtt_ck.Name = "Txtt_ck"
        Me.Txtt_ck.NumberDecimalDigits = 0
        Me.Txtt_ck.ReadOnly = True
        Me.Txtt_ck.Size = New System.Drawing.Size(130, 20)
        Me.Txtt_ck.TabIndex = 110
        Me.Txtt_ck.Text = "0"
        Me.Txtt_ck.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtt_ck.Value = 0
        Me.Txtt_ck.Value2 = 0
        '
        'Txtt_tien_nt
        '
        Me.Txtt_tien_nt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtt_tien_nt.Location = New System.Drawing.Point(692, 364)
        Me.Txtt_tien_nt.MaxLength = 0
        Me.Txtt_tien_nt.Name = "Txtt_tien_nt"
        Me.Txtt_tien_nt.NumberDecimalDigits = 2
        Me.Txtt_tien_nt.ReadOnly = True
        Me.Txtt_tien_nt.Size = New System.Drawing.Size(130, 20)
        Me.Txtt_tien_nt.TabIndex = 107
        Me.Txtt_tien_nt.Text = "0.00"
        Me.Txtt_tien_nt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtt_tien_nt.Value = 0
        Me.Txtt_tien_nt.Value2 = 0
        '
        'Txtt_tien
        '
        Me.Txtt_tien.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtt_tien.Location = New System.Drawing.Point(826, 364)
        Me.Txtt_tien.MaxLength = 0
        Me.Txtt_tien.Name = "Txtt_tien"
        Me.Txtt_tien.NumberDecimalDigits = 0
        Me.Txtt_tien.ReadOnly = True
        Me.Txtt_tien.Size = New System.Drawing.Size(130, 20)
        Me.Txtt_tien.TabIndex = 108
        Me.Txtt_tien.Text = "0"
        Me.Txtt_tien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtt_tien.Value = 0
        Me.Txtt_tien.Value2 = 0
        '
        'toolbar
        '
        Me.toolbar.BackColor = System.Drawing.Color.MediumAquamarine
        Me.toolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSDropDownGetdata})
        Me.toolbar.Location = New System.Drawing.Point(0, 0)
        Me.toolbar.Name = "toolbar"
        Me.toolbar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.toolbar.Size = New System.Drawing.Size(961, 25)
        Me.toolbar.TabIndex = 216
        Me.toolbar.Text = "ToolStrip1"
        '
        'TSDropDownGetdata
        '
        Me.TSDropDownGetdata.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.TSDropDownGetdata.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnlaydulieutudonhang})
        Me.TSDropDownGetdata.Image = CType(resources.GetObject("TSDropDownGetdata.Image"), System.Drawing.Image)
        Me.TSDropDownGetdata.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSDropDownGetdata.Name = "TSDropDownGetdata"
        Me.TSDropDownGetdata.Size = New System.Drawing.Size(77, 22)
        Me.TSDropDownGetdata.Tag = "013"
        Me.TSDropDownGetdata.Text = "Lay du lieu"
        '
        'btnlaydulieutudonhang
        '
        Me.btnlaydulieutudonhang.Name = "btnlaydulieutudonhang"
        Me.btnlaydulieutudonhang.Size = New System.Drawing.Size(199, 22)
        Me.btnlaydulieutudonhang.Tag = "009"
        Me.btnlaydulieutudonhang.Text = "Lay du lieu tu don hang"
        '
        'Txtt_sl
        '
        Me.Txtt_sl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtt_sl.Location = New System.Drawing.Point(395, 364)
        Me.Txtt_sl.MaxLength = 0
        Me.Txtt_sl.Name = "Txtt_sl"
        Me.Txtt_sl.NumberDecimalDigits = 2
        Me.Txtt_sl.ReadOnly = True
        Me.Txtt_sl.Size = New System.Drawing.Size(129, 20)
        Me.Txtt_sl.TabIndex = 210
        Me.Txtt_sl.Text = "0.00"
        Me.Txtt_sl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtt_sl.Value = 0
        Me.Txtt_sl.Value2 = 0
        Me.Txtt_sl.Visible = False
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(314, 368)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(75, 13)
        Me.Label25.TabIndex = 211
        Me.Label25.Tag = "418"
        Me.Label25.Text = "Tong so luong"
        Me.Label25.Visible = False
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(314, 388)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(69, 13)
        Me.Label24.TabIndex = 215
        Me.Label24.Tag = "419"
        Me.Label24.Text = "Tien tien von"
        Me.Label24.Visible = False
        '
        'Txtt_tien_von
        '
        Me.Txtt_tien_von.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtt_tien_von.Location = New System.Drawing.Point(395, 385)
        Me.Txtt_tien_von.MaxLength = 0
        Me.Txtt_tien_von.Name = "Txtt_tien_von"
        Me.Txtt_tien_von.NumberDecimalDigits = 0
        Me.Txtt_tien_von.ReadOnly = True
        Me.Txtt_tien_von.Size = New System.Drawing.Size(129, 20)
        Me.Txtt_tien_von.TabIndex = 213
        Me.Txtt_tien_von.Text = "0"
        Me.Txtt_tien_von.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtt_tien_von.Value = 0
        Me.Txtt_tien_von.Value2 = 0
        Me.Txtt_tien_von.Visible = False
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(544, 410)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 13)
        Me.Label9.TabIndex = 219
        Me.Label9.Tag = "CKH"
        Me.Label9.Text = "Chiết khấu theo hóa đơn"
        '
        'Txtt_ck_hd_nt
        '
        Me.Txtt_ck_hd_nt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtt_ck_hd_nt.Location = New System.Drawing.Point(692, 406)
        Me.Txtt_ck_hd_nt.MaxLength = 0
        Me.Txtt_ck_hd_nt.Name = "Txtt_ck_hd_nt"
        Me.Txtt_ck_hd_nt.NumberDecimalDigits = 2
        Me.Txtt_ck_hd_nt.ReadOnly = True
        Me.Txtt_ck_hd_nt.Size = New System.Drawing.Size(130, 20)
        Me.Txtt_ck_hd_nt.TabIndex = 217
        Me.Txtt_ck_hd_nt.Text = "0.00"
        Me.Txtt_ck_hd_nt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtt_ck_hd_nt.Value = 0
        Me.Txtt_ck_hd_nt.Value2 = 0
        '
        'Txtt_ck_hd
        '
        Me.Txtt_ck_hd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtt_ck_hd.Location = New System.Drawing.Point(826, 406)
        Me.Txtt_ck_hd.MaxLength = 0
        Me.Txtt_ck_hd.Name = "Txtt_ck_hd"
        Me.Txtt_ck_hd.NumberDecimalDigits = 0
        Me.Txtt_ck_hd.ReadOnly = True
        Me.Txtt_ck_hd.Size = New System.Drawing.Size(130, 20)
        Me.Txtt_ck_hd.TabIndex = 218
        Me.Txtt_ck_hd.Text = "0"
        Me.Txtt_ck_hd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtt_ck_hd.Value = 0
        Me.Txtt_ck_hd.Value2 = 0
        '
        'txtky_hieu_hoa_don
        '
        Me.txtky_hieu_hoa_don.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtky_hieu_hoa_don.Location = New System.Drawing.Point(315, 39)
        Me.txtky_hieu_hoa_don.Name = "txtky_hieu_hoa_don"
        Me.txtky_hieu_hoa_don.Size = New System.Drawing.Size(101, 20)
        Me.txtky_hieu_hoa_don.TabIndex = 3
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(230, 43)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(75, 13)
        Me.Label19.TabIndex = 220
        Me.Label19.Tag = "KHH"
        Me.Label19.Text = "Ký hiệu số HĐ"
        '
        'txtma_hoa_don
        '
        Me.txtma_hoa_don.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtma_hoa_don.Location = New System.Drawing.Point(126, 39)
        Me.txtma_hoa_don.Name = "txtma_hoa_don"
        Me.txtma_hoa_don.Size = New System.Drawing.Size(100, 20)
        Me.txtma_hoa_don.TabIndex = 2
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(6, 43)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(65, 13)
        Me.Label26.TabIndex = 219
        Me.Label26.Tag = "MHD"
        Me.Label26.Text = "Mã hóa đơn"
        '
        'frminput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 471)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Txtt_ck_hd_nt)
        Me.Controls.Add(Me.Txtt_ck_hd)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cbbstatus)
        Me.Controls.Add(Me.toolbar)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Txtt_tien_von)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Txtt_sl)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txtt_tt_nt)
        Me.Controls.Add(Me.txtt_tt)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.txtt_thue_nt)
        Me.Controls.Add(Me.txtt_thue)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Txtt_ck_nt)
        Me.Controls.Add(Me.Txtt_ck)
        Me.Controls.Add(Me.btnluuandmoi)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Txtt_tien_nt)
        Me.Controls.Add(Me.Txtt_tien)
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
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.toolbar.ResumeLayout(False)
        Me.toolbar.PerformLayout()
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
    Friend WithEvents Txtt_tien As ClsControl2.TxtNumeric
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtdia_chi As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtong_ba As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtten_kh As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Txtt_tien_nt As ClsControl2.TxtNumeric
    Friend WithEvents btnluuandmoi As System.Windows.Forms.Button
    Friend WithEvents Txtty_gia As ClsControl2.TxtNumeric
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbbstatus As System.Windows.Forms.ComboBox
    Friend WithEvents txtso_seri As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtngay_hd As ClsControl2.TxtDate
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtso_hd As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtten_vt As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Txtt_ck_nt As ClsControl2.TxtNumeric
    Friend WithEvents Txtt_ck As ClsControl2.TxtNumeric
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtt_thue_nt As ClsControl2.TxtNumeric
    Friend WithEvents txtt_thue As ClsControl2.TxtNumeric
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtt_tt_nt As ClsControl2.TxtNumeric
    Friend WithEvents txtt_tt As ClsControl2.TxtNumeric
    Friend WithEvents ma_thue As System.Windows.Forms.Label
    Friend WithEvents txtma_so_thue As System.Windows.Forms.TextBox
    Friend WithEvents toolbar As System.Windows.Forms.ToolStrip
    Friend WithEvents TSDropDownGetdata As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents btnlaydulieutudonhang As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Txtt_sl As ClsControl2.TxtNumeric
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Txtt_tien_von As ClsControl2.TxtNumeric
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Txtt_ck_hd_nt As ClsControl2.TxtNumeric
    Friend WithEvents Txtt_ck_hd As ClsControl2.TxtNumeric
    Friend WithEvents txtky_hieu_hoa_don As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtma_hoa_don As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
End Class
