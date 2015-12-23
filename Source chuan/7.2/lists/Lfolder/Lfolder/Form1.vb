﻿Imports Clsql
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
        list = New ClsList.List1(listid, grd, frmin, , "1=0")
        list.AddToolStripFind(ToolStrip1)
        ToolStrip1.Items.Add(New ToolStripSeparator)
        list.AddToolStripMain(ToolStrip1)
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

        Dim so_loai_nhom As Integer = 3
        If IsNumeric(Clsql.Others.GetArgu(2)) Then
            so_loai_nhom = Clsql.Others.GetArgu(2)
        End If
        'set default value
        Dim df As New Collection
        df.Add(1, "loai_nhom")
        list.ValueDefaults = df
    End Sub
   
    Private Sub thoat(ByVal sender As Object, ByVal e As System.EventArgs)
        list = Nothing
        Me.Close()
    End Sub
    Private Sub list_AddItem() Handles list.BeforeAddItem

    End Sub
    Private Sub list_BeforeEditItem() Handles list.BeforeEditItem

    End Sub

    Private Sub list_SaveClick() Handles list.SaveClick
        If list.Action = Actions.Action.Add Then
            list.CurrentRow("folder_id") = ClsVno.AutoCreateCode.CreateCode(conn, "folder", "folder_id", frmin.txtfolder_name.Text, 16)
        End If
    End Sub
End Class
