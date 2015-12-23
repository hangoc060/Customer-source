Imports System.IO
Public Class frminput

    Private Sub frminput_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.txtten_tl.Focus()
        luu_file = Nothing
    End Sub

    'Luu duong dan va file vao database
    Private Sub btnduyet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnduyet.Click
        OpenFileDialog1.FileName = "" 'Hiển thị chuỗi rỗng trên ô File name trong hộp thoại
        OpenFileDialog1.Filter = "All files (*.*)|*.*|File doc (*.doc)|*.doc|File txt (*.txt)|*.txt"
        OpenFileDialog1.InitialDirectory = "D:\" 'Thu muc mac dinh khi mo ra
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim ten As New FileInfo(OpenFileDialog1.FileName)
            Me.txtfile_dk.Text = ten.Name    'Lay ten file dien vao Textbox
            luu_file = Clsql.Data.GetByteOfFile(ten.FullName) 'luu file vao bien luu_file
            Me.txtnoi_dung.Focus()
        End If
    End Sub
End Class