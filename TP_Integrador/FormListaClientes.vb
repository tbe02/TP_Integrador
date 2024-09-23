Public Class FormListaClientes


    Private Sub FormListaClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarClientes()
    End Sub

    Private Sub DGVListaClientes_EditarCliente(sender As Object, e As DataGridViewCellEventArgs) Handles DGVListaClientes.CellContentClick

        If e.ColumnIndex = DGVListaClientes.Columns("C_Editar").Index AndAlso e.RowIndex >= 0 Then

            Dim filaSeleccionada As DataGridViewRow = DGVListaClientes.Rows(e.RowIndex)

            ' obtenemos el cliente que queremos
            Dim cliente As Cliente = Cliente.obtenerClientes(e.RowIndex)

            ' le pasamos los datos del cliente a mi formulario
            Dim formEditar As New FormEditarCliente(cliente)

            ' abrimos el formulario
            formEditar.Show()

            ' Actualizar el DataGridView después de editar
            filaSeleccionada.Cells("C_Apellido").Value = cliente.Apellido
            filaSeleccionada.Cells("C_Nombre").Value = cliente.Nombre
            filaSeleccionada.Cells("C_DNI").Value = cliente.Dni
            filaSeleccionada.Cells("C_Correo").Value = cliente.Correo
            filaSeleccionada.Cells("C_Telefono").Value = cliente.Telefono


        End If
    End Sub

    Private Sub DGVListaClientes_EliminarCliente(sender As Object, e As DataGridViewCellEventArgs) Handles DGVListaClientes.CellContentClick

        If e.ColumnIndex = DGVListaClientes.Columns("C_Eliminar").Index AndAlso e.RowIndex >= 0 Then

            Dim cliente As Cliente = Cliente.obtenerClientes(e.RowIndex)

            Dim resultado As DialogResult = MessageBox.Show("¿Está seguro que desea eliminar este cliente?", "Eliminar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If resultado = DialogResult.Yes Then

                DGVListaClientes.Rows.RemoveAt(e.RowIndex)
                Cliente.eliminarCliente(cliente)

            End If
        End If
    End Sub

    Private Sub listarClientes()

        DGVListaClientes.AllowUserToAddRows = False 'se agregaba una fila demas cuando no habia ningun cliente entonces esto la quita

        Dim listaClientes As List(Of Cliente) = Cliente.obtenerClientes()

        'traes todos tus clientes en tu array de Clientes
        For Each cliente In listaClientes
            DGVListaClientes.Rows.Add(cliente.Apellido, cliente.Nombre, cliente.Dni, cliente.Correo, cliente.Telefono)
        Next

    End Sub



End Class