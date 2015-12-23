Public Class frminput

    Private Sub frminput_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.Txtma_nv.Focus()
    End Sub
    Private Sub txtstart_time_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtstart_time.GotFocus, txtfinish_time.GotFocus
        sender.SelectAll()
    End Sub
    Private Sub txtstart_time_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtstart_time.Validating, txtfinish_time.Validating
        Dim v As String() = sender.Text.ToString.Split(":")
        If v(0).Trim.Length < 2 OrElse v(0) > 23 Then
            e.Cancel = True
            Return
        End If
        If v(1).Trim.Length < 2 OrElse v(1) > 59 Then
            e.Cancel = True
            Return
        End If
        If v(2).Trim.Length < 2 OrElse v(2) > 59 Then
            e.Cancel = True
            Return
        End If
    End Sub
End Class