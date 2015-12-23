<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class qtluong
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
        Me.Panqtluong = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtso_phu_luc = New System.Windows.Forms.TextBox
        Me.txtnd_phu_luc = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtphucapluong = New ClsControl2.TxtNumeric
        Me.txtluonglamthem = New ClsControl2.TxtNumeric
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txthslcb = New ClsControl2.TxtNumeric
        Me.chbhslcb_yn = New System.Windows.Forms.CheckBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.chbluong_thuc_yn = New System.Windows.Forms.CheckBox
        Me.txtluong_thuc = New ClsControl2.TxtNumeric
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtluong_nd = New ClsControl2.TxtNumeric
        Me.chbluong_nd_yn = New System.Windows.Forms.CheckBox
        Me.txtngay_hl = New ClsControl2.TxtDate
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtngay_sua = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtnguoi_sua = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtngay_tao = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtnguoi_tao = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnhuy = New System.Windows.Forms.Button
        Me.btnLuu = New System.Windows.Forms.Button
        Me.chbluong_ngay = New System.Windows.Forms.CheckBox
        Me.chbluong_thang = New System.Windows.Forms.CheckBox
        Me.Panqtluong.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panqtluong
        '
        Me.Panqtluong.BackColor = System.Drawing.Color.White
        Me.Panqtluong.Controls.Add(Me.GroupBox1)
        Me.Panqtluong.Location = New System.Drawing.Point(-2, -3)
        Me.Panqtluong.Name = "Panqtluong"
        Me.Panqtluong.Size = New System.Drawing.Size(628, 312)
        Me.Panqtluong.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.txtso_phu_luc)
        Me.GroupBox1.Controls.Add(Me.txtnd_phu_luc)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtphucapluong)
        Me.GroupBox1.Controls.Add(Me.txtluonglamthem)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtngay_hl)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(609, 300)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtso_phu_luc
        '
        Me.txtso_phu_luc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtso_phu_luc.Location = New System.Drawing.Point(126, 220)
        Me.txtso_phu_luc.Name = "txtso_phu_luc"
        Me.txtso_phu_luc.Size = New System.Drawing.Size(116, 20)
        Me.txtso_phu_luc.TabIndex = 6
        '
        'txtnd_phu_luc
        '
        Me.txtnd_phu_luc.Location = New System.Drawing.Point(126, 246)
        Me.txtnd_phu_luc.Multiline = True
        Me.txtnd_phu_luc.Name = "txtnd_phu_luc"
        Me.txtnd_phu_luc.Size = New System.Drawing.Size(469, 43)
        Me.txtnd_phu_luc.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(17, 244)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 13)
        Me.Label12.TabIndex = 90
        Me.Label12.Tag = "014"
        Me.Label12.Text = "Noi dung phu luc hd"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 223)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Tag = "013"
        Me.Label11.Text = "So phu luc hd"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(315, 182)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Tag = "012"
        Me.Label10.Text = "Phụ cấp lương"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(315, 153)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Tag = "011"
        Me.Label9.Text = "Mức lương làm thêm"
        '
        'txtphucapluong
        '
        Me.txtphucapluong.Location = New System.Drawing.Point(447, 178)
        Me.txtphucapluong.MaxLength = 18
        Me.txtphucapluong.Name = "txtphucapluong"
        Me.txtphucapluong.NumberDecimalDigits = 2
        Me.txtphucapluong.Size = New System.Drawing.Size(148, 20)
        Me.txtphucapluong.TabIndex = 5
        Me.txtphucapluong.Text = "0.00"
        Me.txtphucapluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtphucapluong.Value = 0
        Me.txtphucapluong.Value2 = 0
        '
        'txtluonglamthem
        '
        Me.txtluonglamthem.Location = New System.Drawing.Point(447, 149)
        Me.txtluonglamthem.MaxLength = 18
        Me.txtluonglamthem.Name = "txtluonglamthem"
        Me.txtluonglamthem.NumberDecimalDigits = 2
        Me.txtluonglamthem.Size = New System.Drawing.Size(148, 20)
        Me.txtluonglamthem.TabIndex = 4
        Me.txtluonglamthem.Text = "0.00"
        Me.txtluonglamthem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtluonglamthem.Value = 0
        Me.txtluonglamthem.Value2 = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.txthslcb)
        Me.GroupBox4.Controls.Add(Me.chbhslcb_yn)
        Me.GroupBox4.Location = New System.Drawing.Point(11, 139)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(288, 74)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Tag = "010"
        Me.Label7.Text = "Hệ số lương cơ bản"
        '
        'txthslcb
        '
        Me.txthslcb.Location = New System.Drawing.Point(115, 36)
        Me.txthslcb.MaxLength = 18
        Me.txthslcb.Name = "txthslcb"
        Me.txthslcb.NumberDecimalDigits = 2
        Me.txthslcb.Size = New System.Drawing.Size(162, 20)
        Me.txthslcb.TabIndex = 1
        Me.txthslcb.Text = "0.00"
        Me.txthslcb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txthslcb.Value = 0
        Me.txthslcb.Value2 = 0
        '
        'chbhslcb_yn
        '
        Me.chbhslcb_yn.AutoSize = True
        Me.chbhslcb_yn.Location = New System.Drawing.Point(115, 13)
        Me.chbhslcb_yn.Name = "chbhslcb_yn"
        Me.chbhslcb_yn.Size = New System.Drawing.Size(162, 17)
        Me.chbhslcb_yn.TabIndex = 0
        Me.chbhslcb_yn.Tag = "009"
        Me.chbhslcb_yn.Text = "Thay đổi hệ số lương cơ bản"
        Me.chbhslcb_yn.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chbluong_thang)
        Me.GroupBox3.Controls.Add(Me.chbluong_ngay)
        Me.GroupBox3.Controls.Add(Me.chbluong_thuc_yn)
        Me.GroupBox3.Controls.Add(Me.txtluong_thuc)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(318, 46)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(288, 97)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Tag = "006"
        Me.GroupBox3.Text = "DN"
        '
        'chbluong_thuc_yn
        '
        Me.chbluong_thuc_yn.AutoSize = True
        Me.chbluong_thuc_yn.Location = New System.Drawing.Point(129, 14)
        Me.chbluong_thuc_yn.Name = "chbluong_thuc_yn"
        Me.chbluong_thuc_yn.Size = New System.Drawing.Size(148, 17)
        Me.chbluong_thuc_yn.TabIndex = 0
        Me.chbluong_thuc_yn.Tag = "007"
        Me.chbluong_thuc_yn.Text = "Thay đổi lương thực nhận"
        Me.chbluong_thuc_yn.UseVisualStyleBackColor = True
        '
        'txtluong_thuc
        '
        Me.txtluong_thuc.Location = New System.Drawing.Point(129, 37)
        Me.txtluong_thuc.MaxLength = 18
        Me.txtluong_thuc.Name = "txtluong_thuc"
        Me.txtluong_thuc.NumberDecimalDigits = 2
        Me.txtluong_thuc.Size = New System.Drawing.Size(148, 20)
        Me.txtluong_thuc.TabIndex = 1
        Me.txtluong_thuc.Text = "0.00"
        Me.txtluong_thuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtluong_thuc.Value = 0
        Me.txtluong_thuc.Value2 = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Tag = "008"
        Me.Label4.Text = "Lương thực nhận"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtluong_nd)
        Me.GroupBox2.Controls.Add(Me.chbluong_nd_yn)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 46)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(288, 87)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Tag = "003"
        Me.GroupBox2.Text = "NĐCP"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Tag = "005"
        Me.Label1.Text = "Lương nghị định"
        '
        'txtluong_nd
        '
        Me.txtluong_nd.Location = New System.Drawing.Point(115, 36)
        Me.txtluong_nd.MaxLength = 18
        Me.txtluong_nd.Name = "txtluong_nd"
        Me.txtluong_nd.NumberDecimalDigits = 2
        Me.txtluong_nd.Size = New System.Drawing.Size(162, 20)
        Me.txtluong_nd.TabIndex = 1
        Me.txtluong_nd.Text = "0.00"
        Me.txtluong_nd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtluong_nd.Value = 0
        Me.txtluong_nd.Value2 = 0
        '
        'chbluong_nd_yn
        '
        Me.chbluong_nd_yn.AutoSize = True
        Me.chbluong_nd_yn.Location = New System.Drawing.Point(115, 14)
        Me.chbluong_nd_yn.Name = "chbluong_nd_yn"
        Me.chbluong_nd_yn.Size = New System.Drawing.Size(144, 17)
        Me.chbluong_nd_yn.TabIndex = 0
        Me.chbluong_nd_yn.Tag = "004"
        Me.chbluong_nd_yn.Text = "Thay đổi lương nghị định"
        Me.chbluong_nd_yn.UseVisualStyleBackColor = True
        '
        'txtngay_hl
        '
        Me.txtngay_hl.Location = New System.Drawing.Point(126, 17)
        Me.txtngay_hl.Mask = "00/00/0000"
        Me.txtngay_hl.Name = "txtngay_hl"
        Me.txtngay_hl.Size = New System.Drawing.Size(117, 20)
        Me.txtngay_hl.TabIndex = 0
        Me.txtngay_hl.Text = "01011910"
        Me.txtngay_hl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtngay_hl.Value = New Date(1910, 1, 1, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Tag = "002"
        Me.Label2.Text = "Ngay"
        '
        'txtngay_sua
        '
        Me.txtngay_sua.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtngay_sua.AutoSize = True
        Me.txtngay_sua.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtngay_sua.Location = New System.Drawing.Point(234, 380)
        Me.txtngay_sua.Name = "txtngay_sua"
        Me.txtngay_sua.Size = New System.Drawing.Size(50, 13)
        Me.txtngay_sua.TabIndex = 110
        Me.txtngay_sua.Text = "ngay sua"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(167, 380)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 109
        Me.Label5.Tag = "093"
        Me.Label5.Text = "Ngay sua:"
        '
        'txtnguoi_sua
        '
        Me.txtnguoi_sua.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtnguoi_sua.AutoSize = True
        Me.txtnguoi_sua.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtnguoi_sua.Location = New System.Drawing.Point(76, 380)
        Me.txtnguoi_sua.Name = "txtnguoi_sua"
        Me.txtnguoi_sua.Size = New System.Drawing.Size(53, 13)
        Me.txtnguoi_sua.TabIndex = 108
        Me.txtnguoi_sua.Text = "nguoi sua"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(10, 380)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 107
        Me.Label8.Tag = "091"
        Me.Label8.Text = "Nguoi sua:"
        '
        'txtngay_tao
        '
        Me.txtngay_tao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtngay_tao.AutoSize = True
        Me.txtngay_tao.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtngay_tao.Location = New System.Drawing.Point(234, 365)
        Me.txtngay_tao.Name = "txtngay_tao"
        Me.txtngay_tao.Size = New System.Drawing.Size(48, 13)
        Me.txtngay_tao.TabIndex = 106
        Me.txtngay_tao.Text = "ngay tao"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(167, 365)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 105
        Me.Label6.Tag = "092"
        Me.Label6.Text = "Ngay tao:"
        '
        'txtnguoi_tao
        '
        Me.txtnguoi_tao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtnguoi_tao.AutoSize = True
        Me.txtnguoi_tao.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtnguoi_tao.Location = New System.Drawing.Point(76, 365)
        Me.txtnguoi_tao.Name = "txtnguoi_tao"
        Me.txtnguoi_tao.Size = New System.Drawing.Size(51, 13)
        Me.txtnguoi_tao.TabIndex = 104
        Me.txtnguoi_tao.Text = "nguoi tao"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(10, 365)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 103
        Me.Label3.Tag = "090"
        Me.Label3.Text = "Nguoi tao:"
        '
        'btnhuy
        '
        Me.btnhuy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnhuy.CausesValidation = False
        Me.btnhuy.Location = New System.Drawing.Point(68, 321)
        Me.btnhuy.Name = "btnhuy"
        Me.btnhuy.Size = New System.Drawing.Size(54, 28)
        Me.btnhuy.TabIndex = 112
        Me.btnhuy.Tag = "095"
        Me.btnhuy.Text = "Huy"
        Me.btnhuy.UseVisualStyleBackColor = True
        '
        'btnLuu
        '
        Me.btnLuu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLuu.Location = New System.Drawing.Point(10, 321)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(54, 28)
        Me.btnLuu.TabIndex = 111
        Me.btnLuu.Tag = "094"
        Me.btnLuu.Text = "Luu"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'chbluong_ngay
        '
        Me.chbluong_ngay.AutoSize = True
        Me.chbluong_ngay.Location = New System.Drawing.Point(9, 67)
        Me.chbluong_ngay.Name = "chbluong_ngay"
        Me.chbluong_ngay.Size = New System.Drawing.Size(106, 17)
        Me.chbluong_ngay.TabIndex = 8
        Me.chbluong_ngay.Tag = "d50"
        Me.chbluong_ngay.Text = "Lương theo ngày"
        Me.chbluong_ngay.UseVisualStyleBackColor = True
        '
        'chbluong_thang
        '
        Me.chbluong_thang.AutoSize = True
        Me.chbluong_thang.Location = New System.Drawing.Point(129, 67)
        Me.chbluong_thang.Name = "chbluong_thang"
        Me.chbluong_thang.Size = New System.Drawing.Size(110, 17)
        Me.chbluong_thang.TabIndex = 9
        Me.chbluong_thang.Tag = "d51"
        Me.chbluong_thang.Text = "Lương theo tháng"
        Me.chbluong_thang.UseVisualStyleBackColor = True
        '
        'qtluong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 405)
        Me.Controls.Add(Me.Panqtluong)
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
        Me.Name = "qtluong"
        Me.Tag = "000"
        Me.Text = "qtluong"
        Me.Panqtluong.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panqtluong As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtngay_hl As ClsControl2.TxtDate
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtngay_sua As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtnguoi_sua As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtngay_tao As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtnguoi_tao As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnhuy As System.Windows.Forms.Button
    Friend WithEvents btnLuu As System.Windows.Forms.Button
    Friend WithEvents chbluong_thuc_yn As System.Windows.Forms.CheckBox
    Friend WithEvents chbluong_nd_yn As System.Windows.Forms.CheckBox
    Friend WithEvents txtluong_nd As ClsControl2.TxtNumeric
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtluong_thuc As ClsControl2.TxtNumeric
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txthslcb As ClsControl2.TxtNumeric
    Friend WithEvents chbhslcb_yn As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtluonglamthem As ClsControl2.TxtNumeric
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtphucapluong As ClsControl2.TxtNumeric
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtnd_phu_luc As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtso_phu_luc As System.Windows.Forms.TextBox
    Friend WithEvents chbluong_thang As System.Windows.Forms.CheckBox
    Friend WithEvents chbluong_ngay As System.Windows.Forms.CheckBox
End Class
