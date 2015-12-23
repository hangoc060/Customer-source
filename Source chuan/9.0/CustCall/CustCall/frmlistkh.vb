Public Class frmlistkh
    Public row_selected As DataRow
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        row_selected = DataGridView1.Rows(e.RowIndex).DataBoundItem.row
        DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub frmlistkh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim l As New ClsList.List1(list_id_permistion, DataGridView1, Me)
        'l.AddToolStripFind(ToolStrip1)
        ClsControl2.PropertyOfGrid.FillGrid(conn, "dkh", DataGridView1, dtCust.DefaultView)
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False

    End Sub

    Private Sub txtfilter_TextChanged(sender As Object, e As EventArgs) Handles txtfilter.TextChanged
        Dim dien_thoai As String = txtfilter.Text
        dtCust.DefaultView.RowFilter = "dien_thoai like '%" & dien_thoai & "' or dien_thoai2 like '%" & dien_thoai & "' or dien_thoai3 like '%" & dien_thoai & "' or dien_thoai4 like '%" & dien_thoai & "' or dien_thoai5 like '%" & dien_thoai & "'"
    End Sub
End Class