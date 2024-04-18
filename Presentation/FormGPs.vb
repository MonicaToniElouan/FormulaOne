Public Class FormGPs
    Property gps As Collection
    Property countries As Collection
    Public Sub New(g As Collection, c As Collection)
        Me.gps = g
        Me.countries = c
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub FormGPs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIDGP.ReadOnly = True
        Try
            For Each aux In Me.gps
                lstGP.Items.Add(aux.GPName)
            Next
            For Each aux In Me.countries
                cmbG.Items.Add(aux.CountryID)
            Next
        Catch ex As Exception

        End Try
    End Sub
End Class