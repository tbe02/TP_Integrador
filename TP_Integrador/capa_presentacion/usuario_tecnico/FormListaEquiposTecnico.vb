Public Class FormListaEquiposTecnico
    Dim equipos As Equipos = Equipos.ObtenerInstancia()

    Private Sub FormListaEquipos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarEquipos()

        DGVListaEquipos.AllowUserToAddRows = False
    End Sub

    Private Sub ListarEquipos()
        For Each equipo In Equipos.ObtenerTodos()
            DGVListaEquipos.Rows.Add(equipo.NombreDelCliente, equipo.TipoDeEquipo, equipo.NroSerie, equipo.Marca, equipo.EnciendeEnIngreso, equipo.Estado)
        Next
    End Sub

    Private Sub AtraparEventosDeBotones(sender As Object, e As DataGridViewCellEventArgs) Handles DGVListaEquipos.CellContentClick
        If e.ColumnIndex = DGVListaEquipos.Columns("C_Editar").Index AndAlso e.RowIndex >= 0 Then
            Dim filaSeleccionada As DataGridViewRow = DGVListaEquipos.Rows(e.RowIndex)

            Dim equipo As Equipos.Equipo = equipos.ObtenerTodos(e.RowIndex)

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

            Dim equipo As Equipos.Equipo = equipos.ObtenerTodos(e.RowIndex)

            ' le pasamos los datos del cliente a mi formulario
            Dim formInfo As New FormInfoEquipo(equipo)

            ' abrimos el formulario
            formInfo.Show()
        End If
    End Sub
End Class