Imports ENTIDADES
Imports MySql.Data.MySqlClient

Public Class DLL_Abono
    Inherits DLL_Base

    Public Function ingresarBD(ByVal abono As ClsAbono, ByRef mensaje As String) As Boolean
        getConexion()
        Dim comando As New MySqlCommand
        Dim estado As Boolean = False
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "INS_Abono"

        comando.Parameters.AddWithValue("_idCuota", abono.IdCuota.IdCuota)
        comando.Parameters.AddWithValue("_idUsuarioCreacion", abono.IdUsuarioCreacion.IdUsuario)
        comando.Parameters.AddWithValue("_idUsuarioModificacion", abono.IdUsuarioModificacion.IdUsuario)
        comando.Parameters.AddWithValue("_fecha", abono.Fecha)
        comando.Parameters.AddWithValue("_valor", abono.Valor)
        comando.Parameters.AddWithValue("_comentarios", abono.Comentario)

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

    Public Function LlenarCartilla(ByVal numeroFactura As String, ByRef mensaje As String) As DataTable
        getConexion()
        Dim comando As New MySqlCommand
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "QRY_LlenarCartilla"
        comando.Parameters.AddWithValue("_numeroFactura", numeroFactura)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable

        comando.Connection = conn
        da.SelectCommand = comando

        Try
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                dt = Nothing
                mensaje = "No existe datos para la cartilla"
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

    Public Function ConsultarTipoVentaPorId(ByVal idTipoVenta As Integer, ByRef mensaje As String) As DataTable
        getConexion()
        Dim comando As New MySqlCommand
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "QRY_ConsultarTipoVentaPorId"
        comando.Parameters.AddWithValue("_idTipoVenta", idTipoVenta)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable

        comando.Connection = conn
        da.SelectCommand = comando

        Try
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                dt = Nothing
                mensaje = "No existe tipoventa con ese ID"
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

    Public Function ConsultarCuotaPorIdFactura(ByVal idFactura As Integer, ByRef mensaje As String) As DataTable
        getConexion()
        Dim comando As New MySqlCommand
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "QRY_ConsultarCuotaPorIdFactura"
        comando.Parameters.AddWithValue("_idFactura", idFactura)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable

        comando.Connection = conn
        da.SelectCommand = comando

        Try
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                dt = Nothing
                mensaje = "No existe tipoventa con ese ID"
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

    Public Function deshabilitarAbono(ByRef mensaje As String) As DataTable
        getConexion()
        Dim comando As New MySqlCommand
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "QRY_deshabilitarAbono"

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable

        comando.Connection = conn
        da.SelectCommand = comando

        Try
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                dt = Nothing
                mensaje = "No existe tipoventa con ese QRY_deshabilitarAbono"
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
