Imports BLL_SICIPV
Imports ENTIDADES
Imports System.Windows.Forms

Public Class frm_Facturacion
    Dim sep As Char
    Dim mensaje As String = ""
    Dim operacion As String = ""
    Public usuario As ClsUsuario
    Dim idPersona As Integer
    Dim idGarante As Integer

    Private Sub frm_Facturacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbBuscar.SetBounds(11, 40, gbBuscar.Width, gbBuscar.Height)
        Me.SetBounds(200, 0, 918, 637)
        sep = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        cbTipoVenta.DataSource = BLL_TipoVenta.ConsultarTipoVentaTodos(mensaje)
        cbTipoVenta.DisplayMember = "descripcion"
        cbTipoVenta.ValueMember = "idTipoVenta"
        cbTipoVenta.SelectedIndex = -1
    End Sub

    Private Sub tslIngresar_Click(sender As Object, e As EventArgs) Handles tslIngresar.Click
        gbInfoGeneral.Visible = True
        gbInfoGeneral.Enabled = True
        gbGarante.Visible = True
        gbGarante.Enabled = True
        gbBuscar.Visible = False
        gbBuscar.Enabled = False
        gbProductos.Visible = True
        gbProductos.Enabled = True
        pnlBotones.Visible = True
        btnAceptar.Enabled = True
        tslIngresar.Enabled = False
        tslConsultar.Enabled = False
        tslModificar.Enabled = False
        pnlBotones.SetBounds(1, 600, 874, 70)
        operacion = "I"
    End Sub

    Private Sub tslConsultar_Click(sender As Object, e As EventArgs) Handles tslConsultar.Click
        gbInfoGeneral.Visible = False
        gbInfoGeneral.Enabled = False
        gbGarante.Visible = False
        gbGarante.Enabled = False
        gbBuscar.Visible = True
        gbBuscar.Enabled = True
        gbProductos.Visible = False
        gbProductos.Enabled = False
        pnlBotones.Visible = True
        btnAceptar.Enabled = False
        tslIngresar.Enabled = False
        tslConsultar.Enabled = False
        tslModificar.Enabled = False
        pnlBotones.SetBounds(10, 370, 874, 70)
        operacion = "C"
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If operacion <> "" Then
            ErrorProvider1.Clear()
            gbInfoGeneral.Visible = False
            gbInfoGeneral.Enabled = False
            gbGarante.Visible = False
            gbGarante.Enabled = False
            gbBuscar.Visible = False
            gbBuscar.Enabled = False
            gbProductos.Visible = False
            gbProductos.Enabled = False
            pnlBotones.Visible = False
            btnAceptar.Enabled = False
            tslIngresar.Enabled = True
            tslConsultar.Enabled = True
            btnAceptar.Enabled = True
            operacion = ""
        End If
    End Sub

    Private Sub tslModificar_Click(sender As Object, e As EventArgs) Handles tslModificar.Click
        gbInfoGeneral.Visible = True
        gbInfoGeneral.Enabled = True
        gbGarante.Visible = True
        gbGarante.Enabled = True
        gbBuscar.Visible = False
        gbBuscar.Enabled = False
        gbProductos.Visible = True
        gbProductos.Enabled = True
        pnlBotones.Visible = True
        btnAceptar.Enabled = True
        tslIngresar.Enabled = False
        tslConsultar.Enabled = False
        tslModificar.Enabled = False
        pnlBotones.SetBounds(10, 620, 874, 70)
        operacion = "M"
    End Sub

    Sub limpiarCampos()
        txtNoFactura.Text = String.Empty
        txtCedula.Text = String.Empty
        txtCliente.Text = String.Empty
        txtCliente.Enabled = True
        txtDireccion.Text = String.Empty
        txtDireccion.Enabled = True
        txtNoContrato.Text = String.Empty
        cbTipoVenta.SelectedValue = -1
        txtTelefono.Text = String.Empty
        txtTelefono.Enabled = True
        dtpFecha.Value = Date.Now
        txtPorcentajeDscto.Value = 0.0
        txtCuotas.Text = 0
        txtInteres.Text = 0
        txtCedulaGarante.Text = String.Empty
        txtGarante.Text = String.Empty
        txtGarante.Enabled = True
        txtTelefonoGarante.Text = String.Empty
        txtTelefonoGarante.Enabled = True
        txtDireccionGarante.Text = String.Empty
        txtDireccion.Enabled = True
        txtSubtotal.Text = 0.0
        txtDescuento.Text = 0.0
        txtTarifa0.Text = 0.0
        txtTarifa12.Text = 0.0
        txtIva.Text = 0.0
        txtTotal.Text = 0.0
        txtEntrada.Text = 0.0
        dgvProductos.Columns.Clear()
    End Sub

    Private Function validarCampos() As Boolean
        Dim resultado As Boolean = True

        ErrorProvider1.Clear()

        If txtNoFactura.Text = "" Then
            ErrorProvider1.SetError(txtNoFactura, "Numero de factura es requerido")
            resultado = False
        End If

        If txtNoContrato.Text = "" Then
            ErrorProvider1.SetError(txtNoContrato, "Numero de Contraro es requerido")
            resultado = False
        End If

        If txtCliente.Text = "" Then
            ErrorProvider1.SetError(txtCliente, "Cliente es requerido")
            resultado = False
        End If

        Dim b As Boolean = Long.TryParse(txtCedula.Text, New Long)
        If txtCedula.Text = "" Or Not Long.TryParse(txtCedula.Text, New Long) Or (txtCedula.TextLength <> 10 And txtCedula.TextLength <> 13) Then
            ErrorProvider1.SetError(txtCedula, "Cedula es requerido")
            resultado = False
        End If


        If txtDireccion.Text = "" Then
            ErrorProvider1.SetError(txtDireccion, "Direccion es requerido")
            resultado = False
        End If

        If txtTelefono.Text = "" Then
            ErrorProvider1.SetError(txtTelefono, "Telefono es requerido")
            resultado = False
        End If

        If cbTipoVenta.SelectedIndex = -1 Then
            ErrorProvider1.SetError(cbTipoVenta, "Tipo de Venta es requerido")
            resultado = False
        End If


        If txtPorcentajeDscto.Text = "" Then
            ErrorProvider1.SetError(txtPorcentajeDscto, "Porcenta de Descuento es requerido")
            resultado = False
        End If

        If txtCuotas.Text = "" Then
            ErrorProvider1.SetError(txtCuotas, "No. Cuotas es requerido")
            resultado = False
        End If

        If txtInteres.Text = "" Then
            ErrorProvider1.SetError(txtInteres, "% de Interes es requerido")
            resultado = False
        End If


        If txtCedulaGarante.Text = "" Or Not Long.TryParse(txtCedulaGarante.Text, New Long) Or (txtCedulaGarante.TextLength <> 10 And txtCedulaGarante.TextLength <> 13) Then
            ErrorProvider1.SetError(txtCedulaGarante, "Cedula es requerido")
            resultado = False
        End If


        If txtGarante.Text = "" Then
            ErrorProvider1.SetError(txtGarante, "Garante es requerido")
            resultado = False
        End If

        If txtTelefonoGarante.Text = "" Then
            ErrorProvider1.SetError(txtTelefonoGarante, "Telefono del Garante es requerido")
            resultado = False
        End If

        If txtDireccionGarante.Text = "" Then
            ErrorProvider1.SetError(txtDireccionGarante, "Direccion del Garante es requerido")
            resultado = False
        End If

        If dgvProductos.RowCount = 0 Then
            ErrorProvider1.SetError(dgvProductos, "Debe ingresar al menos un producto")
            resultado = False
        End If

        Return resultado
    End Function

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If validarCampos() Then

            Dim factura As ClsFactura = New ClsFactura

            factura.IdTipoVenta = New ClsTipoVenta()
            factura.IdTipoVenta.IdTipoVenta = cbTipoVenta.SelectedValue
            factura.IdPersona = New ClsPersona()
            factura.IdPersona.IdPersona = Me.idPersona
            factura.IdGarante = New ClsPersona()
            factura.IdGarante.IdPersona = Me.idGarante

            factura.NumeroFactura = CInt(txtNoFactura.Text)
            factura.NumeroContrato = CInt(txtNoContrato.Text)
            factura.FechaVenta = dtpFecha.Value.Date
            factura.Subtotal = CDbl(txtSubtotal.Text)
            factura.Iva = CDbl(txtIva.Text)
            factura.PorcentajeDescuento = CDbl(txtPorcentajeDscto.Text)
            factura.Descuento = CDbl(txtDescuento.Text)
            factura.TotalVenta = CDbl(txtTotal.Text)
            'If cbEstado.Checked Then
            '    factura.Estado = 1
            'Else
            '    factura.Estado = 0
            'End If
            factura.Cuotas = CInt(txtCuotas.Text)
            factura.ClienteNombre = txtCliente.Text
            factura.ClienteCedula = txtCedula.Text
            factura.ClienteTelefono = txtTelefono.Text
            factura.ClienteDireccion = txtDireccion.Text
            factura.GaranteNombre = txtGarante.Text
            factura.GaranteCedula = txtCedulaGarante.Text
            factura.GaranteTelefono = txtTelefonoGarante.Text
            factura.GaranteDireccion = txtDireccionGarante.Text

            factura.FechaCreacion = Date.Now
            factura.FechaModificacion = Date.Now

            'Agrego los productos a la factura
            For index = 0 To dgvProductos.Rows.Count - 1
                Dim item As ClsItemFactura = New ClsItemFactura()
                Dim producto As ClsProducto = New ClsProducto()
                'dgvProductos -> *Id | Stock |Cantidad |* Costo | Descripcion | ValorUnitario | ValorTotal
                producto.IdProducto = dgvProductos.Rows(index).Cells("Id").Value
                producto.Stock = dgvProductos.Rows(index).Cells("stock").Value

                item.IdFactura = factura
                item.IdProducto = producto
                item.IdUsuarioCreacion = usuario
                item.IdUsuarioModificacion = usuario
                item.PrecioUnitario = dgvProductos.Rows(index).Cells("valorUnitario").Value
                item.Cantidad = dgvProductos.Rows(index).Cells("cantidad").Value
                item.PrecioTotal = dgvProductos.Rows(index).Cells("valorTotal").Value
                item.DescripcionProducto = dgvProductos.Rows(index).Cells("descripcion").Value
                item.CostoProducto = dgvProductos.Rows(index).Cells("costo").Value
                item.FechaCreacion = Date.Now
                item.FechaModificacion = Date.Now
                'Actualizo la cantidad de los productos que fueron ingresados en la venta
                item.IdProducto.Stock = producto.Stock - dgvProductos.Rows(index).Cells("cantidad").Value
                factura.ItemsProductos.Add(item)
            Next


            'Creo cada una de las cuotas
            For index = 0 To txtCuotas.Value - 1
                Dim cuota As ClsCuota = New ClsCuota()
                Dim arrayInteresCuota As Double() = {30, 35, 2.17, 3.26, 4.35, 5.43, 6.52, 7.61, 8.69, 9.78, 10.87, 11.95, 13.04, 14.13, 15.21, 16.3, 18.29, 20.13}

                Dim valorFinanciado As Double = factura.TotalVenta - txtEntrada.Text
                Dim indice As Integer = factura.Cuotas - 1
                Dim valorInteres As Double = (CDbl(arrayInteresCuota(indice)) / 100) * valorFinanciado
                Dim valorCredito As Double = valorInteres + valorFinanciado
                Dim valorPorCuota As Double = valorCredito / txtCuotas.Value
                Dim valorFinal As Double = valorCredito + txtEntrada.Text

                cuota.IdFactura = factura
                cuota.IdUsuarioCreacion = usuario
                cuota.IdUsuarioModificacion = usuario
                cuota.Fecha = Date.Now.AddMonths(index + 1) 'Se va sumando un mes a cada cuota
                cuota.Saldo = factura.TotalVenta
                cuota.ValorCuota = valorPorCuota
                cuota.PorcentajeInteres = arrayInteresCuota(txtCuotas.Value + 1)
                cuota.InteresFactura = valorInteres
                cuota.InteresMora = 0.0
                cuota.ValorTotal = valorFinal
                cuota.Comentario = ""
                cuota.Estado = 1
                cuota.FechaCreacion = Date.Now
                cuota.FechaModificacion = Date.Now
                factura.ListaCuotas.Add(cuota)
            Next

            Select Case operacion
                Case "I"
                    factura.IdUsuarioCreacion = usuario
                    factura.IdUsuarioModificacion = usuario
                    factura.FechaCreacion = Now
                    If BLL_Factura.ingresarBD(factura, mensaje) Then
                        limpiarCampos()
                        'gbInfoGeneral.Visible = False
                        'gbGarante.Visible = False
                        'gbProductos.Visible = False
                        'pnlBotones.Visible = False
                        'tslModificar.Enabled = False
                        'tslIngresar.Enabled = True
                        'tslConsultar.Enabled = True
                    End If
                    MsgBox(mensaje, MsgBoxStyle.Information, My.Settings.NOMBREAPP)

                Case "M"
                    'factura.IdPersona = idPersona
                    factura.IdUsuarioModificacion = usuario
                    factura.FechaModificacion = Date.Now
                    If BLL_Factura.modificarBD(factura, mensaje) Then
                        limpiarCampos()
                    End If
                    MsgBox(mensaje, MsgBoxStyle.Information, My.Settings.NOMBREAPP)

            End Select


        End If
    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click

        Dim dt As DataTable = Nothing

        If txtCedula.Text = "" Or Not Long.TryParse(txtCedula.Text, New Long) Or (txtCedula.TextLength <> 10 And txtCedula.TextLength <> 13) Then
            ErrorProvider1.SetError(txtCedula, "Cedula es requerido")
        ElseIf ValidarCedula() Then
            ErrorProvider1.Clear()
            dt = BLL_Persona.ConsultarPersonasPorCedula(txtCedula.Text, mensaje)
            Try
                If dt.Rows.Count <> 1 Then
                    MsgBox("No existen Clientes con esa cedula", MsgBoxStyle.Information, My.Settings.NOMBREAPP)
                    txtCedula.Enabled = True
                Else
                    txtCedula.Enabled = False
                    idPersona = dt.Rows(0)("Id")
                    txtCliente.Text = dt.Rows(0)("nombre")
                    txtTelefono.Text = dt.Rows(0)("telefono")
                    txtDireccion.Text = dt.Rows(0)("direccion")
                End If
            Catch ex As Exception
                MsgBox("No existen Clientes con esa cedula", MsgBoxStyle.Information, My.Settings.NOMBREAPP)
            End Try
        End If


    End Sub

    Private Sub btnBuscarGarante_Click(sender As Object, e As EventArgs) Handles btnBuscarGarante.Click
        Dim dt As DataTable = Nothing

        If txtCedulaGarante.Text = "" Or Not Long.TryParse(txtCedulaGarante.Text, New Long) Or (txtCedulaGarante.TextLength <> 10 And txtCedulaGarante.TextLength <> 13) Then
            ErrorProvider1.SetError(txtCedulaGarante, "Cedula es requerido")
        ElseIf ValidarCedula() Then
            ErrorProvider1.Clear()
            dt = BLL_Persona.ConsultarPersonasPorCedula(txtCedulaGarante.Text, mensaje)
            Try
                If dt.Rows.Count <> 1 Then
                    MsgBox("No existen Clientes con esa cedula", MsgBoxStyle.Information, My.Settings.NOMBREAPP)
                Else
                    txtCedulaGarante.Enabled = False
                    idGarante = dt.Rows(0)("Id")
                    txtGarante.Text = dt.Rows(0)("nombre")
                    txtTelefonoGarante.Text = dt.Rows(0)("telefono")
                    txtDireccionGarante.Text = dt.Rows(0)("direccion")
                End If
            Catch ex As Exception
                MsgBox("No existen Clientes con esa cedula", MsgBoxStyle.Information, My.Settings.NOMBREAPP)
            End Try
        End If
    End Sub

    Function ValidarCedula() As Boolean
        If (txtCedula.Text = txtCedulaGarante.Text) Then
            MsgBox("Un cliente no puede ser garante al mismo tiempo!!", MsgBoxStyle.Information, My.Settings.NOMBREAPP)
            Return False
        End If
        Return True
    End Function

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        If txtBusqueda.Text = "" Then
            ErrorProvider1.SetError(txtBusqueda, "Este campo no puede estar vacio")
        ElseIf rbCedula.Checked And Not Integer.TryParse(txtBusqueda.Text, New Integer) Then
            ErrorProvider1.SetError(txtBusqueda, "La Cedula debe ser un numero")
        ElseIf rbContrato.Checked And Not Integer.TryParse(txtBusqueda.Text, New Integer) Then
            ErrorProvider1.SetError(txtBusqueda, "El Contrato debe ser un numero")
        ElseIf rbFactura.Checked And Not Integer.TryParse(txtBusqueda.Text, New Integer) Then
            ErrorProvider1.SetError(txtBusqueda, "La Factura debe ser un numero")
        Else
            ErrorProvider1.Clear()
            dgvBusqueda.Columns.Clear()
            dgvBusqueda.Rows.Clear()
            Dim dt As DataTable = Nothing

            If rbCedula.Checked Then
                dt = BLL_Factura.ConsultarFacturasPorCedula(txtBusqueda.Text, mensaje)
            ElseIf rbContrato.Checked Then
                dt = BLL_Factura.ConsultarFacturasPorNumeroContrato(txtBusqueda.Text, mensaje)
            ElseIf rbFactura.Checked Then
                dt = BLL_Factura.ConsultarFacturasPorNumeroFactura(txtBusqueda.Text, mensaje)
            ElseIf rbNombre.Checked Then
                dt = BLL_Factura.ConsultarFacturasPorNombreCliente(txtBusqueda.Text, mensaje)
            End If

            If IsNothing(dt) Then
                dgvBusqueda.DataSource = dt
            Else
                MsgBox(mensaje, MsgBoxStyle.Information, My.Settings.NOMBREAPP)
            End If
        End If

    End Sub

    Private Sub btnEditarCliente_Click(sender As Object, e As EventArgs) Handles btnEditarCliente.Click
        txtCedula.Enabled = True
        txtCliente.Text = String.Empty
        txtTelefono.Text = String.Empty
        txtDireccion.Text = String.Empty

    End Sub

    Private Sub btnEditarGarante_Click(sender As Object, e As EventArgs) Handles btnEditarGarante.Click
        txtCedulaGarante.Enabled = True
        txtGarante.Text = String.Empty
        txtTelefonoGarante.Text = String.Empty
        txtDireccionGarante.Text = String.Empty
    End Sub

    Private Sub btnAnadir_Click(sender As Object, e As EventArgs) Handles btnAnadir.Click
        frm_IngresarProductoFactura.ShowDialog()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        For index = 0 To dgvProductos.SelectedRows.Count - 1
            Dim valorTotal As Double = dgvProductos.SelectedRows(index).Cells("ValorTotal").Value
            txtSubtotal.Text = txtSubtotal.Text - valorTotal
            actualizarValoresFactura()
            dgvProductos.Rows.Remove(dgvProductos.SelectedRows(index))
        Next
    End Sub

    Public Sub agregarProducto(ByVal prod As ClsProducto)
        'dgvProductos -> *Id |Stock| Cantidad |* Costo | Descripcion | ValorUnitario | ValorTotal

        Dim id As Integer = prod.IdProducto
        Dim cantidad As Integer = 1
        Dim costo As Double = prod.Valor
        Dim stock As Integer = prod.Stock
        Dim descripcion As String = prod.Descripcion
        Dim valorUnitario As Double = prod.Pvp / 1.12
        Dim valorTotal As Double = cantidad * valorUnitario
        Dim gravaIva As Integer = prod.GravaIva

        Dim flag As Boolean = True

        If dgvProductos.Rows.Count <> 0 Then 'Pregunto si hay filas en dgvProductos
            For index = 0 To dgvProductos.Rows.Count - 1    'Recorro todas las filas que hay
                If (dgvProductos.Rows(index).Cells("id").Value = id) Then 'Si en el dgvProductos hay algun producto con ese mismo id
                    MessageBox.Show("Producto ya fue ingresado")
                    flag = False
                    index = dgvProductos.Rows.Count 'Pongo al tope el index para que termine
                End If
            Next
        End If

        If flag Then
            dgvProductos.Rows.Add(id, gravaIva, stock, cantidad, costo, descripcion, valorUnitario, valorTotal)
            Dim subtotal As Double = CDbl(txtSubtotal.Text) + valorTotal
            Dim descuento As Double = CDbl(txtSubtotal.Text) * (CDbl(txtDescuento.Text) / 100)
            txtSubtotal.Text = subtotal
            txtDescuento.Text = descuento
            If prod.GravaIva = 0 Then
                txtTarifa0.Text = valorTotal
            Else
                txtTarifa12.Text = valorTotal
            End If
            actualizarValoresFactura()

        End If

    End Sub

    Sub actualizarValoresFactura()
        Dim descuento As Double = (CDbl(txtSubtotal.Text) * CDbl(txtPorcentajeDscto.Text)) / 100
        Dim iva As Double = (CDbl(txtTarifa12.Text) - CDbl(txtDescuento.Text)) * 0.12
        Dim total As Double = CDbl(txtTarifa12.Text) + iva + CDbl(txtTarifa0.Text) - CDbl(txtDescuento.Text)
        Dim valorEntrada = 0.08 * total
        txtDescuento.Text = descuento
        txtIva.Text = iva
        txtTotal.Text = total
        txtEntrada.Text = valorEntrada
    End Sub

    Sub Valida(Data As TextBox)
        If Data.Text = sep Then
            'si el separador decimal es tecleado directamente
            Data.Text = "0" & sep
            Data.SelectionStart = Len(Data.Text)
        ElseIf Not IsNumeric(Trim(Data.Text)) Then
            Beep()
            If Len(Data.Text) < 1 Then
                Data.Text = ""
            Else
                Data.Text = Microsoft.VisualBasic.Left(Data.Text, Len(Data.Text) - 1)
                Data.SelectionStart = Len(Data.Text)
            End If
        End If
    End Sub

    Sub Aplica(Data As TextBox)
        Dim DT As String
        'Para adaptar a la configuracion del PC huesped.
        DT = Replace(Data.Text, ".", sep)
        ' DT = Replace(DT, ",", Sep)
        Label1.Text = CDbl(DT)
        On Error Resume Next
        Data.SelectionStart = 0
        Data.SelectionLength = Len(Data.Text)
        Data.Focus()
    End Sub

    Private Sub txtNoFactura_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles txtNoFactura.KeyPress, txtNoContrato.KeyPress
        If Not (Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub txtDsctoPorcentaje_TextChanged(sender As Object, e As EventArgs)
        Valida(sender)
    End Sub

    Private Sub txtDsctoPorcentaje_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = 13 Then
            Aplica(sender)
        End If
    End Sub

    Private Sub dgvProductos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellValueChanged
        If e.ColumnIndex > 1 Then
            If dgvProductos.Rows.Count <> 0 Then 'Preguntamos si el datagridview de productos esta lleno con al menos un producto
                Dim dr As DataGridViewRow = dgvProductos.Rows(e.RowIndex)
                Dim valorTotal As Double = dr.Cells("ValorTotal").Value
                Dim cantidad As Integer
                If Integer.TryParse(dr.Cells("Cantidad").Value, New Integer()) Then
                    cantidad = dr.Cells("Cantidad").Value
                    If cantidad = 0 Then
                        dr.Cells("Cantidad").Value = cantidad = 1
                        MsgBox("Tiene que ingresar una cantidad mayor a cero", MsgBoxStyle.Information, My.Settings.NOMBREAPP)
                    End If

                Else
                    dr.Cells("Cantidad").Value = 1
                    cantidad = 1
                End If

                Dim nuevoTotal As Double = cantidad * dr.Cells("ValorUnitario").Value
                Dim gravaIva As Integer = dr.Cells("GravaIva").Value
                dr.Cells("ValorTotal").Value = nuevoTotal

                If gravaIva = 0 Then
                    txtTarifa0.Text = nuevoTotal
                Else
                    txtTarifa12.Text = nuevoTotal
                End If
                txtSubtotal.Text = CDbl(txtSubtotal.Text) + nuevoTotal - valorTotal

                actualizarValoresFactura()
            End If

        End If
    End Sub


End Class