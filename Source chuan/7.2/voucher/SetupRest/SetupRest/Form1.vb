Public Class Form1
   
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        txtuser.Text = Clsql.Reg.GetValue("ID")
        olan = ClsControl2.PropertyOfForm.SetLable(conn, Me, Clsql.Others.GetArgu(1))
        ClsControl2.PropertyOfForm.KeyEnter(Me)
       
    End Sub


    Private Sub PanelTable_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PanelTable.DragDrop
        If currentCursor Is Nothing Then
            Return
        End If

        Dim p As New Point(PanelTable.PointToClient(New Point(e.X - currentCursor.Width / 2, e.Y - currentCursor.Height / 2)))

        'copy
        If e.Data.GetDataPresent(GetType(StpPan.ResItemTableType)) Then
            Dim tb As StpPan.ResItemTableType = e.Data.GetData(GetType(StpPan.ResItemTableType))
            If tb.Name = "L02" Then
                addTable(tb, p)
            Else
                addOther(tb, p)
            End If
            tb.Show()

        Else
            If e.Data.GetDataPresent(GetType(StpPan.ResItemTable)) Then
                Dim tb As StpPan.ResItemTable = e.Data.GetData(GetType(StpPan.ResItemTable))
                'If p.X >= tb.Location.X And p.X <= tb.Location.X + tb.Width And p.Y >= tb.Location.Y And p.Y <= tb.Location.Y + tb.Height Then
                '    Return
                'End If
                'move
                PanelTable.Controls.Add(tb)
                tb.Location = p
                tb.Show()
                'update position
                Dim r As String = "update res_dmban set x =" & tb.Location.X & ", y=" & tb.Location.Y
                r = r & " where ma_ban ='" & tb.Name & "'"
                conn.Execute(r)
            Else
                If e.Data.GetDataPresent(GetType(StpPan.ResItemOther)) Then
                    Dim tb As StpPan.ResItemOther = e.Data.GetData(GetType(StpPan.ResItemOther))
                    'If p.X >= tb.Location.X And p.X <= tb.Location.X + tb.Width And p.Y >= tb.Location.Y And p.Y <= tb.Location.Y + tb.Height Then
                    '    Return
                    'End If
                    'move
                    PanelTable.Controls.Add(tb)
                    tb.Location = p
                    tb.Show()
                    'update position
                    Dim r As String = "update res_dmban set x =" & tb.Location.X & ", y=" & tb.Location.Y
                    r = r & " where ma_ban ='" & tb.Name & "'"
                    conn.Execute(r)
                End If
            End If

        End If

    End Sub

    Private Sub addOther(ByVal tb As StpPan.ResItemTableType, ByVal p As Point)
        Dim ntb As New StpPan.ResItemOther
        ntb.AllowUserDelete = True
        ntb.AllowResize = True
        ntb.Type = tb.Name
        ntb.ForeColor = tb.ForeColor
        ntb.BackColor = tb.BackColor
        ntb.UnSelectColor = tb.BackColor

        PanelTable.Controls.Add(ntb)
        ntb.Location = p
        'creat name or id
        Dim m = conn.GetValue("select max(cast(ma_ban as numeric(18,0))) as stt from res_dmban")
        m = m + 1
        ntb.Name = Strings.Format(m, "00000000")

        ntb.Title = tb.Title
        'save to database
        saveTable(ntb)
        AddHandler ntb.OptionsChangedEvent, AddressOf optionchange
        AddHandler ntb.ResItemResize, AddressOf resizeTable
        AddHandler ntb.DeletedEvent, AddressOf deletedTable
        
    End Sub
    Private Sub addTable(ByVal tb As StpPan.ResItemTableType, ByVal p As Point)
        Dim ntb As New StpPan.ResItemTable
        ntb.AllowUserDelete = True
        ntb.AllowResize = True
        ntb.Type = tb.Name

        ntb.ForeColor = tb.ForeColor
        ntb.BackColor = tb.BackColor
        ntb.UnSelectColor = tb.BackColor
        ntb.Status = 0
        PanelTable.Controls.Add(ntb)
        ntb.Location = p
        'creat name or id
        Dim m = conn.GetValue("select max(cast(ma_ban as numeric(18,0))) as stt from res_dmban")
        m = m + 1
        ntb.Name = Strings.Format(m, "00000000")

        ntb.Title = tb.Title
        'save to database
        saveTable(ntb)
        '
        AddHandler ntb.OptionsChangedEvent, AddressOf optionchange
        AddHandler ntb.ResItemResize, AddressOf resizeTable
        AddHandler ntb.DeletedEvent, AddressOf deletedTable
        
    End Sub
    Private Sub saveTable(ByVal ntb As Object)
        Dim r As String = "insert into res_dmban (ma_kv,ma_loai_ban,ma_ban,ten_ban,ten_ban2,stt,x,y,width,height,backcolor,forecolor,trang_thai,status)"
        r = r + " values ("
        r = r + conn.ConvertToSQLType(kv_ht.Name)
        r = r + "," + conn.ConvertToSQLType(ntb.Type)
        r = r + "," + conn.ConvertToSQLType(ntb.Name)
        r = r + "," + conn.ConvertToSQLType(ntb.Title)
        r = r + "," + conn.ConvertToSQLType(ntb.Title)
        r = r + ",0"
        r = r + "," + conn.ConvertToSQLType(ntb.Location.X)
        r = r + "," + conn.ConvertToSQLType(ntb.Location.Y)
        r = r + "," + conn.ConvertToSQLType(ntb.Width)
        r = r + "," + conn.ConvertToSQLType(ntb.Height)
        r = r + "," + conn.ConvertToSQLType(ntb.BackColor.ToArgb)
        r = r + "," + conn.ConvertToSQLType(ntb.ForeColor.ToArgb)
        r = r + "," + conn.ConvertToSQLType(True)
        r = r + "," + conn.ConvertToSQLType(0)
        r = r + ")"

        conn.Execute(r)
    End Sub
    Dim currentCursor As StpPan.ResItem
    Private Sub PanelTable_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PanelTable.DragEnter
        currentCursor = Nothing
        If e.Data.GetDataPresent(GetType(StpPan.ResItemTable)) Then
            Dim tb As StpPan.ResItemTable = e.Data.GetData(GetType(StpPan.ResItemTable))
            e.Effect = DragDropEffects.Move
            currentCursor = tb
            tb.Hide()
            Cursor.Current = StpPan.ResItemTable.CreateCursor(tb)

        Else
            If e.Data.GetDataPresent(GetType(StpPan.ResItemTableType)) Then
                Dim tb As StpPan.ResItemTableType = e.Data.GetData(GetType(StpPan.ResItemTableType))
                e.Effect = DragDropEffects.Copy
                currentCursor = tb
                Cursor.Current = StpPan.ResItemTable.CreateCursor(tb)
            Else
                If e.Data.GetDataPresent(GetType(StpPan.ResItemOther)) Then
                    Dim tb As StpPan.ResItemOther = e.Data.GetData(GetType(StpPan.ResItemOther))
                    e.Effect = DragDropEffects.Move
                    currentCursor = tb
                    tb.Hide()
                    Cursor.Current = StpPan.ResItemTable.CreateCursor(tb)
                End If
            End If
        End If

    End Sub


    Private Sub PanelTable_DragLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PanelTable.DragLeave
        If currentCursor IsNot Nothing Then
            currentCursor.Show()
        End If
    End Sub

    Private Sub linknew_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linknew.LinkClicked
        Dim p As Process = Process.Start(Application.StartupPath & "\Lres_dmkv.exe", "res_dmkv <!add> ma_res:" & ma_res)
        p.WaitForExit()
        loadKV()
    End Sub

    Private Sub linkedit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkedit.LinkClicked
        Dim p As Process = Process.Start(Application.StartupPath & "\Lres_dmkv.exe", "res_dmkv <!edit> ma_kv:" & kv_ht.Name)
        p.WaitForExit()
        loadKV()
    End Sub

    Private Sub linkdelete_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkdelete.LinkClicked
        Dim p As Process = Process.Start(Application.StartupPath & "\Lres_dmkv.exe", "res_dmkv <!delete> ma_kv:" & kv_ht.Name)
        p.WaitForExit()
        kv_ht = Nothing
        loadKV()
    End Sub
End Class
