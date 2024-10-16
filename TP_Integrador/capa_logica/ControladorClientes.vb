Public Class ControladorClientes
    Private clientes As Cliente = New Cliente()

    Public Sub AgregarUno(apellido As String, nombre As String, dni As String, correo As String, telefono As String)
        Try
            clientes.agregarCliente(apellido, nombre, dni, correo, telefono)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function ObtenerTodos() As List(Of Cliente)
        Try
            Return clientes.obtenerClientes()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Sub ActualizarUnoPorDNI(dni As String, actualizado As Cliente)
        Try
            clientes.editarCliente(dni, actualizado)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub EliminarUnoPorDNI(dni As String)
        Try
            clientes.eliminarCliente(New Cliente With {.Dni = dni})
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class
