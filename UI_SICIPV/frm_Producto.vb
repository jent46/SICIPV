Imports BLL_SICIPV
Imports ENTIDADES
Imports System.Windows.Forms

Public Class frm_Producto
    Dim operacion As String = ""
    Dim mensaje As String = ""
    Public usuario As ClsUsuario
    Dim idProducto As Integer
    Dim sep As Char

    Private Sub frmProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SetBounds(0, 0, 516, 465)
        'Detectar el separador decimal de la aplicación.
        Sep = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
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


            Dim dt As DataTable = Nothing

            Try
                dt = BLL_Producto.ConsultarProductosPorDescripcion(txtBusqueda.Text, mensaje)

                If dt.Rows.Count <> 0 Then
                    dgvBusqueda.DataSource = dt
                    dgvBusqueda.Columns("Id").Visible = False
                End If
            Catch ex As Exception
            End Try

            
        End If
    End Sub



    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If validarCampos() Then
            Dim producto As ClsProducto = New ClsProducto



            producto.IdUsuarioModificacion = usuario


            producto.Descripcion = txtDescripcion.Text
            producto.Valor = CDbl(txtValor.Text)
            producto.Pvp = CDbl(txtPvp.Text)
            producto.Stock = CInt(txtStock.Text)
            producto.FechaModificacion = Now()

            If cbEstado.Checked Then
                producto.Estado = 1
            Else
                producto.Estado = 0
            End If

            Select Case operacion
                Case "I"
                    producto.FechaCreacion = Now()
                    producto.IdUsuarioCreacion = usuario

                    If BLL_Producto.ingresarBD(producto, mensaje) Then
                        limpiarCampos()
                    End If
                Case "M"
                    producto.IdProducto = idProducto
                    If BLL_Producto.modificarBD(producto, mensaje) Then
                        limpiarCampos()
                    End If
            End Select

            MsgBox(mensaje, MsgBoxStyle.Information, My.Settings.NOMBREAPP)
        End If
    End Sub
    Private Sub limpiarCampos()
        txtDescripcion.Text = String.Empty
        txtValor.Text = String.Empty
        txtPvp.Text = String.Empty
        txtStock.Text = String.Empty
        cbEstado.Checked = False
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

    Sub Valida(Data As TextBox)
        If Data.Text = Sep Then
            'si el separador decimal es tecleado directamente
            Data.Text = "0" & Sep
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
        DT = Replace(Data.Text, ".", Sep)
        ' DT = Replace(DT, ",", Sep)
        Label1.Text = CDbl(DT)
        On Error Resume Next
        Data.SelectionStart = 0
        Data.SelectionLength = Len(Data.Text)
        Data.Focus()
    End Sub

    Private Sub txtValor_TextChanged(sender As Object, e As EventArgs) Handles txtValor.TextChanged, txtPvp.TextChanged
        Valida(sender)
    End Sub

    Private Sub txtValor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtValor.KeyDown, txtPvp.KeyDown
        If e.KeyCode = 13 Then
            Aplica(sender)
        End If
    End Sub


    Private Sub txtStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStock.KeyPress
        If Not (Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub dgvBusqueda_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBusqueda.CellDoubleClick
        Dim dr As DataGridViewRow = dgvBusqueda.Rows(e.RowIndex)
        Dim dt As DataTable = BLL_Producto.ConsultarProductosPorId(dr.Cells("Id").Value, mensaje)
        idProducto = dt.Rows(0)("idProducto")
        txtDescripcion.Text = dt.Rows(0)("descripcion")
        txtPvp.Text = dt.Rows(0)("pvp")
        txtStock.Text = dt.Rows(0)("stock")
        txtValor.Text = dt.Rows(0)("valor")
        If (dt.Rows(0)("estado")) = 1 Then
            cbEstado.Checked = True
        End If
        txtBusqueda.Text = String.Empty
        dgvBusqueda.Columns.Clear()
        tslModificar_Click(Nothing, Nothing)
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.KeyUp
        btnBuscar_Click(Nothing, Nothing)
    End Sub


End Class