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
        Me.TxtDen_ngay = New ClsControl2.TxtDate()
        Me.Txttu_ngay = New ClsControl2.TxtDate()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnhuy = New System.Windows.Forms.Button()
        Me.btntim = New System.Windows.Forms.Button()
        Me.txtma_thue = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ten_thue = New System.Windows.Forms.Label()
        Me.ten_tk = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txttk_vt = New System.Windows.Forms.TextBox()
        Me.lblten_tk_dt = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txttk_dt = New System.Windows.Forms.TextBox()
        Me.lblten_tk_tien = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txttk_tien = New System.Windows.Forms.TextBox()
        Me.lblten_tk_ck = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txttk_ck = New System.Windows.Forms.TextBox()
        Me.chbck = New System.Windows.Forms.CheckBox()
        Me.chbnock = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'TxtDen_ngay
        '
        Me.TxtDen_ngay.Culture = New System.Globalization.CultureInfo("en-US")
        Me.TxtDen_ngay.Location = New System.Drawing.Point(296, 6)
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
        Me.Txttu_ngay.Location = New System.Drawing.Point(190, 6)
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
        Me.btnhuy.Location = New System.Drawing.Point(84, 194)
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
        Me.btntim.Location = New System.Drawing.Point(3, 194)
        Me.btntim.Name = "btntim"
        Me.btntim.Size = New System.Drawing.Size(75, 23)
        Me.btntim.TabIndex = 6
        Me.btntim.Tag = "233"
        Me.btntim.Text = "Tim"
        Me.btntim.UseVisualStyleBackColor = True
        '
        'txtma_thue
        '
        Me.txtma_thue.Location = New System.Drawing.Point(190, 32)
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
        Me.ten_thue.Location = New System.Drawing.Point(296, 35)
        Me.ten_thue.Name = "ten_thue"
        Me.ten_thue.Size = New System.Drawing.Size(46, 13)
        Me.ten_thue.TabIndex = 10
        Me.ten_thue.Text = "ten thue"
        '
        'ten_tk
        '
        Me.ten_tk.AutoSize = True
        Me.ten_tk.Location = New System.Drawing.Point(296, 61)
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
        Me.txttk_vt.Location = New System.Drawing.Point(190, 58)
        Me.txttk_vt.Name = "txttk_vt"
        Me.txttk_vt.Size = New System.Drawing.Size(100, 20)
        Me.txttk_vt.TabIndex = 3
        '
        'lblten_tk_dt
        '
        Me.lblten_tk_dt.AutoSize = True
        Me.lblten_tk_dt.Location = New System.Drawing.Point(296, 87)
        Me.lblten_tk_dt.Name = "lblten_tk_dt"
        Me.lblten_tk_dt.Size = New System.Drawing.Size(34, 13)
        Me.lblten_tk_dt.TabIndex = 16
        Me.lblten_tk_dt.Text = "ten tk"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Tag = "TKDT"
        Me.Label5.Text = "Tài khoản doanh thu"
        '
        'txttk_dt
        '
        Me.txttk_dt.Location = New System.Drawing.Point(190, 84)
        Me.txttk_dt.Name = "txttk_dt"
        Me.txttk_dt.Size = New System.Drawing.Size(100, 20)
        Me.txttk_dt.TabIndex = 4
        '
        'lblten_tk_tien
        '
        Me.lblten_tk_tien.AutoSize = True
        Me.lblten_tk_tien.Location = New System.Drawing.Point(296, 140)
        Me.lblten_tk_tien.Name = "lblten_tk_tien"
        Me.lblten_tk_tien.Size = New System.Drawing.Size(34, 13)
        Me.lblten_tk_tien.TabIndex = 19
        Me.lblten_tk_tien.Text = "ten tk"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(166, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Tag = ""
        Me.Label6.Text = "Tài khoản đối ứng(Tiền, công nợ)"
        '
        'txttk_tien
        '
        Me.txttk_tien.Location = New System.Drawing.Point(190, 136)
        Me.txttk_tien.Name = "txttk_tien"
        Me.txttk_tien.Size = New System.Drawing.Size(100, 20)
        Me.txttk_tien.TabIndex = 6
        '
        'lblten_tk_ck
        '
        Me.lblten_tk_ck.AutoSize = True
        Me.lblten_tk_ck.Location = New System.Drawing.Point(296, 113)
        Me.lblten_tk_ck.Name = "lblten_tk_ck"
        Me.lblten_tk_ck.Size = New System.Drawing.Size(34, 13)
        Me.lblten_tk_ck.TabIndex = 22
        Me.lblten_tk_ck.Text = "ten tk"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 113)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Tag = "TKDT"
        Me.Label7.Text = "Tài khoản chiết khấu"
        '
        'txttk_ck
        '
        Me.txttk_ck.Location = New System.Drawing.Point(190, 110)
        Me.txttk_ck.Name = "txttk_ck"
        Me.txttk_ck.Size = New System.Drawing.Size(100, 20)
        Me.txttk_ck.TabIndex = 5
        '
        'chbck
        '
        Me.chbck.AutoSize = True
        Me.chbck.Location = New System.Drawing.Point(190, 163)
        Me.chbck.Name = "chbck"
        Me.chbck.Size = New System.Drawing.Size(92, 17)
        Me.chbck.TabIndex = 23
        Me.chbck.TabStop = False
        Me.chbck.Text = "Có chiết khấu"
        Me.chbck.UseVisualStyleBackColor = True
        '
        'chbnock
        '
        Me.chbnock.AutoSize = True
        Me.chbnock.Location = New System.Drawing.Point(288, 163)
        Me.chbnock.Name = "chbnock"
        Me.chbnock.Size = New System.Drawing.Size(110, 17)
        Me.chbnock.TabIndex = 24
        Me.chbnock.TabStop = False
        Me.chbnock.Text = "Không chiết khấu"
        Me.chbnock.UseVisualStyleBackColor = True
        '
        'frmdklayhd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 219)
        Me.Controls.Add(Me.chbnock)
        Me.Controls.Add(Me.chbck)
        Me.Controls.Add(Me.lblten_tk_ck)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txttk_ck)
        Me.Controls.Add(Me.lblten_tk_tien)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txttk_tien)
        Me.Controls.Add(Me.lblten_tk_dt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txttk_dt)
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
    Friend WithEvents lblten_tk_dt As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txttk_dt As TextBox
    Friend WithEvents lblten_tk_tien As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txttk_tien As TextBox
    Friend WithEvents lblten_tk_ck As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txttk_ck As TextBox
    Friend WithEvents chbck As CheckBox
    Friend WithEvents chbnock As CheckBox
End Class
