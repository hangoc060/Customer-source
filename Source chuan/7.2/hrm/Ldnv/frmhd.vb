Public Class frmhd
    Public _list_hd As ClsList.List1
    Public _grd As System.Windows.Forms.DataGridView

    Private Sub frmhd_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = list_hd.oLable("000") + ": " + _grd.Item("ma_nv", _grd.CurrentRow.Index).Value + " - " + _grd.Item("ten_nv", _grd.CurrentRow.Index).Value
        If _list_hd.Action = Clsql.Actions.Action.Add Then
            txtma_bp_hd.Text = _grd.Item("ma_bp", _grd.CurrentRow.Index).Value
            txtma_cv_hd.Text = _grd.Item("ma_cv", _grd.CurrentRow.Index).Value
        End If
    End Sub

    Private Sub frmhd_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        txtso_hop_dong.Focus()
    End Sub
End Class