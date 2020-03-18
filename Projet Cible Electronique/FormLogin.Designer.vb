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
        Me.ButtonConnexionCreateAccount = New System.Windows.Forms.Button()
        Me.ButtonConnexionConnect = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxConnexionUsername = New System.Windows.Forms.TextBox()
        Me.TextBoxConnexionPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxInscriptionUsername = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxInscriptionPassword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxInscriptionEMail = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ButtonInscriptionConnect = New System.Windows.Forms.Button()
        Me.ButtonInscriptionAddUser = New System.Windows.Forms.Button()
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
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonConnexionCreateAccount, 2, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonConnexionConnect, 5, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxConnexionUsername, 5, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxConnexionPassword, 5, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 2, 3)
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
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TableLayoutPanel2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 32)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(453, 236)
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
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxInscriptionUsername, 5, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxInscriptionPassword, 5, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 2, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 2, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxInscriptionEMail, 5, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.ComboBox1, 5, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.ButtonInscriptionConnect, 2, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.ButtonInscriptionAddUser, 5, 6)
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
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(447, 230)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.Label3, 3)
        Me.Label3.Location = New System.Drawing.Point(91, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Utilisateur :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBoxInscriptionUsername
        '
        Me.TextBoxInscriptionUsername.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.SetColumnSpan(Me.TextBoxInscriptionUsername, 3)
        Me.TextBoxInscriptionUsername.Location = New System.Drawing.Point(223, 31)
        Me.TextBoxInscriptionUsername.Name = "TextBoxInscriptionUsername"
        Me.TextBoxInscriptionUsername.Size = New System.Drawing.Size(126, 26)
        Me.TextBoxInscriptionUsername.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.Label4, 3)
        Me.Label4.Location = New System.Drawing.Point(91, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Mot de passe :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBoxInscriptionPassword
        '
        Me.TextBoxInscriptionPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.SetColumnSpan(Me.TextBoxInscriptionPassword, 3)
        Me.TextBoxInscriptionPassword.Location = New System.Drawing.Point(223, 59)
        Me.TextBoxInscriptionPassword.Name = "TextBoxInscriptionPassword"
        Me.TextBoxInscriptionPassword.Size = New System.Drawing.Size(126, 26)
        Me.TextBoxInscriptionPassword.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.Label5, 3)
        Me.Label5.Location = New System.Drawing.Point(91, 116)
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
        Me.Label6.Location = New System.Drawing.Point(91, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 20)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "E-mail :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBoxInscriptionEMail
        '
        Me.TextBoxInscriptionEMail.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.SetColumnSpan(Me.TextBoxInscriptionEMail, 3)
        Me.TextBoxInscriptionEMail.Location = New System.Drawing.Point(223, 87)
        Me.TextBoxInscriptionEMail.Name = "TextBoxInscriptionEMail"
        Me.TextBoxInscriptionEMail.Size = New System.Drawing.Size(126, 26)
        Me.TextBoxInscriptionEMail.TabIndex = 8
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.SetColumnSpan(Me.ComboBox1, 3)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(223, 115)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(126, 28)
        Me.ComboBox1.TabIndex = 9
        '
        'ButtonInscriptionConnect
        '
        Me.ButtonInscriptionConnect.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.SetColumnSpan(Me.ButtonInscriptionConnect, 3)
        Me.ButtonInscriptionConnect.Location = New System.Drawing.Point(91, 171)
        Me.ButtonInscriptionConnect.Name = "ButtonInscriptionConnect"
        Me.TableLayoutPanel2.SetRowSpan(Me.ButtonInscriptionConnect, 2)
        Me.ButtonInscriptionConnect.Size = New System.Drawing.Size(126, 56)
        Me.ButtonInscriptionConnect.TabIndex = 2
        Me.ButtonInscriptionConnect.Text = "Se connecter"
        Me.ButtonInscriptionConnect.UseVisualStyleBackColor = True
        '
        'ButtonInscriptionAddUser
        '
        Me.ButtonInscriptionAddUser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.SetColumnSpan(Me.ButtonInscriptionAddUser, 3)
        Me.ButtonInscriptionAddUser.Location = New System.Drawing.Point(223, 171)
        Me.ButtonInscriptionAddUser.Name = "ButtonInscriptionAddUser"
        Me.TableLayoutPanel2.SetRowSpan(Me.ButtonInscriptionAddUser, 2)
        Me.ButtonInscriptionAddUser.Size = New System.Drawing.Size(126, 56)
        Me.ButtonInscriptionAddUser.TabIndex = 5
        Me.ButtonInscriptionAddUser.Text = "Créer"
        Me.ButtonInscriptionAddUser.UseVisualStyleBackColor = True
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
    Friend WithEvents ButtonInscriptionConnect As Button
    Friend WithEvents ButtonInscriptionAddUser As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxInscriptionUsername As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxInscriptionPassword As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxInscriptionEMail As TextBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
