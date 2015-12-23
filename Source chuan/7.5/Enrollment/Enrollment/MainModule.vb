Imports Futronic.SDKHelper

Module MainModule
    Public UserName As String
    Public baihoc As String
    Public m_OperationObj
    Public m_DatabaseDir As String
    Public m_Operation As FutronicSdkBase
    Public Delegate Sub SetImageCallback(hBitmap As Bitmap)
    Public Delegate Sub SetTextCallback(text As String)
    Public Delegate Sub click()
    Public Function Main(args() As String) As Integer
        m_DatabaseDir = Application.StartupPath & "/DbEnrollment"
        If (args.Length = 0) Then
            Return 0
        End If
        UserName = args(0)
        If UserName = "identify" Then
            If args.Count < 2 Then
                baihoc = "data"
            Else
                baihoc = args(1)
            End If

            Dim f As New frmIdentify
            f.ShowDialog()
            Return 1
        Else
            Dim f As New frmEnroll
            If f.ShowDialog() = DialogResult.OK Then
                Return 1
            Else
                Return 0
            End If
        End If
        

    End Function

End Module
