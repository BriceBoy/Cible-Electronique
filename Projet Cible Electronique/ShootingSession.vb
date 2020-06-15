Imports System.IO

Public Class ShootingSession

    Private _dataSetElectronicTarget As DataSetElectronicTarget
    Private _targetsTableAdapter As DataSetElectronicTargetTableAdapters.targetsTableAdapter
    Private _usersTableAdapter As DataSetElectronicTargetTableAdapters.usersTableAdapter
    Private _shootingSessionsTableAdapter As DataSetElectronicTargetTableAdapters.shooting_sessionsTableAdapter

    Private _user As User
    Public Property User() As User
        Get
            Return _user
        End Get
        Set(ByVal value As User)
            _user = value
        End Set
    End Property

    Private _target As Target
    Public Property Target() As Target
        Get
            Return _target
        End Get
        Set(ByVal value As Target)
            _target = value
        End Set
    End Property

    Private _shotsDone As Integer
    Public Property ShotsDone() As Integer
        Get
            Return _shotsDone
        End Get
        Set(ByVal value As Integer)
            _shotsDone = value
        End Set
    End Property

    Private _shotsToDo As Integer
    Public Property ShotsToDo() As Integer
        Get
            Return _shotsToDo
        End Get
        Set(ByVal value As Integer)
            _shotsToDo = value
        End Set
    End Property

    Private _totalScore As Integer
    Public Property TotalScore() As Integer
        Get
            Return _totalScore
        End Get
        Set(ByVal value As Integer)
            _totalScore = value
        End Set
    End Property

    Private _finalPicture As Image
    Public Property FinalPicture() As Image
        Get
            Return _finalPicture
        End Get
        Set(ByVal value As Image)
            _finalPicture = value
        End Set
    End Property

    Private _weapon As String
    Public Property Weapon() As String
        Get
            Return _weapon
        End Get
        Set(ByVal value As String)
            _weapon = value
        End Set
    End Property

    Private _distance As Integer
    Public Property Distance() As Integer
        Get
            Return _distance
        End Get
        Set(ByVal value As Integer)
            _distance = value
        End Set
    End Property

    Private _comments As String
    Public Property Comments() As String
        Get
            Return _comments
        End Get
        Set(ByVal value As String)
            _comments = value
        End Set
    End Property

    Private _strShots As String
    Public Property StrShots() As String
        Get
            Return _strShots
        End Get
        Set(ByVal value As String)
            _strShots = value
        End Set
    End Property

    Public Sub New(ByRef user As User, ByRef target As Target, ByVal shotsToDo As Integer)
        _dataSetElectronicTarget = New DataSetElectronicTarget
        _targetsTableAdapter = New DataSetElectronicTargetTableAdapters.targetsTableAdapter
        _usersTableAdapter = New DataSetElectronicTargetTableAdapters.usersTableAdapter
        _shootingSessionsTableAdapter = New DataSetElectronicTargetTableAdapters.shooting_sessionsTableAdapter

        _strShots = ""
        _user = user
        _target = target
        _target.ReloadImg()
        _shotsToDo = shotsToDo
        _shotsDone = 0
        _finalPicture = _target.Img
    End Sub

    Public Sub New(ByVal ID As Integer)
        _dataSetElectronicTarget = New DataSetElectronicTarget
        _targetsTableAdapter = New DataSetElectronicTargetTableAdapters.targetsTableAdapter
        _usersTableAdapter = New DataSetElectronicTargetTableAdapters.usersTableAdapter
        _shootingSessionsTableAdapter = New DataSetElectronicTargetTableAdapters.shooting_sessionsTableAdapter

        _shootingSessionsTableAdapter.FillByID(_dataSetElectronicTarget.shooting_sessions, ID)
        Dim shootingSessionRow As DataSetElectronicTarget.shooting_sessionsRow = _dataSetElectronicTarget.shooting_sessions.Rows(0)
        Dim username As String
        Dim targetname As String
        With shootingSessionRow
            username = .user
            targetname = .target
            _strShots = .shots
            _finalPicture = ByteArrayToImage(.image_result)
            _comments = .comments
        End With

        _user = New User
        _user.LoadUserInfos(username)

        _target = New Target
        _target.LoadTarget(targetname)

    End Sub

    Public Function SaveToDatabase() As String
        Try
            Dim newShootingSessionRow As DataSetElectronicTarget.shooting_sessionsRow
            newShootingSessionRow = _dataSetElectronicTarget.shooting_sessions.Newshooting_sessionsRow
            With newShootingSessionRow
                .user = _user.Username
                .session_date = DateTime.Now
                .shots = _strShots
                .target = _target.Name
                .image_result = ImgToByteArray(_finalPicture)
                .weapon = _weapon
                .distance = _distance
                .comments = _comments
            End With

            _dataSetElectronicTarget.shooting_sessions.Addshooting_sessionsRow(newShootingSessionRow)
            _shootingSessionsTableAdapter.Update(_dataSetElectronicTarget.shooting_sessions)
            Return "OK"
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function ShotsRemaining() As Integer
        Return _shotsToDo - _shotsDone
    End Function

    Public Sub AddAShot(ByVal x As Decimal, y As Decimal)
        _strShots += x & ":" & y & ";"
        _shotsDone += 1
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

    Public Function TenLastShots() As String
        Dim testArray() As String = Split(_strShots, ";")
        Dim shotsCount = testArray.GetUpperBound(0)
        Dim tenShots As String = ""
        For i As Integer = (testArray.GetUpperBound(0) - 9) To testArray.GetUpperBound(0) - 1
            tenShots += testArray(i) + ";"
        Next
        Return tenShots
    End Function

    Public Function ShowAdvices() As String
        If _shotsDone Mod 10 = 0 And _shotsDone > 0 Then
            Dim stats As New Stats(TenLastShots, _target)
            _target.ReloadImg()
            Return stats.SmartSystem()
        Else
            Return ""
        End If
    End Function
End Class
