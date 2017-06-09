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

Public Partial Class FormDanhSachSach
	Inherits Form
	Private _listSach As List(Of SachDTO)

	Public Sub New()
		InitializeComponent()
	End Sub

	Private Sub search_button_Click(sender As Object, e As EventArgs)
		Dim criteriaList = New List(Of List(Of SachDTO))()

		If masach_checkbox.Checked Then
			If masach_cb.SelectedItem IsNot Nothing Then
				criteriaList.Add(_listSach.Where(Function(x) x.MaSach = DirectCast(masach_cb.SelectedItem, SachDTO).MaSach).ToList())
			Else
				criteriaList.Add(New List(Of SachDTO)())
			End If
		End If

		If ten_checkbox.Checked Then
			If tensach_tb.Text <> "" Then
				criteriaList.Add(_listSach.Where(Function(x) x.TenSach.Contains(tensach_tb.Text)).ToList())
			Else
				criteriaList.Add(New List(Of SachDTO)())
			End If
		End If

		If dongia_checkbox.Checked Then
			If dongia_tb.Text <> "" Then
				criteriaList.Add(_listSach.Where(Function(x) x.DonGia = Single.Parse(dongia_tb.Text)).ToList())
			Else
				criteriaList.Add(New List(Of SachDTO)())
			End If
		End If

		If tacgia_checkbox.Checked Then
			If tacgia_tb.Text <> "" Then
				criteriaList.Add(_listSach.Where(Function(x) x.TacGia.Contains(tacgia_tb.Text)).ToList())
			Else
				criteriaList.Add(New List(Of SachDTO)())
			End If
		End If

		If theloai_checkbox.Checked Then
			If theloai_tb.Text <> "" Then
				criteriaList.Add(_listSach.Where(Function(x) x.TacGia.Contains(theloai_tb.Text)).ToList())
			Else
				criteriaList.Add(New List(Of SachDTO)())
			End If
		End If

		If soluongton_checkbox.Checked Then
			If soluongton_tb.Text <> "" Then
				criteriaList.Add(_listSach.Where(Function(x) x.SoLuongTon = Integer.Parse(soluongton_tb.Text)).ToList())
			Else
				criteriaList.Add(New List(Of SachDTO)())
			End If
		End If

		If criteriaList.Count = 0 Then
			dataGridView1.DataSource = _listSach
			dataGridView1.Refresh()
			dataGridView1.Parent.Refresh()
		Else
			Dim intersection = criteriaList.Skip(1).Aggregate(New HashSet(Of SachDTO)(criteriaList.First()), Function(h, f) 
			h.IntersectWith(f)
			Return h

End Function).ToList()
			dataGridView1.DataSource = intersection
			dataGridView1.Refresh()
			dataGridView1.Parent.Refresh()
		End If
	End Sub

	Private Sub FormDanhSachSach_Load(sender As Object, e As EventArgs)
		_listSach = SachBUS.SelectSachAll()
		masach_cb.DataSource = _listSach
	End Sub
End Class
