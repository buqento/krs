<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fdatamahasiswa
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.cbprogramstudi = New System.Windows.Forms.ComboBox()
        Me.cbjenjangpendidikan = New System.Windows.Forms.ComboBox()
        Me.rtalamat = New System.Windows.Forms.RichTextBox()
        Me.cbagama = New System.Windows.Forms.ComboBox()
        Me.dtptanggal = New System.Windows.Forms.DateTimePicker()
        Me.rbp = New System.Windows.Forms.RadioButton()
        Me.rbl = New System.Windows.Forms.RadioButton()
        Me.tnim = New System.Windows.Forms.TextBox()
        Me.tnama = New System.Windows.Forms.TextBox()
        Me.btkeluar = New System.Windows.Forms.Button()
        Me.btubah = New System.Windows.Forms.Button()
        Me.bthapus = New System.Windows.Forms.Button()
        Me.btsimpan = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.dgvMhs = New System.Windows.Forms.DataGridView()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbjenjangpendidikan2 = New System.Windows.Forms.ComboBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvMhs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(483, 444)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cbprogramstudi)
        Me.TabPage1.Controls.Add(Me.cbjenjangpendidikan)
        Me.TabPage1.Controls.Add(Me.rtalamat)
        Me.TabPage1.Controls.Add(Me.cbagama)
        Me.TabPage1.Controls.Add(Me.dtptanggal)
        Me.TabPage1.Controls.Add(Me.rbp)
        Me.TabPage1.Controls.Add(Me.rbl)
        Me.TabPage1.Controls.Add(Me.tnim)
        Me.TabPage1.Controls.Add(Me.tnama)
        Me.TabPage1.Controls.Add(Me.btkeluar)
        Me.TabPage1.Controls.Add(Me.btubah)
        Me.TabPage1.Controls.Add(Me.bthapus)
        Me.TabPage1.Controls.Add(Me.btsimpan)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(475, 418)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Data Mahasiswa"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'cbprogramstudi
        '
        Me.cbprogramstudi.FormattingEnabled = True
        Me.cbprogramstudi.Items.AddRange(New Object() {"Teknik Informatika", "Sistem Informasi"})
        Me.cbprogramstudi.Location = New System.Drawing.Point(157, 308)
        Me.cbprogramstudi.Name = "cbprogramstudi"
        Me.cbprogramstudi.Size = New System.Drawing.Size(121, 21)
        Me.cbprogramstudi.TabIndex = 20
        '
        'cbjenjangpendidikan
        '
        Me.cbjenjangpendidikan.FormattingEnabled = True
        Me.cbjenjangpendidikan.Items.AddRange(New Object() {"SMU", "D3", "D4", "S1", "S2"})
        Me.cbjenjangpendidikan.Location = New System.Drawing.Point(157, 264)
        Me.cbjenjangpendidikan.Name = "cbjenjangpendidikan"
        Me.cbjenjangpendidikan.Size = New System.Drawing.Size(121, 21)
        Me.cbjenjangpendidikan.TabIndex = 19
        '
        'rtalamat
        '
        Me.rtalamat.Location = New System.Drawing.Point(157, 196)
        Me.rtalamat.Name = "rtalamat"
        Me.rtalamat.Size = New System.Drawing.Size(210, 48)
        Me.rtalamat.TabIndex = 18
        Me.rtalamat.Text = "Alamat Rumah"
        '
        'cbagama
        '
        Me.cbagama.DisplayMember = "1"
        Me.cbagama.FormattingEnabled = True
        Me.cbagama.Items.AddRange(New Object() {"Budha", "Hindu", "Islam", "Katolik", "Kristen Protestan"})
        Me.cbagama.Location = New System.Drawing.Point(157, 169)
        Me.cbagama.Name = "cbagama"
        Me.cbagama.Size = New System.Drawing.Size(121, 21)
        Me.cbagama.TabIndex = 17
        '
        'dtptanggal
        '
        Me.dtptanggal.Location = New System.Drawing.Point(157, 134)
        Me.dtptanggal.Name = "dtptanggal"
        Me.dtptanggal.Size = New System.Drawing.Size(200, 20)
        Me.dtptanggal.TabIndex = 16
        '
        'rbp
        '
        Me.rbp.AutoSize = True
        Me.rbp.Location = New System.Drawing.Point(253, 104)
        Me.rbp.Name = "rbp"
        Me.rbp.Size = New System.Drawing.Size(79, 17)
        Me.rbp.TabIndex = 15
        Me.rbp.Text = "Perempuan"
        Me.rbp.UseVisualStyleBackColor = True
        '
        'rbl
        '
        Me.rbl.AutoSize = True
        Me.rbl.Checked = True
        Me.rbl.Location = New System.Drawing.Point(157, 104)
        Me.rbl.Name = "rbl"
        Me.rbl.Size = New System.Drawing.Size(64, 17)
        Me.rbl.TabIndex = 14
        Me.rbl.TabStop = True
        Me.rbl.Text = "Laki-laki"
        Me.rbl.UseVisualStyleBackColor = True
        '
        'tnim
        '
        Me.tnim.Location = New System.Drawing.Point(157, 70)
        Me.tnim.MaxLength = 9
        Me.tnim.Name = "tnim"
        Me.tnim.Size = New System.Drawing.Size(100, 20)
        Me.tnim.TabIndex = 13
        '
        'tnama
        '
        Me.tnama.Location = New System.Drawing.Point(157, 37)
        Me.tnama.Name = "tnama"
        Me.tnama.Size = New System.Drawing.Size(100, 20)
        Me.tnama.TabIndex = 12
        Me.tnama.Text = "Nama saya"
        '
        'btkeluar
        '
        Me.btkeluar.Location = New System.Drawing.Point(294, 381)
        Me.btkeluar.Name = "btkeluar"
        Me.btkeluar.Size = New System.Drawing.Size(75, 23)
        Me.btkeluar.TabIndex = 11
        Me.btkeluar.Text = "Keluar"
        Me.btkeluar.UseVisualStyleBackColor = True
        '
        'btubah
        '
        Me.btubah.Location = New System.Drawing.Point(213, 381)
        Me.btubah.Name = "btubah"
        Me.btubah.Size = New System.Drawing.Size(75, 23)
        Me.btubah.TabIndex = 10
        Me.btubah.Text = "Edit"
        Me.btubah.UseVisualStyleBackColor = True
        '
        'bthapus
        '
        Me.bthapus.Location = New System.Drawing.Point(132, 381)
        Me.bthapus.Name = "bthapus"
        Me.bthapus.Size = New System.Drawing.Size(75, 23)
        Me.bthapus.TabIndex = 9
        Me.bthapus.Text = "Hapus"
        Me.bthapus.UseVisualStyleBackColor = True
        '
        'btsimpan
        '
        Me.btsimpan.Location = New System.Drawing.Point(51, 381)
        Me.btsimpan.Name = "btsimpan"
        Me.btsimpan.Size = New System.Drawing.Size(75, 23)
        Me.btsimpan.TabIndex = 8
        Me.btsimpan.Text = "Simpan"
        Me.btsimpan.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(48, 308)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Program Studi"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(48, 264)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Jenjang Pendidikan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(49, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(48, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Agama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tanggal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jenis Kelamin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NIM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Lengkap"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TextBox4)
        Me.TabPage2.Controls.Add(Me.RadioButton6)
        Me.TabPage2.Controls.Add(Me.RadioButton5)
        Me.TabPage2.Controls.Add(Me.RadioButton4)
        Me.TabPage2.Controls.Add(Me.RadioButton3)
        Me.TabPage2.Controls.Add(Me.Button5)
        Me.TabPage2.Controls.Add(Me.dgvMhs)
        Me.TabPage2.Controls.Add(Me.TextBox3)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.cbjenjangpendidikan2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(475, 418)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Lihat Data Mahasiswa"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(363, 381)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 11
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(185, 384)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(140, 17)
        Me.RadioButton6.TabIndex = 10
        Me.RadioButton6.Text = "Komputerisasi Akuntansi"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(185, 358)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(135, 17)
        Me.RadioButton5.TabIndex = 9
        Me.RadioButton5.Text = "Manajemen Informatika"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(25, 384)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(101, 17)
        Me.RadioButton4.TabIndex = 8
        Me.RadioButton4.Text = "Sistem Informasi"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Checked = True
        Me.RadioButton3.Location = New System.Drawing.Point(25, 358)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(113, 17)
        Me.RadioButton3.TabIndex = 7
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Teknik Informatika"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(25, 303)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Detail"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'dgvMhs
        '
        Me.dgvMhs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMhs.Location = New System.Drawing.Point(25, 44)
        Me.dgvMhs.Name = "dgvMhs"
        Me.dgvMhs.Size = New System.Drawing.Size(438, 253)
        Me.dgvMhs.TabIndex = 5
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(261, 17)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(202, 20)
        Me.TextBox3.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(360, 360)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Total Mahasiswa"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(220, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Nama"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Jenjang Pendidikan"
        '
        'cbjenjangpendidikan2
        '
        Me.cbjenjangpendidikan2.FormattingEnabled = True
        Me.cbjenjangpendidikan2.Items.AddRange(New Object() {"SMU", "D3", "D4", "S1", "S2"})
        Me.cbjenjangpendidikan2.Location = New System.Drawing.Point(128, 17)
        Me.cbjenjangpendidikan2.Name = "cbjenjangpendidikan2"
        Me.cbjenjangpendidikan2.Size = New System.Drawing.Size(58, 21)
        Me.cbjenjangpendidikan2.TabIndex = 0
        '
        'fdatamahasiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 500)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "fdatamahasiswa"
        Me.Text = "Data Mahasiswa"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgvMhs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents cbprogramstudi As System.Windows.Forms.ComboBox
    Friend WithEvents cbjenjangpendidikan As System.Windows.Forms.ComboBox
    Friend WithEvents rtalamat As System.Windows.Forms.RichTextBox
    Friend WithEvents cbagama As System.Windows.Forms.ComboBox
    Friend WithEvents dtptanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents rbp As System.Windows.Forms.RadioButton
    Friend WithEvents rbl As System.Windows.Forms.RadioButton
    Friend WithEvents tnim As System.Windows.Forms.TextBox
    Friend WithEvents tnama As System.Windows.Forms.TextBox
    Friend WithEvents btkeluar As System.Windows.Forms.Button
    Friend WithEvents btubah As System.Windows.Forms.Button
    Friend WithEvents bthapus As System.Windows.Forms.Button
    Friend WithEvents btsimpan As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dgvMhs As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbjenjangpendidikan2 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
