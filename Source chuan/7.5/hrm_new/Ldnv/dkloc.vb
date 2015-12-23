Imports Clsql
Imports ClsControl2

Public Class dkloc

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub dkloc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'dk loc
        Dim odmloainv As New ClsLookup.AutoCompleteLookup(conn, "dmloainv", txtma_loai_nv, "ma_loai_nv", False)
        Dim odmbp As New ClsLookup.AutoCompleteLookup(conn, "dmbp", txtma_bp, "ma_bp", False)
        If Reg.GetValue("Language") = "Vi" Then
            
            odmbp.SetValue("ten_bp", ten_bp)
            odmloainv.SetValue("ten_loai_nv", ten_loai_nv)
        Else
            
            odmbp.SetValue("ten_bp2", ten_bp)
            odmloainv.SetValue("ten_loai_nv2", ten_loai_nv)
        End If
        PropertyOfForm.SetLable(list.oLable, Me)
        PropertyOfForm.KeyEnter(Me)

    End Sub
End Class