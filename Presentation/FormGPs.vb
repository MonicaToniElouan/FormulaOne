Public Class FormGPs
    Property gps As Collection
    Property countries As Collection
    Public Sub New(g As Collection, c As Collection)
        Me.gps = g
        Me.countries = c
        InitializeComponent()

    End Sub
    Private Sub FormGPs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIDGP.ReadOnly = True
        cmbG.Items.Add("")
        Try
            For Each aux In Me.gps
                lstGP.Items.Add(aux)
            Next
            For Each aux In Me.countries
                cmbG.Items.Add(aux.CountryID)
            Next
            lstGP.DisplayMember = "ToString"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnInsertGP_Click(sender As Object, e As EventArgs) Handles btnInsertGP.Click
        If checkIfCorrectData(txtNameGP.Text, cmbG.Text) Then
            Try
                Dim g As GP = New GP(txtNameGP.Text, New Country(cmbG.Text))
                g.InsertGP()
                Me.gps.Add(g)
                lstGP.Items.Add(g)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub

    Private Function checkIfCorrectData(name As String, country As String) As Boolean
        If name = "" Or country = "" Then
            MessageBox.Show("Name and country fields cannot be empty. Introduce some values.")
            Return False
        End If
        Return True
    End Function

    Private Function checkID(id As String) As Boolean
        If id = "" Then
            MessageBox.Show("Select a Grand Prix")
            Return False
        End If
        Return True
    End Function

    Private Sub lstGP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstGP.SelectedIndexChanged
        Dim g As GP = lstGP.SelectedItem
        If Not g Is Nothing Then
            txtIDGP.Text = g.GPID
            txtNameGP.Text = g.GPName
            cmbG.Text = g.GPCountry.CountryID
        End If
    End Sub

    Private Sub btnDeleteGP_Click(sender As Object, e As EventArgs) Handles btnDeleteGP.Click
        Dim g As GP
        If checkID(txtIDGP.Text) Then
            Try
                g = New GP(txtIDGP.Text)
                g.DeleteGP()
                deleteGP(g)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub deleteGP(g As GP)
        Dim counter As Integer = 1
        For Each aux In Me.gps
            If aux.GPID = g.GPID Then
                Me.gps.Remove(counter)
                lstGP.Items.Remove(counter)
            End If
            counter = counter + 1
        Next
    End Sub

    Private Sub btnUpdateGP_Click(sender As Object, e As EventArgs) Handles btnUpdateGP.Click
        Dim g As GP
        If checkIfCorrectData(txtNameGP.Text, cmbG.Text) And checkID(txtIDGP.Text) Then
            Try
                g = New GP(txtIDGP.Text, txtNameGP.Text, New Country(cmbG.Text))
                g.UpdateGP()
                updateGP(g)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub updateGP(g As GP)
        Dim counter As Integer = 0
        For Each aux In Me.gps
            If aux.GPID = g.GPID Then
                Me.gps.Remove(counter + 1)
                Me.gps.Add(g)
                lstGP.Items(counter).GPName = g.GPName
                lstGP.Items(counter).GPCountry = g.GPCountry
            End If
            counter = counter + 1
        Next
    End Sub

    Private Sub btnClearGP_Click(sender As Object, e As EventArgs) Handles btnClearGP.Click
        txtIDGP.Text = ""
        txtNameGP.Text = ""
        cmbG.Text = ""
    End Sub
End Class