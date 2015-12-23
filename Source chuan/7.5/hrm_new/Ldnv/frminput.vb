Imports ClsLookup
Imports Clsql

Public Class frminput


    Private Sub frminput_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.Txtma_nv.Focus()
    End Sub


    Private Sub txttu_gio_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txttu_gio.Validated, txtden_gio.Validated
        Dim tu_gio, tu_phut, den_gio, den_phut As Integer
        tu_gio = CType(txttu_gio.Text.Substring(0, 2), Integer)

        tu_phut = CType(txttu_gio.Text.Substring(3), Integer)

        den_gio = CType(txtden_gio.Text.Substring(0, 2), Integer)

        den_phut = CType(txtden_gio.Text.Substring(3), Integer)

        txtgio.Value = ((den_gio * 60 + den_phut) - (tu_gio * 60 + tu_phut)) \ 60
        txtphut.Value = ((den_gio * 60 + den_phut) - (tu_gio * 60 + tu_phut)) - txtgio.Value * 60


    End Sub

  
End Class