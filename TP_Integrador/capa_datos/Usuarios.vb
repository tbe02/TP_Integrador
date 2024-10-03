Imports System.Text.RegularExpressions

Public Class Usuarios

    Public Class Usuario
        Public Apellido As String
        Public Nombre As String
        Public DNI As String
        Public Telefono As String
        Public Correo As String
        Public NombreUsuario As String
        Public Password As String
        Public Tipo As String
    End Class

    Private usuarios As New List(Of Usuario)()

    Sub agregar(apellido As String, nombre As String, dni As String, telefono As String, correo As String, nombreUsuario As String, password As String, tipo As String)
        usuarios.Add(New Usuario With {.Apellido = apellido, .Nombre = nombre, .DNI = dni, .Telefono = telefono, .Correo = correo, .NombreUsuario = nombreUsuario, .Password = password, .Tipo = tipo})
    End Sub


    'hice 2 funciones diferentes pq me queria tirar errores cuando queria loguearme a la app si usaba solo esta
    Function agregarUsuario(apellido As String, nombre As String, dni As String, telefono As String, correo As String, nombreUsuario As String, password As String, tipo As String)

        Dim resultado As DialogResult

        If verificaciones(apellido, nombre, dni, correo, telefono) Then
            resultado = MessageBox.Show("Esta seguro que desea agregar un nuevo usuario?", "Insercion de usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resultado = DialogResult.Yes Then
                agregar(apellido, nombre, dni, telefono, correo, nombreUsuario, password, tipo)
                MessageBox.Show("Usuario agregado correctamente", "Confirmacion de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return True
            End If
        End If
        Return False

    End Function

    Function obtenerTodos() As List(Of Usuario)
        Return usuarios
    End Function


    Function obtenerUno(nombreUsuario As String) As Usuario
        Return obtenerTodos().Find(Function(usuario) usuario.NombreUsuario = nombreUsuario)
    End Function



    Function verificarPassword(nombreUsuario As String, password As String) As Boolean
        For Each usuario In obtenerTodos()
            If usuario.NombreUsuario.Equals(nombreUsuario, StringComparison.OrdinalIgnoreCase) Then
                Return usuario.Password.Equals(password)
            End If
        Next

        Return False
    End Function

    Sub eliminarUsuario(dni As String)
        Dim usuarioAEliminar = usuarios.Find(Function(u) u.DNI = dni)
        If usuarioAEliminar.DNI IsNot Nothing Then
            usuarios.Remove(usuarioAEliminar)
        End If
    End Sub

    Public Sub editarUsuario(dni As String, apellido As String, nombre As String, telefono As String, correo As String, nombreUsuario As String, password As String, tipo As String)
        ' Buscar el usuario que se va a editar usando el DNI
        Dim usuario = usuarios.Find(Function(u) u.DNI = dni)
        If (usuario IsNot Nothing) Then

            usuario.Apellido = apellido
            usuario.Nombre = nombre
            usuario.Telefono = telefono
            usuario.Correo = correo
            usuario.NombreUsuario = nombreUsuario
            usuario.Password = password
            usuario.Tipo = tipo


        End If

    End Sub

    Public Function verificaciones(apellido As String, nombre As String, dni As String, correo As String, telefono As String)


        If (apellido = "" Or nombre = "" Or dni = "" Or correo = "" Or telefono = "") Then
            MessageBox.Show("Debe completar todos los campos", "Falta de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Else

            If validarLetra(apellido) = False Then
                MessageBox.Show("Apellido solo acepta letras", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            If validarLetra(nombre) = False Then
                MessageBox.Show("Nombre solo acepta letras", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            If Not IsNumeric(dni) Then
                MessageBox.Show("DNI solo acepta numeros", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            If Not IsNumeric(telefono) Then
                MessageBox.Show("Telefono solo acepta numeros", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            If Not emailValido(correo) Then
                MessageBox.Show("El correo electrónico no es válido.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        End If

        Return True

    End Function

    Private Function validarLetra(texto As String)

        Dim soloLetras As Boolean
        soloLetras = True


        For Each letra As Char In texto
            If Not (Char.IsLetter(letra) OrElse Char.IsWhiteSpace(letra)) Then
                soloLetras = False
                Return False
            End If
        Next
        Return True
    End Function

    Private Function emailValido(email As String) As Boolean
        ' Definir la expresión regular para validar el correo electrónico
        Dim pattern As String = "^[^@\s]+@[^@\s]+\.[^@\s]+$"
        Dim regex As New Regex(pattern)
        Return regex.IsMatch(email)
    End Function

End Class
