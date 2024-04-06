Public Class Country
    Public Property CountryID As String
    Public Property CountryName As String
    Public Property CountryPopulation As Integer
    Public ReadOnly Property CountryDAO As CountryDAO

    Public Sub New(id As String)
        Me.CountryID = id
        Me.CountryDAO = New CountryDAO
    End Sub
    Public Sub New(id As String, name As String, population As Integer)
        Me.CountryID = id
        Me.CountryName = name
        Me.CountryPopulation = population
        Me.CountryDAO = New CountryDAO
    End Sub

    Public Sub ReadAllCountries()
        Me.CountryDAO.ReadAll()
    End Sub

    Public Function ReadCountry()
        Me.CountryDAO.Read(Me)
        Return Me
    End Function

    Public Function InsertCountry()
        Return Me.CountryDAO.Insert(Me)
    End Function

    Public Function UpdateCountry()
        Return Me.CountryDAO.Update(Me)
    End Function

    Public Function DeleteCountry()
        Return Me.CountryDAO.Delete(Me)
    End Function



End Class
