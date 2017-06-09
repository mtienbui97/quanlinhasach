Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports BUS
Imports DTO

Public Partial Class FormLapHoaDon
	Inherits Form
	Private _bindingSource As BindingSource
	Private _dataTable As DataTable
	Private _childForm As FormThemSachfromHoaDon

	Public Sub New()
		InitializeComponent()

		_dataTable = New DataTable()
		_dataTable.Columns.Add("Mã sách")
		_dataTable.Columns.Add("Tên sách")
		_dataTable.Columns.Add("Thể loại")
		_dataTable.Columns.Add("Tác giả")
		_dataTable.Columns.Add("Đơn giá bán")
		_dataTable.Columns.Add("Số lượng bán")
		_dataTable.Columns.Add("Thành tiền")

		_bindingSource = New BindingSource() With { 
			.DataSource = _dataTable 
		}
	End Sub

	Private Sub maKhachHang_tb_TextChanged(sender As Object, e As EventArgs)

	End Sub

	Private Sub xem_button_Click(sender As Object, e As EventArgs)
		If KhachHangBUS.CheckKhachHangByMaKhachHang(maKhachHang_tb.Text) Then
			Dim thongtinForm = New FormThongTinKhachHang()
			thongtinForm.RefreshFormThongTin(maKhachHang_tb.Text)
			thongtinForm.Show()
		Else
			MessageBox.Show("Không tồn tại mã khách hàng")
		End If
	End Sub

	Private Sub label1_Click(sender As Object, e As EventArgs)

	End Sub

	Private Sub themsach_button_Click(sender As Object, e As EventArgs)
		If _childForm Is Nothing OrElse _childForm.IsDisposed Then
			_childForm = New FormThemSachfromHoaDon(Me)
			_childForm.Show()
		End If
	End Sub


	Private Sub FormLapHoaDon_Load(sender As Object, e As EventArgs)
		RefreshForm()
		dataGridView1.DataSource = _bindingSource
	End Sub

	Public Sub ThemChiTietHoaDon(sach As SachDTO, soLuongBan As Integer, thanhtien As Decimal, dongiaban As Decimal)
		For Each dataRow As DataRow In _dataTable.Rows
			If sach.MaSach <> dataRow("Mã sách").ToString() Then
				Continue For
			End If

			dataRow("Số lượng bán") = Integer.Parse(dataRow("Số lượng bán").ToString()) + soLuongBan
			dataRow("Thành tiền") = Decimal.Parse(dataRow("Thành tiền").ToString()) + thanhtien

			tongTien_tb.Text = (Decimal.Parse(tongTien_tb.Text) + thanhtien).ToString()
			Return
		Next

		Dim row = _dataTable.NewRow()
		row("Mã sách") = sach.MaSach
		row("Tên sách") = sach.TenSach
		row("Thể loại") = sach.TheLoai
		row("Tác giả") = sach.TacGia
		row("Đơn giá bán") = dongiaban
		row("Số lượng bán") = soLuongBan
		row("Thành tiền") = thanhtien
		_dataTable.Rows.Add(row)

		tongTien_tb.Text = (Decimal.Parse(tongTien_tb.Text) + thanhtien).ToString()

	End Sub


	Private Sub RefreshForm()
		maHoaDon_tb.Text = HoaDonBUS.GenerateNewMaHoaDon()
		dateTimePicker1.Value = DateTime.Now
		slTonToiThieuSauBan_tb.Text = ThamSoBUS.SelectSoLuongNhapItNhat().ToString()

	End Sub

	Public Function GetTextfromTextBox(_textbox As TextBox) As String
		Return _textbox.Text
	End Function

	Private Sub lapPhieuthutien_button_Click(sender As Object, e As EventArgs)

	End Sub

	Private Sub lapHoadon_button_Click(sender As Object, e As EventArgs)
		Dim hoadon = New HoaDonDTO() With { 
			.MaKhachHang = maKhachHang_tb.Text, 
			.MaHoaDon = maHoaDon_tb.Text, 
			.NgayLapHoaDon = dateTimePicker1.Value 
		}

		Dim listChiTietHoaDon = New List(Of ChiTietHoaDonDTO)()
		For Each row As DataGridViewRow In dataGridView1.Rows
			If row.Cells("Số lượng bán").Value Is Nothing OrElse Integer.Parse(row.Cells("Số lượng bán").Value.ToString()) = 0 Then
				Continue For
			End If
			Dim chiTietHoaDon = New ChiTietHoaDonDTO() With { _
				.MaHoaDon = maHoaDon_tb.Text, _
				.MaSach = row.Cells("Mã sách").Value.ToString(), _
				.SoLuongBan = Integer.Parse(row.Cells("Số lượng bán").Value.ToString()) _
			}

			listChiTietHoaDon.Add(chiTietHoaDon)
		Next

		If listChiTietHoaDon.Count = 0 Then
			MessageBox.Show("Hóa đơn rỗng", "Lỗi")
		End If

		Try
			HoaDonBUS.InsertHoaDon(hoadon, listChiTietHoaDon)
		Catch exception As Exception
			MessageBox.Show(exception.Message, "Lỗi")
		End Try

		RefreshForm()
	End Sub

	Private Sub dataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

	End Sub

	Private Sub delete_Click(sender As Object, e As EventArgs)
		For Each row As DataGridViewRow In dataGridView1.SelectedRows
			Dim tmp = _dataTable.Rows.Cast(Of DataRow)().Where(Function(r) r("Mã khách hàng") Is row.Cells("Mã khách hàng").Value).ToList()
		    For Each o in tmp
		        o.Delete()
		    Next
		Next
	End Sub
End Class
