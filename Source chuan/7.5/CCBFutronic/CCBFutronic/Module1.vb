Module Module1

    Sub Main()
        Dim conn As New Clsql.SQL
        Dim dt As DataTable = conn.GetDatatable("select ma_nv,enrollment from dnv where enrollment is not null")
        Dim dir As String = System.AppDomain.CurrentDomain.BaseDirectory & "\DbEnrollment"
        If Not IO.Directory.Exists(dir) Then
            Return
        End If
        For Each r As DataRow In dt.Rows
            If IO.File.Exists(dir & "\" & r("ma_nv")) Then
                IO.File.Delete(dir & "\" & r("ma_nv"))
            End If
            Clsql.Data.GetFileFromDB(r("enrollment"), dir & "\" & r("ma_nv"))
        Next
        If Not IO.File.Exists(System.AppDomain.CurrentDomain.BaseDirectory & "\Enrollment.exe") Then
            Return
        End If
        Dim process As Process = process.Start(System.AppDomain.CurrentDomain.BaseDirectory & "\Enrollment.exe", "identify")
        process.WaitForExit()

        Dim dirdata As String = dir & "\data"
        If IO.Directory.Exists(dirdata) Then
            For Each f As String In IO.Directory.GetFiles(dirdata)
                Dim ds As New DataSet
                ds.ReadXml(f)
                If ds.Tables.Count > 0 Then
                    Dim query As String = conn.GetInsertQueryFromDatatable(ds.Tables(0), "ccbfutronic")
                    conn.Execute(query)
                End If
                ds.Dispose()
                IO.File.Delete(f)
            Next
        End If
    End Sub

End Module
