Public Class ClsFactura
    ''' <summary>
    ''' Declaracion de atributos
    ''' </summary>
    ''' <remarks></remarks>
    Private _idFactura As Integer
    Private _idTipoVenta As ClsTipoVenta
    Private _idPersona As ClsPersona
    Private _idGarante As ClsPersona
    Private _idUsuarioCreacion As ClsUsuario
    Private _idUsuarioModificacion As ClsUsuario
    Private _numeroFactura As String
    Private _numeroContrato As String
    Private _fechaVenta As Date
    Private _subtotal As Double
    Private _iva As Double
    Private _descuento As Double
    Private _totalVenta As Double
    Private _estado As Integer


    Private _itemsProductos As New List(Of ClsItemFactura)
    Public Property ItemsProductos() As List(Of ClsItemFactura)
        Get
            Return _itemsProductos
        End Get
        Set(ByVal value As List(Of ClsItemFactura))
            _itemsProductos = value
        End Set
    End Property

    Private _listaCuotas As New List(Of ClsCuota)
    Public Property ListaCuotas() As List(Of ClsCuota)
        Get
            Return _listaCuotas
        End Get
        Set(ByVal value As List(Of ClsCuota))
            _listaCuotas = value
        End Set
    End Property

    Public Property IdFactura() As Integer
        Get
            Return _idFactura
        End Get
        Set(ByVal value As Integer)
            _idFactura = value
        End Set
    End Property

    Public Property IdTipoVenta() As ClsTipoVenta
        Get
            Return _idTipoVenta
        End Get
        Set(ByVal value As ClsTipoVenta)
            _idTipoVenta = value
        End Set
    End Property

    Public Property IdPersona() As ClsPersona
        Get
            Return _idPersona
        End Get
        Set(ByVal value As ClsPersona)
            _idPersona = value
        End Set
    End Property

    Public Property IdGarante() As ClsPersona
        Get
            Return _idGarante
        End Get
        Set(ByVal value As ClsPersona)
            _idGarante = value
        End Set
    End Property

    Private _idCuotaValor As ClsCuotaValor
    Public Property IdCuotaValor() As ClsCuotaValor
        Get
            Return _idCuotaValor
        End Get
        Set(ByVal value As ClsCuotaValor)
            _idCuotaValor = value
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

    Public Property Iva() As Double
        Get
            Return _iva
        End Get
        Set(ByVal value As Double)
            _iva = value
        End Set
    End Property

   

  

    Private _porcentajeDescuento As Double
    Public Property PorcentajeDescuento() As Double
        Get
            Return _porcentajeDescuento
        End Get
        Set(ByVal value As Double)
            _porcentajeDescuento = value
        End Set
    End Property

    Private _valorEntrada As Double
    Public Property ValorEntrada() As Double
        Get
            Return _valorEntrada
        End Get
        Set(ByVal value As Double)
            _valorEntrada = value
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




    Private _clienteNombre As String
    Public Property ClienteNombre() As String
        Get
            Return _clienteNombre
        End Get
        Set(ByVal value As String)
            _clienteNombre = value
        End Set
    End Property

    Private _clienteCedula As String
    Public Property ClienteCedula() As String
        Get
            Return _clienteCedula
        End Get
        Set(ByVal value As String)
            _clienteCedula = value
        End Set
    End Property

    Private _clienteTelefono As String
    Public Property ClienteTelefono() As String
        Get
            Return _clienteTelefono
        End Get
        Set(ByVal value As String)
            _clienteTelefono = value
        End Set
    End Property

    Private _clienteDireccion As String
    Public Property ClienteDireccion() As String
        Get
            Return _clienteDireccion
        End Get
        Set(ByVal value As String)
            _clienteDireccion = value
        End Set
    End Property

    Private _garanteNombre As String
    Public Property GaranteNombre() As String
        Get
            Return _garanteNombre
        End Get
        Set(ByVal value As String)
            _garanteNombre = value
        End Set
    End Property

    Private _garanteCedula As String
    Public Property GaranteCedula() As String
        Get
            Return _garanteCedula
        End Get
        Set(ByVal value As String)
            _garanteCedula = value
        End Set
    End Property

    Private _garanteTelefono As String
    Public Property GaranteTelefono() As String
        Get
            Return _garanteTelefono
        End Get
        Set(ByVal value As String)
            _garanteTelefono = value
        End Set
    End Property

    Private _garanteDireccion As String
    Public Property GaranteDireccion() As String
        Get
            Return _garanteDireccion
        End Get
        Set(ByVal value As String)
            _garanteDireccion = value
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
