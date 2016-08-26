<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmenucetaklaporan
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
        Me.btcetak = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tnim = New System.Windows.Forms.TextBox()
        Me.LaporanMtkuliah1 = New krs.LaporanMtkuliah()
        Me.SuspendLayout()
        '
        'btcetak
        '
        Me.btcetak.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btcetak.Location = New System.Drawing.Point(168, 17)
        Me.btcetak.Name = "btcetak"
        Me.btcetak.Size = New System.Drawing.Size(75, 23)
        Me.btcetak.TabIndex = 0
        Me.btcetak.Text = "&Cetak"
        Me.btcetak.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NIM"
        '
        'tnim
        '
        Me.tnim.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tnim.Location = New System.Drawing.Point(62, 18)
        Me.tnim.Name = "tnim"
        Me.tnim.Size = New System.Drawing.Size(100, 22)
        Me.tnim.TabIndex = 2
        '
        'fmenucetaklaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 61)
        Me.Controls.Add(Me.tnim)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btcetak)
        Me.Name = "fmenucetaklaporan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ":: CETAK LAPORAN ::"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LaporanMtkuliah1 As krs.LaporanMtkuliah
    Friend WithEvents btcetak As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tnim As System.Windows.Forms.TextBox
End Class
