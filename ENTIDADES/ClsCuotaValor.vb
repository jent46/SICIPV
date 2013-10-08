Public Class ClsCuotaValor
    Private _idCuotaValor As Integer
    Public Property IdCuotaValor() As Integer
        Get
            Return _idCuotaValor
        End Get
        Set(ByVal value As Integer)
            _idCuotaValor = value
        End Set
    End Property

    Private _cuota As Integer
    Public Property Cuota() As Integer
        Get
            Return _cuota
        End Get
        Set(ByVal value As Integer)
            _cuota = value
        End Set
    End Property

    Private _interesCuota As Double
    Public Property InteresCuota() As Double
        Get
            Return _interesCuota
        End Get
        Set(ByVal value As Double)
            _interesCuota = value
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
