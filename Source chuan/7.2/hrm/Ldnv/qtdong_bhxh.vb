Public Class qtdong_bhxh
    Public _grd As System.Windows.Forms.DataGridView

    Private Sub qtdong_bhxh_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = list_qtdong_bhxh.oLable("000") + ": " + _grd.Item("ma_nv", _grd.CurrentRow.Index).Value + " - " + _grd.Item("ten_nv", _grd.CurrentRow.Index).Value
    End Sub

    Private Sub qtdong_bhxh_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.txttu_ngay.Focus()
    End Sub

End Class