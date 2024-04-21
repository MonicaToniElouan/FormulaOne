Public Class FormTeams
    Property teams As Collection
    Property countries As Collection
    Public Sub New(t As Collection, c As Collection)
        Me.teams = t
        Me.countries = c
        InitializeComponent()
    End Sub
    Private Sub FormTeams_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIDT.ReadOnly = True
        cmbT.Items.Add("")
        Try
            For Each aux In Me.teams
                lstTeams.Items.Add(aux)
            Next

            For Each aux In Me.countries
                cmbT.Items.Add(aux.CountryID)
            Next

            lstTeams.ValueMember = "TeamName"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnInsertD_Click(sender As Object, e As EventArgs) Handles btnInsertD.Click
        If checkIfCorrectData(txtNameT.Text, cmbT.Text, dtpT.Text) Then
            Try
                Dim t As Team = New Team(txtNameT.Text, New Country(cmbT.Text), Date.Parse(dtpT.Text))
                t.InsertTeam()
                Me.teams.Add(t)
                lstTeams.Items.Add(t)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnClearD_Click(sender As Object, e As EventArgs) Handles btnClearD.Click
        txtIDT.Text = ""
        txtNameT.Text = ""
        cmbT.Text = ""
        dtpT.Text = ""
    End Sub

    Private Sub lstTeams_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTeams.SelectedIndexChanged
        Dim t As Team = lstTeams.SelectedItem
        If Not t Is Nothing Then
            txtIDT.Text = t.TeamID
            txtNameT.Text = t.TeamName
            cmbT.Text = t.TeamCountry.CountryID
            dtpT.Text = t.CreationDate
        End If
    End Sub

    Private Sub btnDeleteD_Click(sender As Object, e As EventArgs) Handles btnDeleteD.Click
        Dim counter As Integer = 0

        If txtIDT Is Nothing Then
            MessageBox.Show("Select a team to delete")
        Else
            Try
                Dim t As Team = New Team(txtIDT.Text)
                t.DeleteTeam()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub deleteTeam(t As Team)
        Dim counter As Integer = 1
        For Each aux In Me.teams
            If aux.TeamID = t.TeamID Then
                Me.teams.Remove(counter)
                lstTeams.Items.Remove(counter)
            End If
            counter = counter + 1
        Next
    End Sub

    Private Sub updateTeam(t As Team)
        Dim counter As Integer = 0
        For Each aux In Me.teams
            If aux.TeamID = t.TeamID Then
                Me.teams.Remove(counter + 1)
                Me.teams.Add(t)
                lstTeams.Items(counter).TeamName = t.TeamName
                lstTeams.Items(counter).TeamCountry = t.TeamCountry
                lstTeams.Items(counter).CreationDate = t.CreationDate
            End If
            counter = counter + 1
        Next
    End Sub

    Private Function checkIfCorrectData(name As String, country As String, creationDate As String) As Boolean
        If name = "" Or country = "" Or creationDate = "" Then
            MessageBox.Show("Name, country and creation data fields cannot be empty. Introduce some values")
            Return False
        End If
        Return True
    End Function

    Private Function checkID(id As String) As Boolean
        If id = "" Then
            MessageBox.Show("Select a team")
            Return False
        End If
        Return True
    End Function

    Private Sub btnUpdateD_Click(sender As Object, e As EventArgs) Handles btnUpdateD.Click
        Dim t As Team
        If checkIfCorrectData(txtNameT.Text, cmbT.Text, txtCreationDateT.Text) And checkID(txtIDT.Text) Then
            Try
                t = New Team(txtIDT.Text, txtNameT.Text, New Country(cmbT.Text), Date.Parse(txtCreationDateT.Text))
                t.UpdateTeam()
                updateTeam(t)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
End Class