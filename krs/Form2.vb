Public Class fmenuutama

    Private Sub DataMahasiswaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DataMahasiswaToolStripMenuItem.Click
        fdatamahasiswa.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class