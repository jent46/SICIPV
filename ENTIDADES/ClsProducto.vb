Public Class ClsProducto
    ''' <summary>
    ''' Declaracion de atributos
    ''' </summary>
    ''' <remarks></remarks>

    Private _idProducto As Integer
    Private _idUsuarioCreacion As ClsUsuario
    Private _idUsuarioModificacion As ClsUsuario
    Private _descripcion As String
    Private _valor As Double
    Private _pvp As Double
    Private _stock As Integer
    Private _fechaCreacion As Date
    Private _fechaModificacion As Date
    
    Private _estado As Integer
    Public Property Estado() As Integer
        Get
            Return _estado
        End Get
        Set(ByVal value As Integer)
            _estado = value
        End Set
    End Property


    Public Property IdProducto() As Integer
        Get
            Return _idProducto
        End Get
        Set(ByVal value As Integer)
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

    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property
    Private _modelo As String
    Public Property Modelo() As String
        Get
            Return _modelo
        End Get
        Set(ByVal value As String)
            _modelo = value
        End Set
    End Property


    Public Property Valor() As Double
        Get
            Return _valor
        End Get
        Set(ByVal value As Double)
            _valor = value
        End Set
    End Property

    Public Property Pvp() As Double
        Get
            Return _pvp
        End Get
        Set(ByVal value As Double)
            _pvp = value
        End Set
    End Property
    Private _gravaIva As Integer
    Public Property GravaIva() As String
        Get
            Return _gravaIva
        End Get
        Set(ByVal value As String)
            _gravaIva = value
        End Set
    End Property


    Public Property Stock() As Integer
        Get
            Return _stock
        End Get
        Set(ByVal value As Integer)
            _stock = value
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
