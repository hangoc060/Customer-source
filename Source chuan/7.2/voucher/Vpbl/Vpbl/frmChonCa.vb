Imports ClsStpService

Public Class frmChonCa
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cbbma_kho.SelectedValue Is Nothing Then
            MsgBox("Bạn phải chọn một kho", MsgBoxStyle.Critical, Me.Text)
            Return
        End If
        If cbbso_may.SelectedValue Is Nothing Then
            MsgBox("Bạn phải chọn một quầy bán hàng", MsgBoxStyle.Critical, Me.Text)
            Return
        End If
        If cbbso_ca.SelectedValue Is Nothing Then
            MsgBox("Bạn phải chọn một ca bán hàng", MsgBoxStyle.Critical, Me.Text)
            Return
        End If

        DialogResult = Windows.Forms.DialogResult.OK
        My.Settings.kho_mac_dinh = cbbma_kho.SelectedValue
        My.Settings.quay_mac_dinh = cbbso_may.SelectedValue
        My.Settings.baudrate = txtbaundrate.Value
        My.Settings.Save()
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub login_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClsControl2.PropertyOfForm.KeyEnter(Me)
        cbbCOM.DropDownStyle = ComboBoxStyle.DropDownList
        For Each n As String In My.Computer.Ports.SerialPortNames
            cbbCOM.Items.Add(n)
        Next
        If My.Computer.Ports.SerialPortNames.Count > 0 Then
            cbbCOM.SelectedIndex = 0
        End If
        txtbaundrate.Value = My.Settings.baudrate
        Try
            Dim kho_mac_dih As String = My.Settings.kho_mac_dinh
            If kho_mac_dih <> "" Then
                cbbma_kho.SelectedValue = kho_mac_dih
            End If
            If IsDBNull(cbbma_kho.SelectedValue) Then
                cbbma_kho.SelectedIndex = 0
            End If
            '
            Dim quay_mac_dinh As String = My.Settings.quay_mac_dinh
            If quay_mac_dinh <> "" Then
                cbbso_may.SelectedValue = quay_mac_dinh
            End If
            If IsDBNull(cbbso_may.SelectedValue) Then
                cbbso_may.SelectedIndex = 0
            End If
        Catch ex As Exception

        End Try
        
    End Sub

    

    Private Sub cbbma_kho_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbbma_kho.SelectedValueChanged
        
        Try
            cbbso_may.DataSource = Nothing
            Dim query As String = "select ma_may,ten_may from dmmaybanle where ma_kho ='" & cbbma_kho.SelectedValue & "' and (isnull(computer_name,'') ='' or computer_name ='" & Environment.MachineName & "')"
            ClsLookup.AddItems.AddItemCbb(conn, query, cbbso_may, "ten_may", "ma_may")
        Catch ex As Exception

        End Try

    End Sub
End Class

