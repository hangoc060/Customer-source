Public Class frmordertmp
    Public id_call_tmp, dia_chi, dien_thoai As String
    Public rowCust As DataRow
    Dim dt_sp As DataTable
    Dim dt_km As DataTable
    Dim ds As New DataSet
    Dim dt_master As DataTable
    Dim action As Integer '0:add,1:edit
    Public Sub add()

        dt_master = dt_px8tmp.Clone
        ds.Tables.Add(dt_master)
        '
        dt_sp = New DataTable
        dt_sp.Columns.Add("ma_vt", GetType(String))
        dt_sp.Columns.Add("ten_vt", GetType(String))
        dt_sp.Columns.Add("sl_xuat", GetType(Double))
        dt_sp.Columns.Add("gia_ban", GetType(Double))
        dt_sp.Columns.Add("tien", GetType(Double))

        dt_sp.Columns.Add("ty_le_ck", GetType(Double))
        dt_sp.Columns.Add("tien_ck", GetType(Double))

        dt_sp.Columns.Add("tien_tt", GetType(Double))

        dt_sp.Columns.Add("so_the_ts_xuat", GetType(String))
        dt_sp.Columns.Add("sl_vo_xuat", GetType(Double))



        '
        dt_km = New DataTable
        dt_km.Columns.Add("ma_vt", GetType(String))
        dt_km.Columns.Add("ten_vt", GetType(String))
        dt_km.Columns.Add("sl_xuat", GetType(Double))





        ClsControl2.PropertyOfGrid.FillGrid(conn, "px8tmp_sp", gridsp, dt_sp.DefaultView)
        ClsControl2.PropertyOfGrid.FillGrid(conn, "px8tmp_km", gridkm, dt_km.DefaultView)

        ds.Tables.Add(dt_sp)
        ds.Tables.Add(dt_km)
        action = 0
        Me.Show()
    End Sub
    Public Sub edit(stt_rec_tmp As String)
        Dim file As String = dirData & "\" & stt_rec_tmp & ".xml"
        ds.ReadXml(file)
        dt_master = ds.Tables(0)
        dt_sp = ds.Tables(1)
        dt_km = ds.Tables(2)
        ClsControl2.PropertyOfGrid.FillGrid(conn, "px8tmp_sp", gridsp, dt_sp.DefaultView)
        ClsControl2.PropertyOfGrid.FillGrid(conn, "px8tmp_km", gridkm, dt_km.DefaultView)
        action = 1
        Me.Show()
    End Sub
    Dim dt_sp_list As DataTable
    Dim dt_km_list As DataTable
    Private Sub frmordertmp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'nhom sanpham
        Dim dt_nhomsp As DataSet = ClsList.List1.load4local("dmnhvt")
        cbbnh_vt.DataSource = dt_nhomsp.Tables(0)
        cbbnh_vt.DisplayMember = "ten_nhom"
        cbbnh_vt.ValueMember = "ma_nhom"
        'If dt_nhomsp.Tables(0).Rows.Count > 0 Then
        '    cbbnh_vt.SelectedIndex = 0
        'End If
        cbbnh_vt.SelectedValue = "GAS"
        'danh sach sản pham
        Dim dt_vt As DataSet = ClsList.List1.load4local("dmvt")

        dt_sp_list = dt_vt.Tables(0).Clone
        Clsql.Data.CopyTableSame(dt_vt.Tables(0), dt_sp_list, "1=1")

        If cbbnh_vt.SelectedValue IsNot Nothing Then
            dt_sp_list.DefaultView.RowFilter = "nh_vt1='" & cbbnh_vt.SelectedValue & "'"
        End If

        gridsplist.DataSource = dt_sp_list
        gridsplist.BackgroundColor = Color.White
        gridsplist.ReadOnly = True
        gridsplist.AllowUserToAddRows = False
        gridsplist.AllowUserToDeleteRows = False
        gridsplist.RowHeadersVisible = False
        For Each c As DataGridViewColumn In gridsplist.Columns
            c.Visible = False
        Next
        gridsplist.Columns("ma_vt").HeaderText = "Mã sản phẩm"
        gridsplist.Columns("ma_vt").Visible = True
        gridsplist.Columns("ma_vt").Width = 50
        gridsplist.Columns("ten_vt").HeaderText = "Tên sản phẩm"
        gridsplist.Columns("ten_vt").Visible = True
        gridsplist.Columns("ten_vt").Width = 180
        'danh sach khuyen mai
        dt_km_list = dt_vt.Tables(0).Clone
        Clsql.Data.CopyTableSame(dt_vt.Tables(0), dt_km_list, "nh_vt1='KM'")
        gridkmlist.DataSource = dt_km_list
        gridkmlist.BackgroundColor = Color.White
        gridkmlist.ReadOnly = True
        gridkmlist.AllowUserToAddRows = False
        gridkmlist.AllowUserToDeleteRows = False
        gridkmlist.RowHeadersVisible = False
        For Each c As DataGridViewColumn In gridkmlist.Columns
            c.Visible = False
        Next
        gridkmlist.Columns("ma_vt").HeaderText = "Mã sản phẩm"
        gridkmlist.Columns("ma_vt").Visible = True
        gridkmlist.Columns("ma_vt").Width = 50
        gridkmlist.Columns("ten_vt").HeaderText = "Tên sản phẩm"
        gridkmlist.Columns("ten_vt").Visible = True
        gridkmlist.Columns("ten_vt").Width = 180

        '
        gridsp.AllowUserToAddRows = False
        gridsp.BackgroundColor = Color.White
        gridkm.AllowUserToAddRows = False
        gridkm.BackgroundColor = Color.White
    End Sub

    Private Sub gridsplist_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridsplist.CellDoubleClick
        If gridsplist.CurrentRow IsNot Nothing Then
            Dim r As DataRow = dt_sp.NewRow
            r("ma_vt") = gridsplist.CurrentRow.Cells("ma_vt").Value
            r("ten_vt") = gridsplist.CurrentRow.Cells("ten_vt").Value
            r("sl_xuat") = 1
            r("gia_ban") = 0
            'get gia ban
            If dmgiaban IsNot Nothing Then
                Dim rgia As DataRow() = dmgiaban.Select("ma_vt='" & r("ma_vt") & "'")
                If (rgia.Count > 0) Then
                    r("gia_ban") = rgia(0)("gia_ban_le")
                End If
            End If
            '
            r("tien") = r("gia_ban") * r("sl_xuat")
            r("ty_le_ck") = 0
            r("tien_ck") = Math.Round(r("tien") * r("ty_le_ck") / 100, 0)
            r("tien_tt") = r("tien") - r("tien_ck")
            r("sl_vo_xuat") = 0
            If (gridsplist.Columns.Contains("so_the_ts")) Then
                r("so_the_ts_xuat") = gridsplist.CurrentRow.Cells("so_the_ts").Value
                If (r("so_the_ts_xuat") <> "") Then
                    r("sl_vo_xuat") = 1
                End If
            End If


            dt_sp.Rows.Add(r)
        End If
    End Sub

    Private Sub gridkmlist_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridkmlist.CellDoubleClick
        If gridkmlist.CurrentRow IsNot Nothing Then
            Dim r As DataRow = dt_km.NewRow
            r("ma_vt") = gridkmlist.CurrentRow.Cells("ma_vt").Value
            r("ten_vt") = gridkmlist.CurrentRow.Cells("ten_vt").Value
            r("sl_xuat") = 1
            dt_km.Rows.Add(r)
        End If
    End Sub

    Private Sub gridsp_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles gridsp.CellValueChanged
        Try
            If gridsp.Columns(e.ColumnIndex).Name = "sl_xuat" OrElse gridsp.Columns(e.ColumnIndex).Name = "gia_ban" Then
                gridsp.Rows(e.RowIndex).Cells("tien").Value = gridsp.Rows(e.RowIndex).Cells("sl_xuat").Value * gridsp.Rows(e.RowIndex).Cells("gia_ban").Value
            End If

            If gridsp.Columns(e.ColumnIndex).Name = "ty_le_ck" OrElse gridsp.Columns(e.ColumnIndex).Name = "tien" Then
                gridsp.Rows(e.RowIndex).Cells("tien_ck").Value = gridsp.Rows(e.RowIndex).Cells("tien").Value * gridsp.Rows(e.RowIndex).Cells("ty_le_ck").Value / 100
            End If

            If gridsp.Columns(e.ColumnIndex).Name = "tien" OrElse gridsp.Columns(e.ColumnIndex).Name = "tien_ck" Then
                gridsp.Rows(e.RowIndex).Cells("tien_tt").Value = gridsp.Rows(e.RowIndex).Cells("tien").Value - gridsp.Rows(e.RowIndex).Cells("tien_ck").Value
            End If

            If gridsp.Columns(e.ColumnIndex).Name = "tien" Then
                lblt_tien.Text = Strings.Format(ClsControl2.PropertyOfGrid.Sum(gridsp, "tien"), "# ### ##0")
                lblt_ck.Text = Strings.Format(ClsControl2.PropertyOfGrid.Sum(gridsp, "tien_ck"), "# ### ##0")
                lblt_tt.Text = Strings.Format(ClsControl2.PropertyOfGrid.Sum(gridsp, "tien_tt"), "# ### ##0")
            End If

            If gridsp.Columns(e.ColumnIndex).Name = "tien_ck" Then
                lblt_ck.Text = Strings.Format(ClsControl2.PropertyOfGrid.Sum(gridsp, "tien_ck"), "# ### ##0")
                lblt_tt.Text = Strings.Format(ClsControl2.PropertyOfGrid.Sum(gridsp, "tien_tt"), "# ### ##0")
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cbbnh_vt_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbbnh_vt.SelectedValueChanged
        If cbbnh_vt.SelectedValue IsNot Nothing AndAlso dt_sp_list IsNot Nothing Then
            dt_sp_list.DefaultView.RowFilter = "nh_vt1='" & cbbnh_vt.SelectedValue & "'"
        End If
    End Sub

    Private Sub btnselectKH_Click(sender As Object, e As EventArgs) Handles btnselectKH.Click
        Dim f As New frmlistkh
        f.Icon = Me.FindForm.Icon
        If f.ShowDialog(Me) = DialogResult.OK Then
            For Each c As DataColumn In f.row_selected.Table.Columns
                If dtCust.Columns.Contains(c.ColumnName) Then
                    rowCust(c.ColumnName) = f.row_selected(c.ColumnName)
                End If
            Next
            txtma_kh.Text = f.row_selected("ma_kh")
            lblten_kh.Text = f.row_selected("ten_kh")
            dia_chi = f.row_selected("dia_chi")
            dien_thoai = f.row_selected("dien_thoai")

        End If
    End Sub
    Sub save()
        Dim row As DataRow
        Dim user As String = Clsql.Reg.GetValue("id")
        If action = 0 Then
            dt_master.Rows.Clear()
            row = dt_master.NewRow
            row("stt_rec_tmp") = user + Strings.Format(Now, "yyyyMMddHHmmss")
            row("ma_kh") = txtma_kh.Text
            row("ten_kh") = lblten_kh.Text
            row("dia_chi") = dia_chi
            row("dien_thoai") = dien_thoai
            row("so_ct") = "BL" & user.Substring(user.Length - 2) & Strings.Format(Now, "yyMMddHHmmss")
            row("ngay_ct") = Now
            row("nguoi_tao") = user
            row("ngay_tao") = Now
            row("id_call_tmp") = id_call_tmp
            row("t_tien") = ClsControl2.PropertyOfGrid.Sum(gridsp, "tien")
            row("t_ck") = ClsControl2.PropertyOfGrid.Sum(gridsp, "tien_ck")
            row("t_tt") = ClsControl2.PropertyOfGrid.Sum(gridsp, "tien_tt")

            dt_master.Rows.Add(row)
        Else
            row = dt_master.Rows(0)
            row("ma_kh") = txtma_kh.Text
            row("ten_kh") = lblten_kh.Text
            row("dia_chi") = dia_chi
            row("dien_thoai") = dien_thoai

            row("t_tien") = ClsControl2.PropertyOfGrid.Sum(gridsp, "tien")
            row("t_ck") = ClsControl2.PropertyOfGrid.Sum(gridsp, "tien_ck")
            row("t_tt") = ClsControl2.PropertyOfGrid.Sum(gridsp, "tien_tt")
        End If

        '
        ds.AcceptChanges()
        Dim fname As String = dirData
        If Not IO.Directory.Exists(fname) Then
            IO.Directory.CreateDirectory(fname)

        End If
        fname = fname & "\" & row("stt_rec_tmp") & ".xml"
        If IO.File.Exists(fname) Then
            IO.File.Delete(fname)
        End If
        ds.WriteXml(fname, XmlWriteMode.WriteSchema)
    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        Try
            save()
            Dim f As New frmformprint
            f.Icon = Me.Icon
            f.Dataset2print = ds
            f.StartPosition = FormStartPosition.CenterParent
            f.ShowDialog(Me)
            DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MsgBox("Không thể lưu data",, Clsql.AboutMe.Name)
        End Try
    End Sub

    Sub print()

    End Sub
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            save()
            MsgBox("Đã lưu thành công",, Clsql.AboutMe.Name)
            DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MsgBox("Không thể lưu data" & Chr(13) & ex.Message,, Clsql.AboutMe.Name)
        End Try
    End Sub

    Private Sub txtfilter_TextChanged(sender As Object, e As EventArgs) Handles txtfilter.TextChanged
        If txtfilter.Text = "" Then Return
        dt_sp_list.DefaultView.RowFilter = "ma_vt like '%" & txtfilter.Text & "%' or ten_vt like '%" & txtfilter.Text & "%'"
    End Sub

    Private Sub txtfilterkm_TextChanged(sender As Object, e As EventArgs) Handles txtfilterkm.TextChanged
        If txtfilterkm.Text = "" Then Return
        dt_km_list.DefaultView.RowFilter = "ma_vt like '%" & txtfilterkm.Text & "%' or ten_vt like '%" & txtfilterkm.Text & "%'"
    End Sub
End Class