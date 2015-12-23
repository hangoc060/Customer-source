Public Class frmDcgia

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmDcgia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbbloai_gia.SelectedIndex = 0
    End Sub
End Class