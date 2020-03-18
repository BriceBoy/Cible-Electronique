Public Class FormMain
    Private Sub PictureBoxTarget_Click(sender As Object, e As EventArgs) Handles PictureBoxTarget.Click
        Dim mousePos As Point = PictureBoxTarget.PointToClient(MousePosition)
        Dim img As Image = Me.PictureBoxTarget.Image
        Dim g As Graphics = Graphics.FromImage(img)
        With g
            .PageUnit = GraphicsUnit.Pixel
            .FillEllipse(Brushes.Red, mousePos.X - 5, mousePos.Y - 5, 10, 10)
            .Save()
        End With
        Me.PictureBoxTarget.Image = img
        UpdateLabels(mousePos.X, mousePos.Y)
    End Sub

    Private Sub UpdateLabels(ByVal x As Single, ByVal y As Single)
        Me.LabelPosShoot.Text = "X : " & x & "   Y : " & y
        Dim distance As Single = DistanceBetween(183, 183, x, y)
        Dim msg As String
        Select Case distance
            Case < 20
                msg = " Putain t'es fortiche frérot !"
                Me.LabelDistanceShoot.ForeColor = Color.Green
            Case < 50
                msg = " Pas si mal !"
                Me.LabelDistanceShoot.ForeColor = Color.ForestGreen
            Case < 100
                msg = " Wllah t'es éclaté frère !"
                Me.LabelDistanceShoot.ForeColor = Color.Red
            Case Else
                msg = " Tu te fous de ma gueule !?"
                Me.LabelDistanceShoot.ForeColor = Color.DarkRed
        End Select
        Me.LabelDistanceShoot.Text = "Dist : " & FormatNumber(DistanceBetween(183, 183, x, y), 0) & msg
    End Sub

    Public Function DistanceBetween(ByVal X1 As Single, ByVal Y1 As Single, ByVal X2 As Single, ByVal Y2 As Single) As Single
        DistanceBetween = Math.Sqrt((Math.Abs(X2 - X1) ^ 2) + (Math.Abs(Y2 - Y1) ^ 2))
    End Function
End Class
