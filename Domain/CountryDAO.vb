Public Class CountryDAO
    Public ReadOnly Property Countries As Collection

    Public Sub New()
        Me.Countries = New Collection
    End Sub

    Public Function Read(countryID As Integer)
        Dim col As Collection
        Dim aux As Collection
        col = DBBroker.GetBroker().Read("SELECT * FROM Countries WHERE CountryID='" & countryID & "';")
        For Each aux In col

        Next


    End Function
End Class
