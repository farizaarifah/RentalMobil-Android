Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Form2_daftar

    Dim dbConnection As New MySqlConnection
    Dim connectionString As String
    Dim sqlCmd As MySqlCommand
    Dim sqlReader As MySqlDataReader

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim toha As Integer
        Dim tb3 As Date
        Dim tb4 As Date

        tb3 = Date.Parse(TextBox4.Text)
        tb4 = Date.Parse(TextBox5.Text)
        toha = DateDiff("d", tb3, tb4)
        Label13.Text = toha

        MsgBox("Silakan lanjutkan ke Pembayaran!")

        Dim hasil As Integer
        hasil = toha * 300000
        Label14.Text = ("Rp " & hasil)

        Dim virtual As New Random
        Dim rek As Integer = virtual.Next(10000000)
        Label12.Text = rek


    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click


        connectionString = "Server=localhost;Database=db_rental;Uid=root;Pwd=;"

        Try
            dbConnection = New MySqlConnection(connectionString)
            dbConnection.Open()

            Dim toha As Integer = Label13.Text
            Dim R As New Random
            Dim code As Integer = R.Next(10000)
            Dim query As String = "insert into tb_penyewa (nama, alamat, no_tlp, tgl_mulai, tgl_selesai, total_hari, code) values ('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text &
                                   "', '" & TextBox4.Text & "', '" & TextBox5.Text & "', '" & toha & "', '" & code & "'  )"


            sqlCmd = New MySqlCommand(query, dbConnection)
            sqlReader = sqlCmd.ExecuteReader

            dbConnection.Close()

            MsgBox("ingat baik-baik id anda untuk menyelesaikan transaksi. id = " & code & vbCrLf &
                    vbCrLf & "Silakan tunggu konfirmasi ke nomor telepon yang anda masukkan :) ")
        Catch ex As Exception
            MsgBox("Terjadi kesalahan")
        End Try

        Me.Close()
    End Sub
End Class