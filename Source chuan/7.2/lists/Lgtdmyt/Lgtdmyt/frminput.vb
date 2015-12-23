Public Class frminput



    Private Sub frminput_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.txtma_yt.Focus()
    End Sub

   
    
    Private Sub frminput_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtcong_tru.Minimum = 1
        txtcong_tru.Maximum = 2
        txtgt_ps.Minimum = 1
        txtgt_ps.Maximum = 2

        If chbpb_ytcp.Checked Then
            groupytcp.Enabled = True
        Else
            groupytcp.Enabled = False
        End If
    End Sub

    Private Sub radiophanbotheoytcp_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chbpb_ytcp.CheckedChanged
        If chbpb_ytcp.Checked Then
            groupytcp.Enabled = True
        Else
            txths_yt.Text = ""
            groupytcp.Enabled = False
        End If
    End Sub

    Private Sub chbpb_ytcp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chbpb_ytcp.Click
        If chbpb_ytcp.Checked Then
            groupytcp.Enabled = True
        Else
            txths_yt.Text = ""
            groupytcp.Enabled = False
        End If
    End Sub
End Class