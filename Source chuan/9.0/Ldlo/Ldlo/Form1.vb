Imports Clsql
Imports ClsControl2
Imports ClsLookup
Public Class Frmmain
    Dim listid As String = "dlo"
    Dim WithEvents list As ClsList.List1
    Dim frmin As New frminput
    Dim dtdetail As DataTable
    Dim bindinsource As New BindingSource
    Dim dsml As DataTable
    Private Sub dmload(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        list = New ClsList.List1(listid, grd, frmin)
        list.AddToolStripMain(ToolStrip1)
        list.AddToolStripFind(ToolStrip1)
        PropertyOfForm.SetLable(list.oLable, Me)
        Me.Icon = frmin.Icon
        user.Text = Clsql.Reg.GetValue("ID")
        PropertyOfForm.SetImage4Control("user.bmp", user)
        AddHandler frmin.btnLuu.Click, AddressOf list.Save
        AddHandler frmin.btnhuy.Click, AddressOf list.Cancel
        dsml = ClsControl2.PropertyOfGrid.SetMaxLength(list.conn, frmin.griddetail, "dlodetail")
        Dim ongrid As New OnGrid(frmin.griddetail)
        'AddHandler frmin.griddetail.KeyDown, AddressOf ClsControl2.PropertyOfGrid.Paste
        ClsControl2.PropertyOfGrid.Lookups(list.conn, frmin.griddetail, "dlo", "dlo")
    End Sub
    Private Sub loadDetail(ByVal ma_lo As String)

        Dim query As String = "select * from vdlodetail where ma_lo ='" & ma_lo & "' order by line"
        dtdetail = list.conn.GetDatatable(query)
        bindinsource.DataSource = dtdetail
        If frmin.griddetail.ColumnCount = 0 Then
            ClsControl2.PropertyOfGrid.FillGrid(list.conn, "dlodetail", frmin.griddetail, bindinsource)
        End If

    End Sub
    Private Sub saveDetail(ByVal ma_lo As String)
        frmin.griddetail.EndEdit()
        bindinsource.EndEdit()
        dtdetail.AcceptChanges()
        Dim i As Integer = 0
        For Each r As DataRow In dtdetail.Rows
            r("line") = i
            r("ma_lo") = ma_lo
            i += 1
        Next
        Dim query As String = list.conn.GetInsertQueryFromDatatable(dtdetail, "dlodetail")
        query = "delete from dlodetail where ma_lo ='" & ma_lo & "'" & Chr(13) & query
        list.conn.Execute(query)

    End Sub
    Private Sub thoat(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuthoat.Click
        list = Nothing
        Me.Close()
    End Sub

    Private Sub list_AfterAddItem(ByVal row As System.Data.DataRow) Handles list.AfterAddItem
        saveDetail(row("ma_lo").ToString)
    End Sub

    Private Sub list_AfterDeleteItem(ByVal row As System.Data.DataRow) Handles list.AfterDeleteItem
        Dim query As String = "delete from dlodetail where ma_lo ='" & row("ma_lo").ToString & "'"
        list.conn.Execute(query)
    End Sub

    Private Sub list_AfterEditItem(ByVal row As System.Data.DataRow) Handles list.AfterEditItem
        saveDetail(row("ma_lo").ToString)
    End Sub

    Private Sub list_BeforeAddItem() Handles list.BeforeAddItem
        loadDetail("")
    End Sub

    Private Sub list_BeforeEditItem() Handles list.BeforeEditItem
        Try
            loadDetail(grd.CurrentRow.Cells("ma_lo").Value.ToString)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub list_SaveClick() Handles list.SaveClick
        If frmin.griddetail.RowCount <= 1 Then
            MsgBox("Bạn chưa nhập danh sách hàng hóa của lô", MsgBoxStyle.Exclamation, Me.Text)
            list.ContinueSave = False
        End If
        If ClsControl2.PropertyOfGrid.CheckFieldsBlank(frmin.griddetail, dsml) Then
            list.ContinueSave = False
        End If
    End Sub
End Class
