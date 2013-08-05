Public Class ClsIngresoProducto
    ''' <summary>
    ''' Declaracion de atributos
    ''' </summary>
    ''' <remarks></remarks>

    Private _idIngresoProucto As Integer
    Private _idProducto As ClsProducto
    Private _usuarioCreacion As ClsUsuario
    Private _usuarioModificacion As ClsUsuario
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

    Public Property UsuarioCreacion() As ClsUsuario
        Get
            Return _usuarioCreacion
        End Get
        Set(ByVal value As ClsUsuario)
            _usuarioCreacion = value
        End Set
    End Property

    Public Property UsuarioModificacion() As ClsUsuario
        Get
            Return _usuarioModificacion
        End Get
        Set(ByVal value As ClsUsuario)
            _usuarioModificacion = value
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
