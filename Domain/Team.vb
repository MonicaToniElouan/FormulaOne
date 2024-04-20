Public Class Team
    Public Property TeamID As Integer
    Public Property TeamName As String
    Public Property TeamCountry As Country
    Public Property CreationDate As Date
    Public Property drivers As Collection
    Public ReadOnly Property TeamDAO As TeamDAO

    Public Sub New()
        Me.TeamDAO = New TeamDAO
    End Sub
    Public Sub New(id As Integer)
        Me.TeamID = id
        Me.TeamDAO = New TeamDAO
    End Sub

    Public Sub New(name As String, country As Country, creationDate As Date)
        Me.TeamName = name
        Me.TeamCountry = country
        Me.CreationDate = creationDate
        Me.TeamDAO = New TeamDAO
    End Sub

    Public Sub New(id As Integer, name As String, country As Country, creationDate As Date)
        Me.TeamID = id
        Me.TeamName = name
        Me.TeamCountry = country
        Me.CreationDate = creationDate
        Me.drivers = New Collection
        Me.TeamDAO = New TeamDAO
    End Sub

    Public Sub ReadAllTeams()
        Me.TeamDAO.ReadAll()
    End Sub

    Public Function ReadTeam()
        Me.TeamDAO.Read(Me)
        Return Me
    End Function

    Public Sub PickRandomTeams(amount As Integer)
        Me.TeamDAO.PickRandom(amount)
    End Sub
    Public Function InsertTeam()
        Return Me.TeamDAO.Insert(Me)
    End Function

    Public Function UpdateTeam()
        Return Me.TeamDAO.Update(Me)
    End Function

    Public Function DeleteTeam()
        Return Me.TeamDAO.Delete(Me)
    End Function

End Class
