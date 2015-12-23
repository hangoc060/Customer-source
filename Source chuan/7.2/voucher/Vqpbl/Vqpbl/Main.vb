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
        SetLable(Voucher.oLan, Me)
        Me.Icon = frmin.Icon
        'khai bao menu
        Dim ctm As New ContextMenuStrip
        Voucher.AddContextMenuStrip(ctm)
        Me.ContextMenuStrip = ctm
        'load
        SetUpLookup()
        loadf()
        ' Voucher.btnDelete.Visible = False
        Voucher.btnNew.Visible = False
        Voucher.btnCopy.Visible = False

        '
        'For Each d As ClsSV31.TabDetail20 In Voucher.Tabdetails.Values
        '    d.gridDetailKeyin.AllowUserToAddRows = False
        '    d.gridDetailKeyin.AllowUserToDeleteRows = False
        'Next
        
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
            Dim query As String
            Dim strdk As String = " ngay_ct between " & Voucher.conn.ConvertToSQLType(search.Txttu_ngay.Value) & " and " & Voucher.conn.ConvertToSQLType(search.TxtDen_ngay.Value)
            strdk = strdk & " and  ma_kh like '" & search.txtma_kh.Text & "%'"
            strdk = strdk & " and ma_nv like '" & search.txtma_nv.Text & "%'"
            strdk = strdk & " and so_ct like '" & search.txtso_ct.Text & "%'"

            query = Voucher.QueryLoad & " and " & strdk & " and stt_rec in " & "(select stt_rec from " & Voucher.Tabdetails(Voucher.TabFirst).TableName & " where ma_vt like '" & search.txtma_vt.Text
            
            query = query & "%' and ma_bp like '" & search.txtma_bp.Text
            query = query & "%' and ma_phi like '" & search.txtma_phi.Text
            query = query & "%' and ma_dt like '" & search.txtma_dt.Text

            query = query & "%' and ma_vt in  (select ma_vt from dmvt where nha_cung_cap like '" & search.txtma_ncc.Text & "%'))"
            Voucher.LoadData(query.Replace("#*#", "cast(0 as bit) as sel,*"))
        End If

    End Sub
    Sub beforedelete(ByVal e As String)
        Dim xhd As Boolean = conn.GetValue("if  exists(select stt_rec_pbl from dxhd where stt_rec_pbl ='" & e & "') select cast(1 as bit) else select cast(0 as bit)")
        Voucher.delete_yn = Not xhd
        If Voucher.delete_yn Then
            Voucher.delete_yn = conn.GetValue("if  exists(select stt_rec from tdttno where status = 5 and left(stt_rec_tt,1) ='" & Clsql.Reg.GetValue("workstation") & "' and right(stt_rec_tt,9)='" & Voucher.Stt_rec.Substring(4) & "' and ma_ct_tt='" & Voucherid & "') select 0 else select 1 ")
        End If
        If Voucher.delete_yn = False Then
            MsgBox(Voucher.oLan("416"), MsgBoxStyle.Exclamation, Text)
        End If
    End Sub
    Sub beforeedit(ByVal e As String)
        Dim xhd As Boolean = conn.GetValue("if  exists(select stt_rec_pbl from dxhd where stt_rec_pbl ='" & e & "') select cast(1 as bit) else select cast(0 as bit)")
        frmin.btnLuu.Enabled = Not xhd
    End Sub

    Sub SetUpLookup()

        ClsLookup.AddItems.AddItemCbb(Voucher.conn, "select inds,text,text2 from dmitemofcbb where form ='" & Voucherid & "' and name = 'status' order by inds", frmin.cbbstatus, "text", "text2", "inds")
        ClsLookup.AddItems.AddItemCbb(Voucher.conn, "exec s_dmnt", frmin.cbbma_nt, "ten_nt", "ma_nt")

        AddHandler Voucher.BeforeEdit, AddressOf kiem_tra_thanh_toan


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
        SetLable(Voucher.oLan, fPrintDialog)
        fPrintDialog.Icon = frmin.Icon


        AddHandler Voucher.btnFind.Click, AddressOf tim
        AddHandler Voucher.BeforeEdit, AddressOf kiem_tra_thanh_toan
        AddHandler Voucher.BeforeDelete, AddressOf beforedelete
        AddHandler Voucher.BeforeEdit, AddressOf beforeedit
        AddHandler Voucher.AfterImportFromExcel, AddressOf postimportfromexcel

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
    Sub kiem_tra_thanh_toan()
        'Voucher.Tabdetails(Voucher.TabFirst).lookups("ma_kho").oKey = "ma_dvcs='" & grd.CurrentRow.Cells("ma_dvcs").Value & "'"
        'If conn.GetValue("if  exists(select stt_rec from tdttno where status = 5 and left(stt_rec_tt,1) ='" & Clsql.Reg.GetValue("workstation") & "' and right(stt_rec_tt,9)='" & Voucher.Stt_rec.Substring(4) & "' and ma_ct_tt='" & Voucherid & "') select 0 else select 1 ") = False Then
        '    frmin.btnLuu.Enabled = False
        '    frmin.btnluuandmoi.Enabled = False
        'End If

    End Sub

   

    Sub postimportfromexcel(ByVal dicstt_rec As Dictionary(Of String, String), ByVal status As Integer)
        For Each stt_rec As String In dicstt_rec.Keys
            'post(stt_rec, status)
            ClsSV31.Functions.Post(conn, Voucherid, Voucher.tenbangchung, Voucher.Stt_rec, status)
        Next
    End Sub
End Class
