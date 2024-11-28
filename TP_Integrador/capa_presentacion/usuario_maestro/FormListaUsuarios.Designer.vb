<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormListaUsuarios
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        IPBBuscarUsuario = New FontAwesome.Sharp.IconPictureBox()
        TBBuscarUsuario = New TextBox()
        PBClientes = New PictureBox()
        LListaClientes = New Label()
        PListaEquipos = New Panel()
        DGVListaUsuarios = New DataGridView()
        C_Apellido = New DataGridViewTextBoxColumn()
        C_Nombre = New DataGridViewTextBoxColumn()
        C_DNI = New DataGridViewTextBoxColumn()
        C_Telefono = New DataGridViewTextBoxColumn()
        C_Correo = New DataGridViewTextBoxColumn()
        C_Usuario = New DataGridViewTextBoxColumn()
        C_TipoDeUsuario = New DataGridViewTextBoxColumn()
        C_Editar = New DataGridViewButtonColumn()
        C_Eliminar = New DataGridViewButtonColumn()
        LFiltrar = New Label()
        CBFiltro = New ComboBox()
        CType(IPBBuscarUsuario, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBClientes, ComponentModel.ISupportInitialize).BeginInit()
        PListaEquipos.SuspendLayout()
        CType(DGVListaUsuarios, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' IPBBuscarUsuario
        ' 
        IPBBuscarUsuario.BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        IPBBuscarUsuario.BackgroundImageLayout = ImageLayout.Stretch
        IPBBuscarUsuario.Cursor = Cursors.Hand
        IPBBuscarUsuario.IconChar = FontAwesome.Sharp.IconChar.Search
        IPBBuscarUsuario.IconColor = Color.White
        IPBBuscarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto
        IPBBuscarUsuario.IconSize = 27
        IPBBuscarUsuario.Location = New Point(1042, 92)
        IPBBuscarUsuario.Margin = New Padding(3, 4, 3, 4)
        IPBBuscarUsuario.Name = "IPBBuscarUsuario"
        IPBBuscarUsuario.Size = New Size(27, 31)
        IPBBuscarUsuario.TabIndex = 22
        IPBBuscarUsuario.TabStop = False
        ' 
        ' TBBuscarUsuario
        ' 
        TBBuscarUsuario.BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        TBBuscarUsuario.ForeColor = SystemColors.Window
        TBBuscarUsuario.Location = New Point(912, 92)
        TBBuscarUsuario.Margin = New Padding(3, 4, 3, 4)
        TBBuscarUsuario.Multiline = True
        TBBuscarUsuario.Name = "TBBuscarUsuario"
        TBBuscarUsuario.Size = New Size(123, 29)
        TBBuscarUsuario.TabIndex = 21
        ' 
        ' PBClientes
        ' 
        PBClientes.Image = My.Resources.Resources.people
        PBClientes.Location = New Point(258, 5)
        PBClientes.Name = "PBClientes"
        PBClientes.Size = New Size(104, 97)
        PBClientes.TabIndex = 20
        PBClientes.TabStop = False
        ' 
        ' LListaClientes
        ' 
        LListaClientes.AutoSize = True
        LListaClientes.BackColor = Color.Transparent
        LListaClientes.Font = New Font("Bahnschrift Condensed", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LListaClientes.ForeColor = Color.White
        LListaClientes.Location = New Point(351, 12)
        LListaClientes.Name = "LListaClientes"
        LListaClientes.Size = New Size(368, 72)
        LListaClientes.TabIndex = 19
        LListaClientes.Text = "Lista de Usuarios"
        ' 
        ' PListaEquipos
        ' 
        PListaEquipos.BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        PListaEquipos.Controls.Add(DGVListaUsuarios)
        PListaEquipos.Location = New Point(13, 149)
        PListaEquipos.Name = "PListaEquipos"
        PListaEquipos.Size = New Size(1059, 755)
        PListaEquipos.TabIndex = 18
        ' 
        ' DGVListaUsuarios
        ' 
        DGVListaUsuarios.AllowUserToResizeColumns = False
        DGVListaUsuarios.AllowUserToResizeRows = False
        DGVListaUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGVListaUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DGVListaUsuarios.BackgroundColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        DGVListaUsuarios.BorderStyle = BorderStyle.None
        DGVListaUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(109), CByte(122), CByte(224))
        DataGridViewCellStyle1.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(109), CByte(122), CByte(224))
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DGVListaUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DGVListaUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVListaUsuarios.Columns.AddRange(New DataGridViewColumn() {C_Apellido, C_Nombre, C_DNI, C_Telefono, C_Correo, C_Usuario, C_TipoDeUsuario, C_Editar, C_Eliminar})
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        DataGridViewCellStyle4.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = Color.White
        DataGridViewCellStyle4.SelectionBackColor = Color.MediumPurple
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        DGVListaUsuarios.DefaultCellStyle = DataGridViewCellStyle4
        DGVListaUsuarios.EnableHeadersVisualStyles = False
        DGVListaUsuarios.GridColor = Color.FromArgb(CByte(109), CByte(122), CByte(224))
        DGVListaUsuarios.Location = New Point(0, 0)
        DGVListaUsuarios.Name = "DGVListaUsuarios"
        DGVListaUsuarios.ReadOnly = True
        DGVListaUsuarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DGVListaUsuarios.RowHeadersVisible = False
        DGVListaUsuarios.RowHeadersWidth = 51
        DataGridViewCellStyle5.ForeColor = Color.White
        DGVListaUsuarios.RowsDefaultCellStyle = DataGridViewCellStyle5
        DGVListaUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGVListaUsuarios.Size = New Size(1054, 751)
        DGVListaUsuarios.TabIndex = 0
        ' 
        ' C_Apellido
        ' 
        C_Apellido.HeaderText = "Apellido"
        C_Apellido.MinimumWidth = 6
        C_Apellido.Name = "C_Apellido"
        C_Apellido.ReadOnly = True
        ' 
        ' C_Nombre
        ' 
        C_Nombre.HeaderText = "Nombre"
        C_Nombre.MinimumWidth = 6
        C_Nombre.Name = "C_Nombre"
        C_Nombre.ReadOnly = True
        C_Nombre.Resizable = DataGridViewTriState.False
        ' 
        ' C_DNI
        ' 
        C_DNI.HeaderText = "DNI"
        C_DNI.MinimumWidth = 6
        C_DNI.Name = "C_DNI"
        C_DNI.ReadOnly = True
        ' 
        ' C_Telefono
        ' 
        C_Telefono.HeaderText = "Telefono"
        C_Telefono.MinimumWidth = 6
        C_Telefono.Name = "C_Telefono"
        C_Telefono.ReadOnly = True
        ' 
        ' C_Correo
        ' 
        C_Correo.HeaderText = "Correo"
        C_Correo.MinimumWidth = 6
        C_Correo.Name = "C_Correo"
        C_Correo.ReadOnly = True
        ' 
        ' C_Usuario
        ' 
        C_Usuario.HeaderText = "Usuario"
        C_Usuario.MinimumWidth = 6
        C_Usuario.Name = "C_Usuario"
        C_Usuario.ReadOnly = True
        C_Usuario.Resizable = DataGridViewTriState.False
        ' 
        ' C_TipoDeUsuario
        ' 
        C_TipoDeUsuario.HeaderText = "Tipo de Usuario"
        C_TipoDeUsuario.MinimumWidth = 6
        C_TipoDeUsuario.Name = "C_TipoDeUsuario"
        C_TipoDeUsuario.ReadOnly = True
        C_TipoDeUsuario.Resizable = DataGridViewTriState.False
        ' 
        ' C_Editar
        ' 
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.SkyBlue
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.SkyBlue
        C_Editar.DefaultCellStyle = DataGridViewCellStyle2
        C_Editar.FlatStyle = FlatStyle.Popup
        C_Editar.HeaderText = "Editar"
        C_Editar.MinimumWidth = 6
        C_Editar.Name = "C_Editar"
        C_Editar.ReadOnly = True
        C_Editar.Text = "Editar"
        C_Editar.UseColumnTextForButtonValue = True
        ' 
        ' C_Eliminar
        ' 
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = Color.SkyBlue
        DataGridViewCellStyle3.ForeColor = Color.White
        DataGridViewCellStyle3.SelectionBackColor = Color.SkyBlue
        C_Eliminar.DefaultCellStyle = DataGridViewCellStyle3
        C_Eliminar.FlatStyle = FlatStyle.Popup
        C_Eliminar.HeaderText = "Eliminar"
        C_Eliminar.MinimumWidth = 6
        C_Eliminar.Name = "C_Eliminar"
        C_Eliminar.ReadOnly = True
        C_Eliminar.Resizable = DataGridViewTriState.False
        C_Eliminar.SortMode = DataGridViewColumnSortMode.Automatic
        C_Eliminar.Text = "Eliminar"
        C_Eliminar.UseColumnTextForButtonValue = True
        ' 
        ' LFiltrar
        ' 
        LFiltrar.AutoSize = True
        LFiltrar.Font = New Font("Segoe UI", 10F)
        LFiltrar.ForeColor = Color.White
        LFiltrar.Location = New Point(679, 94)
        LFiltrar.Name = "LFiltrar"
        LFiltrar.Size = New Size(88, 23)
        LFiltrar.TabIndex = 24
        LFiltrar.Text = "Filtrar por:"
        ' 
        ' CBFiltro
        ' 
        CBFiltro.FormattingEnabled = True
        CBFiltro.Location = New Point(768, 92)
        CBFiltro.Margin = New Padding(3, 4, 3, 4)
        CBFiltro.Name = "CBFiltro"
        CBFiltro.Size = New Size(138, 28)
        CBFiltro.TabIndex = 23
        CBFiltro.Text = "Todos"
        ' 
        ' FormListaUsuarios
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        ClientSize = New Size(1083, 913)
        Controls.Add(LFiltrar)
        Controls.Add(CBFiltro)
        Controls.Add(IPBBuscarUsuario)
        Controls.Add(TBBuscarUsuario)
        Controls.Add(PBClientes)
        Controls.Add(LListaClientes)
        Controls.Add(PListaEquipos)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormListaUsuarios"
        Text = "Form1"
        CType(IPBBuscarUsuario, ComponentModel.ISupportInitialize).EndInit()
        CType(PBClientes, ComponentModel.ISupportInitialize).EndInit()
        PListaEquipos.ResumeLayout(False)
        CType(DGVListaUsuarios, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents IPBBuscarUsuario As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents TBBuscarUsuario As TextBox
    Friend WithEvents PBClientes As PictureBox
    Friend WithEvents LListaClientes As Label
    Friend WithEvents PListaEquipos As Panel
    Friend WithEvents DGVListaUsuarios As DataGridView
    Friend WithEvents C_Apellido As DataGridViewTextBoxColumn
    Friend WithEvents C_Nombre As DataGridViewTextBoxColumn
    Friend WithEvents C_DNI As DataGridViewTextBoxColumn
    Friend WithEvents C_Telefono As DataGridViewTextBoxColumn
    Friend WithEvents C_Correo As DataGridViewTextBoxColumn
    Friend WithEvents C_Usuario As DataGridViewTextBoxColumn
    Friend WithEvents C_TipoDeUsuario As DataGridViewTextBoxColumn
    Friend WithEvents C_Editar As DataGridViewButtonColumn
    Friend WithEvents C_Eliminar As DataGridViewButtonColumn
    Friend WithEvents LFiltrar As Label
    Friend WithEvents CBFiltro As ComboBox
End Class
