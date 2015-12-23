<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateFromDM
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
        Me.ten_kho = New System.Windows.Forms.Label()
        Me.ten_nvu = New System.Windows.Forms.Label()
        Me.txtma_kho = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtma_nvu = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnhuy = New System.Windows.Forms.Button()
        Me.btntim = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtma_dvt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txtso_luong = New ClsControl2.TxtNumeric()
        Me.ten_sp = New System.Windows.Forms.Label()
        Me.txtma_sp = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ten_kho
        '
        Me.ten_kho.AutoSize = True
        Me.ten_kho.Location = New System.Drawing.Point(237, 93)
        Me.ten_kho.Name = "ten_kho"
        Me.ten_kho.Size = New System.Drawing.Size(43, 13)
        Me.ten_kho.TabIndex = 121
        Me.ten_kho.Text = "ten kho"
        '
        'ten_nvu
        '
        Me.ten_nvu.AutoSize = True
        Me.ten_nvu.Location = New System.Drawing.Point(237, 116)
        Me.ten_nvu.Name = "ten_nvu"
        Me.ten_nvu.Size = New System.Drawing.Size(43, 13)
        Me.ten_nvu.TabIndex = 120
        Me.ten_nvu.Text = "ten nvu"
        '
        'txtma_kho
        '
        Me.txtma_kho.Location = New System.Drawing.Point(130, 89)
        Me.txtma_kho.Name = "txtma_kho"
        Me.txtma_kho.Size = New System.Drawing.Size(100, 20)
        Me.txtma_kho.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 117
        Me.Label4.Tag = ""
        Me.Label4.Text = "Kho nguyên vật liệu"
        '
        'txtma_nvu
        '
        Me.txtma_nvu.Location = New System.Drawing.Point(130, 112)
        Me.txtma_nvu.Name = "txtma_nvu"
        Me.txtma_nvu.Size = New System.Drawing.Size(100, 20)
        Me.txtma_nvu.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 115
        Me.Label2.Tag = "NVU"
        Me.Label2.Text = "Nghiệp vụ"
        '
        'btnhuy
        '
        Me.btnhuy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnhuy.Location = New System.Drawing.Point(83, 141)
        Me.btnhuy.Name = "btnhuy"
        Me.btnhuy.Size = New System.Drawing.Size(75, 23)
        Me.btnhuy.TabIndex = 8
        Me.btnhuy.Tag = "229"
        Me.btnhuy.Text = "Hủy"
        Me.btnhuy.UseVisualStyleBackColor = True
        '
        'btntim
        '
        Me.btntim.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btntim.Location = New System.Drawing.Point(2, 141)
        Me.btntim.Name = "btntim"
        Me.btntim.Size = New System.Drawing.Size(75, 23)
        Me.btntim.TabIndex = 7
        Me.btntim.Tag = "233"
        Me.btntim.Text = "Tim"
        Me.btntim.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtma_dvt)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Txtso_luong)
        Me.GroupBox1.Controls.Add(Me.ten_sp)
        Me.GroupBox1.Controls.Add(Me.ten_kho)
        Me.GroupBox1.Controls.Add(Me.ten_nvu)
        Me.GroupBox1.Controls.Add(Me.txtma_sp)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtma_kho)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtma_nvu)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(-3, -10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(540, 145)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'txtma_dvt
        '
        Me.txtma_dvt.Location = New System.Drawing.Point(130, 42)
        Me.txtma_dvt.Name = "txtma_dvt"
        Me.txtma_dvt.Size = New System.Drawing.Size(100, 20)
        Me.txtma_dvt.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 126
        Me.Label6.Tag = ""
        Me.Label6.Text = "Đơn vị tính"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 124
        Me.Label1.Text = "Số lượng sản xuất"
        '
        'Txtso_luong
        '
        Me.Txtso_luong.Location = New System.Drawing.Point(130, 65)
        Me.Txtso_luong.MaxLength = 18
        Me.Txtso_luong.Name = "Txtso_luong"
        Me.Txtso_luong.NumberDecimalDigits = 0
        Me.Txtso_luong.Size = New System.Drawing.Size(100, 20)
        Me.Txtso_luong.TabIndex = 2
        Me.Txtso_luong.Text = "0"
        Me.Txtso_luong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtso_luong.Value = 0R
        Me.Txtso_luong.Value2 = 0R
        '
        'ten_sp
        '
        Me.ten_sp.AutoSize = True
        Me.ten_sp.Location = New System.Drawing.Point(237, 22)
        Me.ten_sp.Name = "ten_sp"
        Me.ten_sp.Size = New System.Drawing.Size(64, 13)
        Me.ten_sp.TabIndex = 122
        Me.ten_sp.Text = "ten bo phan"
        '
        'txtma_sp
        '
        Me.txtma_sp.Location = New System.Drawing.Point(130, 19)
        Me.txtma_sp.Name = "txtma_sp"
        Me.txtma_sp.Size = New System.Drawing.Size(100, 20)
        Me.txtma_sp.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 119
        Me.Label5.Tag = "MBP"
        Me.Label5.Text = "Mã sản phẩm"
        '
        'frmCreateFromDM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 165)
        Me.Controls.Add(Me.btnhuy)
        Me.Controls.Add(Me.btntim)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmCreateFromDM"
        Me.Text = "Tạo phiếu xuất từ định mức nguyên vật liệu"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ten_kho As Label
    Friend WithEvents ten_nvu As Label
    Friend WithEvents txtma_kho As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtma_nvu As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnhuy As Button
    Friend WithEvents btntim As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ten_sp As Label
    Friend WithEvents txtma_sp As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Txtso_luong As ClsControl2.TxtNumeric
    Friend WithEvents txtma_dvt As TextBox
    Friend WithEvents Label6 As Label
End Class
