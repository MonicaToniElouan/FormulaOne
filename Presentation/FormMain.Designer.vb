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
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
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
        pnlModifyData.Controls.Add(Button3)
        pnlModifyData.Controls.Add(Button2)
        pnlModifyData.Controls.Add(Button1)
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
        ' Button1
        ' 
        Button1.Location = New Point(158, 42)
        Button1.Name = "Button1"
        Button1.Size = New Size(115, 50)
        Button1.TabIndex = 1
        Button1.Text = "Countries"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(39, 98)
        Button2.Name = "Button2"
        Button2.Size = New Size(115, 50)
        Button2.TabIndex = 2
        Button2.Text = "Countries"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(158, 98)
        Button3.Name = "Button3"
        Button3.Size = New Size(115, 50)
        Button3.TabIndex = 3
        Button3.Text = "Countries"
        Button3.UseVisualStyleBackColor = True
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
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnCountries As Button

End Class
