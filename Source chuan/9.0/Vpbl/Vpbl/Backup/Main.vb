Module Main
    Public conn As New Clsql.SQL
    Public olan As Collection
    Public fchonca As New frmChonCa
    Public checkright As ClsRight.CheckRight
    Public ma_ct As String = "PBL"
    Public ma_may_ban_le As String = "01"
    Public so_ca As String = "01"
    Public ma_kho As String = ""
    Public soca As DataRow
    Public query_where_soca As String
    Public Sub main()
        If Clsql.Reg.GetValue("SLG") = 0 Then
            Application.Exit()
            Return
        End If
        'check right
        Dim ma_cn As String = conn.GetValue("select id from " & Clsql.Others.Options("cmd_table", conn) & " where ma_cn ='" & ma_ct & "_D'")
        If ma_cn Is Nothing Or ma_cn Is DBNull.Value Then
            Application.Exit()
            Return
        End If
        checkright = New ClsRight.CheckRight(conn, ma_cn)
        If Not checkright.ViewRight Then
            Application.Exit()
            Return
        End If
        '
        olan = ClsControl2.PropertyOfForm.SetLable(conn, fchonca, ma_ct)

        ClsLookup.AddItems.AddItemCbb(conn, "select ma_kho,ten_kho from dmkho where ma_dvcs ='" & Clsql.Reg.GetValue("unit") & "'", fchonca.cbbma_kho, "ten_kho", "ma_kho")

        ClsLookup.AddItems.AddItemCbb(conn, "select ma,ten from dmca", fchonca.cbbso_ca, "ten", "ma")
        fchonca.StartPosition = FormStartPosition.CenterScreen
        If fchonca.ShowDialog = Windows.Forms.DialogResult.OK Then
            ma_may_ban_le = fchonca.cbbso_may.SelectedValue
            so_ca = fchonca.cbbso_ca.SelectedValue
            ma_kho = fchonca.cbbma_kho.SelectedValue
        Else

            Application.Exit()
            Return
        End If
        '
        query_where_soca = "nhan_vien = {0} and ma_kho ={1} and ma_ca ={2} and ma_may = {3} and ngay = {4}" '' and ban_giao = 0"
        query_where_soca = String.Format(query_where_soca, conn.ConvertToSQLType(Clsql.Reg.GetValue("id")), conn.ConvertToSQLType(ma_kho), conn.ConvertToSQLType(so_ca), conn.ConvertToSQLType(ma_may_ban_le), conn.ConvertToSQLType(Now))

        Dim query As String = "select top 1 * from soca where " & query_where_soca
       
        Dim dtsoca As DataTable = conn.GetDatatable(query)
        If dtsoca.Rows.Count = 1 Then
            soca = dtsoca.Rows(0)
        Else
            soca = dtsoca.NewRow
            soca("nhan_vien") = Clsql.Reg.GetValue("id")
            soca("ma_kho") = ma_kho
            soca("ma_ca") = so_ca
            soca("ma_may") = ma_may_ban_le
            soca("ngay") = Now
            soca("tu_gio") = Strings.Format(Now, "hh:mm:ss")
            soca("den_gio") = ""
            soca("so_ct_tu") = ""
            soca("so_ct_den") = ""
            soca("ban_giao") = 0
            dtsoca.Rows.Add(soca)
            conn.WriteToServer(dtsoca, "soca")
        End If
        Dim fmain As New frmMain
        fmain.setup()
        fmain.ShowDialog()

    End Sub
End Module
