Public Class dmhsnv
    Public _grd As System.Windows.Forms.DataGridView

    Private Sub dmhsnv_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = list_dmhs.oLable("000") + ": " + _grd.Item("ma_nv", _grd.CurrentRow.Index).Value + " - " + _grd.Item("ten_nv", _grd.CurrentRow.Index).Value
    End Sub

    
    Private Sub dmhsnv_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        txtten_hs.Focus()
    End Sub
End Class