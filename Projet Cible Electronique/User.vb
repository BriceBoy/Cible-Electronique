Imports System.IO
Imports System.Text

Public Class User
    Private _dataSetEletronicTarget As DataSetElectronicTarget
    Private _usersTableAdapter As DataSetElectronicTargetTableAdapters.usersTableAdapter

#Region "Properties"
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
#End Region

    Public Sub New()
        _dataSetEletronicTarget = New DataSetElectronicTarget
        _usersTableAdapter = New DataSetElectronicTargetTableAdapters.usersTableAdapter
        ResetUsersProperties()
    End Sub

    Public Function Login(ByVal username As String, ByVal password As String) As Integer
        Try
            If username = "" Then
                ' Empty username
                Return -1
            End If

            If _usersTableAdapter.FillByUsername(_dataSetEletronicTarget.users, username) = 0 Then
                ' Incorrect username
                Return -2
            End If

            Dim user As DataSetElectronicTarget.usersRow = _dataSetEletronicTarget.users.Rows(0)
            If DecryptPassword(user.password) <> password Then
                ' Incorrect password
                Return -3
            End If

            If LoadUserInfos(username) = False Then
                ' Error while loading user's data
                Return -4
            Else
                ' Correct login
                Return 1
            End If

        Catch ex As Exception
            ' Any other error
            MsgBox("Erreur lors de la recherche dans la base de données : " & ex.Message, MsgBoxStyle.Critical, "Connexion")
            Return -5
        End Try
    End Function

    Private Function LoadUserInfos(ByVal username As String) As Boolean
        Try
            If _usersTableAdapter.FillByUsername(_dataSetEletronicTarget.users, username) > 0 Then
                Dim userRow As DataSetElectronicTarget.usersRow = _dataSetEletronicTarget.users.Rows(0)
                _firstname = userRow.firstname
                _lastname = userRow.lastname
                _username = userRow.username
                _password = DecryptPassword(userRow.password)
                _email = userRow.e_mail
                _category = userRow.category
                If Not userRow.IspictureNull Then
                    _picture = byteArrayToImage(userRow.picture)
                End If
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            ResetUsersProperties()
            MsgBox("Erreur user.LoadUsersInfos : " & ex.Message, MsgBoxStyle.Critical, "Chargement informations")
            Return False
        End Try
    End Function

    Public Function SignIn(ByVal firstname As String, ByVal lastname As String, ByVal username As String, ByVal password As String, ByVal email As String, ByVal category As String) As Integer
        Try
            If username = "" Then
                ' Empty username
                Return -1
            End If

            If _usersTableAdapter.FillByUsername(_dataSetEletronicTarget.users, username) > 0 Then
                ' Username already exists
                Return -2
            End If

            If email <> "" Then
                If VerifyEmail(email) = False Then
                    ' Incorrect email
                    Return -3
                End If
            End If

            _firstname = firstname
            _lastname = lastname
            _username = username
            _password = password
            _email = email
            _category = category

            If AddAccountToDatabase() = False Then
                ' Error while saving datan in database
                Return -4
            Else
                ' Account creation done
                Return 1
            End If

        Catch ex As Exception
            MsgBox("Erreur lors de l'enregistrement de l'utilisateur : " & ex.Message, MsgBoxStyle.Critical, "Inscription")
            Return -5
        End Try
    End Function

    Private Function AddAccountToDatabase() As Boolean
        Try
            Dim newUser As DataSetElectronicTarget.usersRow = _dataSetEletronicTarget.users.NewusersRow
            newUser.firstname = _firstname
            newUser.lastname = _lastname
            newUser.username = _username
            newUser.password = EncryptPassword(_password)
            newUser.e_mail = _email
            newUser.category = _category
            If Not IsNothing(_picture) Then
                newUser.picture = imgToByteArray(_picture)
            End If
            _dataSetEletronicTarget.users.AddusersRow(newUser)
            _usersTableAdapter.Update(_dataSetEletronicTarget.users)
            Return True
        Catch ex As Exception
            MsgBox("Erreur lors de la création du compte : " & ex.Message, MsgBoxStyle.Critical, "Inscription")
            Return False
        End Try
    End Function

    Private Function EncryptPassword(ByVal uncryptedPassword As String) As String
        Dim bytes() As Byte = Encoding.UTF8.GetBytes(uncryptedPassword)
        Return Convert.ToBase64String(bytes)
    End Function

    Private Function DecryptPassword(ByVal cryptedPassword As String) As String
        Dim bytes() As Byte = Convert.FromBase64String(cryptedPassword)
        Return Encoding.UTF8.GetString(bytes)
    End Function

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

    Private Function VerifyEmail(ByVal email As String) As Boolean
        If email = "" Then
            Return True
        End If

        Dim atCount As Integer = 0
        For Each character In email
            If character = "@" Then
                atCount += 1
            End If
        Next

        If atCount <> 1 Then
            Return False
        End If

        Dim id As String = Split(email, "@")(0)
        Dim domain As String = Split(email, "@")(1)

        If id = "" Or domain = "" Then
            Return False
        End If

        Dim dotCount As Integer = 0
        For Each character In domain
            If character = "." Then
                dotCount += 1
            End If
        Next

        If dotCount <> 1 Then
            Return False
        End If

        Dim firstPart As String = Split(domain, ".")(0)
        Dim secondPart As String = Split(domain, ".")(1)

        If firstPart = "" Or secondPart = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub ResetUsersProperties()
        _firstname = ""
        _lastname = ""
        _username = ""
        _password = ""
        _email = ""
        _category = ""
        _picture = Nothing
    End Sub
End Class
