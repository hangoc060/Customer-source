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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtnam = New System.Windows.Forms.NumericUpDown
        Me.txtky = New System.Windows.Forms.NumericUpDown
        Me.btnOK = New System.Windows.Forms.Button
        Me.btncancel = New System.Windows.Forms.Button
        Me.chbcopy = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtnam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtky, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.chbcopy)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtnam)
        Me.GroupBox1.Controls.Add(Me.txtky)
        Me.GroupBox1.Location = New System.Drawing.Point(-11, -12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(383, 107)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Tag = "022"
        Me.Label2.Text = "Nam"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Tag = "021"
        Me.Label1.Text = "Ky"
        '
        'txtnam
        '
        Me.txtnam.Location = New System.Drawing.Point(144, 50)
        Me.txtnam.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txtnam.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
        Me.txtnam.Name = "txtnam"
        Me.txtnam.Size = New System.Drawing.Size(120, 20)
        Me.txtnam.TabIndex = 1
        Me.txtnam.Value = New Decimal(New Integer() {1900, 0, 0, 0})
        '
        'txtky
        '
        Me.txtky.Location = New System.Drawing.Point(144, 24)
        Me.txtky.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.txtky.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtky.Name = "txtky"
        Me.txtky.Size = New System.Drawing.Size(65, 20)
        Me.txtky.TabIndex = 0
        Me.txtky.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Location = New System.Drawing.Point(6, 100)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Tag = "023"
        Me.btnOK.Text = "Ok"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btncancel.Location = New System.Drawing.Point(87, 100)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 2
        Me.btncancel.Tag = "024"
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'chbcopy
        '
        Me.chbcopy.AutoSize = True
        Me.chbcopy.Location = New System.Drawing.Point(144, 76)
        Me.chbcopy.Name = "chbcopy"
        Me.chbcopy.Size = New System.Drawing.Size(123, 17)
        Me.chbcopy.TabIndex = 2
        Me.chbcopy.TabStop = False
        Me.chbcopy.Tag = "009"
        Me.chbcopy.Text = "sao chep tu ky truoc"
        Me.chbcopy.UseVisualStyleBackColor = True
        '
        'frmfilter
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btncancel
        Me.ClientSize = New System.Drawing.Size(359, 126)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmfilter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "020"
        Me.Text = "frmfilter"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtnam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtky, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnam As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtky As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents chbcopy As System.Windows.Forms.CheckBox
End Class
