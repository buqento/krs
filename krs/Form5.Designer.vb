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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btkeluar = New System.Windows.Forms.Button()
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
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvkrs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btkeluar)
        Me.Panel1.Location = New System.Drawing.Point(395, 323)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(350, 45)
        Me.Panel1.TabIndex = 0
        '
        'btkeluar
        '
        Me.btkeluar.Location = New System.Drawing.Point(272, 11)
        Me.btkeluar.Name = "btkeluar"
        Me.btkeluar.Size = New System.Drawing.Size(75, 23)
        Me.btkeluar.TabIndex = 1
        Me.btkeluar.Text = "K&eluar"
        Me.btkeluar.UseVisualStyleBackColor = True
        '
        'lbnokrs
        '
        Me.lbnokrs.AutoSize = True
        Me.lbnokrs.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbnokrs.Location = New System.Drawing.Point(18, 15)
        Me.lbnokrs.Name = "lbnokrs"
        Me.lbnokrs.Size = New System.Drawing.Size(206, 25)
        Me.lbnokrs.TabIndex = 1
        Me.lbnokrs.Text = "KRS-201509070001"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(244, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tahun Akademik"
        '
        'cbtahunakademik
        '
        Me.cbtahunakademik.FormattingEnabled = True
        Me.cbtahunakademik.Items.AddRange(New Object() {"2015", "2016"})
        Me.cbtahunakademik.Location = New System.Drawing.Point(338, 19)
        Me.cbtahunakademik.Name = "cbtahunakademik"
        Me.cbtahunakademik.Size = New System.Drawing.Size(51, 21)
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
        Me.GroupBox1.Location = New System.Drawing.Point(24, 227)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(366, 141)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mata Kuliah"
        '
        'tdosenpengampu
        '
        Me.tdosenpengampu.Location = New System.Drawing.Point(121, 81)
        Me.tdosenpengampu.Name = "tdosenpengampu"
        Me.tdosenpengampu.ReadOnly = True
        Me.tdosenpengampu.Size = New System.Drawing.Size(230, 20)
        Me.tdosenpengampu.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 81)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Dosen Pengampu"
        '
        'tsks
        '
        Me.tsks.Location = New System.Drawing.Point(309, 29)
        Me.tsks.Name = "tsks"
        Me.tsks.ReadOnly = True
        Me.tsks.Size = New System.Drawing.Size(42, 20)
        Me.tsks.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(275, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "SKS"
        '
        'tnamamk
        '
        Me.tnamamk.Location = New System.Drawing.Point(121, 55)
        Me.tnamamk.Name = "tnamamk"
        Me.tnamamk.ReadOnly = True
        Me.tnamamk.Size = New System.Drawing.Size(230, 20)
        Me.tnamamk.TabIndex = 3
        '
        'btkontrak
        '
        Me.btkontrak.Location = New System.Drawing.Point(121, 107)
        Me.btkontrak.Name = "btkontrak"
        Me.btkontrak.Size = New System.Drawing.Size(75, 23)
        Me.btkontrak.TabIndex = 0
        Me.btkontrak.Text = "&Kontrak"
        Me.btkontrak.UseVisualStyleBackColor = True
        '
        'tkodemk
        '
        Me.tkodemk.Location = New System.Drawing.Point(121, 29)
        Me.tkodemk.Name = "tkodemk"
        Me.tkodemk.Size = New System.Drawing.Size(69, 20)
        Me.tkodemk.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Nama Matakuliah"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Kode Matakuliah"
        '
        'dgvkrs
        '
        Me.dgvkrs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvkrs.Location = New System.Drawing.Point(395, 23)
        Me.dgvkrs.Name = "dgvkrs"
        Me.dgvkrs.Size = New System.Drawing.Size(350, 294)
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
        Me.GroupBox2.Location = New System.Drawing.Point(24, 73)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(365, 136)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Mahasiswa"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(39, 107)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Program Studi"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 81)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Jenjang Pendidikan"
        '
        'tprogramstudi
        '
        Me.tprogramstudi.Location = New System.Drawing.Point(121, 107)
        Me.tprogramstudi.Name = "tprogramstudi"
        Me.tprogramstudi.ReadOnly = True
        Me.tprogramstudi.Size = New System.Drawing.Size(230, 20)
        Me.tprogramstudi.TabIndex = 9
        '
        'tjenjangpendidikan
        '
        Me.tjenjangpendidikan.Location = New System.Drawing.Point(121, 81)
        Me.tjenjangpendidikan.Name = "tjenjangpendidikan"
        Me.tjenjangpendidikan.ReadOnly = True
        Me.tjenjangpendidikan.Size = New System.Drawing.Size(43, 20)
        Me.tjenjangpendidikan.TabIndex = 8
        '
        'tnama
        '
        Me.tnama.Location = New System.Drawing.Point(121, 55)
        Me.tnama.Name = "tnama"
        Me.tnama.ReadOnly = True
        Me.tnama.Size = New System.Drawing.Size(230, 20)
        Me.tnama.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(77, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nama"
        '
        'tnim
        '
        Me.tnim.Location = New System.Drawing.Point(121, 25)
        Me.tnim.MaxLength = 9
        Me.tnim.Name = "tnim"
        Me.tnim.Size = New System.Drawing.Size(100, 20)
        Me.tnim.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(85, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "NIM"
        '
        'cbsemester
        '
        Me.cbsemester.FormattingEnabled = True
        Me.cbsemester.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.cbsemester.Location = New System.Drawing.Point(338, 46)
        Me.cbsemester.Name = "cbsemester"
        Me.cbsemester.Size = New System.Drawing.Size(51, 21)
        Me.cbsemester.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(281, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Semester"
        '
        'fkrs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 406)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbsemester)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgvkrs)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbtahunakademik)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbnokrs)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "fkrs"
        Me.Text = "Kartu Rencana Studi"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvkrs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
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
    Friend WithEvents btkeluar As System.Windows.Forms.Button
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
End Class
