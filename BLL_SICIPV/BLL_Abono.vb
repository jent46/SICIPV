Imports ENTIDADES
Imports DLL_SICIPV
Public Class BLL_Abono

    Shared Function ingresarBD(ByVal abono As ClsAbono, ByRef mensaje As String) As Boolean
        Return New DLL_Abono().ingresarBD(abono, mensaje)
    End Function

    Shared Function LlenarCartilla(ByVal numeroFactura As String, ByRef mensaje As String) As DataTable
        Return New DLL_Abono().LlenarCartilla(numeroFactura, mensaje)
    End Function

    Shared Function ConsultarTipoVentaPorId(ByVal idTipoVenta As Integer, ByRef mensaje As String) As DataTable
        Return New DLL_Abono().ConsultarTipoVentaPorId(idTipoVenta, mensaje)
    End Function

    Shared Function ConsultarCuotaPorIdFactura(ByVal idFactura As Integer, ByRef mensaje As String) As DataTable
        Return New DLL_Abono().ConsultarCuotaPorIdFactura(idFactura, mensaje)
    End Function

    Shared Function deshabilitarAbono(ByVal idCuota As Integer, ByRef mensaje As String) As DataTable
        Return New DLL_Abono().deshabilitarAbono(idCuota, mensaje)
    End Function
End Class
