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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
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
        Me.TabPageUserConnected = New System.Windows.Forms.TabPage()
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
        Me.ButtonUserLogOut = New System.Windows.Forms.Button()
        Me.TextBoxUserLastname = New System.Windows.Forms.TextBox()
        Me.TabPageShootingSession = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ColShootNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDirection = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDistance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColScore = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColSum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPageStatistics = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.TabPageSettings = New System.Windows.Forms.TabPage()
        Me.TabPageEmpty = New System.Windows.Forms.TabPage()
        Me.StatusStrip1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabControlMain.SuspendLayout()
        Me.TabPageUserConnected.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.PictureBoxUserPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageShootingSession.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageStatistics.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(250, 655)
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
        'LabelPaint1
        '
        Me.LabelPaint1.AutoSize = True
        Me.LabelPaint1.BackColor = System.Drawing.Color.Black
        Me.LabelPaint1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelPaint1.Location = New System.Drawing.Point(250, 0)
        Me.LabelPaint1.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelPaint1.Name = "LabelPaint1"
        Me.LabelPaint1.Size = New System.Drawing.Size(2, 655)
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
        Me.TabControlMain.Size = New System.Drawing.Size(1006, 649)
        Me.TabControlMain.TabIndex = 5
        '
        'TabPageUserConnected
        '
        Me.TabPageUserConnected.Controls.Add(Me.TableLayoutPanel3)
        Me.TabPageUserConnected.Location = New System.Drawing.Point(4, 29)
        Me.TabPageUserConnected.Name = "TabPageUserConnected"
        Me.TabPageUserConnected.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageUserConnected.Size = New System.Drawing.Size(998, 616)
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
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(992, 610)
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
        Me.TabPageShootingSession.Size = New System.Drawing.Size(998, 623)
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
        Me.TableLayoutPanel4.Controls.Add(Me.PictureBox1, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.DataGridView1, 12, 1)
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
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(992, 617)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.Gray
        Me.TableLayoutPanel4.SetColumnSpan(Me.PictureBox1, 12)
        Me.PictureBox1.Location = New System.Drawing.Point(44, 50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.TableLayoutPanel4.SetRowSpan(Me.PictureBox1, 18)
        Me.PictureBox1.Size = New System.Drawing.Size(500, 500)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColShootNumber, Me.ColDirection, Me.ColDistance, Me.ColScore, Me.ColSum})
        Me.TableLayoutPanel4.SetColumnSpan(Me.DataGridView1, 8)
        Me.DataGridView1.Location = New System.Drawing.Point(604, 50)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 3, 20, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.TableLayoutPanel4.SetRowSpan(Me.DataGridView1, 18)
        Me.DataGridView1.Size = New System.Drawing.Size(355, 500)
        Me.DataGridView1.TabIndex = 1
        '
        'ColShootNumber
        '
        Me.ColShootNumber.HeaderText = "Tir"
        Me.ColShootNumber.Name = "ColShootNumber"
        Me.ColShootNumber.ReadOnly = True
        '
        'ColDirection
        '
        Me.ColDirection.HeaderText = "Direct."
        Me.ColDirection.Name = "ColDirection"
        Me.ColDirection.ReadOnly = True
        '
        'ColDistance
        '
        Me.ColDistance.HeaderText = "Dist."
        Me.ColDistance.Name = "ColDistance"
        Me.ColDistance.ReadOnly = True
        '
        'ColScore
        '
        Me.ColScore.HeaderText = "Score"
        Me.ColScore.Name = "ColScore"
        Me.ColScore.ReadOnly = True
        '
        'ColSum
        '
        Me.ColSum.HeaderText = "Total"
        Me.ColSum.Name = "ColSum"
        Me.ColSum.ReadOnly = True
        '
        'TabPageStatistics
        '
        Me.TabPageStatistics.Controls.Add(Me.TableLayoutPanel5)
        Me.TabPageStatistics.Location = New System.Drawing.Point(4, 22)
        Me.TabPageStatistics.Name = "TabPageStatistics"
        Me.TabPageStatistics.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageStatistics.Size = New System.Drawing.Size(998, 623)
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
        Me.TableLayoutPanel5.Controls.Add(Me.Chart1, 1, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.GroupBox1, 1, 11)
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
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(992, 617)
        Me.TableLayoutPanel5.TabIndex = 0
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.TableLayoutPanel5.SetColumnSpan(Me.Chart1, 13)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(52, 33)
        Me.Chart1.Name = "Chart1"
        Me.TableLayoutPanel5.SetRowSpan(Me.Chart1, 9)
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(631, 264)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'GroupBox1
        '
        Me.TableLayoutPanel5.SetColumnSpan(Me.GroupBox1, 18)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel6)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(52, 333)
        Me.GroupBox1.Name = "GroupBox1"
        Me.TableLayoutPanel5.SetRowSpan(Me.GroupBox1, 8)
        Me.GroupBox1.Size = New System.Drawing.Size(876, 234)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sélection"
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 10
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.RadioButton1, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.RadioButton2, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.RadioButton3, 0, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.RadioButton4, 0, 3)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 22)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 5
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(870, 209)
        Me.TableLayoutPanel6.TabIndex = 0
        '
        'RadioButton1
        '
        Me.RadioButton1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButton1.AutoSize = True
        Me.TableLayoutPanel6.SetColumnSpan(Me.RadioButton1, 3)
        Me.RadioButton1.Location = New System.Drawing.Point(3, 3)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(255, 35)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Période"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButton2.AutoSize = True
        Me.TableLayoutPanel6.SetColumnSpan(Me.RadioButton2, 3)
        Me.RadioButton2.Location = New System.Drawing.Point(3, 44)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(255, 35)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Session"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButton3.AutoSize = True
        Me.TableLayoutPanel6.SetColumnSpan(Me.RadioButton3, 3)
        Me.RadioButton3.Location = New System.Drawing.Point(3, 85)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(255, 35)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Meilleurs scores"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButton4.AutoSize = True
        Me.TableLayoutPanel6.SetColumnSpan(Me.RadioButton4, 3)
        Me.RadioButton4.Location = New System.Drawing.Point(3, 126)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(255, 35)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Sélection manuelle"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'TabPageSettings
        '
        Me.TabPageSettings.Location = New System.Drawing.Point(4, 22)
        Me.TabPageSettings.Name = "TabPageSettings"
        Me.TabPageSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageSettings.Size = New System.Drawing.Size(998, 623)
        Me.TabPageSettings.TabIndex = 3
        Me.TabPageSettings.UseVisualStyleBackColor = True
        '
        'TabPageEmpty
        '
        Me.TabPageEmpty.Location = New System.Drawing.Point(4, 22)
        Me.TabPageEmpty.Name = "TabPageEmpty"
        Me.TabPageEmpty.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageEmpty.Size = New System.Drawing.Size(998, 623)
        Me.TabPageEmpty.TabIndex = 4
        Me.TabPageEmpty.UseVisualStyleBackColor = True
        '
        'FormMain
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        CType(Me.PictureBoxUserPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageShootingSession.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageStatistics.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ColShootNumber As DataGridViewTextBoxColumn
    Friend WithEvents ColDirection As DataGridViewTextBoxColumn
    Friend WithEvents ColDistance As DataGridViewTextBoxColumn
    Friend WithEvents ColScore As DataGridViewTextBoxColumn
    Friend WithEvents ColSum As DataGridViewTextBoxColumn
    Friend WithEvents TabPageStatistics As TabPage
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents TabPageSettings As TabPage
    Friend WithEvents TabPageEmpty As TabPage
End Class
