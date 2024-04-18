Public Class DriverDAO
    Public ReadOnly Property Drivers As Collection

    Public Sub New()
        Me.Drivers = New Collection
    End Sub

    Public Sub ReadAll()
        Dim d As Driver
        Dim c As Country
        Dim col, aux As Collection
        col = DBBroker.GetBroker().Read("SELECT * FROM Drivers ORDER BY DriverID")
        For Each aux In col
            c = New Country(aux(4).ToString)
            d = New Driver(aux(1).ToString, aux(2).ToString, aux(3).ToString, c.ReadCountry())
            Me.Drivers.Add(d)
        Next
    End Sub

    Public Sub Read(ByRef d As Driver)
        Dim col As Collection : Dim aux As Collection
        Dim c As Country
        col = DBBroker.GetBroker.Read("SELECT * FROM Drivers WHERE DriverID='" & d.DriverID & "';")
        For Each aux In col
            c = New Country(aux(4).ToString)
            d.DriverName = aux(2).ToString
            d.DriverSurname = aux(3).ToString
            d.DriverCountry = c.ReadCountry()
        Next
    End Sub

    Public Function Insert(ByVal d As Driver) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO Drivers(DriverName, DriverSurname, DriverCountry) VALUES ('" & d.DriverName & "', '" & d.DriverSurname & "', '" & d.DriverCountry.CountryID & "');")
    End Function

    Public Function Update(ByVal d As Driver) As Integer
        Return DBBroker.GetBroker.Change("UPDATE Drivers SET DriverName='" & d.DriverName & "', DriverSurname='" & d.DriverSurname & "', DriverCountry='" & d.DriverCountry.CountryID & "' WHERE DriverID='" & d.DriverID & "';")
    End Function

    Public Function Delete(ByVal d As Driver) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM Drivers WHERE DriverID=" & d.DriverID & ";")
    End Function
End Class
