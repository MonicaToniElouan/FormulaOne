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
        lstTeams = New ListBox()
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
        lblTeams.Location = New Point(114, 40)
        lblTeams.Name = "lblTeams"
        lblTeams.Size = New Size(111, 36)
        lblTeams.TabIndex = 2
        lblTeams.Text = "TEAM"
        ' 
        ' lblIDT
        ' 
        lblIDT.AutoSize = True
        lblIDT.BackColor = Color.White
        lblIDT.Font = New Font("Yu Gothic", 14.8F, FontStyle.Bold)
        lblIDT.ForeColor = Color.Black
        lblIDT.Location = New Point(403, 84)
        lblIDT.Name = "lblIDT"
        lblIDT.Size = New Size(45, 26)
        lblIDT.TabIndex = 7
        lblIDT.Text = "ID: "
        ' 
        ' lblNameT
        ' 
        lblNameT.AutoSize = True
        lblNameT.BackColor = Color.White
        lblNameT.Font = New Font("Yu Gothic", 14.8F, FontStyle.Bold)
        lblNameT.ForeColor = Color.Black
        lblNameT.Location = New Point(403, 125)
        lblNameT.Name = "lblNameT"
        lblNameT.Size = New Size(80, 26)
        lblNameT.TabIndex = 8
        lblNameT.Text = "NAME:"
        ' 
        ' lblCountryT
        ' 
        lblCountryT.AutoSize = True
        lblCountryT.BackColor = Color.White
        lblCountryT.Font = New Font("Yu Gothic", 14.8F, FontStyle.Bold)
        lblCountryT.ForeColor = Color.Black
        lblCountryT.Location = New Point(403, 166)
        lblCountryT.Name = "lblCountryT"
        lblCountryT.Size = New Size(124, 26)
        lblCountryT.TabIndex = 9
        lblCountryT.Text = "COUNTRY: "
        ' 
        ' lblCreationDateT
        ' 
        lblCreationDateT.AutoSize = True
        lblCreationDateT.BackColor = Color.White
        lblCreationDateT.Font = New Font("Yu Gothic", 14.8F, FontStyle.Bold)
        lblCreationDateT.ForeColor = Color.Black
        lblCreationDateT.Location = New Point(403, 216)
        lblCreationDateT.Name = "lblCreationDateT"
        lblCreationDateT.Size = New Size(188, 26)
        lblCreationDateT.TabIndex = 10
        lblCreationDateT.Text = "CREATION DATE: "
        ' 
        ' lstTeams
        ' 
        lstTeams.BackColor = SystemColors.Menu
        lstTeams.FormattingEnabled = True
        lstTeams.ItemHeight = 15
        lstTeams.Location = New Point(38, 94)
        lstTeams.Margin = New Padding(3, 2, 3, 2)
        lstTeams.Name = "lstTeams"
        lstTeams.Size = New Size(280, 379)
        lstTeams.TabIndex = 12
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
        pnlSelectOptionT.Location = New Point(403, 258)
        pnlSelectOptionT.Name = "pnlSelectOptionT"
        pnlSelectOptionT.Size = New Size(488, 231)
        pnlSelectOptionT.TabIndex = 13
        ' 
        ' btnClearD
        ' 
        btnClearD.BackColor = SystemColors.Menu
        btnClearD.Font = New Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClearD.ForeColor = Color.OrangeRed
        btnClearD.Location = New Point(251, 36)
        btnClearD.Name = "btnClearD"
        btnClearD.Size = New Size(211, 78)
        btnClearD.TabIndex = 7
        btnClearD.Text = "CLEAR"
        btnClearD.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteD
        ' 
        btnDeleteD.BackColor = SystemColors.Menu
        btnDeleteD.Font = New Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDeleteD.Location = New Point(20, 120)
        btnDeleteD.Name = "btnDeleteD"
        btnDeleteD.Size = New Size(216, 75)
        btnDeleteD.TabIndex = 6
        btnDeleteD.Text = "DELETE"
        btnDeleteD.UseVisualStyleBackColor = False
        ' 
        ' btnUpdateD
        ' 
        btnUpdateD.BackColor = SystemColors.Menu
        btnUpdateD.Font = New Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdateD.Location = New Point(251, 120)
        btnUpdateD.Name = "btnUpdateD"
        btnUpdateD.Size = New Size(211, 75)
        btnUpdateD.TabIndex = 5
        btnUpdateD.Text = "UPDATE"
        btnUpdateD.UseVisualStyleBackColor = False
        ' 
        ' lblSelectOptionC
        ' 
        lblSelectOptionC.AutoSize = True
        lblSelectOptionC.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSelectOptionC.ForeColor = Color.Transparent
        lblSelectOptionC.Location = New Point(164, 14)
        lblSelectOptionC.Name = "lblSelectOptionC"
        lblSelectOptionC.Size = New Size(147, 20)
        lblSelectOptionC.TabIndex = 4
        lblSelectOptionC.Text = "SELECT AN OPTION"
        ' 
        ' btnInsertD
        ' 
        btnInsertD.BackColor = SystemColors.Menu
        btnInsertD.Font = New Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnInsertD.Location = New Point(20, 35)
        btnInsertD.Name = "btnInsertD"
        btnInsertD.Size = New Size(216, 79)
        btnInsertD.TabIndex = 0
        btnInsertD.Text = "INSERT"
        btnInsertD.UseVisualStyleBackColor = False
        ' 
        ' txtIDT
        ' 
        txtIDT.BackColor = Color.White
        txtIDT.Font = New Font("Segoe UI", 14F)
        txtIDT.Location = New Point(628, 79)
        txtIDT.Margin = New Padding(3, 2, 3, 2)
        txtIDT.Name = "txtIDT"
        txtIDT.Size = New Size(264, 32)
        txtIDT.TabIndex = 14
        ' 
        ' txtNameT
        ' 
        txtNameT.BackColor = Color.White
        txtNameT.Font = New Font("Segoe UI", 14F)
        txtNameT.Location = New Point(628, 120)
        txtNameT.Margin = New Padding(3, 2, 3, 2)
        txtNameT.Name = "txtNameT"
        txtNameT.Size = New Size(264, 32)
        txtNameT.TabIndex = 15
        ' 
        ' txtCountryT
        ' 
        txtCountryT.BackColor = Color.White
        txtCountryT.Font = New Font("Segoe UI", 14F)
        txtCountryT.Location = New Point(628, 161)
        txtCountryT.Margin = New Padding(3, 2, 3, 2)
        txtCountryT.Name = "txtCountryT"
        txtCountryT.Size = New Size(264, 32)
        txtCountryT.TabIndex = 16
        ' 
        ' txtCreationDateT
        ' 
        txtCreationDateT.BackColor = Color.White
        txtCreationDateT.Font = New Font("Segoe UI", 14F)
        txtCreationDateT.Location = New Point(628, 211)
        txtCreationDateT.Margin = New Padding(3, 2, 3, 2)
        txtCreationDateT.Name = "txtCreationDateT"
        txtCreationDateT.Size = New Size(264, 32)
        txtCreationDateT.TabIndex = 17
        ' 
        ' FormTeams
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(914, 506)
        Controls.Add(txtCreationDateT)
        Controls.Add(txtCountryT)
        Controls.Add(txtNameT)
        Controls.Add(txtIDT)
        Controls.Add(pnlSelectOptionT)
        Controls.Add(lstTeams)
        Controls.Add(lblCreationDateT)
        Controls.Add(lblCountryT)
        Controls.Add(lblNameT)
        Controls.Add(lblIDT)
        Controls.Add(lblTeams)
        Margin = New Padding(3, 2, 3, 2)
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
    Friend WithEvents lstTeams As ListBox
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
