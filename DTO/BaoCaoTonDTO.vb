Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Public Class BaoCaoTonDTO
    Public Property MaChiTietTon() As String
    Public Property Thang() As DateTime
    Public Property MaSach() As String
    Public Property TonDau() As Decimal
    Public Property TonPhatSinh() As Decimal
    Public Property TonCuoi() As Decimal
    Public Sub New()
        MaChiTietTon = ""
        MaSach = ""
        Thang = DateTime.Now
        TonDau = 0
        TonCuoi = 0
        TonPhatSinh = 0
    End Sub
End Class
