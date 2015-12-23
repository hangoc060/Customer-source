Public Class frmselector
    Private Sub frmselector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ds As DataSet = ClsList.List1.load4local("dmvt")
        DataGridView1.DataSource = ds.Tables(0)
    End Sub
End Class