Public Class FormListaClientesMaestro
    Private _controladorClientes As ControladorClientes = New ControladorClientes()

    Private Sub FormListaClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarClientes()
        ListarFiltros()
    End Sub

    Private Sub RefrescarLista()
        DGVListaClientes.Rows.Clear()

        ListarClientes()
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

    Private Sub ListarClientes()
        DGVListaClientes.AllowUserToAddRows = False 'se agregaba una fila demas cuando no habia ningun cliente entonces esto la quita

        Dim listaClientes As List(Of Cliente) = _controladorClientes.ObtenerTodos()

        'traes todos tus clientes en tu array de Clientes
        For Each cliente In listaClientes
            DGVListaClientes.Rows.Add(cliente.Apellido, cliente.Nombre, cliente.Dni, cliente.Correo, cliente.Telefono, cliente.Estado)
        Next

    End Sub

    Private Sub FiltrarClientes(sender As Object, e As EventArgs) Handles IPBBuscarCliente.Click
        Dim filtro = CBFiltro.Text
        Dim busqueda = TBBuscarCliente.Text

        Dim clientes = _controladorClientes.ObtenerTodos()
        Dim clientesFiltrados As List(Of Cliente)

        DGVListaClientes.Rows.Clear()

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

        RefrescarLista()
    End Sub
End Class
