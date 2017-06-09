Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports DAO
Imports DTO

Public Class BaoCaoCongNoBUS
	#Region "1. Inserting"
	Public Shared Function InsertBaoCaoCongNo(baocaocongno As BaoCaoCongNoDTO) As Boolean
		Return BaoCaoCongNoDAO.InsertBaoCaoCongNo(baocaocongno)
	End Function

	Public Shared Function UpdateBaoCaoCongNo(baocaocongno As BaoCaoCongNoDTO) As Boolean
		Return BaoCaoCongNoDAO.UpdateBaoCaoCongNo(baocaocongno)
	End Function

	'public static BaoCaoCongNoDTO SelectBaoCaoCongNoByMaKhachHangvaThang(string maKhachHang, DateTime thang)
	'{
	'    return BaoCaoCongNoDAO.SelectBaoCaoCongNoByMaKhachHangvaThangHienTai(maKhachHang, thang);
	'}

	Public Shared Function SelectBaoCaoCongNoThangGanNhatByMaKhachHang(maKhachHang As String) As BaoCaoCongNoDTO
		Return BaoCaoCongNoDAO.SelectBaoCaoCongNoThangGanNhatByMaKhachHang(maKhachHang)
	End Function

	Public Shared Function SelectBaoCaoCongNoByThang(thang As DateTime) As List(Of BaoCaoCongNoDTO)
		Return BaoCaoCongNoDAO.SelectBaoCaoCongNoByThang(thang)
	End Function


	Public Shared Function CheckBaoCaoCongNoByMaKhachHangvaThang(maKhachHang As String, thang As DateTime) As Boolean
		Return BaoCaoCongNoDAO.CheckBaoCaoCongNoByMaKhachHangvaThang(maKhachHang, thang)
	End Function

	Public Shared Function GenerateNewMaBaoCaoCongNo() As String
		Return BaoCaoCongNoDAO.GenerateNewMaBaoCaoCongNo()
	End Function

	#End Region
End Class
