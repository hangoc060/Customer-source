Public Class frmCreateFromDM
    Private Sub frmCreateFromDM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim nvu As New ClsLookup.AutoCompleteLookup(conn, "dmnvu", txtma_nvu, "ma_nvu")
        nvu.oKey = "dbo.einstr('PXK',ma_ct)=1"
        nvu.SetValue("ten_nvu", ten_nvu)
        Dim kho As New ClsLookup.AutoCompleteLookup(conn, "dmkho", txtma_kho, "ma_kho")
        kho.oKey = "ma_dvcs ='" & Clsql.Reg.GetValue("unit") & "'"
        kho.SetValue("ten_kho", ten_kho)

        Dim sp As New ClsLookup.AutoCompleteLookup(conn, "dmvt", txtma_sp, "ma_vt")
        sp.oKey = "loai_vt ='TP'"
        sp.SetValue("ten_sp", ten_sp)
        sp.SetValue("ma_dvt", txtma_dvt)



    End Sub

    Private Sub btntim_Click(sender As Object, e As EventArgs) Handles btntim.Click
        If txtma_sp.Text = "" Then
            txtma_sp.Focus()
            Return
        End If
        If txtma_dvt.Text = "" Then
            txtma_dvt.Focus()
            Return
        End If
        If txtma_nvu.Text = "" Then
            txtma_nvu.Focus()
            Return
        End If
        If txtma_kho.Text = "" Then
            txtma_kho.Focus()
            Return
        End If
        DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnhuy_Click(sender As Object, e As EventArgs) Handles btnhuy.Click
        Me.Close()
    End Sub
End Class