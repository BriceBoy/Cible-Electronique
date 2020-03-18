Public Class FormLogin

    Private _usersTableAdapter As DataSetTBTargetTableAdapters.usersTableAdapter
    Private _dataSetTBTarget As DataSetTBTarget

    Public Sub New()
        InitializeComponent()
        _usersTableAdapter = New DataSetTBTargetTableAdapters.usersTableAdapter
        _dataSetTBTarget = New DataSetTBTarget
        Me.TabControlMain.ItemSize = New Size(0, 1)
        Me.TabControlMain.SizeMode = TabSizeMode.Fixed
    End Sub

    Private Sub ButtonConnexionCreateAccount_Click(sender As Object, e As EventArgs) Handles ButtonConnexionCreateAccount.Click
        Me.TabControlMain.SelectedIndex = 1
    End Sub

    Private Sub ButtonInscriptionConnect_Click(sender As Object, e As EventArgs) Handles ButtonInscriptionConnect.Click
        Me.TabControlMain.SelectedIndex = 0
    End Sub

    Private Sub ButtonConnexionConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnexionConnect.Click
        VerifyLogin(Me.TextBoxConnexionUsername.Text, Me.TextBoxConnexionPassword.Text)
    End Sub

    Private Sub ButtonInscriptionAddUser_Click(sender As Object, e As EventArgs) Handles ButtonInscriptionAddUser.Click
        VerifyAccountCreation(Me.TextBoxInscriptionUsername.Text, Me.TextBoxInscriptionPassword.Text, Me.TextBoxInscriptionEMail.Text, 0)
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
            If user.password = password Then
                MsgBox("Connexion réussie", MsgBoxStyle.Information, "Connexion")
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
                Me.TextBoxInscriptionUsername.Text = ""
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
End Class