Module Main
    Public conn As Clsql.SQL
    Public list_lh As ClsList.List1 = Nothing
    Public list_hd As ClsList.List1 = Nothing
    Public list_qtct As ClsList.List1 = Nothing
    Public list_qtluong As ClsList.List1 = Nothing
    Public list_qtdong_bhxh As ClsList.List1 = Nothing
    Public list_dt As ClsList.List1 = Nothing
    '  Public list_gd As ClsList.List1
    Public list_dmhs As ClsList.List1 = Nothing
    Public list_tdcm As ClsList.List1 = Nothing
    Public list_dcns As ClsList.List1 = Nothing
    Public list_ktkl As ClsList.List1 = Nothing
    Public dv As DataView
    Public listid As String = Clsql.Others.GetArgu(1)
    Public list As ClsList.List1
End Module
