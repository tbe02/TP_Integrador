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
        FormsPlotEquiposPorEstado.Location = New Point(12, 147)
        FormsPlotEquiposPorEstado.Name = "FormsPlotEquiposPorEstado"
        FormsPlotEquiposPorEstado.Size = New Size(908, 461)
        FormsPlotEquiposPorEstado.TabIndex = 12
        ' 
        ' ComboBoxFacturacionPorSemana
        ' 
        ComboBoxFacturacionPorSemana.FormattingEnabled = True
        ComboBoxFacturacionPorSemana.Items.AddRange(New Object() {"Total", "Variacion"})
        ComboBoxFacturacionPorSemana.Location = New Point(602, 197)
        ComboBoxFacturacionPorSemana.Name = "ComboBoxFacturacionPorSemana"
        ComboBoxFacturacionPorSemana.Size = New Size(168, 23)
        ComboBoxFacturacionPorSemana.TabIndex = 14
        ComboBoxFacturacionPorSemana.Text = "Total"
        ' 
        ' FormsPlotFacturacionPorSemana
        ' 
        FormsPlotFacturacionPorSemana.DisplayScale = 1F
        FormsPlotFacturacionPorSemana.Location = New Point(158, 225)
        FormsPlotFacturacionPorSemana.Name = "FormsPlotFacturacionPorSemana"
        FormsPlotFacturacionPorSemana.Size = New Size(612, 324)
        FormsPlotFacturacionPorSemana.TabIndex = 13
        ' 
        ' FormEstadisticas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        ClientSize = New Size(932, 653)
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
End Class
