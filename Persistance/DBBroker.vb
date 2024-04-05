Imports MySql.Data.MySqlClient
Public Class DBBroker

    Private Shared _Instance As DBBroker
    Private Shared connection As MySql.Data.MySqlClient.MySqlConnection
    Private Shared connectionString As String

    Private Sub New()
        DBBroker.connectionString = "server=192.168.1.83;userid=elouan2;password='hola';database=mydb"
        DBBroker.connection = New MySql.Data.MySqlClient.MySqlConnection(DBBroker.connectionString)
    End Sub

    Public Shared Function GetBroker() As DBBroker

        If DBBroker._Instance Is Nothing Then
            DBBroker._Instance = New DBBroker
        End If
        Return DBBroker._Instance
    End Function

    Public Function Read(sql As String) As Collection
        Dim result As New Collection
        Dim row As Collection
        Dim i As Integer
        Dim reader As MySql.Data.MySqlClient.MySqlDataReader
        Dim com As New MySql.Data.MySqlClient.MySqlCommand(sql, DBBroker.connection)
        Connect()
        reader = com.ExecuteReader
        While reader.Read
            row = New Collection
            For i = 0 To reader.FieldCount - 1
                row.Add(reader(i).ToString)
            Next
            result.Add(row)
        End While


        Disconnect()
        Return result
    End Function

    Public Function Change(sql As String) As Integer
        Dim com As New MySql.Data.MySqlClient.MySqlCommand(sql, DBBroker.connection)
        Dim result As Integer
        Connect()
        result = com.ExecuteNonQuery
        Disconnect()
        Return result
    End Function

    Private Sub Connect()
        If DBBroker.connection.State = ConnectionState.Closed Then
            Try
                DBBroker.connection.Open()
            Catch ex As Exception
                Application.Exit()
            End Try

        End If
    End Sub

    Private Sub Disconnect()
        If DBBroker.connection.State = ConnectionState.Open Then
            DBBroker.connection.Close()
        End If
    End Sub

End Class

