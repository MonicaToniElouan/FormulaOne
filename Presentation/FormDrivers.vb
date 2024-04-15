Public Class FormDrivers
    Property drivers As Collection

    Public Sub New(d As Collection)
        Me.drivers = d
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub lblCountries_Click(sender As Object, e As EventArgs) Handles lblDrivers.Click

    End Sub

    Private Sub FormDrivers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            For Each aux In Me.drivers
                lstDrivers.Items.Add(aux.DriverName & " " & aux.DriverSurname)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class