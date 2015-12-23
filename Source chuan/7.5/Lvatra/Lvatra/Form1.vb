Imports Clsql
Imports ClsControl2
Imports ClsLookup
Public Class Frmmain
    Dim listid As String = Clsql.Others.GetArgu(1)
    Dim ma_ct As String = Clsql.Others.GetArgu(2)
    Dim WithEvents list As ClsList.List
    Dim vcno As ClsVno.SttRec
    Dim frmin As New sp
    Dim dkloc As New dkloc
    Dim strdkloc As String = ""
    'Dim dk As New dkloc
    Private Sub dmload(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ClsControl2.PropertyOfForm.CheckRegister = False Then
            Me.Close()
        End If

        list = New ClsList.List(listid, btnNew, btnEdit, btnDel, frmin.btnLuu, frmin.btnhuy, grd, frmin, True, "1=0")
        list.CSearch = "ma_ct ='" & ma_ct & "'"
        vcno = New ClsVno.SttRec(list.conn, ma_ct)

        setlookup()

        PropertyOfForm.SetImage4Control("find.bmp", btnfind)
        PropertyOfForm.SetImage4Control("user.bmp", lbluser)
        lbluser.Text = Reg.GetValue("ID")
        lblma_dvcs.Text = list.conn.GetValue("select ten_dvcs from ddv where ma_dvcs ='" & Clsql.Reg.GetValue("unit") & "'")
        PropertyOfForm.SetLable(list.oLable, Me)
        Me.Icon = frmin.Icon
        PropertyOfForm.SetLable(list.oLable, dkloc)
        dkloc.Icon = frmin.Icon
        PropertyOfForm.KeyEnter(dkloc)


        'load du lieu
        Select Case Clsql.Others.GetArgu(1)
            Case "L"
                strdkloc = Clsql.Others.GetArgu(2)
                If strdkloc = "" Then
                    strdkloc = "1=1"
                End If
                list.SetData(strdkloc)
            Case Else
                If dkloc.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    getdk()
                Else
                    Me.Close()
                End If
        End Select
        'format 

    End Sub

    Private Sub thoat(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuthoat.Click
        list = Nothing
        Me.Close()
    End Sub

   

    Private Sub btnfind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfind.Click
        If dkloc.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            getdk()
        End If
    End Sub
    Sub getdk()
        strdkloc = " ngay_hd between " & list.conn.ConvertToSQLType(dkloc.Txttu_ngay.Value) & " and " & list.conn.ConvertToSQLType(dkloc.Txtden_ngay.Value)
        list.SetData(strdkloc)
    End Sub
    Sub setlookup()
        Dim oNCC As New ClsLookup.AutoCompleteLookup(list.conn, "dmkh", frmin.txtma_kh, "ma_kh")
        oNCC.SetValue("ten_kh", frmin.txtten_kh)
        oNCC.SetValue("dia_chi", frmin.txtdia_chi)
        oNCC.SetValue("ma_so_thue", frmin.txtma_so_thue)
       
        Dim omadvcs As New ClsLookup.AutoCompleteLookup(list.conn, "dmdv", frmin.txtma_dvcs, "ma_dvcs")
        omadvcs.SetValue("ten_dvcs", frmin.ten_dvcs)

        Dim oma_thue As New ClsLookup.AutoCompleteLookup(list.conn, "dmvat", frmin.txtma_thue, "ma_thue")
        oma_thue.SetValue("ten_thue", frmin.ten_thue)
        oma_thue.SetValue("thue_suat", frmin.Txtthue_suat)
        oma_thue.SetValue("tk_thue_co", frmin.txttk_thue_co)

        Dim otk_thue As New ClsLookup.AutoCompleteLookup(list.conn, "dmtk", frmin.txttk_thue_co, "tk")
        otk_thue.SetValue("ten_tk", frmin.ten_tk_thue)

        Dim otk_du As New ClsLookup.AutoCompleteLookup(list.conn, "dmtk", frmin.txttk_du, "tk")
        otk_du.SetValue("ten_tk", frmin.ten_tk_du)

    End Sub
   
   

    Private Sub list_AfterAddItem(ByVal e As System.Data.DataRow) Handles list.AfterAddItem
        vcno.UpdateSttRec()
    End Sub

    Private Sub list_BeforeAddItem() Handles list.BeforeAddItem
        Dim valuedf As New Collection
        valuedf.Add("5", "status")
        valuedf.Add(vcno.GetNextSttRec, "stt_rec")
        valuedf.Add(ma_ct, "ma_ct")
        list.ValueDefaults = valuedf
    End Sub
End Class
