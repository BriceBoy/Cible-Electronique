Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting

Public Class FormMain

    Private _currentUser As User
    Private _currentTarget As Target
    Private _currentShootingSession As ShootingSession
    Private _currentStats As Stats
    Private _shootingSessionStats As ShootingSession

    Private _sessionInProgress As Boolean
    Private _currentShotNumber As Integer
    Private _currentScore As Integer

    Private _dataSetElectronicTarget As DataSetElectronicTarget
    Private _targetsTableAdapter As DataSetElectronicTargetTableAdapters.targetsTableAdapter
    Private _sessionsTableAdapter As DataSetElectronicTargetTableAdapters.shooting_sessionsTableAdapter

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _dataSetElectronicTarget = New DataSetElectronicTarget
        _targetsTableAdapter = New DataSetElectronicTargetTableAdapters.targetsTableAdapter
        _sessionsTableAdapter = New DataSetElectronicTargetTableAdapters.shooting_sessionsTableAdapter
        _sessionInProgress = False

        Me.TabControlMain.Appearance = TabAppearance.FlatButtons
        Me.TabControlMain.ItemSize = New Size(0, 1)
        Me.TabControlMain.SizeMode = TabSizeMode.Fixed
        FillComboboxTargets()

        Dim _formLogin As New FormLogin(Me)
        _formLogin.ShowDialog()

        Me.TabControlMain.SelectedIndex = 1
        If Not IsNothing(_currentUser) Then
            Me.ToolStripStatusLabel1.Text = _currentUser.Username
        End If
    End Sub

    Public Sub ChangeUser(ByRef user As User)
        If Not IsNothing(user) Then
            _currentUser = user
            LoadAccountInfos()
            Me.TabControlMain.SelectedIndex = 0
            Me.ToolStripStatusLabel1.Text = _currentUser.Username
        Else
            _currentUser = Nothing
        End If
    End Sub

    Private Sub ButtonUser_Click(sender As Object, e As EventArgs) Handles ButtonUser.Click
        If IsNothing(_currentUser) Then
            Me.TabControlMain.SelectedIndex = 4 'Page blanche
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
        FillComboboxSessions()
        LoadLastSessionsStats()
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

    Private Function ImgToByteArray(ByVal img As Image) As Byte()
        Using mStream As New MemoryStream()
            img.Save(mStream, img.RawFormat)
            Return mStream.ToArray()
        End Using
    End Function

    Private Function ByteArrayToImage(ByVal byteArrayIn As Byte()) As Image
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
        Me.PictureBoxTarget.Image = ByteArrayToImage(targetRow.img)
    End Sub

    Private Sub LoadTargetImage(ByVal img As Image)
        Me.PictureBoxTarget.Image = img
    End Sub

    Private Sub ButtonSettingsAddTarget_Click(sender As Object, e As EventArgs) Handles ButtonSettingsAddTarget.Click
        Dim _formAddTarget As New FormAddTarget()
        _formAddTarget.ShowDialog()
    End Sub

    Private Sub PictureBoxTarget_Click(sender As Object, e As EventArgs) Handles PictureBoxTarget.Click
        If IsNothing(_currentShootingSession) Then
            MsgBox("Lancer une session de tir pour commencer", MsgBoxStyle.Information, "Démarrage")
        ElseIf _currentShootingSession.ShotsRemaining > 0 Then
            AddAShotByMouse()
        Else
            MsgBox("Vous avez terminé la session")
        End If
    End Sub

    Private Sub AddAShotByMouse()
        Dim msg As String = _currentShootingSession.ShowAdvices
        If msg <> "" Then
            Me.PictureBoxTarget.Image = _currentTarget.Img
            Me.LabelShootingSessionAdvices.Text = msg
        End If

        Dim img As Image = Me.PictureBoxTarget.Image
        Dim mousePosition = Me.PictureBoxTarget.PointToClient(Cursor.Position)
        Dim imgPosition = TranslateZoomMousePosition(mousePosition)
        Dim centerPosition As New Point(img.Width / 2, img.Height / 2)
        PrintPointOnImg(imgPosition.X, imgPosition.Y)

        Dim graphPosition = imgPosition - centerPosition 'Relative position
        graphPosition = GetRealCoord(graphPosition, img, _currentTarget.WidthMM, _currentTarget.HeightMM) 'IRL position

        UpdateShootingSessionValuesOnDisplay(graphPosition.X, graphPosition.Y)
        _currentShootingSession.AddAShot(graphPosition.X, graphPosition.Y)
    End Sub

    Private Sub AddAShot(ByVal xGraph As Decimal, ByVal yGraph As Decimal)
        Dim msg As String = _currentShootingSession.ShowAdvices
        If msg <> "" Then
            Me.PictureBoxTarget.Image = _currentTarget.Img
            Me.LabelShootingSessionAdvices.Text = msg
        End If

        Dim ImgPosition As Point = GraphPositionToImgPosition(xGraph, yGraph)
        PrintPointOnImg(ImgPosition.X, ImgPosition.Y)
        UpdateShootingSessionValuesOnDisplay(xGraph, yGraph)
        _currentShootingSession.AddAShot(xGraph, yGraph)
    End Sub

    Private Sub PrintPointOnImg(ByVal xImg As Decimal, ByVal yImg As Decimal)
        Dim img As Image = Me.PictureBoxTarget.Image
        Dim g1 As Graphics = Graphics.FromImage(img)
        With g1
            .PageUnit = GraphicsUnit.Pixel
            .FillEllipse(Brushes.Red, xImg - 5, yImg - 5, 10, 10)
            .Save()
        End With
        Me.PictureBoxTarget.Image = img

        Dim finalImg As Image = _currentShootingSession.FinalPicture
        Dim g2 As Graphics = Graphics.FromImage(finalImg)
        With g2
            .PageUnit = GraphicsUnit.Pixel
            .FillEllipse(Brushes.Red, xImg - 5, yImg - 5, 10, 10)
            .Save()
        End With
        _currentShootingSession.FinalPicture = finalImg
    End Sub

    Private Sub UpdateShootingSessionValuesOnDisplay(ByVal xGraph As Decimal, ByVal yGraph As Decimal)
        Dim distance As Decimal = Decimal.Round(_currentTarget.GetDistance(xGraph, yGraph), 2)
        Dim score As Decimal = _currentTarget.GetScore(xGraph, yGraph)
        _currentScore += score
        Me.LabelLastShootDistance.Text = distance & " mm"
        Me.LabelLastShootScore.Text = score & " points"
        _currentShotNumber += 1
        Me.DataGridViewResults.Rows.Add(_currentShotNumber.ToString, distance.ToString, score.ToString, _currentScore.ToString)
        Me.ToolStripStatusLabel2.Text = "Tir n°" & _currentShotNumber
    End Sub

    Private Sub ButtonStartShootingSession_Click(sender As Object, e As EventArgs) Handles ButtonStartShootingSession.Click
        If Me.ComboBoxShotsCount.SelectedIndex < 0 Then
            MsgBox("Veuillez sélectionner le nombre de tirs avant de lancer la session", MsgBoxStyle.Information, "Erreur")
            Exit Sub
        End If

        _sessionInProgress = True
        _currentShotNumber = 0
        Me.ToolStripStatusLabel2.Text = "Tir n°" & _currentShotNumber

        Dim shotsToDo As Integer
        If Not Integer.TryParse(Me.ComboBoxShotsCount.Items(Me.ComboBoxShotsCount.SelectedIndex), shotsToDo) Then
            shotsToDo = 10000
        End If

        _currentShootingSession = New ShootingSession(_currentUser, _currentTarget, shotsToDo)
        Me.PictureBoxTarget.Image = _currentTarget.Img
        Me.DataGridViewResults.Rows.Clear()
        Me.ButtonCloseShootingSession.Enabled = True
        Me.ButtonStartShootingSession.Enabled = False
        Me.ComboBoxShootingTargetSelection.Enabled = False
        Me.ComboBoxShotsCount.Enabled = False
    End Sub

    Private Sub ButtonCloseShootingSession_Click(sender As Object, e As EventArgs) Handles ButtonCloseShootingSession.Click
        If Not IsNothing(_currentShootingSession.User) Then
            Dim formEnd As New FormEndingShootingSession(_currentShootingSession)
            formEnd.ShowDialog()
            _currentShootingSession.SaveToDatabase()
        End If

        Me.ButtonStartShootingSession.Enabled = True
        Me.ButtonCloseShootingSession.Enabled = False
        Me.ComboBoxShootingTargetSelection.Enabled = True
        Me.ComboBoxShotsCount.Enabled = True
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
                newX *= ratioWidth
                Dim scale As Single = (CType(.Width, Single) / img.Width)
                Dim displayHeight As Single = (scale * img.Height)
                Dim diffHeight As Single = (.Height - displayHeight)
                diffHeight /= 2
                newY -= diffHeight
                newY /= scale
            Else
                'Limité en hauteur
                Dim ratioHeight As Single = (CType(img.Height, Single) / .Height)
                newY *= ratioHeight
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

    Private Function GetRealCoord(ByVal pxPoint As Point, ByVal img As Image, ByVal realWidth As Decimal, ByVal realHeight As Decimal) As Point
        Dim imgWidthMM As Decimal = img.Width / img.HorizontalResolution * 25.4
        Dim imgHeightMM As Decimal = img.Height / img.VerticalResolution * 25.4
        Dim horizontalRatio As Decimal = realWidth / imgWidthMM
        Dim verticalRatio As Decimal = realHeight / imgHeightMM
        Dim x As Decimal = pxPoint.X * horizontalRatio / img.HorizontalResolution * 25.4
        Dim y As Decimal = pxPoint.Y * verticalRatio / img.HorizontalResolution * 25.4
        Dim realPoint As New Point(x, -y)
        Return realPoint
    End Function

    Public Function GraphPositionToImgPosition(ByVal xGraph As Decimal, ByVal yGraph As Decimal) As Point
        yGraph = -yGraph
        Dim img = Me.PictureBoxTarget.Image
        Dim realPositionMM = New Point(xGraph + (_currentTarget.WidthMM / 2), yGraph + (_currentTarget.HeightMM / 2))
        Dim imgWidthMM = img.Width / (img.HorizontalResolution * 25.4)
        Dim imgHeightMM = img.Height / (img.VerticalResolution * 25.4)
        Dim xOnImgMM As Decimal = realPositionMM.X * imgWidthMM / _currentTarget.WidthMM
        Dim yOnImgMM As Decimal = realPositionMM.Y * imgHeightMM / _currentTarget.HeightMM
        Dim xOnImgPX As Decimal = xOnImgMM * img.HorizontalResolution * 25.4
        Dim yOnImgPX As Decimal = yOnImgMM * img.VerticalResolution * 25.4
        Return New Point(xOnImgPX, yOnImgPX)
    End Function

    Private Sub FillComboboxSessions()
        Me.ComboBoxStatsSession.Items.Clear()
        If IsNothing(_currentUser) Then
            MsgBox("Veuillez vous connecter pour accéder à vos statistiques", MsgBoxStyle.Information, "connexion nécessaire")
            Exit Sub
        End If
        _sessionsTableAdapter.FillByUsername(_dataSetElectronicTarget.shooting_sessions, _currentUser.Username)
        For Each session As DataSetElectronicTarget.shooting_sessionsRow In _dataSetElectronicTarget.shooting_sessions
            Me.ComboBoxStatsSession.Items.Add(session.session_date.ToString & "_" & session.id)
        Next
    End Sub

    Private Sub ComboBoxStatsSession_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxStatsSession.SelectedIndexChanged
        Dim text As String = Me.ComboBoxStatsSession.Items(Me.ComboBoxStatsSession.SelectedIndex).ToString
        text = text.Split("_")(1)
        Dim id As Integer = CInt(text)
        Dim session As New ShootingSession(id)
        Dim stats As New Stats(session.StrShots, session.Target)
        Me.LabelStatsAverageScore.Text = stats.AverageScore.ToString("0.00")
        Me.RichTextBoxStatsComments.Text = session.Comments()
        Me.RichTextBoxStatsAdvices.Text = stats.SmartSystem()
        Me.PictureBoxStats.Image = session.FinalPicture
    End Sub

    Private Sub LoadLastSessionsStats()
        Dim serie1 As New Series()
        _sessionsTableAdapter.FillByUsername(_dataSetElectronicTarget.shooting_sessions, _currentUser.Username)
        Dim count As Integer = 0
        If _dataSetElectronicTarget.shooting_sessions.Rows.Count > 10 Then
            count = 10
        Else
            count = _dataSetElectronicTarget.shooting_sessions.Rows.Count
        End If

        For i As Integer = 0 To count - 1
            Dim shootingSessionRow As DataSetElectronicTarget.shooting_sessionsRow = _dataSetElectronicTarget.shooting_sessions.Rows(i)
            Dim id As Integer = shootingSessionRow.id
            Dim sessionDate As String = shootingSessionRow.session_date
            Dim shootingSession As New ShootingSession(id)
            Dim stats As New Stats(shootingSession.StrShots, shootingSession.Target)
            Dim point As New DataPoint
            point.YValues = {stats.AverageScore}
            point.Label = sessionDate.ToString
            serie1.Points.Add(point)
        Next
        Me.ChartStats.Series.Clear()
        Me.ChartStats.Series.Add(serie1)
    End Sub
End Class
