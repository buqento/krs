﻿Imports MySql.Data.MySqlClient

Public Class fmtkuliah
    Dim myadp As MySqlDataAdapter
    Dim dt As New DataTable
    Dim cmd As MySqlCommand
    Dim drd As MySqlDataReader


    Private Sub cari_data_matakuliah()
        openConnectionsMySQL()
        Try
            Dim str As String
            str = "SELECT * FROM  data_mata_kuliah WHERE kode_mk='" & tkodematakuliah.Text & "'"
            cmd = New MySqlCommand(str, connectMySQL)
            drd = cmd.ExecuteReader
            drd.Read()
            If drd.HasRows Then
                tnamamatakuliah.Text = drd.Item("nama_mata_kuliah")
                tsks.Text = drd.Item("sks")
                cbsemester.Text = drd.Item("semester")
                cbtahunajaran.Text = drd.Item("tahun_ajaran")
                cbjenjangpendidikan.Text = drd.Item("jenjang_pendidikan")
                cbprogramstudi.Text = drd.Item("program_studi")
                tkodedosen.Text = drd.Item("dosen_pengajar")
                MsgBox("Kode Mata Kuliah telah terdaftar")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub baca_data_matakuliah()
        Dim query As String
        query = "SELECT * FROM data_mata_kuliah"
        Try
            myadp = New MySqlDataAdapter(query, connectMySQL)
            dt.Clear()
            myadp.Fill(dt)
            dgvmatakuliah.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub fmtkuliah_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        openConnectionsMySQL()
        If connectMySQL.State = ConnectionState.Closed Then
            Try
                connectMySQL.Open()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        baca_data_matakuliah()
        cbsemester.SelectedIndex = 0
        cbtahunajaran.SelectedIndex = 0
        cbjenjangpendidikan.SelectedIndex = 0
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

    Private Sub btkeluar_Click(sender As System.Object, e As System.EventArgs)
        Close()
    End Sub

    Private Sub tkodematakuliah_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tkodematakuliah.KeyPress
        If (e.KeyChar = Chr(13)) Then
            cari_data_matakuliah()
        End If
    End Sub

    Private Sub tnamamatakuliah_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tnamamatakuliah.KeyPress
        If (e.KeyChar = Chr(13)) Then
            tsks.Focus()
        End If
    End Sub

    Private Sub tsks_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tsks.KeyPress
        If (e.KeyChar = Chr(13)) Then
            cbsemester.Focus()
        End If
    End Sub

    Private Sub btsimpan_Click(sender As System.Object, e As System.EventArgs) Handles btsimpan.Click
        Dim mycmd As New MySqlCommand("INSERT INTO data_mata_kuliah (kode_mk,nama_mata_kuliah,sks,semester,tahun_ajaran,jenjang_pendidikan,program_studi,dosen_pengajar) " _
                                    + "VALUES ('" & tkodematakuliah.Text & "','" & tnamamatakuliah.Text & "','" & tsks.Text & "','" & cbsemester.Text & "','" & cbtahunajaran.Text & "','" & cbjenjangpendidikan.Text & "','" & cbprogramstudi.Text & "','" & tkodedosen.Text & "')", connectMySQL)
        If (tkodematakuliah.Text <> "" And tnamamatakuliah.Text <> "" And tsks.Text <> "" And tkodedosen.Text <> "") Then
            Try
                If mycmd.ExecuteNonQuery() = 1 Then
                    MsgBox("Insert data berhasil")
                    Call baca_data_matakuliah()
                    Exit Sub
                End If
            Catch ex As MySqlException
                MsgBox("Kode matakuliah telah terdaftar")
            End Try
        Else
            MsgBox("Periksa inputan data")
        End If
    End Sub

    Private Sub btkeluar_Click_1(sender As System.Object, e As System.EventArgs) Handles btkeluar.Click
        Close()
    End Sub

    Private Sub btubah_Click(sender As System.Object, e As System.EventArgs) Handles btubah.Click
        openConnectionsMySQL()
        Dim jenis As String

        If tkodematakuliah.Text <> "" Then
            Dim mycmd As New MySqlCommand("UPDATE data_mata_kuliah SET " _
                                          + " nama_mata_kuliah='" & tnamamatakuliah.Text & "',sks='" & tsks.Text & "',semester='" & cbsemester.Text & "',tahun_ajaran='" & cbtahunajaran.Text & "',jenjang_pendidikan='" & cbjenjangpendidikan.Text & "',program_studi='" & cbprogramstudi.Text & "',dosen_pengajar='" & tkodedosen.Text & "'" _
                                          + " WHERE kode_mk='" & tkodematakuliah.Text & "'", connectMySQL)
            Try
                If mycmd.ExecuteNonQuery() = 1 Then
                    MsgBox("Data telah diubah")
                    Call baca_data_matakuliah()
                End If
            Catch ex As MySqlException
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Masukkan Kode Mata Kuliah")
        End If
    End Sub

    Private Sub bthapus_Click(sender As System.Object, e As System.EventArgs) Handles bthapus.Click
        openConnectionsMySQL()
        If tkodematakuliah.Text <> "" Then
            Dim mycmd As New MySqlCommand("DELETE FROM data_mata_kuliah WHERE kode_mk='" & tkodematakuliah.Text & "'", connectMySQL)
            Try
                If mycmd.ExecuteNonQuery() = 1 Then
                    MsgBox("Hapus data berhasil")
                    Call baca_data_matakuliah()
                End If
            Catch ex As MySqlException
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Masukkan Kode Mata Kuliah")
        End If
    End Sub
End Class