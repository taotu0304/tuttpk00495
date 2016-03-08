Public Class FormLoaiSP
    Dim sqlConnect As New Class1
    Private Sub LoadSanPham()
        LvLSP.Items.Clear()
        Dim dt As DataTable = sqlConnect.GetDataTable("Select * from LoaiSP")

        For i As Integer = 0 To dt.Rows.Count - 1 Step 1
            Dim it As New ListViewItem(LvLSP.Items.Count + 1)

            it.SubItems.Add(dt.Rows(i).ItemArray(0))
            it.SubItems.Add(dt.Rows(i).ItemArray(1))
            it.SubItems.Add(dt.Rows(i).ItemArray(2))
            LvLSP.Items.Add(it)
        Next
    End Sub
    Private Sub BtThem_Click(sender As Object, e As EventArgs) Handles BtThem.Click
        sqlConnect.ExecuteNoneQuery("Insert into LoaiSP(MaLoaiSP,Size,Soluong) values(" + TbMaLSP.Text + ",N'" + TbSize.Text + "'," + TbSoLuong.Text + ")")
        LoadSanPham()
    End Sub

    Private Sub BtXoa_Click(sender As Object, e As EventArgs) Handles BtXoa.Click
        For i As Integer = LvLSP.SelectedIndices.Count - 1 To 0 Step -1
            Dim viTriCanXoa As Integer = LvLSP.SelectedIndices(i)
            Dim tenCanXoa As String = LvLSP.Items(viTriCanXoa).SubItems(1).Text
            sqlConnect.ExecuteNoneQuery("Delete from LoaiSP where MaLoaiSP = " + tenCanXoa + "")

        Next
        LoadSanPham()
    End Sub

    Private Sub BtSua_Click(sender As Object, e As EventArgs) Handles BtSua.Click
        For i As Integer = LvLSP.SelectedIndices.Count - 1 To 0 Step -1
            Dim vitricansua As Integer = LvLSP.SelectedIndices(i)
            Dim macansua As String = LvLSP.Items(vitricansua).SubItems(1).Text
            sqlConnect.ExecuteNoneQuery("update LoaiSP set  Size=N'" & TbSize.Text & "', Soluong=" & TbSoLuong.Text & " where MaLoaiSP=" & macansua & "")
        Next
        LoadSanPham()
    End Sub

    Private Sub LvLoaiSP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LvLSP.SelectedIndexChanged
        If LvLSP.SelectedItems.Count = 1 Then
            For Each List As ListViewItem In LvLSP.SelectedItems

                TbMaLSP.Text = List.SubItems(1).Text
                TbSize.Text = List.SubItems(2).Text
                TbSoLuong.Text = List.SubItems(3).Text
            Next
        End If
    End Sub

    Private Sub BtThoat_Click(sender As Object, e As EventArgs) Handles BtThoat.Click
        Close()
    End Sub

    Private Sub FormLoaiSP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadSanPham()
    End Sub
End Class