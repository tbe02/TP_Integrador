Public Class FormListaClientesAdmin


    Private Sub FormListaClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarClientes()
        ListarFiltros()
    End Sub

    Private Sub ListarFiltros()
        CBFiltro.Items.Add("Todos")
        CBFiltro.Items.Add("Apellido")
        CBFiltro.Items.Add("Nombre")
        CBFiltro.Items.Add("DNI")
        CBFiltro.Items.Add("Correo")
        CBFiltro.Items.Add("Telefono")
        CBFiltro.Items.Add("Activo")
        CBFiltro.Items.Add("Inactivo")
    End Sub

    Private Sub refrescarLista()
        DGVListaClientes.Rows.Clear()

        listarClientes()
    End Sub

    Private Sub DGVListaClientes_EditarCliente(sender As Object, e As DataGridViewCellEventArgs) Handles DGVListaClientes.CellContentClick

        If e.ColumnIndex = DGVListaClientes.Columns("C_Editar").Index AndAlso e.RowIndex >= 0 Then

            Dim filaSeleccionada As DataGridViewRow = DGVListaClientes.Rows(e.RowIndex)

            ' obtenemos el cliente que queremos
            Dim cliente As Cliente = Cliente.obtenerClientes(e.RowIndex)

            ' le pasamos los datos del cliente a mi formulario
            Dim formEditar As New FormEditarCliente(cliente, New Action(
                Sub()
                    refrescarLista()
                End Sub)
            )

            ' abrimos el formulario
            formEditar.Show()
        End If
    End Sub

    Private Sub DGVListaClientes_EliminarCliente(sender As Object, e As DataGridViewCellEventArgs) Handles DGVListaClientes.CellContentClick

        If e.ColumnIndex = DGVListaClientes.Columns("C_Eliminar").Index AndAlso e.RowIndex >= 0 Then

            Dim cliente As Cliente = Cliente.obtenerClientes(e.RowIndex)

            Dim resultado As DialogResult = MessageBox.Show("¿Está seguro que desea eliminar este cliente?", "Eliminar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If resultado = DialogResult.Yes Then

                Cliente.eliminarCliente(cliente)

                refrescarLista()

            End If
        End If
    End Sub

    Private Sub listarClientes()

        DGVListaClientes.AllowUserToAddRows = False 'se agregaba una fila demas cuando no habia ningun cliente entonces esto la quita

        Dim listaClientes As List(Of Cliente) = Cliente.obtenerClientes()

        'traes todos tus clientes en tu array de Clientes
        For Each cliente In listaClientes
            DGVListaClientes.Rows.Add(cliente.Apellido, cliente.Nombre, cliente.Dni, cliente.Correo, cliente.Telefono, cliente.Estado)
        Next

    End Sub

    Private Sub FiltrarClientes(sender As Object, e As EventArgs) Handles IPBBuscarCliente.Click
        Dim filtro = CBFiltro.Text
        Dim busqueda = TBBuscarCliente.Text

        Dim clientesFiltrados As List(Of Cliente)

        DGVListaClientes.Rows.Clear()

        Dim clientes = Cliente.obtenerClientes()

        Select Case filtro
            Case "Apellido"
                clientesFiltrados = clientes.Where(Function(cliente) cliente.Apellido.StartsWith(busqueda)).ToList()
            Case "Nombre"
                clientesFiltrados = clientes.Where(Function(cliente) cliente.Nombre.StartsWith(busqueda)).ToList()
            Case "DNI"
                clientesFiltrados = clientes.Where(Function(cliente) cliente.Dni.StartsWith(busqueda)).ToList()
            Case "Correo"
                clientesFiltrados = clientes.Where(Function(cliente) cliente.Correo.StartsWith(busqueda)).ToList()
            Case "Telefono"
                clientesFiltrados = clientes.Where(Function(cliente) cliente.Telefono.StartsWith(busqueda)).ToList()
            Case "Activo"
                clientesFiltrados = clientes.Where(Function(cliente) cliente.Estado = "activo").ToList()
            Case "Inactivo"
                clientesFiltrados = clientes.Where(Function(cliente) cliente.Estado = "inactivo").ToList()
            Case Else
                clientesFiltrados = clientes
        End Select

        For Each cliente In clientesFiltrados
            DGVListaClientes.Rows.Add(cliente.Apellido, cliente.Nombre, cliente.Dni, cliente.Correo, cliente.Telefono, cliente.Estado)
        Next
    End Sub

    Private Sub ManejarFiltro(sender As Object, e As EventArgs) Handles CBFiltro.SelectedIndexChanged
        TBBuscarCliente.Clear()

        Dim filtro = CBFiltro.Text

        If filtro = "Activo" Or filtro = "Inactivo" Then
            FiltrarClientes(sender, e)

            Return
        End If

        refrescarLista()
    End Sub

End Class