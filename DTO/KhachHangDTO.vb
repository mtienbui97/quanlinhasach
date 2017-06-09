Public Class KhachHangDTO
    Public Property MaKhachHang() As String
    Public Property HoTenKhachHang() As String
    Public Property DiaChi() As String
    Public Property SoDienThoai() As String
    Public Property Email() As String
    Public Property SoTienNo() As Decimal
    Public Property TinhTrang() As Boolean
    Public Sub New()
        MaKhachHang = ""
        HoTenKhachHang = ""
        DiaChi = ""
        SoDienThoai = ""
        Email = ""
        SoTienNo = 0
        TinhTrang = True
    End Sub
End Class
