<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEstadosEquiposAdmin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        ProgressBarEstadosEquipos = New ProgressBar()
        BRevisarEquipo = New Button()
        BFinalizarRevision = New Button()
        BCargarPresupuesto = New Button()
        BAprobarPresupuesto = New Button()
        BDesaprobarPresupuesto = New Button()
        BRepararEquipo = New Button()
        BReparacionExitosa = New Button()
        BIrreparable = New Button()
        BDevolverEquipo = New Button()
        Timer = New Timer(components)
        BInfoRevision = New Button()
        BInfoPresupuesto = New Button()
        BInfoReparacion = New Button()
        LEstadosEquipo = New Label()
        PBordeSuperior = New Panel()
        BCerrar = New Button()
        BGenerarIngreso = New Button()
        BGenerarInforme = New Button()
        BFactura = New Button()
        SuspendLayout()
        ' 
        ' ProgressBarEstadosEquipos
        ' 
        ProgressBarEstadosEquipos.ForeColor = Color.Silver
        ProgressBarEstadosEquipos.Location = New Point(68, 194)
        ProgressBarEstadosEquipos.Name = "ProgressBarEstadosEquipos"
        ProgressBarEstadosEquipos.Size = New Size(1220, 29)
        ProgressBarEstadosEquipos.TabIndex = 0
        ' 
        ' BRevisarEquipo
        ' 
        BRevisarEquipo.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BRevisarEquipo.FlatAppearance.BorderSize = 0
        BRevisarEquipo.FlatStyle = FlatStyle.Flat
        BRevisarEquipo.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BRevisarEquipo.ForeColor = Color.White
        BRevisarEquipo.Location = New Point(68, 241)
        BRevisarEquipo.Margin = New Padding(2, 3, 2, 3)
        BRevisarEquipo.Name = "BRevisarEquipo"
        BRevisarEquipo.Size = New Size(117, 37)
        BRevisarEquipo.TabIndex = 24
        BRevisarEquipo.Text = "Revisar equipo"
        BRevisarEquipo.UseVisualStyleBackColor = False
        ' 
        ' BFinalizarRevision
        ' 
        BFinalizarRevision.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BFinalizarRevision.FlatAppearance.BorderSize = 0
        BFinalizarRevision.FlatStyle = FlatStyle.Flat
        BFinalizarRevision.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BFinalizarRevision.ForeColor = Color.White
        BFinalizarRevision.Location = New Point(207, 241)
        BFinalizarRevision.Margin = New Padding(2, 3, 2, 3)
        BFinalizarRevision.Name = "BFinalizarRevision"
        BFinalizarRevision.Size = New Size(129, 37)
        BFinalizarRevision.TabIndex = 25
        BFinalizarRevision.Text = "Finalizar revisión"
        BFinalizarRevision.UseVisualStyleBackColor = False
        ' 
        ' BCargarPresupuesto
        ' 
        BCargarPresupuesto.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BCargarPresupuesto.FlatAppearance.BorderSize = 0
        BCargarPresupuesto.FlatStyle = FlatStyle.Flat
        BCargarPresupuesto.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BCargarPresupuesto.ForeColor = Color.White
        BCargarPresupuesto.Location = New Point(365, 241)
        BCargarPresupuesto.Margin = New Padding(2, 3, 2, 3)
        BCargarPresupuesto.Name = "BCargarPresupuesto"
        BCargarPresupuesto.Size = New Size(149, 37)
        BCargarPresupuesto.TabIndex = 26
        BCargarPresupuesto.Text = "Cargar presupuesto"
        BCargarPresupuesto.UseVisualStyleBackColor = False
        ' 
        ' BAprobarPresupuesto
        ' 
        BAprobarPresupuesto.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BAprobarPresupuesto.FlatAppearance.BorderSize = 0
        BAprobarPresupuesto.FlatStyle = FlatStyle.Flat
        BAprobarPresupuesto.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BAprobarPresupuesto.ForeColor = Color.White
        BAprobarPresupuesto.Location = New Point(534, 241)
        BAprobarPresupuesto.Margin = New Padding(2, 3, 2, 3)
        BAprobarPresupuesto.Name = "BAprobarPresupuesto"
        BAprobarPresupuesto.Size = New Size(191, 37)
        BAprobarPresupuesto.TabIndex = 27
        BAprobarPresupuesto.Text = "Aprobar presupuesto"
        BAprobarPresupuesto.UseVisualStyleBackColor = False
        ' 
        ' BDesaprobarPresupuesto
        ' 
        BDesaprobarPresupuesto.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BDesaprobarPresupuesto.FlatAppearance.BorderSize = 0
        BDesaprobarPresupuesto.FlatStyle = FlatStyle.Flat
        BDesaprobarPresupuesto.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BDesaprobarPresupuesto.ForeColor = Color.White
        BDesaprobarPresupuesto.Location = New Point(534, 293)
        BDesaprobarPresupuesto.Margin = New Padding(2, 3, 2, 3)
        BDesaprobarPresupuesto.Name = "BDesaprobarPresupuesto"
        BDesaprobarPresupuesto.Size = New Size(191, 37)
        BDesaprobarPresupuesto.TabIndex = 28
        BDesaprobarPresupuesto.Text = "Desaprobar presupuesto"
        BDesaprobarPresupuesto.UseVisualStyleBackColor = False
        ' 
        ' BRepararEquipo
        ' 
        BRepararEquipo.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BRepararEquipo.FlatAppearance.BorderSize = 0
        BRepararEquipo.FlatStyle = FlatStyle.Flat
        BRepararEquipo.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BRepararEquipo.ForeColor = Color.White
        BRepararEquipo.Location = New Point(751, 241)
        BRepararEquipo.Margin = New Padding(2, 3, 2, 3)
        BRepararEquipo.Name = "BRepararEquipo"
        BRepararEquipo.Size = New Size(149, 37)
        BRepararEquipo.TabIndex = 29
        BRepararEquipo.Text = "Reparar equipo"
        BRepararEquipo.UseVisualStyleBackColor = False
        ' 
        ' BReparacionExitosa
        ' 
        BReparacionExitosa.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BReparacionExitosa.FlatAppearance.BorderSize = 0
        BReparacionExitosa.FlatStyle = FlatStyle.Flat
        BReparacionExitosa.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BReparacionExitosa.ForeColor = Color.White
        BReparacionExitosa.Location = New Point(927, 241)
        BReparacionExitosa.Margin = New Padding(2, 3, 2, 3)
        BReparacionExitosa.Name = "BReparacionExitosa"
        BReparacionExitosa.Size = New Size(191, 37)
        BReparacionExitosa.TabIndex = 30
        BReparacionExitosa.Text = "Reparación exitosa"
        BReparacionExitosa.UseVisualStyleBackColor = False
        ' 
        ' BIrreparable
        ' 
        BIrreparable.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BIrreparable.FlatAppearance.BorderSize = 0
        BIrreparable.FlatStyle = FlatStyle.Flat
        BIrreparable.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BIrreparable.ForeColor = Color.White
        BIrreparable.Location = New Point(927, 293)
        BIrreparable.Margin = New Padding(2, 3, 2, 3)
        BIrreparable.Name = "BIrreparable"
        BIrreparable.Size = New Size(191, 37)
        BIrreparable.TabIndex = 31
        BIrreparable.Text = "Irreparable"
        BIrreparable.UseVisualStyleBackColor = False
        ' 
        ' BDevolverEquipo
        ' 
        BDevolverEquipo.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BDevolverEquipo.FlatAppearance.BorderSize = 0
        BDevolverEquipo.FlatStyle = FlatStyle.Flat
        BDevolverEquipo.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BDevolverEquipo.ForeColor = Color.White
        BDevolverEquipo.Location = New Point(1139, 241)
        BDevolverEquipo.Margin = New Padding(2, 3, 2, 3)
        BDevolverEquipo.Name = "BDevolverEquipo"
        BDevolverEquipo.Size = New Size(149, 37)
        BDevolverEquipo.TabIndex = 32
        BDevolverEquipo.Text = "Devolver equipo"
        BDevolverEquipo.UseVisualStyleBackColor = False
        ' 
        ' BInfoRevision
        ' 
        BInfoRevision.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BInfoRevision.FlatAppearance.BorderSize = 0
        BInfoRevision.FlatStyle = FlatStyle.Flat
        BInfoRevision.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BInfoRevision.ForeColor = Color.White
        BInfoRevision.Location = New Point(68, 122)
        BInfoRevision.Margin = New Padding(2, 3, 2, 3)
        BInfoRevision.Name = "BInfoRevision"
        BInfoRevision.Size = New Size(129, 37)
        BInfoRevision.TabIndex = 33
        BInfoRevision.Text = "Info. Revision"
        BInfoRevision.UseVisualStyleBackColor = False
        ' 
        ' BInfoPresupuesto
        ' 
        BInfoPresupuesto.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BInfoPresupuesto.FlatAppearance.BorderSize = 0
        BInfoPresupuesto.FlatStyle = FlatStyle.Flat
        BInfoPresupuesto.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BInfoPresupuesto.ForeColor = Color.White
        BInfoPresupuesto.Location = New Point(223, 122)
        BInfoPresupuesto.Margin = New Padding(2, 3, 2, 3)
        BInfoPresupuesto.Name = "BInfoPresupuesto"
        BInfoPresupuesto.Size = New Size(148, 37)
        BInfoPresupuesto.TabIndex = 34
        BInfoPresupuesto.Text = "Info. Presupuesto"
        BInfoPresupuesto.UseVisualStyleBackColor = False
        ' 
        ' BInfoReparacion
        ' 
        BInfoReparacion.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BInfoReparacion.FlatAppearance.BorderSize = 0
        BInfoReparacion.FlatStyle = FlatStyle.Flat
        BInfoReparacion.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BInfoReparacion.ForeColor = Color.White
        BInfoReparacion.Location = New Point(400, 122)
        BInfoReparacion.Margin = New Padding(2, 3, 2, 3)
        BInfoReparacion.Name = "BInfoReparacion"
        BInfoReparacion.Size = New Size(148, 37)
        BInfoReparacion.TabIndex = 35
        BInfoReparacion.Text = "Info. Reparacion"
        BInfoReparacion.UseVisualStyleBackColor = False
        ' 
        ' LEstadosEquipo
        ' 
        LEstadosEquipo.AutoSize = True
        LEstadosEquipo.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LEstadosEquipo.ForeColor = Color.White
        LEstadosEquipo.Location = New Point(767, 132)
        LEstadosEquipo.Name = "LEstadosEquipo"
        LEstadosEquipo.Size = New Size(101, 27)
        LEstadosEquipo.TabIndex = 36
        LEstadosEquipo.Text = "Estados"
        ' 
        ' PBordeSuperior
        ' 
        PBordeSuperior.BackColor = Color.FromArgb(CByte(26), CByte(25), CByte(72))
        PBordeSuperior.Location = New Point(0, 2)
        PBordeSuperior.Name = "PBordeSuperior"
        PBordeSuperior.Size = New Size(1340, 60)
        PBordeSuperior.TabIndex = 37
        ' 
        ' BCerrar
        ' 
        BCerrar.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BCerrar.FlatAppearance.BorderSize = 0
        BCerrar.FlatStyle = FlatStyle.Flat
        BCerrar.Font = New Font("Microsoft Sans Serif", 14F)
        BCerrar.ForeColor = Color.White
        BCerrar.Location = New Point(519, 525)
        BCerrar.Margin = New Padding(2, 3, 2, 3)
        BCerrar.Name = "BCerrar"
        BCerrar.Size = New Size(292, 64)
        BCerrar.TabIndex = 38
        BCerrar.Text = "Cerrar"
        BCerrar.UseVisualStyleBackColor = False
        ' 
        ' BGenerarIngreso
        ' 
        BGenerarIngreso.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BGenerarIngreso.FlatAppearance.BorderSize = 0
        BGenerarIngreso.FlatStyle = FlatStyle.Flat
        BGenerarIngreso.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BGenerarIngreso.ForeColor = Color.White
        BGenerarIngreso.Location = New Point(68, 418)
        BGenerarIngreso.Margin = New Padding(2, 3, 2, 3)
        BGenerarIngreso.Name = "BGenerarIngreso"
        BGenerarIngreso.Size = New Size(179, 37)
        BGenerarIngreso.TabIndex = 42
        BGenerarIngreso.Text = "Constancia de ingreso"
        BGenerarIngreso.UseVisualStyleBackColor = False
        ' 
        ' BGenerarInforme
        ' 
        BGenerarInforme.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BGenerarInforme.FlatAppearance.BorderSize = 0
        BGenerarInforme.FlatStyle = FlatStyle.Flat
        BGenerarInforme.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BGenerarInforme.ForeColor = Color.White
        BGenerarInforme.Location = New Point(271, 418)
        BGenerarInforme.Margin = New Padding(2, 3, 2, 3)
        BGenerarInforme.Name = "BGenerarInforme"
        BGenerarInforme.Size = New Size(179, 37)
        BGenerarInforme.TabIndex = 43
        BGenerarInforme.Text = "Informe de equipo"
        BGenerarInforme.UseVisualStyleBackColor = False
        ' 
        ' BFactura
        ' 
        BFactura.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BFactura.FlatAppearance.BorderSize = 0
        BFactura.FlatStyle = FlatStyle.Flat
        BFactura.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BFactura.ForeColor = Color.White
        BFactura.Location = New Point(478, 418)
        BFactura.Margin = New Padding(2, 3, 2, 3)
        BFactura.Name = "BFactura"
        BFactura.Size = New Size(179, 37)
        BFactura.TabIndex = 44
        BFactura.Text = "Factura"
        BFactura.UseVisualStyleBackColor = False
        ' 
        ' FormEstadosEquiposAdmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        ClientSize = New Size(1340, 639)
        Controls.Add(BFactura)
        Controls.Add(BGenerarInforme)
        Controls.Add(BGenerarIngreso)
        Controls.Add(BCerrar)
        Controls.Add(PBordeSuperior)
        Controls.Add(LEstadosEquipo)
        Controls.Add(BInfoReparacion)
        Controls.Add(BInfoPresupuesto)
        Controls.Add(BInfoRevision)
        Controls.Add(BDevolverEquipo)
        Controls.Add(BIrreparable)
        Controls.Add(BReparacionExitosa)
        Controls.Add(BRepararEquipo)
        Controls.Add(BDesaprobarPresupuesto)
        Controls.Add(BAprobarPresupuesto)
        Controls.Add(BCargarPresupuesto)
        Controls.Add(BFinalizarRevision)
        Controls.Add(BRevisarEquipo)
        Controls.Add(ProgressBarEstadosEquipos)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormEstadosEquiposAdmin"
        Text = "FormEstadosEquiposAdmin"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ProgressBarEstadosEquipos As ProgressBar
    Friend WithEvents BRevisarEquipo As Button
    Friend WithEvents BFinalizarRevision As Button
    Friend WithEvents BCargarPresupuesto As Button
    Friend WithEvents BAprobarPresupuesto As Button
    Friend WithEvents BDesaprobarPresupuesto As Button
    Friend WithEvents BRepararEquipo As Button
    Friend WithEvents BReparacionExitosa As Button
    Friend WithEvents BIrreparable As Button
    Friend WithEvents BDevolverEquipo As Button
    Friend WithEvents Timer As Timer
    Friend WithEvents BInfoRevision As Button
    Friend WithEvents BInfoPresupuesto As Button
    Friend WithEvents BInfoReparacion As Button
    Friend WithEvents LEstadosEquipo As Label
    Friend WithEvents PBordeSuperior As Panel
    Friend WithEvents BCerrar As Button
    Friend WithEvents BGenerarIngreso As Button
    Friend WithEvents BGenerarInforme As Button
    Friend WithEvents BFactura As Button
End Class
