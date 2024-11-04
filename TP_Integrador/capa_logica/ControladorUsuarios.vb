Imports System.Text.RegularExpressions

Public Class ControladorUsuarios
    Private usuarios As Usuarios = Usuarios.ObtenerInstancia()

    Public Function ObtenerTodos() As List(Of Usuarios.Usuario)
        Try
            Return usuarios.obtenerTodos()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Class ErroresAlAgregarUno
        Public Const CAMPOS_INCOMPLETOS As String = "Los campos estan incompletos"
        Public Const APELLIDO_SOLO_LETRAS As String = "El apellido solo puede contener letras"
        Public Const NOMBRE_SOLO_LETRAS As String = "El nombre solo puede contener letras"
        Public Const DNI_SOLO_NUMEROS As String = "El DNI solo puede contener numeros"
        Public Const TELEFONO_SOLO_NUMEROS As String = "El telefono solo puede contener numeros"
        Public Const CORREO_INVALIDO As String = "El correo es invalido"
    End Class

    Public Sub AgregarUno(apellido As String, nombre As String, dni As String, telefono As String, correo As String, nombreUsuario As String, password As String, tipo As String)
        Try
            ObtenerLosCamposSonValidos(apellido, nombre, dni, correo, telefono)

            usuarios.agregarUsuario(apellido, nombre, dni, telefono, correo, nombreUsuario, password, tipo)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function ObtenerUnoPorNombreDeUsuario(nombreDeUsuario As String) As Usuarios.Usuario
        Try
            Return usuarios.obtenerUno(nombreDeUsuario)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Sub EliminarUnoPorNombreDeUsuario(nombreDeUsuario As String)
        Try
            usuarios.eliminarUsuario(nombreDeUsuario)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub EditarUnoPorDNI(dni As String, apellido As String, nombre As String, telefono As String, correo As String, nombreUsuario As String, password As String, tipo As String)
        Try
            usuarios.editarUsuario(dni, apellido, nombre, telefono, correo, nombreUsuario, password, tipo)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Function ObtenerElEmailEsValido(email As String) As Boolean
        Dim pattern As String = "^[^@\s]+@[^@\s]+\.[^@\s]+$"
        Dim regex As New Regex(pattern)

        Return regex.IsMatch(email)
    End Function

    Private Function ObtenerSoloContieneLetras(texto As String)
        Dim soloLetras As Boolean = True

        For Each letra As Char In texto
            If Not (Char.IsLetter(letra) OrElse Char.IsWhiteSpace(letra)) Then
                soloLetras = False
                Return False
            End If
        Next

        Return True
    End Function

    Public Function ObtenerLosCamposSonValidos(apellido As String, nombre As String, dni As String, correo As String, telefono As String)
        If (apellido = "" Or nombre = "" Or dni = "" Or correo = "" Or telefono = "") Then
            Throw New Exception(ErroresAlAgregarUno.CAMPOS_INCOMPLETOS)
        End If

        If Not ObtenerSoloContieneLetras(apellido) Then
            Throw New Exception(ErroresAlAgregarUno.APELLIDO_SOLO_LETRAS)
        End If

        If Not ObtenerSoloContieneLetras(nombre) Then
            Throw New Exception(ErroresAlAgregarUno.NOMBRE_SOLO_LETRAS)
        End If

        If Not IsNumeric(dni) Then
            Throw New Exception(ErroresAlAgregarUno.DNI_SOLO_NUMEROS)
        End If

        If Not IsNumeric(telefono) Then
            Throw New Exception(ErroresAlAgregarUno.TELEFONO_SOLO_NUMEROS)
        End If

        If Not ObtenerElEmailEsValido(correo) Then
            Throw New Exception(ErroresAlAgregarUno.CORREO_INVALIDO)
        End If

        Return True
    End Function
End Class
