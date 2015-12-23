Module Main
    Public conn As New Clsql.SQL
    Public olan As Collection
    Public dt As DataTable
    Public cprint As ClPrint.Print
    Public checkright As ClsRight.CheckRight
    Public kv_ht As StpPan.ResItemArea
    Public ma_res As String
    Public f As New Form1
    Public fChooseRes As New formChooseRes
    Sub Main()
        If Clsql.Reg.GetValue("SLG") = 0 Then
            Application.Exit()
            Return
        End If
        'check right
        Dim ma_cn As String = conn.GetValue("select id from " & Clsql.Others.Options("cmd_table", conn) & " where ma_cn ='" & Clsql.Others.GetArgu(1) & "'")
        If ma_cn Is Nothing Or ma_cn Is DBNull.Value Then
            Application.Exit()
            Return
        End If

        checkright = New ClsRight.CheckRight(conn, ma_cn)
        If Not checkright.ViewRight Then
            Application.Exit()
            Return
        End If
        'choose restaurent
        Dim imglist As New ImageList
        imglist.ColorDepth = ColorDepth.Depth32Bit
        imglist.ImageSize = New Size(48, 48)

        Dim file As New IO.FileInfo("Images\qlnh\res.png")
        If file.Exists Then
            imglist.Images.Add("res", Image.FromFile("Images\qlnh\res.png"))
        End If

        fChooseRes.listRes.SmallImageList = imglist
        fChooseRes.listRes.LargeImageList = imglist
        Dim dtres As DataTable = conn.GetDatatable("select * from res_dmres where trang_thai=1")
        For Each r As DataRow In dtres.Rows
            Dim item As New ListViewItem
            item.Name = r("ma_res")
            If conn.Lang = Clsql.SQL.Language.Vietnamese Then
                item.Text = r("ten_res")
            Else
                item.Text = r("ten_res2")
            End If
            item.ImageIndex = 0
            fChooseRes.listRes.Items.Add(item)

        Next
        If fChooseRes.ShowDialog <> DialogResult.OK Or fChooseRes.listRes.SelectedItems.Count = 0 Then
            Return
        End If

        ma_res = fChooseRes.listRes.SelectedItems(0).Name
        'load ds khu vuc
        loadKV()
        'load loai ban
        Dim dtloaiban As DataTable = conn.GetDatatable("select * from res_dmloaiban where trang_thai = 1")
        For Each r As DataRow In dtloaiban.Rows
            Dim b As New StpPan.ResItemTableType
            b.AllowDrap = True
            b.AllowResize = False
            b.Title = r("ten_loai_ban")
            b.Name = r("ma_loai_ban")
            b.AllowUserDelete = False
            b.BackColor = Color.FromArgb(r("backcolor"))
            b.ForeColor = Color.FromArgb(r("forecolor"))
            b.UnSelectColor = b.BackColor
            b.Width = 100
            b.Height = 40
            AddHandler b.OptionsChangedEvent, AddressOf optionchange_loaiban
            f.PanelTableType.Controls.Add(b)
        Next


        f.ShowDialog()
    End Sub
    Public Sub loadKV()
        f.PanelArea.Controls.Clear()
        Dim dtkhvuc As DataTable = conn.GetDatatable("select * from res_dmkv where trang_thai=1 and ma_res ='" & ma_res & "' order by stt")
        For Each r As DataRow In dtkhvuc.Rows
            Dim kv As New StpPan.ResItemArea()
            If conn.Lang = Clsql.SQL.Language.Vietnamese Then
                kv.Title = r("ten_kv")
            Else
                kv.Title = r("ten_kv2")
            End If
            kv.Name = r("ma_kv")
            AddHandler kv.ResItemSelected, AddressOf area_click
            f.PanelArea.Controls.Add(kv)
        Next
        For Each kv As StpPan.ResItemArea In f.PanelArea.Controls
            kv.Selected()
            Exit For
        Next
    End Sub
    Public Sub area_click(ByVal s As StpPan.ResItemArea)
        kv_ht = s
        'load danh sach ban cua khu vuc
        f.PanelTable.Controls.Clear()
        Dim dt As DataTable = conn.GetDatatable("select * from res_dmban where trang_thai=1 and ma_kv ='" & s.Name & "'")
        For Each r As DataRow In dt.Rows
            If r("ma_loai_ban") = "L02" Then
                loadTable(r)
            Else
                loadOther(r)
            End If

        Next
    End Sub
    Public Sub loadTable(ByVal r As DataRow)
        Dim tb As New StpPan.ResItemTable
        tb.Name = r("ma_ban")
        tb.Title = r("ten_ban")
        tb.Type = r("ma_loai_ban")
        tb.Location = New Point(r("x"), r("y"))
        tb.Width = r("width")
        tb.Height = r("height")
        tb.AllowDrap = True
        tb.AllowResize = True
        tb.AllowOptions = True

        tb.BackColor = Color.FromArgb(r("backcolor"))
        tb.ForeColor = Color.FromArgb(r("forecolor"))
        tb.UnSelectColor = Color.FromArgb(r("backcolor"))


        AddHandler tb.OptionsChangedEvent, AddressOf optionchange
        AddHandler tb.ResItemResize, AddressOf resizeTable
        AddHandler tb.DeletedEvent, AddressOf deletedTable
        f.PanelTable.Controls.Add(tb)
    End Sub
    Public Sub loadOther(ByVal r As DataRow)
        Dim tb As New StpPan.ResItemOther
        tb.Name = r("ma_ban")
        tb.Title = r("ten_ban")
        tb.Type = r("ma_loai_ban")
        tb.Location = New Point(r("x"), r("y"))
        tb.Width = r("width")
        tb.Height = r("height")
        tb.AllowDrap = True
        tb.AllowResize = True
        tb.AllowOptions = True

        tb.BackColor = Color.FromArgb(r("backcolor"))
        tb.ForeColor = Color.FromArgb(r("forecolor"))
        tb.UnSelectColor = Color.FromArgb(r("backcolor"))


        AddHandler tb.OptionsChangedEvent, AddressOf optionchange
        AddHandler tb.ResItemResize, AddressOf resizeTable
        AddHandler tb.DeletedEvent, AddressOf deletedTable
        f.PanelTable.Controls.Add(tb)
    End Sub
    Public Sub resizeTable(ByVal tb As Object)
        Dim query As String = "update res_dmban set width =" & tb.Width
        query = query & ",height =" & tb.Height
        query = query & " where ma_ban='" & tb.Name & "'"
        conn.Execute(query)
    End Sub
    Public Sub optionchange(ByVal tb As Object)
        Dim query As String = "update res_dmban set backcolor =" & tb.BackColor.ToArgb
        query = query & ",forecolor =" & tb.ForeColor.ToArgb
        query = query & ",ten_ban =N'" & tb.Title & "'"
        query = query & ",ten_ban2 =N'" & tb.Title & "'"
        query = query & " where ma_ban='" & tb.Name & "'"
        conn.Execute(query)
    End Sub
    Public Sub optionchange_loaiban(ByVal tb As StpPan.ResItemTableType)
        Dim query As String = "update res_dmloaiban set backcolor =" & tb.BackColor.ToArgb
        query = query & ",forecolor =" & tb.ForeColor.ToArgb
        query = query & ",ten_loai_ban =N'" & tb.Title & "'"
        query = query & ",ten_loai_ban2 =N'" & tb.Title & "'"
        query = query & " where ma_loai_ban='" & tb.Name & "'"
        conn.Execute(query)
    End Sub
    Public Sub deletedTable(ByVal tb As Object)
        Dim query As String = "delete res_dmban "
        query = query & " where ma_ban='" & tb.Name & "'"
        conn.Execute(query)
    End Sub
End Module
