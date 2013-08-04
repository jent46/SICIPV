Public Class ClsFactur
    ''' <summary>
    ''' Declaracion de atributos
    ''' </summary>
    ''' <remarks></remarks>
    Private _idFactura As Integer
    Private _idPersona As Integer
    Private _idGarante As Integer
    Private _numeroFactura As String
    Private _numeroContrato As String
    Private _fechaVenta As Date
    Private _subtotal As Double
    Private _iva As Double
    Private _descuento As Double
    Private _totalVenta As Double
    Private _estado As Integer


    Public Property IdFactura() As Integer
        Get
            Return _idFactura
        End Get
        Set(ByVal value As Integer)
            _idFactura = value
        End Set
    End Property

    Public Property IdPersona() As Integer
        Get
            Return _idPersona
        End Get
        Set(ByVal value As Integer)
            _idPersona = value
        End Set
    End Property


    Public Property IdGarante() As Integer
        Get
            Return _idGarante
        End Get
        Set(ByVal value As Integer)
            _idGarante = value
        End Set
    End Property


    Public Property NumeroFactura() As String
        Get
            Return _numeroFactura
        End Get
        Set(ByVal value As String)
            _numeroFactura = value
        End Set
    End Property

    Public Property NumeroContrato() As String
        Get
            Return _numeroContrato
        End Get
        Set(ByVal value As String)
            _numeroContrato = value
        End Set
    End Property

    Public Property FechaVenta() As Date
        Get
            Return _fechaVenta
        End Get
        Set(ByVal value As Date)
            _fechaVenta = value
        End Set
    End Property

    Public Property Subtotal() As Double
        Get
            Return _subtotal
        End Get
        Set(ByVal value As Double)
            _subtotal = value
        End Set
    End Property

    Public Property NewProperty() As Double
        Get
            Return _iva
        End Get
        Set(ByVal value As Double)
            _iva = value
        End Set
    End Property

    Public Property Descuento() As Double
        Get
            Return _descuento
        End Get
        Set(ByVal value As Double)
            _descuento = value
        End Set
    End Property

    Public Property TotalVenta() As Double
        Get
            Return _totalVenta
        End Get
        Set(ByVal value As Double)
            _totalVenta = value
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
