Imports System.IO

Public Class ShootingSession

    Private _dataSetElectronicTarget As DataSetElectronicTarget
    Private _targetsTableAdapter As DataSetElectronicTargetTableAdapters.targetsTableAdapter
    Private _usersTableAdapter As DataSetElectronicTargetTableAdapters.usersTableAdapter
    Private _shootingSessionsTableAdapter As DataSetElectronicTargetTableAdapters.shooting_sessionsTableAdapter

    Private _strShots As String

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
    Public Property ShotToDo() As Integer
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

    Private _imageResult As Image
    Public Property ImageResult() As Image
        Get
            Return _imageResult
        End Get
        Set(ByVal value As Image)
            _imageResult = value
        End Set
    End Property

    Public Sub New(ByRef currentUser As User, ByRef currentTarget As Target, ByVal shotsToDo As Integer)
        _dataSetElectronicTarget = New DataSetElectronicTarget
        _targetsTableAdapter = New DataSetElectronicTargetTableAdapters.targetsTableAdapter
        _usersTableAdapter = New DataSetElectronicTargetTableAdapters.usersTableAdapter
        _shootingSessionsTableAdapter = New DataSetElectronicTargetTableAdapters.shooting_sessionsTableAdapter

        _strShots = ""

        _user = currentUser
        _target = currentTarget
        _shotsToDo = shotsToDo
        _shotsDone = 0
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
                .image_result = imgToByteArray(_imageResult)
            End With
            _dataSetElectronicTarget.shooting_sessions.Addshooting_sessionsRow(newShootingSessionRow)
            _shootingSessionsTableAdapter.Update(_dataSetElectronicTarget.shooting_sessions)
            Return "OK"
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function GetShotsRemaining() As Integer
        Return _shotsToDo - _shotsDone
    End Function

    Public Sub AddAShot(ByVal x As Decimal, y As Decimal)
        _strShots += x & ":" & y & ";"
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
End Class
