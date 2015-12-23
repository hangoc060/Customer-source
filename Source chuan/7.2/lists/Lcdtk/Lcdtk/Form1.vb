Imports Clsql
Imports ClsControl2
Imports ClsStpService

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
        conn = list.conn
        PropertyOfForm.SetLable(list.oLable, Me)
        Me.Icon = frmin.Icon
        user.Text = Clsql.Reg.GetValue("ID")
        lblcty.Text = Clsql.Others.Options("cty_name", conn)
        loadl()
    End Sub

    Private Sub thoat(ByVal sender As Object, ByVal e As System.EventArgs)
        list = Nothing
        Me.Close()
    End Sub
    Private Sub list_AddItem() Handles list.BeforeAddItem

    End Sub
    Private Sub list_BeforeEditItem() Handles list.BeforeEditItem

        frmin.btnLuu.Enabled = Not conn.GetValue("select tk_cn from dmtk where tk ='" & grd.Item("tk", grd.CurrentRow.Index).Value.trim & "'")
        dn()
    End Sub

    Sub dn()
        Dim dmstt As StpTableRow = conn.GetRow("select * from dmstt")
        reonly = (Strings.Format(dmstt("ngay_ky1"), "ddMMyyyy") = Strings.Format(dmstt("ngay_dn"), "ddMMyyyy"))
        frmin.Txtdu_co_nt1.ReadOnly = reonly
        frmin.Txtdu_co1.ReadOnly = reonly
        frmin.Txtdu_no_nt1.ReadOnly = reonly
        frmin.Txtdu_no1.ReadOnly = reonly
        frmin.Txtdu_co_nt00.ReadOnly = False
        frmin.Txtdu_co00.ReadOnly = False
        frmin.Txtdu_no_nt00.ReadOnly = False
        frmin.Txtdu_no00.ReadOnly = False
        If reonly = False Then
            If frmin.btnLuu.Enabled = False Then
                frmin.Txtdu_co_nt00.ReadOnly = True
                frmin.Txtdu_co00.ReadOnly = True
                frmin.Txtdu_no_nt00.ReadOnly = True
                frmin.Txtdu_no00.ReadOnly = True
                frmin.btnLuu.Enabled = True
            End If
        End If
    End Sub
    Sub loadl()
        PropertyOfForm.SetImage4Control("user.bmp", user)
        list.AddToolStripFind(ToolStrip1)
        ToolStrip1.Items.Add(New ToolStripSeparator)
        list.AddToolStripMain(ToolStrip1)
        'disable or enable cac  tinh nang
        list.moi.Visible = False
        list.xoa.Visible = False
        'them menu
        list.AddMenuItem(mnfile)
        list.AddContextMenu()
        '
        AddHandler frmin.btnLuu.Click, AddressOf list.Save
        AddHandler frmin.btnhuy.Click, AddressOf list.Cancel
        Me.ContextMenuStrip = list.Contextmenu
        Dim nambd As Integer = conn.GetValue("select nam_bd from dmstt")

        'conn.Execute("exec fs_Convert2AccountBalance")
        list.LoadData("nam =" & nambd)

    End Sub

End Class
