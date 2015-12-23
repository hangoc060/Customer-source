Public Class frmdklayhd

    Private Sub btntim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntim.Click
        If txtma_nvu.Text = "" Then
            txtma_nvu.Focus()
            Return
        End If
        If txtma_kho.Text = "" Then
            txtma_kho.Focus()
            Return
        End If

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
        Dim nvu As New ClsLookup.AutoCompleteLookup(conn, "dmnvu", txtma_nvu, "ma_nvu")
        nvu.oKey = "dbo.einstr('PXK',ma_ct)=1"
        nvu.SetValue("ten_nvu", ten_nvu)
        Dim kho As New ClsLookup.AutoCompleteLookup(conn, "dmkho", txtma_kho, "ma_kho")
        kho.oKey = "ma_dvcs ='" & Clsql.Reg.GetValue("unit") & "'"
        kho.SetValue("ten_kho", ten_kho)
    End Sub
End Class