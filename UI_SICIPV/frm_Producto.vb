Imports BLL_SICIPV
Imports ENTIDADES

Public Class frm_Producto
    Dim operacion As String = ""
    Dim mensaje As String = ""

    Private Sub frmProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SetBounds(0, 0, 516, 465)
    End Sub

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

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtBusqueda.Text = "" Then
            ErrorProvider1.SetError(txtBusqueda, "Este campo no puede estar vacio")
        Else
            ErrorProvider1.Clear()
            dgvBusqueda.Columns.Clear()
            dgvBusqueda.Rows.Clear()
            Dim dt As DataTable = Nothing
            dt = BLL_Producto.ConsultarProductosPorDescripcion(txtBusqueda.Text, mensaje)

            If IsNothing(dt) Then
                dgvBusqueda.DataSource = dt
            Else
                MsgBox(mensaje, MsgBoxStyle.Information, My.Settings.NOMBREAPP)
            End If
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If validarCampos() Then
            Dim producto As ClsProducto = New ClsProducto
            producto.Descripcion = txtDescripcion.Text
            producto.Stock = txtStock.Text
            producto.Valor = txtValor.Text
            producto.FechaCreacion = Now
            producto.FechaModificacion = Now
            If cbEstado.Checked Then
                producto.Estado = 1
            Else
                producto.Estado = 0
            End If

            Select Case operacion
                Case "I"
                    producto.FechaCreacion = Now
                    If BLL_Producto.ingresarBD(producto, mensaje) Then

                    End If
                Case "M"
                    If BLL_Producto.modificarBD(producto, mensaje) Then

                    End If
            End Select

            MsgBox(mensaje, MsgBoxStyle.Information, My.Settings.NOMBREAPP)
        End If
    End Sub

    Private Function validarCampos() As Boolean
        Dim resultado As Boolean = True

        ErrorProvider1.Clear()

        If txtDescripcion.Text = "" Then
            ErrorProvider1.SetError(txtDescripcion, "Descripción es requerido")
            resultado = False
        End If

        If txtValor.Text = "" Then
            ErrorProvider1.SetError(txtValor, "Valor es requerido")
            resultado = False
        End If

        If txtPvp.Text = "" Then
            ErrorProvider1.SetError(txtPvp, "PVP es requerido")
            resultado = False
        End If

        If txtStock.Text = "" Then
            ErrorProvider1.SetError(txtStock, "Stock es requerido")
            resultado = False
        End If

        Return resultado

    End Function
End Class