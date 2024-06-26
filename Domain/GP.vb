﻿Public Class GP
    Public Property GPID As Integer
    Public Property GPName As String
    Public Property GPCountry As Country
    Public ReadOnly Property GPDAO As GPDAO

    Public Sub New()
        Me.gpDAO = New GPDAO
    End Sub

    Public Sub New(id As Integer)
        Me.GPID = id
        Me.gpDAO = New GPDAO
    End Sub

    Public Sub New(name As String, country As Country)
        Me.GPName = name
        Me.GPCountry = country
        Me.GPDAO = New GPDAO
    End Sub

    Public Sub New(id As Integer, name As String, country As Country)
        Me.GPID = id
        Me.GPName = name
        Me.GPCountry = country
        Me.gpDAO = New GPDAO
    End Sub

    Public Sub ReadAllGPs()
        Me.GPDAO.ReadAll()
    End Sub

    Public Function ReadGP()
        Me.GPDAO.Read(Me)
        Return Me
    End Function

    Public Sub PickRandomGPs(amount As Integer)
        Me.GPDAO.PickRandom(amount)
    End Sub

    Public Function InsertGP()
        Return Me.GPDAO.Insert(Me)
    End Function

    Public Function UpdateGP()
        Return Me.GPDAO.Update(Me)
    End Function

    Public Function DeleteGP()
        Return Me.GPDAO.Delete(Me)
    End Function

    Public Overrides Function ToString() As String
        Return Me.GPName & " (" & Me.GPCountry.CountryID & ")"
    End Function

End Class
