Public Class Sesion
    Private Shared instancia As Sesion = Nothing

    Private usuario As Usuarios.Usuario

    Public Sub GuardarSesion(usuario As Usuarios.Usuario)
        Me.usuario = usuario
    End Sub

    Public Sub EliminarSesion()
        Me.usuario = Nothing
    End Sub

    Public Function ObtenerUsuario() As Usuarios.Usuario
        Return Me.usuario
    End Function

    Public Shared Function ObtenerInstancia() As Sesion
        If instancia Is Nothing Then
            instancia = New Sesion()
        End If

        Return instancia
    End Function
End Class
