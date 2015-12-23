Imports System.IO
Imports System.ComponentModel

Public Class Form1
    Dim conn As New Clsql.SQL
    Dim olan As Collection
    Dim dt As DataTable
    Dim fprintfilter As New frmfilterPrintBarcode
    Dim cprint As ClPrint.Print
    Dim checkright As ClsRight.CheckRight
    Public Shared Sub SaveDataTable2TextFile(ByVal datatable As Data.DataTable, ByVal fileData As String)

        Dim stream As New StreamWriter(fileData)
        For Each r As Data.DataRow In datatable.Rows
            Dim rdata As String = ""
            For Each c As Data.DataColumn In datatable.Columns
                If rdata = "" Then
                    If IsDBNull(r.Item(c)) Then
                        rdata = " "
                    Else
                        rdata = r.Item(c).ToString
                    End If

                Else
                    If IsDBNull(r.Item(c)) Then
                        rdata = rdata & vbTab & " "
                    Else
                        rdata = rdata & vbTab & r.Item(c).ToString
                    End If

                End If
            Next
            stream.WriteLine(rdata)
        Next
        stream.Close()
    End Sub
    Dim bindingsource As New BindingSource
    Dim dtprint As New DataTable
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Clsql.Reg.GetValue("SLG") = 0 Then
            Application.Exit()
            Return
        End If
        'check right
        'check right
        Dim ma_cn As String = conn.GetValue("select id from " & Clsql.Others.Options("cmd_table", conn) & " where ma_cn ='" & Clsql.Others.GetArgu(1) & "'")
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

        Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        txtuser.Text = Clsql.Reg.GetValue("ID")
        olan = ClsControl2.PropertyOfForm.SetLable(conn, Me, Clsql.Others.GetArgu(1))
        ClsControl2.PropertyOfForm.KeyEnter(Me)
        ClsLookup.AddItems.AddItemCbb(conn, "select * from dmitemofcbb where form ='" & Clsql.Others.GetArgu(1) & "'", cbbkieu, "text", "val")
        txtden_ngay.Value = Now
        txttu_ngay.Value = Now
        cbbkieu_SelectedIndexChanged(Nothing, Nothing)
        ClsControl2.PropertyOfForm.SetLable(olan, fprintfilter)
        fprintfilter.Icon = Me.Icon
        ClsControl2.PropertyOfForm.KeyEnter(fprintfilter)
        'ClsLookup.AddItems.AddItemCbb(conn, "select * from rpts where code ='" & Clsql.Others.GetArgu(1) & "'", fprintfilter.cbbmau, "name", "rpt")
        cprint = New ClPrint.Print(conn, Clsql.Others.GetArgu(1), fprintfilter.cbbmau, fprintfilter.txttitle)
        Dim ogrid As New ClsControl2.OnGrid(grid4filter)
        AddHandler grid4filter.KeyDown, AddressOf ClsControl2.PropertyOfGrid.Filter



        Try
            dtprint = conn.GetDatatable("exec dataprintbarcode")
        Catch ex As Exception
            dtprint = New DataTable
            dtprint.Columns.Add("sel", GetType(Boolean))
            dtprint.Columns.Add("ma_vt", GetType(String))
            dtprint.Columns.Add("ten_vt", GetType(String))
            dtprint.Columns.Add("ma_dvt", GetType(String))
            dtprint.Columns.Add("gia_ban_le", GetType(Decimal))
            dtprint.Columns.Add("gia_ban_buon", GetType(Decimal))
            dtprint.Columns.Add("gia_ban_buon1", GetType(Decimal))
            dtprint.Columns.Add("gia_ban_buon2", GetType(Decimal))
            dtprint.Columns.Add("gia_ban_buon3", GetType(Decimal))
            dtprint.Columns.Add("so_luong", GetType(Decimal))
        End Try


        ClsControl2.PropertyOfGrid.FillGrid(conn, "getVT4BC", grid4print, dtprint.DefaultView)
    End Sub


    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        
        bindingsource.DataSource = Nothing
        dt = Nothing
        Dim query As String = "exec " & cbbkieu.SelectedValue
        Try
            Dim dr As DataRowView = cbbkieu.SelectedItem
            query = query.Replace("{ma_vt}", conn.ConvertToSQLType(txtma_vt.Text))
            query = query.Replace("{so_ct}", conn.ConvertToSQLType(txtso_ct.Text))
            query = query.Replace("{tu_ngay}", conn.ConvertToSQLType(txttu_ngay.Value))
            query = query.Replace("{den_ngay}", conn.ConvertToSQLType(txtden_ngay.Value))
            dt = conn.GetDatatable(query)

            Dim gridid As String = "getVT4BC"
            If dt.Columns.Contains("so_ct") Then
                gridid = "getVT4BC_n"
            End If
            bindingsource.DataSource = dt
            ClsControl2.PropertyOfGrid.FillGrid(conn, gridid, grid4filter, bindingsource)
        Catch ex As Exception
            MsgBox(ex.ToString & Chr(13) & Chr(query))
        End Try
    End Sub

    Private Sub cbbkieu_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbbkieu.SelectedIndexChanged
        Try
            Dim query As String = cbbkieu.SelectedValue
            If query.Contains("tu_ngay") Then
                txttu_ngay.Enabled = True
            Else
                txttu_ngay.Enabled = False
            End If

            If query.Contains("den_ngay") Then
                txtden_ngay.Enabled = True
            Else
                txtden_ngay.Enabled = False
            End If
            If query.Contains("ma_vt") Then
                txtma_vt.Enabled = True
            Else
                txtma_vt.Enabled = False
            End If
            If query.Contains("so_ct") Then
                txtso_ct.Enabled = True
            Else
                txtso_ct.Enabled = False
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If grid4filter.RowCount = 0 Then
            Return
        End If
        Dim kq As DialogResult = fprintfilter.ShowDialog(Me)
        If kq = Windows.Forms.DialogResult.Cancel Then
            Return
        End If

        'tao datatable
        Dim dt4print As DataTable = New DataTable

        For Each c As DataColumn In dtprint.Columns
            If c.ColumnName <> "sel" AndAlso c.ColumnName <> "so_luong" Then
                dt4print.Columns.Add(c.ColumnName, GetType(String))
            End If
        Next
        'dt4print.Columns.Add("ma_vt", GetType(String))
        'dt4print.Columns.Add("ten_vt", GetType(String))
        'dt4print.Columns.Add("ma_dvt", GetType(String))
        'dt4print.Columns.Add("gia_ban_le", GetType(String))
        'dt4print.Columns.Add("gia_ban_buon", GetType(String))
        'dt4print.Columns.Add("gia_ban_buon1", GetType(String))
        'dt4print.Columns.Add("gia_ban_buon2", GetType(String))
        'dt4print.Columns.Add("gia_ban_buon3", GetType(String))
        '
        grid4print.EndEdit()
        dtprint.AcceptChanges()
        Dim dpchn As String = Clsql.Others.Options("f_pchn", conn)
        If String.IsNullOrEmpty(dpchn) Then
            dpchn = "."
        End If
        Dim format_number As String = "# ### ### ##0"
        For Each r As DataGridViewRow In grid4print.Rows
            'If r.Cells("sel").Value = True AndAlso r.Cells("so_luong").Value > 0 Then
            For i As Integer = 1 To r.Cells("so_luong").Value
                Dim nr As DataRow = dt4print.NewRow
                For Each c As DataColumn In dt4print.Columns
                    If dtprint.Columns(c.ColumnName).DataType.ToString.Contains("Double") OrElse dtprint.Columns(c.ColumnName).DataType.ToString.Contains("Decimal") Then
                        nr.Item(c.ColumnName) = Strings.Format(r.Cells(c.ColumnName).Value, format_number).Trim.Replace(" ", dpchn)
                    Else
                        nr.Item(c.ColumnName) = r.Cells(c.ColumnName).Value
                    End If

                Next
                'nr.Item("ma_vt") = r.Cells("ma_vt").Value
                'nr.Item("ten_vt") = r.Cells("ten_vt").Value
                'nr.Item("ma_dvt") = r.Cells("ma_dvt").Value
                'nr.Item("gia_ban_le") = Strings.Format(r.Cells("gia_ban_le").Value, format_number).Trim.Replace(" ", dpchn)
                'nr.Item("gia_ban_buon") = Strings.Format(r.Cells("gia_ban_buon").Value, format_number).Trim.Replace(" ", dpchn)
                'nr.Item("gia_ban_buon1") = Strings.Format(r.Cells("gia_ban_buon1").Value, format_number).Trim.Replace(" ", dpchn)
                'nr.Item("gia_ban_buon2") = Strings.Format(r.Cells("gia_ban_buon2").Value, format_number).Trim.Replace(" ", dpchn)
                'nr.Item("gia_ban_buon3") = Strings.Format(r.Cells("gia_ban_buon3").Value, format_number).Trim.Replace(" ", dpchn)

                dt4print.Rows.Add(nr)
            Next


            '' End If
        Next
        '
        If dt4print.Rows.Count > 0 Then
            If fprintfilter.chbBarTender.Checked Then
                'use bartender
                Dim dir As String = Application.StartupPath & "\btw"
                If Not IO.Directory.Exists(dir) Then
                    IO.Directory.CreateDirectory(dir)
                End If
                Dim filePath As String = dir & "\" & fprintfilter.cbbmau.SelectedItem.row("rpt").ToString.Trim & ".btw"
                Dim fileData As String = filePath.Replace(".btw", ".txt")
                SaveDataTable2TextFile(dt4print, fileData)
                Dim argus As String = fprintfilter.cbbmau.SelectedItem.row("rpt").ToString.Trim
                If kq = Windows.Forms.DialogResult.Yes Then 'preview
                    argus = argus & " 0"
                Else
                    argus = argus & " 1"
                End If
                Clsql.Others.Exec("PrintBarTender.exe", argus)

            Else

                Dim ds As New DataSet
                ds.Tables.Add(dt4print)
                cprint.Dataset = ds
                cprint.SetParameterValue("do_rong", fprintfilter.txtdo_rong.Value)
                If kq = Windows.Forms.DialogResult.Yes Then 'preview
                    cprint.RefreshReport()
                    cprint.PrintRPT.ShowDialog(Me)
                Else 'print
                    cprint.Print()
                End If
            End If

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        grid4filter.EndEdit()
        Dim dts = grid4print.DataSource
        grid4print.DataSource = Nothing
        For Each r As DataRow In dt.Rows
            If r("sel") = True Then
                r("sel") = False
                Dim rp As DataRow = dtprint.NewRow
                rp("so_luong") = 1
                rp("gia_ban_le") = 0
                dtprint.Rows.Add(rp)
                For Each c As DataColumn In dtprint.Columns
                    If grid4filter.Columns.Contains(c.ColumnName) Then
                        rp(c) = r(c.ColumnName)
                    End If
                Next
            End If
        Next
        grid4print.DataSource = dts
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        grid4print.EndEdit()
        Dim dts = grid4print.DataSource
        grid4print.DataSource = Nothing
        Dim remove_rows As New List(Of DataRow)
        For index As Integer = 0 To dtprint.Rows.Count - 1
            Dim r As DataRow = dtprint.Rows.Item(index)
            If r("sel") = True Then
                remove_rows.Add(r)
            End If
        Next
        For Each r As DataRow In remove_rows
            dtprint.Rows.Remove(r)
        Next
        grid4print.DataSource = dts
    End Sub

    
End Class
