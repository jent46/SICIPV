Imports ENTIDADES
Imports DLL_SICIPV

Public Class BLL_Persona

    Shared Function ingresarBD(ByVal ppersona As ClsPersona, ByRef mensaje As String) As Boolean
        Return New DLL_Persona().ingresarBD(ppersona, mensaje)
    End Function

    Shared Function modificarBD(ByVal ppersona As ClsPersona, ByRef mensaje As String) As Boolean
        Return New DLL_Persona().modificarBD(ppersona, mensaje)
    End Function

    Shared Function ConsultarPersonasPorNombre(ByVal nombre As String, ByRef mensaje As String) As DataTable
        Return New DLL_Persona().ConsultarPersonasPorNombre(nombre, mensaje)
    End Function

    Shared Function ConsultarPersonasPorCedula(ByVal cedula As String, ByRef mensaje As String) As DataTable
        Return New DLL_Persona().ConsultarPersonasPorCedula(cedula, mensaje)
    End Function

    Shared Function ConsultarPersonasPorId(ByVal idPersona As Integer, ByRef mensaje As String) As DataTable
        Return New DLL_Persona().ConsultarPersonasPorId(idPersona, mensaje)
    End Function

End Class


