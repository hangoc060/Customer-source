Public Class frmFindHD2

    Private Sub btntim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntim.Click
        If txtma_nvu.Text = "" Then
            MsgBox("Nghiệp vụ không được trống", MsgBoxStyle.Critical, Me.Text)
            txtma_nvu.Focus()
            Return
        End If
        If txtma_kho.Text = "" Then
            MsgBox("Kho không được trống", MsgBoxStyle.Critical, Me.Text)
            txtma_kho.Focus()
            Return
        End If
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnhuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhuy.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class