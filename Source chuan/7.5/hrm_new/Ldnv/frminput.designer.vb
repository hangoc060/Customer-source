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
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnLuu = New System.Windows.Forms.Button
        Me.btnhuy = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtten_nguoi_lh = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.ten_nv = New System.Windows.Forms.Label
        Me.Txtma_nv = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Txtngay = New ClsControl2.TxtDate
        Me.cbbma_tien_do = New System.Windows.Forms.ComboBox
        Me.cbbma_lcv = New System.Windows.Forms.ComboBox
        Me.cbbma_ddlv = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtphut = New ClsControl2.TxtNumeric
        Me.txtgio = New ClsControl2.TxtNumeric
        Me.txtghi_chu = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.lblten_kh = New System.Windows.Forms.Label
        Me.txtma_kh = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtdien_giai = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtden_gio = New System.Windows.Forms.MaskedTextBox
        Me.txttu_gio = New System.Windows.Forms.MaskedTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtnguoi_tao = New System.Windows.Forms.Label
        Me.txtngay_tao = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtngay_sua = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtnguoi_sua = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Tag = "001"
        Me.Label2.Text = "Noi lam viec"
        '
        'btnLuu
        '
        Me.btnLuu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLuu.Location = New System.Drawing.Point(3, 287)
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
        Me.btnhuy.Location = New System.Drawing.Point(59, 287)
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
        Me.GroupBox1.Controls.Add(Me.txtten_nguoi_lh)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.ten_nv)
        Me.GroupBox1.Controls.Add(Me.Txtma_nv)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Txtngay)
        Me.GroupBox1.Controls.Add(Me.cbbma_tien_do)
        Me.GroupBox1.Controls.Add(Me.cbbma_lcv)
        Me.GroupBox1.Controls.Add(Me.cbbma_ddlv)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtphut)
        Me.GroupBox1.Controls.Add(Me.txtgio)
        Me.GroupBox1.Controls.Add(Me.txtghi_chu)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lblten_kh)
        Me.GroupBox1.Controls.Add(Me.txtma_kh)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtdien_giai)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtden_gio)
        Me.GroupBox1.Controls.Add(Me.txttu_gio)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(-7, -7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(621, 288)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'txtten_nguoi_lh
        '
        Me.txtten_nguoi_lh.Location = New System.Drawing.Point(106, 117)
        Me.txtten_nguoi_lh.Name = "txtten_nguoi_lh"
        Me.txtten_nguoi_lh.Size = New System.Drawing.Size(498, 20)
        Me.txtten_nguoi_lh.TabIndex = 8
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(12, 121)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(85, 13)
        Me.Label16.TabIndex = 40
        Me.Label16.Tag = "106"
        Me.Label16.Text = "ten nguoi lien he"
        '
        'ten_nv
        '
        Me.ten_nv.AutoSize = True
        Me.ten_nv.Location = New System.Drawing.Point(212, 19)
        Me.ten_nv.Name = "ten_nv"
        Me.ten_nv.Size = New System.Drawing.Size(37, 13)
        Me.ten_nv.TabIndex = 38
        Me.ten_nv.Text = "ten nv"
        '
        'Txtma_nv
        '
        Me.Txtma_nv.Location = New System.Drawing.Point(106, 15)
        Me.Txtma_nv.Name = "Txtma_nv"
        Me.Txtma_nv.Size = New System.Drawing.Size(100, 20)
        Me.Txtma_nv.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(12, 19)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 13)
        Me.Label17.TabIndex = 37
        Me.Label17.Tag = "011"
        Me.Label17.Text = "Nhan vien"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(12, 45)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 13)
        Me.Label15.TabIndex = 35
        Me.Label15.Tag = "105"
        Me.Label15.Text = "Ngay"
        '
        'Txtngay
        '
        Me.Txtngay.Location = New System.Drawing.Point(106, 41)
        Me.Txtngay.Mask = "00/00/0000"
        Me.Txtngay.Name = "Txtngay"
        Me.Txtngay.Size = New System.Drawing.Size(100, 20)
        Me.Txtngay.TabIndex = 1
        Me.Txtngay.Text = "21122009"
        Me.Txtngay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtngay.Value = New Date(2009, 12, 21, 0, 0, 0, 0)
        '
        'cbbma_tien_do
        '
        Me.cbbma_tien_do.FormattingEnabled = True
        Me.cbbma_tien_do.Location = New System.Drawing.Point(106, 142)
        Me.cbbma_tien_do.Name = "cbbma_tien_do"
        Me.cbbma_tien_do.Size = New System.Drawing.Size(497, 21)
        Me.cbbma_tien_do.TabIndex = 9
        '
        'cbbma_lcv
        '
        Me.cbbma_lcv.FormattingEnabled = True
        Me.cbbma_lcv.Location = New System.Drawing.Point(106, 92)
        Me.cbbma_lcv.Name = "cbbma_lcv"
        Me.cbbma_lcv.Size = New System.Drawing.Size(497, 21)
        Me.cbbma_lcv.TabIndex = 7
        '
        'cbbma_ddlv
        '
        Me.cbbma_ddlv.FormattingEnabled = True
        Me.cbbma_ddlv.Location = New System.Drawing.Point(106, 67)
        Me.cbbma_ddlv.Name = "cbbma_ddlv"
        Me.cbbma_ddlv.Size = New System.Drawing.Size(497, 21)
        Me.cbbma_ddlv.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(523, 45)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 13)
        Me.Label14.TabIndex = 33
        Me.Label14.Tag = "005"
        Me.Label14.Text = "phut"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(435, 45)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(21, 13)
        Me.Label13.TabIndex = 32
        Me.Label13.Tag = "004"
        Me.Label13.Text = "gio"
        '
        'txtphut
        '
        Me.txtphut.Location = New System.Drawing.Point(559, 41)
        Me.txtphut.MaxLength = 18
        Me.txtphut.Name = "txtphut"
        Me.txtphut.NumberDecimalDigits = 0
        Me.txtphut.Size = New System.Drawing.Size(44, 20)
        Me.txtphut.TabIndex = 5
        Me.txtphut.Text = "0"
        Me.txtphut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtphut.Value = 0
        Me.txtphut.Value2 = 0
        '
        'txtgio
        '
        Me.txtgio.Location = New System.Drawing.Point(475, 41)
        Me.txtgio.MaxLength = 18
        Me.txtgio.Name = "txtgio"
        Me.txtgio.NumberDecimalDigits = 0
        Me.txtgio.Size = New System.Drawing.Size(44, 20)
        Me.txtgio.TabIndex = 4
        Me.txtgio.Text = "0"
        Me.txtgio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtgio.Value = 0
        Me.txtgio.Value2 = 0
        '
        'txtghi_chu
        '
        Me.txtghi_chu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtghi_chu.Location = New System.Drawing.Point(105, 216)
        Me.txtghi_chu.Multiline = True
        Me.txtghi_chu.Name = "txtghi_chu"
        Me.txtghi_chu.Size = New System.Drawing.Size(498, 66)
        Me.txtghi_chu.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 220)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 29
        Me.Label10.Tag = "010"
        Me.Label10.Text = "Ghi chu"
        '
        'lblten_kh
        '
        Me.lblten_kh.AutoSize = True
        Me.lblten_kh.Location = New System.Drawing.Point(307, 196)
        Me.lblten_kh.Name = "lblten_kh"
        Me.lblten_kh.Size = New System.Drawing.Size(37, 13)
        Me.lblten_kh.TabIndex = 27
        Me.lblten_kh.Text = "ten kh"
        '
        'txtma_kh
        '
        Me.txtma_kh.Location = New System.Drawing.Point(106, 192)
        Me.txtma_kh.Name = "txtma_kh"
        Me.txtma_kh.Size = New System.Drawing.Size(195, 20)
        Me.txtma_kh.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 196)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 13)
        Me.Label12.TabIndex = 26
        Me.Label12.Tag = "009"
        Me.Label12.Text = "Khach hang"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 171)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Tag = "008"
        Me.Label11.Text = "Tien do"
        '
        'txtdien_giai
        '
        Me.txtdien_giai.Location = New System.Drawing.Point(106, 167)
        Me.txtdien_giai.Name = "txtdien_giai"
        Me.txtdien_giai.Size = New System.Drawing.Size(498, 20)
        Me.txtdien_giai.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Tag = "007"
        Me.Label7.Text = "Chi tiet cong viec"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Tag = "006"
        Me.Label9.Text = "Loai cong viec"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(324, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Tag = "003"
        Me.Label4.Text = "den gio"
        '
        'txtden_gio
        '
        Me.txtden_gio.Location = New System.Drawing.Point(383, 41)
        Me.txtden_gio.Mask = "00:00"
        Me.txtden_gio.Name = "txtden_gio"
        Me.txtden_gio.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.txtden_gio.Size = New System.Drawing.Size(47, 20)
        Me.txtden_gio.TabIndex = 3
        Me.txtden_gio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtden_gio.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.txtden_gio.ValidatingType = GetType(Date)
        '
        'txttu_gio
        '
        Me.txttu_gio.Location = New System.Drawing.Point(273, 41)
        Me.txttu_gio.Mask = "00:00"
        Me.txttu_gio.Name = "txttu_gio"
        Me.txttu_gio.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.txttu_gio.Size = New System.Drawing.Size(47, 20)
        Me.txttu_gio.TabIndex = 2
        Me.txttu_gio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txttu_gio.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.txttu_gio.ValidatingType = GetType(Date)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(211, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Tag = "002"
        Me.Label1.Text = "Tu gio"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(0, 331)
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
        Me.txtnguoi_tao.Location = New System.Drawing.Point(67, 331)
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
        Me.txtngay_tao.Location = New System.Drawing.Point(225, 331)
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
        Me.Label6.Location = New System.Drawing.Point(158, 331)
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
        Me.txtngay_sua.Location = New System.Drawing.Point(225, 346)
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
        Me.Label5.Location = New System.Drawing.Point(158, 346)
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
        Me.txtnguoi_sua.Location = New System.Drawing.Point(67, 346)
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
        Me.Label8.Location = New System.Drawing.Point(0, 346)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Tag = "091"
        Me.Label8.Text = "Nguoi sua:"
        '
        'frminput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 365)
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtden_gio As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txttu_gio As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtghi_chu As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblten_kh As System.Windows.Forms.Label
    Friend WithEvents txtma_kh As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtdien_giai As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtgio As ClsControl2.TxtNumeric
    Friend WithEvents txtphut As ClsControl2.TxtNumeric
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cbbma_tien_do As System.Windows.Forms.ComboBox
    Friend WithEvents cbbma_lcv As System.Windows.Forms.ComboBox
    Friend WithEvents cbbma_ddlv As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Txtngay As ClsControl2.TxtDate
    Friend WithEvents ten_nv As System.Windows.Forms.Label
    Friend WithEvents Txtma_nv As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtten_nguoi_lh As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
