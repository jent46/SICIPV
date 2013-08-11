Imports ENTIDADES
Imports MySql.Data.MySqlClient

Public Class DLL_Producto
    Inherits DLL_Base

    Public Function ingresarBD(ByVal pproducto As ClsProducto, ByVal mensaje As String) As Boolean
        getConexion()
        Dim comando As New MySqlCommand
        Dim estado As Boolean = False
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "INS_Producto"

        comando.Parameters.AddWithValue("pnombre", pproducto.Descripcion)


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

    Public Function modificarBD(ByVal pproducto As ClsProducto, ByVal mensaje As String) As Boolean

        Return True
    End Function

    Public Function ConsultarProductosPorDescripcion(ByVal descripcion As String, ByRef mensaje As String) As DataTable
        getConexion()
        Dim comando As New MySqlCommand
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "QRY_ConsultarProductosPorDescripcion"
        comando.Parameters.AddWithValue("pdescripcion", descripcion)

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
