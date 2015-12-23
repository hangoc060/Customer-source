Public Class MainForm
    Dim rpt As ClsRpt.rpt
    Dim rptid As String = ""
    Dim frmdkloc As New frmfilter
    Dim query As String = ""
    Dim muc_bhxh As Double = 10.5
    Dim muc_cong_doan As Double = 1
    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rptid = Clsql.Others.GetArgu(1)
        rpt = New ClsRpt.rpt(rptid, Me.grd, btnIN, btnpreview, frmdkloc.cbbmau, frmdkloc.txttitle, frmdkloc.cbbma_dvcs)
        AddHandler rpt.AfterGetData, AddressOf rpt_AfterGetData
        Dim oLable As Collection = ClsControl2.PropertyOfForm.SetLable(rpt.conn, Me, rptid)
        ClsControl2.PropertyOfForm.SetLable(oLable, frmdkloc)
        setupdkloc()
        frmdkloc.Icon = Me.Icon
        'load du lieu
        If Clsql.Others.GetArgu(2) <> "" Then
            query = Clsql.Others.GetArgu(2)
        Else
            If frmdkloc.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                GetQuery()
            Else
                Me.Close()
                Return
            End If
        End If
        rpt.Query = query
        lbluser.Text = Clsql.Reg.GetValue("ID")
        lblunit.Text = frmdkloc.cbbma_dvcs.Text
        'ClsControl2.PropertyOfForm.SetImage4Control("user.bmp", lbluser)
        ClsControl2.PropertyOfForm.SetImage4Control("find.bmp", btndkloc)
        ClsControl2.PropertyOfForm.SetImage4Control("refresh.bmp", btnrefresh2)
        printer.Text = rpt.cPrint.GetPrinter
        'ClsControl2.PropertyOfForm.SetImage4Control("printer.bmp", lbluser)
        AddHandler rpt.cPrint.BeforeShowReport, AddressOf SetParas
        ClsControl2.PropertyOfGrid.Lookups(rpt.conn, grd, "chamcong", "chamcong")
        ngaycuatuan.Add(0, "CN")
        ngaycuatuan.Add(1, "T2")
        ngaycuatuan.Add(2, "T3")
        ngaycuatuan.Add(3, "T4")
        ngaycuatuan.Add(4, "T5")
        ngaycuatuan.Add(5, "T6")
        ngaycuatuan.Add(6, "T7")
        Dim dtcackhoangiamtru As DataTable = rpt.conn.GetDatatable("select top 1 * from hdmucdongbh order by ngay_hl desc")
        If dtcackhoangiamtru.Rows.Count = 1 Then
            muc_bhxh = dtcackhoangiamtru.Rows(0)("nv_bhxh") + dtcackhoangiamtru.Rows(0)("nv_bhyt") + dtcackhoangiamtru.Rows(0)("nv_bhtn")
            muc_cong_doan = dtcackhoangiamtru.Rows(0)("nv_cd")
        End If
    End Sub
    Dim ngaycuatuan As New Dictionary(Of Integer, String)
    Private Sub ThoatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ThoatToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub btndkloc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndkloc.Click
        If frmdkloc.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            GetQuery()

            rpt.Query = query


            lblunit.Text = frmdkloc.cbbma_dvcs.Text
        End If
    End Sub
    

#Region "form dkloc"
    Sub setupdkloc()
        Try
            frmdkloc.txtthang.Value = Now.Month
            frmdkloc.txtnam.Value = Now.Year
        Catch ex As Exception
        End Try
    End Sub

    Sub GetQuery()
        query = "exec  " & rpt.cPrint.Store & " "
        query = query & rpt.conn.ConvertToSQLType(frmdkloc.txtthang.Value)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtnam.Value)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtma_nv.Text)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtma_bp.Text)
    End Sub

