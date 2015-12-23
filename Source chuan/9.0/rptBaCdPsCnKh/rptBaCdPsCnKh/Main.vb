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
       

        Dim oTK As New ClsLookup.AutoCompleteLookup(rpt.conn, "rdmtk", frmdkloc.txttk, "tk", False)
        Dim okh As New ClsLookup.AutoCompleteLookup(rpt.conn, "dmkh", frmdkloc.txtma_kh, "ma_Kh", False)
        Dim onh_kh1 As New ClsLookup.AutoCompleteLookup(rpt.conn, "dmnhomkh", frmdkloc.txtnh_kh1, "ma_nhom", False)
        onh_kh1.oKey = "loai_nhom=1"
        Dim onh_kh2 As New ClsLookup.AutoCompleteLookup(rpt.conn, "dmnhomkh", frmdkloc.txtnh_kh2, "ma_nhom", False)
        onh_kh2.oKey = "loai_nhom=2"
        Dim onh_kh3 As New ClsLookup.AutoCompleteLookup(rpt.conn, "dmnhomkh", frmdkloc.txtnh_kh3, "ma_nhom", False)
        onh_kh3.oKey = "loai_nhom=3"

        onh_kh1.SetValue("ten_nhom", frmdkloc.ten_nh_kh1)
        onh_kh2.SetValue("ten_nhom", frmdkloc.ten_nh_kh2)
        onh_kh3.SetValue("ten_nhom", frmdkloc.ten_nh_kh3)

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
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtnh_kh1.Text)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtnh_kh2.Text)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtnh_kh3.Text)
        'xem chi tiet
        Dim xemsocai As String = rpt.conn.ConvertToSQLType(frmdkloc.Txttu_ngay.Value)
        xemsocai = xemsocai & "," & rpt.conn.ConvertToSQLType(frmdkloc.TxtDen_ngay.Value)
        xemsocai = xemsocai & "," & rpt.conn.ConvertToSQLType(frmdkloc.cbbma_dvcs.SelectedValue)
        xemsocai = xemsocai & ",'?tk?'"
        xemsocai = xemsocai & ",'?ma_kh?'"
        xemsocai = xemsocai & "," & rpt.conn.ConvertToSQLType(Clsql.Reg.GetValue("Language"))
        rpt.DrillDown.convert2sql_yn = True
        rpt.DrillDown.setCondition("dccn", xemsocai)

        Me.Text = oLable(Me.Tag) & " : " & frmdkloc.txtma_kh.Text & ", " & oLable("003") & " : " & frmdkloc.txttk.Text

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
        rpt.cPrint.SetParameterValue("nh_kh1", frmdkloc.txtnh_kh1.Text)
        rpt.cPrint.SetParameterValue("nh_kh2", frmdkloc.txtnh_kh2.Text)
        rpt.cPrint.SetParameterValue("nh_kh3", frmdkloc.txtnh_kh3.Text)

        rpt.cPrint.SetParameterValue("ten_nh_kh1", frmdkloc.ten_nh_kh1.Text)
        rpt.cPrint.SetParameterValue("ten_nh_kh2", frmdkloc.ten_nh_kh2.Text)
        rpt.cPrint.SetParameterValue("ten_nh_kh3", frmdkloc.ten_nh_kh3.Text)
    End Sub

   
End Class
