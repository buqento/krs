<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmtkuliah
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmtkuliah))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbsemester = New System.Windows.Forms.ComboBox()
        Me.tsks = New System.Windows.Forms.TextBox()
        Me.tnamamatakuliah = New System.Windows.Forms.TextBox()
        Me.tkodematakuliah = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tkodedosen = New System.Windows.Forms.TextBox()
        Me.cbprogramstudi = New System.Windows.Forms.ComboBox()
        Me.cbjenjangpendidikan = New System.Windows.Forms.ComboBox()
        Me.cbtahunajaran = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btkeluar = New System.Windows.Forms.Button()
        Me.bthapus = New System.Windows.Forms.Button()
        Me.btsimpan = New System.Windows.Forms.Button()
        Me.dgvmatakuliah = New System.Windows.Forms.DataGridView()
        Me.btubah = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvmatakuliah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cbsemester)
        Me.Panel1.Controls.Add(Me.tsks)
        Me.Panel1.Controls.Add(Me.tnamamatakuliah)
        Me.Panel1.Controls.Add(Me.tkodematakuliah)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(354, 141)
        Me.Panel1.TabIndex = 0
        '
        'cbsemester
        '
        Me.cbsemester.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbsemester.FormattingEnabled = True
        Me.cbsemester.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.cbsemester.Location = New System.Drawing.Point(135, 103)
        Me.cbsemester.Name = "cbsemester"
        Me.cbsemester.Size = New System.Drawing.Size(73, 24)
        Me.cbsemester.TabIndex = 7
        '
        'tsks
        '
        Me.tsks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsks.Location = New System.Drawing.Point(135, 73)
        Me.tsks.Name = "tsks"
        Me.tsks.Size = New System.Drawing.Size(73, 22)
        Me.tsks.TabIndex = 6
        '
        'tnamamatakuliah
        '
        Me.tnamamatakuliah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tnamamatakuliah.Location = New System.Drawing.Point(135, 46)
        Me.tnamamatakuliah.Name = "tnamamatakuliah"
        Me.tnamamatakuliah.Size = New System.Drawing.Size(203, 22)
        Me.tnamamatakuliah.TabIndex = 5
        '
        'tkodematakuliah
        '
        Me.tkodematakuliah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tkodematakuliah.Location = New System.Drawing.Point(135, 13)
        Me.tkodematakuliah.Name = "tkodematakuliah"
        Me.tkodematakuliah.Size = New System.Drawing.Size(73, 22)
        Me.tkodematakuliah.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(63, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Semester"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Mata Kuliah"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(95, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "SKS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Mata Kuliah"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.tkodedosen)
        Me.Panel2.Controls.Add(Me.cbprogramstudi)
        Me.Panel2.Controls.Add(Me.cbjenjangpendidikan)
        Me.Panel2.Controls.Add(Me.cbtahunajaran)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(372, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(374, 141)
        Me.Panel2.TabIndex = 1
        '
        'tkodedosen
        '
        Me.tkodedosen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tkodedosen.Location = New System.Drawing.Point(142, 106)
        Me.tkodedosen.Name = "tkodedosen"
        Me.tkodedosen.Size = New System.Drawing.Size(210, 22)
        Me.tkodedosen.TabIndex = 7
        '
        'cbprogramstudi
        '
        Me.cbprogramstudi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbprogramstudi.FormattingEnabled = True
        Me.cbprogramstudi.Items.AddRange(New Object() {"Teknik Informatika"})
        Me.cbprogramstudi.Location = New System.Drawing.Point(142, 76)
        Me.cbprogramstudi.Name = "cbprogramstudi"
        Me.cbprogramstudi.Size = New System.Drawing.Size(210, 24)
        Me.cbprogramstudi.TabIndex = 6
        '
        'cbjenjangpendidikan
        '
        Me.cbjenjangpendidikan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbjenjangpendidikan.FormattingEnabled = True
        Me.cbjenjangpendidikan.Items.AddRange(New Object() {"D3", "S1"})
        Me.cbjenjangpendidikan.Location = New System.Drawing.Point(142, 46)
        Me.cbjenjangpendidikan.Name = "cbjenjangpendidikan"
        Me.cbjenjangpendidikan.Size = New System.Drawing.Size(77, 24)
        Me.cbjenjangpendidikan.TabIndex = 5
        '
        'cbtahunajaran
        '
        Me.cbtahunajaran.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbtahunajaran.FormattingEnabled = True
        Me.cbtahunajaran.Items.AddRange(New Object() {"2016", "2017"})
        Me.cbtahunajaran.Location = New System.Drawing.Point(142, 16)
        Me.cbtahunajaran.Name = "cbtahunajaran"
        Me.cbtahunajaran.Size = New System.Drawing.Size(77, 24)
        Me.cbtahunajaran.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(30, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 16)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Dosen Pengajar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(43, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 16)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Program Studi"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 16)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Jenjang Pendidikan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(48, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Tahun Ajaran"
        '
        'btkeluar
        '
        Me.btkeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btkeluar.Location = New System.Drawing.Point(667, 361)
        Me.btkeluar.Name = "btkeluar"
        Me.btkeluar.Size = New System.Drawing.Size(75, 43)
        Me.btkeluar.TabIndex = 6
        Me.btkeluar.Text = "&Keluar"
        Me.btkeluar.UseVisualStyleBackColor = True
        '
        'bthapus
        '
        Me.bthapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bthapus.Location = New System.Drawing.Point(93, 159)
        Me.bthapus.Name = "bthapus"
        Me.bthapus.Size = New System.Drawing.Size(75, 43)
        Me.bthapus.TabIndex = 5
        Me.bthapus.Text = "&Hapus"
        Me.bthapus.UseVisualStyleBackColor = True
        '
        'btsimpan
        '
        Me.btsimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btsimpan.Location = New System.Drawing.Point(12, 159)
        Me.btsimpan.Name = "btsimpan"
        Me.btsimpan.Size = New System.Drawing.Size(75, 43)
        Me.btsimpan.TabIndex = 4
        Me.btsimpan.Text = "&Simpan"
        Me.btsimpan.UseVisualStyleBackColor = True
        '
        'dgvmatakuliah
        '
        Me.dgvmatakuliah.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvmatakuliah.Location = New System.Drawing.Point(12, 208)
        Me.dgvmatakuliah.Name = "dgvmatakuliah"
        Me.dgvmatakuliah.Size = New System.Drawing.Size(734, 147)
        Me.dgvmatakuliah.TabIndex = 7
        '
        'btubah
        '
        Me.btubah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btubah.Location = New System.Drawing.Point(174, 159)
        Me.btubah.Name = "btubah"
        Me.btubah.Size = New System.Drawing.Size(75, 43)
        Me.btubah.TabIndex = 8
        Me.btubah.Text = "&Ubah"
        Me.btubah.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 361)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(247, 91)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'fmtkuliah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 454)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btubah)
        Me.Controls.Add(Me.dgvmatakuliah)
        Me.Controls.Add(Me.btkeluar)
        Me.Controls.Add(Me.bthapus)
        Me.Controls.Add(Me.btsimpan)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "fmtkuliah"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ":: MATA KULIAH ::"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvmatakuliah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cbsemester As System.Windows.Forms.ComboBox
    Friend WithEvents tsks As System.Windows.Forms.TextBox
    Friend WithEvents tnamamatakuliah As System.Windows.Forms.TextBox
    Friend WithEvents tkodematakuliah As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents tkodedosen As System.Windows.Forms.TextBox
    Friend WithEvents cbprogramstudi As System.Windows.Forms.ComboBox
    Friend WithEvents cbjenjangpendidikan As System.Windows.Forms.ComboBox
    Friend WithEvents cbtahunajaran As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btkeluar As System.Windows.Forms.Button
    Friend WithEvents bthapus As System.Windows.Forms.Button
    Friend WithEvents btsimpan As System.Windows.Forms.Button
    Friend WithEvents dgvmatakuliah As System.Windows.Forms.DataGridView
    Friend WithEvents btubah As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
