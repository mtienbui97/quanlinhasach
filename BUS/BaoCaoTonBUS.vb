Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports DAO
Imports DTO

Public Class BaoCaoTonBUS
	#Region "1. Inserting"
	Public Shared Function InsertBaoCaoTon(baocaoTon As BaoCaoTonDTO) As Boolean
		Return BaoCaoTonDAO.InsertBaoCaoTon(baocaoTon)
	End Function

	Public Shared Function UpdateBaoCaoTon(baocaoTon As BaoCaoTonDTO) As Boolean
		Return BaoCaoTonDAO.UpdateBaoCaoTon(baocaoTon)
	End Function

	Public Shared Function SelectBaoCaoTonByThang(thang As DateTime) As List(Of BaoCaoTonDTO)
		Return BaoCaoTonDAO.SelectBaoCaoTonByThang(thang)
	End Function

	'public static BaoCaoTonDTO SelectBaoCaoTonByMaKhachHangvaThang(string maKhachHang, DateTime thang)
	'{
	'    return BaoCaoTonDAO.SelectBaoCaoTonByMaKhachHangvaThangHienTai(maKhachHang, thang);
	'}

	Public Shared Function SelectBaoCaoTonThangGanNhatByMaSach(maSach As String) As BaoCaoTonDTO

		Return BaoCaoTonDAO.SelectBaoCaoTonThangGanNhatByMaSach(maSach)
	End Function


	Public Shared Function CheckBaoCaoTonByMaKhachHangvaThang(maSach As String, thang As DateTime) As Boolean
		Return BaoCaoTonDAO.CheckBaoCaoTonByMaSachvaThang(maSach, thang)
	End Function

	Public Shared Function GenerateNewMaBaoCaoTon() As String
		Return BaoCaoTonDAO.GenerateNewMaBaoCaoTon()
	End Function

	#End Region
End Class
