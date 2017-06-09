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

Public Class SachDAO
    Public Shared Function InsertSach(sach As SachDTO) As Boolean
        Dim result = False
        Try
            Dim parameters As New List(Of MySqlParameter)()
            parameters.Add(New MySqlParameter("p_MaSach", sach.MaSach))
            parameters.Add(New MySqlParameter("p_Tensach", sach.TenSach))
            parameters.Add(New MySqlParameter("p_TheLoai", sach.TheLoai))
            parameters.Add(New MySqlParameter("p_TacGia", sach.TacGia))
            parameters.Add(New MySqlParameter("p_SoLuongTon", sach.SoLuongTon))
            parameters.Add(New MySqlParameter("p_DonGia", sach.DonGia))
            parameters.Add(New MySqlParameter("P_TinhTrang", sach.TinhTrang))
            Dim n = DataAccessHelper.ExecuteNonQuery("InsertSach", parameters)
            If n = 1 Then
                result = True
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return result
    End Function
    Public Shared Function UpdateSach(sach As SachDTO) As Boolean
        Dim result = False
        Try
            Dim parameters As New List(Of MySqlParameter)()
            parameters.Add(New MySqlParameter("p_MaSach", sach.MaSach))
            parameters.Add(New MySqlParameter("p_Tensach", sach.TenSach))
            parameters.Add(New MySqlParameter("p_TheLoai", sach.TheLoai))
            parameters.Add(New MySqlParameter("p_TacGia", sach.TacGia))
            parameters.Add(New MySqlParameter("p_SoLuongTon", sach.SoLuongTon))
            parameters.Add(New MySqlParameter("p_DonGia", sach.DonGia))
            parameters.Add(New MySqlParameter("P_TinhTrang", sach.TinhTrang))
            Dim n = DataAccessHelper.ExecuteNonQuery("UpdateSach", parameters)
            If n = 1 Then
                result = True
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return result
    End Function
    Public Shared Function DeleteSachByMaSach(maSach As String) As Boolean
        Dim result = False
        Try
            Dim parameters As New List(Of MySqlParameter)()
            parameters.Add(New MySqlParameter("p_MaSach", maSach))
            Dim n = DataAccessHelper.ExecuteNonQuery("DeleteSachByMaSach", parameters)
            If n = 1 Then
                result = True
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return result
    End Function
    Public Shared Function SelectSachAll() As List(Of SachDTO)
        Dim list = New List(Of SachDTO)()
        Try
            Dim dt = DataAccessHelper.ExecuteQuery("SelectSachAll")
            list.AddRange(From dr In dt.Rows Select New SachDTO() With { 
                .MaSach = dr("MaSach").ToString(), 
                .TenSach = dr("TenSach").ToString(), 
                .TheLoai = dr("TheLoai").ToString(), 
                .TacGia = dr("TacGia").ToString(), 
                .DonGia = Single.Parse(dr("DonGia").ToString()), 
                .SoLuongTon = Integer.Parse(dr("SoLuongTon").ToString()), 
                .TinhTrang = Integer.Parse(dr("TinhTrang").ToString()) 
            })
        Catch ex As Exception
            Throw ex
        End Try
        Return list
    End Function
    Public Shared Function SelectSachByMaSach(maSach As String) As SachDTO
        Dim Sach = New SachDTO()
        Try
            Dim parameters As New List(Of MySqlParameter)()
            parameters.Add(New MySqlParameter("p_MaSach", maSach))
            Dim dt = DataAccessHelper.ExecuteQuery("SelectSachByMaSach", parameters)
            Dim dr = dt.Rows(0)
            Sach.MaSach = dr("MaSach").ToString()
            Sach.TenSach = dr("TenSach").ToString()
            Sach.TheLoai = dr("TheLoai").ToString()
            Sach.TacGia = dr("TacGia").ToString()
            Sach.DonGia = Single.Parse(dr("DonGia").ToString())
            Sach.SoLuongTon = Integer.Parse(dr("SoLuongTon").ToString())
            Sach.TinhTrang = Integer.Parse(dr("TinhTrang").ToString())
        Catch ex As Exception
            Throw ex
        End Try
        Return Sach
    End Function
    Public Shared Function CheckSachByMaSach(maSach As String) As Boolean
        Dim result = False
        Try
            Dim dt = DataAccessHelper.ExecuteQuery($"Select MaSach From Sach where MaSach = '{maSach}'")
            If dt.Rows.Count = 1 Then
                result = True
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return result
    End Function
    Public Shared Function GenerateNewMaSach() As String
        Dim newMaSach As String = ""
        Try
            Dim dt = DataAccessHelper.ExecuteQuery("GenerateNewMaSach")
            Dim temp As Integer = Integer.Parse(dt.Rows(0)("NewMaSach").ToString())
            newMaSach = $"SACH{temp:0000}"
            Return newMaSach
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class

