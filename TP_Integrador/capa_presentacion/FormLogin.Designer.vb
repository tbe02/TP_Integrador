﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        BIniciarSesion.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BIniciarSesion.ForeColor = Color.White
        BIniciarSesion.Location = New Point(50, 706)
        BIniciarSesion.Margin = New Padding(2, 3, 2, 3)
        BIniciarSesion.Name = "BIniciarSesion"
        BIniciarSesion.Size = New Size(400, 67)
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
        BarraTitulo.Margin = New Padding(2, 4, 2, 4)
        BarraTitulo.Name = "BarraTitulo"
        BarraTitulo.Size = New Size(490, 60)
        BarraTitulo.TabIndex = 5
        ' 
        ' PBMinimizar
        ' 
        PBMinimizar.Image = My.Resources.Resources.minimizar_blanco
        PBMinimizar.Location = New Point(398, 8)
        PBMinimizar.Margin = New Padding(2, 4, 2, 4)
        PBMinimizar.Name = "PBMinimizar"
        PBMinimizar.Size = New Size(32, 32)
        PBMinimizar.SizeMode = PictureBoxSizeMode.AutoSize
        PBMinimizar.TabIndex = 1
        PBMinimizar.TabStop = False
        ' 
        ' PBCerrar
        ' 
        PBCerrar.Image = My.Resources.Resources.cerrar_blanco
        PBCerrar.Location = New Point(441, 8)
        PBCerrar.Margin = New Padding(2, 4, 2, 4)
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
        TBUsuario.Location = New Point(50, 548)
        TBUsuario.Margin = New Padding(2, 3, 2, 3)
        TBUsuario.Name = "TBUsuario"
        TBUsuario.Size = New Size(400, 21)
        TBUsuario.TabIndex = 1
        ' 
        ' TBContrasena
        ' 
        TBContrasena.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBContrasena.BorderStyle = BorderStyle.None
        TBContrasena.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBContrasena.ForeColor = Color.Silver
        TBContrasena.Location = New Point(50, 633)
        TBContrasena.Margin = New Padding(2, 3, 2, 3)
        TBContrasena.Name = "TBContrasena"
        TBContrasena.Size = New Size(400, 21)
        TBContrasena.TabIndex = 3
        TBContrasena.UseSystemPasswordChar = True
        ' 
        ' LUsuario
        ' 
        LUsuario.AutoSize = True
        LUsuario.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LUsuario.ForeColor = Color.Silver
        LUsuario.Location = New Point(50, 505)
        LUsuario.Margin = New Padding(2, 0, 2, 0)
        LUsuario.Name = "LUsuario"
        LUsuario.Size = New Size(79, 25)
        LUsuario.TabIndex = 6
        LUsuario.Text = "Usuario"
        ' 
        ' LContrasena
        ' 
        LContrasena.AutoSize = True
        LContrasena.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LContrasena.ForeColor = Color.Silver
        LContrasena.Location = New Point(50, 593)
        LContrasena.Margin = New Padding(2, 0, 2, 0)
        LContrasena.Name = "LContrasena"
        LContrasena.Size = New Size(114, 25)
        LContrasena.TabIndex = 7
        LContrasena.Text = "Contraseña"
        ' 
        ' BarraFooter
        ' 
        BarraFooter.BackColor = Color.FromArgb(CByte(36), CByte(43), CByte(73))
        BarraFooter.Dock = DockStyle.Bottom
        BarraFooter.Location = New Point(0, 803)
        BarraFooter.Margin = New Padding(2, 4, 2, 4)
        BarraFooter.Name = "BarraFooter"
        BarraFooter.Size = New Size(490, 13)
        BarraFooter.TabIndex = 0
        ' 
        ' PBIconoEmpresa
        ' 
        PBIconoEmpresa.BackColor = Color.Transparent
        PBIconoEmpresa.Image = My.Resources.Resources.impresora21
        PBIconoEmpresa.Location = New Point(106, 68)
        PBIconoEmpresa.Margin = New Padding(2, 4, 2, 4)
        PBIconoEmpresa.Name = "PBIconoEmpresa"
        PBIconoEmpresa.Size = New Size(271, 288)
        PBIconoEmpresa.SizeMode = PictureBoxSizeMode.StretchImage
        PBIconoEmpresa.TabIndex = 9
        PBIconoEmpresa.TabStop = False
        ' 
        ' LGST
        ' 
        LGST.AutoSize = True
        LGST.BackColor = Color.Transparent
        LGST.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LGST.ForeColor = Color.Silver
        LGST.Location = New Point(201, 343)
        LGST.Margin = New Padding(2, 0, 2, 0)
        LGST.Name = "LGST"
        LGST.Size = New Size(102, 46)
        LGST.TabIndex = 10
        LGST.Text = "GST"
        ' 
        ' LGestionServicTec
        ' 
        LGestionServicTec.AutoSize = True
        LGestionServicTec.BackColor = Color.Transparent
        LGestionServicTec.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LGestionServicTec.ForeColor = Color.Silver
        LGestionServicTec.Location = New Point(106, 389)
        LGestionServicTec.Margin = New Padding(2, 0, 2, 0)
        LGestionServicTec.Name = "LGestionServicTec"
        LGestionServicTec.Size = New Size(346, 36)
        LGestionServicTec.TabIndex = 11
        LGestionServicTec.Text = "Gestión Servicio Técnico"
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(490, 816)
        Controls.Add(LGestionServicTec)
        Controls.Add(LGST)
        Controls.Add(PBIconoEmpresa)
        Controls.Add(BarraFooter)
        Controls.Add(LContrasena)
        Controls.Add(LUsuario)
        Controls.Add(TBContrasena)
        Controls.Add(BarraTitulo)
        Controls.Add(TBUsuario)
        Controls.Add(BIniciarSesion)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(2, 3, 2, 3)
        MaximizeBox = False
        MaximumSize = New Size(490, 907)
        MinimizeBox = False
        MinimumSize = New Size(490, 567)
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
    Friend WithEvents PBIconoEmpresa As PictureBox
    Friend WithEvents LGST As Label
    Friend WithEvents LGestionServicTec As Label
    Friend WithEvents PBCerrar As PictureBox
    Friend WithEvents PBMinimizar As PictureBox

End Class
