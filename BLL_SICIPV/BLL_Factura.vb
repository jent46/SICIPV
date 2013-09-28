Imports ENTIDADES
Imports DLL_SICIPV

Public Class BLL_Factura

    Shared Function ingresarBD(ByVal pfactura As ClsFactura, ByRef mensaje As String) As Boolean
        Return New DLL_Factura().ingresarBD(pfactura, mensaje)
    End Function

    Shared Function modificarBD(ByVal pfactura As ClsFactura, ByRef mensaje As String) As Boolean
        Return New DLL_Factura().modificarBD(pfactura, mensaje)
    End Function

    Shared Function ConsultarFacturasPorCedula(ByVal pcedula As Integer, ByRef mensaje As String) As DataTable
        Return New DLL_Factura().ConsultarFacturasPorCedula(pcedula, mensaje)
    End Function

    Shared Function ConsultarFacturasPorNombreCliente(ByVal nombre As String, ByRef mensaje As String) As DataTable
        Return New DLL_Factura().ConsultarFacturasPorNombreCliente(nombre, mensaje)
    End Function

    Shared Function ConsultarFacturasPorNumeroContrato(ByVal contrato As Integer, ByRef mensaje As String) As DataTable
        Return New DLL_Factura().ConsultarFacturasPorNumeroContrato(contrato, mensaje)
    End Function

    Shared Function ConsultarFacturasPorNumeroFactura(ByVal factura As Integer, ByRef mensaje As String) As DataTable
        Return New DLL_Factura().ConsultarFacturasPorNombreCliente(factura, mensaje)
    End Function

End Class
