
Imports ENTIDADES
Imports BLL_SICIPV
Public Class frm_principal
    Public usuario As ClsUsuario
    Dim mensaje As String = "Usuario correcto"
    Private Sub frm_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbIngreso.Visible = True
        deshabilitar()

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
            ''MsgBox(mensaje, MsgBoxStyle.Information, My.Settings.NOMBREAPP)
            gbIngreso.Visible = False
            txtClave.Text = String.Empty
            txtUsuario.Text = String.Empty
            habilitarAdministrador()
            ''gbIngreso.Visible = False

        End If
        ''frm_Facturacion.MdiParent = Me
        ''frm_Facturacion.Show()
    End Sub

    Private Sub deshabilitar()
        'AdministradorToolStripMenuItem.Enabled = False
    End Sub
    Private Sub habilitarAdministrador()
        'AdministradorToolStripMenuItem.Enabled = True
    End Sub


    

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        frm_Producto.MdiParent = Me
        frm_Producto.Show()
        frm_Producto.usuario = Me.usuario
    End Sub

    Private Sub IngroProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngroProductoToolStripMenuItem.Click
        frm_IngresoProducto.MdiParent = Me
        frm_IngresoProducto.Show()
        frm_IngresoProducto.usuario = Me.usuario
    End Sub

    Private Sub NuevaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaToolStripMenuItem.Click
        frm_Facturacion.MdiParent = Me
        frm_Facturacion.Show()
        frm_Facturacion.usuario = Me.usuario
    End Sub

  
    Private Sub ClienteToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem2.Click
        frm_Persona.MdiParent = Me
        frm_Persona.Show()
        frm_Persona.usuario = Me.usuario
    End Sub

    Private Sub GastoToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles GastoToolStripMenuItem2.Click
        frm_Gasto.MdiParent = Me
        frm_Gasto.Show()
        frm_Gasto.usuario = Me.usuario
    End Sub

    Private Sub NuevoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem1.Click
        frm_Usuario.MdiParent = Me
        frm_Usuario.Show()
    End Sub

    Private Sub CerrarCedionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarCedionToolStripMenuItem.Click
        gbIngreso.Visible = True
        deshabilitar()
    End Sub

    Private Sub InteresPorCuotaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InteresPorCuotaToolStripMenuItem.Click
        frm_CuotaValor.MdiParent = Me
        frm_CuotaValor.Show()
    End Sub
End Class