Public Class ClsTipoVenta
    ''' <summary>
    ''' Declaracion de atributos
    ''' </summary>
    ''' <remarks></remarks>
    Private _idTipoVenta As Integer
    Private _usuarioCreacion As ClsUsuario
    Private _usuarioModificacion As ClsUsuario
    Private _fechaCreacion As Date
    Private _fechaModificacion As Date
    Private _estado As Integer

    Public Property IdTipoVenta() As Integer
        Get
            Return _idTipoVenta
        End Get
        Set(ByVal value As Integer)
            _idTipoVenta = value
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

    Public Property Estado() As Integer
        Get
            Return _estado
        End Get
        Set(ByVal value As Integer)
            _estado = value
        End Set
    End Property

End Class
