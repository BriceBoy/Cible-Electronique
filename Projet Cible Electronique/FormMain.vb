Imports System.IO
Imports System.Runtime.Remoting.Metadata.W3cXsd2001
Imports Microsoft.VisualBasic.Devices

Public Class FormMain

    Private _currentUser As User
    Private _currentTarget As Target
    Private _currentShootingSession As ShootingSession

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
            EnableDisableButtonStart()
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
        Dim img = Me.PictureBoxTarget.Image
        Dim mousePos = Me.PictureBoxTarget.PointToClient(Cursor.Position)
        Dim newPoint = TranslateZoomMousePosition(mousePos)
        Dim centerPoint As New Point(img.Width / 2, img.Height / 2)
        Dim g As Graphics = Graphics.FromImage(img)
        With g
            .PageUnit = GraphicsUnit.Pixel
            .FillEllipse(Brushes.Red, newPoint.X - 5, newPoint.Y - 5, 10, 10)
            .Save()
        End With
        Me.PictureBoxTarget.Image = img
        Dim pointAxis = newPoint - centerPoint
        pointAxis = getRealCoord(pointAxis, img, _currentTarget.WidthMM, _currentTarget.HeightMM)
        Console.WriteLine(newPoint.ToString & "/" & Me.PictureBoxTarget.Image.Size.ToString)
        Console.WriteLine(newPoint.ToString & "-" & centerPoint.ToString & "=" & pointAxis.ToString)
        Console.WriteLine(_currentTarget.getDistance(pointAxis.X, pointAxis.Y))
    End Sub

    Private Sub ButtonStartShootingSession_Click(sender As Object, e As EventArgs) Handles ButtonStartShootingSession.Click
        Dim shotsCount As Integer
        If Me.ComboBoxShotsCount.SelectedIndex < 0 Then
            MsgBox("Veuillez sélectionner le nombre de tirs avant de lancer la session", MsgBoxStyle.Information, "Erreur")
            Exit Sub
        End If

        If Not Integer.TryParse(Me.ComboBoxShotsCount.Items(Me.ComboBoxShotsCount.SelectedIndex), shotsCount) Then
            shotsCount = 0
        End If
        _currentShootingSession = New ShootingSession(_currentUser, _currentTarget, shotsCount)
        Me.ButtonCloseShootingSession.Enabled = True
        Me.ButtonStartShootingSession.Enabled = False
    End Sub

    Private Sub ButtonCloseShootingSession_Click(sender As Object, e As EventArgs) Handles ButtonCloseShootingSession.Click
        If Not IsNothing(_currentShootingSession.User) Then
            _currentShootingSession.ImageResult = Me.PictureBoxTarget.Image
            _currentShootingSession.SaveToDatabase()
        End If
        Me.ButtonStartShootingSession.Enabled = True
        Me.ButtonCloseShootingSession.Enabled = False
    End Sub

    Private Sub EnableDisableButtonStart()
        Me.ButtonStartShootingSession.Enabled = Me.ComboBoxShootingTargetSelection.SelectedIndex >= 0 And Me.ComboBoxShotsCount.SelectedIndex >= 0
    End Sub

    Private Sub ComboBoxShotsCount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxShotsCount.SelectedIndexChanged
        EnableDisableButtonStart()
    End Sub

    Private Function TranslateZoomMousePosition(ByVal coordinates As Point) As Point
        With Me.PictureBoxTarget
            Dim img As Image = .Image
            If (Me.PictureBoxTarget.Image Is Nothing) Then
                Return coordinates
            End If

            If ((.Width = 0) OrElse ((.Height = 0) OrElse ((img.Width = 0) OrElse (img.Height = 0)))) Then
                Return coordinates
            End If

            Dim imageAspect As Single = (CType(img.Width, Single) / img.Height)
            Dim controlAspect As Single = (CType(.Width, Single) / .Height)
            Dim newX As Single = coordinates.X
            Dim newY As Single = coordinates.Y
            If (imageAspect > controlAspect) Then
                ' Limité en largeur
                Dim ratioWidth As Single = (CType(img.Width, Single) / .Width)
                newX = (newX * ratioWidth)
                Dim scale As Single = (CType(.Width, Single) / img.Width)
                Dim displayHeight As Single = (scale * img.Height)
                Dim diffHeight As Single = (.Height - displayHeight)
                diffHeight /= 2
                newY -= diffHeight
                newY /= scale
            Else
                'Limité en hauteur
                Dim ratioHeight As Single = (CType(img.Height, Single) / .Height)
                newY = (newY * ratioHeight)
                Dim scale As Single = (CType(.Height, Single) / img.Height)
                Dim displayWidth As Single = (scale * img.Width)
                Dim diffWidth As Single = (.Width - displayWidth)
                diffWidth /= 2
                newX -= diffWidth
                newX /= scale
            End If

            Return New Point(CType(newX, Integer), CType(newY, Integer))
        End With
    End Function

    Private Function getRealCoord(ByVal pxPoint As Point, ByVal img As Image, ByVal realWidth As Decimal, ByVal realHeight As Decimal) As Point
        Dim imgWidthMM As Decimal = img.Width / img.HorizontalResolution * 25.4
        Dim imgHeightMM As Decimal = img.Height / img.VerticalResolution * 25.4
        Dim horizontalRatio As Decimal = imgWidthMM / realWidth
        Dim verticalRatio As Decimal = imgHeightMM / realHeight
        Dim x As Decimal = pxPoint.X * horizontalRatio / img.HorizontalResolution * 25.4
        Dim y As Decimal = pxPoint.Y * verticalRatio / img.HorizontalResolution * 25.4
        Dim realPoint As New Point(x, y)
        Return realPoint
    End Function

End Class
