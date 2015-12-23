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
        ClsControl2.PropertyOfForm.SetImage4Control("htkkt.bmp", btnhtkkt)
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
            frmdkloc.Txttu_ngay.Value = My.Settings.tu_ngay
            frmdkloc.TxtDen_ngay.Value = My.Settings.den_ngay

        Catch ex As Exception
        End Try
        frmdkloc.txtma_thue.Text = My.Settings.ma_thue

        Dim oTK As New ClsLookup.AutoCompleteLookup(rpt.conn, "rdmtk", frmdkloc.txttk, "tk", False)
        Dim othue As New ClsLookup.AutoCompleteLookup(rpt.conn, "dmvat", frmdkloc.txtma_thue, "ma_thue", False)
        Dim otkdu As New ClsLookup.AutoCompleteLookup(rpt.conn, "rdmtk", frmdkloc.txttk_du, "tk", False)
        Dim okh As New ClsLookup.AutoCompleteLookup(rpt.conn, "dmkh", frmdkloc.txtma_kh, "ma_kh", False)

        If Clsql.Reg.GetValue("Language") = "Vi" Then
            oTK.SetValue("ten_tk", frmdkloc.ten_tk)
            otkdu.SetValue("ten_tk", frmdkloc.ten_tk_du)
            othue.SetValue("ten_thue", frmdkloc.ten_thue)
            okh.SetValue("ten_kh", frmdkloc.ten_kh)
            ClsLookup.AddItems.AddItemCbb(rpt.conn, "select codeid,headerV as txt from optgroupby where type =2 and rptid='" & rptid & "'", frmdkloc.cbbsap_xep, "txt", "codeid")
        Else
            oTK.SetValue("ten_tk2", frmdkloc.ten_tk)
            otkdu.SetValue("ten_tk2", frmdkloc.ten_tk_du)
            othue.SetValue("ten_thue2", frmdkloc.ten_thue)
            okh.SetValue("ten_kh2", frmdkloc.ten_kh)
            ClsLookup.AddItems.AddItemCbb(rpt.conn, "select codeid,headerE as txt from optgroupby where type =2 and rptid='" & rptid & "'", frmdkloc.cbbsap_xep, "txt", "codeid")

        End If
        ' ClsLookup.AddItems.AddItemCbbGotBlank(rpt.conn, "select ma_dvcs,ten_dvcs from ddv", frmdkloc.cbbma_dvcs, "ten_dvcs", "ma_dvcs")


    End Sub

    Sub GetQuery()
        query = "exec  " & rpt.cPrint.Store
        query = query & rpt.conn.ConvertToSQLType(frmdkloc.Txttu_ngay.Value)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.TxtDen_ngay.Value)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtma_thue.Text)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txttk.Text)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txttk_du.Text)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.txtma_kh.Text)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.cbbsap_xep.SelectedValue)
        query = query & "," & rpt.conn.ConvertToSQLType(frmdkloc.cbbma_dvcs.SelectedValue)
        query = query & "," & rpt.conn.ConvertToSQLType(Clsql.Reg.GetValue("Language"))
        'set para for export
        ClsControl2.PropertyOfGrid.Parameter4Export2Excel = New Dictionary(Of String, Object)
        ClsControl2.PropertyOfGrid.Parameter4Export2Excel.Add("ky", frmdkloc.TxtDen_ngay.Value.Month)
        ClsControl2.PropertyOfGrid.Parameter4Export2Excel.Add("nam", frmdkloc.TxtDen_ngay.Value.Year)
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
        rpt.cPrint.SetParameterValue("tk", frmdkloc.txtma_thue.Text)
        rpt.cPrint.SetParameterValue("ten_tk", frmdkloc.ten_thue.Text)
    End Sub

    Sub export2htkkt()
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
        Dim rowbigin As Integer = 8
        'xac dinh thang hoac quy bao cao
        Dim name_file_data As String = path & "/01_2_GTGT_"
        If frmdkloc.Txttu_ngay.Value.Month = frmdkloc.TxtDen_ngay.Value.Month Then
            name_file_data = name_file_data & Strings.Format(frmdkloc.TxtDen_ngay.Value.Month, "00") & frmdkloc.TxtDen_ngay.Value.Year & ".xml"
        Else
            If frmdkloc.TxtDen_ngay.Value.Month <= 3 Then
                name_file_data = name_file_data & "Q01" & frmdkloc.TxtDen_ngay.Value.Year & ".xml"
            Else
                If frmdkloc.TxtDen_ngay.Value.Month <= 6 And frmdkloc.TxtDen_ngay.Value.Month > 3 Then
                    name_file_data = name_file_data & "Q02" & frmdkloc.TxtDen_ngay.Value.Year & ".xml"
                Else
                    If frmdkloc.TxtDen_ngay.Value.Month <= 9 And frmdkloc.TxtDen_ngay.Value.Month > 6 Then
                        name_file_data = name_file_data & "Q03" & frmdkloc.TxtDen_ngay.Value.Year & ".xml"
                    Else
                        name_file_data = name_file_data & "Q04" & frmdkloc.TxtDen_ngay.Value.Year & ".xml"
                    End If
                End If
            End If
        End If
        '
        Dim stream As New IO.StreamWriter(name_file_data)
        stream.WriteLine("<!-- Created with STP Accounting (http://saotienphong.com.vn) by Truongpv-->")
        stream.WriteLine("<!DOCTYPE Sections SYSTEM " & Chr(34) & "..\..\InterfaceTemplates\Schema.dtd" & Chr(34) & ">")
        stream.WriteLine("<Sections Version=" & Chr(34) & "130" & Chr(34) & ">")
        'tinh chat 1
        stream.WriteLine("  <Section Dynamic=" & Chr(34) & "1" & Chr(34) & " MaxRows = " & Chr(34) & "0" & Chr(34) & ">")
        Dim i As Integer = 0
        For Each r As DataRow In rpt.dv.Table.Select("ma_tc ='1' and sysorder =5")
            stream.WriteLine("      <Cells>")
            If i = 0 Then
                stream.WriteLine("          <Cell CellID=" & Chr(34) & "C_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AU_" & (rowbigin + 10) & Chr(34) & " FirstCell=" & Chr(34) & "0" & Chr(34) & " Encode='0' Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & "" & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")

            Else
                stream.WriteLine("          <Cell CellID=" & Chr(34) & "C_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AU_" & (rowbigin + 10) & Chr(34) & " FirstCell=" & Chr(34) & "1" & Chr(34) & " Encode='0' Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & "" & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")

            End If
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "D_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "C_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("ky_hieu_hoa_don") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "E_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "E_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("so_seri").trim & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "F_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "G_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("so_hd").trim & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            If Not IsDBNull(r("ngay_hd")) Then
                stream.WriteLine("          <Cell CellID=" & Chr(34) & "G_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "M_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Strings.Format(r("ngay_hd"), "dd/MM/yyyy") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            Else
                stream.WriteLine("          <Cell CellID=" & Chr(34) & "G_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "M_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            End If
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "H_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "R_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("ten_kh").ToString.Trim.Replace("&", "&amp;").Replace(Chr(34), "&quot;").Replace("<", "&lt;") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "I_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "X_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("ma_so_thue").trim & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "J_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AB_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("ten_vt").trim.Replace("&", "&amp;").Replace(Chr(34), "&quot;").Replace("<", "&lt;") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "K_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AF_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Strings.Format(r("t_tien"), "0") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")

            If Not IsDBNull(r("thue_suat")) Then
                stream.WriteLine("          <Cell CellID=" & Chr(34) & "L_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AJ_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Strings.Format(r("thue_suat"), "0") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")

            Else
                stream.WriteLine("          <Cell CellID=" & Chr(34) & "L_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AJ_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & "0" & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")

            End If

            stream.WriteLine("          <Cell CellID=" & Chr(34) & "M_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AN_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Strings.Format(r("t_thue"), "0") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "N_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AR_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")


            stream.WriteLine("      </Cells>")
            rowbigin += 1
            i += 1
        Next
        stream.WriteLine("  </Section>")
        'tinh chat 2
        rowbigin = rowbigin + 4
        stream.WriteLine("  <Section Dynamic=" & Chr(34) & "1" & Chr(34) & " MaxRows = " & Chr(34) & "0" & Chr(34) & ">")
        i = 0
        For Each r As DataRow In rpt.dv.Table.Select("ma_tc ='2' and sysorder =5")
            stream.WriteLine("      <Cells>")
            If i = 0 Then
                stream.WriteLine("          <Cell CellID=" & Chr(34) & "C_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AU_" & (rowbigin + 10) & Chr(34) & " FirstCell=" & Chr(34) & "0" & Chr(34) & " Encode='0' Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & "" & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")

            Else
                stream.WriteLine("          <Cell CellID=" & Chr(34) & "C_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AU_" & (rowbigin + 10) & Chr(34) & " FirstCell=" & Chr(34) & "1" & Chr(34) & " Encode='0' Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & "" & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")

            End If
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "D_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "C_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("ky_hieu_hoa_don") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "E_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "E_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("so_seri").trim & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "F_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "G_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("so_hd").trim & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            If Not IsDBNull(r("ngay_hd")) Then
                stream.WriteLine("          <Cell CellID=" & Chr(34) & "G_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "M_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Strings.Format(r("ngay_hd"), "dd/MM/yyyy") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            Else
                stream.WriteLine("          <Cell CellID=" & Chr(34) & "G_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "M_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")

            End If
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "H_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "R_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("ten_kh").ToString.Trim.Replace("&", "&amp;").Replace(Chr(34), "&quot;").Replace("<", "&lt;") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "I_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "X_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("ma_so_thue").trim & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "J_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AB_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("ten_vt").trim.Replace("&", "&amp;").Replace(Chr(34), "&quot;").Replace("<", "&lt;") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "K_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AF_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Strings.Format(r("t_tien"), "0") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")

            If Not IsDBNull(r("thue_suat")) Then
                stream.WriteLine("          <Cell CellID=" & Chr(34) & "L_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AJ_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Strings.Format(r("thue_suat"), "0") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")

            Else
                stream.WriteLine("          <Cell CellID=" & Chr(34) & "L_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AJ_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & "0" & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")

            End If

            stream.WriteLine("          <Cell CellID=" & Chr(34) & "M_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AN_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Strings.Format(r("t_thue"), "0") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "N_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AR_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")


            stream.WriteLine("      </Cells>")

            rowbigin += 1
            i += 1
        Next

        stream.WriteLine("  </Section>")
        'tinh chat 3
        rowbigin = rowbigin + 4
        stream.WriteLine("  <Section Dynamic=" & Chr(34) & "1" & Chr(34) & " MaxRows = " & Chr(34) & "0" & Chr(34) & ">")
        i = 0
        For Each r As DataRow In rpt.dv.Table.Select("ma_tc ='3' and sysorder =5")
            stream.WriteLine("      <Cells>")

            If i = 0 Then
                stream.WriteLine("          <Cell CellID=" & Chr(34) & "C_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AU_" & (rowbigin + 10) & Chr(34) & " FirstCell=" & Chr(34) & "0" & Chr(34) & " Encode='0' Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & "" & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")

            Else
                stream.WriteLine("          <Cell CellID=" & Chr(34) & "C_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AU_" & (rowbigin + 10) & Chr(34) & " FirstCell=" & Chr(34) & "1" & Chr(34) & " Encode='0' Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & "" & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")

            End If
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "D_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "C_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("ky_hieu_hoa_don") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "E_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "E_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("so_seri").trim & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "F_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "G_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("so_hd").trim & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            If Not IsDBNull(r("ngay_hd")) Then
                stream.WriteLine("          <Cell CellID=" & Chr(34) & "G_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "M_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Strings.Format(r("ngay_hd"), "dd/MM/yyyy") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            Else
                stream.WriteLine("          <Cell CellID=" & Chr(34) & "G_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "M_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")

            End If
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "H_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "R_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("ten_kh").ToString.Trim.Replace("&", "&amp;").Replace(Chr(34), "&quot;").Replace("<", "&lt;") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "I_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "X_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("ma_so_thue").trim & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "J_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AB_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("ten_vt").trim.Replace("&", "&amp;").Replace(Chr(34), "&quot;").Replace("<", "&lt;") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "K_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AF_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Strings.Format(r("t_tien"), "0") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")

            If Not IsDBNull(r("thue_suat")) Then
                stream.WriteLine("          <Cell CellID=" & Chr(34) & "L_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AJ_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Strings.Format(r("thue_suat"), "0") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")

            Else
                stream.WriteLine("          <Cell CellID=" & Chr(34) & "L_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AJ_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & "0" & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")

            End If

            stream.WriteLine("          <Cell CellID=" & Chr(34) & "M_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AN_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Strings.Format(r("t_thue"), "0") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "N_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AR_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")


            stream.WriteLine("      </Cells>")


            rowbigin += 1
            i += 1
        Next

        stream.WriteLine("  </Section>")

        'tinh chat 4
        rowbigin = rowbigin + 4
        stream.WriteLine("  <Section Dynamic=" & Chr(34) & "1" & Chr(34) & " MaxRows = " & Chr(34) & "0" & Chr(34) & ">")
        i = 0
        For Each r As DataRow In rpt.dv.Table.Select("ma_tc ='4' and sysorder =5")
            stream.WriteLine("      <Cells>")

            If i = 0 Then
                stream.WriteLine("          <Cell CellID=" & Chr(34) & "C_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AU_" & (rowbigin + 10) & Chr(34) & " FirstCell=" & Chr(34) & "0" & Chr(34) & " Encode='0' Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & "" & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")

            Else
                stream.WriteLine("          <Cell CellID=" & Chr(34) & "C_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AU_" & (rowbigin + 10) & Chr(34) & " FirstCell=" & Chr(34) & "1" & Chr(34) & " Encode='0' Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & "" & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")

            End If
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "D_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "C_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("ky_hieu_hoa_don") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "E_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "E_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("so_seri").trim & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "F_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "G_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("so_hd").trim & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            If Not IsDBNull(r("ngay_hd")) Then
                stream.WriteLine("          <Cell CellID=" & Chr(34) & "G_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "M_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Strings.Format(r("ngay_hd"), "dd/MM/yyyy") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            Else
                stream.WriteLine("          <Cell CellID=" & Chr(34) & "G_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "M_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")

            End If
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "H_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "R_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("ten_kh").ToString.Trim.Replace("&", "&amp;").Replace(Chr(34), "&quot;").Replace("<", "&lt;") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "I_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "X_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("ma_so_thue").trim & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "J_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AB_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("ten_vt").trim.Replace("&", "&amp;").Replace(Chr(34), "&quot;").Replace("<", "&lt;") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "K_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AF_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Strings.Format(r("t_tien"), "0") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")

            If Not IsDBNull(r("thue_suat")) Then
                stream.WriteLine("          <Cell CellID=" & Chr(34) & "L_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AJ_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Strings.Format(r("thue_suat"), "0") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")

            Else
                stream.WriteLine("          <Cell CellID=" & Chr(34) & "L_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AJ_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & "0" & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")

            End If

            stream.WriteLine("          <Cell CellID=" & Chr(34) & "M_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AN_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Strings.Format(r("t_thue"), "0") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "N_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AR_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")


            stream.WriteLine("      </Cells>")


            rowbigin += 1
            i += 1
        Next

        stream.WriteLine("  </Section>")
        'tinh chat 5
        rowbigin = rowbigin + 4
        stream.WriteLine("  <Section Dynamic=" & Chr(34) & "1" & Chr(34) & " MaxRows = " & Chr(34) & "0" & Chr(34) & ">")
        i = 0
        For Each r As DataRow In rpt.dv.Table.Select("ma_tc ='5' and sysorder =5")
            stream.WriteLine("      <Cells>")

            If i = 0 Then
                stream.WriteLine("          <Cell CellID=" & Chr(34) & "C_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AU_" & (rowbigin + 10) & Chr(34) & " FirstCell=" & Chr(34) & "0" & Chr(34) & " Encode='0' Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & "" & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")

            Else
                stream.WriteLine("          <Cell CellID=" & Chr(34) & "C_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AU_" & (rowbigin + 10) & Chr(34) & " FirstCell=" & Chr(34) & "1" & Chr(34) & " Encode='0' Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & "" & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")

            End If
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "D_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "C_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("ky_hieu_hoa_don") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "E_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "E_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("so_seri").trim & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "F_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "G_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("so_hd").trim & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            If Not IsDBNull(r("ngay_hd")) Then
                stream.WriteLine("          <Cell CellID=" & Chr(34) & "G_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "M_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Strings.Format(r("ngay_hd"), "dd/MM/yyyy") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            Else
                stream.WriteLine("          <Cell CellID=" & Chr(34) & "G_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "M_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")

            End If
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "H_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "R_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("ten_kh").ToString.Trim.Replace("&", "&amp;").Replace(Chr(34), "&quot;").Replace("<", "&lt;") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "I_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "X_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("ma_so_thue").trim & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "J_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AB_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & r("ten_vt").trim.Replace("&", "&amp;").Replace(Chr(34), "&quot;").Replace("<", "&lt;") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "K_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AF_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Strings.Format(r("t_tien"), "0") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")

            If Not IsDBNull(r("thue_suat")) Then
                stream.WriteLine("          <Cell CellID=" & Chr(34) & "L_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AJ_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Strings.Format(r("thue_suat"), "0") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")

            Else
                stream.WriteLine("          <Cell CellID=" & Chr(34) & "L_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AJ_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & "0" & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")

            End If

            stream.WriteLine("          <Cell CellID=" & Chr(34) & "M_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AN_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Strings.Format(r("t_thue"), "0") & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")
            stream.WriteLine("          <Cell CellID=" & Chr(34) & "N_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AR_" & (rowbigin + 10) & Chr(34) & " Encode=""1"" Receive=" & Chr(34) & "1" & Chr(34) & " Value=" & Chr(34) & Chr(34) & " StatusID=" & Chr(34) & "0001" & Chr(34) & "/>")


            stream.WriteLine("      </Cells>")


            rowbigin += 1
            i += 1
        Next

        stream.WriteLine("  </Section>")
        'tong cong
        Dim t_dt As Double = 0, t_thue As Double = 0
        For Each r As DataRow In rpt.dv.Table.Select("sysorder =0")
            t_dt = r("t_tien")
            t_thue = r("t_thue")
        Next
        rowbigin = rowbigin + 12
        stream.WriteLine("  <Section Dynamic=" & Chr(34) & "0" & Chr(34) & " MaxRows = " & Chr(34) & "0" & Chr(34) & ">")
        stream.WriteLine("      <Cells>")
        stream.WriteLine("          <Cell CellID=" & Chr(34) & "K_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AF_" & (rowbigin + 6) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Value=" & Chr(34) & t_dt & Chr(34) & "/>")
        rowbigin = rowbigin + 1
        stream.WriteLine("          <Cell CellID=" & Chr(34) & "K_" & rowbigin & Chr(34) & " CellID2=" & Chr(34) & "AF_" & (rowbigin + 7) & Chr(34) & " Encode=" & Chr(34) & 1 & Chr(34) & " Value=" & Chr(34) & t_thue & Chr(34) & "/>")
        stream.WriteLine("      </Cells>")
        stream.WriteLine("  </Section>")
        'ket thuc
        stream.WriteLine("</Sections>")
        stream.Close()
        MsgBox("Chương trình đã thực hiện xong", , Me.Text)
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhtkkt.Click
        export2htkkt()
    End Sub
End Class
