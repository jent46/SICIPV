Imports ENTIDADES
Imports DLL_SICIPV

Public Class BLL_Usuario

    Shared Function login(ByVal usuario As String, ByVal clave As String, ByRef mensaje As String) As ClsUsuario
        Return New DLL_Usuario().login(usuario, clave, mensaje)
    End Function

End Class
