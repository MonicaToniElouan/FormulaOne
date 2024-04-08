<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDrivers
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDrivers))
        lblDrivers = New Label()
        lstDrivers = New ListBox()
        lblNameD = New Label()
        lblSurnameD = New Label()
        lblCountryD = New Label()
        lblIDD = New Label()
        pnlSelectOptionD = New Panel()
        btnClearD = New Button()
        btnDeleteD = New Button()
        btnUpdateD = New Button()
        lblSelectOptionC = New Label()
        btnInsertD = New Button()
        txtIDD = New TextBox()
        txtNameD = New TextBox()
        txtSurnameD = New TextBox()
        txtCountryD = New TextBox()
        pnlSelectOptionD.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblDrivers
        ' 
        lblDrivers.AutoSize = True
        lblDrivers.BackColor = SystemColors.Window
        lblDrivers.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDrivers.ForeColor = Color.DarkRed
        lblDrivers.Location = New Point(97, 60)
        lblDrivers.Name = "lblDrivers"
        lblDrivers.Size = New Size(179, 45)
        lblDrivers.TabIndex = 1
        lblDrivers.Text = "DRIVER"
        ' 
        ' lstDrivers
        ' 
        lstDrivers.BackColor = SystemColors.Menu
        lstDrivers.FormattingEnabled = True
        lstDrivers.Location = New Point(31, 120)
        lstDrivers.Name = "lstDrivers"
        lstDrivers.Size = New Size(320, 504)
        lstDrivers.TabIndex = 2
        ' 
        ' lblNameD
        ' 
        lblNameD.AutoSize = True
        lblNameD.BackColor = Color.Black
        lblNameD.Font = New Font("Yu Gothic", 14.8F, FontStyle.Bold)
        lblNameD.ForeColor = Color.White
        lblNameD.Location = New Point(403, 142)
        lblNameD.Name = "lblNameD"
        lblNameD.Size = New Size(99, 32)
        lblNameD.TabIndex = 3
        lblNameD.Text = "NAME:"
        ' 
        ' lblSurnameD
        ' 
        lblSurnameD.AutoSize = True
        lblSurnameD.BackColor = Color.Black
        lblSurnameD.Font = New Font("Yu Gothic", 14.8F, FontStyle.Bold)
        lblSurnameD.ForeColor = Color.White
        lblSurnameD.Location = New Point(403, 203)
        lblSurnameD.Name = "lblSurnameD"
        lblSurnameD.Size = New Size(151, 32)
        lblSurnameD.TabIndex = 4
        lblSurnameD.Text = "SURNAME:"
        ' 
        ' lblCountryD
        ' 
        lblCountryD.AutoSize = True
        lblCountryD.BackColor = Color.Black
        lblCountryD.Font = New Font("Yu Gothic", 14.8F, FontStyle.Bold)
        lblCountryD.ForeColor = Color.White
        lblCountryD.Location = New Point(403, 262)
        lblCountryD.Name = "lblCountryD"
        lblCountryD.Size = New Size(153, 32)
        lblCountryD.TabIndex = 5
        lblCountryD.Text = "COUNTRY: "
        ' 
        ' lblIDD
        ' 
        lblIDD.AutoSize = True
        lblIDD.BackColor = Color.Black
        lblIDD.Font = New Font("Yu Gothic", 14.8F, FontStyle.Bold)
        lblIDD.ForeColor = Color.White
        lblIDD.Location = New Point(403, 80)
        lblIDD.Name = "lblIDD"
        lblIDD.Size = New Size(56, 32)
        lblIDD.TabIndex = 6
        lblIDD.Text = "ID: "
        ' 
        ' pnlSelectOptionD
        ' 
        pnlSelectOptionD.BackColor = Color.DarkRed
        pnlSelectOptionD.Controls.Add(btnClearD)
        pnlSelectOptionD.Controls.Add(btnDeleteD)
        pnlSelectOptionD.Controls.Add(btnUpdateD)
        pnlSelectOptionD.Controls.Add(lblSelectOptionC)
        pnlSelectOptionD.Controls.Add(btnInsertD)
        pnlSelectOptionD.ForeColor = Color.Black
        pnlSelectOptionD.Location = New Point(403, 316)
        pnlSelectOptionD.Margin = New Padding(3, 4, 3, 4)
        pnlSelectOptionD.Name = "pnlSelectOptionD"
        pnlSelectOptionD.Size = New Size(558, 308)
        pnlSelectOptionD.TabIndex = 9
        ' 
        ' btnClearD
        ' 
        btnClearD.BackColor = SystemColors.Menu
        btnClearD.Font = New Font("Ubuntu Condensed", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClearD.ForeColor = Color.Black
        btnClearD.Location = New Point(287, 48)
        btnClearD.Margin = New Padding(3, 4, 3, 4)
        btnClearD.Name = "btnClearD"
        btnClearD.Size = New Size(241, 104)
        btnClearD.TabIndex = 7
        btnClearD.Text = "CLEAR"
        btnClearD.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteD
        ' 
        btnDeleteD.BackColor = SystemColors.Menu
        btnDeleteD.Font = New Font("Ubuntu Condensed", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDeleteD.Location = New Point(23, 160)
        btnDeleteD.Margin = New Padding(3, 4, 3, 4)
        btnDeleteD.Name = "btnDeleteD"
        btnDeleteD.Size = New Size(247, 100)
        btnDeleteD.TabIndex = 6
        btnDeleteD.Text = "DELETE"
        btnDeleteD.UseVisualStyleBackColor = False
        ' 
        ' btnUpdateD
        ' 
        btnUpdateD.BackColor = SystemColors.Menu
        btnUpdateD.Font = New Font("Ubuntu Condensed", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdateD.Location = New Point(287, 160)
        btnUpdateD.Margin = New Padding(3, 4, 3, 4)
        btnUpdateD.Name = "btnUpdateD"
        btnUpdateD.Size = New Size(241, 100)
        btnUpdateD.TabIndex = 5
        btnUpdateD.Text = "UPDATE"
        btnUpdateD.UseVisualStyleBackColor = False
        ' 
        ' lblSelectOptionC
        ' 
        lblSelectOptionC.AutoSize = True
        lblSelectOptionC.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSelectOptionC.ForeColor = Color.Transparent
        lblSelectOptionC.Location = New Point(187, 18)
        lblSelectOptionC.Name = "lblSelectOptionC"
        lblSelectOptionC.Size = New Size(180, 25)
        lblSelectOptionC.TabIndex = 4
        lblSelectOptionC.Text = "SELECT AN OPTION"
        ' 
        ' btnInsertD
        ' 
        btnInsertD.BackColor = SystemColors.Menu
        btnInsertD.Font = New Font("Ubuntu Condensed", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnInsertD.Location = New Point(23, 47)
        btnInsertD.Margin = New Padding(3, 4, 3, 4)
        btnInsertD.Name = "btnInsertD"
        btnInsertD.Size = New Size(247, 105)
        btnInsertD.TabIndex = 0
        btnInsertD.Text = "INSERT"
        btnInsertD.UseVisualStyleBackColor = False
        ' 
        ' txtIDD
        ' 
        txtIDD.BackColor = Color.White
        txtIDD.Font = New Font("Segoe UI", 14F)
        txtIDD.Location = New Point(646, 73)
        txtIDD.Name = "txtIDD"
        txtIDD.Size = New Size(315, 39)
        txtIDD.TabIndex = 8
        ' 
        ' txtNameD
        ' 
        txtNameD.BackColor = Color.White
        txtNameD.Font = New Font("Segoe UI", 14F)
        txtNameD.Location = New Point(646, 135)
        txtNameD.Name = "txtNameD"
        txtNameD.Size = New Size(315, 39)
        txtNameD.TabIndex = 10
        ' 
        ' txtSurnameD
        ' 
        txtSurnameD.BackColor = Color.White
        txtSurnameD.Font = New Font("Segoe UI", 14F)
        txtSurnameD.Location = New Point(646, 196)
        txtSurnameD.Name = "txtSurnameD"
        txtSurnameD.Size = New Size(315, 39)
        txtSurnameD.TabIndex = 11
        ' 
        ' txtCountryD
        ' 
        txtCountryD.BackColor = Color.White
        txtCountryD.Font = New Font("Segoe UI", 14F)
        txtCountryD.Location = New Point(646, 255)
        txtCountryD.Name = "txtCountryD"
        txtCountryD.Size = New Size(315, 39)
        txtCountryD.TabIndex = 12
        ' 
        ' FormDrivers
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(973, 670)
        Controls.Add(txtCountryD)
        Controls.Add(txtSurnameD)
        Controls.Add(txtNameD)
        Controls.Add(txtIDD)
        Controls.Add(pnlSelectOptionD)
        Controls.Add(lblIDD)
        Controls.Add(lblCountryD)
        Controls.Add(lblSurnameD)
        Controls.Add(lblNameD)
        Controls.Add(lstDrivers)
        Controls.Add(lblDrivers)
        Name = "FormDrivers"
        Text = "FormDrivers"
        pnlSelectOptionD.ResumeLayout(False)
        pnlSelectOptionD.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblDrivers As Label
    Friend WithEvents lstDrivers As ListBox
    Friend WithEvents lblNameD As Label
    Friend WithEvents lblSurnameD As Label
    Friend WithEvents lblCountryD As Label
    Friend WithEvents lblIDD As Label
    Friend WithEvents pnlSelectOptionD As Panel
    Friend WithEvents btnClearD As Button
    Friend WithEvents btnDeleteD As Button
    Friend WithEvents btnUpdateD As Button
    Friend WithEvents lblSelectOptionC As Label
    Friend WithEvents btnInsertD As Button
    Friend WithEvents txtIDD As TextBox
    Friend WithEvents txtNameD As TextBox
    Friend WithEvents txtSurnameD As TextBox
    Friend WithEvents txtCountryD As TextBox
End Class
