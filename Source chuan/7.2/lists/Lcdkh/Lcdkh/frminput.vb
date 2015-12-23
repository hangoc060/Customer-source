Public Class frminput

    Private Sub frminput_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.txttk.Focus()
    End Sub


    Private Sub Txtdu_co_nt00_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtdu_co_nt00.Validated
        If Txtdu_co_nt00.Value <> 0 Then
            Txtdu_no_nt00.Value = 0
            Txtdu_no00.Value = 0
        End If
    End Sub
    Private Sub Txtdu_co00_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtdu_co00.Validated
        If Txtdu_co00.Value <> 0 Then
            Txtdu_no_nt00.Value = 0
            Txtdu_no00.Value = 0
        End If
    End Sub
    Private Sub Txtdu_no_nt00_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtdu_no_nt00.Validated
        If Txtdu_no_nt00.Value <> 0 Then
            Txtdu_co_nt00.Value = 0
            Txtdu_co00.Value = 0
        End If
    End Sub
    Private Sub Txtdu_no00_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtdu_no00.Validated
        If Txtdu_no00.Value <> 0 Then
            Txtdu_co_nt00.Value = 0
            Txtdu_co00.Value = 0
        End If
    End Sub
End Class