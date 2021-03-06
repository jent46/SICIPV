﻿Imports ENTIDADES
Imports DLL_SICIPV

Public Class BLL_Usuario

    Shared Function login(ByVal usuario As String, ByVal clave As String, ByRef mensaje As String) As ClsUsuario
        Return New DLL_Usuario().login(usuario, clave, mensaje)
    End Function

    Shared Function ingresarBD(ByVal pusuario As ClsUsuario, ByRef mensaje As String) As Boolean
        Return New DLL_Usuario().ingresarBD(pusuario, mensaje)
    End Function

    Shared Function modificarBD(ByVal pusuario As ClsUsuario, ByRef mensaje As String) As Boolean
        Return New DLL_Usuario().modificarBD(pusuario, mensaje)
    End Function

    Shared Function ConsultarUsuarioPorUsuario(ByVal usuario As String, ByRef mensaje As String) As DataTable
        Return New DLL_Usuario().ConsultarUsuarioPorUsuario(usuario, mensaje)
    End Function

    Shared Function ConsultarUsuarioPorNombre(ByVal nombre As String, ByRef mensaje As String) As DataTable
        Return New DLL_Usuario().ConsultarUsuarioPorNombre(nombre, mensaje)
    End Function

    Shared Function ConsultarUsuarioPorId(ByVal idUsuario As String, ByRef mensaje As String) As DataTable
        Return New DLL_Usuario().ConsultarUsuarioPorId(idUsuario, mensaje)
    End Function

End Class
