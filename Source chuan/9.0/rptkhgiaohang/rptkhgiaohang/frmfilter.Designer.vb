﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmfilter
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
        Me.tabdkloc = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtDen_ngay = New ClsControl2.TxtDate()
        Me.Txttu_ngay = New ClsControl2.TxtDate()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbbma_dvcs = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txttitle = New System.Windows.Forms.TextBox()
        Me.cbbmau = New System.Windows.Forms.ComboBox()
        Me.btnok = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtma_vt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ten_vt = New System.Windows.Forms.Label()
        Me.ten_kh = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtma_kh = New System.Windows.Forms.TextBox()
        Me.tabdkloc.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabdkloc
        '
        Me.tabdkloc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabdkloc.Controls.Add(Me.TabPage1)
        Me.tabdkloc.Location = New System.Drawing.Point(-6, -1)
        Me.tabdkloc.Name = "tabdkloc"
        Me.tabdkloc.SelectedIndex = 0
        Me.tabdkloc.Size = New System.Drawing.Size(664, 190)
        Me.tabdkloc.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ten_kh)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txtma_kh)
        Me.TabPage1.Controls.Add(Me.ten_vt)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtma_vt)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.TxtDen_ngay)
        Me.TabPage1.Controls.Add(Me.Txttu_ngay)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.cbbma_dvcs)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txttitle)
        Me.TabPage1.Controls.Add(Me.cbbmau)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(656, 164)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Tag = "001"
        Me.TabPage1.Text = "Điều kiện lọc"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(9, 11)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(96, 13)
        Me.Label16.TabIndex = 36
        Me.Label16.Tag = "002"
        Me.Label16.Text = "Từ ngày/đến ngày"
        '
        'TxtDen_ngay
        '
        Me.TxtDen_ngay.Culture = New System.Globalization.CultureInfo("vi-VN")
        Me.TxtDen_ngay.Location = New System.Drawing.Point(276, 7)
        Me.TxtDen_ngay.Mask = "00/00/0000"
        Me.TxtDen_ngay.Name = "TxtDen_ngay"
        Me.TxtDen_ngay.Size = New System.Drawing.Size(125, 20)
        Me.TxtDen_ngay.TabIndex = 1
        Me.TxtDen_ngay.Text = "26032010"
        Me.TxtDen_ngay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtDen_ngay.Value = New Date(2010, 3, 26, 0, 0, 0, 0)
        '
        'Txttu_ngay
        '
        Me.Txttu_ngay.Location = New System.Drawing.Point(145, 7)
        Me.Txttu_ngay.Mask = "00/00/0000"
        Me.Txttu_ngay.Name = "Txttu_ngay"
        Me.Txttu_ngay.Size = New System.Drawing.Size(125, 20)
        Me.Txttu_ngay.TabIndex = 0
        Me.Txttu_ngay.Text = "26032010"
        Me.Txttu_ngay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txttu_ngay.Value = New Date(2010, 3, 26, 0, 0, 0, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 87)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Tag = "009"
        Me.Label9.Text = "Đơn vị"
        '
        'cbbma_dvcs
        '
        Me.cbbma_dvcs.FormattingEnabled = True
        Me.cbbma_dvcs.Location = New System.Drawing.Point(145, 83)
        Me.cbbma_dvcs.Name = "cbbma_dvcs"
        Me.cbbma_dvcs.Size = New System.Drawing.Size(326, 21)
        Me.cbbma_dvcs.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Tag = "011"
        Me.Label4.Text = "Mẫu báo cáo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Tag = "012"
        Me.Label3.Text = "Tiêu đề"
        '
        'txttitle
        '
        Me.txttitle.Location = New System.Drawing.Point(145, 134)
        Me.txttitle.Name = "txttitle"
        Me.txttitle.Size = New System.Drawing.Size(326, 20)
        Me.txttitle.TabIndex = 12
        '
        'cbbmau
        '
        Me.cbbmau.FormattingEnabled = True
        Me.cbbmau.Location = New System.Drawing.Point(145, 108)
        Me.cbbmau.Name = "cbbmau"
        Me.cbbmau.Size = New System.Drawing.Size(326, 21)
        Me.cbbmau.TabIndex = 11
        '
        'btnok
        '
        Me.btnok.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnok.Location = New System.Drawing.Point(12, 195)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(75, 23)
        Me.btnok.TabIndex = 1
        Me.btnok.Tag = "004"
        Me.btnok.Text = "Ok"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.CausesValidation = False
        Me.btnCancel.Location = New System.Drawing.Point(93, 195)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Tag = "005"
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtma_vt
        '
        Me.txtma_vt.Location = New System.Drawing.Point(145, 31)
        Me.txtma_vt.Name = "txtma_vt"
        Me.txtma_vt.Size = New System.Drawing.Size(125, 20)
        Me.txtma_vt.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Sản phẩm"
        '
        'ten_vt
        '
        Me.ten_vt.AutoSize = True
        Me.ten_vt.Location = New System.Drawing.Point(276, 34)
        Me.ten_vt.Name = "ten_vt"
        Me.ten_vt.Size = New System.Drawing.Size(22, 13)
        Me.ten_vt.TabIndex = 39
        Me.ten_vt.Text = "ten"
        '
        'ten_kh
        '
        Me.ten_kh.AutoSize = True
        Me.ten_kh.Location = New System.Drawing.Point(276, 60)
        Me.ten_kh.Name = "ten_kh"
        Me.ten_kh.Size = New System.Drawing.Size(22, 13)
        Me.ten_kh.TabIndex = 42
        Me.ten_kh.Text = "ten"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Khách hàng"
        '
        'txtma_kh
        '
        Me.txtma_kh.Location = New System.Drawing.Point(145, 57)
        Me.txtma_kh.Name = "txtma_kh"
        Me.txtma_kh.Size = New System.Drawing.Size(125, 20)
        Me.txtma_kh.TabIndex = 3
        '
        'frmfilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 222)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.tabdkloc)
        Me.Name = "frmfilter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "000"
        Me.Text = "Kế hoạch giao hàng"
        Me.tabdkloc.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabdkloc As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txttitle As System.Windows.Forms.TextBox
    Friend WithEvents cbbmau As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbbma_dvcs As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TxtDen_ngay As ClsControl2.TxtDate
    Friend WithEvents Txttu_ngay As ClsControl2.TxtDate
    Friend WithEvents ten_kh As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtma_kh As TextBox
    Friend WithEvents ten_vt As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtma_vt As TextBox
End Class
