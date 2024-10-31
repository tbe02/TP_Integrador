Public Class FormListaEquiposTecnico
    Private _controladorEquipos As ControladorEquipos = New ControladorEquipos()

    Private Sub FormListaEquipos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarEquipos()
        ListarFiltros()

        DGVListaEquipos.AllowUserToAddRows = False
    End Sub

    Private Sub ListarFiltros()
        CBFiltro.Items.Add("Activos")
        CBFiltro.Items.Add("Eliminados")
        CBFiltro.Items.Add("Todos")
    End Sub

    Private Sub RefrescarLista()
        DGVListaEquipos.Rows.Clear()

        ListarEquipos()
    End Sub

    Private Sub ListarEquipos()
        DGVListaEquipos.Rows.Clear() ' Asegúrate de limpiar filas antes de listar

        For Each equipo In _controladorEquipos.ObtenerTodos()
            Dim descripcionEstado As String = Equipos.ObtenerDescripcionEstado(equipo.Estado)
            DGVListaEquipos.Rows.Add(equipo.Cliente.Nombre, equipo.Cliente.Dni, equipo.TipoEquipo.Nombre, equipo.NumeroSerie, equipo.Marca.nombre, equipo.Modelo.nombre, equipo.Enciende, descripcionEstado, equipo.Baja)
        Next

        ' Ordena el DataGridView por Nombre Cliente (suponiendo que el nombre del cliente es la primera columna)
        DGVListaEquipos.Sort(DGVListaEquipos.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub AtraparEventosDeBotones(sender As Object, e As DataGridViewCellEventArgs) Handles DGVListaEquipos.CellContentClick
        If e.ColumnIndex = DGVListaEquipos.Columns("C_Editar").Index AndAlso e.RowIndex >= 0 Then
            Dim filaSeleccionada As DataGridViewRow = DGVListaEquipos.Rows(e.RowIndex)

            Dim equipo As Equipos.Equipo = _controladorEquipos.ObtenerTodos(e.RowIndex)

            ' le pasamos los datos del cliente a mi formulario
            Dim formEditar As New FormEditarEquipo(equipo, New Action(
                Sub()
                    'refrescarLista()
                End Sub)
            )

            ' abrimos el formulario
            formEditar.Show()
        End If

        If e.ColumnIndex = DGVListaEquipos.Columns("C_InfomacionEquipo").Index AndAlso e.RowIndex >= 0 Then
            Dim filaSeleccionada As DataGridViewRow = DGVListaEquipos.Rows(e.RowIndex)

            Dim equipo As Equipos.Equipo = _controladorEquipos.ObtenerTodos(e.RowIndex)

            ' le pasamos los datos del cliente a mi formulario
            Dim formInfo As New FormInfoEquipo(equipo)

            ' abrimos el formulario
            formInfo.Show()
        End If
    End Sub

    Private Sub FiltrarBusqueda()
        Dim filtro As String = TBBuscarEquipo.Text.Trim()
        Dim estadoFiltro As String = If(CBFiltro.SelectedItem IsNot Nothing, CBFiltro.SelectedItem.ToString(), "Todos")

        ' Primero, oculta todas las filas
        For Each r As DataGridViewRow In DGVListaEquipos.Rows
            r.Visible = False
        Next

        ' Luego, muestra solo las filas que coinciden con el filtro del ComboBox y la búsqueda
        For Each r As DataGridViewRow In DGVListaEquipos.Rows
            Dim estado As String = r.Cells("C_Baja").Value.ToString() ' Asegúrate de que "Baja" es el nombre correcto de la columna
            Dim mostrar As Boolean = False

            ' Filtrar según el ComboBox
            If estadoFiltro = "Activos" And estado = "No" Then
                mostrar = True ' Filtrar activos (baja = No)
            ElseIf estadoFiltro = "Eliminados" And estado = "Si" Then
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





    Private Sub IPBBuscarEquipo_Click(sender As Object, e As EventArgs) Handles IPBBuscarEquipo.Click
        Dim filtro As String = TBBuscarEquipo.Text.Trim()
        Dim estadoFiltro As String = If(CBFiltro.SelectedItem IsNot Nothing, CBFiltro.SelectedItem.ToString(), "Todos")

        ' Primero, oculta todas las filas
        For Each r As DataGridViewRow In DGVListaEquipos.Rows
            r.Visible = False
        Next

        ' Luego, muestra solo las filas que coinciden con la búsqueda y el estado
        For Each r As DataGridViewRow In DGVListaEquipos.Rows
            Dim estado As String = r.Cells("C_Baja").Value.ToString() ' Asegúrate de que "Baja" es el nombre correcto de la columna
            Dim mostrar As Boolean = False

            ' Filtrar según el ComboBox
            If estadoFiltro = "Activos" And estado = "No" Then
                mostrar = True ' Filtrar activos (baja = No)
            ElseIf estadoFiltro = "Eliminados" And estado = "Si" Then
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


    Private Sub TBBuscarEquipo_KeyDown(sender As Object, e As KeyEventArgs) Handles TBBuscarEquipo.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' Simula un clic en el botón de búsqueda
            IPBBuscarEquipo_Click(sender, e)
            e.SuppressKeyPress = True ' Evita el sonido de "beep" al presionar Enter
        End If
    End Sub

    Private Sub CBFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBFiltro.SelectedIndexChanged
        FiltrarBusqueda()
    End Sub
End Class
