Imports System.Text

Public Class FormLogin

    Private _usersTableAdapter As DataSetTBTargetTableAdapters.usersTableAdapter
    Private _dataSetTBTarget As DataSetTBTarget
    Private _formMain As FormMain

    Public Sub New(ByRef formMain As FormMain)
        InitializeComponent()
        _formMain = formMain
        _usersTableAdapter = New DataSetTBTargetTableAdapters.usersTableAdapter
        _dataSetTBTarget = New DataSetTBTarget
        Me.TabControlMain.ItemSize = New Size(0, 1)
        Me.TabControlMain.SizeMode = TabSizeMode.Fixed
    End Sub

    Private Sub ButtonConnexionCreateAccount_Click(sender As Object, e As EventArgs) Handles ButtonConnexionCreateAccount.Click
        Me.TabControlMain.SelectedIndex = 1
    End Sub

    Private Sub ButtonRegistrationConnect_Click(sender As Object, e As EventArgs) Handles ButtonRegistrationConnect.Click
        Me.TabControlMain.SelectedIndex = 0
    End Sub

    Private Sub ButtonConnexionConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnexionConnect.Click
        Dim username As String = Me.TextBoxConnexionUsername.Text
        Dim password As String = Me.TextBoxConnexionPassword.Text
        If VerifyLogin(username, password) Then
            _formMain.ChangeUser(username)
            Me.Close()
        End If
    End Sub

    Private Sub ButtonRegistrationAddUser_Click(sender As Object, e As EventArgs) Handles ButtonRegistrationAddUser.Click
        Dim username As String = Me.TextBoxRegistrationUsername.Text
        Dim password As String = Me.TextBoxRegistrationPassword.Text
        Dim eMail As String = Me.TextBoxRegistrationEMail.Text
        Dim level As Integer = Me.ComboBoxRegistrationLevel.Items(Me.ComboBoxRegistrationLevel.SelectedIndex)
        'TODO : Ajout des levels
        If VerifyAccountCreation(Me.TextBoxRegistrationUsername.Text, Me.TextBoxRegistrationPassword.Text, Me.TextBoxRegistrationEMail.Text, 0) Then
            If CreateAccount(Me.TextBoxRegistrationUsername.Text, Me.TextBoxRegistrationPassword.Text, Me.TextBoxRegistrationEMail.Text, 0) Then
                _formMain.ChangeUser(username)
                Me.Close()
            End If
        End If
    End Sub

    Private Function VerifyLogin(ByVal username As String, ByVal password As String) As Boolean
        Try
            If username = "" Then
                MsgBox("Veuillez entrer un nom d'utilisateur", MsgBoxStyle.Information, "Connexion")
                Me.TextBoxConnexionPassword.Text = ""
                Return False
            End If

            If _usersTableAdapter.FillByUsername(_dataSetTBTarget.users, username) = 0 Then
                MsgBox("Utilisateur " & username & " inexistant", MsgBoxStyle.Information, "Connexion")
                Me.TextBoxConnexionUsername.Text = ""
                Me.TextBoxConnexionPassword.Text = ""
                Return False
            End If

            Dim user As DataSetTBTarget.usersRow = _dataSetTBTarget.users.Rows(0)
            If DecryptPassword(user.password) = password Then
                Return True
            Else
                MsgBox("Mot de passe incorrect", MsgBoxStyle.Information, "Connexion")
                Me.TextBoxConnexionPassword.Text = ""
                Return False
            End If

        Catch ex As Exception
            MsgBox("Erreur lors de la recherche dans la base de données : " & ex.Message, MsgBoxStyle.Critical, "Connexion")
            Return False
        End Try
    End Function

    Private Function VerifyAccountCreation(ByVal username As String, ByVal password As String, ByVal email As String, ByVal level As Integer) As Boolean
        Try
            If username = "" Then
                MsgBox("Veuillez entrer un nom d'utilisateur", MsgBoxStyle.Information, "Inscription")
                Me.TextBoxRegistrationUsername.Text = ""
                Return False
            End If

            If _usersTableAdapter.FillByUsername(_dataSetTBTarget.users, username) > 0 Then
                MsgBox("L'utilisateur " & username & " existe déjà", MsgBoxStyle.Information, "Inscription")
                Return False
            End If

            If VerifyEmail(email) = True Then
                Return True
            Else
                MsgBox("L'adresse email " & email & " semble incorrecte", MsgBoxStyle.Information, "Inscription")
                Return False
            End If

        Catch ex As Exception
            MsgBox("Erreur lors de la recherche dans la base de données : " & ex.Message, MsgBoxStyle.Critical, "Inscription")
            Return False
        End Try
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

    Private Function CreateAccount(ByVal username As String, ByVal password As String, ByVal eMail As String, ByVal level As Integer) As Boolean
        Try
            Dim newUser As DataSetTBTarget.usersRow = _dataSetTBTarget.users.NewusersRow
            newUser.username = username
            newUser.password = EncryptPassword(password)
            newUser.e_mail = eMail
            newUser.level = level
            _dataSetTBTarget.users.AddusersRow(newUser)
            _usersTableAdapter.Update(_dataSetTBTarget.users)
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

    Private Sub LabelContinueWithoutConnexion_Click(sender As Object, e As EventArgs) Handles LabelContinueWithoutConnexion.Click
        Me.Close()
    End Sub

    Private Sub LabelContinueWithoutConnexion_MouseHover(sender As Object, e As EventArgs) Handles LabelContinueWithoutConnexion.MouseHover
        Dim standardFont As Font = LabelContinueWithoutConnexion.Font
        Dim underLinedFont As New Font(standardFont, FontStyle.Underline)

        Me.LabelContinueWithoutConnexion.Font = underLinedFont
    End Sub

    Private Sub LabelContinueWithoutConnexion_MouseLeave(sender As Object, e As EventArgs) Handles LabelContinueWithoutConnexion.MouseLeave
        Dim standardFont As Font = LabelContinueWithoutConnexion.Font
        Dim notUnderlinedFont As New Font(standardFont, FontStyle.Regular)

        Me.LabelContinueWithoutConnexion.Font = notUnderlinedFont
    End Sub
End Class