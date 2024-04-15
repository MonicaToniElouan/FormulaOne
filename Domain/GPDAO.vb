Public Class GPDAO
    Public ReadOnly Property GPs As Collection

    Public Sub New()
        GPs = New Collection
    End Sub

    Public Sub ReadAll()
        Dim g As GP
        Dim c As Country
        Dim col, aux As Collection
        col = DBBroker.GetBroker().Read("SELECT * FROM GPs ORDER BY GPID")
        For Each aux In col
            c = New Country(aux(3).ToString)
            g = New GP(aux(1).ToString, aux(2).ToString, c.ReadCountry())
            Me.GPs.Add(g)
        Next
    End Sub

    Public Sub Read(ByRef g As GP)
        Dim col As Collection : Dim aux As Collection
        Dim c As Country
        col = DBBroker.GetBroker.Read("SELECT * FROM GPs WHERE GPID='" & g.GPID & "';")
        For Each aux In col
            c = New Country(aux(3).ToString)
            g.GPName = aux(2).ToString
            g.GPCountry = c.ReadCountry()
        Next
    End Sub

    Public Function Insert(ByVal g As GP) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO GPs VALUES (" & g.GPID & ", '" & g.GPName & "', '" & g.GPCountry.CountryID & "');")
    End Function

    Public Function Update(ByVal g As GP) As Integer
        Return DBBroker.GetBroker.Change("UPDATE GPs SET GPName='" & g.GPName & "', GPCountry='" & g.GPCountry.CountryID & "' WHERE GPID='" & g.GPID & "';")
    End Function

    Public Function Delete(ByVal g As GP) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM GPs WHERE GPID='" & g.GPID & "';")
    End Function

End Class
