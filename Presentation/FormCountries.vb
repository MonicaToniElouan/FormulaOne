Public Class FormCountries
    Property countries As Collection
    Public Sub New(c As Collection)
        Me.countries = c

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub btnInsertC_Click(sender As Object, e As EventArgs) Handles btnInsertC.Click
        Try
            If txtNameC.Text = "" Or txtPopulationC.Text = "" Then
                Dim c As Country = New Country(UCase(Mid(txtNameC.Text, 1, 3)))
                MsgBox(UCase(Mid(txtNameC.Text, 1, 3)))

                If c.ReadCountry().CountryPopulation Is Nothing Then
                    MsgBox("HOLA")
                End If
            Else
                MessageBox.Show("Name and population cannot be empty. Introduce some value")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtName_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIDC.ReadOnly = True
        Try
            For Each aux In Me.countries
                lstCountries.Items.Add(aux.CountryName)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
End Class