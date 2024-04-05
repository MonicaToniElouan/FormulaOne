Public Class Country
    Public Property CountyID As String
    Public Property CountryName As String
    Public Property CountryPopulation As Integer
    Public ReadOnly Property CountryDAO As CountryDAO

    Public Sub New(id As String, name As String, population As Integer)
        Me.CountyID = id
        Me.CountryName = name
        Me.CountryPopulation = population
        Me.CountryDAO = New CountryDAO
    End Sub

End Class
