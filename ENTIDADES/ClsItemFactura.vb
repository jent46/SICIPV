Public Class ClsItemFactura
    ''' <summary>
    ''' Declaracion de atributos
    ''' </summary>
    ''' <remarks></remarks>

    Private _idItemFactura As Integer
    Private _idProducto As ClsProducto
    Private _idUsuarioCreacion As ClsUsuario
    Private _idUsuarioModificacion As ClsUsuario
    Private _precioUnitario As Double
    Private _cantidad As Double
    Private _precioTotal As Double
    Private _descripcionProducto As String
    Private _costoProducto As Double
    Private _fechaCreacion As Date
    Private _fechaModificacion As Date

    Private _idFactura As ClsFactura

    Public Property IdItemFactura() As Integer
        Get
            Return _idItemFactura
        End Get
        Set(ByVal value As Integer)
            _idItemFactura = value
        End Set
    End Property

    Public Property IdFactura() As ClsFactura
        Get
            Return _idFactura
        End Get
        Set(ByVal value As ClsFactura)
            _idFactura = value
        End Set
    End Property

    Public Property IdProducto() As ClsProducto
        Get
            Return _idProducto
        End Get
        Set(ByVal value As ClsProducto)
            _idProducto = value
        End Set
    End Property

    Public Property IdUsuarioCreacion() As ClsUsuario
        Get
            Return _idUsuarioCreacion
        End Get
        Set(ByVal value As ClsUsuario)
            _idUsuarioCreacion = value
        End Set
    End Property

    Public Property IdUsuarioModificacion() As ClsUsuario
        Get
            Return _idUsuarioModificacion
        End Get
        Set(ByVal value As ClsUsuario)
            _idUsuarioModificacion = value
        End Set
    End Property

    Public Property PrecioUnitario() As Double
        Get
            Return _precioUnitario
        End Get
        Set(ByVal value As Double)
            _precioUnitario = value
        End Set
    End Property

    Public Property Cantidad() As Double
        Get
            Return _cantidad
        End Get
        Set(ByVal value As Double)
            _cantidad = value
        End Set
    End Property

    Public Property PrecioTotal() As Double
        Get
            Return _precioTotal
        End Get
        Set(ByVal value As Double)
            _precioTotal = value
        End Set
    End Property

    Public Property DescripcionProducto() As String
        Get
            Return _descripcionProducto
        End Get
        Set(ByVal value As String)
            _descripcionProducto = value
        End Set
    End Property

    Public Property CostoProducto() As Double
        Get
            Return _costoProducto
        End Get
        Set(ByVal value As Double)
            _costoProducto = value
        End Set
    End Property

    Private _estado As Integer
    Public Property Estado() As Integer
        Get
            Return _estado
        End Get
        Set(ByVal value As Integer)
            _estado = value
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

    Public Property FechaModificacion() As Date
        Get
            Return _fechaModificacion
        End Get
        Set(ByVal value As Date)
            _fechaModificacion = value
        End Set
    End Property

End Class
