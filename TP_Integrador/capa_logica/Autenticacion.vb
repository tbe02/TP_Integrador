Public Class Autenticador
    Private usuarios As New Usuarios()

    Sub agregarUsuarios()
        usuarios.agregar("admin", "admin")

        ' Esto es temporal
    End Sub

    Function autenticarUsuario(usuario As String, password As String)
        agregarUsuarios() ' Esto es temporal

        Return usuarios.verificarPassword(usuario, password)
    End Function
End Class
