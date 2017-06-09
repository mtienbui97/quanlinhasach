Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Globalization
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports DTO

Public Class BaoCaoCongNoDAO
    Public Shared Function InsertBaoCaoCongNo(BaoCaoCongNo As BaoCaoCongNoDTO) As Boolean
        Dim result = False
        Try
            Dim parameters As New List(Of MySqlParameter)()
            parameters.Add(New MySqlParameter("p_MaChiTietCongNo", BaoCaoCongNo.MaChiTietCongNo))
            parameters.Add(New MySqlParameter("p_NgayNhap", BaoCaoCongNo.Thang))
            parameters.Add(New MySqlParameter("p_MaKhachHang", BaoCaoCongNo.MaKhachHang))
            parameters.Add(New MySqlParameter("p_NoDau", BaoCaoCongNo.NoDau))
            parameters.Add(New MySqlParameter("p_NoCuoi", BaoCaoCongNo.NoCuoi))
            parameters.Add(New MySqlParameter("p_NoPhatSinh", BaoCaoCongNo.NoPhatSinh))
            Dim n = DataAccessHelper.ExecuteNonQuery("InsertBaoCaoCongNo", parameters)
            If n = 1 Then
                result = True
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return result
    End Function
    Public Shared Function SelectBaoCaoCongNoByThang(thang As DateTime) As List(Of BaoCaoCongNoDTO)
        Dim list = New List(Of BaoCaoCongNoDTO)()
        Dim parameters As New List(Of MySqlParameter)()
        parameters.Add(New MySqlParameter("p_Thang", thang))
        Try
            Dim dt = DataAccessHelper.ExecuteQuery("SelectBaoCaoCongNoByThang", parameters)
            list.AddRange(From dr In dt.Rows Select New BaoCaoCongNoDTO() With { 
                .MaChiTietCongNo = dr("MaChiTietCongNo").ToString(), 
                .Thang = DateTime.Parse(dr("Thang").ToString()), 
                .MaKhachHang = dr("MaKhachHang").ToString(), 
                .NoCuoi = Decimal.Parse(dr("NoCuoi").ToString()), 
                .NoDau = Decimal.Parse(dr("NoDau").ToString()), 
                .NoPhatSinh = Decimal.Parse(dr("NoPhatSinh").ToString()) 
            })
        Catch ex As Exception
            Throw ex
        End Try
        Return list
    End Function
    Public Shared Function UpdateBaoCaoCongNo(BaoCaoCongNo As BaoCaoCongNoDTO) As Boolean
        Dim result = False
        Try
            Dim parameters As New List(Of MySqlParameter)()
            parameters.Add(New MySqlParameter("p_MaChiTietCongNo", BaoCaoCongNo.MaChiTietCongNo))
            parameters.Add(New MySqlParameter("p_Thang", BaoCaoCongNo.Thang))
            parameters.Add(New MySqlParameter("p_MaKhachHang", BaoCaoCongNo.MaKhachHang))
            parameters.Add(New MySqlParameter("p_NoDau", BaoCaoCongNo.NoDau))
            parameters.Add(New MySqlParameter("p_NoCuoi", BaoCaoCongNo.NoCuoi))
            parameters.Add(New MySqlParameter("p_NoPhatSinh", BaoCaoCongNo.NoPhatSinh))
            Dim n = DataAccessHelper.ExecuteNonQuery("UpdateBaoCaoCongNo", parameters)
            If n = 1 Then
                result = True
            End If
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
        End Try
        Return result
    End Function
    Public Shared Function SelectBaoCaoCongNoAll() As List(Of BaoCaoCongNoDTO)
        Dim list = New List(Of BaoCaoCongNoDTO)()
        Try
            Dim dt = DataAccessHelper.ExecuteQuery("SelectBaoCaoCongNoAll")
            list.AddRange(From dr In dt.Rows Select New BaoCaoCongNoDTO() With { 
                .MaChiTietCongNo = dr("MaChiTietCongNo").ToString(), 
                .Thang = DateTime.Parse(dr("Thang").ToString()), 
                .MaKhachHang = dr("MaKhachHang").ToString(), 
                .NoCuoi = Decimal.Parse(dr("NoCuoi").ToString()), 
                .NoDau = Decimal.Parse(dr("NoDau").ToString()), 
                .NoPhatSinh = Decimal.Parse(dr("NoPhatSinh").ToString()) 
            })
        Catch ex As Exception
            Throw ex
        End Try
        Return list
    End Function
    Public Shared Function SelectBaoCaoCongNoByMaBaoCaoCongNo(maChiTietCongNo As String) As BaoCaoCongNoDTO
        Dim BaoCaoCongNo = New BaoCaoCongNoDTO()
        Try
            Dim parameters As New List(Of MySqlParameter)()
            parameters.Add(New MySqlParameter("p_MaChiTietCongNo", maChiTietCongNo))
            Dim dt = DataAccessHelper.ExecuteQuery("SelectBaoCaoCongNoByMaBaoCaoCongNo", parameters)
            Dim dr = dt.Rows(0)
            BaoCaoCongNo.MaChiTietCongNo = dr("MaChiTietCongNo").ToString()
            BaoCaoCongNo.Thang = DateTime.Parse(dr("Thang").ToString())
        Catch ex As Exception
            Throw ex
        End Try
        Return BaoCaoCongNo
    End Function
    Public Shared Function SelectBaoCaoCongNoThangGanNhatByMaKhachHang(maKhachHang As String) As BaoCaoCongNoDTO
        Dim baocaocongno = New BaoCaoCongNoDTO()
        Try
            Dim parameters As New List(Of MySqlParameter)()
            parameters.Add(New MySqlParameter("p_MaKhachHang", maKhachHang))
            Dim dt = DataAccessHelper.ExecuteQuery("SelectBaoCaoCongNoThangGanNhatByMaKhachHang", parameters)
            Dim dr = dt.Rows(0)
            baocaocongno.MaChiTietCongNo = dr("MaChiTietCongNo").ToString()
            baocaocongno.Thang = DateTime.Parse(dr("Thang").ToString())
            baocaocongno.MaKhachHang = dr("MaKhachHang").ToString()
            baocaocongno.NoCuoi = Decimal.Parse(dr("NoCuoi").ToString())
            baocaocongno.NoDau = Decimal.Parse(dr("NoDau").ToString())
            baocaocongno.NoPhatSinh = Decimal.Parse(dr("NoPhatSinh").ToString())
        Catch ex As Exception
            Throw ex
        End Try
        Return baocaocongno
    End Function
    Public Shared Function CheckBaoCaoCongNoByMaKhachHangvaThang(maKhachHang As String, thang As DateTime) As Boolean
        Dim result = False
        Try
            Dim parameters As New List(Of MySqlParameter)()
            parameters.Add(New MySqlParameter("p_MaKhachHang", maKhachHang))
            parameters.Add(New MySqlParameter("p_Thang", thang))
            Dim dt = DataAccessHelper.ExecuteQuery("CheckBaoCaoCongNoByMaKhachHangvaThang", parameters)
            If dt.Rows.Count = 1 Then
                result = True
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return result
    End Function
    Public Shared Function GenerateNewMaBaoCaoCongNo() As String
        Dim newMaBaoCaoCongNo As String = ""
        Try
            Dim dt = DataAccessHelper.ExecuteQuery("GenerateNewMaBaoCaoCongNo")
            Dim temp As Integer = Integer.Parse(dt.Rows(0)("NewMaBaoCaoCongNo").ToString())
            newMaBaoCaoCongNo = $"BCCN{temp:0000}"
            Return newMaBaoCaoCongNo
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class

