Public Class SeasonDAO
    Public Property Contracts As Collection
    Public Property Calendars As Collection
    Public Property Races As Collection

    Public Sub New()
        Me.Contracts = New Collection
        Me.Calendars = New Collection
        Me.Races = New Collection
    End Sub

    Public Sub ReadAllContracts()

    End Sub

    Public Function InsertContract(ByVal c As Contract)
        Return DBBroker.GetBroker.Change("INSERT INTO Contracts VALUES (" & c.team.TeamID & ", " & c.season & ", " & c.driver1.DriverID & ", " & c.driver2.DriverID & ");")
    End Function
End Class
