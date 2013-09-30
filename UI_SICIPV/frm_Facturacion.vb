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
        Me.SetBounds(0, 0, 918, 637)
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
        pnlBotones.SetBounds(1, 620, 874, 70)
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
        txtDescuento.Text = 0
        txtCuotas.Text = 0
        txtInteres.Text = 0
        txtCedulaGarante.Text = String.Empty
        txtGarante.Text = String.Empty
        txtGarante.Enabled = True
        txtTelefonoGarante.Text = String.Empty
        txtTelefonoGarante.Enabled = True
        txtDireccion.Text = String.Empty
        txtDireccion.Enabled = True
        dgvProductos.Columns.Clear()
    End Sub

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

            For index = 0 To dgvProductos.Rows.Count - 1
                Dim item As ClsItemFactura = New ClsItemFactura()
                Dim producto As ClsProducto = New ClsProducto()

                producto.IdProducto = dgvProductos.Rows(index).Cells("Id").Value

                'idFactura
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
                factura.ItemsProductos.Add(item)
            Next


            Select Case operacion
                Case "I"
                    factura.IdUsuarioCreacion = usuario
                    factura.IdUsuarioModificacion = usuario
                    factura.FechaCreacion = Now
                    If BLL_Factura.ingresarBD(factura, mensaje) Then
                        limpiarCampos()
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

    Function ValidarCedula() As Boolean
        If (txtCedula.Text = txtCedulaGarante.Text) Then
            MsgBox("Un cliente no puede ser garante al mismo tiempo!!", MsgBoxStyle.Information, My.Settings.NOMBREAPP)
            Return False
        End If
        Return True
    End Function

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
        Dim id As Integer = prod.IdProducto
        Dim cantidad As Integer = 1
        'dgvProductos.CurrentRow.Cells("Cantidad").Value
        Dim descripcion As String = prod.Descripcion
        Dim valorUnitario As Double = prod.Pvp
        Dim valorTotal As Double = cantidad * valorUnitario
        Dim costo As Double = prod.Valor

        Dim flat As Boolean = True

        If dgvProductos.Rows.Count <> 0 Then
            For index = 0 To dgvProductos.Rows.Count - 1
                If (dgvProductos.Rows(index).Cells("id").Value = id) Then
                    MessageBox.Show("Producto ya fue ingresado")
                    flat = False
                    index = dgvProductos.Rows.Count
                End If
            Next
        End If

        If flat Then
            dgvProductos.Rows.Add(id, cantidad, costo, descripcion, valorUnitario, valorTotal)
            txtSubtotal.Text = CDbl(txtSubtotal.Text) + valorTotal
            actualizarValoresFactura()

        End If


                'If dgvProductos.Rows.Count <> 0 Then
                '    For index = 0 To dgvProductos.Rows.Count - 1
                '        If (dgvProductos.Rows(index).Cells("id").Value = id) Then
                '            MessageBox.Show("Producto ya fue ingresado")
                '        End If
                '    Next
                'Else
                '    dgvProductos.Rows.Add(id, cantidad, descripcion, valorUnitario, valorTotal)
                'End If



        'dgvProductos.Rows.Add(prod.Valor, 1, prod.Pvp, prod.Pvp)
                'txtSubtotal.Text = CDbl(txtSubtotal.Text) + prod.Pvp
                'txtDescuento.Text = CDbl(txtSubtotal.Text) * CDbl(txtDsctoPorcentaje.Text) / 100
                'txtIva.Text = CDbl(txtIva.Text) * 0.12
                'txtTotal.Text = CDbl(txtSubtotal.Text) - CDbl(txtDescuento.Text) + CDbl(txtIva.Text)
    End Sub

    Sub actualizarValoresFactura()
        txtDescuento.Text = (CDbl(txtSubtotal.Text) * CDbl(txtPorcentajeDscto.Text)) / 100
        txtIva.Text = (CDbl(txtSubtotal.Text) - CDbl(txtDescuento.Text)) * 0.12
        txtTotal.Text = CDbl(txtSubtotal.Text) - CDbl(txtDescuento.Text) + CDbl(txtIva.Text)
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
        If e.ColumnIndex = 1 Then
            If dgvProductos.Rows.Count <> 0 Then 'Preguntamos si el datagridview de productos esta lleno con al menos un producto
                Dim dr As DataGridViewRow = dgvProductos.Rows(e.RowIndex)
                Dim valorTotal As Double = dr.Cells("ValorTotal").Value
                Dim cantidad As Integer
                If Integer.TryParse(dr.Cells("Cantidad").Value, New Integer()) Then
                    cantidad = dr.Cells("Cantidad").Value
                    If cantidad = 0 Then
                        dr.Cells("Cantidad").Value = cantidad = 1
                    End If
                    MsgBox("Tiene que ingresar una cantidad mayor a cero", MsgBoxStyle.Information, My.Settings.NOMBREAPP)
                Else
                    dr.Cells("Cantidad").Value = 1
                    cantidad = 1
                End If

                Dim nuevoTotal As Double = cantidad * dr.Cells("ValorUnitario").Value
                dr.Cells("ValorTotal").Value = nuevoTotal
                txtSubtotal.Text = CDbl(txtSubtotal.Text) + nuevoTotal - valorTotal
                actualizarValoresFactura()
            End If

        End If
    End Sub


End Class