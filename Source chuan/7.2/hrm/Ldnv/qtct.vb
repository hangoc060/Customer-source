Public Class qtct
    Public _grd As System.Windows.Forms.DataGridView

    Private Sub qtct_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = list_qtct.oLable("000") + ": " + _grd.Item("ma_nv", _grd.CurrentRow.Index).Value + " - " + _grd.Item("ten_nv", _grd.CurrentRow.Index).Value
    End Sub

    Private Sub qtct_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.txtten_cty.Focus()
    End Sub
    
End Class