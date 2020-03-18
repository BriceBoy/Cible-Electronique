<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabControlMain = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxConnexionUsername = New System.Windows.Forms.TextBox()
        Me.TextBoxConnexionPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonConnexionConnect = New System.Windows.Forms.Button()
        Me.ButtonConnexionCreateAccount = New System.Windows.Forms.Button()
        Me.LabelContinueWithoutConnexion = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxRegistrationUsername = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxRegistrationPassword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxRegistrationEMail = New System.Windows.Forms.TextBox()
        Me.ComboBoxRegistrationLevel = New System.Windows.Forms.ComboBox()
        Me.ButtonRegistrationConnect = New System.Windows.Forms.Button()
        Me.ButtonRegistrationAddUser = New System.Windows.Forms.Button()
        Me.TabControlMain.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControlMain
        '
        Me.TabControlMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControlMain.Controls.Add(Me.TabPage1)
        Me.TabControlMain.Controls.Add(Me.TabPage2)
        Me.TabControlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlMain.Location = New System.Drawing.Point(0, 0)
        Me.TabControlMain.Name = "TabControlMain"
        Me.TabControlMain.SelectedIndex = 0
        Me.TabControlMain.Size = New System.Drawing.Size(461, 272)
        Me.TabControlMain.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 32)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(453, 236)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Connexion"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 10
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxConnexionUsername, 5, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxConnexionPassword, 5, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonConnexionConnect, 5, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonConnexionCreateAccount, 2, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelContinueWithoutConnexion, 2, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(447, 230)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label1, 3)
        Me.Label1.Location = New System.Drawing.Point(91, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Utilisateur :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBoxConnexionUsername
        '
        Me.TextBoxConnexionUsername.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.SetColumnSpan(Me.TextBoxConnexionUsername, 3)
        Me.TextBoxConnexionUsername.Location = New System.Drawing.Point(223, 59)
        Me.TextBoxConnexionUsername.Name = "TextBoxConnexionUsername"
        Me.TextBoxConnexionUsername.Size = New System.Drawing.Size(126, 26)
        Me.TextBoxConnexionUsername.TabIndex = 3
        '
        'TextBoxConnexionPassword
        '
        Me.TextBoxConnexionPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.SetColumnSpan(Me.TextBoxConnexionPassword, 3)
        Me.TextBoxConnexionPassword.Location = New System.Drawing.Point(223, 87)
        Me.TextBoxConnexionPassword.Name = "TextBoxConnexionPassword"
        Me.TextBoxConnexionPassword.Size = New System.Drawing.Size(126, 26)
        Me.TextBoxConnexionPassword.TabIndex = 4
        Me.TextBoxConnexionPassword.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label2, 3)
        Me.Label2.Location = New System.Drawing.Point(91, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mot de passe :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ButtonConnexionConnect
        '
        Me.ButtonConnexionConnect.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.SetColumnSpan(Me.ButtonConnexionConnect, 3)
        Me.ButtonConnexionConnect.Location = New System.Drawing.Point(223, 171)
        Me.ButtonConnexionConnect.Name = "ButtonConnexionConnect"
        Me.TableLayoutPanel1.SetRowSpan(Me.ButtonConnexionConnect, 2)
        Me.ButtonConnexionConnect.Size = New System.Drawing.Size(126, 56)
        Me.ButtonConnexionConnect.TabIndex = 5
        Me.ButtonConnexionConnect.Text = "Connexion"
        Me.ButtonConnexionConnect.UseVisualStyleBackColor = True
        '
        'ButtonConnexionCreateAccount
        '
        Me.ButtonConnexionCreateAccount.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.SetColumnSpan(Me.ButtonConnexionCreateAccount, 3)
        Me.ButtonConnexionCreateAccount.Location = New System.Drawing.Point(91, 171)
        Me.ButtonConnexionCreateAccount.Name = "ButtonConnexionCreateAccount"
        Me.TableLayoutPanel1.SetRowSpan(Me.ButtonConnexionCreateAccount, 2)
        Me.ButtonConnexionCreateAccount.Size = New System.Drawing.Size(126, 56)
        Me.ButtonConnexionCreateAccount.TabIndex = 2
        Me.ButtonConnexionCreateAccount.Text = "Créer compte"
        Me.ButtonConnexionCreateAccount.UseVisualStyleBackColor = True
        '
        'LabelContinueWithoutConnexion
        '
        Me.LabelContinueWithoutConnexion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelContinueWithoutConnexion.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.LabelContinueWithoutConnexion, 6)
        Me.LabelContinueWithoutConnexion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelContinueWithoutConnexion.ForeColor = System.Drawing.Color.DodgerBlue
        Me.LabelContinueWithoutConnexion.Location = New System.Drawing.Point(91, 125)
        Me.LabelContinueWithoutConnexion.Name = "LabelContinueWithoutConnexion"
        Me.LabelContinueWithoutConnexion.Size = New System.Drawing.Size(258, 15)
        Me.LabelContinueWithoutConnexion.TabIndex = 6
        Me.LabelContinueWithoutConnexion.Text = "Continuer sans se connnecter"
        Me.LabelContinueWithoutConnexion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TableLayoutPanel2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(453, 243)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Inscription"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 10
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxRegistrationUsername, 5, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxRegistrationPassword, 5, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 2, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 2, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxRegistrationEMail, 5, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.ComboBoxRegistrationLevel, 5, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.ButtonRegistrationConnect, 2, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.ButtonRegistrationAddUser, 5, 6)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 8
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(447, 237)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.Label3, 3)
        Me.Label3.Location = New System.Drawing.Point(91, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Utilisateur :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBoxRegistrationUsername
        '
        Me.TextBoxRegistrationUsername.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.SetColumnSpan(Me.TextBoxRegistrationUsername, 3)
        Me.TextBoxRegistrationUsername.Location = New System.Drawing.Point(223, 32)
        Me.TextBoxRegistrationUsername.Name = "TextBoxRegistrationUsername"
        Me.TextBoxRegistrationUsername.Size = New System.Drawing.Size(126, 26)
        Me.TextBoxRegistrationUsername.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.Label4, 3)
        Me.Label4.Location = New System.Drawing.Point(91, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Mot de passe :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBoxRegistrationPassword
        '
        Me.TextBoxRegistrationPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.SetColumnSpan(Me.TextBoxRegistrationPassword, 3)
        Me.TextBoxRegistrationPassword.Location = New System.Drawing.Point(223, 61)
        Me.TextBoxRegistrationPassword.Name = "TextBoxRegistrationPassword"
        Me.TextBoxRegistrationPassword.Size = New System.Drawing.Size(126, 26)
        Me.TextBoxRegistrationPassword.TabIndex = 4
        Me.TextBoxRegistrationPassword.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.Label5, 3)
        Me.Label5.Location = New System.Drawing.Point(91, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Niveau :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.Label6, 3)
        Me.Label6.Location = New System.Drawing.Point(91, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 20)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "E-mail :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBoxRegistrationEMail
        '
        Me.TextBoxRegistrationEMail.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.SetColumnSpan(Me.TextBoxRegistrationEMail, 3)
        Me.TextBoxRegistrationEMail.Location = New System.Drawing.Point(223, 90)
        Me.TextBoxRegistrationEMail.Name = "TextBoxRegistrationEMail"
        Me.TextBoxRegistrationEMail.Size = New System.Drawing.Size(126, 26)
        Me.TextBoxRegistrationEMail.TabIndex = 8
        '
        'ComboBoxRegistrationLevel
        '
        Me.ComboBoxRegistrationLevel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.SetColumnSpan(Me.ComboBoxRegistrationLevel, 3)
        Me.ComboBoxRegistrationLevel.FormattingEnabled = True
        Me.ComboBoxRegistrationLevel.Location = New System.Drawing.Point(223, 119)
        Me.ComboBoxRegistrationLevel.Name = "ComboBoxRegistrationLevel"
        Me.ComboBoxRegistrationLevel.Size = New System.Drawing.Size(126, 28)
        Me.ComboBoxRegistrationLevel.TabIndex = 9
        '
        'ButtonRegistrationConnect
        '
        Me.ButtonRegistrationConnect.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.SetColumnSpan(Me.ButtonRegistrationConnect, 3)
        Me.ButtonRegistrationConnect.Location = New System.Drawing.Point(91, 177)
        Me.ButtonRegistrationConnect.Name = "ButtonRegistrationConnect"
        Me.TableLayoutPanel2.SetRowSpan(Me.ButtonRegistrationConnect, 2)
        Me.ButtonRegistrationConnect.Size = New System.Drawing.Size(126, 57)
        Me.ButtonRegistrationConnect.TabIndex = 2
        Me.ButtonRegistrationConnect.Text = "Se connecter"
        Me.ButtonRegistrationConnect.UseVisualStyleBackColor = True
        '
        'ButtonRegistrationAddUser
        '
        Me.ButtonRegistrationAddUser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.SetColumnSpan(Me.ButtonRegistrationAddUser, 3)
        Me.ButtonRegistrationAddUser.Location = New System.Drawing.Point(223, 177)
        Me.ButtonRegistrationAddUser.Name = "ButtonRegistrationAddUser"
        Me.TableLayoutPanel2.SetRowSpan(Me.ButtonRegistrationAddUser, 2)
        Me.ButtonRegistrationAddUser.Size = New System.Drawing.Size(126, 57)
        Me.ButtonRegistrationAddUser.TabIndex = 5
        Me.ButtonRegistrationAddUser.Text = "Créer"
        Me.ButtonRegistrationAddUser.UseVisualStyleBackColor = True
        '
        'FormLogin
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(461, 272)
        Me.Controls.Add(Me.TabControlMain)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormLogin"
        Me.TabControlMain.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControlMain As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonConnexionCreateAccount As Button
    Friend WithEvents TextBoxConnexionUsername As TextBox
    Friend WithEvents TextBoxConnexionPassword As TextBox
    Friend WithEvents ButtonConnexionConnect As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents ButtonRegistrationConnect As Button
    Friend WithEvents ButtonRegistrationAddUser As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxRegistrationUsername As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxRegistrationPassword As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxRegistrationEMail As TextBox
    Friend WithEvents ComboBoxRegistrationLevel As ComboBox
    Friend WithEvents LabelContinueWithoutConnexion As Label
End Class
