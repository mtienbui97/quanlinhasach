Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Public Class BaoCaoCongNoDTO
    Public Property MaChiTietCongNo() As String
    Public Property Thang() As DateTime
    Public Property MaKhachHang() As String
    Public Property NoDau() As Decimal
    Public Property NoPhatSinh() As Decimal
    Public Property NoCuoi() As Decimal
    Public Sub New()
        MaChiTietCongNo = ""
        MaKhachHang = ""
        Thang = DateTime.Now
        NoDau = 0
        NoCuoi = 0
        NoPhatSinh = 0
    End Sub
End Class
