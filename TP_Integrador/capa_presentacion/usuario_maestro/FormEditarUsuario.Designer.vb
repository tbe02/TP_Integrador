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
        LEditarUsuario.Location = New Point(168, 141)
        LEditarUsuario.Name = "LEditarUsuario"
        LEditarUsuario.Size = New Size(309, 72)
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
        PAgregarCliente.Margin = New Padding(3, 4, 3, 4)
        PAgregarCliente.Name = "PAgregarCliente"
        PAgregarCliente.Size = New Size(566, 1001)
        PAgregarCliente.TabIndex = 5
        ' 
        ' PMenuSuperior
        ' 
        PMenuSuperior.BackColor = Color.FromArgb(CByte(26), CByte(25), CByte(72))
        PMenuSuperior.Controls.Add(IBMinimizar)
        PMenuSuperior.Controls.Add(IBCerrar)
        PMenuSuperior.Controls.Add(IBMinimizar_EC)
        PMenuSuperior.Controls.Add(IBCerrar_EC)
        PMenuSuperior.Location = New Point(0, 0)
        PMenuSuperior.Name = "PMenuSuperior"
        PMenuSuperior.Size = New Size(569, 45)
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
        IBMinimizar.Location = New Point(512, 3)
        IBMinimizar.Name = "IBMinimizar"
        IBMinimizar.Size = New Size(22, 23)
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
        IBCerrar.Location = New Point(541, 3)
        IBCerrar.Name = "IBCerrar"
        IBCerrar.Size = New Size(22, 23)
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
        IBMinimizar_EC.Location = New Point(857, 9)
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
        IBCerrar_EC.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        IBCerrar_EC.ForeColor = Color.White
        IBCerrar_EC.IconChar = FontAwesome.Sharp.IconChar.Close
        IBCerrar_EC.IconColor = Color.Gray
        IBCerrar_EC.IconFont = FontAwesome.Sharp.IconFont.Auto
        IBCerrar_EC.IconSize = 20
        IBCerrar_EC.Location = New Point(885, 9)
        IBCerrar_EC.Name = "IBCerrar_EC"
        IBCerrar_EC.Size = New Size(22, 23)
        IBCerrar_EC.TabIndex = 16
        IBCerrar_EC.UseVisualStyleBackColor = False
        ' 
        ' PBEditarUsuario
        ' 
        PBEditarUsuario.Image = My.Resources.Resources.people1
        PBEditarUsuario.Location = New Point(66, 141)
        PBEditarUsuario.Margin = New Padding(3, 4, 3, 4)
        PBEditarUsuario.Name = "PBEditarUsuario"
        PBEditarUsuario.Size = New Size(95, 105)
        PBEditarUsuario.TabIndex = 30
        PBEditarUsuario.TabStop = False
        ' 
        ' LTelefono
        ' 
        LTelefono.AutoSize = True
        LTelefono.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LTelefono.ForeColor = Color.Silver
        LTelefono.Location = New Point(56, 585)
        LTelefono.Name = "LTelefono"
        LTelefono.Size = New Size(89, 25)
        LTelefono.TabIndex = 29
        LTelefono.Text = "Telefono"
        ' 
        ' LCorreo
        ' 
        LCorreo.AutoSize = True
        LCorreo.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LCorreo.ForeColor = Color.Silver
        LCorreo.Location = New Point(56, 505)
        LCorreo.Name = "LCorreo"
        LCorreo.Size = New Size(72, 25)
        LCorreo.TabIndex = 28
        LCorreo.Text = "Correo"
        ' 
        ' LDNI
        ' 
        LDNI.AutoSize = True
        LDNI.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LDNI.ForeColor = Color.Silver
        LDNI.Location = New Point(56, 425)
        LDNI.Name = "LDNI"
        LDNI.Size = New Size(45, 25)
        LDNI.TabIndex = 27
        LDNI.Text = "DNI"
        ' 
        ' LNombre
        ' 
        LNombre.AutoSize = True
        LNombre.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LNombre.ForeColor = Color.Silver
        LNombre.Location = New Point(56, 345)
        LNombre.Name = "LNombre"
        LNombre.Size = New Size(97, 25)
        LNombre.TabIndex = 26
        LNombre.Text = "Nombre/s"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Silver
        Label3.Location = New Point(56, 265)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 25)
        Label3.TabIndex = 25
        Label3.Text = "Apellido/s"
        ' 
        ' TBTelefono
        ' 
        TBTelefono.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBTelefono.BorderStyle = BorderStyle.None
        TBTelefono.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBTelefono.ForeColor = Color.Silver
        TBTelefono.Location = New Point(226, 585)
        TBTelefono.Name = "TBTelefono"
        TBTelefono.Size = New Size(302, 21)
        TBTelefono.TabIndex = 24
        ' 
        ' TBCorreo
        ' 
        TBCorreo.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBCorreo.BorderStyle = BorderStyle.None
        TBCorreo.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBCorreo.ForeColor = Color.Silver
        TBCorreo.Location = New Point(226, 505)
        TBCorreo.Name = "TBCorreo"
        TBCorreo.Size = New Size(302, 21)
        TBCorreo.TabIndex = 23
        ' 
        ' TBDNI
        ' 
        TBDNI.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBDNI.BorderStyle = BorderStyle.None
        TBDNI.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBDNI.ForeColor = Color.Silver
        TBDNI.Location = New Point(226, 425)
        TBDNI.Name = "TBDNI"
        TBDNI.Size = New Size(302, 21)
        TBDNI.TabIndex = 22
        ' 
        ' tNombre
        ' 
        tNombre.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        tNombre.BorderStyle = BorderStyle.None
        tNombre.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tNombre.ForeColor = Color.Silver
        tNombre.Location = New Point(226, 345)
        tNombre.Name = "tNombre"
        tNombre.Size = New Size(302, 21)
        tNombre.TabIndex = 21
        ' 
        ' TBApellido
        ' 
        TBApellido.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBApellido.BorderStyle = BorderStyle.None
        TBApellido.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBApellido.ForeColor = Color.Silver
        TBApellido.Location = New Point(226, 265)
        TBApellido.Name = "TBApellido"
        TBApellido.Size = New Size(302, 21)
        TBApellido.TabIndex = 20
        ' 
        ' ComboBoxTipoUsuario
        ' 
        ComboBoxTipoUsuario.BackColor = Color.White
        ComboBoxTipoUsuario.ForeColor = Color.Black
        ComboBoxTipoUsuario.FormattingEnabled = True
        ComboBoxTipoUsuario.Location = New Point(226, 825)
        ComboBoxTipoUsuario.Margin = New Padding(3, 4, 3, 4)
        ComboBoxTipoUsuario.Name = "ComboBoxTipoUsuario"
        ComboBoxTipoUsuario.Size = New Size(301, 28)
        ComboBoxTipoUsuario.TabIndex = 18
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Silver
        Label2.Location = New Point(56, 825)
        Label2.Name = "Label2"
        Label2.Size = New Size(147, 25)
        Label2.TabIndex = 15
        Label2.Text = "Tipo de usuario"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Silver
        Label1.Location = New Point(56, 745)
        Label1.Name = "Label1"
        Label1.Size = New Size(114, 25)
        Label1.TabIndex = 13
        Label1.Text = "Contraseña"
        ' 
        ' tContrasena
        ' 
        tContrasena.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        tContrasena.BorderStyle = BorderStyle.None
        tContrasena.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tContrasena.ForeColor = Color.Silver
        tContrasena.Location = New Point(226, 745)
        tContrasena.Name = "tContrasena"
        tContrasena.Size = New Size(302, 21)
        tContrasena.TabIndex = 17
        ' 
        ' BEditarUsuario
        ' 
        BEditarUsuario.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BEditarUsuario.FlatAppearance.BorderSize = 0
        BEditarUsuario.FlatStyle = FlatStyle.Flat
        BEditarUsuario.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BEditarUsuario.ForeColor = Color.White
        BEditarUsuario.Location = New Point(81, 897)
        BEditarUsuario.Name = "BEditarUsuario"
        BEditarUsuario.Size = New Size(400, 67)
        BEditarUsuario.TabIndex = 19
        BEditarUsuario.Text = "Editar usuario"
        BEditarUsuario.UseVisualStyleBackColor = False
        ' 
        ' LApellido
        ' 
        LApellido.AutoSize = True
        LApellido.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LApellido.ForeColor = Color.Silver
        LApellido.Location = New Point(56, 665)
        LApellido.Name = "LApellido"
        LApellido.Size = New Size(79, 25)
        LApellido.TabIndex = 6
        LApellido.Text = "Usuario"
        ' 
        ' tUsuario
        ' 
        tUsuario.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        tUsuario.BorderStyle = BorderStyle.None
        tUsuario.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tUsuario.ForeColor = Color.Silver
        tUsuario.Location = New Point(226, 665)
        tUsuario.Name = "tUsuario"
        tUsuario.Size = New Size(302, 21)
        tUsuario.TabIndex = 12
        ' 
        ' FormEditarUsuario
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        ClientSize = New Size(567, 999)
        Controls.Add(PAgregarCliente)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
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
