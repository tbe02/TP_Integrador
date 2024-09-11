Imports TP_Integrador.FormLogin

Public Class Autenticacion


    Public Structure Usuario
        Public Nombre As String
        Public Contrasena As String
    End Structure

    Dim usuarios As New List(Of Usuario)
    Sub AgregarUsuarios()
        usuarios.Add(New Usuario With {.Nombre = "admin", .Contrasena = "admin"})
        ' Puedes agregar más usuarios aquí
    End Sub

    Function autenticarLogin(usuarioText As String, contrasenaText As String)
        AgregarUsuarios()

        Dim usuario As String
        Dim password As String
        usuario = usuarioText
        password = contrasenaText

        If (usuario = "" Or password = "") Then
            MessageBox.Show("Debe completar todos los campos.", "Falta de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If verificarPassword(usuario, password) Then
                MessageBox.Show("Ingreso exitoso", "Ingreso de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Ingreso fallido", "Ingreso de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Function

    Function verificarPassword(nombre As String, password As String) As Boolean
        For Each usuario In usuarios
            If usuario.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase) Then
                Return usuario.Contrasena.Equals(password)
            End If
        Next
        Return False

    End Function


End Class
