Public Class frmfilter

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
       

        My.Settings.ma_thue = txtma_thue.Text
        Try
            My.Settings.tu_ngay = Txttu_ngay.Value
            My.Settings.den_ngay = TxtDen_ngay.Value
        Catch ex As Exception

        End Try
       
       
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub frmfilter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
    End Sub
End Class