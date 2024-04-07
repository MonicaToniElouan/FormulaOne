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
        lblWelcome = New Label()
        btnConnect = New Button()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        lblConnect = New Label()
        lblResultConnection = New Label()
        pnlConn = New Panel()
        pnlSeason = New Panel()
        pnlModifyData = New Panel()
        btnCountries = New Button()
        btnTeams = New Button()
        btnDrivers = New Button()
        btnGPs = New Button()
        Label1 = New Label()
        pnlConn.SuspendLayout()
        pnlModifyData.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lblWelcome.Location = New Point(120, 33)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(571, 47)
        lblWelcome.TabIndex = 0
        lblWelcome.Text = "Welcome To Formula One System"
        lblWelcome.TextAlign = ContentAlignment.TopCenter
        ' 
        ' btnConnect
        ' 
        btnConnect.Anchor = AnchorStyles.None
        btnConnect.FlatStyle = FlatStyle.System
        btnConnect.ForeColor = SystemColors.ActiveCaptionText
        btnConnect.Location = New Point(255, 58)
        btnConnect.Name = "btnConnect"
        btnConnect.Size = New Size(180, 47)
        btnConnect.TabIndex = 1
        btnConnect.Text = "Connect DataBase"
        btnConnect.UseVisualStyleBackColor = True
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CacheAge = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.EnableCaching = False
        MySqlCommand1.Transaction = Nothing
        ' 
        ' lblConnect
        ' 
        lblConnect.AutoSize = True
        lblConnect.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblConnect.Location = New Point(155, 10)
        lblConnect.Name = "lblConnect"
        lblConnect.Size = New Size(399, 21)
        lblConnect.TabIndex = 2
        lblConnect.Text = "To use the application you need to connect the data base"
        ' 
        ' lblResultConnection
        ' 
        lblResultConnection.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblResultConnection.AutoSize = True
        lblResultConnection.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblResultConnection.Location = New Point(312, 132)
        lblResultConnection.Name = "lblResultConnection"
        lblResultConnection.Size = New Size(68, 20)
        lblResultConnection.TabIndex = 3
        lblResultConnection.Text = "Message"
        lblResultConnection.TextAlign = ContentAlignment.MiddleCenter
        lblResultConnection.Visible = False
        ' 
        ' pnlConn
        ' 
        pnlConn.Controls.Add(lblResultConnection)
        pnlConn.Controls.Add(lblConnect)
        pnlConn.Controls.Add(btnConnect)
        pnlConn.Location = New Point(62, 90)
        pnlConn.Name = "pnlConn"
        pnlConn.Size = New Size(676, 161)
        pnlConn.TabIndex = 4
        ' 
        ' pnlSeason
        ' 
        pnlSeason.Location = New Point(62, 274)
        pnlSeason.Name = "pnlSeason"
        pnlSeason.Size = New Size(322, 155)
        pnlSeason.TabIndex = 5
        ' 
        ' pnlModifyData
        ' 
        pnlModifyData.Controls.Add(Label1)
        pnlModifyData.Controls.Add(btnGPs)
        pnlModifyData.Controls.Add(btnDrivers)
        pnlModifyData.Controls.Add(btnTeams)
        pnlModifyData.Controls.Add(btnCountries)
        pnlModifyData.Location = New Point(418, 274)
        pnlModifyData.Name = "pnlModifyData"
        pnlModifyData.Size = New Size(320, 155)
        pnlModifyData.TabIndex = 6
        ' 
        ' btnCountries
        ' 
        btnCountries.Location = New Point(39, 42)
        btnCountries.Name = "btnCountries"
        btnCountries.Size = New Size(115, 50)
        btnCountries.TabIndex = 0
        btnCountries.Text = "Countries"
        btnCountries.UseVisualStyleBackColor = True
        ' 
        ' btnTeams
        ' 
        btnTeams.Location = New Point(158, 42)
        btnTeams.Name = "btnTeams"
        btnTeams.Size = New Size(115, 50)
        btnTeams.TabIndex = 1
        btnTeams.Text = "Teams"
        btnTeams.UseVisualStyleBackColor = True
        ' 
        ' btnDrivers
        ' 
        btnDrivers.Location = New Point(39, 98)
        btnDrivers.Name = "btnDrivers"
        btnDrivers.Size = New Size(115, 50)
        btnDrivers.TabIndex = 2
        btnDrivers.Text = "Drivers"
        btnDrivers.UseVisualStyleBackColor = True
        ' 
        ' btnGPs
        ' 
        btnGPs.Location = New Point(158, 98)
        btnGPs.Name = "btnGPs"
        btnGPs.Size = New Size(115, 50)
        btnGPs.TabIndex = 3
        btnGPs.Text = "GPs"
        btnGPs.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(100, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(118, 15)
        Label1.TabIndex = 4
        Label1.Text = "Data you can change"
        ' 
        ' FormMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(pnlModifyData)
        Controls.Add(pnlSeason)
        Controls.Add(pnlConn)
        Controls.Add(lblWelcome)
        Name = "FormMain"
        Text = "Form1"
        pnlConn.ResumeLayout(False)
        pnlConn.PerformLayout()
        pnlModifyData.ResumeLayout(False)
        pnlModifyData.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnConnect As Button
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents lblConnect As Label
    Friend WithEvents lblResultConnection As Label
    Friend WithEvents pnlConn As Panel
    Friend WithEvents pnlSeason As Panel
    Friend WithEvents pnlModifyData As Panel
    Friend WithEvents btnGPs As Button
    Friend WithEvents btnDrivers As Button
    Friend WithEvents btnTeams As Button
    Friend WithEvents btnCountries As Button
    Friend WithEvents Label1 As Label

End Class
