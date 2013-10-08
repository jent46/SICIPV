Imports ENTIDADES
Imports BLL_SICIPV
Imports System.Windows.Forms
Public Class frm_CuotaValor

    Private operacion As String = ""
    Private mensaje As String = ""
    Private idCuotaValor As Integer

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
        operacion = "I"
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If operacion <> "" Then
            ErrorProvider1.Clear()
            gbDatos.Visible = False
            gbDatos.Enabled = False
            gbBuscar.Visible = False
            gbBuscar.Enabled = False
            pnlBotones.Enabled = False
            pnlBotones.Visible = False
            tslModificar.Enabled = False
            tslIngresar.Enabled = True
            tslConsultar.Enabled = True
            btnAceptar.Enabled = True
            operacion = ""
            limpiarCampos()
        End If

    End Sub

    Private Sub tslModificar_Click(sender As Object, e As EventArgs) Handles tslModificar.Click
        gbDatos.Enabled = True
        gbDatos.Visible = True
        gbBuscar.Visible = False
        gbBuscar.Enabled = False
        pnlBotones.Enabled = True
        pnlBotones.Visible = True
        btnAceptar.Enabled = True
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

    Private Sub limpiarCampos()
        txtNumeroCuota.Text = String.Empty
        txtPorcentajeCuota.Text = String.Empty
        dgvBusqueda.Columns.Clear()
        txtBusqueda.Text = String.Empty
    End Sub

    Private Function validarCampos() As Boolean
        Dim resultado As Boolean = True

        ErrorProvider1.Clear()

        If txtNumeroCuota.Text = "" Then
            ErrorProvider1.SetError(txtNumeroCuota, "El numero de cuota es requerido")
            resultado = False
        End If

        If txtPorcentajeCuota.Text = "" Then
            ErrorProvider1.SetError(txtPorcentajeCuota, "El porcentaje de interes en la cuota es requerido")
            resultado = False
        End If

        Return resultado
    End Function

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If validarCampos() Then
            Dim cuotaValor As ClsCuotaValor = New ClsCuotaValor

            cuotaValor.Cuota = CInt(txtNumeroCuota.Text)
            cuotaValor.InteresCuota = CDbl(txtPorcentajeCuota.Text)


            cuotaValor.FechaModificacion = Date.Now



            Select Case operacion
                Case "I"

                    cuotaValor.FechaCreacion = Date.Now
                    If (BLL_CuotaValor.ingresarBD(cuotaValor, mensaje)) Then
                        limpiarCampos()
                    End If
                    MsgBox(mensaje, MsgBoxStyle.Information, My.Settings.NOMBREAPP)

                Case "M"
                    cuotaValor.InteresCuota = idCuotaValor
                    If BLL_CuotaValor.modificarBD(cuotaValor, mensaje) Then
                        limpiarCampos()
                    End If
                    MsgBox(mensaje, MsgBoxStyle.Information, My.Settings.NOMBREAPP)

            End Select

        End If
    End Sub

    Private Sub dgvBusqueda_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBusqueda.CellDoubleClick
        Dim dr As DataGridViewRow
        Dim dt As DataTable
        Try
            dr = dgvBusqueda.Rows(e.RowIndex)
            dt = BLL_CuotaValor.ConsultarCuotaValorPorId(dr.Cells("Id").Value, mensaje)
            Me.idCuotaValor = dt.Rows(0)("idcuotaValor")
            txtNumeroCuota.Text = dt.Rows(0)("cuota")
            txtPorcentajeCuota.Text = dt.Rows(0)("interesCuota")
            txtBusqueda.Text = String.Empty
            dgvBusqueda.Columns.Clear()
            tslModificar_Click(Nothing, Nothing)
        Catch ex As Exception
            Me.mensaje = "Debe dar doble click en una fila de la tabla para modificar"
            MsgBox(mensaje, MsgBoxStyle.Information, My.Settings.NOMBREAPP)
        End Try

    End Sub

    Private Sub frm_CuotaValor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        If txtBusqueda.Text = "" Then
            ErrorProvider1.SetError(txtBusqueda, "Este campo no puede estar vacio")
        Else
            ErrorProvider1.Clear()
            dgvBusqueda.Columns.Clear()


            Dim dt As DataTable = Nothing

            Try
                dt = BLL_CuotaValor.ConsultarValorCuotaPorCuota(txtBusqueda.Text, mensaje)

                If dt.Rows.Count <> 0 Then
                    dgvBusqueda.DataSource = dt
                    dgvBusqueda.Columns("Id").Visible = False
                End If
            Catch ex As Exception
            End Try


        End If
    End Sub
End Class