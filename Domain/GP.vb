Public Class GP
    Public Property GPID As Integer
    Public Property GPName As String
    Public Property GPCountry As Country
    Public ReadOnly Property gpDAO As GPDAO

    Public Sub New()
        Me.gpDAO = New GPDAO
    End Sub

    Public Sub New(id As Integer)
        Me.GPID = id
        Me.gpDAO = New GPDAO
    End Sub

    Public Sub New(id As Integer, name As String, country As Country)
        Me.GPID = id
        Me.GPName = name
        Me.GPCountry = country
        Me.gpDAO = New GPDAO
    End Sub



End Class
