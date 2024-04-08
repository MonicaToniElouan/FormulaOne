<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTeams
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTeams))
        lblTeams = New Label()
        lblIDT = New Label()
        lblNameT = New Label()
        lblCountryT = New Label()
        lblCreationDateT = New Label()
        lstDrivers = New ListBox()
        pnlSelectOptionT = New Panel()
        btnClearD = New Button()
        btnDeleteD = New Button()
        btnUpdateD = New Button()
        lblSelectOptionC = New Label()
        btnInsertD = New Button()
        txtIDT = New TextBox()
        txtNameT = New TextBox()
        txtCountryT = New TextBox()
        txtCreationDateT = New TextBox()
        pnlSelectOptionT.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTeams
        ' 
        lblTeams.AutoSize = True
        lblTeams.BackColor = SystemColors.Window
        lblTeams.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTeams.ForeColor = Color.OrangeRed
        lblTeams.Location = New Point(130, 54)
        lblTeams.Name = "lblTeams"
        lblTeams.Size = New Size(141, 45)
        lblTeams.TabIndex = 2
        lblTeams.Text = "TEAM"
        ' 
        ' lblIDT
        ' 
        lblIDT.AutoSize = True
        lblIDT.BackColor = Color.White
        lblIDT.Font = New Font("Yu Gothic", 14.8F, FontStyle.Bold)
        lblIDT.ForeColor = Color.Black
        lblIDT.Location = New Point(461, 112)
        lblIDT.Name = "lblIDT"
        lblIDT.Size = New Size(56, 32)
        lblIDT.TabIndex = 7
        lblIDT.Text = "ID: "
        ' 
        ' lblNameT
        ' 
        lblNameT.AutoSize = True
        lblNameT.BackColor = Color.White
        lblNameT.Font = New Font("Yu Gothic", 14.8F, FontStyle.Bold)
        lblNameT.ForeColor = Color.Black
        lblNameT.Location = New Point(461, 167)
        lblNameT.Name = "lblNameT"
        lblNameT.Size = New Size(99, 32)
        lblNameT.TabIndex = 8
        lblNameT.Text = "NAME:"
        ' 
        ' lblCountryT
        ' 
        lblCountryT.AutoSize = True
        lblCountryT.BackColor = Color.White
        lblCountryT.Font = New Font("Yu Gothic", 14.8F, FontStyle.Bold)
        lblCountryT.ForeColor = Color.Black
        lblCountryT.Location = New Point(461, 222)
        lblCountryT.Name = "lblCountryT"
        lblCountryT.Size = New Size(153, 32)
        lblCountryT.TabIndex = 9
        lblCountryT.Text = "COUNTRY: "
        ' 
        ' lblCreationDateT
        ' 
        lblCreationDateT.AutoSize = True
        lblCreationDateT.BackColor = Color.White
        lblCreationDateT.Font = New Font("Yu Gothic", 14.8F, FontStyle.Bold)
        lblCreationDateT.ForeColor = Color.Black
        lblCreationDateT.Location = New Point(461, 288)
        lblCreationDateT.Name = "lblCreationDateT"
        lblCreationDateT.Size = New Size(233, 32)
        lblCreationDateT.TabIndex = 10
        lblCreationDateT.Text = "CREATION DATE: "
        ' 
        ' lstDrivers
        ' 
        lstDrivers.BackColor = SystemColors.Menu
        lstDrivers.FormattingEnabled = True
        lstDrivers.Location = New Point(43, 126)
        lstDrivers.Name = "lstDrivers"
        lstDrivers.Size = New Size(320, 504)
        lstDrivers.TabIndex = 12
        ' 
        ' pnlSelectOptionT
        ' 
        pnlSelectOptionT.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        pnlSelectOptionT.Controls.Add(btnClearD)
        pnlSelectOptionT.Controls.Add(btnDeleteD)
        pnlSelectOptionT.Controls.Add(btnUpdateD)
        pnlSelectOptionT.Controls.Add(lblSelectOptionC)
        pnlSelectOptionT.Controls.Add(btnInsertD)
        pnlSelectOptionT.ForeColor = Color.OrangeRed
        pnlSelectOptionT.Location = New Point(461, 344)
        pnlSelectOptionT.Margin = New Padding(3, 4, 3, 4)
        pnlSelectOptionT.Name = "pnlSelectOptionT"
        pnlSelectOptionT.Size = New Size(558, 308)
        pnlSelectOptionT.TabIndex = 13
        ' 
        ' btnClearD
        ' 
        btnClearD.BackColor = SystemColors.Menu
        btnClearD.Font = New Font("Ubuntu Condensed", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClearD.ForeColor = Color.OrangeRed
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
        ' txtIDT
        ' 
        txtIDT.BackColor = Color.White
        txtIDT.Font = New Font("Segoe UI", 14F)
        txtIDT.Location = New Point(718, 105)
        txtIDT.Name = "txtIDT"
        txtIDT.Size = New Size(301, 39)
        txtIDT.TabIndex = 14
        ' 
        ' txtNameT
        ' 
        txtNameT.BackColor = Color.White
        txtNameT.Font = New Font("Segoe UI", 14F)
        txtNameT.Location = New Point(718, 160)
        txtNameT.Name = "txtNameT"
        txtNameT.Size = New Size(301, 39)
        txtNameT.TabIndex = 15
        ' 
        ' txtCountryT
        ' 
        txtCountryT.BackColor = Color.White
        txtCountryT.Font = New Font("Segoe UI", 14F)
        txtCountryT.Location = New Point(718, 215)
        txtCountryT.Name = "txtCountryT"
        txtCountryT.Size = New Size(301, 39)
        txtCountryT.TabIndex = 16
        ' 
        ' txtCreationDateT
        ' 
        txtCreationDateT.BackColor = Color.White
        txtCreationDateT.Font = New Font("Segoe UI", 14F)
        txtCreationDateT.Location = New Point(718, 281)
        txtCreationDateT.Name = "txtCreationDateT"
        txtCreationDateT.Size = New Size(301, 39)
        txtCreationDateT.TabIndex = 17
        ' 
        ' FormTeams
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1045, 675)
        Controls.Add(txtCreationDateT)
        Controls.Add(txtCountryT)
        Controls.Add(txtNameT)
        Controls.Add(txtIDT)
        Controls.Add(pnlSelectOptionT)
        Controls.Add(lstDrivers)
        Controls.Add(lblCreationDateT)
        Controls.Add(lblCountryT)
        Controls.Add(lblNameT)
        Controls.Add(lblIDT)
        Controls.Add(lblTeams)
        Name = "FormTeams"
        Text = "FormTeams"
        pnlSelectOptionT.ResumeLayout(False)
        pnlSelectOptionT.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTeams As Label
    Friend WithEvents lblIDT As Label
    Friend WithEvents lblNameT As Label
    Friend WithEvents lblCountryT As Label
    Friend WithEvents lblCreationDateT As Label
    Friend WithEvents lstDrivers As ListBox
    Friend WithEvents pnlSelectOptionT As Panel
    Friend WithEvents btnClearD As Button
    Friend WithEvents btnDeleteD As Button
    Friend WithEvents btnUpdateD As Button
    Friend WithEvents lblSelectOptionC As Label
    Friend WithEvents btnInsertD As Button
    Friend WithEvents txtIDT As TextBox
    Friend WithEvents txtNameT As TextBox
    Friend WithEvents txtCountryT As TextBox
    Friend WithEvents txtCreationDateT As TextBox
End Class
