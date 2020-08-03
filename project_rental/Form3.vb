Imports MySql.Data.MySqlClient

Public Class Form3
    Dim dbConnection As New MySqlConnection
    Dim connectionString As String =
        "server=localhost;" &
        "uid=root;" &
        "pwd=;" &
        "database=db_rental;" &
        "Convert Zero Datetime=True"
    Dim sqlCmd As MySqlCommand
    Dim sqlReader As MySqlDataReader
    Dim dataPenyewa As New ArrayList
    Dim kode As Integer

    Sub getAllData()

        Try
            dbConnection = New MySqlConnection(connectionString)
            dataPenyewa.Clear()
            dbConnection.Open()
            Dim query As String = "select * from tb_penyewa"
            sqlCmd = New MySqlCommand(query, dbConnection)
            sqlReader = sqlCmd.ExecuteReader

            While sqlReader.Read
                dataPenyewa.Add(New Penyewa(sqlReader.Item("id"), sqlReader.Item("nama"),
                                                 sqlReader.Item("alamat"), sqlReader.Item("no_tlp"), sqlReader.Item("tgl_mulai"), sqlReader.Item("tgl_selesai"), sqlReader.Item("code")))

                If sqlReader.Item("code") = kode Then
                    Label3.Text = sqlReader.Item("nama")
                    Label4.Text = sqlReader.Item("alamat")
                    Label5.Text = sqlReader.Item("no_tlp")
                    Label6.Text = sqlReader.Item("tgl_mulai")
                    Label7.Text = sqlReader.Item("tgl_selesai")
                End If

            End While
            sqlReader.Close()
            dbConnection.Close()

        Catch ex As Exception

            MsgBox("kesalahan dalam koneksi ke database " & vbCrLf & vbCrLf & vbCrLf & ex.Message, 0, "peringatan!!!")

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        kode = tb1.Text
        getAllData()

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        dbConnection.ConnectionString = connectionString
        dbConnection.Open()

        Dim query As String = "update tb_penyewa set status = '" & ComboBox1.Text & "'WHERE code='" & tb1.Text & "' "

        sqlCmd = New MySqlCommand(query, dbConnection)
        sqlCmd.ExecuteNonQuery()
        dbConnection.Close()

        getAllData()

        MsgBox("Terimakasih telah mempercayai kami!")
        Me.Close()
    End Sub


End Class