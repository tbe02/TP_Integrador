Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar
Imports System.Windows.Media
Imports System.Windows.Navigation
Imports LiveCharts.Wpf.Points
Imports ScottPlot
Imports ScottPlot.Plottables
Imports TP_Integrador.Equipos

Public Class FormEstadisticas
    Private _controladorEstadisticas As ControladorEstadisticas = New ControladorEstadisticas()

    Private _seccionActual As Integer = 0

    Private Sub ActualizarGraficoIngresosPorSemana(sender As Object, e As EventArgs) Handles ComboBoxIngresosPorSemana.SelectedIndexChanged, DateTimePickerDesdeIngresosPorSemana.ValueChanged, DateTimePickerHastaIngresosPorSemana.ValueChanged
        FormsPlotIngresosPorSemana.Plot.Clear()

        Dim fechaInicio As String = DateTimePickerDesdeIngresosPorSemana.Value.ToString("yyyy-MM-dd")
        Dim fechaFin As String = DateTimePickerHastaIngresosPorSemana.Value.ToString("yyyy-MM-dd")

        Dim ingresos = _controladorEstadisticas.ObtenerIngresosPorSemana(fechaInicio, fechaFin)

        Dim tickGenerator = New ScottPlot.TickGenerators.NumericManual()

        tickGenerator.AddMajor(0, DateTimePickerDesdeIngresosPorSemana.Value.ToString("dd-MM-yyyy"))

        Dim contadorSemana = -1
        Dim semanas = ingresos.Select(Function(ingreso)
                                          contadorSemana += 1

                                          Return contadorSemana
                                      End Function).ToList


        tickGenerator.AddMajor(semanas.Max, DateTimePickerHastaIngresosPorSemana.Value.ToString("dd-MM-yyyy"))
        FormsPlotIngresosPorSemana.Plot.XLabel("Semanas")
        FormsPlotIngresosPorSemana.Plot.Axes.SetLimitsX(0, semanas.Max)

        FormsPlotIngresosPorSemana.Plot.Axes.Bottom.TickGenerator = tickGenerator

        If ComboBoxIngresosPorSemana.Text = "Total" Then
            Dim cantidades = ingresos.Select(Function(ingreso) ingreso.Cantidad).ToList

            FormsPlotIngresosPorSemana.Plot.Add.Scatter(semanas, cantidades)
            FormsPlotIngresosPorSemana.Plot.Axes.SetLimitsY(cantidades.Min, cantidades.Max + 1)
            FormsPlotIngresosPorSemana.Plot.Title("Ingresos por semana")
            FormsPlotIngresosPorSemana.Plot.YLabel("Ingresos")

            FormsPlotIngresosPorSemana.Refresh()

            Return
        End If

        Dim variaciones = ingresos.Select(Function(ingreso) ingreso.Variacion).ToList

        FormsPlotIngresosPorSemana.Plot.Add.Scatter(semanas, variaciones)
        FormsPlotIngresosPorSemana.Plot.Axes.SetLimitsY(variaciones.Min, variaciones.Max + 1)
        FormsPlotIngresosPorSemana.Plot.Title("Variacion de ingresos por semana")
        FormsPlotIngresosPorSemana.Plot.YLabel("Variacion Ingresos")

        FormsPlotIngresosPorSemana.Refresh()
    End Sub

    Private Sub ActualizarGraficoRevisionesPorSemana(sender As Object, e As EventArgs) Handles ComboBoxRevisionesPorSemana.SelectedIndexChanged, DateTimePickerDesdeRevisionesPorSemana.ValueChanged, DateTimePickerHastaRevisionesPorSemana.ValueChanged
        FormsPlotRevisionesPorSemana.Plot.Clear()

        Dim fechaInicio As String = DateTimePickerDesdeRevisionesPorSemana.Value.ToString("yyyy-MM-dd")
        Dim fechaFin As String = DateTimePickerHastaRevisionesPorSemana.Value.ToString("yyyy-MM-dd")

        Dim revisiones = _controladorEstadisticas.ObtenerRevisionesPorSemana(fechaInicio, fechaFin)

        Dim tickGenerator = New ScottPlot.TickGenerators.NumericManual()

        tickGenerator.AddMajor(0, DateTimePickerDesdeRevisionesPorSemana.Value.ToString("dd-MM-yyyy"))

        Dim contadorSemana = -1
        Dim semanas = revisiones.Select(Function(ingreso)
                                            contadorSemana += 1

                                            Return contadorSemana
                                        End Function).ToList

        tickGenerator.AddMajor(semanas.Max, DateTimePickerHastaRevisionesPorSemana.Value.ToString("dd-MM-yyyy"))
        FormsPlotRevisionesPorSemana.Plot.XLabel("Semanas")
        FormsPlotRevisionesPorSemana.Plot.Axes.SetLimitsX(0, semanas.Max)

        FormsPlotRevisionesPorSemana.Plot.Axes.Bottom.TickGenerator = tickGenerator

        If ComboBoxRevisionesPorSemana.Text = "Total" Then
            Dim cantidades = revisiones.Select(Function(revision) revision.Cantidad).ToList

            FormsPlotRevisionesPorSemana.Plot.Add.Scatter(semanas, cantidades)
            FormsPlotRevisionesPorSemana.Plot.Axes.SetLimitsY(cantidades.Min, cantidades.Max + 1)
            FormsPlotRevisionesPorSemana.Plot.Title("Revisiones por semana")
            FormsPlotRevisionesPorSemana.Plot.YLabel("Revisiones")

            FormsPlotRevisionesPorSemana.Refresh()

            Return
        End If

        Dim variaciones = revisiones.Select(Function(revision) revision.Variacion).ToList

        FormsPlotRevisionesPorSemana.Plot.Add.Scatter(semanas, variaciones)
        FormsPlotRevisionesPorSemana.Plot.Axes.SetLimitsY(variaciones.Min, variaciones.Max + 1)
        FormsPlotRevisionesPorSemana.Plot.Title("Variacion de revisiones por semana")
        FormsPlotRevisionesPorSemana.Plot.YLabel("Variacion revisiones")

        FormsPlotRevisionesPorSemana.Refresh()
    End Sub

    Private Sub ActualizarSeccion()
        FormsPlotIngresosPorSemana.Hide()
        ComboBoxIngresosPorSemana.Hide()
        LabelDesdeIngresosPorSemana.Hide()
        DateTimePickerDesdeIngresosPorSemana.Hide()
        LabelHastaEquiposPorSemana.Hide()
        DateTimePickerHastaIngresosPorSemana.Hide()
        FormsPlotRevisionesPorSemana.Hide()
        ComboBoxRevisionesPorSemana.Hide()
        LabelDesdeIngresosPorSemana.Hide()
        DateTimePickerDesdeIngresosPorSemana.Hide()
        LabelHastaEquiposPorSemana.Hide()
        DateTimePickerHastaIngresosPorSemana.Hide()
        LabelDesdeRevisionesPorSemana.Hide()
        DateTimePickerDesdeRevisionesPorSemana.Hide()
        LabelHastaRevisionesPorSemana.Hide()
        DateTimePickerHastaRevisionesPorSemana.Hide()

        FormsPlotReparacionesPorSemana.Hide()
        ComboBoxReparacionesPorSemana.Hide()
        FormsPlotEntregasPorSemana.Hide()
        ComboBoxEntregasPorSemana.Hide()
        LabelDesdeReparacionesPorSemana.Hide()
        DateTimePickerDesdeReparacionesPorSemana.Hide()
        LabelHastaReparacionesPorSemana.Hide()
        DateTimePickerHastaReparacionesPorSemana.Hide()
        LabelDesdeEntregasPorSemana.Hide()
        DateTimePickerDesdeEntregasPorSemana.Hide()
        LabelHastaEntregasPorSemana.Hide()
        DateTimePickerHastaEntregasPorSemana.Hide()

        FormsPlotEquiposPorEstado.Hide()

        FormsPlotFacturacionPorSemana.Hide()
        ComboBoxFacturacionPorSemana.Hide()
        LabelDesdeFacturacionPorSemana.Hide()
        DateTimePickerDesdeFacturacionPorSemana.Hide()
        LabelHastaFacturacionPorSemana.Hide()
        DateTimePickerHastaFacturacionPorSemana.Hide()

        Select Case _seccionActual
            Case 1
                TituloDeSeccion.Text = "Reparaciones y Entregas"

                FormsPlotReparacionesPorSemana.Show()
                ComboBoxReparacionesPorSemana.Show()
                FormsPlotEntregasPorSemana.Show()
                ComboBoxEntregasPorSemana.Show()
                LabelDesdeReparacionesPorSemana.Show()
                DateTimePickerDesdeReparacionesPorSemana.Show()
                LabelHastaReparacionesPorSemana.Show()
                DateTimePickerHastaReparacionesPorSemana.Show()
                LabelDesdeEntregasPorSemana.Show()
                DateTimePickerDesdeEntregasPorSemana.Show()
                LabelHastaEntregasPorSemana.Show()
                DateTimePickerHastaEntregasPorSemana.Show()
            Case 2
                TituloDeSeccion.Text = "Cantidad de equipos por estado"

                FormsPlotEquiposPorEstado.Show()

                ActualizarGraficoEquiposPorEstado()
            Case 3
                TituloDeSeccion.Text = "Facturacion"

                FormsPlotFacturacionPorSemana.Show()
                ComboBoxFacturacionPorSemana.Show()
                LabelDesdeFacturacionPorSemana.Show()
                DateTimePickerDesdeFacturacionPorSemana.Show()
                LabelHastaFacturacionPorSemana.Show()
                DateTimePickerHastaFacturacionPorSemana.Show()
            Case Else
                TituloDeSeccion.Text = "Ingresos y Revisiones"

                FormsPlotIngresosPorSemana.Show()
                ComboBoxIngresosPorSemana.Show()
                FormsPlotRevisionesPorSemana.Show()
                ComboBoxRevisionesPorSemana.Show()
                LabelDesdeIngresosPorSemana.Show()
                DateTimePickerDesdeIngresosPorSemana.Show()
                LabelHastaEquiposPorSemana.Show()
                DateTimePickerHastaIngresosPorSemana.Show()
                LabelDesdeRevisionesPorSemana.Show()
                DateTimePickerDesdeRevisionesPorSemana.Show()
                LabelHastaRevisionesPorSemana.Show()
                DateTimePickerHastaRevisionesPorSemana.Show()
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

    Private Sub ActualizarGraficoReparacionesPorSemana(sender As Object, e As EventArgs) Handles ComboBoxReparacionesPorSemana.SelectedIndexChanged, DateTimePickerDesdeReparacionesPorSemana.ValueChanged, DateTimePickerHastaReparacionesPorSemana.ValueChanged
        FormsPlotReparacionesPorSemana.Plot.Clear()

        Dim fechaInicio As String = DateTimePickerDesdeReparacionesPorSemana.Value.ToString("yyyy-MM-dd")
        Dim fechaFin As String = DateTimePickerHastaReparacionesPorSemana.Value.ToString("yyyy-MM-dd")

        Dim reparaciones = _controladorEstadisticas.ObtenerReparacionesPorSemana(fechaInicio, fechaFin)

        Dim tickGenerator = New ScottPlot.TickGenerators.NumericManual()

        tickGenerator.AddMajor(0, DateTimePickerDesdeReparacionesPorSemana.Value.ToString("dd-MM-yyyy"))

        Dim contadorSemana = -1
        Dim semanas = reparaciones.Select(Function(ingreso)
                                              contadorSemana += 1

                                              Return contadorSemana
                                          End Function).ToList


        tickGenerator.AddMajor(semanas.Max, DateTimePickerHastaReparacionesPorSemana.Value.ToString("dd-MM-yyyy"))
        FormsPlotReparacionesPorSemana.Plot.XLabel("Semanas")
        FormsPlotReparacionesPorSemana.Plot.Axes.SetLimitsX(0, semanas.Max)

        FormsPlotReparacionesPorSemana.Plot.Axes.Bottom.TickGenerator = tickGenerator

        If ComboBoxReparacionesPorSemana.Text = "Total" Then
            Dim cantidades = reparaciones.Select(Function(reparacion) reparacion.Cantidad).ToList

            FormsPlotReparacionesPorSemana.Plot.Add.Scatter(semanas, cantidades)
            FormsPlotReparacionesPorSemana.Plot.Axes.SetLimitsY(cantidades.Min, cantidades.Max + 1)
            FormsPlotReparacionesPorSemana.Plot.Title("Reparaciones por semana")
            FormsPlotReparacionesPorSemana.Plot.YLabel("Reparaciones")

            FormsPlotReparacionesPorSemana.Refresh()

            Return
        End If

        Dim variaciones = reparaciones.Select(Function(reparacion) reparacion.Variacion).ToList

        FormsPlotReparacionesPorSemana.Plot.Add.Scatter(semanas, variaciones)
        FormsPlotReparacionesPorSemana.Plot.Axes.SetLimitsY(variaciones.Min, variaciones.Max + 1)
        FormsPlotReparacionesPorSemana.Plot.Title("Variacion de reparaciones por semana")
        FormsPlotReparacionesPorSemana.Plot.YLabel("Variacion reparaciones")

        FormsPlotReparacionesPorSemana.Refresh()
    End Sub

    Private Sub ActualizarGraficoEntregasPorSemana(sender As Object, e As EventArgs) Handles ComboBoxEntregasPorSemana.SelectedIndexChanged, DateTimePickerDesdeEntregasPorSemana.ValueChanged, DateTimePickerHastaEntregasPorSemana.ValueChanged
        FormsPlotEntregasPorSemana.Plot.Clear()

        Dim fechaInicio As String = DateTimePickerDesdeEntregasPorSemana.Value.ToString("yyyy-MM-dd")
        Dim fechaFin As String = DateTimePickerHastaEntregasPorSemana.Value.ToString("yyyy-MM-dd")

        Dim entregas = _controladorEstadisticas.ObtenerEntregasPorSemana(fechaInicio, fechaFin)

        Dim tickGenerator = New ScottPlot.TickGenerators.NumericManual()

        tickGenerator.AddMajor(0, DateTimePickerDesdeEntregasPorSemana.Value.ToString("dd-MM-yyyy"))

        Dim contadorSemana = -1
        Dim semanas = entregas.Select(Function(ingreso)
                                          contadorSemana += 1

                                          Return contadorSemana
                                      End Function).ToList


        tickGenerator.AddMajor(semanas.Max, DateTimePickerHastaEntregasPorSemana.Value.ToString("dd-MM-yyyy"))
        FormsPlotEntregasPorSemana.Plot.XLabel("Semanas")
        FormsPlotEntregasPorSemana.Plot.Axes.SetLimitsX(0, semanas.Max)


        FormsPlotEntregasPorSemana.Plot.Axes.Bottom.TickGenerator = tickGenerator

        If ComboBoxEntregasPorSemana.Text = "Total" Then
            Dim cantidades = entregas.Select(Function(entrega) entrega.Cantidad).ToList

            FormsPlotEntregasPorSemana.Plot.Add.Scatter(semanas, cantidades)
            FormsPlotEntregasPorSemana.Plot.Axes.SetLimitsY(cantidades.Min, cantidades.Max + 1)
            FormsPlotEntregasPorSemana.Plot.Title("Entregas por semana")
            FormsPlotEntregasPorSemana.Plot.YLabel("Entregas")

            FormsPlotEntregasPorSemana.Refresh()

            Return
        End If

        Dim variaciones = entregas.Select(Function(entrega) entrega.Variacion).ToList

        FormsPlotEntregasPorSemana.Plot.Add.Scatter(semanas, variaciones)
        FormsPlotEntregasPorSemana.Plot.Axes.SetLimitsY(variaciones.Min, variaciones.Max + 1)
        FormsPlotEntregasPorSemana.Plot.Title("Variacion de entregas por semana")
        FormsPlotEntregasPorSemana.Plot.YLabel("Variacion entregas")

        FormsPlotEntregasPorSemana.Refresh()
    End Sub

    Private Sub FormEstadisticas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim primerFechaIngreso = _controladorEstadisticas.ObtenerFechaPrimerIngreso()

        DateTimePickerDesdeIngresosPorSemana.Value = primerFechaIngreso
        DateTimePickerDesdeRevisionesPorSemana.Value = primerFechaIngreso
        DateTimePickerDesdeReparacionesPorSemana.Value = primerFechaIngreso
        DateTimePickerDesdeEntregasPorSemana.Value = primerFechaIngreso
        DateTimePickerDesdeFacturacionPorSemana.Value = primerFechaIngreso

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

        Dim tickGenerator = New ScottPlot.TickGenerators.NumericManual()

        For Each equipo In equipos
            Dim barAdded = FormsPlotEquiposPorEstado.Plot.Add.Bars({
                New ScottPlot.Bar With {
                    .Position = indiceColor + 1,
                    .Value = equipo.Cantidad,
                    .FillColor = colores(indiceColor),
                    .Label = equipo.Estado.Replace(" ", Environment.NewLine)
                }
            })

            tickGenerator.AddMajor(indiceColor + 1, equipo.Cantidad)

            barAdded.LegendText = equipo.Estado
            barAdded.ValueLabelStyle.Bold = True
            indiceColor += 1
        Next

        FormsPlotEquiposPorEstado.Plot.Axes.Bottom.TickGenerator = tickGenerator
        FormsPlotEquiposPorEstado.Plot.Axes.Bottom.MajorTickStyle.Length = 0
        FormsPlotEquiposPorEstado.Plot.HideGrid()
        FormsPlotEquiposPorEstado.Plot.FigureBackground.Color = ScottPlot.Colors.White
        FormsPlotEquiposPorEstado.Plot.Axes.Margins(0, 0, 0, 0.2)
        FormsPlotEquiposPorEstado.Plot.Axes.SetLimitsX(0, 9)
        FormsPlotEquiposPorEstado.Plot.ShowLegend(Alignment.UpperRight)

        FormsPlotEquiposPorEstado.Refresh()
    End Sub

    Private Sub ActualizarGraficoFacturacionPorSemana(sender As Object, e As EventArgs) Handles ComboBoxFacturacionPorSemana.SelectedIndexChanged, DateTimePickerDesdeFacturacionPorSemana.ValueChanged, DateTimePickerHastaFacturacionPorSemana.ValueChanged
        FormsPlotFacturacionPorSemana.Plot.Clear()

        Dim fechaInicio As String = DateTimePickerDesdeFacturacionPorSemana.Value.ToString("yyyy-MM-dd")
        Dim fechaFin As String = DateTimePickerHastaFacturacionPorSemana.Value.ToString("yyyy-MM-dd")

        Dim facturaciones = _controladorEstadisticas.ObtenerFacturacionPorSemana(fechaInicio, fechaFin)

        Dim tickGenerator = New ScottPlot.TickGenerators.NumericManual()

        tickGenerator.AddMajor(0, DateTimePickerDesdeFacturacionPorSemana.Value.ToString("dd-MM-yyyy"))

        Dim contadorSemana = -1
        Dim semanas = facturaciones.Select(Function(ingreso)
                                               contadorSemana += 1

                                               Return contadorSemana
                                           End Function).ToList

        tickGenerator.AddMajor(semanas.Max, DateTimePickerHastaFacturacionPorSemana.Value.ToString("dd-MM-yyyy"))
        FormsPlotFacturacionPorSemana.Plot.XLabel("Semanas")
        FormsPlotFacturacionPorSemana.Plot.Axes.SetLimitsX(0, semanas.Max)

        FormsPlotFacturacionPorSemana.Plot.Axes.Bottom.TickGenerator = tickGenerator

        If ComboBoxFacturacionPorSemana.Text = "Total" Then
            Dim cantidades = facturaciones.Select(Function(facturacion) facturacion.Cantidad).ToList

            FormsPlotFacturacionPorSemana.Plot.Add.Scatter(semanas, cantidades)
            FormsPlotFacturacionPorSemana.Plot.Axes.SetLimitsY(cantidades.Min, cantidades.Max + 1)
            FormsPlotFacturacionPorSemana.Plot.Title("Facturacion por semana")
            FormsPlotFacturacionPorSemana.Plot.YLabel("Facturacion")

            FormsPlotFacturacionPorSemana.Refresh()

            Return
        End If

        Dim variaciones = facturaciones.Select(Function(facturacion) facturacion.Variacion).ToList

        FormsPlotFacturacionPorSemana.Plot.Add.Scatter(semanas, variaciones)
        FormsPlotFacturacionPorSemana.Plot.Axes.SetLimitsY(variaciones.Min, variaciones.Max + 1)
        FormsPlotFacturacionPorSemana.Plot.Title("Variacion de facturacion por semana")
        FormsPlotFacturacionPorSemana.Plot.YLabel("Variacion facturacion")

        FormsPlotFacturacionPorSemana.Refresh()
    End Sub
End Class
