Public Class sp
    Dim oldtien As Double = 0
    Dim oldma_thue As String
    Dim oldsl As Double = 0
    Dim oldgia As Double = 0

    Private Sub Txtso_luong_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtso_luong.Enter, txtgia.Enter, txtt_tien.Enter, txtma_thue.Enter
        oldsl = Txtso_luong.Value
        oldgia = txtgia.Value
        oldtien = txtt_tien.Value
        oldma_thue = txtma_thue.Text
    End Sub
    Sub tinh_tien_hang()
        txtt_tien.Value = Txtso_luong.Value * txtgia.Value
    End Sub
    Sub tinh_tien_thue()
        Txtt_thue.Value = txtt_tien.Value * Txtthue_suat.Value / 100
    End Sub

    Private Sub Txtso_luong_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtso_luong.Validated
        If oldsl <> Txtso_luong.Value Then
            tinh_tien_hang()
            tinh_tien_thue()
        End If

    End Sub

    Private Sub txtgia_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtgia.Validated
        If oldgia <> txtgia.Value Then
            tinh_tien_hang()
            tinh_tien_thue()
        End If
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