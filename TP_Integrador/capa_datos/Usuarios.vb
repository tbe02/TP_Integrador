Public Class Usuarios

    Public Structure Usuario
        Public nombre As String
        Public password As String
    End Structure

    Private usuarios As New List(Of Usuario)()

    Sub agregar(nombre As String, password As String)
        usuarios.Add(New Usuario With {.nombre = nombre, .password = password})
    End Sub

    Function obtener() As List(Of Usuario)
        Return usuarios
    End Function

    Function verificarPassword(nombre As String, password As String) As Boolean
        For Each usuario In obtener()
            If usuario.nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase) Then
                Return usuario.password.Equals(password)
            End If
        Next

        Return False
    End Function
End Class
