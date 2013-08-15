Imports ENTIDADES
Imports MySql.Data.MySqlClient

Public Class DLL_Factura
    Inherits DLL_Base

    Public Function ingresarBD(ByVal factura As ClsFactura, ByVal mensaje As String) As Boolean
        getConexion()
        Dim comando As New MySqlCommand
        Dim estado As Boolean = False
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "INS_Factura"

        comando.Parameters.AddWithValue("_idTipoVenta", factura.IdTipoVenta)
        comando.Parameters.AddWithValue("_idPersona", factura.IdPersona)
        comando.Parameters.AddWithValue("_idGarante", factura.IdGarante)
        comando.Parameters.AddWithValue("_idUsuarioCreacion", factura.IdUsuarioCreacion)
        comando.Parameters.AddWithValue("_idUsuarioModificacion", factura.IdUsuarioModificacion)
        comando.Parameters.AddWithValue("_numeroFactura", factura.NumeroFactura)
        comando.Parameters.AddWithValue("_numeroContrato", factura.NumeroContrato)
        comando.Parameters.AddWithValue("_fechaVenta", factura.FechaVenta)
        comando.Parameters.AddWithValue("_subtotal", factura.Subtotal)
        comando.Parameters.AddWithValue("_iva", factura.Iva)
        comando.Parameters.AddWithValue("_porcentajeDescuento", factura.PorcentajeDescuento)
        comando.Parameters.AddWithValue("_descuento", factura.Descuento)
        comando.Parameters.AddWithValue("_estado", factura.Estado)
        comando.Parameters.AddWithValue("_cuotas", factura.Cuotas)
        comando.Parameters.AddWithValue("_clienteNombre", factura.ClienteNombre)
        comando.Parameters.AddWithValue("_clienteCedula", factura.ClienteCedula)
        comando.Parameters.AddWithValue("_clienteTelefono", factura.ClienteTelefono)
        comando.Parameters.AddWithValue("_clienteDireccion", factura.ClienteDireccion)
        comando.Parameters.AddWithValue("_garanteNombre", factura.GaranteNombre)
        comando.Parameters.AddWithValue("_garanteCedula", factura.GaranteCedula)
        comando.Parameters.AddWithValue("_garanteTelefono", factura.GaranteTelefono)
        comando.Parameters.AddWithValue("_garanteDireccion", factura.GaranteDireccion)
        comando.Parameters.AddWithValue("_fechaCreacion", factura.FechaCreacion)
        comando.Parameters.AddWithValue("_fechaModificacion", factura.FechaModificacion)
       


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

    Public Function modificarBD(ByVal pfactura As ClsFactura, ByVal mensaje As String) As Boolean

        Return True
    End Function

    Public Function ConsultarFacturasPorNombreCliente(ByVal nombre As String, ByRef mensaje As String) As DataTable
        getConexion()
        Dim comando As New MySqlCommand
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "QRY_ConsultarFacturasPorNombreCliente"
        comando.Parameters.AddWithValue("pnombre", nombre)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable

        comando.Connection = conn
        da.SelectCommand = comando

        Try
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                dt = Nothing
                mensaje = "No existen Facturas con ese nombre de cliente"
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

    Public Function ConsultarFacturasPorCedula(ByVal pcedula As Integer, ByRef mensaje As String) As DataTable
        getConexion()
        Dim comando As New MySqlCommand
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "QRY_ConsultarFacturasPorCedula"
        comando.Parameters.AddWithValue("pcedula", pcedula)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable

        comando.Connection = conn
        da.SelectCommand = comando

        Try
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                dt = Nothing
                mensaje = "No existen Facturas con esa cedula de cliente"
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

    Public Function ConsultarFacturasPorNumeroContrato(ByVal contrato As Integer, ByRef mensaje As String) As DataTable
        getConexion()
        Dim comando As New MySqlCommand
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "QRY_ConsultarFacturasPorNumeroContrato"
        comando.Parameters.AddWithValue("pcontrato", contrato)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable

        comando.Connection = conn
        da.SelectCommand = comando

        Try
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                dt = Nothing
                mensaje = "No existe Facturas con ese numero de contrato"
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

    Public Function ConsultarFacturasPorNumeroFactura(ByVal factura As Integer, ByRef mensaje As String) As DataTable
        getConexion()
        Dim comando As New MySqlCommand
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "QRY_ConsultarFacturasPorNumeroFactura"
        comando.Parameters.AddWithValue("pfactura", factura)

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable

        comando.Connection = conn
        da.SelectCommand = comando

        Try
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                dt = Nothing
                mensaje = "No existe Facturas con ese numero de factura"
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
