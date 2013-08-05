Public Class frmProducto

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
End Class