#End Region

    Private Sub btnrefresh(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh2.Click
        rpt.Query = query
    End Sub

    Private Sub btnpreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpreview.Click, btnIN.Click
        If sender.name = btnpreview.Name Then
            rpt.cPrint.Show()
        Else
            rpt.cPrint.Print()
        End If
    End Sub
    Sub SetParas()
        For Each c As DataGridViewColumn In grd.Columns
            If c.Visible = True Then
                rpt.cPrint.SetParameterValue(c.Name, c.HeaderText)
            End If
        Next
    End Sub

    Dim old_value As Object
    Private Sub grd_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd.CellEnter
        old_value = grd.Item(e.ColumnIndex, e.RowIndex).Value
    End Sub

    Private Sub grd_CellValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd.CellValidated
        Dim c As String = grd.Columns(e.ColumnIndex).Name
        If c = "cong_quy_dinh" Or c = "luong_khoan_viec" Or c = "phu_cap" Or c = "tien_thuong" Or c = "tam_ung" Or c = "tru_khac" Or c = "ttncn" Or c = "giu_ho" Then
            If IsDBNull(grd.Item(e.ColumnIndex, e.RowIndex).Value) Then
                grd.Item(e.ColumnIndex, e.RowIndex).Value = 0
            End If
            If old_value <> grd.Item(e.ColumnIndex, e.RowIndex).Value Then
                grd.Rows(e.RowIndex).Cells("luong_thang").Value = Math.Round((grd.Rows(e.RowIndex).Cells("luong_co_ban").Value / IIf(grd.Rows(e.RowIndex).Cells("cong_quy_dinh").Value <> 0, grd.Rows(e.RowIndex).Cells("cong_quy_dinh").Value, 1)) * grd.Rows(e.RowIndex).Cells("ngay_cong").Value, 0)

                grd.Rows(e.RowIndex).Cells("tong_cong").Value = grd.Rows(e.RowIndex).Cells("luong_thang").Value + grd.Rows(e.RowIndex).Cells("luong_san_pham").Value + grd.Rows(e.RowIndex).Cells("luong_khoan_viec").Value + grd.Rows(e.RowIndex).Cells("phu_cap").Value + grd.Rows(e.RowIndex).Cells("tien_thuong").Value
                grd.Rows(e.RowIndex).Cells("bhxh").Value = Math.Round(grd.Rows(e.RowIndex).Cells("luong_bhxh").Value * muc_bhxh / 100, 0)
                grd.Rows(e.RowIndex).Cells("cong_doan").Value = Math.Round(grd.Rows(e.RowIndex).Cells("tong_cong").Value * muc_cong_doan / 100, 0)
                grd.Rows(e.RowIndex).Cells("tong_khau_tru").Value = grd.Rows(e.RowIndex).Cells("bhxh").Value + grd.Rows(e.RowIndex).Cells("cong_doan").Value + grd.Rows(e.RowIndex).Cells("ttncn").Value
                grd.Rows(e.RowIndex).Cells("con_lai").Value = grd.Rows(e.RowIndex).Cells("tong_cong").Value - grd.Rows(e.RowIndex).Cells("tam_ung").Value - grd.Rows(e.RowIndex).Cells("tru_khac").Value - grd.Rows(e.RowIndex).Cells("tong_khau_tru").Value - grd.Rows(e.RowIndex).Cells("giu_ho").Value
                grd.EndEdit()

                Dim query As String = "delete from bangtinhluong where thang =" & frmdkloc.txtthang.Value & " and nam =" & frmdkloc.txtnam.Value
                query = query & " and ma_nv ='" & grd.Item("ma_nv", e.RowIndex).Value & "'"
                query = query & Chr(13) & rpt.conn.GetInsertQueryFromDataRow(grd.CurrentRow.DataBoundItem.row, "bangtinhluong")
                rpt.conn.Execute(query)
            End If

        End If
        
    End Sub
    Private Sub rpt_AfterGetData(ByVal dataset As System.Data.DataSet)
        grd.Columns("ten_nv").Frozen = True
        Clsql.Data.ClearNullValue(dataset.Tables(0))
        dataset.AcceptChanges()
        'format column
        Dim query As String = "delete from bangtinhluong where thang=" & frmdkloc.txtthang.Value & " and nam=" & frmdkloc.txtnam.Value
        If frmdkloc.txtma_bp.Text <> "" Then
            query = query & " and ma_bp='" & frmdkloc.txtma_bp.Text & "'"
        End If
        If frmdkloc.txtma_nv.Text <> "" Then
            query = query & " and ma_nv='" & frmdkloc.txtma_nv.Text & "'"
        End If
        query = query & Chr(13) & rpt.conn.GetInsertQueryFromDatatable(dataset.Tables(0), "bangtinhluong")
        rpt.conn.Execute(query)
    End Sub

End Class
