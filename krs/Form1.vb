﻿Imports MySql.Data.MySqlClient
Public Class flogin

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles btnlogin.Click
        Dim query, user, pass As String
        user = tusername.Text
        pass = tpassword.Text
        query = "SELECT COUNT(id_user) FROM data_user WHERE username='" & user & "' AND password='" & pass & "'"
        Dim mycmd As New MySqlCommand(query, connectMySQL)
        Dim jumlah As Integer
        jumlah = mycmd.ExecuteScalar
        If jumlah = 1 Then
            fmenuutama.Show()
            Me.Hide()
        Else
            MsgBox("Username atau password yang dimasukkan salah")
            tusername.Focus()
            tusername.SelectAll()
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btncancel.Click
        Application.Exit()
    End Sub

    Private Sub flogin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        openConnectionsMySQL()
        If connectMySQL.State = ConnectionState.Closed Then
            Try
                connectMySQL.Open()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        tusername.Focus()
    End Sub

    Private Sub tusername_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tusername.KeyPress
        If (e.KeyChar = Chr(13)) Then
            tpassword.Focus()
        End If
    End Sub

    Private Sub tpassword_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tpassword.KeyPress
        If (e.KeyChar = Chr(13)) Then
            btnlogin.Focus()
        End If
    End Sub

End Class
