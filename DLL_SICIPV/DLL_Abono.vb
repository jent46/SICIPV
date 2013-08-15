Imports ENTIDADES
Imports MySql.Data.MySqlClient

Public Class DLL_Abono
    Inherits DLL_Base

    Public Function ingresarBD(ByVal abono As ClsAbono, ByVal mensaje As String) As Boolean
        getConexion()
        Dim comando As New MySqlCommand
        Dim estado As Boolean = False
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "INS_Abono"
       
        comando.Parameters.AddWithValue("_idCuota", abono.IdCuota)
        comando.Parameters.AddWithValue("_idUsuarioCreacion", abono.IdUsuarioCreacion)
        comando.Parameters.AddWithValue("_idUsuarioModificacion", abono.IdUsuarioModificacion)
        comando.Parameters.AddWithValue("_fecha", abono.Fecha)
        comando.Parameters.AddWithValue("_valor", abono.Valor)

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
