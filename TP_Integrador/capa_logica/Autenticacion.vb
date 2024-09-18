Public Class Autenticador
    Private usuarios As New Usuarios()

    Sub agregarUsuarios()
        usuarios.agregar("admin", "admin")

        ' Esto es temporal
    End Sub

    Function autenticarUsuario(usuario As String, password As String) As Boolean
        agregarUsuarios() ' Esto es temporal

        Return usuarios.verificarPassword(usuario, password)
    End Function

    Function obtenerUsuarioAutenticado(usuario As String, password As String) As Usuarios.Usuario

    End Function
End Class
