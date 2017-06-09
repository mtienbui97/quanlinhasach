Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Public Class ChiTietHoaDonDTO
    Public Property MaChiTietHoaDon() As String
    Public Property MaSach() As String
    Public Property MaHoaDon() As String
    Public Property SoLuongBan() As Integer
    Public Property DonGiaBan() As Decimal
    Public Property ThanhTien() As Decimal
    Public Sub New()
        MaChiTietHoaDon = ""
        MaHoaDon = ""
        MaSach = ""
        SoLuongBan = 0
        DonGiaBan = 0
        ThanhTien = 0
    End Sub
End Class

