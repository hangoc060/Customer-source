Imports Clsql
Imports ClsControl2
Imports ClsLookup
Public Class Frmmain
    Dim listid As String
    Dim WithEvents list As ClsList.List1   'chú ý
    Dim frmin As New frminput               'chú ý
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
        If Not (list.onlyAdd Or list.onlyDelete Or list.onlyEdit) Then
            'THÊM BUTTON
            list.TD1.Visible = True
            list.TD1.Text = list.oLable("Z01") 'Nhớ vào tùy chọn --> nhãn --> thêm vào
            PropertyOfForm.SetImage4Control("file.png", list.TD1)  'Image cho nút
            AddHandler list.TD1.Click, AddressOf Xemfile  'Sụ kien nhan nut

            PropertyOfForm.SetLable(list.oLable, Me)
            Me.Icon = frmin.Icon
            user.Text = Clsql.Reg.GetValue("ID")
            lblcty.Text = Clsql.Others.Options("cty_name", conn)
            PropertyOfForm.SetImage4Control("user.bmp", user)
            list.LoadData("1=1")
        End If
        setuplookup()
    End Sub

    Sub Xemfile(ByVal sender As Object, ByVal e As Object)
        If grd.RowCount > 0 Then
            If Not IsDBNull(grd.CurrentRow.Cells("dinh_kem").Value) Then
                Clsql.Data.OpenFileFromDB(grd.CurrentRow.Cells("dinh_kem").Value, grd.CurrentRow.Cells("file_dk").Value)
            End If
        End If
    End Sub

    Private Sub thoat(ByVal sender As Object, ByVal e As System.EventArgs)
        list = Nothing
        Me.Close()
    End Sub

    Sub setuplookup()
        Dim macq As New ClsLookup.AutoCompleteLookup(list.conn, "dmcqph", frmin.txtco_quan_ph, "ma_cq", False)
        Dim loai As New ClsLookup.AutoCompleteLookup(list.conn, "loaitl", frmin.txtloai_tl, "ma_loai", False)
        If Clsql.Reg.GetValue("Language") = "Vi" Then
            macq.SetValue("ten_cq", frmin.lblten_cq)
            loai.SetValue("ten_loai", frmin.lblten_loai)

        Else 'Nếu là tiếng Anh            
            macq.SetValue("ten_cq", frmin.lblten_cq)
            loai.SetValue("ten_loai2", frmin.lblten_loai)
        End If
    End Sub

    'Luu file vao CSDL
    Private Sub list_BeforeSave(ByVal row As System.Data.DataRow) Handles list.BeforeSave
        If luu_file IsNot Nothing Then
            row("dinh_kem") = luu_file
        End If
    End Sub
End Class
