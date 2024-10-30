<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFinalizarRevision
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
        LObservaciones = New Label()
        TBObservaciones = New TextBox()
        BCargarObservaciones = New Button()
        SuspendLayout()
        ' 
        ' LObservaciones
        ' 
        LObservaciones.AutoSize = True
        LObservaciones.Location = New Point(60, 88)
        LObservaciones.Name = "LObservaciones"
        LObservaciones.Size = New Size(105, 20)
        LObservaciones.TabIndex = 0
        LObservaciones.Text = "Observaciones"
        ' 
        ' TBObservaciones
        ' 
        TBObservaciones.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBObservaciones.BorderStyle = BorderStyle.None
        TBObservaciones.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBObservaciones.ForeColor = Color.White
        TBObservaciones.Location = New Point(215, 86)
        TBObservaciones.Multiline = True
        TBObservaciones.Name = "TBObservaciones"
        TBObservaciones.Size = New Size(502, 229)
        TBObservaciones.TabIndex = 39
        ' 
        ' BCargarObservaciones
        ' 
        BCargarObservaciones.Location = New Point(331, 356)
        BCargarObservaciones.Name = "BCargarObservaciones"
        BCargarObservaciones.Size = New Size(178, 29)
        BCargarObservaciones.TabIndex = 40
        BCargarObservaciones.Text = "Cargar observaciones"
        BCargarObservaciones.UseVisualStyleBackColor = True
        ' 
        ' FormFinalizarRevision
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BCargarObservaciones)
        Controls.Add(TBObservaciones)
        Controls.Add(LObservaciones)
        Name = "FormFinalizarRevision"
        Text = "FormFinalizarRevision"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LObservaciones As Label
    Friend WithEvents TBObservaciones As TextBox
    Friend WithEvents BCargarObservaciones As Button
End Class
