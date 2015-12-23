<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.txtten_chuong_trinh = New System.Windows.Forms.ToolStripStatusLabel
        Me.txtserver = New System.Windows.Forms.ToolStripStatusLabel
        Me.txtdatabase = New System.Windows.Forms.ToolStripStatusLabel
        Me.txtuser = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblquay_so = New System.Windows.Forms.ToolStripStatusLabel
        Me.txtstatus = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblngay = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblgio = New System.Windows.Forms.ToolStripStatusLabel
        Me.inputPanel = New System.Windows.Forms.Panel
        Me.totalPanel = New System.Windows.Forms.Panel
        Me.txtt_tien_ck_hd = New ClsControl2.TxtNumeric
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtt_phai_thu = New ClsControl2.TxtNumeric
        Me.phaithu = New System.Windows.Forms.Label
        Me.txtt_giam_gia = New ClsControl2.TxtNumeric
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtt_tra_lai = New ClsControl2.TxtNumeric
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtt_thu = New ClsControl2.TxtNumeric
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtt_hoa_don = New ClsControl2.TxtNumeric
        Me.txtt_so_luong = New ClsControl2.TxtNumeric
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.keyPanel = New System.Windows.Forms.Panel
        Me.btnqlthegiamgia = New System.Windows.Forms.Button
        Me.btnbangiao = New System.Windows.Forms.Button
        Me.txtgia_ban = New ClsControl2.TxtNumeric
        Me.txtma_so_ck = New System.Windows.Forms.TextBox
        Me.txttien = New ClsControl2.TxtNumeric
        Me.txtma_vt = New System.Windows.Forms.TextBox
        Me.txtSo_luong = New ClsControl2.TxtNumeric
        Me.lblten_kh = New System.Windows.Forms.Label
        Me.lblma_kh = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblfunction = New System.Windows.Forms.Label
        Me.txtMa_kh = New System.Windows.Forms.TextBox
        Me.functuionPanel = New System.Windows.Forms.Panel
        Me.logo = New System.Windows.Forms.PictureBox
        Me.btnBack = New System.Windows.Forms.Button
        Me.btnF10 = New System.Windows.Forms.Button
        Me.btnexit = New System.Windows.Forms.Button
        Me.btnmanager = New System.Windows.Forms.Button
        Me.btnF9 = New System.Windows.Forms.Button
        Me.btnF8 = New System.Windows.Forms.Button
        Me.btnF7 = New System.Windows.Forms.Button
        Me.btnF6 = New System.Windows.Forms.Button
        Me.btnF5 = New System.Windows.Forms.Button
        Me.btnF4 = New System.Windows.Forms.Button
        Me.btnF3 = New System.Windows.Forms.Button
        Me.btnF2 = New System.Windows.Forms.Button
        Me.gridsanpham = New ClsControl2.StpDataGridView
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.StatusStrip1.SuspendLayout()
        Me.inputPanel.SuspendLayout()
        Me.totalPanel.SuspendLayout()
        Me.keyPanel.SuspendLayout()
        Me.functuionPanel.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridsanpham, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtten_chuong_trinh, Me.txtserver, Me.txtdatabase, Me.txtuser, Me.lblquay_so, Me.txtstatus, Me.ToolStripStatusLabel1, Me.lblngay, Me.lblgio})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 561)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1175, 24)
        Me.StatusStrip1.TabIndex = 14
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'txtten_chuong_trinh
        '
        Me.txtten_chuong_trinh.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.txtten_chuong_trinh.Name = "txtten_chuong_trinh"
        Me.txtten_chuong_trinh.Size = New System.Drawing.Size(31, 19)
        Me.txtten_chuong_trinh.Text = "STP"
        '
        'txtserver
        '
        Me.txtserver.Name = "txtserver"
        Me.txtserver.Size = New System.Drawing.Size(39, 19)
        Me.txtserver.Text = "Server"
        '
        'txtdatabase
        '
        Me.txtdatabase.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.txtdatabase.Name = "txtdatabase"
        Me.txtdatabase.Size = New System.Drawing.Size(58, 19)
        Me.txtdatabase.Text = "database"
        '
        'txtuser
        '
        Me.txtuser.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(34, 19)
        Me.txtuser.Text = "User"
        '
        'lblquay_so
        '
        Me.lblquay_so.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.lblquay_so.Name = "lblquay_so"
        Me.lblquay_so.Size = New System.Drawing.Size(39, 19)
        Me.lblquay_so.Text = "Quầy"
        '
        'txtstatus
        '
        Me.txtstatus.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.Size = New System.Drawing.Size(20, 19)
        Me.txtstatus.Text = "st"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(875, 19)
        Me.ToolStripStatusLabel1.Spring = True
        '
        'lblngay
        '
        Me.lblngay.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.lblngay.Name = "lblngay"
        Me.lblngay.Size = New System.Drawing.Size(39, 19)
        Me.lblngay.Text = "Ngay"
        '
        'lblgio
        '
        Me.lblgio.Name = "lblgio"
        Me.lblgio.Size = New System.Drawing.Size(25, 19)
        Me.lblgio.Text = "Gio"
        '
        'inputPanel
        '
        Me.inputPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.inputPanel.Controls.Add(Me.totalPanel)
        Me.inputPanel.Controls.Add(Me.keyPanel)
        Me.inputPanel.Controls.Add(Me.functuionPanel)
        Me.inputPanel.Location = New System.Drawing.Point(0, 228)
        Me.inputPanel.Name = "inputPanel"
        Me.inputPanel.Size = New System.Drawing.Size(1175, 332)
        Me.inputPanel.TabIndex = 16
        '
        'totalPanel
        '
        Me.totalPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.totalPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalPanel.Controls.Add(Me.txtt_tien_ck_hd)
        Me.totalPanel.Controls.Add(Me.Label8)
        Me.totalPanel.Controls.Add(Me.txtt_phai_thu)
        Me.totalPanel.Controls.Add(Me.phaithu)
        Me.totalPanel.Controls.Add(Me.txtt_giam_gia)
        Me.totalPanel.Controls.Add(Me.Label1)
        Me.totalPanel.Controls.Add(Me.txtt_tra_lai)
        Me.totalPanel.Controls.Add(Me.Label5)
        Me.totalPanel.Controls.Add(Me.txtt_thu)
        Me.totalPanel.Controls.Add(Me.Label4)
        Me.totalPanel.Controls.Add(Me.txtt_hoa_don)
        Me.totalPanel.Controls.Add(Me.txtt_so_luong)
        Me.totalPanel.Controls.Add(Me.Label3)
        Me.totalPanel.Controls.Add(Me.Label2)
        Me.totalPanel.Location = New System.Drawing.Point(708, 3)
        Me.totalPanel.Name = "totalPanel"
        Me.totalPanel.Size = New System.Drawing.Size(464, 250)
        Me.totalPanel.TabIndex = 2
        '
        'txtt_tien_ck_hd
        '
        Me.txtt_tien_ck_hd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtt_tien_ck_hd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtt_tien_ck_hd.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtt_tien_ck_hd.Location = New System.Drawing.Point(217, 102)
        Me.txtt_tien_ck_hd.MaxLength = 18
        Me.txtt_tien_ck_hd.Name = "txtt_tien_ck_hd"
        Me.txtt_tien_ck_hd.NumberDecimalDigits = 0
        Me.txtt_tien_ck_hd.ReadOnly = True
        Me.txtt_tien_ck_hd.Size = New System.Drawing.Size(243, 23)
        Me.txtt_tien_ck_hd.TabIndex = 3
        Me.txtt_tien_ck_hd.TabStop = False
        Me.txtt_tien_ck_hd.Text = "0"
        Me.txtt_tien_ck_hd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtt_tien_ck_hd.Value = 0
        Me.txtt_tien_ck_hd.Value2 = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(4, 109)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 17)
        Me.Label8.TabIndex = 12
        Me.Label8.Tag = "413"
        Me.Label8.Text = "Chiết khấu HD"
        '
        'txtt_phai_thu
        '
        Me.txtt_phai_thu.BackColor = System.Drawing.SystemColors.Control
        Me.txtt_phai_thu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtt_phai_thu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtt_phai_thu.ForeColor = System.Drawing.Color.Red
        Me.txtt_phai_thu.Location = New System.Drawing.Point(217, 134)
        Me.txtt_phai_thu.MaxLength = 18
        Me.txtt_phai_thu.Name = "txtt_phai_thu"
        Me.txtt_phai_thu.NumberDecimalDigits = 0
        Me.txtt_phai_thu.ReadOnly = True
        Me.txtt_phai_thu.Size = New System.Drawing.Size(243, 23)
        Me.txtt_phai_thu.TabIndex = 4
        Me.txtt_phai_thu.TabStop = False
        Me.txtt_phai_thu.Text = "0"
        Me.txtt_phai_thu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtt_phai_thu.Value = 0
        Me.txtt_phai_thu.Value2 = 0
        '
        'phaithu
        '
        Me.phaithu.AutoSize = True
        Me.phaithu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phaithu.ForeColor = System.Drawing.SystemColors.WindowText
        Me.phaithu.Location = New System.Drawing.Point(4, 137)
        Me.phaithu.Name = "phaithu"
        Me.phaithu.Size = New System.Drawing.Size(83, 25)
        Me.phaithu.TabIndex = 10
        Me.phaithu.Tag = "422"
        Me.phaithu.Text = "Phải thu"
        '
        'txtt_giam_gia
        '
        Me.txtt_giam_gia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtt_giam_gia.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtt_giam_gia.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtt_giam_gia.Location = New System.Drawing.Point(217, 70)
        Me.txtt_giam_gia.MaxLength = 18
        Me.txtt_giam_gia.Name = "txtt_giam_gia"
        Me.txtt_giam_gia.NumberDecimalDigits = 0
        Me.txtt_giam_gia.ReadOnly = True
        Me.txtt_giam_gia.Size = New System.Drawing.Size(243, 23)
        Me.txtt_giam_gia.TabIndex = 2
        Me.txtt_giam_gia.TabStop = False
        Me.txtt_giam_gia.Text = "0"
        Me.txtt_giam_gia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtt_giam_gia.Value = 0
        Me.txtt_giam_gia.Value2 = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Tag = "499"
        Me.Label1.Text = "Thẻ giảm giá"
        '
        'txtt_tra_lai
        '
        Me.txtt_tra_lai.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtt_tra_lai.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtt_tra_lai.Location = New System.Drawing.Point(217, 199)
        Me.txtt_tra_lai.MaxLength = 18
        Me.txtt_tra_lai.Name = "txtt_tra_lai"
        Me.txtt_tra_lai.NumberDecimalDigits = 0
        Me.txtt_tra_lai.ReadOnly = True
        Me.txtt_tra_lai.Size = New System.Drawing.Size(243, 23)
        Me.txtt_tra_lai.TabIndex = 6
        Me.txtt_tra_lai.TabStop = False
        Me.txtt_tra_lai.Text = "0"
        Me.txtt_tra_lai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtt_tra_lai.Value = 0
        Me.txtt_tra_lai.Value2 = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 25)
        Me.Label5.TabIndex = 6
        Me.Label5.Tag = "419"
        Me.Label5.Text = "Tiền trả lại"
        '
        'txtt_thu
        '
        Me.txtt_thu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtt_thu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtt_thu.Location = New System.Drawing.Point(217, 166)
        Me.txtt_thu.MaxLength = 18
        Me.txtt_thu.Name = "txtt_thu"
        Me.txtt_thu.NumberDecimalDigits = 0
        Me.txtt_thu.ReadOnly = True
        Me.txtt_thu.Size = New System.Drawing.Size(243, 23)
        Me.txtt_thu.TabIndex = 5
        Me.txtt_thu.TabStop = False
        Me.txtt_thu.Text = "0"
        Me.txtt_thu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtt_thu.Value = 0
        Me.txtt_thu.Value2 = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Tag = "415"
        Me.Label4.Text = "Tiền khách trả"
        '
        'txtt_hoa_don
        '
        Me.txtt_hoa_don.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtt_hoa_don.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtt_hoa_don.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtt_hoa_don.Location = New System.Drawing.Point(217, 38)
        Me.txtt_hoa_don.MaxLength = 18
        Me.txtt_hoa_don.Name = "txtt_hoa_don"
        Me.txtt_hoa_don.NumberDecimalDigits = 0
        Me.txtt_hoa_don.ReadOnly = True
        Me.txtt_hoa_don.Size = New System.Drawing.Size(243, 23)
        Me.txtt_hoa_don.TabIndex = 1
        Me.txtt_hoa_don.TabStop = False
        Me.txtt_hoa_don.Text = "0"
        Me.txtt_hoa_don.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtt_hoa_don.Value = 0
        Me.txtt_hoa_don.Value2 = 0
        '
        'txtt_so_luong
        '
        Me.txtt_so_luong.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtt_so_luong.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtt_so_luong.Location = New System.Drawing.Point(217, 6)
        Me.txtt_so_luong.MaxLength = 18
        Me.txtt_so_luong.Name = "txtt_so_luong"
        Me.txtt_so_luong.NumberDecimalDigits = 2
        Me.txtt_so_luong.ReadOnly = True
        Me.txtt_so_luong.Size = New System.Drawing.Size(243, 23)
        Me.txtt_so_luong.TabIndex = 0
        Me.txtt_so_luong.TabStop = False
        Me.txtt_so_luong.Text = "0.00"
        Me.txtt_so_luong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtt_so_luong.Value = 0
        Me.txtt_so_luong.Value2 = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Tag = "412"
        Me.Label3.Text = "Tổng hóa đơn"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Tag = "418"
        Me.Label2.Text = "Tổng số lượng"
        '
        'keyPanel
        '
        Me.keyPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.keyPanel.BackColor = System.Drawing.Color.Green
        Me.keyPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.keyPanel.Controls.Add(Me.btnqlthegiamgia)
        Me.keyPanel.Controls.Add(Me.btnbangiao)
        Me.keyPanel.Controls.Add(Me.txtgia_ban)
        Me.keyPanel.Controls.Add(Me.txtma_so_ck)
        Me.keyPanel.Controls.Add(Me.txttien)
        Me.keyPanel.Controls.Add(Me.txtma_vt)
        Me.keyPanel.Controls.Add(Me.txtSo_luong)
        Me.keyPanel.Controls.Add(Me.lblten_kh)
        Me.keyPanel.Controls.Add(Me.lblma_kh)
        Me.keyPanel.Controls.Add(Me.Label7)
        Me.keyPanel.Controls.Add(Me.Label6)
        Me.keyPanel.Controls.Add(Me.lblfunction)
        Me.keyPanel.Controls.Add(Me.txtMa_kh)
        Me.keyPanel.Location = New System.Drawing.Point(3, 3)
        Me.keyPanel.Name = "keyPanel"
        Me.keyPanel.Size = New System.Drawing.Size(706, 250)
        Me.keyPanel.TabIndex = 1
        '
        'btnqlthegiamgia
        '
        Me.btnqlthegiamgia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnqlthegiamgia.BackColor = System.Drawing.SystemColors.Control
        Me.btnqlthegiamgia.Location = New System.Drawing.Point(460, 199)
        Me.btnqlthegiamgia.Name = "btnqlthegiamgia"
        Me.btnqlthegiamgia.Size = New System.Drawing.Size(116, 38)
        Me.btnqlthegiamgia.TabIndex = 12
        Me.btnqlthegiamgia.TabStop = False
        Me.btnqlthegiamgia.Tag = "QGG"
        Me.btnqlthegiamgia.Text = "QL thẻ giảm giá"
        Me.btnqlthegiamgia.UseVisualStyleBackColor = False
        '
        'btnbangiao
        '
        Me.btnbangiao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnbangiao.BackColor = System.Drawing.SystemColors.Control
        Me.btnbangiao.Location = New System.Drawing.Point(582, 199)
        Me.btnbangiao.Name = "btnbangiao"
        Me.btnbangiao.Size = New System.Drawing.Size(116, 38)
        Me.btnbangiao.TabIndex = 11
        Me.btnbangiao.TabStop = False
        Me.btnbangiao.Tag = "BGC"
        Me.btnbangiao.Text = "Bàn giao ca"
        Me.btnbangiao.UseVisualStyleBackColor = False
        '
        'txtgia_ban
        '
        Me.txtgia_ban.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtgia_ban.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgia_ban.Location = New System.Drawing.Point(3, 30)
        Me.txtgia_ban.MaxLength = 18
        Me.txtgia_ban.Name = "txtgia_ban"
        Me.txtgia_ban.NumberDecimalDigits = 0
        Me.txtgia_ban.Size = New System.Drawing.Size(696, 45)
        Me.txtgia_ban.TabIndex = 10
        Me.txtgia_ban.Text = "0"
        Me.txtgia_ban.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtgia_ban.Value = 0
        Me.txtgia_ban.Value2 = 0
        Me.txtgia_ban.Visible = False
        '
        'txtma_so_ck
        '
        Me.txtma_so_ck.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtma_so_ck.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtma_so_ck.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtma_so_ck.Location = New System.Drawing.Point(3, 30)
        Me.txtma_so_ck.Name = "txtma_so_ck"
        Me.txtma_so_ck.Size = New System.Drawing.Size(696, 45)
        Me.txtma_so_ck.TabIndex = 9
        '
        'txttien
        '
        Me.txttien.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txttien.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttien.Location = New System.Drawing.Point(3, 30)
        Me.txttien.MaxLength = 18
        Me.txttien.Name = "txttien"
        Me.txttien.NumberDecimalDigits = 0
        Me.txttien.Size = New System.Drawing.Size(696, 45)
        Me.txttien.TabIndex = 8
        Me.txttien.Text = "0"
        Me.txttien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txttien.Value = 0
        Me.txttien.Value2 = 0
        Me.txttien.Visible = False
        '
        'txtma_vt
        '
        Me.txtma_vt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtma_vt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtma_vt.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtma_vt.Location = New System.Drawing.Point(3, 30)
        Me.txtma_vt.Name = "txtma_vt"
        Me.txtma_vt.Size = New System.Drawing.Size(696, 45)
        Me.txtma_vt.TabIndex = 7
        '
        'txtSo_luong
        '
        Me.txtSo_luong.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSo_luong.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSo_luong.Location = New System.Drawing.Point(3, 30)
        Me.txtSo_luong.MaxLength = 18
        Me.txtSo_luong.Name = "txtSo_luong"
        Me.txtSo_luong.NumberDecimalDigits = 2
        Me.txtSo_luong.Size = New System.Drawing.Size(696, 45)
        Me.txtSo_luong.TabIndex = 6
        Me.txtSo_luong.Text = "1.00"
        Me.txtSo_luong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSo_luong.Value = 1
        Me.txtSo_luong.Value2 = 1
        Me.txtSo_luong.Visible = False
        '
        'lblten_kh
        '
        Me.lblten_kh.AutoSize = True
        Me.lblten_kh.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblten_kh.ForeColor = System.Drawing.Color.White
        Me.lblten_kh.Location = New System.Drawing.Point(141, 122)
        Me.lblten_kh.Name = "lblten_kh"
        Me.lblten_kh.Size = New System.Drawing.Size(0, 25)
        Me.lblten_kh.TabIndex = 5
        '
        'lblma_kh
        '
        Me.lblma_kh.AutoSize = True
        Me.lblma_kh.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblma_kh.ForeColor = System.Drawing.Color.White
        Me.lblma_kh.Location = New System.Drawing.Point(141, 89)
        Me.lblma_kh.Name = "lblma_kh"
        Me.lblma_kh.Size = New System.Drawing.Size(0, 25)
        Me.lblma_kh.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(5, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 20)
        Me.Label7.TabIndex = 3
        Me.Label7.Tag = "002"
        Me.Label7.Text = "Tên khách:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(5, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 20)
        Me.Label6.TabIndex = 2
        Me.Label6.Tag = "001"
        Me.Label6.Text = "Mã khách:"
        '
        'lblfunction
        '
        Me.lblfunction.AutoSize = True
        Me.lblfunction.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfunction.ForeColor = System.Drawing.Color.White
        Me.lblfunction.Location = New System.Drawing.Point(6, 6)
        Me.lblfunction.Name = "lblfunction"
        Me.lblfunction.Size = New System.Drawing.Size(24, 20)
        Me.lblfunction.TabIndex = 1
        Me.lblfunction.Text = "..."
        '
        'txtMa_kh
        '
        Me.txtMa_kh.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMa_kh.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMa_kh.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMa_kh.Location = New System.Drawing.Point(3, 30)
        Me.txtMa_kh.Name = "txtMa_kh"
        Me.txtMa_kh.Size = New System.Drawing.Size(696, 45)
        Me.txtMa_kh.TabIndex = 0
        '
        'functuionPanel
        '
        Me.functuionPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.functuionPanel.Controls.Add(Me.logo)
        Me.functuionPanel.Controls.Add(Me.btnBack)
        Me.functuionPanel.Controls.Add(Me.btnF10)
        Me.functuionPanel.Controls.Add(Me.btnexit)
        Me.functuionPanel.Controls.Add(Me.btnmanager)
        Me.functuionPanel.Controls.Add(Me.btnF9)
        Me.functuionPanel.Controls.Add(Me.btnF8)
        Me.functuionPanel.Controls.Add(Me.btnF7)
        Me.functuionPanel.Controls.Add(Me.btnF6)
        Me.functuionPanel.Controls.Add(Me.btnF5)
        Me.functuionPanel.Controls.Add(Me.btnF4)
        Me.functuionPanel.Controls.Add(Me.btnF3)
        Me.functuionPanel.Controls.Add(Me.btnF2)
        Me.functuionPanel.Location = New System.Drawing.Point(3, 256)
        Me.functuionPanel.Name = "functuionPanel"
        Me.functuionPanel.Size = New System.Drawing.Size(1169, 77)
        Me.functuionPanel.TabIndex = 0
        '
        'logo
        '
        Me.logo.Location = New System.Drawing.Point(1034, 3)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(278, 70)
        Me.logo.TabIndex = 15
        Me.logo.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBack.CausesValidation = False
        Me.btnBack.Enabled = False
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Black
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBack.Location = New System.Drawing.Point(964, 3)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(64, 70)
        Me.btnBack.TabIndex = 14
        Me.btnBack.TabStop = False
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnF10
        '
        Me.btnF10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnF10.CausesValidation = False
        Me.btnF10.Enabled = False
        Me.btnF10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnF10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnF10.ForeColor = System.Drawing.Color.Black
        Me.btnF10.Image = CType(resources.GetObject("btnF10.Image"), System.Drawing.Image)
        Me.btnF10.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnF10.Location = New System.Drawing.Point(873, 3)
        Me.btnF10.Name = "btnF10"
        Me.btnF10.Size = New System.Drawing.Size(93, 70)
        Me.btnF10.TabIndex = 13
        Me.btnF10.TabStop = False
        Me.btnF10.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnF10.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnexit.CausesValidation = False
        Me.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.ForeColor = System.Drawing.Color.Black
        Me.btnexit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnexit.Location = New System.Drawing.Point(0, 39)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(82, 34)
        Me.btnexit.TabIndex = 12
        Me.btnexit.TabStop = False
        Me.btnexit.Tag = "801"
        Me.btnexit.Text = "Thoát (Ctrl+E)"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'btnmanager
        '
        Me.btnmanager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnmanager.CausesValidation = False
        Me.btnmanager.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnmanager.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmanager.ForeColor = System.Drawing.Color.Black
        Me.btnmanager.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnmanager.Location = New System.Drawing.Point(0, 3)
        Me.btnmanager.Name = "btnmanager"
        Me.btnmanager.Size = New System.Drawing.Size(82, 37)
        Me.btnmanager.TabIndex = 11
        Me.btnmanager.TabStop = False
        Me.btnmanager.Tag = "802"
        Me.btnmanager.Text = "Quản lý (F12)"
        Me.btnmanager.UseVisualStyleBackColor = True
        '
        'btnF9
        '
        Me.btnF9.Enabled = False
        Me.btnF9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnF9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnF9.ForeColor = System.Drawing.Color.Black
        Me.btnF9.Image = CType(resources.GetObject("btnF9.Image"), System.Drawing.Image)
        Me.btnF9.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnF9.Location = New System.Drawing.Point(774, 3)
        Me.btnF9.Name = "btnF9"
        Me.btnF9.Size = New System.Drawing.Size(100, 70)
        Me.btnF9.TabIndex = 7
        Me.btnF9.TabStop = False
        Me.btnF9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnF9.UseVisualStyleBackColor = True
        '
        'btnF8
        '
        Me.btnF8.Enabled = False
        Me.btnF8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnF8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnF8.ForeColor = System.Drawing.Color.Black
        Me.btnF8.Image = CType(resources.GetObject("btnF8.Image"), System.Drawing.Image)
        Me.btnF8.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnF8.Location = New System.Drawing.Point(675, 3)
        Me.btnF8.Name = "btnF8"
        Me.btnF8.Size = New System.Drawing.Size(100, 70)
        Me.btnF8.TabIndex = 6
        Me.btnF8.TabStop = False
        Me.btnF8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnF8.UseVisualStyleBackColor = True
        '
        'btnF7
        '
        Me.btnF7.Enabled = False
        Me.btnF7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnF7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnF7.ForeColor = System.Drawing.Color.Black
        Me.btnF7.Image = CType(resources.GetObject("btnF7.Image"), System.Drawing.Image)
        Me.btnF7.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnF7.Location = New System.Drawing.Point(576, 3)
        Me.btnF7.Name = "btnF7"
        Me.btnF7.Size = New System.Drawing.Size(100, 70)
        Me.btnF7.TabIndex = 5
        Me.btnF7.TabStop = False
        Me.btnF7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnF7.UseVisualStyleBackColor = True
        '
        'btnF6
        '
        Me.btnF6.Enabled = False
        Me.btnF6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnF6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnF6.ForeColor = System.Drawing.Color.Black
        Me.btnF6.Image = CType(resources.GetObject("btnF6.Image"), System.Drawing.Image)
        Me.btnF6.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnF6.Location = New System.Drawing.Point(477, 3)
        Me.btnF6.Name = "btnF6"
        Me.btnF6.Size = New System.Drawing.Size(100, 70)
        Me.btnF6.TabIndex = 4
        Me.btnF6.TabStop = False
        Me.btnF6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnF6.UseVisualStyleBackColor = True
        '
        'btnF5
        '
        Me.btnF5.Enabled = False
        Me.btnF5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnF5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnF5.ForeColor = System.Drawing.Color.Black
        Me.btnF5.Image = CType(resources.GetObject("btnF5.Image"), System.Drawing.Image)
        Me.btnF5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnF5.Location = New System.Drawing.Point(378, 3)
        Me.btnF5.Name = "btnF5"
        Me.btnF5.Size = New System.Drawing.Size(100, 70)
        Me.btnF5.TabIndex = 3
        Me.btnF5.TabStop = False
        Me.btnF5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnF5.UseVisualStyleBackColor = True
        '
        'btnF4
        '
        Me.btnF4.Enabled = False
        Me.btnF4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnF4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnF4.ForeColor = System.Drawing.Color.Black
        Me.btnF4.Image = CType(resources.GetObject("btnF4.Image"), System.Drawing.Image)
        Me.btnF4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnF4.Location = New System.Drawing.Point(279, 3)
        Me.btnF4.Name = "btnF4"
        Me.btnF4.Size = New System.Drawing.Size(100, 70)
        Me.btnF4.TabIndex = 2
        Me.btnF4.TabStop = False
        Me.btnF4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnF4.UseVisualStyleBackColor = True
        '
        'btnF3
        '
        Me.btnF3.Enabled = False
        Me.btnF3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnF3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnF3.ForeColor = System.Drawing.Color.Black
        Me.btnF3.Image = CType(resources.GetObject("btnF3.Image"), System.Drawing.Image)
        Me.btnF3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnF3.Location = New System.Drawing.Point(180, 3)
        Me.btnF3.Name = "btnF3"
        Me.btnF3.Size = New System.Drawing.Size(100, 70)
        Me.btnF3.TabIndex = 1
        Me.btnF3.TabStop = False
        Me.btnF3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnF3.UseVisualStyleBackColor = True
        '
        'btnF2
        '
        Me.btnF2.CausesValidation = False
        Me.btnF2.Enabled = False
        Me.btnF2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnF2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnF2.ForeColor = System.Drawing.Color.Black
        Me.btnF2.Image = CType(resources.GetObject("btnF2.Image"), System.Drawing.Image)
        Me.btnF2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnF2.Location = New System.Drawing.Point(81, 3)
        Me.btnF2.Name = "btnF2"
        Me.btnF2.Size = New System.Drawing.Size(100, 70)
        Me.btnF2.TabIndex = 0
        Me.btnF2.TabStop = False
        Me.btnF2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnF2.UseVisualStyleBackColor = True
        '
        'gridsanpham
        '
        Me.gridsanpham.AllowUserToAddRows = False
        Me.gridsanpham.AllowUserToDeleteRows = False
        Me.gridsanpham.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridsanpham.BackgroundColor = System.Drawing.Color.White
        Me.gridsanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridsanpham.Location = New System.Drawing.Point(0, 1)
        Me.gridsanpham.Name = "gridsanpham"
        Me.gridsanpham.ReadOnly = True
        Me.gridsanpham.RowHeadersVisible = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridsanpham.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.gridsanpham.Size = New System.Drawing.Size(1175, 228)
        Me.gridsanpham.TabIndex = 15
        Me.gridsanpham.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(1175, 585)
        Me.Controls.Add(Me.inputPanel)
        Me.Controls.Add(Me.gridsanpham)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "000"
        Me.Text = "Bán hàng"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.inputPanel.ResumeLayout(False)
        Me.totalPanel.ResumeLayout(False)
        Me.totalPanel.PerformLayout()
        Me.keyPanel.ResumeLayout(False)
        Me.keyPanel.PerformLayout()
        Me.functuionPanel.ResumeLayout(False)
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridsanpham, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents txtuser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents gridsanpham As ClsControl2.StpDataGridView
    Friend WithEvents inputPanel As System.Windows.Forms.Panel
    Friend WithEvents functuionPanel As System.Windows.Forms.Panel
    Friend WithEvents totalPanel As System.Windows.Forms.Panel
    Friend WithEvents keyPanel As System.Windows.Forms.Panel
    Friend WithEvents lblfunction As System.Windows.Forms.Label
    Friend WithEvents txtMa_kh As System.Windows.Forms.TextBox
    Friend WithEvents btnF8 As System.Windows.Forms.Button
    Friend WithEvents btnF7 As System.Windows.Forms.Button
    Friend WithEvents btnF6 As System.Windows.Forms.Button
    Friend WithEvents btnF5 As System.Windows.Forms.Button
    Friend WithEvents btnF4 As System.Windows.Forms.Button
    Friend WithEvents btnF3 As System.Windows.Forms.Button
    Friend WithEvents btnF2 As System.Windows.Forms.Button
    Friend WithEvents btnF9 As System.Windows.Forms.Button
    Friend WithEvents txtt_tra_lai As ClsControl2.TxtNumeric
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtt_thu As ClsControl2.TxtNumeric
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtt_hoa_don As ClsControl2.TxtNumeric
    Friend WithEvents txtt_so_luong As ClsControl2.TxtNumeric
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblten_kh As System.Windows.Forms.Label
    Friend WithEvents lblma_kh As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSo_luong As ClsControl2.TxtNumeric
    Friend WithEvents txtma_vt As System.Windows.Forms.TextBox
    Friend WithEvents txttien As ClsControl2.TxtNumeric
    Friend WithEvents txtt_phai_thu As ClsControl2.TxtNumeric
    Friend WithEvents phaithu As System.Windows.Forms.Label
    Friend WithEvents txtt_giam_gia As ClsControl2.TxtNumeric
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtma_so_ck As System.Windows.Forms.TextBox
    Friend WithEvents lblquay_so As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtt_tien_ck_hd As ClsControl2.TxtNumeric
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents btnmanager As System.Windows.Forms.Button
    Friend WithEvents txtgia_ban As ClsControl2.TxtNumeric
    Friend WithEvents btnF10 As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents txtserver As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtdatabase As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblngay As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblgio As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtten_chuong_trinh As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtstatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnbangiao As System.Windows.Forms.Button
    Friend WithEvents logo As System.Windows.Forms.PictureBox
    Friend WithEvents btnqlthegiamgia As System.Windows.Forms.Button
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort

End Class
