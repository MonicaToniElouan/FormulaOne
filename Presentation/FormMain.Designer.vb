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
        pnlConn.SuspendLayout()
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
        btnConnect.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnConnect.FlatStyle = FlatStyle.System
        btnConnect.Location = New Point(251, 64)
        btnConnect.Name = "btnConnect"
        btnConnect.Size = New Size(180, 44)
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
        lblConnect.Location = New Point(123, 17)
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
        lblResultConnection.Location = New Point(314, 143)
        lblResultConnection.Name = "lblResultConnection"
        lblResultConnection.Size = New Size(53, 20)
        lblResultConnection.TabIndex = 3
        lblResultConnection.Text = "Label2"
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
        pnlConn.Size = New Size(676, 194)
        pnlConn.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(pnlConn)
        Controls.Add(lblWelcome)
        Name = "Form1"
        Text = "Form1"
        pnlConn.ResumeLayout(False)
        pnlConn.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnConnect As Button
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents lblConnect As Label
    Friend WithEvents lblResultConnection As Label
    Friend WithEvents pnlConn As Panel

End Class
