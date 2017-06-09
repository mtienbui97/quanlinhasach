Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Imports DAO

Imports DTO

Public Class PhieuNhapBUS
	#Region "1. Inserting"

	Public Shared Function InsertPhieuNhap(phieuNhap As PhieuNhapDTO, listChiTietPhieuNhap As List(Of ChiTietPhieuNhapDTO)) As Boolean
		Dim baocaoton_moi = New BaoCaoTonDTO()
		Dim baocaoton_truoc = New BaoCaoTonDTO()

		If PhieuNhapDAO.CheckPhieuNhapByMaPhieuNhap(phieuNhap.MaPhieuNhap) Then
			Throw New Exception("Mã phiếu nhập đã tồn tại")
		End If

        For Each chiTietPhieuNhap In listChiTietPhieuNhap
            chiTietPhieuNhap.MaChiTietPhieuNhap = ChiTietPhieuNhapDAO.GenerateNewMaChiTietPhieuNhap()
            If ChiTietPhieuNhapDAO.CheckChiTietPhieuNhapByMaChiTietPhieuNhap(chiTietPhieuNhap.MaChiTietPhieuNhap) Then
                Throw New Exception("Mã chi tiết phiếu nhập đã tồn tại")
            End If

            If chiTietPhieuNhap.SoLuongNhap < ThamSoDAO.SelectThamSoAll().SoLuongNhapItNhat Then
                Throw New Exception("Sách có mã {chiTietPhieuNhap.MaSach} có số lượng nhập ít hơn {ThamSoDAO.SelectThamSoAll( ).SoLuongNhapItNhat}")
            End If

            If SachDAO.SelectSachByMaSach(chiTietPhieuNhap.MaSach).SoLuongTon > ThamSoDAO.SelectSoLuongTonToiDaTruocNhap() Then
                Throw New Exception("Sách có mã {chiTietPhieuNhap.MaSach} có số lượng tồn nhiều hơn {ThamSoDAO.SelectSoLuongTonToiDaTruocNhap()}")
            End If
        Next

        PhieuNhapDAO.InsertPhieuNhap(phieuNhap)
		For Each chiTietPhieuNhap In listChiTietPhieuNhap
			chiTietPhieuNhap.MaChiTietPhieuNhap = ChiTietPhieuNhapDAO.GenerateNewMaChiTietPhieuNhap()
			baocaoton_truoc = BaoCaoTonBUS.SelectBaoCaoTonThangGanNhatByMaSach(chiTietPhieuNhap.MaSach)

			ChiTietPhieuNhapDAO.InsertChiTietPhieuNhap(chiTietPhieuNhap)
			Dim sach As SachDTO = SachDAO.SelectSachByMaSach(chiTietPhieuNhap.MaSach)
			sach.SoLuongTon += chiTietPhieuNhap.SoLuongNhap
			SachDAO.UpdateSach(sach)
			baocaoton_moi.MaSach = sach.MaSach
			baocaoton_moi.Thang = phieuNhap.NgayNhap

			If phieuNhap.NgayNhap.[Date].ToString() = "1" Then
				baocaoton_moi.TonDau = baocaoton_truoc.TonCuoi
			End If

			If baocaoton_moi.TonDau = sach.SoLuongTon Then
				baocaoton_moi.TonPhatSinh = 0
				baocaoton_moi.TonCuoi = sach.SoLuongTon
			End If

			baocaoton_moi.TonCuoi = InlineAssignHelper(baocaoton_moi.TonCuoi, chiTietPhieuNhap.SoLuongNhap)
			baocaoton_moi.TonPhatSinh = baocaoton_moi.TonPhatSinh + chiTietPhieuNhap.SoLuongNhap
			sach.SoLuongTon = sach.SoLuongTon + chiTietPhieuNhap.SoLuongNhap

			If baocaoton_truoc.Thang.Month = phieuNhap.NgayNhap.Month Then
				baocaoton_moi.MaChiTietTon = baocaoton_truoc.MaChiTietTon
				baocaoton_moi.Thang = baocaoton_truoc.Thang
				If BaoCaoTonBUS.UpdateBaoCaoTon(baocaoton_moi) Then
					Return True
				Else
					Return False
				End If
			Else
				baocaoton_moi.MaChiTietTon = BaoCaoTonBUS.GenerateNewMaBaoCaoTon()
				baocaoton_moi.Thang = phieuNhap.NgayNhap
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

	Public Shared Function GenerateNewMaPhieuNhap() As String
		Return PhieuNhapDAO.GenerateNewMaPhieuNhap()
	End Function
	Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
		target = value
		Return value
	End Function

	#End Region
End Class
