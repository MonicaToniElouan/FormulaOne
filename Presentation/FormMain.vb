Public Class FormMain
    Property countries As Collection = New Collection
    Property teams As Collection = New Collection
    Property drivers As Collection = New Collection
    Property gps As Collection = New Collection

    Private Sub btnCountries_Click(sender As Object, e As EventArgs) Handles btnCountries.Click
        Dim form_c As FormCountries = New FormCountries(Me.countries)
        form_c.ShowDialog()
    End Sub

    Private Sub btnTeams_Click(sender As Object, e As EventArgs) Handles btnTeams.Click
        Dim form_t As FormTeams = New FormTeams()
        form_t.ShowDialog()
    End Sub

    Private Sub btnDrivers_Click(sender As Object, e As EventArgs) Handles btnDrivers.Click
        Dim form_d As FormDrivers = New FormDrivers(Me.drivers)
        form_d.ShowDialog()
    End Sub

    Private Sub btnGPs_Click(sender As Object, e As EventArgs) Handles btnGPs.Click
        Dim form_g As FormGPs = New FormGPs()
        form_g.ShowDialog()
    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim c As Country = New Country
        Dim t As Team = New Team
        Dim d As Driver = New Driver
        Dim g As GP = New GP

        Try
            c.ReadAllCountries()
            t.ReadAllTeams()
            d.ReadAllDrivers()
            g.ReadAllGPs()
            Me.countries = c.CountryDAO.Countries
            Me.teams = t.TeamDAO.Teams
            Me.drivers = d.DriverDAO.Drivers
            Me.gps = g.GPDAO.GPs


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

    Private Sub pnlModifyData_Paint(sender As Object, e As PaintEventArgs)

    End Sub

End Class
