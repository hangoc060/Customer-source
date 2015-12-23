Public Class frmThuTien

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If txttien_nt.Value <= 0 Then
            txttien_nt.Focus()
            MsgBox("Bạn chưa vào số tiền thu đợt này", MsgBoxStyle.Critical, Me.Text)
            Return
        End If
        If txtma_nt.Text = "" Then
            txtma_nt.Focus()
            MsgBox("Bạn chưa nhập loại tiền thu", MsgBoxStyle.Critical, Me.Text)
            Return
        End If
        My.Settings.Save()
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

   
    Private Sub frmThuTien_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClsControl2.PropertyOfForm.KeyEnter(Me)
        Dim query As String = "select * from dbo.EdCust('131'"
        query = query & "," & conn.ConvertToSQLType(txtma_kh.Text)
        query = query & "," & conn.ConvertToSQLType(conn.Server.GetDate)
        query = query & "," & conn.ConvertToSQLType(Clsql.Reg.GetValue("unit"))
        query = query & ")"
        Dim dt As DataTable = conn.GetDatatable(query)
        If dt.Rows.Count = 1 Then
            Txtt_tien_pt.Value = dt.Rows(0).Item("du") + txttien.Value
        End If
        'set lookup 
        Dim ma_nvuLookup As New ClsLookup.AutoCompleteLookup(conn, "dmnvu", txtma_nvu, "ma_nvu")
        ma_nvuLookup.oKey = "tk_no like '111%' and tk_co like '131%' and dbo.einstr('PT1',ma_ct)=1"
        Dim ma_ntLookup As New ClsLookup.AutoCompleteLookup(conn, "dmnt", txtma_nt, "ma_nt")
        If conn.Lang = Clsql.SQL.Language.Vietnamese Then
            ma_nvuLookup.SetValue("ten_nvu", ten_nvu)
        Else
            ma_nvuLookup.SetValue("ten_nvu2", ten_nvu)
        End If
        txtma_nvu.Text = My.Settings.ma_nvu
    End Sub

    Dim oldvalue As Decimal = 0

    Private Sub txttien_nt_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txttien_nt.Enter, txtty_gia.Enter
        oldvalue = sender.value
    End Sub

    Private Sub txttien_nt_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txttien_nt.Validated, txtty_gia.Validated
        If oldvalue <> sender.value Then
            txttien.Value = txttien_nt.Value * txtty_gia.Value
        End If
    End Sub
End Class