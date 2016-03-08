<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHoaDon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormHoaDon))
        Me.Lb1 = New System.Windows.Forms.Label()
        Me.TbMaHD = New System.Windows.Forms.TextBox()
        Me.LvHD = New System.Windows.Forms.ListView()
        Me.ClSTT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClMaHD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClMaSP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Cl3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Cl4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Lb2 = New System.Windows.Forms.Label()
        Me.TbNgayM = New System.Windows.Forms.TextBox()
        Me.Lb3 = New System.Windows.Forms.Label()
        Me.TbTT = New System.Windows.Forms.TextBox()
        Me.Lb4 = New System.Windows.Forms.Label()
        Me.TbMaSP = New System.Windows.Forms.TextBox()
        Me.BtThem = New System.Windows.Forms.Button()
        Me.BtXoa = New System.Windows.Forms.Button()
        Me.BtSua = New System.Windows.Forms.Button()
        Me.BtThoat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.Location = New System.Drawing.Point(42, 22)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(68, 13)
        Me.Lb1.TabIndex = 0
        Me.Lb1.Text = "Mã Hóa Đơn"
        '
        'TbMaHD
        '
        Me.TbMaHD.Location = New System.Drawing.Point(26, 37)
        Me.TbMaHD.Name = "TbMaHD"
        Me.TbMaHD.Size = New System.Drawing.Size(100, 20)
        Me.TbMaHD.TabIndex = 1
        '
        'LvHD
        '
        Me.LvHD.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ClSTT, Me.ClMaHD, Me.ClMaSP, Me.Cl3, Me.Cl4})
        Me.LvHD.FullRowSelect = True
        Me.LvHD.GridLines = True
        Me.LvHD.Location = New System.Drawing.Point(26, 113)
        Me.LvHD.Name = "LvHD"
        Me.LvHD.RightToLeftLayout = True
        Me.LvHD.Size = New System.Drawing.Size(533, 188)
        Me.LvHD.TabIndex = 9
        Me.LvHD.UseCompatibleStateImageBehavior = False
        Me.LvHD.View = System.Windows.Forms.View.Details
        '
        'ClSTT
        '
        Me.ClSTT.Text = "STT"
        '
        'ClMaHD
        '
        Me.ClMaHD.Text = "Mã Hóa Đơn"
        Me.ClMaHD.Width = 86
        '
        'ClMaSP
        '
        Me.ClMaSP.Text = "Mã Sản Phẩm"
        Me.ClMaSP.Width = 88
        '
        'Cl3
        '
        Me.Cl3.Text = "Ngày Mua"
        Me.Cl3.Width = 115
        '
        'Cl4
        '
        Me.Cl4.Text = "Tổng Tiền"
        Me.Cl4.Width = 118
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.Location = New System.Drawing.Point(154, 22)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(85, 13)
        Me.Lb2.TabIndex = 0
        Me.Lb2.Text = "Ngày Mua Hàng"
        '
        'TbNgayM
        '
        Me.TbNgayM.Location = New System.Drawing.Point(147, 37)
        Me.TbNgayM.Name = "TbNgayM"
        Me.TbNgayM.Size = New System.Drawing.Size(100, 20)
        Me.TbNgayM.TabIndex = 2
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.Location = New System.Drawing.Point(296, 21)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(56, 13)
        Me.Lb3.TabIndex = 0
        Me.Lb3.Text = "Tổng Tiền"
        '
        'TbTT
        '
        Me.TbTT.Location = New System.Drawing.Point(277, 37)
        Me.TbTT.Name = "TbTT"
        Me.TbTT.Size = New System.Drawing.Size(100, 20)
        Me.TbTT.TabIndex = 3
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.Location = New System.Drawing.Point(419, 21)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(74, 13)
        Me.Lb4.TabIndex = 0
        Me.Lb4.Text = "Mã Sản Phẩm"
        '
        'TbMaSP
        '
        Me.TbMaSP.Location = New System.Drawing.Point(406, 37)
        Me.TbMaSP.Name = "TbMaSP"
        Me.TbMaSP.Size = New System.Drawing.Size(100, 20)
        Me.TbMaSP.TabIndex = 4
        '
        'BtThem
        '
        Me.BtThem.Location = New System.Drawing.Point(37, 70)
        Me.BtThem.Name = "BtThem"
        Me.BtThem.Size = New System.Drawing.Size(75, 23)
        Me.BtThem.TabIndex = 5
        Me.BtThem.Text = "Thêm"
        Me.BtThem.UseVisualStyleBackColor = True
        '
        'BtXoa
        '
        Me.BtXoa.Location = New System.Drawing.Point(158, 70)
        Me.BtXoa.Name = "BtXoa"
        Me.BtXoa.Size = New System.Drawing.Size(75, 23)
        Me.BtXoa.TabIndex = 6
        Me.BtXoa.Text = "Xóa"
        Me.BtXoa.UseVisualStyleBackColor = True
        '
        'BtSua
        '
        Me.BtSua.Location = New System.Drawing.Point(277, 70)
        Me.BtSua.Name = "BtSua"
        Me.BtSua.Size = New System.Drawing.Size(75, 23)
        Me.BtSua.TabIndex = 7
        Me.BtSua.Text = "Sửa"
        Me.BtSua.UseVisualStyleBackColor = True
        '
        'BtThoat
        '
        Me.BtThoat.Location = New System.Drawing.Point(406, 70)
        Me.BtThoat.Name = "BtThoat"
        Me.BtThoat.Size = New System.Drawing.Size(75, 23)
        Me.BtThoat.TabIndex = 8
        Me.BtThoat.Text = "Thoát"
        Me.BtThoat.UseVisualStyleBackColor = True
        '
        'FormHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(602, 341)
        Me.Controls.Add(Me.BtThoat)
        Me.Controls.Add(Me.BtSua)
        Me.Controls.Add(Me.BtXoa)
        Me.Controls.Add(Me.BtThem)
        Me.Controls.Add(Me.LvHD)
        Me.Controls.Add(Me.TbMaSP)
        Me.Controls.Add(Me.Lb4)
        Me.Controls.Add(Me.TbTT)
        Me.Controls.Add(Me.Lb3)
        Me.Controls.Add(Me.TbNgayM)
        Me.Controls.Add(Me.Lb2)
        Me.Controls.Add(Me.TbMaHD)
        Me.Controls.Add(Me.Lb1)
        Me.Name = "FormHoaDon"
        Me.Text = "FormHoaDon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lb1 As System.Windows.Forms.Label
    Friend WithEvents TbMaHD As System.Windows.Forms.TextBox
    Friend WithEvents LvHD As System.Windows.Forms.ListView
    Friend WithEvents Lb2 As System.Windows.Forms.Label
    Friend WithEvents TbNgayM As System.Windows.Forms.TextBox
    Friend WithEvents Lb3 As System.Windows.Forms.Label
    Friend WithEvents TbTT As System.Windows.Forms.TextBox
    Friend WithEvents Lb4 As System.Windows.Forms.Label
    Friend WithEvents TbMaSP As System.Windows.Forms.TextBox
    Friend WithEvents BtThem As System.Windows.Forms.Button
    Friend WithEvents BtXoa As System.Windows.Forms.Button
    Friend WithEvents BtSua As System.Windows.Forms.Button
    Friend WithEvents BtThoat As System.Windows.Forms.Button
    Friend WithEvents ClSTT As System.Windows.Forms.ColumnHeader
    Friend WithEvents ClMaHD As System.Windows.Forms.ColumnHeader
    Friend WithEvents ClMaSP As System.Windows.Forms.ColumnHeader
    Friend WithEvents Cl3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Cl4 As System.Windows.Forms.ColumnHeader
End Class
