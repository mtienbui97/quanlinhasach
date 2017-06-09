Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports DTO

Public Class PhieuThuTienDAO
    Public Shared Function InsertPhieuThu(phieuThu As PhieuThuTienDTO) As Boolean
        Dim result = False
        Try
            Dim parameters As New List(Of MySqlParameter)()
            parameters.Add(New MySqlParameter("p_MaPhieuThu", phieuThu.MaPhieuThu))
            parameters.Add(New MySqlParameter("p_NgayThuTien", phieuThu.NgayThu))
            parameters.Add(New MySqlParameter("p_MaKhachHang", phieuThu.MaKhachHang))
            parameters.Add(New MySqlParameter("p_SoTienThu", phieuThu.SoTienThu))
            Dim n = DataAccessHelper.ExecuteNonQuery("InsertPhieuThu", parameters)
            If n = 1 Then
                result = True
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return result
    End Function
    Public Shared Function GenerateNewMaPhieuThu() As String
        Dim newMaPhieuThu As String = ""
        Try
            Dim dt = DataAccessHelper.ExecuteQuery("GenerateNewMaPhieuThu")
            Dim temp As Integer = Integer.Parse(dt.Rows(0)("NewMaPhieuThu").ToString())
            newMaPhieuThu = $"PHTH{temp:0000}"
            Return newMaPhieuThu
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class

