Public Class frminput



    Private Sub frminput_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.txttieu_de.Focus()
    End Sub

   
    
    Private Sub Linkdoc_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Linkdoc.LinkClicked

        If Linkdoc.Tag = "add" Then
            Dim path As String = Application.StartupPath & "\zLdmtl.exe"
            Dim argus As String = "dmtl <!add>"
            Dim p As Process = Process.Start(path, argus)
            p.WaitForExit()
            Dim iddoc As String = Clsql.Reg.GetValue("list_add_item")

            If iddoc IsNot Nothing AndAlso iddoc <> "" Then
                Linkdoc.Tag = iddoc
                Dim query As String = "select file_dk from dmtl where ma_tl ='" & iddoc & "'"
                Linkdoc.Text = conn.GetValue(query)
                LinkDelete.Visible = True
            End If
        Else
            Dim query As String = "select dinh_kem from dmtl where ma_tl ='" & Linkdoc.Tag & "'"
            Clsql.Data.OpenFileFromDB(conn.GetValue(query), Linkdoc.Text)
        End If
    End Sub

    Private Sub LinkDelete_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkDelete.LinkClicked
        Dim path As String = Application.StartupPath & "\zLdmtl.exe"
        If Linkdoc.Tag <> "add" Then
            Dim argus As String = "dmtl <!delete> ma_tl:" & Linkdoc.Tag
            Dim p As Process = Process.Start(path, argus)
            p.WaitForExit()
            Linkdoc.Text = "Thêm mới"
            Linkdoc.Tag = "add"
            LinkDelete.Visible = False
        End If
        
    End Sub
End Class