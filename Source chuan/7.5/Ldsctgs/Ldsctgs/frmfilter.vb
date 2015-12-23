Public Class frmfilter

   
    Private Sub frmfilter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Txttu_ngay.Value = Clsql.Reg.GetValue("tu_ngay")
        Txtden_ngay.Value = Clsql.Reg.GetValue("den_ngay")
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        DialogResult = Windows.Forms.DialogResult.OK
        Clsql.Reg.SetValue("tu_ngay", Txttu_ngay.Value)
        Clsql.Reg.SetValue("den_ngay", Txtden_ngay.Value)
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class