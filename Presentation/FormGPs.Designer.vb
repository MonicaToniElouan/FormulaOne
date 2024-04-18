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
        cmbG = New ComboBox()
        pnlSelectOptionGP.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblGPs
        ' 
        lblGPs.AutoSize = True
        lblGPs.BackColor = SystemColors.Window
        lblGPs.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGPs.ForeColor = Color.IndianRed
        lblGPs.Location = New Point(132, 23)
        lblGPs.Name = "lblGPs"
        lblGPs.Size = New Size(59, 36)
        lblGPs.TabIndex = 3
        lblGPs.Text = "GP"
        ' 
        ' lstGP
        ' 
        lstGP.BackColor = SystemColors.Menu
        lstGP.FormattingEnabled = True
        lstGP.ItemHeight = 15
        lstGP.Location = New Point(25, 66)
        lstGP.Margin = New Padding(3, 2, 3, 2)
        lstGP.Name = "lstGP"
        lstGP.Size = New Size(280, 379)
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
        pnlSelectOptionGP.Location = New Point(340, 213)
        pnlSelectOptionGP.Name = "pnlSelectOptionGP"
        pnlSelectOptionGP.Size = New Size(488, 231)
        pnlSelectOptionGP.TabIndex = 14
        ' 
        ' btnClearGP
        ' 
        btnClearGP.BackColor = SystemColors.Menu
        btnClearGP.Font = New Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClearGP.ForeColor = Color.IndianRed
        btnClearGP.Location = New Point(251, 36)
        btnClearGP.Name = "btnClearGP"
        btnClearGP.Size = New Size(211, 78)
        btnClearGP.TabIndex = 7
        btnClearGP.Text = "CLEAR"
        btnClearGP.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteGP
        ' 
        btnDeleteGP.BackColor = SystemColors.Menu
        btnDeleteGP.Font = New Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDeleteGP.Location = New Point(20, 120)
        btnDeleteGP.Name = "btnDeleteGP"
        btnDeleteGP.Size = New Size(216, 75)
        btnDeleteGP.TabIndex = 6
        btnDeleteGP.Text = "DELETE"
        btnDeleteGP.UseVisualStyleBackColor = False
        ' 
        ' btnUpdateGP
        ' 
        btnUpdateGP.BackColor = SystemColors.Menu
        btnUpdateGP.Font = New Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdateGP.Location = New Point(251, 120)
        btnUpdateGP.Name = "btnUpdateGP"
        btnUpdateGP.Size = New Size(211, 75)
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
        lblSelectOptionC.Location = New Point(165, 14)
        lblSelectOptionC.Name = "lblSelectOptionC"
        lblSelectOptionC.Size = New Size(147, 20)
        lblSelectOptionC.TabIndex = 4
        lblSelectOptionC.Text = "SELECT AN OPTION"
        ' 
        ' btnInsertGP
        ' 
        btnInsertGP.BackColor = SystemColors.Menu
        btnInsertGP.Font = New Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnInsertGP.Location = New Point(20, 35)
        btnInsertGP.Name = "btnInsertGP"
        btnInsertGP.Size = New Size(216, 79)
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
        lblIDGP.Location = New Point(340, 66)
        lblIDGP.Name = "lblIDGP"
        lblIDGP.Size = New Size(45, 26)
        lblIDGP.TabIndex = 15
        lblIDGP.Text = "ID: "
        ' 
        ' lblNameGP
        ' 
        lblNameGP.AutoSize = True
        lblNameGP.BackColor = Color.Black
        lblNameGP.Font = New Font("Yu Gothic", 14.8F, FontStyle.Bold)
        lblNameGP.ForeColor = Color.Transparent
        lblNameGP.Location = New Point(340, 116)
        lblNameGP.Name = "lblNameGP"
        lblNameGP.Size = New Size(80, 26)
        lblNameGP.TabIndex = 16
        lblNameGP.Text = "NAME:"
        ' 
        ' lblCountryGP
        ' 
        lblCountryGP.AutoSize = True
        lblCountryGP.BackColor = Color.Black
        lblCountryGP.Font = New Font("Yu Gothic", 14.8F, FontStyle.Bold)
        lblCountryGP.ForeColor = Color.Transparent
        lblCountryGP.Location = New Point(340, 168)
        lblCountryGP.Name = "lblCountryGP"
        lblCountryGP.Size = New Size(124, 26)
        lblCountryGP.TabIndex = 17
        lblCountryGP.Text = "COUNTRY: "
        ' 
        ' txtIDGP
        ' 
        txtIDGP.BackColor = Color.White
        txtIDGP.Font = New Font("Segoe UI", 14F)
        txtIDGP.Location = New Point(483, 61)
        txtIDGP.Margin = New Padding(3, 2, 3, 2)
        txtIDGP.Name = "txtIDGP"
        txtIDGP.Size = New Size(345, 32)
        txtIDGP.TabIndex = 18
        ' 
        ' txtNameGP
        ' 
        txtNameGP.BackColor = Color.White
        txtNameGP.Font = New Font("Segoe UI", 14F)
        txtNameGP.Location = New Point(483, 111)
        txtNameGP.Margin = New Padding(3, 2, 3, 2)
        txtNameGP.Name = "txtNameGP"
        txtNameGP.Size = New Size(345, 32)
        txtNameGP.TabIndex = 19
        ' 
        ' cmbG
        ' 
        cmbG.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbG.FormattingEnabled = True
        cmbG.Location = New Point(483, 161)
        cmbG.Name = "cmbG"
        cmbG.Size = New Size(345, 33)
        cmbG.TabIndex = 20
        ' 
        ' FormGPs
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(838, 460)
        Controls.Add(cmbG)
        Controls.Add(txtNameGP)
        Controls.Add(txtIDGP)
        Controls.Add(lblCountryGP)
        Controls.Add(lblNameGP)
        Controls.Add(lblIDGP)
        Controls.Add(pnlSelectOptionGP)
        Controls.Add(lstGP)
        Controls.Add(lblGPs)
        Margin = New Padding(3, 2, 3, 2)
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
    Friend WithEvents cmbG As ComboBox
End Class
