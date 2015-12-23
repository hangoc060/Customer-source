Imports Clsql
Imports ClsControl2
Imports ClsLookup
Public Class Frmmain
    Dim listid As String
    Dim WithEvents list As ClsList.List1
    Dim frmin As New frminput
    Dim conn As Clsql.SQL
    Dim f As New frmfilter
    Private Sub dmload(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ClsControl2.PropertyOfForm.CheckRegister = False Then
            Me.Close()
        End If
        listid = Clsql.Others.GetArgu(1)

        list = New ClsList.List1(listid, grd, frmin, , "1=0")
        conn = list.conn
        frmin.txtloc.Maximum = 3

        frmin.txtloc.Minimum = 1
        list.AddToolStripFind(ToolStrip1)
        ToolStrip1.Items.Add(New ToolStripSeparator)
        list.AddToolStripMain(ToolStrip1)
        'dang ky chung tu ghi so
        list.TD1.Visible = True
        ClsControl2.PropertyOfForm.SetImage4Control("reg.bmp", list.TD1)
        list.TD1.Text = list.oLable("200")
        AddHandler list.TD1.Click, AddressOf reg_ctgs
        'huy dang ky
        list.TD2.Visible = True
        ClsControl2.PropertyOfForm.SetImage4Control("cancel.bmp", list.TD2)
        list.TD2.Text = list.oLable("202")
        AddHandler list.TD2.Click, AddressOf cancel_ctgs
        'in
        list.Inds.Visible = True
        AddHandler list.BeforePrint, AddressOf setparamenter
        'them menu
        list.AddMenuItem(mnfile)
        list.AddContextMenu()
        '
        AddHandler frmin.btnLuu.Click, AddressOf list.Save
        AddHandler frmin.btnhuy.Click, AddressOf list.Cancel
        Me.ContextMenuStrip = list.Contextmenu

        PropertyOfForm.SetLable(list.oLable, Me)
        Me.Icon = frmin.Icon
        user.Text = Clsql.Reg.GetValue("ID")
        lblcty.Text = Clsql.Others.Options("cty_name", conn)
        PropertyOfForm.SetImage4Control("user.bmp", user)
        '

        ClsControl2.PropertyOfForm.SetLable(list.oLable, f)
        f.Icon = Me.Icon
        If f.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dk As String = "ngay_ct_gs between " & conn.ConvertToSQLType(f.Txttu_ngay.Value) & " and " & conn.ConvertToSQLType(f.Txtden_ngay.Value)
            list.CSearch = dk
            list.LoadData("1=1")
            grd.ReadOnly = False
        Else
            Application.Exit()
        End If
        
    End Sub

    Private Sub setparamenter(ByVal rpt As ClsRpt.rpt)
        
        rpt.cPrint.SetParameterValue("tu_ngay", f.Txttu_ngay.Value)

        rpt.cPrint.SetParameterValue("den_ngay", f.Txtden_ngay.Value)

    End Sub
   

    Private Sub thoat(ByVal sender As Object, ByVal e As System.EventArgs)
        list = Nothing
        Me.Close()
    End Sub

    Private Sub list_AfterDeleteItem(ByVal row As System.Data.DataRow) Handles list.AfterDeleteItem
        Dim query As String = "exec del_ctgs " & conn.ConvertToSQLType(row("so_ct_gs")) & "," & conn.ConvertToSQLType(row("ngay_ct_gs"))
        conn.Execute(query)
    End Sub

    Private Sub list_AfterLoadData() Handles list.AfterLoadData
        grd.ReadOnly = False
    End Sub

   
    Private Sub list_AddItem() Handles list.BeforeAddItem

    End Sub
    Private Sub list_BeforeEditItem() Handles list.BeforeEditItem

    End Sub
    Sub reg_ctgs(ByVal s As Object, ByVal e As Object)
        Dim query As String = ""
        grd.EndEdit()
        Dim q = From r As DataGridViewRow In grd.Rows Where r.Cells("sel").Value = True
        If q.Count > 0 Then
            For Each r As DataGridViewRow In q
                query = " exec reg_ctgs " & conn.ConvertToSQLType(r.Cells("so_ct_gs").Value)
                query = query & "," & conn.ConvertToSQLType(r.Cells("ngay_ct_gs").Value)
                conn.Execute(query)
                Dim tien, tien_nt As Double
                tien = conn.GetValue("select sum(tien) from socai where so_ct_gs =" & conn.ConvertToSQLType(r.Cells("so_ct_gs").Value) & " and ngay_ct_gs =" & conn.ConvertToSQLType(r.Cells("ngay_ct_gs").Value))
                tien_nt = conn.GetValue("select sum(tien_nt) from socai where so_ct_gs =" & conn.ConvertToSQLType(r.Cells("so_ct_gs").Value) & " and ngay_ct_gs =" & conn.ConvertToSQLType(r.Cells("ngay_ct_gs").Value))
                r.Cells("tien").Value = tien
                r.Cells("tien_nt").Value = tien_nt
                conn.Execute("update dsctgs set tien =" & tien & ",tien_nt =" & tien_nt & " where so_ct_gs =" & conn.ConvertToSQLType(r.Cells("so_ct_gs").Value) & " and ngay_ct_gs =" & conn.ConvertToSQLType(r.Cells("ngay_ct_gs").Value))
                r.Cells("ghi_so_yn").Value = True
            Next
            MsgBox(list.oLable("201"), , Me.Text)
        End If
        

    End Sub
    Sub cancel_ctgs(ByVal s As Object, ByVal e As Object)
        Dim query As String = ""
        grd.EndEdit()
        Dim q = From r As DataGridViewRow In grd.Rows Where r.Cells("sel").Value = True
        If q.Count > 0 Then
            For Each r As DataGridViewRow In q
                query = " exec del_ctgs " & conn.ConvertToSQLType(r.Cells("so_ct_gs").Value)
                query = query & "," & conn.ConvertToSQLType(r.Cells("ngay_ct_gs").Value)
                conn.Execute(query)
                r.Cells("ghi_so_yn").Value = False
                conn.Execute("update dsctgs set tien =0,tien_nt =0 where so_ct_gs =" & conn.ConvertToSQLType(r.Cells("so_ct_gs").Value) & " and ngay_ct_gs =" & conn.ConvertToSQLType(r.Cells("ngay_ct_gs").Value))
                r.Cells("tien").Value = 0
                r.Cells("tien_nt").Value = 0
            Next

            MsgBox(list.oLable("201"), , Me.Text)
        End If
       
    End Sub

End Class
