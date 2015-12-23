Public Class frmcapnhatlo
    Public ma_vt As String = ""
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If txtma_lo.Text.Trim = "" Then
            txtma_lo.Focus()
            Return
        End If
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmBanGiao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClsControl2.PropertyOfForm.KeyEnter(Me)
        txtma_lo.Focus()
        Dim lo As New ClsLookup.AutoCompleteLookup(New Clsql.SQL(), "dmlo_all", txtma_lo, "ma_lo", True, True)
        lo.SetValue("ten_lo", ten_lo)
        lo.oKey = "ma_vt ='" & ma_vt & "'"
    End Sub
End Class