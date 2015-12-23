Public Class frmfilterPrintBarcode

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        DialogResult = Windows.Forms.DialogResult.OK
        My.Settings.UBT = chbBarTender.Checked
        My.Settings.Save()
        Me.Close()
    End Sub


    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        DialogResult = Windows.Forms.DialogResult.Yes
        My.Settings.UBT = chbBarTender.Checked
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub frmfilterPrintBarcode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chbBarTender.Checked = My.Settings.UBT
    End Sub
End Class