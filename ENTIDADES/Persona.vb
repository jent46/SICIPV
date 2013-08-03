Public Class Persona

    Private _idPersona As Integer
    Public Property idPersona() As Integer
        Get
            Return _idPersona
        End Get
        Set(ByVal value As Integer)
            _idPersona = value
        End Set
    End Property

    Private _nombre As String
    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Private _apellido As String
    Public Property apellido() As String
        Get
            Return _apellido
        End Get
        Set(ByVal value As String)
            _apellido = value
        End Set
    End Property

    Private _cedula As Integer
    Public Property cedula() As Integer
        Get
            Return _cedula
        End Get
        Set(ByVal value As Integer)
            _cedula = value
        End Set
    End Property

    Private _estadoCivil As Integer
    Public Property estadoCivil() As Integer
        Get
            Return _estadoCivil
        End Get
        Set(ByVal value As Integer)
            _estadoCivil = value
        End Set
    End Property

    Private _fechaNacimiento As Date
    Public Property fechaNacimiento() As Date
        Get
            Return _fechaNacimiento
        End Get
        Set(ByVal value As Date)
            _fechaNacimiento = value
        End Set
    End Property

    Private _telefono As String
    Public Property telefono() As String
        Get
            Return telefono
        End Get
        Set(ByVal value As String)
            telefono = value
        End Set
    End Property

    Private _direccion As String
    Public Property direccion() As String
        Get
            Return _direccion
        End Get
        Set(ByVal value As String)
            _direccion = value
        End Set
    End Property

    Private _usuarioCreacion As String
    Public Property usuarioCreacion() As String
        Get
            Return _usuarioCreacion
        End Get
        Set(ByVal value As String)
            _usuarioCreacion = value
        End Set
    End Property

    Private _usuarioModificacion As String
    Public Property usuarioModificacion() As String
        Get
            Return _usuarioModificacion
        End Get
        Set(ByVal value As String)
            _usuarioModificacion = value
        End Set
    End Property

    Private _fechaCreacion As Date
    Public Property fechaCreacion() As Date
        Get
            Return _fechaCreacion
        End Get
        Set(ByVal value As Date)
            _fechaCreacion = value
        End Set
    End Property

    Private _fechaModificacion As Date
    Public Property fechaMoficacion() As Date
        Get
            Return _fechaModificacion
        End Get
        Set(ByVal value As Date)
            _fechaModificacion = value
        End Set
    End Property

End Class
