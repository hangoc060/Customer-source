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
        Me.ten_bp = New System.Windows.Forms.Label
        Me.txtma_bp = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txttk_no = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.ten_tk_dd = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txttk_co = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txttk_dd = New System.Windows.Forms.TextBox
        Me.txtcong_tru = New System.Windows.Forms.NumericUpDown
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.chbpb_ytcp = New System.Windows.Forms.RadioButton
        Me.chbpb_sl = New System.Windows.Forms.RadioButton
        Me.chbpb_kg = New System.Windows.Forms.RadioButton
        Me.groupytcp = New System.Windows.Forms.GroupBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txths_yt = New System.Windows.Forms.TextBox
        Me.txtgt_ps = New System.Windows.Forms.NumericUpDown
        Me.Label17 = New System.Windows.Forms.Label
        Me.ten_kieu_yt = New System.Windows.Forms.Label
        Me.ten_nh_yt = New System.Windows.Forms.Label
        Me.ten_loai_yt = New System.Windows.Forms.Label
        Me.chbdd_ck = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.chbth_kg = New System.Windows.Forms.RadioButton
        Me.chbth_bp = New System.Windows.Forms.RadioButton
        Me.chbth_bp0 = New System.Windows.Forms.RadioButton
        Me.chbth_lsx = New System.Windows.Forms.CheckBox
        Me.chbth_nvl = New System.Windows.Forms.CheckBox
        Me.chbth_sp = New System.Windows.Forms.CheckBox
        Me.txtkieu_yt = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtnh_yt = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtloai_yt = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.chbtrang_thai = New System.Windows.Forms.CheckBox
        Me.txtten_yt2 = New System.Windows.Forms.TextBox
        Me.txtten_yt = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtma_yt = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtnguoi_tao = New System.Windows.Forms.Label
        Me.txtngay_tao = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtngay_sua = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtnguoi_sua = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.chbyt_cg = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.txtcong_tru, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.groupytcp.SuspendLayout()
        CType(Me.txtgt_ps, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLuu
        '
        Me.btnLuu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLuu.Location = New System.Drawing.Point(3, 662)
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
        Me.btnhuy.Location = New System.Drawing.Point(59, 662)
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
        Me.GroupBox1.Controls.Add(Me.chbyt_cg)
        Me.GroupBox1.Controls.Add(Me.ten_bp)
        Me.GroupBox1.Controls.Add(Me.txtma_bp)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.ten_kieu_yt)
        Me.GroupBox1.Controls.Add(Me.ten_nh_yt)
        Me.GroupBox1.Controls.Add(Me.ten_loai_yt)
        Me.GroupBox1.Controls.Add(Me.chbdd_ck)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtkieu_yt)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtnh_yt)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtloai_yt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.chbtrang_thai)
        Me.GroupBox1.Controls.Add(Me.txtten_yt2)
        Me.GroupBox1.Controls.Add(Me.txtten_yt)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtma_yt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(-7, -7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(574, 656)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'ten_bp
        '
        Me.ten_bp.AutoSize = True
        Me.ten_bp.Location = New System.Drawing.Point(273, 171)
        Me.ten_bp.Name = "ten_bp"
        Me.ten_bp.Size = New System.Drawing.Size(76, 13)
        Me.ten_bp.TabIndex = 143
        Me.ten_bp.Text = "ten cong doan"
        '
        'txtma_bp
        '
        Me.txtma_bp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtma_bp.Location = New System.Drawing.Point(143, 167)
        Me.txtma_bp.Name = "txtma_bp"
        Me.txtma_bp.Size = New System.Drawing.Size(123, 20)
        Me.txtma_bp.TabIndex = 7
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(12, 171)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(59, 13)
        Me.Label20.TabIndex = 142
        Me.Label20.Tag = "080"
        Me.Label20.Text = "Cong doan"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txttk_no)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.ten_tk_dd)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txttk_co)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txttk_dd)
        Me.GroupBox3.Controls.Add(Me.txtcong_tru)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Location = New System.Drawing.Point(15, 204)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(542, 131)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Tag = "081"
        Me.GroupBox3.Text = "Phuong thuc tap hop chi phi"
        '
        'txttk_no
        '
        Me.txttk_no.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txttk_no.Location = New System.Drawing.Point(148, 47)
        Me.txttk_no.Name = "txttk_no"
        Me.txttk_no.Size = New System.Drawing.Size(337, 20)
        Me.txttk_no.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(20, 51)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 115
        Me.Label11.Tag = "008"
        Me.Label11.Text = "DS tk no"
        '
        'ten_tk_dd
        '
        Me.ten_tk_dd.AutoSize = True
        Me.ten_tk_dd.Location = New System.Drawing.Point(278, 103)
        Me.ten_tk_dd.Name = "ten_tk_dd"
        Me.ten_tk_dd.Size = New System.Drawing.Size(53, 13)
        Me.ten_tk_dd.TabIndex = 138
        Me.ten_tk_dd.Text = "Ten tk dd"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(20, 77)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 13)
        Me.Label12.TabIndex = 117
        Me.Label12.Tag = "009"
        Me.Label12.Text = "Ds tk co"
        '
        'txttk_co
        '
        Me.txttk_co.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txttk_co.Location = New System.Drawing.Point(148, 73)
        Me.txttk_co.Name = "txttk_co"
        Me.txttk_co.Size = New System.Drawing.Size(337, 20)
        Me.txttk_co.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(20, 103)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 13)
        Me.Label13.TabIndex = 119
        Me.Label13.Tag = "010"
        Me.Label13.Text = "TK do dang"
        '
        'txttk_dd
        '
        Me.txttk_dd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txttk_dd.Location = New System.Drawing.Point(148, 99)
        Me.txttk_dd.Name = "txttk_dd"
        Me.txttk_dd.Size = New System.Drawing.Size(123, 20)
        Me.txttk_dd.TabIndex = 10
        '
        'txtcong_tru
        '
        Me.txtcong_tru.Location = New System.Drawing.Point(148, 22)
        Me.txtcong_tru.Maximum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.txtcong_tru.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtcong_tru.Name = "txtcong_tru"
        Me.txtcong_tru.Size = New System.Drawing.Size(41, 20)
        Me.txtcong_tru.TabIndex = 7
        Me.txtcong_tru.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(20, 26)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 13)
        Me.Label14.TabIndex = 121
        Me.Label14.Tag = "007"
        Me.Label14.Text = "Cong them/giam tru"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(192, 26)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(118, 13)
        Me.Label15.TabIndex = 122
        Me.Label15.Tag = "020"
        Me.Label15.Text = "1-Cong them,2-Giam tru"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chbpb_ytcp)
        Me.GroupBox4.Controls.Add(Me.chbpb_sl)
        Me.GroupBox4.Controls.Add(Me.chbpb_kg)
        Me.GroupBox4.Controls.Add(Me.groupytcp)
        Me.GroupBox4.Location = New System.Drawing.Point(15, 441)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(542, 166)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Tag = "086"
        Me.GroupBox4.Text = "Phuong thuc phan bo"
        '
        'chbpb_ytcp
        '
        Me.chbpb_ytcp.AutoSize = True
        Me.chbpb_ytcp.Location = New System.Drawing.Point(21, 79)
        Me.chbpb_ytcp.Name = "chbpb_ytcp"
        Me.chbpb_ytcp.Size = New System.Drawing.Size(155, 17)
        Me.chbpb_ytcp.TabIndex = 135
        Me.chbpb_ytcp.TabStop = True
        Me.chbpb_ytcp.Tag = "089"
        Me.chbpb_ytcp.Text = "Phan bo theo yeu to chi phi"
        Me.chbpb_ytcp.UseVisualStyleBackColor = True
        '
        'chbpb_sl
        '
        Me.chbpb_sl.AutoSize = True
        Me.chbpb_sl.Location = New System.Drawing.Point(21, 51)
        Me.chbpb_sl.Name = "chbpb_sl"
        Me.chbpb_sl.Size = New System.Drawing.Size(121, 17)
        Me.chbpb_sl.TabIndex = 19
        Me.chbpb_sl.TabStop = True
        Me.chbpb_sl.Tag = "022"
        Me.chbpb_sl.Text = "khong theo bo phan"
        Me.chbpb_sl.UseVisualStyleBackColor = True
        '
        'chbpb_kg
        '
        Me.chbpb_kg.AutoSize = True
        Me.chbpb_kg.Location = New System.Drawing.Point(21, 23)
        Me.chbpb_kg.Name = "chbpb_kg"
        Me.chbpb_kg.Size = New System.Drawing.Size(121, 17)
        Me.chbpb_kg.TabIndex = 18
        Me.chbpb_kg.TabStop = True
        Me.chbpb_kg.Tag = "085"
        Me.chbpb_kg.Text = "khong theo bo phan"
        Me.chbpb_kg.UseVisualStyleBackColor = True
        '
        'groupytcp
        '
        Me.groupytcp.Controls.Add(Me.Label18)
        Me.groupytcp.Controls.Add(Me.Label16)
        Me.groupytcp.Controls.Add(Me.txths_yt)
        Me.groupytcp.Controls.Add(Me.txtgt_ps)
        Me.groupytcp.Controls.Add(Me.Label17)
        Me.groupytcp.Location = New System.Drawing.Point(6, 82)
        Me.groupytcp.Name = "groupytcp"
        Me.groupytcp.Size = New System.Drawing.Size(530, 78)
        Me.groupytcp.TabIndex = 17
        Me.groupytcp.TabStop = False
        Me.groupytcp.Tag = ""
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(14, 50)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(114, 13)
        Me.Label18.TabIndex = 133
        Me.Label18.Tag = "018"
        Me.Label18.Text = "Tinh hs pstk/gia thanh"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(14, 23)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(122, 13)
        Me.Label16.TabIndex = 131
        Me.Label16.Tag = "017"
        Me.Label16.Text = "Ds cac yeu to tinh he so"
        '
        'txths_yt
        '
        Me.txths_yt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txths_yt.Location = New System.Drawing.Point(145, 19)
        Me.txths_yt.Name = "txths_yt"
        Me.txths_yt.Size = New System.Drawing.Size(334, 20)
        Me.txths_yt.TabIndex = 13
        '
        'txtgt_ps
        '
        Me.txtgt_ps.Location = New System.Drawing.Point(145, 46)
        Me.txtgt_ps.Maximum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.txtgt_ps.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtgt_ps.Name = "txtgt_ps"
        Me.txtgt_ps.Size = New System.Drawing.Size(41, 20)
        Me.txtgt_ps.TabIndex = 14
        Me.txtgt_ps.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(199, 50)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(100, 13)
        Me.Label17.TabIndex = 134
        Me.Label17.Tag = "019"
        Me.Label17.Text = "1-pstk, 2- Gia thanh"
        '
        'ten_kieu_yt
        '
        Me.ten_kieu_yt.AutoSize = True
        Me.ten_kieu_yt.Location = New System.Drawing.Point(273, 145)
        Me.ten_kieu_yt.Name = "ten_kieu_yt"
        Me.ten_kieu_yt.Size = New System.Drawing.Size(60, 13)
        Me.ten_kieu_yt.TabIndex = 137
        Me.ten_kieu_yt.Text = "Kieu yeu to"
        '
        'ten_nh_yt
        '
        Me.ten_nh_yt.AutoSize = True
        Me.ten_nh_yt.Location = New System.Drawing.Point(273, 119)
        Me.ten_nh_yt.Name = "ten_nh_yt"
        Me.ten_nh_yt.Size = New System.Drawing.Size(66, 13)
        Me.ten_nh_yt.TabIndex = 136
        Me.ten_nh_yt.Text = "Ten nhom yt"
        '
        'ten_loai_yt
        '
        Me.ten_loai_yt.AutoSize = True
        Me.ten_loai_yt.Location = New System.Drawing.Point(273, 93)
        Me.ten_loai_yt.Name = "ten_loai_yt"
        Me.ten_loai_yt.Size = New System.Drawing.Size(45, 13)
        Me.ten_loai_yt.TabIndex = 135
        Me.ten_loai_yt.Text = "Ten loai"
        '
        'chbdd_ck
        '
        Me.chbdd_ck.AutoSize = True
        Me.chbdd_ck.Location = New System.Drawing.Point(272, 13)
        Me.chbdd_ck.Name = "chbdd_ck"
        Me.chbdd_ck.Size = New System.Drawing.Size(104, 17)
        Me.chbdd_ck.TabIndex = 123
        Me.chbdd_ck.Tag = "021"
        Me.chbdd_ck.Text = "Do dang cuoi ky"
        Me.chbdd_ck.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chbth_kg)
        Me.GroupBox2.Controls.Add(Me.chbth_bp)
        Me.GroupBox2.Controls.Add(Me.chbth_bp0)
        Me.GroupBox2.Controls.Add(Me.chbth_lsx)
        Me.GroupBox2.Controls.Add(Me.chbth_nvl)
        Me.GroupBox2.Controls.Add(Me.chbth_sp)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 342)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(542, 93)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Tag = "011"
        Me.GroupBox2.Text = "Kieu tap hop chi phi"
        '
        'chbth_kg
        '
        Me.chbth_kg.AutoSize = True
        Me.chbth_kg.Location = New System.Drawing.Point(257, 71)
        Me.chbth_kg.Name = "chbth_kg"
        Me.chbth_kg.Size = New System.Drawing.Size(121, 17)
        Me.chbth_kg.TabIndex = 5
        Me.chbth_kg.TabStop = True
        Me.chbth_kg.Tag = "087"
        Me.chbth_kg.Text = "khong theo bo phan"
        Me.chbth_kg.UseVisualStyleBackColor = True
        '
        'chbth_bp
        '
        Me.chbth_bp.AutoSize = True
        Me.chbth_bp.Location = New System.Drawing.Point(257, 48)
        Me.chbth_bp.Name = "chbth_bp"
        Me.chbth_bp.Size = New System.Drawing.Size(77, 17)
        Me.chbth_bp.TabIndex = 3
        Me.chbth_bp.TabStop = True
        Me.chbth_bp.Tag = "015"
        Me.chbth_bp.Text = "Cong doan"
        Me.chbth_bp.UseVisualStyleBackColor = True
        '
        'chbth_bp0
        '
        Me.chbth_bp0.AutoSize = True
        Me.chbth_bp0.Location = New System.Drawing.Point(257, 25)
        Me.chbth_bp0.Name = "chbth_bp0"
        Me.chbth_bp0.Size = New System.Drawing.Size(114, 17)
        Me.chbth_bp0.TabIndex = 1
        Me.chbth_bp0.TabStop = True
        Me.chbth_bp0.Tag = "013"
        Me.chbth_bp0.Text = "bo phan trung gian"
        Me.chbth_bp0.UseVisualStyleBackColor = True
        '
        'chbth_lsx
        '
        Me.chbth_lsx.AutoSize = True
        Me.chbth_lsx.Location = New System.Drawing.Point(21, 48)
        Me.chbth_lsx.Name = "chbth_lsx"
        Me.chbth_lsx.Size = New System.Drawing.Size(93, 17)
        Me.chbth_lsx.TabIndex = 2
        Me.chbth_lsx.Tag = "014"
        Me.chbth_lsx.Text = "Lenh san xuat"
        Me.chbth_lsx.UseVisualStyleBackColor = True
        '
        'chbth_nvl
        '
        Me.chbth_nvl.AutoSize = True
        Me.chbth_nvl.Location = New System.Drawing.Point(21, 71)
        Me.chbth_nvl.Name = "chbth_nvl"
        Me.chbth_nvl.Size = New System.Drawing.Size(114, 17)
        Me.chbth_nvl.TabIndex = 4
        Me.chbth_nvl.Tag = "016"
        Me.chbth_nvl.Text = "Tap hop theo NVL"
        Me.chbth_nvl.UseVisualStyleBackColor = True
        '
        'chbth_sp
        '
        Me.chbth_sp.AutoSize = True
        Me.chbth_sp.Location = New System.Drawing.Point(21, 25)
        Me.chbth_sp.Name = "chbth_sp"
        Me.chbth_sp.Size = New System.Drawing.Size(111, 17)
        Me.chbth_sp.TabIndex = 0
        Me.chbth_sp.Tag = "012"
        Me.chbth_sp.Text = "tap hop san pham"
        Me.chbth_sp.UseVisualStyleBackColor = True
        '
        'txtkieu_yt
        '
        Me.txtkieu_yt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtkieu_yt.Location = New System.Drawing.Point(143, 141)
        Me.txtkieu_yt.Name = "txtkieu_yt"
        Me.txtkieu_yt.Size = New System.Drawing.Size(123, 20)
        Me.txtkieu_yt.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 145)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 113
        Me.Label9.Tag = "006"
        Me.Label9.Text = "Kieu yt"
        '
        'txtnh_yt
        '
        Me.txtnh_yt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnh_yt.Location = New System.Drawing.Point(143, 115)
        Me.txtnh_yt.Name = "txtnh_yt"
        Me.txtnh_yt.Size = New System.Drawing.Size(123, 20)
        Me.txtnh_yt.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 111
        Me.Label7.Tag = "005"
        Me.Label7.Text = "Nhom yt"
        '
        'txtloai_yt
        '
        Me.txtloai_yt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtloai_yt.Location = New System.Drawing.Point(143, 89)
        Me.txtloai_yt.Name = "txtloai_yt"
        Me.txtloai_yt.Size = New System.Drawing.Size(123, 20)
        Me.txtloai_yt.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 109
        Me.Label2.Tag = "004"
        Me.Label2.Text = "Loai yt"
        '
        'chbtrang_thai
        '
        Me.chbtrang_thai.AutoSize = True
        Me.chbtrang_thai.Location = New System.Drawing.Point(36, 632)
        Me.chbtrang_thai.Name = "chbtrang_thai"
        Me.chbtrang_thai.Size = New System.Drawing.Size(74, 17)
        Me.chbtrang_thai.TabIndex = 18
        Me.chbtrang_thai.Tag = "088"
        Me.chbtrang_thai.Text = "Trang thai"
        Me.chbtrang_thai.UseVisualStyleBackColor = True
        '
        'txtten_yt2
        '
        Me.txtten_yt2.Location = New System.Drawing.Point(143, 63)
        Me.txtten_yt2.Name = "txtten_yt2"
        Me.txtten_yt2.Size = New System.Drawing.Size(370, 20)
        Me.txtten_yt2.TabIndex = 3
        '
        'txtten_yt
        '
        Me.txtten_yt.Location = New System.Drawing.Point(143, 37)
        Me.txtten_yt.Name = "txtten_yt"
        Me.txtten_yt.Size = New System.Drawing.Size(370, 20)
        Me.txtten_yt.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 41)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 13)
        Me.Label10.TabIndex = 107
        Me.Label10.Tag = "002"
        Me.Label10.Text = "Ten"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Tag = "003"
        Me.Label4.Text = "Ten 2"
        '
        'txtma_yt
        '
        Me.txtma_yt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtma_yt.Location = New System.Drawing.Point(143, 11)
        Me.txtma_yt.Name = "txtma_yt"
        Me.txtma_yt.Size = New System.Drawing.Size(123, 20)
        Me.txtma_yt.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Tag = "001"
        Me.Label1.Text = "Ma"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(0, 699)
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
        Me.txtnguoi_tao.Location = New System.Drawing.Point(67, 699)
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
        Me.txtngay_tao.Location = New System.Drawing.Point(225, 699)
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
        Me.Label6.Location = New System.Drawing.Point(158, 699)
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
        Me.txtngay_sua.Location = New System.Drawing.Point(225, 714)
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
        Me.Label5.Location = New System.Drawing.Point(158, 714)
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
        Me.txtnguoi_sua.Location = New System.Drawing.Point(67, 714)
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
        Me.Label8.Location = New System.Drawing.Point(0, 714)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Tag = "091"
        Me.Label8.Text = "Nguoi sua:"
        '
        'chbyt_cg
        '
        Me.chbyt_cg.AutoSize = True
        Me.chbyt_cg.Location = New System.Drawing.Point(36, 611)
        Me.chbyt_cg.Name = "chbyt_cg"
        Me.chbyt_cg.Size = New System.Drawing.Size(105, 17)
        Me.chbyt_cg.TabIndex = 144
        Me.chbyt_cg.TabStop = False
        Me.chbyt_cg.Tag = "811"
        Me.chbyt_cg.Text = "yếu tố trung gian"
        Me.chbyt_cg.UseVisualStyleBackColor = True
        '
        'frminput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 733)
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
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.txtcong_tru, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.groupytcp.ResumeLayout(False)
        Me.groupytcp.PerformLayout()
        CType(Me.txtgt_ps, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
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
    Friend WithEvents txtma_yt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtten_yt As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtten_yt2 As System.Windows.Forms.TextBox
    Friend WithEvents chbtrang_thai As System.Windows.Forms.CheckBox
    Friend WithEvents txttk_dd As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txttk_co As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txttk_no As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtkieu_yt As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtnh_yt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtloai_yt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtcong_tru As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chbdd_ck As System.Windows.Forms.CheckBox
    Friend WithEvents chbth_lsx As System.Windows.Forms.CheckBox
    Friend WithEvents chbth_nvl As System.Windows.Forms.CheckBox
    Friend WithEvents chbth_sp As System.Windows.Forms.CheckBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtgt_ps As System.Windows.Forms.NumericUpDown
    Friend WithEvents txths_yt As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ten_kieu_yt As System.Windows.Forms.Label
    Friend WithEvents ten_nh_yt As System.Windows.Forms.Label
    Friend WithEvents ten_loai_yt As System.Windows.Forms.Label
    Friend WithEvents ten_tk_dd As System.Windows.Forms.Label
    Friend WithEvents chbth_bp As System.Windows.Forms.RadioButton
    Friend WithEvents chbth_bp0 As System.Windows.Forms.RadioButton
    Friend WithEvents groupytcp As System.Windows.Forms.GroupBox
    Friend WithEvents chbth_kg As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents chbpb_kg As System.Windows.Forms.RadioButton
    Friend WithEvents chbpb_sl As System.Windows.Forms.RadioButton
    Friend WithEvents chbpb_ytcp As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ten_bp As System.Windows.Forms.Label
    Friend WithEvents txtma_bp As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents chbyt_cg As System.Windows.Forms.CheckBox
End Class
