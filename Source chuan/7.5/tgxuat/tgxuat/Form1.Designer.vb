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
        Me.btnOK = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Grpbox = New System.Windows.Forms.GroupBox
        Me.Txtthreadnumber = New System.Windows.Forms.NumericUpDown
        Me.txtnha_cung_cap = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblten_tk = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txttk_cl = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Txttao_px_cl = New ClsControl2.TxtNumeric
        Me.lblten_vt = New System.Windows.Forms.Label
        Me.cbbma_kho = New System.Windows.Forms.ComboBox
        Me.cbbloai_vt = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cbbnh_vt = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Txtma_vt = New System.Windows.Forms.TextBox
        Me.Txtnam = New ClsControl2.TxtNumeric
        Me.Txtden_ky = New ClsControl2.TxtNumeric
        Me.Txttu_ky = New ClsControl2.TxtNumeric
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.txtserver = New System.Windows.Forms.ToolStripStatusLabel
        Me.txtdatabase = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblstatus = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.progressbar = New System.Windows.Forms.ToolStripProgressBar
        Me.btnerrordetail = New System.Windows.Forms.Button
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.Grpbox.SuspendLayout()
        CType(Me.Txtthreadnumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Location = New System.Drawing.Point(6, 236)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 11
        Me.btnOK.Tag = "900"
        Me.btnOK.Text = "Nhan"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.CausesValidation = False
        Me.btnCancel.Location = New System.Drawing.Point(87, 236)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Tag = "901"
        Me.btnCancel.Text = "Huy"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Grpbox
        '
        Me.Grpbox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grpbox.Controls.Add(Me.Txtthreadnumber)
        Me.Grpbox.Controls.Add(Me.txtnha_cung_cap)
        Me.Grpbox.Controls.Add(Me.Label11)
        Me.Grpbox.Controls.Add(Me.Label9)
        Me.Grpbox.Controls.Add(Me.lblten_tk)
        Me.Grpbox.Controls.Add(Me.Label10)
        Me.Grpbox.Controls.Add(Me.txttk_cl)
        Me.Grpbox.Controls.Add(Me.Label8)
        Me.Grpbox.Controls.Add(Me.Label7)
        Me.Grpbox.Controls.Add(Me.Txttao_px_cl)
        Me.Grpbox.Controls.Add(Me.lblten_vt)
        Me.Grpbox.Controls.Add(Me.cbbma_kho)
        Me.Grpbox.Controls.Add(Me.cbbloai_vt)
        Me.Grpbox.Controls.Add(Me.Label6)
        Me.Grpbox.Controls.Add(Me.cbbnh_vt)
        Me.Grpbox.Controls.Add(Me.Label5)
        Me.Grpbox.Controls.Add(Me.Label4)
        Me.Grpbox.Controls.Add(Me.Label3)
        Me.Grpbox.Controls.Add(Me.Label2)
        Me.Grpbox.Controls.Add(Me.Label1)
        Me.Grpbox.Controls.Add(Me.Txtma_vt)
        Me.Grpbox.Controls.Add(Me.Txtnam)
        Me.Grpbox.Controls.Add(Me.Txtden_ky)
        Me.Grpbox.Controls.Add(Me.Txttu_ky)
        Me.Grpbox.Location = New System.Drawing.Point(-9, -27)
        Me.Grpbox.Name = "Grpbox"
        Me.Grpbox.Size = New System.Drawing.Size(672, 259)
        Me.Grpbox.TabIndex = 13
        Me.Grpbox.TabStop = False
        '
        'Txtthreadnumber
        '
        Me.Txtthreadnumber.Location = New System.Drawing.Point(197, 230)
        Me.Txtthreadnumber.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.Txtthreadnumber.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Txtthreadnumber.Name = "Txtthreadnumber"
        Me.Txtthreadnumber.Size = New System.Drawing.Size(70, 20)
        Me.Txtthreadnumber.TabIndex = 36
        Me.Txtthreadnumber.TabStop = False
        Me.Txtthreadnumber.Value = New Decimal(New Integer() {5, 0, 0, 0})
        Me.Txtthreadnumber.Visible = False
        '
        'txtnha_cung_cap
        '
        Me.txtnha_cung_cap.Location = New System.Drawing.Point(197, 157)
        Me.txtnha_cung_cap.Name = "txtnha_cung_cap"
        Me.txtnha_cung_cap.Size = New System.Drawing.Size(349, 20)
        Me.txtnha_cung_cap.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(21, 161)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 13)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Nhà cung cấp"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 234)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 13)
        Me.Label9.TabIndex = 34
        Me.Label9.Tag = ""
        Me.Label9.Text = "Số vật tư tính một lần"
        Me.Label9.Visible = False
        '
        'lblten_tk
        '
        Me.lblten_tk.AutoSize = True
        Me.lblten_tk.Location = New System.Drawing.Point(338, 210)
        Me.lblten_tk.Name = "lblten_tk"
        Me.lblten_tk.Size = New System.Drawing.Size(69, 13)
        Me.lblten_tk.TabIndex = 32
        Me.lblten_tk.Text = "ten tai khoan"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(21, 210)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 13)
        Me.Label10.TabIndex = 31
        Me.Label10.Tag = "009"
        Me.Label10.Text = "tai khoan chenh lech"
        '
        'txttk_cl
        '
        Me.txttk_cl.Location = New System.Drawing.Point(197, 206)
        Me.txttk_cl.Name = "txttk_cl"
        Me.txttk_cl.Size = New System.Drawing.Size(118, 20)
        Me.txttk_cl.TabIndex = 9
        Me.txttk_cl.Text = "632"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 186)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Tag = "008"
        Me.Label8.Text = "Tao phieu xuat chenh lech"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(235, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(172, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Tag = "010"
        Me.Label7.Text = "0.Khong tao,1.tao khi sl=0 tien <>0"
        '
        'Txttao_px_cl
        '
        Me.Txttao_px_cl.Location = New System.Drawing.Point(197, 182)
        Me.Txttao_px_cl.MaxLength = 2
        Me.Txttao_px_cl.Name = "Txttao_px_cl"
        Me.Txttao_px_cl.NumberDecimalDigits = 0
        Me.Txttao_px_cl.Size = New System.Drawing.Size(32, 20)
        Me.Txttao_px_cl.TabIndex = 8
        Me.Txttao_px_cl.Text = "0"
        Me.Txttao_px_cl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txttao_px_cl.Value = 0
        Me.Txttao_px_cl.Value2 = 0
        '
        'lblten_vt
        '
        Me.lblten_vt.AutoSize = True
        Me.lblten_vt.Location = New System.Drawing.Point(338, 67)
        Me.lblten_vt.Name = "lblten_vt"
        Me.lblten_vt.Size = New System.Drawing.Size(34, 13)
        Me.lblten_vt.TabIndex = 26
        Me.lblten_vt.Text = "ten vt"
        '
        'cbbma_kho
        '
        Me.cbbma_kho.FormattingEnabled = True
        Me.cbbma_kho.Location = New System.Drawing.Point(197, 132)
        Me.cbbma_kho.Name = "cbbma_kho"
        Me.cbbma_kho.Size = New System.Drawing.Size(349, 21)
        Me.cbbma_kho.TabIndex = 5
        '
        'cbbloai_vt
        '
        Me.cbbloai_vt.FormattingEnabled = True
        Me.cbbloai_vt.Location = New System.Drawing.Point(197, 108)
        Me.cbbloai_vt.Name = "cbbloai_vt"
        Me.cbbloai_vt.Size = New System.Drawing.Size(349, 21)
        Me.cbbloai_vt.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Tag = "007"
        Me.Label6.Text = "loai vt"
        '
        'cbbnh_vt
        '
        Me.cbbnh_vt.FormattingEnabled = True
        Me.cbbnh_vt.Location = New System.Drawing.Point(197, 85)
        Me.cbbnh_vt.Name = "cbbnh_vt"
        Me.cbbnh_vt.Size = New System.Drawing.Size(349, 21)
        Me.cbbnh_vt.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Tag = "005"
        Me.Label5.Text = "kho"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Tag = "006"
        Me.Label4.Text = "nhom vt"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Tag = "004"
        Me.Label3.Text = "vat tu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(273, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Tag = "003"
        Me.Label2.Text = "nam"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Tag = "002"
        Me.Label1.Text = "tu ky/den ky"
        '
        'Txtma_vt
        '
        Me.Txtma_vt.Location = New System.Drawing.Point(197, 63)
        Me.Txtma_vt.Name = "Txtma_vt"
        Me.Txtma_vt.Size = New System.Drawing.Size(118, 20)
        Me.Txtma_vt.TabIndex = 2
        '
        'Txtnam
        '
        Me.Txtnam.Location = New System.Drawing.Point(311, 40)
        Me.Txtnam.MaxLength = 4
        Me.Txtnam.Name = "Txtnam"
        Me.Txtnam.NumberDecimalDigits = -1
        Me.Txtnam.Size = New System.Drawing.Size(70, 20)
        Me.Txtnam.TabIndex = 1
        Me.Txtnam.Text = "0"
        Me.Txtnam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtnam.Value = 0
        Me.Txtnam.Value2 = 0
        '
        'Txtden_ky
        '
        Me.Txtden_ky.Location = New System.Drawing.Point(235, 40)
        Me.Txtden_ky.MaxLength = 2
        Me.Txtden_ky.Name = "Txtden_ky"
        Me.Txtden_ky.NumberDecimalDigits = 0
        Me.Txtden_ky.Size = New System.Drawing.Size(32, 20)
        Me.Txtden_ky.TabIndex = 0
        Me.Txtden_ky.Text = "0"
        Me.Txtden_ky.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtden_ky.Value = 0
        Me.Txtden_ky.Value2 = 0
        '
        'Txttu_ky
        '
        Me.Txttu_ky.Location = New System.Drawing.Point(197, 40)
        Me.Txttu_ky.MaxLength = 2
        Me.Txttu_ky.Name = "Txttu_ky"
        Me.Txttu_ky.NumberDecimalDigits = 0
        Me.Txttu_ky.Size = New System.Drawing.Size(32, 20)
        Me.Txttu_ky.TabIndex = 0
        Me.Txttu_ky.Text = "0"
        Me.Txttu_ky.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txttu_ky.Value = 0
        Me.Txttu_ky.Value2 = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtserver, Me.txtdatabase, Me.lblstatus, Me.ToolStripStatusLabel1, Me.progressbar})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 264)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(645, 24)
        Me.StatusStrip1.TabIndex = 14
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'txtserver
        '
        Me.txtserver.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.txtserver.Name = "txtserver"
        Me.txtserver.Size = New System.Drawing.Size(43, 19)
        Me.txtserver.Text = "Server"
        '
        'txtdatabase
        '
        Me.txtdatabase.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.txtdatabase.Name = "txtdatabase"
        Me.txtdatabase.Size = New System.Drawing.Size(59, 19)
        Me.txtdatabase.Text = "Database"
        '
        'lblstatus
        '
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(36, 19)
        Me.lblstatus.Text = "ready"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(390, 19)
        Me.ToolStripStatusLabel1.Spring = True
        '
        'progressbar
        '
        Me.progressbar.Name = "progressbar"
        Me.progressbar.Size = New System.Drawing.Size(100, 18)
        Me.progressbar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        '
        'btnerrordetail
        '
        Me.btnerrordetail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnerrordetail.ForeColor = System.Drawing.Color.Red
        Me.btnerrordetail.Location = New System.Drawing.Point(546, 236)
        Me.btnerrordetail.Name = "btnerrordetail"
        Me.btnerrordetail.Size = New System.Drawing.Size(87, 23)
        Me.btnerrordetail.TabIndex = 16
        Me.btnerrordetail.Text = "Chi tiết lỗi"
        Me.btnerrordetail.UseVisualStyleBackColor = True
        Me.btnerrordetail.Visible = False
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 288)
        Me.Controls.Add(Me.btnerrordetail)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Grpbox)
        Me.MinimumSize = New System.Drawing.Size(661, 284)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "000"
        Me.Text = "Tinh gia trung binh vat tu"
        Me.Grpbox.ResumeLayout(False)
        Me.Grpbox.PerformLayout()
        CType(Me.Txtthreadnumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Grpbox As System.Windows.Forms.GroupBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents progressbar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txtma_vt As System.Windows.Forms.TextBox
    Friend WithEvents Txtnam As ClsControl2.TxtNumeric
    Friend WithEvents Txtden_ky As ClsControl2.TxtNumeric
    Friend WithEvents Txttu_ky As ClsControl2.TxtNumeric
    Friend WithEvents cbbma_kho As System.Windows.Forms.ComboBox
    Friend WithEvents cbbloai_vt As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbbnh_vt As System.Windows.Forms.ComboBox
    Friend WithEvents lblten_vt As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Txttao_px_cl As ClsControl2.TxtNumeric
    Friend WithEvents lblten_tk As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txttk_cl As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtserver As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtdatabase As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnerrordetail As System.Windows.Forms.Button
    Friend WithEvents lblstatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtnha_cung_cap As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Txtthreadnumber As System.Windows.Forms.NumericUpDown

End Class
