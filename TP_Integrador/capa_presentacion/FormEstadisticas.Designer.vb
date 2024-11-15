<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEstadisticas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        LEstadisticas = New Label()
        FormsPlotIngresosPorSemana = New ScottPlot.WinForms.FormsPlot()
        ComboBoxIngresosPorSemana = New ComboBox()
        ComboBoxRevisionesPorSemana = New ComboBox()
        FormsPlotRevisionesPorSemana = New ScottPlot.WinForms.FormsPlot()
        TituloDeSeccion = New Label()
        ButtonSiguiente = New Button()
        ButtonAnterior = New Button()
        ComboBoxEntregasPorSemana = New ComboBox()
        FormsPlotEntregasPorSemana = New ScottPlot.WinForms.FormsPlot()
        ComboBoxReparacionesPorSemana = New ComboBox()
        FormsPlotReparacionesPorSemana = New ScottPlot.WinForms.FormsPlot()
        FormsPlotEquiposPorEstado = New ScottPlot.WinForms.FormsPlot()
        ComboBoxFacturacionPorSemana = New ComboBox()
        FormsPlotFacturacionPorSemana = New ScottPlot.WinForms.FormsPlot()
        DateTimePickerDesdeFacturacionPorSemana = New DateTimePicker()
        LabelDesdeFacturacionPorSemana = New Label()
        LabelHastaFacturacionPorSemana = New Label()
        DateTimePickerHastaFacturacionPorSemana = New DateTimePicker()
        LabelHastaEquiposPorSemana = New Label()
        DateTimePickerHastaIngresosPorSemana = New DateTimePicker()
        LabelDesdeIngresosPorSemana = New Label()
        DateTimePickerDesdeIngresosPorSemana = New DateTimePicker()
        LabelHastaRevisionesPorSemana = New Label()
        DateTimePickerHastaRevisionesPorSemana = New DateTimePicker()
        LabelDesdeRevisionesPorSemana = New Label()
        DateTimePickerDesdeRevisionesPorSemana = New DateTimePicker()
        LabelHastaReparacionesPorSemana = New Label()
        DateTimePickerHastaReparacionesPorSemana = New DateTimePicker()
        LabelDesdeReparacionesPorSemana = New Label()
        DateTimePickerDesdeReparacionesPorSemana = New DateTimePicker()
        LabelHastaEntregasPorSemana = New Label()
        DateTimePickerHastaEntregasPorSemana = New DateTimePicker()
        LabelDesdeEntregasPorSemana = New Label()
        DateTimePickerDesdeEntregasPorSemana = New DateTimePicker()
        SuspendLayout()
        ' 
        ' LEstadisticas
        ' 
        LEstadisticas.AutoSize = True
        LEstadisticas.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LEstadisticas.ForeColor = Color.Silver
        LEstadisticas.Location = New Point(381, 23)
        LEstadisticas.Name = "LEstadisticas"
        LEstadisticas.Size = New Size(172, 33)
        LEstadisticas.TabIndex = 0
        LEstadisticas.Text = "Estadisticas"
        ' 
        ' FormsPlotIngresosPorSemana
        ' 
        FormsPlotIngresosPorSemana.DisplayScale = 1F
        FormsPlotIngresosPorSemana.Location = New Point(12, 197)
        FormsPlotIngresosPorSemana.Name = "FormsPlotIngresosPorSemana"
        FormsPlotIngresosPorSemana.Size = New Size(429, 324)
        FormsPlotIngresosPorSemana.TabIndex = 1
        ' 
        ' ComboBoxIngresosPorSemana
        ' 
        ComboBoxIngresosPorSemana.FormattingEnabled = True
        ComboBoxIngresosPorSemana.Items.AddRange(New Object() {"Total", "Variacion"})
        ComboBoxIngresosPorSemana.Location = New Point(325, 168)
        ComboBoxIngresosPorSemana.Name = "ComboBoxIngresosPorSemana"
        ComboBoxIngresosPorSemana.Size = New Size(116, 23)
        ComboBoxIngresosPorSemana.TabIndex = 2
        ComboBoxIngresosPorSemana.Text = "Total"
        ' 
        ' ComboBoxRevisionesPorSemana
        ' 
        ComboBoxRevisionesPorSemana.FormattingEnabled = True
        ComboBoxRevisionesPorSemana.Items.AddRange(New Object() {"Total", "Variacion"})
        ComboBoxRevisionesPorSemana.Location = New Point(804, 168)
        ComboBoxRevisionesPorSemana.Name = "ComboBoxRevisionesPorSemana"
        ComboBoxRevisionesPorSemana.Size = New Size(116, 23)
        ComboBoxRevisionesPorSemana.TabIndex = 4
        ComboBoxRevisionesPorSemana.Text = "Total"
        ' 
        ' FormsPlotRevisionesPorSemana
        ' 
        FormsPlotRevisionesPorSemana.DisplayScale = 1F
        FormsPlotRevisionesPorSemana.Location = New Point(491, 197)
        FormsPlotRevisionesPorSemana.Name = "FormsPlotRevisionesPorSemana"
        FormsPlotRevisionesPorSemana.Size = New Size(429, 324)
        FormsPlotRevisionesPorSemana.TabIndex = 3
        ' 
        ' TituloDeSeccion
        ' 
        TituloDeSeccion.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TituloDeSeccion.ForeColor = Color.Silver
        TituloDeSeccion.Location = New Point(184, 86)
        TituloDeSeccion.Name = "TituloDeSeccion"
        TituloDeSeccion.Size = New Size(561, 33)
        TituloDeSeccion.TabIndex = 5
        TituloDeSeccion.Text = "Ingresos y revisiones"
        TituloDeSeccion.TextAlign = ContentAlignment.TopCenter
        ' 
        ' ButtonSiguiente
        ' 
        ButtonSiguiente.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        ButtonSiguiente.FlatAppearance.BorderSize = 0
        ButtonSiguiente.FlatStyle = FlatStyle.Flat
        ButtonSiguiente.Font = New Font("Microsoft Sans Serif", 12F)
        ButtonSiguiente.ForeColor = Color.White
        ButtonSiguiente.Location = New Point(751, 91)
        ButtonSiguiente.Name = "ButtonSiguiente"
        ButtonSiguiente.Size = New Size(110, 33)
        ButtonSiguiente.TabIndex = 6
        ButtonSiguiente.Text = "Siguiente >"
        ButtonSiguiente.UseVisualStyleBackColor = False
        ' 
        ' ButtonAnterior
        ' 
        ButtonAnterior.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        ButtonAnterior.FlatAppearance.BorderSize = 0
        ButtonAnterior.FlatStyle = FlatStyle.Flat
        ButtonAnterior.Font = New Font("Microsoft Sans Serif", 12F)
        ButtonAnterior.ForeColor = Color.White
        ButtonAnterior.Location = New Point(68, 91)
        ButtonAnterior.Name = "ButtonAnterior"
        ButtonAnterior.Size = New Size(110, 33)
        ButtonAnterior.TabIndex = 7
        ButtonAnterior.Text = "< Anterior"
        ButtonAnterior.UseVisualStyleBackColor = False
        ' 
        ' ComboBoxEntregasPorSemana
        ' 
        ComboBoxEntregasPorSemana.FormattingEnabled = True
        ComboBoxEntregasPorSemana.Items.AddRange(New Object() {"Total", "Variacion"})
        ComboBoxEntregasPorSemana.Location = New Point(804, 168)
        ComboBoxEntregasPorSemana.Name = "ComboBoxEntregasPorSemana"
        ComboBoxEntregasPorSemana.Size = New Size(116, 23)
        ComboBoxEntregasPorSemana.TabIndex = 11
        ComboBoxEntregasPorSemana.Text = "Total"
        ' 
        ' FormsPlotEntregasPorSemana
        ' 
        FormsPlotEntregasPorSemana.DisplayScale = 1F
        FormsPlotEntregasPorSemana.Location = New Point(491, 197)
        FormsPlotEntregasPorSemana.Name = "FormsPlotEntregasPorSemana"
        FormsPlotEntregasPorSemana.Size = New Size(429, 324)
        FormsPlotEntregasPorSemana.TabIndex = 10
        ' 
        ' ComboBoxReparacionesPorSemana
        ' 
        ComboBoxReparacionesPorSemana.FormattingEnabled = True
        ComboBoxReparacionesPorSemana.Items.AddRange(New Object() {"Total", "Variacion"})
        ComboBoxReparacionesPorSemana.Location = New Point(325, 168)
        ComboBoxReparacionesPorSemana.Name = "ComboBoxReparacionesPorSemana"
        ComboBoxReparacionesPorSemana.Size = New Size(116, 23)
        ComboBoxReparacionesPorSemana.TabIndex = 9
        ComboBoxReparacionesPorSemana.Text = "Total"
        ' 
        ' FormsPlotReparacionesPorSemana
        ' 
        FormsPlotReparacionesPorSemana.DisplayScale = 1F
        FormsPlotReparacionesPorSemana.Location = New Point(12, 197)
        FormsPlotReparacionesPorSemana.Name = "FormsPlotReparacionesPorSemana"
        FormsPlotReparacionesPorSemana.Size = New Size(429, 324)
        FormsPlotReparacionesPorSemana.TabIndex = 8
        ' 
        ' FormsPlotEquiposPorEstado
        ' 
        FormsPlotEquiposPorEstado.DisplayScale = 1F
        FormsPlotEquiposPorEstado.Location = New Point(12, 153)
        FormsPlotEquiposPorEstado.Name = "FormsPlotEquiposPorEstado"
        FormsPlotEquiposPorEstado.Size = New Size(908, 461)
        FormsPlotEquiposPorEstado.TabIndex = 12
        ' 
        ' ComboBoxFacturacionPorSemana
        ' 
        ComboBoxFacturacionPorSemana.FormattingEnabled = True
        ComboBoxFacturacionPorSemana.Items.AddRange(New Object() {"Total", "Variacion"})
        ComboBoxFacturacionPorSemana.Location = New Point(603, 187)
        ComboBoxFacturacionPorSemana.Name = "ComboBoxFacturacionPorSemana"
        ComboBoxFacturacionPorSemana.Size = New Size(168, 23)
        ComboBoxFacturacionPorSemana.TabIndex = 14
        ComboBoxFacturacionPorSemana.Text = "Total"
        ' 
        ' FormsPlotFacturacionPorSemana
        ' 
        FormsPlotFacturacionPorSemana.DisplayScale = 1F
        FormsPlotFacturacionPorSemana.Location = New Point(159, 215)
        FormsPlotFacturacionPorSemana.Name = "FormsPlotFacturacionPorSemana"
        FormsPlotFacturacionPorSemana.Size = New Size(612, 324)
        FormsPlotFacturacionPorSemana.TabIndex = 13
        ' 
        ' DateTimePickerDesdeFacturacionPorSemana
        ' 
        DateTimePickerDesdeFacturacionPorSemana.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        DateTimePickerDesdeFacturacionPorSemana.CustomFormat = "dd/MM/yyyy"
        DateTimePickerDesdeFacturacionPorSemana.Location = New Point(522, 545)
        DateTimePickerDesdeFacturacionPorSemana.Name = "DateTimePickerDesdeFacturacionPorSemana"
        DateTimePickerDesdeFacturacionPorSemana.Size = New Size(99, 23)
        DateTimePickerDesdeFacturacionPorSemana.TabIndex = 15
        ' 
        ' LabelDesdeFacturacionPorSemana
        ' 
        LabelDesdeFacturacionPorSemana.ForeColor = Color.White
        LabelDesdeFacturacionPorSemana.Location = New Point(477, 545)
        LabelDesdeFacturacionPorSemana.Name = "LabelDesdeFacturacionPorSemana"
        LabelDesdeFacturacionPorSemana.Size = New Size(48, 23)
        LabelDesdeFacturacionPorSemana.TabIndex = 16
        LabelDesdeFacturacionPorSemana.Text = "Desde:"
        LabelDesdeFacturacionPorSemana.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LabelHastaFacturacionPorSemana
        ' 
        LabelHastaFacturacionPorSemana.ForeColor = Color.White
        LabelHastaFacturacionPorSemana.Location = New Point(627, 545)
        LabelHastaFacturacionPorSemana.Name = "LabelHastaFacturacionPorSemana"
        LabelHastaFacturacionPorSemana.Size = New Size(48, 23)
        LabelHastaFacturacionPorSemana.TabIndex = 18
        LabelHastaFacturacionPorSemana.Text = "Hasta:"
        LabelHastaFacturacionPorSemana.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' DateTimePickerHastaFacturacionPorSemana
        ' 
        DateTimePickerHastaFacturacionPorSemana.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        DateTimePickerHastaFacturacionPorSemana.CustomFormat = "dd/MM/yyyy"
        DateTimePickerHastaFacturacionPorSemana.Location = New Point(672, 545)
        DateTimePickerHastaFacturacionPorSemana.Name = "DateTimePickerHastaFacturacionPorSemana"
        DateTimePickerHastaFacturacionPorSemana.Size = New Size(99, 23)
        DateTimePickerHastaFacturacionPorSemana.TabIndex = 17
        ' 
        ' LabelHastaEquiposPorSemana
        ' 
        LabelHastaEquiposPorSemana.ForeColor = Color.White
        LabelHastaEquiposPorSemana.Location = New Point(298, 527)
        LabelHastaEquiposPorSemana.Name = "LabelHastaEquiposPorSemana"
        LabelHastaEquiposPorSemana.Size = New Size(48, 23)
        LabelHastaEquiposPorSemana.TabIndex = 22
        LabelHastaEquiposPorSemana.Text = "Hasta:"
        LabelHastaEquiposPorSemana.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' DateTimePickerHastaIngresosPorSemana
        ' 
        DateTimePickerHastaIngresosPorSemana.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        DateTimePickerHastaIngresosPorSemana.CustomFormat = "dd/MM/yyyy"
        DateTimePickerHastaIngresosPorSemana.Location = New Point(343, 527)
        DateTimePickerHastaIngresosPorSemana.Name = "DateTimePickerHastaIngresosPorSemana"
        DateTimePickerHastaIngresosPorSemana.Size = New Size(99, 23)
        DateTimePickerHastaIngresosPorSemana.TabIndex = 21
        ' 
        ' LabelDesdeIngresosPorSemana
        ' 
        LabelDesdeIngresosPorSemana.ForeColor = Color.White
        LabelDesdeIngresosPorSemana.Location = New Point(148, 527)
        LabelDesdeIngresosPorSemana.Name = "LabelDesdeIngresosPorSemana"
        LabelDesdeIngresosPorSemana.Size = New Size(48, 23)
        LabelDesdeIngresosPorSemana.TabIndex = 20
        LabelDesdeIngresosPorSemana.Text = "Desde:"
        LabelDesdeIngresosPorSemana.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' DateTimePickerDesdeIngresosPorSemana
        ' 
        DateTimePickerDesdeIngresosPorSemana.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        DateTimePickerDesdeIngresosPorSemana.CustomFormat = "dd/MM/yyyy"
        DateTimePickerDesdeIngresosPorSemana.Location = New Point(193, 527)
        DateTimePickerDesdeIngresosPorSemana.Name = "DateTimePickerDesdeIngresosPorSemana"
        DateTimePickerDesdeIngresosPorSemana.Size = New Size(99, 23)
        DateTimePickerDesdeIngresosPorSemana.TabIndex = 19
        ' 
        ' LabelHastaRevisionesPorSemana
        ' 
        LabelHastaRevisionesPorSemana.ForeColor = Color.White
        LabelHastaRevisionesPorSemana.Location = New Point(777, 525)
        LabelHastaRevisionesPorSemana.Name = "LabelHastaRevisionesPorSemana"
        LabelHastaRevisionesPorSemana.Size = New Size(48, 23)
        LabelHastaRevisionesPorSemana.TabIndex = 26
        LabelHastaRevisionesPorSemana.Text = "Hasta:"
        LabelHastaRevisionesPorSemana.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' DateTimePickerHastaRevisionesPorSemana
        ' 
        DateTimePickerHastaRevisionesPorSemana.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        DateTimePickerHastaRevisionesPorSemana.CustomFormat = "dd/MM/yyyy"
        DateTimePickerHastaRevisionesPorSemana.Location = New Point(822, 525)
        DateTimePickerHastaRevisionesPorSemana.Name = "DateTimePickerHastaRevisionesPorSemana"
        DateTimePickerHastaRevisionesPorSemana.Size = New Size(99, 23)
        DateTimePickerHastaRevisionesPorSemana.TabIndex = 25
        ' 
        ' LabelDesdeRevisionesPorSemana
        ' 
        LabelDesdeRevisionesPorSemana.ForeColor = Color.White
        LabelDesdeRevisionesPorSemana.Location = New Point(627, 525)
        LabelDesdeRevisionesPorSemana.Name = "LabelDesdeRevisionesPorSemana"
        LabelDesdeRevisionesPorSemana.Size = New Size(48, 23)
        LabelDesdeRevisionesPorSemana.TabIndex = 24
        LabelDesdeRevisionesPorSemana.Text = "Desde:"
        LabelDesdeRevisionesPorSemana.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' DateTimePickerDesdeRevisionesPorSemana
        ' 
        DateTimePickerDesdeRevisionesPorSemana.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        DateTimePickerDesdeRevisionesPorSemana.CustomFormat = "dd/MM/yyyy"
        DateTimePickerDesdeRevisionesPorSemana.Location = New Point(672, 525)
        DateTimePickerDesdeRevisionesPorSemana.Name = "DateTimePickerDesdeRevisionesPorSemana"
        DateTimePickerDesdeRevisionesPorSemana.Size = New Size(99, 23)
        DateTimePickerDesdeRevisionesPorSemana.TabIndex = 23
        ' 
        ' LabelHastaReparacionesPorSemana
        ' 
        LabelHastaReparacionesPorSemana.ForeColor = Color.White
        LabelHastaReparacionesPorSemana.Location = New Point(298, 527)
        LabelHastaReparacionesPorSemana.Name = "LabelHastaReparacionesPorSemana"
        LabelHastaReparacionesPorSemana.Size = New Size(48, 23)
        LabelHastaReparacionesPorSemana.TabIndex = 30
        LabelHastaReparacionesPorSemana.Text = "Hasta:"
        LabelHastaReparacionesPorSemana.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' DateTimePickerHastaReparacionesPorSemana
        ' 
        DateTimePickerHastaReparacionesPorSemana.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        DateTimePickerHastaReparacionesPorSemana.CustomFormat = "dd/MM/yyyy"
        DateTimePickerHastaReparacionesPorSemana.Location = New Point(343, 527)
        DateTimePickerHastaReparacionesPorSemana.Name = "DateTimePickerHastaReparacionesPorSemana"
        DateTimePickerHastaReparacionesPorSemana.Size = New Size(99, 23)
        DateTimePickerHastaReparacionesPorSemana.TabIndex = 29
        ' 
        ' LabelDesdeReparacionesPorSemana
        ' 
        LabelDesdeReparacionesPorSemana.ForeColor = Color.White
        LabelDesdeReparacionesPorSemana.Location = New Point(148, 527)
        LabelDesdeReparacionesPorSemana.Name = "LabelDesdeReparacionesPorSemana"
        LabelDesdeReparacionesPorSemana.Size = New Size(48, 23)
        LabelDesdeReparacionesPorSemana.TabIndex = 28
        LabelDesdeReparacionesPorSemana.Text = "Desde:"
        LabelDesdeReparacionesPorSemana.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' DateTimePickerDesdeReparacionesPorSemana
        ' 
        DateTimePickerDesdeReparacionesPorSemana.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        DateTimePickerDesdeReparacionesPorSemana.CustomFormat = "dd/MM/yyyy"
        DateTimePickerDesdeReparacionesPorSemana.Location = New Point(193, 527)
        DateTimePickerDesdeReparacionesPorSemana.Name = "DateTimePickerDesdeReparacionesPorSemana"
        DateTimePickerDesdeReparacionesPorSemana.Size = New Size(99, 23)
        DateTimePickerDesdeReparacionesPorSemana.TabIndex = 27
        ' 
        ' LabelHastaEntregasPorSemana
        ' 
        LabelHastaEntregasPorSemana.ForeColor = Color.White
        LabelHastaEntregasPorSemana.Location = New Point(777, 525)
        LabelHastaEntregasPorSemana.Name = "LabelHastaEntregasPorSemana"
        LabelHastaEntregasPorSemana.Size = New Size(48, 23)
        LabelHastaEntregasPorSemana.TabIndex = 34
        LabelHastaEntregasPorSemana.Text = "Hasta:"
        LabelHastaEntregasPorSemana.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' DateTimePickerHastaEntregasPorSemana
        ' 
        DateTimePickerHastaEntregasPorSemana.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        DateTimePickerHastaEntregasPorSemana.CustomFormat = "dd/MM/yyyy"
        DateTimePickerHastaEntregasPorSemana.Location = New Point(822, 525)
        DateTimePickerHastaEntregasPorSemana.Name = "DateTimePickerHastaEntregasPorSemana"
        DateTimePickerHastaEntregasPorSemana.Size = New Size(99, 23)
        DateTimePickerHastaEntregasPorSemana.TabIndex = 33
        ' 
        ' LabelDesdeEntregasPorSemana
        ' 
        LabelDesdeEntregasPorSemana.ForeColor = Color.White
        LabelDesdeEntregasPorSemana.Location = New Point(627, 525)
        LabelDesdeEntregasPorSemana.Name = "LabelDesdeEntregasPorSemana"
        LabelDesdeEntregasPorSemana.Size = New Size(48, 23)
        LabelDesdeEntregasPorSemana.TabIndex = 32
        LabelDesdeEntregasPorSemana.Text = "Desde:"
        LabelDesdeEntregasPorSemana.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' DateTimePickerDesdeEntregasPorSemana
        ' 
        DateTimePickerDesdeEntregasPorSemana.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        DateTimePickerDesdeEntregasPorSemana.CustomFormat = "dd/MM/yyyy"
        DateTimePickerDesdeEntregasPorSemana.Location = New Point(672, 525)
        DateTimePickerDesdeEntregasPorSemana.Name = "DateTimePickerDesdeEntregasPorSemana"
        DateTimePickerDesdeEntregasPorSemana.Size = New Size(99, 23)
        DateTimePickerDesdeEntregasPorSemana.TabIndex = 31
        ' 
        ' FormEstadisticas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        ClientSize = New Size(932, 653)
        Controls.Add(LabelHastaEntregasPorSemana)
        Controls.Add(DateTimePickerHastaEntregasPorSemana)
        Controls.Add(LabelDesdeEntregasPorSemana)
        Controls.Add(DateTimePickerDesdeEntregasPorSemana)
        Controls.Add(LabelHastaReparacionesPorSemana)
        Controls.Add(DateTimePickerHastaReparacionesPorSemana)
        Controls.Add(LabelDesdeReparacionesPorSemana)
        Controls.Add(DateTimePickerDesdeReparacionesPorSemana)
        Controls.Add(LabelHastaRevisionesPorSemana)
        Controls.Add(DateTimePickerHastaRevisionesPorSemana)
        Controls.Add(LabelDesdeRevisionesPorSemana)
        Controls.Add(DateTimePickerDesdeRevisionesPorSemana)
        Controls.Add(LabelHastaEquiposPorSemana)
        Controls.Add(DateTimePickerHastaIngresosPorSemana)
        Controls.Add(LabelDesdeIngresosPorSemana)
        Controls.Add(DateTimePickerDesdeIngresosPorSemana)
        Controls.Add(LabelHastaFacturacionPorSemana)
        Controls.Add(DateTimePickerHastaFacturacionPorSemana)
        Controls.Add(LabelDesdeFacturacionPorSemana)
        Controls.Add(DateTimePickerDesdeFacturacionPorSemana)
        Controls.Add(ComboBoxFacturacionPorSemana)
        Controls.Add(FormsPlotFacturacionPorSemana)
        Controls.Add(FormsPlotEquiposPorEstado)
        Controls.Add(ComboBoxEntregasPorSemana)
        Controls.Add(FormsPlotEntregasPorSemana)
        Controls.Add(ComboBoxReparacionesPorSemana)
        Controls.Add(FormsPlotReparacionesPorSemana)
        Controls.Add(ButtonAnterior)
        Controls.Add(ButtonSiguiente)
        Controls.Add(TituloDeSeccion)
        Controls.Add(ComboBoxRevisionesPorSemana)
        Controls.Add(FormsPlotRevisionesPorSemana)
        Controls.Add(ComboBoxIngresosPorSemana)
        Controls.Add(FormsPlotIngresosPorSemana)
        Controls.Add(LEstadisticas)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormEstadisticas"
        Text = "FormEstadisticas"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LEstadisticas As Label
    Friend WithEvents FormsPlotIngresosPorSemana As ScottPlot.WinForms.FormsPlot
    Friend WithEvents ComboBoxIngresosPorSemana As ComboBox
    Friend WithEvents ComboBoxRevisionesPorSemana As ComboBox
    Friend WithEvents FormsPlotRevisionesPorSemana As ScottPlot.WinForms.FormsPlot
    Friend WithEvents TituloDeSeccion As Label
    Friend WithEvents ButtonSiguiente As Button
    Friend WithEvents ButtonAnterior As Button
    Friend WithEvents ComboBoxEntregasPorSemana As ComboBox
    Friend WithEvents FormsPlotEntregasPorSemana As ScottPlot.WinForms.FormsPlot
    Friend WithEvents ComboBoxReparacionesPorSemana As ComboBox
    Friend WithEvents FormsPlotReparacionesPorSemana As ScottPlot.WinForms.FormsPlot
    Friend WithEvents FormsPlotEquiposPorEstado As ScottPlot.WinForms.FormsPlot
    Friend WithEvents ComboBoxFacturacionPorSemana As ComboBox
    Friend WithEvents FormsPlotFacturacionPorSemana As ScottPlot.WinForms.FormsPlot
    Friend WithEvents DateTimePickerDesdeFacturacionPorSemana As DateTimePicker
    Friend WithEvents LabelDesdeFacturacionPorSemana As Label
    Friend WithEvents LabelHastaFacturacionPorSemana As Label
    Friend WithEvents DateTimePickerHastaFacturacionPorSemana As DateTimePicker
    Friend WithEvents LabelHastaEquiposPorSemana As Label
    Friend WithEvents DateTimePickerHastaIngresosPorSemana As DateTimePicker
    Friend WithEvents LabelDesdeIngresosPorSemana As Label
    Friend WithEvents DateTimePickerDesdeIngresosPorSemana As DateTimePicker
    Friend WithEvents LabelHastaRevisionesPorSemana As Label
    Friend WithEvents DateTimePickerHastaRevisionesPorSemana As DateTimePicker
    Friend WithEvents LabelDesdeRevisionesPorSemana As Label
    Friend WithEvents DateTimePickerDesdeRevisionesPorSemana As DateTimePicker
    Friend WithEvents LabelHastaReparacionesPorSemana As Label
    Friend WithEvents DateTimePickerHastaReparacionesPorSemana As DateTimePicker
    Friend WithEvents LabelDesdeReparacionesPorSemana As Label
    Friend WithEvents DateTimePickerDesdeReparacionesPorSemana As DateTimePicker
    Friend WithEvents LabelHastaEntregasPorSemana As Label
    Friend WithEvents DateTimePickerHastaEntregasPorSemana As DateTimePicker
    Friend WithEvents LabelDesdeEntregasPorSemana As Label
    Friend WithEvents DateTimePickerDesdeEntregasPorSemana As DateTimePicker
End Class
