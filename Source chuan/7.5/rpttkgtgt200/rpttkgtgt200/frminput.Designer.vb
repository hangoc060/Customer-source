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
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.ptinh_theo_tk = New System.Windows.Forms.Panel
        Me.chbthue_suat = New System.Windows.Forms.CheckBox
        Me.ten_thue = New System.Windows.Forms.Label
        Me.txtma_thue = New System.Windows.Forms.TextBox
        Me.cbbdbf = New System.Windows.Forms.ComboBox
        Me.txttk_co = New System.Windows.Forms.TextBox
        Me.txttk_no = New System.Windows.Forms.TextBox
        Me.cbbkind = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cbbtype = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtma_so02 = New System.Windows.Forms.TextBox
        Me.txtstt_in = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.chbbold = New System.Windows.Forms.CheckBox
        Me.chbin_ck = New System.Windows.Forms.CheckBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtma_so01 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtchi_tieu2 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtchi_tieu = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtma_so = New System.Windows.Forms.TextBox
        Me.Txtstt = New ClsControl2.TxtNumeric
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtcach_tinh = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtma_tc = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.ptinh_theo_tk.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLuu
        '
        Me.btnLuu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLuu.Location = New System.Drawing.Point(3, 426)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(54, 28)
        Me.btnLuu.TabIndex = 90
        Me.btnLuu.Tag = "037"
        Me.btnLuu.Text = "Luu"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'btnhuy
        '
        Me.btnhuy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnhuy.CausesValidation = False
        Me.btnhuy.Location = New System.Drawing.Point(59, 426)
        Me.btnhuy.Name = "btnhuy"
        Me.btnhuy.Size = New System.Drawing.Size(54, 28)
        Me.btnhuy.TabIndex = 91
        Me.btnhuy.Tag = "038"
        Me.btnhuy.Text = "Huy"
        Me.btnhuy.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.ptinh_theo_tk)
        Me.GroupBox1.Controls.Add(Me.cbbkind)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtcach_tinh)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Location = New System.Drawing.Point(-7, -7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(611, 427)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(10, 261)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 13)
        Me.Label13.TabIndex = 37
        Me.Label13.Tag = "045"
        Me.Label13.Text = "Ma thue"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Tag = "044"
        Me.Label3.Text = "Lay tu bang"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 370)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Tag = "035"
        Me.Label5.Text = "Tai khoan co"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 346)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 13)
        Me.Label11.TabIndex = 34
        Me.Label11.Tag = "033"
        Me.Label11.Text = "Tai khoan no"
        '
        'ptinh_theo_tk
        '
        Me.ptinh_theo_tk.Controls.Add(Me.txtma_tc)
        Me.ptinh_theo_tk.Controls.Add(Me.chbthue_suat)
        Me.ptinh_theo_tk.Controls.Add(Me.ten_thue)
        Me.ptinh_theo_tk.Controls.Add(Me.txtma_thue)
        Me.ptinh_theo_tk.Controls.Add(Me.cbbdbf)
        Me.ptinh_theo_tk.Controls.Add(Me.txttk_co)
        Me.ptinh_theo_tk.Controls.Add(Me.txttk_no)
        Me.ptinh_theo_tk.Location = New System.Drawing.Point(115, 228)
        Me.ptinh_theo_tk.Name = "ptinh_theo_tk"
        Me.ptinh_theo_tk.Size = New System.Drawing.Size(489, 163)
        Me.ptinh_theo_tk.TabIndex = 2
        '
        'chbthue_suat
        '
        Me.chbthue_suat.AutoSize = True
        Me.chbthue_suat.Location = New System.Drawing.Point(11, 93)
        Me.chbthue_suat.Name = "chbthue_suat"
        Me.chbthue_suat.Size = New System.Drawing.Size(186, 17)
        Me.chbthue_suat.TabIndex = 3
        Me.chbthue_suat.Tag = "046"
        Me.chbthue_suat.Text = "chi tinh chung tu co thue dau vao"
        Me.chbthue_suat.UseVisualStyleBackColor = True
        '
        'ten_thue
        '
        Me.ten_thue.AutoSize = True
        Me.ten_thue.Location = New System.Drawing.Point(107, 33)
        Me.ten_thue.Name = "ten_thue"
        Me.ten_thue.Size = New System.Drawing.Size(46, 13)
        Me.ten_thue.TabIndex = 38
        Me.ten_thue.Tag = ""
        Me.ten_thue.Text = "ten thue"
        '
        'txtma_thue
        '
        Me.txtma_thue.Location = New System.Drawing.Point(11, 30)
        Me.txtma_thue.Name = "txtma_thue"
        Me.txtma_thue.Size = New System.Drawing.Size(90, 20)
        Me.txtma_thue.TabIndex = 1
        '
        'cbbdbf
        '
        Me.cbbdbf.FormattingEnabled = True
        Me.cbbdbf.Location = New System.Drawing.Point(11, 3)
        Me.cbbdbf.Name = "cbbdbf"
        Me.cbbdbf.Size = New System.Drawing.Size(468, 21)
        Me.cbbdbf.TabIndex = 0
        '
        'txttk_co
        '
        Me.txttk_co.Location = New System.Drawing.Point(11, 139)
        Me.txttk_co.Name = "txttk_co"
        Me.txttk_co.Size = New System.Drawing.Size(227, 20)
        Me.txttk_co.TabIndex = 5
        '
        'txttk_no
        '
        Me.txttk_no.Location = New System.Drawing.Point(11, 115)
        Me.txttk_no.Name = "txttk_no"
        Me.txttk_no.Size = New System.Drawing.Size(227, 20)
        Me.txttk_no.TabIndex = 4
        '
        'cbbkind
        '
        Me.cbbkind.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbbkind.FormattingEnabled = True
        Me.cbbkind.Location = New System.Drawing.Point(126, 201)
        Me.cbbkind.Name = "cbbkind"
        Me.cbbkind.Size = New System.Drawing.Size(468, 21)
        Me.cbbkind.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.cbbtype)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtma_so02)
        Me.GroupBox2.Controls.Add(Me.txtstt_in)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.chbbold)
        Me.GroupBox2.Controls.Add(Me.chbin_ck)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtma_so01)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtchi_tieu2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtchi_tieu)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtma_so)
        Me.GroupBox2.Controls.Add(Me.Txtstt)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(611, 194)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'cbbtype
        '
        Me.cbbtype.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbbtype.FormattingEnabled = True
        Me.cbbtype.Location = New System.Drawing.Point(126, 159)
        Me.cbbtype.Name = "cbbtype"
        Me.cbbtype.Size = New System.Drawing.Size(468, 21)
        Me.cbbtype.TabIndex = 9
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(10, 163)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 13)
        Me.Label14.TabIndex = 27
        Me.Label14.Tag = "043"
        Me.Label14.Text = "Kiểu hiện"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(175, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Tag = "042"
        Me.Label8.Text = "ma in [thue]"
        '
        'txtma_so02
        '
        Me.txtma_so02.Location = New System.Drawing.Point(253, 93)
        Me.txtma_so02.Name = "txtma_so02"
        Me.txtma_so02.Size = New System.Drawing.Size(47, 20)
        Me.txtma_so02.TabIndex = 6
        '
        'txtstt_in
        '
        Me.txtstt_in.Location = New System.Drawing.Point(494, 19)
        Me.txtstt_in.Name = "txtstt_in"
        Me.txtstt_in.Size = New System.Drawing.Size(100, 20)
        Me.txtstt_in.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(424, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Tag = "040"
        Me.Label6.Text = "Stt khi in"
        '
        'chbbold
        '
        Me.chbbold.AutoSize = True
        Me.chbbold.Location = New System.Drawing.Point(126, 141)
        Me.chbbold.Name = "chbbold"
        Me.chbbold.Size = New System.Drawing.Size(58, 17)
        Me.chbbold.TabIndex = 8
        Me.chbbold.Tag = "031"
        Me.chbbold.Text = "In dam"
        Me.chbbold.UseVisualStyleBackColor = True
        '
        'chbin_ck
        '
        Me.chbin_ck.AutoSize = True
        Me.chbin_ck.Location = New System.Drawing.Point(126, 118)
        Me.chbin_ck.Name = "chbin_ck"
        Me.chbin_ck.Size = New System.Drawing.Size(35, 17)
        Me.chbin_ck.TabIndex = 7
        Me.chbin_ck.Tag = "030"
        Me.chbin_ck.Text = "In"
        Me.chbin_ck.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Tag = "041"
        Me.Label9.Text = "Ma in[tien]"
        '
        'txtma_so01
        '
        Me.txtma_so01.Location = New System.Drawing.Point(126, 93)
        Me.txtma_so01.Name = "txtma_so01"
        Me.txtma_so01.Size = New System.Drawing.Size(40, 20)
        Me.txtma_so01.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Tag = "026"
        Me.Label7.Text = "chi tieu 2"
        '
        'txtchi_tieu2
        '
        Me.txtchi_tieu2.Location = New System.Drawing.Point(126, 68)
        Me.txtchi_tieu2.Name = "txtchi_tieu2"
        Me.txtchi_tieu2.Size = New System.Drawing.Size(468, 20)
        Me.txtchi_tieu2.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Tag = "025"
        Me.Label4.Text = "Chi tieu"
        '
        'txtchi_tieu
        '
        Me.txtchi_tieu.Location = New System.Drawing.Point(126, 44)
        Me.txtchi_tieu.Name = "txtchi_tieu"
        Me.txtchi_tieu.Size = New System.Drawing.Size(468, 20)
        Me.txtchi_tieu.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(171, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Tag = "024"
        Me.Label2.Text = "ma so"
        '
        'txtma_so
        '
        Me.txtma_so.Location = New System.Drawing.Point(253, 19)
        Me.txtma_so.Name = "txtma_so"
        Me.txtma_so.Size = New System.Drawing.Size(100, 20)
        Me.txtma_so.TabIndex = 1
        '
        'Txtstt
        '
        Me.Txtstt.Location = New System.Drawing.Point(126, 19)
        Me.Txtstt.MaxLength = 18
        Me.Txtstt.Name = "Txtstt"
        Me.Txtstt.NumberDecimalDigits = -1
        Me.Txtstt.Size = New System.Drawing.Size(40, 20)
        Me.Txtstt.TabIndex = 0
        Me.Txtstt.Text = "0"
        Me.Txtstt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtstt.Value = 0
        Me.Txtstt.Value2 = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Tag = "023"
        Me.Label1.Text = "Stt"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 397)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 13)
        Me.Label12.TabIndex = 26
        Me.Label12.Tag = "036"
        Me.Label12.Text = "Cong thuc"
        '
        'txtcach_tinh
        '
        Me.txtcach_tinh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtcach_tinh.Location = New System.Drawing.Point(126, 394)
        Me.txtcach_tinh.Name = "txtcach_tinh"
        Me.txtcach_tinh.Size = New System.Drawing.Size(468, 20)
        Me.txtcach_tinh.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 205)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Tag = "032"
        Me.Label10.Text = "PP tính"
        '
        'txtma_tc
        '
        Me.txtma_tc.Location = New System.Drawing.Point(11, 56)
        Me.txtma_tc.Name = "txtma_tc"
        Me.txtma_tc.Size = New System.Drawing.Size(90, 20)
        Me.txtma_tc.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(10, 287)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 13)
        Me.Label15.TabIndex = 38
        Me.Label15.Tag = "811"
        Me.Label15.Text = "Tinh chat"
        '
        'frminput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 462)
        Me.Controls.Add(Me.btnhuy)
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frminput"
        Me.Tag = "022"
        Me.Text = "frminput"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ptinh_theo_tk.ResumeLayout(False)
        Me.ptinh_theo_tk.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLuu As System.Windows.Forms.Button
    Friend WithEvents btnhuy As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtcach_tinh As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbbkind As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ptinh_theo_tk As System.Windows.Forms.Panel
    Friend WithEvents chbthue_suat As System.Windows.Forms.CheckBox
    Friend WithEvents ten_thue As System.Windows.Forms.Label
    Friend WithEvents txtma_thue As System.Windows.Forms.TextBox
    Friend WithEvents cbbdbf As System.Windows.Forms.ComboBox
    Friend WithEvents txttk_co As System.Windows.Forms.TextBox
    Friend WithEvents txttk_no As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbbtype As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtma_so02 As System.Windows.Forms.TextBox
    Friend WithEvents txtstt_in As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chbbold As System.Windows.Forms.CheckBox
    Friend WithEvents chbin_ck As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtma_so01 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtchi_tieu2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtchi_tieu As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtma_so As System.Windows.Forms.TextBox
    Friend WithEvents Txtstt As ClsControl2.TxtNumeric
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtma_tc As System.Windows.Forms.TextBox
End Class
