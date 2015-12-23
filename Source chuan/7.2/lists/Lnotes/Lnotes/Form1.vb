Imports Clsql
Imports ClsControl2
Imports ClsLookup
Public Class Frmmain
    Dim listid As String
    Dim WithEvents list As ClsList.List1
    Dim frmin As New frminput
    Private Sub dmload(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ClsControl2.PropertyOfForm.CheckRegister = False Then
            Me.Close()
        End If
        listid = Clsql.Others.GetArgu(1)
        list = New ClsList.List1(listid, grd, frmin, , "1=0")

        list.AddToolStripFind(ToolStrip1)
        ToolStrip1.Items.Add(New ToolStripSeparator)
        list.AddToolStripMain(ToolStrip1)
        
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
    End Sub
   
    Private Sub thoat(ByVal sender As Object, ByVal e As System.EventArgs)
        list = Nothing
        Me.Close()
    End Sub

    Private Sub list_AfterAddItem(ByVal row As System.Data.DataRow) Handles list.AfterAddItem
        If frmin.Linkdoc.Tag <> "add" Then
            Dim query As String = "update dmtl set ma_gc ='" & row("ma_gc") & "' where ma_tl ='" & frmin.Linkdoc.Tag & "'"
            conn.Execute(query)
        End If
        
    End Sub

    Private Sub list_AfterDeleteItem(ByVal row As System.Data.DataRow) Handles list.AfterDeleteItem
        Dim dtdoc As DataTable = conn.GetDatatable("select ma_tl from dmtl where ma_gc ='" & row("ma_gc") & "'")
        If dtdoc.Rows.Count > 0 Then
            conn.Execute("delete from dmtl where ma_tl ='" & dtdoc.Rows(0).Item("ma_tl") & "'")
        End If
    End Sub

    Private Sub list_AfterEditItem(ByVal row As System.Data.DataRow) Handles list.AfterEditItem
        If frmin.Linkdoc.Tag <> "add" Then
            Dim query As String = "update dmtl set ma_gc ='" & row("ma_gc") & "' where ma_tl ='" & frmin.Linkdoc.Tag & "'"
            conn.Execute(query)
        End If
    End Sub
    Private Sub list_AddItem() Handles list.BeforeAddItem
        frmin.Linkdoc.Text = "Thêm mới"
        frmin.Linkdoc.Tag = "add"
        frmin.LinkDelete.Visible = False
    End Sub
    Private Sub list_BeforeEditItem() Handles list.BeforeEditItem
        Dim dtdoc As DataTable = conn.GetDatatable("select file_dk,ma_tl from dmtl where ma_gc ='" & grd.CurrentRow.Cells("ma_gc").Value & "'")
        If dtdoc.Rows.Count > 0 Then
            frmin.Linkdoc.Text = dtdoc.Rows(0)("file_dk")
            frmin.Linkdoc.Tag = dtdoc.Rows(0)("ma_tl")
            frmin.LinkDelete.Visible = True
        Else
            frmin.Linkdoc.Text = "Thêm mới"
            frmin.Linkdoc.Tag = "add"
            frmin.LinkDelete.Visible = False
        End If
    End Sub

End Class
