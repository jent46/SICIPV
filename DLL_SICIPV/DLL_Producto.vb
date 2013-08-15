Imports ENTIDADES
Imports MySql.Data.MySqlClient

Public Class DLL_Producto
    Inherits DLL_Base

    Public Function ingresarBD(ByVal producto As ClsProducto, ByVal mensaje As String) As Boolean
        getConexion()
        Dim comando As New MySqlCommand
        Dim estado As Boolean = False
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "INS_Producto"

        comando.Parameters.AddWithValue("_idUsuarioCreacion", producto.IdUsuarioCreacion)
        comando.Parameters.AddWithValue("_idUsuarioModificacion", producto.IdUsuarioModificacion)
        comando.Parameters.AddWithValue("_descripcion", producto.Descripcion)
        comando.Parameters.AddWithValue("_valor", producto.Valor)
        comando.Parameters.AddWithValue("_pvp", producto.Pvp)
        comando.Parameters.AddWithValue("_stock", producto.Stock)
        comando.Parameters.AddWithValue("_estado", producto.Estado)
        comando.Parameters.AddWithValue("_fechaCreacion", producto.FechaCreacion)
        comando.Parameters.AddWithValue("_fechaModificacion", producto.FechaModificacion)

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
