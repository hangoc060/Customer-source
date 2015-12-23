<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class daotao
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
        Me.btnhuy = New System.Windows.Forms.Button
        Me.btnLuu = New System.Windows.Forms.Button
        Me.txtngay_sua = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtnguoi_sua = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtngay_tao = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtnguoi_tao = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Pandt = New System.Windows.Forms.Panel
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txttt_them = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtnoi_cu_di_dt = New System.Windows.Forms.TextBox
        Me.txtnoi_cap_bang = New System.Windows.Forms.TextBox
        Me.txtten_chung_chi = New System.Windows.Forms.TextBox
        Me.txtket_qua = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtchi_phi_dt = New ClsControl2.TxtNumeric
        Me.txtngay_kt_dt = New ClsControl2.TxtDate
        Me.txtngay_bd_dt = New ClsControl2.TxtDate
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtten_khoa_dt = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Pandt.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnhuy
        '
        Me.btnhuy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnhuy.CausesValidation = False
        Me.btnhuy.Location = New System.Drawing.Point(70, 292)
        Me.btnhuy.Name = "btnhuy"
        Me.btnhuy.Size = New System.Drawing.Size(54, 28)
        Me.btnhuy.TabIndex = 103
        Me.btnhuy.Tag = "095"
        Me.btnhuy.Text = "Huy"
        Me.btnhuy.UseVisualStyleBackColor = True
        '
        'btnLuu
        '
        Me.btnLuu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLuu.Location = New System.Drawing.Point(14, 292)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(54, 28)
        Me.btnLuu.TabIndex = 102
        Me.btnLuu.Tag = "094"
        Me.btnLuu.Text = "Luu"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'txtngay_sua
        '
        Me.txtngay_sua.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtngay_sua.AutoSize = True
        Me.txtngay_sua.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtngay_sua.Location = New System.Drawing.Point(237, 350)
        Me.txtngay_sua.Name = "txtngay_sua"
        Me.txtngay_sua.Size = New System.Drawing.Size(50, 13)
        Me.txtngay_sua.TabIndex = 111
        Me.txtngay_sua.Text = "ngay sua"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(170, 350)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 110
        Me.Label5.Tag = "093"
        Me.Label5.Text = "Ngay sua:"
        '
        'txtnguoi_sua
        '
        Me.txtnguoi_sua.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtnguoi_sua.AutoSize = True
        Me.txtnguoi_sua.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtnguoi_sua.Location = New System.Drawing.Point(79, 350)
        Me.txtnguoi_sua.Name = "txtnguoi_sua"
        Me.txtnguoi_sua.Size = New System.Drawing.Size(53, 13)
        Me.txtnguoi_sua.TabIndex = 109
        Me.txtnguoi_sua.Text = "nguoi sua"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(12, 350)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 108
        Me.Label8.Tag = "091"
        Me.Label8.Text = "Nguoi sua:"
        '
        'txtngay_tao
        '
        Me.txtngay_tao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtngay_tao.AutoSize = True
        Me.txtngay_tao.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtngay_tao.Location = New System.Drawing.Point(237, 335)
        Me.txtngay_tao.Name = "txtngay_tao"
        Me.txtngay_tao.Size = New System.Drawing.Size(48, 13)
        Me.txtngay_tao.TabIndex = 107
        Me.txtngay_tao.Text = "ngay tao"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(170, 335)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 106
        Me.Label6.Tag = "092"
        Me.Label6.Text = "Ngay tao:"
        '
        'txtnguoi_tao
        '
        Me.txtnguoi_tao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtnguoi_tao.AutoSize = True
        Me.txtnguoi_tao.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtnguoi_tao.Location = New System.Drawing.Point(79, 335)
        Me.txtnguoi_tao.Name = "txtnguoi_tao"
        Me.txtnguoi_tao.Size = New System.Drawing.Size(51, 13)
        Me.txtnguoi_tao.TabIndex = 105
        Me.txtnguoi_tao.Text = "nguoi tao"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(12, 335)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 104
        Me.Label3.Tag = "090"
        Me.Label3.Text = "Nguoi tao:"
        '
        'Pandt
        '
        Me.Pandt.BackColor = System.Drawing.Color.White
        Me.Pandt.Controls.Add(Me.GroupBox3)
        Me.Pandt.Controls.Add(Me.GroupBox2)
        Me.Pandt.Controls.Add(Me.GroupBox1)
        Me.Pandt.Location = New System.Drawing.Point(-2, -1)
        Me.Pandt.Name = "Pandt"
        Me.Pandt.Size = New System.Drawing.Size(733, 284)
        Me.Pandt.TabIndex = 112
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txttt_them)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 149)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(696, 124)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Tag = "074"
        Me.GroupBox3.Text = "Thông tin thêm"
        '
        'txttt_them
        '
        Me.txttt_them.Location = New System.Drawing.Point(16, 28)
        Me.txttt_them.Multiline = True
        Me.txttt_them.Name = "txttt_them"
        Me.txttt_them.Size = New System.Drawing.Size(657, 65)
        Me.txttt_them.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtnoi_cu_di_dt)
        Me.GroupBox2.Controls.Add(Me.txtnoi_cap_bang)
        Me.GroupBox2.Controls.Add(Me.txtten_chung_chi)
        Me.GroupBox2.Controls.Add(Me.txtket_qua)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(364, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(349, 123)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'txtnoi_cu_di_dt
        '
        Me.txtnoi_cu_di_dt.Location = New System.Drawing.Point(107, 97)
        Me.txtnoi_cu_di_dt.Name = "txtnoi_cu_di_dt"
        Me.txtnoi_cu_di_dt.Size = New System.Drawing.Size(221, 20)
        Me.txtnoi_cu_di_dt.TabIndex = 3
        '
        'txtnoi_cap_bang
        '
        Me.txtnoi_cap_bang.Location = New System.Drawing.Point(107, 71)
        Me.txtnoi_cap_bang.Name = "txtnoi_cap_bang"
        Me.txtnoi_cap_bang.Size = New System.Drawing.Size(221, 20)
        Me.txtnoi_cap_bang.TabIndex = 2
        '
        'txtten_chung_chi
        '
        Me.txtten_chung_chi.Location = New System.Drawing.Point(107, 45)
        Me.txtten_chung_chi.Name = "txtten_chung_chi"
        Me.txtten_chung_chi.Size = New System.Drawing.Size(221, 20)
        Me.txtten_chung_chi.TabIndex = 1
        '
        'txtket_qua
        '
        Me.txtket_qua.Location = New System.Drawing.Point(107, 19)
        Me.txtket_qua.Name = "txtket_qua"
        Me.txtket_qua.Size = New System.Drawing.Size(221, 20)
        Me.txtket_qua.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 101)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 13)
        Me.Label12.TabIndex = 3
        Me.Label12.Tag = "073"
        Me.Label12.Text = "Noi cu di dao tao"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 75)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Tag = "072"
        Me.Label11.Text = "Noi cap bang "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 49)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Tag = "071"
        Me.Label10.Text = "Ten chung chi"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Tag = "070"
        Me.Label9.Text = "Ket qua"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtchi_phi_dt)
        Me.GroupBox1.Controls.Add(Me.txtngay_kt_dt)
        Me.GroupBox1.Controls.Add(Me.txtngay_bd_dt)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtten_khoa_dt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(337, 123)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtchi_phi_dt
        '
        Me.txtchi_phi_dt.Location = New System.Drawing.Point(104, 45)
        Me.txtchi_phi_dt.MaxLength = 18
        Me.txtchi_phi_dt.Name = "txtchi_phi_dt"
        Me.txtchi_phi_dt.NumberDecimalDigits = 2
        Me.txtchi_phi_dt.Size = New System.Drawing.Size(211, 20)
        Me.txtchi_phi_dt.TabIndex = 1
        Me.txtchi_phi_dt.Text = "0.00"
        Me.txtchi_phi_dt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtchi_phi_dt.Value = 0
        Me.txtchi_phi_dt.Value2 = 0
        '
        'txtngay_kt_dt
        '
        Me.txtngay_kt_dt.Location = New System.Drawing.Point(104, 96)
        Me.txtngay_kt_dt.Mask = "00/00/0000"
        Me.txtngay_kt_dt.Name = "txtngay_kt_dt"
        Me.txtngay_kt_dt.Size = New System.Drawing.Size(123, 20)
        Me.txtngay_kt_dt.TabIndex = 3
        Me.txtngay_kt_dt.Text = "29062011"
        Me.txtngay_kt_dt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtngay_kt_dt.Value = New Date(2011, 6, 29, 0, 0, 0, 0)
        '
        'txtngay_bd_dt
        '
        Me.txtngay_bd_dt.Location = New System.Drawing.Point(104, 70)
        Me.txtngay_bd_dt.Mask = "00/00/0000"
        Me.txtngay_bd_dt.Name = "txtngay_bd_dt"
        Me.txtngay_bd_dt.Size = New System.Drawing.Size(123, 20)
        Me.txtngay_bd_dt.TabIndex = 2
        Me.txtngay_bd_dt.Text = "29062011"
        Me.txtngay_bd_dt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtngay_bd_dt.Value = New Date(2011, 6, 29, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Tag = "069"
        Me.Label7.Text = "Ngay ket thuc"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Tag = "068"
        Me.Label4.Text = "Ngay bat dau"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Tag = "067"
        Me.Label2.Text = "Chi phi dao tao"
        '
        'txtten_khoa_dt
        '
        Me.txtten_khoa_dt.Location = New System.Drawing.Point(104, 19)
        Me.txtten_khoa_dt.Name = "txtten_khoa_dt"
        Me.txtten_khoa_dt.Size = New System.Drawing.Size(211, 20)
        Me.txtten_khoa_dt.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Tag = "066"
        Me.Label1.Text = "Ten khoa dao tao"
        '
        'daotao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 371)
        Me.Controls.Add(Me.Pandt)
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
        Me.Name = "daotao"
        Me.Tag = "000"
        Me.Text = "daotao"
        Me.Pandt.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnhuy As System.Windows.Forms.Button
    Friend WithEvents btnLuu As System.Windows.Forms.Button
    Friend WithEvents txtngay_sua As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtnguoi_sua As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtngay_tao As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtnguoi_tao As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Pandt As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txttt_them As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtnoi_cu_di_dt As System.Windows.Forms.TextBox
    Friend WithEvents txtnoi_cap_bang As System.Windows.Forms.TextBox
    Friend WithEvents txtten_chung_chi As System.Windows.Forms.TextBox
    Friend WithEvents txtket_qua As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtchi_phi_dt As ClsControl2.TxtNumeric
    Friend WithEvents txtngay_kt_dt As ClsControl2.TxtDate
    Friend WithEvents txtngay_bd_dt As ClsControl2.TxtDate
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtten_khoa_dt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
