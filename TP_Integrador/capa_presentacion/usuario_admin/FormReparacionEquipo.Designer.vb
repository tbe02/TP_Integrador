<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReparacionEquipo
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
        Lobservaciones = New Label()
        BCargarObservacion = New Button()
        SuspendLayout()
        ' 
        ' TBObservaciones
        ' 
        TBObservaciones.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBObservaciones.BorderStyle = BorderStyle.None
        TBObservaciones.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBObservaciones.ForeColor = Color.White
        TBObservaciones.Location = New Point(239, 49)
        TBObservaciones.Multiline = True
        TBObservaciones.Name = "TBObservaciones"
        TBObservaciones.Size = New Size(502, 293)
        TBObservaciones.TabIndex = 42
        ' 
        ' Lobservaciones
        ' 
        Lobservaciones.AutoSize = True
        Lobservaciones.Location = New Point(12, 49)
        Lobservaciones.Name = "Lobservaciones"
        Lobservaciones.Size = New Size(221, 20)
        Lobservaciones.TabIndex = 43
        Lobservaciones.Text = "Que se realizo en la reparacion?"
        ' 
        ' BCargarObservacion
        ' 
        BCargarObservacion.Location = New Point(337, 374)
        BCargarObservacion.Name = "BCargarObservacion"
        BCargarObservacion.Size = New Size(148, 29)
        BCargarObservacion.TabIndex = 44
        BCargarObservacion.Text = "Cargar observacion"
        BCargarObservacion.UseVisualStyleBackColor = True
        ' 
        ' FormReparacionEquipo
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BCargarObservacion)
        Controls.Add(Lobservaciones)
        Controls.Add(TBObservaciones)
        Name = "FormReparacionEquipo"
        Text = "FormReparacionEquipo"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TBObservaciones As TextBox
    Friend WithEvents Lobservaciones As Label
    Friend WithEvents BCargarObservacion As Button
End Class
