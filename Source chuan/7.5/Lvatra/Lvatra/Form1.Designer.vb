<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmmain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmmain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ChucNangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuMoi = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuSua = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuXoa = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuthoat = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.lbluser = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnNew = New System.Windows.Forms.ToolStripButton
        Me.btnEdit = New System.Windows.Forms.ToolStripButton
        Me.btnDel = New System.Windows.Forms.ToolStripButton
        Me.btnfind = New System.Windows.Forms.ToolStripButton
        Me.grd = New System.Windows.Forms.DataGridView
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.lblma_dvcs = New System.Windows.Forms.ToolStripStatusLabel
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChucNangToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1005, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ChucNangToolStripMenuItem
        '
        Me.ChucNangToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMoi, Me.mnuSua, Me.mnuXoa, Me.ToolStripSeparator1, Me.mnuthoat})
        Me.ChucNangToolStripMenuItem.Name = "ChucNangToolStripMenuItem"
        Me.ChucNangToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ChucNangToolStripMenuItem.Tag = "100"
        Me.ChucNangToolStripMenuItem.Text = "Chuc nang"
        '
        'mnuMoi
        '
        Me.mnuMoi.Name = "mnuMoi"
        Me.mnuMoi.Size = New System.Drawing.Size(111, 22)
        Me.mnuMoi.Tag = "096"
        Me.mnuMoi.Text = "Moi"
        '
        'mnuSua
        '
        Me.mnuSua.Name = "mnuSua"
        Me.mnuSua.Size = New System.Drawing.Size(111, 22)
        Me.mnuSua.Tag = "097"
        Me.mnuSua.Text = "Sua"
        '
        'mnuXoa
        '
        Me.mnuXoa.Name = "mnuXoa"
        Me.mnuXoa.Size = New System.Drawing.Size(111, 22)
        Me.mnuXoa.Tag = "098"
        Me.mnuXoa.Text = "Xoa"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(108, 6)
        '
        'mnuthoat
        '
        Me.mnuthoat.Name = "mnuthoat"
        Me.mnuthoat.Size = New System.Drawing.Size(111, 22)
        Me.mnuthoat.Tag = "099"
        Me.mnuthoat.Text = "Close"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblma_dvcs, Me.lbluser})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 510)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1005, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lbluser
        '
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(28, 17)
        Me.lbluser.Text = "user"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNew, Me.btnEdit, Me.btnDel, Me.btnfind})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1005, 25)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnNew
        '
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(43, 22)
        Me.btnNew.Tag = "096"
        Me.btnNew.Text = "&Moi"
        '
        'btnEdit
        '
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(45, 22)
        Me.btnEdit.Tag = "097"
        Me.btnEdit.Text = "&Sua"
        '
        'btnDel
        '
        Me.btnDel.Image = CType(resources.GetObject("btnDel.Image"), System.Drawing.Image)
        Me.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(45, 22)
        Me.btnDel.Tag = "098"
        Me.btnDel.Text = "&Xoa"
        '
        'btnfind
        '
        Me.btnfind.Image = CType(resources.GetObject("btnfind.Image"), System.Drawing.Image)
        Me.btnfind.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnfind.Name = "btnfind"
        Me.btnfind.Size = New System.Drawing.Size(43, 22)
        Me.btnfind.Tag = "407"
        Me.btnfind.Text = "Tim"
        '
        'grd
        '
        Me.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grd.Location = New System.Drawing.Point(0, 49)
        Me.grd.Name = "grd"
        Me.grd.Size = New System.Drawing.Size(1005, 461)
        Me.grd.TabIndex = 5
        '
        'BackgroundWorker1
        '
        '
        'lblma_dvcs
        '
        Me.lblma_dvcs.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.lblma_dvcs.Name = "lblma_dvcs"
        Me.lblma_dvcs.Size = New System.Drawing.Size(40, 17)
        Me.lblma_dvcs.Text = "don vi"
        '
        'Frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 532)
        Me.Controls.Add(Me.grd)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Frmmain"
        Me.Tag = "000"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ChucNangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDel As System.Windows.Forms.ToolStripButton
    Friend WithEvents grd As System.Windows.Forms.DataGridView
    Friend WithEvents mnuMoi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSua As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuXoa As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuthoat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnfind As System.Windows.Forms.ToolStripButton
    Friend WithEvents lbluser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblma_dvcs As System.Windows.Forms.ToolStripStatusLabel

End Class
