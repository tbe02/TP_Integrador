Public Class FormAgregarEquipo
    Private Sub FormAgregarEquipo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarClientes()
    End Sub

    Private Sub ListarClientes()
        Dim clientes = Cliente.obtenerClientes()

        For Each cliente In clientes
            ComboBAsociarCliente.Items.Add(cliente.Nombre)
        Next
    End Sub

    Private Sub BAgregarEquipo_Click(sender As Object, e As EventArgs) Handles BAgregarEquipo.Click
        Dim tipoEquipo = ComboBTipoEquipo.Text
        Dim numeroSerie = TBNroSerie.Text
        Dim marca = TBMarca.Text
        Dim modelo = TBModelo.Text
        Dim razonIngreso = TBRazonIngreso.Text
        Dim observaciones = TBObservaciones.Text
        Dim enciende = CBEquipoEnciende.Checked
        Dim cliente = ComboBAsociarCliente.Text

        If tipoEquipo = "" Or numeroSerie = "" Or marca = "" Or modelo = "" Or razonIngreso = "" Or observaciones = "" Or cliente = "" Then
            MessageBox.Show("Por favor complete los campos", "Agregar equipo", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return
        End If

        Equipos.ObtenerInstancia().Agregar(New Equipos.Equipo With {
            .NombreDelCliente = cliente,
            .TipoDeEquipo = tipoEquipo,
            .NroSerie = numeroSerie,
            .Marca = marca,
            .EnciendeEnIngreso = If(enciende, "Si", "No"),
            .RazonDeIngreso = razonIngreso,
            .Observaciones = observaciones,
            .Modelo = modelo,
            .Estado = "Pendiente de revision"
        })

        MessageBox.Show("Equipo agregado exitosamente", "Agregar equipo", MessageBoxButtons.OK, MessageBoxIcon.Information)
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