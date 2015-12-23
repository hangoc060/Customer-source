Module Main
    Public conn As Clsql.SQL
    Public list_lh As ClsList.List1 = Nothing
    Public list_hd As ClsList.List1 = Nothing
    Public dv As DataView
    Public listid As String = Clsql.Others.GetArgu(1)
    Public list As ClsList.List1
End Module
