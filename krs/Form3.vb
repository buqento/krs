Imports MySql.Data.MySqlClient

Public Class fdatamahasiswa
    Dim myadp As MySqlDataAdapter
    Dim dt As New DataTable
    Dim cmd As MySqlCommand
    Dim drd As MySqlDataReader

    Private Sub fdatamahasiswa_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        openConnectionsMySQL()
        If connectMySQL.State = ConnectionState.Closed Then
            Try
                connectMySQL.Open()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        Call baca_data_mahasiswa()
        cbagama.SelectedIndex = 4
        cbjenjangpendidikan.SelectedIndex = 0
        cbprogramstudi.SelectedIndex = 0
        cbjenjangpendidikan2.SelectedIndex = 0
        TabPage1.Focus()
        'ttotalmhs.Text = dgvMhs.RowCount - 1
    End Sub

    Private Sub cari_data_mahasiswa()
        openConnectionsMySQL()
        Try
            Dim str As String
            str = "SELECT * FROM data_mahasiswa WHERE nim='" & tnim.Text & "'"
            cmd = New MySqlCommand(str, connectMySQL)
            drd = cmd.ExecuteReader
            drd.Read()
            If drd.HasRows Then
                tnama.Text = drd.Item("nama_lengkap")
                If drd.Item("jenis_kelamin") = "L" Then
                    rbl.Checked = True
                Else
                    rbp.Checked = True
                End If
                ttempatlahir.Text = drd.Item("tempat_lahir")
                cbagama.Text = drd.Item("agama")
                rtalamat.Text = drd.Item("alamat")
                cbjenjangpendidikan.Text = drd.Item("jenjang_pendidikan")
                cbprogramstudi.Text = drd.Item("program_studi")
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub baca_data_mahasiswa()
        openConnectionsMySQL()
        Dim query As String
        query = "SELECT * FROM data_mahasiswa"
        Try
            myadp = New MySqlDataAdapter(query, connectMySQL)
            dt.Clear()
            myadp.Fill(dt)
            dgvMhs.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub filter_data_mahasiswa()
        openConnectionsMySQL()
        Dim query As String
        query = "SELECT * FROM data_mahasiswa WHERE jenjang_pendidikan='" & cbjenjangpendidikan2.Text & "' AND program_studi='" & cbprogramstudi2.Text & "'"
        Try
            myadp = New MySqlDataAdapter(query, connectMySQL)
            dt.Clear()
            myadp.Fill(dt)
            dgvMhs.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btsimpan_Click(sender As System.Object, e As System.EventArgs) Handles btsimpan.Click
        Dim jenis As String
        If rbl.Checked Then
            jenis = "L"
        Else
            jenis = "P"
        End If
        Dim mycmd As New MySqlCommand("INSERT INTO data_mahasiswa (nim,nama_lengkap,jenis_kelamin,tempat_lahir,tanggal,agama,alamat,jenjang_pendidikan,program_studi) " _
                                     + "VALUES ('" & tnim.Text & "','" & tnama.Text & "','" & jenis & "','" & ttempatlahir.Text & "','" & Format(dtptanggal.Value, "yyyy-MM-dd") & "','" & cbagama.Text & "','" & rtalamat.Text & "','" & cbjenjangpendidikan.Text & "','" & cbprogramstudi.Text & "')", connectMySQL)

        If (tnama.Text <> "" And tnim.Text <> "" And ttempatlahir.Text <> "" And rtalamat.Text <> "") Then
            Try
                If mycmd.ExecuteNonQuery() = 1 Then
                    MsgBox("Insert data berhasil")
                    Call baca_data_mahasiswa()
                    Exit Sub
                End If
            Catch ex As MySqlException
                MsgBox("Nomor Induk Mahasiswa telah terdaftar")
            End Try
        Else
            MsgBox("Periksa inputan data")
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs)
        Close()
    End Sub

    Private Sub bthapus_Click(sender As System.Object, e As System.EventArgs) Handles bthapus.Click
        openConnectionsMySQL()
        If tnim.Text <> "" Then
            Dim mycmd As New MySqlCommand("DELETE FROM data_mahasiswa WHERE nim='" & tnim.Text & "'", connectMySQL)
            Try
                If mycmd.ExecuteNonQuery() = 1 Then
                    MsgBox("Hapus data berhasil")
                    Call baca_data_mahasiswa()
                End If
            Catch ex As MySqlException
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Masukkan NIM")
        End If

    End Sub

    Private Sub btubah_Click(sender As System.Object, e As System.EventArgs) Handles btubah.Click
        openConnectionsMySQL()
        Dim jenis As String
        If rbl.Checked Then
            jenis = "L"
        Else
            jenis = "P"
        End If
        If tnim.Text <> "" Then
            Dim mycmd As New MySqlCommand("UPDATE data_mahasiswa SET " _
                                          + " nama_lengkap='" & tnama.Text & "',jenis_kelamin='" & jenis & "',tanggal='" & Format(dtptanggal.Value, "yyyy-MM-dd") & "',agama='" & cbagama.Text & "',alamat='" & rtalamat.Text & "',jenjang_pendidikan='" & cbjenjangpendidikan.Text & "',program_studi='" & cbprogramstudi.Text & "'" _
                                          + " WHERE nim='" & tnim.Text & "'", connectMySQL)
            Try
                If mycmd.ExecuteNonQuery() = 1 Then
                    MsgBox("Data telah diubah")
                    Call baca_data_mahasiswa()
                End If
            Catch ex As MySqlException
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Masukkan NIM")
        End If

    End Sub

    Private Sub cbjenjangpendidikan2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbjenjangpendidikan2.SelectedIndexChanged
        If cbjenjangpendidikan2.SelectedIndex = 1 Then
            cbprogramstudi2.Items.Clear()
            cbprogramstudi2.Items.Add("Teknik Informatika")
            cbprogramstudi2.Items.Add("Sistem Informasi")
        Else
            cbprogramstudi2.Items.Clear()
            cbprogramstudi2.Items.Add("Manajemen Informatika")
            cbprogramstudi2.Items.Add("Komputerisasi Akuntansi")
        End If
        cbprogramstudi2.SelectedIndex = 0
        filter_data_mahasiswa()
    End Sub

    Private Sub cbjenjangpendidikan_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cbjenjangpendidikan.KeyPress
        If (e.KeyChar = Chr(13)) Then
            cbprogramstudi.Focus()
        End If
    End Sub

    Private Sub cbjenjangpendidikan_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbjenjangpendidikan.SelectedIndexChanged
        If cbjenjangpendidikan.SelectedIndex = 1 Then
            cbprogramstudi.Items.Clear()
            cbprogramstudi.Items.Add("Teknik Informatika")
            cbprogramstudi.Items.Add("Sistem Informasi")
        Else
            cbprogramstudi.Items.Clear()
            cbprogramstudi.Items.Add("Manajemen Informatika")
            cbprogramstudi.Items.Add("Komputerisasi Akuntansi")
        End If
        cbprogramstudi.SelectedIndex = 0
    End Sub

    Private Sub TabPage1_Click(sender As System.Object, e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub tnama_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tnama.KeyPress
        If (e.KeyChar = Chr(13)) Then
            tnim.Focus()
        End If
    End Sub

    Private Sub tnama_TextChanged(sender As System.Object, e As System.EventArgs) Handles tnama.TextChanged

    End Sub

    Private Sub tnim_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tnim.KeyPress
        If (e.KeyChar = Chr(13)) Then
            cari_data_mahasiswa()
        End If
    End Sub

    Private Sub tnim_TextChanged(sender As System.Object, e As System.EventArgs) Handles tnim.TextChanged

    End Sub

    Private Sub rbl_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbl.CheckedChanged

    End Sub

    Private Sub rbl_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles rbl.KeyPress
        If (e.KeyChar = Chr(13)) Then
            dtptanggal.Focus()
        End If
    End Sub

    Private Sub dtptanggal_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles dtptanggal.KeyPress
        If (e.KeyChar = Chr(13)) Then
            cbagama.Focus()
        End If
    End Sub

    Private Sub dtptanggal_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtptanggal.ValueChanged

    End Sub

    Private Sub cbagama_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cbagama.KeyPress
        If (e.KeyChar = Chr(13)) Then
            rtalamat.Focus()
        End If
    End Sub

    Private Sub cbagama_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbagama.SelectedIndexChanged

    End Sub

    Private Sub rtalamat_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles rtalamat.KeyPress
        If (e.KeyChar = Chr(13)) Then
            cbjenjangpendidikan.Focus()
        End If
    End Sub

    Private Sub rtalamat_TextChanged(sender As System.Object, e As System.EventArgs) Handles rtalamat.TextChanged

    End Sub

    Private Sub cbprogramstudi_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cbprogramstudi.KeyPress
        If (e.KeyChar = Chr(13)) Then
            btsimpan.Focus()
        End If
    End Sub

    Private Sub cbprogramstudi_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbprogramstudi.SelectedIndexChanged

    End Sub

    Private Sub cbprogramstudi2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbprogramstudi2.SelectedIndexChanged
        filter_data_mahasiswa()
    End Sub

    Private Sub btkeluar_Click(sender As System.Object, e As System.EventArgs) Handles btkeluar.Click
        Close()
    End Sub
End Class