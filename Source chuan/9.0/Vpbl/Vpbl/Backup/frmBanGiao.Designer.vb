<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBanGiao
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txttong_tien_ban_giao = New ClsControl2.TxtNumeric
        Me.txttong_tien = New ClsControl2.TxtNumeric
        Me.txtden_gio = New System.Windows.Forms.TextBox
        Me.txttu_gio = New System.Windows.Forms.TextBox
        Me.txtma_ca = New System.Windows.Forms.TextBox
        Me.txtma_may = New System.Windows.Forms.TextBox
        Me.txtnhan_vien = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtghi_chu = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnOk = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.txttong_tien_ban_giao)
        Me.GroupBox1.Controls.Add(Me.txttong_tien)
        Me.GroupBox1.Controls.Add(Me.txtden_gio)
        Me.GroupBox1.Controls.Add(Me.txttu_gio)
        Me.GroupBox1.Controls.Add(Me.txtma_ca)
        Me.GroupBox1.Controls.Add(Me.txtma_may)
        Me.GroupBox1.Controls.Add(Me.txtnhan_vien)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtghi_chu)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(-7, -13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(504, 211)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txttong_tien_ban_giao
        '
        Me.txttong_tien_ban_giao.Location = New System.Drawing.Point(129, 152)
        Me.txttong_tien_ban_giao.MaxLength = 18
        Me.txttong_tien_ban_giao.Name = "txttong_tien_ban_giao"
        Me.txttong_tien_ban_giao.NumberDecimalDigits = 2
        Me.txttong_tien_ban_giao.Size = New System.Drawing.Size(336, 20)
        Me.txttong_tien_ban_giao.TabIndex = 8
        Me.txttong_tien_ban_giao.Text = "0.00"
        Me.txttong_tien_ban_giao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txttong_tien_ban_giao.Value = 0
        Me.txttong_tien_ban_giao.Value2 = 0
        '
        'txttong_tien
        '
        Me.txttong_tien.Location = New System.Drawing.Point(129, 124)
        Me.txttong_tien.MaxLength = 18
        Me.txttong_tien.Name = "txttong_tien"
        Me.txttong_tien.NumberDecimalDigits = 2
        Me.txttong_tien.ReadOnly = True
        Me.txttong_tien.Size = New System.Drawing.Size(336, 20)
        Me.txttong_tien.TabIndex = 7
        Me.txttong_tien.Text = "0.00"
        Me.txttong_tien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txttong_tien.Value = 0
        Me.txttong_tien.Value2 = 0
        '
        'txtden_gio
        '
        Me.txtden_gio.Location = New System.Drawing.Point(354, 98)
        Me.txtden_gio.Name = "txtden_gio"
        Me.txtden_gio.ReadOnly = True
        Me.txtden_gio.Size = New System.Drawing.Size(111, 20)
        Me.txtden_gio.TabIndex = 4
        '
        'txttu_gio
        '
        Me.txttu_gio.Location = New System.Drawing.Point(129, 98)
        Me.txttu_gio.Name = "txttu_gio"
        Me.txttu_gio.ReadOnly = True
        Me.txttu_gio.Size = New System.Drawing.Size(107, 20)
        Me.txttu_gio.TabIndex = 3
        '
        'txtma_ca
        '
        Me.txtma_ca.Location = New System.Drawing.Point(129, 71)
        Me.txtma_ca.Name = "txtma_ca"
        Me.txtma_ca.ReadOnly = True
        Me.txtma_ca.Size = New System.Drawing.Size(336, 20)
        Me.txtma_ca.TabIndex = 2
        '
        'txtma_may
        '
        Me.txtma_may.Location = New System.Drawing.Point(129, 45)
        Me.txtma_may.Name = "txtma_may"
        Me.txtma_may.ReadOnly = True
        Me.txtma_may.Size = New System.Drawing.Size(336, 20)
        Me.txtma_may.TabIndex = 1
        '
        'txtnhan_vien
        '
        Me.txtnhan_vien.Location = New System.Drawing.Point(129, 18)
        Me.txtnhan_vien.Name = "txtnhan_vien"
        Me.txtnhan_vien.ReadOnly = True
        Me.txtnhan_vien.Size = New System.Drawing.Size(336, 20)
        Me.txtnhan_vien.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(19, 156)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Tag = "TTG"
        Me.Label10.Text = "Số tiền đã bàn giao"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 183)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Tag = "GCH"
        Me.Label9.Text = "Ghi chú"
        '
        'txtghi_chu
        '
        Me.txtghi_chu.Location = New System.Drawing.Point(129, 179)
        Me.txtghi_chu.Name = "txtghi_chu"
        Me.txtghi_chu.Size = New System.Drawing.Size(336, 20)
        Me.txtghi_chu.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Tag = "TTH"
        Me.Label8.Text = "Tổng tiền hàng"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(276, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Tag = "DG"
        Me.Label5.Text = "Đến giờ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Tag = "TG"
        Me.Label4.Text = "Từ giờ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Tag = "TCA"
        Me.Label3.Text = "Ca"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Tag = "TQH"
        Me.Label2.Text = "Quầy hàng"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Tag = "TNV"
        Me.Label1.Text = "Nhân viên bán hàng"
        '
        'btnOk
        '
        Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOk.Location = New System.Drawing.Point(7, 205)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 1
        Me.btnOk.Tag = "OK"
        Me.btnOk.Text = "Bàn giao"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(88, 205)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Tag = "HUY"
        Me.btnCancel.Text = "Hủy"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmBanGiao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 237)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmBanGiao"
        Me.Tag = "BGC"
        Me.Text = "Bàn giao ca bán hàng"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtden_gio As System.Windows.Forms.TextBox
    Friend WithEvents txttu_gio As System.Windows.Forms.TextBox
    Friend WithEvents txtma_ca As System.Windows.Forms.TextBox
    Friend WithEvents txtma_may As System.Windows.Forms.TextBox
    Friend WithEvents txtnhan_vien As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtghi_chu As System.Windows.Forms.TextBox
    Friend WithEvents txttong_tien_ban_giao As ClsControl2.TxtNumeric
    Friend WithEvents txttong_tien As ClsControl2.TxtNumeric
End Class
