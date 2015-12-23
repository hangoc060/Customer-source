<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dmhsnv
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
        Me.components = New System.ComponentModel.Container
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
        Me.Panhs = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chbda_nop = New System.Windows.Forms.CheckBox
        Me.ten_loai_hs = New System.Windows.Forms.Label
        Me.txtso_luong = New ClsControl2.TxtNumeric
        Me.gfldinh_kem = New ClsControl2.gflGetFile
        Me.txtma_loai_hs = New System.Windows.Forms.TextBox
        Me.txtten_hs = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panhs.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtngay_sua
        '
        Me.txtngay_sua.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtngay_sua.AutoSize = True
        Me.txtngay_sua.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtngay_sua.Location = New System.Drawing.Point(234, 234)
        Me.txtngay_sua.Name = "txtngay_sua"
        Me.txtngay_sua.Size = New System.Drawing.Size(50, 13)
        Me.txtngay_sua.TabIndex = 109
        Me.txtngay_sua.Text = "ngay sua"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(167, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 108
        Me.Label5.Tag = "093"
        Me.Label5.Text = "Ngay sua:"
        '
        'txtnguoi_sua
        '
        Me.txtnguoi_sua.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtnguoi_sua.AutoSize = True
        Me.txtnguoi_sua.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtnguoi_sua.Location = New System.Drawing.Point(76, 234)
        Me.txtnguoi_sua.Name = "txtnguoi_sua"
        Me.txtnguoi_sua.Size = New System.Drawing.Size(53, 13)
        Me.txtnguoi_sua.TabIndex = 107
        Me.txtnguoi_sua.Text = "nguoi sua"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(9, 234)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 106
        Me.Label8.Tag = "091"
        Me.Label8.Text = "Nguoi sua:"
        '
        'txtngay_tao
        '
        Me.txtngay_tao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtngay_tao.AutoSize = True
        Me.txtngay_tao.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtngay_tao.Location = New System.Drawing.Point(234, 219)
        Me.txtngay_tao.Name = "txtngay_tao"
        Me.txtngay_tao.Size = New System.Drawing.Size(48, 13)
        Me.txtngay_tao.TabIndex = 105
        Me.txtngay_tao.Text = "ngay tao"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(167, 219)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 104
        Me.Label6.Tag = "092"
        Me.Label6.Text = "Ngay tao:"
        '
        'txtnguoi_tao
        '
        Me.txtnguoi_tao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtnguoi_tao.AutoSize = True
        Me.txtnguoi_tao.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtnguoi_tao.Location = New System.Drawing.Point(76, 219)
        Me.txtnguoi_tao.Name = "txtnguoi_tao"
        Me.txtnguoi_tao.Size = New System.Drawing.Size(51, 13)
        Me.txtnguoi_tao.TabIndex = 103
        Me.txtnguoi_tao.Text = "nguoi tao"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(9, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 102
        Me.Label3.Tag = "090"
        Me.Label3.Text = "Nguoi tao:"
        '
        'btnhuy
        '
        Me.btnhuy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnhuy.CausesValidation = False
        Me.btnhuy.Location = New System.Drawing.Point(68, 175)
        Me.btnhuy.Name = "btnhuy"
        Me.btnhuy.Size = New System.Drawing.Size(54, 28)
        Me.btnhuy.TabIndex = 111
        Me.btnhuy.Tag = "095"
        Me.btnhuy.Text = "Huy"
        Me.btnhuy.UseVisualStyleBackColor = True
        '
        'btnLuu
        '
        Me.btnLuu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLuu.Location = New System.Drawing.Point(12, 175)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(54, 28)
        Me.btnLuu.TabIndex = 110
        Me.btnLuu.Tag = "094"
        Me.btnLuu.Text = "Luu"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'Panhs
        '
        Me.Panhs.BackColor = System.Drawing.Color.White
        Me.Panhs.Controls.Add(Me.GroupBox1)
        Me.Panhs.Location = New System.Drawing.Point(-1, 7)
        Me.Panhs.Name = "Panhs"
        Me.Panhs.Size = New System.Drawing.Size(461, 161)
        Me.Panhs.TabIndex = 112
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chbda_nop)
        Me.GroupBox1.Controls.Add(Me.ten_loai_hs)
        Me.GroupBox1.Controls.Add(Me.txtso_luong)
        Me.GroupBox1.Controls.Add(Me.gfldinh_kem)
        Me.GroupBox1.Controls.Add(Me.txtma_loai_hs)
        Me.GroupBox1.Controls.Add(Me.txtten_hs)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(443, 152)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'chbda_nop
        '
        Me.chbda_nop.AutoSize = True
        Me.chbda_nop.Location = New System.Drawing.Point(88, 126)
        Me.chbda_nop.Name = "chbda_nop"
        Me.chbda_nop.Size = New System.Drawing.Size(59, 17)
        Me.chbda_nop.TabIndex = 4
        Me.chbda_nop.Tag = "005"
        Me.chbda_nop.Text = "da nop"
        Me.chbda_nop.UseVisualStyleBackColor = True
        '
        'ten_loai_hs
        '
        Me.ten_loai_hs.AutoSize = True
        Me.ten_loai_hs.Location = New System.Drawing.Point(192, 50)
        Me.ten_loai_hs.Name = "ten_loai_hs"
        Me.ten_loai_hs.Size = New System.Drawing.Size(61, 13)
        Me.ten_loai_hs.TabIndex = 8
        Me.ten_loai_hs.Text = "ten_loai_hs"
        '
        'txtso_luong
        '
        Me.txtso_luong.Location = New System.Drawing.Point(88, 74)
        Me.txtso_luong.MaxLength = 18
        Me.txtso_luong.Name = "txtso_luong"
        Me.txtso_luong.NumberDecimalDigits = 2
        Me.txtso_luong.Size = New System.Drawing.Size(96, 20)
        Me.txtso_luong.TabIndex = 2
        Me.txtso_luong.Text = "0.00"
        Me.txtso_luong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtso_luong.Value = 0
        Me.txtso_luong.Value2 = 0
        '
        'gfldinh_kem
        '
        Me.gfldinh_kem.Buffer = Nothing
        Me.gfldinh_kem.Filename = ""
        Me.gfldinh_kem.Location = New System.Drawing.Point(88, 99)
        Me.gfldinh_kem.Name = "gfldinh_kem"
        Me.gfldinh_kem.Size = New System.Drawing.Size(332, 23)
        Me.gfldinh_kem.TabIndex = 3
        Me.gfldinh_kem.Text = "..."
        Me.gfldinh_kem.UseCompatibleTextRendering = True
        Me.gfldinh_kem.UseVisualStyleBackColor = True
        '
        'txtma_loai_hs
        '
        Me.txtma_loai_hs.Location = New System.Drawing.Point(88, 46)
        Me.txtma_loai_hs.Name = "txtma_loai_hs"
        Me.txtma_loai_hs.Size = New System.Drawing.Size(96, 20)
        Me.txtma_loai_hs.TabIndex = 1
        '
        'txtten_hs
        '
        Me.txtten_hs.Location = New System.Drawing.Point(88, 18)
        Me.txtten_hs.Name = "txtten_hs"
        Me.txtten_hs.Size = New System.Drawing.Size(332, 20)
        Me.txtten_hs.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Tag = "004"
        Me.Label7.Text = "File đính kèm"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Tag = "003"
        Me.Label4.Text = "So luong"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Tag = "002"
        Me.Label2.Text = "Loai"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Tag = "001"
        Me.Label1.Text = "Ten ho so"
        '
        'dmhsnv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 254)
        Me.Controls.Add(Me.Panhs)
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
        Me.Name = "dmhsnv"
        Me.Tag = "000"
        Me.Text = "dmhsnv"
        Me.Panhs.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents Panhs As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gfldinh_kem As ClsControl2.gflGetFile
    Friend WithEvents txtma_loai_hs As System.Windows.Forms.TextBox
    Friend WithEvents txtten_hs As System.Windows.Forms.TextBox
    Friend WithEvents txtso_luong As ClsControl2.TxtNumeric
    Friend WithEvents ten_loai_hs As System.Windows.Forms.Label
    Friend WithEvents chbda_nop As System.Windows.Forms.CheckBox
End Class
