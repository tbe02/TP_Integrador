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
        LDetalles = New Label()
        LMonto = New Label()
        IBCerrar = New FontAwesome.Sharp.IconButton()
        PBordeSuperior = New Panel()
        PBordeSuperior.SuspendLayout()
        SuspendLayout()
        ' 
        ' TBMonto
        ' 
        TBMonto.BackColor = Color.FromArgb(CByte(90), CByte(90), CByte(90))
        TBMonto.BorderStyle = BorderStyle.None
        TBMonto.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBMonto.ForeColor = Color.Silver
        TBMonto.Location = New Point(146, 440)
        TBMonto.Multiline = True
        TBMonto.Name = "TBMonto"
        TBMonto.Size = New Size(248, 33)
        TBMonto.TabIndex = 45
        ' 
        ' TBDetalles
        ' 
        TBDetalles.BackColor = Color.FromArgb(CByte(90), CByte(90), CByte(90))
        TBDetalles.BorderStyle = BorderStyle.None
        TBDetalles.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBDetalles.ForeColor = Color.Silver
        TBDetalles.Location = New Point(146, 83)
        TBDetalles.Multiline = True
        TBDetalles.Name = "TBDetalles"
        TBDetalles.Size = New Size(597, 323)
        TBDetalles.TabIndex = 44
        ' 
        ' LDetalles
        ' 
        LDetalles.AutoSize = True
        LDetalles.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LDetalles.ForeColor = Color.White
        LDetalles.Location = New Point(37, 86)
        LDetalles.Name = "LDetalles"
        LDetalles.Size = New Size(103, 27)
        LDetalles.TabIndex = 48
        LDetalles.Text = "Detalles"
        ' 
        ' LMonto
        ' 
        LMonto.AutoSize = True
        LMonto.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LMonto.ForeColor = Color.White
        LMonto.Location = New Point(37, 440)
        LMonto.Name = "LMonto"
        LMonto.Size = New Size(81, 27)
        LMonto.TabIndex = 49
        LMonto.Text = "Monto"
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
        IBCerrar.Location = New Point(819, 3)
        IBCerrar.Name = "IBCerrar"
        IBCerrar.Size = New Size(32, 30)
        IBCerrar.TabIndex = 14
        IBCerrar.UseVisualStyleBackColor = False
        ' 
        ' PBordeSuperior
        ' 
        PBordeSuperior.BackColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        PBordeSuperior.Controls.Add(IBCerrar)
        PBordeSuperior.Location = New Point(0, 0)
        PBordeSuperior.Name = "PBordeSuperior"
        PBordeSuperior.Size = New Size(854, 46)
        PBordeSuperior.TabIndex = 45
        ' 
        ' FormInfoPresupuesto
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(75), CByte(75), CByte(75))
        ClientSize = New Size(853, 503)
        Controls.Add(PBordeSuperior)
        Controls.Add(LMonto)
        Controls.Add(LDetalles)
        Controls.Add(TBMonto)
        Controls.Add(TBDetalles)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormInfoPresupuesto"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormInfoPresupuesto"
        PBordeSuperior.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TBMonto As TextBox
    Friend WithEvents TBDetalles As TextBox


    Friend WithEvents LDetalles As Label
    Friend WithEvents LMonto As Label
    Friend WithEvents IBCerrar As FontAwesome.Sharp.IconButton
    Friend WithEvents PBordeSuperior As Panel

End Class
