Imports System.IO

Public Class FormMain

    Private _currentUser As User

    Private _dataSetElectronicTarget As DataSetTBTarget
    Private _targetsTableAdapter As DataSetTBTargetTableAdapters.targetsTableAdapter

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TabControlMain.Appearance = TabAppearance.FlatButtons
        Me.TabControlMain.ItemSize = New Size(0, 1)
        Me.TabControlMain.SizeMode = TabSizeMode.Fixed
        Me.TabControlMain.SelectedIndex = 1
        _dataSetElectronicTarget = New DataSetTBTarget
        _targetsTableAdapter = New DataSetTBTargetTableAdapters.targetsTableAdapter
        Dim _formLogin As New FormLogin(Me)
        _formLogin.ShowDialog()
    End Sub

    Public Sub ChangeUser(ByRef user As User)
        If Not IsNothing(user) Then
            _currentUser = user
            LoadAccountInfos()
            Me.TabControlMain.SelectedIndex = 0
        Else
            _currentUser = Nothing
        End If
    End Sub

    'Private Sub FormMain_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
    '    Me.ToolStripStatusLabel1.Text = Me.ButtonSettings.Height
    'End Sub

    Private Sub ButtonUser_Click(sender As Object, e As EventArgs) Handles ButtonUser.Click
        If IsNothing(_currentUser) Then
            Me.TabControlMain.SelectedIndex = 4
            Dim _formLogin As New FormLogin(Me)
            _formLogin.ShowDialog()
        Else
            LoadAccountInfos()
            Me.TabControlMain.SelectedIndex = 0
        End If
    End Sub

    Private Sub ButtonShootingSession_Click(sender As Object, e As EventArgs) Handles ButtonShootingSession.Click
        Me.TabControlMain.SelectedIndex = 1
        FillComboboxTargets()
    End Sub

    Private Sub ButtonStatistics_Click(sender As Object, e As EventArgs) Handles ButtonStatistics.Click
        Me.TabControlMain.SelectedIndex = 2
    End Sub

    Private Sub ButtonSettings_Click(sender As Object, e As EventArgs) Handles ButtonSettings.Click
        Me.TabControlMain.SelectedIndex = 3
    End Sub

    Private Sub ButtonUserLogOut_Click(sender As Object, e As EventArgs) Handles ButtonUserLogOut.Click
        _currentUser = Nothing
        ClearUserPage()
    End Sub

    Private Sub ClearUserPage()
        Me.ButtonUser.Text = "Connexion"

        Me.TextBoxUserUsername.Text = ""
        Me.TextBoxUserFirstname.Text = ""
        Me.TextBoxUserLastname.Text = ""
        Me.TextBoxUserPassword.Text = ""
        Me.TextBoxUserPasswordConfirm.Text = ""
        Me.TextBoxUserEmail.Text = ""
        Me.ComboBoxUserCategory.Text = ""
        Me.PictureBoxUserPicture.Image = Nothing
    End Sub

    Private Sub LoadAccountInfos()
        If Not IsNothing(_currentUser) Then
            With _currentUser
                Me.ButtonUser.Text = _currentUser.Username

                Me.TextBoxUserFirstname.Text = .FirstName
                Me.TextBoxUserLastname.Text = .Lastname
                Me.TextBoxUserUsername.Text = .Username
                Me.TextBoxUserEmail.Text = .EMail
                Me.ComboBoxUserCategory.Text = .Category
                If Not IsNothing(.Picture) Then
                    Me.PictureBoxUserPicture.Image = .Picture
                End If
            End With
        End If
    End Sub

    Private Function imgToByteArray(ByVal img As Image) As Byte()
        Using mStream As New MemoryStream()
            img.Save(mStream, img.RawFormat)
            Return mStream.ToArray()
        End Using
    End Function

    Private Function byteArrayToImage(ByVal byteArrayIn As Byte()) As Image
        Using mStream As New MemoryStream(byteArrayIn)
            Return Image.FromStream(mStream)
        End Using
    End Function

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.OpenFileDialogImg.FileName = ""
        If Me.OpenFileDialogImg.ShowDialog = DialogResult.OK Then
            Dim name As String = "test"
            Dim widthMM As Integer = 0
            Dim heightMM As Integer = 0
            Dim widthPX As Integer = 0
            Dim heightPX As Integer = 0
            Dim img As Image = Nothing
            img = Image.FromFile(Me.OpenFileDialogImg.FileName)

            Dim targetRow As DataSetTBTarget.targetsRow
            targetRow = _dataSetElectronicTarget.targets.NewtargetsRow
            With targetRow
                .name = name
                .width_mm = widthMM
                .height_mm = heightMM
                .width_px = widthPX
                .height_px = heightPX
                .img = imgToByteArray(img)
            End With
            _dataSetElectronicTarget.targets.AddtargetsRow(targetRow)
            _targetsTableAdapter.Update(_dataSetElectronicTarget.targets)
        End If
    End Sub

    Private Sub FillComboboxTargets()
        Me.ComboBoxShootingTargetSelection.Items.Clear()
        _targetsTableAdapter.Fill(_dataSetElectronicTarget.targets)
        For Each target As DataSetTBTarget.targetsRow In _dataSetElectronicTarget.targets
            Me.ComboBoxShootingTargetSelection.Items.Add(target.name)
        Next
    End Sub

    Private Sub ComboBoxShootingTargetSelection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxShootingTargetSelection.SelectedIndexChanged
        If Me.ComboBoxShootingTargetSelection.SelectedIndex >= 0 Then
            LoadTargetImage(Me.ComboBoxShootingTargetSelection.Items(Me.ComboBoxShootingTargetSelection.SelectedIndex))
        End If
    End Sub

    Private Sub LoadTargetImage(ByVal targetName As String)
        _targetsTableAdapter.FillByName(_dataSetElectronicTarget.targets, targetName)
        Dim targetRow As DataSetTBTarget.targetsRow = _dataSetElectronicTarget.targets.Rows(0)
        Me.PictureBox1.Image = byteArrayToImage(targetRow.img)
    End Sub
End Class
