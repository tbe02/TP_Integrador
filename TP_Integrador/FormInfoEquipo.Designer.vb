<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInfoEquipo
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
        PMenuSuperior = New Panel()
        IBMinimizar = New FontAwesome.Sharp.IconButton()
        IBCerrar = New FontAwesome.Sharp.IconButton()
        IBMinimizar_EC = New FontAwesome.Sharp.IconButton()
        IBCerrar_EC = New FontAwesome.Sharp.IconButton()
        TBRazonIngreso = New TextBox()
        LObservaciones = New Label()
        LRazonIngreso = New Label()
        TBObservaciones = New TextBox()
        PMenuSuperior.SuspendLayout()
        SuspendLayout()
        ' 
        ' PMenuSuperior
        ' 
        PMenuSuperior.BackColor = Color.FromArgb(CByte(26), CByte(25), CByte(72))
        PMenuSuperior.Controls.Add(IBMinimizar)
        PMenuSuperior.Controls.Add(IBCerrar)
        PMenuSuperior.Controls.Add(IBMinimizar_EC)
        PMenuSuperior.Controls.Add(IBCerrar_EC)
        PMenuSuperior.Location = New Point(0, 1)
        PMenuSuperior.Name = "PMenuSuperior"
        PMenuSuperior.Size = New Size(577, 45)
        PMenuSuperior.TabIndex = 6
        ' 
        ' IBMinimizar
        ' 
        IBMinimizar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        IBMinimizar.BackColor = Color.Transparent
        IBMinimizar.FlatAppearance.BorderSize = 0
        IBMinimizar.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        IBMinimizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        IBMinimizar.FlatStyle = FlatStyle.Flat
        IBMinimizar.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        IBMinimizar.ForeColor = Color.White
        IBMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        IBMinimizar.IconColor = Color.Gray
        IBMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto
        IBMinimizar.IconSize = 20
        IBMinimizar.Location = New Point(513, 3)
        IBMinimizar.Name = "IBMinimizar"
        IBMinimizar.Size = New Size(22, 23)
        IBMinimizar.TabIndex = 20
        IBMinimizar.UseVisualStyleBackColor = False
        ' 
        ' IBCerrar
        ' 
        IBCerrar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        IBCerrar.BackColor = Color.Transparent
        IBCerrar.FlatAppearance.BorderSize = 0
        IBCerrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        IBCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        IBCerrar.FlatStyle = FlatStyle.Flat
        IBCerrar.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        IBCerrar.ForeColor = Color.White
        IBCerrar.IconChar = FontAwesome.Sharp.IconChar.Close
        IBCerrar.IconColor = Color.Gray
        IBCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto
        IBCerrar.IconSize = 20
        IBCerrar.Location = New Point(541, 3)
        IBCerrar.Name = "IBCerrar"
        IBCerrar.Size = New Size(22, 23)
        IBCerrar.TabIndex = 19
        IBCerrar.UseVisualStyleBackColor = False
        ' 
        ' IBMinimizar_EC
        ' 
        IBMinimizar_EC.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        IBMinimizar_EC.BackColor = Color.Transparent
        IBMinimizar_EC.FlatAppearance.BorderSize = 0
        IBMinimizar_EC.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        IBMinimizar_EC.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        IBMinimizar_EC.FlatStyle = FlatStyle.Flat
        IBMinimizar_EC.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        IBMinimizar_EC.ForeColor = Color.White
        IBMinimizar_EC.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        IBMinimizar_EC.IconColor = Color.Gray
        IBMinimizar_EC.IconFont = FontAwesome.Sharp.IconFont.Auto
        IBMinimizar_EC.IconSize = 20
        IBMinimizar_EC.Location = New Point(893, 9)
        IBMinimizar_EC.Name = "IBMinimizar_EC"
        IBMinimizar_EC.Size = New Size(22, 23)
        IBMinimizar_EC.TabIndex = 18
        IBMinimizar_EC.UseVisualStyleBackColor = False
        ' 
        ' IBCerrar_EC
        ' 
        IBCerrar_EC.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        IBCerrar_EC.BackColor = Color.Transparent
        IBCerrar_EC.FlatAppearance.BorderSize = 0
        IBCerrar_EC.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        IBCerrar_EC.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        IBCerrar_EC.FlatStyle = FlatStyle.Flat
        IBCerrar_EC.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        IBCerrar_EC.ForeColor = Color.White
        IBCerrar_EC.IconChar = FontAwesome.Sharp.IconChar.Close
        IBCerrar_EC.IconColor = Color.Gray
        IBCerrar_EC.IconFont = FontAwesome.Sharp.IconFont.Auto
        IBCerrar_EC.IconSize = 20
        IBCerrar_EC.Location = New Point(921, 9)
        IBCerrar_EC.Name = "IBCerrar_EC"
        IBCerrar_EC.Size = New Size(22, 23)
        IBCerrar_EC.TabIndex = 16
        IBCerrar_EC.UseVisualStyleBackColor = False
        ' 
        ' TBRazonIngreso
        ' 
        TBRazonIngreso.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBRazonIngreso.BorderStyle = BorderStyle.None
        TBRazonIngreso.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBRazonIngreso.ForeColor = Color.Silver
        TBRazonIngreso.Location = New Point(12, 147)
        TBRazonIngreso.Multiline = True
        TBRazonIngreso.Name = "TBRazonIngreso"
        TBRazonIngreso.Size = New Size(551, 221)
        TBRazonIngreso.TabIndex = 42
        ' 
        ' LObservaciones
        ' 
        LObservaciones.AutoSize = True
        LObservaciones.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LObservaciones.ForeColor = Color.Silver
        LObservaciones.Location = New Point(183, 426)
        LObservaciones.Name = "LObservaciones"
        LObservaciones.Size = New Size(180, 27)
        LObservaciones.TabIndex = 41
        LObservaciones.Text = "Observaciones"
        ' 
        ' LRazonIngreso
        ' 
        LRazonIngreso.AutoSize = True
        LRazonIngreso.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LRazonIngreso.ForeColor = Color.Silver
        LRazonIngreso.Location = New Point(183, 107)
        LRazonIngreso.Name = "LRazonIngreso"
        LRazonIngreso.Size = New Size(207, 27)
        LRazonIngreso.TabIndex = 40
        LRazonIngreso.Text = "Razon de ingreso"
        ' 
        ' TBObservaciones
        ' 
        TBObservaciones.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBObservaciones.BorderStyle = BorderStyle.None
        TBObservaciones.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBObservaciones.ForeColor = Color.Silver
        TBObservaciones.Location = New Point(12, 474)
        TBObservaciones.Multiline = True
        TBObservaciones.Name = "TBObservaciones"
        TBObservaciones.Size = New Size(551, 221)
        TBObservaciones.TabIndex = 43
        ' 
        ' FormInfoEquipo
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        ClientSize = New Size(571, 880)
        Controls.Add(TBObservaciones)
        Controls.Add(TBRazonIngreso)
        Controls.Add(LObservaciones)
        Controls.Add(LRazonIngreso)
        Controls.Add(PMenuSuperior)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormInfoEquipo"
        PMenuSuperior.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PMenuSuperior As Panel
    Friend WithEvents IBMinimizar_EC As FontAwesome.Sharp.IconButton
    Friend WithEvents IBCerrar_EC As FontAwesome.Sharp.IconButton
    Friend WithEvents IBMinimizar As FontAwesome.Sharp.IconButton
    Friend WithEvents IBCerrar As FontAwesome.Sharp.IconButton
    Friend WithEvents TBRazonIngreso As TextBox
    Friend WithEvents LObservaciones As Label
    Friend WithEvents LRazonIngreso As Label
    Friend WithEvents TBObservaciones As TextBox
End Class
