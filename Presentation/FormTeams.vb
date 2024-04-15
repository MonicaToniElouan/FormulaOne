Public Class FormTeams
    Property teams As Collection

    Public Sub New(t As Collection)
        Me.teams = t
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub FormTeams_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            For Each aux In Me.teams
                lstTeams.Items.Add(aux.TeamName)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class