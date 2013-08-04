Public Class frm_Persona

    
    Private estado As String = ""
  
    Private Sub tslIngresar_Click(sender As Object, e As EventArgs) Handles tslIngresar.Click
        gbDatos.Visible = True
        gbDatos.Enabled = True
        gbBuscar.Visible = False
        gbBuscar.Enabled = False
        pnlBotones.Enabled = True
        pnlBotones.Visible = True
        tslModificar.Enabled = False
        estado = "I"
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If estado <> "" Then
            gbDatos.Visible = False
            gbDatos.Enabled = False
            gbBuscar.Visible = False
            gbBuscar.Enabled = False
            pnlBotones.Enabled = False
            pnlBotones.Visible = False
            tslModificar.Enabled = True
            tslIngresar.Enabled = True
            estado = ""
        End If

    End Sub

    Private Sub tslModificar_Click(sender As Object, e As EventArgs) Handles tslModificar.Click
        gbDatos.Visible = False
        gbDatos.Enabled = False
        gbBuscar.Visible = True
        gbBuscar.Enabled = True
        pnlBotones.Enabled = True
        pnlBotones.Visible = True
        tslModificar.Enabled = False
        estado = "M"
    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As Windows.Forms.TreeViewEventArgs)

    End Sub
End Class