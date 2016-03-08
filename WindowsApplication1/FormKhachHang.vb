Public Class FormKhachHang
    Dim sqlConnect As New Class1
    Private Sub LoadSanPham()
        LvKH.Items.Clear()
        Dim dt As DataTable = sqlConnect.GetDataTable("Select * from KhachHang")

        For i As Integer = 0 To dt.Rows.Count - 1 Step 1
            Dim item As New ListViewItem(LvKH.Items.Count + 1)

            item.SubItems.Add(dt.Rows(i).ItemArray(0))
            item.SubItems.Add(dt.Rows(i).ItemArray(1))
            item.SubItems.Add(dt.Rows(i).ItemArray(2))
            item.SubItems.Add(dt.Rows(i).ItemArray(3))
            item.SubItems.Add(dt.Rows(i).ItemArray(4))
            item.SubItems.Add(dt.Rows(i).ItemArray(5))
            LvKH.Items.Add(item)
        Next

    End Sub

    Private Sub Bt4_Click(sender As Object, e As EventArgs) Handles Bt4.Click
        Close()
    End Sub

    Private Sub Bt1_Click(sender As Object, e As EventArgs) Handles Bt1.Click
        sqlConnect.ExecuteNoneQuery("Insert into KhachHang(MaKH,TenKH,SDT,GioiTinh,DiaChi,MaSP) values(" + TbMaKH.Text + ",N'" + TbTenKH.Text + "'," + TbSDT.Text + ",N'" + TbGioiTinh.Text + "',N'" + TbDiaChi.Text + "'," + TbMaSP.Text + ")")
        LoadSanPham()
    End Sub

    Private Sub Bt3_Click(sender As Object, e As EventArgs) Handles Bt3.Click
        For i As Integer = LvKH.SelectedIndices.Count - 1 To 0 Step -1
            Dim viTriCanXoa As Integer = LvKH.SelectedIndices(i)
            Dim tenCanXoa As String = LvKH.Items(viTriCanXoa).SubItems(1).Text
            sqlConnect.ExecuteNoneQuery("Delete from KhachHang where MaKH = N'" + tenCanXoa + "'")

        Next
        LoadSanPham()
    End Sub

    Private Sub Bt2_Click(sender As Object, e As EventArgs) Handles Bt2.Click
        For i As Integer = LvKH.SelectedIndices.Count - 1 To 0 Step -1
            Dim vitricansua As Integer = LvKH.SelectedIndices(i)
            Dim macansua As String = LvKH.Items(vitricansua).SubItems(6).Text
            sqlConnect.ExecuteNoneQuery("update KhachHang set TenKH=N'" & TbTenKH.Text & "', SDT=" & TbSDT.Text & ", GioiTinh=N'" & TbGioiTinh.Text & "', DiaChi=N'" & TbDiaChi.Text & "', MaSP=" & TbMaSP.Text & " where MaKH=" & macansua & "")
        Next
        LoadSanPham()
    End Sub

    Private Sub LvKH_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LvKH.SelectedIndexChanged
        If LvKH.SelectedItems.Count = 1 Then
            For Each List As ListViewItem In LvKH.SelectedItems

                TbMaKH.Text = List.SubItems(1).Text
                TbTenKH.Text = List.SubItems(2).Text
                TbSDT.Text = List.SubItems(3).Text
                TbGioiTinh.Text = List.SubItems(4).Text
                TbDiaChi.Text = List.SubItems(5).Text
                TbMaSP.Text = List.SubItems(6).Text
            Next
        End If
    End Sub

    Private Sub BtLoad_Click(sender As Object, e As EventArgs) Handles BtLoad.Click
        LoadSanPham()
    End Sub
End Class
