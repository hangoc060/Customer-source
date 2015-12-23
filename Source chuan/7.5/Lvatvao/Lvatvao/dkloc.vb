Public Class dkloc

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Clsql.Reg.SetValue("tu_ngay", Txttu_ngay.Value)
        Clsql.Reg.SetValue("den_ngay", Txtden_ngay.Value)
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

   
   
    Private Sub dkloc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Txttu_ngay.Value = Clsql.Reg.GetValue("tu_ngay")
        Txtden_ngay.Text = Clsql.Reg.GetValue("den_ngay")
    End Sub
End Class