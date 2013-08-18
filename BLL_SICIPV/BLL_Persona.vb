Imports ENTIDADES
Imports DLL_SICIPV

Public Class BLL_Persona

    Shared Function ingresarBD(ByVal ppersona As ClsPersona, ByVal mensaje As String) As Boolean
        Return New DLL_Persona().ingresarBD(ppersona, mensaje)
    End Function

    Shared Function modificarBD(ByVal ppersona As ClsPersona, ByVal mensaje As String) As Boolean
        Return New DLL_Persona().modificarBD(ppersona, mensaje)
    End Function

    Shared Function ConsultarPersonasPorNombre(ByVal nombre As String, ByRef mensaje As String) As DataTable
        Dim ds As New DataTable
        Return ds
    End Function

    Shared Function ConsultarPersonasPorCedula(ByVal cedula As Integer, ByRef mensaje As String) As DataTable
        Dim ds As New DataTable
        Return ds
    End Function
End Class


