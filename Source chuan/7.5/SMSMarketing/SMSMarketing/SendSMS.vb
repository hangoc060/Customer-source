Public Class SendSMS

    Private Sub btnConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfig.Click
        Dim f As New config
        f.ShowDialog(Me)
    End Sub
    Dim WithEvents serialPort As New System.IO.Ports.SerialPort

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        If txtNumber.Text.Trim = "" Then
            txtNumber.Focus()
            Return
        End If
        If txtMessage.Text.Trim = "" Then
            txtMessage.Focus()
            Return
        End If

        If serialPort.IsOpen Then
            serialPort.Close()
        End If
        serialPort.BaudRate = baudrate
        serialPort.PortName = port
        serialPort.NewLine = vbCrLf
        serialPort.Parity = IO.Ports.Parity.None
        serialPort.StopBits = IO.Ports.StopBits.One
        serialPort.DataBits = 8
        serialPort.Handshake = IO.Ports.Handshake.RequestToSend
        serialPort.DtrEnable = True
        serialPort.RtsEnable = True
        serialPort.Open()

        If serialPort.IsOpen Then
            serialPort.WriteLine("AT" & vbCrLf)
            serialPort.WriteLine("AT+CMGF=1" & vbCrLf)
            serialPort.WriteLine("AT+CMGS=" & Chr(34) & txtNumber.Text & Chr(34) & vbCrLf)
            serialPort.WriteLine(txtMessage.Text & vbCrLf & Chr(26))
            MsgBox("Tin nhắn đã được gửi", , "Send SMS")
            'serialPort.Close()
        Else
            MsgBox("Cổng " + port + " không có giá trị", MsgBoxStyle.Critical, "Send SMS")
        End If

    End Sub

    Private Sub serialPort_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles serialPort.DataReceived
        'Console.WriteLine(serialPort.ReadExisting)
        lblstatus.Text = serialPort.ReadExisting
    End Sub
End Class