Public Class qtluong
    Public _grd As System.Windows.Forms.DataGridView
    Dim oldluong_nd, oldluong_thuc, oldhslcb As Double

    Private Sub qtluong_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = list_qtluong.oLable("000") + ": " + _grd.Item("ma_nv", _grd.CurrentRow.Index).Value + " - " + _grd.Item("ten_nv", _grd.CurrentRow.Index).Value
    End Sub

    Private Sub qtluong_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.txtngay_hl.Focus()
        '
        If chbluong_nd_yn.Checked = True Then
            txtluong_nd.ReadOnly = False
        Else
            txtluong_nd.ReadOnly = True
        End If
        '
        If chbluong_thuc_yn.Checked = True Then
            txtluong_thuc.ReadOnly = False
        Else
            txtluong_thuc.ReadOnly = True
        End If
        '

        If chbhslcb_yn.Checked = True Then
            txthslcb.ReadOnly = False
        Else
            txthslcb.ReadOnly = True
        End If
        '
        oldhslcb = txthslcb.Value
        oldluong_nd = txtluong_nd.Value
        oldluong_thuc = txtluong_thuc.Value
    End Sub



    Private Sub chbluong_thuc_yn_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chbluong_thuc_yn.CheckStateChanged
        If chbluong_thuc_yn.Checked = True Then
            txtluong_thuc.ReadOnly = False
        Else
            txtluong_thuc.ReadOnly = True
            txtluong_thuc.Value = oldluong_thuc

        End If

    End Sub
    Private Sub chbhslcb_yn_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chbhslcb_yn.CheckStateChanged

        If chbhslcb_yn.Checked = True Then
            txthslcb.ReadOnly = False
        Else
            txthslcb.ReadOnly = True
            txthslcb.Value = oldhslcb

        End If
    End Sub


    Private Sub chbluong_nd_yn_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chbluong_nd_yn.CheckStateChanged
        If chbluong_nd_yn.Checked = True Then
            txtluong_nd.ReadOnly = False
        Else
            txtluong_nd.ReadOnly = True
            txtluong_nd.Value = oldluong_nd

        End If
    End Sub

    Private Sub chbluong_ngay_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbluong_ngay.CheckedChanged
        chbluong_thang.Checked = Not (chbluong_ngay.Checked)
    End Sub

    Private Sub chbluong_thang_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbluong_thang.CheckedChanged
        chbluong_ngay.Checked = Not (chbluong_thang.Checked)
    End Sub
End Class