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

    Public Class BaoCaoTonDAO
        Public Shared Function InsertBaoCaoTon(BaoCaoTon As BaoCaoTonDTO) As Boolean
            Dim result = False
            Try
                Dim parameters As New List(Of MySqlParameter)()
                parameters.Add(New MySqlParameter("p_MaChiTietTon", BaoCaoTon.MaChiTietTon))
                parameters.Add(New MySqlParameter("p_Thang", BaoCaoTon.Thang))
                parameters.Add(New MySqlParameter("p_MaSach", BaoCaoTon.MaSach))
                parameters.Add(New MySqlParameter("p_TonDau", BaoCaoTon.TonDau))
                parameters.Add(New MySqlParameter("p_TonCuoi", BaoCaoTon.TonCuoi))
                parameters.Add(New MySqlParameter("p_TonPhatSinh", BaoCaoTon.TonPhatSinh))
                Dim n = DataAccessHelper.ExecuteNonQuery("InsertBaoCaoTon", parameters)
                If n = 1 Then
                    result = True
                End If
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
        Public Shared Function UpdateBaoCaoTon(BaoCaoTon As BaoCaoTonDTO) As Boolean
            Dim result = False
            Try
                Dim parameters As New List(Of MySqlParameter)()
                parameters.Add(New MySqlParameter("p_MaChiTietTon", BaoCaoTon.MaChiTietTon))
                parameters.Add(New MySqlParameter("p_Thang", BaoCaoTon.Thang))
                parameters.Add(New MySqlParameter("p_MaSach", BaoCaoTon.MaSach))
                parameters.Add(New MySqlParameter("p_TonDau", BaoCaoTon.TonDau))
                parameters.Add(New MySqlParameter("p_TonCuoi", BaoCaoTon.TonCuoi))
                parameters.Add(New MySqlParameter("p_TonPhatSinh", BaoCaoTon.TonPhatSinh))
                Dim n = DataAccessHelper.ExecuteNonQuery("UpdateBaoCaoTon", parameters)
                If n = 1 Then
                    result = True
                End If
            Catch ex As Exception
                Console.WriteLine(ex.ToString())
            End Try
            Return result
        End Function
        Public Shared Function SelectBaoCaoTonAll() As List(Of BaoCaoTonDTO)
            Dim list = New List(Of BaoCaoTonDTO)()
            Try
                Dim dt = DataAccessHelper.ExecuteQuery("SelectBaoCaoTonAll")
                list.AddRange(From dr In dt.Rows Select New BaoCaoTonDTO() With { 
                    .MaChiTietTon = dr("MaChiTietTon").ToString(), 
                    .Thang = DateTime.Parse(dr("Thang").ToString()), 
                    .MaSach = dr("MaSach").ToString(), 
                    .TonCuoi = Decimal.Parse(dr("TonCuoi").ToString()), 
                    .TonDau = Decimal.Parse(dr("TonDau").ToString()), 
                    .TonPhatSinh = Decimal.Parse(dr("TonPhatSinh").ToString()) 
                })
            Catch ex As Exception
                Throw ex
            End Try
            Return list
        End Function
        Public Shared Function SelectBaoCaoTonByThang(thang As DateTime) As List(Of BaoCaoTonDTO)
            Dim list = New List(Of BaoCaoTonDTO)()
            Dim parameters As New List(Of MySqlParameter)()
            parameters.Add(New MySqlParameter("p_Thang", thang))
            Try
                Dim dt = DataAccessHelper.ExecuteQuery("SelectBaoCaoTonByThang", parameters)
                list.AddRange(From dr In dt.Rows Select New BaoCaoTonDTO() With { _
                    .MaChiTietTon = dr("MaChiTietTon").ToString(), _
                    .Thang = DateTime.Parse(dr("Thang").ToString()), _
                    .MaSach = dr("MaSach").ToString(), _
                    .TonCuoi = Decimal.Parse(dr("TonCuoi").ToString()), _
                    .TonDau = Decimal.Parse(dr("TonDau").ToString()), _
                    .TonPhatSinh = Decimal.Parse(dr("TonPhatSinh").ToString()) _
                })
            Catch ex As Exception
                Throw ex
            End Try
            Return list
        End Function
        Public Shared Function SelectBaoCaoTonByMaBaoCaoTon(maChiTietTon As String) As BaoCaoTonDTO
            Dim BaoCaoTon = New BaoCaoTonDTO()
            Try
                Dim parameters As New List(Of MySqlParameter)()
                parameters.Add(New MySqlParameter("p_MaChiTietTon", maChiTietTon))
                Dim dt = DataAccessHelper.ExecuteQuery("SelectBaoCaoTonByMaBaoCaoTon", parameters)
                Dim dr = dt.Rows(0)
                BaoCaoTon.MaChiTietTon = dr("MaChiTietTon").ToString()
                BaoCaoTon.Thang = DateTime.Parse(dr("Thang").ToString())
            Catch ex As Exception
                Throw ex
            End Try
            Return BaoCaoTon
        End Function
        Public Shared Function SelectBaoCaoTonThangGanNhatByMaSach(MaSach As String) As BaoCaoTonDTO
            Dim baocaoTon = New BaoCaoTonDTO()
            Try
                Dim parameters As New List(Of MySqlParameter)()
                parameters.Add(New MySqlParameter("p_MaSach", MaSach))
                Dim dt = DataAccessHelper.ExecuteQuery("SelectBaoCaoTonThangGanNhatByMaSach", parameters)
                Dim dr = dt.Rows(0)
                baocaoTon.MaChiTietTon = dr("MaChiTietTon").ToString()
                baocaoTon.Thang = DateTime.Parse(dr("Thang").ToString())
                baocaoTon.MaSach = dr("MaSach").ToString()
                baocaoTon.TonCuoi = Decimal.Parse(dr("TonCuoi").ToString())
                baocaoTon.TonDau = Decimal.Parse(dr("TonDau").ToString())
                baocaoTon.TonPhatSinh = Decimal.Parse(dr("TonPhatSinh").ToString())
            Catch ex As Exception
                Throw ex
            End Try
            Return baocaoTon
        End Function
        Public Shared Function CheckBaoCaoTonByMaSachvaThang(MaSach As String, thang As DateTime) As Boolean
            Dim result = False
            Try
                Dim parameters As New List(Of MySqlParameter)()
                parameters.Add(New MySqlParameter("p_MaSach", MaSach))
                parameters.Add(New MySqlParameter("p_Thang", thang))
                Dim dt = DataAccessHelper.ExecuteQuery("CheckBaoCaoTonByMaSachvaThang", parameters)
                If dt.Rows.Count = 1 Then
                    result = True
                End If
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
        Public Shared Function GenerateNewMaBaoCaoTon() As String
            Dim newMaBaoCaoTon As String = ""
            Try
                Dim dt = DataAccessHelper.ExecuteQuery("GenerateNewMaBaoCaoTon")
                Dim temp As Integer = Integer.Parse(dt.Rows(0)("NewMaBaoCaoTon").ToString())
                newMaBaoCaoTon = $"BCTO{temp:0000}"
                Return newMaBaoCaoTon
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class

