Imports System.IO
Imports System.Text

Public Class User
    Private _dataSetTBTargert As DataSetTBTarget
    Private _usersTableAdapter As DataSetTBTargetTableAdapters.usersTableAdapter

    Public Sub New(ByVal username As String)
        _dataSetTBTargert = New DataSetTBTarget
        _usersTableAdapter = New DataSetTBTargetTableAdapters.usersTableAdapter
    End Sub

    Private _firstname As String
    Public Property FirstName() As String
        Get
            Return _firstname
        End Get
        Set(ByVal value As String)
            _firstname = value
        End Set
    End Property

    Private _lastname As String
    Public Property Lastname() As String
        Get
            Return _lastname
        End Get
        Set(ByVal value As String)
            _lastname = value
        End Set
    End Property

    Private _username As String
    Public Property Username() As String
        Get
            Return _username
        End Get
        Set(ByVal value As String)
            _username = value
        End Set
    End Property

    Private _password As String
    Public Property Password() As String
        Get
            Return _password
        End Get
        Set(ByVal value As String)
            _password = value
        End Set
    End Property

    Private _email As String
    Public Property EMail() As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property

    Private _category As String
    Public Property Category() As String
        Get
            Return _category
        End Get
        Set(ByVal value As String)
            _category = value
        End Set
    End Property

    Private _picture As Image
    Public Property Picture() As Image
        Get
            Return _picture
        End Get
        Set(ByVal value As Image)
            _picture = value
        End Set
    End Property

    Public Sub LoadUserInfos()
        Try
            If _usersTableAdapter.FillByUsername(_dataSetTBTargert.users, _username) > 0 Then
                Dim userRow As DataSetTBTarget.usersRow = _dataSetTBTargert.users.Rows(0)
                _firstname = userRow.firstname
                _lastname = userRow.lastname
                _username = userRow.username
                _password = DecryptPassword(userRow.password)
                _email = userRow.e_mail
                _picture = byteArrayToImage(userRow.picture)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Function EncryptPassword(ByVal uncryptedPassword As String) As String
        Dim bytes() As Byte = Encoding.UTF8.GetBytes(uncryptedPassword)
        Return Convert.ToBase64String(bytes)
    End Function

    Private Function DecryptPassword(ByVal cryptedPassword As String) As String
        Dim bytes() As Byte = Convert.FromBase64String(cryptedPassword)
        Return Encoding.UTF8.GetString(bytes)
    End Function

    Public Function imgToByteArray(ByVal img As Image) As Byte()
        Using mStream As New MemoryStream()
            img.Save(mStream, img.RawFormat)
            Return mStream.ToArray()
        End Using
    End Function

    Public Function byteArrayToImage(ByVal byteArrayIn As Byte()) As Image
        Using mStream As New MemoryStream(byteArrayIn)
            Return Image.FromStream(mStream)
        End Using
    End Function
End Class
