Public Class Contract
    Public Property team As Team

    Public Property driver1 As Driver

    Public Property driver2 As Driver

    Public Property season As Integer

    Public Property SeasonDAO As SeasonDAO

    Public Sub New(t As Team, d1 As Driver, d2 As Driver, s As Integer)
        Me.team = t
        Me.driver1 = d1
        Me.driver2 = d2
        Me.season = s
        Me.SeasonDAO = New SeasonDAO()
    End Sub


    Public Function InsertContract()
        Return Me.SeasonDAO.InsertContract(Me)
    End Function
End Class
