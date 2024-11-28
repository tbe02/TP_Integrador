Public Class FormListaClientesMaestro
    Private _controladorClientes As ControladorClientes = New ControladorClientes()

    Private Sub FormListaClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarClientes()
        ListarFiltros()
        DGVListaClientes.AllowUserToAddRows = False
    End Sub

    Private Sub refrescarLista()
        DGVListaClientes.Rows.Clear()

        ListarClientes()
    End Sub

    Private Sub ListarFiltros()
        CBFiltro.Items.Add("Activos")
        CBFiltro.Items.Add("Eliminados")
        CBFiltro.Items.Add("Todos")
    End Sub

    Private Sub listarClientes()
        DGVListaClientes.Rows.Clear() ' Asegúrate de limpiar filas antes de listar

        For Each cliente In _controladorClientes.ObtenerTodos()
            DGVListaClientes.Rows.Add(cliente.Apellido, cliente.Nombre, cliente.Dni, cliente.Correo, cliente.Telefono, cliente.Estado)
        Next
    End Sub

    Private Sub FiltrarClientes()
        Dim filtro As String = TBBuscarCliente.Text.Trim()
        Dim estadoFiltro As String = If(CBFiltro.SelectedItem IsNot Nothing, CBFiltro.SelectedItem.ToString(), "Todos")


        For Each r As DataGridViewRow In DGVListaClientes.Rows
            r.Visible = False
        Next

        For Each r As DataGridViewRow In DGVListaClientes.Rows
            Dim estado As String = r.Cells("C_Estado").Value.ToString() ' Asegúrate de que "Baja" es el nombre correcto de la columna
            Dim mostrar As Boolean = False

            ' Filtrar según el ComboBox
            If estadoFiltro = "Activos" And estado = "activo" Then
                mostrar = True ' Filtrar activos (baja = No)
            ElseIf estadoFiltro = "Eliminados" And estado = "inactivo" Then
                mostrar = True ' Filtrar eliminados (baja = Si)
            ElseIf estadoFiltro = "Todos" Then
                mostrar = True ' Mostrar todos los equipos
            End If

            ' Verificar si coincide con la búsqueda
            If mostrar Then
                If String.IsNullOrEmpty(filtro) OrElse r.Cells.Cast(Of DataGridViewCell)().Any(Function(c) c.Value IsNot Nothing AndAlso c.Value.ToString().ToUpper().Contains(filtro.ToUpper())) Then
                    r.Visible = True ' Si cumple con la búsqueda, mostrar la fila
                End If
            End If
        Next
    End Sub


    Private Sub IPBBuscarCliente_Click(sender As Object, e As EventArgs) Handles IPBBuscarCliente.Click
        Dim filtro As String = TBBuscarCliente.Text.Trim()
        Dim estadoFiltro As String = If(CBFiltro.SelectedItem IsNot Nothing, CBFiltro.SelectedItem.ToString(), "Todos")


        For Each r As DataGridViewRow In DGVListaClientes.Rows
            r.Visible = False
        Next

        For Each r As DataGridViewRow In DGVListaClientes.Rows
            Dim estado As String = r.Cells("C_Estado").Value.ToString() ' Asegúrate de que "Baja" es el nombre correcto de la columna
            Dim mostrar As Boolean = False

            ' Filtrar según el ComboBox
            If estadoFiltro = "Activos" And estado = "activo" Then
                mostrar = True ' Filtrar activos (baja = No)
            ElseIf estadoFiltro = "Eliminados" And estado = "inactivo" Then
                mostrar = True ' Filtrar eliminados (baja = Si)
            ElseIf estadoFiltro = "Todos" Then
                mostrar = True ' Mostrar todos los equipos
            End If

            ' Verificar si coincide con la búsqueda
            If mostrar Then
                If String.IsNullOrEmpty(filtro) OrElse r.Cells.Cast(Of DataGridViewCell)().Any(Function(c) c.Value IsNot Nothing AndAlso c.Value.ToString().ToUpper().Contains(filtro.ToUpper())) Then
                    r.Visible = True ' Si cumple con la búsqueda, mostrar la fila
                End If
            End If
        Next
    End Sub

    Private Sub ManejarFiltro(sender As Object, e As EventArgs) Handles CBFiltro.SelectedIndexChanged
        FiltrarClientes()
    End Sub

    Private Sub TBBuscarCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles TBBuscarCliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' Simula un clic en el botón de búsqueda
            IPBBuscarCliente_Click(sender, e)
            e.SuppressKeyPress = True ' Evita el sonido de "beep" al presionar Enter
        End If
    End Sub
End Class
