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
        Me.mnfile = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.user = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblcty = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnGoogleSync = New System.Windows.Forms.ToolStripButton
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.TreeNV = New System.Windows.Forms.TreeView
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.btnnhan_vien = New System.Windows.Forms.ToolStripButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Calendar1 = New clsCalendar.Calendar
        Me.lblthongtin = New System.Windows.Forms.Label
        Me.grd = New System.Windows.Forms.DataGridView
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.grd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnfile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(816, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnfile
        '
        Me.mnfile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1})
        Me.mnfile.Name = "mnfile"
        Me.mnfile.Size = New System.Drawing.Size(77, 20)
        Me.mnfile.Tag = "100"
        Me.mnfile.Text = "Chuc nang"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(57, 6)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.user, Me.lblcty})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 490)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(816, 24)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'user
        '
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(29, 19)
        Me.user.Text = "user"
        '
        'lblcty
        '
        Me.lblcty.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.lblcty.Name = "lblcty"
        Me.lblcty.Size = New System.Drawing.Size(27, 19)
        Me.lblcty.Text = "cty"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnGoogleSync})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(816, 25)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnGoogleSync
        '
        Me.btnGoogleSync.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnGoogleSync.Image = CType(resources.GetObject("btnGoogleSync.Image"), System.Drawing.Image)
        Me.btnGoogleSync.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGoogleSync.Name = "btnGoogleSync"
        Me.btnGoogleSync.Size = New System.Drawing.Size(123, 22)
        Me.btnGoogleSync.Text = "Đồng bộ Lịch Google"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 49)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblthongtin)
        Me.SplitContainer1.Panel2.Controls.Add(Me.grd)
        Me.SplitContainer1.Size = New System.Drawing.Size(816, 441)
        Me.SplitContainer1.SplitterDistance = 315
        Me.SplitContainer1.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.TreeNV)
        Me.Panel2.Controls.Add(Me.ToolStrip2)
        Me.Panel2.Location = New System.Drawing.Point(0, 307)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(326, 134)
        Me.Panel2.TabIndex = 2
        '
        'TreeNV
        '
        Me.TreeNV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeNV.Location = New System.Drawing.Point(0, 25)
        Me.TreeNV.Name = "TreeNV"
        Me.TreeNV.ShowLines = False
        Me.TreeNV.ShowPlusMinus = False
        Me.TreeNV.ShowRootLines = False
        Me.TreeNV.Size = New System.Drawing.Size(326, 109)
        Me.TreeNV.TabIndex = 1
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnnhan_vien})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Margin = New System.Windows.Forms.Padding(1)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(326, 25)
        Me.ToolStrip2.TabIndex = 0
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btnnhan_vien
        '
        Me.btnnhan_vien.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnnhan_vien.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnnhan_vien.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnnhan_vien.Image = CType(resources.GetObject("btnnhan_vien.Image"), System.Drawing.Image)
        Me.btnnhan_vien.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnnhan_vien.Name = "btnnhan_vien"
        Me.btnnhan_vien.Size = New System.Drawing.Size(81, 22)
        Me.btnnhan_vien.Tag = "011"
        Me.btnnhan_vien.Text = "Nhan vien"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Calendar1)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(314, 312)
        Me.Panel1.TabIndex = 0
        '
        'Calendar1
        '
        Me.Calendar1.BackColor4Date = System.Drawing.SystemColors.Control
        Me.Calendar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Calendar1.Language = clsCalendar.Calendar.Languages.Vietnamese
        Me.Calendar1.Location = New System.Drawing.Point(0, 0)
        Me.Calendar1.MaximumSize = New System.Drawing.Size(315, 314)
        Me.Calendar1.MinimumSize = New System.Drawing.Size(315, 314)
        Me.Calendar1.Name = "Calendar1"
        Me.Calendar1.Size = New System.Drawing.Size(315, 314)
        Me.Calendar1.TabIndex = 0
        '
        'lblthongtin
        '
        Me.lblthongtin.AutoSize = True
        Me.lblthongtin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblthongtin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblthongtin.Location = New System.Drawing.Point(6, 11)
        Me.lblthongtin.Name = "lblthongtin"
        Me.lblthongtin.Size = New System.Drawing.Size(0, 17)
        Me.lblthongtin.TabIndex = 7
        '
        'grd
        '
        Me.grd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd.Location = New System.Drawing.Point(2, 35)
        Me.grd.Name = "grd"
        Me.grd.Size = New System.Drawing.Size(492, 403)
        Me.grd.TabIndex = 6
        '
        'Frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 514)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Frmmain"
        Me.Tag = "000"
        Me.Text = "Ke hoach lam viec"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.grd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnfile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents user As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblcty As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents grd As System.Windows.Forms.DataGridView
    Friend WithEvents lblthongtin As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TreeNV As System.Windows.Forms.TreeView
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnnhan_vien As System.Windows.Forms.ToolStripButton
    Friend WithEvents Calendar1 As clsCalendar.Calendar
    Friend WithEvents btnGoogleSync As System.Windows.Forms.ToolStripButton

End Class
