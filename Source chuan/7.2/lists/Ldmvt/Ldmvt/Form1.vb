Imports Clsql
Imports ClsControl2
Imports ClsLookup
Imports System.ComponentModel
Imports clsViDe

Public Class Frmmain
    Dim frmin As New vt
    Dim strdkloc As String
    Dim isloaded As Boolean = False

    'Dim dk As New dkloc
    Private Sub dmload(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lbluser.Text = Reg.GetValue("ID")
        list = New ClsList.List1(listid, grd, frmin, True, "1=0")
        conn = list.conn
        list.AddToolStripMain(ToolStripmain)
        list.AddToolStripFind(ToolStripfind)

        list.TD1.Visible = True
        list.TD1.Text = list.oLable("017")
        PropertyOfForm.SetImage4Control("find.bmp", list.TD1)
        AddHandler list.TD1.Click, AddressOf btnfind_Click

        list.AddContextMenu()
        list.AddMenuItem(mnfile)
        grd.ContextMenuStrip = list.Contextmenu
        loadf()
        setlookup()
        If Not (list.onlyAdd Or list.onlyDelete Or list.onlyEdit) Then
            list.Inds.Visible = True
            PropertyOfForm.SetImage4Control("user.bmp", lbluser)
            PropertyOfForm.SetLable(list.oLable, Me)
            Me.Icon = frmin.Icon
            dkloc.Icon = frmin.Icon
            list.LoadData("1=1")

            txttu_ngayn.Value = Now
            txtden_ngayn.Value = Now
            txttu_ngax.Value = Now
            txtden_ngayx.Value = Now
            AddHandler gridviewgiaban.KeyDown, AddressOf ClsControl2.PropertyOfGrid.ExportToExcel
            AddHandler gridviewnhap.KeyDown, AddressOf ClsControl2.PropertyOfGrid.ExportToExcel
            AddHandler gridviewxuat.KeyDown, AddressOf ClsControl2.PropertyOfGrid.ExportToExcel
        End If
        
        isloaded = True
        grd.ReadOnly = False

    End Sub
  

    Private Sub btnfind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If dkloc.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            list.LoadData("ma_vt like '%" & Trim(dkloc.txtma_vt.Text) & "%' and ten_vt like N'%" & Trim(dkloc.txtten_vt.Text) & "%' and ten_vt2 like N'%" & dkloc.txtten_vt2.Text.Trim & "%'" _
                          & " and loai_vt like '%" & Trim(dkloc.txtloai_vt.Text) & "%'" _
                          & " and ma_dvt like N'%" & Trim(dkloc.txtma_dvt.Text) & "%'" _
                          & " and nh_vt1 like N'%" & Trim(dkloc.txtnh_vt1.Text) & "%'" _
                           & " and nh_vt2 like N'%" & Trim(dkloc.txtnh_vt2.Text) & "%'" _
                           & " and nh_vt3 like N'%" & Trim(dkloc.txtnh_vt3.Text) & "%'" _
                            & " and tk_vt like N'%" & Trim(dkloc.txttk_vt.Text) & "%'" _
                             & " and tk_gv like N'%" & Trim(dkloc.txttk_gv.Text) & "%'" _
                              & " and tk_dt like N'%" & Trim(dkloc.txttk_dt.Text) & "%'" _
                               & " and tk_ck like N'%" & Trim(dkloc.txttk_ck.Text) & "%'" _
                                 & " and tk_spdd like N'%" & Trim(dkloc.txttk_spdd.Text) & "%'")

        End If
    End Sub

    Private Sub loadgiaban()
        If list.BindingSource.Count > 0 Then
            Dim querygiaban As String = "select * from dmgiaban where ma_vt='" & list.BindingSource.Current("ma_vt") & "' order by tu_ngay desc"
            Dim grididgiaban As String = "dmgiaban"
            Dim dtgiaban As DataTable = conn.GetDatatable(querygiaban)
            ClsControl2.PropertyOfGrid.FillGrid(conn, grididgiaban, gridviewgiaban, dtgiaban.DefaultView)
        End If
    End Sub
    Private Sub loadbknhap()
        If list.BindingSource.Count > 0 Then
            Dim query As String = "select * from sokho where ma_vt='" & list.BindingSource.Current("ma_vt") & "' and nxt=1 and ngay_ct between " & conn.ConvertToSQLType(txttu_ngayn.Value) & " and " & conn.ConvertToSQLType(txtden_ngayn.Value)
            Dim gridid As String = "bkNhap"
            Dim dt As DataTable = conn.GetDatatable(query)
            ClsControl2.PropertyOfGrid.FillGrid(conn, gridid, gridviewnhap, dt.DefaultView)
        End If
    End Sub
    Private Sub loadbkxuat()
        If list.BindingSource.Count > 0 Then
            Dim query As String = "select * from sokho where ma_vt='" & list.BindingSource.Current("ma_vt") & "' and nxt=2 and ngay_ct between " & conn.ConvertToSQLType(txttu_ngax.Value) & " and " & conn.ConvertToSQLType(txtden_ngayx.Value)
            Dim gridid As String = "bkXuat"
            Dim dt As DataTable = conn.GetDatatable(query)
            ClsControl2.PropertyOfGrid.FillGrid(conn, gridid, gridviewxuat, dt.DefaultView)
        End If
    End Sub
    Private Sub grd_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd.CellEnter
        If Me.Enabled = False Then
            Return
        End If
        If TabControl1.SelectedTab.Name = donvitinh.Name Then
            If grd.CurrentRow IsNot Nothing Then
                list_dvt.LoadData("ma_vt = '" & grd.CurrentRow.Cells("ma_vt").Value & "'")
            End If
        End If
        'load gia ban
        If TabControl1.SelectedTab.Name = tabgiaban.Name Then
            loadgiaban()
        End If
        'load bk nhap
        If TabControl1.SelectedTab.Name = tabnhapkho.Name Then
            loadbknhap()
        End If
        'load bk xuat
        If TabControl1.SelectedTab.Name = tabxuatkho.Name Then
            loadbkxuat()
        End If
    End Sub
    Private Sub tabgiaban_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabgiaban.Enter
        loadgiaban()
    End Sub
    Private Sub tabnhap_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabnhapkho.Enter
        loadbknhap()
    End Sub
    Private Sub tabxuat_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabxuatkho.Enter
        loadbkxuat()
    End Sub
    Private Sub btnlocn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlocn.Click
        loadbknhap()
    End Sub

    Private Sub btnlocx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlocx.Click
        loadbkxuat()
    End Sub

    Private Sub list_AfterAddItem(ByVal e As System.Data.DataRow)

    End Sub

    Private Sub list_AfterDeleteItem(ByVal dk As DataRow)
        conn.Execute("delete dmqddvt where ma_vt ='" & dk("ma_vt") & "'")

        If list_dvt IsNot Nothing AndAlso list_dvt.datatable IsNot Nothing Then
            list_dvt.datatable.Clear()
        End If

    End Sub
    Private Sub BeforeAddItem()
        frmin.txtma_dvt.Enabled = True
        frmin.txtma_vt.Enabled = True
    End Sub
    Private Sub BeforeEditItem()
        Dim query As String = "select 1 from sokho where ltrim(rtrim(ma_vt)) ='" & grd.CurrentRow.Cells("ma_vt").Value.ToString.Trim & "' and ltrim(rtrim(ma_dvt)) = '" & grd.CurrentRow.Cells("ma_dvt").Value.ToString.Trim & "'"
        If conn.GetValue(query) = 1 Then
            frmin.txtma_dvt.Enabled = False
            frmin.txtma_vt.Enabled = False
        Else
            frmin.txtma_dvt.Enabled = True
            frmin.txtma_vt.Enabled = True
        End If
    End Sub

#Region "DVT qd"
    Private Sub donvitinh_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles donvitinh.Enter
        setupttgd()
        If list.BindingSource.Count > 0 Then
            list_dvt.LoadData("ma_vt ='" & list.BindingSource.Current("ma_vt") & "'")
        Else
            list_dvt.LoadData("1=0")
        End If
    End Sub

    Sub setupttgd()
        If list_dvt IsNot Nothing Then
            Return
        End If
        list_dvt = New ClsList.List1("dqddvt", gridgd, dqddvt, False, "1=0")

        AddHandler list_dvt.BeforeAddItem, AddressOf beforeAddgd

        donvitinh.Text = list_dvt.oLable("000")

        dqddvt.btnhuy.CausesValidation = False
        list_dvt.tat.Visible = False
        list_dvt.AddToolStripMain(bar_qddvt)
    End Sub
    Private Sub beforeAddgd()
        If grd.CurrentRow Is Nothing Then
            list_dvt.ContinueAdd = False
            Return
        End If
        Dim defaults As New Collection
        defaults.Add(grd.Item("ma_dvt", grd.CurrentRow.Index).Value, "ma_dvt_c")
        defaults.Add(grd.Item("ma_vt", grd.CurrentRow.Index).Value, "ma_vt")
        list_dvt.ValueDefaults = defaults
    End Sub
#End Region

    Private Sub grd_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles grd.RowsAdded

        If Reg.GetValue("Language") = "Vi" Then
            lbllines.Text = grd.RowCount & " Vật tư"
        Else
            lbllines.Text = grd.RowCount & " Item(s)"
        End If

    End Sub

    Private Sub grd_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles grd.RowsRemoved

        If Reg.GetValue("Language") = "Vi" Then
            lbllines.Text = grd.RowCount & " Vật tư"
        Else
            lbllines.Text = grd.RowCount & " Item(s)"
        End If
    End Sub

    Sub setup()
        AddItems.AddItemCbb(conn, "select ma_pp,ten_pp,ten_pp2 from dmpp where loai_pp =2", cbbgia_ton, "ten_pp", "ten_pp2", "ma_pp")
        frmin.cbbgia_ton.DataSource = cbbgia_ton.DataSource
        frmin.cbbgia_ton.DisplayMember = cbbgia_ton.DisplayMember
        frmin.cbbgia_ton.ValueMember = cbbgia_ton.ValueMember
        frmin.cbbgia_ton.DropDownStyle = ComboBoxStyle.DropDownList
        ''set gia tri mac dinh cho dmkh
        Dim ValueDefault As New Collection
        ValueDefault.Add(True, "vt_ton_kho")
        ValueDefault.Add(1, "gia_ton")
        list.ValueDefaults = ValueDefault
    End Sub
    Sub setlookup()
        ClsControl2.PropertyOfForm.Lookups(conn, Me, listid)
        Dim othue As New ClsLookup.AutoCompleteLookup(conn, "dmvat", frmin.txtma_thue, "ma_thue", False)
        othue.SetValue("thue_suat", frmin.lblten_thue)

        Dim odvt As New ClsLookup.AutoCompleteLookup(conn, "dmdvt0", frmin.txtma_dvt, "ma_dvt", True)
        Dim okho As New ClsLookup.AutoCompleteLookup(conn, "dmkho", frmin.txtma_kho, "ma_kho", False)
        okho.oKey = "ma_dvcs = '" & Reg.GetValue("unit") & "'"
       
        

        If Reg.GetValue("Language") = "Vi" Then
           

            odvt.SetValue("ten_dvt", frmin.ten_dvt)

            okho.SetValue("ten_kho", frmin.ten_kho)

            

        Else
           

            odvt.SetValue("ten_dvt2", frmin.ten_dvt)
            okho.SetValue("ten_kho2", frmin.ten_kho)
            
        End If
    End Sub
    Sub loadf()

        setup()

        If Not (list.onlyAdd Or list.onlyDelete Or list.onlyEdit) Then
            'bind data cho view
            PropertyOfForm.BindData(list.BindingSource, thong_tin_chung)
            PropertyOfForm.BindData(list.BindingSource, taikhoan)

            PropertyOfForm.BindData(list.BindingSource, muahang)

            PropertyOfForm.BindData(list.BindingSource, thongtinkhac)
            PropertyOfForm.BindData(list.BindingSource, chitiet)

            'sercurity
            PropertyOfForm.Sercurity(thong_tin_chung)
            PropertyOfForm.Sercurity(taikhoan)
            PropertyOfForm.Sercurity(muahang)

            PropertyOfForm.Sercurity(thongtinkhac)
            PropertyOfForm.Sercurity(chitiet)
        End If
        
        ' setupttgd()
        'set up cmd
        frmin.btnhuy.CausesValidation = False



        AddHandler frmin.btnLuu.Click, AddressOf list.Save
        AddHandler frmin.btnhuy.Click, AddressOf list.Cancel
        AddHandler gridgd.KeyDown, AddressOf PropertyOfGrid.Filter
        AddHandler grd.KeyDown, AddressOf PropertyOfGrid.Filter
        AddHandler list.AfterAddItem, AddressOf list_AfterAddItem
        AddHandler list.AfterDeleteItem, AddressOf list_AfterDeleteItem
        AddHandler list.BeforeAddItem, AddressOf BeforeAddItem
        AddHandler list.BeforeEditItem, AddressOf BeforeEditItem
    End Sub


    Private Sub btncapnhatgiaban_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncapnhatgiaban.Click
        Clsql.Others.Exec(Application.StartupPath & "\ldmgiaban.exe", "dmgiaban")
    End Sub





    Private Sub gridviewnhap_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridviewnhap.CellDoubleClick
        If gridviewnhap.Columns.Contains("stt_rec") Then
            If Not String.IsNullOrEmpty(gridviewnhap.CurrentRow.Cells("stt_rec").Value.ToString) Then
                ofvoucher.ViewVoucher(conn, gridviewnhap.CurrentRow.Cells("stt_rec").Value)
            End If
        End If
    End Sub
    Private Sub gridviewxuat_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridviewxuat.CellDoubleClick

        If gridviewxuat.Columns.Contains("stt_rec") Then

            If Not String.IsNullOrEmpty(gridviewxuat.CurrentRow.Cells("stt_rec").Value.ToString) Then
                ofvoucher.ViewVoucher(conn, gridviewxuat.CurrentRow.Cells("stt_rec").Value)
            End If
        End If
    End Sub

End Class
