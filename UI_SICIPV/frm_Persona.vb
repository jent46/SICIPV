﻿Imports BLL_SICIPV
Imports ENTIDADES
Imports System.Windows.Forms

Public Class frm_Persona

    Public usuario As ClsUsuario = frm_principal.usuario
    Private idPersona As Integer
    Private operacion As String = ""
    Private mensaje As String = ""

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
        txtNombre.Text = String.Empty
        txtApellido.Text = String.Empty
        txtCedula.Text = String.Empty
        txtCodigoCliente.Text = String.Empty
        txtTelefono.Text = String.Empty
        txtDireccion.Text = String.Empty
        cbEstadoCivil.SelectedValue = -1
        cbEstado.Checked = False
        dgvBusqueda.Columns.Clear()
        txtBusqueda.Text = String.Empty
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If validarCampos() Then
            Dim persona As ClsPersona = New ClsPersona

            persona.Nombre = txtNombre.Text
            persona.Apellido = txtApellido.Text
            persona.Cedula = txtCedula.Text
            persona.Telefono = txtTelefono.Text
            persona.CodigoPersona = txtCodigoCliente.Text
            persona.Direccion = txtDireccion.Text
            persona.FechaNacimiento = dtpFechaNacimiento.Value.Date

            persona.IdEstadoCivil = New ClsEstadoCivil()
            persona.IdEstadoCivil.IdEstadoCivil = cbEstadoCivil.SelectedValue

            persona.FechaModificacion = Date.Now

            If cbEstado.Checked Then
                persona.Estado = 1
            Else
                persona.Estado = 0
            End If
            Dim dt As DataTable = BLL_Persona.ValidarCedula(persona.Cedula, mensaje)
            Dim count As Integer

            Select Case operacion
                Case "I"
                    persona.IdUsuarioCreacion = usuario
                    persona.IdUsuarioModificacion = usuario
                    persona.FechaCreacion = Now

                    For index = 0 To dt.Rows.Count - 1
                        If (dt.Rows(index)("cedula") = persona.Cedula) Then
                            count = +1
                            mensaje = "Numero de cedula ya se encuentra registrado"
                        End If
                    Next



                    If count = 0 Then
                        If (BLL_Persona.ingresarBD(persona, mensaje)) Then
                            limpiarCampos()
                        End If
                    End If


                    MsgBox(mensaje, MsgBoxStyle.Information, My.Settings.NOMBREAPP)

                Case "M"
                    persona.IdPersona = idPersona
                    persona.IdUsuarioModificacion = usuario
                    If BLL_Persona.modificarBD(persona, mensaje) Then
                        limpiarCampos()
                    End If
                    MsgBox(mensaje, MsgBoxStyle.Information, My.Settings.NOMBREAPP)

            End Select

        End If
    End Sub

    Private Function validarCampos() As Boolean
        Dim resultado As Boolean = True

        ErrorProvider1.Clear()

        If txtNombre.Text = "" Then
            ErrorProvider1.SetError(txtNombre, "Nombre es requerido")
            resultado = False
        End If

        If txtNombre.Text = "" Then
            ErrorProvider1.SetError(txtNombre, "Nombre es requerido")
            resultado = False
        End If

        If txtApellido.Text = "" Then
            ErrorProvider1.SetError(txtApellido, "Apellido es requerido")
            resultado = False
        End If

        If txtCodigoCliente.Text = "" Then
            ErrorProvider1.SetError(txtCodigoCliente, "CodigoCliente es requerido")
            resultado = False
        End If
        'If (txtCedula.Text.Length <> 10) Then
        '    MessageBox.Show("LA CEDULA CONTIENE 10 DIGITOS", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    txtCedula.Text = String.Empty
        '    ErrorProvider1.SetError(txtCedula, "Cedula es requerido")
        '    Return False
        'End If
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

        If dtpFechaNacimiento.Value.Date = Now Then
            ErrorProvider1.SetError(dtpFechaNacimiento, "Fecha de Nacimiento es requerido")
            resultado = False
        End If

        If cbEstadoCivil.SelectedIndex = -1 Then
            ErrorProvider1.SetError(cbEstadoCivil, "Estado Civil es requerido")
            resultado = False
        End If

        Return resultado
    End Function

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        If txtBusqueda.Text = "" Then
            ErrorProvider1.SetError(txtBusqueda, "Este campo no puede estar vacio")
        ElseIf rbCedula.Checked And Not Integer.TryParse(txtBusqueda.Text, New Integer) Then
            ErrorProvider1.SetError(txtBusqueda, "La cedula debe ser un numero")
        Else
            ErrorProvider1.Clear()
            dgvBusqueda.Columns.Clear()
            Dim dt As DataTable = Nothing

            If rbCedula.Checked Then
                dt = BLL_Persona.ConsultarPersonasPorCedula(txtBusqueda.Text, mensaje)
            ElseIf rbNombre.Checked Then
                dt = BLL_Persona.ConsultarPersonasPorNombre(txtBusqueda.Text, mensaje)
            End If
            Try
                If dt.Rows.Count <> 0 Then
                    dgvBusqueda.DataSource = dt
                    dgvBusqueda.Columns("Id").Visible = False
                Else
                    MsgBox(mensaje, MsgBoxStyle.Information, My.Settings.NOMBREAPP)
                End If
            Catch
                MsgBox(mensaje, MsgBoxStyle.Information, My.Settings.NOMBREAPP)
            End Try

        End If

    End Sub

    Private Sub frm_Persona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SetBounds(400, 0, 516, 465)
        cbEstadoCivil.DataSource = BLL_EstadoCivil.ConsultarEstadoCivilTodos(mensaje)
        cbEstadoCivil.DisplayMember = "descripcion"
        cbEstadoCivil.ValueMember = "idEstadoCivil"
        cbEstadoCivil.SelectedIndex = -1
    End Sub


    Private Sub rbCedula_CheckedChanged(sender As Object, e As EventArgs) Handles rbCedula.CheckedChanged, rbNombre.CheckedChanged
        txtBusqueda.Text = String.Empty
    End Sub

    Private Sub dgvBusqueda_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBusqueda.CellDoubleClick

        Dim dr As DataGridViewRow
        Dim dt As DataTable

        Try
            dr = dgvBusqueda.Rows(e.RowIndex)
            dt = BLL_Persona.ConsultarPersonasPorId(dr.Cells("Id").Value, mensaje)
            idPersona = dt.Rows(0)("idPersona")
            txtNombre.Text = dt.Rows(0)("nombre")
            txtApellido.Text = dt.Rows(0)("apellido")
            txtCedula.Text = dt.Rows(0)("cedula")
            txtDireccion.Text = dt.Rows(0)("direccion")
            txtTelefono.Text = dt.Rows(0)("telefono")
            cbEstadoCivil.SelectedValue = dt.Rows(0)("idEstadoCivil")
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

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        btnBuscar_Click(Nothing, Nothing)
    End Sub
End Class