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
        Me.txtma_dvcs = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnLuu = New System.Windows.Forms.Button
        Me.btnhuy = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblten_tk = New System.Windows.Forms.Label
        Me.lblten_dvcs = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Txtdu_co_nt1 = New ClsControl2.TxtNumeric
        Me.Txtdu_no_nt1 = New ClsControl2.TxtNumeric
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Txtdu_co_nt00 = New ClsControl2.TxtNumeric
        Me.Txtdu_no_nt00 = New ClsControl2.TxtNumeric
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Txtdu_co1 = New ClsControl2.TxtNumeric
        Me.Txtdu_co00 = New ClsControl2.TxtNumeric
        Me.Txtdu_no1 = New ClsControl2.TxtNumeric
        Me.Txtdu_no00 = New ClsControl2.TxtNumeric
        Me.txttk = New System.Windows.Forms.TextBox
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
        'txtma_dvcs
        '
        Me.txtma_dvcs.Enabled = False
        Me.txtma_dvcs.Location = New System.Drawing.Point(97, 12)
        Me.txtma_dvcs.Name = "txtma_dvcs"
        Me.txtma_dvcs.ReadOnly = True
        Me.txtma_dvcs.Size = New System.Drawing.Size(123, 20)
        Me.txtma_dvcs.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Tag = "001"
        Me.Label2.Text = "Don vi"
        '
        'btnLuu
        '
        Me.btnLuu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLuu.Location = New System.Drawing.Point(3, 179)
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
        Me.btnhuy.Location = New System.Drawing.Point(59, 179)
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
        Me.GroupBox1.Controls.Add(Me.lblten_tk)
        Me.GroupBox1.Controls.Add(Me.lblten_dvcs)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Txtdu_co_nt1)
        Me.GroupBox1.Controls.Add(Me.Txtdu_no_nt1)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Txtdu_co_nt00)
        Me.GroupBox1.Controls.Add(Me.Txtdu_no_nt00)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Txtdu_co1)
        Me.GroupBox1.Controls.Add(Me.Txtdu_co00)
        Me.GroupBox1.Controls.Add(Me.Txtdu_no1)
        Me.GroupBox1.Controls.Add(Me.Txtdu_no00)
        Me.GroupBox1.Controls.Add(Me.txttk)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtma_dvcs)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(-7, -7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(524, 173)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'lblten_tk
        '
        Me.lblten_tk.AutoSize = True
        Me.lblten_tk.Location = New System.Drawing.Point(227, 41)
        Me.lblten_tk.Name = "lblten_tk"
        Me.lblten_tk.Size = New System.Drawing.Size(34, 13)
        Me.lblten_tk.TabIndex = 105
        Me.lblten_tk.Text = "ten tk"
        '
        'lblten_dvcs
        '
        Me.lblten_dvcs.AutoSize = True
        Me.lblten_dvcs.Location = New System.Drawing.Point(227, 15)
        Me.lblten_dvcs.Name = "lblten_dvcs"
        Me.lblten_dvcs.Size = New System.Drawing.Size(54, 13)
        Me.lblten_dvcs.TabIndex = 104
        Me.lblten_dvcs.Text = "ten don vi"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(227, 146)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(92, 13)
        Me.Label13.TabIndex = 103
        Me.Label13.Tag = "010"
        Me.Label13.Text = "Du co nt dau nam"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(227, 120)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(92, 13)
        Me.Label14.TabIndex = 102
        Me.Label14.Tag = "009"
        Me.Label14.Text = "Du no nt dau nam"
        '
        'Txtdu_co_nt1
        '
        Me.Txtdu_co_nt1.Location = New System.Drawing.Point(339, 142)
        Me.Txtdu_co_nt1.MaxLength = 18
        Me.Txtdu_co_nt1.Name = "Txtdu_co_nt1"
        Me.Txtdu_co_nt1.NumberDecimalDigits = 2
        Me.Txtdu_co_nt1.Size = New System.Drawing.Size(123, 20)
        Me.Txtdu_co_nt1.TabIndex = 9
        Me.Txtdu_co_nt1.Text = "0.00"
        Me.Txtdu_co_nt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtdu_co_nt1.Value = 0
        Me.Txtdu_co_nt1.Value2 = 0
        '
        'Txtdu_no_nt1
        '
        Me.Txtdu_no_nt1.Location = New System.Drawing.Point(339, 116)
        Me.Txtdu_no_nt1.MaxLength = 18
        Me.Txtdu_no_nt1.Name = "Txtdu_no_nt1"
        Me.Txtdu_no_nt1.NumberDecimalDigits = 2
        Me.Txtdu_no_nt1.Size = New System.Drawing.Size(123, 20)
        Me.Txtdu_no_nt1.TabIndex = 7
        Me.Txtdu_no_nt1.Text = "0.00"
        Me.Txtdu_no_nt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtdu_no_nt1.Value = 0
        Me.Txtdu_no_nt1.Value2 = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 146)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 99
        Me.Label11.Tag = "006"
        Me.Label11.Text = "Du co nt"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 120)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 13)
        Me.Label12.TabIndex = 98
        Me.Label12.Tag = "005"
        Me.Label12.Text = "Du no nt"
        '
        'Txtdu_co_nt00
        '
        Me.Txtdu_co_nt00.Location = New System.Drawing.Point(97, 142)
        Me.Txtdu_co_nt00.MaxLength = 18
        Me.Txtdu_co_nt00.Name = "Txtdu_co_nt00"
        Me.Txtdu_co_nt00.NumberDecimalDigits = 2
        Me.Txtdu_co_nt00.Size = New System.Drawing.Size(123, 20)
        Me.Txtdu_co_nt00.TabIndex = 8
        Me.Txtdu_co_nt00.Text = "0.00"
        Me.Txtdu_co_nt00.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtdu_co_nt00.Value = 0
        Me.Txtdu_co_nt00.Value2 = 0
        '
        'Txtdu_no_nt00
        '
        Me.Txtdu_no_nt00.Location = New System.Drawing.Point(97, 116)
        Me.Txtdu_no_nt00.MaxLength = 18
        Me.Txtdu_no_nt00.Name = "Txtdu_no_nt00"
        Me.Txtdu_no_nt00.NumberDecimalDigits = 2
        Me.Txtdu_no_nt00.Size = New System.Drawing.Size(123, 20)
        Me.Txtdu_no_nt00.TabIndex = 6
        Me.Txtdu_no_nt00.Text = "0.00"
        Me.Txtdu_no_nt00.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtdu_no_nt00.Value = 0
        Me.Txtdu_no_nt00.Value2 = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(227, 94)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 95
        Me.Label9.Tag = "008"
        Me.Label9.Text = "Du co dau nam"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Tag = "004"
        Me.Label7.Text = "Du co"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(227, 68)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 13)
        Me.Label10.TabIndex = 94
        Me.Label10.Tag = "007"
        Me.Label10.Text = "Du no dau nam"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Tag = "003"
        Me.Label4.Text = "Du no"
        '
        'Txtdu_co1
        '
        Me.Txtdu_co1.Location = New System.Drawing.Point(339, 90)
        Me.Txtdu_co1.MaxLength = 18
        Me.Txtdu_co1.Name = "Txtdu_co1"
        Me.Txtdu_co1.NumberDecimalDigits = 0
        Me.Txtdu_co1.Size = New System.Drawing.Size(123, 20)
        Me.Txtdu_co1.TabIndex = 5
        Me.Txtdu_co1.Text = "0"
        Me.Txtdu_co1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtdu_co1.Value = 0
        Me.Txtdu_co1.Value2 = 0
        '
        'Txtdu_co00
        '
        Me.Txtdu_co00.Location = New System.Drawing.Point(97, 90)
        Me.Txtdu_co00.MaxLength = 18
        Me.Txtdu_co00.Name = "Txtdu_co00"
        Me.Txtdu_co00.NumberDecimalDigits = 0
        Me.Txtdu_co00.Size = New System.Drawing.Size(123, 20)
        Me.Txtdu_co00.TabIndex = 4
        Me.Txtdu_co00.Text = "0"
        Me.Txtdu_co00.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtdu_co00.Value = 0
        Me.Txtdu_co00.Value2 = 0
        '
        'Txtdu_no1
        '
        Me.Txtdu_no1.Location = New System.Drawing.Point(339, 64)
        Me.Txtdu_no1.MaxLength = 18
        Me.Txtdu_no1.Name = "Txtdu_no1"
        Me.Txtdu_no1.NumberDecimalDigits = 0
        Me.Txtdu_no1.Size = New System.Drawing.Size(123, 20)
        Me.Txtdu_no1.TabIndex = 3
        Me.Txtdu_no1.Text = "0"
        Me.Txtdu_no1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtdu_no1.Value = 0
        Me.Txtdu_no1.Value2 = 0
        '
        'Txtdu_no00
        '
        Me.Txtdu_no00.Location = New System.Drawing.Point(97, 64)
        Me.Txtdu_no00.MaxLength = 18
        Me.Txtdu_no00.Name = "Txtdu_no00"
        Me.Txtdu_no00.NumberDecimalDigits = 0
        Me.Txtdu_no00.Size = New System.Drawing.Size(123, 20)
        Me.Txtdu_no00.TabIndex = 2
        Me.Txtdu_no00.Text = "0"
        Me.Txtdu_no00.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtdu_no00.Value = 0
        Me.Txtdu_no00.Value2 = 0
        '
        'txttk
        '
        Me.txttk.Enabled = False
        Me.txttk.Location = New System.Drawing.Point(97, 38)
        Me.txttk.Name = "txttk"
        Me.txttk.ReadOnly = True
        Me.txttk.Size = New System.Drawing.Size(123, 20)
        Me.txttk.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Tag = "002"
        Me.Label1.Text = "Tai khoan"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(0, 216)
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
        Me.txtnguoi_tao.Location = New System.Drawing.Point(67, 216)
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
        Me.txtngay_tao.Location = New System.Drawing.Point(225, 216)
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
        Me.Label6.Location = New System.Drawing.Point(158, 216)
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
        Me.txtngay_sua.Location = New System.Drawing.Point(225, 231)
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
        Me.Label5.Location = New System.Drawing.Point(158, 231)
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
        Me.txtnguoi_sua.Location = New System.Drawing.Point(67, 231)
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
        Me.Label8.Location = New System.Drawing.Point(0, 231)
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
        Me.ClientSize = New System.Drawing.Size(512, 250)
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
    Friend WithEvents txtma_dvcs As System.Windows.Forms.TextBox
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
    Friend WithEvents txttk As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Txtdu_co00 As ClsControl2.TxtNumeric
    Friend WithEvents Txtdu_no00 As ClsControl2.TxtNumeric
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Txtdu_co_nt1 As ClsControl2.TxtNumeric
    Friend WithEvents Txtdu_no_nt1 As ClsControl2.TxtNumeric
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Txtdu_co_nt00 As ClsControl2.TxtNumeric
    Friend WithEvents Txtdu_no_nt00 As ClsControl2.TxtNumeric
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Txtdu_co1 As ClsControl2.TxtNumeric
    Friend WithEvents Txtdu_no1 As ClsControl2.TxtNumeric
    Friend WithEvents lblten_dvcs As System.Windows.Forms.Label
    Friend WithEvents lblten_tk As System.Windows.Forms.Label
End Class
