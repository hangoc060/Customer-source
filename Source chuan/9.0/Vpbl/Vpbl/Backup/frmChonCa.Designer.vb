<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChonCa
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
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cbbso_ca = New System.Windows.Forms.ComboBox
        Me.cbbso_may = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbbma_kho = New System.Windows.Forms.ComboBox
        Me.lblma_kho = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(0, 99)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Tag = "603"
        Me.Button1.Text = "Bán hàng"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(81, 99)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Tag = "604"
        Me.Button2.Text = "Thoát"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.cbbma_kho)
        Me.GroupBox1.Controls.Add(Me.lblma_kho)
        Me.GroupBox1.Controls.Add(Me.cbbso_ca)
        Me.GroupBox1.Controls.Add(Me.cbbso_may)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(-7, -18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(571, 111)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'cbbso_ca
        '
        Me.cbbso_ca.FormattingEnabled = True
        Me.cbbso_ca.Location = New System.Drawing.Point(100, 81)
        Me.cbbso_ca.Name = "cbbso_ca"
        Me.cbbso_ca.Size = New System.Drawing.Size(422, 21)
        Me.cbbso_ca.TabIndex = 2
        '
        'cbbso_may
        '
        Me.cbbso_may.FormattingEnabled = True
        Me.cbbso_may.Location = New System.Drawing.Point(100, 55)
        Me.cbbso_may.Name = "cbbso_may"
        Me.cbbso_may.Size = New System.Drawing.Size(422, 21)
        Me.cbbso_may.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Tag = "602"
        Me.Label2.Text = "Số ca"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Tag = "601"
        Me.Label1.Text = "Số quầy"
        '
        'cbbma_kho
        '
        Me.cbbma_kho.FormattingEnabled = True
        Me.cbbma_kho.Location = New System.Drawing.Point(100, 28)
        Me.cbbma_kho.Name = "cbbma_kho"
        Me.cbbma_kho.Size = New System.Drawing.Size(422, 21)
        Me.cbbma_kho.TabIndex = 0
        '
        'lblma_kho
        '
        Me.lblma_kho.AutoSize = True
        Me.lblma_kho.Location = New System.Drawing.Point(19, 32)
        Me.lblma_kho.Name = "lblma_kho"
        Me.lblma_kho.Size = New System.Drawing.Size(26, 13)
        Me.lblma_kho.TabIndex = 3
        Me.lblma_kho.Tag = "KHO"
        Me.lblma_kho.Text = "Kho"
        '
        'frmChonCa
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button2
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(554, 126)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmChonCa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "600"
        Me.Text = "Chọn ca làm việc"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbbso_ca As System.Windows.Forms.ComboBox
    Friend WithEvents cbbso_may As System.Windows.Forms.ComboBox
    Friend WithEvents cbbma_kho As System.Windows.Forms.ComboBox
    Friend WithEvents lblma_kho As System.Windows.Forms.Label

End Class
