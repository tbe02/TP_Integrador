Imports System.Text.RegularExpressions
Imports System.Security.Cryptography
Imports System.Text
Imports TP_Integrador.Marcas
Imports TP_Integrador.TiposDeUsuario

Public Class Usuarios
    Private Shared instancia As Usuarios = Nothing

    Public Class Usuario
        Public Apellido As String
        Public Nombre As String
        Public DNI As String
        Public Telefono As String
        Public Correo As String
        Public NombreUsuario As String
        Public Password As String
        Public Tipo As TipoDeUsuario
    End Class

    Private usuarios As New List(Of Usuario)()

    Sub agregar(apellido As String, nombre As String, dni As String, telefono As String, correo As String, nombreUsuario As String, password As String, tipo As String)
        Dim conexion = New BaseDeDatos().obtenerConexion()

        Dim comando = New SqlCommand("INSERT INTO Usuarios (apellido, nombre, DNI, telefono, correo, usuario, contrasena, idTipoDeUsuario) VALUES (@apellido, @nombre, @DNI, @telefono, @correo, @usuario, @contrasena, @idTipoDeUsuario);", conexion)

        comando.Parameters.AddWithValue("@apellido", apellido)
        comando.Parameters.AddWithValue("@nombre", nombre)
        comando.Parameters.AddWithValue("@DNI", dni)
        comando.Parameters.AddWithValue("@telefono", telefono)
        comando.Parameters.AddWithValue("@correo", correo)
        comando.Parameters.AddWithValue("@usuario", nombreUsuario)
        comando.Parameters.AddWithValue("@contrasena", ObtenerContraseñaHasheada(password))
        comando.Parameters.AddWithValue("@idTipoDeUsuario", tipo)

        conexion.Open()
        comando.ExecuteNonQuery()
    End Sub

    Public Shared Function ObtenerContraseñaHasheada(ByVal constraseña As String) As String
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(constraseña)

        Using sha256 As SHA256 = SHA256.Create()
            Dim hashBytes As Byte() = sha256.ComputeHash(bytes)

            Dim hash As New StringBuilder()

            For Each b As Byte In hashBytes
                hash.Append(b.ToString("x2"))
            Next

            Return hash.ToString()
        End Using
    End Function

    Public Function VerificarContraseña(ByVal usuario As String, ByVal constraseña As String) As Boolean
        Dim hashAlmacenado As String = Nothing

        Dim conexion = New BaseDeDatos().obtenerConexion()

        Dim comando As New SqlCommand("SELECT contrasena FROM Usuarios WHERE usuario = @usuario", conexion)

        comando.Parameters.AddWithValue("@usuario", usuario)

        conexion.Open()
        Using lector As SqlDataReader = comando.ExecuteReader()
            If lector.Read() Then
                hashAlmacenado = lector("contrasena").ToString()
            End If
        End Using

        If String.IsNullOrEmpty(hashAlmacenado) Then
            Return False
        End If

        Dim hashIngresado As String = ObtenerContraseñaHasheada(constraseña)

        Return hashAlmacenado.Equals(hashIngresado)
    End Function

    'hice 2 funciones diferentes pq me queria tirar errores cuando queria loguearme a la app si usaba solo esta
    Function agregarUsuario(apellido As String, nombre As String, dni As String, telefono As String, correo As String, nombreUsuario As String, password As String, tipo As String) As Boolean
        Dim resultado As DialogResult

        If verificaciones(apellido, nombre, dni, correo, telefono) Then
            resultado = MessageBox.Show("¿Está seguro que desea agregar un nuevo usuario?", "Inserción de usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resultado = DialogResult.Yes Then
                agregar(apellido, nombre, dni, telefono, correo, nombreUsuario, password, tipo)
                MessageBox.Show("Usuario agregado correctamente", "Confirmación de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return True
            End If
        End If
        Return False
    End Function


    Function obtenerTodos() As List(Of Usuario)
        Dim usuarios As New List(Of Usuario)()

        Dim conexion = New BaseDeDatos().obtenerConexion()
        Dim comando = New SqlCommand("SELECT Usuarios.*, TiposDeUsuario.nombre as nombreTipoDeUsuario FROM Usuarios JOIN TiposDeUsuario ON Usuarios.idTipoDeUsuario = TiposDeUsuario.idTipoDeUsuario;", conexion)

        conexion.Open()

        Using lector As SqlDataReader = comando.ExecuteReader()
            If lector.HasRows Then
                While lector.Read()
                    usuarios.Add(
                        New Usuario With {
                            .Apellido = lector("apellido"),
                            .Nombre = lector("nombre"),
                            .DNI = lector("DNI"),
                            .Telefono = lector("telefono"),
                            .Correo = lector("correo"),
                            .NombreUsuario = lector("usuario"),
                            .Tipo = New TipoDeUsuario() With {.idTipoUsuario = CInt(lector("idTipoDeUsuario")), .nombre = lector("nombreTipoDeUsuario").ToString()}
                        }
                    )
                End While
            End If
        End Using

        Return usuarios
    End Function

    Function obtenerUno(nombreUsuario As String) As Usuario
        Dim usuario As New Usuario()

        Dim conexion = New BaseDeDatos().obtenerConexion()
        Dim comando = New SqlCommand("SELECT Usuarios.*, TiposDeUsuario.nombre as nombreTipoDeUsuario FROM Usuarios JOIN TiposDeUsuario ON Usuarios.idTipoDeUsuario = TiposDeUsuario.idTipoDeUsuario WHERE usuario = @usuario;", conexion)

        comando.Parameters.AddWithValue("@usuario", nombreUsuario)

        conexion.Open()

        Using lector As SqlDataReader = comando.ExecuteReader()
            If lector.HasRows Then
                While lector.Read()
                    usuario = New Usuario With {
                        .Apellido = lector("apellido"),
                        .Nombre = lector("nombre"),
                        .DNI = lector("DNI"),
                        .Telefono = lector("telefono"),
                        .Correo = lector("correo"),
                        .NombreUsuario = lector("usuario"),
                        .Tipo = New TipoDeUsuario() With {.idTipoUsuario = CInt(lector("idTipoDeUsuario")), .nombre = lector("nombreTipoDeUsuario").ToString()}
                    }
                End While
            End If
        End Using

        Return usuario
    End Function

    Function verificarPassword(nombreUsuario As String, password As String) As Boolean
        For Each usuario In obtenerTodos()
            If usuario.NombreUsuario.Equals(nombreUsuario, StringComparison.OrdinalIgnoreCase) Then
                Return usuario.Password.Equals(password)
            End If
        Next

        Return False
    End Function



    Public Sub eliminarUsuario(DNI As String)


        Dim conexion = New BaseDeDatos().obtenerConexion()

        Try
            ' Realiza la conexión a la base de datos
            Dim comando = New SqlCommand("DELETE FROM Usuarios WHERE DNI = @DNI", conexion)

            ' Agrega el parámetro necesario
            comando.Parameters.AddWithValue("@DNI", DNI)

            ' Abre la conexión y ejecuta el comando
            conexion.Open()
            comando.ExecuteNonQuery()

        Catch ex As Exception
            ' Maneja cualquier excepción
            Throw New Exception("Error al eliminar el usuario de la base de datos: " & ex.Message)
        Finally
            ' Cierra la conexión
            If conexion IsNot Nothing AndAlso conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try
    End Sub


    Public Shared Sub editarUsuario(apellido As String, nombre As String, dni As String, telefono As String, correo As String, nombreUsuario As String, password As String, tipo As String)
        ' Establecer conexión con la base de datos
        Dim conexion = New BaseDeDatos().obtenerConexion()

        ' Obtener el ID del tipo de usuario
        Dim idTipoDeUsuario As Integer
        Dim comandoTipo As New SqlCommand("SELECT idTipoDeUsuario FROM TiposDeUsuario WHERE nombre = @nombreTipo", conexion)
        comandoTipo.Parameters.AddWithValue("@nombreTipo", tipo)

        conexion.Open()
        idTipoDeUsuario = Convert.ToInt32(comandoTipo.ExecuteScalar()) ' Obtener el ID del tipo de usuario

        ' Actualizar la información del usuario
        Dim comando = New SqlCommand("UPDATE Usuarios SET apellido = @apellido, nombre = @nombre, DNI = @DNI, telefono = @telefono, correo = @correo, usuario = @usuario, idTipoDeUsuario = @idTipoDeUsuario WHERE usuario = @usuario;", conexion)
        comando.Parameters.AddWithValue("@apellido", apellido)
        comando.Parameters.AddWithValue("@nombre", nombre)
        comando.Parameters.AddWithValue("@DNI", dni)
        comando.Parameters.AddWithValue("@telefono", telefono)
        comando.Parameters.AddWithValue("@correo", correo)
        comando.Parameters.AddWithValue("@usuario", nombreUsuario)
        comando.Parameters.AddWithValue("@idTipoDeUsuario", idTipoDeUsuario) ' Usar el ID numérico

        comando.ExecuteNonQuery()

        ' Actualizar la contraseña si se ha proporcionado
        If Not String.IsNullOrEmpty(password) Then
            Dim comandoParaContraseña = New SqlCommand("UPDATE Usuarios SET contrasena = @contrasena WHERE usuario = @usuario;", conexion)
            comandoParaContraseña.Parameters.AddWithValue("@usuario", nombreUsuario)
            comandoParaContraseña.Parameters.AddWithValue("@contrasena", ObtenerContraseñaHasheada(password))
            comandoParaContraseña.ExecuteNonQuery()
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
        Dim soloLetras As Boolean = True

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

    Public Shared Function ObtenerInstancia() As Usuarios
        If instancia Is Nothing Then
            instancia = New Usuarios()
        End If

        Return instancia
    End Function

End Class
