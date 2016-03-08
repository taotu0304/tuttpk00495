Public Class FormCTHD
    Dim sqlConnect As New Class1
    Private Sub LoadSanPham()
        LvCTHD.Items.Clear()
        Dim dt As DataTable = sqlConnect.GetDataTable("Select * from CTHD")

        For i As Integer = 0 To dt.Rows.Count - 1 Step 1
            Dim item As New ListViewItem(LvCTHD.Items.Count + 1)

            item.SubItems.Add(dt.Rows(i).ItemArray(0))
            item.SubItems.Add(dt.Rows(i).ItemArray(1))
            item.SubItems.Add(dt.Rows(i).ItemArray(2))
            item.SubItems.Add(dt.Rows(i).ItemArray(3))
            item.SubItems.Add(dt.Rows(i).ItemArray(3))
            LvCTHD.Items.Add(item)
        Next

    End Sub

    Private Sub BtThem_Click(sender As Object, e As EventArgs) Handles BtThem.Click
        sqlConnect.ExecuteNoneQuery("Insert into CTHD(MaCTHD,MaKH,DonGia,SoLuong,MaHD) values(" + TbMaCTHD.Text + "," + TbMaKH.Text + "," + TbDonGia.Text + "," + TbSoLuong.Text + "," + TbMaHD.Text + ")")
        LoadSanPham()
    End Sub

    Private Sub BtXoa_Click(sender As Object, e As EventArgs) Handles BtXoa.Click
        For i As Integer = LvCTHD.SelectedIndices.Count - 1 To 0 Step -1
            Dim viTriCanXoa As Integer = LvCTHD.SelectedIndices(i)
            Dim tenCanXoa As String = LvCTHD.Items(viTriCanXoa).SubItems(1).Text
            sqlConnect.ExecuteNoneQuery("Delete from CTHD where MaCTHD = N'" + tenCanXoa + "'")

        Next
        LoadSanPham()
    End Sub

    Private Sub BtSua_Click(sender As Object, e As EventArgs) Handles BtSua.Click
        For i As Integer = LvCTHD.SelectedIndices.Count - 1 To 0 Step -1
            Dim vitricansua As Integer = LvCTHD.SelectedIndices(i)
            Dim macansua As String = LvCTHD.Items(vitricansua).SubItems(1).Text
            sqlConnect.ExecuteNoneQuery("update CTHD set MaKH=" & TbMaKH.Text & ", DonGia=" & TbDonGia.Text & ", SoLuong=" & TbSoLuong.Text & ", MaHD=" & TbMaHD.Text & " where MaCTHD=" & macansua & "")
        Next
        LoadSanPham()
    End Sub

    Private Sub LvCTHD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LvCTHD.SelectedIndexChanged
        If LvCTHD.SelectedItems.Count = 1 Then
            For Each List As ListViewItem In LvCTHD.SelectedItems

                TbMaCTHD.Text = List.SubItems(1).Text
                TbMaKH.Text = List.SubItems(2).Text
                TbDonGia.Text = List.SubItems(3).Text
                TbSoLuong.Text = List.SubItems(4).Text
                TbMaHD.Text = List.SubItems(5).Text

            Next
        End If
    End Sub

    Private Sub BtThoat_Click(sender As Object, e As EventArgs) Handles BtThoat.Click
        Close()
    End Sub

    Private Sub FormCTHD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSanPham()
    End Sub
End Class