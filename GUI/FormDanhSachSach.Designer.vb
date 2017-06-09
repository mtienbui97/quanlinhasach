Partial Class FormDanhSachSach
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	''' <summary>
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Windows Form Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
		Me.dataGridView1 = New System.Windows.Forms.DataGridView()
		Me.search_button = New System.Windows.Forms.Button()
		Me.masach_checkbox = New System.Windows.Forms.CheckBox()
		Me.ten_checkbox = New System.Windows.Forms.CheckBox()
		Me.tensach_tb = New System.Windows.Forms.TextBox()
		Me.theloai_checkbox = New System.Windows.Forms.CheckBox()
		Me.theloai_tb = New System.Windows.Forms.TextBox()
		Me.tacgia_checkbox = New System.Windows.Forms.CheckBox()
		Me.tacgia_tb = New System.Windows.Forms.TextBox()
		Me.soluongton_checkbox = New System.Windows.Forms.CheckBox()
		Me.dongia_checkbox = New System.Windows.Forms.CheckBox()
		Me.dongia_tb = New System.Windows.Forms.TextBox()
		Me.soluongton_tb = New System.Windows.Forms.TextBox()
		Me.masach_cb = New System.Windows.Forms.ComboBox()
		Me.masach_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.tensach_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.theloai_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.tacgia_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.dongia_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.soluongton_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
		DirectCast(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		' 
		' dataGridView1
		' 
		Me.dataGridView1.AllowUserToAddRows = False
		Me.dataGridView1.AllowUserToDeleteRows = False
		Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.masach_col, Me.tensach_col, Me.theloai_col, Me.tacgia_col, Me.dongia_col, Me.soluongton_col})
		Me.dataGridView1.Location = New System.Drawing.Point(31, 116)
		Me.dataGridView1.Name = "dataGridView1"
		Me.dataGridView1.[ReadOnly] = True
		Me.dataGridView1.Size = New System.Drawing.Size(641, 205)
		Me.dataGridView1.TabIndex = 0
		' 
		' search_button
		' 
		Me.search_button.Location = New System.Drawing.Point(615, 24)
		Me.search_button.Name = "search_button"
		Me.search_button.Size = New System.Drawing.Size(57, 48)
		Me.search_button.TabIndex = 3
		Me.search_button.Text = "Search"
		Me.search_button.UseVisualStyleBackColor = True
		AddHandler Me.search_button.Click, New System.EventHandler(AddressOf Me.search_button_Click)
		' 
		' masach_checkbox
		' 
		Me.masach_checkbox.AutoSize = True
		Me.masach_checkbox.Location = New System.Drawing.Point(31, 28)
		Me.masach_checkbox.Name = "masach_checkbox"
		Me.masach_checkbox.Size = New System.Drawing.Size(67, 17)
		Me.masach_checkbox.TabIndex = 7
		Me.masach_checkbox.Text = "Mã sách"
		Me.masach_checkbox.UseVisualStyleBackColor = True
		' 
		' ten_checkbox
		' 
		Me.ten_checkbox.AutoSize = True
		Me.ten_checkbox.Location = New System.Drawing.Point(31, 54)
		Me.ten_checkbox.Name = "ten_checkbox"
		Me.ten_checkbox.Size = New System.Drawing.Size(71, 17)
		Me.ten_checkbox.TabIndex = 9
		Me.ten_checkbox.Text = "Tên sách"
		Me.ten_checkbox.UseVisualStyleBackColor = True
		' 
		' tensach_tb
		' 
		Me.tensach_tb.Location = New System.Drawing.Point(108, 51)
		Me.tensach_tb.Name = "tensach_tb"
		Me.tensach_tb.Size = New System.Drawing.Size(96, 20)
		Me.tensach_tb.TabIndex = 8
		' 
		' theloai_checkbox
		' 
		Me.theloai_checkbox.AutoSize = True
		Me.theloai_checkbox.Location = New System.Drawing.Point(226, 28)
		Me.theloai_checkbox.Name = "theloai_checkbox"
		Me.theloai_checkbox.Size = New System.Drawing.Size(64, 17)
		Me.theloai_checkbox.TabIndex = 11
		Me.theloai_checkbox.Text = "Thể loại"
		Me.theloai_checkbox.UseVisualStyleBackColor = True
		' 
		' theloai_tb
		' 
		Me.theloai_tb.Location = New System.Drawing.Point(296, 25)
		Me.theloai_tb.Name = "theloai_tb"
		Me.theloai_tb.Size = New System.Drawing.Size(95, 20)
		Me.theloai_tb.TabIndex = 10
		' 
		' tacgia_checkbox
		' 
		Me.tacgia_checkbox.AutoSize = True
		Me.tacgia_checkbox.Location = New System.Drawing.Point(226, 53)
		Me.tacgia_checkbox.Name = "tacgia_checkbox"
		Me.tacgia_checkbox.Size = New System.Drawing.Size(62, 17)
		Me.tacgia_checkbox.TabIndex = 13
		Me.tacgia_checkbox.Text = "Tác giả"
		Me.tacgia_checkbox.UseVisualStyleBackColor = True
		' 
		' tacgia_tb
		' 
		Me.tacgia_tb.Location = New System.Drawing.Point(296, 50)
		Me.tacgia_tb.Name = "tacgia_tb"
		Me.tacgia_tb.Size = New System.Drawing.Size(96, 20)
		Me.tacgia_tb.TabIndex = 12
		' 
		' soluongton_checkbox
		' 
		Me.soluongton_checkbox.AutoSize = True
		Me.soluongton_checkbox.Location = New System.Drawing.Point(412, 26)
		Me.soluongton_checkbox.Name = "soluongton_checkbox"
		Me.soluongton_checkbox.Size = New System.Drawing.Size(86, 17)
		Me.soluongton_checkbox.TabIndex = 15
		Me.soluongton_checkbox.Text = "Số lượng tồn"
		Me.soluongton_checkbox.UseVisualStyleBackColor = True
		' 
		' dongia_checkbox
		' 
		Me.dongia_checkbox.AutoSize = True
		Me.dongia_checkbox.Location = New System.Drawing.Point(412, 53)
		Me.dongia_checkbox.Name = "dongia_checkbox"
		Me.dongia_checkbox.Size = New System.Drawing.Size(63, 17)
		Me.dongia_checkbox.TabIndex = 17
		Me.dongia_checkbox.Text = "Đơn giá"
		Me.dongia_checkbox.UseVisualStyleBackColor = True
		' 
		' dongia_tb
		' 
		Me.dongia_tb.Location = New System.Drawing.Point(504, 50)
		Me.dongia_tb.Name = "dongia_tb"
		Me.dongia_tb.Size = New System.Drawing.Size(96, 20)
		Me.dongia_tb.TabIndex = 16
		' 
		' soluongton_tb
		' 
		Me.soluongton_tb.Location = New System.Drawing.Point(504, 23)
		Me.soluongton_tb.Name = "soluongton_tb"
		Me.soluongton_tb.Size = New System.Drawing.Size(96, 20)
		Me.soluongton_tb.TabIndex = 18
		' 
		' masach_cb
		' 
		Me.masach_cb.DisplayMember = "MaSach"
		Me.masach_cb.FormattingEnabled = True
		Me.masach_cb.Location = New System.Drawing.Point(108, 26)
		Me.masach_cb.Name = "masach_cb"
		Me.masach_cb.Size = New System.Drawing.Size(96, 21)
		Me.masach_cb.TabIndex = 19
		' 
		' masach_col
		' 
		Me.masach_col.DataPropertyName = "MaSach"
		Me.masach_col.HeaderText = "Mã sách"
		Me.masach_col.Name = "masach_col"
		Me.masach_col.[ReadOnly] = True
		' 
		' tensach_col
		' 
		Me.tensach_col.DataPropertyName = "TenSach"
		Me.tensach_col.HeaderText = "Tên sách"
		Me.tensach_col.Name = "tensach_col"
		Me.tensach_col.[ReadOnly] = True
		' 
		' theloai_col
		' 
		Me.theloai_col.DataPropertyName = "TheLoai"
		Me.theloai_col.HeaderText = "Thể loại"
		Me.theloai_col.Name = "theloai_col"
		Me.theloai_col.[ReadOnly] = True
		' 
		' tacgia_col
		' 
		Me.tacgia_col.DataPropertyName = "TacGia"
		Me.tacgia_col.HeaderText = "Tác giả"
		Me.tacgia_col.Name = "tacgia_col"
		Me.tacgia_col.[ReadOnly] = True
		' 
		' dongia_col
		' 
		Me.dongia_col.DataPropertyName = "DonGia"
		Me.dongia_col.HeaderText = "Đơn giá"
		Me.dongia_col.Name = "dongia_col"
		Me.dongia_col.[ReadOnly] = True
		' 
		' soluongton_col
		' 
		Me.soluongton_col.DataPropertyName = "SoLuongTon"
		Me.soluongton_col.HeaderText = "Số lượng tồn"
		Me.soluongton_col.Name = "soluongton_col"
		Me.soluongton_col.[ReadOnly] = True
		' 
		' FormDanhSachSach
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(713, 370)
		Me.Controls.Add(Me.masach_cb)
		Me.Controls.Add(Me.soluongton_tb)
		Me.Controls.Add(Me.dongia_checkbox)
		Me.Controls.Add(Me.dongia_tb)
		Me.Controls.Add(Me.soluongton_checkbox)
		Me.Controls.Add(Me.tacgia_checkbox)
		Me.Controls.Add(Me.tacgia_tb)
		Me.Controls.Add(Me.theloai_checkbox)
		Me.Controls.Add(Me.theloai_tb)
		Me.Controls.Add(Me.ten_checkbox)
		Me.Controls.Add(Me.tensach_tb)
		Me.Controls.Add(Me.masach_checkbox)
		Me.Controls.Add(Me.search_button)
		Me.Controls.Add(Me.dataGridView1)
		Me.Name = "FormDanhSachSach"
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text = "Tra cứu sách"
		AddHandler Me.Load, New System.EventHandler(AddressOf Me.FormDanhSachSach_Load)
		DirectCast(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	#End Region

	Private dataGridView1 As System.Windows.Forms.DataGridView
	Private search_button As System.Windows.Forms.Button
	Private masach_checkbox As System.Windows.Forms.CheckBox
	Private ten_checkbox As System.Windows.Forms.CheckBox
	Private tensach_tb As System.Windows.Forms.TextBox
	Private theloai_checkbox As System.Windows.Forms.CheckBox
	Private theloai_tb As System.Windows.Forms.TextBox
	Private tacgia_checkbox As System.Windows.Forms.CheckBox
	Private tacgia_tb As System.Windows.Forms.TextBox
	Private soluongton_checkbox As System.Windows.Forms.CheckBox
	Private dongia_checkbox As System.Windows.Forms.CheckBox
	Private dongia_tb As System.Windows.Forms.TextBox
	Private soluongton_tb As System.Windows.Forms.TextBox
	Private masach_cb As System.Windows.Forms.ComboBox
	Private masach_col As System.Windows.Forms.DataGridViewTextBoxColumn
	Private tensach_col As System.Windows.Forms.DataGridViewTextBoxColumn
	Private theloai_col As System.Windows.Forms.DataGridViewTextBoxColumn
	Private tacgia_col As System.Windows.Forms.DataGridViewTextBoxColumn
	Private dongia_col As System.Windows.Forms.DataGridViewTextBoxColumn
	Private soluongton_col As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
