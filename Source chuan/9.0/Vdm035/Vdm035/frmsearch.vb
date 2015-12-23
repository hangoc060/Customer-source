Imports ClsControl2

Public Class frmsearch

    Private Sub btntim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntim.Click
        DialogResult = Windows.Forms.DialogResult.OK

        Me.Close()
    End Sub

    Private Sub btnhuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhuy.Click
        Me.Close()
    End Sub


    Private Sub frmsearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'dien gia tri mac dinh cho form tim kiem
        Dim osp As New ClsLookup.AutoCompleteLookup(Voucher.conn, "dmsp", txtma_sp, "ma_vt", False, False)

         Dim omavt As New ClsLookup.AutoCompleteLookup(Voucher.conn, "dmvt", txtma_vt, "ma_vt", False, False)

        Dim obpSearch As New ClsLookup.AutoCompleteLookup(Voucher.conn, "dmbp", txtma_bp, "ma_bp", False, False)
      


        If Clsql.Reg.GetValue("Language") = "Vi" Then
            osp.SetValue("ten_vt", ten_sp)


            omavt.SetValue("ten_vt", ten_vt)


            obpSearch.SetValue("ten_bp", ten_bp)
        Else
            osp.SetValue("ten_vt2", ten_sp)

            omavt.SetValue("ten_vt2", ten_vt)
            obpSearch.SetValue("ten_bp2", ten_bp)
        End If



        PropertyOfForm.KeyEnter(Me)
        StartPosition = FormStartPosition.CenterParent

        ClsControl2.PropertyOfForm.SetLable(Voucher.oLan, Me)

    End Sub
End Class