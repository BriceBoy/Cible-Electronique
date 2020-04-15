Public Class FormMain

    Private _currentUser As User

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TabControlMain.Appearance = TabAppearance.FlatButtons
        Me.TabControlMain.ItemSize = New Size(0, 1)
        Me.TabControlMain.SizeMode = TabSizeMode.Fixed
        Dim _formLogin As New FormLogin(Me)
        _formLogin.ShowDialog()
    End Sub

    Public Sub ChangeUser(ByRef user As User)
        If Not IsNothing(user) Then
            _currentUser = user
        Else
            _currentUser = New User()
        End If
    End Sub

    Private Sub FormMain_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Me.ToolStripStatusLabel1.Text = Me.ButtonSettings.Height
    End Sub

    Private Sub ButtonUser_Click(sender As Object, e As EventArgs) Handles ButtonUser.Click
        Me.TabControlMain.SelectedIndex = 0
    End Sub

    Private Sub ButtonShootingSession_Click(sender As Object, e As EventArgs) Handles ButtonShootingSession.Click
        Me.TabControlMain.SelectedIndex = 1
    End Sub

    Private Sub ButtonStatistics_Click(sender As Object, e As EventArgs) Handles ButtonStatistics.Click
        Me.TabControlMain.SelectedIndex = 2
    End Sub

    Private Sub ButtonSettings_Click(sender As Object, e As EventArgs) Handles ButtonSettings.Click
        Me.TabControlMain.SelectedIndex = 3
    End Sub
End Class
