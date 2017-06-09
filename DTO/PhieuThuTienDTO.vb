Public Class PhieuThuTienDTO
    Public Property MaPhieuThu() As String
    Public Property NgayThu() As DateTime
    Public Property MaKhachHang() As String
    Public Property SoTienThu() As Decimal
    Public Sub New()
        MaPhieuThu = ""
        MaKhachHang = ""
        NgayThu = DateTime.Now
        SoTienThu = 0
    End Sub
End Class
