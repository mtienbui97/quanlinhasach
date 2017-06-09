Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Imports DAO

Imports DTO

Public Class HoaDonBUS
	#Region "1. Inserting"

	Public Shared Function InsertHoaDon(HoaDon As HoaDonDTO, listChiTietHoaDon As List(Of ChiTietHoaDonDTO)) As Boolean
		Dim baocaoton_moi = New BaoCaoTonDTO()
		Dim baocaoton_truoc = New BaoCaoTonDTO()

		If KhachHangDAO.SelectKhachHangByMaKhachHang(HoaDon.MaKhachHang).SoTienNo > ThamSoDAO.SelectThamSoAll().SoTienNoToiDa Then
			Throw New Exception("Khách hàng có mã {HoaDon.MaKhachHang} có nợ nhiều hơn {ThamSoDAO.SelectThamSoAll().SoTienNoToiDa}")
		End If

		For Each chiTietHoaDon In listChiTietHoaDon

			If (SachDAO.SelectSachByMaSach(chiTietHoaDon.MaSach).SoLuongTon - chiTietHoaDon.SoLuongBan) < ThamSoDAO.SelectThamSoAll().SoLuongTonToiThieuSauBan Then
				Throw New Exception("Sách có mã {chiTietHoaDon.MaSach} có số lượng tồn sau bán ít hơn {ThamSoDAO.SelectThamSoAll().SoLuongTonToiThieuSauBan}")
			End If
		Next

		HoaDonDAO.InsertHoaDon(HoaDon)
		For Each chiTietHoaDon In listChiTietHoaDon
			chiTietHoaDon.MaChiTietHoaDon = ChiTietHoaDonDAO.GenerateNewMaChiTietHoaDon()
			baocaoton_truoc = BaoCaoTonBUS.SelectBaoCaoTonThangGanNhatByMaSach(chiTietHoaDon.MaSach)

			ChiTietHoaDonDAO.InsertChiTietHoaDon(chiTietHoaDon)
			Dim sach As SachDTO = SachDAO.SelectSachByMaSach(chiTietHoaDon.MaSach)
			sach.SoLuongTon += chiTietHoaDon.SoLuongBan
			SachDAO.UpdateSach(sach)
			baocaoton_moi.MaSach = sach.MaSach
			baocaoton_moi.Thang = HoaDon.NgayLapHoaDon

			If HoaDon.NgayLapHoaDon.[Date].ToString() = "1" Then
				baocaoton_moi.TonDau = baocaoton_truoc.TonCuoi
			End If

			If baocaoton_moi.TonDau = sach.SoLuongTon Then
				baocaoton_moi.TonPhatSinh = 0
				baocaoton_moi.TonCuoi = sach.SoLuongTon
			End If

			baocaoton_moi.TonCuoi = InlineAssignHelper(baocaoton_moi.TonCuoi, chiTietHoaDon.SoLuongBan)
			baocaoton_moi.TonPhatSinh = baocaoton_moi.TonPhatSinh - chiTietHoaDon.SoLuongBan
			sach.SoLuongTon = sach.SoLuongTon - chiTietHoaDon.SoLuongBan

			If baocaoton_truoc.Thang.Month = HoaDon.NgayLapHoaDon.Month Then
				baocaoton_moi.MaChiTietTon = baocaoton_truoc.MaChiTietTon
				baocaoton_moi.Thang = baocaoton_truoc.Thang
				If BaoCaoTonBUS.UpdateBaoCaoTon(baocaoton_moi) Then
					Return True
				Else
					Return False
				End If
			Else
				baocaoton_moi.MaChiTietTon = BaoCaoTonBUS.GenerateNewMaBaoCaoTon()
				baocaoton_moi.Thang = HoaDon.NgayLapHoaDon
				If BaoCaoTonBUS.InsertBaoCaoTon(baocaoton_moi) Then
					Return True
				Else
					Return False
				End If

			End If
		Next

		Return True
	End Function

	#End Region
	#Region "2. Update"

	#End Region
	#Region "4. Retrieving"

	Public Shared Function GenerateNewMaHoaDon() As String
		Return HoaDonDAO.GenerateNewMaHoaDon()
	End Function
	Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
		target = value
		Return value
	End Function

	#End Region
End Class
