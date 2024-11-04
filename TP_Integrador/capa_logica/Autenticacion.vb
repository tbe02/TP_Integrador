Imports TP_Integrador.Usuarios

Public Class Autenticador
    Private usuarios As Usuarios = Usuarios.ObtenerInstancia()

    Public Sub Autenticar(nombreUsuario As String, password As String)
        Dim usuario As Usuarios.Usuario = usuarios.obtenerUno(nombreUsuario)

        If usuario.DNI Is Nothing Then
            Throw New Exception("Usuario no encontrado")
        End If

        Dim elPasswordEsValido As Boolean = usuarios.VerificarContraseña(nombreUsuario, password)

        If Not elPasswordEsValido Then
            Throw New Exception("La contraseña es incorrecta")
        End If
    End Sub
End Class
