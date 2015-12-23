<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.statusbar = New System.Windows.Forms.StatusStrip
        Me.lblunit = New System.Windows.Forms.ToolStripStatusLabel
        Me.lbluser = New System.Windows.Forms.ToolStripStatusLabel
        Me.printer = New System.Windows.Forms.ToolStripStatusLabel
        Me.mnu = New System.Windows.Forms.MenuStrip
        Me.ChucNangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ThoatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnIN = New System.Windows.Forms.ToolStripButton
        Me.btnpreview = New System.Windows.Forms.ToolStripButton
        Me.btnrefresh2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btndkloc = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnphan_bo = New System.Windows.Forms.ToolStripButton
        Me.btnluu = New System.Windows.Forms.ToolStripButton
        Me.btnxoa_phan_bo = New System.Windows.Forms.ToolStripButton
        Me.grd = New System.Windows.Forms.DataGridView
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.gridhd = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbbtypepb = New System.Windows.Forms.ComboBox
        Me.btnAutoAllo = New System.Windows.Forms.ToolStripButton
        Me.statusbar.SuspendLayout()
        Me.mnu.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.gridhd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'statusbar
        '
        Me.statusbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblunit, Me.lbluser, Me.printer})
        Me.statusbar.Location = New System.Drawing.Point(0, 498)
        Me.statusbar.Name = "statusbar"
        Me.statusbar.Size = New System.Drawing.Size(1028, 24)
        Me.statusbar.TabIndex = 0
        Me.statusbar.Text = "StatusStrip1"
        '
        'lblunit
        '
        Me.lblunit.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.lblunit.Name = "lblunit"
        Me.lblunit.Size = New System.Drawing.Size(33, 19)
        Me.lblunit.Text = "Unit"
        '
        'lbluser
        '
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(30, 19)
        Me.lbluser.Text = "User"
        '
        'printer
        '
        Me.printer.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.printer.Name = "printer"
        Me.printer.Size = New System.Drawing.Size(46, 19)
        Me.printer.Text = "Printer"
        '
        'mnu
        '
        Me.mnu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChucNangToolStripMenuItem})
        Me.mnu.Location = New System.Drawing.Point(0, 0)
        Me.mnu.Name = "mnu"
        Me.mnu.Size = New System.Drawing.Size(1028, 24)
        Me.mnu.TabIndex = 1
        Me.mnu.Text = "MenuStrip1"
        '
        'ChucNangToolStripMenuItem
        '
        Me.ChucNangToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThoatToolStripMenuItem})
        Me.ChucNangToolStripMenuItem.Name = "ChucNangToolStripMenuItem"
        Me.ChucNangToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.ChucNangToolStripMenuItem.Tag = "200"
        Me.ChucNangToolStripMenuItem.Text = "Chuc nang"
        '
        'ThoatToolStripMenuItem
        '
        Me.ThoatToolStripMenuItem.Name = "ThoatToolStripMenuItem"
        Me.ThoatToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.ThoatToolStripMenuItem.Tag = "999"
        Me.ThoatToolStripMenuItem.Text = "Thoat"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnIN, Me.btnpreview, Me.btnrefresh2, Me.ToolStripSeparator2, Me.btndkloc, Me.ToolStripSeparator1, Me.btnphan_bo, Me.btnluu, Me.btnxoa_phan_bo, Me.btnAutoAllo})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1028, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnIN
        '
        Me.btnIN.Image = CType(resources.GetObject("btnIN.Image"), System.Drawing.Image)
        Me.btnIN.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnIN.Name = "btnIN"
        Me.btnIN.Size = New System.Drawing.Size(37, 22)
        Me.btnIN.Tag = "201"
        Me.btnIN.Text = "In"
        '
        'btnpreview
        '
        Me.btnpreview.Image = CType(resources.GetObject("btnpreview.Image"), System.Drawing.Image)
        Me.btnpreview.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnpreview.Name = "btnpreview"
        Me.btnpreview.Size = New System.Drawing.Size(51, 22)
        Me.btnpreview.Tag = "202"
        Me.btnpreview.Text = "Xem"
        '
        'btnrefresh2
        '
        Me.btnrefresh2.Image = CType(resources.GetObject("btnrefresh2.Image"), System.Drawing.Image)
        Me.btnrefresh2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnrefresh2.Name = "btnrefresh2"
        Me.btnrefresh2.Size = New System.Drawing.Size(71, 22)
        Me.btnrefresh2.Tag = "203"
        Me.btnrefresh2.Text = "lam tuoi"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btndkloc
        '
        Me.btndkloc.Image = CType(resources.GetObject("btndkloc.Image"), System.Drawing.Image)
        Me.btndkloc.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btndkloc.Name = "btndkloc"
        Me.btndkloc.Size = New System.Drawing.Size(59, 22)
        Me.btndkloc.Tag = "001"
        Me.btndkloc.Text = "dk loc"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnphan_bo
        '
        Me.btnphan_bo.Image = CType(resources.GetObject("btnphan_bo.Image"), System.Drawing.Image)
        Me.btnphan_bo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnphan_bo.Name = "btnphan_bo"
        Me.btnphan_bo.Size = New System.Drawing.Size(71, 22)
        Me.btnphan_bo.Tag = "007"
        Me.btnphan_bo.Text = "Phan bo"
        '
        'btnluu
        '
        Me.btnluu.Image = CType(resources.GetObject("btnluu.Image"), System.Drawing.Image)
        Me.btnluu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnluu.Name = "btnluu"
        Me.btnluu.Size = New System.Drawing.Size(109, 22)
        Me.btnluu.Tag = "008"
        Me.btnluu.Text = "Sua kq phan bo"
        '
        'btnxoa_phan_bo
        '
        Me.btnxoa_phan_bo.Image = CType(resources.GetObject("btnxoa_phan_bo.Image"), System.Drawing.Image)
        Me.btnxoa_phan_bo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnxoa_phan_bo.Name = "btnxoa_phan_bo"
        Me.btnxoa_phan_bo.Size = New System.Drawing.Size(94, 22)
        Me.btnxoa_phan_bo.Tag = "009"
        Me.btnxoa_phan_bo.Text = "Xoa phan bo"
        '
        'grd
        '
        Me.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grd.Location = New System.Drawing.Point(0, 0)
        Me.grd.Name = "grd"
        Me.grd.Size = New System.Drawing.Size(1028, 224)
        Me.grd.TabIndex = 3
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 49)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.grd)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1028, 449)
        Me.SplitContainer1.SplitterDistance = 224
        Me.SplitContainer1.TabIndex = 4
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.gridhd)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer2.Panel2.Controls.Add(Me.cbbtypepb)
        Me.SplitContainer2.Panel2MinSize = 0
        Me.SplitContainer2.Size = New System.Drawing.Size(1028, 221)
        Me.SplitContainer2.SplitterDistance = 216
        Me.SplitContainer2.TabIndex = 0
        '
        'gridhd
        '
        Me.gridhd.AllowUserToAddRows = False
        Me.gridhd.AllowUserToDeleteRows = False
        Me.gridhd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridhd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridhd.Location = New System.Drawing.Point(0, 0)
        Me.gridhd.Name = "gridhd"
        Me.gridhd.Size = New System.Drawing.Size(1028, 216)
        Me.gridhd.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Tag = "010"
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'cbbtypepb
        '
        Me.cbbtypepb.FormattingEnabled = True
        Me.cbbtypepb.Location = New System.Drawing.Point(111, 2)
        Me.cbbtypepb.Name = "cbbtypepb"
        Me.cbbtypepb.Size = New System.Drawing.Size(297, 21)
        Me.cbbtypepb.TabIndex = 0
        Me.cbbtypepb.Visible = False
        '
        'btnAutoAllo
        '
        Me.btnAutoAllo.Image = CType(resources.GetObject("btnAutoAllo.Image"), System.Drawing.Image)
        Me.btnAutoAllo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAutoAllo.Name = "btnAutoAllo"
        Me.btnAutoAllo.Size = New System.Drawing.Size(124, 22)
        Me.btnAutoAllo.Text = "Phân bổ hàng loạt"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 522)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.statusbar)
        Me.Controls.Add(Me.mnu)
        Me.MainMenuStrip = Me.mnu
        Me.Name = "MainForm"
        Me.Tag = "000"
        Me.Text = "Form1"
        Me.statusbar.ResumeLayout(False)
        Me.statusbar.PerformLayout()
        Me.mnu.ResumeLayout(False)
        Me.mnu.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.gridhd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents statusbar As System.Windows.Forms.StatusStrip
    Friend WithEvents mnu As System.Windows.Forms.MenuStrip
    Friend WithEvents ChucNangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThoatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnIN As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnpreview As System.Windows.Forms.ToolStripButton
    Friend WithEvents grd As System.Windows.Forms.DataGridView
    Friend WithEvents btndkloc As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnrefresh2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblunit As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbluser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents printer As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnphan_bo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnluu As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnxoa_phan_bo As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents gridhd As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbbtypepb As System.Windows.Forms.ComboBox
    Friend WithEvents btnAutoAllo As System.Windows.Forms.ToolStripButton

End Class
