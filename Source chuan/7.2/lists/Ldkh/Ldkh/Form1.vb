Imports Clsql
Imports ClsControl2
Imports ClsLookup
Public Class Frmmain

    Dim frmin As New kh
    Dim strdkloc As String
    Dim isloaded As Boolean = False
 
    'Dim dk As New dkloc
    Private Sub dmload(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        grd.AllowUserToAddRows = False
        grd.AllowUserToDeleteRows = False
        lbluser.Text = Reg.GetValue("ID")
        list = New ClsList.List1(listid, grd, frmin, True, "1=0")

        list.AddToolStripMain(ToolStripmain)
        list.AddToolStripFind(ToolStripfind)
        list.TD1.Visible = True
        list.TD1.Text = list.oLable("017")
        PropertyOfForm.SetImage4Control("find.bmp", list.TD1)
        list.Inds.Visible = True
        AddHandler list.TD1.Click, AddressOf btnfind_Click

        list.AddContextMenu()
        list.AddMenuItem(mnfile)
        grd.ContextMenuStrip = list.Contextmenu
        conn = list.conn
        loadf()
        If Not (list.onlyEdit Or list.onlyDelete Or list.onlyAdd) Then
            PropertyOfForm.SetImage4Control("user.bmp", lbluser)
            PropertyOfForm.SetLable(list.oLable, Me)
            Me.Icon = frmin.Icon
            dkloc.Icon = frmin.Icon
            list.LoadData("1=1")
        End If
        isloaded = True
        

    End Sub
   
    Dim col As String
    
    Private Sub thoat(ByVal sender As Object, ByVal e As System.EventArgs)
        list = Nothing
        Me.Close()
    End Sub
    Private Sub btnfind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If dkloc.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            list.LoadData("ma_tinh_thanh like '%" & Trim(dkloc.txtma_tinh_thanh.Text) & "%' and ma_quan_huyen like '%" & Trim(dkloc.txtma_quan_huyen.Text) & "%' and ma_qg like '%" & dkloc.txtma_qg.Text.Trim & "%'" _
                          & " and ma_loai_kh like '%" & Trim(dkloc.txtma_loai_kh.Text) & "%'" _
                          & " and dia_chi like N'%" & Trim(dkloc.txtdia_chi.Text) & "%'" _
                          & " and ma_so_thue like N'%" & Trim(dkloc.txtma_so_thue.Text) & "%'" _
                           & " and dai_dien_pl like N'%" & Trim(dkloc.txtdai_dien_pl.Text) & "%'" _
                           & " and dien_thoai like N'%" & Trim(dkloc.txtdien_thoai.Text) & "%'" _
                            & " and email like N'%" & Trim(dkloc.txtemail.Text) & "%'" _
                             & " and fax like N'%" & Trim(dkloc.txtfax.Text) & "%'" _
                              & " and htsh like N'%" & Trim(dkloc.txthtsh.Text) & "%'" _
                               & " and lhkd like N'%" & Trim(dkloc.txtlhkd.Text) & "%'" _
                                 & " and lvkd like N'%" & Trim(dkloc.txtlvkd.Text) & "%'" _
                                   & " and website like N'%" & Trim(dkloc.txtwebsite.Text) & "%'" _
                                      & " and ten_dn like N'%" & Trim(dkloc.txtten_dn.Text) & "%'" _
                                         & " and ten_kh like N'%" & Trim(dkloc.txtten_kh.Text) & "%'" _
                                            & " and ten_gd like N'%" & Trim(dkloc.ten_gd.Text) & "%'" _
                                              & " and ma_kh in (select ma_kh from nkcv where dien_giai like N'%" & Trim(dkloc.txtdien_giai.Text) & "%'" _
                                              & " and ma_lcv like N'%" & Trim(dkloc.cbbma_lcv.SelectedValue) & "%'" _
                                                 & " and ma_nv like N'%" & Trim(dkloc.Txtma_nv.Text) & "%'" _
                                                    & " and ghi_chu like N'%" & Trim(dkloc.txtghi_chu.Text) & "%'" _
                                                    & " and ma_ddlv like N'%" & Trim(dkloc.cbbma_ddlv.SelectedValue) & "%'" _
                                                    & " and (ngay between " & conn.ConvertToSQLType(dkloc.Txttu_ngay.Value) & " and " & conn.ConvertToSQLType(dkloc.Txtden_ngay.Value) _
                                                     & ") and ma_tien_do like N'%" & Trim(dkloc.cbbma_tien_do.SelectedValue) & "%')" _
                                                    & " and dai_dien_pl like N'%" & Trim(dkloc.txtdai_dien_pl.Text) & "%'")
            'grd.Columns(0).Width = SplitContainer1.Panel1.Width
        End If
    End Sub


    Private Sub grd_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd.CellEnter
        If Me.Enabled = False Then
            Return
        End If
        
        If TabControl1.SelectedTab.Name = thong_tin_lien_he.Name Then
            If list.BindingSource.Count > 0 Then
                list_lh.LoadData("ma_kh = '" & list.BindingSource.Current("ma_kh") & "'")
            End If
        End If
        If TabControl1.SelectedTab.Name = hop_dong.Name Then
            If list.BindingSource.Count > 0 Then
                list_hd.LoadData("ma_kh = '" & list.BindingSource.Current("ma_kh") & "'")
            End If
        End If
        If TabControl1.SelectedTab.Name = actives.Name Then
            If list.BindingSource.Count > 0 Then
                loadactives(list.BindingSource.Current("ma_kh"))
            End If
        End If
        If TabControl1.SelectedTab.Name = documents.Name Then
            If list.BindingSource.Count > 0 Then
                loaddocs(list.BindingSource.Current("ma_kh"))
            End If
        End If
    End Sub

    Private Sub list_AfterDeleteItem(ByVal dk As DataRow)
        

    End Sub
    Private Sub BeforeAddItem()
        
    End Sub
    Private Sub SaveClick()
        'If (list.Action = Actions.Action.Add) Then
        '    Dim mst As String = frmin.txtma_so_thue.Text
        '    If (mst.Trim <> "") Then
        '        Dim k As String = list.conn.GetValue("select ma_kh from dkh where ma_so_thue ='" & mst & "'")
        '        If IsDBNull(k) Then
        '            k = ""
        '        End If
        '        If k.Trim <> "" Then
        '            MsgBox(Clsql.Others.Msgs("0002", list.conn).Replace("%&", mst), MsgBoxStyle.Critical, Clsql.AboutMe.Name)

        '            list.ContinueSave = False
        '            frmin.txtma_so_thue.Focus()
        '        End If
        '    End If
        'End If
    End Sub

#Region "Thong tin lien he"
    Private Sub thong_tin_lien_he_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles thong_tin_lien_he.Enter
        setupttlh()
        If list.BindingSource.Count > 0 Then
            list_lh.LoadData("ma_kh='" & list.BindingSource.Current("ma_kh") & "'")
        Else
            list_lh.LoadData("1=0")
        End If
    End Sub

    Private Sub beforeAddlh()
        If grd.CurrentRow Is Nothing Then
            list_lh.ContinueAdd = False
            Return
        End If

        Dim iditityMa_kh = conn.GetValue("select cast(max(ma_nguoi_lien_he) as numeric(8,0)) from dlh where ma_kh='" & list.BindingSource.Current("ma_kh") & "'")
        If IsDBNull(iditityMa_kh) Then
            iditityMa_kh = 1
        Else
            iditityMa_kh = iditityMa_kh + 1
        End If
        Dim keydefaul As New Collection
        keydefaul.Add(Strings.Format(iditityMa_kh, "00000000"), "ma_nguoi_lien_he")
        keydefaul.Add(grd.Item("ma_kh", grd.CurrentRow.Index).Value, "ma_kh")
        list_lh.SetKeys = keydefaul
        Dim valuedefaul As New Collection
        valuedefaul.Add(0, "gioi_tinh")
        valuedefaul.Add(list.BindingSource.Current("dien_thoai"), "dien_thoai_co_quan")
        list_lh.ValueDefaults = valuedefaul


    End Sub
    Sub setupttlh()
        If list_lh IsNot Nothing Then
            Return
        End If
        Dim flh As New dlh
        list_lh = New ClsList.List1("dlh", gridlh, flh, False, "1=0")

        list_lh.tat.Visible = False
        list_lh.AddToolStripMain(bar_lh)
        '
        '
        AddHandler list_lh.BeforeAddItem, AddressOf beforeAddlh

        AddHandler flh.btnLuu.Click, AddressOf list_lh.Save
        AddHandler flh.btnhuy.Click, AddressOf list_lh.Cancel
    End Sub

#End Region
#Region "Thong tin hop dong"
    Private Sub hop_dong_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles hop_dong.Enter
        setuptthd()
        If list.BindingSource.Count > 0 Then
            list_hd.LoadData("ma_kh='" & list.BindingSource.Current("ma_kh") & "'")
        Else
            list_hd.LoadData("1=0")
        End If

    End Sub
    
    Private Sub beforeaddhd()
        If grd.CurrentRow Is Nothing Then
            list_hd.ContinueAdd = False
            Return
        End If
        Dim keydefaul As New Collection
        keydefaul.Add(grd.Item("ma_kh", grd.CurrentRow.Index).Value, "ma_kh")
        list_hd.SetKeys = keydefaul
    End Sub
   
    Sub setuptthd()
        If list_hd IsNot Nothing Then
            Return
        End If
        Dim finhd As New frmhd
        list_hd = New ClsList.List1("dmhd", grdhop_dong, finhd, False, "1=0")


        Dim nv As New ClsLookup.AutoCompleteLookup(conn, "dmnv", finhd.txtma_nvbh, "ma_nv", False)
        nv.SetValue("ten_nv", finhd.ten_nv)

        Dim bp As New AutoCompleteLookup(conn, "dmbp", finhd.txtma_bp, "ma_bp", False)
        If Reg.GetValue("Language") = "Vi" Then
            bp.SetValue("ten_bp", finhd.ten_bp)

        Else
            bp.SetValue("ten_bp2", finhd.ten_bp)

        End If
        Dim nt As New AutoCompleteLookup(conn, "dmnt", finhd.txtma_nt, "ma_nt")


        hop_dong.Text = list_hd.oLable("000")

        'set label
        list_hd.tat.Visible = False
        list_hd.AddToolStripMain(bar_hd)
        list_hd.TD1.Visible = True

        AddHandler list_hd.TD1.Click, AddressOf addfilehd

        list_hd.TD2.Visible = True

        AddHandler list_hd.TD2.Click, AddressOf viewfilehd
        If conn.Lang = SQL.Language.Vietnamese Then
            list_hd.TD1.Text = "Thêm tài liệu"
            list_hd.TD2.Text = "Danh sách tài liệu"
        Else
            list_hd.TD1.Text = "New document"
            list_hd.TD2.Text = "Documents"
        End If
        '

        AddHandler list_hd.BeforeAddItem, AddressOf beforeaddhd
        '
        AddHandler finhd.btnLuu.Click, AddressOf list_hd.Save
        AddHandler finhd.btnhuy.Click, AddressOf list_hd.Cancel
    End Sub
    Private Sub addfilehd()
        If grdhop_dong.CurrentRow Is Nothing Then
            Return
        End If
        Dim argus As String = "dmtl <!add> ma_kh:" & grdhop_dong.CurrentRow.Cells("ma_kh").Value.ToString.Trim
        argus = argus & ";ma_hd:" & grdhop_dong.CurrentRow.Cells("ma_hd").Value.ToString.Trim
        Dim process As Process = process.Start(Application.StartupPath & "\zLdmtl.exe", argus)
        process.WaitForExit()
    End Sub
    Private Sub viewfilehd()
        If grdhop_dong.CurrentRow Is Nothing Then
            Return
        End If
        Dim argus As String = "dmtl <!view> ma_hd:" & grdhop_dong.CurrentRow.Cells("ma_hd").Value.ToString.Trim
        Dim process As Process = process.Start(Application.StartupPath & "\zLdmtl.exe", argus)
        process.WaitForExit()
    End Sub
#End Region
#Region "Actives"
    Dim dtactive As DataTable
    Dim rightoflistactive As ClsList.RightOfList = Nothing
    Sub loadactives(ByVal ma_kh As String)
        If rightoflistactive Is Nothing Then
            dtactive = conn.GetDatatable("select * from vnkcv where 1=0")
            ClsControl2.PropertyOfGrid.FillGrid(conn, "nkcv", gridactives, dtactive.DefaultView)
            AddHandler gridactives.KeyDown, AddressOf ClsControl2.PropertyOfGrid.Filter
            rightoflistactive = New ClsList.RightOfList(conn, "nkcv", list.user_id, Reg.GetValue("unit"))
            btnnewactive.Visible = rightoflistactive.getRight().NewRight
            btnupdateactive.Visible = rightoflistactive.getRight().EditRight
            btndeleteactive.Visible = rightoflistactive.getRight().DeleteRight
        End If
        dtactive = conn.GetDatatable("select * from vnkcv where ma_kh ='" & ma_kh.Trim & "' and (" & rightoflistactive.getAuthorizationQuery(dtactive) & ")")
        gridactives.DataSource = dtactive
    End Sub
    Private Sub actives_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles actives.Enter
        Dim ma_kh As String = ""
        If grd.CurrentRow IsNot Nothing Then
            ma_kh = grd.CurrentRow.Cells("ma_kh").Value.ToString.Trim
        End If
        loadactives(ma_kh)
    End Sub
    Private Sub btnnewactive_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnnewactive.Click
        Dim ma_kh As String = ""
        If grd.CurrentRow IsNot Nothing Then
            ma_kh = grd.CurrentRow.Cells("ma_kh").Value.ToString.Trim
        End If
        If ma_kh = "" Then
            Return
        End If
        Dim argus As String = "nkcv <!add> ma_kh:" & ma_kh
        Dim process As Process = process.Start(Application.StartupPath & "\Lnkcv.exe", argus)
        process.WaitForExit()
        loadactives(ma_kh)
    End Sub
    Private Sub btnupdateactive_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnupdateactive.Click
        Dim ma_kh As String = ""
        If grd.CurrentRow IsNot Nothing Then
            ma_kh = grd.CurrentRow.Cells("ma_kh").Value.ToString.Trim
        End If
        If ma_kh = "" Then
            Return
        End If
        If gridactives.CurrentRow Is Nothing Then
            Return
        End If
        Dim stt_rec As String = gridactives.CurrentRow.Cells("stt_rec").Value.ToString.Trim
        Dim argus As String = "nkcv <!edit> stt_rec:" & stt_rec
        Dim process As Process = process.Start(Application.StartupPath & "\Lnkcv.exe", argus)
        process.WaitForExit()
        loadactives(ma_kh)
    End Sub

    Private Sub btndeleteactive_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btndeleteactive.Click
        Dim ma_kh As String = ""
        If grd.CurrentRow IsNot Nothing Then
            ma_kh = grd.CurrentRow.Cells("ma_kh").Value.ToString.Trim
        End If
        If ma_kh = "" Then
            Return
        End If
        If gridactives.CurrentRow Is Nothing Then
            Return
        End If
        Dim stt_rec As String = gridactives.CurrentRow.Cells("stt_rec").Value.ToString.Trim
        Dim argus As String = "nkcv <!delete> stt_rec:" & stt_rec
        Dim process As Process = process.Start(Application.StartupPath & "\Lnkcv.exe", argus)
        process.WaitForExit()
        loadactives(ma_kh)
    End Sub
    Private Sub gridactives_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles gridactives.CellMouseDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 AndAlso rightoflistactive.getRight().EditRight Then
            btnupdateactive.PerformClick()
        End If
    End Sub
#End Region

#Region "Documents"
    Dim dtdoc As DataTable
    Dim rightoflistdoc As ClsList.RightOfList = Nothing
    Sub loaddocs(ByVal ma_kh As String)
        If rightoflistdoc Is Nothing Then
            dtdoc = conn.GetDatatable("select * from vdmtl where 1=0")
            ClsControl2.PropertyOfGrid.FillGrid(conn, "dmtl", griddocuments, dtdoc.DefaultView)
            AddHandler griddocuments.KeyDown, AddressOf ClsControl2.PropertyOfGrid.Filter

            rightoflistdoc = New ClsList.RightOfList(conn, "dmtl", list.user_id, Reg.GetValue("unit"))
            btnadddoc.Visible = rightoflistdoc.getRight().NewRight
            btnupdatedoc.Visible = rightoflistdoc.getRight().EditRight
            btndeletedoc.Visible = rightoflistdoc.getRight().DeleteRight
        End If
        dtdoc = conn.GetDatatable("select * from vdmtl where ma_kh ='" & ma_kh.Trim & "' and (" & rightoflistdoc.getAuthorizationQuery(dtactive) & ")")
        griddocuments.DataSource = dtdoc
    End Sub
    Private Sub documents_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles documents.Enter
        Dim ma_kh As String = ""
        If grd.CurrentRow IsNot Nothing Then
            ma_kh = grd.CurrentRow.Cells("ma_kh").Value.ToString.Trim
        End If
        loaddocs(ma_kh)
    End Sub
    Private Sub btnadddoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadddoc.Click
        Dim ma_kh As String = ""
        If grd.CurrentRow IsNot Nothing Then
            ma_kh = grd.CurrentRow.Cells("ma_kh").Value.ToString.Trim
        End If
        If ma_kh = "" Then
            Return
        End If
        Dim argus As String = "dmtl <!add> ma_kh:" & ma_kh
        Dim process As Process = process.Start(Application.StartupPath & "\zLdmtl.exe", argus)
        process.WaitForExit()
        loaddocs(ma_kh)
    End Sub
    Private Sub btnupdatedoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdatedoc.Click
        Dim ma_kh As String = ""
        If grd.CurrentRow IsNot Nothing Then
            ma_kh = grd.CurrentRow.Cells("ma_kh").Value.ToString.Trim
        End If
        If ma_kh = "" Then
            Return
        End If
        If griddocuments.CurrentRow Is Nothing Then
            Return
        End If
        Dim ma_tl As String = griddocuments.CurrentRow.Cells("ma_tl").Value.ToString.Trim
        Dim argus As String = "dmtl <!edit> ma_tl:" & ma_tl
        Dim process As Process = process.Start(Application.StartupPath & "\zLdmtl.exe", argus)
        process.WaitForExit()
        loaddocs(ma_kh)
    End Sub
    Private Sub btndeletedoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndeletedoc.Click
        Dim ma_kh As String = ""
        If grd.CurrentRow IsNot Nothing Then
            ma_kh = grd.CurrentRow.Cells("ma_kh").Value.ToString.Trim
        End If
        If ma_kh = "" Then
            Return
        End If
        If griddocuments.CurrentRow Is Nothing Then
            Return
        End If
        Dim ma_tl As String = griddocuments.CurrentRow.Cells("ma_tl").Value.ToString.Trim
        Dim argus As String = "dmtl <!delete> ma_tl:" & ma_tl
        Dim process As Process = process.Start(Application.StartupPath & "\zLdmtl.exe", argus)
        process.WaitForExit()
        loaddocs(ma_kh)
    End Sub
    Private Sub btnviewfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnviewfile.Click
        If griddocuments.CurrentRow Is Nothing Then
            Return
        End If
        Dim bytes As Byte() = griddocuments.CurrentRow.Cells("dinh_kem").Value
        If IsDBNull(bytes) Then
            Return
        End If
        Dim filename As String = griddocuments.CurrentRow.Cells("file_dk").Value
        Clsql.Data.OpenFileFromDB(bytes, filename)
    End Sub

    Private Sub griddocuments_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles griddocuments.CellMouseDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            btnupdatedoc.PerformClick()
        End If
    End Sub
#End Region
    Private Sub grd_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles grd.RowsAdded

        If Reg.GetValue("Language") = "Vi" Then
            lbllines.Text = grd.RowCount & " Khách hàng"
        Else
            lbllines.Text = grd.RowCount & " Customer(s)"
        End If

    End Sub

    Private Sub grd_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles grd.RowsRemoved

        If Reg.GetValue("Language") = "Vi" Then
            lbllines.Text = grd.RowCount & " Khách hàng"
        Else
            lbllines.Text = grd.RowCount & " Customer(s)"
        End If
    End Sub
    Sub loadf()
        'set gia tri mac dinh cho dmkh
        Dim ValueDefault As New Collection
        ValueDefault.Add(True, "kh_yn")
        ValueDefault.Add(False, "ncc_yn")
        ValueDefault.Add(Now, "ngay_tc")
        ValueDefault.Add(list.conn.GetValue("select ma_nv from dmnsd where id ='" & Reg.GetValue("id") & "'"), "ma_nv_lh")
        list.ValueDefaults = ValueDefault
        'bind data cho view
        If Not (list.onlyAdd Or list.onlyEdit Or list.onlyDelete) Then
            PropertyOfForm.BindData(list.BindingSource, thong_tin_chung)
            PropertyOfForm.BindData(list.BindingSource, thong_tin_pha_tich)
            PropertyOfForm.BindData(list.BindingSource, tabother)
            'sercurity
            PropertyOfForm.Sercurity(thong_tin_chung)
            PropertyOfForm.Sercurity(thong_tin_pha_tich)
            PropertyOfForm.Sercurity(tabother)
            '
            ClsControl2.PropertyOfForm.Lookups(conn, Me, listid)
        End If

        'add button detail
        ' Dim dd As New clsViDe.DropDownButtonDetail(list.conn, ToolStripfind, "ldkh", Me.grd)
        'set up cmd
        frmin.btnhuy.CausesValidation = False
        AddHandler frmin.btnLuu.Click, AddressOf list.Save
        AddHandler frmin.btnhuy.Click, AddressOf list.Cancel
        AddHandler gridlh.KeyDown, AddressOf PropertyOfGrid.Filter
        AddHandler grd.KeyDown, AddressOf PropertyOfGrid.Filter

        AddHandler list.AfterDeleteItem, AddressOf list_AfterDeleteItem

        AddHandler list.BeforeAddItem, AddressOf BeforeAddItem
        AddHandler list.SaveClick, AddressOf SaveClick
    End Sub



End Class
