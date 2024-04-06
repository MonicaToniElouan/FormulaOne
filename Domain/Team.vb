Public Class Team
    Public Property TeamID As Integer
    Public Property TeamName As String
    Public Property TeamCountry As Country
    Public Property CreationDate As Date
    Public ReadOnly Property TeamDAO As TeamDAO

    Public Sub New(id As Integer)
        Me.TeamID = id
        Me.TeamDAO = New TeamDAO
    End Sub
    Public Sub New(id As Integer, name As String, country As Country, creationDate As Date)
        Me.TeamID = id
        Me.TeamName = name
        Me.TeamCountry = country
        Me.CreationDate = creationDate
        Me.TeamDAO = New TeamDAO
    End Sub

    Public Sub ReadTeam()
        Me.TeamDAO.Read(Me)
    End Sub

End Class
