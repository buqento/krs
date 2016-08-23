Imports MySql.Data.MySqlClient

Public Class fkrs
    Dim myadp As MySqlDataAdapter
    Dim dt As New DataTable
    Dim cmd As MySqlCommand
    Dim drd As MySqlDataReader

    Private Sub filter_data_mahasiswa()
        openConnectionsMySQL()
        Try
            Dim str As String
            str = "SELECT * FROM data_mahasiswa WHERE nim='" & tnim.Text & "'"
            cmd = New MySqlCommand(str, connectMySQL)
            drd = cmd.ExecuteReader
            drd.Read()
            If drd.HasRows Then
                tnama.Text = drd.Item("nama_lengkap")
                tjenjangpendidikan.Text = drd.Item("jenjang_pendidikan")
                tprogramstudi.Text = drd.Item("program_studi")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub filter_data_matakuliah()
        openConnectionsMySQL()
        Try
            Dim str As String
            str = "SELECT * FROM data_mata_kuliah WHERE kode_mata_kuliah='" & tkodemk.Text & "'"
            cmd = New MySqlCommand(str, connectMySQL)
            drd = cmd.ExecuteReader
            drd.Read()
            If drd.HasRows Then
                tnamamk.Text = drd.Item("nama_mata_kuliah")
                tsks.Text = drd.Item("sks")
                tdosenpengampu.Text = drd.Item("dosen_pengampu")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub filter_data_krs()
        openConnectionsMySQL()
        Dim query As String
        query = "SELECT * FROM data_krs WHERE nim='" & tnim.Text & "'"
        Try
            myadp = New MySqlDataAdapter(query, connectMySQL)
            dt.Clear()
            myadp.Fill(dt)
            dgvkrs.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub fkrs_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        openConnectionsMySQL()
        filter_data_krs()
        cbtahunakademik.SelectedIndex = 0
        cbsemester.SelectedIndex = 0
    End Sub

    Private Sub btkontrak_Click(sender As System.Object, e As System.EventArgs) Handles btkontrak.Click
        openConnectionsMySQL()
        Dim mycmd As New MySqlCommand("INSERT INTO data_krs(no_krs,nim,kode_mata_kuliah,nama_matakuliah,sks,semester,dosen_pengampu,tahun_akademik) " _
                             + "VALUES ('" & lbnokrs.Text & "','" & tnim.Text & "','" & tkodemk.Text & "','" & tnamamk.Text & "','" & tsks.Text & "','" & cbsemester.Text & "','" & tdosenpengampu.Text & "','" & cbtahunakademik.Text & "')", connectMySQL)

        Try
            If mycmd.ExecuteNonQuery() = 1 Then
                MsgBox("Insert data berhasil")
                Call filter_data_krs()
                Exit Sub
            End If
        Catch ex As MySqlException
            MsgBox("Insert data gagal")
        End Try
    End Sub

    Private Sub btkeluar_Click(sender As System.Object, e As System.EventArgs) Handles btkeluar.Click
        Close()
    End Sub

    Private Sub tnim_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tnim.KeyPress
        If (e.KeyChar = Chr(13)) Then
            filter_data_mahasiswa()
            filter_data_krs()
        End If
    End Sub

    Private Sub tkodemk_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tkodemk.KeyPress
        If (e.KeyChar = Chr(13)) Then
            filter_data_matakuliah()
        End If
    End Sub

End Class