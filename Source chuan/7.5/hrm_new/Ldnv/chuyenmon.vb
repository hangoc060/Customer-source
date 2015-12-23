Public Class chuyenmon
    Public _grd As System.Windows.Forms.DataGridView

    Private Sub chuyenmon_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = list_tdcm.oLable("000") + ": " + _grd.Item("ma_nv", _grd.CurrentRow.Index).Value + " - " + _grd.Item("ten_nv", _grd.CurrentRow.Index).Value
    End Sub

    Private Sub chuyenmon_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        txtma_hoc_van.Focus()
    End Sub
End Class