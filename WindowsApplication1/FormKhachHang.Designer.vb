<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKhachHang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Lb1 = New System.Windows.Forms.Label()
        Me.Lb2 = New System.Windows.Forms.Label()
        Me.Lb3 = New System.Windows.Forms.Label()
        Me.Lb4 = New System.Windows.Forms.Label()
        Me.Bt1 = New System.Windows.Forms.Button()
        Me.LvKH = New System.Windows.Forms.ListView()
        Me.ClSTT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClMaKH = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClTen = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClSDT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClGioiTinh = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClDC = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClMaSP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Bt2 = New System.Windows.Forms.Button()
        Me.Bt3 = New System.Windows.Forms.Button()
        Me.Bt4 = New System.Windows.Forms.Button()
        Me.TbTenKH = New System.Windows.Forms.TextBox()
        Me.TbSDT = New System.Windows.Forms.TextBox()
        Me.TbDiaChi = New System.Windows.Forms.TextBox()
        Me.TbGioiTinh = New System.Windows.Forms.TextBox()
        Me.BtLoad = New System.Windows.Forms.Button()
        Me.LbMaKH = New System.Windows.Forms.Label()
        Me.TbMaKH = New System.Windows.Forms.TextBox()
        Me.TbMaSP = New System.Windows.Forms.TextBox()
        Me.LbMaSP = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.Location = New System.Drawing.Point(36, 73)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(89, 13)
        Me.Lb1.TabIndex = 0
        Me.Lb1.Text = "Tên Khách Hàng"
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.Location = New System.Drawing.Point(36, 103)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(75, 13)
        Me.Lb2.TabIndex = 0
        Me.Lb2.Text = "Số Điện Thoại"
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.Location = New System.Drawing.Point(37, 161)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(41, 13)
        Me.Lb3.TabIndex = 0
        Me.Lb3.Text = "Địa Chỉ"
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.Location = New System.Drawing.Point(36, 132)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(51, 13)
        Me.Lb4.TabIndex = 0
        Me.Lb4.Text = "Giới Tính"
        '
        'Bt1
        '
        Me.Bt1.Location = New System.Drawing.Point(335, 17)
        Me.Bt1.Name = "Bt1"
        Me.Bt1.Size = New System.Drawing.Size(75, 23)
        Me.Bt1.TabIndex = 7
        Me.Bt1.Text = "Thêm"
        Me.Bt1.UseVisualStyleBackColor = True
        '
        'LvKH
        '
        Me.LvKH.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ClSTT, Me.ClMaKH, Me.ClTen, Me.ClSDT, Me.ClGioiTinh, Me.ClDC, Me.ClMaSP})
        Me.LvKH.FullRowSelect = True
        Me.LvKH.GridLines = True
        Me.LvKH.Location = New System.Drawing.Point(30, 216)
        Me.LvKH.Name = "LvKH"
        Me.LvKH.Size = New System.Drawing.Size(644, 176)
        Me.LvKH.TabIndex = 12
        Me.LvKH.UseCompatibleStateImageBehavior = False
        Me.LvKH.View = System.Windows.Forms.View.Details
        '
        'ClSTT
        '
        Me.ClSTT.Text = "STT"
        Me.ClSTT.Width = 50
        '
        'ClMaKH
        '
        Me.ClMaKH.Text = "Mã Khách Hàng"
        Me.ClMaKH.Width = 92
        '
        'ClTen
        '
        Me.ClTen.Text = "Tên Khách Hàng"
        Me.ClTen.Width = 114
        '
        'ClSDT
        '
        Me.ClSDT.Text = "Số Điện Thoại"
        Me.ClSDT.Width = 101
        '
        'ClGioiTinh
        '
        Me.ClGioiTinh.Text = "Giới Tính"
        Me.ClGioiTinh.Width = 82
        '
        'ClDC
        '
        Me.ClDC.Text = "Địa Chỉ"
        Me.ClDC.Width = 91
        '
        'ClMaSP
        '
        Me.ClMaSP.Text = "Mã Sản Phẩm"
        Me.ClMaSP.Width = 96
        '
        'Bt2
        '
        Me.Bt2.Location = New System.Drawing.Point(446, 17)
        Me.Bt2.Name = "Bt2"
        Me.Bt2.Size = New System.Drawing.Size(75, 23)
        Me.Bt2.TabIndex = 9
        Me.Bt2.Text = "Sửa"
        Me.Bt2.UseVisualStyleBackColor = True
        '
        'Bt3
        '
        Me.Bt3.Location = New System.Drawing.Point(335, 58)
        Me.Bt3.Name = "Bt3"
        Me.Bt3.Size = New System.Drawing.Size(75, 23)
        Me.Bt3.TabIndex = 8
        Me.Bt3.Text = "Xóa"
        Me.Bt3.UseVisualStyleBackColor = True
        '
        'Bt4
        '
        Me.Bt4.Location = New System.Drawing.Point(446, 58)
        Me.Bt4.Name = "Bt4"
        Me.Bt4.Size = New System.Drawing.Size(75, 23)
        Me.Bt4.TabIndex = 10
        Me.Bt4.Text = "Thoát"
        Me.Bt4.UseVisualStyleBackColor = True
        '
        'TbTenKH
        '
        Me.TbTenKH.Location = New System.Drawing.Point(169, 66)
        Me.TbTenKH.Name = "TbTenKH"
        Me.TbTenKH.Size = New System.Drawing.Size(133, 20)
        Me.TbTenKH.TabIndex = 3
        '
        'TbSDT
        '
        Me.TbSDT.Location = New System.Drawing.Point(169, 96)
        Me.TbSDT.Name = "TbSDT"
        Me.TbSDT.Size = New System.Drawing.Size(133, 20)
        Me.TbSDT.TabIndex = 4
        '
        'TbDiaChi
        '
        Me.TbDiaChi.Location = New System.Drawing.Point(169, 158)
        Me.TbDiaChi.Name = "TbDiaChi"
        Me.TbDiaChi.Size = New System.Drawing.Size(133, 20)
        Me.TbDiaChi.TabIndex = 6
        '
        'TbGioiTinh
        '
        Me.TbGioiTinh.Location = New System.Drawing.Point(169, 127)
        Me.TbGioiTinh.Name = "TbGioiTinh"
        Me.TbGioiTinh.Size = New System.Drawing.Size(133, 20)
        Me.TbGioiTinh.TabIndex = 5
        '
        'BtLoad
        '
        Me.BtLoad.Location = New System.Drawing.Point(335, 99)
        Me.BtLoad.Name = "BtLoad"
        Me.BtLoad.Size = New System.Drawing.Size(75, 23)
        Me.BtLoad.TabIndex = 11
        Me.BtLoad.Text = "Load"
        Me.BtLoad.UseVisualStyleBackColor = True
        '
        'LbMaKH
        '
        Me.LbMaKH.AutoSize = True
        Me.LbMaKH.Location = New System.Drawing.Point(38, 42)
        Me.LbMaKH.Name = "LbMaKH"
        Me.LbMaKH.Size = New System.Drawing.Size(85, 13)
        Me.LbMaKH.TabIndex = 0
        Me.LbMaKH.Text = "Mã Khách Hàng"
        '
        'TbMaKH
        '
        Me.TbMaKH.Location = New System.Drawing.Point(169, 38)
        Me.TbMaKH.Name = "TbMaKH"
        Me.TbMaKH.Size = New System.Drawing.Size(133, 20)
        Me.TbMaKH.TabIndex = 2
        '
        'TbMaSP
        '
        Me.TbMaSP.Location = New System.Drawing.Point(169, 10)
        Me.TbMaSP.Name = "TbMaSP"
        Me.TbMaSP.Size = New System.Drawing.Size(133, 20)
        Me.TbMaSP.TabIndex = 1
        '
        'LbMaSP
        '
        Me.LbMaSP.AutoSize = True
        Me.LbMaSP.Location = New System.Drawing.Point(38, 17)
        Me.LbMaSP.Name = "LbMaSP"
        Me.LbMaSP.Size = New System.Drawing.Size(39, 13)
        Me.LbMaSP.TabIndex = 0
        Me.LbMaSP.Text = "Mã SP"
        '
        'FormKhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 417)
        Me.Controls.Add(Me.LbMaSP)
        Me.Controls.Add(Me.TbMaSP)
        Me.Controls.Add(Me.TbMaKH)
        Me.Controls.Add(Me.LbMaKH)
        Me.Controls.Add(Me.BtLoad)
        Me.Controls.Add(Me.TbGioiTinh)
        Me.Controls.Add(Me.TbDiaChi)
        Me.Controls.Add(Me.TbSDT)
        Me.Controls.Add(Me.TbTenKH)
        Me.Controls.Add(Me.LvKH)
        Me.Controls.Add(Me.Bt4)
        Me.Controls.Add(Me.Bt3)
        Me.Controls.Add(Me.Bt2)
        Me.Controls.Add(Me.Bt1)
        Me.Controls.Add(Me.Lb4)
        Me.Controls.Add(Me.Lb3)
        Me.Controls.Add(Me.Lb2)
        Me.Controls.Add(Me.Lb1)
        Me.Name = "FormKhachHang"
        Me.Text = "Khách Hàng"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lb1 As System.Windows.Forms.Label
    Friend WithEvents Lb2 As System.Windows.Forms.Label
    Friend WithEvents Lb3 As System.Windows.Forms.Label
    Friend WithEvents Lb4 As System.Windows.Forms.Label
    Friend WithEvents Bt1 As System.Windows.Forms.Button
    Friend WithEvents LvKH As System.Windows.Forms.ListView
    Friend WithEvents Bt2 As System.Windows.Forms.Button
    Friend WithEvents Bt3 As System.Windows.Forms.Button
    Friend WithEvents Bt4 As System.Windows.Forms.Button
    Friend WithEvents TbTenKH As System.Windows.Forms.TextBox
    Friend WithEvents TbSDT As System.Windows.Forms.TextBox
    Friend WithEvents TbDiaChi As System.Windows.Forms.TextBox
    Friend WithEvents TbGioiTinh As System.Windows.Forms.TextBox
    Friend WithEvents ClSTT As System.Windows.Forms.ColumnHeader
    Friend WithEvents BtLoad As System.Windows.Forms.Button
    Friend WithEvents ClMaKH As System.Windows.Forms.ColumnHeader
    Friend WithEvents ClTen As System.Windows.Forms.ColumnHeader
    Friend WithEvents ClSDT As System.Windows.Forms.ColumnHeader
    Friend WithEvents ClGioiTinh As System.Windows.Forms.ColumnHeader
    Friend WithEvents ClDC As System.Windows.Forms.ColumnHeader
    Friend WithEvents LbMaKH As System.Windows.Forms.Label
    Friend WithEvents TbMaKH As System.Windows.Forms.TextBox
    Friend WithEvents ClMaSP As System.Windows.Forms.ColumnHeader
    Friend WithEvents TbMaSP As System.Windows.Forms.TextBox
    Friend WithEvents LbMaSP As System.Windows.Forms.Label

End Class
