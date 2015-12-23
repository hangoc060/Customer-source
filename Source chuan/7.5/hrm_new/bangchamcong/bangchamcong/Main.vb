Public Class MainForm
    Dim rpt As ClsRpt.rpt
    Dim rptid As String = ""
    Dim frmdkloc As New frmfilter
    Dim query As String = ""

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

    Dim old_value As String = ""
    Private Sub grd_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd.CellEnter
        old_value = grd.Item(e.ColumnIndex, e.RowIndex).Value
    End Sub

    Private Sub grd_CellValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd.CellValidated

        If (old_value <> grd.Item(e.ColumnIndex, e.RowIndex).Value) Then
            Dim col_name As String = grd.Columns(e.ColumnIndex).Name
            
        End If
    End Sub
    Private Sub rpt_AfterGetData(ByVal dataset As System.Data.DataSet)
        'Dim query As String = "delete from bangchamcong where thang =" & frmdkloc.txtthang.Value & " and nam =" & frmdkloc.txtnam.Value
        'If frmdkloc.txtma_bp.Text <> "" Then
        '    query = query & " and ma_bp = '" & frmdkloc.txtma_bp.Text & "'"
        'End If
        'If frmdkloc.txtma_nv.Text <> "" Then
        '    query = query & " and ma_nv = '" & frmdkloc.txtma_nv.Text & "'"
        'End If

        'query = query & Chr(13) & rpt.conn.GetInsertQueryFromDatatable(dataset.Tables(0), "bangchamcong")
        'rpt.conn.Execute(query)
        grd.Columns("ten_nv").Frozen = True
        'format column
        Dim ngay_cuoi_thang As Date = Clsql.Others.EndDateOfMonth(frmdkloc.txtthang.Value, frmdkloc.txtnam.Value)
        If ngay_cuoi_thang.Day = 28 Then
            grd.Columns("n29_ngay_cong").Visible = False
            grd.Columns("n30_ngay_cong").Visible = False
            grd.Columns("n31_ngay_cong").Visible = False
        End If
        If ngay_cuoi_thang.Day = 29 Then
            grd.Columns("n30_ngay_cong").Visible = False
            grd.Columns("n31_ngay_cong").Visible = False
        End If
        If ngay_cuoi_thang.Day = 30 Then
            grd.Columns("n31_ngay_cong").Visible = False
        End If
        ''
        'Dim i As Integer = 1
        'While i <= ngay_cuoi_thang.Day
        '    Dim d As Date = New Date(ngay_cuoi_thang.Year, ngay_cuoi_thang.Month, i)

        '    grd.Columns("n" & i).HeaderText = i & Chr(13) & ngaycuatuan(d.DayOfWeek)
        '    If d.DayOfWeek = 0 Then
        '        ClsControl2.PropertyOfGrid.FormatCell(grd, "n" & i, "1=1", grd.Font.Size, FontStyle.Bold, Color.Black, Color.RosyBrown)

        '    End If

        '    i = i + 1
        'End While
    End Sub

End Class
