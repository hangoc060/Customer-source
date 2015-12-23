<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsearch
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
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtma_kho = New System.Windows.Forms.TextBox
        Me.label99 = New System.Windows.Forms.Label
        Me.txtdien_giai = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtden_ngay = New ClsControl2.TxtDate
        Me.lable = New System.Windows.Forms.Label
        Me.Txttu_ngay = New ClsControl2.TxtDate
        Me.btntim = New System.Windows.Forms.Button
        Me.btnhuy = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtma_sp = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtma_sp)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtma_kho)
        Me.GroupBox1.Controls.Add(Me.label99)
        Me.GroupBox1.Controls.Add(Me.txtdien_giai)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtden_ngay)
        Me.GroupBox1.Controls.Add(Me.lable)
        Me.GroupBox1.Controls.Add(Me.Txttu_ngay)
        Me.GroupBox1.Location = New System.Drawing.Point(-6, -7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(455, 119)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 13)
        Me.Label9.TabIndex = 52
        Me.Label9.Tag = "406"
        Me.Label9.Text = "Kho"
        '
        'txtma_kho
        '
        Me.txtma_kho.Location = New System.Drawing.Point(108, 62)
        Me.txtma_kho.Name = "txtma_kho"
        Me.txtma_kho.Size = New System.Drawing.Size(317, 20)
        Me.txtma_kho.TabIndex = 48
        '
        'label99
        '
        Me.label99.AutoSize = True
        Me.label99.Location = New System.Drawing.Point(14, 40)
        Me.label99.Name = "label99"
        Me.label99.Size = New System.Drawing.Size(50, 13)
        Me.label99.TabIndex = 51
        Me.label99.Tag = "405"
        Me.label99.Text = "Noi dung"
        '
        'txtdien_giai
        '
        Me.txtdien_giai.Location = New System.Drawing.Point(108, 36)
        Me.txtdien_giai.Name = "txtdien_giai"
        Me.txtdien_giai.Size = New System.Drawing.Size(317, 20)
        Me.txtdien_giai.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(220, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 50
        Me.Label1.Tag = "401"
        Me.Label1.Text = "Den ngay"
        '
        'txtden_ngay
        '
        Me.txtden_ngay.Culture = New System.Globalization.CultureInfo("vi-VN")
        Me.txtden_ngay.Location = New System.Drawing.Point(325, 11)
        Me.txtden_ngay.Mask = "00/00/0000"
        Me.txtden_ngay.Name = "txtden_ngay"
        Me.txtden_ngay.Size = New System.Drawing.Size(100, 20)
        Me.txtden_ngay.TabIndex = 46
        Me.txtden_ngay.Text = "01011910"
        Me.txtden_ngay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtden_ngay.Value = New Date(1910, 1, 1, 0, 0, 0, 0)
        '
        'lable
        '
        Me.lable.AutoSize = True
        Me.lable.Location = New System.Drawing.Point(14, 15)
        Me.lable.Name = "lable"
        Me.lable.Size = New System.Drawing.Size(46, 13)
        Me.lable.TabIndex = 49
        Me.lable.Tag = "400"
        Me.lable.Text = "Tu ngay"
        '
        'Txttu_ngay
        '
        Me.Txttu_ngay.Location = New System.Drawing.Point(108, 11)
        Me.Txttu_ngay.Mask = "00/00/0000"
        Me.Txttu_ngay.Name = "Txttu_ngay"
        Me.Txttu_ngay.Size = New System.Drawing.Size(100, 20)
        Me.Txttu_ngay.TabIndex = 45
        Me.Txttu_ngay.Text = "01011910"
        Me.Txttu_ngay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txttu_ngay.Value = New Date(1910, 1, 1, 0, 0, 0, 0)
        '
        'btntim
        '
        Me.btntim.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btntim.Location = New System.Drawing.Point(5, 118)
        Me.btntim.Name = "btntim"
        Me.btntim.Size = New System.Drawing.Size(75, 23)
        Me.btntim.TabIndex = 1
        Me.btntim.Tag = "233"
        Me.btntim.Text = "Tim"
        Me.btntim.UseVisualStyleBackColor = True
        '
        'btnhuy
        '
        Me.btnhuy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnhuy.Location = New System.Drawing.Point(86, 118)
        Me.btnhuy.Name = "btnhuy"
        Me.btnhuy.Size = New System.Drawing.Size(75, 23)
        Me.btnhuy.TabIndex = 2
        Me.btnhuy.Tag = "229"
        Me.btnhuy.Text = "Huy"
        Me.btnhuy.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 54
        Me.Label2.Tag = "001"
        Me.Label2.Text = "Sản phẩm"
        '
        'txtma_sp
        '
        Me.txtma_sp.Location = New System.Drawing.Point(108, 87)
        Me.txtma_sp.Name = "txtma_sp"
        Me.txtma_sp.Size = New System.Drawing.Size(317, 20)
        Me.txtma_sp.TabIndex = 53
        '
        'frmsearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 145)
        Me.Controls.Add(Me.btnhuy)
        Me.Controls.Add(Me.btntim)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmsearch"
        Me.Tag = "234"
        Me.Text = "frmsearch"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btntim As System.Windows.Forms.Button
    Friend WithEvents btnhuy As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtma_kho As System.Windows.Forms.TextBox
    Friend WithEvents label99 As System.Windows.Forms.Label
    Friend WithEvents txtdien_giai As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtden_ngay As ClsControl2.TxtDate
    Friend WithEvents lable As System.Windows.Forms.Label
    Friend WithEvents Txttu_ngay As ClsControl2.TxtDate
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtma_sp As System.Windows.Forms.TextBox
End Class
