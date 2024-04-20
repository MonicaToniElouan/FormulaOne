<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSeason
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
        Label1 = New Label()
        cmbYear = New ComboBox()
        Label2 = New Label()
        btnGenInfo = New Button()
        Label3 = New Label()
        nudMinTeams = New NumericUpDown()
        nudMaxTeams = New NumericUpDown()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        nudGPs = New NumericUpDown()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        btnReset = New Button()
        CType(nudMinTeams, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudMaxTeams, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudGPs, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(244, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(314, 45)
        Label1.TabIndex = 0
        Label1.Text = "Season Information"
        ' 
        ' cmbYear
        ' 
        cmbYear.DropDownStyle = ComboBoxStyle.DropDownList
        cmbYear.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbYear.FormattingEnabled = True
        cmbYear.Location = New Point(273, 115)
        cmbYear.Name = "cmbYear"
        cmbYear.Size = New Size(244, 33)
        cmbYear.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(55, 118)
        Label2.Name = "Label2"
        Label2.Size = New Size(135, 25)
        Label2.TabIndex = 2
        Label2.Text = "Select the year"
        ' 
        ' btnGenInfo
        ' 
        btnGenInfo.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnGenInfo.Location = New Point(173, 304)
        btnGenInfo.Name = "btnGenInfo"
        btnGenInfo.Size = New Size(289, 60)
        btnGenInfo.TabIndex = 3
        btnGenInfo.Text = "Generate Information"
        btnGenInfo.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(55, 172)
        Label3.Name = "Label3"
        Label3.Size = New Size(158, 25)
        Label3.TabIndex = 4
        Label3.Text = "Number of teams"
        ' 
        ' nudMinTeams
        ' 
        nudMinTeams.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        nudMinTeams.Location = New Point(284, 174)
        nudMinTeams.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        nudMinTeams.Minimum = New Decimal(New Integer() {4, 0, 0, 0})
        nudMinTeams.Name = "nudMinTeams"
        nudMinTeams.Size = New Size(62, 29)
        nudMinTeams.TabIndex = 5
        nudMinTeams.Value = New Decimal(New Integer() {4, 0, 0, 0})
        ' 
        ' nudMaxTeams
        ' 
        nudMaxTeams.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        nudMaxTeams.Location = New Point(424, 175)
        nudMaxTeams.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        nudMaxTeams.Minimum = New Decimal(New Integer() {4, 0, 0, 0})
        nudMaxTeams.Name = "nudMaxTeams"
        nudMaxTeams.Size = New Size(62, 29)
        nudMaxTeams.TabIndex = 6
        nudMaxTeams.Value = New Decimal(New Integer() {4, 0, 0, 0})
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(379, 177)
        Label4.Name = "Label4"
        Label4.Size = New Size(39, 21)
        Label4.TabIndex = 7
        Label4.Text = "Max"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(241, 177)
        Label5.Name = "Label5"
        Label5.Size = New Size(37, 21)
        Label5.TabIndex = 8
        Label5.Text = "Min"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(55, 223)
        Label6.Name = "Label6"
        Label6.Size = New Size(140, 25)
        Label6.TabIndex = 9
        Label6.Text = "Number of GPs"
        ' 
        ' nudGPs
        ' 
        nudGPs.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        nudGPs.Location = New Point(284, 224)
        nudGPs.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        nudGPs.Minimum = New Decimal(New Integer() {9, 0, 0, 0})
        nudGPs.Name = "nudGPs"
        nudGPs.Size = New Size(62, 29)
        nudGPs.TabIndex = 10
        nudGPs.Value = New Decimal(New Integer() {9, 0, 0, 0})
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(492, 188)
        Label7.Name = "Label7"
        Label7.Size = New Size(288, 15)
        Label7.TabIndex = 11
        Label7.Text = "If not touched, the values will be randomly generated"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(352, 238)
        Label8.Name = "Label8"
        Label8.Size = New Size(283, 15)
        Label8.TabIndex = 12
        Label8.Text = "If not touched, the value will be randomly generated"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(539, 126)
        Label9.Name = "Label9"
        Label9.Size = New Size(91, 15)
        Label9.TabIndex = 13
        Label9.Text = "Mandatory field"
        ' 
        ' btnReset
        ' 
        btnReset.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnReset.Location = New Point(539, 324)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(120, 26)
        btnReset.TabIndex = 14
        btnReset.Text = "Reset Values"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' FormSeason
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnReset)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(nudGPs)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(nudMaxTeams)
        Controls.Add(nudMinTeams)
        Controls.Add(Label3)
        Controls.Add(btnGenInfo)
        Controls.Add(Label2)
        Controls.Add(cmbYear)
        Controls.Add(Label1)
        Name = "FormSeason"
        Text = "FormSeason"
        CType(nudMinTeams, ComponentModel.ISupportInitialize).EndInit()
        CType(nudMaxTeams, ComponentModel.ISupportInitialize).EndInit()
        CType(nudGPs, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnGenInfo As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents nudMinTeams As NumericUpDown
    Friend WithEvents nudMaxTeams As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents nudGPs As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnReset As Button
End Class
