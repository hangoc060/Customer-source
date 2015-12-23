<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.txtuser = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.PanelArea = New System.Windows.Forms.FlowLayoutPanel
        Me.PanelTable = New System.Windows.Forms.Panel
        Me.PanelTableType = New System.Windows.Forms.FlowLayoutPanel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.linknew = New System.Windows.Forms.LinkLabel
        Me.linkdelete = New System.Windows.Forms.LinkLabel
        Me.linkedit = New System.Windows.Forms.LinkLabel
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtuser, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 432)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(892, 22)
        Me.StatusStrip1.TabIndex = 14
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'txtuser
        '
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(30, 17)
        Me.txtuser.Text = "User"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(847, 17)
        Me.ToolStripStatusLabel1.Spring = True
        '
        'PanelArea
        '
        Me.PanelArea.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelArea.BackColor = System.Drawing.Color.White
        Me.PanelArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelArea.Location = New System.Drawing.Point(-1, -1)
        Me.PanelArea.Name = "PanelArea"
        Me.PanelArea.Size = New System.Drawing.Size(230, 379)
        Me.PanelArea.TabIndex = 0
        '
        'PanelTable
        '
        Me.PanelTable.AllowDrop = True
        Me.PanelTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelTable.AutoScroll = True
        Me.PanelTable.BackColor = System.Drawing.Color.White
        Me.PanelTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelTable.Location = New System.Drawing.Point(244, 63)
        Me.PanelTable.Name = "PanelTable"
        Me.PanelTable.Size = New System.Drawing.Size(642, 362)
        Me.PanelTable.TabIndex = 0
        '
        'PanelTableType
        '
        Me.PanelTableType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelTableType.BackColor = System.Drawing.Color.White
        Me.PanelTableType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelTableType.Location = New System.Drawing.Point(244, 7)
        Me.PanelTableType.Name = "PanelTableType"
        Me.PanelTableType.Size = New System.Drawing.Size(642, 50)
        Me.PanelTableType.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.linkedit)
        Me.Panel1.Controls.Add(Me.linkdelete)
        Me.Panel1.Controls.Add(Me.linknew)
        Me.Panel1.Controls.Add(Me.PanelArea)
        Me.Panel1.Location = New System.Drawing.Point(8, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(230, 418)
        Me.Panel1.TabIndex = 15
        '
        'linknew
        '
        Me.linknew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.linknew.AutoSize = True
        Me.linknew.Location = New System.Drawing.Point(3, 391)
        Me.linknew.Name = "linknew"
        Me.linknew.Size = New System.Drawing.Size(53, 13)
        Me.linknew.TabIndex = 1
        Me.linknew.TabStop = True
        Me.linknew.Text = "Thêm mới"
        '
        'linkdelete
        '
        Me.linkdelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.linkdelete.AutoSize = True
        Me.linkdelete.Location = New System.Drawing.Point(106, 391)
        Me.linkdelete.Name = "linkdelete"
        Me.linkdelete.Size = New System.Drawing.Size(26, 13)
        Me.linkdelete.TabIndex = 2
        Me.linkdelete.TabStop = True
        Me.linkdelete.Text = "Xóa"
        '
        'linkedit
        '
        Me.linkedit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.linkedit.AutoSize = True
        Me.linkedit.Location = New System.Drawing.Point(67, 391)
        Me.linkedit.Name = "linkedit"
        Me.linkedit.Size = New System.Drawing.Size(26, 13)
        Me.linkedit.TabIndex = 3
        Me.linkedit.TabStop = True
        Me.linkedit.Text = "Sửa"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 454)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelTable)
        Me.Controls.Add(Me.PanelTableType)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "000"
        Me.Text = "Thiết kế nhà hàng"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents txtuser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PanelArea As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents PanelTable As System.Windows.Forms.Panel
    Friend WithEvents PanelTableType As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents linkdelete As System.Windows.Forms.LinkLabel
    Friend WithEvents linknew As System.Windows.Forms.LinkLabel
    Friend WithEvents linkedit As System.Windows.Forms.LinkLabel

End Class
