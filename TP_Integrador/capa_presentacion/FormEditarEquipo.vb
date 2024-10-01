Public Class FormEditarEquipo
    Private Sub BEditarEquipo_Click(sender As Object, e As EventArgs) Handles BEditarEquipo.Click
        Dim tipoEquipo = ComboBTipoEquipo.Text
        Dim numeroSerie = TBNroSerie.Text
        Dim marca = TBMarca.Text
        Dim modelo = TBModelo.Text
        Dim razonIngreso = TBRazonIngreso.Text
        Dim observaciones = TBObservaciones.Text
        Dim enciende = CBEquipoEnciende.Checked

        If tipoEquipo = "" Or numeroSerie = "" Or marca = "" Or modelo = "" Or razonIngreso = "" Or observaciones = "" Then
            MessageBox.Show("Por favor complete los campos", "Editar equipo", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return
        End If

        MessageBox.Show("Equipo editado exitosamente", "Editar equipo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class