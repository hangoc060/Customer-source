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
        Me.chbTaoPXCL = New System.Windows.Forms.CheckBox
        Me.lblten_vt = New System.Windows.Forms.Label
        Me.cbbma_kho = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
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
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Location = New System.Drawing.Point(6, 115)
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
        Me.btnCancel.Location = New System.Drawing.Point(87, 115)
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
        Me.Grpbox.Controls.Add(Me.chbTaoPXCL)
        Me.Grpbox.Controls.Add(Me.lblten_vt)
        Me.Grpbox.Controls.Add(Me.cbbma_kho)
        Me.Grpbox.Controls.Add(Me.Label5)
        Me.Grpbox.Controls.Add(Me.Label3)
        Me.Grpbox.Controls.Add(Me.Label2)
        Me.Grpbox.Controls.Add(Me.Label1)
        Me.Grpbox.Controls.Add(Me.Txtma_vt)
        Me.Grpbox.Controls.Add(Me.Txtnam)
        Me.Grpbox.Controls.Add(Me.Txtden_ky)
        Me.Grpbox.Controls.Add(Me.Txttu_ky)
        Me.Grpbox.Location = New System.Drawing.Point(-9, -27)
        Me.Grpbox.Name = "Grpbox"
        Me.Grpbox.Size = New System.Drawing.Size(672, 136)
        Me.Grpbox.TabIndex = 13
        Me.Grpbox.TabStop = False
        '
        'chbTaoPXCL
        '
        Me.chbTaoPXCL.AutoSize = True
        Me.chbTaoPXCL.Location = New System.Drawing.Point(197, 113)
        Me.chbTaoPXCL.Name = "chbTaoPXCL"
        Me.chbTaoPXCL.Size = New System.Drawing.Size(105, 17)
        Me.chbTaoPXCL.TabIndex = 4
        Me.chbTaoPXCL.Text = "Xử lý chênh lệnh"
        Me.chbTaoPXCL.UseVisualStyleBackColor = True
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
        Me.cbbma_kho.Location = New System.Drawing.Point(197, 86)
        Me.cbbma_kho.Name = "cbbma_kho"
        Me.cbbma_kho.Size = New System.Drawing.Size(349, 21)
        Me.cbbma_kho.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Tag = "005"
        Me.Label5.Text = "kho"
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
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 143)
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
        Me.btnerrordetail.Location = New System.Drawing.Point(546, 115)
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
        Me.ClientSize = New System.Drawing.Size(645, 167)
        Me.Controls.Add(Me.btnerrordetail)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Grpbox)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "000"
        Me.Text = "Tinh gia trung binh vat tu"
        Me.Grpbox.ResumeLayout(False)
        Me.Grpbox.PerformLayout()
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txtma_vt As System.Windows.Forms.TextBox
    Friend WithEvents Txtnam As ClsControl2.TxtNumeric
    Friend WithEvents Txtden_ky As ClsControl2.TxtNumeric
    Friend WithEvents Txttu_ky As ClsControl2.TxtNumeric
    Friend WithEvents cbbma_kho As System.Windows.Forms.ComboBox
    Friend WithEvents lblten_vt As System.Windows.Forms.Label
    Friend WithEvents txtserver As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtdatabase As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnerrordetail As System.Windows.Forms.Button
    Friend WithEvents lblstatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents chbTaoPXCL As System.Windows.Forms.CheckBox

End Class
