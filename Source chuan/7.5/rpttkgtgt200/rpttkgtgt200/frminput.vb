
Public Class frminput

    Private Sub cbbmcal_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbbkind.SelectedValueChanged
        Try
            Select Case cbbkind.SelectedValue
                Case 0
                    ptinh_theo_tk.Enabled = False
                    txtcach_tinh.Enabled = True
                    txttk_no.Text = ""
                    txttk_co.Text = ""
                Case 1
                    ptinh_theo_tk.Enabled = True
                    txtcach_tinh.Enabled = False
                    txtcach_tinh.Text = ""
                    txtma_thue.Enabled = False
                    txtma_tc.Enabled = False
                    chbthue_suat.Enabled = False
                    cbbdbf.SelectedValue = ""
                    cbbdbf.Enabled = False
                Case 2
                    ptinh_theo_tk.Enabled = True
                    txtcach_tinh.Enabled = False
                    txtcach_tinh.Text = ""

                    txtma_thue.Enabled = True
                    txtma_tc.Enabled = True
                    chbthue_suat.Enabled = True

                    cbbdbf.Enabled = True
            End Select

        Catch ex As Exception

        End Try

       

    End Sub


End Class