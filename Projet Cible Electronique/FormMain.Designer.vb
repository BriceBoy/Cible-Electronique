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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelPaint1 = New System.Windows.Forms.Label()
        Me.TabControlMain = New System.Windows.Forms.TabControl()
        Me.TabPageUserConnected = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonUserSave = New System.Windows.Forms.Button()
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
        Me.ButtonUserLogOut = New System.Windows.Forms.Button()
        Me.TextBoxUserLastname = New System.Windows.Forms.TextBox()
        Me.TabPageShootingSession = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LabelLastShootDistance = New System.Windows.Forms.Label()
        Me.LabelLastShootScore = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataGridViewResults = New System.Windows.Forms.DataGridView()
        Me.ColShoot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDistance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColScore = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabelShootingSessionAdvices = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboBoxShootingTargetSelection = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBoxShotsCount = New System.Windows.Forms.ComboBox()
        Me.ButtonStartShootingSession = New System.Windows.Forms.Button()
        Me.ButtonCloseShootingSession = New System.Windows.Forms.Button()
        Me.TabPageStatistics = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.ChartStats = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ComboBoxStatsSession = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LabelStatsAverageScore = New System.Windows.Forms.Label()
        Me.RichTextBoxStatsAdvices = New System.Windows.Forms.RichTextBox()
        Me.RichTextBoxStatsComments = New System.Windows.Forms.RichTextBox()
        Me.TabPageSettings = New System.Windows.Forms.TabPage()
        Me.ButtonSettingsAddTarget = New System.Windows.Forms.Button()
        Me.TabPageEmpty = New System.Windows.Forms.TabPage()
        Me.OpenFileDialogImg = New System.Windows.Forms.OpenFileDialog()
        Me.ButtonStatistics = New System.Windows.Forms.Button()
        Me.ButtonShootingSession = New System.Windows.Forms.Button()
        Me.ButtonUser = New System.Windows.Forms.Button()
        Me.ButtonSettings = New System.Windows.Forms.Button()
        Me.PictureBoxUserPicture = New System.Windows.Forms.PictureBox()
        Me.PictureBoxTarget = New System.Windows.Forms.PictureBox()
        Me.PictureBoxStats = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabControlMain.SuspendLayout()
        Me.TabPageUserConnected.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TabPageShootingSession.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        CType(Me.DataGridViewResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageStatistics.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.ChartStats, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TabPageSettings.SuspendLayout()
        CType(Me.PictureBoxUserPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxTarget, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxStats, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 659)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1264, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(0, 17)
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
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
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1264, 659)
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(250, 659)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'LabelPaint1
        '
        Me.LabelPaint1.AutoSize = True
        Me.LabelPaint1.BackColor = System.Drawing.Color.Black
        Me.LabelPaint1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelPaint1.Location = New System.Drawing.Point(250, 0)
        Me.LabelPaint1.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelPaint1.Name = "LabelPaint1"
        Me.LabelPaint1.Size = New System.Drawing.Size(2, 659)
        Me.LabelPaint1.TabIndex = 4
        '
        'TabControlMain
        '
        Me.TabControlMain.Controls.Add(Me.TabPageUserConnected)
        Me.TabControlMain.Controls.Add(Me.TabPageShootingSession)
        Me.TabControlMain.Controls.Add(Me.TabPageStatistics)
        Me.TabControlMain.Controls.Add(Me.TabPageSettings)
        Me.TabControlMain.Controls.Add(Me.TabPageEmpty)
        Me.TabControlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlMain.Location = New System.Drawing.Point(255, 3)
        Me.TabControlMain.Name = "TabControlMain"
        Me.TabControlMain.SelectedIndex = 0
        Me.TabControlMain.Size = New System.Drawing.Size(1006, 653)
        Me.TabControlMain.TabIndex = 5
        '
        'TabPageUserConnected
        '
        Me.TabPageUserConnected.Controls.Add(Me.TableLayoutPanel3)
        Me.TabPageUserConnected.Location = New System.Drawing.Point(4, 29)
        Me.TabPageUserConnected.Name = "TabPageUserConnected"
        Me.TabPageUserConnected.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageUserConnected.Size = New System.Drawing.Size(998, 620)
        Me.TabPageUserConnected.TabIndex = 0
        Me.TabPageUserConnected.UseVisualStyleBackColor = True
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
        Me.TableLayoutPanel3.Controls.Add(Me.ButtonUserLogOut, 5, 16)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBoxUserLastname, 10, 6)
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
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(992, 614)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'ButtonUserSave
        '
        Me.TableLayoutPanel3.SetColumnSpan(Me.ButtonUserSave, 5)
        Me.ButtonUserSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonUserSave.Location = New System.Drawing.Point(493, 515)
        Me.ButtonUserSave.Name = "ButtonUserSave"
        Me.TableLayoutPanel3.SetRowSpan(Me.ButtonUserSave, 2)
        Me.ButtonUserSave.Size = New System.Drawing.Size(239, 58)
        Me.ButtonUserSave.TabIndex = 8
        Me.ButtonUserSave.Text = "Sauvegarder"
        Me.ButtonUserSave.UseVisualStyleBackColor = True
        '
        'TextBoxUserUsername
        '
        Me.TextBoxUserUsername.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.SetColumnSpan(Me.TextBoxUserUsername, 5)
        Me.TextBoxUserUsername.Location = New System.Drawing.Point(493, 67)
        Me.TextBoxUserUsername.Name = "TextBoxUserUsername"
        Me.TextBoxUserUsername.Size = New System.Drawing.Size(239, 26)
        Me.TextBoxUserUsername.TabIndex = 0
        '
        'TextBoxUserFirstname
        '
        Me.TextBoxUserFirstname.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.SetColumnSpan(Me.TextBoxUserFirstname, 5)
        Me.TextBoxUserFirstname.Location = New System.Drawing.Point(493, 131)
        Me.TextBoxUserFirstname.Name = "TextBoxUserFirstname"
        Me.TextBoxUserFirstname.Size = New System.Drawing.Size(239, 26)
        Me.TextBoxUserFirstname.TabIndex = 1
        '
        'TextBoxUserPassword
        '
        Me.TextBoxUserPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.SetColumnSpan(Me.TextBoxUserPassword, 5)
        Me.TextBoxUserPassword.Location = New System.Drawing.Point(493, 259)
        Me.TextBoxUserPassword.Name = "TextBoxUserPassword"
        Me.TextBoxUserPassword.Size = New System.Drawing.Size(239, 26)
        Me.TextBoxUserPassword.TabIndex = 3
        '
        'TextBoxUserPasswordConfirm
        '
        Me.TextBoxUserPasswordConfirm.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.SetColumnSpan(Me.TextBoxUserPasswordConfirm, 5)
        Me.TextBoxUserPasswordConfirm.Location = New System.Drawing.Point(493, 323)
        Me.TextBoxUserPasswordConfirm.Name = "TextBoxUserPasswordConfirm"
        Me.TextBoxUserPasswordConfirm.Size = New System.Drawing.Size(239, 26)
        Me.TextBoxUserPasswordConfirm.TabIndex = 4
        '
        'TextBoxUserEmail
        '
        Me.TextBoxUserEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.SetColumnSpan(Me.TextBoxUserEmail, 5)
        Me.TextBoxUserEmail.Location = New System.Drawing.Point(493, 387)
        Me.TextBoxUserEmail.Name = "TextBoxUserEmail"
        Me.TextBoxUserEmail.Size = New System.Drawing.Size(239, 26)
        Me.TextBoxUserEmail.TabIndex = 5
        '
        'ComboBoxUserCategory
        '
        Me.ComboBoxUserCategory.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.SetColumnSpan(Me.ComboBoxUserCategory, 5)
        Me.ComboBoxUserCategory.FormattingEnabled = True
        Me.ComboBoxUserCategory.Items.AddRange(New Object() {"Débutant", "Amateur", "Professionnel"})
        Me.ComboBoxUserCategory.Location = New System.Drawing.Point(493, 451)
        Me.ComboBoxUserCategory.Name = "ComboBoxUserCategory"
        Me.ComboBoxUserCategory.Size = New System.Drawing.Size(239, 28)
        Me.ComboBoxUserCategory.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.TableLayoutPanel3.SetColumnSpan(Me.Label6, 5)
        Me.Label6.Location = New System.Drawing.Point(248, 454)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(239, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Catégorie :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.TableLayoutPanel3.SetColumnSpan(Me.Label5, 5)
        Me.Label5.Location = New System.Drawing.Point(248, 390)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(239, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "E-mail :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.TableLayoutPanel3.SetColumnSpan(Me.Label4, 5)
        Me.Label4.Location = New System.Drawing.Point(248, 326)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(239, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Confirmer mot de passe :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.TableLayoutPanel3.SetColumnSpan(Me.Label7, 5)
        Me.Label7.Location = New System.Drawing.Point(248, 262)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(239, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Nouveau mot de passe :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.TableLayoutPanel3.SetColumnSpan(Me.Label3, 5)
        Me.Label3.Location = New System.Drawing.Point(248, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(239, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Pseudo :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.TableLayoutPanel3.SetColumnSpan(Me.Label2, 5)
        Me.Label2.Location = New System.Drawing.Point(248, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(239, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Prénom :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.TableLayoutPanel3.SetColumnSpan(Me.Label1, 5)
        Me.Label1.Location = New System.Drawing.Point(248, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nom :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ButtonUserLogOut
        '
        Me.TableLayoutPanel3.SetColumnSpan(Me.ButtonUserLogOut, 5)
        Me.ButtonUserLogOut.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonUserLogOut.Location = New System.Drawing.Point(248, 515)
        Me.ButtonUserLogOut.Name = "ButtonUserLogOut"
        Me.TableLayoutPanel3.SetRowSpan(Me.ButtonUserLogOut, 2)
        Me.ButtonUserLogOut.Size = New System.Drawing.Size(239, 58)
        Me.ButtonUserLogOut.TabIndex = 7
        Me.ButtonUserLogOut.Text = "Se déconnecter"
        Me.ButtonUserLogOut.UseVisualStyleBackColor = True
        '
        'TextBoxUserLastname
        '
        Me.TextBoxUserLastname.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.SetColumnSpan(Me.TextBoxUserLastname, 5)
        Me.TextBoxUserLastname.Location = New System.Drawing.Point(493, 195)
        Me.TextBoxUserLastname.Name = "TextBoxUserLastname"
        Me.TextBoxUserLastname.Size = New System.Drawing.Size(239, 26)
        Me.TextBoxUserLastname.TabIndex = 2
        '
        'TabPageShootingSession
        '
        Me.TabPageShootingSession.Controls.Add(Me.TableLayoutPanel4)
        Me.TabPageShootingSession.Location = New System.Drawing.Point(4, 22)
        Me.TabPageShootingSession.Name = "TabPageShootingSession"
        Me.TabPageShootingSession.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageShootingSession.Size = New System.Drawing.Size(998, 627)
        Me.TabPageShootingSession.TabIndex = 1
        Me.TabPageShootingSession.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 20
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.PictureBoxTarget, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel7, 12, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label9, 0, 19)
        Me.TableLayoutPanel4.Controls.Add(Me.ComboBoxShootingTargetSelection, 3, 18)
        Me.TableLayoutPanel4.Controls.Add(Me.Label8, 1, 18)
        Me.TableLayoutPanel4.Controls.Add(Me.ComboBoxShotsCount, 3, 19)
        Me.TableLayoutPanel4.Controls.Add(Me.ButtonStartShootingSession, 8, 18)
        Me.TableLayoutPanel4.Controls.Add(Me.ButtonCloseShootingSession, 11, 18)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 20
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(992, 621)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel7.ColumnCount = 1
        Me.TableLayoutPanel4.SetColumnSpan(Me.TableLayoutPanel7, 8)
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.GroupBox2, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.DataGridViewResults, 0, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.LabelShootingSessionAdvices, 0, 2)
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(605, 29)
        Me.TableLayoutPanel7.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 3
        Me.TableLayoutPanel4.SetRowSpan(Me.TableLayoutPanel7, 18)
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(370, 500)
        Me.TableLayoutPanel7.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel8)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(370, 72)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dernier tir"
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 4
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.Label11, 2, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.LabelLastShootDistance, 1, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.LabelLastShootScore, 3, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.Label10, 0, 0)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(3, 22)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 1
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(364, 47)
        Me.TableLayoutPanel8.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(185, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 20)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Score :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelLastShootDistance
        '
        Me.LabelLastShootDistance.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelLastShootDistance.AutoSize = True
        Me.LabelLastShootDistance.Location = New System.Drawing.Point(94, 13)
        Me.LabelLastShootDistance.Name = "LabelLastShootDistance"
        Me.LabelLastShootDistance.Size = New System.Drawing.Size(85, 20)
        Me.LabelLastShootDistance.TabIndex = 4
        Me.LabelLastShootDistance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelLastShootScore
        '
        Me.LabelLastShootScore.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelLastShootScore.AutoSize = True
        Me.LabelLastShootScore.Location = New System.Drawing.Point(276, 13)
        Me.LabelLastShootScore.Name = "LabelLastShootScore"
        Me.LabelLastShootScore.Size = New System.Drawing.Size(85, 20)
        Me.LabelLastShootScore.TabIndex = 6
        Me.LabelLastShootScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 20)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Distance :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridViewResults
        '
        Me.DataGridViewResults.AllowUserToAddRows = False
        Me.DataGridViewResults.AllowUserToDeleteRows = False
        Me.DataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewResults.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColShoot, Me.ColDistance, Me.ColScore, Me.ColTotal})
        Me.DataGridViewResults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewResults.Location = New System.Drawing.Point(0, 78)
        Me.DataGridViewResults.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.DataGridViewResults.Name = "DataGridViewResults"
        Me.DataGridViewResults.ReadOnly = True
        Me.DataGridViewResults.RowHeadersVisible = False
        Me.DataGridViewResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewResults.Size = New System.Drawing.Size(370, 297)
        Me.DataGridViewResults.TabIndex = 1
        '
        'ColShoot
        '
        Me.ColShoot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ColShoot.HeaderText = "Tir"
        Me.ColShoot.Name = "ColShoot"
        Me.ColShoot.ReadOnly = True
        Me.ColShoot.Width = 51
        '
        'ColDistance
        '
        Me.ColDistance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColDistance.HeaderText = "Distance"
        Me.ColDistance.Name = "ColDistance"
        Me.ColDistance.ReadOnly = True
        '
        'ColScore
        '
        Me.ColScore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColScore.HeaderText = "Score"
        Me.ColScore.Name = "ColScore"
        Me.ColScore.ReadOnly = True
        '
        'ColTotal
        '
        Me.ColTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColTotal.HeaderText = "Total"
        Me.ColTotal.Name = "ColTotal"
        Me.ColTotal.ReadOnly = True
        '
        'LabelShootingSessionAdvices
        '
        Me.LabelShootingSessionAdvices.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelShootingSessionAdvices.AutoSize = True
        Me.LabelShootingSessionAdvices.Location = New System.Drawing.Point(3, 427)
        Me.LabelShootingSessionAdvices.Name = "LabelShootingSessionAdvices"
        Me.LabelShootingSessionAdvices.Size = New System.Drawing.Size(364, 20)
        Me.LabelShootingSessionAdvices.TabIndex = 2
        Me.LabelShootingSessionAdvices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label9.AutoSize = True
        Me.TableLayoutPanel4.SetColumnSpan(Me.Label9, 3)
        Me.Label9.Location = New System.Drawing.Point(24, 595)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 20)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Nombre de tirs :"
        '
        'ComboBoxShootingTargetSelection
        '
        Me.ComboBoxShootingTargetSelection.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.SetColumnSpan(Me.ComboBoxShootingTargetSelection, 4)
        Me.ComboBoxShootingTargetSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxShootingTargetSelection.FormattingEnabled = True
        Me.ComboBoxShootingTargetSelection.Location = New System.Drawing.Point(150, 561)
        Me.ComboBoxShootingTargetSelection.Name = "ComboBoxShootingTargetSelection"
        Me.ComboBoxShootingTargetSelection.Size = New System.Drawing.Size(190, 28)
        Me.ComboBoxShootingTargetSelection.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.TableLayoutPanel4.SetColumnSpan(Me.Label8, 2)
        Me.Label8.Location = New System.Drawing.Point(52, 563)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 20)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Cible :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBoxShotsCount
        '
        Me.ComboBoxShotsCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.SetColumnSpan(Me.ComboBoxShotsCount, 4)
        Me.ComboBoxShotsCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxShotsCount.FormattingEnabled = True
        Me.ComboBoxShotsCount.Items.AddRange(New Object() {"10", "20", "30", "40", "50", "60", "libre"})
        Me.ComboBoxShotsCount.Location = New System.Drawing.Point(150, 592)
        Me.ComboBoxShotsCount.Name = "ComboBoxShotsCount"
        Me.ComboBoxShotsCount.Size = New System.Drawing.Size(190, 28)
        Me.ComboBoxShotsCount.TabIndex = 3
        '
        'ButtonStartShootingSession
        '
        Me.ButtonStartShootingSession.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.SetColumnSpan(Me.ButtonStartShootingSession, 3)
        Me.ButtonStartShootingSession.Enabled = False
        Me.ButtonStartShootingSession.Location = New System.Drawing.Point(395, 567)
        Me.ButtonStartShootingSession.Name = "ButtonStartShootingSession"
        Me.TableLayoutPanel4.SetRowSpan(Me.ButtonStartShootingSession, 2)
        Me.ButtonStartShootingSession.Size = New System.Drawing.Size(141, 44)
        Me.ButtonStartShootingSession.TabIndex = 6
        Me.ButtonStartShootingSession.Text = "Commencer"
        Me.ButtonStartShootingSession.UseVisualStyleBackColor = True
        '
        'ButtonCloseShootingSession
        '
        Me.ButtonCloseShootingSession.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.SetColumnSpan(Me.ButtonCloseShootingSession, 3)
        Me.ButtonCloseShootingSession.Enabled = False
        Me.ButtonCloseShootingSession.Location = New System.Drawing.Point(542, 567)
        Me.ButtonCloseShootingSession.Name = "ButtonCloseShootingSession"
        Me.TableLayoutPanel4.SetRowSpan(Me.ButtonCloseShootingSession, 2)
        Me.ButtonCloseShootingSession.Size = New System.Drawing.Size(141, 44)
        Me.ButtonCloseShootingSession.TabIndex = 6
        Me.ButtonCloseShootingSession.Text = "Terminer"
        Me.ButtonCloseShootingSession.UseVisualStyleBackColor = True
        '
        'TabPageStatistics
        '
        Me.TabPageStatistics.Controls.Add(Me.TableLayoutPanel5)
        Me.TabPageStatistics.Location = New System.Drawing.Point(4, 22)
        Me.TabPageStatistics.Name = "TabPageStatistics"
        Me.TabPageStatistics.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageStatistics.Size = New System.Drawing.Size(998, 627)
        Me.TabPageStatistics.TabIndex = 2
        Me.TabPageStatistics.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 20
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.ChartStats, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.GroupBox1, 0, 10)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 20
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(992, 621)
        Me.TableLayoutPanel5.TabIndex = 0
        '
        'ChartStats
        '
        ChartArea2.Name = "ChartArea1"
        Me.ChartStats.ChartAreas.Add(ChartArea2)
        Me.TableLayoutPanel5.SetColumnSpan(Me.ChartStats, 20)
        Me.ChartStats.Dock = System.Windows.Forms.DockStyle.Fill
        Legend2.Name = "Legend1"
        Legend2.Title = "Légende"
        Me.ChartStats.Legends.Add(Legend2)
        Me.ChartStats.Location = New System.Drawing.Point(3, 3)
        Me.ChartStats.Name = "ChartStats"
        Me.TableLayoutPanel5.SetRowSpan(Me.ChartStats, 10)
        Me.ChartStats.Size = New System.Drawing.Size(986, 304)
        Me.ChartStats.TabIndex = 0
        Me.ChartStats.Text = "Chart1"
        Title2.Name = "Title1"
        Title2.Text = "Dernières sessions"
        Me.ChartStats.Titles.Add(Title2)
        '
        'GroupBox1
        '
        Me.TableLayoutPanel5.SetColumnSpan(Me.GroupBox1, 20)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel6)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 313)
        Me.GroupBox1.Name = "GroupBox1"
        Me.TableLayoutPanel5.SetRowSpan(Me.GroupBox1, 10)
        Me.GroupBox1.Size = New System.Drawing.Size(986, 305)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Statistiques Session"
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 3
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.PictureBoxStats, 2, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Label12, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.ComboBoxStatsSession, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Label13, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.LabelStatsAverageScore, 1, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.RichTextBoxStatsAdvices, 0, 3)
        Me.TableLayoutPanel6.Controls.Add(Me.RichTextBoxStatsComments, 0, 2)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 22)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 4
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(980, 280)
        Me.TableLayoutPanel6.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(239, 20)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Session :"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBoxStatsSession
        '
        Me.ComboBoxStatsSession.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxStatsSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxStatsSession.FormattingEnabled = True
        Me.ComboBoxStatsSession.Location = New System.Drawing.Point(248, 3)
        Me.ComboBoxStatsSession.Name = "ComboBoxStatsSession"
        Me.ComboBoxStatsSession.Size = New System.Drawing.Size(239, 28)
        Me.ComboBoxStatsSession.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 44)
        Me.Label13.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(239, 20)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Score moyen :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelStatsAverageScore
        '
        Me.LabelStatsAverageScore.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelStatsAverageScore.AutoSize = True
        Me.LabelStatsAverageScore.Location = New System.Drawing.Point(248, 44)
        Me.LabelStatsAverageScore.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.LabelStatsAverageScore.Name = "LabelStatsAverageScore"
        Me.LabelStatsAverageScore.Size = New System.Drawing.Size(239, 20)
        Me.LabelStatsAverageScore.TabIndex = 4
        '
        'RichTextBoxStatsAdvices
        '
        Me.TableLayoutPanel6.SetColumnSpan(Me.RichTextBoxStatsAdvices, 2)
        Me.RichTextBoxStatsAdvices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBoxStatsAdvices.Location = New System.Drawing.Point(3, 182)
        Me.RichTextBoxStatsAdvices.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.RichTextBoxStatsAdvices.Name = "RichTextBoxStatsAdvices"
        Me.RichTextBoxStatsAdvices.Size = New System.Drawing.Size(484, 95)
        Me.RichTextBoxStatsAdvices.TabIndex = 5
        Me.RichTextBoxStatsAdvices.Text = ""
        '
        'RichTextBoxStatsComments
        '
        Me.TableLayoutPanel6.SetColumnSpan(Me.RichTextBoxStatsComments, 2)
        Me.RichTextBoxStatsComments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBoxStatsComments.Location = New System.Drawing.Point(3, 74)
        Me.RichTextBoxStatsComments.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.RichTextBoxStatsComments.Name = "RichTextBoxStatsComments"
        Me.RichTextBoxStatsComments.Size = New System.Drawing.Size(484, 95)
        Me.RichTextBoxStatsComments.TabIndex = 6
        Me.RichTextBoxStatsComments.Text = ""
        '
        'TabPageSettings
        '
        Me.TabPageSettings.Controls.Add(Me.ButtonSettingsAddTarget)
        Me.TabPageSettings.Location = New System.Drawing.Point(4, 22)
        Me.TabPageSettings.Name = "TabPageSettings"
        Me.TabPageSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageSettings.Size = New System.Drawing.Size(998, 627)
        Me.TabPageSettings.TabIndex = 3
        Me.TabPageSettings.UseVisualStyleBackColor = True
        '
        'ButtonSettingsAddTarget
        '
        Me.ButtonSettingsAddTarget.Location = New System.Drawing.Point(104, 79)
        Me.ButtonSettingsAddTarget.Name = "ButtonSettingsAddTarget"
        Me.ButtonSettingsAddTarget.Size = New System.Drawing.Size(178, 69)
        Me.ButtonSettingsAddTarget.TabIndex = 1
        Me.ButtonSettingsAddTarget.Text = "Ajouter Cible"
        Me.ButtonSettingsAddTarget.UseVisualStyleBackColor = True
        '
        'TabPageEmpty
        '
        Me.TabPageEmpty.Location = New System.Drawing.Point(4, 22)
        Me.TabPageEmpty.Name = "TabPageEmpty"
        Me.TabPageEmpty.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageEmpty.Size = New System.Drawing.Size(998, 627)
        Me.TabPageEmpty.TabIndex = 4
        Me.TabPageEmpty.UseVisualStyleBackColor = True
        '
        'OpenFileDialogImg
        '
        Me.OpenFileDialogImg.FileName = "OpenFileDialog1"
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
        Me.ButtonStatistics.Size = New System.Drawing.Size(244, 157)
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
        Me.ButtonShootingSession.Size = New System.Drawing.Size(244, 157)
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
        Me.ButtonUser.Size = New System.Drawing.Size(244, 157)
        Me.ButtonUser.TabIndex = 0
        Me.ButtonUser.Text = "Connexion"
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
        Me.ButtonSettings.Size = New System.Drawing.Size(244, 157)
        Me.ButtonSettings.TabIndex = 3
        Me.ButtonSettings.Text = "Paramètres"
        Me.ButtonSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonSettings.UseVisualStyleBackColor = False
        '
        'PictureBoxUserPicture
        '
        Me.PictureBoxUserPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableLayoutPanel3.SetColumnSpan(Me.PictureBoxUserPicture, 3)
        Me.PictureBoxUserPicture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBoxUserPicture.Location = New System.Drawing.Point(52, 35)
        Me.PictureBoxUserPicture.Name = "PictureBoxUserPicture"
        Me.TableLayoutPanel3.SetRowSpan(Me.PictureBoxUserPicture, 5)
        Me.PictureBoxUserPicture.Size = New System.Drawing.Size(141, 154)
        Me.PictureBoxUserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxUserPicture.TabIndex = 0
        Me.PictureBoxUserPicture.TabStop = False
        '
        'PictureBoxTarget
        '
        Me.PictureBoxTarget.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBoxTarget.BackColor = System.Drawing.Color.Gray
        Me.TableLayoutPanel4.SetColumnSpan(Me.PictureBoxTarget, 12)
        Me.PictureBoxTarget.Location = New System.Drawing.Point(44, 29)
        Me.PictureBoxTarget.Name = "PictureBoxTarget"
        Me.TableLayoutPanel4.SetRowSpan(Me.PictureBoxTarget, 18)
        Me.PictureBoxTarget.Size = New System.Drawing.Size(500, 500)
        Me.PictureBoxTarget.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxTarget.TabIndex = 0
        Me.PictureBoxTarget.TabStop = False
        '
        'PictureBoxStats
        '
        Me.PictureBoxStats.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBoxStats.Location = New System.Drawing.Point(493, 3)
        Me.PictureBoxStats.Name = "PictureBoxStats"
        Me.TableLayoutPanel6.SetRowSpan(Me.PictureBoxStats, 4)
        Me.PictureBoxStats.Size = New System.Drawing.Size(484, 274)
        Me.PictureBoxStats.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxStats.TabIndex = 0
        Me.PictureBoxStats.TabStop = False
        '
        'FormMain
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1280, 720)
        Me.MinimumSize = New System.Drawing.Size(1280, 720)
        Me.Name = "FormMain"
        Me.Text = "TB Target"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TabControlMain.ResumeLayout(False)
        Me.TabPageUserConnected.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TabPageShootingSession.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        CType(Me.DataGridViewResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageStatistics.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        CType(Me.ChartStats, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TabPageSettings.ResumeLayout(False)
        CType(Me.PictureBoxUserPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxTarget, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxStats, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TabPageUserConnected As TabPage
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents ButtonUserSave As Button
    Friend WithEvents PictureBoxUserPicture As PictureBox
    Friend WithEvents TextBoxUserUsername As TextBox
    Friend WithEvents TextBoxUserFirstname As TextBox
    Friend WithEvents TextBoxUserPassword As TextBox
    Friend WithEvents TextBoxUserPasswordConfirm As TextBox
    Friend WithEvents TextBoxUserEmail As TextBox
    Friend WithEvents ComboBoxUserCategory As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonUserLogOut As Button
    Friend WithEvents TextBoxUserLastname As TextBox
    Friend WithEvents TabPageShootingSession As TabPage
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents PictureBoxTarget As PictureBox
    Friend WithEvents TabPageStatistics As TabPage
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TabPageSettings As TabPage
    Friend WithEvents TabPageEmpty As TabPage
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBoxShootingTargetSelection As ComboBox
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridViewResults As DataGridView
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LabelLastShootDistance As Label
    Friend WithEvents LabelLastShootScore As Label
    Friend WithEvents OpenFileDialogImg As OpenFileDialog
    Friend WithEvents ButtonSettingsAddTarget As Button
    Friend WithEvents ColShoot As DataGridViewTextBoxColumn
    Friend WithEvents ColDistance As DataGridViewTextBoxColumn
    Friend WithEvents ColScore As DataGridViewTextBoxColumn
    Friend WithEvents ColTotal As DataGridViewTextBoxColumn
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBoxShotsCount As ComboBox
    Friend WithEvents ButtonStartShootingSession As Button
    Friend WithEvents ButtonCloseShootingSession As Button
    Friend WithEvents ChartStats As DataVisualization.Charting.Chart
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents PictureBoxStats As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents ComboBoxStatsSession As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents LabelStatsAverageScore As Label
    Friend WithEvents LabelShootingSessionAdvices As Label
    Friend WithEvents RichTextBoxStatsAdvices As RichTextBox
    Friend WithEvents RichTextBoxStatsComments As RichTextBox
End Class
