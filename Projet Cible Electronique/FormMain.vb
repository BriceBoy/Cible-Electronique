Imports System.IO

Public Class FormMain

    Private _currentUser As User
    Private _currentTarget As Target

    Private _dataSetElectronicTarget As DataSetElectronicTarget
    Private _targetsTableAdapter As DataSetElectronicTargetTableAdapters.targetsTableAdapter

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TabControlMain.Appearance = TabAppearance.FlatButtons
        Me.TabControlMain.ItemSize = New Size(0, 1)
        Me.TabControlMain.SizeMode = TabSizeMode.Fixed
        _dataSetElectronicTarget = New DataSetElectronicTarget
        _targetsTableAdapter = New DataSetElectronicTargetTableAdapters.targetsTableAdapter
        Dim _formLogin As New FormLogin(Me)
        _formLogin.ShowDialog()
        FillComboboxTargets()
        Me.TabControlMain.SelectedIndex = 1
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

    Private Sub FillComboboxTargets()
        Me.ComboBoxShootingTargetSelection.Items.Clear()
        _targetsTableAdapter.Fill(_dataSetElectronicTarget.targets)
        For Each target As DataSetElectronicTarget.targetsRow In _dataSetElectronicTarget.targets
            Me.ComboBoxShootingTargetSelection.Items.Add(target.name)
        Next
    End Sub

    Private Sub ComboBoxShootingTargetSelection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxShootingTargetSelection.SelectedIndexChanged
        If Me.ComboBoxShootingTargetSelection.SelectedIndex >= 0 Then
            _currentTarget = New Target
            _currentTarget.LoadTarget(Me.ComboBoxShootingTargetSelection.Items(Me.ComboBoxShootingTargetSelection.SelectedIndex))
            LoadTargetImage(_currentTarget.Img)
        End If
    End Sub

    Private Sub LoadTargetImage(ByVal targetName As String)
        _targetsTableAdapter.FillByName(_dataSetElectronicTarget.targets, targetName)
        Dim targetRow As DataSetElectronicTarget.targetsRow = _dataSetElectronicTarget.targets.Rows(0)
        Me.PictureBoxTarget.Image = byteArrayToImage(targetRow.img)
    End Sub

    Private Sub LoadTargetImage(ByVal img As Image)
        Me.PictureBoxTarget.Image = img
    End Sub

    Private Sub ButtonSettingsAddTarget_Click(sender As Object, e As EventArgs) Handles ButtonSettingsAddTarget.Click
        Dim _formAddTarget As New FormAddTarget()
        _formAddTarget.ShowDialog()
    End Sub

    Private Sub PictureBoxTarget_Click(sender As Object, e As EventArgs) Handles PictureBoxTarget.Click
        Dim mousePos As Point = PictureBoxTarget.PointToClient(MousePosition)
        Dim img As Image = Me.PictureBoxTarget.Image
        Dim g As Graphics = Graphics.FromImage(img)
        With g
            .PageUnit = GraphicsUnit.Pixel
            .FillEllipse(Brushes.Red, mousePos.X - 5, mousePos.Y - 5, 10, 10)
            .Save()
        End With
        Me.PictureBoxTarget.Image = img
    End Sub
End Class
