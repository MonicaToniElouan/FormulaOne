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
        btnGenSeason = New Button()
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
        pnlModifyData.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        pnlModifyData.ForeColor = Color.Red
        pnlModifyData.Location = New Point(0, 294)
        pnlModifyData.Name = "pnlModifyData"
        pnlModifyData.Size = New Size(778, 73)
        pnlModifyData.TabIndex = 6
        ' 
        ' btnGPs
        ' 
        btnGPs.Location = New Point(10, 12)
        btnGPs.Name = "btnGPs"
        btnGPs.Size = New Size(171, 50)
        btnGPs.TabIndex = 3
        btnGPs.Text = "GPs"
        btnGPs.UseVisualStyleBackColor = True
        ' 
        ' btnDrivers
        ' 
        btnDrivers.Location = New Point(396, 12)
        btnDrivers.Name = "btnDrivers"
        btnDrivers.Size = New Size(171, 50)
        btnDrivers.TabIndex = 2
        btnDrivers.Text = "Drivers"
        btnDrivers.UseVisualStyleBackColor = True
        ' 
        ' btnTeams
        ' 
        btnTeams.Location = New Point(588, 12)
        btnTeams.Name = "btnTeams"
        btnTeams.Size = New Size(171, 50)
        btnTeams.TabIndex = 1
        btnTeams.Text = "Teams"
        btnTeams.UseVisualStyleBackColor = True
        ' 
        ' btnCountries
        ' 
        btnCountries.Location = New Point(206, 12)
        btnCountries.Name = "btnCountries"
        btnCountries.Size = New Size(171, 50)
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
        lblWelcome.Location = New Point(155, -10)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(440, 71)
        lblWelcome.TabIndex = 0
        lblWelcome.Text = "Formula One System"
        lblWelcome.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblResultConnection
        ' 
        lblResultConnection.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblResultConnection.AutoSize = True
        lblResultConnection.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblResultConnection.Location = New Point(297, 12)
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
        pnlConn.Location = New Point(62, 90)
        pnlConn.Name = "pnlConn"
        pnlConn.Size = New Size(676, 43)
        pnlConn.TabIndex = 4
        ' 
        ' btnGenSeason
        ' 
        btnGenSeason.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnGenSeason.Location = New Point(286, 149)
        btnGenSeason.Name = "btnGenSeason"
        btnGenSeason.Size = New Size(219, 55)
        btnGenSeason.TabIndex = 7
        btnGenSeason.Text = "Generate Season"
        btnGenSeason.UseVisualStyleBackColor = True
        ' 
        ' FormMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(769, 366)
        Controls.Add(btnGenSeason)
        Controls.Add(pnlModifyData)
        Controls.Add(pnlConn)
        Controls.Add(lblWelcome)
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
    Friend WithEvents btnGenSeason As Button

End Class
