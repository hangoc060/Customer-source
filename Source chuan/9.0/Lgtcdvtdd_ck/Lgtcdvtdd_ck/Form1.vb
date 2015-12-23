Imports Clsql
Imports ClsControl2
Imports ClsLookup
Public Class Frmmain
    Dim listid As String
    Dim WithEvents list As ClsList.List1
    Dim frmin As New frminput
    Dim conn As Clsql.SQL
    Dim ky As Integer
    Dim nam As Integer
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
        'dieu kien loc
        Dim dkloc As New frmfilter
        dkloc.Icon = Me.Icon
        dkloc.StartPosition = FormStartPosition.CenterParent
        dkloc.Txtky.Value = Now.Month
        dkloc.Txtnam.Value = Now.Year
        ClsControl2.PropertyOfForm.KeyEnter(dkloc)
        ClsControl2.PropertyOfForm.SetLable(list.oLable, dkloc)
        If dkloc.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            ky = dkloc.Txtky.Value
            nam = dkloc.Txtnam.Value
            list.CSearch = "ky =" & ky & " and nam =" & nam
            list.LoadData("1=1")
            'list.Lookups.Item("txtma_yt").oKey = "ma_yt in (select ma_yt from gt_dmyt where kieu_yt=1)"
        Else
            Application.Exit()
            Return
        End If
        '
    End Sub
   
    Private Sub thoat(ByVal sender As Object, ByVal e As System.EventArgs)
        list = Nothing
        Me.Close()
    End Sub
    Private Sub list_AddItem() Handles list.BeforeAddItem

    End Sub
    Private Sub list_BeforeEditItem() Handles list.BeforeEditItem

    End Sub
    
    Private Sub list_BeforeSave(ByVal row As System.Data.DataRow) Handles list.BeforeSave
        
    End Sub

    Private Sub list_SaveClick() Handles list.SaveClick
        If list.Action = Actions.Action.Add Then
            list.CurrentRow("ky") = ky
            list.CurrentRow("nam") = nam
        End If
        
    End Sub
End Class
