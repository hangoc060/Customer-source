Imports Clsql

Public Class dqddvt
    Private Sub frminput_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.txtma_dvt.Focus()
    End Sub
    Private Sub btnLuu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLuu.Click
        list_dvt.Save(sender, e)
    End Sub

    Private Sub btnhuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhuy.Click
        list_dvt.Cancel(sender, e)
    End Sub
    Private Sub dgd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim odvt As New ClsLookup.AutoCompleteLookup(conn, "dmdvt0", txtma_dvt, "ma_dvt", True)
        Dim odvtc As New ClsLookup.AutoCompleteLookup(conn, "dmdvt0", txtma_dvt_c, "ma_dvt", True)
        If Reg.GetValue("Language") = "Vi" Then
           
            odvt.SetValue("ten_dvt", ten_dvt)

        Else

            odvt.SetValue("ten_dvt2", ten_dvt)
        End If

    End Sub
End Class