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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ChucNangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuMoi = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuSua = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuXoa = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuthoat = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.user = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.grd = New System.Windows.Forms.DataGridView
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.grd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChucNangToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(816, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ChucNangToolStripMenuItem
        '
        Me.ChucNangToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMoi, Me.mnuSua, Me.mnuXoa, Me.ToolStripSeparator1, Me.mnuthoat})
        Me.ChucNangToolStripMenuItem.Name = "ChucNangToolStripMenuItem"
        Me.ChucNangToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.ChucNangToolStripMenuItem.Tag = "100"
        Me.ChucNangToolStripMenuItem.Text = "Chuc nang"
        '
        'mnuMoi
        '
        Me.mnuMoi.Name = "mnuMoi"
        Me.mnuMoi.Size = New System.Drawing.Size(103, 22)
        Me.mnuMoi.Tag = "096"
        Me.mnuMoi.Text = "Moi"
        '
        'mnuSua
        '
        Me.mnuSua.Name = "mnuSua"
        Me.mnuSua.Size = New System.Drawing.Size(103, 22)
        Me.mnuSua.Tag = "097"
        Me.mnuSua.Text = "Sua"
        '
        'mnuXoa
        '
        Me.mnuXoa.Name = "mnuXoa"
        Me.mnuXoa.Size = New System.Drawing.Size(103, 22)
        Me.mnuXoa.Tag = "098"
        Me.mnuXoa.Text = "Xoa"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(100, 6)
        '
        'mnuthoat
        '
        Me.mnuthoat.Name = "mnuthoat"
        Me.mnuthoat.Size = New System.Drawing.Size(103, 22)
        Me.mnuthoat.Tag = "099"
        Me.mnuthoat.Text = "Close"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.user})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 352)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(816, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'user
        '
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(29, 17)
        Me.user.Text = "user"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(816, 25)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'grd
        '
        Me.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grd.Location = New System.Drawing.Point(0, 49)
        Me.grd.Name = "grd"
        Me.grd.Size = New System.Drawing.Size(816, 303)
        Me.grd.TabIndex = 5
        '
        'Frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 374)
        Me.Controls.Add(Me.grd)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Frmmain"
        Me.Tag = "004"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.grd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ChucNangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents grd As System.Windows.Forms.DataGridView
    Friend WithEvents mnuMoi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSua As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuXoa As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuthoat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents user As System.Windows.Forms.ToolStripStatusLabel

End Class
