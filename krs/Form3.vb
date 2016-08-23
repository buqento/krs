Imports MySql.Data.MySqlClient

Public Class fdatamahasiswa
    Dim myadp As MySqlDataAdapter
    Dim dt As New DataTable

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
        'ttotalmhs.Text = dgvMhs.RowCount - 1
    End Sub

    Private Sub baca_data_mahasiswa()
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
        Dim query As String
        query = "SELECT * FROM data_mahasiswa WHERE jenjang_pendidikan='" & cbjenjangpendidikan2.Text & "'"
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

        Try
            If mycmd.ExecuteNonQuery() = 1 Then
                MsgBox("Insert data berhasil")
                Call baca_data_mahasiswa()
                Exit Sub
            End If
        Catch ex As MySqlException
            MsgBox("Insert data gagal")
        End Try
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles btkeluar.Click
        Close()
    End Sub

    Private Sub bthapus_Click(sender As System.Object, e As System.EventArgs) Handles bthapus.Click
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
            MsgBox("Pilih data yang ingin dihapus")
        End If

    End Sub

    Private Sub btubah_Click(sender As System.Object, e As System.EventArgs) Handles btubah.Click
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
    End Sub


    Private Sub btdetail_Click(sender As System.Object, e As System.EventArgs) Handles btdetail.Click
        filter_data_mahasiswa()
    End Sub

    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs) Handles Label5.Click

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
End Class