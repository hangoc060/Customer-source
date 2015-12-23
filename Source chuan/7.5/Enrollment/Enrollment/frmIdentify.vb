Imports Futronic.SDKHelper
Imports System.Text
Imports System.Media
Imports System.Data

Public Class frmIdentify
    Dim Users As List(Of DbRecord)
    Dim finished As Boolean = False
    Dim ds As New DataSet
    Dim tb As New DataTable
    Dim path_data As String

    Private Sub frmIdentify_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        
    End Sub
    Private Sub frmIdentify_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        If IO.File.Exists(m_DatabaseDir & "/restart") Then
            IO.File.Delete(m_DatabaseDir & "/restart")
        End If
        lblstatus.Text = "Đang tải dữ liệu..."
        Users = DbRecord.ReadRecords(m_DatabaseDir)
        lblstatus.Text = ""
        If Users.Count = 0 Then
            MsgBox("Không tìm thấy học viên nào đã đăng ký. Hãy đăng ký dấu vẫn tay trong danh mục học viên trước", , "STP")
            Me.Close()
        End If
        '

        tb.Columns.Add("ma_nv", GetType(String))
        tb.Columns.Add("ma_bh", GetType(String))
        tb.Columns.Add("ngay_tao", GetType(DateTime))
        ds.Tables.Add(tb)
        If Not IO.Directory.Exists(m_DatabaseDir & "/" & baihoc) Then
            IO.Directory.CreateDirectory(m_DatabaseDir & "/" & baihoc)
        End If

        path_data = m_DatabaseDir & "/" & baihoc & "/" & Strings.Format(Now, "yyyyMMddHHmmss") & ".xml"

        '
        Timer1.Start()
        identity()
    End Sub
    Private Sub identity()
        finished = False
        SetUserText("Đang chờ...")
        UpdateScreenImage(Nothing)
        m_OperationObj = Users
        If m_Operation IsNot Nothing Then
            m_Operation.Dispose()
            m_Operation = Nothing
        End If
        m_Operation = New FutronicIdentification()

        ' Set control property
        m_Operation.FakeDetection = False
        m_Operation.FFDControl = True
        m_Operation.FARN = 166


        AddHandler m_Operation.OnPutOn, AddressOf OnPutOn
        AddHandler m_Operation.OnTakeOff, AddressOf OnTakeOff
        AddHandler m_Operation.UpdateScreenImage, AddressOf UpdateScreenImage
        AddHandler DirectCast(m_Operation, FutronicIdentification).OnGetBaseTemplateComplete, AddressOf OnGetBaseTemplateComplete

        DirectCast(m_Operation, FutronicIdentification).GetBaseTemplate()
    End Sub
    Private Sub OnPutOn(Progress As FTR_PROGRESS)
        lblstatus.Text = ("Đặt ngón tay vào máy quét vân tay ...")
    End Sub

    Private Sub OnTakeOff(Progress As FTR_PROGRESS)
        lblstatus.Text = ("Bỏ ngón tay ra khỏi máy quét vân tay ...")
    End Sub

    Private Sub UpdateScreenImage(hBitmap As Bitmap)
        If PictureBox1.InvokeRequired Then
            Dim d As New SetImageCallback(AddressOf Me.UpdateScreenImage)
            Me.Invoke(d, New Object() {hBitmap})
        Else
            PictureBox1.Image = hBitmap
        End If
    End Sub
    Dim g As Integer = 0
    Private Sub OnGetBaseTemplateComplete(bSuccess As Boolean, nRetCode As Integer)
        g = g + 1
        Dim szMessage As New StringBuilder()
        If bSuccess Then
            lblstatus.Text = ("Starting identification...")
            Dim Users As List(Of DbRecord) = DirectCast(m_OperationObj, List(Of DbRecord))

            Dim iRecords As Integer = 0
            Dim nResult As Integer
            Dim rgRecords As FtrIdentifyRecord() = New FtrIdentifyRecord(Users.Count - 1) {}
            For Each item As DbRecord In Users
                rgRecords(iRecords) = item.GetRecord()
                iRecords += 1
            Next
            nResult = DirectCast(m_Operation, FutronicIdentification).Identification(rgRecords, iRecords)
            If nResult = FutronicSdkBase.RETCODE_OK Then
                szMessage.Append("OK.")
                If iRecords <> -1 Then
                    SystemSounds.Asterisk.Play()
                    Dim r As DataRow = tb.NewRow
                    r("ma_nv") = Users(iRecords).UserName
                    r("ma_bh") = baihoc
                    r("ngay_tao") = Now
                    tb.Rows.Add(r)
                    ds.WriteXml(path_data, XmlWriteMode.WriteSchema)
                    SetUserText(Users(iRecords).UserName)
                Else
                    SetUserText("Không tìm thấy")
                End If
            Else
                szMessage.Append("Không thể xác thực.")
                'szMessage.Append("Code " & nResult & ":" & FutronicSdkBase.SdkRetCode2Message(nResult))
            End If
            ' Me.SetIdentificationLimit(m_Operation.IdentificationsLeft)
        Else
            szMessage.Append("Lỗi: Không thể mở máy quét vân tay. Kiểm tra máy quét vân tay rồi nhấn nút 'Mở máy quét' để thử lại")
            'szMessage.Append(FutronicSdkBase.SdkRetCode2Message(nRetCode))

        End If
        If g = 3 Then
            Dim dsrestart As New DataSet
            dsrestart.WriteXml(m_DatabaseDir & "/restart")
            dsrestart.Dispose()
            Me.Close()
            Return
        End If
        lblstatus.Text = (szMessage.ToString())
        m_OperationObj = Nothing
        Threading.Thread.Sleep(1000)
        finished = True
    End Sub

    Private Sub SetUserText(text As String)
        If Me.lblNhanVien.InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf Me.SetUserText)
            Me.Invoke(d, New Object() {text})
        Else
            Me.lblNhanVien.Text = text
            Me.Update()
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnRestart.Click
        identity()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As System.EventArgs) Handles Timer1.Tick
        If finished Then
            identity()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://saotienphong.com.vn")
    End Sub
End Class