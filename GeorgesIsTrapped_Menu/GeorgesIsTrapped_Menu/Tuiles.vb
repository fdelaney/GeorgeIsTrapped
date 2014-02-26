Public Class Tuiles
    Private collisionSet As Boolean
    Public Property collision() As Boolean
        Get
            Return collisionSet
        End Get
        Set(ByVal value As Boolean)
            collisionSet = value

        End Set
    End Property
End Class
