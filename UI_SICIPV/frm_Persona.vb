Imports BLL_SICIPV
Imports ENTIDADES

Public Class frm_Persona


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
        End If

    End Sub


    Private Sub tslModificar_Click(sender As Object, e As EventArgs) Handles tslModificar.Click
        gbDatos.Visible = False
        gbDatos.Enabled = False
        gbBuscar.Visible = True
        gbBuscar.Enabled = True
        pnlBotones.Enabled = True
        pnlBotones.Visible = True
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

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If validarCampos() Then
            Dim persona As ClsPersona = New ClsPersona
            persona.Nombre = txtNombre.Text
            persona.Apellido = txtApellido.Text
            persona.Cedula = txtCedula.Text
            persona.Direccion = txtDireccion.Text
            persona.Telefono = txtTelefono.Text
            persona.FechaNacimiento = dtpFechaNacimiento.Value.Date
            persona.IdEstadoCivil = cbEstadoCivil.SelectedValue
            persona.FechaModificacion = Now

            If cbEstado.Checked Then
                persona.Estado = 1
            Else
                persona.Estado = 0
            End If

            Select Case operacion
                Case "I"
                    persona.FechaCreacion = Now
                    If BLL_Persona.ingresarBD(persona, mensaje) Then

                    End If
                Case "M"
                    If BLL_Persona.modificarBD(persona, mensaje) Then

                    End If
            End Select

            MsgBox(mensaje, MsgBoxStyle.Information, My.Settings.NOMBREAPP)

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

        If dtpFechaNacimiento.Value.Date = Now Then
            ErrorProvider1.SetError(dtpFechaNacimiento, "Fecha de Nacimiento es requerido")
            resultado = False
        End If

        If cbEstadoCivil.SelectedIndex <> -1 Then
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
            dgvBusqueda.Rows.Clear()
            Dim dt As DataTable = Nothing

            If rbCedula.Checked Then
                dt = BLL_Persona.ConsultarPersonasPorCedula(txtBusqueda.Text, mensaje)
            ElseIf rbNombre.Checked Then
                dt = BLL_Persona.ConsultarPersonasPorNombre(txtBusqueda.Text, mensaje)
            End If

            If IsNothing(dt) Then
                dgvBusqueda.DataSource = dt
            Else
                MsgBox(mensaje, MsgBoxStyle.Information, My.Settings.NOMBREAPP)
            End If
        End If

    End Sub


    Private Sub frm_Persona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SetBounds(0, 0, 527, 482)
    End Sub

End Class