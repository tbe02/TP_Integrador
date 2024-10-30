Imports System.Security.Cryptography.X509Certificates
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions


Public Class Cliente

    Public Property ID As Integer
    Public Property Nombre As String
    Public Property Apellido As String
    Public Property Dni As String
    Public Property Correo As String
    Public Property Telefono As String

    Public Property Estado As String

    Public Shared Clientes As New List(Of Cliente)()

    Public ReadOnly Property DNI_Nombre As String
        Get
            Return $"{Dni} - {Nombre}"
        End Get
    End Property


    Public Sub editarCliente(DNICliente As String, clienteEditado As Cliente)
        Try
            Dim conexion = New BaseDeDatos().obtenerConexion()

            Dim comando = New SqlCommand("UPDATE Clientes SET nombres = '" & clienteEditado.Nombre & "', apellidos = '" & clienteEditado.Apellido & "', DNI = '" & clienteEditado.Dni & "', correo = '" & clienteEditado.Correo & "', telefono = '" & clienteEditado.Telefono & "', estado = '" & clienteEditado.Estado & "' WHERE DNI = '" & DNICliente & "'", conexion)

            conexion.Open()

            comando.ExecuteNonQuery()

            MessageBox.Show("Cliente editado correctamente", "Edicion de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As SqlException
            If ex.Number = 2627 Or ex.Number = 2601 Then
                Dim claveRepetida As String = ""

                If ex.Message.Contains(clienteEditado.Dni) Then
                    claveRepetida = "DNI (" & clienteEditado.Dni & ")"
                ElseIf ex.Message.Contains(clienteEditado.Correo) Then
                    claveRepetida = "Correo (" & clienteEditado.Correo & ")"
                End If

                MessageBox.Show("Usted intento ingresar un cliente con datos que identifican a un cliente ya existente, este dato fue: " & claveRepetida, "Error al agregar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function agregarCliente(apellido As String, nombre As String, dni As String, correo As String, telefono As String)

        Dim resultado As DialogResult

        If verificaciones(apellido, nombre, dni, correo, telefono) Then
            resultado = MessageBox.Show("Esta seguro que desea agregar un nuevo cliente?", "Insercion de cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resultado = DialogResult.Yes Then

                Try
                    Dim conexion = New BaseDeDatos().obtenerConexion()

                    Dim comando = New SqlCommand("INSERT INTO Clientes (DNI, nombres, apellidos, telefono, correo) VALUES ('" & dni & "', '" & nombre & "', '" & apellido & "', '" & telefono & "', '" & correo & "');", conexion)

                    conexion.Open()

                    comando.ExecuteNonQuery()

                    MessageBox.Show("Cliente agregado correctamente", "Confirmacion de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Return True
                Catch ex As SqlException
                    If ex.Number = 2627 Or ex.Number = 2601 Then
                        Dim claveRepetida As String = ""

                        If ex.Message.Contains(dni) Then
                            claveRepetida = "DNI (" & dni & ")"
                        ElseIf ex.Message.Contains(correo) Then
                            claveRepetida = "Correo (" & correo & ")"
                        End If

                        MessageBox.Show("Usted intento ingresar un cliente con datos que identifican a un cliente ya existente, este dato fue: " & claveRepetida, "Error al agregar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            End If

        End If

        Return False




    End Function

    Public Shared Function obtenerClientes() As List(Of Cliente)
        Dim clientes As New List(Of Cliente)()

        Try
            Dim conexion = New BaseDeDatos().obtenerConexion()

            Dim comando = New SqlCommand("SELECT * FROM Clientes;", conexion)

            conexion.Open()

            Using lector As SqlDataReader = comando.ExecuteReader()
                If lector.HasRows Then
                    While lector.Read()
                        clientes.Add(
                            New Cliente With {
                                .Nombre = lector("nombres").ToString(),
                                .ID = lector("idCliente").ToString(),
                                .Apellido = lector("apellidos").ToString(),
                                .Dni = lector("DNI").ToString(),
                                .Correo = lector("correo").ToString(),
                                .Telefono = lector("telefono").ToString(),
                                .Estado = lector("estado").ToString()
                            }
                        )
                    End While
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.InnerException.ToString())
        End Try

        Return clientes
    End Function

    Public Shared Function eliminarCliente(clienteAEliminar As Cliente)

        If clienteAEliminar IsNot Nothing Then
            Dim conexion = New BaseDeDatos().obtenerConexion()

            Dim comando = New SqlCommand("UPDATE Clientes SET estado = 'inactivo' WHERE DNI = '" & clienteAEliminar.Dni & "';", conexion)

            conexion.Open()

            comando.ExecuteNonQuery()

            Return True ' indica que se eliminó correctamente
        Else
            Return False ' indica que no se encontró el cliente
        End If

    End Function


    Private Function verificaciones(apellido As String, nombre As String, dni As String, correo As String, telefono As String)


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
