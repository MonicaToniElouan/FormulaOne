Imports System.Windows.Forms.Design
Imports MySql.Data.MySqlClient

Public Class FormCountries
    Property countries As Collection
    Public Sub New(c As Collection)
        Me.countries = c

        InitializeComponent()

    End Sub

    Private Sub btnInsertC_Click(sender As Object, e As EventArgs) Handles btnInsertC.Click
        Dim c As Country
        Dim id As String
        If checkIfCorrectData(txtIDC.Text, txtNameC.Text, txtPopulationC.Text) And checkIfCorrectId(txtIDC.Text, txtNameC.Text) Then
            id = UCase(Mid(txtNameC.Text, 1, 3))
            While Not checkIfIdAvailable(id) Or id.Length <> 3
                id = InputBox("The ID is correct but not available. Introduce a custom ID (it must have 3 characters)")
            End While
            Try
                c = New Country(id, txtNameC.Text, txtPopulationC.Text)
                c.InsertCountry()
                Me.countries.Add(c)
                lstCountries.Items.Add(c)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub

    Private Sub FormCountries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            For Each aux In Me.countries
                lstCountries.Items.Add(aux)
            Next
            lstCountries.DisplayMember = "ToString"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub lstCountries_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCountries.SelectedIndexChanged
        Dim c As Country = lstCountries.SelectedItem
        If Not c Is Nothing Then
            txtIDC.Text = c.CountryID
            txtNameC.Text = c.CountryName
            txtPopulationC.Text = c.CountryPopulation
        End If
    End Sub

    Private Function checkIfIdAvailable(id As String) As Boolean
        Dim result As Boolean = True
        For Each aux In Me.countries
            If aux.CountryID = id Then
                result = False
            End If
        Next

        Return result
    End Function

    Private Function checkIfCorrectData(id As String, name As String, pop As String) As Boolean
        If name = "" Or pop = "" Or id = "" Then
            MessageBox.Show("ID, name and population cannot be empty. Introduce some value")
            Return False
        End If
        Return True
    End Function

    Private Function checkIfCorrectId(id As String, name As String) As Boolean
        If Not UCase(id) = UCase(Mid(name, 1, 3)) Then
            MessageBox.Show("The ID must be composed by the 3 first characters of the country name")
            Return False
        End If
        Return True
    End Function

    Private Sub btnClearC_Click(sender As Object, e As EventArgs) Handles btnClearC.Click
        txtIDC.Text = ""
        txtNameC.Text = ""
        txtPopulationC.Text = ""
    End Sub

    Private Sub btnDeleteC_Click(sender As Object, e As EventArgs) Handles btnDeleteC.Click
        Dim c As Country
        Try
            c = New Country(txtIDC.Text)
            c.DeleteCountry()
            deleteCountry(c)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnUpdateC_Click(sender As Object, e As EventArgs) Handles btnUpdateC.Click
        Dim c As Country
        If checkIfCorrectData(txtIDC.Text, txtNameC.Text, txtPopulationC.Text) Then
            Try
                c = New Country(txtIDC.Text, txtNameC.Text, txtPopulationC.Text)
                c.UpdateCountry()
                updatecountry(c)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub deleteCountry(c As Country)
        Dim counter As Integer = 1
        For Each aux In Me.countries
            If aux.CountryID = c.CountryID Then
                Me.countries.Remove(counter)
                lstCountries.Items.Remove(lstCountries.Items.IndexOf(aux))
            End If
            counter = counter + 1
        Next
    End Sub
    Private Sub updateCountry(c As Country)
        Dim counter As Integer = 1
        For Each aux In Me.countries
            If aux.CountryID = c.CountryID Then
                Me.countries.Remove(counter)
                Me.countries.Add(c)
                lstCountries.Items.Remove(lstCountries.Items.IndexOf(aux))
                lstCountries.Items.Add(c)
            End If
            counter = counter + 1
        Next
    End Sub
End Class