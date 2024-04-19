Public Class FormDrivers
    Property drivers As Collection
    Property countries As Collection

    Public Sub New(d As Collection, c As Collection)
        Me.drivers = d
        Me.countries = c
        InitializeComponent()
    End Sub
    Private Sub lblCountries_Click(sender As Object, e As EventArgs) Handles lblDrivers.Click

    End Sub

    Private Sub FormDrivers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIDD.ReadOnly = True
        Try
            For Each d In Me.drivers
                lstDrivers.Items.Add(d)
            Next
            For Each aux In Me.countries
                cmbD.Items.Add(aux.CountryID)
            Next
            lstDrivers.DisplayMember = "ToString"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnInsertD_Click(sender As Object, e As EventArgs) Handles btnInsertD.Click

        If checkIfCorrectData(txtNameD.Text, txtSurnameD.Text, cmbD.Text) Then
            Try
                Dim d As Driver = New Driver(txtNameD.Text, txtSurnameD.Text, New Country(cmbD.Text))
                d.InsertDriver()
                Me.drivers.Add(d)
                lstDrivers.Items.Add(d)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub lstDrivers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDrivers.SelectedIndexChanged
        Dim d As Driver = lstDrivers.SelectedItem
        txtIDD.Text = d.DriverID
        txtNameD.Text = d.DriverName
        txtSurnameD.Text = d.DriverSurname
        cmbD.Text = d.DriverCountry.CountryID
    End Sub

    Private Sub btnClearD_Click(sender As Object, e As EventArgs) Handles btnClearD.Click
        txtSurnameD.Text = ""
        txtNameD.Text = ""
        txtIDD.Text = ""
        cmbD.Text = ""
    End Sub

    Private Sub btnDeleteD_Click(sender As Object, e As EventArgs) Handles btnDeleteD.Click
        Dim d As Driver
        If checkID(txtIDD.Text) Then
            Try
                d = New Driver(txtIDD.Text)
                d.DeleteDriver()
                deleteDriver(d)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnUpdateD_Click(sender As Object, e As EventArgs) Handles btnUpdateD.Click
        Dim d As Driver
        If checkIfCorrectData(txtNameD.Text, txtSurnameD.Text, cmbD.Text) And checkID(txtIDD.Text) Then
            Try
                d = New Driver(txtIDD.Text, txtNameD.Text, txtSurnameD.Text, New Country(cmbD.Text))
                d.UpdateDriver()
                updateDriver(d)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub deleteDriver(d As Driver)
        Dim counter As Integer = 1
        For Each aux In Me.drivers
            If aux.DriverID = d.DriverID Then
                Me.drivers.Remove(counter)
                lstDrivers.Items.Remove(counter)
            End If
            counter = counter + 1
        Next
    End Sub

    Private Sub updateDriver(d As Driver)
        Dim counter As Integer = 0
        For Each aux In Me.drivers
            If aux.DriverID = d.DriverID Then
                Me.drivers.Remove(counter + 1)
                Me.drivers.Add(d)
                lstDrivers.Items(counter).DriverName = d.DriverName
                lstDrivers.Items(counter).DriverSurname = d.DriverSurname
                lstDrivers.Items(counter).DriverCountry = d.DriverCountry

            End If
            counter = counter + 1
        Next
    End Sub

    Private Function checkIfCorrectData(name As String, surname As String, country As String) As Boolean
        If name = "" Or surname = "" Or country = "" Then
            MessageBox.Show("ID, name, surname and country fields cannot be empty. Introduce some values.")
            Return False
        End If
        Return True
    End Function

    Private Function checkID(id As String) As Boolean
        If id = "" Then
            MessageBox.Show("Select a driver")
            Return False
        End If
        Return True
    End Function
End Class