Imports ENTIDADES
Imports MySql.Data.MySqlClient
Public Class DLL_CuotaValor
    Inherits DLL_Base

    Public Function ingresarBD(ByVal cuotaValor As ClsCuotaValor, ByRef mensaje As String) As Boolean
        getConexion()

        Dim comando As New MySqlCommand
        Dim estado As Boolean = False
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "INS_CuotaValor"

        comando.Parameters.AddWithValue("_cuota", cuotaValor.Cuota)
        comando.Parameters.AddWithValue("_interesCuota", cuotaValor.InteresCuota)
        comando.Parameters.AddWithValue("_fechaCreacion", cuotaValor.FechaCreacion)
        comando.Parameters.AddWithValue("_fechaModificacion", cuotaValor.FechaModificacion)

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

    Public Function modificarBD(ByVal cuotaValor As ClsCuotaValor, ByRef mensaje As String) As Boolean
        getConexion()
        Dim comando As New MySqlCommand
        Dim estado As Boolean = False
        comando.CommandText = "UPD_CuotaValor"
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.AddWithValue("_idcuotaValor", cuotaValor.IdCuotaValor)
        comando.Parameters.AddWithValue("_cuota", cuotaValor.Cuota)
        comando.Parameters.AddWithValue("_interesCuota", cuotaValor.InteresCuota)
        comando.Parameters.AddWithValue("_fechaCreacion", cuotaValor.FechaCreacion)
        comando.Parameters.AddWithValue("_fechaModificacion", cuotaValor.FechaModificacion)

        Try
            comando.Connection = conn
            conn.Open()
            comando.ExecuteNonQuery()
            estado = True
            mensaje = "Modificaco correctamente"
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

    Public Function ConsultarCuotaValor(ByRef mensaje As String) As DataTable
        getConexion()
        Dim comando As New MySqlCommand
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "QRY_ConsultarCuotaValor"
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable

        comando.Connection = conn
        da.SelectCommand = comando

        Try
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                dt = Nothing
                mensaje = "No existen cuotas"
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

    Public Function ConsultarCuotaValorPorId(ByVal idcuotaValor As Integer, ByRef mensaje As String) As DataTable
        getConexion()
        Dim comando As New MySqlCommand
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "QRY_ConsultarCuotaValorPorId"
        comando.Parameters.AddWithValue("_idcuotaValor", idcuotaValor)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable

        comando.Connection = conn
        da.SelectCommand = comando

        Try
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                dt = Nothing
                mensaje = "No existe CuotaValor con ese ID"
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

    Public Function ConsultarValorCuotaPorCuota(ByVal cuota As String, ByRef mensaje As String) As DataTable
        getConexion()
        Dim comando As New MySqlCommand
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "QRY_ConsultarValorCuotaPorCuota"
        comando.Parameters.AddWithValue("_cuota", cuota)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable

        comando.Connection = conn
        da.SelectCommand = comando

        Try
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                dt = Nothing
                mensaje = "No existe Cuota con ese numero"
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
