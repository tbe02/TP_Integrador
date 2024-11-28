Public Class ControladorClientes
    Private _clientes As Cliente = New Cliente()

    Public Function AgregarUno(cliente As Cliente) As Boolean
        Try
            Return _clientes.agregarCliente(cliente.Apellido, cliente.Nombre, cliente.Dni, cliente.Correo, cliente.Telefono)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function ObtenerTodos() As List(Of Cliente)
        Try
            Return _clientes.obtenerClientes().Select(
                Function(cliente)
                    Return New Cliente With {
                        .ID = cliente.ID,
                        .Nombre = cliente.Nombre,
                        .Apellido = cliente.Apellido,
                        .Dni = cliente.Dni,
                        .Correo = cliente.Correo,
                        .Telefono = cliente.Telefono,
                        .Estado = cliente.Estado
                    }
                End Function
            ).ToList()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Sub ActualizarUnoPorDNI(DNI As String, clienteActualizado As Cliente)
        Try
            _clientes.editarCliente(DNI, clienteActualizado)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub EliminarUnoPorDNI(DNI As String)
        Try
            _clientes.eliminarCliente(New Cliente With {.Dni = DNI})
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class
