Public Class fmenucetaklaporan

    Private Sub btcetak_Click(sender As System.Object, e As System.EventArgs) Handles btcetak.Click
        fcetakkrs.CrystalReportViewer1.SelectionFormula = "{Command.nim} = '" & tnim.Text & "'"
        fcetakkrs.Refresh()
        fcetakkrs.Show()
    End Sub
End Class