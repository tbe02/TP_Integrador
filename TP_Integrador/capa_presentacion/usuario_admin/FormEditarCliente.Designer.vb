<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEditarCliente
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
        PAgregarCliente = New Panel()
        ComboBoxEstado = New ComboBox()
        Label1 = New Label()
        BEditarCliente = New Button()
        LEditarCliente = New Label()
        LTelefono = New Label()
        LCorreo = New Label()
        LDNI = New Label()
        LNombre = New Label()
        LApellido = New Label()
        TBTelefono = New TextBox()
        TBCorreo = New TextBox()
        TBDNI = New TextBox()
        TBNombre = New TextBox()
        TBApellido = New TextBox()
        PBEditarCliente = New PictureBox()
        IBMinimizar_EC = New FontAwesome.Sharp.IconButton()
        PMenuSuperior = New Panel()
        IBCerrar = New FontAwesome.Sharp.IconButton()
        PAgregarCliente.SuspendLayout()
        CType(PBEditarCliente, ComponentModel.ISupportInitialize).BeginInit()
        PMenuSuperior.SuspendLayout()
        SuspendLayout()
        ' 
        ' PAgregarCliente
        ' 
        PAgregarCliente.BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        PAgregarCliente.Controls.Add(ComboBoxEstado)
        PAgregarCliente.Controls.Add(Label1)
        PAgregarCliente.Controls.Add(BEditarCliente)
        PAgregarCliente.Controls.Add(LEditarCliente)
        PAgregarCliente.Controls.Add(LTelefono)
        PAgregarCliente.Controls.Add(LCorreo)
        PAgregarCliente.Controls.Add(LDNI)
        PAgregarCliente.Controls.Add(LNombre)
        PAgregarCliente.Controls.Add(LApellido)
        PAgregarCliente.Controls.Add(TBTelefono)
        PAgregarCliente.Controls.Add(TBCorreo)
        PAgregarCliente.Controls.Add(TBDNI)
        PAgregarCliente.Controls.Add(TBNombre)
        PAgregarCliente.Controls.Add(TBApellido)
        PAgregarCliente.Controls.Add(PBEditarCliente)
        PAgregarCliente.Location = New Point(2, 51)
        PAgregarCliente.Margin = New Padding(3, 4, 3, 4)
        PAgregarCliente.Name = "PAgregarCliente"
        PAgregarCliente.Size = New Size(557, 881)
        PAgregarCliente.TabIndex = 4
        ' 
        ' ComboBoxEstado
        ' 
        ComboBoxEstado.FormattingEnabled = True
        ComboBoxEstado.Location = New Point(216, 704)
        ComboBoxEstado.Margin = New Padding(3, 4, 3, 4)
        ComboBoxEstado.Name = "ComboBoxEstado"
        ComboBoxEstado.Size = New Size(301, 28)
        ComboBoxEstado.TabIndex = 13
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Silver
        Label1.Location = New Point(46, 708)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 25)
        Label1.TabIndex = 12
        Label1.Text = "Estado"
        ' 
        ' BEditarCliente
        ' 
        BEditarCliente.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BEditarCliente.FlatAppearance.BorderSize = 0
        BEditarCliente.FlatStyle = FlatStyle.Flat
        BEditarCliente.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BEditarCliente.ForeColor = Color.White
        BEditarCliente.Location = New Point(88, 800)
        BEditarCliente.Name = "BEditarCliente"
        BEditarCliente.Size = New Size(400, 67)
        BEditarCliente.TabIndex = 4
        BEditarCliente.Text = "Editar cliente"
        BEditarCliente.UseVisualStyleBackColor = False
        ' 
        ' LEditarCliente
        ' 
        LEditarCliente.AutoSize = True
        LEditarCliente.BackColor = Color.Transparent
        LEditarCliente.Font = New Font("Bahnschrift Condensed", 36.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LEditarCliente.ForeColor = Color.White
        LEditarCliente.Location = New Point(155, 187)
        LEditarCliente.Name = "LEditarCliente"
        LEditarCliente.Size = New Size(298, 72)
        LEditarCliente.TabIndex = 11
        LEditarCliente.Text = "Editar Cliente"
        ' 
        ' LTelefono
        ' 
        LTelefono.AutoSize = True
        LTelefono.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LTelefono.ForeColor = Color.Silver
        LTelefono.Location = New Point(46, 621)
        LTelefono.Name = "LTelefono"
        LTelefono.Size = New Size(89, 25)
        LTelefono.TabIndex = 10
        LTelefono.Text = "Telefono"
        ' 
        ' LCorreo
        ' 
        LCorreo.AutoSize = True
        LCorreo.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LCorreo.ForeColor = Color.Silver
        LCorreo.Location = New Point(46, 541)
        LCorreo.Name = "LCorreo"
        LCorreo.Size = New Size(72, 25)
        LCorreo.TabIndex = 9
        LCorreo.Text = "Correo"
        ' 
        ' LDNI
        ' 
        LDNI.AutoSize = True
        LDNI.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LDNI.ForeColor = Color.Silver
        LDNI.Location = New Point(46, 461)
        LDNI.Name = "LDNI"
        LDNI.Size = New Size(45, 25)
        LDNI.TabIndex = 8
        LDNI.Text = "DNI"
        ' 
        ' LNombre
        ' 
        LNombre.AutoSize = True
        LNombre.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LNombre.ForeColor = Color.Silver
        LNombre.Location = New Point(46, 381)
        LNombre.Name = "LNombre"
        LNombre.Size = New Size(97, 25)
        LNombre.TabIndex = 7
        LNombre.Text = "Nombre/s"
        ' 
        ' LApellido
        ' 
        LApellido.AutoSize = True
        LApellido.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LApellido.ForeColor = Color.Silver
        LApellido.Location = New Point(46, 301)
        LApellido.Name = "LApellido"
        LApellido.Size = New Size(98, 25)
        LApellido.TabIndex = 6
        LApellido.Text = "Apellido/s"
        ' 
        ' TBTelefono
        ' 
        TBTelefono.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBTelefono.BorderStyle = BorderStyle.None
        TBTelefono.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBTelefono.ForeColor = Color.Silver
        TBTelefono.Location = New Point(216, 621)
        TBTelefono.Name = "TBTelefono"
        TBTelefono.Size = New Size(302, 21)
        TBTelefono.TabIndex = 5
        ' 
        ' TBCorreo
        ' 
        TBCorreo.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBCorreo.BorderStyle = BorderStyle.None
        TBCorreo.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBCorreo.ForeColor = Color.Silver
        TBCorreo.Location = New Point(216, 541)
        TBCorreo.Name = "TBCorreo"
        TBCorreo.Size = New Size(302, 21)
        TBCorreo.TabIndex = 4
        ' 
        ' TBDNI
        ' 
        TBDNI.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBDNI.BorderStyle = BorderStyle.None
        TBDNI.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBDNI.ForeColor = Color.Silver
        TBDNI.Location = New Point(216, 461)
        TBDNI.Name = "TBDNI"
        TBDNI.Size = New Size(302, 21)
        TBDNI.TabIndex = 3
        ' 
        ' TBNombre
        ' 
        TBNombre.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBNombre.BorderStyle = BorderStyle.None
        TBNombre.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBNombre.ForeColor = Color.Silver
        TBNombre.Location = New Point(216, 381)
        TBNombre.Name = "TBNombre"
        TBNombre.Size = New Size(302, 21)
        TBNombre.TabIndex = 2
        ' 
        ' TBApellido
        ' 
        TBApellido.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBApellido.BorderStyle = BorderStyle.None
        TBApellido.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBApellido.ForeColor = Color.Silver
        TBApellido.Location = New Point(216, 301)
        TBApellido.Name = "TBApellido"
        TBApellido.Size = New Size(302, 21)
        TBApellido.TabIndex = 1
        ' 
        ' PBEditarCliente
        ' 
        PBEditarCliente.Image = My.Resources.Resources.editar_cliente_128px
        PBEditarCliente.Location = New Point(216, 9)
        PBEditarCliente.Margin = New Padding(3, 4, 3, 4)
        PBEditarCliente.Name = "PBEditarCliente"
        PBEditarCliente.Size = New Size(173, 173)
        PBEditarCliente.TabIndex = 0
        PBEditarCliente.TabStop = False
        ' 
        ' IBMinimizar_EC
        ' 
        IBMinimizar_EC.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        IBMinimizar_EC.BackColor = Color.Transparent
        IBMinimizar_EC.FlatAppearance.BorderSize = 0
        IBMinimizar_EC.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        IBMinimizar_EC.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        IBMinimizar_EC.FlatStyle = FlatStyle.Flat
        IBMinimizar_EC.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        IBMinimizar_EC.ForeColor = Color.White
        IBMinimizar_EC.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        IBMinimizar_EC.IconColor = Color.Gray
        IBMinimizar_EC.IconFont = FontAwesome.Sharp.IconFont.Auto
        IBMinimizar_EC.IconSize = 20
        IBMinimizar_EC.Location = New Point(524, 3)
        IBMinimizar_EC.Name = "IBMinimizar_EC"
        IBMinimizar_EC.Size = New Size(22, 23)
        IBMinimizar_EC.TabIndex = 18
        IBMinimizar_EC.UseVisualStyleBackColor = False
        ' 
        ' PMenuSuperior
        ' 
        PMenuSuperior.BackColor = Color.FromArgb(CByte(26), CByte(25), CByte(72))
        PMenuSuperior.Controls.Add(IBCerrar)
        PMenuSuperior.Controls.Add(IBMinimizar_EC)
        PMenuSuperior.Location = New Point(-2, -3)
        PMenuSuperior.Name = "PMenuSuperior"
        PMenuSuperior.Size = New Size(577, 45)
        PMenuSuperior.TabIndex = 5
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
        IBCerrar.IconSize = 20
        IBCerrar.Location = New Point(552, 3)
        IBCerrar.Name = "IBCerrar"
        IBCerrar.Size = New Size(22, 23)
        IBCerrar.TabIndex = 19
        IBCerrar.UseVisualStyleBackColor = False
        ' 
        ' FormEditarCliente
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        ClientSize = New Size(571, 948)
        Controls.Add(PMenuSuperior)
        Controls.Add(PAgregarCliente)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormEditarCliente"
        Text = "FormAgregarCliente"
        PAgregarCliente.ResumeLayout(False)
        PAgregarCliente.PerformLayout()
        CType(PBEditarCliente, ComponentModel.ISupportInitialize).EndInit()
        PMenuSuperior.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents PAgregarCliente As Panel
    Friend WithEvents BEditarCliente As Button
    Friend WithEvents LEditarCliente As Label
    Friend WithEvents LTelefono As Label
    Friend WithEvents LCorreo As Label
    Friend WithEvents LDNI As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents LApellido As Label
    Friend WithEvents TBTelefono As TextBox
    Friend WithEvents TBCorreo As TextBox
    Friend WithEvents TBDNI As TextBox
    Friend WithEvents TBNombre As TextBox
    Friend WithEvents TBApellido As TextBox
    Friend WithEvents PBEditarCliente As PictureBox
    Friend WithEvents IBMinimizar_EC As FontAwesome.Sharp.IconButton
    Friend WithEvents IBCerrar_EC As FontAwesome.Sharp.IconButton
    Friend WithEvents PMenuSuperior As Panel
    Friend WithEvents ComboBoxEstado As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents IBCerrar As FontAwesome.Sharp.IconButton
End Class
