﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInfoReparacion
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
        TBObservaciones = New TextBox()
        PBordeSuperior = New Panel()
        IBCerrar = New FontAwesome.Sharp.IconButton()
        LObservaciones = New Label()
        PBordeSuperior.SuspendLayout()
        SuspendLayout()
        ' 
        ' TBObservaciones
        ' 
        TBObservaciones.BackColor = Color.FromArgb(CByte(90), CByte(90), CByte(90))
        TBObservaciones.BorderStyle = BorderStyle.None
        TBObservaciones.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBObservaciones.ForeColor = Color.White
        TBObservaciones.Location = New Point(263, 100)
        TBObservaciones.Multiline = True
        TBObservaciones.Name = "TBObservaciones"
        TBObservaciones.Size = New Size(502, 293)
        TBObservaciones.TabIndex = 44
        ' 
        ' PBordeSuperior
        ' 
        PBordeSuperior.BackColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        PBordeSuperior.Controls.Add(IBCerrar)
        PBordeSuperior.Location = New Point(1, 1)
        PBordeSuperior.Name = "PBordeSuperior"
        PBordeSuperior.Size = New Size(803, 46)
        PBordeSuperior.TabIndex = 46
        ' 
        ' IBCerrar
        ' 
        IBCerrar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        IBCerrar.BackColor = Color.Transparent
        IBCerrar.FlatAppearance.BorderSize = 0
        IBCerrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        IBCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        IBCerrar.FlatStyle = FlatStyle.Flat
        IBCerrar.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        IBCerrar.ForeColor = Color.White
        IBCerrar.IconChar = FontAwesome.Sharp.IconChar.Close
        IBCerrar.IconColor = Color.Gray
        IBCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto
        IBCerrar.IconSize = 25
        IBCerrar.Location = New Point(768, 0)
        IBCerrar.Name = "IBCerrar"
        IBCerrar.Size = New Size(32, 30)
        IBCerrar.TabIndex = 47
        IBCerrar.UseVisualStyleBackColor = False
        ' 
        ' LObservaciones
        ' 
        LObservaciones.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LObservaciones.ForeColor = Color.White
        LObservaciones.Location = New Point(28, 192)
        LObservaciones.Name = "LObservaciones"
        LObservaciones.Size = New Size(219, 77)
        LObservaciones.TabIndex = 48
        LObservaciones.Text = "Qué se realizó en la reparación?"
        ' 
        ' FormInfoReparacion
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(75), CByte(75), CByte(75))
        ClientSize = New Size(800, 450)
        Controls.Add(LObservaciones)
        Controls.Add(PBordeSuperior)
        Controls.Add(TBObservaciones)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormInfoReparacion"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormInfoReparacion"
        PBordeSuperior.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TBObservaciones As TextBox
    Friend WithEvents PBordeSuperior As Panel
    Friend WithEvents IBCerrar As FontAwesome.Sharp.IconButton
    Friend WithEvents LObservaciones As Label

End Class