Public Class ClsAbono
    ''' <summary>
    ''' Declaracion de atributos
    ''' </summary>
    ''' <remarks></remarks>
    Private _idAbono As Integer
    Private _idFactura As Integer
    Private _usuarioCreacion As Integer
    Private _usuarioModificacion As Integer
    Private _saldoPagado As Double
    Private _saldoPendiente As Double
    Private _interes As Double
    Private _fecha As Date
    Private _fechaCreacion As Date
    Private _estado As Integer

    Public Property IdAbono() As String
        Get
            Return _idAbono
        End Get
        Set(ByVal value As String)
            _idAbono = value
        End Set
    End Property

    Public Property IdFactura() As Integer
        Get
            Return _idFactura
        End Get
        Set(ByVal value As Integer)
            _idFactura = value
        End Set
    End Property

    Public Property UsuarioCreacion() As String
        Get
            Return _usuarioCreacion
        End Get
        Set(ByVal value As String)
            _usuarioCreacion = value
        End Set
    End Property

    Public Property UsuarioModificacion() As String
        Get
            Return _usuarioModificacion
        End Get
        Set(ByVal value As String)
            _usuarioModificacion = value
        End Set
    End Property

    Public Property SaldoPagado() As Double
        Get
            Return _saldoPagado
        End Get
        Set(ByVal value As Double)
            _saldoPagado = value
        End Set
    End Property

    Public Property SaldoPendiente() As Double
        Get
            Return _saldoPendiente
        End Get
        Set(ByVal value As Double)
            _saldoPendiente = value
        End Set
    End Property

    Public Property Interes() As Double
        Get
            Return _interes
        End Get
        Set(ByVal value As Double)
            _interes = value
        End Set
    End Property

    Public Property Fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
        End Set
    End Property

    Public Property FechaCreacion() As Date
        Get
            Return _fechaCreacion
        End Get
        Set(ByVal value As Date)
            _fechaCreacion = value
        End Set
    End Property

    Public Property Estado() As Integer
        Get
            Return _estado
        End Get
        Set(ByVal value As Integer)
            _estado = value
        End Set
    End Property

End Class
