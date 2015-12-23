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
            'Me.Text = oLable(Me.Tag) & " " & Clsql.Others.GetArgu(3)

            Me.Text = oLable(Me.Tag) & " : " & Clsql.Others.GetArgu(4) & ", " & oLable("003") & " : " & Clsql.Others.GetArgu(3)

            frmdkloc.txttk.Text = Clsql.Others.GetArgu(3)
            frmdkloc.ten_tk.Text = rpt.conn.GetValue("select ten_tk from dmtk where tk ='" & frmdkloc.txttk.Text & "'")


            frmdkloc.txtma_kh.Text = Clsql.Others.GetArgu(4)
            frmdkloc.ten_kh.Text = rpt.conn.GetValue("select ten_kh from dkh where ma_kh ='" & frmdkloc.txtma_kh.Text & "'")


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
        AddHandler rpt.cPrint.BeforeShowReport, AddressOf SetParas

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
        Try
            frmdkloc.txttk.Text = rpt.conn.GetValue("select textV from forminfo where textid='mtk' and formid='" & rptid & "'")
            frmdkloc.txtma_kh.Text = rpt.conn.GetValue("select textV from forminfo where textid='mkh' and formid='" & rptid & "'")
        Catch ex As Exception
        End Try
      


        Dim oTK As New ClsLookup.AutoCompleteLookup(rpt.conn, "rdmtk", frmdkloc.txttk, "tk")
        Dim okh As New ClsLookup.AutoCompleteLookup(rpt.conn, "dmkh", frmdkloc.txtma_kh, "ma_Kh")
        If Clsql.Reg.GetValue("Language") = "Vi" Then
            okh.SetValue("ten_kh", frmdkloc.ten_kh)
            oTK.SetValue("ten_tk", frmdkloc.ten_tk)
        Else
            oTK.SetValue("ten_tk2", frmdkloc.ten_tk)
            okh.SetValue("ten_kh2", frmdkloc.ten_kh)
        End If
    End Sub

    Sub GetQuery()
        query = "exec  " & rpt.cPrint.Store
        query = query & rpt.conn.ConvertToSQLType(frmdkloc.Txttu_ngay.Value)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.TxtDen_ngay.Value)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.cbbma_dvcs.SelectedValue)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txttk.Text)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtma_kh.Text)
        query = query & "," & rpt.conn.ConvertToSQLType(Clsql.Reg.GetValue("Language"))
        Me.Text = oLable(Me.Tag) & " : " & frmdkloc.txtma_kh.Text & ", " & oLable("003") & " : " & frmdkloc.txttk.Text

        rpt.conn.Execute("update forminfo set textv ='" & frmdkloc.txttk.Text & "', texte ='" & frmdkloc.txttk.Text & "' where formid ='" & rptid & "' and textid ='mtk'")
        rpt.conn.Execute("update forminfo set textv ='" & frmdkloc.txtma_kh.Text & "', texte ='" & frmdkloc.txtma_kh.Text & "' where formid ='" & rptid & "' and textid ='mkh'")


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
        rpt.cPrint.SetParameterValue("tk", frmdkloc.txttk.Text)
        rpt.cPrint.SetParameterValue("ten_tk", frmdkloc.ten_tk.Text)

        Dim dtkh As DataTable = rpt.conn.GetDatatable("select * from dkh where ma_kh ='" & frmdkloc.txtma_kh.Text & "'")
        For Each c As DataColumn In dtkh.Columns
            If dtkh.Rows.Count > 0 Then
                If Not IsDBNull(dtkh.Rows(0).Item(c.ColumnName)) Then
                    rpt.cPrint.SetParameterValue(c.ColumnName, dtkh.Rows(0).Item(c.ColumnName))
                Else
                    rpt.cPrint.SetParameterValue(c.ColumnName, "")
                End If
            Else
                rpt.cPrint.SetParameterValue(c.ColumnName, "")
            End If
        Next
        '
        Dim du_no As Double = 0
        Dim du_co As Double = 0
        For Each r As DataGridViewRow In grd.Rows
            If r.Cells("sysorder").Value = 2 Then
                du_no = r.Cells("ps_no").Value
                du_co = r.Cells("ps_co").Value
            End If
        Next
        rpt.cPrint.SetParameterValue("doc_du_no", ClPrint.ByWord.Number2TextV(du_no))
        rpt.cPrint.SetParameterValue("doc_du_co", ClPrint.ByWord.Number2TextV(du_co))

        rpt.cPrint.SetParameterValue("du_no", du_no)
        rpt.cPrint.SetParameterValue("du_co", du_co)
    End Sub
End Class