Public Class FormDrivers
    Property drivers As Collection
    Property countries As Collection

    Public Sub New(d As Collection, c As Collection)
        Me.drivers = d
        Me.countries = c
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub lblCountries_Click(sender As Object, e As EventArgs) Handles lblDrivers.Click

    End Sub

    Private Sub FormDrivers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIDD.ReadOnly = True
        Try
            lstDrivers.DataSource = Me.drivers
            For Each aux In Me.countries
                cmbD.Items.Add(aux.CountryID)
            Next
            lstDrivers.DisplayMember = "ToString"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnInsertD_Click(sender As Object, e As EventArgs) Handles btnInsertD.Click
        Try
            If txtNameD.Text Is Nothing Or txtSurnameD.Text Is Nothing Or cmbD.Text Is Nothing Then
                MessageBox.Show("Name and Surname fields cannot be empty")
            Else
                Dim d As Driver = New Driver(txtNameD.Text, txtSurnameD.Text, New Country(cmbD.Text))
                d.InsertDriver()
            End If
        Catch ex As Exception

        End Try
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
End Class