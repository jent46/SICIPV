Imports BLL_SICIPV
Imports ENTIDADES

Public Class frm_Facturacion

    Dim mensaje As String = ""
    Dim operacion As String = ""

    Private Sub frm_Facturacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbBuscar.SetBounds(11, 40, gbBuscar.Width, gbBuscar.Height)
        Me.SetBounds(0, 0, 918, 637)
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

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If validarCampos() Then

        End If
    End Sub

    Private Function validarCampos() As Boolean
        Dim resultado As Boolean = True

        ErrorProvider1.Clear()

        If txtNoFactura.Text = "" Or Integer.TryParse(txtNoFactura.Text, New Integer) Then
            ErrorProvider1.SetError(txtNoFactura, "Numero de factura es requerido")
            resultado = False
        End If

        If txtNoContrato.Text = "" Or Integer.TryParse(txtNoContrato.Text, New Integer) Then
            ErrorProvider1.SetError(txtNoContrato, "Numero de Contraro es requerido")
            resultado = False
        End If

        If txtCliente.Text = "" Then
            ErrorProvider1.SetError(txtCliente, "Cliente es requerido")
            resultado = False
        End If

        If txtCedula.Text = "" Or Integer.TryParse(txtCedula.Text, New Integer) Or txtCedula.TextLength = 10 Or txtCedula.TextLength = 13 Then
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

        If cbTipoVenta.SelectedIndex <> -1 Then
            ErrorProvider1.SetError(cbTipoVenta, "Tipo de Venta es requerido")
            resultado = False
        End If

        If txtDsctoPorcentaje.Text = "" Or Integer.TryParse(txtDsctoPorcentaje.Text, New Integer) Then
            ErrorProvider1.SetError(txtDsctoPorcentaje, "Porcenta de Descuento es requerido")
            resultado = False
        End If

        If txtCuotas.Text = "" Or Integer.TryParse(txtCuotas.Text, New Integer) Then
            ErrorProvider1.SetError(txtCuotas, "No. Cuotas es requerido")
            resultado = False
        End If

        If txtInteres.Text = "" Or Integer.TryParse(txtInteres.Text, New Integer) Then
            ErrorProvider1.SetError(txtInteres, "% de Interes es requerido")
            resultado = False
        End If

        If txtCedulaGarante.Text = "" Or Integer.TryParse(txtCedulaGarante.Text, New Integer) Or txtCedula.TextLength = 10 Or txtCedula.TextLength = 13 Then
            ErrorProvider1.SetError(txtCedulaGarante, "Cedula del Garante es requerido")
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

        If txtCedula.Text = "" Or Integer.TryParse(txtCedula.Text, New Integer) Or txtCedula.TextLength = 10 Or txtCedula.TextLength = 13 Then
            ErrorProvider1.SetError(txtCedula, "Cedula es requerido")
        Else
            ErrorProvider1.Clear()
            dt = BLL_Persona.ConsultarPersonasPorCedula(txtCedula.Text, mensaje)
        End If

        If IsNothing(dt) Then

        Else
            MsgBox(mensaje, MsgBoxStyle.Information, My.Settings.NOMBREAPP)
        End If

    End Sub

    Private Sub btnBuscarGarante_Click(sender As Object, e As EventArgs) Handles btnBuscarGarante.Click
        Dim dt As DataTable = Nothing

        If txtCedulaGarante.Text = "" Or Integer.TryParse(txtCedulaGarante.Text, New Integer) Or txtCedulaGarante.TextLength = 10 Or txtCedulaGarante.TextLength = 13 Then
            ErrorProvider1.SetError(txtCedula, "Cedula es requerido")
        Else
            ErrorProvider1.Clear()
            dt = BLL_Persona.ConsultarPersonasPorCedula(txtCedula.Text, mensaje)
        End If

        If IsNothing(dt) Then

        Else
            MsgBox(mensaje, MsgBoxStyle.Information, My.Settings.NOMBREAPP)
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
End Class