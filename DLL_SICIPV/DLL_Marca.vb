Imports ENTIDADES
Imports MySql.Data.MySqlClient

Public Class DLL_Marca
    Inherits DLL_Base
    Public Function ingresarBD(ByVal marca As ClsMarca, ByRef mensaje As String) As Boolean
        getConexion()

        Dim comando As New MySqlCommand
        Dim estado As Boolean = False
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "INS_Marca"

        comando.Parameters.AddWithValue("_nombreMarca", marca.NombreMarca)


        Try
            mensaje = ""
            comando.Connection = conn
            conn.Open()
            comando.ExecuteNonQuery()
            estado = True
            mensaje = "Ingresado Exitosamente!"
        Catch ex As Exception
            estado = False
            mensaje = "Ocurrió un error no se pudo ingresar!"
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try

        Return estado
    End Function


    Public Function modificarBD(ByVal marca As ClsMarca, ByRef mensaje As String) As Boolean
        getConexion()
        Dim comando As New MySqlCommand
        Dim estado As Boolean = False
        comando.CommandText = "UPD_Marca"
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.AddWithValue("_idMarca", marca.IdMarca)
        comando.Parameters.AddWithValue("_nombreMarca", marca.NombreMarca)

        Try
            comando.Connection = conn
            conn.Open()
            comando.ExecuteNonQuery()
            mensaje = "Marca fue Modificada Exitosamente!"
            estado = True
        Catch ex As Exception
            estado = False
            mensaje = ex.Message
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try

        Return estado
    End Function


    Public Function ConsultarMarcas(ByRef mensaje As String) As DataTable
        getConexion()
        Dim comando As New MySqlCommand
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "QRY_ConsultarMarcas"

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable

        comando.Connection = conn
        da.SelectCommand = comando

        Try
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                dt = Nothing
                mensaje = "Error al cargar marcas"
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

    Public Function FiltrarMarcas(ByVal marca As String, ByRef mensaje As String) As DataTable
        getConexion()
        Dim comando As New MySqlCommand
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "QRYFiltrarMarcas"
        comando.Parameters.AddWithValue("_nombreMarca", marca)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable

        comando.Connection = conn
        da.SelectCommand = comando

        Try
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                dt = Nothing
                mensaje = "No existen Marcas Registrada"
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

    Public Function ConsultarMarcaPorId(ByVal idMarca As String, ByRef mensaje As String) As DataTable
        getConexion()
        Dim comando As New MySqlCommand
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "QRY_ConsultarMarcaPorId"
        comando.Parameters.AddWithValue("_idMarca", idMarca)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable

        comando.Connection = conn
        da.SelectCommand = comando

        Try
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                dt = Nothing
                mensaje = "No existe Marca con ese ID"
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