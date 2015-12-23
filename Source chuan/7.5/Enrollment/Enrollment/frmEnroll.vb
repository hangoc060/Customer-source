Imports System.IO
Imports Futronic.SDKHelper
Imports System.Text
Imports System.Media

Public Class frmEnroll


    Delegate Sub closeform()
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblNhanVien.Text = UserName
        Timer1.Interval = 10
        Timer1.Start()
        btnEnrollment.PerformClick()
    End Sub

    Private Sub btnEnrollment_Click(sender As System.Object, e As System.EventArgs) Handles btnEnrollment.Click
        Dim User As DbRecord = New DbRecord()
        CreateFile(UserName)
        User.UserName = UserName
        m_OperationObj = User


        If m_Operation IsNot Nothing Then
            m_Operation.Dispose()
            m_Operation = Nothing
        End If

        m_Operation = New FutronicEnrollment()

        m_Operation.FakeDetection = False
        m_Operation.FFDControl = True
        m_Operation.FARN = 166

        DirectCast(m_Operation, FutronicEnrollment).MaxModels = 3

        AddHandler m_Operation.OnPutOn, AddressOf OnPutOn
        AddHandler m_Operation.OnTakeOff, AddressOf OnTakeOff
        AddHandler m_Operation.UpdateScreenImage, AddressOf UpdateScreenImage
        AddHandler DirectCast(m_Operation, FutronicEnrollment).OnEnrollmentComplete, AddressOf OnEnrollmentComplete
        DirectCast(m_Operation, FutronicEnrollment).Enrollment()
    End Sub
    Protected Sub CreateFile(UserName As String)
        Dim szFileName As String = m_DatabaseDir
        If Not IO.Directory.Exists(szFileName) Then
            IO.Directory.CreateDirectory(szFileName)
        End If
        szFileName = Path.Combine(Application.StartupPath, UserName)
        File.Create(szFileName).Close()
        File.Delete(szFileName)


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
    Private saved As Boolean = False
    Private Sub OnEnrollmentComplete(bSuccess As Boolean, nRetCode As Integer)
        Dim szMessage As New StringBuilder()
        If bSuccess Then
            ' set status string
            szMessage.Append("Đăng ký đã thành công.")
            lblstatus.Text = (szMessage.ToString())

            ' Set template into user's information and save it
            Dim User As DbRecord = DirectCast(m_OperationObj, DbRecord)
            User.Template = DirectCast(m_Operation, FutronicEnrollment).Template

            Dim szFileName As [String] = Path.Combine(m_DatabaseDir, User.UserName)
            If Not User.Save(szFileName) Then
                MessageBox.Show("Không thể lưu thông tin đăng ký tới file " & szFileName, "STP", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                SystemSounds.Asterisk.Play()
                saved = True

            End If
        Else
            szMessage.Append("Lỗi: Không thể mở máy quét vân tay. Kiểm tra máy quét vân tay rồi nhấn nút 'Mở máy quét' để thử lại")
            'szMessage.Append("Lỗi: ")
            'szMessage.Append(FutronicSdkBase.SdkRetCode2Message(nRetCode))
            'szMessage.Append("Cắm máy quét vân tay vào máy tính và nhấn nút 'Mở máy quét' để thử lại")
            lblstatus.Text = (szMessage.ToString())
        End If
        m_OperationObj = Nothing
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As System.EventArgs) Handles Timer1.Tick
        If saved Then
            Timer1.Stop()
            MsgBox("Đã đăng ký thành công", , "STP")
            DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://saotienphong.com.vn")
    End Sub
End Class
