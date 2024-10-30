<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCargarPresupuesto
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
        LDetalles = New Label()
        LMonto = New Label()
        TBDetalles = New TextBox()
        TBMonto = New TextBox()
        BCargarPresupuesto = New Button()
        SuspendLayout()
        ' 
        ' LDetalles
        ' 
        LDetalles.AutoSize = True
        LDetalles.Location = New Point(74, 59)
        LDetalles.Name = "LDetalles"
        LDetalles.Size = New Size(63, 20)
        LDetalles.TabIndex = 0
        LDetalles.Text = "Detalles"
        ' 
        ' LMonto
        ' 
        LMonto.AutoSize = True
        LMonto.Location = New Point(74, 415)
        LMonto.Name = "LMonto"
        LMonto.Size = New Size(53, 20)
        LMonto.TabIndex = 1
        LMonto.Text = "Monto"
        ' 
        ' TBDetalles
        ' 
        TBDetalles.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBDetalles.BorderStyle = BorderStyle.None
        TBDetalles.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBDetalles.ForeColor = Color.Silver
        TBDetalles.Location = New Point(197, 59)
        TBDetalles.Multiline = True
        TBDetalles.Name = "TBDetalles"
        TBDetalles.Size = New Size(597, 323)
        TBDetalles.TabIndex = 40
        ' 
        ' TBMonto
        ' 
        TBMonto.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBMonto.BorderStyle = BorderStyle.None
        TBMonto.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBMonto.ForeColor = Color.Silver
        TBMonto.Location = New Point(197, 413)
        TBMonto.Multiline = True
        TBMonto.Name = "TBMonto"
        TBMonto.Size = New Size(248, 33)
        TBMonto.TabIndex = 41
        ' 
        ' BCargarPresupuesto
        ' 
        BCargarPresupuesto.Location = New Point(436, 494)
        BCargarPresupuesto.Name = "BCargarPresupuesto"
        BCargarPresupuesto.Size = New Size(181, 29)
        BCargarPresupuesto.TabIndex = 42
        BCargarPresupuesto.Text = "Cargar presupuesto"
        BCargarPresupuesto.UseVisualStyleBackColor = True
        ' 
        ' FormCargarPresupuesto
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1007, 594)
        Controls.Add(BCargarPresupuesto)
        Controls.Add(TBMonto)
        Controls.Add(TBDetalles)
        Controls.Add(LMonto)
        Controls.Add(LDetalles)
        Name = "FormCargarPresupuesto"
        Text = "FormCargarPresupuesto"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LDetalles As Label
    Friend WithEvents LMonto As Label
    Friend WithEvents TBDetalles As TextBox
    Friend WithEvents TBMonto As TextBox
    Friend WithEvents BCargarPresupuesto As Button
End Class
