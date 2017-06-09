Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Imports BUS

Public Partial Class FormBaoCaoTon
	Inherits Form
	Public Sub New()
		InitializeComponent()
	End Sub

	Private Sub lapbaocao_button_Click(sender As Object, e As EventArgs)
		Dim listBaoCaoTon = BaoCaoTonBUS.SelectBaoCaoTonByThang(dateTimePicker1.Value)

		dataGridView1.DataSource = listBaoCaoTon
		dataGridView1.Refresh()
		dataGridView1.Parent.Refresh()
	End Sub
End Class
