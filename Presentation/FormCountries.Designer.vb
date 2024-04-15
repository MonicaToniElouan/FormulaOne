<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class txtName
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(txtName))
        lblCountries = New Label()
        lstCountries = New ListBox()
        lblIDC = New Label()
        lblNameC = New Label()
        lblPopulationC = New Label()
        txtIDC = New TextBox()
        txtNameC = New TextBox()
        txtPopulationC = New TextBox()
        pnlSelectOptionC = New Panel()
        btnClearC = New Button()
        btnDeleteC = New Button()
        btnUpdateC = New Button()
        lblSelectOptionC = New Label()
        btnInsertC = New Button()
        pnlSelectOptionC.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblCountries
        ' 
        lblCountries.AutoSize = True
        lblCountries.BackColor = SystemColors.Window
        lblCountries.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCountries.ForeColor = SystemColors.ActiveCaptionText
        lblCountries.Location = New Point(82, 107)
        lblCountries.Name = "lblCountries"
        lblCountries.Size = New Size(175, 36)
        lblCountries.TabIndex = 0
        lblCountries.Text = "COUNTRY"
        ' 
        ' lstCountries
        ' 
        lstCountries.BackColor = SystemColors.GradientInactiveCaption
        lstCountries.FormattingEnabled = True
        lstCountries.ItemHeight = 15
        lstCountries.Location = New Point(38, 150)
        lstCountries.Margin = New Padding(3, 2, 3, 2)
        lstCountries.Name = "lstCountries"
        lstCountries.Size = New Size(280, 334)
        lstCountries.TabIndex = 1
        ' 
        ' lblIDC
        ' 
        lblIDC.AutoSize = True
        lblIDC.BackColor = Color.White
        lblIDC.Font = New Font("Yu Gothic", 14.8F, FontStyle.Bold)
        lblIDC.ForeColor = Color.Black
        lblIDC.Location = New Point(438, 118)
        lblIDC.Name = "lblIDC"
        lblIDC.Size = New Size(45, 26)
        lblIDC.TabIndex = 2
        lblIDC.Text = "ID: "
        ' 
        ' lblNameC
        ' 
        lblNameC.AutoSize = True
        lblNameC.Font = New Font("Yu Gothic", 14F, FontStyle.Bold)
        lblNameC.ForeColor = Color.Black
        lblNameC.Location = New Point(438, 166)
        lblNameC.Name = "lblNameC"
        lblNameC.Size = New Size(81, 25)
        lblNameC.TabIndex = 3
        lblNameC.Text = "NAME: "
        ' 
        ' lblPopulationC
        ' 
        lblPopulationC.AutoSize = True
        lblPopulationC.Font = New Font("Yu Gothic", 14F, FontStyle.Bold)
        lblPopulationC.ForeColor = Color.Black
        lblPopulationC.Location = New Point(438, 207)
        lblPopulationC.Name = "lblPopulationC"
        lblPopulationC.Size = New Size(152, 25)
        lblPopulationC.TabIndex = 4
        lblPopulationC.Text = "POPULATION: "
        ' 
        ' txtIDC
        ' 
        txtIDC.BackColor = Color.White
        txtIDC.Font = New Font("Segoe UI", 14F)
        txtIDC.Location = New Point(617, 113)
        txtIDC.Margin = New Padding(3, 2, 3, 2)
        txtIDC.Name = "txtIDC"
        txtIDC.Size = New Size(277, 32)
        txtIDC.TabIndex = 5
        ' 
        ' txtNameC
        ' 
        txtNameC.BackColor = Color.White
        txtNameC.Font = New Font("Segoe UI", 14F)
        txtNameC.Location = New Point(617, 160)
        txtNameC.Margin = New Padding(3, 2, 3, 2)
        txtNameC.Name = "txtNameC"
        txtNameC.Size = New Size(277, 32)
        txtNameC.TabIndex = 6
        ' 
        ' txtPopulationC
        ' 
        txtPopulationC.BackColor = Color.White
        txtPopulationC.Font = New Font("Segoe UI", 14F)
        txtPopulationC.Location = New Point(617, 201)
        txtPopulationC.Margin = New Padding(3, 2, 3, 2)
        txtPopulationC.Name = "txtPopulationC"
        txtPopulationC.Size = New Size(277, 32)
        txtPopulationC.TabIndex = 7
        ' 
        ' pnlSelectOptionC
        ' 
        pnlSelectOptionC.BackColor = Color.Red
        pnlSelectOptionC.Controls.Add(btnClearC)
        pnlSelectOptionC.Controls.Add(btnDeleteC)
        pnlSelectOptionC.Controls.Add(btnUpdateC)
        pnlSelectOptionC.Controls.Add(lblSelectOptionC)
        pnlSelectOptionC.Controls.Add(btnInsertC)
        pnlSelectOptionC.ForeColor = Color.MidnightBlue
        pnlSelectOptionC.Location = New Point(405, 252)
        pnlSelectOptionC.Name = "pnlSelectOptionC"
        pnlSelectOptionC.Size = New Size(488, 231)
        pnlSelectOptionC.TabIndex = 8
        ' 
        ' btnClearC
        ' 
        btnClearC.BackColor = Color.White
        btnClearC.Font = New Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClearC.Location = New Point(251, 36)
        btnClearC.Name = "btnClearC"
        btnClearC.Size = New Size(211, 78)
        btnClearC.TabIndex = 7
        btnClearC.Text = "CLEAR"
        btnClearC.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteC
        ' 
        btnDeleteC.BackColor = Color.White
        btnDeleteC.Font = New Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDeleteC.Location = New Point(20, 120)
        btnDeleteC.Name = "btnDeleteC"
        btnDeleteC.Size = New Size(216, 75)
        btnDeleteC.TabIndex = 6
        btnDeleteC.Text = "DELETE"
        btnDeleteC.UseVisualStyleBackColor = False
        ' 
        ' btnUpdateC
        ' 
        btnUpdateC.BackColor = Color.White
        btnUpdateC.Font = New Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdateC.Location = New Point(251, 120)
        btnUpdateC.Name = "btnUpdateC"
        btnUpdateC.Size = New Size(211, 75)
        btnUpdateC.TabIndex = 5
        btnUpdateC.Text = "UPDATE"
        btnUpdateC.UseVisualStyleBackColor = False
        ' 
        ' lblSelectOptionC
        ' 
        lblSelectOptionC.AutoSize = True
        lblSelectOptionC.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSelectOptionC.ForeColor = SystemColors.ActiveCaptionText
        lblSelectOptionC.Location = New Point(164, 14)
        lblSelectOptionC.Name = "lblSelectOptionC"
        lblSelectOptionC.Size = New Size(147, 20)
        lblSelectOptionC.TabIndex = 4
        lblSelectOptionC.Text = "SELECT AN OPTION"
        ' 
        ' btnInsertC
        ' 
        btnInsertC.BackColor = Color.White
        btnInsertC.Font = New Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnInsertC.Location = New Point(20, 35)
        btnInsertC.Name = "btnInsertC"
        btnInsertC.Size = New Size(216, 79)
        btnInsertC.TabIndex = 0
        btnInsertC.Text = "INSERT"
        btnInsertC.UseVisualStyleBackColor = False
        ' 
        ' txtName
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(960, 539)
        Controls.Add(pnlSelectOptionC)
        Controls.Add(txtPopulationC)
        Controls.Add(txtNameC)
        Controls.Add(txtIDC)
        Controls.Add(lblPopulationC)
        Controls.Add(lblNameC)
        Controls.Add(lblIDC)
        Controls.Add(lstCountries)
        Controls.Add(lblCountries)
        FormBorderStyle = FormBorderStyle.SizableToolWindow
        Name = "txtName"
        Text = "FormCountries"
        pnlSelectOptionC.ResumeLayout(False)
        pnlSelectOptionC.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblCountries As Label
    Friend WithEvents lstCountries As ListBox
    Friend WithEvents lblIDC As Label
    Friend WithEvents lblNameC As Label
    Friend WithEvents lblPopulationC As Label
    Friend WithEvents txtIDC As TextBox
    Friend WithEvents txtNameC As TextBox
    Friend WithEvents txtPopulationC As TextBox
    Friend WithEvents pnlSelectOptionC As Panel
    Friend WithEvents lblSelectOptionC As Label
    Friend WithEvents btnInsertC As Button
    Friend WithEvents btnClearC As Button
    Friend WithEvents btnDeleteC As Button
    Friend WithEvents btnUpdateC As Button
End Class
