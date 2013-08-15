Imports ENTIDADES
Imports MySql.Data.MySqlClient

Public Class DLL_TipoVenta
    Inherits DLL_Base
    Public Function ingresarBD(ByVal tipoVenta As ClsTipoVenta, ByVal mensaje As String) As Boolean
        getConexion()
        Dim comando As New MySqlCommand
        Dim estado As Boolean = False
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "INS_TipoVenta"
        comando.Parameters.AddWithValue("_idUsuarioCreacion", tipoVenta.IdUsuarioCreacion)
        comando.Parameters.AddWithValue("_idUsuarioModificacion", tipoVenta.IdUsuarioModificacion)
        comando.Parameters.AddWithValue("_descripcion", tipoVenta.Descripcion)
        comando.Parameters.AddWithValue("_estado", tipoVenta.Estado)
        comando.Parameters.AddWithValue("_fechaCreacion", tipoVenta.FechaCreacion)
        comando.Parameters.AddWithValue("_fechaModificacion", tipoVenta.FechaModificacion)

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
