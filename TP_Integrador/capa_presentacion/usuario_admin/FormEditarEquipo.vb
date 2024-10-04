Public Class FormEditarEquipo
    Dim equipo As Equipos.Equipo
    Dim alFinalizar As Action

    Public Sub New(equipo As Equipos.Equipo, alFinalizar As Action)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.equipo = equipo
        Me.alFinalizar = alFinalizar

        InicializarCampos()
    End Sub

    Private Sub InicializarCampos()
        ComboBTipoEquipo.Text = equipo.TipoDeEquipo
        TBNroSerie.Text = equipo.NroSerie
        TBMarca.Text = equipo.Marca
        TBModelo.Text = ""
        TBRazonIngreso.Text = ""
        TBObservaciones.Text = ""
        CBEquipoEnciende.Checked = equipo.EnciendeEnIngreso = "Si"
        ComboBAsociarCliente.Text = equipo.NombreDelCliente
        TBRazonIngreso.Text = equipo.RazonDeIngreso
        TBObservaciones.Text = equipo.Observaciones
        TBModelo.Text = equipo.Modelo
    End Sub

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

    Private Sub IBCerrar_EC_Click(sender As Object, e As EventArgs) Handles IBCerrar_EC.Click
        Me.Close()
    End Sub

    Private Sub IBMinimizar_EC_Click(sender As Object, e As EventArgs) Handles IBMinimizar_EC.Click
        WindowState = FormWindowState.Minimized
    End Sub
End Class