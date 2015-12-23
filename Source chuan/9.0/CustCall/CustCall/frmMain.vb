Imports System.ComponentModel

Public Class frmMain
    Public udpclient As System.Net.Sockets.UdpClient
    Dim RemoteIpEndPoint As System.Net.IPEndPoint
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClsControl2.PropertyOfForm.SetICon4Control("phonebook.ico", Me)
        If Clsql.Reg.GetValue("id") = "" Then
            MsgBox("Bạn phải đăng nhập vào chương trình trước",, Clsql.AboutMe.Name)
            Application.Exit()
            Return
        End If
        lblstatus.Text = "Chương trình đang chạy tại cổng " & port
        RemoteIpEndPoint = New System.Net.IPEndPoint(System.Net.IPAddress.Any, port)
        Try
            udpclient = New Net.Sockets.UdpClient(RemoteIpEndPoint)
        Catch ex As Exception
            MsgBox(ex.Message)
            Application.Exit()
            Return
        End Try
        conn = New Clsql.SQL
        Dim threads As New Threading.Thread(AddressOf syncdata)
        threads.Start()
        ''load danh sach khach hang
        Dim ds As DataSet = ClsList.List1.load4local(list_id_permistion)
        If ds IsNot Nothing Then
            dtCust = ds.Tables(0)
        End If
        'load danh sach gia ban
        ds = ClsList.List1.load4local("dmgiaban")
        If ds IsNot Nothing Then
            dmgiaban = ds.Tables(0)
        End If
        'load loai khach hang
        ds_loaikh = ClsList.List1.load4local("dlkh")
        If ds_loaikh IsNot Nothing Then
            Dim r As DataRow = ds_loaikh.Tables(0).NewRow
            r("ma_loai_kh") = ""
            r("ten") = "<Chọn một loại khách hàng>"
            ds_loaikh.Tables(0).Rows.Add(r)
        End If



        'quan ly process
        Dim dsprocess As String = Clsql.Reg.GetValue("Processes")
        Try
            If dsprocess.Contains(Process.GetCurrentProcess.Id) Then
                dsprocess = dsprocess.Replace(Process.GetCurrentProcess.Id, "")
                Clsql.Reg.SetValue("Processes", dsprocess)
            End If
        Catch ex As Exception

        End Try

        Try
            ct_custcall = Clsql.Others.Options("ct_custcall", conn)
            Dim cs As String() = ct_custcall.Split("#")
            If cs.Length > 1 Then
                exe = cs(0)
                ma_ct = cs(1)
            Else
                exe = "vso1.exe"
                ma_ct = "SO1"
            End If
        Catch ex As Exception

        End Try
        'sync dmkh
        If IO.Directory.Exists(dirKH) Then
            For Each file As String In IO.Directory.GetFiles(dirKH)
                Try
                    Dim ds_o As New DataSet
                    ds_o.ReadXml(file)
                    Dim query As String = "delete from dkh where ma_kh='" & ds_o.Tables(0).Rows(0)("ma_kh") & "'"
                    query = query & Chr(13) & conn.GetInsertQueryFromDataRow(ds_o.Tables(0).Rows(0), "dkh")
                    conn.Execute(query)
                    conn.Execute("exec UpdateCustomer '" & ds_o.Tables(0).Rows(0)("ma_kh") & "','ADD'")
                    ds_o.Dispose()
                    IO.File.Delete(file)

                Catch ex As Exception
                    Exit For
                End Try

            Next
        End If
        'load history
        ds_history = New DataSet
        If IO.File.Exists(flog) Then
            Try
                ds_history.ReadXml(flog)
                'sync log call
                For Each r As DataRow In ds_history.Tables(0).Select("id=0")
                    Try
                        Dim query As String = conn.GetInsertQueryFromDataRow(r, "phonelog") & "; select SCOPE_IDENTITY()"
                        Dim id As Integer = conn.GetValue(query)
                        r("id") = id
                    Catch ex As Exception
                        Exit For
                    End Try
                Next
                ds_history.WriteXml(flog, XmlWriteMode.WriteSchema)
            Catch ex As Exception
                Try
                    ds_history = conn.GetDataSet("select top 10 a.*,b.ma_kh,b.ten_kh from phonelog a left join dkh b on a.dien_thoai = b.dien_thoai or a.dien_thoai = b.dien_thoai2  or a.dien_thoai = b.dien_thoai3  or a.dien_thoai = b.dien_thoai4  or a.dien_thoai = b.dien_thoai5 where a.nguoi_tao = '" & Clsql.Reg.GetValue("id") & "' order by a.ngay_tao desc")
                    ds_history.WriteXml(flog, XmlWriteMode.WriteSchema)
                Catch ex2 As Exception
                    Dim dt As New DataTable
                    'dien_thoai,ngay_tao,nguoi_tao,trang_thai,line
                    dt.Columns.Add("dien_thoai")
                    dt.Columns.Add("ma_kh")
                    dt.Columns.Add("ten_kh")
                    dt.Columns.Add("ngay_tao", GetType(DateTime))
                    dt.Columns.Add("bat_dau", GetType(DateTime))
                    dt.Columns.Add("ket_thuc", GetType(DateTime))
                    dt.Columns.Add("file_ghi_am")
                    dt.Columns.Add("nguoi_tao")
                    dt.Columns.Add("trang_thai")
                    dt.Columns.Add("line")
                    dt.Columns.Add("id")
                    dt.Columns.Add("id_tmp")
                    ds_history.Tables.Add(dt)
                End Try
            End Try

        Else
            Try
                ds_history = conn.GetDataSet("select top 10 a.*,b.ma_kh,b.ten_kh from phonelog a left join dkh b on a.dien_thoai = b.dien_thoai or a.dien_thoai = b.dien_thoai2  or a.dien_thoai = b.dien_thoai3  or a.dien_thoai = b.dien_thoai4  or a.dien_thoai = b.dien_thoai5 where a.nguoi_tao = '" & Clsql.Reg.GetValue("id") & "' order by a.ngay_tao desc")
                ds_history.WriteXml(flog, XmlWriteMode.WriteSchema)
            Catch ex As Exception
                Dim dt As New DataTable
                'dien_thoai,ngay_tao,nguoi_tao,trang_thai,line
                dt.Columns.Add("dien_thoai")
                dt.Columns.Add("ma_kh")
                dt.Columns.Add("ten_kh")
                dt.Columns.Add("ngay_tao", GetType(DateTime))
                dt.Columns.Add("bat_dau", GetType(DateTime))
                dt.Columns.Add("ket_thuc", GetType(DateTime))
                dt.Columns.Add("file_ghi_am")
                dt.Columns.Add("nguoi_tao")
                dt.Columns.Add("trang_thai")
                dt.Columns.Add("line")
                dt.Columns.Add("id")
                dt.Columns.Add("id_tmp")
                ds_history.Tables.Add(dt)
            End Try
        End If
        Dim y As Date = Now
        y = y.AddDays(-1)

        ds_history.Tables(0).DefaultView.RowFilter = "ngay_tao>=#" & Strings.Format(y, "yyyy-MM-dd") & "#"
        DataGridView1.DataSource = ds_history.Tables(0)
        DataGridView1.BackgroundColor = Color.White
        For Each col As DataGridViewColumn In DataGridView1.Columns
            col.Visible = False
        Next

        DataGridView1.Columns("dien_thoai").HeaderText = "Số điện thoại"
        DataGridView1.Columns("dien_thoai").Visible = True
        DataGridView1.Columns("dien_thoai").Width = 150

        DataGridView1.Columns("ten_kh").HeaderText = "Khách hàng"
        DataGridView1.Columns("ten_kh").Width = 300
        DataGridView1.Columns("ten_kh").Visible = True

        DataGridView1.Columns("ngay_tao").HeaderText = "Thời gian gọi"
        DataGridView1.Columns("ngay_tao").Width = 200
        DataGridView1.Columns("ngay_tao").Visible = True
        ' DataGridView1.Columns("bat_dau").HeaderText = "Thời gian nhấc máy"
        'DataGridView1.Columns("bat_dau").Visible = True
        'DataGridView1.Columns("ket_thuc").HeaderText = "Thời gian kết thúc"
        'DataGridView1.Columns("ket_thuc").Visible = True
        DataGridView1.Columns("line").HeaderText = "line"
        DataGridView1.Columns("line").Width = 30
        DataGridView1.Columns("line").Visible = True
        'phieu xuat tam
        dt_px8tmp = New DataTable
        dt_px8tmp.Columns.Add("stt_rec_tmp")
        dt_px8tmp.Columns.Add("ma_kh")
        dt_px8tmp.Columns.Add("ten_kh")
        dt_px8tmp.Columns.Add("dia_chi")
        dt_px8tmp.Columns.Add("dien_thoai")
        dt_px8tmp.Columns.Add("so_ct")
        dt_px8tmp.Columns.Add("id_call_tmp")
        dt_px8tmp.Columns.Add("ngay_ct", GetType(Date))
        dt_px8tmp.Columns.Add("nguoi_tao")
        dt_px8tmp.Columns.Add("ngay_tao")
        dt_px8tmp.Columns.Add("t_tien")
        dt_px8tmp.Columns.Add("t_ck")
        dt_px8tmp.Columns.Add("t_tt")

        If IO.Directory.Exists(dirData) Then
            For Each f As String In IO.Directory.GetFiles(dirData)
                Try
                    Dim dstmp As New DataSet
                    dstmp.ReadXml(f)
                    Clsql.Data.CopyTable(dstmp.Tables(0), dt_px8tmp, "1=1", "1=0")
                Catch ex As Exception

                End Try

            Next
        End If
        gridpx8tmp.BackgroundColor = Color.White
        gridpx8tmp.AllowUserToDeleteRows = False
        gridpx8tmp.AllowUserToAddRows = False
        ClsControl2.PropertyOfGrid.FillGrid(conn, "mpx8tmp", gridpx8tmp, dt_px8tmp.DefaultView)

        Dim thread As New Threading.Thread(AddressOf receivemessage)
        thread.Start()
        thread.IsBackground = True


    End Sub
    Sub syncdata()
        ClsList.List1.Save2Local(list_id_permistion)
        ClsList.List1.Save2Local("dlkh")
        ClsList.List1.Save2Local("dmvt")
        'ClsList.List1.Save2Local("dmgiaban")
        ClsList.List1.Save2Local("dmnhvt",, "loai_nhom=1")
        Try
            Dim ma_kho As String = conn.GetValue("select ext_number from dmnsd where id='" & Clsql.Reg.GetValue("id") & "'")
            If ma_kho = "" Then
                ClsList.List1.Save2Local("dmgiaban",, "gia_ban_le<>0 and trang_thai=1 and cast(getdate() as date) between tu_ngay and den_ngay")
            Else
                ClsList.List1.Save2Local("dmgiaban",, "gia_ban_le<>0 and trang_thai=1 and (ma_kho ='' or dbo.einstr('" & ma_kho.Trim & "',ma_kho) =1) and cast(getdate() as date) between tu_ngay and den_ngay")
            End If

        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try

        Dim ds As DataSet = ClsList.List1.load4local(list_id_permistion)
        If ds IsNot Nothing Then
            dtCust = ds.Tables(0)
        End If
        ds = ClsList.List1.load4local("dmgiaban")
        If ds IsNot Nothing Then
            dmgiaban = ds.Tables(0)
        End If
    End Sub
    Private Sub NotifyIcon1_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Maximized
        Me.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        e.Cancel = True
        Me.WindowState = FormWindowState.Minimized
        'Me.Hide()
    End Sub

    Private dic_id As New Dictionary(Of String, String)
    Private Delegate Sub invokeAddTab(line As String, dien_thoai As String, id_call As String, row As DataRow)
    Private Sub addTab(line As String, dien_thoai As String, id_call As String, row As DataRow)

        If TabControl1.InvokeRequired Then
            Dim invoker As New invokeAddTab(AddressOf addTab)
            Me.Invoke(invoker, line, dien_thoai, id_call, row)
            Return
        End If

        Dim tab As TabPage = Nothing
        For Each t As TabPage In TabControl1.TabPages
            If t.Name = line Then
                tab = t
                tab.Controls.Clear()
                Exit For
            End If
        Next

        If tab Is Nothing Then
            tab = New TabPage
            tab.Name = line
            TabControl1.TabPages.Add(tab)
        End If
        tab.Text = "Line: " & line & "- Phone: " & dien_thoai
        Dim cust As New customer
        cust.row = row
        cust.getCustomer(dien_thoai, id_call)

        cust.Dock = DockStyle.Fill
        tab.Controls.Add(cust)

        TabControl1.SelectedTab = tab
        Me.Show()
        Me.WindowState = FormWindowState.Maximized
        Me.Activate()

    End Sub
    Sub addRow(row)
        If DataGridView1.InvokeRequired Then
            DataGridView1.Invoke(New addDelegate(AddressOf addRow), row)
            Return
        End If
        ds_history.Tables(0).Rows.InsertAt(row, 0)

        Dim _7_days As Date = Now
        _7_days = _7_days.AddDays(-7)

        For Each r As DataRow In ds_history.Tables(0).Select("ngay_tao <=#" & Strings.Format(_7_days, "yyyy-MM-dd") & "#")
            r.Delete()
        Next
        ds_history.Tables(0).AcceptChanges()
        ds_history.WriteXml(flog, XmlWriteMode.WriteSchema)
    End Sub
    Private Delegate Sub updateDelegate(id_tmp As String, value As Dictionary(Of String, Object))
    Sub updateRow(id_tmp As String, value As Dictionary(Of String, Object))
        If DataGridView1.InvokeRequired Then
            DataGridView1.Invoke(New updateDelegate(AddressOf updateRow), id_tmp, value)
            Return
        End If
        For Each r As DataRow In ds_history.Tables(0).Select("id_tmp='" & id_tmp & "'")
            For Each key As String In value.Keys
                r(key) = value.Item(key)
            Next
        Next
        ds_history.AcceptChanges()
        ds_history.WriteXml(flog, XmlWriteMode.WriteSchema)
    End Sub
    Private Delegate Sub addDelegate(row As DataRow)
    Delegate Sub wl(msg As String)
    Sub writelog(msg As String)
        If RichTextBox1.InvokeRequired Then
            RichTextBox1.Invoke(New wl(AddressOf writelog), msg)
            Return
        End If
        RichTextBox1.AppendText(Chr(13))
        RichTextBox1.AppendText(msg)
    End Sub
    Dim user As String = Nothing
    Private Sub receivemessage()
        If udpclient Is Nothing Then
            Return
        End If
        If user Is Nothing Then
            user = Clsql.Reg.GetValue("id")
        End If
        Dim receiveBytes As [Byte]() = udpclient.Receive(RemoteIpEndPoint)
        Dim strReturnData As String = System.Text.Encoding.UTF8.GetString(receiveBytes)
        writelog(strReturnData)
        Dim ct As String()
        Dim dien_thoai As String = Nothing
        ' Dim trang_thai As String = ct(0)
        Dim trang_thai As String = 1 '1: goi den,2-miss,3-nhac may,4-hoan thanh,5-khong nghe may,6-hoan thanh
        Dim line As String
        If strReturnData.StartsWith("<CRMV1") AndAlso strReturnData.Contains(">") Then
            strReturnData = strReturnData.Split(">")(0)
            trang_thai = 1
            ct = strReturnData.Split(" ")

            Dim i As Integer = 0
            For Each v As String In ct
                If v.Trim <> "" Then
                    If i = 1 Then
                        line = v
                    Else
                        If i = 4 Then
                            dien_thoai = v
                        End If
                    End If
                    i += 1
                End If
            Next
        Else
            ct = strReturnData.Split(",")
            If ct.Length > 1 Then
                dien_thoai = ct(1)
                trang_thai = ct(ct.Length - 2) '1: goi den,2-miss,3-nhac may,4-hoan thanh,5-khong nghe may,6-hoan thanh
                line = ct(ct.Length - 3)
            End If
        End If


        If dien_thoai IsNot Nothing Then
            'write log
            Dim id_tmp As String
            Select Case trang_thai
                Case "1"
                    id_tmp = user & Strings.Format(Now, "yyyyMMddHHmmss")
                    'cuoc goi den
                    Dim query As String = "insert into phonelog(dien_thoai,ngay_tao,nguoi_tao,trang_thai,line,id_tmp) values('" + dien_thoai + "',getdate(),'" + Clsql.Reg.GetValue("id") + "','" + trang_thai + "','" & line & "','" & id_tmp & "'); select SCOPE_IDENTITY()"

                    Dim row As DataRow = ds_history.Tables(0).NewRow

                    row("dien_thoai") = dien_thoai
                    row("ngay_tao") = Now 'conn.Server.GetDate
                    row("nguoi_tao") = user
                    row("trang_thai") = trang_thai
                    row("line") = line
                    row("id_tmp") = id_tmp

                    Try
                        Dim id As Integer = conn.GetValue(query)
                        row("id") = id
                    Catch ex As Exception
                        row("id") = 0
                    End Try

                    addRow(row)


                    If dic_id.ContainsKey(line) Then
                        dic_id.Item(line) = id_tmp
                    Else
                        dic_id.Add(line, id_tmp)
                    End If

                    If dic_id.ContainsKey(line & "_" & dien_thoai) Then
                        dic_id.Item(line & "_" & dien_thoai) = id_tmp
                    Else
                        dic_id.Add(line & "_" & dien_thoai, id_tmp)
                    End If

                    'show info of customer
                    If dien_thoai <> "" Then

                        addTab(line, dien_thoai, id_tmp, row)
                    End If

                    Exit Select
                Case "2" 'miss
                    If dic_id.ContainsKey(line & "_" & dien_thoai) Then
                        id_tmp = dic_id.Item(line & "_" & dien_thoai)
                        Dim query As String = "update phonelog set trang_thai='" & trang_thai & "',ket_thuc = getdate() where  id_tmp='" & id_tmp & "'"
                        Try
                            conn.Execute(query)
                        Catch ex As Exception
                        End Try
                        Dim values As New Dictionary(Of String, Object)
                        values.Add("trang_thai", trang_thai)
                        values.Add("ket_thuc", Now)
                        updateRow(id_tmp, values)
                    End If

                    Exit Select
                Case "3" 'received
                    If dic_id.ContainsKey(line & "_" & dien_thoai) Then
                        id_tmp = dic_id.Item(line & "_" & dien_thoai)
                        Dim query As String = "update phonelog set trang_thai='" & trang_thai & "',bat_dau = getdate() where  id_tmp='" & id_tmp & "'"
                        Try
                            conn.Execute(query)
                        Catch ex As Exception
                        End Try
                        Dim values As New Dictionary(Of String, Object)
                        values.Add("trang_thai", trang_thai)
                        values.Add("bat_dau", Now)
                        updateRow(id_tmp, values)
                    End If

                    Exit Select
                Case "4" 'finised
                    If dic_id.ContainsKey(line & "_" & dien_thoai) Then
                        id_tmp = dic_id.Item(line & "_" & dien_thoai)
                        Dim query As String = "update phonelog set ket_thuc = getdate() where  id_tmp='" & id_tmp & "'"
                        Try
                            conn.Execute(query)
                        Catch ex As Exception
                        End Try
                        Dim values As New Dictionary(Of String, Object)
                        values.Add("ket_thuc", Now)
                        updateRow(id_tmp, values)
                    End If
                    Exit Select
                Case "5" 'no answer
                    If dic_id.ContainsKey(line & "_" & dien_thoai) Then
                        id_tmp = dic_id.Item(line & "_" & dien_thoai)
                        Dim query As String = "update phonelog set trang_thai='" & trang_thai & "',ket_thuc = getdate() where id_tmp='" & id_tmp & "'"
                        Try
                            conn.Execute(query)
                        Catch ex As Exception
                        End Try
                        Dim values As New Dictionary(Of String, Object)
                        values.Add("trang_thai", trang_thai)
                        values.Add("ket_thuc", Now)
                        updateRow(id_tmp, values)
                    End If
                    Exit Select
                Case "6" 'record
                    If dic_id.ContainsKey(line) Then
                        id_tmp = dic_id.Item(line)
                        Dim query As String = "update phonelog set file_ghi_am='" & dien_thoai & "' where id_tmp='" & id_tmp & "'"
                        Try
                            conn.Execute(query)
                        Catch ex As Exception
                        End Try
                        Dim values As New Dictionary(Of String, Object)
                        values.Add("file_ghi_am", dien_thoai)
                        updateRow(id_tmp, values)
                    End If
                    Exit Select
            End Select




        End If
        Dim thread As New Threading.Thread(AddressOf receivemessage)
        thread.Start()
        thread.IsBackground = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        syncdata()
    End Sub

    'Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
    '    Dim min As Boolean = False

    '    'if minimized button was pressed
    '    If Me.WindowState = FormWindowState.Minimized = True Then
    '        min = True

    '        'undo minimize
    '        Me.WindowState = FormWindowState.Normal
    '    End If

    '    If min Then
    '        Me.Hide()
    '    End If
    'End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim row As DataRow = DataGridView1.Rows(e.RowIndex).DataBoundItem.row
        addTab(row("line"), row("dien_thoai"), row("id_tmp"), row)
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        If gridpx8tmp.CurrentRow IsNot Nothing Then
            If MsgBox("Có chắc chắn xóa phiếu này không?", MsgBoxStyle.YesNo, Clsql.AboutMe.Name) = MsgBoxResult.Yes Then
                Try
                    Dim f As String = dirData & "\" & gridpx8tmp.CurrentRow.Cells("stt_rec_tmp").Value & ".xml"
                    If IO.File.Exists(f) Then
                        IO.File.Delete(f)
                    End If
                    gridpx8tmp.Rows.Remove(gridpx8tmp.CurrentRow)
                Catch ex As Exception
                    MsgBox("Không thể xóa phiếu này",, Clsql.AboutMe.Name)
                End Try
            End If
        End If
    End Sub



    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        dt_px8tmp.Rows.Clear()
        If IO.Directory.Exists(dirData) Then
            For Each f As String In IO.Directory.GetFiles(dirData)
                Try
                    Dim dstmp As New DataSet
                    dstmp.ReadXml(f)
                    Clsql.Data.CopyTable(dstmp.Tables(0), dt_px8tmp, "1=1", "1=0")
                Catch ex As Exception

                End Try

            Next
        End If
    End Sub

    Private Sub btneditorder_Click(sender As Object, e As EventArgs) Handles btneditorder.Click
        If gridpx8tmp.CurrentRow IsNot Nothing Then
            Dim stt_rec_tmp As String = gridpx8tmp.CurrentRow.Cells("stt_rec_tmp").Value
            If IO.File.Exists(dirData & "\" & stt_rec_tmp & ".xml") Then
                Dim f As New frmordertmp
                f.id_call_tmp = gridpx8tmp.CurrentRow.Cells("id_call_tmp").Value
                f.txtma_kh.Text = gridpx8tmp.CurrentRow.Cells("ma_kh").Value
                f.lblten_kh.Text = gridpx8tmp.CurrentRow.Cells("ten_kh").Value
                f.dia_chi = gridpx8tmp.CurrentRow.Cells("dia_chi").Value
                f.dien_thoai = gridpx8tmp.CurrentRow.Cells("dien_thoai").Value
                f.Icon = Me.FindForm.Icon
                f.StartPosition = FormStartPosition.CenterScreen
                f.edit(stt_rec_tmp)
            Else
                MsgBox("Phiếu này đã được xóa hoặc xử lý",, Clsql.AboutMe.Name)
            End If

        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub btnfilter_Click(sender As Object, e As EventArgs) Handles btnfilter.Click
        ds_history.Tables(0).DefaultView.RowFilter = "dien_thoai like '%" & txtfilter.Text & "%' or ten_kh like '%" & txtfilter.Text & "%'"
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim so_dien_thoai As String = InputBox("Nhập số điện thoại", "Thêm mới một khách hàng")
        If so_dien_thoai <> "" Then
            Dim id_tmp As String = user & Strings.Format(Now, "yyyyMMddHHmmss")
            'cuoc goi den
            Dim row As DataRow = ds_history.Tables(0).NewRow
            Dim line As Integer = 9
            row("dien_thoai") = so_dien_thoai
            row("ngay_tao") = Now 'conn.Server.GetDate
            row("nguoi_tao") = user
            row("trang_thai") = 1
            row("line") = line
            row("id_tmp") = id_tmp
            row("id") = 0
            addRow(row)

    
            If dic_id.ContainsKey(line) Then
                dic_id.Item(line) = id_tmp
            Else
                dic_id.Add(line, id_tmp)
            End If

            If dic_id.ContainsKey(line & "_" & so_dien_thoai) Then
                dic_id.Item(line & "_" & so_dien_thoai) = id_tmp
            Else
                dic_id.Add(line & "_" & so_dien_thoai, id_tmp)
            End If

            'show info of customer
            If so_dien_thoai <> "" Then

                addTab(line, so_dien_thoai, id_tmp, row)
            End If
        End If
    End Sub
End Class