Module Module1
    Public list_id As String = "dmkh"
    Public list_id_permistion As String = "dmkhle"
    Public dtCust As DataTable
    Public dmgiaban As DataTable
    Public conn As Clsql.SQL
    Public ma_ct As String, exe As String, ct_custcall As String
    Public ds_loaikh As DataSet
    Public ds_history As DataSet
    Public dt_px8tmp As DataTable
    Public dirData As String = Application.StartupPath & "\datapx8tmp"
    Public dirKH As String = Application.StartupPath & "\datakh"
    Public flog As String = Application.StartupPath & "\phonelog2.xml"
    Public port As Integer = 1972
End Module
