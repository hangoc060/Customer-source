Public Class MainForm
    Dim rpt As ClsRpt.rpt
    Dim rptid As String = ""
    Dim frmdkloc As New frmfilter
    Dim query As String = ""

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rptid = Clsql.Others.GetArgu(1)
        rpt = New ClsRpt.rpt(rptid, Me.grd, btnIN, btnpreview, frmdkloc.cbbmau, frmdkloc.txttitle, frmdkloc.cbbma_dvcs, True)
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
        ngaycuatuan.Add(0, "CN")
        ngaycuatuan.Add(1, "T2")
        ngaycuatuan.Add(2, "T3")
        ngaycuatuan.Add(3, "T4")
        ngaycuatuan.Add(4, "T5")
        ngaycuatuan.Add(5, "T6")
        ngaycuatuan.Add(6, "T7")
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

            frmdkloc.txtnam.Value = Now.Year
        Catch ex As Exception
        End Try
    End Sub

    Sub GetQuery()
        query = "exec  " & rpt.cPrint.Store & " "
        query = query & " " & rpt.conn.ConvertToSQLType(frmdkloc.txtnam.Value)
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

    Dim old_value As String = ""
    Private Sub grd_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd.CellEnter
        If IsDBNull(grd.Item(e.ColumnIndex, e.RowIndex).Value) Then
            old_value = ""
            Return
        End If
        old_value = grd.Item(e.ColumnIndex, e.RowIndex).Value
    End Sub

    Private Sub grd_CellValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd.CellValidated
        Dim col_name As String = grd.Columns(e.ColumnIndex).Name
        If Not (col_name = "tong_phep_nam" Or col_name = "dieu_chinh_phep") Then
            Return
        End If
        If IsDBNull(grd.CurrentRow.Cells("ma_nv").Value) Or grd.CurrentRow.Cells("ma_nv").Value.ToString.Trim.ToLower = "zzz" Then
            Return
        End If
        If (old_value <> grd.Item(e.ColumnIndex, e.RowIndex).Value) Then


            Dim query As String = "delete from phepnam where nam =" & frmdkloc.txtnam.Value & " and ma_nv ='" & grd.CurrentRow.Cells("ma_nv").Value & "'"
            query = query & Chr(13) & "insert into phepnam (nam,ma_nv,tong_phep_nam,dieu_chinh_phep) values ("
            query = query & rpt.conn.ConvertToSQLType(frmdkloc.txtnam.Value) & ","
            query = query & rpt.conn.ConvertToSQLType(grd.CurrentRow.Cells("ma_nv").Value) & ","
            query = query & rpt.conn.ConvertToSQLType(grd.CurrentRow.Cells("tong_phep_nam").Value) & ","
            query = query & rpt.conn.ConvertToSQLType(grd.CurrentRow.Cells("dieu_chinh_phep").Value) & ")"
            rpt.conn.Execute(query)
            grd.CurrentRow.Cells("con_lai").Value = grd.CurrentRow.Cells("tong_phep_nam").Value + grd.CurrentRow.Cells("dieu_chinh_phep").Value - grd.CurrentRow.Cells("da_nghi_phep").Value


        End If
    End Sub
  

End Class
