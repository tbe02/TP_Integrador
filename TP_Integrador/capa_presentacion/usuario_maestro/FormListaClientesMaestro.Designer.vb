<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormListaClientesMaestro
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
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        PListaEquipos = New Panel()
        DGVListaClientes = New DataGridView()
        C_Apellido = New DataGridViewTextBoxColumn()
        C_Nombre = New DataGridViewTextBoxColumn()
        C_DNI = New DataGridViewTextBoxColumn()
        C_Correo = New DataGridViewTextBoxColumn()
        C_Telefono = New DataGridViewTextBoxColumn()
        C_Estado = New DataGridViewTextBoxColumn()
        LListaClientes = New Label()
        PBClientes = New PictureBox()
        IPBBuscarCliente = New FontAwesome.Sharp.IconPictureBox()
        TBBuscarCliente = New TextBox()
        LFiltrar = New Label()
        CBFiltro = New ComboBox()
        PListaEquipos.SuspendLayout()
        CType(DGVListaClientes, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBClientes, ComponentModel.ISupportInitialize).BeginInit()
        CType(IPBBuscarCliente, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PListaEquipos
        ' 
        PListaEquipos.BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        PListaEquipos.Controls.Add(DGVListaClientes)
        PListaEquipos.Location = New Point(10, 110)
        PListaEquipos.Margin = New Padding(3, 2, 3, 2)
        PListaEquipos.Name = "PListaEquipos"
        PListaEquipos.Size = New Size(927, 566)
        PListaEquipos.TabIndex = 0
        ' 
        ' DGVListaClientes
        ' 
        DGVListaClientes.AllowUserToResizeColumns = False
        DGVListaClientes.AllowUserToResizeRows = False
        DGVListaClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGVListaClientes.BackgroundColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        DGVListaClientes.BorderStyle = BorderStyle.None
        DGVListaClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(109), CByte(122), CByte(224))
        DataGridViewCellStyle1.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(109), CByte(122), CByte(224))
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DGVListaClientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DGVListaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVListaClientes.Columns.AddRange(New DataGridViewColumn() {C_Apellido, C_Nombre, C_DNI, C_Correo, C_Telefono, C_Estado})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.MediumPurple
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DGVListaClientes.DefaultCellStyle = DataGridViewCellStyle2
        DGVListaClientes.EnableHeadersVisualStyles = False
        DGVListaClientes.GridColor = Color.FromArgb(CByte(109), CByte(122), CByte(224))
        DGVListaClientes.Location = New Point(0, 0)
        DGVListaClientes.Margin = New Padding(3, 2, 3, 2)
        DGVListaClientes.Name = "DGVListaClientes"
        DGVListaClientes.ReadOnly = True
        DGVListaClientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DGVListaClientes.RowHeadersVisible = False
        DGVListaClientes.RowHeadersWidth = 51
        DataGridViewCellStyle3.ForeColor = Color.White
        DGVListaClientes.RowsDefaultCellStyle = DataGridViewCellStyle3
        DGVListaClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGVListaClientes.Size = New Size(922, 563)
        DGVListaClientes.TabIndex = 0
        ' 
        ' C_Apellido
        ' 
        C_Apellido.HeaderText = "Apellido/s"
        C_Apellido.MinimumWidth = 6
        C_Apellido.Name = "C_Apellido"
        C_Apellido.ReadOnly = True
        C_Apellido.Resizable = DataGridViewTriState.False
        ' 
        ' C_Nombre
        ' 
        C_Nombre.HeaderText = "Nombre/s"
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
        C_DNI.Resizable = DataGridViewTriState.False
        ' 
        ' C_Correo
        ' 
        C_Correo.HeaderText = "Correo"
        C_Correo.MinimumWidth = 6
        C_Correo.Name = "C_Correo"
        C_Correo.ReadOnly = True
        C_Correo.Resizable = DataGridViewTriState.False
        ' 
        ' C_Telefono
        ' 
        C_Telefono.HeaderText = "Telefono"
        C_Telefono.MinimumWidth = 6
        C_Telefono.Name = "C_Telefono"
        C_Telefono.ReadOnly = True
        C_Telefono.Resizable = DataGridViewTriState.False
        ' 
        ' C_Estado
        ' 
        C_Estado.HeaderText = "Estado"
        C_Estado.Name = "C_Estado"
        C_Estado.ReadOnly = True
        C_Estado.Resizable = DataGridViewTriState.False
        ' 
        ' LListaClientes
        ' 
        LListaClientes.AutoSize = True
        LListaClientes.BackColor = Color.Transparent
        LListaClientes.Font = New Font("Bahnschrift Condensed", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LListaClientes.ForeColor = Color.White
        LListaClientes.Location = New Point(306, 7)
        LListaClientes.Name = "LListaClientes"
        LListaClientes.Size = New Size(290, 58)
        LListaClientes.TabIndex = 12
        LListaClientes.Text = "Lista de Clientes"
        ' 
        ' PBClientes
        ' 
        PBClientes.Image = My.Resources.Resources.people
        PBClientes.Location = New Point(225, 2)
        PBClientes.Margin = New Padding(3, 2, 3, 2)
        PBClientes.Name = "PBClientes"
        PBClientes.Size = New Size(91, 73)
        PBClientes.TabIndex = 13
        PBClientes.TabStop = False
        ' 
        ' IPBBuscarCliente
        ' 
        IPBBuscarCliente.BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        IPBBuscarCliente.BackgroundImageLayout = ImageLayout.Stretch
        IPBBuscarCliente.Cursor = Cursors.Hand
        IPBBuscarCliente.IconChar = FontAwesome.Sharp.IconChar.Search
        IPBBuscarCliente.IconColor = Color.White
        IPBBuscarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto
        IPBBuscarCliente.IconSize = 23
        IPBBuscarCliente.Location = New Point(911, 67)
        IPBBuscarCliente.Name = "IPBBuscarCliente"
        IPBBuscarCliente.Size = New Size(24, 23)
        IPBBuscarCliente.TabIndex = 17
        IPBBuscarCliente.TabStop = False
        ' 
        ' TBBuscarCliente
        ' 
        TBBuscarCliente.BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        TBBuscarCliente.ForeColor = SystemColors.Window
        TBBuscarCliente.Location = New Point(797, 67)
        TBBuscarCliente.Multiline = True
        TBBuscarCliente.Name = "TBBuscarCliente"
        TBBuscarCliente.Size = New Size(108, 23)
        TBBuscarCliente.TabIndex = 16
        ' 
        ' LFiltrar
        ' 
        LFiltrar.AutoSize = True
        LFiltrar.Font = New Font("Segoe UI", 10F)
        LFiltrar.ForeColor = Color.White
        LFiltrar.Location = New Point(592, 68)
        LFiltrar.Name = "LFiltrar"
        LFiltrar.Size = New Size(72, 19)
        LFiltrar.TabIndex = 21
        LFiltrar.Text = "Filtrar por:"
        ' 
        ' CBFiltro
        ' 
        CBFiltro.FormattingEnabled = True
        CBFiltro.Location = New Point(670, 67)
        CBFiltro.Name = "CBFiltro"
        CBFiltro.Size = New Size(121, 23)
        CBFiltro.TabIndex = 20
        CBFiltro.Text = "Todos"
        ' 
        ' FormListaClientesMaestro
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        ClientSize = New Size(948, 685)
        Controls.Add(LFiltrar)
        Controls.Add(CBFiltro)
        Controls.Add(IPBBuscarCliente)
        Controls.Add(TBBuscarCliente)
        Controls.Add(PBClientes)
        Controls.Add(LListaClientes)
        Controls.Add(PListaEquipos)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(3, 2, 3, 2)
        Name = "FormListaClientesMaestro"
        Text = "FormListaEquipos"
        PListaEquipos.ResumeLayout(False)
        CType(DGVListaClientes, ComponentModel.ISupportInitialize).EndInit()
        CType(PBClientes, ComponentModel.ISupportInitialize).EndInit()
        CType(IPBBuscarCliente, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PListaEquipos As Panel
    Friend WithEvents DGVListaClientes As DataGridView
    Friend WithEvents LListaClientes As Label
    Friend WithEvents PBClientes As PictureBox
    Friend WithEvents IPBBuscarCliente As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents TBBuscarCliente As TextBox
    Friend WithEvents C_Apellido As DataGridViewTextBoxColumn
    Friend WithEvents C_Nombre As DataGridViewTextBoxColumn
    Friend WithEvents C_DNI As DataGridViewTextBoxColumn
    Friend WithEvents C_Correo As DataGridViewTextBoxColumn
    Friend WithEvents C_Telefono As DataGridViewTextBoxColumn
    Friend WithEvents C_Estado As DataGridViewTextBoxColumn
    Friend WithEvents LFiltrar As Label
    Friend WithEvents CBFiltro As ComboBox
End Class
