Public Class fmenuutama

    Private Sub DataMahasiswaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DataMahasiswaToolStripMenuItem.Click
        fdatamahasiswa.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub DataMataKuliahToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DataMataKuliahToolStripMenuItem.Click
        fmtkuliah.Show()
    End Sub

    Private Sub DataKRSToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DataKRSToolStripMenuItem.Click
        fkrs.Show()
    End Sub
End Class