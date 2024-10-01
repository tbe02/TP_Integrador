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
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        IPBBuscarCliente = New FontAwesome.Sharp.IconPictureBox()
        TBBuscarCliente = New TextBox()
        PBClientes = New PictureBox()
        LListaClientes = New Label()
        PListaEquipos = New Panel()
        DGVListaClientes = New DataGridView()
        C_Nombre = New DataGridViewTextBoxColumn()
        C_Usuario = New DataGridViewTextBoxColumn()
        C_TipoDeUsuario = New DataGridViewTextBoxColumn()
        C_Eliminar = New DataGridViewButtonColumn()
        CType(IPBBuscarCliente, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBClientes, ComponentModel.ISupportInitialize).BeginInit()
        PListaEquipos.SuspendLayout()
        CType(DGVListaClientes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' IPBBuscarCliente
        ' 
        IPBBuscarCliente.BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        IPBBuscarCliente.BackgroundImageLayout = ImageLayout.Stretch
        IPBBuscarCliente.IconChar = FontAwesome.Sharp.IconChar.Search
        IPBBuscarCliente.IconColor = Color.White
        IPBBuscarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto
        IPBBuscarCliente.IconSize = 23
        IPBBuscarCliente.Location = New Point(912, 69)
        IPBBuscarCliente.Name = "IPBBuscarCliente"
        IPBBuscarCliente.Size = New Size(24, 23)
        IPBBuscarCliente.TabIndex = 22
        IPBBuscarCliente.TabStop = False
        ' 
        ' TBBuscarCliente
        ' 
        TBBuscarCliente.BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        TBBuscarCliente.ForeColor = SystemColors.Window
        TBBuscarCliente.Location = New Point(798, 69)
        TBBuscarCliente.Multiline = True
        TBBuscarCliente.Name = "TBBuscarCliente"
        TBBuscarCliente.Size = New Size(108, 23)
        TBBuscarCliente.TabIndex = 21
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
        PListaEquipos.Controls.Add(DGVListaClientes)
        PListaEquipos.Location = New Point(11, 112)
        PListaEquipos.Margin = New Padding(3, 2, 3, 2)
        PListaEquipos.Name = "PListaEquipos"
        PListaEquipos.Size = New Size(927, 566)
        PListaEquipos.TabIndex = 18
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
        DGVListaClientes.Columns.AddRange(New DataGridViewColumn() {C_Nombre, C_Usuario, C_TipoDeUsuario, C_Eliminar})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        DataGridViewCellStyle3.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.White
        DataGridViewCellStyle3.SelectionBackColor = Color.MediumPurple
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DGVListaClientes.DefaultCellStyle = DataGridViewCellStyle3
        DGVListaClientes.EnableHeadersVisualStyles = False
        DGVListaClientes.GridColor = Color.FromArgb(CByte(109), CByte(122), CByte(224))
        DGVListaClientes.Location = New Point(0, 0)
        DGVListaClientes.Margin = New Padding(3, 2, 3, 2)
        DGVListaClientes.Name = "DGVListaClientes"
        DGVListaClientes.ReadOnly = True
        DGVListaClientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DGVListaClientes.RowHeadersVisible = False
        DGVListaClientes.RowHeadersWidth = 51
        DataGridViewCellStyle4.ForeColor = Color.White
        DGVListaClientes.RowsDefaultCellStyle = DataGridViewCellStyle4
        DGVListaClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGVListaClientes.Size = New Size(922, 563)
        DGVListaClientes.TabIndex = 0
        ' 
        ' C_Nombre
        ' 
        C_Nombre.HeaderText = "Nombre"
        C_Nombre.MinimumWidth = 6
        C_Nombre.Name = "C_Nombre"
        C_Nombre.ReadOnly = True
        C_Nombre.Resizable = DataGridViewTriState.False
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
        ' C_Eliminar
        ' 
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.SkyBlue
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.SkyBlue
        C_Eliminar.DefaultCellStyle = DataGridViewCellStyle2
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
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        ClientSize = New Size(948, 685)
        Controls.Add(IPBBuscarCliente)
        Controls.Add(TBBuscarCliente)
        Controls.Add(PBClientes)
        Controls.Add(LListaClientes)
        Controls.Add(PListaEquipos)
        Name = "Form1"
        Text = "Form1"
        CType(IPBBuscarCliente, ComponentModel.ISupportInitialize).EndInit()
        CType(PBClientes, ComponentModel.ISupportInitialize).EndInit()
        PListaEquipos.ResumeLayout(False)
        CType(DGVListaClientes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents IPBBuscarCliente As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents TBBuscarCliente As TextBox
    Friend WithEvents PBClientes As PictureBox
    Friend WithEvents LListaClientes As Label
    Friend WithEvents PListaEquipos As Panel
    Friend WithEvents DGVListaClientes As DataGridView
    Friend WithEvents C_Nombre As DataGridViewTextBoxColumn
    Friend WithEvents C_Usuario As DataGridViewTextBoxColumn
    Friend WithEvents C_TipoDeUsuario As DataGridViewTextBoxColumn
    Friend WithEvents C_Eliminar As DataGridViewButtonColumn
End Class
