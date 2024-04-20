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
            If result = DialogResult.OK Then
                PickRandom(num_gps, num_teams, num_teams * 2)
            End If
        End If

    End Sub

    Private Sub PickRandom(gps As Integer, teams As Integer, drivers As Integer)
        Dim g As GP = New GP()
        Dim t As Team = New Team()
        Dim d As Driver = New Driver()
        g.PickRandomGPs(gps)
        t.PickRandomTeams(teams)
        d.PickRandomDrivers(drivers)
        For i As Integer = 1 To t.TeamDAO.Teams.Count Step 2
            t.TeamDAO.Teams(i).drivers.Add(d.DriverDAO.Drivers(i))
            t.TeamDAO.Teams(i).drivers.Add(d.DriverDAO.Drivers(i + 1))
        Next
        Me.season = New Season(g.GPDAO.GPs, t.TeamDAO.Teams, d.DriverDAO.Drivers)

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