Imports Clsql
Imports ClsControl2
Imports ClsLookup
Imports System.Net
Imports System.Text
Public Class frmkbmau
    Dim listid As String
    Dim WithEvents list As ClsList.List1
    Dim frmin As New frminput
    Dim conn As Clsql.SQL
    Private Sub dmload(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        listid = rpt.cPrint.drvForm("tbform")
        list = New ClsList.List1(listid, grd, frmin, , "1=0")
        list.CSearch = "form ='" & rpt.cPrint.drvForm("idform") & "'"
        list.LoadData("1=1")
        list.AddToolStripFind(ToolStrip1)
        ToolStrip1.Items.Add(New ToolStripSeparator)
        list.AddToolStripMain(ToolStrip1)
        list.AddMenuItem(mnfile)
        list.AddContextMenu()
        AddHandler frmin.btnLuu.Click, AddressOf list.Save
        AddHandler frmin.btnhuy.Click, AddressOf list.Cancel
        Me.ContextMenuStrip = list.Contextmenu
        setuplookup()
        conn = list.conn
        ClsControl2.PropertyOfForm.SetLable(oLable, frmin)
        PropertyOfForm.SetLable(oLable, Me)
        frmin.Icon = Me.Icon
        user.Text = Clsql.Reg.GetValue("ID")
        lblcty.Text = Clsql.Others.Options("cty_name", conn)
        PropertyOfForm.SetImage4Control("user.bmp", user)
        'set gia tri mac dinh
        Dim defaultvalue As New Collection
        defaultvalue.Add(True, "in_ck")
        defaultvalue.Add(1, "type")
        defaultvalue.Add(1, "kind")
        defaultvalue.Add(rpt.cPrint.drvForm("idform"), "form")
        list.ValueDefaults = defaultvalue

        'conn.UploadFile(Encoding.Unicode.GetBytes("phạm quốc việt"), "test.txt", "ftp://ketoancanban.com", "saotienp", "stp!@#$%^")

    End Sub
    Sub setuplookup()
        AddItems.AddItemCbb(rpt.conn, "select headerv as text,headerE as text2,codeid from optgroupby where rptid='" & listid & "' and type = 9", frmin.cbbdbf, "text", "text2", "codeid")
        AddItems.AddItemCbb(rpt.conn, "select text,text2,inds from dmitemofcbb where form='" & listid & "' and name ='kind'", frmin.cbbkind, "text", "text2", "inds")
        AddItems.AddItemCbb(rpt.conn, "select text,inds from dmitemofcbb where form='" & listid & "' and name ='type'", frmin.cbbtype, "text", "text", "inds")
    End Sub
    Private Sub list_SaveClick() Handles list.SaveClick
        If frmin.txtcach_tinh.Text.Trim <> "" Then
            list.ContinueSave = ClsRpt.Check.CheckFormula(frmin.txtcach_tinh.Text, list.datatable, "ma_so")
        End If
    End Sub
End Class