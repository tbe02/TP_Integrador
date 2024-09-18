Public Class Autenticador
    Private usuarios As New Usuarios()

    Public Sub New()
        agregarUsuarios() ' Esto es temporal
    End Sub

    Sub agregarUsuarios()
        usuarios.agregar("master", "master", "maestro")

        ' Esto es temporal
    End Sub

    Function autenticarUsuario(usuario As String, password As String) As Boolean
        Return usuarios.verificarPassword(usuario, password)
    End Function

    Function obtenerUsuarioAutenticado(usuario As String, password As String) As Usuarios.Usuario
        If autenticarUsuario(usuario, password) Then
            Return usuarios.obtenerUno(usuario)
        Else
            Return Nothing
        End If
    End Function
End Class
