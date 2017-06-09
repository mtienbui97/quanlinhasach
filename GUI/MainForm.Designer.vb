Partial Class MainForm
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	''' <summary>
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Windows Form Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
		Me.comboBox1 = New System.Windows.Forms.ComboBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.LapPhieuNhapSach = New System.Windows.Forms.Button()
		Me.LapHoaDonBanSach = New System.Windows.Forms.Button()
		Me.TraCuuSach = New System.Windows.Forms.Button()
		Me.LapPhieuThuTien = New System.Windows.Forms.Button()
		Me.LapBaoCaoCongNo = New System.Windows.Forms.Button()
		Me.LapBaoCaoTon = New System.Windows.Forms.Button()
		Me.ThayDoiQuyDinh = New System.Windows.Forms.Button()
		Me.ThemMoiKhachHang = New System.Windows.Forms.Button()
		Me.ThemMoiSach = New System.Windows.Forms.Button()
		Me.close = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		' 
		' comboBox1
		' 
		Me.comboBox1.FormattingEnabled = True
		Me.comboBox1.Location = New System.Drawing.Point(208, 35)
		Me.comboBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.comboBox1.Name = "comboBox1"
		Me.comboBox1.Size = New System.Drawing.Size(82, 21)
		Me.comboBox1.TabIndex = 0
		AddHandler Me.comboBox1.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBox1_SelectedIndexChanged)
		' 
		' label1
		' 
		Me.label1.AutoSize = True
		Me.label1.Location = New System.Drawing.Point(131, 37)
		Me.label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(62, 13)
		Me.label1.TabIndex = 1
		Me.label1.Text = "Người dùng"
		' 
		' LapPhieuNhapSach
		' 
		Me.LapPhieuNhapSach.Location = New System.Drawing.Point(87, 66)
		Me.LapPhieuNhapSach.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.LapPhieuNhapSach.Name = "LapPhieuNhapSach"
		Me.LapPhieuNhapSach.Size = New System.Drawing.Size(115, 42)
		Me.LapPhieuNhapSach.TabIndex = 2
		Me.LapPhieuNhapSach.Text = "Lập phiếu nhập sách"
		Me.LapPhieuNhapSach.UseVisualStyleBackColor = True
		AddHandler Me.LapPhieuNhapSach.Click, New System.EventHandler(AddressOf Me.LapPhieuNhapSach_Click)
		' 
		' LapHoaDonBanSach
		' 
		Me.LapHoaDonBanSach.Location = New System.Drawing.Point(245, 66)
		Me.LapHoaDonBanSach.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.LapHoaDonBanSach.Name = "LapHoaDonBanSach"
		Me.LapHoaDonBanSach.Size = New System.Drawing.Size(115, 42)
		Me.LapHoaDonBanSach.TabIndex = 3
		Me.LapHoaDonBanSach.Text = "Lập hóa đơn bán sách"
		Me.LapHoaDonBanSach.UseVisualStyleBackColor = True
		AddHandler Me.LapHoaDonBanSach.Click, New System.EventHandler(AddressOf Me.LapHoaDonBanSach_Click)
		' 
		' TraCuuSach
		' 
		Me.TraCuuSach.Location = New System.Drawing.Point(87, 126)
		Me.TraCuuSach.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.TraCuuSach.Name = "TraCuuSach"
		Me.TraCuuSach.Size = New System.Drawing.Size(115, 33)
		Me.TraCuuSach.TabIndex = 4
		Me.TraCuuSach.Text = "Tra cứu sách"
		Me.TraCuuSach.UseVisualStyleBackColor = True
		AddHandler Me.TraCuuSach.Click, New System.EventHandler(AddressOf Me.TraCuuSach_Click)
		' 
		' LapPhieuThuTien
		' 
		Me.LapPhieuThuTien.Location = New System.Drawing.Point(245, 126)
		Me.LapPhieuThuTien.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.LapPhieuThuTien.Name = "LapPhieuThuTien"
		Me.LapPhieuThuTien.Size = New System.Drawing.Size(115, 33)
		Me.LapPhieuThuTien.TabIndex = 5
		Me.LapPhieuThuTien.Text = "Lập phiếu thu tiền"
		Me.LapPhieuThuTien.UseVisualStyleBackColor = True
		AddHandler Me.LapPhieuThuTien.Click, New System.EventHandler(AddressOf Me.LapPhieuThuTien_Click)
		' 
		' LapBaoCaoCongNo
		' 
		Me.LapBaoCaoCongNo.Location = New System.Drawing.Point(87, 177)
		Me.LapBaoCaoCongNo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.LapBaoCaoCongNo.Name = "LapBaoCaoCongNo"
		Me.LapBaoCaoCongNo.Size = New System.Drawing.Size(115, 43)
		Me.LapBaoCaoCongNo.TabIndex = 6
		Me.LapBaoCaoCongNo.Text = "Lập báo cáo công nợ"
		Me.LapBaoCaoCongNo.UseVisualStyleBackColor = True
		AddHandler Me.LapBaoCaoCongNo.Click, New System.EventHandler(AddressOf Me.LapBaoCaoCongNo_Click)
		' 
		' LapBaoCaoTon
		' 
		Me.LapBaoCaoTon.Location = New System.Drawing.Point(245, 177)
		Me.LapBaoCaoTon.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.LapBaoCaoTon.Name = "LapBaoCaoTon"
		Me.LapBaoCaoTon.Size = New System.Drawing.Size(115, 43)
		Me.LapBaoCaoTon.TabIndex = 7
		Me.LapBaoCaoTon.Text = "Lập báo cáo tồn"
		Me.LapBaoCaoTon.UseVisualStyleBackColor = True
		AddHandler Me.LapBaoCaoTon.Click, New System.EventHandler(AddressOf Me.LapBaoCaoTon_Click)
		' 
		' ThayDoiQuyDinh
		' 
		Me.ThayDoiQuyDinh.Location = New System.Drawing.Point(87, 242)
		Me.ThayDoiQuyDinh.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.ThayDoiQuyDinh.Name = "ThayDoiQuyDinh"
		Me.ThayDoiQuyDinh.Size = New System.Drawing.Size(115, 33)
		Me.ThayDoiQuyDinh.TabIndex = 8
		Me.ThayDoiQuyDinh.Text = "Thay đổi quy định"
		Me.ThayDoiQuyDinh.UseVisualStyleBackColor = True
		AddHandler Me.ThayDoiQuyDinh.Click, New System.EventHandler(AddressOf Me.ThayDoiQuyDinh_Click)
		' 
		' ThemMoiKhachHang
		' 
		Me.ThemMoiKhachHang.Location = New System.Drawing.Point(87, 300)
		Me.ThemMoiKhachHang.Name = "ThemMoiKhachHang"
		Me.ThemMoiKhachHang.Size = New System.Drawing.Size(115, 45)
		Me.ThemMoiKhachHang.TabIndex = 10
		Me.ThemMoiKhachHang.Text = "Thêm mới khách hàng"
		Me.ThemMoiKhachHang.UseVisualStyleBackColor = True
		AddHandler Me.ThemMoiKhachHang.Click, New System.EventHandler(AddressOf Me.ThemMoiKhachHang_Click)
		' 
		' ThemMoiSach
		' 
		Me.ThemMoiSach.Location = New System.Drawing.Point(245, 242)
		Me.ThemMoiSach.Name = "ThemMoiSach"
		Me.ThemMoiSach.Size = New System.Drawing.Size(115, 33)
		Me.ThemMoiSach.TabIndex = 11
		Me.ThemMoiSach.Text = "Thêm mới sách"
		Me.ThemMoiSach.UseVisualStyleBackColor = True
		AddHandler Me.ThemMoiSach.Click, New System.EventHandler(AddressOf Me.ThemMoiSach_Click)
		' 
		' close
		' 
		Me.close.Location = New System.Drawing.Point(245, 300)
		Me.close.Name = "close"
		Me.close.Size = New System.Drawing.Size(115, 45)
		Me.close.TabIndex = 12
		Me.close.Text = "Thoát"
		Me.close.UseVisualStyleBackColor = True
		AddHandler Me.close.Click, New System.EventHandler(AddressOf Me.close_Click)
		' 
		' MainForm
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(445, 371)
		Me.Controls.Add(Me.close)
		Me.Controls.Add(Me.ThemMoiSach)
		Me.Controls.Add(Me.ThemMoiKhachHang)
		Me.Controls.Add(Me.ThayDoiQuyDinh)
		Me.Controls.Add(Me.LapBaoCaoTon)
		Me.Controls.Add(Me.LapBaoCaoCongNo)
		Me.Controls.Add(Me.LapPhieuThuTien)
		Me.Controls.Add(Me.TraCuuSach)
		Me.Controls.Add(Me.LapHoaDonBanSach)
		Me.Controls.Add(Me.LapPhieuNhapSach)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.comboBox1)
		Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.Name = "MainForm"
		Me.Text = "FormMenu"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	#End Region

	Private comboBox1 As System.Windows.Forms.ComboBox
	Private label1 As System.Windows.Forms.Label
	Private LapPhieuNhapSach As System.Windows.Forms.Button
	Private LapHoaDonBanSach As System.Windows.Forms.Button
	Private TraCuuSach As System.Windows.Forms.Button
	Private LapPhieuThuTien As System.Windows.Forms.Button
	Private LapBaoCaoCongNo As System.Windows.Forms.Button
	Private LapBaoCaoTon As System.Windows.Forms.Button
	Private ThayDoiQuyDinh As System.Windows.Forms.Button
	Private ThemMoiKhachHang As System.Windows.Forms.Button
	Private ThemMoiSach As System.Windows.Forms.Button
	Private close As System.Windows.Forms.Button
End Class
