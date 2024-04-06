Public Class FormMain
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Dim c As Country = New Country
        Dim t As Team = New Team
        Try
            c.ReadAllCountries()
            t.ReadAllTeams()
            lblResultConnection.Text = "Connection with database SUCCSESSFUL"
            lblResultConnection.ForeColor = Color.Green
            ' Set the new location of the label
            lblResultConnection.Location = New Point((pnlConn.Width - lblResultConnection.Width) / 2, lblResultConnection.Location.Y)
            lblResultConnection.Visible = True
        Catch ex As Exception
            lblResultConnection.Text = ex.Message
            lblResultConnection.ForeColor = Color.Red
            ' Set the new location of the label
            lblResultConnection.Location = New Point((pnlConn.Width - lblResultConnection.Width) / 2, lblResultConnection.Location.Y)
            lblResultConnection.Visible = True
        End Try
    End Sub

End Class
