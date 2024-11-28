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
        BCargarObservacion = New Button()
        LObservaciones = New Label()
        PBordeSuperior = New Panel()
        SuspendLayout()
        ' 
        ' TBObservaciones
        ' 
        TBObservaciones.BackColor = Color.FromArgb(CByte(90), CByte(90), CByte(90))
        TBObservaciones.BorderStyle = BorderStyle.None
        TBObservaciones.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBObservaciones.ForeColor = Color.White
        TBObservaciones.Location = New Point(240, 72)
        TBObservaciones.Multiline = True
        TBObservaciones.Name = "TBObservaciones"
        TBObservaciones.Size = New Size(502, 293)
        TBObservaciones.TabIndex = 42
        ' 
        ' BCargarObservacion
        ' 
        BCargarObservacion.BackColor = Color.Black
        BCargarObservacion.FlatAppearance.BorderSize = 0
        BCargarObservacion.FlatStyle = FlatStyle.Flat
        BCargarObservacion.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BCargarObservacion.ForeColor = Color.White
        BCargarObservacion.Location = New Point(388, 392)
        BCargarObservacion.Margin = New Padding(2, 3, 2, 3)
        BCargarObservacion.Name = "BCargarObservacion"
        BCargarObservacion.Size = New Size(197, 37)
        BCargarObservacion.TabIndex = 45
        BCargarObservacion.Text = "Cargar observación"
        BCargarObservacion.UseVisualStyleBackColor = False
        ' 
        ' LObservaciones
        ' 
        LObservaciones.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LObservaciones.ForeColor = Color.White
        LObservaciones.Location = New Point(15, 178)
        LObservaciones.Name = "LObservaciones"
        LObservaciones.Size = New Size(219, 77)
        LObservaciones.TabIndex = 46
        LObservaciones.Text = "Qué se realizó en la reparación?"
        ' 
        ' PBordeSuperior
        ' 
        PBordeSuperior.BackColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        PBordeSuperior.Location = New Point(1, 1)
        PBordeSuperior.Name = "PBordeSuperior"
        PBordeSuperior.Size = New Size(800, 46)
        PBordeSuperior.TabIndex = 47
        ' 
        ' FormReparacionEquipo
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(75), CByte(75), CByte(75))
        ClientSize = New Size(800, 450)
        Controls.Add(PBordeSuperior)
        Controls.Add(LObservaciones)
        Controls.Add(BCargarObservacion)
        Controls.Add(TBObservaciones)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormReparacionEquipo"
        Text = "FormReparacionEquipo"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TBObservaciones As TextBox
    Friend WithEvents BCargarObservacion As Button
    Friend WithEvents LObservaciones As Label
    Friend WithEvents PBordeSuperior As Panel
End Class
