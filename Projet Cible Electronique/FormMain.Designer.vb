<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonStatistics = New System.Windows.Forms.Button()
        Me.ButtonShootingSession = New System.Windows.Forms.Button()
        Me.ButtonUser = New System.Windows.Forms.Button()
        Me.ButtonSettings = New System.Windows.Forms.Button()
        Me.LabelPaint1 = New System.Windows.Forms.Label()
        Me.TabControlMain = New System.Windows.Forms.TabControl()
        Me.TabPageUser = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonUserSave = New System.Windows.Forms.Button()
        Me.PictureBoxUserPicture = New System.Windows.Forms.PictureBox()
        Me.TextBoxUserUsername = New System.Windows.Forms.TextBox()
        Me.TextBoxUserFirstname = New System.Windows.Forms.TextBox()
        Me.TextBoxUserPassword = New System.Windows.Forms.TextBox()
        Me.TextBoxUserPasswordConfirm = New System.Windows.Forms.TextBox()
        Me.TextBoxUserEmail = New System.Windows.Forms.TextBox()
        Me.ComboBoxUserCategory = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonUSerCancel = New System.Windows.Forms.Button()
        Me.TextBoxUSerLastname = New System.Windows.Forms.TextBox()
        Me.TabPageShootingSession = New System.Windows.Forms.TabPage()
        Me.TabPageStatistics = New System.Windows.Forms.TabPage()
        Me.TabPageSettings = New System.Windows.Forms.TabPage()
        Me.StatusStrip1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabControlMain.SuspendLayout()
        Me.TabPageUser.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.PictureBoxUserPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 655)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1264, 26)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(158, 21)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(158, 21)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelPaint1, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TabControlMain, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1264, 655)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonStatistics, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonShootingSession, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonUser, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonSettings, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 163.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 163.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 163.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 163.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(300, 655)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'ButtonStatistics
        '
        Me.ButtonStatistics.BackColor = System.Drawing.Color.White
        Me.ButtonStatistics.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonStatistics.FlatAppearance.BorderSize = 0
        Me.ButtonStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonStatistics.Image = CType(resources.GetObject("ButtonStatistics.Image"), System.Drawing.Image)
        Me.ButtonStatistics.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonStatistics.Location = New System.Drawing.Point(3, 329)
        Me.ButtonStatistics.Name = "ButtonStatistics"
        Me.ButtonStatistics.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.ButtonStatistics.Size = New System.Drawing.Size(294, 157)
        Me.ButtonStatistics.TabIndex = 2
        Me.ButtonStatistics.Text = "Statistiques"
        Me.ButtonStatistics.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonStatistics.UseVisualStyleBackColor = False
        '
        'ButtonShootingSession
        '
        Me.ButtonShootingSession.BackColor = System.Drawing.Color.White
        Me.ButtonShootingSession.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonShootingSession.FlatAppearance.BorderSize = 0
        Me.ButtonShootingSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonShootingSession.Image = CType(resources.GetObject("ButtonShootingSession.Image"), System.Drawing.Image)
        Me.ButtonShootingSession.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonShootingSession.Location = New System.Drawing.Point(3, 166)
        Me.ButtonShootingSession.Name = "ButtonShootingSession"
        Me.ButtonShootingSession.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.ButtonShootingSession.Size = New System.Drawing.Size(294, 157)
        Me.ButtonShootingSession.TabIndex = 1
        Me.ButtonShootingSession.Text = "Session de tir"
        Me.ButtonShootingSession.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonShootingSession.UseVisualStyleBackColor = False
        '
        'ButtonUser
        '
        Me.ButtonUser.BackColor = System.Drawing.Color.White
        Me.ButtonUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonUser.FlatAppearance.BorderSize = 0
        Me.ButtonUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonUser.Image = CType(resources.GetObject("ButtonUser.Image"), System.Drawing.Image)
        Me.ButtonUser.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonUser.Location = New System.Drawing.Point(3, 3)
        Me.ButtonUser.Name = "ButtonUser"
        Me.ButtonUser.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.ButtonUser.Size = New System.Drawing.Size(294, 157)
        Me.ButtonUser.TabIndex = 0
        Me.ButtonUser.Text = "Utilisateur"
        Me.ButtonUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonUser.UseVisualStyleBackColor = False
        '
        'ButtonSettings
        '
        Me.ButtonSettings.BackColor = System.Drawing.Color.White
        Me.ButtonSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonSettings.FlatAppearance.BorderSize = 0
        Me.ButtonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSettings.Image = CType(resources.GetObject("ButtonSettings.Image"), System.Drawing.Image)
        Me.ButtonSettings.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonSettings.Location = New System.Drawing.Point(3, 492)
        Me.ButtonSettings.Name = "ButtonSettings"
        Me.ButtonSettings.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.ButtonSettings.Size = New System.Drawing.Size(294, 157)
        Me.ButtonSettings.TabIndex = 3
        Me.ButtonSettings.Text = "Paramètres"
        Me.ButtonSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonSettings.UseVisualStyleBackColor = False
        '
        'LabelPaint1
        '
        Me.LabelPaint1.AutoSize = True
        Me.LabelPaint1.BackColor = System.Drawing.Color.Black
        Me.LabelPaint1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelPaint1.Location = New System.Drawing.Point(300, 0)
        Me.LabelPaint1.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelPaint1.Name = "LabelPaint1"
        Me.LabelPaint1.Size = New System.Drawing.Size(2, 655)
        Me.LabelPaint1.TabIndex = 4
        '
        'TabControlMain
        '
        Me.TabControlMain.Controls.Add(Me.TabPageUser)
        Me.TabControlMain.Controls.Add(Me.TabPageShootingSession)
        Me.TabControlMain.Controls.Add(Me.TabPageStatistics)
        Me.TabControlMain.Controls.Add(Me.TabPageSettings)
        Me.TabControlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlMain.Location = New System.Drawing.Point(305, 3)
        Me.TabControlMain.Name = "TabControlMain"
        Me.TabControlMain.SelectedIndex = 0
        Me.TabControlMain.Size = New System.Drawing.Size(956, 649)
        Me.TabControlMain.TabIndex = 5
        '
        'TabPageUser
        '
        Me.TabPageUser.Controls.Add(Me.TableLayoutPanel3)
        Me.TabPageUser.Location = New System.Drawing.Point(4, 29)
        Me.TabPageUser.Name = "TabPageUser"
        Me.TabPageUser.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageUser.Size = New System.Drawing.Size(948, 616)
        Me.TabPageUser.TabIndex = 0
        Me.TabPageUser.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 20
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.ButtonUserSave, 6, 16)
        Me.TableLayoutPanel3.Controls.Add(Me.PictureBoxUserPicture, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBoxUserUsername, 10, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBoxUserFirstname, 10, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBoxUserPassword, 10, 8)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBoxUserPasswordConfirm, 10, 10)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBoxUserEmail, 10, 12)
        Me.TableLayoutPanel3.Controls.Add(Me.ComboBoxUserCategory, 10, 14)
        Me.TableLayoutPanel3.Controls.Add(Me.Label6, 5, 14)
        Me.TableLayoutPanel3.Controls.Add(Me.Label5, 5, 12)
        Me.TableLayoutPanel3.Controls.Add(Me.Label4, 5, 10)
        Me.TableLayoutPanel3.Controls.Add(Me.Label7, 5, 8)
        Me.TableLayoutPanel3.Controls.Add(Me.Label3, 5, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.Label2, 5, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 5, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.ButtonUSerCancel, 5, 16)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBoxUSerLastname, 10, 6)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 19
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(942, 610)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'ButtonUserSave
        '
        Me.TableLayoutPanel3.SetColumnSpan(Me.ButtonUserSave, 5)
        Me.ButtonUserSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonUserSave.Location = New System.Drawing.Point(473, 515)
        Me.ButtonUserSave.Name = "ButtonUserSave"
        Me.TableLayoutPanel3.SetRowSpan(Me.ButtonUserSave, 2)
        Me.ButtonUserSave.Size = New System.Drawing.Size(229, 58)
        Me.ButtonUserSave.TabIndex = 8
        Me.ButtonUserSave.Text = "Sauvegarder"
        Me.ButtonUserSave.UseVisualStyleBackColor = True
        '
        'PictureBoxUserPicture
        '
        Me.PictureBoxUserPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableLayoutPanel3.SetColumnSpan(Me.PictureBoxUserPicture, 3)
        Me.PictureBoxUserPicture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBoxUserPicture.Location = New System.Drawing.Point(50, 35)
        Me.PictureBoxUserPicture.Name = "PictureBoxUserPicture"
        Me.TableLayoutPanel3.SetRowSpan(Me.PictureBoxUserPicture, 5)
        Me.PictureBoxUserPicture.Size = New System.Drawing.Size(135, 154)
        Me.PictureBoxUserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxUserPicture.TabIndex = 0
        Me.PictureBoxUserPicture.TabStop = False
        '
        'TextBoxUserUsername
        '
        Me.TextBoxUserUsername.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.SetColumnSpan(Me.TextBoxUserUsername, 5)
        Me.TextBoxUserUsername.Location = New System.Drawing.Point(473, 67)
        Me.TextBoxUserUsername.Name = "TextBoxUserUsername"
        Me.TextBoxUserUsername.Size = New System.Drawing.Size(229, 26)
        Me.TextBoxUserUsername.TabIndex = 0
        '
        'TextBoxUserFirstname
        '
        Me.TextBoxUserFirstname.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.SetColumnSpan(Me.TextBoxUserFirstname, 5)
        Me.TextBoxUserFirstname.Location = New System.Drawing.Point(473, 131)
        Me.TextBoxUserFirstname.Name = "TextBoxUserFirstname"
        Me.TextBoxUserFirstname.Size = New System.Drawing.Size(229, 26)
        Me.TextBoxUserFirstname.TabIndex = 1
        '
        'TextBoxUserPassword
        '
        Me.TextBoxUserPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.SetColumnSpan(Me.TextBoxUserPassword, 5)
        Me.TextBoxUserPassword.Location = New System.Drawing.Point(473, 259)
        Me.TextBoxUserPassword.Name = "TextBoxUserPassword"
        Me.TextBoxUserPassword.Size = New System.Drawing.Size(229, 26)
        Me.TextBoxUserPassword.TabIndex = 3
        '
        'TextBoxUserPasswordConfirm
        '
        Me.TextBoxUserPasswordConfirm.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.SetColumnSpan(Me.TextBoxUserPasswordConfirm, 5)
        Me.TextBoxUserPasswordConfirm.Location = New System.Drawing.Point(473, 323)
        Me.TextBoxUserPasswordConfirm.Name = "TextBoxUserPasswordConfirm"
        Me.TextBoxUserPasswordConfirm.Size = New System.Drawing.Size(229, 26)
        Me.TextBoxUserPasswordConfirm.TabIndex = 4
        '
        'TextBoxUserEmail
        '
        Me.TextBoxUserEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.SetColumnSpan(Me.TextBoxUserEmail, 5)
        Me.TextBoxUserEmail.Location = New System.Drawing.Point(473, 387)
        Me.TextBoxUserEmail.Name = "TextBoxUserEmail"
        Me.TextBoxUserEmail.Size = New System.Drawing.Size(229, 26)
        Me.TextBoxUserEmail.TabIndex = 5
        '
        'ComboBoxUserCategory
        '
        Me.ComboBoxUserCategory.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.SetColumnSpan(Me.ComboBoxUserCategory, 5)
        Me.ComboBoxUserCategory.FormattingEnabled = True
        Me.ComboBoxUserCategory.Location = New System.Drawing.Point(473, 451)
        Me.ComboBoxUserCategory.Name = "ComboBoxUserCategory"
        Me.ComboBoxUserCategory.Size = New System.Drawing.Size(229, 28)
        Me.ComboBoxUserCategory.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.TableLayoutPanel3.SetColumnSpan(Me.Label6, 5)
        Me.Label6.Location = New System.Drawing.Point(238, 454)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(229, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Catégorie :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.TableLayoutPanel3.SetColumnSpan(Me.Label5, 5)
        Me.Label5.Location = New System.Drawing.Point(238, 390)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(229, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "E-mail :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.TableLayoutPanel3.SetColumnSpan(Me.Label4, 5)
        Me.Label4.Location = New System.Drawing.Point(238, 326)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(229, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Confirmer mot de passe :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.TableLayoutPanel3.SetColumnSpan(Me.Label7, 5)
        Me.Label7.Location = New System.Drawing.Point(238, 262)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(229, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Nouveau mot de passe :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.TableLayoutPanel3.SetColumnSpan(Me.Label3, 5)
        Me.Label3.Location = New System.Drawing.Point(238, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(229, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Pseudo :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.TableLayoutPanel3.SetColumnSpan(Me.Label2, 5)
        Me.Label2.Location = New System.Drawing.Point(238, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(229, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Prénom :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.TableLayoutPanel3.SetColumnSpan(Me.Label1, 5)
        Me.Label1.Location = New System.Drawing.Point(238, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nom :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ButtonUSerCancel
        '
        Me.TableLayoutPanel3.SetColumnSpan(Me.ButtonUSerCancel, 5)
        Me.ButtonUSerCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonUSerCancel.Location = New System.Drawing.Point(238, 515)
        Me.ButtonUSerCancel.Name = "ButtonUSerCancel"
        Me.TableLayoutPanel3.SetRowSpan(Me.ButtonUSerCancel, 2)
        Me.ButtonUSerCancel.Size = New System.Drawing.Size(229, 58)
        Me.ButtonUSerCancel.TabIndex = 7
        Me.ButtonUSerCancel.Text = "Annuler"
        Me.ButtonUSerCancel.UseVisualStyleBackColor = True
        '
        'TextBoxUSerLastname
        '
        Me.TextBoxUSerLastname.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.SetColumnSpan(Me.TextBoxUSerLastname, 5)
        Me.TextBoxUSerLastname.Location = New System.Drawing.Point(473, 195)
        Me.TextBoxUSerLastname.Name = "TextBoxUSerLastname"
        Me.TextBoxUSerLastname.Size = New System.Drawing.Size(229, 26)
        Me.TextBoxUSerLastname.TabIndex = 2
        '
        'TabPageShootingSession
        '
        Me.TabPageShootingSession.Location = New System.Drawing.Point(4, 22)
        Me.TabPageShootingSession.Name = "TabPageShootingSession"
        Me.TabPageShootingSession.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageShootingSession.Size = New System.Drawing.Size(948, 623)
        Me.TabPageShootingSession.TabIndex = 1
        Me.TabPageShootingSession.UseVisualStyleBackColor = True
        '
        'TabPageStatistics
        '
        Me.TabPageStatistics.Location = New System.Drawing.Point(4, 22)
        Me.TabPageStatistics.Name = "TabPageStatistics"
        Me.TabPageStatistics.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageStatistics.Size = New System.Drawing.Size(948, 623)
        Me.TabPageStatistics.TabIndex = 2
        Me.TabPageStatistics.UseVisualStyleBackColor = True
        '
        'TabPageSettings
        '
        Me.TabPageSettings.Location = New System.Drawing.Point(4, 22)
        Me.TabPageSettings.Name = "TabPageSettings"
        Me.TabPageSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageSettings.Size = New System.Drawing.Size(948, 623)
        Me.TabPageSettings.TabIndex = 3
        Me.TabPageSettings.UseVisualStyleBackColor = True
        '
        'FormMain
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimumSize = New System.Drawing.Size(1280, 720)
        Me.Name = "FormMain"
        Me.Text = "TB Target"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TabControlMain.ResumeLayout(False)
        Me.TabPageUser.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.PictureBoxUserPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LabelPaint1 As Label
    Friend WithEvents ButtonSettings As Button
    Friend WithEvents ButtonStatistics As Button
    Friend WithEvents ButtonShootingSession As Button
    Friend WithEvents ButtonUser As Button
    Friend WithEvents TabControlMain As TabControl
    Friend WithEvents TabPageUser As TabPage
    Friend WithEvents TabPageShootingSession As TabPage
    Friend WithEvents TabPageStatistics As TabPage
    Friend WithEvents TabPageSettings As TabPage
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents PictureBoxUserPicture As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxUserUsername As TextBox
    Friend WithEvents TextBoxUserFirstname As TextBox
    Friend WithEvents TextBoxUSerLastname As TextBox
    Friend WithEvents TextBoxUserPassword As TextBox
    Friend WithEvents TextBoxUserPasswordConfirm As TextBox
    Friend WithEvents TextBoxUserEmail As TextBox
    Friend WithEvents ComboBoxUserCategory As ComboBox
    Friend WithEvents ButtonUserSave As Button
    Friend WithEvents ButtonUSerCancel As Button
End Class
