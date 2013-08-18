Imports ENTIDADES
Imports MySql.Data.MySqlClient

Public Class DLL_EstadoCivil
    Inherits DLL_Base

    Public Function ConsultarEstadoCivilTodos(ByRef mensaje As String) As DataTable
        getConexion()
        Dim comando As New MySqlCommand
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "QRY_ConsultarEstadoCivilTodos"

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable

        comando.Connection = conn
        da.SelectCommand = comando

        Try
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                dt = Nothing
                mensaje = "No existen Estados Civil Ingresados"
            End If
        Catch ex As Exception
            dt = Nothing
            mensaje = ex.Message
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try

        Return dt
    End Function

End Class
