Public Class sp
    Dim oldtien As Double = 0
    

    Private Sub Txtso_luong_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtt_tien.Enter

        oldtien = txtt_tien.Value

    End Sub
   
    Sub tinh_tien_thue()
        Txtt_thue.Value = txtt_tien.Value * Txtthue_suat.Value / 100
    End Sub

  
    Private Sub txtt_tien_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtt_tien.Validated
        If oldtien <> txtt_tien.Value Then
            tinh_tien_thue()
        End If
    End Sub

    Private Sub txtma_thue_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtthue_suat.TextChanged
        tinh_tien_thue()
    End Sub

   
End Class