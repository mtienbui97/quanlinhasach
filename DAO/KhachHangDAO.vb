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

Public Class KhachHangDAO
    Public Shared Function InsertKhachHang(khachhang As KhachHangDTO) As Boolean
        Dim result = False
        Try
            Dim parameters As New List(Of MySqlParameter)()
            parameters.Add(New MySqlParameter("p_MaKhachHang", khachhang.MaKhachHang))
            parameters.Add(New MySqlParameter("p_HoTenKhachHang", khachhang.HoTenKhachHang))
            parameters.Add(New MySqlParameter("p_DiaChi", khachhang.DiaChi))
            parameters.Add(New MySqlParameter("p_DienThoai", khachhang.SoDienThoai))
            parameters.Add(New MySqlParameter("p_SoTienNo", khachhang.SoTienNo))
            parameters.Add(New MySqlParameter("p_Email", khachhang.Email))
            parameters.Add(New MySqlParameter("P_TinhTrang", khachhang.TinhTrang))
            Dim n = DataAccessHelper.ExecuteNonQuery("InsertKhachHang", parameters)
            If n = 1 Then
                result = True
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return result
    End Function
    Public Shared Function UpdateKhachHang(khachhang As KhachHangDTO) As Boolean
        Dim result = False
        Try
            Dim parameters As New List(Of MySqlParameter)()
            parameters.Add(New MySqlParameter("p_MaKhachHang", khachhang.MaKhachHang))
            parameters.Add(New MySqlParameter("p_HoTenKhachHang", khachhang.HoTenKhachHang))
            parameters.Add(New MySqlParameter("p_DiaChi", khachhang.DiaChi))
            parameters.Add(New MySqlParameter("p_SoDienThoai", khachhang.SoDienThoai))
            parameters.Add(New MySqlParameter("p_SoTienNo", khachhang.SoTienNo))
            parameters.Add(New MySqlParameter("p_Email", khachhang.Email))
            parameters.Add(New MySqlParameter("P_TinhTrang", khachhang.TinhTrang))
            Dim n = DataAccessHelper.ExecuteNonQuery("UpdateKhachHang", parameters)
            If n = 1 Then
                result = True
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return result
    End Function
    Public Shared Function DeleteKhachByMaKhachHang(maKhachHang As String) As Boolean
        Dim result = False
        Try
            Dim parameters As New List(Of MySqlParameter)()
            parameters.Add(New MySqlParameter("p_MaKhachHang", maKhachHang))
            Dim n = DataAccessHelper.ExecuteNonQuery("DeleteKhachHangByMaKhachHang", parameters)
            If n = 1 Then
                result = True
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return result
    End Function
    Public Shared Function SelectKhachHangAll() As List(Of KhachHangDTO)
        Dim list = New List(Of KhachHangDTO)()
        Try
            Dim dt = DataAccessHelper.ExecuteQuery("SelectKhachHangAll")
            list.AddRange(From dr In dt.Rows Select New KhachHangDTO() With { 
                .MaKhachHang = dr("MaSach").ToString(), 
                .HoTenKhachHang = dr("HoTenKhachHang").ToString(), 
                .DiaChi = dr("DiaChi").ToString(), 
                .SoDienThoai = dr("SoDienThoai").ToString(), 
                .Email = dr("Email").ToString(), 
                .SoTienNo = Decimal.Parse(dr("SoTienNo").ToString()) 
            })
        Catch ex As Exception
            Throw ex
        End Try
        Return list
    End Function
    Public Shared Function SelectKhachHangByMaKhachHang(maKhachHang As String) As KhachHangDTO
        Dim khachhang = New KhachHangDTO()
        Try
            Dim parameters As New List(Of MySqlParameter)()
            parameters.Add(New MySqlParameter("p_MaKhachHang", maKhachHang))
            Dim dt = DataAccessHelper.ExecuteQuery("SelectKhachHangByMaKhachHang", parameters)
            Dim dr = dt.Rows(0)
            khachhang.MaKhachHang = dr("MaKhachHang").ToString()
            khachhang.HoTenKhachHang = dr("HoTenKhachHang").ToString()
            khachhang.DiaChi = dr("DiaChi").ToString()
            khachhang.SoDienThoai = dr("DienThoai").ToString()
            khachhang.Email = dr("Email").ToString()
            khachhang.SoTienNo = Decimal.Parse(dr("SoTienNo").ToString())
        Catch ex As Exception
            Throw ex
        End Try
        Return khachhang
    End Function
    Public Shared Function CheckKhachHangByMaKhachHang(maKhachHang As String) As Boolean
        Dim result = False
        Try
            Dim parameters As New List(Of MySqlParameter)()
            parameters.Add(New MySqlParameter("p_maKhachHang", maKhachHang))
            Dim dt = DataAccessHelper.ExecuteQuery("SelectKhachHangByMaKhachHang", parameters)
            If dt.Rows.Count = 1 Then
                result = True
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return result
    End Function
    Public Shared Function GenerateNewMaKhachHang() As String
        Dim newMaKhachHang As String = ""
        Try
            Dim dt = DataAccessHelper.ExecuteQuery("GenerateNewMaKhachHang")
            Dim temp As Integer = Integer.Parse(dt.Rows(0)("NewMaKhachHang").ToString())
            newMaKhachHang = $"KH{temp:0000}"
            Return newMaKhachHang
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
