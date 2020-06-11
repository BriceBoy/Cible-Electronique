Imports System.IO

Public Class Target
    Private _dataSetElectronicTarget As DataSetElectronicTarget
    Private _targetsTableAdapter As DataSetElectronicTargetTableAdapters.targetsTableAdapter

    Private _name As String
    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Private _widthMM As Integer
    Public Property WidthMM() As Integer
        Get
            Return _widthMM
        End Get
        Set(ByVal value As Integer)
            _widthMM = value
        End Set
    End Property

    Private _heightMM As Integer
    Public Property HeightMM() As Integer
        Get
            Return _heightMM
        End Get
        Set(ByVal value As Integer)
            _heightMM = value
        End Set
    End Property

    Private _img As Image
    Public Property Img() As Image
        Get
            Return _img
        End Get
        Set(ByVal value As Image)
            _img = value
        End Set
    End Property

    Private _listZonesRadius As List(Of Decimal)
    Public Property ListZonesRadius() As List(Of Decimal)
        Get
            Return _listZonesRadius
        End Get
        Set(ByVal value As List(Of Decimal))
            _listZonesRadius = value
        End Set
    End Property

    Private _listZonesScore As List(Of Integer)
    Public Property listZonesScore() As List(Of Integer)
        Get
            Return _listZonesScore
        End Get
        Set(ByVal value As List(Of Integer))
            _listZonesScore = value
        End Set
    End Property

    Public Sub New()
        _dataSetElectronicTarget = New DataSetElectronicTarget
        _targetsTableAdapter = New DataSetElectronicTargetTableAdapters.targetsTableAdapter

        _name = ""
        _heightMM = 0
        _widthMM = 0
        _img = Nothing
        _listZonesRadius = New List(Of Decimal)
        _listZonesScore = New List(Of Integer)
    End Sub

    Public Sub LoadTarget(ByVal targetName As String)
        Try
            _targetsTableAdapter.FillByName(_dataSetElectronicTarget.targets, targetName)
            If _dataSetElectronicTarget.targets.Rows.Count > 0 Then
                Dim targetRow As DataSetElectronicTarget.targetsRow = _dataSetElectronicTarget.targets.Rows(0)
                With targetRow
                    _name = .name
                    _widthMM = .width_mm
                    _heightMM = .height_mm
                    _img = byteArrayToImage(.img)
                    _listZonesRadius = New List(Of Decimal) From { .radius_zone_1, .radius_zone_2, .radius_zone_3, .radius_zone_4, .radius_zone_5, .radius_zone_6, .radius_zone_7, .radius_zone_8, .radius_zone_9, .radius_zone_10, .radius_zone_11}
                    _listZonesScore = New List(Of Integer) From { .score_zone_1, .score_zone_2, .score_zone_3, .score_zone_4, .score_zone_5, .score_zone_6, .score_zone_7, .score_zone_8, .score_zone_9, .score_zone_10, .score_zone_11}
                End With
            End If
        Catch ex As Exception
            MsgBox("Erreur : " & ex.Message, MsgBoxStyle.Critical, "Erreur")
        End Try
    End Sub

    Public Function SaveToDatabase() As String

        If _name = "" Then
            Return "Veuillez définir un nom pour la cible"
        End If
        If _targetsTableAdapter.FillByName(_dataSetElectronicTarget.targets, _name) > 0 Then
            Return "Une cible portant ce nom existe déjà"
        End If
        If HeightMM = 0 Or WidthMM = 0 Then
            Return "Veuillez spécifier les dimensions de la cible"
        End If
        If IsNothing(_img) Then
            Return "Veuillez ajouter une image pour la cible"
        End If

        Try
            Dim newTargetRow As DataSetElectronicTarget.targetsRow
            newTargetRow = _dataSetElectronicTarget.targets.NewtargetsRow
            With newTargetRow
                .name = _name
                .width_mm = _widthMM
                .height_mm = _heightMM
                .img = imgToByteArray(_img)

                .radius_zone_1 = _listZonesRadius(0)
                .score_zone_1 = _listZonesScore(0)
                .radius_zone_2 = _listZonesRadius(1)
                .score_zone_2 = _listZonesScore(1)
                .radius_zone_3 = _listZonesRadius(2)
                .score_zone_3 = _listZonesScore(2)
                .radius_zone_4 = _listZonesRadius(3)
                .score_zone_4 = _listZonesScore(3)
                .radius_zone_5 = _listZonesRadius(4)
                .score_zone_5 = _listZonesScore(4)
                .radius_zone_6 = _listZonesRadius(5)
                .score_zone_6 = _listZonesScore(5)
                .radius_zone_7 = _listZonesRadius(6)
                .score_zone_7 = _listZonesScore(6)
                .radius_zone_8 = _listZonesRadius(7)
                .score_zone_8 = _listZonesScore(7)
                .radius_zone_9 = _listZonesRadius(8)
                .score_zone_9 = _listZonesScore(8)
                .radius_zone_10 = _listZonesRadius(9)
                .score_zone_10 = _listZonesScore(9)
                .radius_zone_11 = _listZonesRadius(10)
                .score_zone_11 = _listZonesScore(10)

            End With
            _dataSetElectronicTarget.targets.AddtargetsRow(newTargetRow)
            _targetsTableAdapter.Update(_dataSetElectronicTarget.targets)
            Return "OK"
        Catch ex As Exception
            Return ex.Message
        End Try
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

    Public Function getScore(ByVal x As Decimal, ByVal y As Decimal) As Integer
        Dim distance As Decimal = getDistance(x, y)
        If distance < (_listZonesRadius(0) / 2) And _listZonesRadius(0) <> 0 Then
            Return _listZonesScore(0)
        End If
        If distance < (_listZonesRadius(1) / 2) And _listZonesRadius(1) <> 0 Then
            Return _listZonesScore(1)
        End If
        If distance < (_listZonesRadius(2) / 2) And _listZonesRadius(2) <> 0 Then
            Return _listZonesScore(2)
        End If
        If distance < (_listZonesRadius(3) / 2) And _listZonesRadius(3) <> 0 Then
            Return _listZonesScore(3)
        End If
        If distance < (_listZonesRadius(4) / 2) And _listZonesRadius(4) <> 0 Then
            Return _listZonesScore(4)
        End If
        If distance < (_listZonesRadius(5) / 2) And _listZonesRadius(5) <> 0 Then
            Return _listZonesScore(5)
        End If
        If distance < (_listZonesRadius(6) / 2) And _listZonesRadius(6) <> 0 Then
            Return _listZonesScore(6)
        End If
        If distance < (_listZonesRadius(7) / 2) And _listZonesRadius(7) <> 0 Then
            Return _listZonesScore(7)
        End If
        If distance < (_listZonesRadius(8) / 2) And _listZonesRadius(8) <> 0 Then
            Return _listZonesScore(8)
        End If
        If distance < (_listZonesRadius(9) / 2) And _listZonesRadius(9) <> 0 Then
            Return _listZonesScore(9)
        End If
        If distance < (_listZonesRadius(10) / 2) And _listZonesRadius(10) <> 0 Then
            Return _listZonesScore(10)
        End If
        Return 0
    End Function

    Public Function getDistance(ByVal x As Decimal, y As Decimal) As Decimal
        Return Math.Sqrt((x ^ 2) + (y ^ 2))
    End Function
End Class
