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
        lblCountries = New Label()
        SuspendLayout()
        ' 
        ' lblCountries
        ' 
        lblCountries.AutoSize = True
        lblCountries.BackColor = SystemColors.Window
        lblCountries.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCountries.ForeColor = SystemColors.ActiveCaptionText
        lblCountries.Location = New Point(43, 133)
        lblCountries.Name = "lblCountries"
        lblCountries.Size = New Size(150, 25)
        lblCountries.TabIndex = 1
        lblCountries.Text = "COUNTRIES"
        ' 
        ' FormDrivers
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(973, 670)
        Controls.Add(lblCountries)
        Name = "FormDrivers"
        Text = "FormDrivers"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblCountries As Label
End Class
