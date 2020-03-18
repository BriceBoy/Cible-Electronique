Public Class FormMain

    Private _currentUser As String

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim _formLogin As New FormLogin(Me)
        _formLogin.ShowDialog()
    End Sub

    Public Sub ChangeUser(ByVal username As String)
        _currentUser = username
        Me.MenuUserCurrent.Text = username
    End Sub
End Class
