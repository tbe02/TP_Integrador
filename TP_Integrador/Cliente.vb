Imports System.Security.Cryptography.X509Certificates

Public Class Cliente
    Public Property Nombre As String
    Public Property Apellido As String
    Public Property Dni As String
    Public Property Correo As String
    Public Property Telefono As String

    Public Shared Clientes As New List(Of Cliente)()


    Public Sub agregarCliente(apellido As String, nombre As String, dni As String, correo As String, telefono As String)

        Dim resultado As DialogResult


        If verificaciones(apellido, nombre, dni, correo, telefono) Then
            resultado = MessageBox.Show("Esta seguro que desea agregar un nuevo cliente?", "Insercion de cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resultado = DialogResult.Yes Then

                Dim nuevoCliente As New Cliente With {
                .Nombre = nombre,
                .Apellido = apellido,
                .Dni = dni,
                .Correo = correo,
                .Telefono = telefono
                }

                Clientes.Add(nuevoCliente)

                MessageBox.Show("Cliente agregado correctamente", "Confirmacion de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        End If




    End Sub

    Public Shared Function obtenerClientes() As List(Of Cliente)
        Return Clientes
    End Function

    Public Shared Function eliminarCliente(clienteAEliminar As Cliente)

        If clienteAEliminar IsNot Nothing Then
            Clientes.Remove(clienteAEliminar)
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

End Class
