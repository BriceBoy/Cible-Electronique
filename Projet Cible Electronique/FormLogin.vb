Imports System.Text

Public Class FormLogin

    Private _usersTableAdapter As DataSetTBTargetTableAdapters.usersTableAdapter
    Private _dataSetTBTarget As DataSetTBTarget
    Private _formMain As FormMain
    Private _currentUser As User

    Public Sub New(ByRef formMain As FormMain)
        InitializeComponent()
        _formMain = formMain
        _usersTableAdapter = New DataSetTBTargetTableAdapters.usersTableAdapter
        _dataSetTBTarget = New DataSetTBTarget
        _currentUser = New User()
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
            _formMain.ChangeUser(_currentUser)
            Me.Close()
        End If
    End Sub

    Private Sub ButtonRegistrationAddUser_Click(sender As Object, e As EventArgs) Handles ButtonRegistrationAddUser.Click
        Dim firstname As String = Me.TextBoxRegistrationFirstname.Text
        Dim lastname As String = Me.TextBoxRegistrationLastname.Text
        Dim username As String = Me.TextBoxRegistrationUsername.Text
        Dim password As String = Me.TextBoxRegistrationPassword.Text
        Dim eMail As String = Me.TextBoxRegistrationEMail.Text
        Dim category As String = ""
        If Me.ComboBoxRegistrationCategory.SelectedIndex >= 0 Then
            category = Me.ComboBoxRegistrationCategory.Items(Me.ComboBoxRegistrationCategory.SelectedIndex).ToString
        End If
        ' TODO : Ajouter catergory
        If VerifyAccountCreation(firstname, lastname, username, password, eMail, category) Then
            _formMain.ChangeUser(_currentUser)
            Me.Close()
        End If
    End Sub

    Private Function VerifyLogin(ByVal username As String, ByVal password As String) As Boolean
        Dim result As Integer = _currentUser.Login(username, password)
        Select Case result
            Case 1
                Return True
            Case -1
                MsgBox("Veuillez entrer un nom d'utilisateur", MsgBoxStyle.Information, "Connexion")
                Me.TextBoxConnexionPassword.Text = ""
                Return False
            Case -2
                MsgBox("Utilisateur " & username & " inexistant", MsgBoxStyle.Information, "Connexion")
                Me.TextBoxConnexionUsername.Text = ""
                Me.TextBoxConnexionPassword.Text = ""
                Return False
            Case -3
                MsgBox("Mot de passe incorrect", MsgBoxStyle.Information, "Connexion")
                Me.TextBoxConnexionPassword.Text = ""
                Return False
            Case Else
                Return False
        End Select
    End Function

    Private Function VerifyAccountCreation(ByVal firstname As String, ByVal lastname As String, ByVal username As String, ByVal password As String, ByVal email As String, ByVal category As String) As Boolean
        Dim result As Integer = _currentUser.SignIn(firstname, lastname, username, password, email, category)
        Select Case result
            Case 1
                Return True
            Case -1
                MsgBox("Veuillez entrer un nom d'utilisateur", MsgBoxStyle.Information, "Inscription")
                Return False
            Case -2
                Me.TextBoxRegistrationUsername.Text = ""
                MsgBox("L'utilisateur " & username & " existe déjà", MsgBoxStyle.Information, "Inscription")
                Return False
            Case -3
                MsgBox("L'adresse email " & email & " semble incorrecte", MsgBoxStyle.Information, "Inscription")
                Return False
            Case Else
                Return False
        End Select
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

    Private Sub TextBoxConnexionPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxConnexionPassword.KeyPress
        If e.KeyChar = vbCr Then
            Call Me.ButtonConnexionConnect_Click(Nothing, Nothing)
        End If
    End Sub
End Class