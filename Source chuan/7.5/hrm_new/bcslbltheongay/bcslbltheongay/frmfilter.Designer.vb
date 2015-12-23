<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmfilter
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
        Me.tabdkloc = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.ten_loai_ts = New System.Windows.Forms.Label
        Me.txtloai_ts = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtnam = New System.Windows.Forms.NumericUpDown
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtthang = New System.Windows.Forms.NumericUpDown
        Me.ten_vt = New System.Windows.Forms.Label
        Me.txtma_vt = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ten_ts = New System.Windows.Forms.Label
        Me.txtso_the_ts = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.cbbma_dvcs = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txttitle = New System.Windows.Forms.TextBox
        Me.cbbmau = New System.Windows.Forms.ComboBox
        Me.btnok = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.ten_kh_dl = New System.Windows.Forms.Label
        Me.txtma_kh_dl = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.tabdkloc.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.txtnam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtthang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabdkloc
        '
        Me.tabdkloc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabdkloc.Controls.Add(Me.TabPage1)
        Me.tabdkloc.Location = New System.Drawing.Point(-6, -1)
        Me.tabdkloc.Name = "tabdkloc"
        Me.tabdkloc.SelectedIndex = 0
        Me.tabdkloc.Size = New System.Drawing.Size(660, 222)
        Me.tabdkloc.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ten_kh_dl)
        Me.TabPage1.Controls.Add(Me.txtma_kh_dl)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.ten_loai_ts)
        Me.TabPage1.Controls.Add(Me.txtloai_ts)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txtnam)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtthang)
        Me.TabPage1.Controls.Add(Me.ten_vt)
        Me.TabPage1.Controls.Add(Me.txtma_vt)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.ten_ts)
        Me.TabPage1.Controls.Add(Me.txtso_the_ts)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txttitle)
        Me.TabPage1.Controls.Add(Me.cbbmau)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(652, 196)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Tag = "001"
        Me.TabPage1.Text = "Điều kiện lọc"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ten_loai_ts
        '
        Me.ten_loai_ts.AutoSize = True
        Me.ten_loai_ts.Location = New System.Drawing.Point(288, 89)
        Me.ten_loai_ts.Name = "ten_loai_ts"
        Me.ten_loai_ts.Size = New System.Drawing.Size(45, 13)
        Me.ten_loai_ts.TabIndex = 48
        Me.ten_loai_ts.Text = "ten binh"
        '
        'txtloai_ts
        '
        Me.txtloai_ts.Location = New System.Drawing.Point(145, 85)
        Me.txtloai_ts.Name = "txtloai_ts"
        Me.txtloai_ts.Size = New System.Drawing.Size(125, 20)
        Me.txtloai_ts.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 47
        Me.Label6.Tag = ""
        Me.Label6.Text = "Loại bình"
        '
        'txtnam
        '
        Me.txtnam.Location = New System.Drawing.Point(266, 7)
        Me.txtnam.Maximum = New Decimal(New Integer() {2999, 0, 0, 0})
        Me.txtnam.Minimum = New Decimal(New Integer() {1999, 0, 0, 0})
        Me.txtnam.Name = "txtnam"
        Me.txtnam.Size = New System.Drawing.Size(68, 20)
        Me.txtnam.TabIndex = 1
        Me.txtnam.Value = New Decimal(New Integer() {1999, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(219, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 45
        Me.Label1.Tag = "002"
        Me.Label1.Text = "Năm"
        '
        'txtthang
        '
        Me.txtthang.Location = New System.Drawing.Point(145, 7)
        Me.txtthang.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.txtthang.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtthang.Name = "txtthang"
        Me.txtthang.Size = New System.Drawing.Size(68, 20)
        Me.txtthang.TabIndex = 0
        Me.txtthang.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ten_vt
        '
        Me.ten_vt.AutoSize = True
        Me.ten_vt.Location = New System.Drawing.Point(288, 63)
        Me.ten_vt.Name = "ten_vt"
        Me.ten_vt.Size = New System.Drawing.Size(34, 13)
        Me.ten_vt.TabIndex = 43
        Me.ten_vt.Text = "ten vt"
        '
        'txtma_vt
        '
        Me.txtma_vt.Location = New System.Drawing.Point(145, 59)
        Me.txtma_vt.Name = "txtma_vt"
        Me.txtma_vt.Size = New System.Drawing.Size(125, 20)
        Me.txtma_vt.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 42
        Me.Label2.Tag = "004"
        Me.Label2.Text = "Mã gas"
        '
        'ten_ts
        '
        Me.ten_ts.AutoSize = True
        Me.ten_ts.Location = New System.Drawing.Point(288, 37)
        Me.ten_ts.Name = "ten_ts"
        Me.ten_ts.Size = New System.Drawing.Size(46, 13)
        Me.ten_ts.TabIndex = 40
        Me.ten_ts.Text = "ten_kho"
        '
        'txtso_the_ts
        '
        Me.txtso_the_ts.Location = New System.Drawing.Point(145, 33)
        Me.txtso_the_ts.Name = "txtso_the_ts"
        Me.txtso_the_ts.Size = New System.Drawing.Size(125, 20)
        Me.txtso_the_ts.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 13)
        Me.Label8.TabIndex = 39
        Me.Label8.Tag = "003"
        Me.Label8.Text = "Số seri vỏ bình"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(9, 11)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(38, 13)
        Me.Label16.TabIndex = 36
        Me.Label16.Tag = "002"
        Me.Label16.Text = "Tháng"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(201, 227)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Tag = "009"
        Me.Label9.Text = "Đơn vị cơ sở"
        Me.Label9.Visible = False
        '
        'cbbma_dvcs
        '
        Me.cbbma_dvcs.FormattingEnabled = True
        Me.cbbma_dvcs.Location = New System.Drawing.Point(337, 223)
        Me.cbbma_dvcs.Name = "cbbma_dvcs"
        Me.cbbma_dvcs.Size = New System.Drawing.Size(282, 21)
        Me.cbbma_dvcs.TabIndex = 10
        Me.cbbma_dvcs.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Tag = "011"
        Me.Label4.Text = "Mẫu báo cáo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Tag = "012"
        Me.Label3.Text = "Tiêu đề"
        '
        'txttitle
        '
        Me.txttitle.Location = New System.Drawing.Point(145, 162)
        Me.txttitle.Name = "txttitle"
        Me.txttitle.Size = New System.Drawing.Size(326, 20)
        Me.txttitle.TabIndex = 12
        '
        'cbbmau
        '
        Me.cbbmau.FormattingEnabled = True
        Me.cbbmau.Location = New System.Drawing.Point(145, 136)
        Me.cbbmau.Name = "cbbmau"
        Me.cbbmau.Size = New System.Drawing.Size(326, 21)
        Me.cbbmau.TabIndex = 11
        '
        'btnok
        '
        Me.btnok.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnok.Location = New System.Drawing.Point(12, 227)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(75, 23)
        Me.btnok.TabIndex = 1
        Me.btnok.Tag = "900"
        Me.btnok.Text = "Ok"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.CausesValidation = False
        Me.btnCancel.Location = New System.Drawing.Point(93, 227)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Tag = "901"
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'ten_kh_dl
        '
        Me.ten_kh_dl.AutoSize = True
        Me.ten_kh_dl.Location = New System.Drawing.Point(288, 114)
        Me.ten_kh_dl.Name = "ten_kh_dl"
        Me.ten_kh_dl.Size = New System.Drawing.Size(33, 13)
        Me.ten_kh_dl.TabIndex = 51
        Me.ten_kh_dl.Text = "ten dl"
        '
        'txtma_kh_dl
        '
        Me.txtma_kh_dl.Location = New System.Drawing.Point(145, 110)
        Me.txtma_kh_dl.Name = "txtma_kh_dl"
        Me.txtma_kh_dl.Size = New System.Drawing.Size(125, 20)
        Me.txtma_kh_dl.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 114)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 50
        Me.Label7.Tag = ""
        Me.Label7.Text = "Đại lý"
        '
        'frmfilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 254)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.tabdkloc)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbbma_dvcs)
        Me.Name = "frmfilter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "000"
        Me.Text = "Sản lượng bán lẻ theo ngày"
        Me.tabdkloc.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.txtnam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtthang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tabdkloc As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txttitle As System.Windows.Forms.TextBox
    Friend WithEvents cbbmau As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbbma_dvcs As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ten_ts As System.Windows.Forms.Label
    Friend WithEvents txtso_the_ts As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ten_vt As System.Windows.Forms.Label
    Friend WithEvents txtma_vt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnam As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtthang As System.Windows.Forms.NumericUpDown
    Friend WithEvents ten_loai_ts As System.Windows.Forms.Label
    Friend WithEvents txtloai_ts As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ten_kh_dl As System.Windows.Forms.Label
    Friend WithEvents txtma_kh_dl As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
