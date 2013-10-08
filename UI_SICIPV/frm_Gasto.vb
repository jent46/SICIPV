Imports ENTIDADES
Imports BLL_SICIPV
Imports System.Windows.Forms

Public Class frm_Gasto

    Public usuario As ClsUsuario
    Private idGasto As Integer
    Private operacion As String = ""
    Private mensaje As String = ""
    Dim sep As Char

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

    Private Sub tslModificar_Click(sender As Object, e As EventArgs) Handles tslModificar.Click
        gbBuscar.Enabled = False
        gbBuscar.Visible = False
        gbDatos.Visible = True
        gbDatos.Enabled = True
        pnlBotones.Visible = True
        pnlBotones.Enabled = True
        tslIngresar.Enabled = False
        tslModificar.Enabled = False
        tslConsultar.Enabled = False
        btnAceptar.Enabled = True
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

    Sub limpiarCampos()
        dtpFecha.Value = Date.Now
        txtObservacion.Text = String.Empty
        txtBeneficiario.Text = String.Empty
        txtDetalle.Text = String.Empty
        txtNumFactura.Text = String.Empty
        txtNumDocumento.Text = String.Empty
        txtNumRetencion.Text = String.Empty
        txtValor.Text = String.Empty
    End Sub

    Private Function validarCampos() As Boolean
        Dim resultado As Boolean = True

        ErrorProvider1.Clear()

        If txtObservacion.Text = "" Then
            ErrorProvider1.SetError(txtObservacion, "Observacion es requerido")
            resultado = False
        End If

        If txtBeneficiario.Text = "" Then
            ErrorProvider1.SetError(txtBeneficiario, "Beneficiario es requerido")
            resultado = False
        End If

        If txtDetalle.Text = "" Then
            ErrorProvider1.SetError(txtDetalle, "Detalle es requerido")
            resultado = False
        End If

        If txtValor.Text = "" Then
            ErrorProvider1.SetError(txtValor, "Valor es requerido")
            resultado = False
        End If

        Return resultado
    End Function


    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If validarCampos() Then

            Dim gasto As ClsGasto = New ClsGasto()
            gasto.Observacion = txtObservacion.Text
            gasto.Beneficiario = txtBeneficiario.Text
            gasto.Detelle = txtDetalle.Text
            gasto.NumFactura = txtNumFactura.Text
            gasto.NumDocumento = txtNumDocumento.Text
            gasto.NumRetencion = txtNumRetencion.Text
            gasto.Valor = CDbl(txtValor.Text)


            Select Case operacion
                Case "I"
                    gasto.IdUsuarioCreacion = usuario
                    gasto.IdUsuarioModificacion = usuario
                    gasto.Fecha = dtpFecha.Value
                    If BLL_Gasto.ingresarBD(gasto, mensaje) Then
                        limpiarCampos()
                        gbDatos.Visible = False
                        pnlBotones.Visible = False
                        tslModificar.Enabled = False
                        tslIngresar.Enabled = True
                        tslConsultar.Enabled = True
                    End If
                    MsgBox(mensaje, MsgBoxStyle.Information, My.Settings.NOMBREAPP)

                Case "M"
                    'gasto.IdPersona = idPersona
                    'gasto.IdUsuarioModificacion = usuario
                    'If BLL_Persona.modificarBD(persona, mensaje) Then
                    '    limpiarCampos()
                    'End If
                    MsgBox(mensaje, MsgBoxStyle.Information, My.Settings.NOMBREAPP)

            End Select
        End If
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
        DT = Replace(Data.Text, ".", Sep)
        DT = Replace(DT, ",", sep)
        Label1.Text = CDbl(DT)
        On Error Resume Next
        Data.SelectionStart = 0
        Data.SelectionLength = Len(Data.Text)
        Data.Focus()
    End Sub


    Private Sub frm_Gasto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SetBounds(400, 0, 516, 465)
        sep = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
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
    End Sub

    Private Sub txtValor_TextChanged(sender As Object, e As EventArgs) Handles txtValor.TextChanged
        Call Valida(sender)
    End Sub

    Private Sub txtValor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtValor.KeyDown
        If e.KeyCode = 13 Then
            Aplica(sender)
        End If
    End Sub

   
    Private Sub dgvBusqueda_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBusqueda.CellDoubleClick
        Dim dr As DataGridViewRow
        Dim dt As DataTable
        Try
            dr = dgvBusqueda.Rows(e.RowIndex)
            dt = BLL_Gasto.ConsultarGastoPorId(dr.Cells("Id").Value, mensaje)
            Me.idGasto = dt.Rows(0)("idGasto")
            dtpFecha.Value = dt.Rows(0)("fecha")
            txtObservacion.Text = dt.Rows(0)("observacion")
            txtBeneficiario.Text = dt.Rows(0)("beneficiario")
            txtDetalle.Text = dt.Rows(0)("detalle")
            txtNumFactura.Text = dt.Rows(0)("numFactura")
            txtNumDocumento.Text = dt.Rows(0)("numDocumento")
            txtNumRetencion.Text = dt.Rows(0)("numRetencion")
            txtValor.Text = dt.Rows(0)("valor")
            txtBusqueda.Text = String.Empty
            dgvBusqueda.Columns.Clear()
            tslModificar_Click(Nothing, Nothing)
        Catch ex As Exception
            Me.mensaje = "Debe dar doble click en una fila de la tabla para modificar"
            MsgBox(mensaje, MsgBoxStyle.Information, My.Settings.NOMBREAPP)
        End Try
       
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtBusqueda.Text = "" Then
            ErrorProvider1.SetError(txtBusqueda, "Este campo no puede estar vacio")
        Else
            ErrorProvider1.Clear()
            dgvBusqueda.Columns.Clear()

            Dim dt As DataTable = Nothing

            Try
                dt = BLL_Gasto.ConsultarGastoPorFactura(txtBusqueda.Text, mensaje)

                If dt.Rows.Count <> 0 Then
                    dgvBusqueda.DataSource = dt
                    dgvBusqueda.Columns("Id").Visible = False
                End If
            Catch ex As Exception
            End Try


        End If
    End Sub
End Class