Public Class SachDTO
    Public Property MaSach() As String
    Public Property TenSach() As String
    Public Property TheLoai() As String
    Public Property TacGia() As String
    Public Property DonGia() As Single
    Public Property SoLuongTon() As Integer
    Public Property TinhTrang() As Integer
    Public Sub New()
        MaSach = ""
        TenSach = ""
        TacGia = ""
        SoLuongTon = 0
        DonGia = 0
        TheLoai = ""
        TinhTrang = 0
    End Sub
End Class

