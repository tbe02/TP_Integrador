Imports System.Windows.Media
Imports LiveCharts.Wpf.Points
Imports ScottPlot

Public Class FormEstadisticas
    Private _controladorEstadisticas As ControladorEstadisticas = New ControladorEstadisticas()

    Private _seccionActual As Integer = 0

    Private Sub ActualizarGraficoIngresosPorSemana(sender As Object, e As EventArgs) Handles ComboBoxIngresosPorSemana.SelectedIndexChanged
        FormsPlotIngresosPorSemana.Plot.Clear()

        Dim ingresos = _controladorEstadisticas.ObtenerIngresosPorSemana()

        Dim semanas = ingresos.Select(Function(ingreso) ingreso.Semana).ToList
        semanas.Insert(0, 0)

        FormsPlotIngresosPorSemana.Plot.XLabel("Semanas")

        If ComboBoxIngresosPorSemana.Text = "Total" Then
            Dim cantidades = ingresos.Select(Function(ingreso) ingreso.Cantidad).ToList

            cantidades.Insert(0, 0)

            FormsPlotIngresosPorSemana.Plot.Add.Scatter(semanas, cantidades)
            FormsPlotIngresosPorSemana.Plot.Axes.SetLimitsY(cantidades.Min - 1, cantidades.Max + 1)
            FormsPlotIngresosPorSemana.Plot.Title("Ingresos por semana")
            FormsPlotIngresosPorSemana.Plot.YLabel("Ingresos")

            FormsPlotIngresosPorSemana.Refresh()

            Return
        End If

        Dim variaciones = ingresos.Select(Function(ingreso) ingreso.Variacion).ToList
        variaciones.Insert(0, 0)

        FormsPlotIngresosPorSemana.Plot.Add.Scatter(semanas, variaciones)
        FormsPlotIngresosPorSemana.Plot.Axes.SetLimitsY(variaciones.Min - 1, variaciones.Max + 1)
        FormsPlotIngresosPorSemana.Plot.Title("Variacion de ingresos por semana")
        FormsPlotIngresosPorSemana.Plot.YLabel("Variacion Ingresos")

        FormsPlotIngresosPorSemana.Refresh()
    End Sub

    Private Sub ActualizarGraficoRevisionesPorSemana(sender As Object, e As EventArgs) Handles ComboBoxRevisionesPorSemana.SelectedIndexChanged
        FormsPlotRevisionesPorSemana.Plot.Clear()

        Dim revisiones = _controladorEstadisticas.ObtenerRevisionesPorSemana

        Dim semanas = revisiones.Select(Function(revision) revision.Semana).ToList
        semanas.Insert(0, 0)

        FormsPlotRevisionesPorSemana.Plot.XLabel("Semanas")

        If ComboBoxRevisionesPorSemana.Text = "Total" Then
            Dim cantidades = revisiones.Select(Function(revision) revision.Cantidad).ToList

            cantidades.Insert(0, 0)

            FormsPlotRevisionesPorSemana.Plot.Add.Scatter(semanas, cantidades)
            FormsPlotRevisionesPorSemana.Plot.Axes.SetLimitsY(cantidades.Min - 1, cantidades.Max + 1)
            FormsPlotRevisionesPorSemana.Plot.Title("Revisiones por semana")
            FormsPlotRevisionesPorSemana.Plot.YLabel("Revisiones")

            FormsPlotRevisionesPorSemana.Refresh()

            Return
        End If

        Dim variaciones = revisiones.Select(Function(revision) revision.Variacion).ToList
        variaciones.Insert(0, 0)

        FormsPlotRevisionesPorSemana.Plot.Add.Scatter(semanas, variaciones)
        FormsPlotRevisionesPorSemana.Plot.Axes.SetLimitsY(variaciones.Min - 1, variaciones.Max + 1)
        FormsPlotRevisionesPorSemana.Plot.Title("Variacion de revisiones por semana")
        FormsPlotRevisionesPorSemana.Plot.YLabel("Variacion revisiones")

        FormsPlotRevisionesPorSemana.Refresh()
    End Sub

    Private Sub ActualizarSeccion()
        FormsPlotIngresosPorSemana.Hide()
        ComboBoxIngresosPorSemana.Hide()
        FormsPlotRevisionesPorSemana.Hide()
        ComboBoxRevisionesPorSemana.Hide()

        FormsPlotReparacionesPorSemana.Hide()
        ComboBoxReparacionesPorSemana.Hide()
        FormsPlotEntregasPorSemana.Hide()
        ComboBoxEntregasPorSemana.Hide()

        FormsPlotEquiposPorEstado.Hide()

        FormsPlotFacturacionPorSemana.Hide()
        ComboBoxFacturacionPorSemana.Hide()

        Select Case _seccionActual
            Case 1
                TituloDeSeccion.Text = "Reparaciones y Entregas"

                FormsPlotReparacionesPorSemana.Show()
                ComboBoxReparacionesPorSemana.Show()
                FormsPlotEntregasPorSemana.Show()
                ComboBoxEntregasPorSemana.Show()
            Case 2
                TituloDeSeccion.Text = "Cantidad de equipos por estado"

                FormsPlotEquiposPorEstado.Show()

                ActualizarGraficoEquiposPorEstado()
            Case 3
                TituloDeSeccion.Text = "Facturacion"

                FormsPlotFacturacionPorSemana.Show()
                ComboBoxFacturacionPorSemana.Show()
            Case Else
                TituloDeSeccion.Text = "Ingresos y Revisiones"

                FormsPlotIngresosPorSemana.Show()
                ComboBoxIngresosPorSemana.Show()
                FormsPlotRevisionesPorSemana.Show()
                ComboBoxRevisionesPorSemana.Show()
        End Select
    End Sub

    Private Sub PasarALaSiguienteSeccion(sender As Object, e As EventArgs) Handles ButtonSiguiente.Click
        If _seccionActual = 3 Then
            Return
        End If

        If _seccionActual = 2 Then
            ButtonSiguiente.BackColor = System.Drawing.Color.LightGray
            ButtonSiguiente.ForeColor = System.Drawing.Color.DarkGray
            ButtonSiguiente.Enabled = False
        End If

        If _seccionActual = 0 Then
            ButtonAnterior.BackColor = System.Drawing.Color.FromArgb(CByte(128), CByte(128), CByte(255))
            ButtonAnterior.ForeColor = System.Drawing.Color.White
            ButtonAnterior.Enabled = True
        End If

        _seccionActual = _seccionActual + 1

        ActualizarSeccion()
    End Sub

    Private Sub PasarALaAnteriorSeccion(sender As Object, e As EventArgs) Handles ButtonAnterior.Click
        If _seccionActual = 0 Then
            Return
        End If

        If _seccionActual = 1 Then
            ButtonAnterior.BackColor = System.Drawing.Color.LightGray
            ButtonAnterior.ForeColor = System.Drawing.Color.DarkGray
            ButtonAnterior.Enabled = False
        End If

        If _seccionActual = 3 Then
            ButtonSiguiente.BackColor = System.Drawing.Color.FromArgb(CByte(128), CByte(128), CByte(255))
            ButtonSiguiente.ForeColor = System.Drawing.Color.White
            ButtonSiguiente.Enabled = True
        End If

        _seccionActual = _seccionActual - 1

        ActualizarSeccion()
    End Sub

    Private Sub ActualizarGraficoReparacionesPorSemana(sender As Object, e As EventArgs) Handles ComboBoxReparacionesPorSemana.SelectedIndexChanged
        FormsPlotReparacionesPorSemana.Plot.Clear

        Dim reparaciones = _controladorEstadisticas.ObtenerReparacionesPorSemana

        Dim semanas = reparaciones.Select(Function(reparacion) reparacion.Semana).ToList
        semanas.Insert(0, 0)

        FormsPlotReparacionesPorSemana.Plot.XLabel("Semanas")

        If ComboBoxReparacionesPorSemana.Text = "Total" Then
            Dim cantidades = reparaciones.Select(Function(reparacion) reparacion.Cantidad).ToList

            cantidades.Insert(0, 0)

            FormsPlotReparacionesPorSemana.Plot.Add.Scatter(semanas, cantidades)
            FormsPlotReparacionesPorSemana.Plot.Axes.SetLimitsY(cantidades.Min - 1, cantidades.Max + 1)
            FormsPlotReparacionesPorSemana.Plot.Title("Reparaciones por semana")
            FormsPlotReparacionesPorSemana.Plot.YLabel("Reparaciones")

            FormsPlotReparacionesPorSemana.Refresh

            Return
        End If

        Dim variaciones = reparaciones.Select(Function(reparacion) reparacion.Variacion).ToList
        variaciones.Insert(0, 0)

        FormsPlotReparacionesPorSemana.Plot.Add.Scatter(semanas, variaciones)
        FormsPlotReparacionesPorSemana.Plot.Axes.SetLimitsY(variaciones.Min - 1, variaciones.Max + 1)
        FormsPlotReparacionesPorSemana.Plot.Title("Variacion de reparaciones por semana")
        FormsPlotReparacionesPorSemana.Plot.YLabel("Variacion reparaciones")

        FormsPlotReparacionesPorSemana.Refresh
    End Sub

    Private Sub ActualizarGraficoEntregasPorSemana(sender As Object, e As EventArgs) Handles ComboBoxEntregasPorSemana.SelectedIndexChanged
        FormsPlotEntregasPorSemana.Plot.Clear()

        Dim entregas = _controladorEstadisticas.ObtenerEntregasPorSemana()

        Dim semanas = entregas.Select(Function(entrega) entrega.Semana).ToList
        semanas.Insert(0, 0)

        FormsPlotEntregasPorSemana.Plot.XLabel("Semanas")

        If ComboBoxEntregasPorSemana.Text = "Total" Then
            Dim cantidades = entregas.Select(Function(entrega) entrega.Cantidad).ToList()

            cantidades.Insert(0, 0)

            FormsPlotEntregasPorSemana.Plot.Add.Scatter(semanas, cantidades)
            FormsPlotEntregasPorSemana.Plot.Axes.SetLimitsY(cantidades.Min - 1, cantidades.Max + 1)
            FormsPlotEntregasPorSemana.Plot.Title("Entregas por semana")
            FormsPlotEntregasPorSemana.Plot.YLabel("Entregas")

            FormsPlotEntregasPorSemana.Refresh()

            Return
        End If

        Dim variaciones = entregas.Select(Function(entrega) entrega.Variacion).ToList
        variaciones.Insert(0, 0)

        FormsPlotEntregasPorSemana.Plot.Add.Scatter(semanas, variaciones)
        FormsPlotEntregasPorSemana.Plot.Axes.SetLimitsY(variaciones.Min - 1, variaciones.Max + 1)
        FormsPlotEntregasPorSemana.Plot.Title("Variacion de entregas por semana")
        FormsPlotEntregasPorSemana.Plot.YLabel("Variacion entregas")

        FormsPlotEntregasPorSemana.Refresh()
    End Sub

    Private Sub FormEstadisticas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarSeccion()

        ButtonAnterior.BackColor = System.Drawing.Color.LightGray
        ButtonAnterior.ForeColor = System.Drawing.Color.DarkGray
        ButtonAnterior.Enabled = False
    End Sub

    Private Sub ActualizarGraficoEquiposPorEstado()
        FormsPlotEquiposPorEstado.Reset()

        Dim equipos = _controladorEstadisticas.ObtenerEquiposPorEstado()

        Dim slices = New List(Of ScottPlot.PieSlice)

        Dim colores = {
            ScottPlot.Colors.Red,
            ScottPlot.Colors.Blue,
            ScottPlot.Colors.Orange,
            ScottPlot.Colors.Yellow,
            ScottPlot.Colors.Purple,
            ScottPlot.Colors.Brown,
            ScottPlot.Colors.Cyan,
            ScottPlot.Colors.Pink
        }

        Dim indiceColor = 0

        For Each equipo In equipos
            slices.Add(New ScottPlot.PieSlice With {
                .Value = equipo.Cantidad,
                .Label = equipo.Estado,
                .FillColor = colores(indiceColor),
                .LegendText = equipo.Estado,
                .LabelBold = True
            })

            indiceColor += 1
        Next

        Dim pie As ScottPlot.Plottables.Pie = FormsPlotEquiposPorEstado.Plot.Add.Pie(slices)

        FormsPlotEquiposPorEstado.Plot.ShowLegend()

        FormsPlotEquiposPorEstado.Plot.Axes.Frameless()
        FormsPlotEquiposPorEstado.Plot.HideGrid()

        FormsPlotEquiposPorEstado.Refresh()
    End Sub

    Private Sub ActualizarGraficoFacturacionPorSemana(sender As Object, e As EventArgs) Handles ComboBoxFacturacionPorSemana.SelectedIndexChanged
        FormsPlotFacturacionPorSemana.Plot.Clear()

        Dim facturaciones = _controladorEstadisticas.ObtenerFacturacionPorSemana()

        Dim semanas = facturaciones.Select(Function(facturacion) facturacion.Semana).ToList
        semanas.Insert(0, 0)

        FormsPlotFacturacionPorSemana.Plot.XLabel("Semanas")

        If ComboBoxFacturacionPorSemana.Text = "Total" Then
            Dim cantidades = facturaciones.Select(Function(facturacion) facturacion.Cantidad).ToList()

            cantidades.Insert(0, 0)

            FormsPlotFacturacionPorSemana.Plot.Add.Scatter(semanas, cantidades)
            FormsPlotFacturacionPorSemana.Plot.Axes.SetLimitsY(cantidades.Min - 1, cantidades.Max + 1)
            FormsPlotFacturacionPorSemana.Plot.Title("Facturacion por semana")
            FormsPlotFacturacionPorSemana.Plot.YLabel("Facturacion")

            FormsPlotFacturacionPorSemana.Refresh()

            Return
        End If

        Dim variaciones = facturaciones.Select(Function(facturacion) facturacion.Variacion).ToList
        variaciones.Insert(0, 0)

        FormsPlotFacturacionPorSemana.Plot.Add.Scatter(semanas, variaciones)
        FormsPlotFacturacionPorSemana.Plot.Axes.SetLimitsY(variaciones.Min - 1, variaciones.Max + 1)
        FormsPlotFacturacionPorSemana.Plot.Title("Variacion de facturacion por semana")
        FormsPlotFacturacionPorSemana.Plot.YLabel("Variacion facturacion")

        FormsPlotFacturacionPorSemana.Refresh()
    End Sub
End Class
