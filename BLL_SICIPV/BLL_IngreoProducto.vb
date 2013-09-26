Imports ENTIDADES
Imports DLL_SICIPV

Public Class BLL_IngreoProducto
    'Para insertar un nuevo objeto
    Shared Function ingresarBD(ByVal ingresoProducto As ClsIngresoProducto, ByRef mensaje As String) As Boolean
        Return New DLL_IngresoProducto().ingresarBD(ingresoProducto, mensaje)
    End Function
    'Para modificacion
    Shared Function ConsultarIngreosProductoPorId(ByVal idIngresoProducto As String, ByRef mensaje As String) As DataTable
        Return New DLL_IngresoProducto().ConsultarIngreosProductoPorId(idIngresoProducto, mensaje)
    End Function
    'Para llenar el combo de productos
    Shared Function ListaProducto(ByRef mensaje As String) As DataTable
        Return New DLL_IngresoProducto().ListaProducto(mensaje)
    End Function
    'Para realizar la busqueda
    Shared Function ConsultarIngresoProductoPorDescripcion(ByVal idIngresoProducto As String, ByRef mensaje As String) As DataTable
        Return New DLL_IngresoProducto().ConsultarIngresoProductoPorDescripcion(idIngresoProducto, mensaje)
    End Function
End Class
