Public Class MainForm
    Dim rpt As ClsRpt.rpt
    Dim rptid As String = ""
    Dim query As String = ""

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rptid = Clsql.Others.GetArgu(1)

        rpt = New ClsRpt.rpt(rptid, Me.grd, btnIN, btnpreview, frmfilter.cbbmau, frmfilter.txttitle, frmfilter.cbbma_dvcs, False, True, False)

        Dim oLable As Collection = ClsControl2.PropertyOfForm.SetLable(rpt.conn, Me, rptid)
       
        ClsControl2.PropertyOfForm.SetLable(rpt.conn, Me, "rvcdetail")
        lbluser.Text = Clsql.Reg.GetValue("ID")
        If Clsql.Reg.GetValue("language") = "Vi" Then
            lblunit.Text = rpt.conn.GetValue("select ten_dvcs from ddv where ma_dvcs='" & Clsql.Reg.GetValue("unit") & "'")

        Else
            lblunit.Text = rpt.conn.GetValue("select ten_dvcs2 from ddv where ma_dvcs='" & Clsql.Reg.GetValue("unit") & "'")

        End If
       
        'ClsControl2.PropertyOfForm.SetImage4Control("user.bmp", lbluser)

        ClsControl2.PropertyOfForm.SetImage4Control("refresh.bmp", btnrefresh2)
        printer.Text = rpt.cPrint.GetPrinter
        'ClsControl2.PropertyOfForm.SetImage4Control("printer.bmp", lbluser)
        'load du lieu
        If Clsql.Others.GetArgu(2) <> "" Then
            query = "exec " & rpt.cPrint.Store & " " & Clsql.Others.GetArgu(2)
        Else
            Me.Close()
            Return
        End If

        rpt.Query = query
        AddHandler rpt.cPrint.BeforeShowReport, AddressOf SetParas
        Me.Text = frmfilter.txttitle.Text
    End Sub

    Private Sub ThoatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ThoatToolStripMenuItem.Click
        Me.Close()
    End Sub
    
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
End Class
