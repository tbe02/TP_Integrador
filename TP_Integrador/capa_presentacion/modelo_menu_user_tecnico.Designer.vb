<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modelo_menu_user_tecnico
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
        components = New ComponentModel.Container()
        TSMCerrarSesion = New ToolStripMenuItem()
        MenuPerfil = New ContextMenuStrip(components)
        TSMMiPerfil = New ToolStripMenuItem()
        LGestionServicTec = New Label()
        PBIconoEmpresa = New PictureBox()
        LGST = New Label()
        PFondoPrincipal = New Panel()
        IBListaEquipos = New FontAwesome.Sharp.IconButton()
        PMenuIzquierdo = New Panel()
        IBCerrar = New FontAwesome.Sharp.IconButton()
        IBSesion = New FontAwesome.Sharp.IconButton()
        IBMaximizar = New FontAwesome.Sharp.IconButton()
        IBMinimizar = New FontAwesome.Sharp.IconButton()
        PMenuSuperior = New Panel()
        BMinimizar = New FontAwesome.Sharp.IconButton()
        BMaximizar = New FontAwesome.Sharp.IconButton()
        BCerrar = New FontAwesome.Sharp.IconButton()
        MenuPerfil.SuspendLayout()
        CType(PBIconoEmpresa, ComponentModel.ISupportInitialize).BeginInit()
        PMenuIzquierdo.SuspendLayout()
        PMenuSuperior.SuspendLayout()
        SuspendLayout()
        ' 
        ' TSMCerrarSesion
        ' 
        TSMCerrarSesion.AutoSize = False
        TSMCerrarSesion.BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        TSMCerrarSesion.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TSMCerrarSesion.ForeColor = Color.White
        TSMCerrarSesion.ImageTransparentColor = Color.Transparent
        TSMCerrarSesion.Name = "TSMCerrarSesion"
        TSMCerrarSesion.Size = New Size(176, 29)
        TSMCerrarSesion.Text = "Cerrar sesión"
        ' 
        ' MenuPerfil
        ' 
        MenuPerfil.BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        MenuPerfil.ImageScalingSize = New Size(20, 20)
        MenuPerfil.Items.AddRange(New ToolStripItem() {TSMMiPerfil, TSMCerrarSesion})
        MenuPerfil.Name = "ContextMenuStrip1"
        MenuPerfil.RenderMode = ToolStripRenderMode.System
        MenuPerfil.Size = New Size(148, 62)
        ' 
        ' TSMMiPerfil
        ' 
        TSMMiPerfil.AutoSize = False
        TSMMiPerfil.BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        TSMMiPerfil.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TSMMiPerfil.ForeColor = Color.White
        TSMMiPerfil.ImageTransparentColor = Color.Transparent
        TSMMiPerfil.Name = "TSMMiPerfil"
        TSMMiPerfil.Size = New Size(176, 29)
        TSMMiPerfil.Text = "Mi perfil"
        ' 
        ' LGestionServicTec
        ' 
        LGestionServicTec.AutoSize = True
        LGestionServicTec.BackColor = Color.Transparent
        LGestionServicTec.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LGestionServicTec.ForeColor = Color.Silver
        LGestionServicTec.Location = New Point(32, 153)
        LGestionServicTec.Name = "LGestionServicTec"
        LGestionServicTec.Size = New Size(165, 17)
        LGestionServicTec.TabIndex = 13
        LGestionServicTec.Text = "Gestión Servicio Técnico"
        ' 
        ' PBIconoEmpresa
        ' 
        PBIconoEmpresa.BackColor = Color.Transparent
        PBIconoEmpresa.Image = My.Resources.Resources.impresora21
        PBIconoEmpresa.Location = New Point(32, 22)
        PBIconoEmpresa.Name = "PBIconoEmpresa"
        PBIconoEmpresa.Size = New Size(144, 117)
        PBIconoEmpresa.SizeMode = PictureBoxSizeMode.StretchImage
        PBIconoEmpresa.TabIndex = 12
        PBIconoEmpresa.TabStop = False
        ' 
        ' LGST
        ' 
        LGST.AutoSize = True
        LGST.BackColor = Color.Transparent
        LGST.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LGST.ForeColor = Color.Silver
        LGST.Location = New Point(89, 136)
        LGST.Name = "LGST"
        LGST.Size = New Size(42, 20)
        LGST.TabIndex = 12
        LGST.Text = "GST"
        ' 
        ' PFondoPrincipal
        ' 
        PFondoPrincipal.BackColor = Color.Transparent
        PFondoPrincipal.Location = New Point(219, 62)
        PFondoPrincipal.Name = "PFondoPrincipal"
        PFondoPrincipal.Size = New Size(915, 613)
        PFondoPrincipal.TabIndex = 7
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
        IBListaEquipos.Location = New Point(2, 222)
        IBListaEquipos.Margin = New Padding(3, 2, 3, 2)
        IBListaEquipos.Name = "IBListaEquipos"
        IBListaEquipos.Size = New Size(216, 45)
        IBListaEquipos.TabIndex = 8
        IBListaEquipos.Text = "Lista de equipos"
        IBListaEquipos.UseVisualStyleBackColor = False
        ' 
        ' PMenuIzquierdo
        ' 
        PMenuIzquierdo.BackColor = Color.FromArgb(CByte(31), CByte(30), CByte(68))
        PMenuIzquierdo.BorderStyle = BorderStyle.FixedSingle
        PMenuIzquierdo.Controls.Add(LGestionServicTec)
        PMenuIzquierdo.Controls.Add(PBIconoEmpresa)
        PMenuIzquierdo.Controls.Add(LGST)
        PMenuIzquierdo.Controls.Add(IBListaEquipos)
        PMenuIzquierdo.Dock = DockStyle.Left
        PMenuIzquierdo.Location = New Point(0, 0)
        PMenuIzquierdo.Margin = New Padding(3, 2, 3, 2)
        PMenuIzquierdo.Name = "PMenuIzquierdo"
        PMenuIzquierdo.Size = New Size(219, 692)
        PMenuIzquierdo.TabIndex = 5
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
        IBCerrar.Location = New Point(1640, 2)
        IBCerrar.Margin = New Padding(3, 2, 3, 2)
        IBCerrar.Name = "IBCerrar"
        IBCerrar.Size = New Size(19, 17)
        IBCerrar.TabIndex = 13
        IBCerrar.UseVisualStyleBackColor = False
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
        IBSesion.Location = New Point(718, 10)
        IBSesion.Margin = New Padding(3, 2, 3, 2)
        IBSesion.Name = "IBSesion"
        IBSesion.Size = New Size(127, 33)
        IBSesion.TabIndex = 16
        IBSesion.Text = "Theo"
        IBSesion.UseVisualStyleBackColor = False
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
        IBMaximizar.Location = New Point(1616, 2)
        IBMaximizar.Margin = New Padding(3, 2, 3, 2)
        IBMaximizar.Name = "IBMaximizar"
        IBMaximizar.Size = New Size(19, 17)
        IBMaximizar.TabIndex = 14
        IBMaximizar.UseVisualStyleBackColor = False
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
        IBMinimizar.Location = New Point(1591, 2)
        IBMinimizar.Margin = New Padding(3, 2, 3, 2)
        IBMinimizar.Name = "IBMinimizar"
        IBMinimizar.Size = New Size(19, 17)
        IBMinimizar.TabIndex = 15
        IBMinimizar.UseVisualStyleBackColor = False
        ' 
        ' PMenuSuperior
        ' 
        PMenuSuperior.BackColor = Color.FromArgb(CByte(26), CByte(25), CByte(72))
        PMenuSuperior.Controls.Add(BMinimizar)
        PMenuSuperior.Controls.Add(BMaximizar)
        PMenuSuperior.Controls.Add(BCerrar)
        PMenuSuperior.Controls.Add(IBMinimizar)
        PMenuSuperior.Controls.Add(IBMaximizar)
        PMenuSuperior.Controls.Add(IBSesion)
        PMenuSuperior.Controls.Add(IBCerrar)
        PMenuSuperior.Dock = DockStyle.Top
        PMenuSuperior.Location = New Point(219, 0)
        PMenuSuperior.Margin = New Padding(3, 2, 3, 2)
        PMenuSuperior.Name = "PMenuSuperior"
        PMenuSuperior.Size = New Size(931, 57)
        PMenuSuperior.TabIndex = 6
        ' 
        ' BMinimizar
        ' 
        BMinimizar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BMinimizar.BackColor = Color.Transparent
        BMinimizar.FlatAppearance.BorderSize = 0
        BMinimizar.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        BMinimizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        BMinimizar.FlatStyle = FlatStyle.Flat
        BMinimizar.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BMinimizar.ForeColor = Color.White
        BMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        BMinimizar.IconColor = Color.Gray
        BMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto
        BMinimizar.IconSize = 20
        BMinimizar.Location = New Point(863, 2)
        BMinimizar.Margin = New Padding(3, 2, 3, 2)
        BMinimizar.Name = "BMinimizar"
        BMinimizar.Size = New Size(19, 17)
        BMinimizar.TabIndex = 19
        BMinimizar.UseVisualStyleBackColor = False
        ' 
        ' BMaximizar
        ' 
        BMaximizar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BMaximizar.BackColor = Color.Transparent
        BMaximizar.FlatAppearance.BorderSize = 0
        BMaximizar.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        BMaximizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        BMaximizar.FlatStyle = FlatStyle.Flat
        BMaximizar.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BMaximizar.ForeColor = Color.White
        BMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize
        BMaximizar.IconColor = Color.Gray
        BMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto
        BMaximizar.IconSize = 20
        BMaximizar.Location = New Point(888, 2)
        BMaximizar.Margin = New Padding(3, 2, 3, 2)
        BMaximizar.Name = "BMaximizar"
        BMaximizar.Size = New Size(19, 17)
        BMaximizar.TabIndex = 18
        BMaximizar.UseVisualStyleBackColor = False
        ' 
        ' BCerrar
        ' 
        BCerrar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BCerrar.BackColor = Color.Transparent
        BCerrar.FlatAppearance.BorderSize = 0
        BCerrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        BCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        BCerrar.FlatStyle = FlatStyle.Flat
        BCerrar.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BCerrar.ForeColor = Color.White
        BCerrar.IconChar = FontAwesome.Sharp.IconChar.Close
        BCerrar.IconColor = Color.Gray
        BCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto
        BCerrar.IconSize = 20
        BCerrar.Location = New Point(912, 2)
        BCerrar.Margin = New Padding(3, 2, 3, 2)
        BCerrar.Name = "BCerrar"
        BCerrar.Size = New Size(19, 17)
        BCerrar.TabIndex = 17
        BCerrar.UseVisualStyleBackColor = False
        ' 
        ' modelo_menu_user_tecnico
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        ClientSize = New Size(1150, 692)
        Controls.Add(PFondoPrincipal)
        Controls.Add(PMenuSuperior)
        Controls.Add(PMenuIzquierdo)
        FormBorderStyle = FormBorderStyle.None
        Name = "modelo_menu_user_tecnico"
        Text = "modelo_menu_user_tecnico"
        MenuPerfil.ResumeLayout(False)
        CType(PBIconoEmpresa, ComponentModel.ISupportInitialize).EndInit()
        PMenuIzquierdo.ResumeLayout(False)
        PMenuIzquierdo.PerformLayout()
        PMenuSuperior.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TSMCerrarSesion As ToolStripMenuItem
    Friend WithEvents MenuPerfil As ContextMenuStrip
    Friend WithEvents TSMMiPerfil As ToolStripMenuItem
    Friend WithEvents LGestionServicTec As Label
    Friend WithEvents PBIconoEmpresa As PictureBox
    Friend WithEvents LGST As Label
    Friend WithEvents IBListaEquipos As FontAwesome.Sharp.IconButton
    Friend WithEvents PMenuIzquierdo As Panel
    Friend WithEvents PFondoPrincipal As Panel
    Friend WithEvents IBCerrar As FontAwesome.Sharp.IconButton
    Friend WithEvents IBSesion As FontAwesome.Sharp.IconButton
    Friend WithEvents IBMaximizar As FontAwesome.Sharp.IconButton
    Friend WithEvents IBMinimizar As FontAwesome.Sharp.IconButton
    Friend WithEvents PMenuSuperior As Panel
    Friend WithEvents BMinimizar As FontAwesome.Sharp.IconButton
    Friend WithEvents BMaximizar As FontAwesome.Sharp.IconButton
    Friend WithEvents BCerrar As FontAwesome.Sharp.IconButton
End Class
