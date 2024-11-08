<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAgregarMarca
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
        PBordeSuperior = New Panel()
        TBAgregarMarca = New TextBox()
        LMarca = New Label()
        BAgregarMarca = New Button()
        IBCerrar = New FontAwesome.Sharp.IconButton()
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
        ' TBAgregarMarca
        ' 
        TBAgregarMarca.BackColor = Color.FromArgb(CByte(75), CByte(75), CByte(75))
        TBAgregarMarca.ForeColor = Color.White
        TBAgregarMarca.Location = New Point(182, 59)
        TBAgregarMarca.Name = "TBAgregarMarca"
        TBAgregarMarca.Size = New Size(330, 27)
        TBAgregarMarca.TabIndex = 1
        ' 
        ' LMarca
        ' 
        LMarca.AutoSize = True
        LMarca.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LMarca.ForeColor = Color.White
        LMarca.Location = New Point(50, 59)
        LMarca.Name = "LMarca"
        LMarca.Size = New Size(83, 27)
        LMarca.TabIndex = 2
        LMarca.Text = "Marca"
        ' 
        ' BAgregarMarca
        ' 
        BAgregarMarca.BackColor = Color.Black
        BAgregarMarca.FlatAppearance.BorderSize = 0
        BAgregarMarca.FlatStyle = FlatStyle.Flat
        BAgregarMarca.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BAgregarMarca.ForeColor = Color.White
        BAgregarMarca.Location = New Point(245, 120)
        BAgregarMarca.Margin = New Padding(3, 4, 3, 4)
        BAgregarMarca.Name = "BAgregarMarca"
        BAgregarMarca.Size = New Size(178, 39)
        BAgregarMarca.TabIndex = 5
        BAgregarMarca.Text = "Agregar marca"
        BAgregarMarca.UseVisualStyleBackColor = False
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
        ' FormAgregarMarca
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(90), CByte(90), CByte(90))
        ClientSize = New Size(594, 187)
        Controls.Add(BAgregarMarca)
        Controls.Add(LMarca)
        Controls.Add(TBAgregarMarca)
        Controls.Add(PBordeSuperior)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormAgregarMarca"
        Text = "FormAgregarMarca"
        PBordeSuperior.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PBordeSuperior As Panel
    Friend WithEvents TBAgregarMarca As TextBox
    Friend WithEvents LMarca As Label
    Friend WithEvents BAgregarMarca As Button
    Friend WithEvents IBCerrar As FontAwesome.Sharp.IconButton
End Class
