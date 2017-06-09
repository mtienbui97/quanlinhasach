Public Class PhieuNhapDTO
    Public Property MaPhieuNhap() As String
    Public Property NgayNhap() As DateTime
    Public Sub New()
        MaPhieuNhap = ""
        NgayNhap = New DateTime()
    End Sub
End Class

