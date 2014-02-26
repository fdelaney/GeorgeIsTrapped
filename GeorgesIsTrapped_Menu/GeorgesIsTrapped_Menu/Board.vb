Public Class Board
    'Attributs de classe (Proprietes)
    Dim sizeX As Integer
    Dim sizeY As Integer

    'Constrcuteur
    Public Sub New(_sizeX As Integer, _sizeY As Integer)
        sizeX = _sizeX
        sizeY = _sizeY
    End Sub

    'Methodes
    Public Function moveCharacterUp(PersoX As Integer, PersoY As Integer) As Integer
        If CollisionCheck(PersoX, (PersoY - 1)) = False AndAlso George.characterLock = False Then
            George.moved = True
            PersoY = PersoY - 1
        End If
        Return PersoY
    End Function
    Public Function moveCharacterDown(PersoX As Integer, PersoY As Integer) As Integer
        If CollisionCheck(PersoX, (PersoY + 1)) = False AndAlso George.characterLock = False Then
            George.moved = True
            PersoY = PersoY + 1
        End If
        Return PersoY
    End Function
    Public Function moveCharacterRight(PersoX As Integer, PersoY As Integer) As Integer
        If CollisionCheck((PersoX + 1), PersoY) = False AndAlso George.characterLock = False Then
            George.moved = True
            PersoX = PersoX + 1
        End If
        Return PersoX
    End Function
    Public Function moveCharacterLeft(PersoX As Integer, PersoY As Integer) As Integer
        If CollisionCheck((PersoX - 1), PersoY) = False AndAlso George.characterLock = False Then
            George.moved = True
            PersoX = PersoX - 1
        End If
        Return PersoX
    End Function

    Public Function CollisionCheck(posX As Integer, posY As Integer) As Boolean
        Return George.CarteLogique(posX, posY).collision
    End Function
End Class
