Public Class FormCountries
    Property countries As Collection
    Public Sub New(c As Collection)
        Me.countries = c

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub btnInsertC_Click(sender As Object, e As EventArgs) Handles btnInsertC.Click

    End Sub

    Private Sub txtName_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            For Each aux In Me.countries
                lstCountries.Items.Add(aux.CountryName)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
End Class