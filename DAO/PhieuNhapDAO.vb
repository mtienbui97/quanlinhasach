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

Public Class PhieuNhapDAO
    Public Shared Function InsertPhieuNhap(phieuNhap As PhieuNhapDTO) As Boolean
        Dim result = False
        Try
            Dim parameters As New List(Of MySqlParameter)()
            parameters.Add(New MySqlParameter("p_MaPhieuNhap", phieuNhap.MaPhieuNhap))
            parameters.Add(New MySqlParameter("p_NgayNhap", phieuNhap.NgayNhap))
            Dim n = DataAccessHelper.ExecuteNonQuery("InsertPhieuNhap", parameters)
            If n = 1 Then
                result = True
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return result
    End Function
    Public Shared Function UpdatePhieuNhap(phieuNhap As PhieuNhapDTO) As Boolean
        Dim result = False
        Try
            Dim parameters As New List(Of MySqlParameter)()
            parameters.Add(New MySqlParameter("p_MaPhieuNhap", phieuNhap.MaPhieuNhap))
            parameters.Add(New MySqlParameter("p_NgayNhap", phieuNhap.NgayNhap))
            Dim n = DataAccessHelper.ExecuteNonQuery("UpdatePhieuNhap", parameters)
            If n = 1 Then
                result = True
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return result
    End Function
    Public Shared Function DeletePhieuNhapByMaPhieuNhap(maPhieuNhap As String) As Boolean
        Dim result = False
        Try
            Dim parameters As New List(Of MySqlParameter)()
            parameters.Add(New MySqlParameter("p_MaPhieuNhap", maPhieuNhap))
            Dim n = DataAccessHelper.ExecuteNonQuery("DeletePhieuNhapByMaPhieuNhap", parameters)
            If n = 1 Then
                result = True
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return result
    End Function
    Public Shared Function SelectPhieuNhapAll() As List(Of PhieuNhapDTO)
        Dim list = New List(Of PhieuNhapDTO)()
        Try
            Dim dt = DataAccessHelper.ExecuteQuery("SelectPhieuNhapAll")
            list.AddRange(From dr In dt.Rows Select New PhieuNhapDTO() With {
                .MaPhieuNhap = dr("MaPhieuNhap").ToString(),
                .NgayNhap = DateTime.Parse(dr("NgayNhap").ToString())
            })
        Catch ex As Exception
            Throw ex
        End Try
        Return list
    End Function
    Public Shared Function SelectPhieuNhapByMaPhieuNhap(maPhieuNhap As String) As PhieuNhapDTO
        Dim phieuNhap = New PhieuNhapDTO()
        Try
            Dim parameters As New List(Of MySqlParameter)()
            parameters.Add(New MySqlParameter("p_MaPhieuNhap", maPhieuNhap))
            Dim dt = DataAccessHelper.ExecuteQuery("SelectPhieuNhapByMaPhieuNhap", parameters)
            Dim dr = dt.Rows(0)
            phieuNhap.MaPhieuNhap = dr("MaPhieuNhap").ToString()
            phieuNhap.NgayNhap = DateTime.Parse(dr("NgayNhap").ToString())
        Catch ex As Exception
            Throw ex
        End Try
        Return phieuNhap
    End Function
    Public Shared Function CheckPhieuNhapByMaPhieuNhap(maPhieuNhap As String) As Boolean
        Dim result = False
        Try
            Dim parameters As New List(Of MySqlParameter)()
            parameters.Add(New MySqlParameter("p_MaPhieuNhap", maPhieuNhap))
            Dim dt = DataAccessHelper.ExecuteQuery("SelectPhieuNhapByMaPhieuNhap", parameters)
            If dt.Rows.Count = 1 Then
                result = True
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return result
    End Function
    Public Shared Function GenerateNewMaPhieuNhap() As String
        Dim newMaPhieuNhap As String = ""
        Try
            Dim dt = DataAccessHelper.ExecuteQuery("GenerateNewMaPhieuNhap2")
            Dim temp As Integer = Integer.Parse(dt.Rows(0)("NewMaPhieuNhap").ToString())
            newMaPhieuNhap = $"PHNH{temp:0000}"
            Return newMaPhieuNhap
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
