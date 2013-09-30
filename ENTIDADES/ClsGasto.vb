Public Class ClsGasto


    Private _idUsuarioCreacion As ClsUsuario
    Public Property IdUsuarioCreacion() As ClsUsuario
        Get
            Return _idUsuarioCreacion
        End Get
        Set(ByVal value As ClsUsuario)
            _idUsuarioCreacion = value
        End Set
    End Property

    Private _idUsuarioModificacion As ClsUsuario
    Public Property IdUsuarioModificacion() As ClsUsuario
        Get
            Return _idUsuarioModificacion
        End Get
        Set(ByVal value As ClsUsuario)
            _idUsuarioModificacion = value
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
    Private _observacion As String
    Public Property Observacion() As String
        Get
            Return _observacion
        End Get
        Set(ByVal value As String)
            _observacion = value
        End Set
    End Property

    Private _beneficiario As String
    Public Property Beneficiario() As String
        Get
            Return _beneficiario
        End Get
        Set(ByVal value As String)
            _beneficiario = value
        End Set
    End Property

    Private _detalle As String
    Public Property Detelle() As String
        Get
            Return _detalle
        End Get
        Set(ByVal value As String)
            _detalle = value
        End Set
    End Property

    Private _numFactura As String
    Public Property NumFactura() As String
        Get
            Return _numFactura
        End Get
        Set(ByVal value As String)
            _numFactura = value
        End Set
    End Property

    Private _numDocumento As String
    Public Property NumDocumento() As String
        Get
            Return _numDocumento
        End Get
        Set(ByVal value As String)
            _numDocumento = value
        End Set
    End Property

    Private _numRetencion As String
    Public Property NumRetencion() As String
        Get
            Return _numRetencion
        End Get
        Set(ByVal value As String)
            _numRetencion = value
        End Set
    End Property

    Private _valor As Double
    Public Property Valor() As Double
        Get
            Return _valor
        End Get
        Set(ByVal value As Double)
            _valor = value
        End Set
    End Property


End Class
