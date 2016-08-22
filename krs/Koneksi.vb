Imports System.Data.Odbc
Imports MySql.Data.MySqlClient
Module Koneksi
    Public connectodbc As OdbcConnection
    Public connectMySQL As MySqlConnection
    Sub openConnectionsODBC()
        Try
            connectodbc = New OdbcConnection("DSN=dsnkrs;MultipleActiveResultSets=True")
            If connectodbc.State = ConnectionState.Closed Then
                connectodbc.Open()
                'MsgBox("Koneksi Berhasil")
            End If
        Catch ex As Exception
            MsgBox("Koneksi ke datasource bermasalah!")
        End Try
    End Sub

    Sub openConnectionsMySQL()
        Try
            connectMySQL = New MySqlConnection("Server=localhost;" _
                                               + "user id=root;" _
                                               + "password=;" _
                                               + "database=krs")
            If connectMySQL.State = ConnectionState.Closed Then
                connectMySQL.Open()
                'MsgBox("Koneksi Berhasil")
            End If
        Catch ex As Exception
            MsgBox("Koneksi ke database bermasalah!")
        End Try
    End Sub

    Sub closeConnection()
        connectodbc.Close()
        connectMySQL.Clone()
    End Sub
End Module
