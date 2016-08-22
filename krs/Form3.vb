﻿Imports MySql.Data.MySqlClient
Public Class vglobal
    Public Shared jenis As String
End Class

Public Class fdatamahasiswa
    Dim myadp As MySqlDataAdapter
    Dim dt As New DataTable

    Sub jenis_kelamin()
        If rbl.Checked Then
            vglobal.jenis = "L"
        Else
            vglobal.jenis = "P"
        End If
    End Sub
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


    Private Sub btsimpan_Click(sender As System.Object, e As System.EventArgs) Handles btsimpan.Click
        jenis_kelamin()
        Dim mycmd As New MySqlCommand("INSERT INTO data_mahasiswa (nim,nama_lengkap,jenis_kelamin,tanggal,agama,alamat,jenjang_pendidikan,program_studi) " _
                                     + "VALUES ('" & tnim.Text & "','" & tnama.Text & "','" & vglobal.jenis & "','" & Format(dtptanggal.Value, "yyyy-MM-dd") & "','" & cbagama.Text & "','" & rtalamat.Text & "','" & cbjenjangpendidikan.Text & "','" & cbprogramstudi.Text & "')", connectMySQL)
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
        jenis_kelamin()
        If tnim.Text <> "" Then
            Dim mycmd As New MySqlCommand("UPDATE data_mahasiswa SET " _
                                          + " nama_lengkap='" & tnama.Text & "',jenis_kelamin='" & vglobal.jenis & "',tanggal='" & Format(dtptanggal.Value, "yyyy-MM-dd") & "',agama='" & cbagama.Text & "',alamat='" & rtalamat.Text & "',jenjang_pendidikan='" & cbjenjangpendidikan.Text & "',program_studi='" & cbprogramstudi.Text & "'" _
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
End Class