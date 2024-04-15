Public Class FormGPs
    Property gps As Collection

    Public Sub New(g As Collection)
        Me.gps = g
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub FormGPs_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class