<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCTHD
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbMaCTHD = New System.Windows.Forms.TextBox()
        Me.BtSua = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbMaKH = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbDonGia = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbSoLuong = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbMaHD = New System.Windows.Forms.TextBox()
        Me.BtThem = New System.Windows.Forms.Button()
        Me.BtThoat = New System.Windows.Forms.Button()
        Me.BtXoa = New System.Windows.Forms.Button()
        Me.LvCTHD = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Chi Tiết HD"
        '
        'TbMaCTHD
        '
        Me.TbMaCTHD.Location = New System.Drawing.Point(103, 2)
        Me.TbMaCTHD.Name = "TbMaCTHD"
        Me.TbMaCTHD.Size = New System.Drawing.Size(108, 20)
        Me.TbMaCTHD.TabIndex = 1
        '
        'BtSua
        '
        Me.BtSua.Location = New System.Drawing.Point(40, 154)
        Me.BtSua.Name = "BtSua"
        Me.BtSua.Size = New System.Drawing.Size(75, 23)
        Me.BtSua.TabIndex = 8
        Me.BtSua.Text = "Sửa"
        Me.BtSua.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mã Khách Hàng"
        '
        'TbMaKH
        '
        Me.TbMaKH.Location = New System.Drawing.Point(103, 36)
        Me.TbMaKH.Name = "TbMaKH"
        Me.TbMaKH.Size = New System.Drawing.Size(108, 20)
        Me.TbMaKH.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Đơn Giá"
        '
        'TbDonGia
        '
        Me.TbDonGia.Location = New System.Drawing.Point(103, 70)
        Me.TbDonGia.Name = "TbDonGia"
        Me.TbDonGia.Size = New System.Drawing.Size(108, 20)
        Me.TbDonGia.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(240, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Số Lượng"
        '
        'TbSoLuong
        '
        Me.TbSoLuong.Location = New System.Drawing.Point(316, 2)
        Me.TbSoLuong.Name = "TbSoLuong"
        Me.TbSoLuong.Size = New System.Drawing.Size(100, 20)
        Me.TbSoLuong.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(240, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Mã Hóa Đơn"
        '
        'TbMaHD
        '
        Me.TbMaHD.Location = New System.Drawing.Point(316, 35)
        Me.TbMaHD.Name = "TbMaHD"
        Me.TbMaHD.Size = New System.Drawing.Size(100, 20)
        Me.TbMaHD.TabIndex = 5
        '
        'BtThem
        '
        Me.BtThem.Location = New System.Drawing.Point(40, 116)
        Me.BtThem.Name = "BtThem"
        Me.BtThem.Size = New System.Drawing.Size(75, 23)
        Me.BtThem.TabIndex = 6
        Me.BtThem.Text = "Thêm"
        Me.BtThem.UseVisualStyleBackColor = True
        '
        'BtThoat
        '
        Me.BtThoat.Location = New System.Drawing.Point(121, 154)
        Me.BtThoat.Name = "BtThoat"
        Me.BtThoat.Size = New System.Drawing.Size(75, 23)
        Me.BtThoat.TabIndex = 9
        Me.BtThoat.Text = "Thoát"
        Me.BtThoat.UseVisualStyleBackColor = True
        '
        'BtXoa
        '
        Me.BtXoa.Location = New System.Drawing.Point(121, 116)
        Me.BtXoa.Name = "BtXoa"
        Me.BtXoa.Size = New System.Drawing.Size(75, 23)
        Me.BtXoa.TabIndex = 7
        Me.BtXoa.Text = "Xóa"
        Me.BtXoa.UseVisualStyleBackColor = True
        '
        'LvCTHD
        '
        Me.LvCTHD.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.LvCTHD.FullRowSelect = True
        Me.LvCTHD.GridLines = True
        Me.LvCTHD.Location = New System.Drawing.Point(202, 116)
        Me.LvCTHD.Name = "LvCTHD"
        Me.LvCTHD.RightToLeftLayout = True
        Me.LvCTHD.Size = New System.Drawing.Size(430, 167)
        Me.LvCTHD.TabIndex = 10
        Me.LvCTHD.UseCompatibleStateImageBehavior = False
        Me.LvCTHD.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "STT"
        Me.ColumnHeader1.Width = 36
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Mã CTHD"
        Me.ColumnHeader2.Width = 67
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Mã Khách Hàng"
        Me.ColumnHeader3.Width = 91
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Đơn Giá"
        Me.ColumnHeader4.Width = 83
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Số Lượng"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Mã Hóa Đơn"
        Me.ColumnHeader6.Width = 76
        '
        'FormCTHD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 295)
        Me.Controls.Add(Me.LvCTHD)
        Me.Controls.Add(Me.BtXoa)
        Me.Controls.Add(Me.BtThoat)
        Me.Controls.Add(Me.BtThem)
        Me.Controls.Add(Me.BtSua)
        Me.Controls.Add(Me.TbMaHD)
        Me.Controls.Add(Me.TbSoLuong)
        Me.Controls.Add(Me.TbDonGia)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TbMaKH)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TbMaCTHD)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormCTHD"
        Me.Text = "FormCTHD"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TbMaCTHD As System.Windows.Forms.TextBox
    Friend WithEvents BtSua As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TbMaKH As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TbDonGia As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TbSoLuong As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TbMaHD As System.Windows.Forms.TextBox
    Friend WithEvents BtThem As System.Windows.Forms.Button
    Friend WithEvents BtThoat As System.Windows.Forms.Button
    Friend WithEvents BtXoa As System.Windows.Forms.Button
    Friend WithEvents LvCTHD As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
End Class
