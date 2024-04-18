Public Class Driver
    Public Property DriverID As Integer
    Public Property DriverName As String
    Public Property DriverSurname As String
    Public Property DriverCountry As Country
    Public ReadOnly Property DriverDAO As DriverDAO

    Public Sub New()
        Me.DriverDAO = New DriverDAO
    End Sub

    Public Sub New(id As Integer)
        Me.DriverID = id
        Me.DriverDAO = New DriverDAO
    End Sub

    Public Sub New(name As String, surname As String, country As Country)
        Me.DriverName = name
        Me.DriverSurname = surname
        Me.DriverCountry = country
        Me.DriverDAO = New DriverDAO
    End Sub

    Public Sub New(id As Integer, name As String, surname As String, country As Country)
        Me.DriverID = id
        Me.DriverName = name
        Me.DriverSurname = surname
        Me.DriverCountry = country
        Me.DriverDAO = New DriverDAO
    End Sub

    Public Sub ReadAllDrivers()
        Me.DriverDAO.ReadAll()
    End Sub

    Public Function ReadDriver()
        Me.DriverDAO.Read(Me)
        Return Me
    End Function

    Public Function InsertDriver()
        Return Me.DriverDAO.Insert(Me)
    End Function

    Public Function UpdateDriver()
        Return Me.DriverDAO.Update(Me)
    End Function

    Public Function DeleteDriver()
        Return Me.DriverDAO.Delete(Me)
    End Function

    Public Overrides Function ToString() As String
        Return Me.DriverName & " " & Me.DriverSurname
    End Function
End Class
