<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmmain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmmain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.mnfile = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.lbluser = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.lbllines = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripmain = New System.Windows.Forms.ToolStrip
        Me.ToolStripfind = New System.Windows.Forms.ToolStrip
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.grd = New System.Windows.Forms.DataGridView
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.thong_tin_chung = New System.Windows.Forms.TabPage
        Me.txtdien_thoai = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtdia_chi = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.chbtrang_thai = New System.Windows.Forms.CheckBox
        Me.ten_nh3 = New System.Windows.Forms.Label
        Me.txtnh_kh3 = New System.Windows.Forms.TextBox
        Me.Label35 = New System.Windows.Forms.Label
        Me.ten_nh2 = New System.Windows.Forms.Label
        Me.txtnh_kh2 = New System.Windows.Forms.TextBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.ten_nh1 = New System.Windows.Forms.Label
        Me.txtnh_kh1 = New System.Windows.Forms.TextBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.lblten_tk = New System.Windows.Forms.Label
        Me.txttk_cn = New System.Windows.Forms.TextBox
        Me.txtt_dm = New ClsControl2.TxtNumeric
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.lblten_loai_kh = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtngay_tl = New ClsControl2.TxtDate
        Me.txtma_loai_kh = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtma_so_thue = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtma_kh = New System.Windows.Forms.TextBox
        Me.txtten_kh = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.thong_tin_pha_tich = New System.Windows.Forms.TabPage
        Me.Label42 = New System.Windows.Forms.Label
        Me.txtngay_tc = New ClsControl2.TxtDate
        Me.txtten_kh2 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtdai_dien_pl = New System.Windows.Forms.TextBox
        Me.txtten_dn = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.lblten_dt_ct = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.txtten_gd = New System.Windows.Forms.TextBox
        Me.txtly_do_c_ncc = New System.Windows.Forms.TextBox
        Me.txthtsh = New System.Windows.Forms.TextBox
        Me.txtma_dt_ct = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.lblten_ly_do_c_ncc = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Txtgia_ct = New ClsControl2.TxtNumeric
        Me.txtlhkd = New System.Windows.Forms.TextBox
        Me.txtvon_kd = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.lblten_td = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.txtlvkd = New System.Windows.Forms.TextBox
        Me.txtma_td = New System.Windows.Forms.TextBox
        Me.tabother = New System.Windows.Forms.TabPage
        Me.txttd3 = New System.Windows.Forms.TextBox
        Me.Label41 = New System.Windows.Forms.Label
        Me.txttd2 = New System.Windows.Forms.TextBox
        Me.Label40 = New System.Windows.Forms.Label
        Me.txttd1 = New System.Windows.Forms.TextBox
        Me.Label39 = New System.Windows.Forms.Label
        Me.txtso_cmnd = New System.Windows.Forms.TextBox
        Me.Label38 = New System.Windows.Forms.Label
        Me.txtten_nh = New System.Windows.Forms.TextBox
        Me.Label33 = New System.Windows.Forms.Label
        Me.txttk_nh = New System.Windows.Forms.TextBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.lblten_nv = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtma_nv_lh = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtwebsite = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtma_tinh_thanh = New System.Windows.Forms.TextBox
        Me.txtemail = New System.Windows.Forms.TextBox
        Me.lblten_tinh_thanh = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtma_qg = New System.Windows.Forms.TextBox
        Me.txtfax = New System.Windows.Forms.TextBox
        Me.lblten_qg = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtma_quan_huyen = New System.Windows.Forms.TextBox
        Me.lblten_quan_huyen = New System.Windows.Forms.Label
        Me.thong_tin_lien_he = New System.Windows.Forms.TabPage
        Me.gridlh = New System.Windows.Forms.DataGridView
        Me.bar_lh = New System.Windows.Forms.ToolStrip
        Me.hop_dong = New System.Windows.Forms.TabPage
        Me.bar_hd = New System.Windows.Forms.ToolStrip
        Me.grdhop_dong = New System.Windows.Forms.DataGridView
        Me.actives = New System.Windows.Forms.TabPage
        Me.gridactives = New System.Windows.Forms.DataGridView
        Me.toolbaractives = New System.Windows.Forms.ToolStrip
        Me.btnnewactive = New System.Windows.Forms.ToolStripButton
        Me.btnupdateactive = New System.Windows.Forms.ToolStripButton
        Me.btndeleteactive = New System.Windows.Forms.ToolStripButton
        Me.documents = New System.Windows.Forms.TabPage
        Me.toolbardocuments = New System.Windows.Forms.ToolStrip
        Me.btnadddoc = New System.Windows.Forms.ToolStripButton
        Me.btnupdatedoc = New System.Windows.Forms.ToolStripButton
        Me.btndeletedoc = New System.Windows.Forms.ToolStripButton
        Me.btnviewfile = New System.Windows.Forms.ToolStripButton
        Me.griddocuments = New System.Windows.Forms.DataGridView
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.grd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.thong_tin_chung.SuspendLayout()
        Me.thong_tin_pha_tich.SuspendLayout()
        Me.tabother.SuspendLayout()
        Me.thong_tin_lien_he.SuspendLayout()
        CType(Me.gridlh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hop_dong.SuspendLayout()
        CType(Me.grdhop_dong, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.actives.SuspendLayout()
        CType(Me.gridactives, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolbaractives.SuspendLayout()
        Me.documents.SuspendLayout()
        Me.toolbardocuments.SuspendLayout()
        CType(Me.griddocuments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnfile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(900, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnfile
        '
        Me.mnfile.Name = "mnfile"
        Me.mnfile.Size = New System.Drawing.Size(77, 20)
        Me.mnfile.Tag = "100"
        Me.mnfile.Text = "Chuc nang"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbluser, Me.ToolStripStatusLabel1, Me.lbllines})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 552)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(900, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lbluser
        '
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(29, 17)
        Me.lbluser.Text = "user"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(856, 17)
        Me.ToolStripStatusLabel1.Spring = True
        '
        'lbllines
        '
        Me.lbllines.Name = "lbllines"
        Me.lbllines.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripmain
        '
        Me.ToolStripmain.Location = New System.Drawing.Point(0, 24)
        Me.ToolStripmain.Name = "ToolStripmain"
        Me.ToolStripmain.Size = New System.Drawing.Size(900, 25)
        Me.ToolStripmain.TabIndex = 2
        Me.ToolStripmain.Text = "ToolStrip1"
        '
        'ToolStripfind
        '
        Me.ToolStripfind.Location = New System.Drawing.Point(0, 49)
        Me.ToolStripfind.Name = "ToolStripfind"
        Me.ToolStripfind.Size = New System.Drawing.Size(900, 25)
        Me.ToolStripfind.TabIndex = 3
        Me.ToolStripfind.Text = "ToolStrip2"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 74)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.grd)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(900, 478)
        Me.SplitContainer1.SplitterDistance = 166
        Me.SplitContainer1.TabIndex = 6
        '
        'grd
        '
        Me.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grd.GridColor = System.Drawing.SystemColors.Control
        Me.grd.Location = New System.Drawing.Point(0, 0)
        Me.grd.Name = "grd"
        Me.grd.RowHeadersVisible = False
        Me.grd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grd.Size = New System.Drawing.Size(900, 166)
        Me.grd.TabIndex = 6
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.thong_tin_chung)
        Me.TabControl1.Controls.Add(Me.thong_tin_pha_tich)
        Me.TabControl1.Controls.Add(Me.tabother)
        Me.TabControl1.Controls.Add(Me.thong_tin_lien_he)
        Me.TabControl1.Controls.Add(Me.hop_dong)
        Me.TabControl1.Controls.Add(Me.actives)
        Me.TabControl1.Controls.Add(Me.documents)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(900, 308)
        Me.TabControl1.TabIndex = 23
        '
        'thong_tin_chung
        '
        Me.thong_tin_chung.AutoScroll = True
        Me.thong_tin_chung.BackColor = System.Drawing.Color.Transparent
        Me.thong_tin_chung.Controls.Add(Me.txtdien_thoai)
        Me.thong_tin_chung.Controls.Add(Me.Label6)
        Me.thong_tin_chung.Controls.Add(Me.txtdia_chi)
        Me.thong_tin_chung.Controls.Add(Me.Label4)
        Me.thong_tin_chung.Controls.Add(Me.chbtrang_thai)
        Me.thong_tin_chung.Controls.Add(Me.ten_nh3)
        Me.thong_tin_chung.Controls.Add(Me.txtnh_kh3)
        Me.thong_tin_chung.Controls.Add(Me.Label35)
        Me.thong_tin_chung.Controls.Add(Me.ten_nh2)
        Me.thong_tin_chung.Controls.Add(Me.txtnh_kh2)
        Me.thong_tin_chung.Controls.Add(Me.Label32)
        Me.thong_tin_chung.Controls.Add(Me.ten_nh1)
        Me.thong_tin_chung.Controls.Add(Me.txtnh_kh1)
        Me.thong_tin_chung.Controls.Add(Me.Label30)
        Me.thong_tin_chung.Controls.Add(Me.lblten_tk)
        Me.thong_tin_chung.Controls.Add(Me.txttk_cn)
        Me.thong_tin_chung.Controls.Add(Me.txtt_dm)
        Me.thong_tin_chung.Controls.Add(Me.Label37)
        Me.thong_tin_chung.Controls.Add(Me.Label36)
        Me.thong_tin_chung.Controls.Add(Me.lblten_loai_kh)
        Me.thong_tin_chung.Controls.Add(Me.Label1)
        Me.thong_tin_chung.Controls.Add(Me.txtngay_tl)
        Me.thong_tin_chung.Controls.Add(Me.txtma_loai_kh)
        Me.thong_tin_chung.Controls.Add(Me.Label21)
        Me.thong_tin_chung.Controls.Add(Me.txtma_so_thue)
        Me.thong_tin_chung.Controls.Add(Me.Label20)
        Me.thong_tin_chung.Controls.Add(Me.Label9)
        Me.thong_tin_chung.Controls.Add(Me.txtma_kh)
        Me.thong_tin_chung.Controls.Add(Me.txtten_kh)
        Me.thong_tin_chung.Controls.Add(Me.Label10)
        Me.thong_tin_chung.Location = New System.Drawing.Point(4, 22)
        Me.thong_tin_chung.Name = "thong_tin_chung"
        Me.thong_tin_chung.Padding = New System.Windows.Forms.Padding(3)
        Me.thong_tin_chung.Size = New System.Drawing.Size(892, 282)
        Me.thong_tin_chung.TabIndex = 0
        Me.thong_tin_chung.Text = "Thông tin chính"
        Me.thong_tin_chung.UseVisualStyleBackColor = True
        '
        'txtdien_thoai
        '
        Me.txtdien_thoai.Location = New System.Drawing.Point(139, 48)
        Me.txtdien_thoai.Name = "txtdien_thoai"
        Me.txtdien_thoai.Size = New System.Drawing.Size(378, 20)
        Me.txtdien_thoai.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 226
        Me.Label6.Tag = "006"
        Me.Label6.Text = "Dien thoai"
        '
        'txtdia_chi
        '
        Me.txtdia_chi.Location = New System.Drawing.Point(139, 69)
        Me.txtdia_chi.Name = "txtdia_chi"
        Me.txtdia_chi.Size = New System.Drawing.Size(378, 20)
        Me.txtdia_chi.TabIndex = 202
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 224
        Me.Label4.Tag = "005"
        Me.Label4.Text = "dia chi"
        '
        'chbtrang_thai
        '
        Me.chbtrang_thai.AutoSize = True
        Me.chbtrang_thai.Location = New System.Drawing.Point(139, 240)
        Me.chbtrang_thai.Name = "chbtrang_thai"
        Me.chbtrang_thai.Size = New System.Drawing.Size(86, 17)
        Me.chbtrang_thai.TabIndex = 210
        Me.chbtrang_thai.Tag = "STU"
        Me.chbtrang_thai.Text = "Còn sử dụng"
        Me.chbtrang_thai.UseVisualStyleBackColor = True
        '
        'ten_nh3
        '
        Me.ten_nh3.AutoSize = True
        Me.ten_nh3.Location = New System.Drawing.Point(248, 220)
        Me.ten_nh3.Name = "ten_nh3"
        Me.ten_nh3.Size = New System.Drawing.Size(43, 13)
        Me.ten_nh3.TabIndex = 223
        Me.ten_nh3.Tag = ""
        Me.ten_nh3.Text = "ten nh3"
        '
        'txtnh_kh3
        '
        Me.txtnh_kh3.Location = New System.Drawing.Point(139, 216)
        Me.txtnh_kh3.Name = "txtnh_kh3"
        Me.txtnh_kh3.Size = New System.Drawing.Size(100, 20)
        Me.txtnh_kh3.TabIndex = 209
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(7, 220)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(56, 13)
        Me.Label35.TabIndex = 222
        Me.Label35.Tag = "412"
        Me.Label35.Text = "Nhóm kh3"
        '
        'ten_nh2
        '
        Me.ten_nh2.AutoSize = True
        Me.ten_nh2.Location = New System.Drawing.Point(248, 199)
        Me.ten_nh2.Name = "ten_nh2"
        Me.ten_nh2.Size = New System.Drawing.Size(43, 13)
        Me.ten_nh2.TabIndex = 221
        Me.ten_nh2.Tag = ""
        Me.ten_nh2.Text = "ten nh2"
        '
        'txtnh_kh2
        '
        Me.txtnh_kh2.Location = New System.Drawing.Point(139, 195)
        Me.txtnh_kh2.Name = "txtnh_kh2"
        Me.txtnh_kh2.Size = New System.Drawing.Size(100, 20)
        Me.txtnh_kh2.TabIndex = 208
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(7, 199)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(56, 13)
        Me.Label32.TabIndex = 220
        Me.Label32.Tag = "411"
        Me.Label32.Text = "Nhóm kh2"
        '
        'ten_nh1
        '
        Me.ten_nh1.AutoSize = True
        Me.ten_nh1.Location = New System.Drawing.Point(248, 178)
        Me.ten_nh1.Name = "ten_nh1"
        Me.ten_nh1.Size = New System.Drawing.Size(43, 13)
        Me.ten_nh1.TabIndex = 219
        Me.ten_nh1.Tag = ""
        Me.ten_nh1.Text = "ten nh1"
        '
        'txtnh_kh1
        '
        Me.txtnh_kh1.Location = New System.Drawing.Point(139, 174)
        Me.txtnh_kh1.Name = "txtnh_kh1"
        Me.txtnh_kh1.Size = New System.Drawing.Size(100, 20)
        Me.txtnh_kh1.TabIndex = 207
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(7, 178)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(56, 13)
        Me.Label30.TabIndex = 218
        Me.Label30.Tag = "409"
        Me.Label30.Text = "Nhóm kh1"
        '
        'lblten_tk
        '
        Me.lblten_tk.AutoSize = True
        Me.lblten_tk.Location = New System.Drawing.Point(248, 157)
        Me.lblten_tk.Name = "lblten_tk"
        Me.lblten_tk.Size = New System.Drawing.Size(37, 13)
        Me.lblten_tk.TabIndex = 217
        Me.lblten_tk.Text = "ten_tk"
        '
        'txttk_cn
        '
        Me.txttk_cn.Location = New System.Drawing.Point(139, 153)
        Me.txttk_cn.Name = "txttk_cn"
        Me.txttk_cn.Size = New System.Drawing.Size(100, 20)
        Me.txttk_cn.TabIndex = 206
        '
        'txtt_dm
        '
        Me.txtt_dm.Location = New System.Drawing.Point(139, 132)
        Me.txtt_dm.MaxLength = 18
        Me.txtt_dm.Name = "txtt_dm"
        Me.txtt_dm.NumberDecimalDigits = 2
        Me.txtt_dm.Size = New System.Drawing.Size(100, 20)
        Me.txtt_dm.TabIndex = 205
        Me.txtt_dm.Text = "0.00"
        Me.txtt_dm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtt_dm.Value = 0
        Me.txtt_dm.Value2 = 0
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(7, 157)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(97, 13)
        Me.Label37.TabIndex = 216
        Me.Label37.Tag = "011"
        Me.Label37.Text = "Tai khoan cong no"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(7, 136)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(52, 13)
        Me.Label36.TabIndex = 215
        Me.Label36.Tag = "010"
        Me.Label36.Text = "Dinh muc"
        '
        'lblten_loai_kh
        '
        Me.lblten_loai_kh.AutoSize = True
        Me.lblten_loai_kh.Location = New System.Drawing.Point(248, 115)
        Me.lblten_loai_kh.Name = "lblten_loai_kh"
        Me.lblten_loai_kh.Size = New System.Drawing.Size(45, 13)
        Me.lblten_loai_kh.TabIndex = 214
        Me.lblten_loai_kh.Tag = ""
        Me.lblten_loai_kh.Text = "Tên loại"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(312, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 213
        Me.Label1.Tag = "209"
        Me.Label1.Text = "Ngày thành lập"
        '
        'txtngay_tl
        '
        Me.txtngay_tl.Location = New System.Drawing.Point(417, 90)
        Me.txtngay_tl.Mask = "00/00/0000"
        Me.txtngay_tl.Name = "txtngay_tl"
        Me.txtngay_tl.Size = New System.Drawing.Size(100, 20)
        Me.txtngay_tl.TabIndex = 203
        Me.txtngay_tl.Text = "24112009"
        Me.txtngay_tl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtngay_tl.Value = New Date(2009, 11, 24, 0, 0, 0, 0)
        '
        'txtma_loai_kh
        '
        Me.txtma_loai_kh.Location = New System.Drawing.Point(139, 111)
        Me.txtma_loai_kh.Name = "txtma_loai_kh"
        Me.txtma_loai_kh.Size = New System.Drawing.Size(100, 20)
        Me.txtma_loai_kh.TabIndex = 204
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(7, 115)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(27, 13)
        Me.Label21.TabIndex = 212
        Me.Label21.Tag = "208"
        Me.Label21.Text = "Loại"
        '
        'txtma_so_thue
        '
        Me.txtma_so_thue.Location = New System.Drawing.Point(139, 90)
        Me.txtma_so_thue.Name = "txtma_so_thue"
        Me.txtma_so_thue.Size = New System.Drawing.Size(161, 20)
        Me.txtma_so_thue.TabIndex = 201
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(7, 94)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(60, 13)
        Me.Label20.TabIndex = 211
        Me.Label20.Tag = "203"
        Me.Label20.Text = "Ma so thue"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(22, 13)
        Me.Label9.TabIndex = 199
        Me.Label9.Tag = "001"
        Me.Label9.Text = "Ma"
        '
        'txtma_kh
        '
        Me.txtma_kh.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtma_kh.Location = New System.Drawing.Point(139, 6)
        Me.txtma_kh.Name = "txtma_kh"
        Me.txtma_kh.Size = New System.Drawing.Size(103, 20)
        Me.txtma_kh.TabIndex = 2
        '
        'txtten_kh
        '
        Me.txtten_kh.Location = New System.Drawing.Point(139, 27)
        Me.txtten_kh.Name = "txtten_kh"
        Me.txtten_kh.Size = New System.Drawing.Size(378, 20)
        Me.txtten_kh.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 13)
        Me.Label10.TabIndex = 195
        Me.Label10.Tag = "002"
        Me.Label10.Text = "Ten"
        '
        'thong_tin_pha_tich
        '
        Me.thong_tin_pha_tich.AutoScroll = True
        Me.thong_tin_pha_tich.BackColor = System.Drawing.Color.Transparent
        Me.thong_tin_pha_tich.Controls.Add(Me.Label42)
        Me.thong_tin_pha_tich.Controls.Add(Me.txtngay_tc)
        Me.thong_tin_pha_tich.Controls.Add(Me.txtten_kh2)
        Me.thong_tin_pha_tich.Controls.Add(Me.Label7)
        Me.thong_tin_pha_tich.Controls.Add(Me.txtdai_dien_pl)
        Me.thong_tin_pha_tich.Controls.Add(Me.txtten_dn)
        Me.thong_tin_pha_tich.Controls.Add(Me.Label15)
        Me.thong_tin_pha_tich.Controls.Add(Me.Label28)
        Me.thong_tin_pha_tich.Controls.Add(Me.Label18)
        Me.thong_tin_pha_tich.Controls.Add(Me.lblten_dt_ct)
        Me.thong_tin_pha_tich.Controls.Add(Me.Label22)
        Me.thong_tin_pha_tich.Controls.Add(Me.Label27)
        Me.thong_tin_pha_tich.Controls.Add(Me.txtten_gd)
        Me.thong_tin_pha_tich.Controls.Add(Me.txtly_do_c_ncc)
        Me.thong_tin_pha_tich.Controls.Add(Me.txthtsh)
        Me.thong_tin_pha_tich.Controls.Add(Me.txtma_dt_ct)
        Me.thong_tin_pha_tich.Controls.Add(Me.Label16)
        Me.thong_tin_pha_tich.Controls.Add(Me.lblten_ly_do_c_ncc)
        Me.thong_tin_pha_tich.Controls.Add(Me.Label23)
        Me.thong_tin_pha_tich.Controls.Add(Me.Label26)
        Me.thong_tin_pha_tich.Controls.Add(Me.Txtgia_ct)
        Me.thong_tin_pha_tich.Controls.Add(Me.txtlhkd)
        Me.thong_tin_pha_tich.Controls.Add(Me.txtvon_kd)
        Me.thong_tin_pha_tich.Controls.Add(Me.Label24)
        Me.thong_tin_pha_tich.Controls.Add(Me.Label34)
        Me.thong_tin_pha_tich.Controls.Add(Me.lblten_td)
        Me.thong_tin_pha_tich.Controls.Add(Me.Label25)
        Me.thong_tin_pha_tich.Controls.Add(Me.txtlvkd)
        Me.thong_tin_pha_tich.Controls.Add(Me.txtma_td)
        Me.thong_tin_pha_tich.Location = New System.Drawing.Point(4, 22)
        Me.thong_tin_pha_tich.Name = "thong_tin_pha_tich"
        Me.thong_tin_pha_tich.Size = New System.Drawing.Size(892, 282)
        Me.thong_tin_pha_tich.TabIndex = 2
        Me.thong_tin_pha_tich.Text = "Thông tin phân tích"
        Me.thong_tin_pha_tich.UseVisualStyleBackColor = True
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(7, 260)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(73, 13)
        Me.Label42.TabIndex = 204
        Me.Label42.Tag = "NTC"
        Me.Label42.Text = "Ngày tiếp cận"
        '
        'txtngay_tc
        '
        Me.txtngay_tc.Location = New System.Drawing.Point(160, 257)
        Me.txtngay_tc.Mask = "00/00/0000"
        Me.txtngay_tc.Name = "txtngay_tc"
        Me.txtngay_tc.Size = New System.Drawing.Size(100, 20)
        Me.txtngay_tc.TabIndex = 203
        Me.txtngay_tc.Text = "24112009"
        Me.txtngay_tc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtngay_tc.Value = New Date(2009, 11, 24, 0, 0, 0, 0)
        '
        'txtten_kh2
        '
        Me.txtten_kh2.Location = New System.Drawing.Point(160, 5)
        Me.txtten_kh2.Name = "txtten_kh2"
        Me.txtten_kh2.Size = New System.Drawing.Size(367, 20)
        Me.txtten_kh2.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 202
        Me.Label7.Tag = "413"
        Me.Label7.Text = "Ten 2"
        '
        'txtdai_dien_pl
        '
        Me.txtdai_dien_pl.Location = New System.Drawing.Point(160, 68)
        Me.txtdai_dien_pl.Name = "txtdai_dien_pl"
        Me.txtdai_dien_pl.Size = New System.Drawing.Size(367, 20)
        Me.txtdai_dien_pl.TabIndex = 119
        '
        'txtten_dn
        '
        Me.txtten_dn.Location = New System.Drawing.Point(160, 26)
        Me.txtten_dn.Name = "txtten_dn"
        Me.txtten_dn.Size = New System.Drawing.Size(367, 20)
        Me.txtten_dn.TabIndex = 117
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(7, 30)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 13)
        Me.Label15.TabIndex = 139
        Me.Label15.Tag = "200"
        Me.Label15.Text = "Ten doi ngoai"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(7, 219)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(129, 13)
        Me.Label28.TabIndex = 134
        Me.Label28.Tag = "216"
        Me.Label28.Text = "Lý do chọn nhà cung cáp"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(7, 72)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(83, 13)
        Me.Label18.TabIndex = 141
        Me.Label18.Tag = "202"
        Me.Label18.Text = "Đại diện pháp lý"
        '
        'lblten_dt_ct
        '
        Me.lblten_dt_ct.AutoSize = True
        Me.lblten_dt_ct.Location = New System.Drawing.Point(267, 177)
        Me.lblten_dt_ct.Name = "lblten_dt_ct"
        Me.lblten_dt_ct.Size = New System.Drawing.Size(62, 13)
        Me.lblten_dt_ct.TabIndex = 135
        Me.lblten_dt_ct.Tag = ""
        Me.lblten_dt_ct.Text = "Tên đối thủ"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(7, 93)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(88, 13)
        Me.Label22.TabIndex = 128
        Me.Label22.Tag = "210"
        Me.Label22.Text = "Hình thức sở hữu"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(7, 198)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(77, 13)
        Me.Label27.TabIndex = 133
        Me.Label27.Tag = "215"
        Me.Label27.Text = "Giá cạnh tranh"
        '
        'txtten_gd
        '
        Me.txtten_gd.Location = New System.Drawing.Point(160, 47)
        Me.txtten_gd.Name = "txtten_gd"
        Me.txtten_gd.Size = New System.Drawing.Size(367, 20)
        Me.txtten_gd.TabIndex = 118
        '
        'txtly_do_c_ncc
        '
        Me.txtly_do_c_ncc.Location = New System.Drawing.Point(160, 215)
        Me.txtly_do_c_ncc.Name = "txtly_do_c_ncc"
        Me.txtly_do_c_ncc.Size = New System.Drawing.Size(100, 20)
        Me.txtly_do_c_ncc.TabIndex = 126
        '
        'txthtsh
        '
        Me.txthtsh.Location = New System.Drawing.Point(160, 89)
        Me.txthtsh.Name = "txthtsh"
        Me.txthtsh.Size = New System.Drawing.Size(367, 20)
        Me.txthtsh.TabIndex = 120
        '
        'txtma_dt_ct
        '
        Me.txtma_dt_ct.Location = New System.Drawing.Point(160, 173)
        Me.txtma_dt_ct.Name = "txtma_dt_ct"
        Me.txtma_dt_ct.Size = New System.Drawing.Size(100, 20)
        Me.txtma_dt_ct.TabIndex = 124
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(7, 51)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 13)
        Me.Label16.TabIndex = 140
        Me.Label16.Tag = "201"
        Me.Label16.Text = "Ten giao dich"
        '
        'lblten_ly_do_c_ncc
        '
        Me.lblten_ly_do_c_ncc.AutoSize = True
        Me.lblten_ly_do_c_ncc.Location = New System.Drawing.Point(267, 219)
        Me.lblten_ly_do_c_ncc.Name = "lblten_ly_do_c_ncc"
        Me.lblten_ly_do_c_ncc.Size = New System.Drawing.Size(147, 13)
        Me.lblten_ly_do_c_ncc.TabIndex = 136
        Me.lblten_ly_do_c_ncc.Tag = ""
        Me.lblten_ly_do_c_ncc.Text = "Tên lý do chọn nhà cung cấp"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(7, 114)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(106, 13)
        Me.Label23.TabIndex = 129
        Me.Label23.Tag = "211"
        Me.Label23.Text = "Loại hình kinh doanh"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(7, 177)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(95, 13)
        Me.Label26.TabIndex = 132
        Me.Label26.Tag = "214"
        Me.Label26.Text = "Đối thủ cạnh tranh"
        '
        'Txtgia_ct
        '
        Me.Txtgia_ct.Location = New System.Drawing.Point(160, 194)
        Me.Txtgia_ct.MaxLength = 0
        Me.Txtgia_ct.Name = "Txtgia_ct"
        Me.Txtgia_ct.NumberDecimalDigits = 2
        Me.Txtgia_ct.Size = New System.Drawing.Size(100, 20)
        Me.Txtgia_ct.TabIndex = 125
        Me.Txtgia_ct.Tag = "23"
        Me.Txtgia_ct.Text = "0.00"
        Me.Txtgia_ct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txtgia_ct.Value = 0
        Me.Txtgia_ct.Value2 = 0
        '
        'txtlhkd
        '
        Me.txtlhkd.Location = New System.Drawing.Point(160, 110)
        Me.txtlhkd.Name = "txtlhkd"
        Me.txtlhkd.Size = New System.Drawing.Size(367, 20)
        Me.txtlhkd.TabIndex = 121
        '
        'txtvon_kd
        '
        Me.txtvon_kd.Location = New System.Drawing.Point(160, 152)
        Me.txtvon_kd.Name = "txtvon_kd"
        Me.txtvon_kd.Size = New System.Drawing.Size(100, 20)
        Me.txtvon_kd.TabIndex = 123
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(7, 135)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(107, 13)
        Me.Label24.TabIndex = 130
        Me.Label24.Tag = "212"
        Me.Label24.Text = "Lĩnh vực kinh doanh"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(7, 240)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(55, 13)
        Me.Label34.TabIndex = 137
        Me.Label34.Tag = "003"
        Me.Label34.Text = "Trang thai"
        '
        'lblten_td
        '
        Me.lblten_td.AutoSize = True
        Me.lblten_td.Location = New System.Drawing.Point(267, 240)
        Me.lblten_td.Name = "lblten_td"
        Me.lblten_td.Size = New System.Drawing.Size(55, 13)
        Me.lblten_td.TabIndex = 138
        Me.lblten_td.Tag = ""
        Me.lblten_td.Text = "Trang thai"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(7, 154)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(26, 13)
        Me.Label25.TabIndex = 131
        Me.Label25.Tag = "213"
        Me.Label25.Text = "Vốn"
        '
        'txtlvkd
        '
        Me.txtlvkd.Location = New System.Drawing.Point(160, 131)
        Me.txtlvkd.Name = "txtlvkd"
        Me.txtlvkd.Size = New System.Drawing.Size(367, 20)
        Me.txtlvkd.TabIndex = 122
        '
        'txtma_td
        '
        Me.txtma_td.Location = New System.Drawing.Point(160, 236)
        Me.txtma_td.Name = "txtma_td"
        Me.txtma_td.Size = New System.Drawing.Size(100, 20)
        Me.txtma_td.TabIndex = 127
        '
        'tabother
        '
        Me.tabother.Controls.Add(Me.txttd3)
        Me.tabother.Controls.Add(Me.Label41)
        Me.tabother.Controls.Add(Me.txttd2)
        Me.tabother.Controls.Add(Me.Label40)
        Me.tabother.Controls.Add(Me.txttd1)
        Me.tabother.Controls.Add(Me.Label39)
        Me.tabother.Controls.Add(Me.txtso_cmnd)
        Me.tabother.Controls.Add(Me.Label38)
        Me.tabother.Controls.Add(Me.txtten_nh)
        Me.tabother.Controls.Add(Me.Label33)
        Me.tabother.Controls.Add(Me.txttk_nh)
        Me.tabother.Controls.Add(Me.Label31)
        Me.tabother.Controls.Add(Me.lblten_nv)
        Me.tabother.Controls.Add(Me.Label2)
        Me.tabother.Controls.Add(Me.txtma_nv_lh)
        Me.tabother.Controls.Add(Me.Label12)
        Me.tabother.Controls.Add(Me.txtwebsite)
        Me.tabother.Controls.Add(Me.Label19)
        Me.tabother.Controls.Add(Me.Label17)
        Me.tabother.Controls.Add(Me.txtma_tinh_thanh)
        Me.tabother.Controls.Add(Me.txtemail)
        Me.tabother.Controls.Add(Me.lblten_tinh_thanh)
        Me.tabother.Controls.Add(Me.Label3)
        Me.tabother.Controls.Add(Me.txtma_qg)
        Me.tabother.Controls.Add(Me.txtfax)
        Me.tabother.Controls.Add(Me.lblten_qg)
        Me.tabother.Controls.Add(Me.Label5)
        Me.tabother.Controls.Add(Me.Label13)
        Me.tabother.Controls.Add(Me.txtma_quan_huyen)
        Me.tabother.Controls.Add(Me.lblten_quan_huyen)
        Me.tabother.Location = New System.Drawing.Point(4, 22)
        Me.tabother.Name = "tabother"
        Me.tabother.Size = New System.Drawing.Size(892, 282)
        Me.tabother.TabIndex = 6
        Me.tabother.Tag = "OTH"
        Me.tabother.Text = "Thông tin khác"
        Me.tabother.UseVisualStyleBackColor = True
        '
        'txttd3
        '
        Me.txttd3.Location = New System.Drawing.Point(140, 257)
        Me.txttd3.Name = "txttd3"
        Me.txttd3.Size = New System.Drawing.Size(378, 20)
        Me.txttd3.TabIndex = 161
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(8, 264)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(41, 13)
        Me.Label41.TabIndex = 160
        Me.Label41.Tag = "KH3"
        Me.Label41.Text = "Khác 3"
        '
        'txttd2
        '
        Me.txttd2.Location = New System.Drawing.Point(140, 236)
        Me.txttd2.Name = "txttd2"
        Me.txttd2.Size = New System.Drawing.Size(378, 20)
        Me.txttd2.TabIndex = 159
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(8, 243)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(41, 13)
        Me.Label40.TabIndex = 158
        Me.Label40.Tag = "KH2"
        Me.Label40.Text = "Khác 2"
        '
        'txttd1
        '
        Me.txttd1.Location = New System.Drawing.Point(140, 215)
        Me.txttd1.Name = "txttd1"
        Me.txttd1.Size = New System.Drawing.Size(378, 20)
        Me.txttd1.TabIndex = 157
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(8, 222)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(41, 13)
        Me.Label39.TabIndex = 156
        Me.Label39.Tag = "KH1"
        Me.Label39.Text = "Khác 1"
        '
        'txtso_cmnd
        '
        Me.txtso_cmnd.Location = New System.Drawing.Point(140, 194)
        Me.txtso_cmnd.Name = "txtso_cmnd"
        Me.txtso_cmnd.Size = New System.Drawing.Size(159, 20)
        Me.txtso_cmnd.TabIndex = 155
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(8, 201)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(39, 13)
        Me.Label38.TabIndex = 154
        Me.Label38.Tag = "CMND"
        Me.Label38.Text = "CMND"
        '
        'txtten_nh
        '
        Me.txtten_nh.Location = New System.Drawing.Point(140, 173)
        Me.txtten_nh.Name = "txtten_nh"
        Me.txtten_nh.Size = New System.Drawing.Size(378, 20)
        Me.txtten_nh.TabIndex = 139
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(8, 177)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(37, 13)
        Me.Label33.TabIndex = 153
        Me.Label33.Tag = "415"
        Me.Label33.Text = "ten nh"
        '
        'txttk_nh
        '
        Me.txttk_nh.Location = New System.Drawing.Point(140, 152)
        Me.txttk_nh.Name = "txttk_nh"
        Me.txttk_nh.Size = New System.Drawing.Size(159, 20)
        Me.txttk_nh.TabIndex = 138
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(8, 156)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(31, 13)
        Me.Label31.TabIndex = 152
        Me.Label31.Tag = "414"
        Me.Label31.Text = "tk nh"
        '
        'lblten_nv
        '
        Me.lblten_nv.AutoSize = True
        Me.lblten_nv.Location = New System.Drawing.Point(249, 135)
        Me.lblten_nv.Name = "lblten_nv"
        Me.lblten_nv.Size = New System.Drawing.Size(85, 13)
        Me.lblten_nv.TabIndex = 151
        Me.lblten_nv.Tag = ""
        Me.lblten_nv.Text = "ten nguoi lien he"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 150
        Me.Label2.Tag = "015"
        Me.Label2.Text = "Người liên hệ"
        '
        'txtma_nv_lh
        '
        Me.txtma_nv_lh.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtma_nv_lh.Location = New System.Drawing.Point(140, 131)
        Me.txtma_nv_lh.Name = "txtma_nv_lh"
        Me.txtma_nv_lh.Size = New System.Drawing.Size(103, 20)
        Me.txtma_nv_lh.TabIndex = 137
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 13)
        Me.Label12.TabIndex = 140
        Me.Label12.Tag = "013"
        Me.Label12.Text = "Ma tinh thanh"
        '
        'txtwebsite
        '
        Me.txtwebsite.Location = New System.Drawing.Point(140, 110)
        Me.txtwebsite.Name = "txtwebsite"
        Me.txtwebsite.Size = New System.Drawing.Size(378, 20)
        Me.txtwebsite.TabIndex = 136
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(8, 51)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(50, 13)
        Me.Label19.TabIndex = 141
        Me.Label19.Tag = "204"
        Me.Label19.Text = "Quoc gia"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(8, 114)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(46, 13)
        Me.Label17.TabIndex = 149
        Me.Label17.Tag = "207"
        Me.Label17.Text = "Website"
        '
        'txtma_tinh_thanh
        '
        Me.txtma_tinh_thanh.Location = New System.Drawing.Point(140, 26)
        Me.txtma_tinh_thanh.Name = "txtma_tinh_thanh"
        Me.txtma_tinh_thanh.Size = New System.Drawing.Size(103, 20)
        Me.txtma_tinh_thanh.TabIndex = 131
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(140, 89)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(378, 20)
        Me.txtemail.TabIndex = 135
        '
        'lblten_tinh_thanh
        '
        Me.lblten_tinh_thanh.AutoSize = True
        Me.lblten_tinh_thanh.Location = New System.Drawing.Point(249, 30)
        Me.lblten_tinh_thanh.Name = "lblten_tinh_thanh"
        Me.lblten_tinh_thanh.Size = New System.Drawing.Size(72, 13)
        Me.lblten_tinh_thanh.TabIndex = 142
        Me.lblten_tinh_thanh.Tag = ""
        Me.lblten_tinh_thanh.Text = "Ma tinh thanh"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 148
        Me.Label3.Tag = "206"
        Me.Label3.Text = "Email"
        '
        'txtma_qg
        '
        Me.txtma_qg.Location = New System.Drawing.Point(140, 47)
        Me.txtma_qg.Name = "txtma_qg"
        Me.txtma_qg.Size = New System.Drawing.Size(103, 20)
        Me.txtma_qg.TabIndex = 132
        '
        'txtfax
        '
        Me.txtfax.Location = New System.Drawing.Point(140, 68)
        Me.txtfax.Name = "txtfax"
        Me.txtfax.Size = New System.Drawing.Size(378, 20)
        Me.txtfax.TabIndex = 134
        '
        'lblten_qg
        '
        Me.lblten_qg.AutoSize = True
        Me.lblten_qg.Location = New System.Drawing.Point(249, 51)
        Me.lblten_qg.Name = "lblten_qg"
        Me.lblten_qg.Size = New System.Drawing.Size(50, 13)
        Me.lblten_qg.TabIndex = 143
        Me.lblten_qg.Tag = ""
        Me.lblten_qg.Text = "Quoc gia"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 147
        Me.Label5.Tag = "205"
        Me.Label5.Text = "Fax"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(8, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 13)
        Me.Label13.TabIndex = 144
        Me.Label13.Tag = "014"
        Me.Label13.Text = "Ma quan huyen"
        '
        'txtma_quan_huyen
        '
        Me.txtma_quan_huyen.Location = New System.Drawing.Point(140, 5)
        Me.txtma_quan_huyen.Name = "txtma_quan_huyen"
        Me.txtma_quan_huyen.Size = New System.Drawing.Size(103, 20)
        Me.txtma_quan_huyen.TabIndex = 130
        '
        'lblten_quan_huyen
        '
        Me.lblten_quan_huyen.AutoSize = True
        Me.lblten_quan_huyen.Location = New System.Drawing.Point(249, 9)
        Me.lblten_quan_huyen.Name = "lblten_quan_huyen"
        Me.lblten_quan_huyen.Size = New System.Drawing.Size(81, 13)
        Me.lblten_quan_huyen.TabIndex = 145
        Me.lblten_quan_huyen.Tag = ""
        Me.lblten_quan_huyen.Text = "Ma quan huyen"
        '
        'thong_tin_lien_he
        '
        Me.thong_tin_lien_he.AutoScroll = True
        Me.thong_tin_lien_he.Controls.Add(Me.gridlh)
        Me.thong_tin_lien_he.Controls.Add(Me.bar_lh)
        Me.thong_tin_lien_he.Location = New System.Drawing.Point(4, 22)
        Me.thong_tin_lien_he.Name = "thong_tin_lien_he"
        Me.thong_tin_lien_he.Size = New System.Drawing.Size(892, 282)
        Me.thong_tin_lien_he.TabIndex = 3
        Me.thong_tin_lien_he.Tag = "302"
        Me.thong_tin_lien_he.Text = "thong tin lien he"
        Me.thong_tin_lien_he.UseVisualStyleBackColor = True
        '
        'gridlh
        '
        Me.gridlh.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridlh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridlh.Location = New System.Drawing.Point(0, 25)
        Me.gridlh.Name = "gridlh"
        Me.gridlh.Size = New System.Drawing.Size(889, 322)
        Me.gridlh.TabIndex = 1
        '
        'bar_lh
        '
        Me.bar_lh.Location = New System.Drawing.Point(0, 0)
        Me.bar_lh.Name = "bar_lh"
        Me.bar_lh.Size = New System.Drawing.Size(892, 25)
        Me.bar_lh.TabIndex = 0
        Me.bar_lh.Text = "ToolStrip3"
        '
        'hop_dong
        '
        Me.hop_dong.AutoScroll = True
        Me.hop_dong.Controls.Add(Me.bar_hd)
        Me.hop_dong.Controls.Add(Me.grdhop_dong)
        Me.hop_dong.Location = New System.Drawing.Point(4, 22)
        Me.hop_dong.Name = "hop_dong"
        Me.hop_dong.Size = New System.Drawing.Size(892, 282)
        Me.hop_dong.TabIndex = 5
        Me.hop_dong.Tag = "CHD"
        Me.hop_dong.Text = "Hợp đồng"
        Me.hop_dong.UseVisualStyleBackColor = True
        '
        'bar_hd
        '
        Me.bar_hd.Location = New System.Drawing.Point(0, 0)
        Me.bar_hd.Name = "bar_hd"
        Me.bar_hd.Size = New System.Drawing.Size(892, 25)
        Me.bar_hd.TabIndex = 5
        Me.bar_hd.Text = "ToolStrip2"
        '
        'grdhop_dong
        '
        Me.grdhop_dong.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdhop_dong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdhop_dong.Location = New System.Drawing.Point(0, 26)
        Me.grdhop_dong.Name = "grdhop_dong"
        Me.grdhop_dong.Size = New System.Drawing.Size(892, 321)
        Me.grdhop_dong.TabIndex = 3
        '
        'actives
        '
        Me.actives.Controls.Add(Me.gridactives)
        Me.actives.Controls.Add(Me.toolbaractives)
        Me.actives.Location = New System.Drawing.Point(4, 22)
        Me.actives.Name = "actives"
        Me.actives.Size = New System.Drawing.Size(892, 282)
        Me.actives.TabIndex = 7
        Me.actives.Tag = "034"
        Me.actives.Text = "Hoạt động, lịch làm việc"
        Me.actives.UseVisualStyleBackColor = True
        '
        'gridactives
        '
        Me.gridactives.AllowUserToAddRows = False
        Me.gridactives.AllowUserToDeleteRows = False
        Me.gridactives.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridactives.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridactives.Location = New System.Drawing.Point(0, 25)
        Me.gridactives.Name = "gridactives"
        Me.gridactives.Size = New System.Drawing.Size(892, 257)
        Me.gridactives.TabIndex = 1
        '
        'toolbaractives
        '
        Me.toolbaractives.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnnewactive, Me.btnupdateactive, Me.btndeleteactive})
        Me.toolbaractives.Location = New System.Drawing.Point(0, 0)
        Me.toolbaractives.Name = "toolbaractives"
        Me.toolbaractives.Size = New System.Drawing.Size(892, 25)
        Me.toolbaractives.TabIndex = 0
        Me.toolbaractives.Text = "ToolStrip1"
        '
        'btnnewactive
        '
        Me.btnnewactive.Image = CType(resources.GetObject("btnnewactive.Image"), System.Drawing.Image)
        Me.btnnewactive.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnnewactive.Name = "btnnewactive"
        Me.btnnewactive.Size = New System.Drawing.Size(48, 22)
        Me.btnnewactive.Tag = "096"
        Me.btnnewactive.Text = "Mới"
        '
        'btnupdateactive
        '
        Me.btnupdateactive.Image = CType(resources.GetObject("btnupdateactive.Image"), System.Drawing.Image)
        Me.btnupdateactive.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnupdateactive.Name = "btnupdateactive"
        Me.btnupdateactive.Size = New System.Drawing.Size(46, 22)
        Me.btnupdateactive.Tag = "097"
        Me.btnupdateactive.Text = "Sửa"
        '
        'btndeleteactive
        '
        Me.btndeleteactive.Image = CType(resources.GetObject("btndeleteactive.Image"), System.Drawing.Image)
        Me.btndeleteactive.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btndeleteactive.Name = "btndeleteactive"
        Me.btndeleteactive.Size = New System.Drawing.Size(47, 22)
        Me.btndeleteactive.Tag = "098"
        Me.btndeleteactive.Text = "Xóa"
        '
        'documents
        '
        Me.documents.Controls.Add(Me.toolbardocuments)
        Me.documents.Controls.Add(Me.griddocuments)
        Me.documents.Location = New System.Drawing.Point(4, 22)
        Me.documents.Name = "documents"
        Me.documents.Size = New System.Drawing.Size(892, 282)
        Me.documents.TabIndex = 8
        Me.documents.Tag = "DOC"
        Me.documents.Text = "Tài liệu"
        Me.documents.UseVisualStyleBackColor = True
        '
        'toolbardocuments
        '
        Me.toolbardocuments.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnadddoc, Me.btnupdatedoc, Me.btndeletedoc, Me.btnviewfile})
        Me.toolbardocuments.Location = New System.Drawing.Point(0, 0)
        Me.toolbardocuments.Name = "toolbardocuments"
        Me.toolbardocuments.Size = New System.Drawing.Size(892, 25)
        Me.toolbardocuments.TabIndex = 4
        Me.toolbardocuments.Text = "ToolStrip1"
        '
        'btnadddoc
        '
        Me.btnadddoc.Image = CType(resources.GetObject("btnadddoc.Image"), System.Drawing.Image)
        Me.btnadddoc.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnadddoc.Name = "btnadddoc"
        Me.btnadddoc.Size = New System.Drawing.Size(48, 22)
        Me.btnadddoc.Tag = "096"
        Me.btnadddoc.Text = "Mới"
        '
        'btnupdatedoc
        '
        Me.btnupdatedoc.Image = CType(resources.GetObject("btnupdatedoc.Image"), System.Drawing.Image)
        Me.btnupdatedoc.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnupdatedoc.Name = "btnupdatedoc"
        Me.btnupdatedoc.Size = New System.Drawing.Size(46, 22)
        Me.btnupdatedoc.Tag = "097"
        Me.btnupdatedoc.Text = "Sửa"
        '
        'btndeletedoc
        '
        Me.btndeletedoc.Image = CType(resources.GetObject("btndeletedoc.Image"), System.Drawing.Image)
        Me.btndeletedoc.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btndeletedoc.Name = "btndeletedoc"
        Me.btndeletedoc.Size = New System.Drawing.Size(47, 22)
        Me.btndeletedoc.Tag = "098"
        Me.btndeletedoc.Text = "Xóa"
        '
        'btnviewfile
        '
        Me.btnviewfile.Image = CType(resources.GetObject("btnviewfile.Image"), System.Drawing.Image)
        Me.btnviewfile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnviewfile.Name = "btnviewfile"
        Me.btnviewfile.Size = New System.Drawing.Size(70, 22)
        Me.btnviewfile.Tag = "View"
        Me.btnviewfile.Text = "Xem file"
        '
        'griddocuments
        '
        Me.griddocuments.AllowUserToAddRows = False
        Me.griddocuments.AllowUserToDeleteRows = False
        Me.griddocuments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.griddocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.griddocuments.Location = New System.Drawing.Point(-1, 27)
        Me.griddocuments.Name = "griddocuments"
        Me.griddocuments.Size = New System.Drawing.Size(893, 255)
        Me.griddocuments.TabIndex = 3
        '
        'Frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 574)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStripfind)
        Me.Controls.Add(Me.ToolStripmain)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Frmmain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "004"
        Me.Text = "Danh mục khách hàng"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.grd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.thong_tin_chung.ResumeLayout(False)
        Me.thong_tin_chung.PerformLayout()
        Me.thong_tin_pha_tich.ResumeLayout(False)
        Me.thong_tin_pha_tich.PerformLayout()
        Me.tabother.ResumeLayout(False)
        Me.tabother.PerformLayout()
        Me.thong_tin_lien_he.ResumeLayout(False)
        Me.thong_tin_lien_he.PerformLayout()
        CType(Me.gridlh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hop_dong.ResumeLayout(False)
        Me.hop_dong.PerformLayout()
        CType(Me.grdhop_dong, System.ComponentModel.ISupportInitialize).EndInit()
        Me.actives.ResumeLayout(False)
        Me.actives.PerformLayout()
        CType(Me.gridactives, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolbaractives.ResumeLayout(False)
        Me.toolbaractives.PerformLayout()
        Me.documents.ResumeLayout(False)
        Me.documents.PerformLayout()
        Me.toolbardocuments.ResumeLayout(False)
        Me.toolbardocuments.PerformLayout()
        CType(Me.griddocuments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnfile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lbluser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripmain As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripfind As System.Windows.Forms.ToolStrip
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents grd As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents thong_tin_chung As System.Windows.Forms.TabPage
    Friend WithEvents thong_tin_pha_tich As System.Windows.Forms.TabPage
    Friend WithEvents thong_tin_lien_he As System.Windows.Forms.TabPage
    Friend WithEvents gridlh As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbllines As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents bar_lh As System.Windows.Forms.ToolStrip
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtma_kh As System.Windows.Forms.TextBox
    Friend WithEvents txtten_kh As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtdai_dien_pl As System.Windows.Forms.TextBox
    Friend WithEvents txtten_dn As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lblten_dt_ct As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtten_gd As System.Windows.Forms.TextBox
    Friend WithEvents txtly_do_c_ncc As System.Windows.Forms.TextBox
    Friend WithEvents txthtsh As System.Windows.Forms.TextBox
    Friend WithEvents txtma_dt_ct As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblten_ly_do_c_ncc As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Txtgia_ct As ClsControl2.TxtNumeric
    Friend WithEvents txtlhkd As System.Windows.Forms.TextBox
    Friend WithEvents txtvon_kd As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents lblten_td As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtlvkd As System.Windows.Forms.TextBox
    Friend WithEvents txtma_td As System.Windows.Forms.TextBox
    Friend WithEvents hop_dong As System.Windows.Forms.TabPage
    Friend WithEvents bar_hd As System.Windows.Forms.ToolStrip
    Friend WithEvents grdhop_dong As System.Windows.Forms.DataGridView
    Friend WithEvents txtdia_chi As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chbtrang_thai As System.Windows.Forms.CheckBox
    Friend WithEvents ten_nh3 As System.Windows.Forms.Label
    Friend WithEvents txtnh_kh3 As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents ten_nh2 As System.Windows.Forms.Label
    Friend WithEvents txtnh_kh2 As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents ten_nh1 As System.Windows.Forms.Label
    Friend WithEvents txtnh_kh1 As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents lblten_tk As System.Windows.Forms.Label
    Friend WithEvents txttk_cn As System.Windows.Forms.TextBox
    Friend WithEvents txtt_dm As ClsControl2.TxtNumeric
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents lblten_loai_kh As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtngay_tl As ClsControl2.TxtDate
    Friend WithEvents txtma_loai_kh As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtma_so_thue As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents tabother As System.Windows.Forms.TabPage
    Friend WithEvents txtten_nh As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txttk_nh As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents lblten_nv As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtma_nv_lh As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtwebsite As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtma_tinh_thanh As System.Windows.Forms.TextBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents lblten_tinh_thanh As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtma_qg As System.Windows.Forms.TextBox
    Friend WithEvents txtfax As System.Windows.Forms.TextBox
    Friend WithEvents lblten_qg As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtma_quan_huyen As System.Windows.Forms.TextBox
    Friend WithEvents lblten_quan_huyen As System.Windows.Forms.Label
    Friend WithEvents txtdien_thoai As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtten_kh2 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txttd3 As System.Windows.Forms.TextBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents txttd2 As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents txttd1 As System.Windows.Forms.TextBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents txtso_cmnd As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents actives As System.Windows.Forms.TabPage
    Friend WithEvents toolbaractives As System.Windows.Forms.ToolStrip
    Friend WithEvents btnnewactive As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnupdateactive As System.Windows.Forms.ToolStripButton
    Friend WithEvents btndeleteactive As System.Windows.Forms.ToolStripButton
    Friend WithEvents documents As System.Windows.Forms.TabPage
    Friend WithEvents griddocuments As System.Windows.Forms.DataGridView
    Friend WithEvents gridactives As System.Windows.Forms.DataGridView
    Friend WithEvents toolbardocuments As System.Windows.Forms.ToolStrip
    Friend WithEvents btnadddoc As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnupdatedoc As System.Windows.Forms.ToolStripButton
    Friend WithEvents btndeletedoc As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnviewfile As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents txtngay_tc As ClsControl2.TxtDate



End Class
