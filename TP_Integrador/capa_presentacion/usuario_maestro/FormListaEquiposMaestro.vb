﻿Public Class FormListaEquiposMaestro
    Dim equipos As Equipos = Equipos.ObtenerInstancia()

    Private Sub FormListaEquiposMaestro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        For Each equipo In equipos.ObtenerTodos()
            DGVListaEquipos.Rows.Add(equipo.NombreDelCliente, equipo.TipoDeEquipo, equipo.NroSerie, equipo.Marca, equipo.EnciendeEnIngreso, equipo.Estado)
        Next
    End Sub

    Private Sub AtraparEventosDeBotones(sender As Object, e As DataGridViewCellEventArgs) Handles DGVListaEquipos.CellContentClick
        If e.ColumnIndex = DGVListaEquipos.Columns("C_InfomacionEquipo").Index AndAlso e.RowIndex >= 0 Then
            Dim filaSeleccionada As DataGridViewRow = DGVListaEquipos.Rows(e.RowIndex)

            Dim equipo As Equipos.Equipo = equipos.ObtenerTodos(e.RowIndex)

            ' le pasamos los datos del cliente a mi formulario
            Dim formInfo As New FormInfoEquipo(equipo)

            ' abrimos el formulario
            formInfo.Show()
        End If
    End Sub

    Private Sub FiltrarEquipos(sender As Object, e As EventArgs) Handles IPBBuscarEquipo.Click
        Dim filtro = CBFiltro.Text
        Dim busqueda = TBBuscarEquipo.Text

        Dim equiposFiltrados As List(Of Equipos.Equipo)

        DGVListaEquipos.Rows.Clear()

        Select Case filtro
            Case "Nombre cliente"
                equiposFiltrados = equipos.ObtenerTodos().Where(Function(equipo) equipo.NombreDelCliente.StartsWith(busqueda)).ToList()
            Case "Marca"
                equiposFiltrados = equipos.ObtenerTodos().Where(Function(equipo) equipo.Marca.StartsWith(busqueda)).ToList()
            Case "Nro de Serie"
                equiposFiltrados = equipos.ObtenerTodos().Where(Function(equipo) equipo.NroSerie.StartsWith(busqueda)).ToList()
            Case "Enciende"
                equiposFiltrados = equipos.ObtenerTodos().Where(Function(equipo) equipo.EnciendeEnIngreso = "Si").ToList()
            Case "No enciende"
                equiposFiltrados = equipos.ObtenerTodos().Where(Function(equipo) equipo.EnciendeEnIngreso = "No").ToList()
            Case Else
                equiposFiltrados = equipos.ObtenerTodos()
        End Select

        For Each equipo In equiposFiltrados
            DGVListaEquipos.Rows.Add(equipo.NombreDelCliente, equipo.TipoDeEquipo, equipo.NroSerie, equipo.Marca, equipo.EnciendeEnIngreso, equipo.Estado)
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