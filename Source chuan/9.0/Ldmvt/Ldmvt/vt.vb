Imports Clsql
Imports ClsLookup

Public Class vt
    Private Sub vt_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        TabControl1.SelectedTab = tabthong_tin_chinh
        txtma_vt.Focus()
    End Sub
End Class