Public Class FormListaEquiposAdmin
    Private _controladorEquipos As ControladorEquipos = New ControladorEquipos()

    Private Sub FormListaEquipos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarEquipos()
        ListarFiltros()

        DGVListaEquipos.AllowUserToAddRows = False
    End Sub

    Private Sub ListarFiltros()
        CBFiltro.Items.Add("Todos")
        CBFiltro.Items.Add("Nombre cliente")
        CBFiltro.Items.Add("Marca")
        CBFiltro.Items.Add("Nro de Serie")
        CBFiltro.Items.Add("Enciende")
        CBFiltro.Items.Add("No enciende")
    End Sub

    Private Sub ListarEquipos()
        For Each equipo In _controladorEquipos.ObtenerTodos()
            DGVListaEquipos.Rows.Add(equipo.Cliente.Nombre, equipo.TipoEquipo.Nombre, equipo.NumeroSerie, equipo.Marca.nombre, equipo.Modelo.nombre, equipo.Enciende, equipo.Estado, equipo.Baja)
        Next
    End Sub

    Private Sub RefrescarLista()
        DGVListaEquipos.Rows.Clear()

        ListarEquipos()
    End Sub


    Private Sub AtraparEventosDeBotones(sender As Object, e As DataGridViewCellEventArgs) Handles DGVListaEquipos.CellContentClick
        If e.ColumnIndex = DGVListaEquipos.Columns("C_Editar").Index AndAlso e.RowIndex >= 0 Then
            Dim filaSeleccionada As DataGridViewRow = DGVListaEquipos.Rows(e.RowIndex)

            Dim equipo As Equipos.Equipo = _controladorEquipos.ObtenerTodos(e.RowIndex)

            Dim formEditar As New FormEditarEquipo(equipo, New Action(
                    Sub()
                        RefrescarLista()
                    End Sub
                )
            )

            formEditar.Show()
        End If

        If e.ColumnIndex = DGVListaEquipos.Columns("C_InfomacionEquipo").Index AndAlso e.RowIndex >= 0 Then
            Dim filaSeleccionada As DataGridViewRow = DGVListaEquipos.Rows(e.RowIndex)

            Dim equipo As Equipos.Equipo = _controladorEquipos.ObtenerTodos(e.RowIndex)

            Dim formInfo As New FormInfoEquipo(equipo)

            formInfo.Show()
        End If

        If e.ColumnIndex = DGVListaEquipos.Columns("C_Eliminar").Index AndAlso e.RowIndex >= 0 Then
            Dim filaSeleccionada As DataGridViewRow = DGVListaEquipos.Rows(e.RowIndex)

            Dim equipoSeleccionado As Equipos.Equipo = _controladorEquipos.ObtenerTodos(e.RowIndex)

            Dim decision As DialogResult = MessageBox.Show("¿Está seguro que desea eliminar este equipo?", "Eliminar equipo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            _controladorEquipos.EliminarUnoPorId(equipoSeleccionado.IDEquipo)

            RefrescarLista()

            'If decision = DialogResult.Yes Then
            '    Dim equiposFiltrados = equipos.ObtenerTodos().Where(Function(equipo) equipo.NumeroSerie <> equipoSeleccionado.NumeroSerie).ToList()

            '    DGVListaEquipos.Rows.Clear()
            '    equipos.eliminar(equipoSeleccionado)

            '    For Each equipo In equiposFiltrados
            '        DGVListaEquipos.Rows.Add(equipo.Cliente.Nombre, equipo.TipoEquipo.Nombre, equipo.NumeroSerie, equipo.Marca.nombre, equipo.Enciende, equipo.Estado)
            '    Next

            '    MessageBox.Show("Equipo eliminado con éxito.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'End If
        End If
    End Sub

    Private Sub FiltrarEquipos(sender As Object, e As EventArgs) Handles IPBBuscarEquipo.Click
        Dim filtro = CBFiltro.Text
        Dim busqueda = TBBuscarEquipo.Text

        Dim equipos As List(Of Equipos.Equipo) = _controladorEquipos.ObtenerTodos()
        Dim equiposFiltrados As List(Of Equipos.Equipo)

        DGVListaEquipos.Rows.Clear()

        Select Case filtro
            Case "Nombre cliente"
                equiposFiltrados = equipos.Where(Function(equipo) equipo.Cliente.Nombre.StartsWith(busqueda)).ToList()
            Case "Marca"
                equiposFiltrados = equipos.Where(Function(equipo) equipo.Marca.nombre.StartsWith(busqueda)).ToList()
            Case "Nro de Serie"
                equiposFiltrados = equipos.Where(Function(equipo) equipo.NumeroSerie.StartsWith(busqueda)).ToList()
            Case "Enciende"
                equiposFiltrados = equipos.Where(Function(equipo) equipo.Enciende = "Si").ToList()
            Case "No enciende"
                equiposFiltrados = equipos.Where(Function(equipo) equipo.Enciende = "No").ToList()
            Case Else
                equiposFiltrados = equipos
        End Select

        For Each equipo In equiposFiltrados
            DGVListaEquipos.Rows.Add(equipo.Cliente.Nombre, equipo.TipoEquipo.Nombre, equipo.NumeroSerie, equipo.Marca.nombre, equipo.Enciende, equipo.Estado)
        Next
    End Sub

    Private Sub ManejarFiltro(sender As Object, e As EventArgs) Handles CBFiltro.SelectedIndexChanged
        TBBuscarEquipo.Text = ""

        Dim filtro = CBFiltro.Text

        If filtro = "Enciende" Or filtro = "No enciende" Then
            FiltrarEquipos(sender, e)

            Return
        End If

        DGVListaEquipos.Rows.Clear()

        ListarEquipos()
    End Sub
End Class
