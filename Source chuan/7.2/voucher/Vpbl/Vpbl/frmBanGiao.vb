Public Class frmBanGiao

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        soca("ban_giao") = True
        soca("tong_tien_ban_giao") = txttong_tien_ban_giao.Value
        soca("ghi_chu") = txtghi_chu.Text

        conn.Execute("delete from soca where " & query_where_soca & " and tu_gio ='" & soca("tu_gio") & "'")
        conn.WriteToServer(soca.Table, "soca")
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmBanGiao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txttong_tien_ban_giao.Focus()
        txtnhan_vien.Text = conn.GetValue("select idname from dmnsd where id='" & soca("nhan_vien") & "'")
        txtma_may.Text = conn.GetValue("select ten_may from dmmaybanle where ma_may = '" & soca("ma_may") & "'")
        txtma_ca.Text = conn.GetValue("select ten from dmca where ma = '" & soca("ma_ca") & "'")
        txttu_gio.Text = soca("tu_gio")
        soca("den_gio") = Strings.Format(Now, "hh:mm:ss")
        txtden_gio.Text = soca("den_gio")
        'txtso_ct_tu.Text = soca("so_ct_tu")
        'txtso_ct_den.Text = soca("so_ct_den")
        Dim query As String = "select sum(t_phai_thu) from mpbl where nguoi_tao ={0} and ma_ca ={1} and ma_may ={2} and ngay_ct ={3} and gio_ca ={4}"
        query = String.Format(query, conn.ConvertToSQLType(Clsql.Reg.GetValue("id")), conn.ConvertToSQLType(so_ca), conn.ConvertToSQLType(ma_may_ban_le), conn.ConvertToSQLType(Now), conn.ConvertToSQLType(soca("tu_gio")))
        soca("tong_tien") = conn.GetValue(query)
        txttong_tien.Value = soca("tong_tien")
        txttong_tien_ban_giao.Value = txttong_tien.Value
    End Sub
End Class