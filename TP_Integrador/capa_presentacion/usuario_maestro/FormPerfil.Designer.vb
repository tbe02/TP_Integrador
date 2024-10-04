<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPerfil
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
        PBEditarUsuario = New PictureBox()
        LTelefono = New Label()
        LCorreo = New Label()
        LDNI = New Label()
        LNombre = New Label()
        Label3 = New Label()
        Label2 = New Label()
        BCerrar = New Button()
        LEditarUsuario = New Label()
        PAgregarCliente = New Panel()
        LTipoDeUsuarioU = New Label()
        LUsuarioU = New Label()
        LTelefonoU = New Label()
        LCorreoU = New Label()
        LDNIU = New Label()
        LNombreU = New Label()
        LApellidoU = New Label()
        LApellido = New Label()
        CType(PBEditarUsuario, ComponentModel.ISupportInitialize).BeginInit()
        PAgregarCliente.SuspendLayout()
        SuspendLayout()
        ' 
        ' PBEditarUsuario
        ' 
        PBEditarUsuario.Image = My.Resources.Resources.people1
        PBEditarUsuario.Location = New Point(56, 67)
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
        LTelefono.Location = New Point(47, 400)
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
        LCorreo.Location = New Point(47, 340)
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
        LDNI.Location = New Point(47, 280)
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
        LNombre.Location = New Point(47, 220)
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
        Label3.Location = New Point(47, 160)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 20)
        Label3.TabIndex = 25
        Label3.Text = "Apellido/s"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Silver
        Label2.Location = New Point(47, 520)
        Label2.Name = "Label2"
        Label2.Size = New Size(117, 20)
        Label2.TabIndex = 15
        Label2.Text = "Tipo de usuario"
        ' 
        ' BCerrar
        ' 
        BCerrar.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BCerrar.FlatAppearance.BorderSize = 0
        BCerrar.FlatStyle = FlatStyle.Flat
        BCerrar.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BCerrar.ForeColor = Color.White
        BCerrar.Location = New Point(69, 634)
        BCerrar.Margin = New Padding(3, 2, 3, 2)
        BCerrar.Name = "BCerrar"
        BCerrar.Size = New Size(350, 50)
        BCerrar.TabIndex = 19
        BCerrar.Text = "Cerrar"
        BCerrar.UseVisualStyleBackColor = False
        ' 
        ' LEditarUsuario
        ' 
        LEditarUsuario.AutoSize = True
        LEditarUsuario.BackColor = Color.Transparent
        LEditarUsuario.Font = New Font("Bahnschrift Condensed", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LEditarUsuario.ForeColor = Color.White
        LEditarUsuario.Location = New Point(145, 67)
        LEditarUsuario.Name = "LEditarUsuario"
        LEditarUsuario.Size = New Size(290, 58)
        LEditarUsuario.TabIndex = 11
        LEditarUsuario.Text = "Perfil de Usuario"
        ' 
        ' PAgregarCliente
        ' 
        PAgregarCliente.BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        PAgregarCliente.Controls.Add(LTipoDeUsuarioU)
        PAgregarCliente.Controls.Add(LUsuarioU)
        PAgregarCliente.Controls.Add(LTelefonoU)
        PAgregarCliente.Controls.Add(LCorreoU)
        PAgregarCliente.Controls.Add(LDNIU)
        PAgregarCliente.Controls.Add(LNombreU)
        PAgregarCliente.Controls.Add(LApellidoU)
        PAgregarCliente.Controls.Add(PBEditarUsuario)
        PAgregarCliente.Controls.Add(LTelefono)
        PAgregarCliente.Controls.Add(LCorreo)
        PAgregarCliente.Controls.Add(LDNI)
        PAgregarCliente.Controls.Add(LNombre)
        PAgregarCliente.Controls.Add(Label3)
        PAgregarCliente.Controls.Add(Label2)
        PAgregarCliente.Controls.Add(BCerrar)
        PAgregarCliente.Controls.Add(LEditarUsuario)
        PAgregarCliente.Controls.Add(LApellido)
        PAgregarCliente.Location = New Point(0, 0)
        PAgregarCliente.Name = "PAgregarCliente"
        PAgregarCliente.Size = New Size(495, 751)
        PAgregarCliente.TabIndex = 6
        ' 
        ' LTipoDeUsuarioU
        ' 
        LTipoDeUsuarioU.AutoSize = True
        LTipoDeUsuarioU.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LTipoDeUsuarioU.ForeColor = Color.Silver
        LTipoDeUsuarioU.Location = New Point(195, 520)
        LTipoDeUsuarioU.Name = "LTipoDeUsuarioU"
        LTipoDeUsuarioU.RightToLeft = RightToLeft.No
        LTipoDeUsuarioU.Size = New Size(14, 20)
        LTipoDeUsuarioU.TabIndex = 38
        LTipoDeUsuarioU.Text = "-"
        ' 
        ' LUsuarioU
        ' 
        LUsuarioU.AutoSize = True
        LUsuarioU.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LUsuarioU.ForeColor = Color.Silver
        LUsuarioU.Location = New Point(195, 460)
        LUsuarioU.Name = "LUsuarioU"
        LUsuarioU.RightToLeft = RightToLeft.No
        LUsuarioU.Size = New Size(14, 20)
        LUsuarioU.TabIndex = 37
        LUsuarioU.Text = "-"
        ' 
        ' LTelefonoU
        ' 
        LTelefonoU.AutoSize = True
        LTelefonoU.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LTelefonoU.ForeColor = Color.Silver
        LTelefonoU.Location = New Point(195, 400)
        LTelefonoU.Name = "LTelefonoU"
        LTelefonoU.RightToLeft = RightToLeft.No
        LTelefonoU.Size = New Size(14, 20)
        LTelefonoU.TabIndex = 36
        LTelefonoU.Text = "-"
        ' 
        ' LCorreoU
        ' 
        LCorreoU.AutoSize = True
        LCorreoU.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LCorreoU.ForeColor = Color.Silver
        LCorreoU.Location = New Point(195, 340)
        LCorreoU.Name = "LCorreoU"
        LCorreoU.RightToLeft = RightToLeft.No
        LCorreoU.Size = New Size(14, 20)
        LCorreoU.TabIndex = 35
        LCorreoU.Text = "-"
        ' 
        ' LDNIU
        ' 
        LDNIU.AutoSize = True
        LDNIU.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LDNIU.ForeColor = Color.Silver
        LDNIU.Location = New Point(195, 280)
        LDNIU.Name = "LDNIU"
        LDNIU.RightToLeft = RightToLeft.No
        LDNIU.Size = New Size(14, 20)
        LDNIU.TabIndex = 34
        LDNIU.Text = "-"
        ' 
        ' LNombreU
        ' 
        LNombreU.AutoSize = True
        LNombreU.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LNombreU.ForeColor = Color.Silver
        LNombreU.Location = New Point(195, 220)
        LNombreU.Name = "LNombreU"
        LNombreU.RightToLeft = RightToLeft.No
        LNombreU.Size = New Size(14, 20)
        LNombreU.TabIndex = 33
        LNombreU.Text = "-"
        ' 
        ' LApellidoU
        ' 
        LApellidoU.AutoSize = True
        LApellidoU.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LApellidoU.ForeColor = Color.Silver
        LApellidoU.Location = New Point(195, 160)
        LApellidoU.Name = "LApellidoU"
        LApellidoU.RightToLeft = RightToLeft.No
        LApellidoU.Size = New Size(14, 20)
        LApellidoU.TabIndex = 32
        LApellidoU.Text = "-"
        ' 
        ' LApellido
        ' 
        LApellido.AutoSize = True
        LApellido.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LApellido.ForeColor = Color.Silver
        LApellido.Location = New Point(47, 460)
        LApellido.Name = "LApellido"
        LApellido.Size = New Size(64, 20)
        LApellido.TabIndex = 6
        LApellido.Text = "Usuario"
        ' 
        ' FormPerfil
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(493, 751)
        Controls.Add(PAgregarCliente)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormPerfil"
        Text = "FormPerfil"
        CType(PBEditarUsuario, ComponentModel.ISupportInitialize).EndInit()
        PAgregarCliente.ResumeLayout(False)
        PAgregarCliente.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents PBEditarUsuario As PictureBox
    Friend WithEvents LTelefono As Label
    Friend WithEvents LCorreo As Label
    Friend WithEvents LDNI As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BCerrar As Button
    Friend WithEvents LEditarUsuario As Label
    Friend WithEvents PAgregarCliente As Panel
    Friend WithEvents LApellido As Label
    Friend WithEvents LTipoDeUsuarioU As Label
    Friend WithEvents LUsuarioU As Label
    Friend WithEvents LTelefonoU As Label
    Friend WithEvents LCorreoU As Label
    Friend WithEvents LDNIU As Label
    Friend WithEvents LNombreU As Label
    Friend WithEvents LApellidoU As Label
End Class
