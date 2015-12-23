Imports Clsql
Imports ClsControl2
Imports ClsControl2.PropertyOfForm
Imports ClsLookup
Imports ClsSV31
Imports System.ComponentModel

Public Class Frmmain
    Dim frmin As New frminput
    Private Sub dmload(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'kiem tra dang ky
        If ClsControl2.PropertyOfForm.CheckRegister = False Then
            Me.Close()
        End If
        txtuser.Text = Clsql.Reg.GetValue("ID")
        '
        Voucher = New Voucher20(Voucherid, grd, frmin.TabControl1, frmin)
        conn = Voucher.conn
        Voucher.AddToolStrip(ToolStrip1)
        Voucher.btnpostGL.Visible = False
        Voucher.btnPostStock.Visible = False
        '
        Dim ctm As New ContextMenuStrip
        Voucher.AddContextMenuStrip(ctm)
        Me.ContextMenuStrip = ctm
        '
        SetLable(Voucher.oLan, Me)
        Me.Icon = frmin.Icon
        'khai bao lookup
        SetUpLookup()
        loadf()
    End Sub

    Private Sub thoat(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuthoat.Click
        Voucher = Nothing
        Me.Close()
    End Sub
    Private Sub tim()
        Dim search As New frmsearch
        search.StartPosition = FormStartPosition.CenterParent
        search.Icon = Me.Icon
        If search.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Clsql.Reg.SetValue("tu_ngay", search.Txttu_ngay.Value)
            Clsql.Reg.SetValue("den_ngay", search.TxtDen_ngay.Value)
            Clsql.Reg.SetValue("ma_kho", search.txtma_kho.Text)

            Dim query As String
            Dim strdk As String = " ngay_ct between " & Voucher.conn.ConvertToSQLType(search.Txttu_ngay.Value) & " and " & Voucher.conn.ConvertToSQLType(search.TxtDen_ngay.Value)
            strdk = strdk & " and  ma_kho like '" & search.txtma_kho.Text & "%'"
            strdk = strdk & " and  ma_khon like '" & search.txtma_khon.Text & "%'"
            strdk = strdk & " and  so_ct like '" & search.txtso_ct.Text & "%'"
            query = Voucher.QueryLoad & " and " & strdk & " and stt_rec in " & "(select stt_rec from " & Voucher.TabFirst & " where ma_vt like '" & search.txtma_vt.Text
            query = query & "%' and tk_co like '" & search.txttk_co.Text

            query = query & "%' and ma_bp like '" & search.txtma_bp.Text
            query = query & "%' and ma_phi like '" & search.txtma_phi.Text
            query = query & "%' and ma_dt like '" & search.txtma_dt.Text

            query = query & "%' and tk_no like '" & search.txttk_no.Text & "%')"
            Voucher.LoadData(query.Replace("#*#", "cast(0 as bit) as sel,*"))
        End If

    End Sub
    Sub beforeadd(ByVal e As String)
        Dim defaultvalue As New Collection
        defaultvalue.Add("VND", "ma_nt")
        defaultvalue.Add(Now, "ngay_ct")
        Voucher.ValueDefaults = defaultvalue
        Voucher.FormLookups("txtma_kho").oKey = "ma_dvcs='" & Reg.GetValue("unit") & "'"
        Voucher.FormLookups("txtma_khon").oKey = "ma_dvcs='" & Reg.GetValue("unit") & "'"
    End Sub
    Sub beforeedit(ByVal e As String)
        Voucher.FormLookups("txtma_kho").oKey = "ma_dvcs='" & grd.CurrentRow.Cells("ma_dvcs").Value & "'"
        Voucher.FormLookups("txtma_khon").oKey = "ma_dvcs='" & grd.CurrentRow.Cells("ma_dvcs").Value & "'"
    End Sub
    Sub beforedelete(ByVal e As String)
       
    End Sub

    Sub SetUpLookup()
        ClsLookup.AddItems.AddItemCbb(Voucher.conn, "select inds,text,text2 from dmitemofcbb where form ='" & Voucherid & "' and name = 'status' order by inds", frmin.cbbstatus, "text", "text2", "inds")
        ClsLookup.AddItems.AddItemCbb(Voucher.conn, "select inds,text,text2 from dmitemofcbb where form ='" & Voucherid & "' and name = 'ma_gd' order by inds", frmin.cbbma_gd, "text", "text2", "inds")
        ClsLookup.AddItems.AddItemCbb(Voucher.conn, "exec s_dmnt", frmin.cbbma_nt, "ten_nt", "ma_nt")
        AddHandler Voucher.FirstLoadFormKeyIn, AddressOf Voucher_FirstLoadFormKeyIn
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
        'Dim oLable As Collection = SetLable(Voucher.conn, frmin, Voucherid)
        SetLable(Voucher.oLan, fPrintDialog)
        fPrintDialog.Icon = frmin.Icon

        AddHandler Voucher.btnFind.Click, AddressOf tim

        AddHandler Voucher.BeforeAdd, AddressOf beforeadd
        AddHandler Voucher.BeforeEdit, AddressOf beforeedit
        AddHandler Voucher.BeforeDelete, AddressOf beforedelete
        AddHandler Voucher.AfterDelete, AddressOf AfterDelete
        AddHandler Voucher.AfterImportFromExcel, AddressOf postimportfromexcel
        'print
        oPrint = New Print20(Voucher, fPrintDialog.cbbmau, fPrintDialog.txttieu_de, fPrintDialog.Txtso_lien)
        AddHandler Voucher.btnPrint.Click, AddressOf oPrint.Print
        fPrintDialog.StartPosition = FormStartPosition.CenterParent
        fPrintDialog.Txtso_lien.Value = Voucher.Voucherinfo("d_so_lien")
        'set up formtask
        SetLable(Voucher.oLan, formtask)
        formtask.Icon = Me.Icon
        'load data
        Voucher.LoadFirst()
    End Sub

    Dim kho_dl_yn, khon_dl_yn As Boolean
    Private Sub vt_AfterLookup(ByVal row As System.Data.DataRow, ByVal gridrow As DataGridViewRow)
        kho_dl_yn = conn.GetValue("select dai_ly_yn from dmkho where ma_kho ='" & frmin.txtma_kho.Text & "'")
        khon_dl_yn = conn.GetValue("select dai_ly_yn from dmkho where ma_kho ='" & frmin.txtma_khon.Text & "'")
        If kho_dl_yn = True Then
            gridrow.Cells("tk_co").Value = row("tk_dl")
        End If
        If khon_dl_yn = True Then
            gridrow.Cells("tk_no").Value = row("tk_dl")
        End If
    End Sub

    Private Sub AfterDelete(ByVal e As String)
        'xoa phieu nhap dieu chuyen
        Dim strquery As String = "delete sokho where stt_rec ='" & e.Substring(0, 1) & "PNC" & e.Substring(4) & "'"
        strquery = strquery & Chr(13) & " delete socai where stt_rec ='" & e.Substring(0, 1) & "PNC" & e.Substring(4) & "'"
        conn.Execute(strquery)
    End Sub

    Sub postimportfromexcel(ByVal dicstt_rec As Dictionary(Of String, String), ByVal status As Integer)
        For Each stt_rec As String In dicstt_rec.Keys
            ClsSV31.Functions.Post(conn, Voucherid, Voucher.tenbangchung, Voucher.Stt_rec, status)
        Next
    End Sub

    Private Sub Voucher_FirstLoadFormKeyIn()
        AddHandler Voucher.Tabdetails(Voucher.TabFirst).lookups("ma_dvt").AfterLookup, AddressOf vt_AfterLookup
    End Sub
End Class
