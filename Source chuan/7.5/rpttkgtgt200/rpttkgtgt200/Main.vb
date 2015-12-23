Public Class MainForm

    Dim frmdkloc As New frmfilter
    Dim rptid As String = ""
    Dim query As String = ""

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ClsControl2.PropertyOfForm.CheckRegister = False Then
            Me.Close()
        End If
        rptid = Clsql.Others.GetArgu(1)
        rpt = New ClsRpt.rpt(rptid, Me.grd, btnIN, btnpreview, frmdkloc.cbbmau, frmdkloc.txttitle, frmdkloc.cbbma_dvcs)
        oLable = ClsControl2.PropertyOfForm.SetLable(rpt.conn, Me, rptid)
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
        ClsControl2.PropertyOfForm.SetImage4Control("form.bmp", btnmform)
        ClsControl2.PropertyOfForm.SetImage4Control("htkkt.bmp", btnhtkkt)
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
        Try
            frmdkloc.txttu_ky.Value = Now.Month
            frmdkloc.txtden_ky.Value = Now.Month
            frmdkloc.txtnam.Value = Now.Year
        Catch ex As Exception
        End Try
        'frmdkloc.txttk.Text = Clsql.Reg.GetValue("tk")

        'If frmdkloc.txttk.Text.Trim = "" Then
        '    frmdkloc.txttk.Text = "111"
        'End If



        'ClsLookup.AddItems.AddItemCbbGotBlank(rpt.conn, "select ma_dvcs,ten_dvcs from ddv", frmdkloc.cbbma_dvcs, "ten_dvcs", "ma_dvcs")


    End Sub

    Sub GetQuery()
        query = "exec  " & rpt.cPrint.Store & " "
        query = query & rpt.conn.ConvertToSQLType(frmdkloc.txttu_ky.Value)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtden_ky.Value)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtnam.Value)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.cbbma_dvcs.SelectedValue)
        query = query & "," & rpt.conn.ConvertToSQLType(rpt.cPrint.drvForm("idform"))
        query = query & ",0"

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
        rpt.cPrint.SetParameterValue("tu_ky", frmdkloc.txttu_ky.Value)
        rpt.cPrint.SetParameterValue("den_ky", frmdkloc.txtden_ky.Value)
        rpt.cPrint.SetParameterValue("nam", frmdkloc.txtnam.Value)

    End Sub
    Private Sub btnmform_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmform.Click
        Dim fmau As New frmkbmau
        fmau.Icon = Me.Icon
        fmau.Show()
    End Sub

    Private Sub grd_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles grd.DataError

    End Sub

    Private Sub grd_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd.RowEnter
        rpt.DataSource.EndEdit()
    End Sub
    Sub export2htkkt28()
        'doc file templete
        If Not IO.File.Exists(Application.StartupPath & "\template\tkgtgt28.xml") Then
            Return
        End If

        Dim read As New IO.StreamReader(Application.StartupPath & "\template\tkgtgt28.xml")
        Dim template As String = read.ReadToEnd
        read.Close()
        read.Dispose()
        'import du lieu
        Dim fbd As New FolderBrowserDialog
        fbd.ShowNewFolderButton = False
        Dim path As String = Clsql.Reg.GetValue("htkkt_path")
        If path = "" Then
            path = "C:\Program Files\"
        End If
        fbd.SelectedPath = path
        If fbd.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            path = fbd.SelectedPath
        Else
            Return
        End If
        Clsql.Reg.SetValue("htkkt_path", path)
        'xac dinh thang hoac quy bao cao
        Dim name_file_data As String = path & "/01_GTGT_"
        If frmdkloc.txttu_ky.Value = frmdkloc.txtden_ky.Value Then
            name_file_data = name_file_data & Strings.Format(frmdkloc.txttu_ky.Value, "00") & frmdkloc.txtnam.Value & ".xml"
        Else
            If frmdkloc.txtden_ky.Value <= 3 Then
                name_file_data = name_file_data & "Q01" & frmdkloc.txtnam.Value & ".xml"
            Else
                If frmdkloc.txtden_ky.Value <= 6 And frmdkloc.txtden_ky.Value > 3 Then
                    name_file_data = name_file_data & "Q02" & frmdkloc.txtnam.Value & ".xml"
                Else
                    If frmdkloc.txtden_ky.Value <= 9 And frmdkloc.txtden_ky.Value > 6 Then
                        name_file_data = name_file_data & "Q03" & frmdkloc.txtnam.Value & ".xml"
                    Else
                        name_file_data = name_file_data & "Q04" & frmdkloc.txtnam.Value & ".xml"
                    End If
                End If
            End If
        End If
        '
        Dim stream As New IO.StreamWriter(name_file_data)
        For Each r As DataRow In rpt.dv.Table.Rows
            Dim ma_so As String = r("ma_so")
            Dim doanh_so As Double = IIf(IsDBNull(r("ds")), 0, r("ds"))
            Dim thue As Double = IIf(IsDBNull(r("thue")), 0, r("thue"))
            template = template.Replace("#" & ma_so & "_D#", Strings.Format(doanh_so, "##0"))
            template = template.Replace("#" & ma_so & "_T#", Strings.Format(thue, "##0"))
        Next
        'chu ky
        Dim nguoi_ky As String = Clsql.Others.Options("cty_nnt", rpt.conn)
        Dim ngay_ky As String = Strings.Format(Now.Date, "dd/MM/yyyy")
        template = template.Replace("#NGU#", nguoi_ky)
        template = template.Replace("#NGA#", ngay_ky)
        stream.Write(template)
        stream.Close()
        stream.Dispose()
        MsgBox("Chương trình đã thực hiện xong", , Me.Text)
    End Sub


    Private Sub btnhtkkt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhtkkt.Click
        export2htkkt28()
    End Sub
End Class
