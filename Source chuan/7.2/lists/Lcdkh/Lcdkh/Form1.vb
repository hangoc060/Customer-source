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
        Dim nambd As Integer = conn.GetValue("select nam_bd from dmstt")
        list.LoadData("nam=" & nambd)
        
        'set default value
        Dim df As New Collection
        df.Add(nambd, "nam")
        list.ValueDefaults = df

        setuplookup()
    End Sub
   
    Private Sub thoat(ByVal sender As Object, ByVal e As System.EventArgs)
        list = Nothing
        Me.Close()
    End Sub
   
    Sub setuplookup()
        Dim Otk As New ClsLookup.AutoCompleteLookup(conn, "dmtk", frmin.txttk, "tk")
        Otk.oKey = "loai_tk = 0 and tk_cn =1"
        Otk.SetValue("ten_tk", frmin.lblten_tk)

        Dim Okh As New ClsLookup.AutoCompleteLookup(conn, "dmkh", frmin.txtma_kh, "ma_kh")
        Okh.SetValue("ten_kh", frmin.lblten_kh)

        Dim Odv As New ClsLookup.AutoCompleteLookup(conn, "dmdv", frmin.txtma_dvcs, "ma_dvcs")
        Odv.SetValue("ten_dvcs", frmin.lblten_dvcs)
    End Sub

    Private Sub list_AfterAddItem(ByVal row As System.Data.DataRow) Handles list.AfterAddItem
        list.conn.Execute("exec Convert2AccountBalanceFromCustomerBalance_v2 '" & row.Item("ma_dvcs") & "'")
    End Sub

    Private Sub list_AfterDeleteItem(ByVal row As System.Data.DataRow) Handles list.AfterDeleteItem
        list.conn.Execute("exec Convert2AccountBalanceFromCustomerBalance_v2 '" & row.Item("ma_dvcs") & "'")
    End Sub

    Private Sub list_AfterEditItem(ByVal row As System.Data.DataRow) Handles list.AfterEditItem
        list.conn.Execute("exec Convert2AccountBalanceFromCustomerBalance_v2 '" & row.Item("ma_dvcs") & "'")
    End Sub
End Class
