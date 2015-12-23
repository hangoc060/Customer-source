Public Class dieuchuyen
    Public _grd As System.Windows.Forms.DataGridView

    Private Sub dieuchuyen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = list_dcns.oLable("000") + ": " + _grd.Item("ma_nv", _grd.CurrentRow.Index).Value + " - " + _grd.Item("ten_nv", _grd.CurrentRow.Index).Value
    End Sub

    Private Sub dieuchuyen_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        txtso_quyet_dinh.Focus()
    End Sub
End Class