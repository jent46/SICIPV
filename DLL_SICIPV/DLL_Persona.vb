﻿Imports ENTIDADES
Imports MySql.Data.MySqlClient

Public Class DLL_Persona
    Inherits DLL_Base


    Public Function ingresarBD(ByVal persona As ClsPersona, ByVal mensaje As String) As Boolean
        getConexion()
        Dim comando As New MySqlCommand
        Dim estado As Boolean = False
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "INS_Persona"

        comando.Parameters.AddWithValue("_idEstadoCivil", persona.IdEstadoCivil)
        comando.Parameters.AddWithValue("_idUsuarioCreacion", persona.IdUsuarioCreacion)
        comando.Parameters.AddWithValue("_idUsuarioModificacion", persona.IdUsuarioModificacion)
        comando.Parameters.AddWithValue("_nombre", persona.Nombre)
        comando.Parameters.AddWithValue("_apellido", persona.Apellido)
        comando.Parameters.AddWithValue("_cedula", persona.Cedula)
        comando.Parameters.AddWithValue("_telefono", persona.Telefono)
        comando.Parameters.AddWithValue("_direccion", persona.Direccion)
        comando.Parameters.AddWithValue("_estado", persona.Estado)
        comando.Parameters.AddWithValue("_fechaNacimiento", persona.FechaNacimiento)
        comando.Parameters.AddWithValue("_fechaCreacion", persona.FechaCreacion)
        comando.Parameters.AddWithValue("_fechaModificacion", persona.FechaModificacion)

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

    Public Function modificarBD(ByVal ppersona As ClsPersona, ByVal mensaje As String) As Boolean

        Return True
    End Function

    Public Function ConsultarPersonasPorNombre(ByVal nombre As String, ByRef mensaje As String) As DataTable
        getConexion()
        Dim comando As New MySqlCommand
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "QRY_ConsultarPersonasPorNombre"
        comando.Parameters.AddWithValue("pnombre", nombre)

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

    Public Function ConsultarPersonasPorCedula(ByVal cedula As Integer, ByRef mensaje As String) As DataTable
        getConexion()
        Dim comando As New MySqlCommand
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "QRY_ConsultarPersonasPorCedula"
        comando.Parameters.AddWithValue("pcedula", cedula)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable

        comando.Connection = conn
        da.SelectCommand = comando

        Try
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                dt = Nothing
                mensaje = "No existe Persona con esa cedula"
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
