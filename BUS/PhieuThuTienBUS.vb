Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports DAO
Imports DTO

Public Class PhieuThuTienBUS
	Public Shared Function InsertPhieuThuTien(phieuthu As PhieuThuTienDTO) As Boolean
		Dim baocaocongno_moi = New BaoCaoCongNoDTO()
		Dim baocaocongno_truoc = New BaoCaoCongNoDTO()
		baocaocongno_truoc = BaoCaoCongNoBUS.SelectBaoCaoCongNoThangGanNhatByMaKhachHang(phieuthu.MaKhachHang)
		Dim khachhang = KhachHangDAO.SelectKhachHangByMaKhachHang(phieuthu.MaKhachHang)
		baocaocongno_moi.MaKhachHang = khachhang.MaKhachHang



		If ThamSoBUS.CheckApDungQuiDinh4() Then
			phieuthu.SoTienThu = khachhang.SoTienNo
		End If


		If phieuthu.NgayThu.[Date].ToString() = "1" Then
			baocaocongno_moi.NoDau = baocaocongno_truoc.NoCuoi
		End If

		If baocaocongno_moi.NoDau = khachhang.SoTienNo Then
			baocaocongno_moi.NoPhatSinh = 0
			baocaocongno_moi.NoCuoi = khachhang.SoTienNo
		End If

		baocaocongno_moi.NoCuoi = InlineAssignHelper(baocaocongno_moi.NoCuoi, phieuthu.SoTienThu)
		baocaocongno_moi.NoPhatSinh = baocaocongno_moi.NoPhatSinh - phieuthu.SoTienThu
		khachhang.SoTienNo = khachhang.SoTienNo - phieuthu.SoTienThu
		' if (ton tai bao cao cong no cua Thang hien tai)
		' { update}
		' else {insert}
		If baocaocongno_truoc.Thang.Month = phieuthu.NgayThu.Month Then
			baocaocongno_moi.MaChiTietCongNo = baocaocongno_truoc.MaChiTietCongNo
			baocaocongno_moi.Thang = baocaocongno_truoc.Thang
			If BaoCaoCongNoBUS.UpdateBaoCaoCongNo(baocaocongno_moi) Then
				If PhieuThuTienDAO.InsertPhieuThu(phieuthu) Then
					Return True
				Else
					Return False
				End If
			Else
				Return False
			End If
		Else
			baocaocongno_moi.MaChiTietCongNo = BaoCaoCongNoBUS.GenerateNewMaBaoCaoCongNo()
			baocaocongno_moi.Thang = phieuthu.NgayThu
			If BaoCaoCongNoBUS.InsertBaoCaoCongNo(baocaocongno_moi) Then
				If PhieuThuTienDAO.InsertPhieuThu(phieuthu) Then
					Return True
				Else
					Return False
				End If
			Else
				Return False
			End If
		End If

	End Function

	Public Shared Function GenerateNewMaPhieuThu() As String
		Return PhieuThuTienDAO.GenerateNewMaPhieuThu()
	End Function
	Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
		target = value
		Return value
	End Function
End Class
