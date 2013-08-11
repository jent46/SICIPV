Imports BLL_SICIPV
Imports ENTIDADES

Public Class frm_Usuario

    Private operacion As String = ""
    Private mensaje As String = ""

    Private Sub tslIngresar_Click(sender As Object, e As EventArgs) Handles tslIngresar.Click
        gbDatos.Enabled = True
        gbDatos.Visible = True
        gbBuscar.Visible = False
        gbBuscar.Visible = False
        pnlBotones.Enabled = True
        pnlBotones.Visible = True
        btnAceptar.Enabled = True
        tslIngresar.Enabled = False
        tslConsultar.Enabled = False
        tslModificar.Enabled = False
        operacion = "I"
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If validarCampos() Then
            ErrorProvider1.Clear()
            Dim usuario As ClsUsuario = New ClsUsuario
            usuario.Nombre = txtNombre.Text
            usuario.Contrasena = txtcontrasena.Text
            usuario.Usuario = txtUsuario.Text
            usuario.FechaModificacion = Now

            If cbEstado.Checked Then
                usuario.Estado = 1
            Else
                usuario.Estado = 0
            End If

            Select Case operacion
                Case "I"
                    usuario.FechaCreacion = Now
                    If BLL_Usuario.ingresarBD(usuario, mensaje) Then

                    End If
                Case "M"
                    If BLL_Usuario.modificarBD(usuario, mensaje) Then

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

        If txtUsuario.Text = "" Then
            ErrorProvider1.SetError(txtUsuario, "Usuario es requerido")
            resultado = False
        End If

        If txtcontrasena.Text = "" Then
            ErrorProvider1.SetError(txtcontrasena, "Contrasena es requerido")
            resultado = False
        End If

        If cbRol.SelectedIndex <> -1 Then
            ErrorProvider1.SetError(cbRol, "Rol es requerido")
            resultado = False
        End If
       
        Return resultado

    End Function

    Private Sub tslModificar_Click(sender As Object, e As EventArgs) Handles tslModificar.Click
        gbDatos.Enabled = True
        gbDatos.Visible = True
        gbBuscar.Visible = False
        gbBuscar.Visible = False
        pnlBotones.Enabled = True
        pnlBotones.Visible = True
        btnAceptar.Enabled = True
        tslIngresar.Enabled = False
        tslConsultar.Enabled = False
        tslModificar.Enabled = False
        operacion = "M"
    End Sub

    Private Sub tslConsultar_Click(sender As Object, e As EventArgs) Handles tslConsultar.Click
        gbDatos.Enabled = False
        gbDatos.Visible = False
        gbBuscar.Visible = True
        gbBuscar.Visible = True
        pnlBotones.Enabled = True
        pnlBotones.Visible = True
        btnAceptar.Enabled = False
        tslIngresar.Enabled = False
        tslConsultar.Enabled = False
        tslModificar.Enabled = False
        operacion = "C"
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        gbDatos.Enabled = False
        gbDatos.Visible = False
        gbBuscar.Visible = False
        gbBuscar.Visible = False
        pnlBotones.Enabled = False
        pnlBotones.Visible = False
        btnAceptar.Enabled = False
        tslIngresar.Enabled = True
        tslConsultar.Enabled = True
        tslModificar.Enabled = False
        operacion = "C"
    End Sub

    Private Sub frm_Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SetBounds(0, 0, 512, 451)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtBusqueda.Text = "" Then
            ErrorProvider1.SetError(txtBusqueda, "Este campo no puede estar vacio")
        Else
            ErrorProvider1.Clear()
            dgvBusqueda.Columns.Clear()
            dgvBusqueda.Rows.Clear()
            Dim dt As DataTable = Nothing

            If rbUsuario.Checked Then
                dt = BLL_Usuario.ConsultarUsuarioPorUsuario(txtBusqueda.Text, mensaje)
            ElseIf rbNombre.Checked Then
                dt = BLL_Usuario.ConsultarUsuarioPorNombre(txtBusqueda.Text, mensaje)
            End If

            If IsNothing(dt) Then
                dgvBusqueda.DataSource = dt
            Else
                MsgBox(mensaje, MsgBoxStyle.Information, My.Settings.NOMBREAPP)
            End If
        End If
    End Sub
End Class