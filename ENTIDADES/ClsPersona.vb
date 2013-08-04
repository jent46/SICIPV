Public Class ClsPersona
    ''' <summary>
    ''' Declaracion de atributos
    ''' </summary>
    ''' <remarks></remarks>
    Private _idPersona As Integer
    Private _usuarioCreacion As String
    Private _usuarioModificacion As String
    Private _nombre As String
    Private _apellido As String
    Private _cedula As Integer
    Private _estadoCivil As Integer
    Private _fechaNacimiento As Date
    Private _telefono As String
    Private _direccion As String
    Private _fechaCreacion As Date
    Private _fechaModificacion As Date
    Private _estado As Integer

    Public Property IdPersona() As Integer
        Get
            Return _idPersona
        End Get
        Set(ByVal value As Integer)
            _idPersona = value
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

    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Public Property Apellido() As String
        Get
            Return _apellido
        End Get
        Set(ByVal value As String)
            _apellido = value
        End Set
    End Property

    Public Property Cedula() As Integer
        Get
            Return _cedula
        End Get
        Set(ByVal value As Integer)
            _cedula = value
        End Set
    End Property

    Public Property EstadoCivil() As Integer
        Get
            Return _estadoCivil
        End Get
        Set(ByVal value As Integer)
            _estadoCivil = value
        End Set
    End Property

    Public Property FechaNacimiento() As Date
        Get
            Return _fechaNacimiento
        End Get
        Set(ByVal value As Date)
            _fechaNacimiento = value
        End Set
    End Property

    Public Property Telefono() As String
        Get
            Return _telefono
        End Get
        Set(ByVal value As String)
            _telefono = value
        End Set
    End Property

    Public Property Direccion() As String
        Get
            Return _direccion
        End Get
        Set(ByVal value As String)
            _direccion = value
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
