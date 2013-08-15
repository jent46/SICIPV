Imports ENTIDADES
Imports MySql.Data.MySqlClient

Public Class Cls_ItemFactura
    Inherits DLL_Base

    Public Function ingresarBD(ByVal item As ClsItemFactura, ByVal mensaje As String) As Boolean
        getConexion()
        Dim comando As New MySqlCommand
        Dim estado As Boolean = False
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "INS_ItemFactura"
        
        comando.Parameters.AddWithValue("_idFactura", item.IdFactura)
        comando.Parameters.AddWithValue("_idProducto", item.IdProducto)
        comando.Parameters.AddWithValue("_idUsuarioCreacion", item.IdUsuarioCreacion)
        comando.Parameters.AddWithValue("_idUsuarioModificacion", item.IdUsuarioModificacion)
        comando.Parameters.AddWithValue("_precioUnitario", item.PrecioUnitario)
        comando.Parameters.AddWithValue("_cantidad", item.Cantidad)
        comando.Parameters.AddWithValue("_precioTotal", item.PrecioTotal)
        comando.Parameters.AddWithValue("_descripcionProducto", item.DescripcionProducto)
        comando.Parameters.AddWithValue("_costoProducto", item.CostoProducto)
        comando.Parameters.AddWithValue("_estado", item.Estado)
        comando.Parameters.AddWithValue("_fechaCreacion", item.FechaCreacion)
        comando.Parameters.AddWithValue("_fechaModificacion", item.FechaModificacion)

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
