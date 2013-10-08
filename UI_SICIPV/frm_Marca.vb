Imports ENTIDADES
Imports BLL_SICIPV
Imports System.Windows.Forms

Public Class frm_Marca

    Private operacion As String = ""
    Private mensaje As String = ""
    Private idMarca As Integer

    Private Sub tslIngresar_Click(sender As Object, e As EventArgs) Handles tslIngresar.Click
        gbDatos.Visible = True
        gbDatos.Enabled = True
        gbBuscar.Visible = False
        gbBuscar.Enabled = False
        pnlBotones.Enabled = True
        pnlBotones.Visible = True
        tslIngresar.Enabled = False
        tslModificar.Enabled = False
        tslConsultar.Enabled = False
        btnAceptar.Enabled = True
        operacion = "I"
    End Sub

    Private Sub tslModificar_Click(sender As Object, e As EventArgs) Handles tslModificar.Click
        gbDatos.Enabled = True
        gbDatos.Visible = True
        gbBuscar.Visible = False
        gbBuscar.Enabled = False
        pnlBotones.Enabled = True
        pnlBotones.Visible = True
        btnAceptar.Enabled = True
        btnAceptar.Visible = True
        tslIngresar.Enabled = False
        tslConsultar.Enabled = False
        tslModificar.Enabled = False
        operacion = "M"
    End Sub

    Private Sub tslConsultar_Click(sender As Object, e As EventArgs) Handles tslConsultar.Click
        gbDatos.Visible = False
        gbDatos.Enabled = False
        gbBuscar.Visible = True
        gbBuscar.Enabled = True
        pnlBotones.Enabled = True
        pnlBotones.Visible = True
        tslIngresar.Enabled = False
        tslModificar.Enabled = False
        tslConsultar.Enabled = False
        btnAceptar.Enabled = False

        operacion = "C"
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        gbBuscar.Enabled = False
        gbBuscar.Visible = False
        gbDatos.Visible = False
        gbBuscar.Enabled = False
        pnlBotones.Visible = False
        pnlBotones.Enabled = False
        tslIngresar.Enabled = True
        tslModificar.Enabled = False
        tslConsultar.Enabled = True
        btnAceptar.Enabled = False
        limpiarCampos()
    End Sub

    Sub limpiarCampos()
        txtMarca.Text = String.Empty
    End Sub

    Private Function validarCampos() As Boolean
        Dim resultado As Boolean = True

        ErrorProvider1.Clear()

        If txtMarca.Text = "" Then
            ErrorProvider1.SetError(txtMarca, "Marca es requerido")
            resultado = False
        End If

        Return resultado
    End Function

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If validarCampos() Then
            Dim marca As ClsMarca = New ClsMarca

            marca.NombreMarca = txtMarca.Text

            Select Case operacion
                Case "I"

                    If BLL_Marca.ingresarBD(marca, mensaje) Then
                        limpiarCampos()
                    End If
                Case "M"
                    marca.IdMarca = Me.idMarca
                    If BLL_Marca.modificarBD(marca, mensaje) Then
                        limpiarCampos()
                    End If
            End Select

            MsgBox(mensaje, MsgBoxStyle.Information, My.Settings.NOMBREAPP)
        End If
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        Dim dt As DataTable = Nothing

        Try
            dt = BLL_Marca.FiltrarMarcas(txtBusqueda.Text, mensaje)

            If dt.Rows.Count <> 0 Then
                dgvBusqueda.DataSource = dt
                dgvBusqueda.Columns("Id").Visible = False
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgvBusqueda_CellContentClick(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvBusqueda.CellDoubleClick
        Try
            Dim dr As DataGridViewRow = dgvBusqueda.Rows(e.RowIndex)
            Dim dt As DataTable = BLL_Marca.ConsultarMarcaPorId(dr.Cells("Id").Value, mensaje)
            Me.idMarca = dt.Rows(0)("idMarca")
            txtMarca.Text = dt.Rows(0)("nombreMarca")
            txtBusqueda.Text = String.Empty
            dgvBusqueda.Columns.Clear()
            tslModificar_Click(Nothing, Nothing)
        Catch ex As Exception
            Me.mensaje = "Debe dar doble click en una fila de la tabla para modificar"
            MsgBox(mensaje, MsgBoxStyle.Information, My.Settings.NOMBREAPP)
        End Try
        
    End Sub
End Class