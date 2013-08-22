Imports ENTIDADES
Imports MySql.Data.MySqlClient

Public Class DLL_Cuota
    Inherits DLL_Base

    Public Function ingresarBD(ByVal cuota As ClsCuota, ByVal mensaje As String) As Boolean
        getConexion()
        Dim comando As New MySqlCommand
        Dim estado As Boolean = False
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "INS_Cuota"

        comando.Parameters.AddWithValue("_idFactura", cuota.IdFactura)
        comando.Parameters.AddWithValue("_idUsuarioCreacion", cuota.IdUsuarioCreacion)
        comando.Parameters.AddWithValue("_idUsuarioModificacion", cuota.IdUsuarioModificacion)
        comando.Parameters.AddWithValue("_fecha", cuota.Fecha)
        comando.Parameters.AddWithValue("_saldo", cuota.Saldo)
        comando.Parameters.AddWithValue("_valorCuota", cuota.ValorCuota)
        comando.Parameters.AddWithValue("_porcentajeInteres", cuota.PorcentajeInteres)
        comando.Parameters.AddWithValue("_interesFactura", cuota.InteresFactura)
        comando.Parameters.AddWithValue("_interesMora", cuota.InteresMora)
        comando.Parameters.AddWithValue("_valorTotal", cuota.ValorTotal)
        comando.Parameters.AddWithValue("_comentario", cuota.Comentario)
        comando.Parameters.AddWithValue("_estado", cuota.Estado)
        comando.Parameters.AddWithValue("_fechaCreacion", cuota.FechaCreacion)
        comando.Parameters.AddWithValue("_fechaModificacion", cuota.FechaModificacion)

        Try
            comando.Connection = conn
            conn.Open()
            comando.ExecuteNonQuery()
            estado = True
        Catch ex As Exception
            estado = False
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try

        Return estado
    End Function
End Class
