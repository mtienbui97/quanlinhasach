Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Public Partial Class MainForm
	Inherits Form
	Public Sub New()
		InitializeComponent()
		comboBox1.Items.Add("Chủ nhà sách")
		comboBox1.Items.Add("Nhân viên")
		comboBox1.Items.Add("Khác")
		comboBox1.SelectedIndex = 0
	End Sub

	Private Sub comboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
		If comboBox1.SelectedItem Is Nothing Then
			ThayDoiQuyDinh.Enabled = False
			TraCuuSach.Enabled = False
			LapPhieuNhapSach.Enabled = False
			LapBaoCaoCongNo.Enabled = False
			LapBaoCaoTon.Enabled = False
			LapPhieuThuTien.Enabled = False
			LapHoaDonBanSach.Enabled = False
			ThemMoiSach.Enabled = False
			ThemMoiKhachHang.Enabled = False
		End If
		Select Case comboBox1.SelectedItem.ToString()
			Case "Nhân viên"
				ThayDoiQuyDinh.Enabled = False
				TraCuuSach.Enabled = True
				LapPhieuNhapSach.Enabled = True
				LapBaoCaoCongNo.Enabled = True
				LapBaoCaoTon.Enabled = True
				LapPhieuThuTien.Enabled = True
				LapHoaDonBanSach.Enabled = True
				ThemMoiSach.Enabled = False
				ThemMoiKhachHang.Enabled = False
				Exit Select
			Case "Khác"
				ThayDoiQuyDinh.Enabled = False
				TraCuuSach.Enabled = True
				LapPhieuNhapSach.Enabled = False
				LapBaoCaoCongNo.Enabled = False
				LapBaoCaoTon.Enabled = False
				LapPhieuThuTien.Enabled = False
				LapHoaDonBanSach.Enabled = False
				ThemMoiSach.Enabled = False
				ThemMoiKhachHang.Enabled = False
				Exit Select
			Case "Chủ nhà sách"
				ThayDoiQuyDinh.Enabled = True
				TraCuuSach.Enabled = True
				LapPhieuNhapSach.Enabled = False
				LapBaoCaoCongNo.Enabled = False
				LapBaoCaoTon.Enabled = False
				LapPhieuThuTien.Enabled = False
				LapHoaDonBanSach.Enabled = False
				ThemMoiSach.Enabled = True
				ThemMoiKhachHang.Enabled = True
				Exit Select
		End Select
	End Sub

	Private Sub LapPhieuNhapSach_Click(sender As Object, e As EventArgs)
		Dim form = New FormLapPhieuNhapSach()
		form.Show()
	End Sub

	Private Sub LapHoaDonBanSach_Click(sender As Object, e As EventArgs)
		Dim form = New FormLapHoaDon()
		form.Show()
	End Sub

	Private Sub TraCuuSach_Click(sender As Object, e As EventArgs)
		Dim form = New FormDanhSachSach()
		form.Show()
	End Sub

	Private Sub LapPhieuThuTien_Click(sender As Object, e As EventArgs)
		Dim form = New FormPhieuThuTien()
		form.Show()
	End Sub

	Private Sub LapBaoCaoCongNo_Click(sender As Object, e As EventArgs)
		Dim form = New FormBaoCaoCongNo()
		form.Show()
	End Sub

	Private Sub LapBaoCaoTon_Click(sender As Object, e As EventArgs)
		Dim form = New FormBaoCaoTon()
		form.Show()
	End Sub

	Private Sub ThayDoiQuyDinh_Click(sender As Object, e As EventArgs)
		Dim form = New FormThayDoiQuyDinh()
		form.Show()
	End Sub

	Private Sub ThemMoiSach_Click(sender As Object, e As EventArgs)
		Dim form = New SACH.FormImportSach()
		form.Show()
	End Sub

	Private Sub ThemMoiKhachHang_Click(sender As Object, e As EventArgs)
		Dim form = New KHACHHANG.FormImportKhachHang()
		form.Show()
	End Sub

	Private Sub close_Click(sender As Object, e As EventArgs)
		Application.[Exit]()
	End Sub
End Class
