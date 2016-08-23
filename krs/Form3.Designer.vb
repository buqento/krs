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
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbprogramstudi2 = New System.Windows.Forms.ComboBox()
        Me.btdetail = New System.Windows.Forms.Button()
        Me.dgvMhs = New System.Windows.Forms.DataGridView()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbjenjangpendidikan2 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ttempatlahir = New System.Windows.Forms.TextBox()
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
        Me.TabControl1.Size = New System.Drawing.Size(506, 444)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ttempatlahir)
        Me.TabPage1.Controls.Add(Me.Label11)
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
        Me.TabPage1.Size = New System.Drawing.Size(498, 418)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Data Mahasiswa"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'cbprogramstudi
        '
        Me.cbprogramstudi.FormattingEnabled = True
        Me.cbprogramstudi.Location = New System.Drawing.Point(157, 282)
        Me.cbprogramstudi.Name = "cbprogramstudi"
        Me.cbprogramstudi.Size = New System.Drawing.Size(210, 21)
        Me.cbprogramstudi.TabIndex = 20
        '
        'cbjenjangpendidikan
        '
        Me.cbjenjangpendidikan.FormattingEnabled = True
        Me.cbjenjangpendidikan.Items.AddRange(New Object() {"D3", "S1"})
        Me.cbjenjangpendidikan.Location = New System.Drawing.Point(157, 255)
        Me.cbjenjangpendidikan.Name = "cbjenjangpendidikan"
        Me.cbjenjangpendidikan.Size = New System.Drawing.Size(48, 21)
        Me.cbjenjangpendidikan.TabIndex = 19
        '
        'rtalamat
        '
        Me.rtalamat.Location = New System.Drawing.Point(157, 197)
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
        Me.cbagama.Location = New System.Drawing.Point(157, 170)
        Me.cbagama.Name = "cbagama"
        Me.cbagama.Size = New System.Drawing.Size(121, 21)
        Me.cbagama.TabIndex = 17
        '
        'dtptanggal
        '
        Me.dtptanggal.Location = New System.Drawing.Point(157, 144)
        Me.dtptanggal.Name = "dtptanggal"
        Me.dtptanggal.Size = New System.Drawing.Size(200, 20)
        Me.dtptanggal.TabIndex = 16
        '
        'rbp
        '
        Me.rbp.AutoSize = True
        Me.rbp.Location = New System.Drawing.Point(234, 89)
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
        Me.rbl.Location = New System.Drawing.Point(157, 89)
        Me.rbl.Name = "rbl"
        Me.rbl.Size = New System.Drawing.Size(64, 17)
        Me.rbl.TabIndex = 14
        Me.rbl.TabStop = True
        Me.rbl.Text = "Laki-laki"
        Me.rbl.UseVisualStyleBackColor = True
        '
        'tnim
        '
        Me.tnim.Location = New System.Drawing.Point(157, 63)
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
        Me.tnama.Text = "King Richard"
        '
        'btkeluar
        '
        Me.btkeluar.Location = New System.Drawing.Point(292, 334)
        Me.btkeluar.Name = "btkeluar"
        Me.btkeluar.Size = New System.Drawing.Size(75, 23)
        Me.btkeluar.TabIndex = 11
        Me.btkeluar.Text = "Keluar"
        Me.btkeluar.UseVisualStyleBackColor = True
        '
        'btubah
        '
        Me.btubah.Location = New System.Drawing.Point(211, 334)
        Me.btubah.Name = "btubah"
        Me.btubah.Size = New System.Drawing.Size(75, 23)
        Me.btubah.TabIndex = 10
        Me.btubah.Text = "Edit"
        Me.btubah.UseVisualStyleBackColor = True
        '
        'bthapus
        '
        Me.bthapus.Location = New System.Drawing.Point(130, 334)
        Me.bthapus.Name = "bthapus"
        Me.bthapus.Size = New System.Drawing.Size(75, 23)
        Me.bthapus.TabIndex = 9
        Me.bthapus.Text = "Hapus"
        Me.bthapus.UseVisualStyleBackColor = True
        '
        'btsimpan
        '
        Me.btsimpan.Location = New System.Drawing.Point(49, 334)
        Me.btsimpan.Name = "btsimpan"
        Me.btsimpan.Size = New System.Drawing.Size(75, 23)
        Me.btsimpan.TabIndex = 8
        Me.btsimpan.Text = "Simpan"
        Me.btsimpan.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(53, 285)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Program Studi"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 258)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Jenjang Pendidikan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(89, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(86, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Agama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(80, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tanggal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jenis Kelamin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(101, 63)
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
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.cbprogramstudi2)
        Me.TabPage2.Controls.Add(Me.btdetail)
        Me.TabPage2.Controls.Add(Me.dgvMhs)
        Me.TabPage2.Controls.Add(Me.TextBox3)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.cbjenjangpendidikan2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(498, 418)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Lihat Data Mahasiswa"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(49, 52)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Program Studi"
        '
        'cbprogramstudi2
        '
        Me.cbprogramstudi2.FormattingEnabled = True
        Me.cbprogramstudi2.Location = New System.Drawing.Point(128, 44)
        Me.cbprogramstudi2.Name = "cbprogramstudi2"
        Me.cbprogramstudi2.Size = New System.Drawing.Size(236, 21)
        Me.cbprogramstudi2.TabIndex = 12
        '
        'btdetail
        '
        Me.btdetail.Location = New System.Drawing.Point(128, 116)
        Me.btdetail.Name = "btdetail"
        Me.btdetail.Size = New System.Drawing.Size(75, 23)
        Me.btdetail.TabIndex = 6
        Me.btdetail.Text = "Detail"
        Me.btdetail.UseVisualStyleBackColor = True
        '
        'dgvMhs
        '
        Me.dgvMhs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvMhs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMhs.Location = New System.Drawing.Point(8, 145)
        Me.dgvMhs.Name = "dgvMhs"
        Me.dgvMhs.Size = New System.Drawing.Size(455, 267)
        Me.dgvMhs.TabIndex = 5
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(128, 80)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(335, 20)
        Me.TextBox3.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(87, 80)
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
        Me.cbjenjangpendidikan2.Items.AddRange(New Object() {"D3", "S1"})
        Me.cbjenjangpendidikan2.Location = New System.Drawing.Point(128, 17)
        Me.cbjenjangpendidikan2.Name = "cbjenjangpendidikan2"
        Me.cbjenjangpendidikan2.Size = New System.Drawing.Size(75, 21)
        Me.cbjenjangpendidikan2.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(57, 121)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Tempat Lahir"
        '
        'ttempatlahir
        '
        Me.ttempatlahir.Location = New System.Drawing.Point(157, 118)
        Me.ttempatlahir.Name = "ttempatlahir"
        Me.ttempatlahir.Size = New System.Drawing.Size(200, 20)
        Me.ttempatlahir.TabIndex = 22
        Me.ttempatlahir.Text = "Masohi"
        '
        'fdatamahasiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 463)
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
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbjenjangpendidikan2 As System.Windows.Forms.ComboBox
    Friend WithEvents btdetail As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbprogramstudi2 As System.Windows.Forms.ComboBox
    Friend WithEvents ttempatlahir As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
