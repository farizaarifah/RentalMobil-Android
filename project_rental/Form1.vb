Imports MySql.Data.MySqlClient

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim form2_daftar As New Form2_daftar
        form2_daftar.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim form3 As New Form3
        form3.Show()
    End Sub
End Class
