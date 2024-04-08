Public Class FormMain
    Private Sub btnCountries_Click(sender As Object, e As EventArgs) Handles btnCountries.Click
        Dim form_c As FormCountries = New FormCountries
        form_c.ShowDialog()
    End Sub

    Private Sub btnTeams_Click(sender As Object, e As EventArgs) Handles btnTeams.Click
        Dim form_t As FormTeams = New FormTeams
        form_t.ShowDialog()
    End Sub

    Private Sub btnDrivers_Click(sender As Object, e As EventArgs) Handles btnDrivers.Click
        Dim form_d As FormDrivers = New FormDrivers
        form_d.ShowDialog()
    End Sub

    Private Sub btnGPs_Click(sender As Object, e As EventArgs) Handles btnGPs.Click
        Dim form_g As FormGPs = New FormGPs
        form_g.ShowDialog()
    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim c = New Country
        Dim t = New Team

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
