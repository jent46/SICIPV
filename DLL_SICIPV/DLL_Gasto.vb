Imports ENTIDADES
Imports MySql.Data.MySqlClient

Public Class DLL_Gasto
    Inherits DLL_Base
    'Nueve
    Public Function ingresarBD(ByVal gasto As ClsGasto, ByRef mensaje As String) As Boolean
        getConexion()

        Dim comando As New MySqlCommand
        Dim estado As Boolean = False
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "INS_Gasto"

        comando.Parameters.AddWithValue("_idUsuarioCreacion", gasto.IdUsuarioCreacion.IdUsuario)
        comando.Parameters.AddWithValue("_idUsuarioModificacion", gasto.IdUsuarioModificacion.IdUsuario)
        comando.Parameters.AddWithValue("_fecha", gasto.Fecha)
        comando.Parameters.AddWithValue("_observacion", gasto.Observacion)
        comando.Parameters.AddWithValue("_beneficiario", gasto.Beneficiario)
        comando.Parameters.AddWithValue("_detalle", gasto.Detelle)
        comando.Parameters.AddWithValue("_numFactura", gasto.NumFactura)
        comando.Parameters.AddWithValue("_numDocumento", gasto.NumDocumento)
        comando.Parameters.AddWithValue("_numRetencion", gasto.NumRetencion)
        comando.Parameters.AddWithValue("_valor", gasto.Valor)


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
    'Modificacion
    Public Function modificarBD(ByVal persona As ClsPersona, ByRef mensaje As String) As Boolean
        getConexion()
        Dim comando As New MySqlCommand
        Dim estado As Boolean = False
        comando.CommandText = "UPD_Persona"
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.AddWithValue("_idPersona", persona.IdPersona)
        comando.Parameters.AddWithValue("_idEstadoCivil", persona.IdEstadoCivil.IdEstadoCivil)
        comando.Parameters.AddWithValue("_idUsuarioModificacion", persona.IdUsuarioModificacion.IdUsuario)
        comando.Parameters.AddWithValue("_nombre", persona.Nombre)
        comando.Parameters.AddWithValue("_apellido", persona.Apellido)
        comando.Parameters.AddWithValue("_cedula", persona.Cedula)
        comando.Parameters.AddWithValue("_telefono", persona.Telefono)
        comando.Parameters.AddWithValue("_direccion", persona.Direccion)
        comando.Parameters.AddWithValue("_estado", persona.Estado)
        comando.Parameters.AddWithValue("_fechaNacimiento", persona.FechaNacimiento)
        comando.Parameters.AddWithValue("_fechaModificacion", persona.FechaModificacion)

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
    'Consultas
    Public Function ConsultarGastoPorFactura(ByVal factura As String, ByRef mensaje As String) As DataTable
        getConexion()
        Dim comando As New MySqlCommand
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "QRY_ConsultarGastoPorFactura"
        comando.Parameters.AddWithValue("_numFactura", factura)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable

        comando.Connection = conn
        da.SelectCommand = comando

        Try
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                dt = Nothing
                mensaje = "No existe Factura con ese numero"
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

    Public Function ConsultarGastoPorId(ByVal idGasto As String, ByRef mensaje As String) As DataTable
        getConexion()
        Dim comando As New MySqlCommand
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "QRY_ConsultarGastoPorId"
        comando.Parameters.AddWithValue("_idGasto", idGasto)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable

        comando.Connection = conn
        da.SelectCommand = comando

        Try
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                dt = Nothing
                mensaje = "No existe Gasto con ese ID"
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
