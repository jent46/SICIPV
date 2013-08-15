Public Class ClsIngresoProducto
    ''' <summary>
    ''' Declaracion de atributos
    ''' </summary>
    ''' <remarks></remarks>

    Private _idIngresoProucto As Integer
    Private _idProducto As ClsProducto
    Private _idUsuarioCreacion As ClsUsuario
    Private _udUsuarioModificacion As ClsUsuario
    Private _cantidad As Integer
    Private _fecha As Date
    Private _estado As Integer
    Private _fechaCreacion As Date
    Private _fechaModificacion As Date

    Public Property IdIngresoProducto() As Integer
        Get
            Return _idIngresoProucto
        End Get
        Set(ByVal value As Integer)
            _idIngresoProucto = value
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
            Return _udUsuarioModificacion
        End Get
        Set(ByVal value As ClsUsuario)
            _udUsuarioModificacion = value
        End Set
    End Property

    Public Property Cantidad() As Integer
        Get
            Return _cantidad
        End Get
        Set(ByVal value As Integer)
            _cantidad = value
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
