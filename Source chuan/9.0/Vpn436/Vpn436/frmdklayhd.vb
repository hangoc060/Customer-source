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
        Dim mkho As New ClsLookup.AutoCompleteLookup(conn, "dmkho", txtma_kho, "ma_kho", False)
        mkho.oKey = "ma_dvcs ='" & Clsql.Reg.GetValue("unit") & "'"
        mkho.SetValue("ten_kho", ten_kho)

        Dim nvu As New ClsLookup.AutoCompleteLookup(conn, "dmnvu", txtma_nvu, "ma_nvu", False)
        nvu.oKey = "dbo.einstr('PN4',ma_ct)=1"
        nvu.SetValue("ten_nvu", ten_nvu)
    End Sub
End Class