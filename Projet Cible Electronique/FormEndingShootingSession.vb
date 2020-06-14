Public Class FormEndingShootingSession

    Private _shootingSession As ShootingSession

    Public Sub New(ByRef shootingSession As ShootingSession)
        InitializeComponent()
        _shootingSession = shootingSession
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        If Me.RadioButtonGun.Checked Then
            _shootingSession.Weapon = "Pistolet"
        ElseIf Me.RadioButtonRifle.Checked Then
            _shootingSession.Weapon = "Carabine"
        Else
            _shootingSession.Weapon = ""
        End If
        _shootingSession.Distance = Me.NumericUpDownDistance.Value
        _shootingSession.Comments = Me.RichTextBoxComments.Text
        Me.Close()
    End Sub
End Class