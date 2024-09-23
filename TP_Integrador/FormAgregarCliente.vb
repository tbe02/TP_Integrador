
Imports System.Net
Imports System.Runtime.InteropServices.JavaScript.JSType

Public Class FormAgregarCliente


    Private Sub BAgregarCliente_Click(sender As Object, e As EventArgs) Handles BAgregarCliente.Click
        Dim apellido, nombre, dni, correo, telefono As String

        apellido = TBApellido.Text
        nombre = TBNombre.Text
        dni = TBDNI.Text
        correo = TBCorreo.Text
        telefono = TBTelefono.Text

        Dim cliente As New Cliente()

        cliente.agregarCliente(apellido, nombre, dni, correo, telefono)

        TBApellido.Clear()
        TBNombre.Clear()
        TBDNI.Clear()
        TBCorreo.Clear()
        TBTelefono.Clear()


    End Sub






End Class