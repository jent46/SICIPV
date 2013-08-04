Public Class ClsRol
    ''' <summary>
    ''' Declaracion de atributos
    ''' </summary>
    ''' <remarks></remarks>
    Private _idRol As Integer
    Private _descripcion As String

    Public Property IdRol() As Integer
        Get
            Return _idRol
        End Get
        Set(ByVal value As Integer)
            _idRol = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

End Class
