Imports TP_Integrador.Usuarios

Public Class Autenticador
    'Private usuarios As New Usuarios()
    Private usuarios As Usuarios


    'Public Sub New()
    'agregarUsuarios() ' Esto es temporal
    'End Sub

    Public Sub New(usuarios As Usuarios)
        Me.usuarios = usuarios
    End Sub


    'Sub agregarUsuarios()
    '    usuarios.agregar("Perez", "Cristian", "44876932", "3794098765", "cristianperez@gmail.com", "maestro", "maestro", "maestro")
    '    usuarios.agregar("Flores", "Fabian", "39876543", "3794123456", "fabian84@gmail.com", "admin", "admin", "administrador")
    '    usuarios.agregar("Pereira", "Rodrigo", "41098321", "3794887766", "rodrigox@gmail.com", "tecnico", "tecnico", "tecnico")

    '    ' Esto es temporal
    'End Sub

    'Function autenticarUsuario(usuario As String, password As String) As Boolean
    '    Return usuarios.verificarPassword(usuario, password)
    'End Function

    'Function obtenerUsuarioAutenticado(usuario As String, password As String) As Usuarios.Usuario
    '    If autenticarUsuario(usuario, password) Then
    '        Return usuarios.obtenerUno(usuario)
    '    Else
    '        Return Nothing
    '    End If
    'End Function


    Public Function Autenticar(nombreUsuario As String, password As String) As Boolean
        Dim usuario As Usuarios.Usuario = usuarios.obtenerUno(nombreUsuario)
        If usuario.NombreUsuario IsNot Nothing Then
            Return usuario.Password.Equals(password)
        End If
        Return False
    End Function

End Class
