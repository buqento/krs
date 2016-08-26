<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fkrs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fkrs))
        Me.lbnokrs = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbtahunakademik = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tdosenpengampu = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tsks = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tnamamk = New System.Windows.Forms.TextBox()
        Me.btkontrak = New System.Windows.Forms.Button()
        Me.tkodemk = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvkrs = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tprogramstudi = New System.Windows.Forms.TextBox()
        Me.tjenjangpendidikan = New System.Windows.Forms.TextBox()
        Me.tnama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tnim = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbsemester = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tnokrs = New System.Windows.Forms.TextBox()
        Me.btkeluar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvkrs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbnokrs
        '
        Me.lbnokrs.AutoSize = True
        Me.lbnokrs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbnokrs.Location = New System.Drawing.Point(21, 19)
        Me.lbnokrs.Name = "lbnokrs"
        Me.lbnokrs.Size = New System.Drawing.Size(79, 16)
        Me.lbnokrs.TabIndex = 1
        Me.lbnokrs.Text = "Nomor KRS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(422, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tahun Akademik"
        '
        'cbtahunakademik
        '
        Me.cbtahunakademik.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbtahunakademik.FormattingEnabled = True
        Me.cbtahunakademik.Items.AddRange(New Object() {"2015", "2016"})
        Me.cbtahunakademik.Location = New System.Drawing.Point(546, 39)
        Me.cbtahunakademik.Name = "cbtahunakademik"
        Me.cbtahunakademik.Size = New System.Drawing.Size(75, 24)
        Me.cbtahunakademik.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tdosenpengampu)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.tsks)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.tnamamk)
        Me.GroupBox1.Controls.Add(Me.btkontrak)
        Me.GroupBox1.Controls.Add(Me.tkodemk)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(425, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(366, 169)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mata Kuliah"
        '
        'tdosenpengampu
        '
        Me.tdosenpengampu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdosenpengampu.Location = New System.Drawing.Point(142, 81)
        Me.tdosenpengampu.Name = "tdosenpengampu"
        Me.tdosenpengampu.ReadOnly = True
        Me.tdosenpengampu.Size = New System.Drawing.Size(209, 22)
        Me.tdosenpengampu.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(30, 81)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 16)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Dosen Pengajar"
        '
        'tsks
        '
        Me.tsks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsks.Location = New System.Drawing.Point(309, 29)
        Me.tsks.Name = "tsks"
        Me.tsks.ReadOnly = True
        Me.tsks.Size = New System.Drawing.Size(42, 22)
        Me.tsks.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(275, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 16)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "SKS"
        '
        'tnamamk
        '
        Me.tnamamk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tnamamk.Location = New System.Drawing.Point(142, 55)
        Me.tnamamk.Name = "tnamamk"
        Me.tnamamk.ReadOnly = True
        Me.tnamamk.Size = New System.Drawing.Size(209, 22)
        Me.tnamamk.TabIndex = 3
        '
        'btkontrak
        '
        Me.btkontrak.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btkontrak.Location = New System.Drawing.Point(142, 110)
        Me.btkontrak.Name = "btkontrak"
        Me.btkontrak.Size = New System.Drawing.Size(75, 43)
        Me.btkontrak.TabIndex = 0
        Me.btkontrak.Text = "K&ontrak"
        Me.btkontrak.UseVisualStyleBackColor = True
        '
        'tkodemk
        '
        Me.tkodemk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tkodemk.Location = New System.Drawing.Point(142, 28)
        Me.tkodemk.Name = "tkodemk"
        Me.tkodemk.Size = New System.Drawing.Size(127, 22)
        Me.tkodemk.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 16)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Nama Matakuliah"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Kode Matakuliah"
        '
        'dgvkrs
        '
        Me.dgvkrs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvkrs.Location = New System.Drawing.Point(24, 262)
        Me.dgvkrs.Name = "dgvkrs"
        Me.dgvkrs.Size = New System.Drawing.Size(767, 158)
        Me.dgvkrs.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.tprogramstudi)
        Me.GroupBox2.Controls.Add(Me.tjenjangpendidikan)
        Me.GroupBox2.Controls.Add(Me.tnama)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.tnim)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(24, 73)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(395, 169)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Mahasiswa"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(43, 120)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 16)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Program Studi"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 92)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 16)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Jenjang Pendidikan"
        '
        'tprogramstudi
        '
        Me.tprogramstudi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tprogramstudi.Location = New System.Drawing.Point(142, 120)
        Me.tprogramstudi.Name = "tprogramstudi"
        Me.tprogramstudi.ReadOnly = True
        Me.tprogramstudi.Size = New System.Drawing.Size(238, 22)
        Me.tprogramstudi.TabIndex = 9
        '
        'tjenjangpendidikan
        '
        Me.tjenjangpendidikan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tjenjangpendidikan.Location = New System.Drawing.Point(142, 92)
        Me.tjenjangpendidikan.Name = "tjenjangpendidikan"
        Me.tjenjangpendidikan.ReadOnly = True
        Me.tjenjangpendidikan.Size = New System.Drawing.Size(43, 22)
        Me.tjenjangpendidikan.TabIndex = 8
        '
        'tnama
        '
        Me.tnama.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tnama.Location = New System.Drawing.Point(142, 55)
        Me.tnama.Name = "tnama"
        Me.tnama.ReadOnly = True
        Me.tnama.Size = New System.Drawing.Size(238, 22)
        Me.tnama.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(91, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nama"
        '
        'tnim
        '
        Me.tnim.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tnim.Location = New System.Drawing.Point(142, 22)
        Me.tnim.MaxLength = 9
        Me.tnim.Name = "tnim"
        Me.tnim.Size = New System.Drawing.Size(100, 22)
        Me.tnim.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(104, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "NIM"
        '
        'cbsemester
        '
        Me.cbsemester.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbsemester.FormattingEnabled = True
        Me.cbsemester.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.cbsemester.Location = New System.Drawing.Point(353, 39)
        Me.cbsemester.Name = "cbsemester"
        Me.cbsemester.Size = New System.Drawing.Size(51, 24)
        Me.cbsemester.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(281, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Semester"
        '
        'tnokrs
        '
        Me.tnokrs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tnokrs.Location = New System.Drawing.Point(24, 42)
        Me.tnokrs.Name = "tnokrs"
        Me.tnokrs.Size = New System.Drawing.Size(206, 22)
        Me.tnokrs.TabIndex = 9
        Me.tnokrs.Text = "KRS-001"
        '
        'btkeluar
        '
        Me.btkeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btkeluar.Location = New System.Drawing.Point(716, 426)
        Me.btkeluar.Name = "btkeluar"
        Me.btkeluar.Size = New System.Drawing.Size(75, 43)
        Me.btkeluar.TabIndex = 10
        Me.btkeluar.Text = "&Keluar"
        Me.btkeluar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(24, 426)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(247, 91)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'fkrs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 537)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btkeluar)
        Me.Controls.Add(Me.tnokrs)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbsemester)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgvkrs)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbtahunakademik)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbnokrs)
        Me.Name = "fkrs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ":: KARTU RENCANA STUDI ::"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvkrs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbnokrs As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbtahunakademik As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tnamamk As System.Windows.Forms.TextBox
    Friend WithEvents tkodemk As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgvkrs As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tnama As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tnim As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btkontrak As System.Windows.Forms.Button
    Friend WithEvents cbsemester As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tsks As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tdosenpengampu As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tprogramstudi As System.Windows.Forms.TextBox
    Friend WithEvents tjenjangpendidikan As System.Windows.Forms.TextBox
    Friend WithEvents tnokrs As System.Windows.Forms.TextBox
    Friend WithEvents btkeluar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
