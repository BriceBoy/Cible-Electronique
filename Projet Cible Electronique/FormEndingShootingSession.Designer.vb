<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEndingShootingSession
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButtonRifle = New System.Windows.Forms.RadioButton()
        Me.RadioButtonGun = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumericUpDownDistance = New System.Windows.Forms.NumericUpDown()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RichTextBoxComments = New System.Windows.Forms.RichTextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.NumericUpDownDistance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.RadioButtonRifle, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.RadioButtonGun, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.NumericUpDownDistance, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonSave, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(468, 307)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Arme :"
        '
        'RadioButtonRifle
        '
        Me.RadioButtonRifle.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButtonRifle.AutoSize = True
        Me.RadioButtonRifle.Location = New System.Drawing.Point(159, 5)
        Me.RadioButtonRifle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadioButtonRifle.Name = "RadioButtonRifle"
        Me.RadioButtonRifle.Size = New System.Drawing.Size(148, 20)
        Me.RadioButtonRifle.TabIndex = 1
        Me.RadioButtonRifle.TabStop = True
        Me.RadioButtonRifle.Text = "Carabine"
        Me.RadioButtonRifle.UseVisualStyleBackColor = True
        '
        'RadioButtonGun
        '
        Me.RadioButtonGun.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButtonGun.AutoSize = True
        Me.RadioButtonGun.Location = New System.Drawing.Point(314, 5)
        Me.RadioButtonGun.Name = "RadioButtonGun"
        Me.RadioButtonGun.Size = New System.Drawing.Size(151, 20)
        Me.RadioButtonGun.TabIndex = 2
        Me.RadioButtonGun.TabStop = True
        Me.RadioButtonGun.Text = "Pistolet"
        Me.RadioButtonGun.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 37)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Distance :"
        '
        'NumericUpDownDistance
        '
        Me.NumericUpDownDistance.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.SetColumnSpan(Me.NumericUpDownDistance, 2)
        Me.NumericUpDownDistance.Location = New System.Drawing.Point(158, 34)
        Me.NumericUpDownDistance.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.NumericUpDownDistance.Name = "NumericUpDownDistance"
        Me.NumericUpDownDistance.Size = New System.Drawing.Size(307, 22)
        Me.NumericUpDownDistance.TabIndex = 4
        '
        'ButtonSave
        '
        Me.ButtonSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonSave.Location = New System.Drawing.Point(158, 277)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(150, 26)
        Me.ButtonSave.TabIndex = 6
        Me.ButtonSave.Text = "Sauvegarder"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.GroupBox1, 3)
        Me.GroupBox1.Controls.Add(Me.RichTextBoxComments)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(4, 64)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(460, 206)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Commentaires"
        '
        'RichTextBoxComments
        '
        Me.RichTextBoxComments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBoxComments.Location = New System.Drawing.Point(4, 19)
        Me.RichTextBoxComments.Name = "RichTextBoxComments"
        Me.RichTextBoxComments.Size = New System.Drawing.Size(452, 183)
        Me.RichTextBoxComments.TabIndex = 0
        Me.RichTextBoxComments.Text = ""
        '
        'FormEndingShootingSession
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 307)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormEndingShootingSession"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Commentaires de séance"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.NumericUpDownDistance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents RadioButtonRifle As RadioButton
    Friend WithEvents RadioButtonGun As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents NumericUpDownDistance As NumericUpDown
    Friend WithEvents ButtonSave As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RichTextBoxComments As RichTextBox
End Class
