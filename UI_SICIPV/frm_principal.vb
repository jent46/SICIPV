

Public Class frm_principal

    Private Sub frm_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        gbIngreso.Visible = False
        frm_Persona.MdiParent = Me
        frm_Persona.Show()


    End Sub
End Class