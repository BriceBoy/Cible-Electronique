Public Class Stats

    Private _radiusZone1, _radiusZone2, _radiusZone3, _radiusZone4, _radiusZone5, _radiusZone6 As Decimal
    Private _volley(,) As Decimal

    Private _averageX As Decimal
    Private _averageY As Decimal
    Private _standardErrorX As Decimal
    Private _standardErrorY As Decimal
    Private _listOutliers As List(Of Integer)

    Public ReadOnly Property AverageScore As Decimal

    Public Sub New(ByVal strShots As String, ByVal target As Target)
        _volley = ConvertVolleyStringToArray(strShots)
        _radiusZone1 = target.ListZonesRadius(0) / 2
        _radiusZone2 = target.ListZonesRadius(1) / 2
        _radiusZone3 = target.ListZonesRadius(2) / 2
        _radiusZone4 = target.ListZonesRadius(3) / 2
        _radiusZone5 = target.ListZonesRadius(4) / 2
        _radiusZone6 = target.ListZonesRadius(5) / 2

        _AverageScore = CalculDonneesVolee(_volley)

        'Calcul des moyennes X et Y
        _averageX = AverageX(_volley)
        _averageY = AverageY(_volley)

        'Calcul des ecarts-types de X et Y
        _standardErrorX = StandardErrorX(_volley, _averageX)
        _standardErrorY = StandardErrorY(_volley, _averageY)

        'Suppression des valeurs aberrantes
        Dim volleyWithoutOutlier = DeleteOutlier(_volley, _averageX, _averageY, _standardErrorX, _standardErrorY)

        'Mise à jour des valeurs si valeurs aberrantes
        If _volley.GetUpperBound(0) <> volleyWithoutOutlier.GetUpperBound(0) Then
            _averageX = AverageX(volleyWithoutOutlier)
            _averageY = AverageY(volleyWithoutOutlier)
            _standardErrorX = StandardErrorX(volleyWithoutOutlier, _averageX)
            _standardErrorY = StandardErrorY(volleyWithoutOutlier, _averageY)
        End If
    End Sub

    Private Function DeleteOutlier(ByVal volley(,) As Decimal, averageX As Decimal, averageY As Decimal, standardErrorX As Decimal, standardErrorY As Decimal) As Decimal(,)
        _listOutliers = New List(Of Integer)
        Dim dimension As Integer = 0
        For i As Integer = 0 To volley.GetUpperBound(0)
            If ((averageX - 2 * standardErrorX) < volley(i, 0) And volley(i, 0) < (averageX + 2 * standardErrorX) And (averageY - 2 * standardErrorY) < volley(i, 1) And volley(i, 1) < (averageY + 2 * standardErrorY)) Then
                dimension += 1
            End If
        Next

        Dim voleeWithoutOutlier(dimension - 1, 1) As Decimal
        Dim j As Integer = 0
        For i As Integer = 0 To volley.GetUpperBound(0)
            If ((averageX - 2 * standardErrorX) < volley(i, 0) And volley(i, 0) < (averageX + 2 * standardErrorX) And (averageY - 2 * standardErrorY) < volley(i, 1) And volley(i, 1) < (averageY + 2 * standardErrorY)) Then
                voleeWithoutOutlier(j, 0) = volley(i, 0)
                voleeWithoutOutlier(j, 1) = volley(i, 1)
                j += 1
            Else
                _listOutliers.Add(i + 1)
            End If
        Next
        Return voleeWithoutOutlier
    End Function

    Private Function ConvertVolleyStringToArray(ByVal str As String) As Decimal(,)
        Dim testArray() As String = Split(str, ";")
        Dim shotsCount = testArray.GetUpperBound(0) - 1
        Dim volee(shotsCount, 1) As Decimal
        For i As Integer = 0 To shotsCount
            Dim coord() As String = Split(testArray(i), ":")
            volee(i, 0) = coord(0)
            volee(i, 1) = coord(1)
            Console.WriteLine("Coordonnées plomb " & i + 1 & " en X = " & volee(i, 0) & " mm et en Y = " & volee(i, 1) & " mm")
        Next
        Return volee
    End Function

    Private Function CalculDonneesVolee(ByVal volley(,) As Decimal) As Decimal
        Dim distance(volley.GetUpperBound(0)), score(volley.GetUpperBound(0)), sumScore, averageScore As Decimal

        'Calcul des distances
        For i As Integer = 0 To distance.GetUpperBound(0)
            distance(i) = Math.Sqrt(volley(i, 0) ^ 2 + volley(i, 1) ^ 2)
            Console.WriteLine("Distance " & i & " = " & distance(i))
        Next

        'Calcul des scores
        For i As Integer = 0 To score.GetUpperBound(0)
            Select Case distance(i)
                Case Is < 5.75
                    score(i) = 10
                Case Is < 13.75
                    score(i) = 9
                Case Is < 21.75
                    score(i) = 8
                Case Is < 29.75
                    score(i) = 7
                Case Is < 37.75
                    score(i) = 6
                Case Is < 45.75
                    score(i) = 5
                Case Is < 53.75
                    score(i) = 4
                Case Is < 61.75
                    score(i) = 3
                Case Is < 69.75
                    score(i) = 2
                Case Is < 77.75
                    score(i) = 1
                Case Is > 77, 76
                    score(i) = 0
                Case Else
                    Console.WriteLine("Problème de détection du score")
            End Select
            Console.WriteLine("Score " & i & " = " & score(i))
            sumScore += score(i)
        Next

        'Calcul du score moyen sur une volée
        averageScore = sumScore / (score.GetUpperBound(0) + 1)
        Console.WriteLine("Score moyen = " & averageScore)

        Return averageScore
    End Function

    Private Function AverageX(ByVal volley(,) As Decimal) As Decimal
        Dim average As Decimal
        For i As Integer = 0 To volley.GetUpperBound(0)
            average += volley(i, 0)
        Next
        average /= (volley.GetUpperBound(0) + 1)
        Console.WriteLine("Moyenne de X = " & average)

        Return average
    End Function

    Private Function AverageY(ByVal volley(,) As Decimal) As Decimal
        Dim average As Decimal
        For i As Integer = 0 To volley.GetUpperBound(0)
            average += volley(i, 1)
        Next
        average /= (volley.GetUpperBound(0) + 1)
        Console.WriteLine("Moyenne de Y = " & average)

        Return average
    End Function

    Private Function StandardErrorX(ByVal volley(,) As Decimal, averageX As Decimal) As Decimal
        Dim standardError As Decimal
        For i As Integer = 0 To volley.GetUpperBound(0)
            standardError += (volley(i, 0) - averageX) ^ 2
        Next
        standardError = Math.Sqrt(standardError / (volley.GetUpperBound(0) + 1))
        Console.WriteLine("Ecart de X = " & standardError)

        Return standardError
    End Function

    Private Function StandardErrorY(ByVal volley(,) As Decimal, averageY As Decimal) As Decimal
        Dim standardError As Decimal
        For i As Integer = 0 To volley.GetUpperBound(0)
            standardError += (volley(i, 1) - averageY) ^ 2
        Next
        standardError = Math.Sqrt(standardError / (volley.GetUpperBound(0) + 1))
        Console.WriteLine("Ecart de Y = " & standardError)

        Return standardError
    End Function

    Private Function Outliers() As String
        If _listOutliers.Count = 0 Then
            Return ""
        ElseIf _listOutliers.Count = 1 Then
            Return "Le plomb n°" & _listOutliers(0) & " a été négligé pour ne pas fausser les statistiques"
        Else
            Dim msg As String = "Les plombs "
            For Each outlier As Integer In _listOutliers
                msg += "n°" & outlier & ", "
            Next
            msg = Left(msg, Len(msg) - 2)
            msg += " ont été négligés pour ne pas fausser les statistiques"
            Return msg
        End If
    End Function

    Public Function SmartSystem() As String
        Dim position, viseur As String
        If _AverageScore >= 10 Then
            Return "Volée excellente, continuez comme ca"
        ElseIf _AverageScore >= 9 Then
            Return "Très bonne volée, perséverez dans vos efforts"
        Else
            Select Case _standardErrorX
                Case Is < _radiusZone1
                    Select Case _standardErrorY
                        Case Is < _radiusZone1
                            position = "Votre position est stable"
                        Case Is < _radiusZone2
                            position = "Votre position se balance légèrement verticalement"
                        Case Is < _radiusZone3
                            position = "Votre position se balance verticalement"
                        Case Is < _radiusZone4
                            position = "Votre position se balance beaucoup verticalement"
                        Case Is > _radiusZone4
                            position = "Votre position se balance bien trop verticalement"
                        Case Else
                            position = "Pas de détection de position"
                    End Select
                Case Is < _radiusZone2
                    Select Case _standardErrorY
                        Case Is < _radiusZone1
                            position = "Votre position se balance légèrement horizontalement"
                        Case Is < _radiusZone2
                            position = "Votre position se balance légèrement"
                        Case Is < _radiusZone3
                            position = "Votre position se balance, notamment verticalement"
                        Case Is < _radiusZone4
                            position = "Votre position se balance, notamment beaucoup verticalement"
                        Case Is > _radiusZone4
                            position = "Votre position se balance, notamment bien trop verticalement"
                        Case Else
                            position = "Pas de détection de position"
                    End Select
                Case Is < _radiusZone3
                    Select Case _standardErrorY
                        Case Is < _radiusZone1
                            position = "Votre position se balance horizontalement"
                        Case Is < _radiusZone2
                            position = "Votre position se balance, notamment horizontalement"
                        Case Is < _radiusZone3
                            position = "Votre position se balance"
                        Case Is < _radiusZone4
                            position = "Votre position se balance horizontalement et beaucoup verticalement"
                        Case Is > _radiusZone4
                            position = "Votre position se balance horizontalement et bien trop verticalement"
                        Case Else
                            position = "Pas de détection de position"
                    End Select
                Case Is < _radiusZone4
                    Select Case _standardErrorY
                        Case Is < _radiusZone1
                            position = "Votre position se balance beaucoup horizontalement"
                        Case Is < _radiusZone2
                            position = "Votre position se balance, notamment beaucoup horizontalement"
                        Case Is < _radiusZone3
                            position = "Votre position se balance verticalement et beaucoup horizontalement"
                        Case Is < _radiusZone4
                            position = "Votre position se balance beaucoup"
                        Case Is > _radiusZone4
                            position = "Votre position se balance beaucoup horizontalement et bien trop verticalement"
                        Case Else
                            position = "Pas de détection de position"
                    End Select
                Case Is > _radiusZone4
                    Select Case _standardErrorY
                        Case Is < _radiusZone1
                            position = "Votre position se balance bien trop horizontalement"
                        Case Is < _radiusZone2
                            position = "Votre position se balance, notamment bien trop horizontalement"
                        Case Is < _radiusZone3
                            position = "Votre position se balance verticalement et bien trop horizontalement"
                        Case Is < _radiusZone4
                            position = "Votre position se balance beaucoup horizontalement et bien trop verticalement"
                        Case Is > _radiusZone4
                            position = "Votre position se balance bien trop"
                        Case Else
                            position = "Pas de détection de position"
                    End Select
                Case Else
                    position = "Pas de détection de position"
            End Select

            Select Case _averageX
                Case Is < -_radiusZone6
                    Select Case _averageY
                        Case Is < -_radiusZone6
                            viseur = "Réglez énormément le viseur vers le haut et la droite"
                        Case -_radiusZone6 To -_radiusZone5
                            viseur = "Réglez beaucoup le viseur vers le haut et énormément vers la droite"
                        Case -_radiusZone5 To -_radiusZone4
                            viseur = "Réglez le viseur vers le haut et énormément vers la droite"
                        Case -_radiusZone4 To -_radiusZone3
                            viseur = "Réglez légèrement le viseur vers le haut et énormément vers la droite"
                        Case -_radiusZone3 To -_radiusZone2
                            viseur = "Réglez très légèrement le viseur vers le haut et énormément vers la droite"
                        Case -_radiusZone2 To _radiusZone2
                            viseur = "Réglez énormément le viseur vers la droite"
                        Case _radiusZone2 To _radiusZone3
                            viseur = "Réglez très légèrement le viseur vers le bas et énormément vers la droite"
                        Case _radiusZone3 To _radiusZone4
                            viseur = "Réglez légèrement le viseur vers le bas et énormément vers la droite"
                        Case _radiusZone4 To _radiusZone5
                            viseur = "Réglez le viseur vers le bas et énormément vers la droite"
                        Case _radiusZone5 To _radiusZone6
                            viseur = "Réglez beaucoup le viseur vers le bas et énormément vers la droite"
                        Case Is > _radiusZone6
                            viseur = "Réglez énormément le viseur vers le bas et la droite"
                        Case Else
                            viseur = "Pas de détection du réglage du viseur"
                    End Select
                Case -_radiusZone6 To -_radiusZone5
                    Select Case _averageY
                        Case Is < -_radiusZone6
                            viseur = "Réglez énormément vers le haut et beaucoup sur la droite"
                        Case -_radiusZone6 To -_radiusZone5
                            viseur = "Réglez beaucoup le viseur vers le haut et la droite"
                        Case -_radiusZone5 To -_radiusZone4
                            viseur = "Réglez le viseur vers le haut et beaucoup vers la droite"
                        Case -_radiusZone4 To -_radiusZone3
                            viseur = "Réglez légèrement le viseur vers le haut et beaucoup vers la droite"
                        Case -_radiusZone3 To -_radiusZone2
                            viseur = "Réglez très légèrement le viseur vers le haut et beaucoup vers la droite"
                        Case -_radiusZone2 To _radiusZone2
                            viseur = "Réglez beaucoup le viseur vers la droite"
                        Case _radiusZone2 To _radiusZone3
                            viseur = "Réglez très légèrement le viseur vers le bas et beaucoup vers la droite"
                        Case _radiusZone3 To _radiusZone4
                            viseur = "Réglez légèrement le viseur vers le bas et beaucoup vers la droite"
                        Case _radiusZone4 To _radiusZone5
                            viseur = "Réglez le viseur vers le bas et beaucoup vers la droite"
                        Case _radiusZone5 To _radiusZone6
                            viseur = "Réglez beaucoup le viseur vers le bas et la droite"
                        Case Is > _radiusZone6
                            viseur = "Réglez énormément vers le bas et beaucoup sur la droite"
                        Case Else
                            viseur = "Pas de détection du réglage du viseur"
                    End Select
                Case -_radiusZone5 To -_radiusZone4
                    Select Case _averageY
                        Case Is < -_radiusZone6
                            viseur = "Réglez vers la droite et énormément vers le haut"
                        Case -_radiusZone6 To -_radiusZone5
                            viseur = "Réglez le viseur vers la droite et beaucoup vers le haut"
                        Case -_radiusZone5 To -_radiusZone4
                            viseur = "Réglez le viseur vers le haut et la droite"
                        Case -_radiusZone4 To -_radiusZone3
                            viseur = "Réglez le viseur vers la droite et légèrement vers le haut"
                        Case -_radiusZone3 To -_radiusZone2
                            viseur = "Réglez le viseur vers la droite et très légèrement  vers le haut"
                        Case -_radiusZone2 To _radiusZone2
                            viseur = "Réglez le viseur vers la droite"
                        Case _radiusZone2 To _radiusZone3
                            viseur = "Réglez le viseur vers la droite et très légèrement  vers le bas"
                        Case _radiusZone3 To _radiusZone4
                            viseur = "Réglez le viseur vers la droite et légèrement vers le bas"
                        Case _radiusZone4 To _radiusZone5
                            viseur = "Réglez le viseur vers le bas et la droite"
                        Case _radiusZone5 To _radiusZone6
                            viseur = "Réglez le viseur vers la droite et beaucoup vers le bas"
                        Case Is > _radiusZone6
                            viseur = "Réglez vers la droite et énormément vers le bas"
                        Case Else
                            viseur = "Pas de détection du réglage du viseur"
                    End Select
                Case -_radiusZone4 To -_radiusZone3
                    Select Case _averageY
                        Case Is < -_radiusZone6
                            viseur = "Réglez énormément le viseur vers le haut et légèrement vers la droite"
                        Case -_radiusZone6 To -_radiusZone5
                            viseur = "Réglez beaucoup le viseur vers le haut et légèrement vers la droite"
                        Case -_radiusZone5 To -_radiusZone4
                            viseur = "Réglez le viseur vers le haut et légèrement vers la droite"
                        Case -_radiusZone4 To -_radiusZone3
                            viseur = "Réglez légèrement le viseur vers le haut et la droite"
                        Case -_radiusZone3 To -_radiusZone2
                            viseur = "Réglez très légèrement le viseur vers le haut et légèrement vers la droite"
                        Case -_radiusZone2 To _radiusZone2
                            viseur = "Réglez légèrement le viseur vers la droite"
                        Case _radiusZone2 To _radiusZone3
                            viseur = "Réglez très légèrement le viseur vers le bas et légèrement vers la droite"
                        Case _radiusZone3 To _radiusZone4
                            viseur = "Réglez légèrement le viseur vers le bas et la droite"
                        Case _radiusZone4 To _radiusZone5
                            viseur = "Réglez le viseur vers le bas et légèrement vers la droite"
                        Case _radiusZone5 To _radiusZone6
                            viseur = "Réglez beaucoup le viseur vers le bas et légèrement vers la droite"
                        Case Is > _radiusZone6
                            viseur = "Réglez énormément le viseur vers le bas et légèrement vers la droite"
                        Case Else
                            viseur = "Pas de détection du réglage du viseur"
                    End Select
                Case -_radiusZone3 To -_radiusZone2
                    Select Case _averageY
                        Case Is < -_radiusZone6
                            viseur = "Réglez énormément le viseur vers le haut et très légèrement vers la droite"
                        Case -_radiusZone6 To -_radiusZone5
                            viseur = "Réglez beaucoup le viseur vers le haut et très légèrement vers la droite"
                        Case -_radiusZone5 To -_radiusZone4
                            viseur = "Réglez le viseur vers le haut et très légèrement vers la droite"
                        Case -_radiusZone4 To -_radiusZone3
                            viseur = "Réglez légèrement le viseur vers le haut et très légèrement vers la droite"
                        Case -_radiusZone3 To -_radiusZone2
                            viseur = "Réglez très légèrement le viseur vers le haut et la droite"
                        Case -_radiusZone2 To _radiusZone2
                            viseur = "Réglez très légèrement le viseur vers la droite"
                        Case _radiusZone2 To _radiusZone3
                            viseur = "Réglez très légèrement le viseur vers le bas et la droite"
                        Case _radiusZone3 To _radiusZone4
                            viseur = "Réglez légèrement le viseur vers le bas et très légèrement vers la droite"
                        Case _radiusZone4 To _radiusZone5
                            viseur = "Réglez le viseur vers le bas et très légèrement vers la droite"
                        Case _radiusZone5 To _radiusZone6
                            viseur = "Réglez beaucoup le viseur vers le bas et très légèrement vers la droite"
                        Case Is > _radiusZone6
                            viseur = "Réglez énormément le viseur vers le bas et très légèrement vers la droite"
                        Case Else
                            viseur = "Pas de détection du réglage du viseur"
                    End Select
                Case -_radiusZone2 To _radiusZone2
                    Select Case _averageY
                        Case Is < -_radiusZone6
                            viseur = "Réglez énormément le viseur vers le haut"
                        Case -_radiusZone6 To -_radiusZone5
                            viseur = "Réglez beaucoup le viseur vers le haut"
                        Case -_radiusZone5 To -_radiusZone4
                            viseur = "Réglez le viseur vers le haut"
                        Case -_radiusZone4 To -_radiusZone3
                            viseur = "Réglez légèrement le viseur vers le haut"
                        Case -_radiusZone3 To -_radiusZone2
                            viseur = "Réglez très légèrement le viseur vers le haut"
                        Case -_radiusZone2 To _radiusZone2
                            viseur = "Le viseur est réglé correctement"
                        Case _radiusZone2 To _radiusZone3
                            viseur = "Réglez très légèrement le viseur vers le bas"
                        Case _radiusZone3 To _radiusZone4
                            viseur = "Réglez légèrement le viseur vers le bas"
                        Case _radiusZone4 To _radiusZone5
                            viseur = "Réglez le viseur vers le bas"
                        Case _radiusZone5 To _radiusZone6
                            viseur = "Réglez beaucoup le viseur vers le bas"
                        Case Is > _radiusZone6
                            viseur = "Réglez énormément le viseur vers le bas"
                        Case Else
                            viseur = "Pas de détection du réglage du viseur"
                    End Select
                Case _radiusZone2 To _radiusZone3
                    Select Case _averageY
                        Case Is < -_radiusZone6
                            viseur = "Réglez énormément le viseur vers le haut et très légèrement vers la gauche"
                        Case -_radiusZone6 To -_radiusZone5
                            viseur = "Réglez beaucoup le viseur vers le haut et très légèrement vers la gauche"
                        Case -_radiusZone5 To -_radiusZone4
                            viseur = "Réglez le viseur vers le haut et très légèrement vers la gauche"
                        Case -_radiusZone4 To -_radiusZone3
                            viseur = "Réglez légèrement le viseur vers le haut et très légèrement vers la gauche"
                        Case -_radiusZone3 To -_radiusZone2
                            viseur = "Réglez très légèrement le viseur vers le haut et la gauche"
                        Case -_radiusZone2 To _radiusZone2
                            viseur = "Réglez très légèrement le viseur vers la gauche"
                        Case _radiusZone2 To _radiusZone3
                            viseur = "Réglez très légèrement le viseur vers le bas et la gauche"
                        Case _radiusZone3 To _radiusZone4
                            viseur = "Réglez légèrement le viseur vers le bas et très légèrement vers la gauche"
                        Case _radiusZone4 To _radiusZone5
                            viseur = "Réglez le viseur vers le bas et très légèrement vers la gauche"
                        Case _radiusZone5 To _radiusZone6
                            viseur = "Réglez beaucoup le viseur vers le bas et très légèrement vers la gauche"
                        Case Is > _radiusZone6
                            viseur = "Réglez énormément le viseur vers le bas et très légèrement vers la gauche"
                        Case Else
                            viseur = "Pas de détection du réglage du viseur"
                    End Select
                Case _radiusZone3 To _radiusZone4
                    Select Case _averageY
                        Case Is < -_radiusZone6
                            viseur = "Réglez énormément le viseur vers le haut et légèrement vers la gauche"
                        Case -_radiusZone6 To -_radiusZone5
                            viseur = "Réglez le viseur vers le haut et légèrement vers la gauche"
                        Case -_radiusZone4 To -_radiusZone3
                            viseur = "Réglez légèrement le viseur vers le haut et la gauche"
                        Case -_radiusZone3 To -_radiusZone2
                            viseur = "Réglez très légèrement le viseur vers le haut et légèrement vers la gauche"
                        Case -_radiusZone2 To _radiusZone2
                            viseur = "Réglez légèrement le viseur vers la gauche"
                        Case _radiusZone2 To _radiusZone3
                            viseur = "Réglez très légèrement le viseur vers le bas et légèrement vers la gauche"
                        Case _radiusZone3 To _radiusZone4
                            viseur = "Réglez légèrement le viseur vers le bas et la gauche"
                        Case _radiusZone4 To _radiusZone5
                            viseur = "Réglez le viseur vers le bas et légèrement vers la gauche"
                        Case _radiusZone5 To _radiusZone6
                            viseur = "Réglez beaucoup le viseur vers le bas et légèrement vers la gauche"
                        Case Is > _radiusZone6
                            viseur = "Réglez énormément le viseur vers le bas et légèrement vers la gauche"
                        Case Else
                            viseur = "Pas de détection du réglage du viseur"
                    End Select
                Case _radiusZone4 To _radiusZone5
                    Select Case _averageY
                        Case Is < -_radiusZone6
                            viseur = "Réglez vers la gauche et énormément vers le haut"
                        Case -_radiusZone6 To -_radiusZone5
                            viseur = "Réglez le viseur vers la gauche et beaucoup vers le haut"
                        Case -_radiusZone5 To -_radiusZone4
                            viseur = "Réglez le viseur vers le bas et la gauche"
                        Case -_radiusZone4 To -_radiusZone3
                            viseur = "Réglez le viseur vers la gauche et légèrement vers le haut"
                        Case -_radiusZone3 To -_radiusZone2
                            viseur = "Réglez le viseur vers la gauche et très légèrement  vers le haut"
                        Case -_radiusZone2 To _radiusZone2
                            viseur = "Réglez le viseur vers la gauche"
                        Case _radiusZone2 To _radiusZone3
                            viseur = "Réglez le viseur vers la gauche et très légèrement  vers le bas"
                        Case _radiusZone3 To _radiusZone4
                            viseur = "Réglez le viseur vers la gauche et légèrement vers le bas"
                        Case _radiusZone4 To _radiusZone5
                            viseur = "Réglez le viseur vers le bas et la gauche"
                        Case _radiusZone5 To _radiusZone6
                            viseur = "Réglez le viseur vers la gauche et beaucoup vers le bas"
                        Case Is > _radiusZone6
                            viseur = "Réglez vers la gauche et énormément vers le bas"
                        Case Else
                            viseur = "Pas de détection du réglage du viseur"
                    End Select
                Case _radiusZone5 To _radiusZone6
                    Select Case _averageY
                        Case Is < -_radiusZone6
                            viseur = "Réglez énormément vers le haut et beaucoup sur la gauche"
                        Case -_radiusZone6 To -_radiusZone5
                            viseur = "Réglez beaucoup le viseur vers le haut et la gauche"
                        Case -_radiusZone5 To -_radiusZone4
                            viseur = "Réglez le viseur vers le haut et beaucoup vers la gauche"
                        Case -_radiusZone4 To -_radiusZone3
                            viseur = "Réglez légèrement le viseur vers le haut et beaucoup vers la gauche"
                        Case -_radiusZone3 To -_radiusZone2
                            viseur = "Réglez très légèrement le viseur vers le haut et beaucoup vers la gauche"
                        Case -_radiusZone2 To _radiusZone2
                            viseur = "Réglez beaucoup le viseur vers la gauche"
                        Case _radiusZone2 To _radiusZone3
                            viseur = "Réglez très légèrement le viseur vers le bas et beaucoup vers la gauche"
                        Case _radiusZone3 To _radiusZone4
                            viseur = "Réglez légèrement le viseur vers le bas et beaucoup vers la gauche"
                        Case _radiusZone4 To _radiusZone5
                            viseur = "Réglez le viseur vers le bas et beaucoup vers la gauche"
                        Case _radiusZone5 To _radiusZone6
                            viseur = "Réglez beaucoup le viseur vers le bas et la gauche"
                        Case Is > _radiusZone6
                            viseur = "Réglez énormément vers le bas et beaucoup sur la gauche"
                        Case Else
                            viseur = "Pas de détection du réglage du viseur"
                    End Select
                Case Is > _radiusZone6
                    Select Case _averageY
                        Case Is < -_radiusZone6
                            viseur = "Réglez énormément le viseur vers le haut et la gauche"
                        Case -_radiusZone6 To -_radiusZone5
                            viseur = "Réglez beaucoup le viseur vers le haut et énormément vers la gauche"
                        Case -_radiusZone5 To -_radiusZone4
                            viseur = "Réglez le viseur vers le haut et énormément vers la gauche"
                        Case -_radiusZone4 To -_radiusZone3
                            viseur = "Réglez légèrement le viseur vers le haut et énormément vers la gauche"
                        Case -_radiusZone3 To -_radiusZone2
                            viseur = "Réglez très légèrement le viseur vers le haut et énormément vers la gauche"
                        Case -_radiusZone2 To _radiusZone2
                            viseur = "Réglez énormément le viseur vers la gauche"
                        Case _radiusZone2 To _radiusZone3
                            viseur = "Réglez très légèrement le viseur vers le bas et énormément vers la gauche"
                        Case _radiusZone3 To _radiusZone4
                            viseur = "Réglez légèrement le viseur vers le bas et énormément vers la gauche"
                        Case _radiusZone4 To _radiusZone5
                            viseur = "Réglez le viseur vers le bas et énormément vers la gauche"
                        Case _radiusZone5 To _radiusZone6
                            viseur = "Réglez beaucoup le viseur vers le bas et énormément vers la gauche"
                        Case Is > _radiusZone6
                            viseur = "Réglez énormément le viseur vers le bas et la gauche"
                        Case Else
                            viseur = "Pas de détection du réglage du viseur"
                    End Select

                Case Else
                    viseur = "Pas de détection du réglage du viseur"
            End Select
            Return Outliers() & vbCrLf & vbCrLf & position & vbCrLf & vbCrLf & viseur
        End If

    End Function
End Class
