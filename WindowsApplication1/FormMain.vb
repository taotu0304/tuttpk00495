Public Class FormMain
    Dim sqlConnect As New Class1
    Private Sub LoadSanPham()
        LvSanPham.Items.Clear()
        Dim dt As DataTable = sqlConnect.GetDataTable("Select * from SanPham")

        For i As Integer = 0 To dt.Rows.Count - 1 Step 1
            Dim item As New ListViewItem(LvSanPham.Items.Count + 1)

            item.SubItems.Add(dt.Rows(i).ItemArray(0))
            item.SubItems.Add(dt.Rows(i).ItemArray(1))
            item.SubItems.Add(dt.Rows(i).ItemArray(2))
            item.SubItems.Add(dt.Rows(i).ItemArray(3))
            LvSanPham.Items.Add(item)
        Next

    End Sub

    Private Sub BtThoat_Click(sender As Object, e As EventArgs) Handles BtThoat.Click
        End
    End Sub

    Private Sub BtThem_Click(sender As Object, e As EventArgs) Handles BtThem.Click
        sqlConnect.ExecuteNoneQuery("Insert into SanPham(MaSP,TenSP,GiaBan,MaLoaiSP) values(" + TbMaSP.Text + ",N'" + TbTenSP.Text + "'," + TbGiaBan.Text + "," + TbMaLoaiSP.Text + ")")
        LoadSanPham()
    End Sub

    Private Sub BtXoa_Click(sender As Object, e As EventArgs) Handles BtXoa.Click
        For i As Integer = LvSanPham.SelectedIndices.Count - 1 To 0 Step -1
            Dim viTriCanXoa As Integer = LvSanPham.SelectedIndices(i)
            Dim tenCanXoa As String = LvSanPham.Items(viTriCanXoa).SubItems(1).Text
            sqlConnect.ExecuteNoneQuery("Delete from SanPham where MaSP = N'" + tenCanXoa + "'")

        Next
        LoadSanPham()
    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSanPham()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LbMa.Click

    End Sub

    Private Sub BtSua_Click(sender As Object, e As EventArgs) Handles BtSua.Click
        For i As Integer = LvSanPham.SelectedIndices.Count - 1 To 0 Step -1
            Dim vitricansua As Integer = LvSanPham.SelectedIndices(i)
            Dim macansua As String = LvSanPham.Items(vitricansua).SubItems(1).Text
            sqlConnect.ExecuteNoneQuery("update SanPham set TenSP=N'" & TbTenSP.Text & "', GiaBan=" & TbGiaBan.Text & ", MaLoaiSP=" & TbMaLoaiSP.Text & " where MaSP=" & macansua & "")
        Next
        LoadSanPham()
    End Sub

    Private Sub LvSanPham_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LvSanPham.SelectedIndexChanged
        If LvSanPham.SelectedItems.Count = 1 Then
            For Each List As ListViewItem In LvSanPham.SelectedItems

                TbMaSP.Text = List.SubItems(1).Text
                TbTenSP.Text = List.SubItems(2).Text
                TbGiaBan.Text = List.SubItems(3).Text
                TbMaLoaiSP.Text = List.SubItems(4).Text
            
            Next
        End If
    End Sub

    Private Sub KháchHàngToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles KháchHàngToolStripMenuItem1.Click
        FormKhachHang.Show()
    End Sub

    Private Sub LoạiSảnPhẩmToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LoạiSảnPhẩmToolStripMenuItem1.Click
        FormLoaiSP.Show()
    End Sub

    Private Sub HóaĐơnToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HóaĐơnToolStripMenuItem1.Click
        FormHoaDon.Show()
    End Sub

    Private Sub ChiTiếtHóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChiTiếtHóaĐơnToolStripMenuItem.Click
        FormCTHD.Show()
    End Sub
End Class