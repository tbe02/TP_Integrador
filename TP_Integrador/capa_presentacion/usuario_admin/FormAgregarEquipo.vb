Imports TP_Integrador.Marcas
Imports TP_Integrador.Modelos
Imports TP_Integrador.TiposDeEquipo

Public Class FormAgregarEquipo
    Private Sub FormAgregarEquipo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarClientes()
        ListarTiposDeEquipos()
        ListarMarcas()
        ListarModelos()
    End Sub

    Private Sub ListarClientes()
        Dim clientes = Cliente.obtenerClientes()

        ComboBAsociarCliente.DataSource = clientes
        ComboBAsociarCliente.DisplayMember = "Nombre"
        ComboBAsociarCliente.ValueMember = "ID"
    End Sub

    Private Sub ListarTiposDeEquipos()
        Dim tiposEquipos = TiposDeEquipo.ObtenerTiposDeEquipo()

        ComboBTipoEquipo.DataSource = tiposEquipos
        ComboBTipoEquipo.DisplayMember = "Nombre"
        ComboBTipoEquipo.ValueMember = "IdTipoEquipo"
    End Sub

    Private Sub ListarMarcas()
        Dim marcasEquipos = Marcas.ObtenerMarcas()

        ComboBMarca.DataSource = marcasEquipos
        ComboBMarca.DisplayMember = "nombre"
        ComboBMarca.ValueMember = "idMarca"
    End Sub

    Private Sub ListarModelos()
        Dim modelosEquipos = Modelos.ObtenerModelos()

        ComboBModelo.DataSource = modelosEquipos
        ComboBModelo.DisplayMember = "nombre"
        ComboBModelo.ValueMember = "idModelo"
    End Sub


    Private Sub BAgregarEquipo_Click(sender As Object, e As EventArgs) Handles BAgregarEquipo.Click
        Dim equipo As New Equipos.Equipo()


        equipo.TipoEquipo = CType(ComboBTipoEquipo.SelectedItem, TipoDeEquipo)
        equipo.NumeroSerie = TBNroSerie.Text
        equipo.Marca = CType(ComboBMarca.SelectedItem, Marca)
        equipo.Modelo = CType(ComboBModelo.SelectedItem, Modelo)
        equipo.RazonIngreso = TBRazonIngreso.Text
        equipo.Observaciones = TBObservaciones.Text
        equipo.Enciende = If(CBEquipoEnciende.Checked, "Sí", "No")
        equipo.Cliente = CType(ComboBAsociarCliente.SelectedItem, Cliente)
        equipo.Estado = "Hola"
        equipo.Baja = "No"


        If Equipos.Agregar(equipo) Then

            ComboBTipoEquipo.SelectedIndex = -1
            TBNroSerie.Clear()
            ComboBMarca.SelectedIndex = -1
            ComboBModelo.SelectedIndex = -1
            TBRazonIngreso.Clear()
            TBObservaciones.Clear()
            CBEquipoEnciende.Checked = False
            ComboBAsociarCliente.SelectedIndex = -1
        End If


    End Sub

    Private Sub BAgregarCliente_Click(sender As Object, e As EventArgs) Handles BAgregarCliente.Click
        Dim cliente = ComboBAsociarCliente.Text

        If cliente = "" Then
            MessageBox.Show("Por favor complete los campos", "Asociar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return
        End If

        MessageBox.Show("Cliente asociado exitosamente", "Asociar cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


End Class