Public Class txtName
    Property countries As Country
    Public Sub New(c As Country)
        Me.countries = c

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub lblID_Click(sender As Object, e As EventArgs) Handles lblIDC.Click

    End Sub

    Private Sub btnUpdateC_Click(sender As Object, e As EventArgs) Handles btnUpdateC.Click

    End Sub

    Private Sub lblSelectOptionC_Click(sender As Object, e As EventArgs) Handles lblSelectOptionC.Click

    End Sub

    Private Sub lstCountries_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCountries.SelectedIndexChanged

    End Sub

    Private Sub txtName_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblCountries_Click(sender As Object, e As EventArgs) Handles lblCountries.Click

    End Sub

    Private Sub txtName_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class