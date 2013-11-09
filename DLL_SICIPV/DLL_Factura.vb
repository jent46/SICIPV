Imports ENTIDADES
Imports MySql.Data.MySqlClient

Public Class DLL_Factura
    Inherits DLL_Base
    'Nuevo

    Public Function ingresarBD(ByVal factura As ClsFactura, ByRef mensaje As String) As Boolean
        getConexion()
        conn.Open()
        Dim comando As New MySqlCommand
        Dim transaction As MySqlTransaction
        Dim estado As Boolean = False
        Dim idFactura As Integer = 1

        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "INS_Factura"

        Try
            transaction = conn.BeginTransaction()
            comando.Transaction = transaction
            'comando = conn.CreateCommand()
            comando.Connection = conn

            comando.Parameters.AddWithValue("_idTipoVenta", factura.IdTipoVenta.IdTipoVenta)
            comando.Parameters.AddWithValue("_idFactura", idFactura)
            comando.Parameters("_idFactura").Direction = ParameterDirection.Output
            comando.Parameters.AddWithValue("_idPersona", factura.IdPersona.IdPersona)
            comando.Parameters.AddWithValue("_idGarante", factura.IdGarante.IdPersona)
            comando.Parameters.AddWithValue("_idCuotaValor", factura.IdCuotaValor.IdCuotaValor)
            comando.Parameters.AddWithValue("_idUsuarioCreacion", factura.IdUsuarioCreacion.IdUsuario)
            comando.Parameters.AddWithValue("_idUsuarioModificacion", factura.IdUsuarioModificacion.IdUsuario)
            comando.Parameters.AddWithValue("_numeroFactura", factura.NumeroFactura)
            comando.Parameters.AddWithValue("_numeroContrato", factura.NumeroContrato)
            comando.Parameters.AddWithValue("_fechaVenta", factura.FechaVenta)
            comando.Parameters.AddWithValue("_porcentajeDescuento", factura.PorcentajeDescuento)
            comando.Parameters.AddWithValue("_valorEntrada", factura.ValorEntrada)
            comando.Parameters.AddWithValue("_subtotal", factura.Subtotal)
            comando.Parameters.AddWithValue("_iva", factura.Iva)
            comando.Parameters.AddWithValue("_descuento", factura.Descuento)
            comando.Parameters.AddWithValue("_totalVenta", factura.TotalVenta)
            comando.Parameters.AddWithValue("_estado", factura.Estado)
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
            comando.ExecuteNonQuery()
            idFactura = comando.Parameters("_idFactura").Value.ToString()

            For Each item As ClsItemFactura In factura.ItemsProductos
                comando = New MySqlCommand
                comando.Connection = conn
                comando.CommandType = CommandType.StoredProcedure
                comando.CommandText = "INS_ItemFactura"
                comando.Parameters.AddWithValue("_idFactura", idFactura)
                comando.Parameters.AddWithValue("_idProducto", item.IdProducto.IdProducto)
                comando.Parameters.AddWithValue("_idUsuarioCreacion", item.IdUsuarioCreacion.IdUsuario)
                comando.Parameters.AddWithValue("_idUsuarioModificacion", item.IdUsuarioModificacion.IdUsuario)
                comando.Parameters.AddWithValue("_precioUnitario", item.PrecioUnitario)
                comando.Parameters.AddWithValue("_cantidad", item.Cantidad)
                comando.Parameters.AddWithValue("_precioTotal", item.PrecioTotal)
                comando.Parameters.AddWithValue("_descripcionProducto", item.DescripcionProducto)
                comando.Parameters.AddWithValue("_costoProducto", item.CostoProducto)
                comando.Parameters.AddWithValue("_estado", item.Estado)
                comando.Parameters.AddWithValue("_fechaCreacion", item.FechaCreacion)
                comando.Parameters.AddWithValue("_fechaModificacion", item.FechaModificacion)
                'Actualiza stock
                comando.Parameters.AddWithValue("_stock", item.IdProducto.Stock)
                comando.Transaction = transaction
                comando.ExecuteNonQuery()

            Next

            For Each itemCuota As ClsCuota In factura.ListaCuotas

                comando = New MySqlCommand
                comando.Connection = conn
                comando.CommandType = CommandType.StoredProcedure
                comando.CommandText = "INS_Cuota"
                comando.Parameters.AddWithValue("_idFactura", idFactura)
                comando.Parameters.AddWithValue("_idUsuarioCreacion", itemCuota.IdUsuarioCreacion.IdUsuario)
                comando.Parameters.AddWithValue("_idUsuarioModificacion", itemCuota.IdUsuarioModificacion.IdUsuario)
                comando.Parameters.AddWithValue("_numeroDeCuota", itemCuota.NumeroDeCuota)
                comando.Parameters.AddWithValue("_fecha", itemCuota.Fecha)
                comando.Parameters.AddWithValue("_saldo", itemCuota.Saldo)
                comando.Parameters.AddWithValue("_valorCuota", itemCuota.ValorCuota)
                comando.Parameters.AddWithValue("_porcentajeInteres", itemCuota.PorcentajeInteres)
                comando.Parameters.AddWithValue("_interesFactura", itemCuota.InteresFactura)

                comando.Parameters.AddWithValue("_valorTotal", itemCuota.ValorTotal)

                comando.Parameters.AddWithValue("_estado", itemCuota.Estado)
                comando.Parameters.AddWithValue("_fechaCreacion", itemCuota.FechaCreacion)
                comando.Parameters.AddWithValue("_fechaModificacion", itemCuota.FechaModificacion)
                comando.Transaction = transaction
                comando.ExecuteNonQuery()

            Next


            transaction.Commit()
            estado = True
            mensaje = "Factura ingresada exitosamente!"
        Catch ex As Exception
            mensaje = ex.Message
            estado = False
            If Not transaction Is Nothing Then
                transaction.Rollback()
            End If

        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try

        Return estado
    End Function

    'Modificacion

    Public Function modificarBD(ByVal factura As ClsFactura, ByRef mensaje As String) As Boolean
        getConexion()
        conn.Open()
        Dim transaction As MySqlTransaction
        Dim comando As New MySqlCommand
        Dim estado As Boolean = False
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "UPD_Factura"
        Try
            transaction = conn.BeginTransaction()
            comando.Transaction = transaction
            comando.Connection = conn
            comando.Parameters.AddWithValue("_idFactura", factura.IdFactura)
            comando.Parameters.AddWithValue("_idTipoVenta", factura.IdTipoVenta)
            comando.Parameters.AddWithValue("_idPersona", factura.IdPersona)
            comando.Parameters.AddWithValue("_idGarante", factura.IdGarante)
            comando.Parameters.AddWithValue("_idUsuarioModificacion", factura.IdUsuarioModificacion)
            comando.Parameters.AddWithValue("_numeroFactura", factura.NumeroFactura)
            comando.Parameters.AddWithValue("_numeroContrato", factura.NumeroContrato)
            comando.Parameters.AddWithValue("_fechaVenta", factura.FechaVenta)
            comando.Parameters.AddWithValue("_subtotal", factura.Subtotal)
            comando.Parameters.AddWithValue("_iva", factura.Iva)
            comando.Parameters.AddWithValue("_porcentajeDescuento", factura.PorcentajeDescuento)
            comando.Parameters.AddWithValue("_descuento", factura.Descuento)
            comando.Parameters.AddWithValue("_estado", factura.Estado)
            'comando.Parameters.AddWithValue("_cuotas", factura.Cuotas)
            comando.Parameters.AddWithValue("_clienteNombre", factura.ClienteNombre)
            comando.Parameters.AddWithValue("_clienteCedula", factura.ClienteCedula)
            comando.Parameters.AddWithValue("_clienteTelefono", factura.ClienteTelefono)
            comando.Parameters.AddWithValue("_clienteDireccion", factura.ClienteDireccion)
            comando.Parameters.AddWithValue("_garanteNombre", factura.GaranteNombre)
            comando.Parameters.AddWithValue("_garanteCedula", factura.GaranteCedula)
            comando.Parameters.AddWithValue("_garanteTelefono", factura.GaranteTelefono)
            comando.Parameters.AddWithValue("_garanteDireccion", factura.GaranteDireccion)
            comando.Parameters.AddWithValue("_fechaModificacion", factura.FechaModificacion)
            comando.ExecuteNonQuery()

            For Each item As ClsItemFactura In factura.ItemsProductos
                comando = New MySqlCommand
                comando.Connection = conn
                comando.CommandType = CommandType.StoredProcedure
                comando.CommandText = "UPD_ItemFactura"
                comando.Parameters.AddWithValue("_idFactura", item.IdFactura.IdFactura)
                comando.Parameters.AddWithValue("_idProducto", item.IdProducto.IdProducto)
                comando.Parameters.AddWithValue("_idUsuarioModificacion", item.IdUsuarioModificacion.IdUsuario)
                comando.Parameters.AddWithValue("_precioUnitario", item.PrecioUnitario)
                comando.Parameters.AddWithValue("_cantidad", item.Cantidad)
                comando.Parameters.AddWithValue("_precioTotal", item.PrecioTotal)
                comando.Parameters.AddWithValue("_descripcionProducto", item.DescripcionProducto)
                comando.Parameters.AddWithValue("_costoProducto", item.CostoProducto)
                comando.Parameters.AddWithValue("_estado", item.Estado)
                comando.Parameters.AddWithValue("_fechaModificacion", item.FechaModificacion)
                comando.Transaction = transaction
                comando.ExecuteNonQuery()
            Next

            transaction.Commit()
            estado = True
        Catch ex As Exception
            estado = False
            mensaje = ex.Message
            If Not transaction Is Nothing Then
                transaction.Rollback()
            End If
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try

        Return estado
    End Function

    'Consultas

    Public Function ConsultarFacturasPorCedula(ByVal pcedula As Integer, ByRef mensaje As String) As DataTable
        getConexion()
        Dim comando As New MySqlCommand
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "QRY_ConsultarFacturasPorCedula"
        comando.Parameters.AddWithValue("_cedula", pcedula)

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
