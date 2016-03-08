Public Class FormHoaDon
    Dim sqlConnect As New Class1
    Private Sub LoadSanPham()
        LvHD.Items.Clear()
        Dim dt As DataTable = sqlConnect.GetDataTable("Select * from HoaDon")

        For i As Integer = 0 To dt.Rows.Count - 1 Step 1
            Dim item As New ListViewItem(LvHD.Items.Count + 1)

            item.SubItems.Add(dt.Rows(i).ItemArray(0))
            item.SubItems.Add(dt.Rows(i).ItemArray(3))
            item.SubItems.Add(dt.Rows(i).ItemArray(1))
            item.SubItems.Add(dt.Rows(i).ItemArray(2))
            LvHD.Items.Add(item)
        Next

    End Sub

    Private Sub BtThem_Click(sender As Object, e As EventArgs) Handles BtThem.Click
        sqlConnect.ExecuteNoneQuery("Insert into HoaDon(MaHD,MaSP,NgayMua,TongTien) values(" + TbMaHD.Text + "," + TbMaSP.Text + "," + TbNgayM.Text + "," + TbTT.Text + ")")
        LoadSanPham()
    End Sub

    Private Sub BtXoa_Click(sender As Object, e As EventArgs) Handles BtXoa.Click
        For i As Integer = LvHD.SelectedIndices.Count - 1 To 0 Step -1
            Dim viTriCanXoa As Integer = LvHD.SelectedIndices(i)
            Dim tenCanXoa As String = LvHD.Items(viTriCanXoa).SubItems(1).Text
            sqlConnect.ExecuteNoneQuery("Delete from HoaDon where MaHD = N'" + tenCanXoa + "'")

        Next
        LoadSanPham()
    End Sub

    Private Sub BtSua_Click(sender As Object, e As EventArgs) Handles BtSua.Click
        For i As Integer = LvHD.SelectedIndices.Count - 1 To 0 Step -1
            Dim vitricansua As Integer = LvHD.SelectedIndices(i)
            Dim macansua As String = LvHD.Items(vitricansua).SubItems(1).Text
            sqlConnect.ExecuteNoneQuery("update HoaDon set MaSP=" & TbMaSP.Text & ", NgayMua=" & TbNgayM.Text & ", TongTien=" & TbTT.Text & " where MaHD=" & macansua & "")
        Next
        LoadSanPham()
    End Sub

    Private Sub BtThoat_Click(sender As Object, e As EventArgs) Handles BtThoat.Click
        Close()
    End Sub

    Private Sub LvHD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LvHD.SelectedIndexChanged
        If LvHD.SelectedItems.Count = 1 Then
            For Each List As ListViewItem In LvHD.SelectedItems

                TbMaHD.Text = List.SubItems(1).Text
                TbMaSP.Text = List.SubItems(2).Text
                TbNgayM.Text = List.SubItems(3).Text
                TbTT.Text = List.SubItems(4).Text

            Next
        End If
    End Sub

    Private Sub FormHoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSanPham()
    End Sub
End Class