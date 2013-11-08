Public Class ClsAbono

    Private _idAbono As Integer
    Public Property IdAbono() As Integer
        Get
            Return IdAbono
        End Get
        Set(ByVal value As Integer)
            _idAbono = value
        End Set
    End Property

    Private _idCuota As ClsCuota
    Public Property IdCuota() As ClsCuota
        Get
            Return _idCuota
        End Get
        Set(ByVal value As ClsCuota)
            _idCuota = value
        End Set
    End Property

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

    Private _valor As Double
    Public Property Valor() As Double
        Get
            Return _valor
        End Get
        Set(ByVal value As Double)
            _valor = value
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

End Class
