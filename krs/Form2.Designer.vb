<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmenuutama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmenuutama))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataMahasiswaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataMataKuliahToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataKRSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntryToolStripMenuItem, Me.ReportToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(619, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EntryToolStripMenuItem
        '
        Me.EntryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataMahasiswaToolStripMenuItem, Me.DataMataKuliahToolStripMenuItem, Me.DataKRSToolStripMenuItem})
        Me.EntryToolStripMenuItem.Name = "EntryToolStripMenuItem"
        Me.EntryToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.EntryToolStripMenuItem.Text = "&Entri Data"
        '
        'DataMahasiswaToolStripMenuItem
        '
        Me.DataMahasiswaToolStripMenuItem.Name = "DataMahasiswaToolStripMenuItem"
        Me.DataMahasiswaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DataMahasiswaToolStripMenuItem.Text = "&Biodata Mahasiswa"
        '
        'DataMataKuliahToolStripMenuItem
        '
        Me.DataMataKuliahToolStripMenuItem.Name = "DataMataKuliahToolStripMenuItem"
        Me.DataMataKuliahToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DataMataKuliahToolStripMenuItem.Text = "&Mata Kuliah"
        '
        'DataKRSToolStripMenuItem
        '
        Me.DataKRSToolStripMenuItem.Name = "DataKRSToolStripMenuItem"
        Me.DataKRSToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DataKRSToolStripMenuItem.Text = "Kartu &Rencana Studi"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.ReportToolStripMenuItem.Text = "&Laporan"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.KeluarToolStripMenuItem.Text = "&Keluar"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(241, 91)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'fmenuutama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 476)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "fmenuutama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ":: MENU UTAMA ::"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents EntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataMahasiswaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataMataKuliahToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataKRSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
