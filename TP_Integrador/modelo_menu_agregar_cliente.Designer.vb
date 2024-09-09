<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modelo_menu_agregar_cliente
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
        IBAgregarCliente = New FontAwesome.Sharp.IconButton()
        IBAgregarEquipo = New FontAwesome.Sharp.IconButton()
        IBListaClientes = New FontAwesome.Sharp.IconButton()
        IBListaEquipos = New FontAwesome.Sharp.IconButton()
        PMenuSuperior = New Panel()
        IBMinimizar = New FontAwesome.Sharp.IconButton()
        IBMaximizar = New FontAwesome.Sharp.IconButton()
        IBSesion = New FontAwesome.Sharp.IconButton()
        IBCerrar = New FontAwesome.Sharp.IconButton()
        MenuPerfil = New ContextMenuStrip(components)
        TSMMiPerfil = New ToolStripMenuItem()
        TSMCerrarSesion = New ToolStripMenuItem()
        PAgregarCliente = New Panel()
        BAgregarCliente = New Button()
        LAgregarCliente = New Label()
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
        PBAgregarCliente = New PictureBox()
        PMenuIzquierdo.SuspendLayout()
        CType(PBIconoEmpresa, ComponentModel.ISupportInitialize).BeginInit()
        PMenuSuperior.SuspendLayout()
        MenuPerfil.SuspendLayout()
        PAgregarCliente.SuspendLayout()
        CType(PBAgregarCliente, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PMenuIzquierdo
        ' 
        PMenuIzquierdo.BackColor = Color.FromArgb(CByte(31), CByte(30), CByte(68))
        PMenuIzquierdo.Controls.Add(LGestionServicTec)
        PMenuIzquierdo.Controls.Add(PBIconoEmpresa)
        PMenuIzquierdo.Controls.Add(LGST)
        PMenuIzquierdo.Controls.Add(IBMenuPrincipal)
        PMenuIzquierdo.Controls.Add(IBAgregarCliente)
        PMenuIzquierdo.Controls.Add(IBAgregarEquipo)
        PMenuIzquierdo.Controls.Add(IBListaClientes)
        PMenuIzquierdo.Controls.Add(IBListaEquipos)
        PMenuIzquierdo.Dock = DockStyle.Left
        PMenuIzquierdo.Location = New Point(0, 0)
        PMenuIzquierdo.Margin = New Padding(3, 2, 3, 2)
        PMenuIzquierdo.Name = "PMenuIzquierdo"
        PMenuIzquierdo.Size = New Size(219, 714)
        PMenuIzquierdo.TabIndex = 1
        ' 
        ' LGestionServicTec
        ' 
        LGestionServicTec.AutoSize = True
        LGestionServicTec.BackColor = Color.Transparent
        LGestionServicTec.Font = New Font("Berlin Sans FB", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LGestionServicTec.ForeColor = Color.Silver
        LGestionServicTec.Location = New Point(32, 153)
        LGestionServicTec.Name = "LGestionServicTec"
        LGestionServicTec.Size = New Size(140, 16)
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
        LGST.Font = New Font("Berlin Sans FB", 12.0F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LGST.ForeColor = Color.Silver
        LGST.Location = New Point(89, 136)
        LGST.Name = "LGST"
        LGST.Size = New Size(34, 18)
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
        IBMenuPrincipal.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        IBMenuPrincipal.ForeColor = Color.White
        IBMenuPrincipal.IconChar = FontAwesome.Sharp.IconChar.House
        IBMenuPrincipal.IconColor = Color.White
        IBMenuPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto
        IBMenuPrincipal.IconSize = 40
        IBMenuPrincipal.ImageAlign = ContentAlignment.MiddleLeft
        IBMenuPrincipal.Location = New Point(-3, 220)
        IBMenuPrincipal.Margin = New Padding(3, 2, 3, 2)
        IBMenuPrincipal.Name = "IBMenuPrincipal"
        IBMenuPrincipal.Size = New Size(219, 45)
        IBMenuPrincipal.TabIndex = 10
        IBMenuPrincipal.Text = "Menú principal"
        IBMenuPrincipal.UseVisualStyleBackColor = False
        ' 
        ' IBAgregarCliente
        ' 
        IBAgregarCliente.BackColor = Color.Transparent
        IBAgregarCliente.FlatAppearance.BorderSize = 0
        IBAgregarCliente.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        IBAgregarCliente.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        IBAgregarCliente.FlatStyle = FlatStyle.Flat
        IBAgregarCliente.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        IBAgregarCliente.ForeColor = Color.White
        IBAgregarCliente.IconChar = FontAwesome.Sharp.IconChar.User
        IBAgregarCliente.IconColor = Color.White
        IBAgregarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto
        IBAgregarCliente.IconSize = 40
        IBAgregarCliente.ImageAlign = ContentAlignment.MiddleLeft
        IBAgregarCliente.Location = New Point(0, 276)
        IBAgregarCliente.Margin = New Padding(3, 2, 3, 2)
        IBAgregarCliente.Name = "IBAgregarCliente"
        IBAgregarCliente.Size = New Size(216, 45)
        IBAgregarCliente.TabIndex = 11
        IBAgregarCliente.Text = "Agregar cliente"
        IBAgregarCliente.UseVisualStyleBackColor = False
        ' 
        ' IBAgregarEquipo
        ' 
        IBAgregarEquipo.BackColor = Color.Transparent
        IBAgregarEquipo.FlatAppearance.BorderSize = 0
        IBAgregarEquipo.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        IBAgregarEquipo.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        IBAgregarEquipo.FlatStyle = FlatStyle.Flat
        IBAgregarEquipo.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        IBAgregarEquipo.ForeColor = Color.White
        IBAgregarEquipo.IconChar = FontAwesome.Sharp.IconChar.Computer
        IBAgregarEquipo.IconColor = Color.White
        IBAgregarEquipo.IconFont = FontAwesome.Sharp.IconFont.Auto
        IBAgregarEquipo.IconSize = 40
        IBAgregarEquipo.ImageAlign = ContentAlignment.MiddleLeft
        IBAgregarEquipo.Location = New Point(3, 393)
        IBAgregarEquipo.Margin = New Padding(3, 2, 3, 2)
        IBAgregarEquipo.Name = "IBAgregarEquipo"
        IBAgregarEquipo.Size = New Size(214, 45)
        IBAgregarEquipo.TabIndex = 10
        IBAgregarEquipo.Text = "Agregar equipo"
        IBAgregarEquipo.UseVisualStyleBackColor = False
        ' 
        ' IBListaClientes
        ' 
        IBListaClientes.BackColor = Color.Transparent
        IBListaClientes.FlatAppearance.BorderSize = 0
        IBListaClientes.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        IBListaClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        IBListaClientes.FlatStyle = FlatStyle.Flat
        IBListaClientes.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        IBListaClientes.ForeColor = Color.White
        IBListaClientes.IconChar = FontAwesome.Sharp.IconChar.ListSquares
        IBListaClientes.IconColor = Color.White
        IBListaClientes.IconFont = FontAwesome.Sharp.IconFont.Auto
        IBListaClientes.IconSize = 40
        IBListaClientes.ImageAlign = ContentAlignment.MiddleLeft
        IBListaClientes.Location = New Point(0, 332)
        IBListaClientes.Margin = New Padding(3, 2, 3, 2)
        IBListaClientes.Name = "IBListaClientes"
        IBListaClientes.Size = New Size(216, 45)
        IBListaClientes.TabIndex = 9
        IBListaClientes.Text = "Lista de clientes"
        IBListaClientes.UseVisualStyleBackColor = False
        ' 
        ' IBListaEquipos
        ' 
        IBListaEquipos.BackColor = Color.Transparent
        IBListaEquipos.FlatAppearance.BorderSize = 0
        IBListaEquipos.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        IBListaEquipos.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        IBListaEquipos.FlatStyle = FlatStyle.Flat
        IBListaEquipos.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        IBListaEquipos.ForeColor = Color.White
        IBListaEquipos.IconChar = FontAwesome.Sharp.IconChar.ListAlt
        IBListaEquipos.IconColor = Color.White
        IBListaEquipos.IconFont = FontAwesome.Sharp.IconFont.Auto
        IBListaEquipos.IconSize = 40
        IBListaEquipos.ImageAlign = ContentAlignment.MiddleLeft
        IBListaEquipos.Location = New Point(0, 455)
        IBListaEquipos.Margin = New Padding(3, 2, 3, 2)
        IBListaEquipos.Name = "IBListaEquipos"
        IBListaEquipos.Size = New Size(216, 45)
        IBListaEquipos.TabIndex = 8
        IBListaEquipos.Text = "Lista de equipos"
        IBListaEquipos.UseVisualStyleBackColor = False
        ' 
        ' PMenuSuperior
        ' 
        PMenuSuperior.BackColor = Color.FromArgb(CByte(26), CByte(25), CByte(72))
        PMenuSuperior.Controls.Add(IBMinimizar)
        PMenuSuperior.Controls.Add(IBMaximizar)
        PMenuSuperior.Controls.Add(IBSesion)
        PMenuSuperior.Controls.Add(IBCerrar)
        PMenuSuperior.Dock = DockStyle.Top
        PMenuSuperior.Location = New Point(219, 0)
        PMenuSuperior.Margin = New Padding(3, 2, 3, 2)
        PMenuSuperior.Name = "PMenuSuperior"
        PMenuSuperior.Size = New Size(931, 45)
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
        IBMinimizar.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        IBMinimizar.ForeColor = Color.White
        IBMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        IBMinimizar.IconColor = Color.Gray
        IBMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto
        IBMinimizar.IconSize = 20
        IBMinimizar.Location = New Point(860, 2)
        IBMinimizar.Margin = New Padding(3, 2, 3, 2)
        IBMinimizar.Name = "IBMinimizar"
        IBMinimizar.Size = New Size(19, 17)
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
        IBMaximizar.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        IBMaximizar.ForeColor = Color.White
        IBMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize
        IBMaximizar.IconColor = Color.Gray
        IBMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto
        IBMaximizar.IconSize = 20
        IBMaximizar.Location = New Point(885, 2)
        IBMaximizar.Margin = New Padding(3, 2, 3, 2)
        IBMaximizar.Name = "IBMaximizar"
        IBMaximizar.Size = New Size(19, 17)
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
        IBSesion.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        IBSesion.ForeColor = Color.White
        IBSesion.IconChar = FontAwesome.Sharp.IconChar.UserCircle
        IBSesion.IconColor = Color.White
        IBSesion.IconFont = FontAwesome.Sharp.IconFont.Auto
        IBSesion.IconSize = 40
        IBSesion.ImageAlign = ContentAlignment.MiddleLeft
        IBSesion.Location = New Point(687, 9)
        IBSesion.Margin = New Padding(3, 2, 3, 2)
        IBSesion.Name = "IBSesion"
        IBSesion.Size = New Size(127, 33)
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
        IBCerrar.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        IBCerrar.ForeColor = Color.White
        IBCerrar.IconChar = FontAwesome.Sharp.IconChar.Close
        IBCerrar.IconColor = Color.Gray
        IBCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto
        IBCerrar.IconSize = 20
        IBCerrar.Location = New Point(909, 2)
        IBCerrar.Margin = New Padding(3, 2, 3, 2)
        IBCerrar.Name = "IBCerrar"
        IBCerrar.Size = New Size(19, 17)
        IBCerrar.TabIndex = 13
        IBCerrar.UseVisualStyleBackColor = False
        ' 
        ' MenuPerfil
        ' 
        MenuPerfil.BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        MenuPerfil.ImageScalingSize = New Size(20, 20)
        MenuPerfil.Items.AddRange(New ToolStripItem() {TSMMiPerfil, TSMCerrarSesion})
        MenuPerfil.Name = "ContextMenuStrip1"
        MenuPerfil.RenderMode = ToolStripRenderMode.System
        MenuPerfil.Size = New Size(154, 62)
        ' 
        ' TSMMiPerfil
        ' 
        TSMMiPerfil.AutoSize = False
        TSMMiPerfil.BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        TSMMiPerfil.Font = New Font("Arial Rounded MT Bold", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TSMMiPerfil.ForeColor = Color.White
        TSMMiPerfil.ImageTransparentColor = Color.Transparent
        TSMMiPerfil.Name = "TSMMiPerfil"
        TSMMiPerfil.Size = New Size(176, 29)
        TSMMiPerfil.Text = "Mi perfil"
        ' 
        ' TSMCerrarSesion
        ' 
        TSMCerrarSesion.AutoSize = False
        TSMCerrarSesion.BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        TSMCerrarSesion.Font = New Font("Arial Rounded MT Bold", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TSMCerrarSesion.ForeColor = Color.White
        TSMCerrarSesion.ImageTransparentColor = Color.Transparent
        TSMCerrarSesion.Name = "TSMCerrarSesion"
        TSMCerrarSesion.Size = New Size(176, 29)
        TSMCerrarSesion.Text = "Cerrar sesión"
        ' 
        ' PAgregarCliente
        ' 
        PAgregarCliente.BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        PAgregarCliente.Controls.Add(BAgregarCliente)
        PAgregarCliente.Controls.Add(LAgregarCliente)
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
        PAgregarCliente.Controls.Add(PBAgregarCliente)
        PAgregarCliente.Location = New Point(416, 64)
        PAgregarCliente.Name = "PAgregarCliente"
        PAgregarCliente.Size = New Size(500, 638)
        PAgregarCliente.TabIndex = 3
        ' 
        ' BAgregarCliente
        ' 
        BAgregarCliente.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BAgregarCliente.FlatAppearance.BorderSize = 0
        BAgregarCliente.FlatStyle = FlatStyle.Flat
        BAgregarCliente.Font = New Font("Arial Rounded MT Bold", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BAgregarCliente.ForeColor = Color.White
        BAgregarCliente.Location = New Point(75, 542)
        BAgregarCliente.Margin = New Padding(3, 2, 3, 2)
        BAgregarCliente.Name = "BAgregarCliente"
        BAgregarCliente.Size = New Size(350, 50)
        BAgregarCliente.TabIndex = 4
        BAgregarCliente.Text = "Agregar cliente"
        BAgregarCliente.UseVisualStyleBackColor = False
        ' 
        ' LAgregarCliente
        ' 
        LAgregarCliente.AutoSize = True
        LAgregarCliente.BackColor = Color.Transparent
        LAgregarCliente.Font = New Font("Bahnschrift Condensed", 36.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LAgregarCliente.ForeColor = Color.White
        LAgregarCliente.Location = New Point(112, 140)
        LAgregarCliente.Name = "LAgregarCliente"
        LAgregarCliente.Size = New Size(275, 58)
        LAgregarCliente.TabIndex = 11
        LAgregarCliente.Text = "Agregar Cliente"
        ' 
        ' LTelefono
        ' 
        LTelefono.AutoSize = True
        LTelefono.Font = New Font("Arial Rounded MT Bold", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LTelefono.ForeColor = Color.Silver
        LTelefono.Location = New Point(40, 466)
        LTelefono.Name = "LTelefono"
        LTelefono.Size = New Size(77, 18)
        LTelefono.TabIndex = 10
        LTelefono.Text = "Telefono"
        ' 
        ' LCorreo
        ' 
        LCorreo.AutoSize = True
        LCorreo.Font = New Font("Arial Rounded MT Bold", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LCorreo.ForeColor = Color.Silver
        LCorreo.Location = New Point(40, 406)
        LCorreo.Name = "LCorreo"
        LCorreo.Size = New Size(64, 18)
        LCorreo.TabIndex = 9
        LCorreo.Text = "Correo"
        ' 
        ' LDNI
        ' 
        LDNI.AutoSize = True
        LDNI.Font = New Font("Arial Rounded MT Bold", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LDNI.ForeColor = Color.Silver
        LDNI.Location = New Point(40, 346)
        LDNI.Name = "LDNI"
        LDNI.Size = New Size(37, 18)
        LDNI.TabIndex = 8
        LDNI.Text = "DNI"
        ' 
        ' LNombre
        ' 
        LNombre.AutoSize = True
        LNombre.Font = New Font("Arial Rounded MT Bold", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LNombre.ForeColor = Color.Silver
        LNombre.Location = New Point(40, 286)
        LNombre.Name = "LNombre"
        LNombre.Size = New Size(84, 18)
        LNombre.TabIndex = 7
        LNombre.Text = "Nombre/s"
        ' 
        ' LApellido
        ' 
        LApellido.AutoSize = True
        LApellido.Font = New Font("Arial Rounded MT Bold", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LApellido.ForeColor = Color.Silver
        LApellido.Location = New Point(40, 226)
        LApellido.Name = "LApellido"
        LApellido.Size = New Size(85, 18)
        LApellido.TabIndex = 6
        LApellido.Text = "Apellido/s"
        ' 
        ' TBTelefono
        ' 
        TBTelefono.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBTelefono.BorderStyle = BorderStyle.None
        TBTelefono.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBTelefono.ForeColor = Color.Silver
        TBTelefono.Location = New Point(189, 466)
        TBTelefono.Margin = New Padding(3, 2, 3, 2)
        TBTelefono.Name = "TBTelefono"
        TBTelefono.Size = New Size(264, 17)
        TBTelefono.TabIndex = 5
        ' 
        ' TBCorreo
        ' 
        TBCorreo.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBCorreo.BorderStyle = BorderStyle.None
        TBCorreo.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBCorreo.ForeColor = Color.Silver
        TBCorreo.Location = New Point(189, 406)
        TBCorreo.Margin = New Padding(3, 2, 3, 2)
        TBCorreo.Name = "TBCorreo"
        TBCorreo.Size = New Size(264, 17)
        TBCorreo.TabIndex = 4
        ' 
        ' TBDNI
        ' 
        TBDNI.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBDNI.BorderStyle = BorderStyle.None
        TBDNI.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBDNI.ForeColor = Color.Silver
        TBDNI.Location = New Point(189, 346)
        TBDNI.Margin = New Padding(3, 2, 3, 2)
        TBDNI.Name = "TBDNI"
        TBDNI.Size = New Size(264, 17)
        TBDNI.TabIndex = 3
        ' 
        ' TBNombre
        ' 
        TBNombre.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBNombre.BorderStyle = BorderStyle.None
        TBNombre.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBNombre.ForeColor = Color.Silver
        TBNombre.Location = New Point(189, 286)
        TBNombre.Margin = New Padding(3, 2, 3, 2)
        TBNombre.Name = "TBNombre"
        TBNombre.Size = New Size(264, 17)
        TBNombre.TabIndex = 2
        ' 
        ' TBApellido
        ' 
        TBApellido.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBApellido.BorderStyle = BorderStyle.None
        TBApellido.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBApellido.ForeColor = Color.Silver
        TBApellido.Location = New Point(189, 226)
        TBApellido.Margin = New Padding(3, 2, 3, 2)
        TBApellido.Name = "TBApellido"
        TBApellido.Size = New Size(264, 17)
        TBApellido.TabIndex = 1
        ' 
        ' PBAgregarCliente
        ' 
        PBAgregarCliente.Image = My.Resources.Resources.agregar_cliente
        PBAgregarCliente.Location = New Point(184, 3)
        PBAgregarCliente.Name = "PBAgregarCliente"
        PBAgregarCliente.Size = New Size(132, 132)
        PBAgregarCliente.TabIndex = 0
        PBAgregarCliente.TabStop = False
        ' 
        ' modelo_menu_agregar_cliente
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        ClientSize = New Size(1150, 714)
        Controls.Add(PAgregarCliente)
        Controls.Add(PMenuSuperior)
        Controls.Add(PMenuIzquierdo)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "modelo_menu_agregar_cliente"
        Text = "modelo_menu_principal"
        PMenuIzquierdo.ResumeLayout(False)
        PMenuIzquierdo.PerformLayout()
        CType(PBIconoEmpresa, ComponentModel.ISupportInitialize).EndInit()
        PMenuSuperior.ResumeLayout(False)
        MenuPerfil.ResumeLayout(False)
        PAgregarCliente.ResumeLayout(False)
        PAgregarCliente.PerformLayout()
        CType(PBAgregarCliente, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents PMenuIzquierdo As Panel
    Friend WithEvents PMenuSuperior As Panel
    Friend WithEvents IBListaEquipos As FontAwesome.Sharp.IconButton
    Friend WithEvents IBMenuPrincipal As FontAwesome.Sharp.IconButton
    Friend WithEvents IBAgregarCliente As FontAwesome.Sharp.IconButton
    Friend WithEvents IBAgregarEquipo As FontAwesome.Sharp.IconButton
    Friend WithEvents IBListaClientes As FontAwesome.Sharp.IconButton
    Friend WithEvents PBIconoEmpresa As PictureBox
    Friend WithEvents IBCerrar As FontAwesome.Sharp.IconButton
    Friend WithEvents IBMinimizar As FontAwesome.Sharp.IconButton
    Friend WithEvents IBMaximizar As FontAwesome.Sharp.IconButton
    Friend WithEvents LGestionServicTec As Label
    Friend WithEvents LGST As Label
    Friend WithEvents IBSesion As FontAwesome.Sharp.IconButton
    Friend WithEvents MenuPerfil As ContextMenuStrip
    Friend WithEvents TSMMiPerfil As ToolStripMenuItem
    Friend WithEvents TSMCerrarSesion As ToolStripMenuItem
    Friend WithEvents PAgregarCliente As Panel
    Friend WithEvents PBAgregarCliente As PictureBox
    Friend WithEvents TBApellido As TextBox
    Friend WithEvents LApellido As Label
    Friend WithEvents TBTelefono As TextBox
    Friend WithEvents TBCorreo As TextBox
    Friend WithEvents TBDNI As TextBox
    Friend WithEvents TBNombre As TextBox
    Friend WithEvents LTelefono As Label
    Friend WithEvents LCorreo As Label
    Friend WithEvents LDNI As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents LAgregarCliente As Label
    Friend WithEvents BAgregarCliente As Button
End Class