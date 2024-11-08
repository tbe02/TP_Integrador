<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormListaEquiposTecnico
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        PListaEquipos = New Panel()
        DGVListaEquipos = New DataGridView()
        C_Cliente = New DataGridViewTextBoxColumn()
        C_DNI = New DataGridViewTextBoxColumn()
        C_TipoEquipo = New DataGridViewTextBoxColumn()
        C_NroSerie = New DataGridViewTextBoxColumn()
        C_Marca = New DataGridViewTextBoxColumn()
        C_Modelo = New DataGridViewTextBoxColumn()
        C_EquipoEnciende = New DataGridViewTextBoxColumn()
        C_EstadoEquipo = New DataGridViewTextBoxColumn()
        C_Baja = New DataGridViewTextBoxColumn()
        C_InfomacionEquipo = New DataGridViewButtonColumn()
        C_Editar = New DataGridViewButtonColumn()
        LListaEquipos = New Label()
        PBDevices = New PictureBox()
        TBBuscarEquipo = New TextBox()
        IPBBuscarEquipo = New FontAwesome.Sharp.IconPictureBox()
        LFiltrar = New Label()
        CBFiltro = New ComboBox()
        PListaEquipos.SuspendLayout()
        CType(DGVListaEquipos, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBDevices, ComponentModel.ISupportInitialize).BeginInit()
        CType(IPBBuscarEquipo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PListaEquipos
        ' 
        PListaEquipos.BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        PListaEquipos.Controls.Add(DGVListaEquipos)
        PListaEquipos.Location = New Point(11, 147)
        PListaEquipos.Name = "PListaEquipos"
        PListaEquipos.Size = New Size(1059, 755)
        PListaEquipos.TabIndex = 0
        ' 
        ' DGVListaEquipos
        ' 
        DGVListaEquipos.AllowUserToResizeColumns = False
        DGVListaEquipos.AllowUserToResizeRows = False
        DGVListaEquipos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGVListaEquipos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DGVListaEquipos.BackgroundColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        DGVListaEquipos.BorderStyle = BorderStyle.None
        DGVListaEquipos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(109), CByte(122), CByte(224))
        DataGridViewCellStyle1.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(109), CByte(122), CByte(224))
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DGVListaEquipos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DGVListaEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVListaEquipos.Columns.AddRange(New DataGridViewColumn() {C_Cliente, C_DNI, C_TipoEquipo, C_NroSerie, C_Marca, C_Modelo, C_EquipoEnciende, C_EstadoEquipo, C_Baja, C_InfomacionEquipo, C_Editar})
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        DataGridViewCellStyle4.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = Color.White
        DataGridViewCellStyle4.SelectionBackColor = Color.MediumPurple
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.False
        DGVListaEquipos.DefaultCellStyle = DataGridViewCellStyle4
        DGVListaEquipos.EnableHeadersVisualStyles = False
        DGVListaEquipos.GridColor = Color.FromArgb(CByte(109), CByte(122), CByte(224))
        DGVListaEquipos.Location = New Point(0, 0)
        DGVListaEquipos.Name = "DGVListaEquipos"
        DGVListaEquipos.ReadOnly = True
        DGVListaEquipos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DGVListaEquipos.RowHeadersVisible = False
        DGVListaEquipos.RowHeadersWidth = 51
        DataGridViewCellStyle5.ForeColor = Color.White
        DGVListaEquipos.RowsDefaultCellStyle = DataGridViewCellStyle5
        DGVListaEquipos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGVListaEquipos.Size = New Size(1053, 751)
        DGVListaEquipos.TabIndex = 0
        ' 
        ' C_Cliente
        ' 
        C_Cliente.HeaderText = "Cliente"
        C_Cliente.MinimumWidth = 6
        C_Cliente.Name = "C_Cliente"
        C_Cliente.ReadOnly = True
        C_Cliente.Resizable = DataGridViewTriState.False
        ' 
        ' C_DNI
        ' 
        C_DNI.HeaderText = "DNI"
        C_DNI.MinimumWidth = 6
        C_DNI.Name = "C_DNI"
        C_DNI.ReadOnly = True
        ' 
        ' C_TipoEquipo
        ' 
        C_TipoEquipo.HeaderText = "Tipo de Equipo"
        C_TipoEquipo.MinimumWidth = 6
        C_TipoEquipo.Name = "C_TipoEquipo"
        C_TipoEquipo.ReadOnly = True
        C_TipoEquipo.Resizable = DataGridViewTriState.False
        ' 
        ' C_NroSerie
        ' 
        C_NroSerie.HeaderText = "Nro. Serie"
        C_NroSerie.MinimumWidth = 6
        C_NroSerie.Name = "C_NroSerie"
        C_NroSerie.ReadOnly = True
        C_NroSerie.Resizable = DataGridViewTriState.False
        ' 
        ' C_Marca
        ' 
        C_Marca.HeaderText = "Marca"
        C_Marca.MinimumWidth = 6
        C_Marca.Name = "C_Marca"
        C_Marca.ReadOnly = True
        C_Marca.Resizable = DataGridViewTriState.False
        ' 
        ' C_Modelo
        ' 
        C_Modelo.HeaderText = "Modelo"
        C_Modelo.MinimumWidth = 6
        C_Modelo.Name = "C_Modelo"
        C_Modelo.ReadOnly = True
        ' 
        ' C_EquipoEnciende
        ' 
        C_EquipoEnciende.HeaderText = "Enciende"
        C_EquipoEnciende.MinimumWidth = 6
        C_EquipoEnciende.Name = "C_EquipoEnciende"
        C_EquipoEnciende.ReadOnly = True
        C_EquipoEnciende.Resizable = DataGridViewTriState.False
        ' 
        ' C_EstadoEquipo
        ' 
        C_EstadoEquipo.HeaderText = "Estado equipo"
        C_EstadoEquipo.MinimumWidth = 6
        C_EstadoEquipo.Name = "C_EstadoEquipo"
        C_EstadoEquipo.ReadOnly = True
        ' 
        ' C_Baja
        ' 
        C_Baja.HeaderText = "Baja"
        C_Baja.MinimumWidth = 6
        C_Baja.Name = "C_Baja"
        C_Baja.ReadOnly = True
        ' 
        ' C_InfomacionEquipo
        ' 
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.SkyBlue
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.SkyBlue
        C_InfomacionEquipo.DefaultCellStyle = DataGridViewCellStyle2
        C_InfomacionEquipo.FlatStyle = FlatStyle.Popup
        C_InfomacionEquipo.HeaderText = "Info. Equipo"
        C_InfomacionEquipo.MinimumWidth = 6
        C_InfomacionEquipo.Name = "C_InfomacionEquipo"
        C_InfomacionEquipo.ReadOnly = True
        C_InfomacionEquipo.Resizable = DataGridViewTriState.False
        C_InfomacionEquipo.SortMode = DataGridViewColumnSortMode.Automatic
        C_InfomacionEquipo.Text = "Info. Equipo"
        C_InfomacionEquipo.UseColumnTextForButtonValue = True
        ' 
        ' C_Editar
        ' 
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = Color.SkyBlue
        DataGridViewCellStyle3.ForeColor = Color.White
        DataGridViewCellStyle3.SelectionBackColor = Color.SkyBlue
        C_Editar.DefaultCellStyle = DataGridViewCellStyle3
        C_Editar.FlatStyle = FlatStyle.Popup
        C_Editar.HeaderText = "Editar"
        C_Editar.MinimumWidth = 6
        C_Editar.Name = "C_Editar"
        C_Editar.ReadOnly = True
        C_Editar.Resizable = DataGridViewTriState.False
        C_Editar.SortMode = DataGridViewColumnSortMode.Automatic
        C_Editar.Text = "Editar"
        C_Editar.UseColumnTextForButtonValue = True
        ' 
        ' LListaEquipos
        ' 
        LListaEquipos.AutoSize = True
        LListaEquipos.BackColor = Color.Transparent
        LListaEquipos.Font = New Font("Bahnschrift Condensed", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LListaEquipos.ForeColor = Color.White
        LListaEquipos.Location = New Point(350, 9)
        LListaEquipos.Name = "LListaEquipos"
        LListaEquipos.Size = New Size(349, 72)
        LListaEquipos.TabIndex = 12
        LListaEquipos.Text = "Lista de Equipos"
        ' 
        ' PBDevices
        ' 
        PBDevices.Image = My.Resources.Resources.devices2
        PBDevices.Location = New Point(257, 3)
        PBDevices.Name = "PBDevices"
        PBDevices.Size = New Size(104, 97)
        PBDevices.TabIndex = 13
        PBDevices.TabStop = False
        ' 
        ' TBBuscarEquipo
        ' 
        TBBuscarEquipo.BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        TBBuscarEquipo.ForeColor = SystemColors.Window
        TBBuscarEquipo.Location = New Point(913, 96)
        TBBuscarEquipo.Margin = New Padding(3, 4, 3, 4)
        TBBuscarEquipo.Multiline = True
        TBBuscarEquipo.Name = "TBBuscarEquipo"
        TBBuscarEquipo.Size = New Size(123, 29)
        TBBuscarEquipo.TabIndex = 14
        ' 
        ' IPBBuscarEquipo
        ' 
        IPBBuscarEquipo.BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        IPBBuscarEquipo.BackgroundImageLayout = ImageLayout.Stretch
        IPBBuscarEquipo.IconChar = FontAwesome.Sharp.IconChar.Search
        IPBBuscarEquipo.IconColor = Color.White
        IPBBuscarEquipo.IconFont = FontAwesome.Sharp.IconFont.Auto
        IPBBuscarEquipo.IconSize = 27
        IPBBuscarEquipo.Location = New Point(1043, 96)
        IPBBuscarEquipo.Margin = New Padding(3, 4, 3, 4)
        IPBBuscarEquipo.Name = "IPBBuscarEquipo"
        IPBBuscarEquipo.Size = New Size(27, 31)
        IPBBuscarEquipo.TabIndex = 15
        IPBBuscarEquipo.TabStop = False
        ' 
        ' LFiltrar
        ' 
        LFiltrar.AutoSize = True
        LFiltrar.Font = New Font("Segoe UI", 10F)
        LFiltrar.ForeColor = Color.White
        LFiltrar.Location = New Point(679, 97)
        LFiltrar.Name = "LFiltrar"
        LFiltrar.Size = New Size(88, 23)
        LFiltrar.TabIndex = 21
        LFiltrar.Text = "Filtrar por:"
        ' 
        ' CBFiltro
        ' 
        CBFiltro.FormattingEnabled = True
        CBFiltro.Location = New Point(768, 96)
        CBFiltro.Margin = New Padding(3, 4, 3, 4)
        CBFiltro.Name = "CBFiltro"
        CBFiltro.Size = New Size(138, 28)
        CBFiltro.TabIndex = 20
        CBFiltro.Text = "Todos"
        ' 
        ' FormListaEquiposTecnico
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        ClientSize = New Size(1083, 913)
        Controls.Add(LFiltrar)
        Controls.Add(CBFiltro)
        Controls.Add(IPBBuscarEquipo)
        Controls.Add(TBBuscarEquipo)
        Controls.Add(PBDevices)
        Controls.Add(LListaEquipos)
        Controls.Add(PListaEquipos)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormListaEquiposTecnico"
        Text = "FormListaEquipos"
        PListaEquipos.ResumeLayout(False)
        CType(DGVListaEquipos, ComponentModel.ISupportInitialize).EndInit()
        CType(PBDevices, ComponentModel.ISupportInitialize).EndInit()
        CType(IPBBuscarEquipo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PListaEquipos As Panel
    Friend WithEvents LListaEquipos As Label
    Friend WithEvents PBDevices As PictureBox
    Friend WithEvents DGVListaEquipos As DataGridView
    Friend WithEvents TBBuscarEquipo As TextBox
    Friend WithEvents IPBBuscarEquipo As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents LFiltrar As Label
    Friend WithEvents CBFiltro As ComboBox
    Friend WithEvents C_Cliente As DataGridViewTextBoxColumn
    Friend WithEvents C_DNI As DataGridViewTextBoxColumn
    Friend WithEvents C_TipoEquipo As DataGridViewTextBoxColumn
    Friend WithEvents C_NroSerie As DataGridViewTextBoxColumn
    Friend WithEvents C_Marca As DataGridViewTextBoxColumn
    Friend WithEvents C_Modelo As DataGridViewTextBoxColumn
    Friend WithEvents C_EquipoEnciende As DataGridViewTextBoxColumn
    Friend WithEvents C_EstadoEquipo As DataGridViewTextBoxColumn
    Friend WithEvents C_Baja As DataGridViewTextBoxColumn
    Friend WithEvents C_InfomacionEquipo As DataGridViewButtonColumn
    Friend WithEvents C_Editar As DataGridViewButtonColumn
End Class
