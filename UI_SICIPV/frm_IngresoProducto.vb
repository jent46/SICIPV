Imports ENTIDADES
Imports BLL_SICIPV
Imports System.Windows.Forms

Public Class frm_IngresoProducto
    Private idIngresoProducto As Integer
    Public usuario As ClsUsuario
    Private operacion As String = ""
    Private mensaje As String = ""


    Private Sub tslIngresar_Click(sender As Object, e As EventArgs) Handles tslIngresar.Click
        gbBuscar.Enabled = False
        gbBuscar.Visible = False
        gbProducto.Visible = True
        gbProducto.Enabled = True
        pnlBotones.Visible = True
        pnlBotones.Enabled = True
        tslIngresar.Enabled = False
        tslModificar.Enabled = False
        tslConsultar.Enabled = False
        btnAceptar.Enabled = True
        operacion = "I"
    End Sub

    Private Sub tslModificar_Click(sender As Object, e As EventArgs) Handles tslModificar.Click
        gbBuscar.Enabled = False
        gbBuscar.Visible = False
        gbProducto.Visible = True
        gbProducto.Enabled = True
        pnlBotones.Visible = True
        pnlBotones.Enabled = True
        tslIngresar.Enabled = False
        tslModificar.Enabled = False
        tslConsultar.Enabled = False
        btnAceptar.Enabled = True
        operacion = "M"

    End Sub

    Private Sub tslConsultar_Click(sender As Object, e As EventArgs) Handles tslConsultar.Click
        gbBuscar.Enabled = True
        gbBuscar.Visible = True
        gbProducto.Visible = False
        gbProducto.Enabled = False
        pnlBotones.Visible = True
        pnlBotones.Enabled = True
        tslIngresar.Enabled = False
        tslModificar.Enabled = False
        tslConsultar.Enabled = False
        btnAceptar.Enabled = False
        operacion = "C"
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        gbBuscar.Enabled = False
        gbBuscar.Visible = False
        gbProducto.Visible = False
        gbBuscar.Enabled = False
        pnlBotones.Visible = False
        pnlBotones.Enabled = False
        tslIngresar.Enabled = True
        tslModificar.Enabled = False
        tslConsultar.Enabled = True
        btnAceptar.Enabled = False
    End Sub

    Private Sub frm_IngresoProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SetBounds(400, 0, 516, 465)
        cbProducto.DataSource = BLL_IngreoProducto.ListaProducto(mensaje)
        cbProducto.DisplayMember = "Descripcion"
        cbProducto.ValueMember = "Id"
        cbProducto.SelectedIndex = -1
    End Sub

    Private Function validarCampos() As Boolean
        Dim resultado As Boolean = True

        ErrorProvider1.Clear()

        If txtCantidad.Text = "" Then
            ErrorProvider1.SetError(txtCantidad, "Cantidad es requerido")
            resultado = False
        End If

        If dtpFecha.Value.Date = Now Then
            ErrorProvider1.SetError(dtpFecha, "Fecha es requerido")
            resultado = False
        End If

        Return resultado

    End Function

    Private Sub limpiarCampos()
        txtCantidad.Text = String.Empty
        dtpFecha.Value = Date.Now
        cbProducto.SelectedValue = -1
        dtpFecha.Value = Date.Now
        cbEstado.Checked = False
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If validarCampos() Then

            Dim ingresoProducto As ClsIngresoProducto = New ClsIngresoProducto()

            ingresoProducto.IdProducto = New ClsProducto()
            ingresoProducto.IdProducto.IdProducto = cbProducto.SelectedValue
            ingresoProducto.Cantidad = txtCantidad.Text
            ingresoProducto.Fecha = dtpFecha.Value.Date

            If cbEstado.Checked Then
                ingresoProducto.Estado = 1
            Else
                ingresoProducto.Estado = 0
            End If
            ingresoProducto.FechaModificacion = Date.Now

            Select Case operacion
                Case "I"
                    ingresoProducto.IdUsuarioCreacion = usuario
                    ingresoProducto.IdUsuarioModificacion = usuario
                    ingresoProducto.FechaCreacion = Date.Now
                    If BLL_IngreoProducto.ingresarBD(ingresoProducto, mensaje) Then
                        limpiarCampos()

                    End If
                Case "M"
                    ingresoProducto.IdUsuarioModificacion = usuario

                    'producto.IdProducto = idProducto
                    'If BLL_Producto.modificarBD(ingresoProducto, mensaje) Then
                    '    limpiarCampos()
                    'End If
            End Select

            MsgBox(mensaje, MsgBoxStyle.Information, My.Settings.NOMBREAPP)
        End If
    End Sub

    Private Sub dgvBusqueda_CellContentClick(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvBusqueda.CellDoubleClick
        Try
            Dim dr As DataGridViewRow = dgvBusqueda.Rows(e.RowIndex)
            Dim dt As DataTable = BLL_IngreoProducto.ConsultarIngreosProductoPorId(dr.Cells("Id").Value, mensaje)
            idIngresoProducto = dt.Rows(0)("idIngresoProducto")

            cbProducto.SelectedValue = dt.Rows(0)("idIngresoProducto")
            txtCantidad.Text = dt.Rows(0)("cantidad")
            dtpFecha.Value = dt.Rows(0)("fecha")
            If (dt.Rows(0)("estado")) = 1 Then
                cbEstado.Checked = True
            End If
            txtBusqueda.Text = String.Empty
            dgvBusqueda.Columns.Clear()
            tslModificar_Click(Nothing, Nothing)
        Catch ex As Exception
            Me.mensaje = "Debe dar doble click en una fila de la tabla para modificar"
            MsgBox(mensaje, MsgBoxStyle.Information, My.Settings.NOMBREAPP)
        End Try
        
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Not (Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        If txtBusqueda.Text = "" Then
            ErrorProvider1.SetError(txtBusqueda, "Este campo no puede estar vacio")
        Else
            ErrorProvider1.Clear()
            dgvBusqueda.Columns.Clear()


            Dim dt As DataTable = Nothing

            Try
                dt = BLL_IngreoProducto.ConsultarIngresoProductoPorDescripcion(txtBusqueda.Text, mensaje)

                If dt.Rows.Count <> 0 Then
                    dgvBusqueda.DataSource = dt
                    dgvBusqueda.Columns("Id").Visible = False
                End If

            Catch ex As Exception
            End Try

        End If
    End Sub
End Class