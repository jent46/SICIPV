Public Class ClsCuota
    ''' <summary>
    ''' Declaracion de atributos
    ''' </summary>
    ''' <remarks></remarks>
    Private _idCuota As Integer
    Private _idFactura As ClsFactura
    Private _usuarioCreacion As ClsPersona
    Private _usuarioModificacion As ClsPersona

    Public Property IdCuota() As Integer
        Get
            Return _idCuota
        End Get
        Set(ByVal value As Integer)
            _idCuota = value
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

    Public Property IdUsuarioCreacion() As ClsPersona
        Get
            Return _usuarioCreacion
        End Get
        Set(ByVal value As ClsPersona)
            _usuarioCreacion = value
        End Set
    End Property

    Public Property IdUsuarioModificacion() As ClsPersona
        Get
            Return _usuarioModificacion
        End Get
        Set(ByVal value As ClsPersona)
            _usuarioModificacion = value
        End Set
    End Property

    Private _fecha As Date
    Public Property Fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
        End Set
    End Property

    Private _saldo As Double
    Public Property Saldo() As Double
        Get
            Return _saldo
        End Get
        Set(ByVal value As Double)
            _saldo = value
        End Set
    End Property

    Private _valorCuota As Double
    Public Property ValorCuota() As Double
        Get
            Return _valorCuota
        End Get
        Set(ByVal value As Double)
            _valorCuota = value
        End Set
    End Property


    Private _porcentajeInteres As Double
    Public Property PorcentajeInteres() As Double
        Get
            Return _porcentajeInteres
        End Get
        Set(ByVal value As Double)
            _porcentajeInteres = value
        End Set
    End Property

    Private _interesFactura As Double
    Public Property InteresFactura() As Double
        Get
            Return _interesFactura
        End Get
        Set(ByVal value As Double)
            _interesFactura = value
        End Set
    End Property

    Private _interesMora As Double
    Public Property InteresMora() As Double
        Get
            Return _interesMora
        End Get
        Set(ByVal value As Double)
            _interesMora = value
        End Set
    End Property

    Private _valorTotal As Double
    Public Property ValorTotal() As Double
        Get
            Return _valorTotal
        End Get
        Set(ByVal value As Double)
            _valorTotal = value
        End Set
    End Property

    Private _comentario As String
    Public Property Comentario() As String
        Get
            Return _comentario
        End Get
        Set(ByVal value As String)
            _comentario = value
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

    Private _fechaCreacion As Date
    Public Property FechaCreacion() As Date
        Get
            Return _fechaCreacion
        End Get
        Set(ByVal value As Date)
            _fechaCreacion = value
        End Set
    End Property

    Private _fechaModificacion As Date
    Public Property FechaModificacion() As Date
        Get
            Return _fechaModificacion
        End Get
        Set(ByVal value As Date)
            _fechaModificacion = value
        End Set
    End Property



End Class
