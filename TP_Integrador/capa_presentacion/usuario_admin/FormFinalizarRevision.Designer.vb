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
        PBordeSuperior = New Panel()
        SuspendLayout()
        ' 
        ' LObservaciones
        ' 
        LObservaciones.AutoSize = True
        LObservaciones.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LObservaciones.ForeColor = Color.White
        LObservaciones.Location = New Point(22, 223)
        LObservaciones.Name = "LObservaciones"
        LObservaciones.Size = New Size(180, 27)
        LObservaciones.TabIndex = 0
        LObservaciones.Text = "Observaciones"
        ' 
        ' TBObservaciones
        ' 
        TBObservaciones.BackColor = Color.FromArgb(CByte(90), CByte(90), CByte(90))
        TBObservaciones.BorderStyle = BorderStyle.None
        TBObservaciones.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBObservaciones.ForeColor = Color.White
        TBObservaciones.Location = New Point(220, 83)
        TBObservaciones.Multiline = True
        TBObservaciones.Name = "TBObservaciones"
        TBObservaciones.Size = New Size(522, 278)
        TBObservaciones.TabIndex = 39
        ' 
        ' BCargarObservaciones
        ' 
        BCargarObservaciones.BackColor = Color.Black
        BCargarObservaciones.FlatAppearance.BorderSize = 0
        BCargarObservaciones.FlatStyle = FlatStyle.Flat
        BCargarObservaciones.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BCargarObservaciones.ForeColor = Color.White
        BCargarObservaciones.Location = New Point(385, 385)
        BCargarObservaciones.Margin = New Padding(2, 3, 2, 3)
        BCargarObservaciones.Name = "BCargarObservaciones"
        BCargarObservaciones.Size = New Size(197, 37)
        BCargarObservaciones.TabIndex = 41
        BCargarObservaciones.Text = "Cargar observaciones"
        BCargarObservaciones.UseVisualStyleBackColor = False
        ' 
        ' PBordeSuperior
        ' 
        PBordeSuperior.BackColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        PBordeSuperior.Location = New Point(1, 0)
        PBordeSuperior.Name = "PBordeSuperior"
        PBordeSuperior.Size = New Size(803, 46)
        PBordeSuperior.TabIndex = 42
        ' 
        ' FormFinalizarRevision
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(75), CByte(75), CByte(75))
        ClientSize = New Size(800, 450)
        Controls.Add(PBordeSuperior)
        Controls.Add(BCargarObservaciones)
        Controls.Add(TBObservaciones)
        Controls.Add(LObservaciones)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormFinalizarRevision"
        Text = "FormFinalizarRevision"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LObservaciones As Label
    Friend WithEvents TBObservaciones As TextBox
    Friend WithEvents BCargarObservaciones As Button
    Friend WithEvents PBordeSuperior As Panel
End Class
