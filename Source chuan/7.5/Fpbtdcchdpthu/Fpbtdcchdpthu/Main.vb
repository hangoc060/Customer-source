Public Class MainForm
    Dim WithEvents rpt As ClsRpt.rpt
    Dim rptid As String = ""
    Dim frmdkloc As New frmfilter
    Dim query As String = ""
    Dim isloaded As Boolean = False
    Dim oLable As Collection
    Dim issaved As Boolean = True
    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rptid = Clsql.Others.GetArgu(1)
        rpt = New ClsRpt.rpt(rptid, Me.grd, btnIN, btnpreview, frmdkloc.cbbmau, frmdkloc.txttitle, frmdkloc.cbbma_dvcs)
        oLable = ClsControl2.PropertyOfForm.SetLable(rpt.conn, Me, rptid)
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
        ClsControl2.PropertyOfForm.SetImage4Control("delete.bmp", btnxoa_phan_bo)
        ClsControl2.PropertyOfForm.SetImage4Control("save.bmp", btnluu)
        ClsControl2.PropertyOfForm.SetImage4Control("recalc.bmp", btnphan_bo)

        printer.Text = rpt.cPrint.GetPrinter
        AddHandler rpt.cPrint.BeforeShowReport, AddressOf SetParas
        btnIN.Visible = False
        btnpreview.Visible = False
        isloaded = True

        Dim ogrid As ClsControl2.OnGrid
        ogrid = New ClsControl2.OnGrid(gridhd)
    End Sub

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
            frmdkloc.Txttu_ngay.Value = Clsql.Reg.GetValue("tu_ngay")
            frmdkloc.TxtDen_ngay.Value = Clsql.Reg.GetValue("den_ngay")

        Catch ex As Exception
        End Try
        frmdkloc.txttk.Text = Clsql.Reg.GetValue("tk")


        Dim oTK As New ClsLookup.AutoCompleteLookup(rpt.conn, "rdmtk", frmdkloc.txttk, "tk", False)
        Dim odmkh As New ClsLookup.AutoCompleteLookup(rpt.conn, "dmkh", frmdkloc.txtma_kh, "ma_kh", False)
        If Clsql.Reg.GetValue("Language") = "Vi" Then
            oTK.SetValue("ten_tk", frmdkloc.ten_tk)
            odmkh.SetValue("ten_kh", frmdkloc.ten_kh)
            ClsLookup.AddItems.AddItemCbb(rpt.conn, "select inds,text as txt from dmitemofcbb where form='" & rptid & "' and name='TypePB'", cbbtypepb, "txt", "inds")
           
        Else
            oTK.SetValue("ten_tk2", frmdkloc.ten_tk)
            odmkh.SetValue("ten_kh2", frmdkloc.ten_kh)
            ClsLookup.AddItems.AddItemCbb(rpt.conn, "select inds,text2 as txt from dmitemofcbb where form='" & rptid & "' and name='TypePB'", cbbtypepb, "txt", "inds")

        End If

    End Sub

    Sub GetQuery()
        query = "exec  " & rpt.cPrint.Store
        query = query & rpt.conn.ConvertToSQLType(frmdkloc.Txttu_ngay.Value)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.TxtDen_ngay.Value)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtma_kh.Text)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txttk.Text)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.cbbma_dvcs.SelectedValue)

    End Sub
    
