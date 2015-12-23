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
        PropertyOfForm.SetLable(list.oLable, Me)
        ' Lookup()
        Dim otkvt As New ClsLookup.AutoCompleteLookup(conn, "dmtk", txttk_vt, "tk", False, False)
        Dim otkgv As New ClsLookup.AutoCompleteLookup(conn, "dmtk", txttk_gv, "tk", False, False)
        Dim otkdt As New ClsLookup.AutoCompleteLookup(conn, "dmtk", txttk_dt, "tk", False, False)
        Dim otkck As New ClsLookup.AutoCompleteLookup(conn, "dmtk", txttk_ck, "tk", False, False)
        Dim otkspdd As New ClsLookup.AutoCompleteLookup(conn, "dmtk", txttk_spdd, "tk", False, False)
        Dim odvt As New ClsLookup.AutoCompleteLookup(conn, "dmdvt0", txtma_dvt, "ma_dvt", False, False)

        Dim oloaivt As New ClsLookup.AutoCompleteLookup(conn, "dmloaivt", txtloai_vt, "ma_loai_vt", False, False)


        Dim onhomvt1 As New ClsLookup.AutoCompleteLookup(conn, "dmnhomvt", txtnh_vt1, "ma_nhom", False, False)
        onhomvt1.oKey = "loai_nhom = 1"

        Dim onhomvt2 As New ClsLookup.AutoCompleteLookup(conn, "dmnhomvt", txtnh_vt2, "ma_nhom", False, False)
        onhomvt2.oKey = "loai_nhom = 2"

        Dim onhomvt3 As New ClsLookup.AutoCompleteLookup(conn, "dmnhomvt", txtnh_vt3, "ma_nhom", False, False)
        onhomvt3.oKey = "loai_nhom = 3"

        If Reg.GetValue("Language") = "Vi" Then
            otkvt.SetValue("ten_tk", ten_tk_vt)
            otkgv.SetValue("ten_tk", ten_tk_gv)
            otkdt.SetValue("ten_tk", ten_tk_dt)
            otkck.SetValue("ten_tk", ten_tk_ck)
            otkspdd.SetValue("ten_tk", ten_tk_spdd)
            odvt.SetValue("ten_dvt", ten_dvt)

            onhomvt1.SetValue("ten_nhom", ten_nh_vt1)
            onhomvt2.SetValue("ten_nhom", ten_nh_vt2)
            onhomvt3.SetValue("ten_nhom", ten_nh_vt3)

            oloaivt.SetValue("ten_loai_vt", ten_loai_vt)
        Else
            otkvt.SetValue("ten_tk2", ten_tk_vt)
            otkgv.SetValue("ten_tk2", ten_tk_gv)
            otkdt.SetValue("ten_tk2", ten_tk_dt)
            otkck.SetValue("ten_tk2", ten_tk_ck)
            otkspdd.SetValue("ten_tk2", ten_tk_spdd)
            odvt.SetValue("ten_dvt2", ten_dvt)

            onhomvt1.SetValue("ten_nhom2", ten_nh_vt1)
            onhomvt2.SetValue("ten_nhom2", ten_nh_vt2)
            onhomvt3.SetValue("ten_nhom2", ten_nh_vt3)

            oloaivt.SetValue("ten_loai_vt2", ten_loai_vt)
        End If
    End Sub
End Class