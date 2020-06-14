Public Class FormAddTarget
    Private _listNumericUpDown As List(Of NumericUpDown)
    Private _listLabels As List(Of Label)
    Private _target As Target
    Public Sub New()
        InitializeComponent()
        _listLabels = New List(Of Label) From {LabelRad1, LabelScore1, LabelRad2, LabelScore2, LabelRad3, LabelScore3, LabelRad4, LabelScore4, LabelRad5, LabelScore5, LabelRad6, LabelScore6, LabelRad7, LabelScore7, LabelRad8, LabelScore8, LabelRad9, LabelScore9, LabelRad10, LabelScore10, LabelRad11, LabelScore11}
        _listNumericUpDown = New List(Of NumericUpDown) From {Rad1, Score1, Rad2, Score2, Rad3, Score3, Rad4, Score4, Rad5, Score5,
                                                              Rad6, Score6, Rad7, Score7, Rad8, Score8, Rad9, Score9, Rad10, Score10, Rad11, Score11}
        _target = New Target()
    End Sub

    Private Sub NumZonesCount_ValueChanged(sender As Object, e As EventArgs) Handles NumZonesCount.ValueChanged
        HideAndShow(NumZonesCount.Value)
    End Sub

    Private Sub HideAndShow(ByVal zonesCount As Integer)
        For i As Integer = 0 To (zonesCount * 2 - 1)
            _listLabels(i).Visible = True
            _listNumericUpDown(i).Visible = True
        Next
        For i As Integer = (zonesCount * 2) To (_listLabels.Count - 1)
            _listLabels(i).Visible = False
            _listNumericUpDown(i).Value = 0
            _listNumericUpDown(i).Visible = False
        Next
    End Sub

    Private Sub TextBoxImgPath_Click(sender As Object, e As EventArgs) Handles TextBoxImgPath.Click
        Me.OpenFileDialogImg.FileName = ""
        If Me.OpenFileDialogImg.ShowDialog = DialogResult.OK And Not Me.OpenFileDialogImg.FileName = "" Then
            Me.TextBoxImgPath.Text = Me.OpenFileDialogImg.FileName
        End If
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Try
            _target.Name = TextBoxNameTarget.Text
            _target.WidthMM = NumericUpDownWidth.Value
            _target.HeightMM = NumericUpDownHeight.Value
            _target.Img = Image.FromFile(TextBoxImgPath.Text)
            _target.ListZonesRadius = New List(Of Decimal) From {Rad1.Value, Rad2.Value, Rad3.Value, Rad4.Value, Rad5.Value, Rad6.Value, Rad7.Value, Rad8.Value, Rad9.Value, Rad10.Value, Rad11.Value}
            _target.ListZonesScore = New List(Of Integer) From {Score1.Value, Score2.Value, Score3.Value, Score4.Value, Score5.Value, Score6.Value, Score7.Value, Score8.Value, Score9.Value, Score10.Value, Score11.Value}

            Dim result As String = _target.SaveToDatabase
            If Not result = "OK" Then
                MsgBox(result, MsgBoxStyle.Information, "Erreur")
            Else
                MsgBox("La cible " & _target.Name & " a bien été sauvegardée", MsgBoxStyle.Information, "Sauvegarde réussie")
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Erreur : " & ex.Message, MsgBoxStyle.Critical, "Erreur")
        End Try
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub
End Class