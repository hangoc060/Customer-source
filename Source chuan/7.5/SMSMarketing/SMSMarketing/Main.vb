Module Main
    Public baudrate As Double = 9600
    Public port As String = "COM3"
    Public path As String = Application.StartupPath & "\smsmodemconfig.xml"
    Public Sub readConfig()
        If System.IO.File.Exists(path) Then
            Try
                Dim ds As New DataSet
                ds.ReadXml(path)
                port = ds.Tables(0).Rows(0).Item("port")
                baudrate = ds.Tables(0).Rows(0).Item("baudrate")
                ds.Dispose()
            Catch ex As Exception
            End Try
        End If
        
    End Sub
End Module
