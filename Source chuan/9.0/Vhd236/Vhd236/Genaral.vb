Imports ClsLookup

Module Genaral
    Public Voucherid As String = Clsql.Others.GetArgu(1)
    Public Voucher As ClsSV31.Voucher20
    Public conn As Clsql.SQL
    Public f_tien As String
    Public f_tien_nt As String
    Public f_so_luong As String
    Public oPrint As ClsSV31.Print20
    Public ma_nt_ht As String
    Public formtask As New ClsSV31.frmTask
    Public fPrintDialog As New frmPrint
    Public frmin As New frminput
    Public ma_vt_deleted As String
    Public ma_kho_deleted As String
    Public Sub row_remove(ByVal r As DataGridViewRow)
        ma_vt_deleted = r.Cells("ma_vt").Value
        ma_kho_deleted = r.Cells("ma_kho").Value
        xoa_sp_km(ma_vt_deleted, ma_kho_deleted)
    End Sub
    Public Sub xoa_sp_km(ByVal ma_vt As String, ByVal ma_kho As String)
        For Each r As DataGridViewRow In Voucher.Tabdetails("vdhd2_km").gridDetailKeyin.Rows
            If r.IsNewRow Then
                Continue For
            End If
            If r.Cells("sp_km_of").Value = ma_vt AndAlso r.Cells("ma_kho").Value = ma_kho Then
                Voucher.Tabdetails("vdhd2_km").gridDetailKeyin.Rows.Remove(r)
            End If
        Next
    End Sub
    Public Sub tinh_sp_km(ByVal ma_vt As String, ByVal ma_kh As String, ByVal ma_kho As String, ByVal grid As DataGridView)
        If ma_vt = "" Then
            Return
        End If
        ma_vt = ma_vt.Replace("'", "''")
        ma_kh = ma_kh.Replace("'", "''")
        ma_kho = ma_kho.Replace("'", "''")
        Dim dvt_chuan As String = conn.GetValue("select ma_dvt from dmvt where ma_vt ='" & ma_vt & "'")

        Dim hs_qd As Double = 1
        Dim m_dvt As String
        'tinh so luong xuat cua sp nay theo don vi tinh chuan
        Dim sl_xuat As String = 0
        For Each rx As DataGridViewRow In grid.Rows
            If rx.IsNewRow Then
                Continue For
            End If
            If rx.Cells("ma_vt").Value = ma_vt Then
                m_dvt = rx.Cells("ma_dvt").Value
                If m_dvt <> dvt_chuan Then
                    hs_qd = conn.GetValue("select he_so from dmqddvt where ma_vt ='" & ma_vt & "' and ma_dvt =N'" & m_dvt & "'")
                Else
                    hs_qd = 1
                End If

                sl_xuat = sl_xuat + rx.Cells("sl_xuat").Value * hs_qd
            End If
        Next
        'tinh sp km
        Dim query As String = "exec get_sanphamkhuyenmai '" & ma_vt & "',N'" & dvt_chuan & "','" & ma_kh & "','" & ma_kho & "'," & sl_xuat
        Dim dt As DataTable = conn.GetDatatable(query)
        Clsql.Data.CopyTable(dt, Voucher.Tabdetails("vdhd2_km").Datatable, "1=1", "sp_km_of ='" & ma_vt & "'")
    End Sub

End Module
