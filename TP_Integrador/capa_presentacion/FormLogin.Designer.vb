<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
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
        BIniciarSesion = New Button()
        BarraTitulo = New Panel()
        PBMinimizar = New PictureBox()
        PBCerrar = New PictureBox()
        TBUsuario = New TextBox()
        TBContrasena = New TextBox()
        LUsuario = New Label()
        LContrasena = New Label()
        BarraFooter = New Panel()
        CBRecordarme = New CheckBox()
        PBIconoEmpresa = New PictureBox()
        LGST = New Label()
        LGestionServicTec = New Label()
        BarraTitulo.SuspendLayout()
        CType(PBMinimizar, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBCerrar, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBIconoEmpresa, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BIniciarSesion
        ' 
        BIniciarSesion.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BIniciarSesion.FlatAppearance.BorderSize = 0
        BIniciarSesion.FlatStyle = FlatStyle.Flat
        BIniciarSesion.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BIniciarSesion.ForeColor = Color.White
        BIniciarSesion.Location = New Point(44, 563)
        BIniciarSesion.Margin = New Padding(2, 2, 2, 2)
        BIniciarSesion.Name = "BIniciarSesion"
        BIniciarSesion.Size = New Size(350, 50)
        BIniciarSesion.TabIndex = 4
        BIniciarSesion.Text = "Iniciar Sesión"
        BIniciarSesion.UseVisualStyleBackColor = False
        ' 
        ' BarraTitulo
        ' 
        BarraTitulo.BackColor = Color.FromArgb(CByte(36), CByte(43), CByte(73))
        BarraTitulo.Controls.Add(PBMinimizar)
        BarraTitulo.Controls.Add(PBCerrar)
        BarraTitulo.Dock = DockStyle.Top
        BarraTitulo.Location = New Point(0, 0)
        BarraTitulo.Margin = New Padding(2, 3, 2, 3)
        BarraTitulo.Name = "BarraTitulo"
        BarraTitulo.Size = New Size(429, 45)
        BarraTitulo.TabIndex = 5
        ' 
        ' PBMinimizar
        ' 
        PBMinimizar.Image = My.Resources.Resources.minimizar_blanco
        PBMinimizar.Location = New Point(348, 6)
        PBMinimizar.Margin = New Padding(2, 3, 2, 3)
        PBMinimizar.Name = "PBMinimizar"
        PBMinimizar.Size = New Size(32, 32)
        PBMinimizar.SizeMode = PictureBoxSizeMode.AutoSize
        PBMinimizar.TabIndex = 1
        PBMinimizar.TabStop = False
        ' 
        ' PBCerrar
        ' 
        PBCerrar.Image = My.Resources.Resources.cerrar_blanco
        PBCerrar.Location = New Point(386, 6)
        PBCerrar.Margin = New Padding(2, 3, 2, 3)
        PBCerrar.Name = "PBCerrar"
        PBCerrar.Size = New Size(32, 32)
        PBCerrar.SizeMode = PictureBoxSizeMode.AutoSize
        PBCerrar.TabIndex = 0
        PBCerrar.TabStop = False
        ' 
        ' TBUsuario
        ' 
        TBUsuario.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBUsuario.BorderStyle = BorderStyle.None
        TBUsuario.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBUsuario.ForeColor = Color.Silver
        TBUsuario.Location = New Point(44, 411)
        TBUsuario.Margin = New Padding(2, 2, 2, 2)
        TBUsuario.Name = "TBUsuario"
        TBUsuario.Size = New Size(350, 17)
        TBUsuario.TabIndex = 1
        ' 
        ' TBContrasena
        ' 
        TBContrasena.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBContrasena.BorderStyle = BorderStyle.None
        TBContrasena.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBContrasena.ForeColor = Color.Silver
        TBContrasena.Location = New Point(44, 475)
        TBContrasena.Margin = New Padding(2, 2, 2, 2)
        TBContrasena.Name = "TBContrasena"
        TBContrasena.Size = New Size(350, 17)
        TBContrasena.TabIndex = 3
        TBContrasena.UseSystemPasswordChar = True
        ' 
        ' LUsuario
        ' 
        LUsuario.AutoSize = True
        LUsuario.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LUsuario.ForeColor = Color.Silver
        LUsuario.Location = New Point(44, 379)
        LUsuario.Margin = New Padding(2, 0, 2, 0)
        LUsuario.Name = "LUsuario"
        LUsuario.Size = New Size(64, 20)
        LUsuario.TabIndex = 6
        LUsuario.Text = "Usuario"
        ' 
        ' LContrasena
        ' 
        LContrasena.AutoSize = True
        LContrasena.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LContrasena.ForeColor = Color.Silver
        LContrasena.Location = New Point(44, 445)
        LContrasena.Margin = New Padding(2, 0, 2, 0)
        LContrasena.Name = "LContrasena"
        LContrasena.Size = New Size(92, 20)
        LContrasena.TabIndex = 7
        LContrasena.Text = "Contraseña"
        ' 
        ' BarraFooter
        ' 
        BarraFooter.BackColor = Color.FromArgb(CByte(36), CByte(43), CByte(73))
        BarraFooter.Dock = DockStyle.Bottom
        BarraFooter.Location = New Point(0, 670)
        BarraFooter.Margin = New Padding(2, 3, 2, 3)
        BarraFooter.Name = "BarraFooter"
        BarraFooter.Size = New Size(429, 10)
        BarraFooter.TabIndex = 0
        ' 
        ' CBRecordarme
        ' 
        CBRecordarme.AutoSize = True
        CBRecordarme.FlatStyle = FlatStyle.Flat
        CBRecordarme.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CBRecordarme.ForeColor = Color.DarkGray
        CBRecordarme.Location = New Point(44, 515)
        CBRecordarme.Margin = New Padding(2, 3, 2, 3)
        CBRecordarme.Name = "CBRecordarme"
        CBRecordarme.Size = New Size(99, 20)
        CBRecordarme.TabIndex = 8
        CBRecordarme.Text = "Recordarme"
        CBRecordarme.UseVisualStyleBackColor = True
        ' 
        ' PBIconoEmpresa
        ' 
        PBIconoEmpresa.BackColor = Color.Transparent
        PBIconoEmpresa.Image = My.Resources.Resources.impresora21
        PBIconoEmpresa.Location = New Point(93, 51)
        PBIconoEmpresa.Margin = New Padding(2, 3, 2, 3)
        PBIconoEmpresa.Name = "PBIconoEmpresa"
        PBIconoEmpresa.Size = New Size(237, 216)
        PBIconoEmpresa.SizeMode = PictureBoxSizeMode.StretchImage
        PBIconoEmpresa.TabIndex = 9
        PBIconoEmpresa.TabStop = False
        ' 
        ' LGST
        ' 
        LGST.AutoSize = True
        LGST.BackColor = Color.Transparent
        LGST.Font = New Font("Microsoft Sans Serif", 24.0F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LGST.ForeColor = Color.Silver
        LGST.Location = New Point(176, 257)
        LGST.Margin = New Padding(2, 0, 2, 0)
        LGST.Name = "LGST"
        LGST.Size = New Size(83, 37)
        LGST.TabIndex = 10
        LGST.Text = "GST"
        ' 
        ' LGestionServicTec
        ' 
        LGestionServicTec.AutoSize = True
        LGestionServicTec.BackColor = Color.Transparent
        LGestionServicTec.Font = New Font("Microsoft Sans Serif", 18.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LGestionServicTec.ForeColor = Color.Silver
        LGestionServicTec.Location = New Point(93, 292)
        LGestionServicTec.Margin = New Padding(2, 0, 2, 0)
        LGestionServicTec.Name = "LGestionServicTec"
        LGestionServicTec.Size = New Size(282, 29)
        LGestionServicTec.TabIndex = 11
        LGestionServicTec.Text = "Gestión Servicio Técnico"
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(429, 680)
        Controls.Add(LGestionServicTec)
        Controls.Add(LGST)
        Controls.Add(PBIconoEmpresa)
        Controls.Add(CBRecordarme)
        Controls.Add(BarraFooter)
        Controls.Add(LContrasena)
        Controls.Add(LUsuario)
        Controls.Add(TBContrasena)
        Controls.Add(BarraTitulo)
        Controls.Add(TBUsuario)
        Controls.Add(BIniciarSesion)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(2, 2, 2, 2)
        MaximizeBox = False
        MaximumSize = New Size(429, 680)
        MinimizeBox = False
        MinimumSize = New Size(429, 425)
        Name = "FormLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormLogin"
        BarraTitulo.ResumeLayout(False)
        BarraTitulo.PerformLayout()
        CType(PBMinimizar, ComponentModel.ISupportInitialize).EndInit()
        CType(PBCerrar, ComponentModel.ISupportInitialize).EndInit()
        CType(PBIconoEmpresa, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents BIniciarSesion As Button
    Friend WithEvents BarraTitulo As Panel
    Friend WithEvents TBUsuario As TextBox
    Friend WithEvents TBContrasena As TextBox
    Friend WithEvents LUsuario As Label
    Friend WithEvents LContrasena As Label
    Friend WithEvents BarraFooter As Panel
    Friend WithEvents CBRecordarme As CheckBox
    Friend WithEvents PBIconoEmpresa As PictureBox
    Friend WithEvents LGST As Label
    Friend WithEvents LGestionServicTec As Label
    Friend WithEvents PBCerrar As PictureBox
    Friend WithEvents PBMinimizar As PictureBox

End Class
