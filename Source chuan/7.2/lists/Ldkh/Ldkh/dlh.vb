Public Class dlh
    Private Sub frminput_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.txtten_nguoi_lien_he.Focus()
    End Sub
    Private Sub dlh_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim gt As String = list_lh.oLable("011")
        Dim dt As New DataTable
        dt.Columns.Add("gioi_tinh")
        dt.Columns.Add("ten_gioi_tinh")
        Dim loai As Integer = 0
        For Each g As String In gt.Split("/")
            Dim r As DataRow
            r = dt.NewRow
            r(0) = loai
            r(1) = g
            dt.Rows.Add(r)
            loai += 1
        Next
        cbbgioi_tinh.DataSource = dt
        cbbgioi_tinh.DisplayMember = "ten_gioi_tinh"
        cbbgioi_tinh.ValueMember = "gioi_tinh"
        cbbgioi_tinh.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub
End Class