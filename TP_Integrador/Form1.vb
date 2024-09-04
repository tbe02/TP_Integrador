Public Structure Usuario
    Public Nombre As String
    Public Contrasena As String
End Structure

Dim usuarios As New List(Of Usuario)

Sub AgregarUsuarios()
    usuarios.Add(New Usuario With {.Nombre = "admin", .Contrasena = "admin"})
    ' Puedes agregar más usuarios aquí
End Sub

Function VerificarPassword(nombre As String, password As String) As Boolean
    For Each usuario In usuarios
        If usuario.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase) Then
            Return usuario.Contrasena.Equals(password)
        End If
    Next
    Return False
End Function

Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        AgregarUsuarios()

        Dim usuario As String
        Dim password As String

        usuario = "" 'Aca va el nombre del TextBox de usuario {nombreTextBox}.Text
        password = "" 'Aca va el nombre del TextBox de password {nombreTextBox}.Text

        If (usuario = "" Or password = "") Then
            MessageBox.Show("Debe completar todos los campos.", "Falta de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If VerificarPassword(usuario, password) Then
                MessageBox.Show("Ingreso exitoso", "Ingreso de usuario", MessageBoxButtons.OK, MessageBoxIcon.Success)
            Else
                MessageBox.Show("Ingreso fallido", "Ingreso de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End if
        End if
    End Sub
End Class

