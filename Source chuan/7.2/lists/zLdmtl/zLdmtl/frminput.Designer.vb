<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frminput
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
        Me.btnLuu = New System.Windows.Forms.Button
        Me.btnhuy = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblten_loai = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.lblfolder_name = New System.Windows.Forms.Label
        Me.txtloai_tl = New System.Windows.Forms.TextBox
        Me.txtfolder_id = New System.Windows.Forms.TextBox
        Me.btnduyet = New System.Windows.Forms.Button
        Me.lblten_cq = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtfile_dk = New System.Windows.Forms.TextBox
        Me.txtchuc_vu = New System.Windows.Forms.TextBox
        Me.txtnguoi_ky = New System.Windows.Forms.TextBox
        Me.txtnoi_dung = New System.Windows.Forms.TextBox
        Me.txtnoi_gui = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtnoi_nhan = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtngay_tl = New ClsControl2.TxtDate
        Me.txtco_quan_ph = New System.Windows.Forms.TextBox
        Me.chbtrang_thai = New System.Windows.Forms.CheckBox
        Me.txtten_tl2 = New System.Windows.Forms.TextBox
        Me.txtten_tl = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtnguoi_tao = New System.Windows.Forms.Label
        Me.txtngay_tao = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtngay_sua = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtnguoi_sua = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLuu
        '
        Me.btnLuu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLuu.Location = New System.Drawing.Point(3, 355)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(54, 28)
        Me.btnLuu.TabIndex = 90
        Me.btnLuu.Tag = "094"
        Me.btnLuu.Text = "Luu"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'btnhuy
        '
        Me.btnhuy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnhuy.CausesValidation = False
        Me.btnhuy.Location = New System.Drawing.Point(59, 355)
        Me.btnhuy.Name = "btnhuy"
        Me.btnhuy.Size = New System.Drawing.Size(54, 28)
        Me.btnhuy.TabIndex = 91
        Me.btnhuy.Tag = "095"
        Me.btnhuy.Text = "Huy"
        Me.btnhuy.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.lblten_loai)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.lblfolder_name)
        Me.GroupBox1.Controls.Add(Me.txtloai_tl)
        Me.GroupBox1.Controls.Add(Me.txtfolder_id)
        Me.GroupBox1.Controls.Add(Me.btnduyet)
        Me.GroupBox1.Controls.Add(Me.lblten_cq)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtfile_dk)
        Me.GroupBox1.Controls.Add(Me.txtchuc_vu)
        Me.GroupBox1.Controls.Add(Me.txtnguoi_ky)
        Me.GroupBox1.Controls.Add(Me.txtnoi_dung)
        Me.GroupBox1.Controls.Add(Me.txtnoi_gui)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtnoi_nhan)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtngay_tl)
        Me.GroupBox1.Controls.Add(Me.txtco_quan_ph)
        Me.GroupBox1.Controls.Add(Me.chbtrang_thai)
        Me.GroupBox1.Controls.Add(Me.txtten_tl2)
        Me.GroupBox1.Controls.Add(Me.txtten_tl)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(3, -7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(548, 349)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lblten_loai
        '
        Me.lblten_loai.AutoSize = True
        Me.lblten_loai.Location = New System.Drawing.Point(319, 93)
        Me.lblten_loai.Name = "lblten_loai"
        Me.lblten_loai.Size = New System.Drawing.Size(56, 13)
        Me.lblten_loai.TabIndex = 52
        Me.lblten_loai.Text = "loai tai lieu"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(12, 93)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 13)
        Me.Label17.TabIndex = 51
        Me.Label17.Tag = "014"
        Me.Label17.Text = "loai tai lieu"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(12, 67)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(66, 13)
        Me.Label16.TabIndex = 50
        Me.Label16.Tag = "013"
        Me.Label16.Text = "nhom tai lieu"
        '
        'lblfolder_name
        '
        Me.lblfolder_name.AutoSize = True
        Me.lblfolder_name.Location = New System.Drawing.Point(319, 67)
        Me.lblfolder_name.Name = "lblfolder_name"
        Me.lblfolder_name.Size = New System.Drawing.Size(66, 13)
        Me.lblfolder_name.TabIndex = 49
        Me.lblfolder_name.Text = "nhom tai lieu"
        '
        'txtloai_tl
        '
        Me.txtloai_tl.Location = New System.Drawing.Point(129, 89)
        Me.txtloai_tl.MaxLength = 64
        Me.txtloai_tl.Name = "txtloai_tl"
        Me.txtloai_tl.Size = New System.Drawing.Size(180, 20)
        Me.txtloai_tl.TabIndex = 5
        '
        'txtfolder_id
        '
        Me.txtfolder_id.Location = New System.Drawing.Point(129, 63)
        Me.txtfolder_id.MaxLength = 64
        Me.txtfolder_id.Name = "txtfolder_id"
        Me.txtfolder_id.Size = New System.Drawing.Size(180, 20)
        Me.txtfolder_id.TabIndex = 4
        '
        'btnduyet
        '
        Me.btnduyet.Location = New System.Drawing.Point(450, 218)
        Me.btnduyet.Name = "btnduyet"
        Me.btnduyet.Size = New System.Drawing.Size(31, 23)
        Me.btnduyet.TabIndex = 11
        Me.btnduyet.Text = "..."
        Me.btnduyet.UseVisualStyleBackColor = True
        '
        'lblten_cq
        '
        Me.lblten_cq.AutoSize = True
        Me.lblten_cq.Location = New System.Drawing.Point(265, 145)
        Me.lblten_cq.Name = "lblten_cq"
        Me.lblten_cq.Size = New System.Drawing.Size(64, 13)
        Me.lblten_cq.TabIndex = 46
        Me.lblten_cq.Text = "ten co quan"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(12, 275)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(47, 13)
        Me.Label15.TabIndex = 45
        Me.Label15.Tag = "011"
        Me.Label15.Text = "nguoi ky"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 301)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 13)
        Me.Label14.TabIndex = 41
        Me.Label14.Tag = "012"
        Me.Label14.Text = "chuc vu"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 249)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 13)
        Me.Label13.TabIndex = 42
        Me.Label13.Tag = "010"
        Me.Label13.Text = "noi dung"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 223)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 13)
        Me.Label12.TabIndex = 43
        Me.Label12.Tag = "009"
        Me.Label12.Text = "file dinh kem"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 197)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 13)
        Me.Label11.TabIndex = 44
        Me.Label11.Tag = "008"
        Me.Label11.Text = "noi gui"
        '
        'txtfile_dk
        '
        Me.txtfile_dk.Location = New System.Drawing.Point(129, 219)
        Me.txtfile_dk.MaxLength = 64
        Me.txtfile_dk.Name = "txtfile_dk"
        Me.txtfile_dk.Size = New System.Drawing.Size(315, 20)
        Me.txtfile_dk.TabIndex = 10
        '
        'txtchuc_vu
        '
        Me.txtchuc_vu.Location = New System.Drawing.Point(129, 297)
        Me.txtchuc_vu.MaxLength = 64
        Me.txtchuc_vu.Name = "txtchuc_vu"
        Me.txtchuc_vu.Size = New System.Drawing.Size(209, 20)
        Me.txtchuc_vu.TabIndex = 14
        '
        'txtnguoi_ky
        '
        Me.txtnguoi_ky.Location = New System.Drawing.Point(129, 271)
        Me.txtnguoi_ky.MaxLength = 64
        Me.txtnguoi_ky.Name = "txtnguoi_ky"
        Me.txtnguoi_ky.Size = New System.Drawing.Size(209, 20)
        Me.txtnguoi_ky.TabIndex = 13
        '
        'txtnoi_dung
        '
        Me.txtnoi_dung.Location = New System.Drawing.Point(129, 245)
        Me.txtnoi_dung.MaxLength = 100
        Me.txtnoi_dung.Name = "txtnoi_dung"
        Me.txtnoi_dung.Size = New System.Drawing.Size(410, 20)
        Me.txtnoi_dung.TabIndex = 12
        '
        'txtnoi_gui
        '
        Me.txtnoi_gui.Location = New System.Drawing.Point(129, 193)
        Me.txtnoi_gui.MaxLength = 64
        Me.txtnoi_gui.Name = "txtnoi_gui"
        Me.txtnoi_gui.Size = New System.Drawing.Size(315, 20)
        Me.txtnoi_gui.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 171)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 34
        Me.Label9.Tag = "007"
        Me.Label9.Text = "noi nhan"
        '
        'txtnoi_nhan
        '
        Me.txtnoi_nhan.Location = New System.Drawing.Point(129, 167)
        Me.txtnoi_nhan.MaxLength = 64
        Me.txtnoi_nhan.Name = "txtnoi_nhan"
        Me.txtnoi_nhan.Size = New System.Drawing.Size(315, 20)
        Me.txtnoi_nhan.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Tag = "006"
        Me.Label7.Text = "co quan phat hanh"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Tag = "004"
        Me.Label2.Text = "ngay tao lap"
        '
        'txtngay_tl
        '
        Me.txtngay_tl.Culture = New System.Globalization.CultureInfo("en-US")
        Me.txtngay_tl.Location = New System.Drawing.Point(129, 115)
        Me.txtngay_tl.Mask = "00/00/0000"
        Me.txtngay_tl.Name = "txtngay_tl"
        Me.txtngay_tl.Size = New System.Drawing.Size(129, 20)
        Me.txtngay_tl.TabIndex = 6
        Me.txtngay_tl.Text = "01011910"
        Me.txtngay_tl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtngay_tl.Value = New Date(1910, 1, 1, 0, 0, 0, 0)
        '
        'txtco_quan_ph
        '
        Me.txtco_quan_ph.Location = New System.Drawing.Point(129, 141)
        Me.txtco_quan_ph.MaxLength = 64
        Me.txtco_quan_ph.Name = "txtco_quan_ph"
        Me.txtco_quan_ph.Size = New System.Drawing.Size(129, 20)
        Me.txtco_quan_ph.TabIndex = 7
        '
        'chbtrang_thai
        '
        Me.chbtrang_thai.AutoSize = True
        Me.chbtrang_thai.Location = New System.Drawing.Point(129, 323)
        Me.chbtrang_thai.Name = "chbtrang_thai"
        Me.chbtrang_thai.Size = New System.Drawing.Size(74, 17)
        Me.chbtrang_thai.TabIndex = 15
        Me.chbtrang_thai.Tag = "003"
        Me.chbtrang_thai.Text = "Trang thai"
        Me.chbtrang_thai.UseVisualStyleBackColor = True
        '
        'txtten_tl2
        '
        Me.txtten_tl2.Location = New System.Drawing.Point(129, 37)
        Me.txtten_tl2.MaxLength = 64
        Me.txtten_tl2.Name = "txtten_tl2"
        Me.txtten_tl2.Size = New System.Drawing.Size(410, 20)
        Me.txtten_tl2.TabIndex = 3
        '
        'txtten_tl
        '
        Me.txtten_tl.Location = New System.Drawing.Point(129, 11)
        Me.txtten_tl.MaxLength = 64
        Me.txtten_tl.Name = "txtten_tl"
        Me.txtten_tl.Size = New System.Drawing.Size(410, 20)
        Me.txtten_tl.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Tag = "002"
        Me.Label10.Text = "Ten tl"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Tag = "005"
        Me.Label4.Text = "Ten tl2"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(0, 392)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Tag = "090"
        Me.Label3.Text = "Nguoi tao:"
        '
        'txtnguoi_tao
        '
        Me.txtnguoi_tao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtnguoi_tao.AutoSize = True
        Me.txtnguoi_tao.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtnguoi_tao.Location = New System.Drawing.Point(67, 392)
        Me.txtnguoi_tao.Name = "txtnguoi_tao"
        Me.txtnguoi_tao.Size = New System.Drawing.Size(51, 13)
        Me.txtnguoi_tao.TabIndex = 14
        Me.txtnguoi_tao.Text = "nguoi tao"
        '
        'txtngay_tao
        '
        Me.txtngay_tao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtngay_tao.AutoSize = True
        Me.txtngay_tao.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtngay_tao.Location = New System.Drawing.Point(225, 392)
        Me.txtngay_tao.Name = "txtngay_tao"
        Me.txtngay_tao.Size = New System.Drawing.Size(48, 13)
        Me.txtngay_tao.TabIndex = 16
        Me.txtngay_tao.Text = "ngay tao"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(158, 392)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Tag = "092"
        Me.Label6.Text = "Ngay tao:"
        '
        'txtngay_sua
        '
        Me.txtngay_sua.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtngay_sua.AutoSize = True
        Me.txtngay_sua.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtngay_sua.Location = New System.Drawing.Point(225, 407)
        Me.txtngay_sua.Name = "txtngay_sua"
        Me.txtngay_sua.Size = New System.Drawing.Size(50, 13)
        Me.txtngay_sua.TabIndex = 20
        Me.txtngay_sua.Text = "ngay sua"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(158, 407)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Tag = "093"
        Me.Label5.Text = "Ngay sua:"
        '
        'txtnguoi_sua
        '
        Me.txtnguoi_sua.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtnguoi_sua.AutoSize = True
        Me.txtnguoi_sua.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtnguoi_sua.Location = New System.Drawing.Point(67, 407)
        Me.txtnguoi_sua.Name = "txtnguoi_sua"
        Me.txtnguoi_sua.Size = New System.Drawing.Size(53, 13)
        Me.txtnguoi_sua.TabIndex = 18
        Me.txtnguoi_sua.Text = "nguoi sua"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(0, 407)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Tag = "091"
        Me.Label8.Text = "Nguoi sua:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frminput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 426)
        Me.Controls.Add(Me.txtngay_sua)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtnguoi_sua)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtngay_tao)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtnguoi_tao)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnhuy)
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frminput"
        Me.Tag = "000"
        Me.Text = "frminput"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLuu As System.Windows.Forms.Button
    Friend WithEvents btnhuy As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtnguoi_tao As System.Windows.Forms.Label
    Friend WithEvents txtngay_tao As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtngay_sua As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtnguoi_sua As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtten_tl As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtten_tl2 As System.Windows.Forms.TextBox
    Friend WithEvents chbtrang_thai As System.Windows.Forms.CheckBox
    Friend WithEvents txtco_quan_ph As System.Windows.Forms.TextBox
    Friend WithEvents txtngay_tl As ClsControl2.TxtDate
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtfile_dk As System.Windows.Forms.TextBox
    Friend WithEvents txtchuc_vu As System.Windows.Forms.TextBox
    Friend WithEvents txtnguoi_ky As System.Windows.Forms.TextBox
    Friend WithEvents txtnoi_dung As System.Windows.Forms.TextBox
    Friend WithEvents txtnoi_gui As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtnoi_nhan As System.Windows.Forms.TextBox
    Friend WithEvents lblten_cq As System.Windows.Forms.Label
    Friend WithEvents btnduyet As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtloai_tl As System.Windows.Forms.TextBox
    Friend WithEvents txtfolder_id As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblfolder_name As System.Windows.Forms.Label
    Friend WithEvents lblten_loai As System.Windows.Forms.Label
End Class
