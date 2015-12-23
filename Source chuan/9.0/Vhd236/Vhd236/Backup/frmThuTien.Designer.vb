<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThuTien
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
        Me.btnOK = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtty_gia = New ClsControl2.TxtNumeric
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtma_nt = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txttien = New ClsControl2.TxtNumeric
        Me.Label2 = New System.Windows.Forms.Label
        Me.ten_kh = New System.Windows.Forms.Label
        Me.txtma_kh = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.ten_nvu = New System.Windows.Forms.Label
        Me.txtma_nvu = New System.Windows.Forms.TextBox
        Me.txttien_nt = New ClsControl2.TxtNumeric
        Me.Label5 = New System.Windows.Forms.Label
        Me.txttien_hd = New ClsControl2.TxtNumeric
        Me.Label4 = New System.Windows.Forms.Label
        Me.Txtt_tien_pt = New ClsControl2.TxtNumeric
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.chbttthd = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Location = New System.Drawing.Point(2, 206)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "Thu"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(83, 206)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Hủy"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.chbttthd)
        Me.GroupBox1.Controls.Add(Me.txtty_gia)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtma_nt)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txttien)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ten_kh)
        Me.GroupBox1.Controls.Add(Me.txtma_kh)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.ten_nvu)
        Me.GroupBox1.Controls.Add(Me.txtma_nvu)
        Me.GroupBox1.Controls.Add(Me.txttien_nt)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txttien_hd)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Txtt_tien_pt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(-2, -10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(530, 212)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'txtty_gia
        '
        Me.txtty_gia.Location = New System.Drawing.Point(351, 139)
        Me.txtty_gia.MaxLength = 0
        Me.txtty_gia.Name = "txtty_gia"
        Me.txtty_gia.NumberDecimalDigits = 2
        Me.txtty_gia.Size = New System.Drawing.Size(86, 20)
        Me.txtty_gia.TabIndex = 6
        Me.txtty_gia.Text = "1.00"
        Me.txtty_gia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtty_gia.Value = 1
        Me.txtty_gia.Value2 = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(287, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 123
        Me.Label6.Text = "Tỷ giá"
        '
        'txtma_nt
        '
        Me.txtma_nt.Location = New System.Drawing.Point(154, 139)
        Me.txtma_nt.Name = "txtma_nt"
        Me.txtma_nt.Size = New System.Drawing.Size(130, 20)
        Me.txtma_nt.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 143)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 120
        Me.Label8.Text = "Ngoại tệ"
        '
        'txttien
        '
        Me.txttien.Location = New System.Drawing.Point(154, 164)
        Me.txttien.MaxLength = 0
        Me.txttien.Name = "txttien"
        Me.txttien.NumberDecimalDigits = 2
        Me.txttien.Size = New System.Drawing.Size(130, 20)
        Me.txttien.TabIndex = 7
        Me.txttien.Text = "0.00"
        Me.txttien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txttien.Value = 0
        Me.txttien.Value2 = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 119
        Me.Label2.Text = "Tiền thu VNĐ"
        '
        'ten_kh
        '
        Me.ten_kh.AutoSize = True
        Me.ten_kh.Location = New System.Drawing.Point(290, 44)
        Me.ten_kh.Name = "ten_kh"
        Me.ten_kh.Size = New System.Drawing.Size(82, 13)
        Me.ten_kh.TabIndex = 117
        Me.ten_kh.Text = "ten khach hang"
        '
        'txtma_kh
        '
        Me.txtma_kh.Location = New System.Drawing.Point(154, 40)
        Me.txtma_kh.Name = "txtma_kh"
        Me.txtma_kh.ReadOnly = True
        Me.txtma_kh.Size = New System.Drawing.Size(130, 20)
        Me.txtma_kh.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 115
        Me.Label7.Text = "Khách hàng"
        '
        'ten_nvu
        '
        Me.ten_nvu.AutoSize = True
        Me.ten_nvu.Location = New System.Drawing.Point(290, 20)
        Me.ten_nvu.Name = "ten_nvu"
        Me.ten_nvu.Size = New System.Drawing.Size(72, 13)
        Me.ten_nvu.TabIndex = 114
        Me.ten_nvu.Text = "ten nghiep vu"
        '
        'txtma_nvu
        '
        Me.txtma_nvu.Location = New System.Drawing.Point(154, 16)
        Me.txtma_nvu.Name = "txtma_nvu"
        Me.txtma_nvu.Size = New System.Drawing.Size(130, 20)
        Me.txtma_nvu.TabIndex = 0
        '
        'txttien_nt
        '
        Me.txttien_nt.Location = New System.Drawing.Point(154, 114)
        Me.txttien_nt.MaxLength = 0
        Me.txttien_nt.Name = "txttien_nt"
        Me.txttien_nt.NumberDecimalDigits = 2
        Me.txttien_nt.Size = New System.Drawing.Size(130, 20)
        Me.txttien_nt.TabIndex = 4
        Me.txttien_nt.Text = "0.00"
        Me.txttien_nt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txttien_nt.Value = 0
        Me.txttien_nt.Value2 = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 111
        Me.Label5.Text = "Tiền thu ngoại tệ"
        '
        'txttien_hd
        '
        Me.txttien_hd.Location = New System.Drawing.Point(154, 89)
        Me.txttien_hd.MaxLength = 0
        Me.txttien_hd.Name = "txttien_hd"
        Me.txttien_hd.NumberDecimalDigits = 2
        Me.txttien_hd.ReadOnly = True
        Me.txttien_hd.Size = New System.Drawing.Size(130, 20)
        Me.txttien_hd.TabIndex = 3
        Me.txttien_hd.Text = "0.00"
        Me.txttien_hd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txttien_hd.Value = 0
        Me.txttien_hd.Value2 = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 109
        Me.Label4.Text = "Số tiền trên HD này"
        '
        'Txtt_tien_pt
        '
        Me.Txtt_tien_pt.Location = New System.Drawing.Point(154, 64)
        Me.Txtt_tien_pt.MaxLength = 0
        Me.Txtt_tien_pt.Name = "Txtt_tien_pt"
        Me.Txtt_tien_pt.NumberDecimalDigits = 2
        Me.Txtt_tien_pt.ReadOnly = True
        Me.Txtt_tien_pt.Size = New System.Drawing.Size(130, 20)
        Me.Txtt_tien_pt.TabIndex = 2
        Me.Txtt_tien_pt.Text = "0.00"
        Me.Txtt_tien_pt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtt_tien_pt.Value = 0
        Me.Txtt_tien_pt.Value2 = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tổng số tiền phải thu (VNĐ)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nghiệp vụ"
        '
        'chbttthd
        '
        Me.chbttthd.AutoSize = True
        Me.chbttthd.Location = New System.Drawing.Point(154, 190)
        Me.chbttthd.Name = "chbttthd"
        Me.chbttthd.Size = New System.Drawing.Size(148, 17)
        Me.chbttthd.TabIndex = 9
        Me.chbttthd.Tag = "TTTHD"
        Me.chbttthd.Text = "Thanh toán theo hóa đơn"
        Me.chbttthd.UseVisualStyleBackColor = True
        '
        'frmThuTien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 233)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Name = "frmThuTien"
        Me.Text = "frmThuTien"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txttien_nt As ClsControl2.TxtNumeric
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txttien_hd As ClsControl2.TxtNumeric
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Txtt_tien_pt As ClsControl2.TxtNumeric
    Friend WithEvents ten_kh As System.Windows.Forms.Label
    Friend WithEvents txtma_kh As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ten_nvu As System.Windows.Forms.Label
    Friend WithEvents txtma_nvu As System.Windows.Forms.TextBox
    Friend WithEvents txtty_gia As ClsControl2.TxtNumeric
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtma_nt As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txttien As ClsControl2.TxtNumeric
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chbttthd As System.Windows.Forms.CheckBox
End Class
