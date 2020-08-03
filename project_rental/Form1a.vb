Imports MySql.Data.MySqlClient

Public Class Form1

    Dim dbConnection As MySqlConnection
    Dim connectionString As String
    Dim sqlCmd As MySqlCommand
    Dim sqlReader As MySqlDataReader

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        connectionString = "Server=localhost;Database=db_mahasiswa;Uid=root;Pwd=;"

        Try
            dbConnection = New MySqlConnection(connectionString)
            dbConnection.Open()
            MsgBox("koneksi ke database berhasil :)")

            

        Catch ex As Exception
            MsgBox("terjadi kesalahan dalam koneksi ke database")
        End Try


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        connectionString = "Server=localhost;Database=db_mahasiswa;Uid=root;Pwd=;"
        Try
            dbConnection = New MySqlConnection(connectionString)
            dbConnection.Open()
            Dim query As String = "insert into db_mahasiswa (nim, nama, jurusan, prodi, alamat, email) values ('" & TextBox1.Text & "', '" & TextBox2.Text &
                                   "', '" & TextBox3.Text & "', '" & TextBox4.Text & "', '" & TextBox5.Text & "', '" & TextBox6.Text & "')"

            sqlCmd = New MySqlCommand(query, dbConnection)

            sqlReader = sqlCmd.ExecuteReader
            dbConnection.Close()
            MsgBox("simpan berhasil !")
        Catch ex As Exception
            MsgBox("terjadi kesalahan dalam koneksi ke database")
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim form2 As New Form2
        form2.Show()
    End Sub
End Class
