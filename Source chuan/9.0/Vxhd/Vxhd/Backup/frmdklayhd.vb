Public Class frmdklayhd

    Private Sub btntim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntim.Click

        If Txttu_ngay.Text.Replace(" ", "") <> "//" Then
            Clsql.Reg.SetValue("tu_ngay", Txttu_ngay.Value)
        Else
            Txttu_ngay.Value = DateSerial(1901, 1, 1)
        End If
        If TxtDen_ngay.Text.Replace(" ", "") <> "//" Then
            Clsql.Reg.SetValue("den_ngay", TxtDen_ngay.Value)
        Else
            TxtDen_ngay.Value = DateSerial(2099, 12, 31)
        End If

        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnhuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhuy.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmdklayhd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Txttu_ngay.Value = Clsql.Reg.GetValue("tu_ngay")
        TxtDen_ngay.Value = Clsql.Reg.GetValue("den_ngay")
        Dim lupma_thue As New ClsLookup.AutoCompleteLookup(conn, "dmvat", txtma_thue, "ma_thue", False, True)
        lupma_thue.SetValue("ten_thue", ten_thue)

        Dim luptk_vt As New ClsLookup.AutoCompleteLookup(conn, "dmtk", txttk_vt, "tk", False, True)
        luptk_vt.SetValue("ten_tk", ten_tk)
    End Sub
End Class