Public Class FormAgregarCliente
    Private _controladorClientes As ControladorClientes = New ControladorClientes()

    Private Sub BAgregarCliente_Click(sender As Object, e As EventArgs) Handles BAgregarCliente.Click
        Dim apellido, nombre, dni, correo, telefono As String

        apellido = TBApellido.Text
        nombre = TBNombre.Text
        dni = TBDNI.Text
        correo = TBCorreo.Text
        telefono = TBTelefono.Text

        Try
            ' Llama a AgregarUno y verifica el resultado
            Dim seAgregoCliente As Boolean = _controladorClientes.AgregarUno(New Cliente With {
                .Apellido = apellido,
                .Nombre = nombre,
                .Dni = dni,
                .Correo = correo,
                .Telefono = telefono
            })

            ' Solo limpia los campos si se agregó correctamente
            If seAgregoCliente Then
                TBApellido.Clear()
                TBNombre.Clear()
                TBDNI.Clear()
                TBCorreo.Clear()
                TBTelefono.Clear()
            End If
        Catch ex As Exception
            MsgBox("Error al agregar el cliente")
        End Try
    End Sub
End Class
