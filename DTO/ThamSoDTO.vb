Public Class ThamSoDTO
    Public Property SoLuongNhapItNhat() As Integer
    Public Property SoLuongTonToiDaTruocNhap() As Integer
    Public Property SoLuongTonToiThieuSauBan() As Integer
    Public Property SoTienNoToiDa() As Integer
    Public Property SuDungQuiDinh4() As Boolean
    Public Sub New()
        SoLuongNhapItNhat = 0
        SoLuongTonToiDaTruocNhap = 0
        SoLuongTonToiThieuSauBan = 0
        SoTienNoToiDa = 0
        SuDungQuiDinh4 = True
    End Sub
End Class
