<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDcgia
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtty_le = New ClsControl2.TxtNumeric
        Me.txtGia_tri = New ClsControl2.TxtNumeric
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnOk = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbbloai_gia = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Điều chỉnh giá theo tỷ lệ(%)"
        '
        'txtty_le
        '
        Me.txtty_le.Location = New System.Drawing.Point(192, 35)
        Me.txtty_le.MaxLength = 18
        Me.txtty_le.Name = "txtty_le"
        Me.txtty_le.NumberDecimalDigits = 2
        Me.txtty_le.Size = New System.Drawing.Size(233, 20)
        Me.txtty_le.TabIndex = 1
        Me.txtty_le.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtty_le.Value = 0
        Me.txtty_le.Value2 = 0
        '
        'txtGia_tri
        '
        Me.txtGia_tri.Location = New System.Drawing.Point(192, 61)
        Me.txtGia_tri.MaxLength = 18
        Me.txtGia_tri.Name = "txtGia_tri"
        Me.txtGia_tri.NumberDecimalDigits = 2
        Me.txtGia_tri.Size = New System.Drawing.Size(233, 20)
        Me.txtGia_tri.TabIndex = 3
        Me.txtGia_tri.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtGia_tri.Value = 0
        Me.txtGia_tri.Value2 = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Điều chỉnh giá theo giá trị"
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(13, 98)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 4
        Me.btnOk.Text = "Nhận"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(104, 98)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Hủy"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Loại giá"
        '
        'cbbloai_gia
        '
        Me.cbbloai_gia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbloai_gia.FormattingEnabled = True
        Me.cbbloai_gia.Items.AddRange(New Object() {"Giá bán lẻ", "Giá bán buôn 1", "Giá bán buôn 2", "Giá bán buôn 3", "Giá bán buôn 4"})
        Me.cbbloai_gia.Location = New System.Drawing.Point(192, 10)
        Me.cbbloai_gia.Name = "cbbloai_gia"
        Me.cbbloai_gia.Size = New System.Drawing.Size(233, 21)
        Me.cbbloai_gia.TabIndex = 0
        '
        'frmDcgia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 130)
        Me.Controls.Add(Me.cbbloai_gia)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.txtGia_tri)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtty_le)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmDcgia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmDcgia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtty_le As ClsControl2.TxtNumeric
    Friend WithEvents txtGia_tri As ClsControl2.TxtNumeric
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbbloai_gia As System.Windows.Forms.ComboBox
End Class
