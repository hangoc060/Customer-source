Imports Clsql
Imports ClsControl2
Imports ClsControl2.PropertyOfForm
Imports ClsLookup
Imports ClsSV31
Imports System.ComponentModel
Imports ClsStpService

Public Class Frmmain

    Dim frmin As New frminput


    Private Sub dmload(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        'kiem tra dang ky
        If ClsControl2.PropertyOfForm.CheckRegister = False Then
            Me.Close()
        End If
        txtuser.Text = Clsql.Reg.GetValue("ID")
        '
        '
        Voucher = New Voucher20(Voucherid, grd, frmin.TabControl1, frmin)
        conn = Voucher.conn
        Voucher.AddToolStrip(ToolStrip1)
        Voucher.btnpostGL.Visible = False
        Voucher.btnPostStock.Visible = False
        SetLable(Voucher.oLan, Me)
        Me.Icon = frmin.Icon
        '

        Dim ctm As New ContextMenuStrip
        Voucher.AddContextMenuStrip(ctm)
        Me.ContextMenuStrip = ctm
        Dim tabmanager As New TabManager(frmin.TabControl1)
        'loadf
        SetUpLookup()
        loadf()
    End Sub

    Private Sub thoat(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuthoat.Click
        Voucher = Nothing
        Me.Close()
    End Sub
    Private Sub tim()
        Dim search As New frmsearch
        search.Icon = Me.Icon
        search.StartPosition = FormStartPosition.CenterParent
        If search.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then

            Clsql.Reg.SetValue("tu_ngay", search.Txttu_ngay.Value)
            Clsql.Reg.SetValue("den_ngay", search.TxtDen_ngay.Value)
            Clsql.Reg.SetValue("ma_kh", search.txtma_kh.Text)
            Clsql.Reg.SetValue("tk_no", search.txttk_no.Text)
            Clsql.Reg.SetValue("tk_co", search.txttk_co.Text)

            Dim query As String
            Dim strdk As String = " ngay_ct between " & Voucher.conn.ConvertToSQLType(search.Txttu_ngay.Value) & " and " & Voucher.conn.ConvertToSQLType(search.TxtDen_ngay.Value)
            strdk = strdk & " and  ma_kh like '" & search.txtma_kh.Text & "%'"
            strdk = strdk & " and  so_ct like '" & search.txtso_ct.Text & "%'"

            query = Voucher.QueryLoad & " and " & strdk & " and stt_rec in " & "(select stt_rec from " & Voucher.Tabdetails(Voucher.TabFirst).TableName & " where ma_vt like '" & search.txtma_vt.Text
            query = query & "%' and tk_vt like '" & search.txttk_no.Text
            query = query & "%' and ma_bp like '" & search.txtma_bp.Text
            query = query & "%' and ma_phi like '" & search.txtma_phi.Text
            query = query & "%' and ma_dt like '" & search.txtma_dt.Text

            query = query & "%' and tk_du like '" & search.txttk_co.Text & "%')"

            Voucher.LoadData(query.Replace("#*#", "cast(0 as bit) as sel,*"))
        End If

    End Sub
    Sub beforeadd(ByVal e As String)
        Dim defaultvalue As New Collection
        'defaultvalue.Add("VND", "ma_nt")
        defaultvalue.Add(Now, "ngay_ct")
        Voucher.ValueDefaults = defaultvalue
        Voucher.Tabdetails(Voucher.TabFirst).lookups("ma_kho").oKey = "ma_dvcs='" & Reg.GetValue("unit") & "'"
        frmin.TabControl1.SelectedTab = frmin.TabControl1.TabPages(0)
    End Sub
    Sub beforeedit(ByVal e As String)
        Voucher.Tabdetails(Voucher.TabFirst).lookups("ma_kho").oKey = "ma_dvcs='" & grd.CurrentRow.Cells("ma_dvcs").Value & "'"
        kiem_tra_thanh_toan()
    End Sub
    Sub beforedelete(ByVal e As String)
        Voucher.delete_yn = conn.GetValue("if  exists(select stt_rec from tdttco where status = 5 and left(stt_rec_tt,1) ='" & Clsql.Reg.GetValue("workstation") & "' and right(stt_rec_tt,9)='" & e.Substring(4) & "' and ma_ct_tt='" & Voucherid & "') select 0 else select 1 ")
        If Voucher.delete_yn = False Then
            MsgBox(Voucher.oLan("416"), MsgBoxStyle.Exclamation, Text)
        End If
    End Sub
    Sub afterdelete(ByVal e As String)
        'xoa phieu chi cu
        Dim query As String
        Dim dtpc As DataTable = conn.GetDatatable("select * from mpc1 where stt_rec_goc ='" & e & "'")
        If dtpc.Rows.Count > 0 Then
            'xoa post
            ClsSV31.Functions.deletePost(conn, dtpc.Rows(0).Item("ma_ct"), dtpc.Rows(0))
            'xoa detail master
            Dim stt_rec_pc As String = dtpc.Rows(0).Item("stt_rec")
            query = "delete from dpc1 where stt_rec='" & stt_rec_pc & "'"
            query = query & ChrW(13) & "GO" & ChrW(13) & "delete from mpc1 where stt_rec='" & stt_rec_pc & "'"
            conn.ExecuteWithMultiQuery(query)

        End If
    End Sub
    Sub SetUpLookup()
        ClsLookup.AddItems.AddItemCbb(conn, "select inds,text,text2 from dmitemofcbb where form ='" & Voucherid & "' and name = 'status'", frmin.cbbstatus, "text", "text2", "inds")
        ClsLookup.AddItems.AddItemCbb(Voucher.conn, "select inds,text,text2,val,val2 from dmitemofcbb where form ='" & Voucherid & "' and name = 'kieu_pb'", frmin.cbbkieu_pb, "text", "text2", "val")
        ClsLookup.AddItems.AddItemCbb(conn, "exec s_dmnt", frmin.cbbma_nt, "ten_nt", "ten_nt2", "ma_nt")
        AddHandler Voucher.FormLookups.Item("txtma_kh").AfterLookup, AddressOf ma_khSelected
    End Sub
    Dim current_kh As StpTableRow
    Sub ma_khSelected(ByVal row As StpTableRow)
        frmin.txtcon_no.Value = 0
        current_kh = row
        Dim thread As New Threading.Thread(AddressOf tinh_cn_ht)
        thread.IsBackground = True
        thread.Start()

    End Sub
    Public Delegate Sub DelegateStandardPattern(ByVal cn As Double)

    Sub setCon_no(ByVal cn As Double)
        frmin.txtcon_no.Value = cn
    End Sub
    Sub tinh_cn_ht()
        Try
            Dim query As String = "select du from dbo.EdCust('331'"
            query = query & "," & conn.ConvertToSQLType(current_kh("ma_kh"))
            query = query & "," & conn.ConvertToSQLType(Now)
            query = query & ",'')"
            Dim cn As Double = conn.GetValue(query)
            If frmin.txtcon_no.InvokeRequired Then
                frmin.txtcon_no.Invoke(New DelegateStandardPattern(AddressOf setCon_no), cn)
            Else
                setCon_no(cn)
            End If

        Catch ex As Exception
        End Try
    End Sub
    Sub kiem_tra_thanh_toan()
        If conn.GetValue("exec kiemtrathanhtoanco " & conn.ConvertToSQLType(Voucher.Stt_rec) & "," & conn.ConvertToSQLType(Voucherid)) = False Then
            frmin.btnLuu.Enabled = False
            frmin.btnluuandmoi.Enabled = False
        End If
    End Sub
    Sub loadf()
        '
        f_tien = Clsql.Format.GetFormatNumeric(conn)
        f_tien_nt = Clsql.Format.GetFormatNumeric(conn, "f_tien_nt")
        f_so_luong = Clsql.Format.GetFormatNumeric(conn, "f_sl")
        ma_nt_ht = Clsql.Others.Options("a_dtht", conn)
        '
        grd.ReadOnly = False
        Voucher.btnCancel = frmin.btnhuy

        SetLable(Voucher.oLan, frmsearch)
        SetLable(Voucher.oLan, fPrintDialog)
        fPrintDialog.Icon = frmin.Icon

        frmsearch.Icon = Me.Icon

        AddHandler Voucher.btnFind.Click, AddressOf tim

        AddHandler Voucher.BeforeAdd, AddressOf beforeadd
        AddHandler Voucher.BeforeEdit, AddressOf beforeedit
        AddHandler Voucher.BeforeDelete, AddressOf beforedelete
        AddHandler Voucher.AfterDelete, AddressOf afterdelete

        ' AddHandler Voucher.AfterImportFromExcel, AddressOf postimportfromexcel
        'print
        oPrint = New ClsSV31.Print20(Voucher, fPrintDialog.cbbmau, fPrintDialog.txttieu_de, fPrintDialog.Txtso_lien)
        AddHandler Voucher.btnPrint.Click, AddressOf oPrint.Print
        fPrintDialog.StartPosition = FormStartPosition.CenterParent
        fPrintDialog.Txtso_lien.Value = Voucher.Voucherinfo("d_so_lien")
        'set up formtask
        SetLable(Voucher.oLan, formtask)
        formtask.Icon = Me.Icon
        'load data
        Voucher.LoadFirst()
    End Sub

End Class
