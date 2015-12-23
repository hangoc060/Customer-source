Public Class MainForm
    Dim rpt As ClsRpt.rpt
    Dim rptid As String = ""
    Dim frmdkloc As New frmfilter
    Dim query As String = ""

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rptid = Clsql.Others.GetArgu(1)
        rpt = New ClsRpt.rpt(rptid, Me.grd, btnIN, btnpreview, frmdkloc.cbbmau, frmdkloc.txttitle, frmdkloc.cbbma_dvcs)
        Dim oLable As Collection = ClsControl2.PropertyOfForm.SetLable(rpt.conn, Me, rptid)
        ClsControl2.PropertyOfForm.SetLable(oLable, frmdkloc)
        setupdkloc()
        frmdkloc.Icon = Me.Icon

        'them nut xem chi tiet
        rpt.DrillDown.convert2sql_yn = True
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

        frmdkloc.txtthang.Value = Now.Month
        frmdkloc.txtnam.Value = Now.Year
   
    End Sub

    Sub GetQuery()
        query = "exec  " & rpt.cPrint.Store
        query = query & " " & rpt.conn.ConvertToSQLType(frmdkloc.txtthang.Value)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtnam.Value)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtma_sp.Text)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtma_bp.Text)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtso_lsx.Text)
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
        rpt.cPrint.SetParameterValue("thang", frmdkloc.txtthang.Value)
        rpt.cPrint.SetParameterValue("nam", frmdkloc.txtnam.Value)
        rpt.cPrint.SetParameterValue("ma_sp", frmdkloc.txtma_sp.Text)
        rpt.cPrint.SetParameterValue("ten_sp", frmdkloc.ten_sp.Text)

        rpt.cPrint.SetParameterValue("ma_bp", frmdkloc.txtma_bp.Text)
        rpt.cPrint.SetParameterValue("ten_bp", frmdkloc.ten_bp.Text)
    
    End Sub
End Class
