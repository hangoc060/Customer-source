<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmordertmp
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
        Me.gridsp = New System.Windows.Forms.DataGridView()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnprint = New System.Windows.Forms.Button()
        Me.gridkm = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gridsplist = New System.Windows.Forms.DataGridView()
        Me.gridkmlist = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblt_tien = New System.Windows.Forms.Label()
        Me.cbbnh_vt = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtma_kh = New System.Windows.Forms.TextBox()
        Me.lblten_kh = New System.Windows.Forms.Label()
        Me.btnselectKH = New System.Windows.Forms.Button()
        Me.lblt_ck = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblt_tt = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtfilter = New System.Windows.Forms.TextBox()
        Me.txtfilterkm = New System.Windows.Forms.TextBox()
        CType(Me.gridsp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridkm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridsplist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridkmlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridsp
        '
        Me.gridsp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridsp.Location = New System.Drawing.Point(1, 58)
        Me.gridsp.Name = "gridsp"
        Me.gridsp.Size = New System.Drawing.Size(738, 179)
        Me.gridsp.TabIndex = 0
        '
        'btnsave
        '
        Me.btnsave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnsave.Location = New System.Drawing.Point(85, 404)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(88, 23)
        Me.btnsave.TabIndex = 1
        Me.btnsave.Text = "Lưu và đóng"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnprint
        '
        Me.btnprint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnprint.Location = New System.Drawing.Point(4, 404)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(75, 23)
        Me.btnprint.TabIndex = 2
        Me.btnprint.Text = "Lưu và in"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'gridkm
        '
        Me.gridkm.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridkm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridkm.Location = New System.Drawing.Point(1, 269)
        Me.gridkm.Name = "gridkm"
        Me.gridkm.Size = New System.Drawing.Size(738, 129)
        Me.gridkm.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Sản phẩm"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1, 247)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Khuyến mãi"
        '
        'gridsplist
        '
        Me.gridsplist.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridsplist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridsplist.Location = New System.Drawing.Point(745, 81)
        Me.gridsplist.Name = "gridsplist"
        Me.gridsplist.Size = New System.Drawing.Size(251, 156)
        Me.gridsplist.TabIndex = 8
        '
        'gridkmlist
        '
        Me.gridkmlist.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridkmlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridkmlist.Location = New System.Drawing.Point(745, 269)
        Me.gridkmlist.Name = "gridkmlist"
        Me.gridkmlist.Size = New System.Drawing.Size(251, 129)
        Me.gridkmlist.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(465, 414)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Tổng tiền"
        '
        'lblt_tien
        '
        Me.lblt_tien.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblt_tien.AutoSize = True
        Me.lblt_tien.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblt_tien.Location = New System.Drawing.Point(523, 408)
        Me.lblt_tien.Name = "lblt_tien"
        Me.lblt_tien.Size = New System.Drawing.Size(21, 24)
        Me.lblt_tien.TabIndex = 11
        Me.lblt_tien.Text = "0"
        '
        'cbbnh_vt
        '
        Me.cbbnh_vt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbbnh_vt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbnh_vt.FormattingEnabled = True
        Me.cbbnh_vt.Location = New System.Drawing.Point(745, 33)
        Me.cbbnh_vt.Name = "cbbnh_vt"
        Me.cbbnh_vt.Size = New System.Drawing.Size(251, 21)
        Me.cbbnh_vt.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Khách hàng"
        '
        'txtma_kh
        '
        Me.txtma_kh.Location = New System.Drawing.Point(82, 6)
        Me.txtma_kh.Name = "txtma_kh"
        Me.txtma_kh.ReadOnly = True
        Me.txtma_kh.Size = New System.Drawing.Size(128, 20)
        Me.txtma_kh.TabIndex = 14
        '
        'lblten_kh
        '
        Me.lblten_kh.AutoSize = True
        Me.lblten_kh.Location = New System.Drawing.Point(216, 10)
        Me.lblten_kh.Name = "lblten_kh"
        Me.lblten_kh.Size = New System.Drawing.Size(40, 13)
        Me.lblten_kh.TabIndex = 15
        Me.lblten_kh.Text = "ten_kh"
        '
        'btnselectKH
        '
        Me.btnselectKH.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnselectKH.Location = New System.Drawing.Point(182, 6)
        Me.btnselectKH.Name = "btnselectKH"
        Me.btnselectKH.Size = New System.Drawing.Size(28, 20)
        Me.btnselectKH.TabIndex = 16
        Me.btnselectKH.Text = "..."
        Me.btnselectKH.UseVisualStyleBackColor = True
        '
        'lblt_ck
        '
        Me.lblt_ck.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblt_ck.AutoSize = True
        Me.lblt_ck.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblt_ck.Location = New System.Drawing.Point(718, 408)
        Me.lblt_ck.Name = "lblt_ck"
        Me.lblt_ck.Size = New System.Drawing.Size(21, 24)
        Me.lblt_ck.TabIndex = 18
        Me.lblt_ck.Text = "0"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(632, 414)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Tổng chiết khấu"
        '
        'lblt_tt
        '
        Me.lblt_tt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblt_tt.AutoSize = True
        Me.lblt_tt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblt_tt.Location = New System.Drawing.Point(878, 408)
        Me.lblt_tt.Name = "lblt_tt"
        Me.lblt_tt.Size = New System.Drawing.Size(21, 24)
        Me.lblt_tt.TabIndex = 20
        Me.lblt_tt.Text = "0"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(795, 414)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Tổng thanh toán"
        '
        'txtfilter
        '
        Me.txtfilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtfilter.Location = New System.Drawing.Point(745, 58)
        Me.txtfilter.Name = "txtfilter"
        Me.txtfilter.Size = New System.Drawing.Size(251, 20)
        Me.txtfilter.TabIndex = 21
        '
        'txtfilterkm
        '
        Me.txtfilterkm.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtfilterkm.Location = New System.Drawing.Point(745, 247)
        Me.txtfilterkm.Name = "txtfilterkm"
        Me.txtfilterkm.Size = New System.Drawing.Size(251, 20)
        Me.txtfilterkm.TabIndex = 22
        '
        'frmordertmp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 439)
        Me.Controls.Add(Me.txtfilterkm)
        Me.Controls.Add(Me.txtfilter)
        Me.Controls.Add(Me.lblt_tt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblt_ck)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnselectKH)
        Me.Controls.Add(Me.lblten_kh)
        Me.Controls.Add(Me.txtma_kh)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbbnh_vt)
        Me.Controls.Add(Me.lblt_tien)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.gridkmlist)
        Me.Controls.Add(Me.gridsplist)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gridkm)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.gridsp)
        Me.Name = "frmordertmp"
        Me.Text = "Đặt hàng tạm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gridsp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridkm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridsplist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridkmlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gridsp As DataGridView
    Friend WithEvents btnsave As Button
    Friend WithEvents btnprint As Button
    Friend WithEvents gridkm As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents gridsplist As DataGridView
    Friend WithEvents gridkmlist As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents lblt_tien As Label
    Friend WithEvents cbbnh_vt As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtma_kh As TextBox
    Friend WithEvents lblten_kh As Label
    Friend WithEvents btnselectKH As Button
    Friend WithEvents lblt_ck As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblt_tt As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtfilter As TextBox
    Friend WithEvents txtfilterkm As TextBox
End Class
