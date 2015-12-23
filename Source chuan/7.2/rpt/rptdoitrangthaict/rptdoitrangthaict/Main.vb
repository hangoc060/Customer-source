Public Class MainForm
    Dim rpt As ClsRpt.rpt
    Dim rptid As String = ""
    Dim frmdkloc As New frmfilter
    Dim query As String = ""
    Dim oLable As Collection
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
            Me.Text = oLable(Me.Tag) & " " & Clsql.Others.GetArgu(3)
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

        ClsControl2.PropertyOfForm.SetImage4Control("gl.bmp", btnchuyensocai)
        ClsControl2.PropertyOfForm.SetImage4Control("ungl.bmp", btnchuyenlapchungtu)
        printer.Text = rpt.cPrint.GetPrinter


        AddHandler rpt.cPrint.BeforeShowReport, AddressOf SetParas
        btnIN.Visible = False
        btnpreview.Visible = False
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

        Dim oct As New ClsLookup.AutoCompleteLookup(rpt.conn, "dmct", frmdkloc.txtma_ct, "ma_ct", False)
        If Clsql.Reg.GetValue("Language") = "Vi" Then
            oct.SetValue("ten_ct", frmdkloc.ten_ct)
        Else
            oct.SetValue("ten_ct", frmdkloc.ten_ct)
        End If
       

    End Sub

    Sub GetQuery()
        query = "exec  " & rpt.cPrint.Store
        query = query & rpt.conn.ConvertToSQLType(frmdkloc.Txttu_ngay.Value)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.TxtDen_ngay.Value)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtma_ct.Text)
        If frmdkloc.kieuhien.Checked Then
            query = query & "," & rpt.conn.ConvertToSQLType(4)
        Else
            query = query & "," & rpt.conn.ConvertToSQLType(5)
        End If

        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.cbbma_dvcs.SelectedValue)

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
        rpt.cPrint.SetParameterValue("tu_ngay", frmdkloc.Txttu_ngay.Value)
        rpt.cPrint.SetParameterValue("den_ngay", frmdkloc.TxtDen_ngay.Value)
        rpt.cPrint.SetParameterValue("tk", frmdkloc.txtma_ct.Text)
        rpt.cPrint.SetParameterValue("ten_tk", frmdkloc.ten_ct.Text)
    End Sub

   
    Private Sub btnchuyensocai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnchuyensocai.Click
        chuyentrangthai(5)
    End Sub
    Private Sub btnchuyenlapchungtu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnchuyenlapchungtu.Click
        chuyentrangthai(0)
    End Sub
    Sub chuyentrangthai(ByVal status As Integer)
        grd.EndEdit()
        For Each r As DataGridViewRow In grd.Rows
            If r.Cells("sel").Value = True Then
                r.Cells("sel").Value = False
                'kiem tra ngay khoa so
                Dim ngay_ks As Date = rpt.conn.GetValue("get_ngay_ks '" & Clsql.Reg.GetValue("ID") & "','" & r.Cells("ma_ct").Value & "'")
                If ngay_ks >= r.Cells("ngay_ct").Value Then
                    MsgBox(Clsql.Others.Msgs("0015", rpt.conn).Replace("%n", r.Cells("ngay_ct").Value).Replace("%s", r.Cells("so_ct").Value), MsgBoxStyle.Exclamation, Me.Text)
                    Continue For
                End If
                'bat dau doi

                Dim query As String = "Update " & r.Cells("mastertable").Value & " set status ='" & status & "' where stt_rec='" & r.Cells("stt_rec").Value & "'"
                query = query & ChrW(13) & " exec cctcbct " & status & "," & rpt.conn.ConvertToSQLType(r.Cells("stt_rec").Value) & "," & rpt.conn.ConvertToSQLType(r.Cells("ma_ct").Value)
                rpt.conn.Execute(query)
                ClsSV31.Functions.PostRealTime(rpt.conn, r.Cells("ma_ct").Value, r.Cells("mastertable").Value, r.Cells("stt_rec").Value, status)
            End If
        Next
        MsgBox(oLable("007"), , Me.Text)
        btnrefresh2.PerformClick()
    End Sub
End Class
