Imports System.Text.RegularExpressions

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEditarUsuario
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        LEditarUsuario = New Label()
        PAgregarCliente = New Panel()
        PMenuSuperior = New Panel()
        IBMinimizar = New FontAwesome.Sharp.IconButton()
        IBCerrar = New FontAwesome.Sharp.IconButton()
        IBMinimizar_EC = New FontAwesome.Sharp.IconButton()
        IBCerrar_EC = New FontAwesome.Sharp.IconButton()
        PBEditarUsuario = New PictureBox()
        LTelefono = New Label()
        LCorreo = New Label()
        LDNI = New Label()
        LNombre = New Label()
        Label3 = New Label()
        TBTelefono = New TextBox()
        TBCorreo = New TextBox()
        TBDNI = New TextBox()
        tNombre = New TextBox()
        TBApellido = New TextBox()
        ComboBoxTipoUsuario = New ComboBox()
        Label2 = New Label()
        Label1 = New Label()
        tContrasena = New TextBox()
        BEditarUsuario = New Button()
        LApellido = New Label()
        tUsuario = New TextBox()
        PAgregarCliente.SuspendLayout()
        PMenuSuperior.SuspendLayout()
        CType(PBEditarUsuario, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LEditarUsuario
        ' 
        LEditarUsuario.AutoSize = True
        LEditarUsuario.BackColor = Color.Transparent
        LEditarUsuario.Font = New Font("Bahnschrift Condensed", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LEditarUsuario.ForeColor = Color.White
        LEditarUsuario.Location = New Point(147, 106)
        LEditarUsuario.Name = "LEditarUsuario"
        LEditarUsuario.Size = New Size(250, 58)
        LEditarUsuario.TabIndex = 11
        LEditarUsuario.Text = "Editar Usuario"
        ' 
        ' PAgregarCliente
        ' 
        PAgregarCliente.BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        PAgregarCliente.Controls.Add(PMenuSuperior)
        PAgregarCliente.Controls.Add(PBEditarUsuario)
        PAgregarCliente.Controls.Add(LTelefono)
        PAgregarCliente.Controls.Add(LCorreo)
        PAgregarCliente.Controls.Add(LDNI)
        PAgregarCliente.Controls.Add(LNombre)
        PAgregarCliente.Controls.Add(Label3)
        PAgregarCliente.Controls.Add(TBTelefono)
        PAgregarCliente.Controls.Add(TBCorreo)
        PAgregarCliente.Controls.Add(TBDNI)
        PAgregarCliente.Controls.Add(tNombre)
        PAgregarCliente.Controls.Add(TBApellido)
        PAgregarCliente.Controls.Add(ComboBoxTipoUsuario)
        PAgregarCliente.Controls.Add(Label2)
        PAgregarCliente.Controls.Add(Label1)
        PAgregarCliente.Controls.Add(tContrasena)
        PAgregarCliente.Controls.Add(BEditarUsuario)
        PAgregarCliente.Controls.Add(LEditarUsuario)
        PAgregarCliente.Controls.Add(LApellido)
        PAgregarCliente.Controls.Add(tUsuario)
        PAgregarCliente.Location = New Point(0, 0)
        PAgregarCliente.Name = "PAgregarCliente"
        PAgregarCliente.Size = New Size(495, 751)
        PAgregarCliente.TabIndex = 5
        ' 
        ' PMenuSuperior
        ' 
        PMenuSuperior.BackColor = Color.FromArgb(CByte(26), CByte(25), CByte(72))
        PMenuSuperior.Controls.Add(IBMinimizar)
        PMenuSuperior.Controls.Add(IBCerrar)
        PMenuSuperior.Controls.Add(IBMinimizar_EC)
        PMenuSuperior.Controls.Add(IBCerrar_EC)
        PMenuSuperior.Location = New Point(0, 2)
        PMenuSuperior.Margin = New Padding(3, 2, 3, 2)
        PMenuSuperior.Name = "PMenuSuperior"
        PMenuSuperior.Size = New Size(498, 34)
        PMenuSuperior.TabIndex = 31
        ' 
        ' IBMinimizar
        ' 
        IBMinimizar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        IBMinimizar.BackColor = Color.Transparent
        IBMinimizar.FlatAppearance.BorderSize = 0
        IBMinimizar.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        IBMinimizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        IBMinimizar.FlatStyle = FlatStyle.Flat
        IBMinimizar.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        IBMinimizar.ForeColor = Color.White
        IBMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        IBMinimizar.IconColor = Color.Gray
        IBMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto
        IBMinimizar.IconSize = 20
        IBMinimizar.Location = New Point(448, 2)
        IBMinimizar.Margin = New Padding(3, 2, 3, 2)
        IBMinimizar.Name = "IBMinimizar"
        IBMinimizar.Size = New Size(19, 17)
        IBMinimizar.TabIndex = 33
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
        IBCerrar.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        IBCerrar.ForeColor = Color.White
        IBCerrar.IconChar = FontAwesome.Sharp.IconChar.Close
        IBCerrar.IconColor = Color.Gray
        IBCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto
        IBCerrar.IconSize = 20
        IBCerrar.Location = New Point(473, 2)
        IBCerrar.Margin = New Padding(3, 2, 3, 2)
        IBCerrar.Name = "IBCerrar"
        IBCerrar.Size = New Size(19, 17)
        IBCerrar.TabIndex = 32
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
        IBMinimizar_EC.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        IBMinimizar_EC.ForeColor = Color.White
        IBMinimizar_EC.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        IBMinimizar_EC.IconColor = Color.Gray
        IBMinimizar_EC.IconFont = FontAwesome.Sharp.IconFont.Auto
        IBMinimizar_EC.IconSize = 20
        IBMinimizar_EC.Location = New Point(750, 7)
        IBMinimizar_EC.Margin = New Padding(3, 2, 3, 2)
        IBMinimizar_EC.Name = "IBMinimizar_EC"
        IBMinimizar_EC.Size = New Size(19, 17)
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
        IBCerrar_EC.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        IBCerrar_EC.ForeColor = Color.White
        IBCerrar_EC.IconChar = FontAwesome.Sharp.IconChar.Close
        IBCerrar_EC.IconColor = Color.Gray
        IBCerrar_EC.IconFont = FontAwesome.Sharp.IconFont.Auto
        IBCerrar_EC.IconSize = 20
        IBCerrar_EC.Location = New Point(774, 7)
        IBCerrar_EC.Margin = New Padding(3, 2, 3, 2)
        IBCerrar_EC.Name = "IBCerrar_EC"
        IBCerrar_EC.Size = New Size(19, 17)
        IBCerrar_EC.TabIndex = 16
        IBCerrar_EC.UseVisualStyleBackColor = False
        ' 
        ' PBEditarUsuario
        ' 
        PBEditarUsuario.Image = My.Resources.Resources.people1
        PBEditarUsuario.Location = New Point(58, 106)
        PBEditarUsuario.Name = "PBEditarUsuario"
        PBEditarUsuario.Size = New Size(83, 79)
        PBEditarUsuario.TabIndex = 30
        PBEditarUsuario.TabStop = False
        ' 
        ' LTelefono
        ' 
        LTelefono.AutoSize = True
        LTelefono.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LTelefono.ForeColor = Color.Silver
        LTelefono.Location = New Point(49, 439)
        LTelefono.Name = "LTelefono"
        LTelefono.Size = New Size(71, 20)
        LTelefono.TabIndex = 29
        LTelefono.Text = "Telefono"
        ' 
        ' LCorreo
        ' 
        LCorreo.AutoSize = True
        LCorreo.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LCorreo.ForeColor = Color.Silver
        LCorreo.Location = New Point(49, 379)
        LCorreo.Name = "LCorreo"
        LCorreo.Size = New Size(57, 20)
        LCorreo.TabIndex = 28
        LCorreo.Text = "Correo"
        ' 
        ' LDNI
        ' 
        LDNI.AutoSize = True
        LDNI.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LDNI.ForeColor = Color.Silver
        LDNI.Location = New Point(49, 319)
        LDNI.Name = "LDNI"
        LDNI.Size = New Size(37, 20)
        LDNI.TabIndex = 27
        LDNI.Text = "DNI"
        ' 
        ' LNombre
        ' 
        LNombre.AutoSize = True
        LNombre.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LNombre.ForeColor = Color.Silver
        LNombre.Location = New Point(49, 259)
        LNombre.Name = "LNombre"
        LNombre.Size = New Size(77, 20)
        LNombre.TabIndex = 26
        LNombre.Text = "Nombre/s"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Silver
        Label3.Location = New Point(49, 199)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 20)
        Label3.TabIndex = 25
        Label3.Text = "Apellido/s"
        ' 
        ' TBTelefono
        ' 
        TBTelefono.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBTelefono.BorderStyle = BorderStyle.None
        TBTelefono.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBTelefono.ForeColor = Color.Silver
        TBTelefono.Location = New Point(198, 439)
        TBTelefono.Margin = New Padding(3, 2, 3, 2)
        TBTelefono.Name = "TBTelefono"
        TBTelefono.Size = New Size(264, 17)
        TBTelefono.TabIndex = 24
        ' 
        ' TBCorreo
        ' 
        TBCorreo.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBCorreo.BorderStyle = BorderStyle.None
        TBCorreo.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBCorreo.ForeColor = Color.Silver
        TBCorreo.Location = New Point(198, 379)
        TBCorreo.Margin = New Padding(3, 2, 3, 2)
        TBCorreo.Name = "TBCorreo"
        TBCorreo.Size = New Size(264, 17)
        TBCorreo.TabIndex = 23
        ' 
        ' TBDNI
        ' 
        TBDNI.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBDNI.BorderStyle = BorderStyle.None
        TBDNI.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBDNI.ForeColor = Color.Silver
        TBDNI.Location = New Point(198, 319)
        TBDNI.Margin = New Padding(3, 2, 3, 2)
        TBDNI.Name = "TBDNI"
        TBDNI.Size = New Size(264, 17)
        TBDNI.TabIndex = 22
        ' 
        ' tNombre
        ' 
        tNombre.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        tNombre.BorderStyle = BorderStyle.None
        tNombre.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tNombre.ForeColor = Color.Silver
        tNombre.Location = New Point(198, 259)
        tNombre.Margin = New Padding(3, 2, 3, 2)
        tNombre.Name = "tNombre"
        tNombre.Size = New Size(264, 17)
        tNombre.TabIndex = 21
        ' 
        ' TBApellido
        ' 
        TBApellido.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBApellido.BorderStyle = BorderStyle.None
        TBApellido.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBApellido.ForeColor = Color.Silver
        TBApellido.Location = New Point(198, 199)
        TBApellido.Margin = New Padding(3, 2, 3, 2)
        TBApellido.Name = "TBApellido"
        TBApellido.Size = New Size(264, 17)
        TBApellido.TabIndex = 20
        ' 
        ' ComboBoxTipoUsuario
        ' 
        ComboBoxTipoUsuario.BackColor = Color.White
        ComboBoxTipoUsuario.ForeColor = Color.Black
        ComboBoxTipoUsuario.FormattingEnabled = True
        ComboBoxTipoUsuario.Location = New Point(198, 619)
        ComboBoxTipoUsuario.Name = "ComboBoxTipoUsuario"
        ComboBoxTipoUsuario.Size = New Size(264, 23)
        ComboBoxTipoUsuario.TabIndex = 18
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Silver
        Label2.Location = New Point(49, 619)
        Label2.Name = "Label2"
        Label2.Size = New Size(117, 20)
        Label2.TabIndex = 15
        Label2.Text = "Tipo de usuario"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Silver
        Label1.Location = New Point(49, 559)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 20)
        Label1.TabIndex = 13
        Label1.Text = "Contraseña"
        ' 
        ' tContrasena
        ' 
        tContrasena.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        tContrasena.BorderStyle = BorderStyle.None
        tContrasena.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tContrasena.ForeColor = Color.Silver
        tContrasena.Location = New Point(198, 559)
        tContrasena.Margin = New Padding(3, 2, 3, 2)
        tContrasena.Name = "tContrasena"
        tContrasena.Size = New Size(264, 17)
        tContrasena.TabIndex = 17
        ' 
        ' BEditarUsuario
        ' 
        BEditarUsuario.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BEditarUsuario.FlatAppearance.BorderSize = 0
        BEditarUsuario.FlatStyle = FlatStyle.Flat
        BEditarUsuario.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BEditarUsuario.ForeColor = Color.White
        BEditarUsuario.Location = New Point(71, 673)
        BEditarUsuario.Margin = New Padding(3, 2, 3, 2)
        BEditarUsuario.Name = "BEditarUsuario"
        BEditarUsuario.Size = New Size(350, 50)
        BEditarUsuario.TabIndex = 19
        BEditarUsuario.Text = "Editar usuario"
        BEditarUsuario.UseVisualStyleBackColor = False
        ' 
        ' LApellido
        ' 
        LApellido.AutoSize = True
        LApellido.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LApellido.ForeColor = Color.Silver
        LApellido.Location = New Point(49, 499)
        LApellido.Name = "LApellido"
        LApellido.Size = New Size(64, 20)
        LApellido.TabIndex = 6
        LApellido.Text = "Usuario"
        ' 
        ' tUsuario
        ' 
        tUsuario.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        tUsuario.BorderStyle = BorderStyle.None
        tUsuario.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tUsuario.ForeColor = Color.Silver
        tUsuario.Location = New Point(198, 499)
        tUsuario.Margin = New Padding(3, 2, 3, 2)
        tUsuario.Name = "tUsuario"
        tUsuario.Size = New Size(264, 17)
        tUsuario.TabIndex = 12
        ' 
        ' FormEditarUsuario
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        ClientSize = New Size(496, 749)
        Controls.Add(PAgregarCliente)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormEditarUsuario"
        Text = "FormAgregarUsuario"
        PAgregarCliente.ResumeLayout(False)
        PAgregarCliente.PerformLayout()
        PMenuSuperior.ResumeLayout(False)
        CType(PBEditarUsuario, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents LEditarUsuario As Label
    Friend WithEvents PAgregarCliente As Panel
    Friend WithEvents BEditarUsuario As Button
    Friend WithEvents LApellido As Label
    Friend WithEvents tUsuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tContrasena As TextBox

    Friend WithEvents ComboBoxTipoUsuario As ComboBox




    Friend WithEvents LTelefono As Label
    Friend WithEvents LCorreo As Label
    Friend WithEvents LDNI As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TBTelefono As TextBox
    Friend WithEvents TBCorreo As TextBox
    Friend WithEvents TBDNI As TextBox
    Friend WithEvents tNombre As TextBox
    Friend WithEvents TBApellido As TextBox
    Friend WithEvents PBEditarUsuario As PictureBox
    Friend WithEvents PMenuSuperior As Panel
    Friend WithEvents IBMinimizar_EC As FontAwesome.Sharp.IconButton
    Friend WithEvents IBCerrar_EC As FontAwesome.Sharp.IconButton
    Friend WithEvents IBMinimizar As FontAwesome.Sharp.IconButton
    Friend WithEvents IBCerrar As FontAwesome.Sharp.IconButton
End Class
