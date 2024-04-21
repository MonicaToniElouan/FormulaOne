Public Class FormSeasonInformation
    Private Property season As Season

    Public Sub New(s As Season)
        season = s
        InitializeComponent()
    End Sub

    Private Sub SeasonInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstGPSeason.DisplayMember = "ToString"
        lstTeamsSeason.DisplayMember = "TeamName"
        lstDriversSeason.DisplayMember = "ToString"

        For Each aux In Me.season.gps
            lstGPSeason.Items.Add(aux)
        Next

        For Each aux In Me.season.teams
            lstTeamsSeason.Items.Add(aux)
        Next

        For Each aux In Me.season.drivers
            lstDriversSeason.Items.Add(aux)
        Next
    End Sub
End Class