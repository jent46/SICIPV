Imports MySql.Data.MySqlClient

Public Class DLL_Base
    Friend conn As MySqlConnection

    Sub getConexion()
        If conn Is Nothing Then

            Dim cadena As New MySqlConnectionStringBuilder

            cadena.Database = "base"
            cadena.Server = "localhost"
            cadena.UserID = "root"
            cadena.Password = "1234"
            cadena.Port = "3305"

            conn = New MySqlConnection(cadena.ConnectionString)
        End If

    End Sub

End Class
