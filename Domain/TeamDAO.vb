﻿Imports Google.Protobuf.Compiler

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
            t.TeamName = aux(2).ToString
            t.TeamCountry = c.ReadCountry()
            t.CreationDate = Date.Parse(aux(4).ToString)
        Next
    End Sub

    Public Sub PickRandom(ByVal amount As Integer)
        Dim t As Team
        Dim c As Country
        Dim col, aux As Collection
        col = DBBroker.GetBroker().Read("SELECT * FROM Teams ORDER BY RAND() LIMIT " & amount & ";")
        For Each aux In col
            c = New Country(aux(3).ToString)
            t = New Team(aux(1).ToString, aux(2).ToString, c.ReadCountry(), Date.Parse(aux(4).ToString))
            Me.Teams.Add(t)
        Next
    End Sub

    Public Function Insert(ByVal t As Team) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO Teams VALUES (" & t.TeamID & ", '" & t.TeamName & "', '" & t.TeamCountry.CountryID & "', '" & t.CreationDate.ToString("yyyy-MM-dd") & "');")
    End Function

    Public Function Update(ByVal t As Team) As Integer
        Return DBBroker.GetBroker.Change("UPDATE Teams SET TeamName='" & t.TeamName & "', TeamCountry='" & t.TeamCountry.CountryID & "', CreationDate='" & t.CreationDate.ToString("yyyy-MM-dd") & "' WHERE TeamID='" & t.TeamID & "';")
    End Function

    Public Function Delete(ByVal t As Team) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM Teams WHERE TeamID=" & t.TeamID & ";")
    End Function
End Class
