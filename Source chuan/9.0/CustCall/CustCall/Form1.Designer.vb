<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lbldien_thoai = New System.Windows.Forms.TextBox()
        Me.txtma_kh = New System.Windows.Forms.TextBox()
        Me.txtten_kh = New System.Windows.Forms.TextBox()
        Me.txtdia_chi = New System.Windows.Forms.TextBox()
        Me.btnAddNewCust = New System.Windows.Forms.Button()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnGhi_chu = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cbbma_loai_kh = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtdien_thoai = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtdien_thoai2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtdien_thoai3 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtdien_thoai4 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtdien_thoai5 = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbldien_thoai
        '
        Me.lbldien_thoai.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbldien_thoai.BackColor = System.Drawing.Color.White
        Me.lbldien_thoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbldien_thoai.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldien_thoai.ForeColor = System.Drawing.Color.Blue
        Me.lbldien_thoai.Location = New System.Drawing.Point(12, 12)
        Me.lbldien_thoai.Name = "lbldien_thoai"
        Me.lbldien_thoai.ReadOnly = True
        Me.lbldien_thoai.Size = New System.Drawing.Size(610, 35)
        Me.lbldien_thoai.TabIndex = 1
        Me.lbldien_thoai.TabStop = False
        Me.lbldien_thoai.Text = "dien thoai"
        Me.lbldien_thoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtma_kh
        '
        Me.txtma_kh.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtma_kh.BackColor = System.Drawing.Color.White
        Me.txtma_kh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtma_kh.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtma_kh.Location = New System.Drawing.Point(116, 76)
        Me.txtma_kh.Name = "txtma_kh"
        Me.txtma_kh.ReadOnly = True
        Me.txtma_kh.Size = New System.Drawing.Size(506, 23)
        Me.txtma_kh.TabIndex = 0
        Me.txtma_kh.TabStop = False
        '
        'txtten_kh
        '
        Me.txtten_kh.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtten_kh.BackColor = System.Drawing.Color.White
        Me.txtten_kh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtten_kh.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtten_kh.Location = New System.Drawing.Point(116, 105)
        Me.txtten_kh.Name = "txtten_kh"
        Me.txtten_kh.Size = New System.Drawing.Size(506, 23)
        Me.txtten_kh.TabIndex = 1
        '
        'txtdia_chi
        '
        Me.txtdia_chi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtdia_chi.BackColor = System.Drawing.Color.White
        Me.txtdia_chi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdia_chi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdia_chi.Location = New System.Drawing.Point(116, 134)
        Me.txtdia_chi.Name = "txtdia_chi"
        Me.txtdia_chi.Size = New System.Drawing.Size(506, 23)
        Me.txtdia_chi.TabIndex = 2
        '
        'btnAddNewCust
        '
        Me.btnAddNewCust.Location = New System.Drawing.Point(15, 206)
        Me.btnAddNewCust.Name = "btnAddNewCust"
        Me.btnAddNewCust.Size = New System.Drawing.Size(100, 23)
        Me.btnAddNewCust.TabIndex = 5
        Me.btnAddNewCust.Text = "Cập nhật KH"
        Me.btnAddNewCust.UseVisualStyleBackColor = True
        '
        'btnOrder
        '
        Me.btnOrder.Location = New System.Drawing.Point(119, 206)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(84, 23)
        Me.btnOrder.TabIndex = 6
        Me.btnOrder.Text = "Đặt hàng"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Mã khách"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Tên khách hàng"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Địa chỉ"
        '
        'btnGhi_chu
        '
        Me.btnGhi_chu.Location = New System.Drawing.Point(209, 206)
        Me.btnGhi_chu.Name = "btnGhi_chu"
        Me.btnGhi_chu.Size = New System.Drawing.Size(84, 23)
        Me.btnGhi_chu.TabIndex = 12
        Me.btnGhi_chu.Text = "Ghi chú"
        Me.btnGhi_chu.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(502, 206)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Đồng bộ khách hàng"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(15, 244)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(607, 184)
        Me.TabControl1.TabIndex = 15
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(599, 158)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Lịch sử giao dịch"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(593, 152)
        Me.DataGridView1.TabIndex = 0
        '
        'cbbma_loai_kh
        '
        Me.cbbma_loai_kh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbma_loai_kh.FormattingEnabled = True
        Me.cbbma_loai_kh.Location = New System.Drawing.Point(116, 164)
        Me.cbbma_loai_kh.Name = "cbbma_loai_kh"
        Me.cbbma_loai_kh.Size = New System.Drawing.Size(506, 21)
        Me.cbbma_loai_kh.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Loại khách hàng"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.txtdien_thoai5)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.txtdien_thoai4)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.txtdien_thoai3)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.txtdien_thoai2)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.txtdien_thoai)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(599, 158)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Số điện thoại khác"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Điện thoại 1"
        '
        'txtdien_thoai
        '
        Me.txtdien_thoai.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtdien_thoai.BackColor = System.Drawing.Color.White
        Me.txtdien_thoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdien_thoai.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdien_thoai.Location = New System.Drawing.Point(113, 15)
        Me.txtdien_thoai.Name = "txtdien_thoai"
        Me.txtdien_thoai.Size = New System.Drawing.Size(258, 23)
        Me.txtdien_thoai.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Điện thoại 2"
        '
        'txtdien_thoai2
        '
        Me.txtdien_thoai2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtdien_thoai2.BackColor = System.Drawing.Color.White
        Me.txtdien_thoai2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdien_thoai2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdien_thoai2.Location = New System.Drawing.Point(113, 44)
        Me.txtdien_thoai2.Name = "txtdien_thoai2"
        Me.txtdien_thoai2.Size = New System.Drawing.Size(258, 23)
        Me.txtdien_thoai2.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Điện thoại 3"
        '
        'txtdien_thoai3
        '
        Me.txtdien_thoai3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtdien_thoai3.BackColor = System.Drawing.Color.White
        Me.txtdien_thoai3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdien_thoai3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdien_thoai3.Location = New System.Drawing.Point(113, 73)
        Me.txtdien_thoai3.Name = "txtdien_thoai3"
        Me.txtdien_thoai3.Size = New System.Drawing.Size(258, 23)
        Me.txtdien_thoai3.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Điện thoại 4"
        '
        'txtdien_thoai4
        '
        Me.txtdien_thoai4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtdien_thoai4.BackColor = System.Drawing.Color.White
        Me.txtdien_thoai4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdien_thoai4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdien_thoai4.Location = New System.Drawing.Point(113, 102)
        Me.txtdien_thoai4.Name = "txtdien_thoai4"
        Me.txtdien_thoai4.Size = New System.Drawing.Size(258, 23)
        Me.txtdien_thoai4.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 133)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Điện thoại 5"
        '
        'txtdien_thoai5
        '
        Me.txtdien_thoai5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtdien_thoai5.BackColor = System.Drawing.Color.White
        Me.txtdien_thoai5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdien_thoai5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdien_thoai5.Location = New System.Drawing.Point(113, 129)
        Me.txtdien_thoai5.Name = "txtdien_thoai5"
        Me.txtdien_thoai5.Size = New System.Drawing.Size(258, 23)
        Me.txtdien_thoai5.TabIndex = 17
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 440)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbbma_loai_kh)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnGhi_chu)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.btnAddNewCust)
        Me.Controls.Add(Me.txtdia_chi)
        Me.Controls.Add(Me.txtten_kh)
        Me.Controls.Add(Me.txtma_kh)
        Me.Controls.Add(Me.lbldien_thoai)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Khách hàng liên hệ"
        Me.TopMost = True
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbldien_thoai As System.Windows.Forms.TextBox
    Friend WithEvents txtma_kh As System.Windows.Forms.TextBox
    Friend WithEvents txtten_kh As System.Windows.Forms.TextBox
    Friend WithEvents txtdia_chi As System.Windows.Forms.TextBox
    Friend WithEvents btnAddNewCust As System.Windows.Forms.Button
    Friend WithEvents btnOrder As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnGhi_chu As System.Windows.Forms.Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cbbma_loai_kh As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label9 As Label
    Friend WithEvents txtdien_thoai5 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtdien_thoai4 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtdien_thoai3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtdien_thoai2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtdien_thoai As TextBox
End Class
