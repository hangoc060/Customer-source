<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formChooseRes
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
        Me.listRes = New System.Windows.Forms.ListView
        Me.col1 = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'listRes
        '
        Me.listRes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col1})
        Me.listRes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listRes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listRes.ForeColor = System.Drawing.Color.Green
        Me.listRes.GridLines = True
        Me.listRes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.listRes.Location = New System.Drawing.Point(0, 0)
        Me.listRes.MultiSelect = False
        Me.listRes.Name = "listRes"
        Me.listRes.Size = New System.Drawing.Size(305, 315)
        Me.listRes.TabIndex = 0
        Me.listRes.UseCompatibleStateImageBehavior = False
        Me.listRes.View = System.Windows.Forms.View.Details
        '
        'col1
        '
        Me.col1.Width = 297
        '
        'formChooseRes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 315)
        Me.Controls.Add(Me.listRes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formChooseRes"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chọn nhà hàng"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents listRes As System.Windows.Forms.ListView
    Friend WithEvents col1 As System.Windows.Forms.ColumnHeader

End Class
