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
        Me.txtma_thue = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ten_thue = New System.Windows.Forms.Label
        Me.ten_tk = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txttk_vt = New System.Windows.Forms.TextBox
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
        Me.btnhuy.Location = New System.Drawing.Point(84, 99)
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
        Me.btntim.Location = New System.Drawing.Point(3, 99)
        Me.btntim.Name = "btntim"
        Me.btntim.Size = New System.Drawing.Size(75, 23)
        Me.btntim.TabIndex = 6
        Me.btntim.Tag = "233"
        Me.btntim.Text = "Tim"
        Me.btntim.UseVisualStyleBackColor = True
        '
        'txtma_thue
        '
        Me.txtma_thue.Location = New System.Drawing.Point(137, 32)
        Me.txtma_thue.Name = "txtma_thue"
        Me.txtma_thue.Size = New System.Drawing.Size(100, 20)
        Me.txtma_thue.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Tag = "MTH"
        Me.Label2.Text = "Mã thuế"
        '
        'ten_thue
        '
        Me.ten_thue.AutoSize = True
        Me.ten_thue.Location = New System.Drawing.Point(243, 35)
        Me.ten_thue.Name = "ten_thue"
        Me.ten_thue.Size = New System.Drawing.Size(46, 13)
        Me.ten_thue.TabIndex = 10
        Me.ten_thue.Text = "ten thue"
        '
        'ten_tk
        '
        Me.ten_tk.AutoSize = True
        Me.ten_tk.Location = New System.Drawing.Point(243, 61)
        Me.ten_tk.Name = "ten_tk"
        Me.ten_tk.Size = New System.Drawing.Size(34, 13)
        Me.ten_tk.TabIndex = 13
        Me.ten_tk.Text = "ten tk"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Tag = "TKV"
        Me.Label4.Text = "Tài khoản vật tư"
        '
        'txttk_vt
        '
        Me.txttk_vt.Location = New System.Drawing.Point(137, 58)
        Me.txttk_vt.Name = "txttk_vt"
        Me.txttk_vt.Size = New System.Drawing.Size(100, 20)
        Me.txttk_vt.TabIndex = 3
        '
        'frmdklayhd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 124)
        Me.Controls.Add(Me.ten_tk)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txttk_vt)
        Me.Controls.Add(Me.ten_thue)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtma_thue)
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
    Friend WithEvents txtma_thue As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ten_thue As System.Windows.Forms.Label
    Friend WithEvents ten_tk As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txttk_vt As System.Windows.Forms.TextBox
End Class
