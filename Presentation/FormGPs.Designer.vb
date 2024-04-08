<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGPs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormGPs))
        lblGPs = New Label()
        lstGP = New ListBox()
        pnlSelectOptionGP = New Panel()
        btnClearGP = New Button()
        btnDeleteGP = New Button()
        btnUpdateGP = New Button()
        lblSelectOptionC = New Label()
        btnInsertGP = New Button()
        lblIDGP = New Label()
        lblNameGP = New Label()
        lblCountryGP = New Label()
        txtIDGP = New TextBox()
        txtNameGP = New TextBox()
        txtCountryGP = New TextBox()
        pnlSelectOptionGP.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblGPs
        ' 
        lblGPs.AutoSize = True
        lblGPs.BackColor = SystemColors.Window
        lblGPs.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGPs.ForeColor = Color.IndianRed
        lblGPs.Location = New Point(151, 31)
        lblGPs.Name = "lblGPs"
        lblGPs.Size = New Size(76, 45)
        lblGPs.TabIndex = 3
        lblGPs.Text = "GP"
        ' 
        ' lstGP
        ' 
        lstGP.BackColor = SystemColors.Menu
        lstGP.FormattingEnabled = True
        lstGP.Location = New Point(29, 88)
        lstGP.Name = "lstGP"
        lstGP.Size = New Size(320, 504)
        lstGP.TabIndex = 13
        ' 
        ' pnlSelectOptionGP
        ' 
        pnlSelectOptionGP.BackColor = Color.MistyRose
        pnlSelectOptionGP.Controls.Add(btnClearGP)
        pnlSelectOptionGP.Controls.Add(btnDeleteGP)
        pnlSelectOptionGP.Controls.Add(btnUpdateGP)
        pnlSelectOptionGP.Controls.Add(lblSelectOptionC)
        pnlSelectOptionGP.Controls.Add(btnInsertGP)
        pnlSelectOptionGP.ForeColor = Color.IndianRed
        pnlSelectOptionGP.Location = New Point(388, 284)
        pnlSelectOptionGP.Margin = New Padding(3, 4, 3, 4)
        pnlSelectOptionGP.Name = "pnlSelectOptionGP"
        pnlSelectOptionGP.Size = New Size(558, 308)
        pnlSelectOptionGP.TabIndex = 14
        ' 
        ' btnClearGP
        ' 
        btnClearGP.BackColor = SystemColors.Menu
        btnClearGP.Font = New Font("Ubuntu Condensed", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClearGP.ForeColor = Color.IndianRed
        btnClearGP.Location = New Point(287, 48)
        btnClearGP.Margin = New Padding(3, 4, 3, 4)
        btnClearGP.Name = "btnClearGP"
        btnClearGP.Size = New Size(241, 104)
        btnClearGP.TabIndex = 7
        btnClearGP.Text = "CLEAR"
        btnClearGP.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteGP
        ' 
        btnDeleteGP.BackColor = SystemColors.Menu
        btnDeleteGP.Font = New Font("Ubuntu Condensed", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDeleteGP.Location = New Point(23, 160)
        btnDeleteGP.Margin = New Padding(3, 4, 3, 4)
        btnDeleteGP.Name = "btnDeleteGP"
        btnDeleteGP.Size = New Size(247, 100)
        btnDeleteGP.TabIndex = 6
        btnDeleteGP.Text = "DELETE"
        btnDeleteGP.UseVisualStyleBackColor = False
        ' 
        ' btnUpdateGP
        ' 
        btnUpdateGP.BackColor = SystemColors.Menu
        btnUpdateGP.Font = New Font("Ubuntu Condensed", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdateGP.Location = New Point(287, 160)
        btnUpdateGP.Margin = New Padding(3, 4, 3, 4)
        btnUpdateGP.Name = "btnUpdateGP"
        btnUpdateGP.Size = New Size(241, 100)
        btnUpdateGP.TabIndex = 5
        btnUpdateGP.Text = "UPDATE"
        btnUpdateGP.UseVisualStyleBackColor = False
        ' 
        ' lblSelectOptionC
        ' 
        lblSelectOptionC.AutoSize = True
        lblSelectOptionC.BackColor = Color.MistyRose
        lblSelectOptionC.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSelectOptionC.ForeColor = Color.Black
        lblSelectOptionC.Location = New Point(189, 18)
        lblSelectOptionC.Name = "lblSelectOptionC"
        lblSelectOptionC.Size = New Size(180, 25)
        lblSelectOptionC.TabIndex = 4
        lblSelectOptionC.Text = "SELECT AN OPTION"
        ' 
        ' btnInsertGP
        ' 
        btnInsertGP.BackColor = SystemColors.Menu
        btnInsertGP.Font = New Font("Ubuntu Condensed", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnInsertGP.Location = New Point(23, 47)
        btnInsertGP.Margin = New Padding(3, 4, 3, 4)
        btnInsertGP.Name = "btnInsertGP"
        btnInsertGP.Size = New Size(247, 105)
        btnInsertGP.TabIndex = 0
        btnInsertGP.Text = "INSERT"
        btnInsertGP.UseVisualStyleBackColor = False
        ' 
        ' lblIDGP
        ' 
        lblIDGP.AutoSize = True
        lblIDGP.BackColor = Color.Black
        lblIDGP.Font = New Font("Yu Gothic", 14.8F, FontStyle.Bold)
        lblIDGP.ForeColor = Color.Transparent
        lblIDGP.Location = New Point(388, 88)
        lblIDGP.Name = "lblIDGP"
        lblIDGP.Size = New Size(56, 32)
        lblIDGP.TabIndex = 15
        lblIDGP.Text = "ID: "
        ' 
        ' lblNameGP
        ' 
        lblNameGP.AutoSize = True
        lblNameGP.BackColor = Color.Black
        lblNameGP.Font = New Font("Yu Gothic", 14.8F, FontStyle.Bold)
        lblNameGP.ForeColor = Color.Transparent
        lblNameGP.Location = New Point(388, 155)
        lblNameGP.Name = "lblNameGP"
        lblNameGP.Size = New Size(99, 32)
        lblNameGP.TabIndex = 16
        lblNameGP.Text = "NAME:"
        ' 
        ' lblCountryGP
        ' 
        lblCountryGP.AutoSize = True
        lblCountryGP.BackColor = Color.Black
        lblCountryGP.Font = New Font("Yu Gothic", 14.8F, FontStyle.Bold)
        lblCountryGP.ForeColor = Color.Transparent
        lblCountryGP.Location = New Point(388, 224)
        lblCountryGP.Name = "lblCountryGP"
        lblCountryGP.Size = New Size(153, 32)
        lblCountryGP.TabIndex = 17
        lblCountryGP.Text = "COUNTRY: "
        ' 
        ' txtIDGP
        ' 
        txtIDGP.BackColor = Color.White
        txtIDGP.Font = New Font("Segoe UI", 14F)
        txtIDGP.Location = New Point(552, 81)
        txtIDGP.Name = "txtIDGP"
        txtIDGP.Size = New Size(394, 39)
        txtIDGP.TabIndex = 18
        ' 
        ' txtNameGP
        ' 
        txtNameGP.BackColor = Color.White
        txtNameGP.Font = New Font("Segoe UI", 14F)
        txtNameGP.Location = New Point(552, 148)
        txtNameGP.Name = "txtNameGP"
        txtNameGP.Size = New Size(394, 39)
        txtNameGP.TabIndex = 19
        ' 
        ' txtCountryGP
        ' 
        txtCountryGP.BackColor = Color.White
        txtCountryGP.Font = New Font("Segoe UI", 14F)
        txtCountryGP.Location = New Point(552, 217)
        txtCountryGP.Name = "txtCountryGP"
        txtCountryGP.Size = New Size(394, 39)
        txtCountryGP.TabIndex = 20
        ' 
        ' FormGPs
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(958, 613)
        Controls.Add(txtCountryGP)
        Controls.Add(txtNameGP)
        Controls.Add(txtIDGP)
        Controls.Add(lblCountryGP)
        Controls.Add(lblNameGP)
        Controls.Add(lblIDGP)
        Controls.Add(pnlSelectOptionGP)
        Controls.Add(lstGP)
        Controls.Add(lblGPs)
        Name = "FormGPs"
        Text = "FormGPs"
        pnlSelectOptionGP.ResumeLayout(False)
        pnlSelectOptionGP.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblGPs As Label
    Friend WithEvents lstGP As ListBox
    Friend WithEvents pnlSelectOptionGP As Panel
    Friend WithEvents btnClearGP As Button
    Friend WithEvents btnDeleteGP As Button
    Friend WithEvents btnUpdateGP As Button
    Friend WithEvents lblSelectOptionC As Label
    Friend WithEvents btnInsertGP As Button
    Friend WithEvents lblIDGP As Label
    Friend WithEvents lblNameGP As Label
    Friend WithEvents lblCountryGP As Label
    Friend WithEvents txtIDGP As TextBox
    Friend WithEvents txtNameGP As TextBox
    Friend WithEvents txtCountryGP As TextBox
End Class
