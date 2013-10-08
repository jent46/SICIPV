Imports ENTIDADES
Imports DLL_SICIPV
Public Class BLL_CuotaValor

    Shared Function ingresarBD(ByVal cuotaValor As ClsCuotaValor, ByRef mensaje As String) As Boolean
        Return New DLL_CuotaValor().ingresarBD(cuotaValor, mensaje)
    End Function

    Shared Function modificarBD(ByVal cuotaValor As ClsCuotaValor, ByVal mensaje As String) As Boolean
        Return New DLL_CuotaValor().modificarBD(cuotaValor, mensaje)
    End Function

    Shared Function ConsultarCuotaValor(ByRef mensaje As String) As DataTable
        Return New DLL_CuotaValor().ConsultarCuotaValor(mensaje)
    End Function

    Shared Function ConsultarCuotaValorPorId(ByVal idcuotaValor As String, ByRef mensaje As String) As DataTable
        Return New DLL_CuotaValor().ConsultarCuotaValorPorId(idcuotaValor, mensaje)
    End Function

    Shared Function ConsultarValorCuotaPorCuota(ByVal cuota As String, ByRef mensaje As String) As DataTable
        Return New DLL_CuotaValor().ConsultarValorCuotaPorCuota(cuota, mensaje)
    End Function

End Class
