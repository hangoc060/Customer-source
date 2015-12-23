Public Class config

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DialogResult = Windows.Forms.DialogResult.OK
        If cbbPort.Text = "" Then
            MsgBox("Bạn phải chọn một cổng COM", MsgBoxStyle.Critical, "Cấu hình cổng COM")
            Return
        End If
        port = cbbPort.Text
        baudrate = txtbaudrate.Value
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        dt.Columns.Add("port")
        dt.Columns.Add("baudrate")
        Dim r As DataRow = dt.NewRow
        r.Item("port") = port
        r.Item("baudrate") = baudrate
        dt.Rows.Add(r)
        ds.AcceptChanges()
        ds.WriteXml(path)
        ds.Dispose()
        Me.Close()
    End Sub

    Private Sub config_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each port As String In System.IO.Ports.SerialPort.GetPortNames
            cbbPort.Items.Add(port)
        Next
        cbbPort.Text = port
        If cbbPort.Items.Count > 0 And cbbPort.Text = "" Then
            cbbPort.SelectedIndex = 0
        End If

        txtbaudrate.Value = baudrate

    End Sub
End Class
