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
        lblID = New Label()
        lblName = New Label()
        lblPopulation = New Label()
        txtID = New TextBox()
        TextBox2 = New TextBox()
        txtPopulation = New TextBox()
        pnlModifyData = New Panel()
        btnClearC = New Button()
        btnDeleteC = New Button()
        btnUpdateC = New Button()
        lblSelectOptionC = New Label()
        btnInsertC = New Button()
        pnlModifyData.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblCountries
        ' 
        lblCountries.AutoSize = True
        lblCountries.BackColor = SystemColors.Window
        lblCountries.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCountries.ForeColor = SystemColors.ActiveCaptionText
        lblCountries.Location = New Point(43, 144)
        lblCountries.Name = "lblCountries"
        lblCountries.Size = New Size(150, 25)
        lblCountries.TabIndex = 0
        lblCountries.Text = "COUNTRIES"
        ' 
        ' lstCountries
        ' 
        lstCountries.BackColor = SystemColors.GradientInactiveCaption
        lstCountries.FormattingEnabled = True
        lstCountries.Location = New Point(43, 187)
        lstCountries.Name = "lstCountries"
        lstCountries.Size = New Size(320, 444)
        lstCountries.TabIndex = 1
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.BackColor = Color.White
        lblID.Font = New Font("Yu Gothic", 14.8F, FontStyle.Bold)
        lblID.ForeColor = Color.Black
        lblID.Location = New Point(500, 158)
        lblID.Name = "lblID"
        lblID.Size = New Size(56, 32)
        lblID.TabIndex = 2
        lblID.Text = "ID: "
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Yu Gothic", 14F, FontStyle.Bold)
        lblName.ForeColor = Color.Black
        lblName.Location = New Point(500, 222)
        lblName.Name = "lblName"
        lblName.Size = New Size(102, 31)
        lblName.TabIndex = 3
        lblName.Text = "NAME: "
        ' 
        ' lblPopulation
        ' 
        lblPopulation.AutoSize = True
        lblPopulation.Font = New Font("Yu Gothic", 14F, FontStyle.Bold)
        lblPopulation.ForeColor = Color.Black
        lblPopulation.Location = New Point(500, 276)
        lblPopulation.Name = "lblPopulation"
        lblPopulation.Size = New Size(190, 31)
        lblPopulation.TabIndex = 4
        lblPopulation.Text = "POPULATION: "
        ' 
        ' txtID
        ' 
        txtID.BackColor = Color.White
        txtID.Font = New Font("Segoe UI", 14F)
        txtID.Location = New Point(705, 151)
        txtID.Name = "txtID"
        txtID.Size = New Size(216, 39)
        txtID.TabIndex = 5
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.White
        TextBox2.Font = New Font("Segoe UI", 14F)
        TextBox2.Location = New Point(705, 214)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(216, 39)
        TextBox2.TabIndex = 6
        ' 
        ' txtPopulation
        ' 
        txtPopulation.BackColor = Color.White
        txtPopulation.Font = New Font("Segoe UI", 14F)
        txtPopulation.Location = New Point(705, 268)
        txtPopulation.Name = "txtPopulation"
        txtPopulation.Size = New Size(216, 39)
        txtPopulation.TabIndex = 7
        ' 
        ' pnlModifyData
        ' 
        pnlModifyData.BackColor = Color.Red
        pnlModifyData.Controls.Add(btnClearC)
        pnlModifyData.Controls.Add(btnDeleteC)
        pnlModifyData.Controls.Add(btnUpdateC)
        pnlModifyData.Controls.Add(lblSelectOptionC)
        pnlModifyData.Controls.Add(btnInsertC)
        pnlModifyData.ForeColor = Color.MidnightBlue
        pnlModifyData.Location = New Point(463, 336)
        pnlModifyData.Margin = New Padding(3, 4, 3, 4)
        pnlModifyData.Name = "pnlModifyData"
        pnlModifyData.Size = New Size(558, 308)
        pnlModifyData.TabIndex = 8
        ' 
        ' btnClearC
        ' 
        btnClearC.BackColor = Color.White
        btnClearC.Font = New Font("Ubuntu Condensed", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClearC.Location = New Point(287, 48)
        btnClearC.Margin = New Padding(3, 4, 3, 4)
        btnClearC.Name = "btnClearC"
        btnClearC.Size = New Size(241, 104)
        btnClearC.TabIndex = 7
        btnClearC.Text = "CLEAR"
        btnClearC.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteC
        ' 
        btnDeleteC.BackColor = Color.White
        btnDeleteC.Font = New Font("Ubuntu Condensed", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDeleteC.Location = New Point(23, 160)
        btnDeleteC.Margin = New Padding(3, 4, 3, 4)
        btnDeleteC.Name = "btnDeleteC"
        btnDeleteC.Size = New Size(247, 100)
        btnDeleteC.TabIndex = 6
        btnDeleteC.Text = "DELETE"
        btnDeleteC.UseVisualStyleBackColor = False
        ' 
        ' btnUpdateC
        ' 
        btnUpdateC.BackColor = Color.White
        btnUpdateC.Font = New Font("Ubuntu Condensed", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdateC.Location = New Point(287, 160)
        btnUpdateC.Margin = New Padding(3, 4, 3, 4)
        btnUpdateC.Name = "btnUpdateC"
        btnUpdateC.Size = New Size(241, 100)
        btnUpdateC.TabIndex = 5
        btnUpdateC.Text = "UPDATE"
        btnUpdateC.UseVisualStyleBackColor = False
        ' 
        ' lblSelectOptionC
        ' 
        lblSelectOptionC.AutoSize = True
        lblSelectOptionC.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSelectOptionC.ForeColor = SystemColors.ActiveCaptionText
        lblSelectOptionC.Location = New Point(188, 18)
        lblSelectOptionC.Name = "lblSelectOptionC"
        lblSelectOptionC.Size = New Size(180, 25)
        lblSelectOptionC.TabIndex = 4
        lblSelectOptionC.Text = "SELECT AN OPTION"
        ' 
        ' btnInsertC
        ' 
        btnInsertC.BackColor = Color.White
        btnInsertC.Font = New Font("Ubuntu Condensed", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnInsertC.Location = New Point(23, 47)
        btnInsertC.Margin = New Padding(3, 4, 3, 4)
        btnInsertC.Name = "btnInsertC"
        btnInsertC.Size = New Size(247, 105)
        btnInsertC.TabIndex = 0
        btnInsertC.Text = "INSERT"
        btnInsertC.UseVisualStyleBackColor = False
        ' 
        ' txtName
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1097, 719)
        Controls.Add(pnlModifyData)
        Controls.Add(txtPopulation)
        Controls.Add(TextBox2)
        Controls.Add(txtID)
        Controls.Add(lblPopulation)
        Controls.Add(lblName)
        Controls.Add(lblID)
        Controls.Add(lstCountries)
        Controls.Add(lblCountries)
        FormBorderStyle = FormBorderStyle.SizableToolWindow
        Margin = New Padding(3, 4, 3, 4)
        Name = "txtName"
        Text = "FormCountries"
        pnlModifyData.ResumeLayout(False)
        pnlModifyData.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblCountries As Label
    Friend WithEvents lstCountries As ListBox
    Friend WithEvents lblID As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblPopulation As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents txtPopulation As TextBox
    Friend WithEvents pnlModifyData As Panel
    Friend WithEvents lblSelectOptionC As Label
    Friend WithEvents btnInsertC As Button
    Friend WithEvents btnClearC As Button
    Friend WithEvents btnDeleteC As Button
    Friend WithEvents btnUpdateC As Button
End Class
