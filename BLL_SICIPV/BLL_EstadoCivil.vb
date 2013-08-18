Imports ENTIDADES
Imports DLL_SICIPV

Public Class BLL_EstadoCivil

    Shared Function ConsultarEstadoCivilTodos(ByRef mensaje As String) As DataTable
        Return New DLL_EstadoCivil().ConsultarEstadoCivilTodos(mensaje)
    End Function


End Class
