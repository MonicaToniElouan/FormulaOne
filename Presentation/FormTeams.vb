Public Class FormTeams
    Property teams As Collection
    Property countries As Collection
    Public Sub New(t As Collection, c As Collection)
        Me.teams = t
        Me.countries = c
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub FormTeams_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIDT.ReadOnly = True
        Try
            lstTeams.DataSource = Me.teams
            For Each aux In Me.countries
                cmbT.Items.Add(aux.CountryID)
            Next
            lstTeams.ValueMember = "TeamName"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnInsertD_Click(sender As Object, e As EventArgs) Handles btnInsertD.Click
        Try
            If txtNameT.Text Is Nothing Or cmbT.Text Is Nothing Or dtpT.Text Is Nothing Then
                MessageBox.Show("Name, country and creation date fields cannot be empty")
            Else
                Dim t As Team = New Team(txtNameT.Text, New Country(cmbT.Text), Date.Parse(dtpT.Text))
                t.InsertTeam()
                Me.teams.Add(t)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClearD_Click(sender As Object, e As EventArgs) Handles btnClearD.Click
        txtIDT.Text = ""
        txtNameT.Text = ""
        cmbT.Text = ""
        dtpT.Text = ""
    End Sub

    Private Sub lstTeams_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTeams.SelectedIndexChanged
        Dim t As Team = lstTeams.SelectedItem
        txtIDT.Text = t.TeamID
        txtNameT.Text = t.TeamName
        cmbT.Text = t.TeamCountry.CountryID
        dtpT.Text = t.CreationDate

    End Sub

    Private Sub btnDeleteD_Click(sender As Object, e As EventArgs) Handles btnDeleteD.Click
        Dim counter As Integer = 0
        Try
            If txtIDT Is Nothing Then
                MessageBox.Show("Select a team to delete")
            Else
                Dim t As Team = New Team(txtIDT.Text)
                t.DeleteTeam()
                For Each aux In Me.teams
                    If aux.TeamID = txtIDT.Text Then
                        Me.teams.Remove(counter)
                        'lstTeams.Items.Remove()
                        Exit For
                    End If
                    counter = counter + 1
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class