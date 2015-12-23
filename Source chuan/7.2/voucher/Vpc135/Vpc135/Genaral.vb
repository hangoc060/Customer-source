Imports ClsLookup

Module Genaral
    Public Voucherid As String = Clsql.Others.GetArgu(1)
    Public Voucher As ClsSV31.Voucher20
    Public conn As Clsql.SQL
    Public f_tien As String
    Public f_tien_nt As String
    Public f_so_luong As String
    Public oPrint As ClsSV31.Print20
    Public layhd As GetDataByStore
    Public querytt As String = ""
    Public formtask As New ClsSV31.frmTask
    Public fPrintDialog As frmPrint
    Public fPrintDialog2 As frmPrint2

    Public dtht As String

    Function getQuerytattoan() As String
        Dim kq As String = ""
        For Each r As DataRow In conn.GetDatatable("select stt_rec_tt,ma_ct_tt from vtdttco where stt_rec ='" & Voucher.Stt_rec & "'").Rows
            kq = kq & Chr(13) & "EXEC Tatoanco '" & r("stt_rec_tt") & "','" & r("ma_ct_tt") & "'"
        Next
        Return kq
    End Function

 
End Module
