Public Class ChiTietPhieuNhapDTO
    Public Property MaChiTietPhieuNhap() As String
    Public Property MaPhieuNhap() As String
    Public Property MaSach() As String
    Public Property SoLuongNhap() As Integer
    Public Sub New()
        MaChiTietPhieuNhap = ""
        MaPhieuNhap = ""
        MaSach = ""
        SoLuongNhap = 0
    End Sub
End Class

