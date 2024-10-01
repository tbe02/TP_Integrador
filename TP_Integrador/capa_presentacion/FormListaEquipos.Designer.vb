<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormListaEquipos
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
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        PListaEquipos = New Panel()
        DGVListaEquipos = New DataGridView()
        C_Cliente = New DataGridViewTextBoxColumn()
        C_TipoEquipo = New DataGridViewTextBoxColumn()
        C_NroSerie = New DataGridViewTextBoxColumn()
        C_Marca = New DataGridViewTextBoxColumn()
        C_EquipoEnciende = New DataGridViewTextBoxColumn()
        C_InfomacionEquipo = New DataGridViewButtonColumn()
        C_EstadoEquipo = New DataGridViewButtonColumn()
        C_Editar = New DataGridViewButtonColumn()
        C_Eliminar = New DataGridViewButtonColumn()
        LListaEquipos = New Label()
        PBDevices = New PictureBox()
        TBBuscarEquipo = New TextBox()
        IPBBuscarEquipo = New FontAwesome.Sharp.IconPictureBox()
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
        PListaEquipos.Location = New Point(10, 110)
        PListaEquipos.Margin = New Padding(3, 2, 3, 2)
        PListaEquipos.Name = "PListaEquipos"
        PListaEquipos.Size = New Size(927, 566)
        PListaEquipos.TabIndex = 0
        ' 
        ' DGVListaEquipos
        ' 
        DGVListaEquipos.AllowUserToResizeColumns = False
        DGVListaEquipos.AllowUserToResizeRows = False
        DGVListaEquipos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGVListaEquipos.BackgroundColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        DGVListaEquipos.BorderStyle = BorderStyle.None
        DGVListaEquipos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(109), CByte(122), CByte(224))
        DataGridViewCellStyle1.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(109), CByte(122), CByte(224))
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DGVListaEquipos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DGVListaEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVListaEquipos.Columns.AddRange(New DataGridViewColumn() {C_Cliente, C_TipoEquipo, C_NroSerie, C_Marca, C_EquipoEnciende, C_InfomacionEquipo, C_EstadoEquipo, C_Editar, C_Eliminar})
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        DataGridViewCellStyle6.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle6.ForeColor = Color.White
        DataGridViewCellStyle6.SelectionBackColor = Color.MediumPurple
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        DGVListaEquipos.DefaultCellStyle = DataGridViewCellStyle6
        DGVListaEquipos.EnableHeadersVisualStyles = False
        DGVListaEquipos.GridColor = Color.FromArgb(CByte(109), CByte(122), CByte(224))
        DGVListaEquipos.Location = New Point(0, 0)
        DGVListaEquipos.Margin = New Padding(3, 2, 3, 2)
        DGVListaEquipos.Name = "DGVListaEquipos"
        DGVListaEquipos.ReadOnly = True
        DGVListaEquipos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DGVListaEquipos.RowHeadersVisible = False
        DGVListaEquipos.RowHeadersWidth = 51
        DataGridViewCellStyle7.ForeColor = Color.White
        DGVListaEquipos.RowsDefaultCellStyle = DataGridViewCellStyle7
        DGVListaEquipos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGVListaEquipos.Size = New Size(921, 563)
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
        ' C_EquipoEnciende
        ' 
        C_EquipoEnciende.HeaderText = "Enciende"
        C_EquipoEnciende.MinimumWidth = 6
        C_EquipoEnciende.Name = "C_EquipoEnciende"
        C_EquipoEnciende.ReadOnly = True
        C_EquipoEnciende.Resizable = DataGridViewTriState.False
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
        ' C_EstadoEquipo
        ' 
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = Color.SkyBlue
        DataGridViewCellStyle3.ForeColor = Color.White
        DataGridViewCellStyle3.SelectionBackColor = Color.SkyBlue
        C_EstadoEquipo.DefaultCellStyle = DataGridViewCellStyle3
        C_EstadoEquipo.FlatStyle = FlatStyle.Popup
        C_EstadoEquipo.HeaderText = "Estado equipo"
        C_EstadoEquipo.MinimumWidth = 6
        C_EstadoEquipo.Name = "C_EstadoEquipo"
        C_EstadoEquipo.ReadOnly = True
        C_EstadoEquipo.Resizable = DataGridViewTriState.True
        C_EstadoEquipo.SortMode = DataGridViewColumnSortMode.Automatic
        C_EstadoEquipo.Text = "Estado"
        C_EstadoEquipo.UseColumnTextForButtonValue = True
        ' 
        ' C_Editar
        ' 
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = Color.SkyBlue
        DataGridViewCellStyle4.ForeColor = Color.White
        DataGridViewCellStyle4.SelectionBackColor = Color.SkyBlue
        C_Editar.DefaultCellStyle = DataGridViewCellStyle4
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
        ' C_Eliminar
        ' 
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = Color.SkyBlue
        DataGridViewCellStyle5.ForeColor = Color.White
        DataGridViewCellStyle5.SelectionBackColor = Color.SkyBlue
        C_Eliminar.DefaultCellStyle = DataGridViewCellStyle5
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
        ' LListaEquipos
        ' 
        LListaEquipos.AutoSize = True
        LListaEquipos.BackColor = Color.Transparent
        LListaEquipos.Font = New Font("Bahnschrift Condensed", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LListaEquipos.ForeColor = Color.White
        LListaEquipos.Location = New Point(306, 7)
        LListaEquipos.Name = "LListaEquipos"
        LListaEquipos.Size = New Size(282, 58)
        LListaEquipos.TabIndex = 12
        LListaEquipos.Text = "Lista de Equipos"
        ' 
        ' PBDevices
        ' 
        PBDevices.Image = My.Resources.Resources.devices2
        PBDevices.Location = New Point(225, 2)
        PBDevices.Margin = New Padding(3, 2, 3, 2)
        PBDevices.Name = "PBDevices"
        PBDevices.Size = New Size(91, 73)
        PBDevices.TabIndex = 13
        PBDevices.TabStop = False
        ' 
        ' TBBuscarEquipo
        ' 
        TBBuscarEquipo.BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        TBBuscarEquipo.ForeColor = SystemColors.Window
        TBBuscarEquipo.Location = New Point(799, 72)
        TBBuscarEquipo.Multiline = True
        TBBuscarEquipo.Name = "TBBuscarEquipo"
        TBBuscarEquipo.Size = New Size(108, 23)
        TBBuscarEquipo.TabIndex = 14
        ' 
        ' IPBBuscarEquipo
        ' 
        IPBBuscarEquipo.BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        IPBBuscarEquipo.BackgroundImageLayout = ImageLayout.Stretch
        IPBBuscarEquipo.IconChar = FontAwesome.Sharp.IconChar.Search
        IPBBuscarEquipo.IconColor = Color.White
        IPBBuscarEquipo.IconFont = FontAwesome.Sharp.IconFont.Auto
        IPBBuscarEquipo.IconSize = 23
        IPBBuscarEquipo.Location = New Point(913, 72)
        IPBBuscarEquipo.Name = "IPBBuscarEquipo"
        IPBBuscarEquipo.Size = New Size(24, 23)
        IPBBuscarEquipo.TabIndex = 15
        IPBBuscarEquipo.TabStop = False
        ' 
        ' FormListaEquipos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        ClientSize = New Size(948, 685)
        Controls.Add(IPBBuscarEquipo)
        Controls.Add(TBBuscarEquipo)
        Controls.Add(PBDevices)
        Controls.Add(LListaEquipos)
        Controls.Add(PListaEquipos)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "FormListaEquipos"
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
    Friend WithEvents C_Cliente As DataGridViewTextBoxColumn
    Friend WithEvents C_TipoEquipo As DataGridViewTextBoxColumn
    Friend WithEvents C_NroSerie As DataGridViewTextBoxColumn
    Friend WithEvents C_Marca As DataGridViewTextBoxColumn
    Friend WithEvents C_EquipoEnciende As DataGridViewTextBoxColumn
    Friend WithEvents C_InfomacionEquipo As DataGridViewButtonColumn
    Friend WithEvents C_EstadoEquipo As DataGridViewButtonColumn
    Friend WithEvents C_Editar As DataGridViewButtonColumn
    Friend WithEvents C_Eliminar As DataGridViewButtonColumn
    Friend WithEvents TBBuscarEquipo As TextBox
    Friend WithEvents IPBBuscarEquipo As FontAwesome.Sharp.IconPictureBox
End Class
