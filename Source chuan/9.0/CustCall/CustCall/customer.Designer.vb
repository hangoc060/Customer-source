<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customer
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtghi_chu = New System.Windows.Forms.TextBox()
        Me.cbbma_loai_kh = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnGhi_chu = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.btnAddNewCust = New System.Windows.Forms.Button()
        Me.txtdia_chi = New System.Windows.Forms.TextBox()
        Me.txtten_kh = New System.Windows.Forms.TextBox()
        Me.txtma_kh = New System.Windows.Forms.TextBox()
        Me.dien_thoai_current = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtdien_thoai5 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtdien_thoai4 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtdien_thoai3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtdien_thoai2 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtdien_thoai = New System.Windows.Forms.TextBox()
        Me.btnselectkh = New System.Windows.Forms.Button()
        Me.btnordertmp = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(6, 281)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(620, 188)
        Me.TabControl1.TabIndex = 30
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(612, 162)
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
        Me.DataGridView1.Size = New System.Drawing.Size(606, 156)
        Me.DataGridView1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.txtghi_chu)
        Me.TabPage2.Controls.Add(Me.cbbma_loai_kh)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(612, 162)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Thông tin khác"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Ghi chú"
        '
        'txtghi_chu
        '
        Me.txtghi_chu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtghi_chu.BackColor = System.Drawing.Color.White
        Me.txtghi_chu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtghi_chu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtghi_chu.Location = New System.Drawing.Point(108, 43)
        Me.txtghi_chu.Multiline = True
        Me.txtghi_chu.Name = "txtghi_chu"
        Me.txtghi_chu.Size = New System.Drawing.Size(490, 113)
        Me.txtghi_chu.TabIndex = 34
        '
        'cbbma_loai_kh
        '
        Me.cbbma_loai_kh.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbbma_loai_kh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbma_loai_kh.FormattingEnabled = True
        Me.cbbma_loai_kh.Location = New System.Drawing.Point(108, 16)
        Me.cbbma_loai_kh.Name = "cbbma_loai_kh"
        Me.cbbma_loai_kh.Size = New System.Drawing.Size(490, 21)
        Me.cbbma_loai_kh.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Loại khách hàng"
        '
        'btnGhi_chu
        '
        Me.btnGhi_chu.Location = New System.Drawing.Point(282, 252)
        Me.btnGhi_chu.Name = "btnGhi_chu"
        Me.btnGhi_chu.Size = New System.Drawing.Size(84, 23)
        Me.btnGhi_chu.TabIndex = 28
        Me.btnGhi_chu.Text = "Ghi chú"
        Me.btnGhi_chu.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Địa chỉ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Tên khách hàng"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Mã khách"
        '
        'btnOrder
        '
        Me.btnOrder.Location = New System.Drawing.Point(107, 252)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(84, 23)
        Me.btnOrder.TabIndex = 24
        Me.btnOrder.Text = "Đặt hàng"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'btnAddNewCust
        '
        Me.btnAddNewCust.Location = New System.Drawing.Point(5, 252)
        Me.btnAddNewCust.Name = "btnAddNewCust"
        Me.btnAddNewCust.Size = New System.Drawing.Size(100, 23)
        Me.btnAddNewCust.TabIndex = 23
        Me.btnAddNewCust.Text = "Cập nhật KH"
        Me.btnAddNewCust.UseVisualStyleBackColor = True
        '
        'txtdia_chi
        '
        Me.txtdia_chi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtdia_chi.BackColor = System.Drawing.Color.White
        Me.txtdia_chi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdia_chi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdia_chi.Location = New System.Drawing.Point(107, 125)
        Me.txtdia_chi.Name = "txtdia_chi"
        Me.txtdia_chi.Size = New System.Drawing.Size(512, 23)
        Me.txtdia_chi.TabIndex = 2
        '
        'txtten_kh
        '
        Me.txtten_kh.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtten_kh.BackColor = System.Drawing.Color.White
        Me.txtten_kh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtten_kh.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtten_kh.Location = New System.Drawing.Point(107, 96)
        Me.txtten_kh.Name = "txtten_kh"
        Me.txtten_kh.Size = New System.Drawing.Size(512, 23)
        Me.txtten_kh.TabIndex = 1
        '
        'txtma_kh
        '
        Me.txtma_kh.BackColor = System.Drawing.Color.White
        Me.txtma_kh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtma_kh.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtma_kh.Location = New System.Drawing.Point(107, 67)
        Me.txtma_kh.Name = "txtma_kh"
        Me.txtma_kh.ReadOnly = True
        Me.txtma_kh.Size = New System.Drawing.Size(157, 23)
        Me.txtma_kh.TabIndex = 0
        Me.txtma_kh.TabStop = False
        '
        'dien_thoai_current
        '
        Me.dien_thoai_current.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dien_thoai_current.BackColor = System.Drawing.Color.White
        Me.dien_thoai_current.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dien_thoai_current.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dien_thoai_current.ForeColor = System.Drawing.Color.Blue
        Me.dien_thoai_current.Location = New System.Drawing.Point(3, 3)
        Me.dien_thoai_current.Name = "dien_thoai_current"
        Me.dien_thoai_current.ReadOnly = True
        Me.dien_thoai_current.Size = New System.Drawing.Size(616, 35)
        Me.dien_thoai_current.TabIndex = 20
        Me.dien_thoai_current.TabStop = False
        Me.dien_thoai_current.Text = "dien thoai"
        Me.dien_thoai_current.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(316, 187)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 13)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Điện thoại 5"
        '
        'txtdien_thoai5
        '
        Me.txtdien_thoai5.BackColor = System.Drawing.Color.White
        Me.txtdien_thoai5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdien_thoai5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdien_thoai5.Location = New System.Drawing.Point(420, 182)
        Me.txtdien_thoai5.Name = "txtdien_thoai5"
        Me.txtdien_thoai5.Size = New System.Drawing.Size(199, 23)
        Me.txtdien_thoai5.TabIndex = 40
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(316, 158)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Điện thoại 4"
        '
        'txtdien_thoai4
        '
        Me.txtdien_thoai4.BackColor = System.Drawing.Color.White
        Me.txtdien_thoai4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdien_thoai4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdien_thoai4.Location = New System.Drawing.Point(420, 153)
        Me.txtdien_thoai4.Name = "txtdien_thoai4"
        Me.txtdien_thoai4.Size = New System.Drawing.Size(199, 23)
        Me.txtdien_thoai4.TabIndex = 38
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Điện thoại 3"
        '
        'txtdien_thoai3
        '
        Me.txtdien_thoai3.BackColor = System.Drawing.Color.White
        Me.txtdien_thoai3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdien_thoai3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdien_thoai3.Location = New System.Drawing.Point(107, 211)
        Me.txtdien_thoai3.Name = "txtdien_thoai3"
        Me.txtdien_thoai3.Size = New System.Drawing.Size(157, 23)
        Me.txtdien_thoai3.TabIndex = 36
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Điện thoại 2"
        '
        'txtdien_thoai2
        '
        Me.txtdien_thoai2.BackColor = System.Drawing.Color.White
        Me.txtdien_thoai2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdien_thoai2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdien_thoai2.Location = New System.Drawing.Point(107, 182)
        Me.txtdien_thoai2.Name = "txtdien_thoai2"
        Me.txtdien_thoai2.Size = New System.Drawing.Size(157, 23)
        Me.txtdien_thoai2.TabIndex = 34
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 158)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Điện thoại 1"
        '
        'txtdien_thoai
        '
        Me.txtdien_thoai.BackColor = System.Drawing.Color.White
        Me.txtdien_thoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdien_thoai.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdien_thoai.Location = New System.Drawing.Point(107, 153)
        Me.txtdien_thoai.Name = "txtdien_thoai"
        Me.txtdien_thoai.Size = New System.Drawing.Size(157, 23)
        Me.txtdien_thoai.TabIndex = 32
        '
        'btnselectkh
        '
        Me.btnselectkh.Location = New System.Drawing.Point(270, 67)
        Me.btnselectkh.Name = "btnselectkh"
        Me.btnselectkh.Size = New System.Drawing.Size(44, 23)
        Me.btnselectkh.TabIndex = 42
        Me.btnselectkh.TabStop = False
        Me.btnselectkh.Text = "..."
        Me.btnselectkh.UseVisualStyleBackColor = True
        '
        'btnordertmp
        '
        Me.btnordertmp.Location = New System.Drawing.Point(194, 252)
        Me.btnordertmp.Name = "btnordertmp"
        Me.btnordertmp.Size = New System.Drawing.Size(84, 23)
        Me.btnordertmp.TabIndex = 43
        Me.btnordertmp.Text = "Đặt hàng tạm"
        Me.btnordertmp.UseVisualStyleBackColor = True
        '
        'customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnordertmp)
        Me.Controls.Add(Me.btnselectkh)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtdien_thoai5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtdien_thoai4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtdien_thoai3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtdien_thoai2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtdien_thoai)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnGhi_chu)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.btnAddNewCust)
        Me.Controls.Add(Me.txtdia_chi)
        Me.Controls.Add(Me.txtten_kh)
        Me.Controls.Add(Me.txtma_kh)
        Me.Controls.Add(Me.dien_thoai_current)
        Me.Name = "customer"
        Me.Size = New System.Drawing.Size(629, 472)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnGhi_chu As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnOrder As Button
    Friend WithEvents btnAddNewCust As Button
    Friend WithEvents txtdia_chi As TextBox
    Friend WithEvents txtten_kh As TextBox
    Friend WithEvents txtma_kh As TextBox
    Friend WithEvents dien_thoai_current As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbbma_loai_kh As ComboBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label5 As Label
    Friend WithEvents txtghi_chu As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtdien_thoai5 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtdien_thoai4 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtdien_thoai3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtdien_thoai2 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtdien_thoai As TextBox
    Friend WithEvents btnselectkh As Button
    Friend WithEvents btnordertmp As Button
End Class
