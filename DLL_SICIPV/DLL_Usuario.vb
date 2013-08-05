Imports ENTIDADES
Imports MySql.Data.MySqlClient


Public Class DLL_Usuario
    Inherits DLL_Base


    Public Function login(ByVal pusuario As String, ByVal pclave As String, ByRef mensaje As String) As ClsUsuario
        getConexion()
        Dim comando As New MySqlCommand
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "QRY_login"

        comando.Parameters.AddWithValue("pusuario", pusuario)
        comando.Parameters.AddWithValue("pcontrasena", pclave)

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
