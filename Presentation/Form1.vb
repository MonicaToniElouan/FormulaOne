Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim c As Country = New Country("FRA")
        Dim t As Team = New Team(1, "Mercedes", New Country("ENG"), New Date(2010, 7, 15))


        Try



        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class
