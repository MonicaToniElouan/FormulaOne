<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSeasonInformation
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
        lstGPSeason = New ListBox()
        lstTeamsSeason = New ListBox()
        lstDriversSeason = New ListBox()
        lblGPs = New Label()
        lblTeams = New Label()
        lblDrivers = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' lstGPSeason
        ' 
        lstGPSeason.FormattingEnabled = True
        lstGPSeason.ItemHeight = 15
        lstGPSeason.Location = New Point(42, 112)
        lstGPSeason.Name = "lstGPSeason"
        lstGPSeason.Size = New Size(221, 289)
        lstGPSeason.TabIndex = 0
        ' 
        ' lstTeamsSeason
        ' 
        lstTeamsSeason.FormattingEnabled = True
        lstTeamsSeason.ItemHeight = 15
        lstTeamsSeason.Location = New Point(290, 112)
        lstTeamsSeason.Name = "lstTeamsSeason"
        lstTeamsSeason.Size = New Size(221, 289)
        lstTeamsSeason.TabIndex = 1
        ' 
        ' lstDriversSeason
        ' 
        lstDriversSeason.FormattingEnabled = True
        lstDriversSeason.ItemHeight = 15
        lstDriversSeason.Location = New Point(541, 112)
        lstDriversSeason.Name = "lstDriversSeason"
        lstDriversSeason.Size = New Size(221, 289)
        lstDriversSeason.TabIndex = 2
        ' 
        ' lblGPs
        ' 
        lblGPs.AutoSize = True
        lblGPs.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblGPs.Location = New Point(85, 66)
        lblGPs.Name = "lblGPs"
        lblGPs.Size = New Size(123, 32)
        lblGPs.TabIndex = 3
        lblGPs.Text = "Grand Prix"
        ' 
        ' lblTeams
        ' 
        lblTeams.AutoSize = True
        lblTeams.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTeams.Location = New Point(352, 66)
        lblTeams.Name = "lblTeams"
        lblTeams.Size = New Size(81, 32)
        lblTeams.TabIndex = 4
        lblTeams.Text = "Teams"
        ' 
        ' lblDrivers
        ' 
        lblDrivers.AutoSize = True
        lblDrivers.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDrivers.Location = New Point(604, 66)
        lblDrivers.Name = "lblDrivers"
        lblDrivers.Size = New Size(88, 32)
        lblDrivers.TabIndex = 5
        lblDrivers.Text = "Drivers"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(256, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(281, 30)
        Label1.TabIndex = 6
        Label1.Text = "Generating races and results..."
        ' 
        ' FormSeasonInformation
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(lblDrivers)
        Controls.Add(lblTeams)
        Controls.Add(lblGPs)
        Controls.Add(lstDriversSeason)
        Controls.Add(lstTeamsSeason)
        Controls.Add(lstGPSeason)
        Name = "FormSeasonInformation"
        Text = "SeasonInformation"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lstGPSeason As ListBox
    Friend WithEvents lstTeamsSeason As ListBox
    Friend WithEvents lstDriversSeason As ListBox
    Friend WithEvents lblGPs As Label
    Friend WithEvents lblTeams As Label
    Friend WithEvents lblDrivers As Label
    Friend WithEvents Label1 As Label
End Class
