Imports System.IO
Imports System.Text
Imports Futronic.SDKHelper

Public Class DbRecord
    Public Sub New()
        m_UserName = [String].Empty
        ' Generate user's unique identifier
        m_Key = Guid.NewGuid().ToByteArray()
        m_Template = Nothing
    End Sub

    Public Sub New(szFileName As String)
        If szFileName Is Nothing Then
            Throw New ArgumentNullException("szFileName")
        End If
        Load(szFileName)
    End Sub

    Private Sub Load(szFileName As String)
        Using fileStream As New FileStream(szFileName, FileMode.Open)
            Dim utfEncoder As New UTF8Encoding()
            Dim Data As Byte() = Nothing

            ' Read user name length and user name in UTF8
            If fileStream.Length < 2 Then
                Throw New InvalidDataException([String].Format("Bad file {0}", fileStream.Name))
            End If
            Dim nLength As Integer = (fileStream.ReadByte() << 8) Or fileStream.ReadByte()
            Data = New Byte(nLength - 1) {}
            If nLength <> fileStream.Read(Data, 0, nLength) Then
                Throw New InvalidDataException([String].Format("Bad file {0}", fileStream.Name))
            End If
            m_UserName = utfEncoder.GetString(Data)

            ' Read user unique ID
            m_Key = New Byte(15) {}
            If fileStream.Read(m_Key, 0, 16) <> 16 Then
                Throw New InvalidDataException([String].Format("Bad file {0}", fileStream.Name))
            End If

            ' Read template length and template data
            If (fileStream.Length - fileStream.Position) < 2 Then
                Throw New InvalidDataException([String].Format("Bad file {0}", fileStream.Name))
            End If
            nLength = (fileStream.ReadByte() << 8) Or fileStream.ReadByte()
            m_Template = New Byte(nLength - 1) {}
            If fileStream.Read(m_Template, 0, nLength) <> nLength Then
                Throw New InvalidDataException([String].Format("Bad file {0}", fileStream.Name))
            End If
        End Using
    End Sub

    Public Function Save(szFileName As String) As Boolean
        If File.Exists(szFileName) Then
            File.Delete(szFileName)
        End If
        If m_Template Is Nothing OrElse m_UserName = [String].Empty Then
            Throw New InvalidOperationException()
        End If
        Dim fileStream As New FileStream(szFileName, FileMode.Create)
        Dim utfEncoder As New UTF8Encoding()
        Dim Data As Byte() = Nothing

        ' Save user name
        Data = utfEncoder.GetBytes(m_UserName)
        FileStream.WriteByte(CByte((Data.Length >> 8) And &HFF))
        FileStream.WriteByte(CByte(Data.Length And &HFF))
        FileStream.Write(Data, 0, Data.Length)

        ' Save user unique ID
        FileStream.Write(m_Key, 0, m_Key.Length)

        ' Save user template
        FileStream.WriteByte(CByte((m_Template.Length >> 8) And &HFF))
        FileStream.WriteByte(CByte(m_Template.Length And &HFF))
        FileStream.Write(m_Template, 0, m_Template.Length)
        FileStream.Close()


        Return True
    End Function

    Public Function GetRecord() As FtrIdentifyRecord
        Dim item As FtrIdentifyRecord
        item.KeyValue = m_Key
        item.Template = m_Template

        Return item
    End Function

    ''' <summary>
    ''' Get or set the user name.
    ''' </summary>
    Public Property UserName() As [String]
        Get
            Return m_UserName
        End Get

        Set(value As [String])
            m_UserName = value
        End Set
    End Property

    ''' <summary>
    ''' Get or set the user template.
    ''' </summary>
    Public Property Template() As Byte()
        Get
            Return m_Template
        End Get

        Set(value As Byte())
            m_Template = value
        End Set
    End Property

    ''' <summary>
    ''' Get the user unique identifier.
    ''' </summary>
    Public ReadOnly Property UniqueID() As Byte()
        Get
            Return m_Key
        End Get
    End Property

    Public Shared Function ReadRecords(szDbDir As [String]) As List(Of DbRecord)
        Dim Users As New List(Of DbRecord)(10)

        If Not Directory.Exists(szDbDir) Then
            Throw New DirectoryNotFoundException([String].Format("The folder {0} is not found", szDbDir))
        End If
        Dim rgFiles As String() = Directory.GetFiles(szDbDir, "*")
        If rgFiles Is Nothing OrElse rgFiles.Length = 0 Then
            Return Users
        End If

        For iFiles As Integer = 0 To rgFiles.Length - 1
            Try
                Dim User As New DbRecord(rgFiles(iFiles))
                Users.Add(User)
                ' The user's information has invalid data. Skip it and continue processing.
            Catch generatedExceptionName As InvalidDataException
            End Try
        Next

        Return Users
    End Function

    ''' <summary>
    ''' User name
    ''' </summary>
    Private m_UserName As [String]

    ''' <summary>
    ''' User unique key
    ''' </summary>
    Private m_Key As Byte()

    ''' <summary>
    ''' Finger template.
    ''' </summary>
    Private m_Template As Byte()
End Class