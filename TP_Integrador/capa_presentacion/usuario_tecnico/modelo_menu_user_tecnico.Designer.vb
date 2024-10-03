<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class modelo_menu_user_tecnico
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
        components = New ComponentModel.Container()
        PMenuIzquierdo = New Panel()
        LGestionServicTec = New Label()
        PBIconoEmpresa = New PictureBox()
        LGST = New Label()
        IBMenuPrincipal = New FontAwesome.Sharp.IconButton()
        IBListaEquipos = New FontAwesome.Sharp.IconButton()
        PFondoPrincipal = New Panel()
        PMenuSuperior = New Panel()
        IBMinimizar = New FontAwesome.Sharp.IconButton()
        IBMaximizar = New FontAwesome.Sharp.IconButton()
        IBSesion = New FontAwesome.Sharp.IconButton()
        IBCerrar = New FontAwesome.Sharp.IconButton()
        MenuPerfil = New ContextMenuStrip(components)
        TSMCerrarSesion = New ToolStripMenuItem()
        PMenuIzquierdo.SuspendLayout()
        CType(PBIconoEmpresa, ComponentModel.ISupportInitialize).BeginInit()
        PMenuSuperior.SuspendLayout()
        MenuPerfil.SuspendLayout()
        SuspendLayout()
        ' 
        ' PMenuIzquierdo
        ' 
        PMenuIzquierdo.BackColor = Color.FromArgb(CByte(31), CByte(30), CByte(68))
        PMenuIzquierdo.Controls.Add(LGestionServicTec)
        PMenuIzquierdo.Controls.Add(PBIconoEmpresa)
        PMenuIzquierdo.Controls.Add(LGST)
        PMenuIzquierdo.Controls.Add(IBMenuPrincipal)
        PMenuIzquierdo.Controls.Add(IBListaEquipos)
        PMenuIzquierdo.Dock = DockStyle.Left
        PMenuIzquierdo.Location = New Point(0, 0)
        PMenuIzquierdo.Name = "PMenuIzquierdo"
        PMenuIzquierdo.Size = New Size(250, 737)
        PMenuIzquierdo.TabIndex = 1
        ' 
        ' LGestionServicTec
        ' 
        LGestionServicTec.AutoSize = True
        LGestionServicTec.BackColor = Color.Transparent
        LGestionServicTec.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LGestionServicTec.ForeColor = Color.Silver
        LGestionServicTec.Location = New Point(37, 214)
        LGestionServicTec.Name = "LGestionServicTec"
        LGestionServicTec.Size = New Size(165, 17)
        LGestionServicTec.TabIndex = 13
        LGestionServicTec.Text = "Gestión Servicio Técnico"
        ' 
        ' PBIconoEmpresa
        ' 
        PBIconoEmpresa.BackColor = Color.Transparent
        PBIconoEmpresa.Image = My.Resources.Resources.impresora21
        PBIconoEmpresa.Location = New Point(37, 30)
        PBIconoEmpresa.Margin = New Padding(3, 4, 3, 4)
        PBIconoEmpresa.Name = "PBIconoEmpresa"
        PBIconoEmpresa.Size = New Size(164, 156)
        PBIconoEmpresa.SizeMode = PictureBoxSizeMode.StretchImage
        PBIconoEmpresa.TabIndex = 12
        PBIconoEmpresa.TabStop = False
        ' 
        ' LGST
        ' 
        LGST.AutoSize = True
        LGST.BackColor = Color.Transparent
        LGST.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LGST.ForeColor = Color.Silver
        LGST.Location = New Point(102, 190)
        LGST.Name = "LGST"
        LGST.Size = New Size(42, 20)
        LGST.TabIndex = 12
        LGST.Text = "GST"
        ' 
        ' IBMenuPrincipal
        ' 
        IBMenuPrincipal.BackColor = Color.Transparent
        IBMenuPrincipal.FlatAppearance.BorderSize = 0
        IBMenuPrincipal.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        IBMenuPrincipal.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        IBMenuPrincipal.FlatStyle = FlatStyle.Flat
        IBMenuPrincipal.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        IBMenuPrincipal.ForeColor = Color.White
        IBMenuPrincipal.IconChar = FontAwesome.Sharp.IconChar.House
        IBMenuPrincipal.IconColor = Color.White
        IBMenuPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto
        IBMenuPrincipal.IconSize = 40
        IBMenuPrincipal.ImageAlign = ContentAlignment.MiddleLeft
        IBMenuPrincipal.Location = New Point(0, 293)
        IBMenuPrincipal.Name = "IBMenuPrincipal"
        IBMenuPrincipal.Size = New Size(247, 60)
        IBMenuPrincipal.TabIndex = 10
        IBMenuPrincipal.Text = "Menú principal"
        IBMenuPrincipal.UseVisualStyleBackColor = False
        ' 
        ' IBListaEquipos
        ' 
        IBListaEquipos.BackColor = Color.Transparent
        IBListaEquipos.FlatAppearance.BorderSize = 0
        IBListaEquipos.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        IBListaEquipos.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        IBListaEquipos.FlatStyle = FlatStyle.Flat
        IBListaEquipos.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        IBListaEquipos.ForeColor = Color.White
        IBListaEquipos.IconChar = FontAwesome.Sharp.IconChar.ListAlt
        IBListaEquipos.IconColor = Color.White
        IBListaEquipos.IconFont = FontAwesome.Sharp.IconFont.Auto
        IBListaEquipos.IconSize = 40
        IBListaEquipos.ImageAlign = ContentAlignment.MiddleLeft
        IBListaEquipos.Location = New Point(0, 368)
        IBListaEquipos.Name = "IBListaEquipos"
        IBListaEquipos.Size = New Size(247, 60)
        IBListaEquipos.TabIndex = 8
        IBListaEquipos.Text = "Lista de equipos"
        IBListaEquipos.UseVisualStyleBackColor = False
        ' 
        ' PFondoPrincipal
        ' 
        PFondoPrincipal.BackColor = Color.Transparent
        PFondoPrincipal.Location = New Point(256, 66)
        PFondoPrincipal.Name = "PFondoPrincipal"
        PFondoPrincipal.Size = New Size(932, 653)
        PFondoPrincipal.TabIndex = 3
        ' 
        ' PMenuSuperior
        ' 
        PMenuSuperior.BackColor = Color.FromArgb(CByte(26), CByte(25), CByte(72))
        PMenuSuperior.Controls.Add(IBMinimizar)
        PMenuSuperior.Controls.Add(IBMaximizar)
        PMenuSuperior.Controls.Add(IBSesion)
        PMenuSuperior.Controls.Add(IBCerrar)
        PMenuSuperior.Dock = DockStyle.Top
        PMenuSuperior.Location = New Point(250, 0)
        PMenuSuperior.Name = "PMenuSuperior"
        PMenuSuperior.Size = New Size(950, 60)
        PMenuSuperior.TabIndex = 2
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
        IBMinimizar.Location = New Point(869, 3)
        IBMinimizar.Name = "IBMinimizar"
        IBMinimizar.Size = New Size(22, 23)
        IBMinimizar.TabIndex = 15
        IBMinimizar.UseVisualStyleBackColor = False
        ' 
        ' IBMaximizar
        ' 
        IBMaximizar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        IBMaximizar.BackColor = Color.Transparent
        IBMaximizar.FlatAppearance.BorderSize = 0
        IBMaximizar.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        IBMaximizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        IBMaximizar.FlatStyle = FlatStyle.Flat
        IBMaximizar.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        IBMaximizar.ForeColor = Color.White
        IBMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize
        IBMaximizar.IconColor = Color.Gray
        IBMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto
        IBMaximizar.IconSize = 20
        IBMaximizar.Location = New Point(897, 3)
        IBMaximizar.Name = "IBMaximizar"
        IBMaximizar.Size = New Size(22, 23)
        IBMaximizar.TabIndex = 14
        IBMaximizar.UseVisualStyleBackColor = False
        ' 
        ' IBSesion
        ' 
        IBSesion.BackColor = Color.Transparent
        IBSesion.FlatAppearance.BorderSize = 0
        IBSesion.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        IBSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        IBSesion.FlatStyle = FlatStyle.Flat
        IBSesion.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        IBSesion.ForeColor = Color.White
        IBSesion.IconChar = FontAwesome.Sharp.IconChar.UserCircle
        IBSesion.IconColor = Color.White
        IBSesion.IconFont = FontAwesome.Sharp.IconFont.Auto
        IBSesion.IconSize = 40
        IBSesion.ImageAlign = ContentAlignment.MiddleLeft
        IBSesion.Location = New Point(699, 13)
        IBSesion.Name = "IBSesion"
        IBSesion.Size = New Size(145, 44)
        IBSesion.TabIndex = 16
        IBSesion.Text = "Theo"
        IBSesion.UseVisualStyleBackColor = False
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
        IBCerrar.Location = New Point(925, 3)
        IBCerrar.Name = "IBCerrar"
        IBCerrar.Size = New Size(22, 23)
        IBCerrar.TabIndex = 13
        IBCerrar.UseVisualStyleBackColor = False
        ' 
        ' MenuPerfil
        ' 
        MenuPerfil.BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        MenuPerfil.ImageScalingSize = New Size(20, 20)
        MenuPerfil.Items.AddRange(New ToolStripItem() {TSMCerrarSesion})
        MenuPerfil.Name = "ContextMenuStrip1"
        MenuPerfil.RenderMode = ToolStripRenderMode.System
        MenuPerfil.Size = New Size(148, 33)
        ' 
        ' TSMCerrarSesion
        ' 
        TSMCerrarSesion.AutoSize = False
        TSMCerrarSesion.BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        TSMCerrarSesion.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TSMCerrarSesion.ForeColor = Color.White
        TSMCerrarSesion.ImageTransparentColor = Color.Transparent
        TSMCerrarSesion.Name = "TSMCerrarSesion"
        TSMCerrarSesion.Size = New Size(160, 29)
        TSMCerrarSesion.Text = "Cerrar sesión"
        ' 
        ' modelo_menu_user_tecnico
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        ClientSize = New Size(1200, 737)
        Controls.Add(PFondoPrincipal)
        Controls.Add(PMenuSuperior)
        Controls.Add(PMenuIzquierdo)
        FormBorderStyle = FormBorderStyle.None
        Name = "modelo_menu_user_tecnico"
        Text = "modelo_menu_principal"
        PMenuIzquierdo.ResumeLayout(False)
        PMenuIzquierdo.PerformLayout()
        CType(PBIconoEmpresa, ComponentModel.ISupportInitialize).EndInit()
        PMenuSuperior.ResumeLayout(False)
        MenuPerfil.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents PMenuIzquierdo As Panel
    Friend WithEvents PMenuSuperior As Panel
    Friend WithEvents IBListaEquipos As FontAwesome.Sharp.IconButton
    Friend WithEvents IBMenuPrincipal As FontAwesome.Sharp.IconButton
    Friend WithEvents PBIconoEmpresa As PictureBox
    Friend WithEvents IBCerrar As FontAwesome.Sharp.IconButton
    Friend WithEvents IBMinimizar As FontAwesome.Sharp.IconButton
    Friend WithEvents IBMaximizar As FontAwesome.Sharp.IconButton
    Friend WithEvents LGestionServicTec As Label
    Friend WithEvents LGST As Label
    Friend WithEvents IBSesion As FontAwesome.Sharp.IconButton
    Friend WithEvents MenuPerfil As ContextMenuStrip
    Friend WithEvents TSMCerrarSesion As ToolStripMenuItem
    Friend WithEvents PFondoPrincipal As Panel
End Class
