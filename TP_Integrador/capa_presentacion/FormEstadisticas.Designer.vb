<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEstadisticas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        LEstadisticas = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' LEstadisticas
        ' 
        LEstadisticas.AutoSize = True
        LEstadisticas.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LEstadisticas.ForeColor = Color.Silver
        LEstadisticas.Location = New Point(325, 33)
        LEstadisticas.Name = "LEstadisticas"
        LEstadisticas.Size = New Size(172, 33)
        LEstadisticas.TabIndex = 0
        LEstadisticas.Text = "Estadisticas"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Silver
        Label1.Location = New Point(225, 266)
        Label1.Name = "Label1"
        Label1.Size = New Size(578, 33)
        Label1.TabIndex = 1
        Label1.Text = "Estadisticas no disponibles por el momento"
        ' 
        ' FormEstadisticas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        ClientSize = New Size(932, 653)
        Controls.Add(Label1)
        Controls.Add(LEstadisticas)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormEstadisticas"
        Text = "FormEstadisticas"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LEstadisticas As Label
    Friend WithEvents Label1 As Label
End Class
