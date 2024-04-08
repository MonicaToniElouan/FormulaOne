<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        pnlModifyData = New Panel()
        btnGPs = New Button()
        btnDrivers = New Button()
        btnTeams = New Button()
        btnCountries = New Button()
        lblWelcome = New Label()
        lblResultConnection = New Label()
        pnlConn = New Panel()
        pnlModifyData.SuspendLayout()
        pnlConn.SuspendLayout()
        SuspendLayout()
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CacheAge = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.EnableCaching = False
        MySqlCommand1.Transaction = Nothing
        ' 
        ' pnlModifyData
        ' 
        pnlModifyData.BackColor = Color.Black
        pnlModifyData.Controls.Add(btnGPs)
        pnlModifyData.Controls.Add(btnDrivers)
        pnlModifyData.Controls.Add(btnTeams)
        pnlModifyData.Controls.Add(btnCountries)
        pnlModifyData.Font = New Font("Stencil", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        pnlModifyData.ForeColor = Color.Red
        pnlModifyData.Location = New Point(0, 392)
        pnlModifyData.Margin = New Padding(3, 4, 3, 4)
        pnlModifyData.Name = "pnlModifyData"
        pnlModifyData.Size = New Size(889, 97)
        pnlModifyData.TabIndex = 6
        ' 
        ' btnGPs
        ' 
        btnGPs.Location = New Point(12, 16)
        btnGPs.Margin = New Padding(3, 4, 3, 4)
        btnGPs.Name = "btnGPs"
        btnGPs.Size = New Size(195, 67)
        btnGPs.TabIndex = 3
        btnGPs.Text = "GPs"
        btnGPs.UseVisualStyleBackColor = True
        ' 
        ' btnDrivers
        ' 
        btnDrivers.Location = New Point(452, 16)
        btnDrivers.Margin = New Padding(3, 4, 3, 4)
        btnDrivers.Name = "btnDrivers"
        btnDrivers.Size = New Size(195, 67)
        btnDrivers.TabIndex = 2
        btnDrivers.Text = "Drivers"
        btnDrivers.UseVisualStyleBackColor = True
        ' 
        ' btnTeams
        ' 
        btnTeams.Location = New Point(672, 16)
        btnTeams.Margin = New Padding(3, 4, 3, 4)
        btnTeams.Name = "btnTeams"
        btnTeams.Size = New Size(195, 67)
        btnTeams.TabIndex = 1
        btnTeams.Text = "Teams"
        btnTeams.UseVisualStyleBackColor = True
        ' 
        ' btnCountries
        ' 
        btnCountries.Location = New Point(235, 16)
        btnCountries.Margin = New Padding(3, 4, 3, 4)
        btnCountries.Name = "btnCountries"
        btnCountries.Size = New Size(195, 67)
        btnCountries.TabIndex = 0
        btnCountries.Text = "Countries"
        btnCountries.UseVisualStyleBackColor = True
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.BackColor = Color.Red
        lblWelcome.BorderStyle = BorderStyle.FixedSingle
        lblWelcome.Font = New Font("Sitka Banner", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblWelcome.ForeColor = Color.Transparent
        lblWelcome.Location = New Point(177, -14)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(549, 89)
        lblWelcome.TabIndex = 0
        lblWelcome.Text = "Formula One System"
        lblWelcome.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblResultConnection
        ' 
        lblResultConnection.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblResultConnection.AutoSize = True
        lblResultConnection.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblResultConnection.Location = New Point(339, 16)
        lblResultConnection.Name = "lblResultConnection"
        lblResultConnection.Size = New Size(87, 25)
        lblResultConnection.TabIndex = 3
        lblResultConnection.Text = "Message"
        lblResultConnection.TextAlign = ContentAlignment.MiddleCenter
        lblResultConnection.Visible = False
        ' 
        ' pnlConn
        ' 
        pnlConn.Controls.Add(lblResultConnection)
        pnlConn.Location = New Point(71, 120)
        pnlConn.Margin = New Padding(3, 4, 3, 4)
        pnlConn.Name = "pnlConn"
        pnlConn.Size = New Size(773, 57)
        pnlConn.TabIndex = 4
        ' 
        ' FormMain
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(879, 488)
        Controls.Add(pnlModifyData)
        Controls.Add(pnlConn)
        Controls.Add(lblWelcome)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormMain"
        Text = "Form1"
        pnlModifyData.ResumeLayout(False)
        pnlConn.ResumeLayout(False)
        pnlConn.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents pnlModifyData As Panel
    Friend WithEvents btnGPs As Button
    Friend WithEvents btnDrivers As Button
    Friend WithEvents btnTeams As Button
    Friend WithEvents btnCountries As Button
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblResultConnection As Label
    Friend WithEvents pnlConn As Panel

End Class
