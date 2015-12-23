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

    Private Sub rpt_AfterGetData(ByVal dataset As System.Data.DataSet) Handles rpt.AfterGetData
        dvhd = dataset.Tables(1).DefaultView
        ClsControl2.PropertyOfGrid.FillGrid(rpt.conn, rptid.Trim & "D", gridhd, dvhd)
        ClsControl2.PropertyOfGrid.SetMaxLength(rpt.conn, gridhd, "tdttco")
    End Sub

    
    Private Sub grd_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd.CellEnter
        If isloaded = True Then
            dvhd.RowFilter = "stt_rec ='" & grd.CurrentRow.Cells("stt_rec").Value _
            & "' and ma_kh ='" & grd.CurrentRow.Cells("ma_kh").Value _
            & "' and tk_no ='" & grd.CurrentRow.Cells("tk_no").Value & "'"

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

        Next
        grd.CurrentRow.Cells("da_pb").Value = grd.CurrentRow.Cells("tien").Value - tien_pb
        grd.CurrentRow.Cells("da_pb_nt").Value = grd.CurrentRow.Cells("tien_nt").Value - tien_pb_nt
        grd.CurrentRow.Cells("chua_pb_nt").Value = tien_pb_nt
        grd.CurrentRow.Cells("chua_pb").Value = tien_pb

    End Sub
    Dim querysave As String
    Dim currcell_r As Integer
    Dim currcell_c As Integer
    Sub luu()
        If gridhd.RowCount = 0 Then
            Return
        End If
        If Not kiem_tra_tien_Pb() Then
            Return
        End If

        Try
            currcell_r = grd.CurrentCell.RowIndex
            If grd.CurrentCell.ColumnIndex = 0 Then
                currcell_c = grd.CurrentCell.ColumnIndex + 1
            Else
                currcell_c = grd.CurrentCell.ColumnIndex
            End If

            dvhd.Table.AcceptChanges()
            gridhd.EndEdit()
            querysave = "delete tdttco where stt_rec ='" & grd.CurrentRow.Cells("stt_rec").Value & "' and ma_kh ='" & grd.CurrentRow.Cells("ma_kh").Value & "' and tk_no ='" & grd.CurrentRow.Cells("tk_no").Value & "'"

            querysave = querysave & Chr(13) & rpt.conn.GetInsertQueryFromDatatable(dvhd.Table, "stt_rec ='" & grd.CurrentRow.Cells("stt_rec").Value & "' and ma_kh ='" & grd.CurrentRow.Cells("ma_kh").Value & "' and pb_dn = 1", "tdttco")
            querysave = querysave & Chr(13) & getQuerytattoan()
            rpt.conn.Execute(querysave)
            rpt.Query = query

            grd.CurrentCell = grd.Item(currcell_c, currcell_r)
        Catch ex As Exception
        End Try
        issaved = True
    End Sub
    Function getQuerytattoan() As String
        Dim kq As String = ""
        For Each r As DataGridViewRow In gridhd.Rows
            If r.Cells("pb_dn").Value = 1 Then
                kq = kq & Chr(13) & "EXEC Tatoanco '" & r.Cells("stt_rec_tt").Value & "','" & r.Cells("ma_ct_tt").Value & "'"
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

            querysave = "delete tdttco where stt_rec ='" & grd.CurrentRow.Cells("stt_rec").Value & "' and ma_kh ='" & grd.CurrentRow.Cells("ma_kh").Value & "' and tk_no ='" & grd.CurrentRow.Cells("tk_no").Value & "'"
            querysave = querysave & Chr(13) & getQuerytattoan()

            rpt.conn.Execute(querysave)
            rpt.Query = query

            grd.CurrentCell = grd.Item(currcell_c, currcell_r)
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
    End Sub
    Function kiem_tra_tien_Pb() As Boolean

        Dim kq As Boolean = True
        tien_pb = grd.CurrentRow.Cells("chua_pb").Value
        If tien_pb < 0 Then
            kq = False

            GoTo finish
        End If

        tien_pb_nt = grd.CurrentRow.Cells("chua_pb_nt").Value
        If tien_pb_nt < 0 Then
            kq = False
        End If
finish:
        If kq = False Then
            MsgBox(oLable("888"), MsgBoxStyle.Exclamation, Me.Text)
        End If
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
        gridhd.CurrentRow.Cells("pb_dn").Value = 1
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
End Class
