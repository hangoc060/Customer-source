Public Class frmfilter

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click


        If Txttu_ngay.Text.Replace(" ", "").Replace(Txttu_ngay.pc, "") <> "" Then
            Clsql.Reg.SetValue("tu_ngay", Txttu_ngay.Value)
        Else
            Txttu_ngay.Value = DateSerial(1901, 1, 1)
        End If
        If TxtDen_ngay.Text.Replace(" ", "").Replace(TxtDen_ngay.pc, "") <> "" Then
            Clsql.Reg.SetValue("den_ngay", TxtDen_ngay.Value)
        Else
            TxtDen_ngay.Value = DateSerial(2099, 12, 31)
        End If


        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub frmfilter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
    End Sub
End Class