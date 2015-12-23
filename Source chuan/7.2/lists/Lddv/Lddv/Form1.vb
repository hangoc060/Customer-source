Imports Clsql
Imports ClsControl2
Imports ClsLookup
Public Class Frmmain
    Dim listid As String = "ddv"
    Dim WithEvents list As ClsList.List
    Dim frmin As New frminput
    Private Sub dmload(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        list = New ClsList.List(listid, btnNew, btnEdit, btnDel, frmin.btnLuu, frmin.btnhuy, grd, frmin)
        AddHandler mnuMoi.Click, AddressOf list.moi_Click
        AddHandler mnuSua.Click, AddressOf list.sua_Click
        AddHandler mnuXoa.Click, AddressOf list.xoa_Click
        PropertyOfForm.SetLable(list.oLable, Me)
        Me.Icon = frmin.Icon
        user.Text = Clsql.Reg.GetValue("ID")
        PropertyOfForm.SetImage4Control("user.bmp", user)
    End Sub
   
    Private Sub thoat(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuthoat.Click
        list = Nothing
        Me.Close()
    End Sub

    Private Sub list_AfterAddItem(ByVal e As System.Data.DataRow) Handles list.AfterAddItem
        list.conn.Execute("exec fs_Convert2AccountBalance_v2 '" & e.Item("ma_dvcs") & "'")
    End Sub

    Private Sub list_AfterDeleteItem(ByVal e As System.Data.DataRow) Handles list.AfterDeleteItem
        list.conn.Execute("exec fs_Convert2AccountBalance_v2 '" & e.Item("ma_dvcs") & "'")
    End Sub

    Private Sub list_AfterEditItem(ByVal e As Object) Handles list.AfterEditItem
        list.conn.Execute("exec fs_Convert2AccountBalance_v2 '" & e.Item("ma_dvcs") & "'")
    End Sub

   
End Class
