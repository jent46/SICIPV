Public Class ClsEstadoCivil
    ''' <summary>
    ''' Declaracion de atributos
    ''' </summary>
    ''' <remarks></remarks>
    Private _idEstadoCivil As Integer
    Private _descripcion As String

    Public Property IdEstadoCivil() As String
        Get
            Return _idEstadoCivil
        End Get
        Set(ByVal value As String)
            _idEstadoCivil = value
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
