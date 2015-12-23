Imports Clsql

Public Class kh

    Private Sub frminput_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        TabControl1.SelectedTab = tabthong_tin_chinh
        txtma_kh.Focus()
    End Sub
End Class