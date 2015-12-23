Imports Clsql
Imports ClsControl2
Imports ClsLookup
Public Class Frmmain

    Dim frmin As New nv

    Dim strdkloc As String
    Dim isloaded As Boolean = False
 
    'Dim dk As New dkloc
    Private Sub dmload(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        grd.AllowUserToAddRows = False
        grd.AllowUserToDeleteRows = False
        lbluser.Text = Reg.GetValue("ID")
        list = New ClsList.List1(listid, grd, frmin, True, "1=0")
        ClsLookup.AddItems.AddItemCbb(list.conn, "SELECT * FROM dmItemOfCbb WHERE form = 'dnv' AND NAME = 'tt_hon_nhan'", frmin.cbbtt_hon_nhan, "text", "text2", "inds")

        list.AddToolStripMain(ToolStripmain)
        list.AddToolStripFind(ToolStripfind)

        list.TD1.Visible = True
        list.TD1.Text = list.oLable("112")
        PropertyOfForm.SetImage4Control("find.bmp", list.TD1)
        'nut quyet dinh nghi viec
       
        list.Inds.Visible = True
        list.Inds.Text = list.oLable("QD1")
        AddHandler list.TD1.Click, AddressOf btnfind_Click


        list.AddContextMenu()
        list.AddMenuItem(mnfile)
        grd.ContextMenuStrip = list.Contextmenu
        conn = list.conn
        PropertyOfForm.SetImage4Control("user.bmp", lbluser)
        PropertyOfForm.SetLable(list.oLable, Me)
        Me.Icon = frmin.Icon
        dkloc.Icon = frmin.Icon

        setlookup()



        'setupttgd()
        'setuptthd()
        'setupqtct()
        'setupqtluong()
        'setupqtdong_bhxh()
        'setupdaotao()
        'setupdmhs()
        'setuptdcm()
        'setupdieuchuyen()
        'setupktkl()

        loadf()
        If Clsql.Others.GetArgu(2) = "" Then

            Dim dk As String = "1=1"
            Try
                dk = My.Settings.history
            Catch ex As Exception

            End Try
            If dk = "" Then
                dk = "1=1"
            End If

            list.LoadData(dk)
        Else
            list.LoadData("ma_nv='" & Clsql.Others.GetArgu(2) & "'")
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
            list.LoadData("ma_loai_nv like '%" & Trim(dkloc.txtma_loai_nv.Text) & "%' and ma_bp like N'%" & Trim(dkloc.txtma_bp.Text) & "%'and ten_nv like N'%" & Trim(dkloc.txtten_nv.Text) & "%'and dang_lam_viec =" & conn.ConvertToSQLType(dkloc.chbdang_lam_viec.Checked))

        End If
    End Sub
    


    Private Sub grd_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd.CellEnter

        If TabControl1.SelectedTab.Name = thong_tin_gd.Name Then
            If list.BindingSource.Count > 0 Then
                list_lh.LoadData("ma_nv = '" & list.BindingSource.Current("ma_nv") & "'")
            End If
        End If

        If TabControl1.SelectedTab.Name = qtct.Name Then
            If list.BindingSource.Count > 0 Then
                list_qtct.LoadData("ma_nv = '" & list.BindingSource.Current("ma_nv") & "'")


            End If
        End If
        If TabControl1.SelectedTab.Name = qtluong.Name Then
            If list.BindingSource.Count > 0 Then
                list_qtluong.LoadData("ma_nv = '" & list.BindingSource.Current("ma_nv") & "'")


            End If
        End If
        If TabControl1.SelectedTab.Name = qtdong_bhxh.Name Then
            If list.BindingSource.Count > 0 Then
                list_qtdong_bhxh.LoadData("ma_nv = '" & list.BindingSource.Current("ma_nv") & "'")

            End If
        End If
        If TabControl1.SelectedTab.Name = khen_thuong.Name Then
            If list.BindingSource.Count > 0 Then
                list_ktkl.LoadData("ma_nv = '" & list.BindingSource.Current("ma_nv") & "'")
            End If
        End If

        If TabControl1.SelectedTab.Name = dieu_chuyen_nhan_su.Name Then
            If list.BindingSource.Count > 0 Then
                list_dcns.LoadData("ma_nv = '" & list.BindingSource.Current("ma_nv") & "'")
            End If
        End If

        If TabControl1.SelectedTab.Name = trinh_do_chuyen_mon.Name Then
            If list.BindingSource.Count > 0 Then
                list_tdcm.LoadData("ma_nv = '" & list.BindingSource.Current("ma_nv") & "'")
            End If
        End If
        If TabControl1.SelectedTab.Name = dmho_so_nv.Name Then
            If list.BindingSource.Count > 0 Then
                list_dmhs.LoadData("ma_nv = '" & list.BindingSource.Current("ma_nv") & "'")
            End If
        End If
        If TabControl1.SelectedTab.Name = dao_tao.Name Then
            If list.BindingSource.Count > 0 Then

                list_dt.LoadData("ma_nv = '" & list.BindingSource.Current("ma_nv") & "'")
            End If
        End If

        If TabControl1.SelectedTab.Name = hop_dong_ld.Name Then
            If list.BindingSource.Count > 0 Then
                list_hd.LoadData("ma_nv = '" & list.BindingSource.Current("ma_nv") & "'")
            End If
        End If
    End Sub

    Private Sub list_AfterDeleteItem(ByVal dk As DataRow)
        

    End Sub
    Private Sub BeforeAddItem()
        
    End Sub

#Region "Thong tin gia dinh"
    Private Sub thong_tin_gd_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles thong_tin_gd.Enter
        setupttgd()
        If list.BindingSource.Count > 0 Then
            list_lh.LoadData("ma_nv='" & list.BindingSource.Current("ma_nv") & "'")
        Else
            list_lh.LoadData("1=0")
        End If
    End Sub

    Private Sub beforeAddlh()
        If grd.CurrentRow Is Nothing Then
            list_lh.ContinueAdd = False
            Return
        End If

        Dim iditityMa_nv = conn.GetValue("select cast(max(ma_tn) as numeric(8,0)) from dmthannhan where ma_nv='" & list.BindingSource.Current("ma_nv") & "'")
        If IsDBNull(iditityMa_nv) Then
            iditityMa_nv = 1
        Else
            iditityMa_nv = iditityMa_nv + 1
        End If
        Dim keydefaul As New Collection
        keydefaul.Add(Strings.Format(iditityMa_nv, "00000000"), "ma_tn")
        keydefaul.Add(grd.Item("ma_nv", grd.CurrentRow.Index).Value, "ma_nv")
        list_lh.SetKeys = keydefaul




    End Sub
    Sub setupttgd()
        If list_lh IsNot Nothing Then
            Return
        End If
        Dim flh As New dgd
        list_lh = New ClsList.List1("dmthannhan", gridlh, flh, False, "1=0")
        flh._grd = grd

        list_lh.tat.Visible = False
        list_lh.AddToolStripMain(bar_lh)

        '
        AddHandler list_lh.BeforeAddItem, AddressOf beforeAddlh

        AddHandler flh.btnLuu.Click, AddressOf list_lh.Save
        AddHandler flh.btnhuy.Click, AddressOf list_lh.Cancel
    End Sub

#End Region
#Region "Thong tin hop dong"
    Private Sub hop_dong_ld_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles hop_dong_ld.Enter
        setuptthd()
        If list.BindingSource.Count > 0 Then
            list_hd.LoadData("ma_nv='" & list.BindingSource.Current("ma_nv") & "'")
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
        keydefaul.Add(grd.Item("ma_nv", grd.CurrentRow.Index).Value, "ma_nv")
        
        list_hd.SetKeys = keydefaul
    End Sub
    Sub AfterAddItem(ByVal r As DataRow)
        'ThanhPT: theo yêu cầu chú Thắng, chỉ sửa bp, cv khi thêm mới
        'If list_hd.Action = Actions.Action.Add Then
        '    nv.txtma_bp.Text = r.Item("ma_bp_hd")
        '    nv.txtma_cv.Text = r.Item("ma_cv_hd")
        '    conn.Execute("update dnv set ma_bp = b.ma_bp_hd,ma_cv = b.ma_cv_hd from dnv a left join dmhopdongld b on a.ma_nv=b.ma_nv where b.ngay_bd_hd in (select max(ngay_bd_hd) as ngay_bd_hd from dmhopdongld group by ma_nv)")
        'End If
    End Sub
    Sub setuptthd()
        If list_hd IsNot Nothing Then
            Return
        End If
        Dim finhd As New frmhd
        list_hd = New ClsList.List1("dmhopdongld", grdhd, finhd, False, "1=0")

        'gán 2 biến này để sự kiện load của form finhd có thể truy cập list_hd, grd và lấy giá trị mặc định bp, cv
        finhd._list_hd = list_hd
        finhd._grd = grd
        ClsLookup.AddItems.AddItemCbb(list_hd.conn, "exec s_dmnt", finhd.cbbma_nt2, "ten_nt", "ma_nt2")

        'set label
        '
        list_hd.tat.Visible = False
        list_hd.AddToolStripMain(bar_hd)
        list_hd.Inds.Visible = True
        '

        AddHandler list_hd.BeforeAddItem, AddressOf beforeaddhd
        AddHandler list_hd.AfterAddItem, AddressOf AfterAddItem

        '
        AddHandler finhd.btnLuu.Click, AddressOf list_hd.Save
        AddHandler finhd.btnhuy.Click, AddressOf list_hd.Cancel
        '

        AddHandler list_hd.Printing, AddressOf printing
        AddHandler list_hd.BeforePrint, AddressOf beforeprint
    End Sub

    Sub printing(ByVal query As String)
        Try
            query = "exec print_hopdongld '" & grdhd.CurrentRow.Cells("ma_nv").Value & "','" & grdhd.CurrentRow.Cells("so_hop_dong").Value & "'"

            list_hd.queryPrint = query
        Catch ex As Exception

        End Try


    End Sub
    Sub beforeprint(ByVal rpt As ClsRpt.rpt)

    End Sub

#End Region
#Region "Thong tin qua trinh cong tac"
    Private Sub qtct_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles qtct.Enter
        setupqtct()
        If list.BindingSource.Count > 0 Then
            list_qtct.LoadData("ma_nv='" & list.BindingSource.Current("ma_nv") & "'")
        Else
            list_qtct.LoadData("1=0")
        End If

    End Sub

    Private Sub beforeaddqtct()
        If grd.CurrentRow Is Nothing Then
            list_qtct.ContinueAdd = False
            Return
        End If

        Dim iditityMa_nv = conn.GetValue("select cast(max(ma_qtct) as numeric(8,0)) from dmqtct where ma_nv='" & list.BindingSource.Current("ma_nv") & "'")
        If IsDBNull(iditityMa_nv) Then
            iditityMa_nv = 1
        Else
            iditityMa_nv = iditityMa_nv + 1
        End If

        Dim keydefaul As New Collection
        keydefaul.Add(Strings.Format(iditityMa_nv, "00000000"), "ma_qtct")
        keydefaul.Add(grd.Item("ma_nv", grd.CurrentRow.Index).Value, "ma_nv")
        list_qtct.SetKeys = keydefaul
    End Sub

    Sub setupqtct()
        If list_qtct IsNot Nothing Then
            Return
        End If
        Dim finqtct As New qtct
        list_qtct = New ClsList.List1("dmqtct", grdqtct, finqtct, False, "1=0")
        finqtct._grd = grd

        'set label
        
        list_qtct.tat.Visible = False
        list_qtct.AddToolStripMain(bar_qtct)

        '

        AddHandler list_qtct.BeforeAddItem, AddressOf beforeaddqtct
        '
        AddHandler finqtct.btnLuu.Click, AddressOf list_qtct.Save
        AddHandler finqtct.btnhuy.Click, AddressOf list_qtct.Cancel
    End Sub

#End Region
#Region "danh muc ho so nhan vien"
    Private Sub dmho_so_nv_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dmho_so_nv.Enter
        setupdmhs()
        If list.BindingSource.Count > 0 Then
            list_dmhs.LoadData("ma_nv='" & list.BindingSource.Current("ma_nv") & "'")
        Else
            list_dmhs.LoadData("1=0")
        End If

    End Sub

    Private Sub beforeaddhs()
        If grd.CurrentRow Is Nothing Then
            list_dmhs.ContinueAdd = False
            Return
        End If
        Dim keydefaul As New Collection
        keydefaul.Add(grd.Item("ma_nv", grd.CurrentRow.Index).Value, "ma_nv")
        list_dmhs.SetKeys = keydefaul

    End Sub

    Sub setupdmhs()
        If list_dmhs IsNot Nothing Then
            Return
        End If
        Dim finhs As New dmhsnv
        list_dmhs = New ClsList.List1("dmhoso", grdhs, finhs, False, "1=0")
        finhs._grd = grd

        'set label
        'PropertyOfForm.SetLable(list_dmsd.oLable, Panhs)
        'PropertyOfForm.BindData(list_dmsd.BindingSource, Panhs)
        'PropertyOfForm.Sercurity(Panhs)
        list_dmhs.tat.Visible = False
        list_dmhs.AddToolStripMain(bar_hs)
        'list_dmhs.Inds.Visible = True
        'them nut xem file_dk
        list_dmhs.TD1.Visible = True
        list_dmhs.TD1.Text = list_dmhs.oLable("010")
        PropertyOfForm.SetImage4Control("plan.bmp", list_dmhs.TD1)
        AddHandler list_dmhs.TD1.Click, AddressOf xem_dinhKem

        '
        AddHandler list_dmhs.BeforeAddItem, AddressOf beforeaddhs
        '
        AddHandler finhs.btnLuu.Click, AddressOf list_dmhs.Save
        AddHandler finhs.btnhuy.Click, AddressOf list_dmhs.Cancel
    End Sub
    Sub xem_dinhKem()
        If grdhs.CurrentRow IsNot Nothing Then
            If Not IsDBNull(grdhs.CurrentRow.Cells("dinh_kem_data").Value) AndAlso Not String.IsNullOrEmpty(grdhs.CurrentRow.Cells("dinh_kem_name").Value.ToString) Then
                Clsql.Data.OpenFileFromDB(grdhs.CurrentRow.Cells("dinh_kem_data").Value, grdhs.CurrentRow.Cells("dinh_kem_name").Value)
            End If
        End If
        
    End Sub
#End Region
#Region "Thong tin cac khoa dao tao"
    Private Sub dao_tao_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dao_tao.Enter
        setupdaotao()
        If list.BindingSource.Count > 0 Then
            list_dt.LoadData("ma_nv='" & list.BindingSource.Current("ma_nv") & "'")
        Else
            list_dt.LoadData("1=0")
        End If

    End Sub

    Private Sub beforeadddaotao()
        If grd.CurrentRow Is Nothing Then
            list_dt.ContinueAdd = False
            Return
        End If

        Dim iditityMa_nv = conn.GetValue("select cast(max(ma_daotao) as numeric(8,0)) from dmdaotao where ma_nv='" & list.BindingSource.Current("ma_nv") & "'")
        If IsDBNull(iditityMa_nv) Then
            iditityMa_nv = 1
        Else
            iditityMa_nv = iditityMa_nv + 1
        End If

        Dim keydefaul As New Collection
        keydefaul.Add(Strings.Format(iditityMa_nv, "00000000"), "ma_daotao")
        keydefaul.Add(grd.Item("ma_nv", grd.CurrentRow.Index).Value, "ma_nv")
        list_dt.SetKeys = keydefaul
    End Sub

    Sub setupdaotao()
        If list_dt IsNot Nothing Then
            Return
        End If
        Dim findt As New daotao
        list_dt = New ClsList.List1("dmdaotao", grddt, findt, False, "1=0")
        findt._grd = grd

        'set label
        
        list_dt.tat.Visible = False
        list_dt.AddToolStripMain(bar_dt)

        '

        AddHandler list_dt.BeforeAddItem, AddressOf beforeadddaotao
        '
        AddHandler findt.btnLuu.Click, AddressOf list_dt.Save
        AddHandler findt.btnhuy.Click, AddressOf list_dt.Cancel
    End Sub

#End Region
#Region "Trinh do chuyen mon"
    Private Sub trinh_do_chuyen_mon_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles trinh_do_chuyen_mon.Enter
        setuptdcm()
        If list.BindingSource.Count > 0 Then
            list_tdcm.LoadData("ma_nv='" & list.BindingSource.Current("ma_nv") & "'")
        Else
            list_tdcm.LoadData("1=0")
        End If

    End Sub

    Private Sub beforeaddtdcm()
        If grd.CurrentRow Is Nothing Then
            list_tdcm.ContinueAdd = False
            Return
        End If
        Dim keydefaul As New Collection
        keydefaul.Add(grd.Item("ma_nv", grd.CurrentRow.Index).Value, "ma_nv")
        list_tdcm.SetKeys = keydefaul
    End Sub

    Sub setuptdcm()
        If list_tdcm IsNot Nothing Then
            Return
        End If
        Dim fintdcm As New chuyenmon
        list_tdcm = New ClsList.List1("dmtrinhdocm", grdtd, fintdcm, False, "1=0")
        fintdcm._grd = grd

        'set label
        
        list_tdcm.tat.Visible = False
        list_tdcm.AddToolStripMain(bar_td)

        '

        AddHandler list_tdcm.BeforeAddItem, AddressOf beforeaddtdcm
        '
        AddHandler fintdcm.btnLuu.Click, AddressOf list_tdcm.Save
        AddHandler fintdcm.btnhuy.Click, AddressOf list_tdcm.Cancel
    End Sub

#End Region
#Region "Dieu chuyen nhan su"
    Private Sub dieu_chuyen_nhan_su_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dieu_chuyen_nhan_su.Enter
        setupdieuchuyen()
        If list.BindingSource.Count > 0 Then
            list_dcns.LoadData("ma_nv='" & list.BindingSource.Current("ma_nv") & "'")
        Else
            list_dcns.LoadData("1=0")
        End If

    End Sub

    Private Sub beforeadddieuchuyen()
        If grd.CurrentRow Is Nothing Then
            list_dcns.ContinueAdd = False
            Return
        End If
        Dim keydefaul As New Collection
        keydefaul.Add(grd.Item("ma_nv", grd.CurrentRow.Index).Value, "ma_nv")
        keydefaul.Add(grd.Item("ma_bp", grd.CurrentRow.Index).Value, "ma_bp_cu")
        keydefaul.Add(grd.Item("ma_cv", grd.CurrentRow.Index).Value, "ma_cv_cu")
        keydefaul.Add(grd.Item("ma_cong_viec", grd.CurrentRow.Index).Value, "ma_cong_viec_cu")
        list_dcns.SetKeys = keydefaul

    End Sub

    

    Sub AfterAddItem_dcns(ByVal r As DataRow)
        'nv.txtma_bp.Text = r.Item("ma_bp_dc")
        'nv.txtma_cv.Text = r.Item("ma_cv_dc")
        'nv.txtma_cong_viec.Text = r.Item("ma_cong_viec_dc")
        'conn.Execute("update dnv set ma_bp = b.ma_bp_dc,ma_cv = b.ma_cv_dc,ma_cong_viec=b.ma_cong_viec_dc from dnv a left join dmdieuchuyenns b on a.ma_nv=b.ma_nv where b.ngay_bd_lv in (select max(ngay_bd_lv) as ngay_bd_lv from dmdieuchuyenns group by ma_nv)")
    End Sub

    Sub setupdieuchuyen()
        If list_dcns IsNot Nothing Then
            Return
        End If
        Dim findcns As New dieuchuyen
        list_dcns = New ClsList.List1("dmdieuchuyenns", grddc, findcns, False, "1=0")
        findcns._grd = grd

        'set label
        

        list_dcns.tat.Visible = False
        list_dcns.AddToolStripMain(bar_dc)

        '

        AddHandler list_dcns.BeforeAddItem, AddressOf beforeadddieuchuyen
        AddHandler list_dcns.AfterAddItem, AddressOf AfterAddItem_dcns
        '
        AddHandler findcns.btnLuu.Click, AddressOf list_dcns.Save
        AddHandler findcns.btnhuy.Click, AddressOf list_dcns.Cancel
    End Sub

#End Region
#Region "Thong tin qua trinh luong"
    Private Sub qtluong_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles qtluong.Enter
        setupqtluong()
        If list.BindingSource.Count > 0 Then
            list_qtluong.LoadData("ma_nv='" & list.BindingSource.Current("ma_nv") & "'")
        Else
            list_qtluong.LoadData("1=0")
        End If

    End Sub

    Private Sub beforeaddqtluong()
        If grd.CurrentRow Is Nothing Then
            list_qtluong.ContinueAdd = False
            Return
        End If
        Dim keydefaul As New Collection

        keydefaul.Add(grd.Item("ma_nv", grd.CurrentRow.Index).Value, "ma_nv")
        list_qtluong.SetKeys = keydefaul
    End Sub

    Sub setupqtluong()
        If list_qtluong IsNot Nothing Then
            Return
        End If
        Dim finqtluong As New qtluong
        list_qtluong = New ClsList.List1("dmqtluong", grdqtluong, finqtluong, False, "1=0")
        finqtluong._grd = grd

        'set label
        'PropertyOfForm.SetLable(list_qtluong.oLable, Panqtluong)
        'PropertyOfForm.BindData(list_qtct.BindingSource, Panqtluong)
        'PropertyOfForm.Sercurity(Panqtluong)
        list_qtluong.tat.Visible = False
        list_qtluong.AddToolStripMain(bar_qtluong)
        list_qtluong.Inds.Visible = True
        '

        AddHandler list_qtluong.BeforeAddItem, AddressOf beforeaddqtluong
        AddHandler list_qtluong.Printing, AddressOf list_qtluong_printing
        AddHandler list_qtluong.BeforePrint, AddressOf list_qtluong_BeforePrint
        '
        AddHandler finqtluong.btnLuu.Click, AddressOf list_qtluong.Save
        AddHandler finqtluong.btnhuy.Click, AddressOf list_qtluong.Cancel
    End Sub

    Sub list_qtluong_printing(ByVal query As String)
        Try
            query = "exec print_qtluong '" & grdqtluong.CurrentRow.Cells("ma_nv").Value & "'," & conn.ConvertToSQLType(grdqtluong.CurrentRow.Cells("ngay_hl").Value)
            list_qtluong.queryPrint = query
        Catch ex As Exception
        End Try
    End Sub

    Sub list_qtluong_BeforePrint(ByVal rpt As ClsRpt.rpt)

    End Sub

#End Region


#Region "Khen thuong & ky luat"
    Private Sub khen_thuong_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles khen_thuong.Enter
        setupktkl()
        If list.BindingSource.Count > 0 Then
            list_ktkl.LoadData("ma_nv='" & list.BindingSource.Current("ma_nv") & "'")
        Else
            list_ktkl.LoadData("1=0")
        End If

    End Sub

    Private Sub beforeaddktkl()
        If grd.CurrentRow Is Nothing Then
            list_ktkl.ContinueAdd = False
            Return
        End If
        Dim keydefaul As New Collection
        keydefaul.Add(grd.Item("ma_nv", grd.CurrentRow.Index).Value, "ma_nv")
        list_ktkl.SetKeys = keydefaul
    End Sub

    Sub setupktkl()
        If list_ktkl IsNot Nothing Then
            Return
        End If
        Dim finktkl As New khenthuong
        list_ktkl = New ClsList.List1("dmktkl", grdktkl, finktkl, False, "1=0")
        finktkl._grd = grd
        ClsLookup.AddItems.AddItemCbb(list_ktkl.conn, "select * from  dmloaikhenthuong", finktkl.cbbten_loai_qd, "ten_loai_qd", "ten_loai_qd2", "ma_loai_qd")

        'set label
        
        list_ktkl.tat.Visible = False
        list_ktkl.AddToolStripMain(bar_ktkl)
        'list_ktkl.Inds.Visible = True
        '

        AddHandler list_ktkl.BeforeAddItem, AddressOf beforeaddktkl
        '
        AddHandler finktkl.btnLuu.Click, AddressOf list_ktkl.Save
        AddHandler finktkl.btnhuy.Click, AddressOf list_ktkl.Cancel
    End Sub

#End Region

#Region "Thong tin qua trinh dong bhxh"
    Private Sub qtdong_bhxh_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles qtdong_bhxh.Enter
        setupqtdong_bhxh()
        If list.BindingSource.Count > 0 Then
            list_qtdong_bhxh.LoadData("ma_nv='" & list.BindingSource.Current("ma_nv") & "'")
        Else
            list_qtdong_bhxh.LoadData("1=0")
        End If

    End Sub

    Private Sub beforeaddqtdong_bhxh()
        If grd.CurrentRow Is Nothing Then
            list_qtdong_bhxh.ContinueAdd = False
            Return
        End If
        Dim keydefaul As New Collection

        keydefaul.Add(grd.Item("ma_nv", grd.CurrentRow.Index).Value, "ma_nv")
        list_qtdong_bhxh.SetKeys = keydefaul
    End Sub

    Sub setupqtdong_bhxh()
        If list_qtdong_bhxh IsNot Nothing Then
            Return
        End If
        Dim finqtdong_bhxh As New qtdong_bhxh
        list_qtdong_bhxh = New ClsList.List1("dmqtdong_bhxh", grdqtdong_bhxh, finqtdong_bhxh, False, "1=0")
        finqtdong_bhxh._grd = grd

        'set label
        'PropertyOfForm.SetLable(list_qtluong.oLable, Panqtluong)
        'PropertyOfForm.BindData(list_qtct.BindingSource, Panqtluong)
        'PropertyOfForm.Sercurity(Panqtluong)
        list_qtdong_bhxh.tat.Visible = False
        list_qtdong_bhxh.AddToolStripMain(bar_qtdong_bhxh)
        'list_qtdong_bhxh.Inds.Visible = True
        '

        AddHandler list_qtdong_bhxh.BeforeAddItem, AddressOf beforeaddqtdong_bhxh
        '
        AddHandler finqtdong_bhxh.btnLuu.Click, AddressOf list_qtdong_bhxh.Save
        AddHandler finqtdong_bhxh.btnhuy.Click, AddressOf list_qtdong_bhxh.Cancel
    End Sub

#End Region

    Private Sub grd_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles grd.RowsAdded
        
        If Reg.GetValue("Language") = "Vi" Then
            lbllines.Text = grd.RowCount & " Nhân viên"
        Else
            lbllines.Text = grd.RowCount & " Nhân viên"
        End If

    End Sub

    Private Sub grd_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles grd.RowsRemoved
       
        If Reg.GetValue("Language") = "Vi" Then
            lbllines.Text = grd.RowCount & " Nhân viên"
        Else
            lbllines.Text = grd.RowCount & " Nhân viên"
        End If
    End Sub


    Private Sub CloseMe(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.FormClosing
        Try
            
            If list.datatable IsNot Nothing Then
                Dim stt_recs As String = ""
                Dim key As String = list.keys.Split(",")(0)
                Dim i As Integer = 0
                For Each r As DataRow In list.datatable.Rows
                    If r.RowState <> DataRowState.Deleted Then
                        If stt_recs <> "" Then
                            stt_recs = stt_recs & "," & conn.ConvertToSQLType(r(key))
                        Else
                            stt_recs = key & " in (" & conn.ConvertToSQLType(r(key))
                        End If
                        i += 1
                        If i > 10 Then
                            Exit For
                        End If
                    End If
                Next
                If stt_recs <> "" Then
                    stt_recs = stt_recs & ")"
                End If

                My.Settings.history = stt_recs
                My.Settings.Save()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Sub loadf()
        'set gia tri mac dinh cho dnv
        Dim ValueDefault As New Collection
        list.ValueDefaults = ValueDefault
        If Not (list.onlyEdit Or list.onlyDelete Or list.onlyAdd) Then
            'bind data cho view
            PropertyOfForm.BindData(list.BindingSource, thong_tin_chung)
            PropertyOfForm.BindData(list.BindingSource, dia_chi)
            PropertyOfForm.BindData(list.BindingSource, bao_hiem)
            'sercurity
            PropertyOfForm.Sercurity(thong_tin_chung)
            PropertyOfForm.Sercurity(dia_chi)
            PropertyOfForm.Sercurity(bao_hiem)
        End If
        
        
        'add button detail
        ' Dim dd As New clsViDe.DropDownButtonDetail(list.conn, ToolStripfind, "ldkh", Me.grd)
        'set up cmd
        frmin.btnhuy.CausesValidation = False
        AddHandler frmin.btnLuu.Click, AddressOf list.Save
        AddHandler frmin.btnhuy.Click, AddressOf list.Cancel

        'AddHandler gridgd.KeyDown, AddressOf PropertyOfGrid.Filter
        AddHandler gridlh.KeyDown, AddressOf PropertyOfGrid.Filter
        AddHandler grd.KeyDown, AddressOf PropertyOfGrid.Filter

        AddHandler list.AfterDeleteItem, AddressOf list_AfterDeleteItem
        AddHandler list.BeforeAddItem, AddressOf BeforeAddItem

        AddHandler list.Printing, AddressOf print_qd_nghi_viec
        AddHandler list.BeforePrint, AddressOf beforeprint


    End Sub

    Sub print_qd_nghi_viec(ByVal query As String)
        Try
            query = "exec print_qd_nghi_viec '" & grd.CurrentRow.Cells("ma_nv").Value & "'"

            list.queryPrint = query
        Catch ex As Exception

        End Try


    End Sub
    Sub setlookup()

    End Sub
  
 

    Private Sub btnPrintBarCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If grd.CurrentRow Is Nothing Then
            Return
        End If

        Dim printbarcode As New ClsRpt.PrintBarCode
        printbarcode.Filter.txtcode.Text = grd.CurrentRow.Cells("ma_nv").Value
        If conn.Lang = SQL.Language.Vietnamese Then
            printbarcode.Filter.txtname.Text = grd.CurrentRow.Cells("ten_nv").Value
        Else
            printbarcode.Filter.txtname.Text = grd.CurrentRow.Cells("ten_nv").Value
        End If
        printbarcode.print(Me)
        printbarcode.dispose()
    End Sub
End Class
