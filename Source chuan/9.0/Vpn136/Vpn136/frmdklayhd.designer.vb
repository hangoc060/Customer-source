<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdklayhd
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
        Me.TxtDen_ngay = New ClsControl2.TxtDate
        Me.Txttu_ngay = New ClsControl2.TxtDate
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnhuy = New System.Windows.Forms.Button
        Me.btntim = New System.Windows.Forms.Button
        Me.ten_kho = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtma_kho = New System.Windows.Forms.TextBox
        Me.ten_nvu = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtma_nvu = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'TxtDen_ngay
        '
        Me.TxtDen_ngay.Location = New System.Drawing.Point(243, 6)
        Me.TxtDen_ngay.Mask = "00/00/0000"
        Me.TxtDen_ngay.Name = "TxtDen_ngay"
        Me.TxtDen_ngay.Size = New System.Drawing.Size(100, 20)
        Me.TxtDen_ngay.TabIndex = 1
        Me.TxtDen_ngay.Text = "22012010"
        Me.TxtDen_ngay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtDen_ngay.Value = New Date(2010, 1, 22, 0, 0, 0, 0)
        '
        'Txttu_ngay
        '
        Me.Txttu_ngay.Location = New System.Drawing.Point(137, 6)
        Me.Txttu_ngay.Mask = "00/00/0000"
        Me.Txttu_ngay.Name = "Txttu_ngay"
        Me.Txttu_ngay.Size = New System.Drawing.Size(100, 20)
        Me.Txttu_ngay.TabIndex = 0
        Me.Txttu_ngay.Text = "22012010"
        Me.Txttu_ngay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txttu_ngay.Value = New Date(2010, 1, 22, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Tag = "232"
        Me.Label1.Text = "tu/den ngay"
        '
        'btnhuy
        '
        Me.btnhuy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnhuy.Location = New System.Drawing.Point(85, 75)
        Me.btnhuy.Name = "btnhuy"
        Me.btnhuy.Size = New System.Drawing.Size(75, 23)
        Me.btnhuy.TabIndex = 7
        Me.btnhuy.Tag = "229"
        Me.btnhuy.Text = "Huy"
        Me.btnhuy.UseVisualStyleBackColor = True
        '
        'btntim
        '
        Me.btntim.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btntim.Location = New System.Drawing.Point(4, 75)
        Me.btntim.Name = "btntim"
        Me.btntim.Size = New System.Drawing.Size(75, 23)
        Me.btntim.TabIndex = 4
        Me.btntim.Tag = "233"
        Me.btntim.Text = "Tim"
        Me.btntim.UseVisualStyleBackColor = True
        '
        'ten_kho
        '
        Me.ten_kho.AutoSize = True
        Me.ten_kho.Location = New System.Drawing.Point(243, 32)
        Me.ten_kho.Name = "ten_kho"
        Me.ten_kho.Size = New System.Drawing.Size(43, 13)
        Me.ten_kho.TabIndex = 13
        Me.ten_kho.Text = "ten kho"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Tag = "KHO"
        Me.Label2.Text = "Kho nhập"
        '
        'txtma_kho
        '
        Me.txtma_kho.Location = New System.Drawing.Point(137, 28)
        Me.txtma_kho.Name = "txtma_kho"
        Me.txtma_kho.Size = New System.Drawing.Size(100, 20)
        Me.txtma_kho.TabIndex = 2
        '
        'ten_nvu
        '
        Me.ten_nvu.AutoSize = True
        Me.ten_nvu.Location = New System.Drawing.Point(243, 54)
        Me.ten_nvu.Name = "ten_nvu"
        Me.ten_nvu.Size = New System.Drawing.Size(72, 13)
        Me.ten_nvu.TabIndex = 16
        Me.ten_nvu.Text = "ten nghiep vu"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Tag = "NVU"
        Me.Label4.Text = "Nghiệp vụ"
        '
        'txtma_nvu
        '
        Me.txtma_nvu.Location = New System.Drawing.Point(137, 50)
        Me.txtma_nvu.Name = "txtma_nvu"
        Me.txtma_nvu.Size = New System.Drawing.Size(100, 20)
        Me.txtma_nvu.TabIndex = 3
        '
        'frmdklayhd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 100)
        Me.Controls.Add(Me.ten_nvu)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtma_nvu)
        Me.Controls.Add(Me.ten_kho)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtma_kho)
        Me.Controls.Add(Me.btnhuy)
        Me.Controls.Add(Me.btntim)
        Me.Controls.Add(Me.TxtDen_ngay)
        Me.Controls.Add(Me.Txttu_ngay)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmdklayhd"
        Me.Tag = "234"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtDen_ngay As ClsControl2.TxtDate
    Friend WithEvents Txttu_ngay As ClsControl2.TxtDate
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnhuy As System.Windows.Forms.Button
    Friend WithEvents btntim As System.Windows.Forms.Button
    Friend WithEvents ten_kho As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtma_kho As System.Windows.Forms.TextBox
    Friend WithEvents ten_nvu As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtma_nvu As System.Windows.Forms.TextBox
End Class
