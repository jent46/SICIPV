Imports ENTIDADES
Imports MySql.Data.MySqlClient


Public Class DLL_Usuario
    Inherits DLL_Base

    Public Function ingresarBD(ByVal usuario As ClsUsuario, ByVal mensaje As String) As Boolean
        getConexion()
        Dim comando As New MySqlCommand
        Dim estado As Boolean = False
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "INS_Usuario"

        comando.Parameters.AddWithValue("_nombre", usuario.Nombre)
        comando.Parameters.AddWithValue("_apellido", usuario.Apellido)
        comando.Parameters.AddWithValue("_usuario", usuario.Usuario)
        comando.Parameters.AddWithValue("_contrasena", usuario.Contrasena)
        comando.Parameters.AddWithValue("_fechaCreacion", usuario.FechaCreacion)
        comando.Parameters.AddWithValue("_fechaModificacion", usuario.FechaModificacion)
        comando.Parameters.AddWithValue("_estado", usuario.Estado)

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

    Public Function login(ByVal pusuario As String, ByVal pclave As String, ByRef mensaje As String) As ClsUsuario
        getConexion()
        Dim comando As New MySqlCommand
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "QRY_login"

        comando.Parameters.AddWithValue("_usuario", pusuario)
        comando.Parameters.AddWithValue("_clave", pclave)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Dim usuario As ClsUsuario = New ClsUsuario()

        Try
            comando.Connection = conn
            da.SelectCommand = comando
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                usuario = Nothing
                mensaje = "Usuario o Clave Incorrecta!"
            Else
                For Each item As DataRow In dt.Rows
                    usuario.IdUsuario = item("idUsuario")
                    usuario.Nombre = item("nombre")
                    usuario.Apellido = item("apellido")
                Next

            End If

        Catch ex As Exception
            usuario = Nothing
            mensaje = ex.Message
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try

        Return usuario


    End Function

End Class
