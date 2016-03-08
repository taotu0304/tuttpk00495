<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLoaiSP
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
        Me.BtThem = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LvLSP = New System.Windows.Forms.ListView()
        Me.ClSTT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClMaLSP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClSize = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Clsoluong = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TbSize = New System.Windows.Forms.TextBox()
        Me.TbSoLuong = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtXoa = New System.Windows.Forms.Button()
        Me.BtSua = New System.Windows.Forms.Button()
        Me.BtThoat = New System.Windows.Forms.Button()
        Me.LbMaLSP = New System.Windows.Forms.Label()
        Me.TbMaLSP = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtThem
        '
        Me.BtThem.Location = New System.Drawing.Point(12, 74)
        Me.BtThem.Name = "BtThem"
        Me.BtThem.Size = New System.Drawing.Size(75, 23)
        Me.BtThem.TabIndex = 4
        Me.BtThem.Text = "Thêm"
        Me.BtThem.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(167, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Size"
        '
        'LvLSP
        '
        Me.LvLSP.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ClSTT, Me.ClMaLSP, Me.ClSize, Me.Clsoluong})
        Me.LvLSP.FullRowSelect = True
        Me.LvLSP.GridLines = True
        Me.LvLSP.Location = New System.Drawing.Point(12, 103)
        Me.LvLSP.Name = "LvLSP"
        Me.LvLSP.Size = New System.Drawing.Size(452, 170)
        Me.LvLSP.TabIndex = 8
        Me.LvLSP.UseCompatibleStateImageBehavior = False
        Me.LvLSP.View = System.Windows.Forms.View.Details
        '
        'ClSTT
        '
        Me.ClSTT.Text = "STT"
        '
        'ClMaLSP
        '
        Me.ClMaLSP.Text = "Mã Loại Sản Phẩm"
        Me.ClMaLSP.Width = 103
        '
        'ClSize
        '
        Me.ClSize.Text = "Size"
        Me.ClSize.Width = 88
        '
        'Clsoluong
        '
        Me.Clsoluong.Text = "Số Lượng"
        Me.Clsoluong.Width = 91
        '
        'TbSize
        '
        Me.TbSize.Location = New System.Drawing.Point(170, 32)
        Me.TbSize.Name = "TbSize"
        Me.TbSize.Size = New System.Drawing.Size(100, 20)
        Me.TbSize.TabIndex = 2
        '
        'TbSoLuong
        '
        Me.TbSoLuong.Location = New System.Drawing.Point(313, 32)
        Me.TbSoLuong.Name = "TbSoLuong"
        Me.TbSoLuong.Size = New System.Drawing.Size(100, 20)
        Me.TbSoLuong.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(310, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Số lượng"
        '
        'BtXoa
        '
        Me.BtXoa.Location = New System.Drawing.Point(106, 74)
        Me.BtXoa.Name = "BtXoa"
        Me.BtXoa.Size = New System.Drawing.Size(75, 23)
        Me.BtXoa.TabIndex = 5
        Me.BtXoa.Text = "Xóa"
        Me.BtXoa.UseVisualStyleBackColor = True
        '
        'BtSua
        '
        Me.BtSua.Location = New System.Drawing.Point(204, 74)
        Me.BtSua.Name = "BtSua"
        Me.BtSua.Size = New System.Drawing.Size(75, 23)
        Me.BtSua.TabIndex = 6
        Me.BtSua.Text = "Sửa"
        Me.BtSua.UseVisualStyleBackColor = True
        '
        'BtThoat
        '
        Me.BtThoat.Location = New System.Drawing.Point(367, 279)
        Me.BtThoat.Name = "BtThoat"
        Me.BtThoat.Size = New System.Drawing.Size(75, 23)
        Me.BtThoat.TabIndex = 0
        Me.BtThoat.Text = "Thoát"
        Me.BtThoat.UseVisualStyleBackColor = True
        '
        'LbMaLSP
        '
        Me.LbMaLSP.AutoSize = True
        Me.LbMaLSP.Location = New System.Drawing.Point(29, 9)
        Me.LbMaLSP.Name = "LbMaLSP"
        Me.LbMaLSP.Size = New System.Drawing.Size(97, 13)
        Me.LbMaLSP.TabIndex = 0
        Me.LbMaLSP.Text = "Mã Loại Sản Phâm"
        '
        'TbMaLSP
        '
        Me.TbMaLSP.Location = New System.Drawing.Point(32, 32)
        Me.TbMaLSP.Name = "TbMaLSP"
        Me.TbMaLSP.Size = New System.Drawing.Size(100, 20)
        Me.TbMaLSP.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(313, 74)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Load"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormLoaiSP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 316)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TbSoLuong)
        Me.Controls.Add(Me.TbMaLSP)
        Me.Controls.Add(Me.TbSize)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LvLSP)
        Me.Controls.Add(Me.LbMaLSP)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtThoat)
        Me.Controls.Add(Me.BtSua)
        Me.Controls.Add(Me.BtXoa)
        Me.Controls.Add(Me.BtThem)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Name = "FormLoaiSP"
        Me.Text = "Loại Sản Phẩm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtThem As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LvLSP As System.Windows.Forms.ListView
    Friend WithEvents TbSize As System.Windows.Forms.TextBox
    Friend WithEvents TbSoLuong As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtXoa As System.Windows.Forms.Button
    Friend WithEvents BtSua As System.Windows.Forms.Button
    Friend WithEvents BtThoat As System.Windows.Forms.Button
    Friend WithEvents LbMaLSP As System.Windows.Forms.Label
    Friend WithEvents TbMaLSP As System.Windows.Forms.TextBox
    Friend WithEvents ClSTT As System.Windows.Forms.ColumnHeader
    Friend WithEvents ClMaLSP As System.Windows.Forms.ColumnHeader
    Friend WithEvents ClSize As System.Windows.Forms.ColumnHeader
    Friend WithEvents Clsoluong As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
