Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim c As Country = New Country("ESP", "España", 47000000)
        Dim cdao As CountryDAO = New CountryDAO()
        Try
            cdao.Insert(c)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try


    End Sub
End Class
