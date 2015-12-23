Imports Clsql
Imports ClsControl2
Imports ClsLookup
Public Class Frmmain
    Dim listid As String
    Dim WithEvents list As ClsList.List1
    Dim frmin As New frminput
    Dim conn As New Clsql.SQL
    Private Sub dmload(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ClsControl2.PropertyOfForm.CheckRegister = False Then
            Me.Close()
        End If
        listid = Clsql.Others.GetArgu(1)
        list = New ClsList.List1(conn, listid, grd, frmin, , "1=0", False)

        list.AddToolStripFind(ToolStrip1)
        ToolStrip1.Items.Add(New ToolStripSeparator)
        list.AddToolStripMain(ToolStrip1)
        'disable or enable cac  tinh nang
        '  list.moi.Visible = False
        ' list.xoa.Visible = False
        'them menu
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
        setuplookup()
        Dim f As New frmfilter
        PropertyOfForm.SetLable(list.oLable, f)
        f.Icon = Me.Icon
        If f.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            'copy tu ky truoc
            If f.chbcopy.Checked = True Then
                conn.Execute("cc_copyhspbcc " & f.txtky.Value & "," & f.txtnam.Value)
            End If
            '
            list.CSearch = "ky =" & f.txtky.Value & " and nam =" & f.txtnam.Value
            list.LoadData("1=1")
            Dim df As New Collection
            df.Add(f.txtnam.Value, "nam")
            df.Add(f.txtky.Value, "ky")
            list.ValueDefaults = df
            f.Dispose()
        Else
            f.Dispose()
            Me.Close()
        End If

        'set default value
        
       
    End Sub
   
    Private Sub thoat(ByVal sender As Object, ByVal e As System.EventArgs)
        list = Nothing
        Me.Close()
    End Sub
    Private Sub list_AddItem() Handles list.BeforeAddItem

    End Sub
    Private Sub list_BeforeEditItem() Handles list.BeforeEditItem

    End Sub
    Sub setuplookup()
        'Dim query = From r As DataRow In list.oField Where Clsql.Others.oInStr(r.Item("name"), "ma_bp,ma_phi,ma_dt,ma_hd,ma_sp") = True

        'For Each r As DataRow In query
        '    r("isnullable") = True
        'Next
        Dim ots As New AutoCompleteLookup(conn, "dmcc", frmin.txtso_the_ts, "so_the_ts", True)
        Dim otkkh As New AutoCompleteLookup(conn, "dmtk", frmin.txttk_kh, "tk", True)
        Dim otkcp As New AutoCompleteLookup(conn, "dmtk", frmin.txttk_cp, "tk", True)
        Dim obp As New AutoCompleteLookup(conn, "dmbp", frmin.txtma_bp, "ma_bp", False)
        Dim ophi As New AutoCompleteLookup(conn, "dmphi", frmin.txtma_phi, "ma_phi", False)
        Dim odt As New AutoCompleteLookup(conn, "dmdt", frmin.txtma_dt, "ma_dt", False)
        Dim ohd As New AutoCompleteLookup(conn, "dmhd", frmin.txtma_hd, "ma_hd", False)
        Dim osp As New AutoCompleteLookup(conn, "dmsp", frmin.txtma_sp, "ma_vt", False)


        If Reg.GetValue("language") = "Vi" Then
            ots.SetValue("ten_ts", frmin.ten_ts)
            otkkh.SetValue("ten_tk", frmin.ten_tk_kh)
            otkcp.SetValue("ten_tk", frmin.ten_tk_cp)

            obp.SetValue("ten_bp", frmin.ten_bp)
            ophi.SetValue("ten_phi", frmin.ten_phi)
            odt.SetValue("ten_dt", frmin.ten_dt)
            osp.SetValue("ten_vt", frmin.ten_sp)

            ohd.SetValue("ten_hd", frmin.ten_hd)
        Else
            ots.SetValue("ten_ts2", frmin.ten_ts)

            ots.SetValue("ten_ts2", frmin.ten_ts)
            otkkh.SetValue("ten_tk2", frmin.ten_tk_kh)
            otkcp.SetValue("ten_tk2", frmin.ten_tk_cp)

            obp.SetValue("ten_bp2", frmin.ten_bp)
            ophi.SetValue("ten_phi2", frmin.ten_phi)
            odt.SetValue("ten_dt2", frmin.ten_dt)
            osp.SetValue("ten_vt2", frmin.ten_sp)

            ohd.SetValue("ten_hd2", frmin.ten_hd)
        End If
    End Sub

    Private Sub list_SaveClick() Handles list.SaveClick
    End Sub
End Class
