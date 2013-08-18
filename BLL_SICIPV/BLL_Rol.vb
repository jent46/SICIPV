Imports ENTIDADES
Imports DLL_SICIPV

Public Class BLL_Rol

    Shared Function ConsultarRolTodos(ByRef mensaje As String) As DataTable
        Return New DLL_Rol().ConsultarRolTodos(mensaje)
    End Function


End Class
