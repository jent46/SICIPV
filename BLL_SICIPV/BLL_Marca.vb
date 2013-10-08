Imports ENTIDADES
Imports DLL_SICIPV
Public Class BLL_Marca

    Shared Function ingresarBD(ByVal marca As ClsMarca, ByRef mensaje As String) As Boolean
        Return New DLL_Marca().ingresarBD(marca, mensaje)
    End Function

    Shared Function modificarBD(ByVal marca As ClsMarca, ByRef mensaje As String) As Boolean
        Return New DLL_Marca().modificarBD(marca, mensaje)
    End Function

    Shared Function ConsultarMarcas(ByRef mensaje As String) As DataTable
        Return New DLL_Marca().ConsultarMarcas(mensaje)
    End Function

    Shared Function FiltrarMarcas(ByVal marca As String, ByRef mensaje As String) As DataTable
        Return New DLL_Marca().FiltrarMarcas(marca, mensaje)
    End Function

    Shared Function ConsultarMarcaPorId(ByVal idMarca As String, ByRef mensaje As String) As DataTable
        Return New DLL_Marca().ConsultarMarcaPorId(idMarca, mensaje)
    End Function

End Class
