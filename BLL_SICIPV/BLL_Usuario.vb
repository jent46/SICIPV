Imports ENTIDADES
Imports DLL_SICIPV

Public Class BLL_Usuario

    Shared Function login(ByVal usuario As String, ByVal clave As String, ByRef mensaje As String) As ClsUsuario
        Return New DLL_Usuario().login(usuario, clave, mensaje)
    End Function

    Shared Function ingresarBD(ByVal pusuario As ClsUsuario, ByVal mensaje As String) As Boolean
        Return New DLL_Usuario().ingresarBD(pusuario, mensaje)
    End Function

    Shared Function modificarBD(ByVal pusuario As ClsUsuario, ByVal mensaje As String) As Boolean
        Return New DLL_Usuario().modificarBD(pusuario, mensaje)
    End Function

    Shared Function ConsultarUsuarioPorUsuario(ByVal usuario As String, ByRef mensaje As String) As DataTable
        Dim ds As New DataTable
        Return ds
    End Function

    Shared Function ConsultarUsuarioPorNombre(ByVal nombre As String, ByRef mensaje As String) As DataTable
        Dim ds As New DataTable
        Return ds
    End Function

End Class
