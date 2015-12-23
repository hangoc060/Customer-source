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
        Dim otinhdk As New ClsLookup.AutoCompleteLookup(conn, "dmtt", txtma_tinh_thanh, "ma_tinh_thanh", False)
        otinhdk.SetValue("ten_tinh_thanh", lblten_tinh_thanh)

        Dim ohuyendk As New ClsLookup.AutoCompleteLookup(conn, "dmqh", txtma_quan_huyen, "ma_quan_huyen", False)
        ohuyendk.SetValue("ten_quan_huyen", lblten_quan_huyen)

        '  Dim odxl As New ClsLookup.AutoCompleteLookup(conn, "dmtd", txtma_td, "ma_td", True)
        '  Dim odldcncc As New ClsLookup.AutoCompleteLookup(conn, "dmldcncc", txtly_do_c_ncc, "ly_do_c_ncc", False)
        '  Dim oddtct As New ClsLookup.AutoCompleteLookup(conn, "dmdtct", txtma_dt_ct, "ma_dt_ct", False)
        Dim odlkh As New ClsLookup.AutoCompleteLookup(conn, "dmlkh", txtma_loai_kh, "ma_loai_kh", False)
        Dim odqg As New ClsLookup.AutoCompleteLookup(conn, "dmqg", txtma_qg, "ma_qg", False)
        If Reg.GetValue("Language") = "Vi" Then
            ' odxl.SetValue("ten", lblten_td)
            ' odldcncc.SetValue("ten", lblten_ly_do_c_ncc)
            ' oddtct.SetValue("ten", lblten_dt_ct)
            odlkh.SetValue("ten", lblten_loai_kh)
            odqg.SetValue("ten", lblten_qg)
        Else
            ' odxl.SetValue("ten2", lblten_td)
            ' odldcncc.SetValue("ten2", lblten_ly_do_c_ncc)
            ' oddtct.SetValue("ten2", lblten_dt_ct)
            odlkh.SetValue("ten2", lblten_loai_kh)
            odqg.SetValue("ten2", lblten_qg)
        End If
        PropertyOfForm.SetLable(list.oLable, Me)
        PropertyOfForm.KeyEnter(Me)


        If Clsql.Reg.GetValue("Language") = "Vi" Then
            ClsLookup.AddItems.AddItemCbbGotBlank(conn, "select ma_ddlv,ten from dddlv where trang_thai =1", cbbma_ddlv, "ten", "ma_ddlv")
            ClsLookup.AddItems.AddItemCbbGotBlank(conn, "select ma_lcv,ten from dlcv where trang_thai =1", cbbma_lcv, "ten", "ma_lcv")
            ClsLookup.AddItems.AddItemCbbGotBlank(conn, "select trang_thai_xl,ten from dxl where trang_thai =1", cbbma_tien_do, "ten", "trang_thai_xl")
        Else
            ClsLookup.AddItems.AddItemCbbGotBlank(conn, "select ma_ddlv,ten2 from dddlv where trang_thai =1", cbbma_ddlv, "ten2", "ma_ddlv")
            ClsLookup.AddItems.AddItemCbbGotBlank(conn, "select ma_lcv,ten2 from dlcv where trang_thai =1", cbbma_lcv, "ten2", "ma_lcv")
            ClsLookup.AddItems.AddItemCbbGotBlank(conn, "select trang_thai_xl,ten2 from dxl where trang_thai =1", cbbma_tien_do, "ten2", "trang_thai_xl")
        End If
        Dim oNV As New ClsLookup.AutoCompleteLookup(conn, "dmnsd", Txtma_nv, "id", False)
        oNV.SetValue("idname", ten_nv)
    End Sub
End Class