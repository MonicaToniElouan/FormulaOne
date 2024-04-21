Public Class Season
    Public Property teams As Collection
    Public Property gps As Collection
    Public Property drivers As Collection
    Public Property year As Integer
    Public Sub New(g As Collection, t As Collection, d As Collection, y As Integer)
        Me.gps = g
        Me.teams = t
        Me.drivers = d
        Me.year = y
    End Sub

    Public Sub GenerateRaces()
        Dim random_generatos = New System.Random()
        Dim positions As Collection = GeneratePositions()
        Dim current_position As Integer = 0
        For Each aux In Me.drivers
            current_position = random_generatos.Next(1, positions.Count + 1)
        Next
    End Sub

    Public Function GeneratePositions() As Collection
        Dim c As Collection = New Collection()
        For i As Integer = 1 To drivers.Count
            c.Add(i)
        Next
        Return c
    End Function

End Class
