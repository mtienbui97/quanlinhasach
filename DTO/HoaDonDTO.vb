Public Class HoaDonDTO
    Public Property MaHoaDon() As String
    Public Property MaKhachHang() As String
    Public Property NgayLapHoaDon() As DateTime
    Public Property TongThanhTien() As Integer
    Public Sub New()
        MaHoaDon = ""
        MaKhachHang = ""
        NgayLapHoaDon = DateTime.Now
        TongThanhTien = 0
    End Sub
End Class

