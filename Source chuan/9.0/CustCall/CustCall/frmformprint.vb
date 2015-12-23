Public Class frmformprint
    Dim oPrint As ClPrint.Print
    Public Dataset2print As DataSet
    Private Sub frmformprint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        oPrint = New ClPrint.Print(conn, "PX8TMP", cbbform, txttitle)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        oPrint.Dataset = Dataset2print
        oPrint.Print()
    End Sub

    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        oPrint.Dataset = Dataset2print
        oPrint.RefreshReport()
        oPrint.PrintRPT.ShowDialog(Me)
    End Sub
End Class