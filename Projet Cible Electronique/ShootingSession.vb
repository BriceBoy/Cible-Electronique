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

    Private _shotsCount As Integer
    Public Property ShotsCount() As Integer
        Get
            Return _shotsCount
        End Get
        Set(ByVal value As Integer)
            _shotsCount = value
        End Set
    End Property

    Public Sub New(ByRef currentUser As User, ByRef currentTarget As Target)
        _dataSetElectronicTarget = New DataSetElectronicTarget
        _targetsTableAdapter = New DataSetElectronicTargetTableAdapters.targetsTableAdapter
        _usersTableAdapter = New DataSetElectronicTargetTableAdapters.usersTableAdapter
        _shootingSessionsTableAdapter = New DataSetElectronicTargetTableAdapters.shooting_sessionsTableAdapter

        _user = currentUser
        _target = currentTarget
    End Sub

    Public Function SaveToDatabase() As String
        Try
            Dim newShootingSessionRow As DataSetElectronicTarget.shooting_sessionsRow
            newShootingSessionRow = _dataSetElectronicTarget.shooting_sessions.Newshooting_sessionsRow
            With newShootingSessionRow

            End With
            _dataSetElectronicTarget.shooting_sessions.Addshooting_sessionsRow(newShootingSessionRow)
            _shootingSessionsTableAdapter.Update(_dataSetElectronicTarget.shooting_sessions)
            Return "OK"
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
End Class
