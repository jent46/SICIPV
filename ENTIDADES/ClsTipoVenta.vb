Public Class ClsTipoVenta
    ''' <summary>
    ''' Declaracion de atributos
    ''' </summary>
    ''' <remarks></remarks>
    Private _idTipoVenta As Integer

    Public Property IdTipoVenta() As Integer
        Get
            Return _idTipoVenta
        End Get
        Set(ByVal value As Integer)
            _idTipoVenta = value
        End Set
    End Property

End Class
