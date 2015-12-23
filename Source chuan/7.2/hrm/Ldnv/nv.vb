Imports Clsql

Public Class nv

    Private Sub frminput_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        TabControl1.SelectedTab = thong_tin_chung
        txtma_nv.Focus()
    End Sub

    Private Sub txtngay_nghi_viec_Validated(ByVal sender As Object, ByVal e As System.EventArgs)
        If txtngay_nghi_viec.Text.Replace("/", "").Replace(" ", "") = "" Then
            chbdang_lam_viec.Checked = True
        Else
            chbdang_lam_viec.Checked = False
        End If


    End Sub
End Class