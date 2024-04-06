
Public Class CountryDAO
    Public Property Countries As Collection

    Public Sub New()
        Me.Countries = New Collection
    End Sub

    Public Sub Read(ByRef c As Country)
        Dim col As Collection
        Dim aux As Collection
        col = DBBroker.GetBroker().Read("SELECT * FROM Countries WHERE CountryID='" & c.CountryID & "';")
        For Each aux In col
            c.CountryName = aux(2).ToString
            c.CountryPopulation = Integer.Parse(aux(3).ToString)
        Next
    End Sub

    Public Function Insert(c As Country) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO Countries VALUES('" & c.CountryID & "', '" & c.CountryName & "', " & c.CountryPopulation & ");")
    End Function
End Class
