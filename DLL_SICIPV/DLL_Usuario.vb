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


    Public Function ingresarBD(ByVal pusuario As ClsUsuario, ByVal mensaje As String) As Boolean
        getConexion()
        Dim comando As New MySqlCommand
        Dim estado As Boolean = False
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "INS_Persona"

        comando.Parameters.AddWithValue("pusuario", pusuario.Nombre)
       

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

    Public Function modificarBD(ByVal pusuario As ClsUsuario, ByVal mensaje As String) As Boolean

        Return True
    End Function

    Public Function ConsultarUsuarioPorUsuario(ByVal usuario As String, ByRef mensaje As String) As DataTable
        getConexion()
        Dim comando As New MySqlCommand
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "QRY_ConsultarUsuarioPorUsuario"
        comando.Parameters.AddWithValue("pnombre", usuario)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable

        comando.Connection = conn
        da.SelectCommand = comando

        Try
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                dt = Nothing
                mensaje = "No existe Usuario con ese usuario"
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

    Public Function ConsultarUsuarioPorNombre(ByVal nombre As String, ByRef mensaje As String) As DataTable
        getConexion()
        Dim comando As New MySqlCommand
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "QRY_ConsultarUsuarioPorNombre"
        comando.Parameters.AddWithValue("pnombre", nombre)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable

        comando.Connection = conn
        da.SelectCommand = comando

        Try
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                dt = Nothing
                mensaje = "No existe Usuario con ese nombre"
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
