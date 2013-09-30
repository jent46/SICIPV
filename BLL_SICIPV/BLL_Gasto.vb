Imports ENTIDADES
Imports DLL_SICIPV
Public Class BLL_Gasto
    Shared Function ingresarBD(ByVal gasto As ClsGasto, ByRef mensaje As String) As Boolean
        Return New DLL_Gasto().ingresarBD(gasto, mensaje)
    End Function

    Shared Function ConsultarGastoPorFactura(ByVal factura As String, ByRef mensaje As String) As DataTable
        Return New DLL_Gasto().ConsultarGastoPorFactura(factura, mensaje)
    End Function

    Shared Function ConsultarGastoPorId(ByVal idGasto As String, ByRef mensaje As String) As DataTable
        Return New DLL_Gasto().ConsultarGastoPorId(idGasto, mensaje)
    End Function
End Class
