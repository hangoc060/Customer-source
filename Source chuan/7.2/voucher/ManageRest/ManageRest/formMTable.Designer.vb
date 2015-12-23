<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMTable
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formMTable))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtt_hoa_don = New ClsControl2.TxtNumeric
        Me.btbplus = New System.Windows.Forms.Button
        Me.btnsubtract = New System.Windows.Forms.Button
        Me.txtso_luong = New System.Windows.Forms.NumericUpDown
        Me.gridInvoice = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtty_le_ck_hd = New ClsControl2.TxtNumeric
        Me.btndoi_ban = New System.Windows.Forms.Button
        Me.btntra_ban = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtt_tien_ck_hd = New ClsControl2.TxtNumeric
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbltong_tien = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnexit = New System.Windows.Forms.Button
        Me.btnthanh_toan = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.txtso_luong, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(5, 6)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Size = New System.Drawing.Size(996, 384)
        Me.SplitContainer1.SplitterDistance = 436
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.gridInvoice)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(436, 384)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Hóa đơn"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtt_hoa_don)
        Me.Panel1.Controls.Add(Me.btbplus)
        Me.Panel1.Controls.Add(Me.btnsubtract)
        Me.Panel1.Controls.Add(Me.txtso_luong)
        Me.Panel1.Location = New System.Drawing.Point(6, 337)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(424, 44)
        Me.Panel1.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(270, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Cộng"
        '
        'txtt_hoa_don
        '
        Me.txtt_hoa_don.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtt_hoa_don.Location = New System.Drawing.Point(319, 13)
        Me.txtt_hoa_don.MaxLength = 18
        Me.txtt_hoa_don.Name = "txtt_hoa_don"
        Me.txtt_hoa_don.NumberDecimalDigits = 0
        Me.txtt_hoa_don.ReadOnly = True
        Me.txtt_hoa_don.Size = New System.Drawing.Size(100, 20)
        Me.txtt_hoa_don.TabIndex = 11
        Me.txtt_hoa_don.TabStop = False
        Me.txtt_hoa_don.Text = "0"
        Me.txtt_hoa_don.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtt_hoa_don.Value = 0
        Me.txtt_hoa_don.Value2 = 0
        '
        'btbplus
        '
        Me.btbplus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btbplus.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btbplus.ForeColor = System.Drawing.Color.Blue
        Me.btbplus.Location = New System.Drawing.Point(73, 6)
        Me.btbplus.Name = "btbplus"
        Me.btbplus.Size = New System.Drawing.Size(36, 32)
        Me.btbplus.TabIndex = 2
        Me.btbplus.Text = "+"
        Me.btbplus.UseVisualStyleBackColor = True
        '
        'btnsubtract
        '
        Me.btnsubtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsubtract.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsubtract.ForeColor = System.Drawing.Color.Red
        Me.btnsubtract.Location = New System.Drawing.Point(3, 6)
        Me.btnsubtract.Name = "btnsubtract"
        Me.btnsubtract.Size = New System.Drawing.Size(35, 32)
        Me.btnsubtract.TabIndex = 1
        Me.btnsubtract.Text = "-"
        Me.btnsubtract.UseVisualStyleBackColor = True
        '
        'txtso_luong
        '
        Me.txtso_luong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtso_luong.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtso_luong.Location = New System.Drawing.Point(37, 6)
        Me.txtso_luong.Name = "txtso_luong"
        Me.txtso_luong.Size = New System.Drawing.Size(56, 32)
        Me.txtso_luong.TabIndex = 0
        Me.txtso_luong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gridInvoice
        '
        Me.gridInvoice.AllowUserToAddRows = False
        Me.gridInvoice.AllowUserToResizeColumns = False
        Me.gridInvoice.AllowUserToResizeRows = False
        Me.gridInvoice.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridInvoice.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.gridInvoice.BackgroundColor = System.Drawing.Color.White
        Me.gridInvoice.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridInvoice.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.gridInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridInvoice.DefaultCellStyle = DataGridViewCellStyle6
        Me.gridInvoice.Location = New System.Drawing.Point(3, 16)
        Me.gridInvoice.Name = "gridInvoice"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridInvoice.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.gridInvoice.RowHeadersVisible = False
        Me.gridInvoice.RowHeadersWidth = 20
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridInvoice.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.gridInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridInvoice.Size = New System.Drawing.Size(430, 315)
        Me.gridInvoice.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TabControl1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(556, 384)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Menu"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.ItemSize = New System.Drawing.Size(0, 24)
        Me.TabControl1.Location = New System.Drawing.Point(3, 16)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(550, 365)
        Me.TabControl1.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.txtty_le_ck_hd)
        Me.GroupBox3.Controls.Add(Me.btndoi_ban)
        Me.GroupBox3.Controls.Add(Me.btntra_ban)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txtt_tien_ck_hd)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.lbltong_tien)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.btnexit)
        Me.GroupBox3.Controls.Add(Me.btnthanh_toan)
        Me.GroupBox3.Location = New System.Drawing.Point(5, 393)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(996, 58)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'txtty_le_ck_hd
        '
        Me.txtty_le_ck_hd.Location = New System.Drawing.Point(34, 21)
        Me.txtty_le_ck_hd.MaxLength = 18
        Me.txtty_le_ck_hd.Name = "txtty_le_ck_hd"
        Me.txtty_le_ck_hd.NumberDecimalDigits = 0
        Me.txtty_le_ck_hd.Size = New System.Drawing.Size(55, 20)
        Me.txtty_le_ck_hd.TabIndex = 7
        Me.txtty_le_ck_hd.TabStop = False
        Me.txtty_le_ck_hd.Text = "0"
        Me.txtty_le_ck_hd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtty_le_ck_hd.Value = 0
        Me.txtty_le_ck_hd.Value2 = 0
        '
        'btndoi_ban
        '
        Me.btndoi_ban.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btndoi_ban.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btndoi_ban.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btndoi_ban.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndoi_ban.ForeColor = System.Drawing.Color.White
        Me.btndoi_ban.Location = New System.Drawing.Point(758, 15)
        Me.btndoi_ban.Name = "btndoi_ban"
        Me.btndoi_ban.Size = New System.Drawing.Size(75, 33)
        Me.btndoi_ban.TabIndex = 12
        Me.btndoi_ban.TabStop = False
        Me.btndoi_ban.Text = "Đổi bàn"
        Me.btndoi_ban.UseVisualStyleBackColor = False
        '
        'btntra_ban
        '
        Me.btntra_ban.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btntra_ban.BackColor = System.Drawing.Color.LightSlateGray
        Me.btntra_ban.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btntra_ban.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntra_ban.ForeColor = System.Drawing.Color.White
        Me.btntra_ban.Location = New System.Drawing.Point(837, 15)
        Me.btntra_ban.Name = "btntra_ban"
        Me.btntra_ban.Size = New System.Drawing.Size(75, 33)
        Me.btntra_ban.TabIndex = 11
        Me.btntra_ban.TabStop = False
        Me.btntra_ban.Text = "Trả bàn"
        Me.btntra_ban.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(116, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Tiền CK"
        '
        'txtt_tien_ck_hd
        '
        Me.txtt_tien_ck_hd.Location = New System.Drawing.Point(177, 21)
        Me.txtt_tien_ck_hd.MaxLength = 18
        Me.txtt_tien_ck_hd.Name = "txtt_tien_ck_hd"
        Me.txtt_tien_ck_hd.NumberDecimalDigits = 0
        Me.txtt_tien_ck_hd.Size = New System.Drawing.Size(100, 20)
        Me.txtt_tien_ck_hd.TabIndex = 9
        Me.txtt_tien_ck_hd.TabStop = False
        Me.txtt_tien_ck_hd.Text = "0"
        Me.txtt_tien_ck_hd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtt_tien_ck_hd.Value = 0
        Me.txtt_tien_ck_hd.Value2 = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(95, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "%"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "CK"
        '
        'lbltong_tien
        '
        Me.lbltong_tien.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbltong_tien.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltong_tien.ForeColor = System.Drawing.Color.Red
        Me.lbltong_tien.Location = New System.Drawing.Point(449, 13)
        Me.lbltong_tien.Name = "lbltong_tien"
        Me.lbltong_tien.Size = New System.Drawing.Size(209, 36)
        Me.lbltong_tien.TabIndex = 5
        Me.lbltong_tien.Text = "000000"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(321, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 36)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Tổng PT:"
        '
        'btnexit
        '
        Me.btnexit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnexit.BackColor = System.Drawing.Color.Red
        Me.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.ForeColor = System.Drawing.Color.White
        Me.btnexit.Location = New System.Drawing.Point(915, 15)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 33)
        Me.btnexit.TabIndex = 1
        Me.btnexit.Text = "Đóng"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'btnthanh_toan
        '
        Me.btnthanh_toan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnthanh_toan.BackColor = System.Drawing.Color.Blue
        Me.btnthanh_toan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnthanh_toan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnthanh_toan.ForeColor = System.Drawing.Color.White
        Me.btnthanh_toan.Location = New System.Drawing.Point(677, 15)
        Me.btnthanh_toan.Name = "btnthanh_toan"
        Me.btnthanh_toan.Size = New System.Drawing.Size(75, 33)
        Me.btnthanh_toan.TabIndex = 0
        Me.btnthanh_toan.Text = "Tính tiền"
        Me.btnthanh_toan.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "delete.bmp")
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(542, 333)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'formMTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 459)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "formMTable"
        Me.Text = "Quản lý bàn"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txtso_luong, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents gridInvoice As System.Windows.Forms.DataGridView
    Friend WithEvents btnthanh_toan As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtso_luong As System.Windows.Forms.NumericUpDown
    Friend WithEvents btbplus As System.Windows.Forms.Button
    Friend WithEvents btnsubtract As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbltong_tien As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtt_tien_ck_hd As ClsControl2.TxtNumeric
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtt_hoa_don As ClsControl2.TxtNumeric
    Friend WithEvents btntra_ban As System.Windows.Forms.Button
    Friend WithEvents btndoi_ban As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents txtty_le_ck_hd As ClsControl2.TxtNumeric
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
End Class
