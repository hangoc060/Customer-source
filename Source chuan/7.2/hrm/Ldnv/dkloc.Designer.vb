<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dkloc
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
        Me.btnOK = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ten_loai_nv = New System.Windows.Forms.Label
        Me.ten_bp = New System.Windows.Forms.Label
        Me.txtma_loai_nv = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtma_bp = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtten_nv = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.chbdang_lam_viec = New System.Windows.Forms.CheckBox
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Location = New System.Drawing.Point(12, 175)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "Ok"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(93, 175)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chbdang_lam_viec)
        Me.GroupBox2.Controls.Add(Me.ten_loai_nv)
        Me.GroupBox2.Controls.Add(Me.ten_bp)
        Me.GroupBox2.Controls.Add(Me.txtma_loai_nv)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtma_bp)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtten_nv)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(535, 158)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Tag = ""
        '
        'ten_loai_nv
        '
        Me.ten_loai_nv.AutoSize = True
        Me.ten_loai_nv.Location = New System.Drawing.Point(222, 79)
        Me.ten_loai_nv.Name = "ten_loai_nv"
        Me.ten_loai_nv.Size = New System.Drawing.Size(62, 13)
        Me.ten_loai_nv.TabIndex = 10
        Me.ten_loai_nv.Text = "ten_loai_nv"
        '
        'ten_bp
        '
        Me.ten_bp.AutoSize = True
        Me.ten_bp.Location = New System.Drawing.Point(222, 52)
        Me.ten_bp.Name = "ten_bp"
        Me.ten_bp.Size = New System.Drawing.Size(40, 13)
        Me.ten_bp.TabIndex = 9
        Me.ten_bp.Text = "ten_bp"
        '
        'txtma_loai_nv
        '
        Me.txtma_loai_nv.Location = New System.Drawing.Point(97, 75)
        Me.txtma_loai_nv.Name = "txtma_loai_nv"
        Me.txtma_loai_nv.Size = New System.Drawing.Size(108, 20)
        Me.txtma_loai_nv.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Tag = "007"
        Me.Label2.Text = "Loai nhan vien"
        '
        'txtma_bp
        '
        Me.txtma_bp.Location = New System.Drawing.Point(97, 48)
        Me.txtma_bp.Name = "txtma_bp"
        Me.txtma_bp.Size = New System.Drawing.Size(109, 20)
        Me.txtma_bp.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Tag = "012"
        Me.Label3.Text = "Phong ban"
        '
        'txtten_nv
        '
        Me.txtten_nv.Location = New System.Drawing.Point(97, 20)
        Me.txtten_nv.Name = "txtten_nv"
        Me.txtten_nv.Size = New System.Drawing.Size(292, 20)
        Me.txtten_nv.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Tag = "002"
        Me.Label1.Text = "Ten nhan vien"
        '
        'chbdang_lam_viec
        '
        Me.chbdang_lam_viec.AutoSize = True
        Me.chbdang_lam_viec.Location = New System.Drawing.Point(97, 115)
        Me.chbdang_lam_viec.Name = "chbdang_lam_viec"
        Me.chbdang_lam_viec.Size = New System.Drawing.Size(94, 17)
        Me.chbdang_lam_viec.TabIndex = 11
        Me.chbdang_lam_viec.Text = "Đang làm việc"
        Me.chbdang_lam_viec.UseVisualStyleBackColor = True
        '
        'dkloc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 210)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Name = "dkloc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "111"
        Me.Text = "dkloc"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtma_bp As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtten_nv As System.Windows.Forms.TextBox
    Friend WithEvents txtma_loai_nv As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ten_loai_nv As System.Windows.Forms.Label
    Friend WithEvents ten_bp As System.Windows.Forms.Label
    Friend WithEvents chbdang_lam_viec As System.Windows.Forms.CheckBox
End Class