#End Region

    Private Sub btnrefresh(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh2.Click
        Try
            currcell_r = grd.CurrentCell.RowIndex
            If grd.CurrentCell.ColumnIndex = 0 Then
                currcell_c = grd.CurrentCell.ColumnIndex + 1
            Else
                currcell_c = grd.CurrentCell.ColumnIndex
            End If
            rpt.Query = query

            grd.CurrentCell = grd.Item(currcell_c, currcell_r)
        Catch ex As Exception
        End Try
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
        rpt.cPrint.SetParameterValue("tu_ngay", frmdkloc.Txttu_ngay.Value)
        rpt.cPrint.SetParameterValue("den_ngay", frmdkloc.TxtDen_ngay.Value)
        rpt.cPrint.SetParameterValue("tk", frmdkloc.txttk.Text)
        rpt.cPrint.SetParameterValue("ten_tk", frmdkloc.ten_tk.Text)
    End Sub

    Dim dvhd As DataView
    Dim dataset As DataSet
    Private Sub rpt_AfterGetData(ByVal dataset As System.Data.DataSet) Handles rpt.AfterGetData
        Me.dataset = dataset
        dvhd = dataset.Tables(1).DefaultView
        If Not dataset.Tables(1).Columns.Contains("da_tt_nt_goc") Then
            dataset.Tables(1).Columns.Add("da_tt_nt_goc", GetType(Double))
            dataset.Tables(1).Columns.Add("con_lai_nt_goc", GetType(Double))
        End If
        For Each r As DataRow In dataset.Tables(1).Rows
            r("da_tt_nt_goc") = r("da_tt_nt")
            r("con_lai_nt_goc") = r("con_lai_nt")
        Next
        ClsControl2.PropertyOfGrid.FillGrid(rpt.conn, rptid.Trim & "D", gridhd, dvhd)
        ClsControl2.PropertyOfGrid.SetMaxLength(rpt.conn, gridhd, "tdttno")
        dataset.Tables(0).DefaultView.RowFilter = "1=1"
    End Sub


    Private Sub grd_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd.CellEnter
        If isloaded = True Then
            dvhd.RowFilter = "stt_rec ='" & grd.CurrentRow.Cells("stt_rec").Value _
            & "' and ma_kh ='" & grd.CurrentRow.Cells("ma_kh").Value _
            & "' and tk_co ='" & grd.CurrentRow.Cells("tk_co").Value & "'"

            gridhd.Columns("tien").Visible = Not (grd.CurrentRow.Cells("ma_nt").Value.ToString.ToUpper = Clsql.Others.Options("a_dtht", rpt.conn).Trim.ToUpper)


            If gridhd.Columns("tien").Visible = False Then
                gridhd.Columns("tien_nt").HeaderText = gridhd.Columns("tien").HeaderText
                gridhd.Columns("tien_nt").DefaultCellStyle.Format = gridhd.Columns("tien").DefaultCellStyle.Format
            Else
                gridhd.Columns("tien_nt").HeaderText = gridhd.Columns("tien_nt").HeaderCell.Tag.ToString.Split("?")(0)
                gridhd.Columns("tien_nt").DefaultCellStyle.Format = gridhd.Columns("tien_nt").HeaderCell.Tag.ToString.Split("?")(1)

            End If
        End If

    End Sub
    Dim tien_pb, tien_pb_nt, ty_gia, ty_gia_tt, tien_qd As Double, ma_nt As String, ma_nt_tt As String
    Sub phan_bo_theo_ngay_ct()
        If grd.RowCount = 0 Then
            Return
        End If
        issaved = False
        tien_pb = grd.CurrentRow.Cells("chua_pb").Value + ClsControl2.PropertyOfGrid.Sum(gridhd, "tien")
        tien_pb_nt = grd.CurrentRow.Cells("chua_pb_nt").Value + ClsControl2.PropertyOfGrid.Sum(gridhd, "tien_nt")
        ma_nt = grd.CurrentRow.Cells("ma_nt").Value
        ty_gia = grd.CurrentRow.Cells("ty_gia").Value
        For Each r As DataGridViewRow In gridhd.Rows
            r.Cells("tt_qd").Value = 0
            r.Cells("tien_nt").Value = 0
            r.Cells("tien").Value = 0
            r.Cells("pb_dn").Value = 0
            If r.Cells("con_lai_nt").Value > 0 Then
                'quy doi tien tren pc 
                If ma_nt.Trim.ToLower = r.Cells("ma_nt_tt").Value.ToString.Trim.ToLower Then
                    tien_qd = tien_pb_nt
                Else
                    tien_qd = tien_pb / r.Cells("ty_gia_tt").Value
                End If
                'phan bo
                If tien_qd <= 0 Then GoTo finnish
                If tien_qd >= r.Cells("con_lai_nt").Value Then
                    r.Cells("ma_nt").Value = ma_nt
                    r.Cells("ty_gia").Value = ty_gia
                    r.Cells("tt_qd").Value = r.Cells("con_lai_nt").Value

                    r.Cells("pb_dn").Value = 1


                    If ma_nt.Trim.ToLower = r.Cells("ma_nt_tt").Value.ToString.Trim.ToLower Then
                        r.Cells("tien_nt").Value = r.Cells("tt_qd").Value
                        r.Cells("tien").Value = r.Cells("tien_nt").Value * ty_gia
                    Else
                        r.Cells("tien").Value = r.Cells("tt_qd").Value * r.Cells("ty_gia_tt").Value
                        r.Cells("tien_nt").Value = r.Cells("tien").Value / ty_gia

                    End If
                    'tinh tien con lai
                    tien_pb_nt = tien_pb_nt - r.Cells("tien_nt").Value
                    tien_pb = tien_pb - r.Cells("tien").Value
                Else
                    r.Cells("ma_nt").Value = ma_nt
                    r.Cells("ty_gia").Value = ty_gia
                    r.Cells("tt_qd").Value = tien_qd
                    r.Cells("tien_nt").Value = tien_pb_nt
                    r.Cells("tien").Value = tien_pb
                    tien_pb = 0
                    tien_pb_nt = 0
                    r.Cells("pb_dn").Value = 1
                    GoTo finnish
                End If
            End If
finnish:

            Dim query2 As String = "stt_rec <>'" & grd.CurrentRow.Cells("stt_rec").Value _
           & "' and ma_kh ='" & grd.CurrentRow.Cells("ma_kh").Value _
           & "' and tk_co ='" & grd.CurrentRow.Cells("tk_co").Value & "' and stt_rec_tt='" & r.Cells("stt_rec_tt").Value & "' and ma_ct_tt='" & r.Cells("ma_ct_tt").Value & "'"

            Dim tt_dot_nay As Double = sumHD("stt_rec_tt='" & r.Cells("stt_rec_tt").Value & "'", "tt_qd")
            Dim tien_pb_theo_hd As Double = rpt.conn.GetValue("select sum(tt_qd) from tdttno where ngay_tt is not null and " & "stt_rec_tt+rtrim(ma_ct_tt)='" & r.Cells("stt_rec_tt").Value & r.Cells("ma_ct_tt").Value.ToString.Trim & "'")
            For Each r2 As DataRow In dvhd.Table.Select(query2)
                'tinh so tien con lai nt
                r2.Item("da_tt_nt") = tien_pb_theo_hd + tt_dot_nay - r2.Item("tt_qd")
                r2.Item("con_lai_nt") = r2.Item("t_tt_nt") - r2.Item("da_tt_nt")
            Next
            dvhd.Table.AcceptChanges()


        Next
        grd.CurrentRow.Cells("da_pb").Value = grd.CurrentRow.Cells("tien").Value - tien_pb
        grd.CurrentRow.Cells("da_pb_nt").Value = grd.CurrentRow.Cells("tien_nt").Value - tien_pb_nt
        grd.CurrentRow.Cells("chua_pb_nt").Value = tien_pb_nt
        grd.CurrentRow.Cells("chua_pb").Value = tien_pb
    End Sub
    Function sumHD(ByVal query As String, ByVal col As String) As Double
        Dim kq As Double = 0
        For Each r As DataRow In dvhd.Table.Select(query)
            kq = kq + r(col)
        Next
        Return kq
    End Function
    Sub phan_bo_hang_loat()
        If grd.RowCount = 0 Then
            Return
        End If
        Dim grd_datasource, hd_datasource
        grd_datasource = grd.DataSource
        hd_datasource = gridhd.DataSource
        gridhd.DataSource = Nothing
        grd.DataSource = Nothing
        issaved = False
        
        For Each r As DataRow In dataset.Tables(1).Rows
            r("da_tt_nt") = r("da_tt_nt_goc")
            r("con_lai_nt") = r("con_lai_nt_goc")
        Next
        For Each c_row As DataRow In dataset.Tables(0).Rows
            Dim query As String = "stt_rec ='" & c_row("stt_rec") _
              & "' and ma_kh ='" & c_row("ma_kh") _
              & "' and tk_co ='" & c_row("tk_co") & "'"

            tien_pb = c_row("chua_pb") + sumHD(query, "tien")
            tien_pb_nt = c_row("chua_pb_nt") + sumHD(query, "tien_nt")
            ma_nt = c_row("ma_nt")
            ty_gia = c_row("ty_gia")



            For Each r As DataRow In dvhd.Table.Select(query)
                r("tt_qd") = 0
                r("tien_nt") = 0
                r("tien") = 0
                r("pb_dn") = 0
                If r("con_lai_nt") > 0 Then
                    'quy doi tien tren pc 
                    If ma_nt.Trim.ToLower = r("ma_nt_tt").ToString.Trim.ToLower Then
                        tien_qd = tien_pb_nt
                    Else
                        tien_qd = tien_pb / r("ty_gia_tt")
                    End If
                    'phan bo
                    If tien_qd <= 0 Then GoTo finnish
                    If tien_qd >= r("con_lai_nt") Then
                        r("ma_nt") = ma_nt
                        r("ty_gia") = ty_gia
                        r("tt_qd") = r("con_lai_nt")

                        r("pb_dn") = 1



                        If ma_nt.Trim.ToLower = r("ma_nt_tt").ToString.Trim.ToLower Then
                            r("tien_nt") = r("tt_qd")
                            r("tien") = r("tien_nt") * ty_gia
                        Else
                            r("tien") = r("tt_qd") * r("ty_gia_tt")
                            r("tien_nt") = r("tien") / ty_gia

                        End If
                        'tinh tien con lai
                        tien_pb_nt = tien_pb_nt - r("tien_nt")
                        tien_pb = tien_pb - r("tien")
                    Else
                        r("ma_nt") = ma_nt
                        r("ty_gia") = ty_gia
                        r("tt_qd") = tien_qd
                        r("tien_nt") = tien_pb_nt
                        r("tien") = tien_pb
                        tien_pb = 0
                        tien_pb_nt = 0
                        r("pb_dn") = 1

                        GoTo finnish
                    End If
                End If
finnish:



                Dim query2 As String = "stt_rec <>'" & c_row("stt_rec") _
               & "' and ma_kh ='" & c_row("ma_kh") _
               & "' and tk_co ='" & c_row("tk_co") & "' and stt_rec_tt='" & r.Item("stt_rec_tt") & "' and ma_ct_tt='" & r("ma_ct_tt") & "'"

                Dim tt_dot_nay As Double = sumHD("stt_rec_tt='" & r.Item("stt_rec_tt") & "'", "tt_qd")
                Dim tien_pb_theo_hd As Double = rpt.conn.GetValue("select sum(tt_qd) from tdttno where ngay_tt is not null and " & "stt_rec_tt+rtrim(ma_ct_tt)='" & r.Item("stt_rec_tt") & r.Item("ma_ct_tt").ToString.Trim & "'")
                For Each r2 As DataRow In dvhd.Table.Select(query2)
                    'tinh so tien con lai nt
                    r2.Item("da_tt_nt") = tien_pb_theo_hd + tt_dot_nay - r2.Item("tt_qd")
                    r2.Item("con_lai_nt") = r2.Item("t_tt_nt") - r2.Item("da_tt_nt")
                Next
                dvhd.Table.AcceptChanges()

            Next
            c_row("da_pb") = c_row("tien") - tien_pb
            c_row("da_pb_nt") = c_row("tien_nt") - tien_pb_nt
            c_row("chua_pb_nt") = tien_pb_nt
            c_row("chua_pb") = tien_pb

        Next

        grd.DataSource = grd_datasource
        gridhd.DataSource = hd_datasource

    End Sub

    Dim querysave As String
    Dim currcell_r As Integer
    Dim currcell_c As Integer
    Sub luu()
        For Each r As DataGridViewRow In grd.Rows
            If Not kiem_tra_tien_Pb(r) Then
                Continue For
            End If

            Try
                dvhd.Table.AcceptChanges()
                querysave = "delete tdttno where stt_rec ='" & r.Cells("stt_rec").Value & "' and ma_kh ='" & r.Cells("ma_kh").Value & "' and tk_co ='" & r.Cells("tk_co").Value & "'"
                querysave = querysave & Chr(13) & "GO" & Chr(13) & rpt.conn.GetInsertQueryFromDatatable(dvhd.Table, "stt_rec ='" & r.Cells("stt_rec").Value & "' and ma_kh ='" & r.Cells("ma_kh").Value & "' and pb_dn = 1", "tdttno")
                querysave = querysave & Chr(13) & "GO" & Chr(13) & getQuerytattoan("stt_rec ='" & r.Cells("stt_rec").Value & "' and ma_kh ='" & r.Cells("ma_kh").Value & "' and pb_dn = 1")
                rpt.conn.ExecuteWithMultiQuery(querysave)

            Catch ex As Exception
                MsgBox("Không thể lưu" & Chr(13) & ex.ToString)
                Return
            End Try
        Next
        btnrefresh2.PerformClick()
        MsgBox("Đã lưu thành công")
        issaved = True
    End Sub
    Function getQuerytattoan(ByVal query) As String
        Dim kq As String = ""
        For Each r As DataRow In dvhd.Table.Select(query)
            If r("pb_dn") = 1 Then
                kq = kq & Chr(13) & "EXEC Tatoanno '" & r("stt_rec_tt") & "','" & r("ma_ct_tt") & "'"
            End If
        Next
        Return kq
    End Function
    Sub xoa_phan_bo()
        Try
            currcell_r = grd.CurrentCell.RowIndex
            currcell_c = grd.CurrentCell.ColumnIndex
            If grd.CurrentCell.ColumnIndex = 0 Then
                currcell_c = grd.CurrentCell.ColumnIndex + 1
            Else
                currcell_c = grd.CurrentCell.ColumnIndex
            End If

            querysave = "delete tdttno where stt_rec ='" & grd.CurrentRow.Cells("stt_rec").Value & "' and ma_kh ='" & grd.CurrentRow.Cells("ma_kh").Value & "' and tk_co ='" & grd.CurrentRow.Cells("tk_co").Value & "'"
            Dim query As String = "stt_rec ='" & grd.CurrentRow.Cells("stt_rec").Value & "' and ma_kh ='" & grd.CurrentRow.Cells("ma_kh").Value & "' and pb_dn = 1"
            querysave = querysave & Chr(13) & getQuerytattoan(query)

            rpt.conn.Execute(querysave)
            btnrefresh2.PerformClick()
            grd.CurrentCell = grd.Item(currcell_c, currcell_r)
            grd.CurrentCell.Selected = True
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnphan_bo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnphan_bo.Click
        phan_bo_theo_ngay_ct()
    End Sub

    Private Sub btnluu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnluu.Click
        luu()
    End Sub

    Private Sub btnxoa_phan_bo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnxoa_phan_bo.Click
        xoa_phan_bo()
    End Sub

    Private Sub gridhd_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles gridhd.CellBeginEdit
        Dim con_lai_nt As Double = gridhd.CurrentRow.Cells("con_lai_nt").Value
        ma_nt = grd.CurrentRow.Cells("ma_nt").Value.Trim.ToLower
        ty_gia = grd.CurrentRow.Cells("ty_gia").Value

        ma_nt_tt = gridhd.CurrentRow.Cells("ma_nt_tt").Value.Trim.ToLower
        ty_gia_tt = gridhd.CurrentRow.Cells("ty_gia_tt").Value
        If con_lai_nt <= 0 Then
            Return
        End If

        tien_pb_nt = grd.CurrentRow.Cells("chua_pb_nt").Value + gridhd.CurrentRow.Cells("tien_nt").Value
        tien_pb = grd.CurrentRow.Cells("chua_pb").Value + gridhd.CurrentRow.Cells("tien").Value

        
        'quy doi tien tren pc 
        If ma_nt = ma_nt_tt Then
            tien_qd = tien_pb_nt
        Else
            tien_qd = tien_pb / ty_gia_tt
        End If
        If tien_qd <= 0 Then
            Return
        End If
        '

        Select Case gridhd.Columns(e.ColumnIndex).Name.ToLower
            Case "tien_nt"
                If tien_qd > con_lai_nt Then
                    gridhd.CurrentRow.Cells("tt_qd").Value = con_lai_nt
                Else
                    gridhd.CurrentRow.Cells("tt_qd").Value = tien_qd
                End If
                gridhd.CurrentRow.Cells("ma_nt").Value = ma_nt
                gridhd.CurrentRow.Cells("ty_gia").Value = ty_gia

                If ma_nt = ma_nt_tt Then
                    gridhd.CurrentRow.Cells("tien_nt").Value = gridhd.CurrentRow.Cells("tt_qd").Value
                    gridhd.CurrentRow.Cells("tien").Value = gridhd.CurrentRow.Cells("tien_nt").Value * ty_gia
                Else
                    gridhd.CurrentRow.Cells("tien").Value = gridhd.CurrentRow.Cells("tt_qd").Value * gridhd.CurrentRow.Cells("ty_gia_tt").Value
                    gridhd.CurrentRow.Cells("tien_nt").Value = gridhd.CurrentRow.Cells("tien").Value / ty_gia

                End If



        End Select


    End Sub

    Private Sub gridhd_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridhd.CellEndEdit
        ma_nt = grd.CurrentRow.Cells("ma_nt").Value.Trim.ToLower
        ty_gia = grd.CurrentRow.Cells("ty_gia").Value
        ma_nt_tt = gridhd.CurrentRow.Cells("ma_nt_tt").Value.Trim.ToLower
        ty_gia_tt = gridhd.CurrentRow.Cells("ty_gia_tt").Value

        Select Case gridhd.Columns(e.ColumnIndex).Name.ToLower
            Case "tien_nt"
                gridhd.CurrentRow.Cells("tien").Value = gridhd.CurrentRow.Cells("tien_nt").Value * ty_gia
                tinh_tt_qd()

            Case "tien"
                tinh_tt_qd()
            Case "tt_qd"
                '  tinh_tien_tt()
        End Select
        gridhd.CurrentRow.Cells("pb_dn").Value = 1
    End Sub
    Function kiem_tra_tien_Pb(ByVal r As DataGridViewRow) As Boolean
        Dim kq As Boolean = True
        tien_pb = r.Cells("chua_pb").Value
        If tien_pb < 0 Then
            kq = False

            GoTo finish
        End If

        tien_pb_nt = r.Cells("chua_pb_nt").Value
        If tien_pb_nt < 0 Then
            kq = False
        End If
finish:
        Return kq
    End Function
    Sub tinh_tt_qd()
        If ma_nt = ma_nt_tt Then
            gridhd.CurrentRow.Cells("tt_qd").Value = gridhd.CurrentRow.Cells("tien_nt").Value
        Else
            gridhd.CurrentRow.Cells("tt_qd").Value = gridhd.CurrentRow.Cells("tien").Value / ty_gia_tt
        End If

        grd.CurrentRow.Cells("da_pb").Value = ClsControl2.PropertyOfGrid.Sum(gridhd, "tien")
        grd.CurrentRow.Cells("da_pb_nt").Value = ClsControl2.PropertyOfGrid.Sum(gridhd, "tien_nt")

        grd.CurrentRow.Cells("chua_pb").Value = grd.CurrentRow.Cells("tien").Value - grd.CurrentRow.Cells("da_pb").Value
        grd.CurrentRow.Cells("chua_pb_nt").Value = grd.CurrentRow.Cells("tien_nt").Value - grd.CurrentRow.Cells("da_pb_nt").Value
        If gridhd.CurrentRow.Cells("tt_qd").Value > 0 Then
            gridhd.CurrentRow.Cells("pb_dn").Value = 1
            issaved = False
        Else
            gridhd.CurrentRow.Cells("pb_dn").Value = 0
        End If
    End Sub
    Sub tinh_tien_tt()
        If ma_nt = ma_nt_tt Then
            gridhd.CurrentRow.Cells("tien_nt").Value = gridhd.CurrentRow.Cells("tt_qd").Value
            gridhd.CurrentRow.Cells("tien").Value = gridhd.CurrentRow.Cells("tt_qd").Value * ty_gia
        Else
            gridhd.CurrentRow.Cells("tien").Value = gridhd.CurrentRow.Cells("tt_qd").Value / ty_gia_tt
            gridhd.CurrentRow.Cells("tien_nt").Value = gridhd.CurrentRow.Cells("tien").Value / ty_gia
        End If
    End Sub
   
    Private Sub gridhd_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles gridhd.CellMouseDoubleClick

       
    End Sub

    Private Sub btnAutoAllo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAutoAllo.Click
        phan_bo_hang_loat()
    End Sub
End Class
