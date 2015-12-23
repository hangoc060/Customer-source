Imports ClsLookup
Imports ClsSV31

Module Genaral
    Public Voucherid As String = Clsql.Others.GetArgu(1)
    Public Voucher As ClsSV31.Voucher20
    Public conn As Clsql.SQL
    Public f_tien As String
    Public f_tien_nt As String
    Public f_so_luong As String
    Public oPrint As Print20
    Public ma_nt_ht As String
    Public formtask As New ClsSV31.frmTask
    Public fPrintDialog As New frmPrint
End Module
