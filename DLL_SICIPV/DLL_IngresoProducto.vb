Imports ENTIDADES
Imports MySql.Data.MySqlClient

Public Class DLL_IngresoProducto
    Inherits DLL_Base

    Public Function ingresarBD(ByVal ingresoProducto As ClsIngresoProducto, ByRef mensaje As String) As Boolean
        getConexion()
        Dim comando As New MySqlCommand
        Dim estado As Boolean = False
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "INS_IngresoProducto"

        comando.Parameters.AddWithValue("_idProducto", ingresoProducto.IdProducto.IdProducto)
        comando.Parameters.AddWithValue("_idUsuarioCreacion", ingresoProducto.IdUsuarioCreacion.IdUsuario)
        comando.Parameters.AddWithValue("_idUsuarioModificacion", ingresoProducto.IdUsuarioModificacion.IdUsuario)
        comando.Parameters.AddWithValue("_cantidad", ingresoProducto.Cantidad)
        comando.Parameters.AddWithValue("_fecha", ingresoProducto.Fecha)
        comando.Parameters.AddWithValue("_estado", ingresoProducto.Estado)
        comando.Parameters.AddWithValue("_proveedor", ingresoProducto.Proveedor)
        comando.Parameters.AddWithValue("_comprador", ingresoProducto.Comprador)
        comando.Parameters.AddWithValue("_fechaCreacion", ingresoProducto.FechaCreacion)
        comando.Parameters.AddWithValue("_fechaModificacion", ingresoProducto.FechaModificacion)
        comando.Parameters.AddWithValue("_stock", ingresoProducto.Cantidad) 'Actualiza el stock de la tabla Producto

        Try
            comando.Connection = conn
            conn.Open()
            comando.ExecuteNonQuery()
            estado = True
            mensaje = "Producto ingresado exitosamente"
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

    Public Function modificarBD(ByVal ingresoProducto As ClsIngresoProducto, ByRef mensaje As String) As Boolean
        getConexion()
        Dim comando As New MySqlCommand
        Dim estado As Boolean = False
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "UPD_IngresoProducto"

        comando.Parameters.AddWithValue("idIngresoProducto", ingresoProducto.IdIngresoProducto)
        comando.Parameters.AddWithValue("_idProducto", ingresoProducto.IdProducto)
        comando.Parameters.AddWithValue("_idUsuarioModificacion", ingresoProducto.IdUsuarioModificacion)
        comando.Parameters.AddWithValue("_cantidad", ingresoProducto.Cantidad)
        comando.Parameters.AddWithValue("_fecha", ingresoProducto.Fecha)
        comando.Parameters.AddWithValue("_proveedor", ingresoProducto.Proveedor)
        comando.Parameters.AddWithValue("_comprador", ingresoProducto.Comprador)
        comando.Parameters.AddWithValue("_estado", ingresoProducto.Estado)
        comando.Parameters.AddWithValue("_fechaModificacion", ingresoProducto.FechaModificacion)

        Try
            comando.Connection = conn
            conn.Open()
            comando.ExecuteNonQuery()
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

    Public Function ConsultarIngreosProductoPorId(ByVal idIngresoProducto As String, ByRef mensaje As String) As DataTable
        getConexion()
        Dim comando As New MySqlCommand
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "QRY_ConsultarIngreosProductoPorId"
        comando.Parameters.AddWithValue("_idIngresoProducto", idIngresoProducto)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable

        comando.Connection = conn
        da.SelectCommand = comando

        Try
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                dt = Nothing
                mensaje = "No existe Producto con ese ID"
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

    Public Function ListaProducto(ByRef mensaje As String) As DataTable
        getConexion()
        Dim comando As New MySqlCommand
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "QRY_ListaProducto"


        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable

        comando.Connection = conn
        da.SelectCommand = comando

        Try
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                dt = Nothing
                mensaje = "No existe lista de prosuctos"
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

    Public Function ConsultarIngresoProductoPorDescripcion(ByVal descripcion As String, ByRef mensaje As String) As DataTable
        getConexion()
        Dim comando As New MySqlCommand
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "QRY_ConsultarIngresoProductosPorDescripcion"
        comando.Parameters.AddWithValue("_descripcion", descripcion)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable

        comando.Connection = conn
        da.SelectCommand = comando

        Try
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                dt = Nothing
                mensaje = "No existe Persona con ese nombre"
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
