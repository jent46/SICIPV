Public Class ClsTipoVenta
    ''' <summary>
    ''' Declaracion de atributos
    ''' </summary>
    ''' <remarks></remarks>
    Private _idTipoVenta As Integer
    Private _idUsuarioCreacion As ClsUsuario
    Private _idUsuarioModificacion As ClsUsuario
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

    Private _descripcion As String
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
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
