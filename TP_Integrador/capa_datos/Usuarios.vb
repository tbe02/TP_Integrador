Public Class Usuarios

    Public Structure Usuario
        Public nombre As String
        Public password As String
        Public tipo As String
    End Structure

    Private usuarios As New List(Of Usuario)()

    Sub agregar(nombre As String, password As String, tipo As String)
        usuarios.Add(New Usuario With {.nombre = nombre, .password = password, .tipo = tipo})
    End Sub

    Function obtenerTodos() As List(Of Usuario)
        Return usuarios
    End Function

    Function obtenerUno(nombre As String) As Usuario
        Return obtenerTodos().Find(Function(usuario) usuario.nombre = nombre)
    End Function

    Function verificarPassword(nombre As String, password As String) As Boolean
        For Each usuario In obtenerTodos()
            If usuario.nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase) Then
                Return usuario.password.Equals(password)
            End If
        Next

        Return False
    End Function
End Class
