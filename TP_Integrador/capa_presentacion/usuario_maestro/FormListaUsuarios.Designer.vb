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
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
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
        IPBBuscarUsuario.IconSize = 23
        IPBBuscarUsuario.Location = New Point(912, 69)
        IPBBuscarUsuario.Name = "IPBBuscarUsuario"
        IPBBuscarUsuario.Size = New Size(24, 23)
        IPBBuscarUsuario.TabIndex = 22
        IPBBuscarUsuario.TabStop = False
        ' 
        ' TBBuscarUsuario
        ' 
        TBBuscarUsuario.BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        TBBuscarUsuario.ForeColor = SystemColors.Window
        TBBuscarUsuario.Location = New Point(798, 69)
        TBBuscarUsuario.Multiline = True
        TBBuscarUsuario.Name = "TBBuscarUsuario"
        TBBuscarUsuario.Size = New Size(108, 23)
        TBBuscarUsuario.TabIndex = 21
        ' 
        ' PBClientes
        ' 
        PBClientes.Image = My.Resources.Resources.people
        PBClientes.Location = New Point(226, 4)
        PBClientes.Margin = New Padding(3, 2, 3, 2)
        PBClientes.Name = "PBClientes"
        PBClientes.Size = New Size(91, 73)
        PBClientes.TabIndex = 20
        PBClientes.TabStop = False
        ' 
        ' LListaClientes
        ' 
        LListaClientes.AutoSize = True
        LListaClientes.BackColor = Color.Transparent
        LListaClientes.Font = New Font("Bahnschrift Condensed", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LListaClientes.ForeColor = Color.White
        LListaClientes.Location = New Point(307, 9)
        LListaClientes.Name = "LListaClientes"
        LListaClientes.Size = New Size(298, 58)
        LListaClientes.TabIndex = 19
        LListaClientes.Text = "Lista de Usuarios"
        ' 
        ' PListaEquipos
        ' 
        PListaEquipos.BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        PListaEquipos.Controls.Add(DGVListaUsuarios)
        PListaEquipos.Location = New Point(11, 112)
        PListaEquipos.Margin = New Padding(3, 2, 3, 2)
        PListaEquipos.Name = "PListaEquipos"
        PListaEquipos.Size = New Size(927, 566)
        PListaEquipos.TabIndex = 18
        ' 
        ' DGVListaUsuarios
        ' 
        DGVListaUsuarios.AllowUserToResizeColumns = False
        DGVListaUsuarios.AllowUserToResizeRows = False
        DGVListaUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGVListaUsuarios.BackgroundColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        DGVListaUsuarios.BorderStyle = BorderStyle.None
        DGVListaUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.FromArgb(CByte(109), CByte(122), CByte(224))
        DataGridViewCellStyle6.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle6.ForeColor = Color.White
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(109), CByte(122), CByte(224))
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        DGVListaUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        DGVListaUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVListaUsuarios.Columns.AddRange(New DataGridViewColumn() {C_Apellido, C_Nombre, C_DNI, C_Telefono, C_Correo, C_Usuario, C_TipoDeUsuario, C_Editar, C_Eliminar})
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        DataGridViewCellStyle9.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle9.ForeColor = Color.White
        DataGridViewCellStyle9.SelectionBackColor = Color.MediumPurple
        DataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = DataGridViewTriState.True
        DGVListaUsuarios.DefaultCellStyle = DataGridViewCellStyle9
        DGVListaUsuarios.EnableHeadersVisualStyles = False
        DGVListaUsuarios.GridColor = Color.FromArgb(CByte(109), CByte(122), CByte(224))
        DGVListaUsuarios.Location = New Point(0, 0)
        DGVListaUsuarios.Margin = New Padding(3, 2, 3, 2)
        DGVListaUsuarios.Name = "DGVListaUsuarios"
        DGVListaUsuarios.ReadOnly = True
        DGVListaUsuarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DGVListaUsuarios.RowHeadersVisible = False
        DGVListaUsuarios.RowHeadersWidth = 51
        DataGridViewCellStyle10.ForeColor = Color.White
        DGVListaUsuarios.RowsDefaultCellStyle = DataGridViewCellStyle10
        DGVListaUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGVListaUsuarios.Size = New Size(922, 563)
        DGVListaUsuarios.TabIndex = 0
        ' 
        ' C_Apellido
        ' 
        C_Apellido.HeaderText = "Apellido"
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
        C_DNI.Name = "C_DNI"
        C_DNI.ReadOnly = True
        ' 
        ' C_Telefono
        ' 
        C_Telefono.HeaderText = "Telefono"
        C_Telefono.Name = "C_Telefono"
        C_Telefono.ReadOnly = True
        ' 
        ' C_Correo
        ' 
        C_Correo.HeaderText = "Correo"
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
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = Color.SkyBlue
        DataGridViewCellStyle7.ForeColor = Color.White
        DataGridViewCellStyle7.SelectionBackColor = Color.SkyBlue
        C_Editar.DefaultCellStyle = DataGridViewCellStyle7
        C_Editar.FlatStyle = FlatStyle.Popup
        C_Editar.HeaderText = "Editar"
        C_Editar.Name = "C_Editar"
        C_Editar.ReadOnly = True
        C_Editar.Text = "Editar"
        C_Editar.UseColumnTextForButtonValue = True
        ' 
        ' C_Eliminar
        ' 
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = Color.SkyBlue
        DataGridViewCellStyle8.ForeColor = Color.White
        DataGridViewCellStyle8.SelectionBackColor = Color.SkyBlue
        C_Eliminar.DefaultCellStyle = DataGridViewCellStyle8
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
        LFiltrar.Location = New Point(593, 70)
        LFiltrar.Name = "LFiltrar"
        LFiltrar.Size = New Size(72, 19)
        LFiltrar.TabIndex = 24
        LFiltrar.Text = "Filtrar por:"
        ' 
        ' CBFiltro
        ' 
        CBFiltro.FormattingEnabled = True
        CBFiltro.Location = New Point(671, 69)
        CBFiltro.Name = "CBFiltro"
        CBFiltro.Size = New Size(121, 23)
        CBFiltro.TabIndex = 23
        CBFiltro.Text = "Todos"
        ' 
        ' FormListaUsuarios
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        ClientSize = New Size(948, 685)
        Controls.Add(LFiltrar)
        Controls.Add(CBFiltro)
        Controls.Add(IPBBuscarUsuario)
        Controls.Add(TBBuscarUsuario)
        Controls.Add(PBClientes)
        Controls.Add(LListaClientes)
        Controls.Add(PListaEquipos)
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
