<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SảnPhẩmToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.KháchHàngToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoạiSảnPhẩmToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HóaĐơnToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChiTiếtHóaĐơnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoạiSảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KháchHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HóaĐơnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChỉTiếtHóaĐơnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtThem = New System.Windows.Forms.Button()
        Me.BtSua = New System.Windows.Forms.Button()
        Me.BtXoa = New System.Windows.Forms.Button()
        Me.BtThoat = New System.Windows.Forms.Button()
        Me.TbTenSP = New System.Windows.Forms.TextBox()
        Me.TbGiaBan = New System.Windows.Forms.TextBox()
        Me.TbMaLoaiSP = New System.Windows.Forms.TextBox()
        Me.LbTenSP = New System.Windows.Forms.Label()
        Me.LvSanPham = New System.Windows.Forms.ListView()
        Me.ClSTT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClMaSP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClTenSP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClGiaBan = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClMaLSP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LbGiaBan = New System.Windows.Forms.Label()
        Me.LbMaSP = New System.Windows.Forms.Label()
        Me.LbMa = New System.Windows.Forms.Label()
        Me.TbMaSP = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SảnPhẩmToolStripMenuItem1, Me.KháchHàngToolStripMenuItem1, Me.LoạiSảnPhẩmToolStripMenuItem1, Me.HóaĐơnToolStripMenuItem1, Me.ChiTiếtHóaĐơnToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(596, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SảnPhẩmToolStripMenuItem1
        '
        Me.SảnPhẩmToolStripMenuItem1.Name = "SảnPhẩmToolStripMenuItem1"
        Me.SảnPhẩmToolStripMenuItem1.Size = New System.Drawing.Size(72, 20)
        Me.SảnPhẩmToolStripMenuItem1.Text = "Sản Phẩm"
        '
        'KháchHàngToolStripMenuItem1
        '
        Me.KháchHàngToolStripMenuItem1.Name = "KháchHàngToolStripMenuItem1"
        Me.KháchHàngToolStripMenuItem1.Size = New System.Drawing.Size(84, 20)
        Me.KháchHàngToolStripMenuItem1.Text = "Khách Hàng"
        '
        'LoạiSảnPhẩmToolStripMenuItem1
        '
        Me.LoạiSảnPhẩmToolStripMenuItem1.Name = "LoạiSảnPhẩmToolStripMenuItem1"
        Me.LoạiSảnPhẩmToolStripMenuItem1.Size = New System.Drawing.Size(97, 20)
        Me.LoạiSảnPhẩmToolStripMenuItem1.Text = "Loại Sản Phẩm"
        '
        'HóaĐơnToolStripMenuItem1
        '
        Me.HóaĐơnToolStripMenuItem1.Name = "HóaĐơnToolStripMenuItem1"
        Me.HóaĐơnToolStripMenuItem1.Size = New System.Drawing.Size(66, 20)
        Me.HóaĐơnToolStripMenuItem1.Text = "Hóa Đơn"
        '
        'ChiTiếtHóaĐơnToolStripMenuItem
        '
        Me.ChiTiếtHóaĐơnToolStripMenuItem.Name = "ChiTiếtHóaĐơnToolStripMenuItem"
        Me.ChiTiếtHóaĐơnToolStripMenuItem.Size = New System.Drawing.Size(110, 20)
        Me.ChiTiếtHóaĐơnToolStripMenuItem.Text = "Chi Tiết Hóa Đơn"
        '
        'SảnPhẩmToolStripMenuItem
        '
        Me.SảnPhẩmToolStripMenuItem.Name = "SảnPhẩmToolStripMenuItem"
        Me.SảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.SảnPhẩmToolStripMenuItem.Text = "Sản Phẩm"
        '
        'LoạiSảnPhẩmToolStripMenuItem
        '
        Me.LoạiSảnPhẩmToolStripMenuItem.Name = "LoạiSảnPhẩmToolStripMenuItem"
        Me.LoạiSảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(97, 20)
        Me.LoạiSảnPhẩmToolStripMenuItem.Text = "Loại Sản Phẩm"
        '
        'KháchHàngToolStripMenuItem
        '
        Me.KháchHàngToolStripMenuItem.Name = "KháchHàngToolStripMenuItem"
        Me.KháchHàngToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.KháchHàngToolStripMenuItem.Text = "Khách Hàng"
        '
        'HóaĐơnToolStripMenuItem
        '
        Me.HóaĐơnToolStripMenuItem.Name = "HóaĐơnToolStripMenuItem"
        Me.HóaĐơnToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.HóaĐơnToolStripMenuItem.Text = "Hóa Đơn"
        '
        'ChỉTiếtHóaĐơnToolStripMenuItem
        '
        Me.ChỉTiếtHóaĐơnToolStripMenuItem.Name = "ChỉTiếtHóaĐơnToolStripMenuItem"
        Me.ChỉTiếtHóaĐơnToolStripMenuItem.Size = New System.Drawing.Size(110, 20)
        Me.ChỉTiếtHóaĐơnToolStripMenuItem.Text = "Chỉ Tiết Hóa Đơn"
        '
        'BtThem
        '
        Me.BtThem.Location = New System.Drawing.Point(318, 36)
        Me.BtThem.Name = "BtThem"
        Me.BtThem.Size = New System.Drawing.Size(65, 29)
        Me.BtThem.TabIndex = 5
        Me.BtThem.Text = "Thêm"
        Me.BtThem.UseVisualStyleBackColor = True
        '
        'BtSua
        '
        Me.BtSua.Location = New System.Drawing.Point(318, 124)
        Me.BtSua.Name = "BtSua"
        Me.BtSua.Size = New System.Drawing.Size(65, 29)
        Me.BtSua.TabIndex = 7
        Me.BtSua.Text = "Sửa"
        Me.BtSua.UseVisualStyleBackColor = True
        '
        'BtXoa
        '
        Me.BtXoa.Location = New System.Drawing.Point(318, 79)
        Me.BtXoa.Name = "BtXoa"
        Me.BtXoa.Size = New System.Drawing.Size(65, 29)
        Me.BtXoa.TabIndex = 6
        Me.BtXoa.Text = "Xóa"
        Me.BtXoa.UseVisualStyleBackColor = True
        '
        'BtThoat
        '
        Me.BtThoat.Location = New System.Drawing.Point(404, 124)
        Me.BtThoat.Name = "BtThoat"
        Me.BtThoat.Size = New System.Drawing.Size(65, 29)
        Me.BtThoat.TabIndex = 8
        Me.BtThoat.Text = "Thoát"
        Me.BtThoat.UseVisualStyleBackColor = True
        '
        'TbTenSP
        '
        Me.TbTenSP.Location = New System.Drawing.Point(127, 62)
        Me.TbTenSP.Name = "TbTenSP"
        Me.TbTenSP.Size = New System.Drawing.Size(157, 20)
        Me.TbTenSP.TabIndex = 2
        '
        'TbGiaBan
        '
        Me.TbGiaBan.Location = New System.Drawing.Point(127, 93)
        Me.TbGiaBan.Name = "TbGiaBan"
        Me.TbGiaBan.Size = New System.Drawing.Size(157, 20)
        Me.TbGiaBan.TabIndex = 3
        '
        'TbMaLoaiSP
        '
        Me.TbMaLoaiSP.Location = New System.Drawing.Point(127, 124)
        Me.TbMaLoaiSP.Name = "TbMaLoaiSP"
        Me.TbMaLoaiSP.Size = New System.Drawing.Size(157, 20)
        Me.TbMaLoaiSP.TabIndex = 4
        '
        'LbTenSP
        '
        Me.LbTenSP.AutoSize = True
        Me.LbTenSP.Location = New System.Drawing.Point(12, 66)
        Me.LbTenSP.Name = "LbTenSP"
        Me.LbTenSP.Size = New System.Drawing.Size(78, 13)
        Me.LbTenSP.TabIndex = 0
        Me.LbTenSP.Text = "Tên Sản Phẩm"
        '
        'LvSanPham
        '
        Me.LvSanPham.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ClSTT, Me.ClMaSP, Me.ClTenSP, Me.ClGiaBan, Me.ClMaLSP})
        Me.LvSanPham.FullRowSelect = True
        Me.LvSanPham.Location = New System.Drawing.Point(28, 172)
        Me.LvSanPham.Name = "LvSanPham"
        Me.LvSanPham.RightToLeftLayout = True
        Me.LvSanPham.Size = New System.Drawing.Size(501, 213)
        Me.LvSanPham.TabIndex = 9
        Me.LvSanPham.UseCompatibleStateImageBehavior = False
        Me.LvSanPham.View = System.Windows.Forms.View.Details
        '
        'ClSTT
        '
        Me.ClSTT.Text = "STT"
        '
        'ClMaSP
        '
        Me.ClMaSP.Text = "Mã Sản Phẩm"
        Me.ClMaSP.Width = 89
        '
        'ClTenSP
        '
        Me.ClTenSP.Text = "Tên Sản Phẩm"
        Me.ClTenSP.Width = 109
        '
        'ClGiaBan
        '
        Me.ClGiaBan.Text = "Giá Bán"
        Me.ClGiaBan.Width = 111
        '
        'ClMaLSP
        '
        Me.ClMaLSP.Text = "Mã Loại Sản Phẩm"
        Me.ClMaLSP.Width = 129
        '
        'LbGiaBan
        '
        Me.LbGiaBan.AutoSize = True
        Me.LbGiaBan.Location = New System.Drawing.Point(14, 94)
        Me.LbGiaBan.Name = "LbGiaBan"
        Me.LbGiaBan.Size = New System.Drawing.Size(45, 13)
        Me.LbGiaBan.TabIndex = 0
        Me.LbGiaBan.Text = "Giá Bán"
        '
        'LbMaSP
        '
        Me.LbMaSP.AutoSize = True
        Me.LbMaSP.Location = New System.Drawing.Point(12, 125)
        Me.LbMaSP.Name = "LbMaSP"
        Me.LbMaSP.Size = New System.Drawing.Size(97, 13)
        Me.LbMaSP.TabIndex = 0
        Me.LbMaSP.Text = "Mã Loại Sản Phẩm"
        '
        'LbMa
        '
        Me.LbMa.AutoSize = True
        Me.LbMa.Location = New System.Drawing.Point(13, 36)
        Me.LbMa.Name = "LbMa"
        Me.LbMa.Size = New System.Drawing.Size(74, 13)
        Me.LbMa.TabIndex = 0
        Me.LbMa.Text = "Mã Sản Phẩm"
        '
        'TbMaSP
        '
        Me.TbMaSP.Location = New System.Drawing.Point(128, 30)
        Me.TbMaSP.Name = "TbMaSP"
        Me.TbMaSP.Size = New System.Drawing.Size(156, 20)
        Me.TbMaSP.TabIndex = 1
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(596, 399)
        Me.Controls.Add(Me.TbMaSP)
        Me.Controls.Add(Me.LbMa)
        Me.Controls.Add(Me.LvSanPham)
        Me.Controls.Add(Me.LbMaSP)
        Me.Controls.Add(Me.LbGiaBan)
        Me.Controls.Add(Me.LbTenSP)
        Me.Controls.Add(Me.TbMaLoaiSP)
        Me.Controls.Add(Me.TbGiaBan)
        Me.Controls.Add(Me.TbTenSP)
        Me.Controls.Add(Me.BtThoat)
        Me.Controls.Add(Me.BtSua)
        Me.Controls.Add(Me.BtXoa)
        Me.Controls.Add(Me.BtThem)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormMain"
        Me.Text = "Quản Lý Bán Hàng"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SảnPhẩmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoạiSảnPhẩmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KháchHàngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HóaĐơnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChỉTiếtHóaĐơnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtThem As System.Windows.Forms.Button
    Friend WithEvents BtSua As System.Windows.Forms.Button
    Friend WithEvents BtXoa As System.Windows.Forms.Button
    Friend WithEvents BtThoat As System.Windows.Forms.Button
    Friend WithEvents TbTenSP As System.Windows.Forms.TextBox
    Friend WithEvents TbGiaBan As System.Windows.Forms.TextBox
    Friend WithEvents TbMaLoaiSP As System.Windows.Forms.TextBox
    Friend WithEvents LbTenSP As System.Windows.Forms.Label
    Friend WithEvents LvSanPham As System.Windows.Forms.ListView
    Friend WithEvents LbGiaBan As System.Windows.Forms.Label
    Friend WithEvents LbMaSP As System.Windows.Forms.Label
    Friend WithEvents ClMaSP As System.Windows.Forms.ColumnHeader
    Friend WithEvents ClTenSP As System.Windows.Forms.ColumnHeader
    Friend WithEvents ClGiaBan As System.Windows.Forms.ColumnHeader
    Friend WithEvents ClMaLSP As System.Windows.Forms.ColumnHeader
    Friend WithEvents ClSTT As System.Windows.Forms.ColumnHeader
    Friend WithEvents LbMa As System.Windows.Forms.Label
    Friend WithEvents TbMaSP As System.Windows.Forms.TextBox
    Friend WithEvents SảnPhẩmToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KháchHàngToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoạiSảnPhẩmToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HóaĐơnToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChiTiếtHóaĐơnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
