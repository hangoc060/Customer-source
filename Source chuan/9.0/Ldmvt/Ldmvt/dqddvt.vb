Imports Clsql

Public Class dqddvt
    Private Sub frminput_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.txtma_dvt.Focus()
    End Sub
    Private Sub btnLuu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLuu.Click
        If txtma_vt_p.Text <> "" Then
            Dim query_check As String = "select ma_vt_p from vdmdvt where ma_vt_p =" & conn.ConvertToSQLType(txtma_vt_p.Text)
            Dim dt As DataTable = conn.GetDatatable(query_check)
            If dt.Rows.Count > 0 Then
                If list_dvt.Action = Actions.Action.Add Then
                    MsgBox("Mã vật tư này đã tồn tại, bạn hãy chọn một mã khác",, Clsql.AboutMe.Name)
                    Return
                Else
                    If list_dvt.CollectionFieldKey("ma_vt_p") = "" OrElse list_dvt.CollectionFieldKey("ma_vt_p") <> txtma_vt_p.Text Then
                        MsgBox("Mã vật tư này đã tồn tại, bạn hãy chọn một mã khác",, Clsql.AboutMe.Name)
                        Return
                    End If
                End If

            End If
        End If
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