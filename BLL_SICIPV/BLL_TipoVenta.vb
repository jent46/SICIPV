Imports ENTIDADES
Imports DLL_SICIPV

Public Class BLL_TipoVenta

    Shared Function ConsultarTipoVentaTodos(ByRef mensaje As String) As DataTable
        Return New DLL_TipoVenta().ConsultarTipoVentaTodos(mensaje)
    End Function


End Class
