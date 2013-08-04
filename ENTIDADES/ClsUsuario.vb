Public Class ClsUsuario
    ''' <summary>
    ''' Declaracion de atributos
    ''' </summary>
    ''' <remarks></remarks>
    Private _idUsuario As Integer
    Private _idRol As Integer
    Private _nombre As String
    Private _apellido As String
    Private _usuario As String
    Private _contrasena As String
    Private _fechaCreacion As Date
    Private _fechaModificacion As Date
    Private _estado As Integer

    Public Property IdUsuario() As Integer
        Get
            Return _idUsuario
        End Get
        Set(ByVal value As Integer)
            _idUsuario = value
        End Set
    End Property

    Public Property IdRol() As Integer
        Get
            Return _idRol
        End Get
        Set(ByVal value As Integer)
            _idRol = value
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

    Public Property Usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property

    Public Property Contrasena() As String
        Get
            Return _contrasena
        End Get
        Set(ByVal value As String)
            _contrasena = value
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
