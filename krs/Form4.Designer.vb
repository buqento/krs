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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btkeluar = New System.Windows.Forms.Button()
        Me.bthapus = New System.Windows.Forms.Button()
        Me.btsimpan = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dgvmatakuliah = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgvmatakuliah, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(354, 131)
        Me.Panel1.TabIndex = 0
        '
        'cbsemester
        '
        Me.cbsemester.FormattingEnabled = True
        Me.cbsemester.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.cbsemester.Location = New System.Drawing.Point(135, 91)
        Me.cbsemester.Name = "cbsemester"
        Me.cbsemester.Size = New System.Drawing.Size(73, 21)
        Me.cbsemester.TabIndex = 7
        '
        'tsks
        '
        Me.tsks.Location = New System.Drawing.Point(135, 65)
        Me.tsks.Name = "tsks"
        Me.tsks.Size = New System.Drawing.Size(73, 20)
        Me.tsks.TabIndex = 6
        '
        'tnamamatakuliah
        '
        Me.tnamamatakuliah.Location = New System.Drawing.Point(135, 39)
        Me.tnamamatakuliah.Name = "tnamamatakuliah"
        Me.tnamamatakuliah.Size = New System.Drawing.Size(203, 20)
        Me.tnamamatakuliah.TabIndex = 5
        '
        'tkodematakuliah
        '
        Me.tkodematakuliah.Location = New System.Drawing.Point(135, 13)
        Me.tkodematakuliah.Name = "tkodematakuliah"
        Me.tkodematakuliah.Size = New System.Drawing.Size(73, 20)
        Me.tkodematakuliah.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(78, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Semester"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Mata Kuliah"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(101, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "SKS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
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
        Me.Panel2.Location = New System.Drawing.Point(372, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(374, 131)
        Me.Panel2.TabIndex = 1
        '
        'tkodedosen
        '
        Me.tkodedosen.Location = New System.Drawing.Point(142, 92)
        Me.tkodedosen.Name = "tkodedosen"
        Me.tkodedosen.Size = New System.Drawing.Size(210, 20)
        Me.tkodedosen.TabIndex = 7
        '
        'cbprogramstudi
        '
        Me.cbprogramstudi.FormattingEnabled = True
        Me.cbprogramstudi.Items.AddRange(New Object() {"Teknik Informatika"})
        Me.cbprogramstudi.Location = New System.Drawing.Point(142, 65)
        Me.cbprogramstudi.Name = "cbprogramstudi"
        Me.cbprogramstudi.Size = New System.Drawing.Size(210, 21)
        Me.cbprogramstudi.TabIndex = 6
        '
        'cbjenjangpendidikan
        '
        Me.cbjenjangpendidikan.FormattingEnabled = True
        Me.cbjenjangpendidikan.Items.AddRange(New Object() {"D3", "S1"})
        Me.cbjenjangpendidikan.Location = New System.Drawing.Point(142, 40)
        Me.cbjenjangpendidikan.Name = "cbjenjangpendidikan"
        Me.cbjenjangpendidikan.Size = New System.Drawing.Size(77, 21)
        Me.cbjenjangpendidikan.TabIndex = 5
        '
        'cbtahunajaran
        '
        Me.cbtahunajaran.FormattingEnabled = True
        Me.cbtahunajaran.Items.AddRange(New Object() {"2016", "2017"})
        Me.cbtahunajaran.Location = New System.Drawing.Point(142, 13)
        Me.cbtahunajaran.Name = "cbtahunajaran"
        Me.cbtahunajaran.Size = New System.Drawing.Size(77, 21)
        Me.cbtahunajaran.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Kode Dosen Pengampu"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(63, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Program Studi"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Jenjang Pendidikan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(66, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Tahun Ajaran"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btkeluar)
        Me.Panel3.Controls.Add(Me.bthapus)
        Me.Panel3.Controls.Add(Me.btsimpan)
        Me.Panel3.Location = New System.Drawing.Point(12, 149)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(354, 53)
        Me.Panel3.TabIndex = 2
        '
        'btkeluar
        '
        Me.btkeluar.Location = New System.Drawing.Point(170, 16)
        Me.btkeluar.Name = "btkeluar"
        Me.btkeluar.Size = New System.Drawing.Size(75, 23)
        Me.btkeluar.TabIndex = 3
        Me.btkeluar.Text = "&Keluar"
        Me.btkeluar.UseVisualStyleBackColor = True
        '
        'bthapus
        '
        Me.bthapus.Location = New System.Drawing.Point(89, 16)
        Me.bthapus.Name = "bthapus"
        Me.bthapus.Size = New System.Drawing.Size(75, 23)
        Me.bthapus.TabIndex = 2
        Me.bthapus.Text = "&Hapus"
        Me.bthapus.UseVisualStyleBackColor = True
        '
        'btsimpan
        '
        Me.btsimpan.Location = New System.Drawing.Point(8, 16)
        Me.btsimpan.Name = "btsimpan"
        Me.btsimpan.Size = New System.Drawing.Size(75, 23)
        Me.btsimpan.TabIndex = 0
        Me.btsimpan.Text = "&Simpan"
        Me.btsimpan.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.dgvmatakuliah)
        Me.Panel4.Location = New System.Drawing.Point(12, 228)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(733, 127)
        Me.Panel4.TabIndex = 3
        '
        'dgvmatakuliah
        '
        Me.dgvmatakuliah.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvmatakuliah.Location = New System.Drawing.Point(0, 0)
        Me.dgvmatakuliah.Name = "dgvmatakuliah"
        Me.dgvmatakuliah.Size = New System.Drawing.Size(730, 150)
        Me.dgvmatakuliah.TabIndex = 0
        '
        'fmtkuliah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 361)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "fmtkuliah"
        Me.Text = "Mata Kuliah"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.dgvmatakuliah, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btkeluar As System.Windows.Forms.Button
    Friend WithEvents bthapus As System.Windows.Forms.Button
    Friend WithEvents btsimpan As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents dgvmatakuliah As System.Windows.Forms.DataGridView
End Class
