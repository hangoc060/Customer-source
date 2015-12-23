Imports ClsLookup

Public Class frminput
    ' Dim ty_gia_cu As Double
    Dim isloaded As Boolean = False

    Private Sub frminput_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If isloaded = False Then
            Me.txtso_ct.Focus()
            Me.txtso_ct.SelectionStart = txtso_ct.Text.Length
        End If
    End Sub

    Private Sub frminput_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        isloaded = False
        For Each dvtab As ClsSV31.TabDetail20 In Voucher.Tabdetails.Values
            RemoveHandler dvtab.AfterCalcOnCell, AddressOf tinh_tong_tien
        Next
    End Sub

    Private Sub frminput_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        For Each dvtab As ClsSV31.TabDetail20 In Voucher.Tabdetails.Values
            AddHandler dvtab.AfterCalcOnCell, AddressOf tinh_tong_tien
        Next

    End Sub

    Private Sub frminput_show(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Try
            Dim dvr As DataRowView = cbbma_nt.SelectedItem

            hide_show_control(dvr("ma_nt"))
            isloaded = True
            If Voucher.Action = ClsSV31.Voucher20.Actions.ADD Then
                Txtty_gia.Value = conn.GetValue("exec getty_gia " & conn.ConvertToSQLType(cbbma_nt.SelectedValue.trim) & "," & conn.ConvertToSQLType(Txtngay_ct.Value))
                Voucher.BindingSource.EndEdit()
            End If
        Catch ex As Exception

        End Try
       
    End Sub
#Region "lay ty gia tu dong"
    Dim ngay_ctold As Date
    Private Sub Txtngay_ct_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtngay_ct.Validated
        If ngay_ctold <> Txtngay_ct.Value Then
            If isloaded Then
                If Voucher.Action = ClsSV31.Voucher20.Actions.ADD Then
                    Txtty_gia.Value = conn.GetValue("exec getty_gia " & conn.ConvertToSQLType(cbbma_nt.SelectedValue.trim) & "," & conn.ConvertToSQLType(Txtngay_ct.Value))
                End If
            End If
        End If
    End Sub
    Private Sub Txtngay_ct_endter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtngay_ct.Enter
        ngay_ctold = Txtngay_ct.Value
    End Sub
#End Region
    
    Private Sub btnLuu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLuu.Click
        If save() = False Then
            Exit Sub
        End If

        formtask.btnnew.Enabled = Voucher.rights.NewRight
        If formtask.btncopy.Enabled = True Then
            formtask.btncopy.Enabled = Voucher.rights.NewRight
        End If
        formtask.btnprint.Enabled = Voucher.rights.PrintRight

        formtask.ShowDialog(Me)
        Select Case formtask.task
            Case ClsSV31.frmTask.Tasks.AddNew
                Me.BindingContext(Voucher.BindingSource).EndCurrentEdit()
                Voucher.Mdatatable.AcceptChanges()
                Voucher.News2()
            Case ClsSV31.frmTask.Tasks.Copy
                Voucher.Copy()
            Case ClsSV31.frmTask.Tasks.Print
                For Each r As DataRow In Voucher.Mdatatable.Select("sel=true")
                    r("sel") = False
                Next
                Voucher.BindingSource.Current("sel") = True
                oPrint.Print()
                Me.Close()
            Case ClsSV31.frmTask.Tasks.Close
                Me.DialogResult = DialogResult.OK
                Me.Close()
        End Select
    End Sub
    Function save() As Boolean
        'kiem tra so chung tu
        Try
            If Voucher.CheckSoCT(Txtngay_ct.Value, txtso_ct.Text) = False Then
                Return False
                Exit Function
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Voucher.BindingSource.EndEdit()
        'kiem tra nhap lieu
        If Voucher.CheckKeyIn = False Then
            Return False
        End If
        Voucher.SynMD()
        If Voucher.Action = 1 Then
            Voucher.Insert()
        Else
            Voucher.Update()
        End If
        'post
        ClsSV31.Functions.Post(conn, Voucherid, Voucher.Mviewname, Voucher.Stt_rec, cbbstatus.SelectedValue)

        Return True
    End Function
  

    Dim t_tien, t_thue, t_tt, t_sl, t_tien_von, t_tien_nt, t_thue_nt, t_tt_nt, t_sl_nt, t_tien_von_nt As Double
    Sub tinh_tong_tien()

        If isloaded = False Then
            Return
        End If

        t_tien_nt = ClsControl2.PropertyOfGrid.Sum(Voucher.Tabdetails(Voucher.TabFirst).gridDetailKeyin, "tien_nt")
        t_tien = ClsControl2.PropertyOfGrid.Sum(Voucher.Tabdetails(Voucher.TabFirst).gridDetailKeyin, "tien")

        t_thue_nt = ClsControl2.PropertyOfGrid.Sum(Voucher.Tabdetails("vvatvao").gridDetailKeyin, "t_thue_nt")
        t_thue = ClsControl2.PropertyOfGrid.Sum(Voucher.Tabdetails("vvatvao").gridDetailKeyin, "t_thue")

        t_tt_nt = t_tien_nt + t_thue_nt
        t_tt = t_tien + t_thue
        '
        Txtt_tien_nt.Value = t_tien_nt
        Txtt_tien.Value = t_tien

        txtt_thue_nt.Value = t_thue_nt
        txtt_thue.Value = t_thue

        txtt_tt_nt.Value = t_tt_nt
        txtt_tt.Value = t_tt


    End Sub
    
    Private Sub btnluuandmoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnluuandmoi.Click
        If save() = False Then
            Exit Sub
        End If
        Me.BindingContext(Voucher.BindingSource).EndCurrentEdit()
        Voucher.Mdatatable.AcceptChanges()
        Voucher.News2()
        'Dim dvr As DataRowView = cbbma_nt.SelectedItem
        Txtty_gia.Value = conn.GetValue("exec getty_gia " & conn.ConvertToSQLType(cbbma_nt.SelectedValue.trim) & "," & conn.ConvertToSQLType(Txtngay_ct.Value))
        txtso_ct.Focus()
    End Sub

    Private Sub btnhuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhuy.Click
        'If Voucher.Action = ClsSV31.Voucher20.Actions.ADD Then
        '    Voucher.Mdatatable.Rows.Remove(Voucher.CurrentVoucher)
        'End If
        isloaded = False
    End Sub


    Private Sub cbbma_nt_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbbma_nt.SelectedValueChanged
        If isloaded = False Then
            Exit Sub
        End If
        Try
            TabControl1.SelectedTab = TabControl1.TabPages(0)
            If cbbma_nt.SelectedItem IsNot Nothing Then
                Dim dvr As DataRowView = cbbma_nt.SelectedItem

                Txtty_gia.Value = conn.GetValue("exec getty_gia " & conn.ConvertToSQLType(cbbma_nt.SelectedValue.trim) & "," & conn.ConvertToSQLType(Txtngay_ct.Value))
                hide_show_control(dvr("ma_nt"))
            End If

        Catch ex As Exception

        End Try
    End Sub

   


    Sub hide_show_control(ByVal ma_nt As String)
        For Each t As ClsSV31.TabDetail20 In Voucher.Tabdetails.Values
            t.ma_nt = ma_nt
        Next

        If ma_nt.Trim.ToUpper = ma_nt_ht.Trim.ToUpper Then
           

            Txtty_gia.ReadOnly = True
            Txtt_tien.Hide() 'Visible = False
            txtt_thue.Hide() 'Visible = False
            txtt_tt.Hide() 'Visible = False

            Txtt_tien_nt.NumberDecimalDigits = Clsql.Others.Options("f_tien", conn)
            txtt_thue_nt.NumberDecimalDigits = Clsql.Others.Options("f_tien", conn)
            txtt_tt_nt.NumberDecimalDigits = Clsql.Others.Options("f_tien", conn)
        Else

            Txtty_gia.ReadOnly = False
            Txtt_tien.Show() 'Visible = True
            txtt_thue.Show() 'Visible = True
            txtt_tt.Show() 'Visible = True
            Txtt_tien_nt.NumberDecimalDigits = Clsql.Others.Options("f_tien_nt", conn)
            txtt_thue_nt.NumberDecimalDigits = Clsql.Others.Options("f_tien_nt", conn)
            txtt_tt_nt.NumberDecimalDigits = Clsql.Others.Options("f_tien_nt", conn)
            tinh_tong_tien()
        End If

    End Sub

End Class