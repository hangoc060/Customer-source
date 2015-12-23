Imports Clsql
Imports ClsControl2
Imports ClsLookup
Public Class Frmmain
    Dim listid As String
    Dim WithEvents list As ClsList.List1
    Dim frmin As New frminput
    Dim conn As Clsql.SQL
    Private Sub dmload(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ClsControl2.PropertyOfForm.CheckRegister = False Then
            Me.Close()
        End If
        listid = Clsql.Others.GetArgu(1)
        Try
            list = New ClsList.List1(listid, grd, frmin, , "1=0")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        list.AddToolStripFind(ToolStrip1)
        ToolStrip1.Items.Add(New ToolStripSeparator)
        list.AddToolStripMain(ToolStrip1)
        list.TD1.Visible = list.sua.Visible
        list.TD1.Text = "Điều chỉnh giá"
        AddHandler list.TD1.Click, AddressOf doigia
        'disable or enable cac  tinh nang
        '  list.moi.Visible = False
        ' list.xoa.Visible = False
        'them menu
        list.AddMenuItem(mnfile)
        list.AddContextMenu()
        '
        AddHandler frmin.btnLuu.Click, AddressOf list.Save
        AddHandler frmin.btnhuy.Click, AddressOf list.Cancel
        Me.ContextMenuStrip = list.Contextmenu
        conn = list.conn
        PropertyOfForm.SetLable(list.oLable, Me)
        Me.Icon = frmin.Icon
        user.Text = Clsql.Reg.GetValue("ID")
        lblcty.Text = Clsql.Others.Options("cty_name", conn)
        PropertyOfForm.SetImage4Control("user.bmp", user)
        list.LoadData("1=1")
        Dim lookup As New Threading.Thread(AddressOf setuplookup)
        lookup.Start()
        ''set default value
        'Dim df As New Collection
        'df.Add(conn.GetValue("select nam_bd from dmstt"), "nam")
        'list.ValueDefaults = df
    End Sub
    Private Sub doigia()
        Dim f As New frmDcgia
        f.Icon = Me.Icon
        f.Text = list.TD1.Text
        If f.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            If MsgBox("Bạn có chắc chắn điểu chỉnh giá cho tất cả mọi sản phẩm không?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
                conn.Server.writeLog("Giá đã được điều chỉnh hàng loạt bời " & Reg.GetValue("id"), "dieuchinhgiahangloat_")
                Dim query As String = "exec dcgiaban " & f.cbbloai_gia.SelectedIndex & "," & f.txtty_le.Value & "," & f.txtGia_tri.Value & ",'" & Reg.GetValue("id") & "'"
                conn.Execute(query)
                list.tim.PerformClick()
            End If
        End If
    End Sub
    Private Sub thoat(ByVal sender As Object, ByVal e As System.EventArgs)
        list = Nothing
        Me.Close()
    End Sub
    Private Sub list_AddItem() Handles list.BeforeAddItem

    End Sub
    Private Sub list_BeforeEditItem() Handles list.BeforeEditItem

    End Sub
    Sub setuplookup()

    End Sub
End Class
