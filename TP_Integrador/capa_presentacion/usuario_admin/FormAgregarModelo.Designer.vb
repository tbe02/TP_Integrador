<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAgregarModelo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PBordeSuperior = New Panel()
        IBCerrar = New FontAwesome.Sharp.IconButton()
        TBAgregarModelo = New TextBox()
        LModelo = New Label()
        BAgregarModelo = New Button()
        PBordeSuperior.SuspendLayout()
        SuspendLayout()
        ' 
        ' PBordeSuperior
        ' 
        PBordeSuperior.BackColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        PBordeSuperior.Controls.Add(IBCerrar)
        PBordeSuperior.Location = New Point(0, 0)
        PBordeSuperior.Name = "PBordeSuperior"
        PBordeSuperior.Size = New Size(599, 34)
        PBordeSuperior.TabIndex = 0
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
        IBCerrar.Location = New Point(564, 1)
        IBCerrar.Name = "IBCerrar"
        IBCerrar.Size = New Size(32, 30)
        IBCerrar.TabIndex = 15
        IBCerrar.UseVisualStyleBackColor = False
        ' 
        ' TBAgregarModelo
        ' 
        TBAgregarModelo.BackColor = Color.FromArgb(CByte(75), CByte(75), CByte(75))
        TBAgregarModelo.ForeColor = Color.White
        TBAgregarModelo.Location = New Point(182, 59)
        TBAgregarModelo.Name = "TBAgregarModelo"
        TBAgregarModelo.Size = New Size(330, 27)
        TBAgregarModelo.TabIndex = 1
        ' 
        ' LModelo
        ' 
        LModelo.AutoSize = True
        LModelo.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LModelo.ForeColor = Color.White
        LModelo.Location = New Point(50, 59)
        LModelo.Name = "LModelo"
        LModelo.Size = New Size(93, 27)
        LModelo.TabIndex = 2
        LModelo.Text = "Modelo"
        ' 
        ' BAgregarModelo
        ' 
        BAgregarModelo.BackColor = Color.Black
        BAgregarModelo.FlatAppearance.BorderSize = 0
        BAgregarModelo.FlatStyle = FlatStyle.Flat
        BAgregarModelo.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BAgregarModelo.ForeColor = Color.White
        BAgregarModelo.Location = New Point(245, 120)
        BAgregarModelo.Margin = New Padding(3, 4, 3, 4)
        BAgregarModelo.Name = "BAgregarModelo"
        BAgregarModelo.Size = New Size(178, 39)
        BAgregarModelo.TabIndex = 5
        BAgregarModelo.Text = "Agregar modelo"
        BAgregarModelo.UseVisualStyleBackColor = False
        ' 
        ' FormAgregarModelo
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(90), CByte(90), CByte(90))
        ClientSize = New Size(594, 187)
        Controls.Add(BAgregarModelo)
        Controls.Add(LModelo)
        Controls.Add(TBAgregarModelo)
        Controls.Add(PBordeSuperior)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormAgregarModelo"
        Text = "FormAgregarMarca"
        PBordeSuperior.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PBordeSuperior As Panel
    Friend WithEvents TBAgregarModelo As TextBox
    Friend WithEvents LModelo As Label
    Friend WithEvents BAgregarModelo As Button
    Friend WithEvents IBCerrar As FontAwesome.Sharp.IconButton
End Class
