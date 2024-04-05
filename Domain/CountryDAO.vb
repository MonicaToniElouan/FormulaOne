Public Class CountryDAO
    Public ReadOnly Property Countries As Collection

    Public Sub New()
        Me.Countries = New Collection
    End Sub

    Public Sub Read(countryID As Integer)
        Dim col As Collection
        Dim aux As Collection
        col = DBBroker.GetBroker().Read("SELECT * FROM Countries WHERE CountryID='" & countryID & "';")
        For Each aux In col

        Next
    End Sub

    Public Function Insert(c As Country) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO Countries VALUES('" & c.CountyID & "', '" & c.CountryName & "', " & c.CountryPopulation & ");")
    End Function
End Class
