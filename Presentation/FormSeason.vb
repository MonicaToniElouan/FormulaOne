Imports System.Threading

Public Class FormSeason
    Property season As Season

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnGenInfo_Click(sender As Object, e As EventArgs) Handles btnGenInfo.Click
        Dim num_teams As Integer
        Dim num_gps As Integer
        num_gps = establishNumberGPs()
        If checkYear(cmbYear.Text) And establishNumberTeams(nudMinTeams.Value, nudMaxTeams.Value, num_teams) Then
            Dim result As DialogResult = MessageBox.Show("The generated information is: " & vbCrLf & "Season Year: " &
                cmbYear.Text & vbCrLf & "Number of Teams: " & num_teams & vbCrLf & "Number of Grand Prix: " & num_gps,
                                                         "Create Season?", MessageBoxButtons.OKCancel)
            If result = DialogResult.OK And PickRandom(num_gps, num_teams, num_teams * 2) Then
                Dim form_info As FormSeasonInformation = New FormSeasonInformation(Me.season)
                form_info.Show()
            End If
        End If

    End Sub

    Private Function PickRandom(gps As Integer, teams As Integer, drivers As Integer) As Boolean
        Dim g As GP = New GP()
        Dim t As Team = New Team()
        Dim d As Driver = New Driver()
        g.PickRandomGPs(gps)
        t.PickRandomTeams(teams)
        d.PickRandomDrivers(drivers)
        If CheckIfEnoughData(d.DriverDAO.Drivers, t.TeamDAO.Teams, g.GPDAO.GPs, gps, teams, drivers) Then
            Me.season = New Season(g.GPDAO.GPs, t.TeamDAO.Teams, d.DriverDAO.Drivers, cmbYear.Text)
            GenerateContracts()
        Else
            Return False
        End If


        Return True
    End Function

    Private Function CheckIfEnoughData(drivers_read As Collection, teams_read As Collection, gps_read As Collection,
                                       num_gps As Integer, num_teams As Integer, num_drivers As Integer) As Boolean
        If drivers_read.Count < num_drivers Then
            MessageBox.Show("There are not enough drivers in the database. There are " & drivers_read.Count & " and " & num_drivers & " are needed.")
            Return False
        ElseIf teams_read.Count < num_teams Then
            MessageBox.Show("There are not enough teams in the database. There are " & teams_read.Count & " and " & num_teams & " are needed.")
            Return False
        ElseIf gps_read.Count < num_gps Then
            MessageBox.Show("There are not enough grand prixes in the database. There are " & gps_read.Count & " and " & num_gps & " are needed.")
            Return False
        End If
        Return True
    End Function

    Private Sub GenerateContracts()
        Dim c As Contract
        Try
            For i As Integer = 0 To Me.season.teams.Count - 1
                c = New Contract(Me.season.teams(i + 1), Me.season.drivers(i * 2 + 1), Me.season.drivers(i * 2 + 2), Me.season.year)
                c.InsertContract()
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub GenerateCalendar()
        Dim 
    End Sub


    Private Function checkYear(y As String) As Boolean
        If y = "" Then
            MessageBox.Show("Introduce a year for the season")
            Return False
        End If
        Return True
    End Function

    Private Function establishNumberTeams(min As Integer, max As Integer, ByRef num_teams As Integer) As Boolean
        Dim rand_generator As System.Random = New System.Random()
        If min > max Then
            MessageBox.Show("The min value cannot be greater than the max value")
            Return False
        End If
        If min < 5 Or max < 5 Then
            num_teams = rand_generator.Next(5, 11)
        Else
            num_teams = rand_generator.Next(min, max + 1)
        End If
        Return True
    End Function

    Private Function establishNumberGPs() As Integer
        Dim rand_generator As System.Random = New System.Random()
        If nudGPs.Value < 10 Then
            Return rand_generator.Next(10, 21)
        Else
            Return nudGPs.Value
        End If
    End Function
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        nudMaxTeams.Value = 4
        nudMinTeams.Value = 4
        nudGPs.Value = 9
        cmbYear.Text = ""
    End Sub

    Private Sub FormSeason_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbYear.Items.Add("")
        For i As Integer = 1970 To 2024
            cmbYear.Items.Add(i)
        Next

    End Sub
End Class