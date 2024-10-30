<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInfoPresupuesto
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
        TBMonto = New TextBox()
        TBDetalles = New TextBox()
        LMonto = New Label()
        LDetalles = New Label()
        SuspendLayout()
        ' 
        ' TBMonto
        ' 
        TBMonto.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBMonto.BorderStyle = BorderStyle.None
        TBMonto.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBMonto.ForeColor = Color.Silver
        TBMonto.Location = New Point(163, 386)
        TBMonto.Multiline = True
        TBMonto.Name = "TBMonto"
        TBMonto.Size = New Size(248, 33)
        TBMonto.TabIndex = 45
        ' 
        ' TBDetalles
        ' 
        TBDetalles.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBDetalles.BorderStyle = BorderStyle.None
        TBDetalles.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBDetalles.ForeColor = Color.Silver
        TBDetalles.Location = New Point(163, 32)
        TBDetalles.Multiline = True
        TBDetalles.Name = "TBDetalles"
        TBDetalles.Size = New Size(597, 323)
        TBDetalles.TabIndex = 44
        ' 
        ' LMonto
        ' 
        LMonto.AutoSize = True
        LMonto.Location = New Point(40, 388)
        LMonto.Name = "LMonto"
        LMonto.Size = New Size(53, 20)
        LMonto.TabIndex = 43
        LMonto.Text = "Monto"
        ' 
        ' LDetalles
        ' 
        LDetalles.AutoSize = True
        LDetalles.Location = New Point(40, 32)
        LDetalles.Name = "LDetalles"
        LDetalles.Size = New Size(63, 20)
        LDetalles.TabIndex = 42
        LDetalles.Text = "Detalles"
        ' 
        ' FormInfoPresupuesto
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TBMonto)
        Controls.Add(TBDetalles)
        Controls.Add(LMonto)
        Controls.Add(LDetalles)
        Name = "FormInfoPresupuesto"
        Text = "FormInfoPresupuesto"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TBMonto As TextBox
    Friend WithEvents TBDetalles As TextBox
    Friend WithEvents LMonto As Label
    Friend WithEvents LDetalles As Label
End Class
