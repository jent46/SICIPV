Public Class ClsMarca

    Private _idMarca As Integer
    Public Property IdMarca() As Integer
        Get
            Return _idMarca
        End Get
        Set(ByVal value As Integer)
            _idMarca = value
        End Set
    End Property


    Private _nombreMarca As String
    Public Property NombreMarca() As String
        Get
            Return _nombreMarca
        End Get
        Set(ByVal value As String)
            _nombreMarca = value
        End Set
    End Property


End Class
