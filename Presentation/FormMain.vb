Imports System.Linq.Expressions

Public Class FormMain
    Property countries As Collection = New Collection
    Property teams As Collection = New Collection
    Property drivers As Collection = New Collection
    Property gps As Collection = New Collection

    Private Sub readCountries()
        Dim c As Country = New Country
        c.ReadAllCountries()
        Me.countries = c.CountryDAO.Countries
    End Sub

    Private Sub readDrivers()
        Dim d As Driver = New Driver
        d.ReadAllDrivers()
        Me.drivers = d.DriverDAO.Drivers
    End Sub

    Private Sub readTeams()
        Dim t As Team = New Team
        t.ReadAllTeams()
        Me.teams = t.TeamDAO.Teams
    End Sub

    Private Sub readGPs()
        Dim g As GP = New GP
        g.ReadAllGPs()
        Me.gps = g.GPDAO.GPs
    End Sub
    Private Sub btnCountries_Click(sender As Object, e As EventArgs) Handles btnCountries.Click
        readCountries()
        Dim form_c As FormCountries = New FormCountries(Me.countries)
        form_c.ShowDialog()
    End Sub

    Private Sub btnTeams_Click(sender As Object, e As EventArgs) Handles btnTeams.Click
        readTeams()
        readCountries()
        Dim form_t As FormTeams = New FormTeams(Me.teams, Me.countries)
        form_t.ShowDialog()
    End Sub

    Private Sub btnDrivers_Click(sender As Object, e As EventArgs) Handles btnDrivers.Click
        readDrivers()
        readCountries()
        Dim form_d As FormDrivers = New FormDrivers(Me.drivers, Me.countries)
        form_d.ShowDialog()
    End Sub

    Private Sub btnGPs_Click(sender As Object, e As EventArgs) Handles btnGPs.Click
        readGPs()
        readCountries()
        Dim form_g As FormGPs = New FormGPs(Me.gps, Me.countries)
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

    Private Sub btnGenSeason_Click(sender As Object, e As EventArgs) Handles btnGenSeason.Click
        Dim form_s As FormSeason = New FormSeason()
        form_s.ShowDialog()
    End Sub
End Class
