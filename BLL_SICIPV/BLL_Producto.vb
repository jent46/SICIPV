Imports ENTIDADES
Imports DLL_SICIPV

Public Class BLL_Producto

    Shared Function ingresarBD(ByVal pproducto As ClsProducto, ByVal mensaje As String) As Boolean
        Return New DLL_Producto().ingresarBD(pproducto, mensaje)
    End Function

    Shared Function modificarBD(ByVal pproducto As ClsProducto, ByVal mensaje As String) As Boolean
        Return New DLL_Producto().modificarBD(pproducto, mensaje)
    End Function

    Shared Function ConsultarProductosPorDescripcion(ByVal descripcion As String, ByRef mensaje As String) As DataTable
        Return New DLL_Producto().ConsultarProductosPorDescripcion(descripcion, mensaje)
    End Function

End Class
