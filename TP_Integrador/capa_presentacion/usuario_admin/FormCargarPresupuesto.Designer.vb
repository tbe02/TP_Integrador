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
        TBDetalles = New TextBox()
        TBMonto = New TextBox()
        BCargarPresupuesto = New Button()
        LMonto = New Label()
        LDetalles = New Label()
        PBordeSuperior = New Panel()
        SuspendLayout()
        ' 
        ' TBDetalles
        ' 
        TBDetalles.BackColor = Color.FromArgb(CByte(90), CByte(90), CByte(90))
        TBDetalles.BorderStyle = BorderStyle.None
        TBDetalles.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBDetalles.ForeColor = Color.White
        TBDetalles.Location = New Point(235, 92)
        TBDetalles.Multiline = True
        TBDetalles.Name = "TBDetalles"
        TBDetalles.Size = New Size(597, 323)
        TBDetalles.TabIndex = 40
        ' 
        ' TBMonto
        ' 
        TBMonto.BackColor = Color.FromArgb(CByte(90), CByte(90), CByte(90))
        TBMonto.BorderStyle = BorderStyle.None
        TBMonto.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBMonto.ForeColor = Color.White
        TBMonto.Location = New Point(235, 446)
        TBMonto.Multiline = True
        TBMonto.Name = "TBMonto"
        TBMonto.Size = New Size(248, 33)
        TBMonto.TabIndex = 41
        ' 
        ' BCargarPresupuesto
        ' 
        BCargarPresupuesto.BackColor = Color.Black
        BCargarPresupuesto.FlatAppearance.BorderSize = 0
        BCargarPresupuesto.FlatStyle = FlatStyle.Flat
        BCargarPresupuesto.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BCargarPresupuesto.ForeColor = Color.White
        BCargarPresupuesto.Location = New Point(425, 520)
        BCargarPresupuesto.Margin = New Padding(2, 3, 2, 3)
        BCargarPresupuesto.Name = "BCargarPresupuesto"
        BCargarPresupuesto.Size = New Size(197, 37)
        BCargarPresupuesto.TabIndex = 42
        BCargarPresupuesto.Text = "Cargar presupuesto"
        BCargarPresupuesto.UseVisualStyleBackColor = False
        ' 
        ' LMonto
        ' 
        LMonto.AutoSize = True
        LMonto.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LMonto.ForeColor = Color.White
        LMonto.Location = New Point(112, 446)
        LMonto.Name = "LMonto"
        LMonto.Size = New Size(81, 27)
        LMonto.TabIndex = 43
        LMonto.Text = "Monto"
        ' 
        ' LDetalles
        ' 
        LDetalles.AutoSize = True
        LDetalles.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LDetalles.ForeColor = Color.White
        LDetalles.Location = New Point(90, 92)
        LDetalles.Name = "LDetalles"
        LDetalles.Size = New Size(103, 27)
        LDetalles.TabIndex = 44
        LDetalles.Text = "Detalles"
        ' 
        ' PBordeSuperior
        ' 
        PBordeSuperior.BackColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        PBordeSuperior.Location = New Point(1, 1)
        PBordeSuperior.Name = "PBordeSuperior"
        PBordeSuperior.Size = New Size(1007, 46)
        PBordeSuperior.TabIndex = 45
        ' 
        ' FormCargarPresupuesto
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(75), CByte(75), CByte(75))
        ClientSize = New Size(1007, 594)
        Controls.Add(PBordeSuperior)
        Controls.Add(LDetalles)
        Controls.Add(LMonto)
        Controls.Add(BCargarPresupuesto)
        Controls.Add(TBMonto)
        Controls.Add(TBDetalles)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormCargarPresupuesto"
        Text = "FormCargarPresupuesto"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents TBDetalles As TextBox
    Friend WithEvents TBMonto As TextBox
    Friend WithEvents BCargarPresupuesto As Button
    Friend WithEvents LMonto As Label
    Friend WithEvents LDetalles As Label
    Friend WithEvents PBordeSuperior As Panel
End Class
