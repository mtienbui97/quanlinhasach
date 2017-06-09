Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports BUS
Imports DTO

Public Partial Class FormPhieuThuTien
	Inherits Form

	Public Sub New()
		InitializeComponent()
	End Sub

	Private Sub FormPhieuThuTien_Load(sender As Object, e As EventArgs)
		RefreshForm()
	End Sub

	Private Sub RefreshForm()
		maphieu_tb.Text = PhieuThuTienBUS.GenerateNewMaPhieuThu()
		makh_tb.Text = ""
		ten_tb.Text = ""
		diachi_tb.Text = ""
		sdt_tb.Text = ""
		email_tb.Text = ""
		sotienthu_tb.Text = "0"
		dateTimePicker1.Value = DateTime.Now
	End Sub

	Private Sub refresh_Click(sender As Object, e As EventArgs)
		RefreshForm()
	End Sub

	Private Sub makh_tb_TextChanged(sender As Object, e As EventArgs)
		Dim khachhang = New KhachHangDTO()
		Dim makhachhang As String = ""
		If makh_tb.Text.Length = 6 Then
			makhachhang = makh_tb.Text
			If KhachHangBUS.CheckKhachHangByMaKhachHang(makhachhang) Then
				khachhang = KhachHangBUS.SelectKhachHangByMaKhachHang(makhachhang)
			Else
				MessageBox.Show("Mã khách hàng không tồn tại")
			End If

			makh_tb.Text = khachhang.MaKhachHang
			ten_tb.Text = khachhang.HoTenKhachHang
			diachi_tb.Text = khachhang.DiaChi
			sdt_tb.Text = khachhang.SoDienThoai
			email_tb.Text = khachhang.Email
		End If
		'else {do nothing}
	End Sub

	Private Sub lapphieu_button_Click(sender As Object, e As EventArgs)
		Dim phieuthu = New PhieuThuTienDTO()
		phieuthu.MaPhieuThu = maphieu_tb.Text
		phieuthu.MaKhachHang = makh_tb.Text
		phieuthu.NgayThu = DateTime.Parse(dateTimePicker1.Text)
		phieuthu.SoTienThu = Decimal.Parse(sotienthu_tb.Text)
		If PhieuThuTienBUS.InsertPhieuThuTien(phieuthu) Then
			MessageBox.Show("Thành công!")
		Else
			MessageBox.Show("Thất bại!")
		End If
	End Sub
End Class
