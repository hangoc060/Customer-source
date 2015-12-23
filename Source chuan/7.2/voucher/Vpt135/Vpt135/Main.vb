Imports Clsql
Imports ClsControl2
Imports ClsControl2.PropertyOfForm
Imports ClsLookup
Imports ClsSV31
Imports System.ComponentModel
Imports ClsStpService

Public Class Frmmain
    Dim frmin As New frminput
    'Dim WithEvents oKH As ClsLookup.AutoCompleteLookup
    Private Sub dmload(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        'kiem tra dang ky

        If ClsControl2.PropertyOfForm.CheckRegister = False Then
            Me.Close()
        End If

        txtuser.Text = Clsql.Reg.GetValue("ID")
        Voucher = New Voucher20(Voucherid, grd, frmin.TabControl1, frmin)

        Voucher.autoRefreshMaster = False
        conn = Voucher.conn

        Voucher.btnpostGL.Visible = False
        Voucher.btnPostStock.Visible = False
        SetLable(Voucher.oLan, Me)
        Me.Icon = frmin.Icon
        Voucher.AddToolStrip(ToolStrip1)
        Dim ctm As New ContextMenuStrip
        Voucher.AddContextMenuStrip(ctm)
        Me.ContextMenuStrip = ctm
        'khai bao lookup
        SetUpLookup()
        loadf()
        ''
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

            Dim query As String
            Dim strdk As String = " ngay_ct between " & Voucher.conn.ConvertToSQLType(search.Txttu_ngay.Value) & " and " & Voucher.conn.ConvertToSQLType(search.TxtDen_ngay.Value)
            strdk = strdk & " and  ma_kh like '" & search.txtma_kh.Text & "%'"
            strdk = strdk & " and  so_ct like '" & search.txtso_ct.Text & "%'"


            query = Voucher.QueryLoad & " and " & strdk & " and stt_rec in " & "(select stt_rec from " & Voucher.Tabdetails(Voucher.TabFirst).TableName & " where "

            query = query & " ma_bp like '" & search.txtma_bp.Text
            query = query & "%' and ma_phi like '" & search.txtma_phi.Text
            query = query & "%' and ma_dt like '" & search.txtma_dt.Text & "%')"


            Voucher.LoadData(query.Replace("#*#", "cast(0 as bit) as sel,*"))
        End If

    End Sub
    Sub beforeadd(ByVal e As String)
        Dim defaultvalue As New Collection
        defaultvalue.Add("VND", "ma_nt")
        defaultvalue.Add(Now, "ngay_ct")
        Voucher.ValueDefaults = defaultvalue

    End Sub
    Sub detailHD_load(ByVal e As String)
        If Voucher.Action = ClsSV31.Voucher20.Actions.ADD Then
            frmin.Txtngay_ct.Value = Now
        Else
            frmin.Txtngay_ct.Value = grd.Item("ngay_ct", grd.CurrentRow.Index).Value
            frmin.txtma_kh.Text = grd.Item("ma_kh", grd.CurrentRow.Index).Value
        End If
        Voucher.Tabdetails("tdttno").Datatable = conn.GetDatatable("Exec GetInvoice4Rec_load ''," & conn.ConvertToSQLType(frmin.Txtngay_ct.Value) & "," & Voucher.Action & "," & conn.ConvertToSQLType(e))
        Voucher.Tabdetails("tdttno").gridDetailKeyin.AllowUserToAddRows = False
        Voucher.Tabdetails("tdttno").bindingsource.DataSource = Voucher.Tabdetails("tdttno").Datatable
        frmin.Txtt_tien_nt.Value = ClsControl2.PropertyOfGrid.Sum(Voucher.Tabdetails("tdttno").gridDetailKeyin, "tien_nt")
        frmin.Txtt_tien.Value = ClsControl2.PropertyOfGrid.Sum(Voucher.Tabdetails("tdttno").gridDetailKeyin, "tien")
    End Sub


    Sub SetUpLookup()
        ClsLookup.AddItems.AddItemCbb(Voucher.conn, "select inds,text,text2 from dmitemofcbb where form ='" & Voucherid & "' and name = 'status'", frmin.cbbstatus, "text", "text2", "inds")
        ClsLookup.AddItems.AddItemCbb(Voucher.conn, "select inds,text,text2 from dmitemofcbb where form ='" & Voucherid & "' and name = 'ma_gd'", frmin.cbbma_gd, "text", "text2", "inds")


        layhd = New GetDataByStore(Voucher.conn, "dpt1_ghd", "TTHD")
        AddHandler layhd.BeforeShow, AddressOf BeforeShowInvoide
        ClsLookup.AddItems.AddItemCbb(Voucher.conn, "exec s_dmnt", frmin.cbbma_nt, "ten_nt", "ma_nt")


        AddHandler Voucher.FormLookups.Item("txtma_kh").AfterLookup, AddressOf ma_khSelected
    End Sub
    Sub AfterDeleted(ByVal e As String)
        If querytt <> "" Then
            conn.Execute(querytt)
        End If
    End Sub
    Dim current_kh As StpTableRow
    Sub ma_khSelected(ByVal row As StpTableRow)
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
            Dim query As String = "select du from dbo.EdCust('131'"
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
    Sub BeforeDelete(ByVal e As String)
        Dim dt As DataTable = conn.GetDatatable("select stt_rec_tt,ma_ct_tt from tdttno where stt_rec ='" & e & "'")
        For Each r As DataRow In dt.Rows
            querytt = querytt & Chr(13) & "EXEC Tatoanno '" & r("stt_rec_tt") & "','" & r("ma_ct_tt") & "'"
        Next
    End Sub
    Sub BeforeShowInvoide(ByVal dv As DataView)
        For Each r As DataRow In dv.Table.Select("tien_nt<>0")
            r("sel") = True
        Next

    End Sub
    Sub loadf()

        'thanh toan theo hoa don
        Voucher.Tabdetails("tdttno").AutoLoad = False
        AddHandler Voucher.Tabdetails("tdttno").Load, AddressOf detailHD_load
        '
        f_tien = Clsql.Format.GetFormatNumeric(conn)
        f_tien_nt = Clsql.Format.GetFormatNumeric(conn, "f_tien_nt")
        f_so_luong = Clsql.Format.GetFormatNumeric(conn, "f_sl")
        ma_nt_ht = Clsql.Others.Options("a_dtht", conn)
        '
        grd.ReadOnly = False
        Voucher.btnCancel = frmin.btnhuy
        AddHandler Voucher.btnFind.Click, AddressOf tim
        AddHandler Voucher.BeforeAdd, AddressOf beforeadd
        AddHandler Voucher.BeforeDelete, AddressOf BeforeDelete
        AddHandler Voucher.AfterDelete, AddressOf AfterDeleted

        AddHandler ClsSV31.Functions.BeforePost, AddressOf BeforePost
        AddHandler ClsSV31.Functions.AfterPost, AddressOf AfterPost
        AddHandler Voucher.AfterImportFromExcel, AddressOf postimportfromexcel

        'SetUpLookup()
        SetLable(Voucher.oLan, fPrintDialog)
        fPrintDialog.Icon = frmin.Icon
        'print
        oPrint = New ClsSV31.Print20(Voucher, fPrintDialog.cbbmau, fPrintDialog.txttieu_de, fPrintDialog.Txtso_lien)  'New ClPrint.Print(conn, Voucherid, fPrintDialog.cbbmau, fPrintDialog.txttieu_de)
        AddHandler oPrint.BeforeShowReport, AddressOf beforePrintpt
        AddHandler Voucher.btnPrint.Click, AddressOf oPrint.Print  'printF
        fPrintDialog.StartPosition = FormStartPosition.CenterParent
        fPrintDialog.Txtso_lien.Value = Voucher.Voucherinfo("d_so_lien")
        'set up formtask
        SetLable(Voucher.oLan, formtask)
        formtask.Icon = Me.Icon
        'load data
        Voucher.LoadFirst()

    End Sub


    Sub BeforePost(ByVal ma_ct As String, ByVal stt_rec As String, ByVal status As Integer)
        If querytt <> "" Then
            conn.Execute(querytt)
        End If
    End Sub
    Sub AfterPost(ByVal ma_ct As String, ByVal stt_rec As String, ByVal status As Integer)
        querytt = getQuerytattoan()
        If querytt <> "" Then
            conn.Execute(querytt)
        End If
    End Sub
    Sub beforePrintpt()
        oPrint.oPrint.SetParameterValue("sctkt", fPrintDialog.Txtsctkt.Value)
        oPrint.oPrint.SetParameterValue("dien_giai_ctg", fPrintDialog.txtdien_giai_ctg.Text)
    End Sub
    Sub postimportfromexcel(ByVal dicstt_rec As Dictionary(Of String, String), ByVal status As Integer)
        For Each stt_rec As String In dicstt_rec.Keys
            ClsSV31.Functions.Post(conn, Voucherid, Voucher.tenbangchung, Voucher.Stt_rec, status)
        Next
    End Sub
End Class
