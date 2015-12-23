Imports System.Windows.Forms

Public Class formChooseRes



   
    Private Sub listRes_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles listRes.DoubleClick
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class
