Public Class frminput



    Private Sub frminput_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.txtma_dvcs.Focus()
    End Sub

   
    Private Sub Txtdu_co_nt00_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtdu_co_nt00.Validated
        If Txtdu_co_nt00.Value <> 0 Then
            Txtdu_no_nt00.Value = 0
            Txtdu_no00.Value = 0
        End If
        If reonly = True Then
            Txtdu_co_nt1.Value = Txtdu_co_nt00.Value
            Txtdu_co_nt_dn_Validated(sender, e)
        End If
    End Sub
    Private Sub Txtdu_co00_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtdu_co00.Validated
        If Txtdu_co00.Value <> 0 Then
            Txtdu_no_nt00.Value = 0
            Txtdu_no00.Value = 0
        End If
        If reonly = True Then
            Txtdu_co1.Value = Txtdu_co00.Value
            Txtdu_co1_Validated(sender, e)
        End If
    End Sub
    Private Sub Txtdu_no_nt00_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtdu_no_nt00.Validated
        If Txtdu_no_nt00.Value <> 0 Then
            Txtdu_co_nt00.Value = 0
            Txtdu_co00.Value = 0
        End If
        If reonly = True Then
            Txtdu_no_nt1.Value = Txtdu_no_nt00.Value
            Txtdu_no_nt1_Validated(sender, e)
        End If
    End Sub
    Private Sub Txtdu_no00_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtdu_no00.Validated
        If Txtdu_no00.Value <> 0 Then
            Txtdu_co_nt00.Value = 0
            Txtdu_co00.Value = 0
        End If
        If reonly = True Then
            Txtdu_no1.Value = Txtdu_no00.Value
            Txtdu_no1_Validated(sender, e)
        End If
    End Sub


    Private Sub Txtdu_co_nt_dn_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtdu_co_nt1.Validated
        If Txtdu_co_nt1.Value <> 0 Then
            Txtdu_no_nt1.Value = 0
            Txtdu_no1.Value = 0
        End If
    End Sub
    Private Sub Txtdu_co1_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtdu_co1.Validated
        If Txtdu_co1.Value <> 0 Then
            Txtdu_no_nt1.Value = 0
            Txtdu_no1.Value = 0
        End If
    End Sub
    Private Sub Txtdu_no_nt1_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtdu_no_nt1.Validated
        If Txtdu_no_nt1.Value <> 0 Then
            Txtdu_co_nt1.Value = 0
            Txtdu_co1.Value = 0
        End If
    End Sub
    Private Sub Txtdu_no1_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtdu_no1.Validated
        If Txtdu_no1.Value <> 0 Then
            Txtdu_co_nt1.Value = 0
            Txtdu_co1.Value = 0
        End If
    End Sub
End Class