Imports ENTIDADES
Imports MySql.Data.MySqlClient

Public Class DLL_IngresoProducto
    Inherits DLL_Base

    Public Function ingresarBD(ByVal ingresoProducto As ClsIngresoProducto, ByVal mensaje As String) As Boolean
        getConexion()
        Dim comando As New MySqlCommand
        Dim estado As Boolean = False
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "INS_IngresoProducto"
       
        comando.Parameters.AddWithValue("_idProducto", ingresoProducto.IdIngresoProducto)
        comando.Parameters.AddWithValue("_idUsuarioCreacion", ingresoProducto.IdUsuarioCreacion)
        comando.Parameters.AddWithValue("_idUsuarioModificacion", ingresoProducto.IdUsuarioModificacion)
        comando.Parameters.AddWithValue("_cantidad", ingresoProducto.Cantidad)
        comando.Parameters.AddWithValue("_fecha", ingresoProducto.Fecha)
        comando.Parameters.AddWithValue("_estado", ingresoProducto.Estado)
        comando.Parameters.AddWithValue("_fechaCreacion", ingresoProducto.FechaCreacion)
        comando.Parameters.AddWithValue("_fechaModificacion", ingresoProducto.FechaModificacion)

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
