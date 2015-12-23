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
        Me.tabdkloc = New System.Windows.Forms.TabControl
        Me.btnSuaMau = New System.Windows.Forms.TabPage
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.cbbma_dvcs = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txttitle = New System.Windows.Forms.TextBox
        Me.cbbmau = New System.Windows.Forms.ComboBox
        Me.btnok = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.txttu_ky = New System.Windows.Forms.NumericUpDown
        Me.txtden_ky = New System.Windows.Forms.NumericUpDown
        Me.txtnam = New System.Windows.Forms.NumericUpDown
        Me.tabdkloc.SuspendLayout()
        Me.btnSuaMau.SuspendLayout()
        CType(Me.txttu_ky, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtden_ky, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtnam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabdkloc
        '
        Me.tabdkloc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabdkloc.Controls.Add(Me.btnSuaMau)
        Me.tabdkloc.Location = New System.Drawing.Point(-6, -1)
        Me.tabdkloc.Name = "tabdkloc"
        Me.tabdkloc.SelectedIndex = 0
        Me.tabdkloc.Size = New System.Drawing.Size(494, 139)
        Me.tabdkloc.TabIndex = 0
        '
        'btnSuaMau
        '
        Me.btnSuaMau.Controls.Add(Me.txtnam)
        Me.btnSuaMau.Controls.Add(Me.txtden_ky)
        Me.btnSuaMau.Controls.Add(Me.txttu_ky)
        Me.btnSuaMau.Controls.Add(Me.Label16)
        Me.btnSuaMau.Controls.Add(Me.Label9)
        Me.btnSuaMau.Controls.Add(Me.cbbma_dvcs)
        Me.btnSuaMau.Controls.Add(Me.Label4)
        Me.btnSuaMau.Controls.Add(Me.Label3)
        Me.btnSuaMau.Controls.Add(Me.txttitle)
        Me.btnSuaMau.Controls.Add(Me.cbbmau)
        Me.btnSuaMau.Location = New System.Drawing.Point(4, 22)
        Me.btnSuaMau.Name = "btnSuaMau"
        Me.btnSuaMau.Padding = New System.Windows.Forms.Padding(3)
        Me.btnSuaMau.Size = New System.Drawing.Size(486, 113)
        Me.btnSuaMau.TabIndex = 0
        Me.btnSuaMau.Tag = "001"
        Me.btnSuaMau.Text = "Dieu kien loc"
        Me.btnSuaMau.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(9, 12)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(42, 13)
        Me.Label16.TabIndex = 36
        Me.Label16.Tag = "002"
        Me.Label16.Text = "tu ngay"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Tag = "009"
        Me.Label9.Text = "don vi"
        '
        'cbbma_dvcs
        '
        Me.cbbma_dvcs.FormattingEnabled = True
        Me.cbbma_dvcs.Location = New System.Drawing.Point(145, 32)
        Me.cbbma_dvcs.Name = "cbbma_dvcs"
        Me.cbbma_dvcs.Size = New System.Drawing.Size(326, 21)
        Me.cbbma_dvcs.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Tag = "011"
        Me.Label4.Text = "Mau bao cao"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Tag = "012"
        Me.Label3.Text = "Tieu de"
        '
        'txttitle
        '
        Me.txttitle.Location = New System.Drawing.Point(145, 83)
        Me.txttitle.Name = "txttitle"
        Me.txttitle.Size = New System.Drawing.Size(326, 20)
        Me.txttitle.TabIndex = 5
        '
        'cbbmau
        '
        Me.cbbmau.FormattingEnabled = True
        Me.cbbmau.Location = New System.Drawing.Point(145, 57)
        Me.cbbmau.Name = "cbbmau"
        Me.cbbmau.Size = New System.Drawing.Size(326, 21)
        Me.cbbmau.TabIndex = 4
        '
        'btnok
        '
        Me.btnok.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnok.Location = New System.Drawing.Point(12, 144)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(75, 23)
        Me.btnok.TabIndex = 1
        Me.btnok.Tag = "900"
        Me.btnok.Text = "Ok"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.CausesValidation = False
        Me.btnCancel.Location = New System.Drawing.Point(93, 144)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Tag = "901"
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(367, 144)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 23)
        Me.Button1.TabIndex = 50
        Me.Button1.Tag = "020"
        Me.Button1.Text = "Sua mau"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txttu_ky
        '
        Me.txttu_ky.Location = New System.Drawing.Point(145, 8)
        Me.txttu_ky.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.txttu_ky.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txttu_ky.Name = "txttu_ky"
        Me.txttu_ky.Size = New System.Drawing.Size(64, 20)
        Me.txttu_ky.TabIndex = 0
        Me.txttu_ky.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txttu_ky.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtden_ky
        '
        Me.txtden_ky.Location = New System.Drawing.Point(215, 8)
        Me.txtden_ky.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.txtden_ky.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtden_ky.Name = "txtden_ky"
        Me.txtden_ky.Size = New System.Drawing.Size(64, 20)
        Me.txtden_ky.TabIndex = 1
        Me.txtden_ky.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtden_ky.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtnam
        '
        Me.txtnam.Location = New System.Drawing.Point(285, 8)
        Me.txtnam.Maximum = New Decimal(New Integer() {2999, 0, 0, 0})
        Me.txtnam.Minimum = New Decimal(New Integer() {1901, 0, 0, 0})
        Me.txtnam.Name = "txtnam"
        Me.txtnam.Size = New System.Drawing.Size(70, 20)
        Me.txtnam.TabIndex = 2
        Me.txtnam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtnam.Value = New Decimal(New Integer() {1901, 0, 0, 0})
        '
        'frmfilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 171)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.tabdkloc)
        Me.Name = "frmfilter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "000"
        Me.Text = "frmfilter"
        Me.tabdkloc.ResumeLayout(False)
        Me.btnSuaMau.ResumeLayout(False)
        Me.btnSuaMau.PerformLayout()
        CType(Me.txttu_ky, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtden_ky, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtnam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabdkloc As System.Windows.Forms.TabControl
    Friend WithEvents btnSuaMau As System.Windows.Forms.TabPage
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txttitle As System.Windows.Forms.TextBox
    Friend WithEvents cbbmau As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbbma_dvcs As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtnam As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtden_ky As System.Windows.Forms.NumericUpDown
    Friend WithEvents txttu_ky As System.Windows.Forms.NumericUpDown
End Class
