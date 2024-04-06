Imports Google.Protobuf.Compiler

Public Class TeamDAO
    Public ReadOnly Property Teams As Collection

    Public Sub New()
        Me.Teams = New Collection
    End Sub

    Public Sub ReadAll()
        Dim t As Team
        Dim c As Country
        Dim col, aux As Collection
        col = DBBroker.GetBroker().Read("SELECT * FROM Teams ORDER BY TeamID")
        For Each aux In col
            c = New Country(aux(3).ToString)
            t = New Team(aux(1).ToString, aux(2).ToString, c.ReadCountry(), Date.Parse(aux(4).ToString))
            Me.Teams.Add(t)
        Next
    End Sub

    Public Sub Read(ByRef t As Team)
        Dim col As Collection : Dim aux As Collection
        Dim c As Country
        col = DBBroker.GetBroker.Read("SELECT * FROM Teams WHERE TeamID='" & t.TeamID & "';")
        For Each aux In col
            c = New Country(aux(3).ToString)
            t.TeamName = aux(1).ToString
            t.TeamCountry = c.ReadCountry()
            t.CreationDate = Date.Parse(aux(4).ToString)
        Next
    End Sub

    Public Function Insert(ByVal t As Team) As Integer
        'Return DBBroker.GetBroker.Change("INSERT INTO Persons VALUES ('" & p.PersonID & "', '" & p.PersonName & "');")
    End Function

    Public Function Update(ByVal t As Team) As Integer
        'Return DBBroker.GetBroker.Change("UPDATE Persons SET PersonName='" & p.PersonName & "' WHERE PersonID='" & p.PersonID & "';")
    End Function

    Public Function Delete(ByVal t As Team) As Integer
        'Return DBBroker.GetBroker.Change("DELETE FROM Persons WHERE PersonID='" & p.PersonID & "';")
    End Function
End Class
