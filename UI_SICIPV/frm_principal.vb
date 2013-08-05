
Imports ENTIDADES
Imports BLL_SICIPV


Public Class frm_principal

    Public usuario As ClsUsuario
    Dim mensaje As String = ""
    Private Sub frm_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        usuario = BLL_Usuario.login(txtUsuario.Text, txtClave.Text, mensaje)
        frm_Persona.MdiParent = Me
        frm_Persona.Show()
        If IsNothing(usuario) Then
            MsgBox(mensaje, MsgBoxStyle.Information, My.Settings.NOMBREAPP)
        Else
            gbIngreso.Visible = False
            frm_Persona.MdiParent = Me
            frm_Persona.Show()
        End If

        


    End Sub
End Class