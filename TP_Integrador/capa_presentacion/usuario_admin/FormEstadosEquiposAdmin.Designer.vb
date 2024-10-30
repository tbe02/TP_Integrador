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
        Button1 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Button3 = New Button()
        Label3 = New Label()
        Button4 = New Button()
        Button5 = New Button()
        Label4 = New Label()
        Label5 = New Label()
        Button6 = New Button()
        Label6 = New Label()
        Button7 = New Button()
        Label7 = New Label()
        Button8 = New Button()
        Label8 = New Label()
        Label9 = New Label()
        Button9 = New Button()
        Label10 = New Label()
        Label11 = New Label()
        Button10 = New Button()
        Label12 = New Label()
        Button11 = New Button()
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
        SuspendLayout()
        ' 
        ' ProgressBarEstadosEquipos
        ' 
        ProgressBarEstadosEquipos.Location = New Point(70, 101)
        ProgressBarEstadosEquipos.Name = "ProgressBarEstadosEquipos"
        ProgressBarEstadosEquipos.Size = New Size(1220, 29)
        ProgressBarEstadosEquipos.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(118, 296)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 54)
        Button1.TabIndex = 1
        Button1.Text = "Revisar equipo"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(323, 287)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 54)
        Button2.TabIndex = 2
        Button2.Text = "Finalizar revision"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(118, 353)
        Label1.Name = "Label1"
        Label1.Size = New Size(128, 20)
        Label1.TabIndex = 3
        Label1.Text = "Pasa a: en revision"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(307, 344)
        Label2.Name = "Label2"
        Label2.Size = New Size(243, 20)
        Label2.TabIndex = 4
        Label2.Text = "Pasa a: a la espeera de presupuesto"
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(609, 289)
        Button3.Name = "Button3"
        Button3.Size = New Size(118, 52)
        Button3.TabIndex = 5
        Button3.Text = "Cargar presupuesto"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(605, 344)
        Label3.Name = "Label3"
        Label3.Size = New Size(336, 20)
        Label3.TabIndex = 6
        Label3.Text = "Pasa a: a la espera de aprobacion de presupuesto"
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(113, 489)
        Button4.Name = "Button4"
        Button4.Size = New Size(113, 63)
        Button4.TabIndex = 7
        Button4.Text = "Aprobar presupuesto"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(113, 615)
        Button5.Name = "Button5"
        Button5.Size = New Size(113, 63)
        Button5.TabIndex = 8
        Button5.Text = "Desaprobar presupuesto"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(70, 564)
        Label4.Name = "Label4"
        Label4.Size = New Size(220, 20)
        Label4.TabIndex = 9
        Label4.Text = "Pasa a: pendiente de reparacion"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(70, 691)
        Label5.Name = "Label5"
        Label5.Size = New Size(190, 20)
        Label5.TabIndex = 10
        Label5.Text = "Pasa a: listo para la entrega"
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(347, 622)
        Button6.Name = "Button6"
        Button6.Size = New Size(94, 56)
        Button6.TabIndex = 11
        Button6.Text = "Devolver equipo"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(329, 691)
        Label6.Name = "Label6"
        Label6.Size = New Size(182, 20)
        Label6.TabIndex = 12
        Label6.Text = "Pasar a: equipo entregado"
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(347, 489)
        Button7.Name = "Button7"
        Button7.Size = New Size(94, 52)
        Button7.TabIndex = 13
        Button7.Text = "Reparar equipo"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(347, 544)
        Label7.Name = "Label7"
        Label7.Size = New Size(153, 20)
        Label7.TabIndex = 14
        Label7.Text = "Pasar a: en reparacion"
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(577, 407)
        Button8.Name = "Button8"
        Button8.Size = New Size(94, 55)
        Button8.TabIndex = 15
        Button8.Text = "Reparacion exitosa"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(571, 461)
        Label8.Name = "Label8"
        Label8.Size = New Size(0, 20)
        Label8.TabIndex = 16
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(552, 461)
        Label9.Name = "Label9"
        Label9.Size = New Size(195, 20)
        Label9.TabIndex = 17
        Label9.Text = "Pasar a: listo para la entrega"
        ' 
        ' Button9
        ' 
        Button9.Location = New Point(577, 509)
        Button9.Name = "Button9"
        Button9.Size = New Size(94, 55)
        Button9.TabIndex = 18
        Button9.Text = "Irreparable"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(576, 567)
        Label10.Name = "Label10"
        Label10.Size = New Size(195, 20)
        Label10.TabIndex = 19
        Label10.Text = "Pasar a: listo para la entrega"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(835, 464)
        Label11.Name = "Label11"
        Label11.Size = New Size(182, 20)
        Label11.TabIndex = 21
        Label11.Text = "Pasar a: equipo entregado"
        ' 
        ' Button10
        ' 
        Button10.Location = New Point(853, 395)
        Button10.Name = "Button10"
        Button10.Size = New Size(94, 56)
        Button10.TabIndex = 20
        Button10.Text = "Devolver equipo"
        Button10.UseVisualStyleBackColor = True
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(835, 595)
        Label12.Name = "Label12"
        Label12.Size = New Size(182, 20)
        Label12.TabIndex = 23
        Label12.Text = "Pasar a: equipo entregado"
        ' 
        ' Button11
        ' 
        Button11.Location = New Point(853, 526)
        Button11.Name = "Button11"
        Button11.Size = New Size(94, 56)
        Button11.TabIndex = 22
        Button11.Text = "Devolver equipo"
        Button11.UseVisualStyleBackColor = True
        ' 
        ' BRevisarEquipo
        ' 
        BRevisarEquipo.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BRevisarEquipo.FlatAppearance.BorderSize = 0
        BRevisarEquipo.FlatStyle = FlatStyle.Flat
        BRevisarEquipo.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BRevisarEquipo.ForeColor = Color.White
        BRevisarEquipo.Location = New Point(66, 148)
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
        BFinalizarRevision.Location = New Point(209, 148)
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
        BCargarPresupuesto.Location = New Point(367, 148)
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
        BAprobarPresupuesto.Location = New Point(536, 148)
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
        BDesaprobarPresupuesto.Location = New Point(536, 200)
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
        BRepararEquipo.Location = New Point(753, 148)
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
        BReparacionExitosa.Location = New Point(929, 148)
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
        BIrreparable.Location = New Point(929, 200)
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
        BDevolverEquipo.Location = New Point(1141, 148)
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
        BInfoRevision.Location = New Point(70, 29)
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
        BInfoPresupuesto.Location = New Point(225, 29)
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
        BInfoReparacion.Location = New Point(402, 29)
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
        LEstadosEquipo.Location = New Point(1067, 65)
        LEstadosEquipo.Name = "LEstadosEquipo"
        LEstadosEquipo.Size = New Size(60, 20)
        LEstadosEquipo.TabIndex = 36
        LEstadosEquipo.Text = "Estados"
        ' 
        ' FormEstadosEquiposAdmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1340, 817)
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
        Controls.Add(Label12)
        Controls.Add(Button11)
        Controls.Add(Label11)
        Controls.Add(Button10)
        Controls.Add(Label10)
        Controls.Add(Button9)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Button8)
        Controls.Add(Label7)
        Controls.Add(Button7)
        Controls.Add(Label6)
        Controls.Add(Button6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Label3)
        Controls.Add(Button3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ProgressBarEstadosEquipos)
        Name = "FormEstadosEquiposAdmin"
        Text = "FormEstadosEquiposAdmin"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ProgressBarEstadosEquipos As ProgressBar
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Button10 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Button11 As Button
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
End Class
