
Imports ENTIDADES
Imports BLL_SICIPV
Public Class frm_principal
    Public usuario As ClsUsuario
    Dim mensaje As String = "Usuario correcto"
    Private Sub frm_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbIngreso.Visible = True
        ''deshabilitar()
        'deshabilitar()

    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        mensaje = ""
        usuario = BLL_Usuario.login(txtUsuario.Text, txtClave.Text, mensaje)
        ''frm_Persona.MdiParent = Me
        ''frm_Persona.Show()
        If IsNothing(usuario) Then
            MsgBox(mensaje, MsgBoxStyle.Critical, My.Settings.NOMBREAPP)
            txtClave.Text = String.Empty
            txtUsuario.Text = String.Empty
        Else
            MsgBox(mensaje, MsgBoxStyle.Information, My.Settings.NOMBREAPP)
            gbIngreso.Visible = False
            habilitarAdministrador()
            ''gbIngreso.Visible = False

        End If
        ''frm_Facturacion.MdiParent = Me
        ''frm_Facturacion.Show()
    End Sub

    Private Sub FacturacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturacionToolStripMenuItem.Click
        frm_Facturacion.MdiParent = Me
        frm_Facturacion.Show()

    End Sub

    Private Sub ClienteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem1.Click
        frm_Persona.MdiParent = Me
        frm_Persona.Show()
        frm_Persona.usuario = Me.usuario
    End Sub

    Private Sub ProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductoToolStripMenuItem.Click
        frm_Producto.MdiParent = Me
        frm_Producto.Show()
        frm_Producto.usuario = Me.usuario
    End Sub

    Private Sub UsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuarioToolStripMenuItem.Click
        frm_Usuario.MdiParent = Me
        frm_Usuario.Show()
    End Sub

    Private Sub deshabilitar()
        AdministradorToolStripMenuItem.Enabled = False
    End Sub
    Private Sub habilitarAdministrador()
        AdministradorToolStripMenuItem.Enabled = True
    End Sub
End Class