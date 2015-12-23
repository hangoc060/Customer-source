<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSendSMS
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.listGroup = New System.Windows.Forms.ListView
        Me.cbbloai_nhom = New System.Windows.Forms.ComboBox
        Me.gridkh = New System.Windows.Forms.DataGridView
        Me.PanelMessage = New System.Windows.Forms.Panel
        Me.btngettemplate = New System.Windows.Forms.Button
        Me.btnSend = New System.Windows.Forms.Button
        Me.txtMessage = New System.Windows.Forms.RichTextBox
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.gridkh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMessage.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.PanelMessage)
        Me.SplitContainer1.Size = New System.Drawing.Size(914, 287)
        Me.SplitContainer1.SplitterDistance = 107
        Me.SplitContainer1.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.listGroup)
        Me.SplitContainer2.Panel1.Controls.Add(Me.cbbloai_nhom)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.gridkh)
        Me.SplitContainer2.Size = New System.Drawing.Size(914, 107)
        Me.SplitContainer2.SplitterDistance = 238
        Me.SplitContainer2.TabIndex = 1
        '
        'listGroup
        '
        Me.listGroup.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listGroup.FullRowSelect = True
        Me.listGroup.HideSelection = False
        Me.listGroup.HoverSelection = True
        Me.listGroup.Location = New System.Drawing.Point(3, 27)
        Me.listGroup.Name = "listGroup"
        Me.listGroup.Size = New System.Drawing.Size(232, 80)
        Me.listGroup.TabIndex = 1
        Me.listGroup.UseCompatibleStateImageBehavior = False
        Me.listGroup.View = System.Windows.Forms.View.List
        '
        'cbbloai_nhom
        '
        Me.cbbloai_nhom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbbloai_nhom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbloai_nhom.FormattingEnabled = True
        Me.cbbloai_nhom.Items.AddRange(New Object() {"Nhóm khách hàng 1", "Nhóm khách hàng 2", "Nhóm khách hàng 3"})
        Me.cbbloai_nhom.Location = New System.Drawing.Point(3, 3)
        Me.cbbloai_nhom.Name = "cbbloai_nhom"
        Me.cbbloai_nhom.Size = New System.Drawing.Size(232, 21)
        Me.cbbloai_nhom.TabIndex = 0
        '
        'gridkh
        '
        Me.gridkh.AllowUserToAddRows = False
        Me.gridkh.AllowUserToDeleteRows = False
        Me.gridkh.BackgroundColor = System.Drawing.Color.White
        Me.gridkh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridkh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridkh.Location = New System.Drawing.Point(0, 0)
        Me.gridkh.Name = "gridkh"
        Me.gridkh.Size = New System.Drawing.Size(672, 107)
        Me.gridkh.TabIndex = 0
        '
        'PanelMessage
        '
        Me.PanelMessage.Controls.Add(Me.btngettemplate)
        Me.PanelMessage.Controls.Add(Me.btnSend)
        Me.PanelMessage.Controls.Add(Me.txtMessage)
        Me.PanelMessage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMessage.Location = New System.Drawing.Point(0, 0)
        Me.PanelMessage.Name = "PanelMessage"
        Me.PanelMessage.Size = New System.Drawing.Size(914, 176)
        Me.PanelMessage.TabIndex = 6
        '
        'btngettemplate
        '
        Me.btngettemplate.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btngettemplate.Location = New System.Drawing.Point(753, 146)
        Me.btngettemplate.Name = "btngettemplate"
        Me.btngettemplate.Size = New System.Drawing.Size(149, 23)
        Me.btngettemplate.TabIndex = 2
        Me.btngettemplate.Text = "Chọn tệp mẫu"
        Me.btngettemplate.UseVisualStyleBackColor = True
        '
        'btnSend
        '
        Me.btnSend.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSend.Location = New System.Drawing.Point(4, 146)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 1
        Me.btnSend.Text = "Gửi"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'txtMessage
        '
        Me.txtMessage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMessage.Location = New System.Drawing.Point(3, 0)
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(908, 139)
        Me.txtMessage.TabIndex = 0
        Me.txtMessage.Text = ""
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "text|*.txt"
        '
        'BackgroundWorker1
        '
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 288)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(914, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        Me.ToolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'frmSendSMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 310)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmSendSMS"
        Me.Text = "frmSendSMS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.gridkh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMessage.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents listGroup As System.Windows.Forms.ListView
    Friend WithEvents cbbloai_nhom As System.Windows.Forms.ComboBox
    Friend WithEvents gridkh As System.Windows.Forms.DataGridView
    Friend WithEvents PanelMessage As System.Windows.Forms.Panel
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents txtMessage As System.Windows.Forms.RichTextBox
    Friend WithEvents btngettemplate As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
End Class
