Imports TP_Integrador.Marcas
Imports TP_Integrador.Modelos
Imports TP_Integrador.TiposDeEquipo

Public Class FormAgregarEquipo
    Private _controladorClientes As ControladorClientes = New ControladorClientes()
    Private _controladorTiposDeEquipo As ControladorTiposDeEquipo = New ControladorTiposDeEquipo()
    Private _controladorMarcas As ControladorMarcas = New ControladorMarcas()
    Private _controladorModelos As ControladorModelos = New ControladorModelos()
    Private _controladorEquipos As ControladorEquipos = New ControladorEquipos()

    Private Sub FormAgregarEquipo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarClientes()
        ListarTiposDeEquipos()
        ListarMarcas()
        ListarModelos()
    End Sub

    Private Sub ListarClientes()
        Dim clientes = _controladorClientes.ObtenerTodos()

        ComboBAsociarCliente.DataSource = clientes
        ComboBAsociarCliente.DisplayMember = "DNI_Nombre"
        ComboBAsociarCliente.ValueMember = "ID"
    End Sub

    Private Sub ListarTiposDeEquipos()
        Dim tiposDeEquipo = _controladorTiposDeEquipo.ObtenerTodos()

        ComboBTipoEquipo.DataSource = tiposDeEquipo
        ComboBTipoEquipo.DisplayMember = "Nombre"
        ComboBTipoEquipo.ValueMember = "IdTipoEquipo"
    End Sub

    Private Sub ListarMarcas()
        Dim marcas = _controladorMarcas.ObtenerTodas()

        ComboBMarca.DataSource = marcas
        ComboBMarca.DisplayMember = "nombre"
        ComboBMarca.ValueMember = "idMarca"
    End Sub

    Private Sub ListarModelos()
        Dim modelos = _controladorModelos.ObtenerTodos()

        ComboBModelo.DataSource = modelos
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
        equipo.Estado = 1
        equipo.Baja = "No"

        Try
            _controladorEquipos.AgregarUno(equipo)
        Catch ex As Exception
            ComboBTipoEquipo.SelectedIndex = -1
            TBNroSerie.Clear()
            ComboBMarca.SelectedIndex = -1
            ComboBModelo.SelectedIndex = -1
            TBRazonIngreso.Clear()
            TBObservaciones.Clear()
            CBEquipoEnciende.Checked = False
            ComboBAsociarCliente.SelectedIndex = -1
        End Try
    End Sub

    Private Sub BAgregarCliente_Click(sender As Object, e As EventArgs)
        Dim cliente = ComboBAsociarCliente.Text

        If cliente = "" Then
            MessageBox.Show("Por favor complete los campos", "Asociar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return
        End If

        MessageBox.Show("Cliente asociado exitosamente", "Asociar cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub IBAgregarMarca_Click(sender As Object, e As EventArgs) Handles IBAgregarMarca.Click
        Dim form As New FormAgregarMarca

        AddHandler form.FormClosed, AddressOf ListarMarcas

        form.Show()
    End Sub

    Private Sub IBAgregarModelo_Click(sender As Object, e As EventArgs) Handles IBAgregarModelo.Click
        Dim form As New FormAgregarModelo

        AddHandler form.FormClosed, AddressOf ListarModelos

        form.Show()
    End Sub

    Private Sub BAgregarCliente_Click_1(sender As Object, e As EventArgs) Handles BAgregarCliente.Click
        Dim form As New FormAgregarCliente

        form.Show()
    End Sub
End Class
