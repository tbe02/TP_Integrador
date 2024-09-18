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
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        PListaEquipos = New Panel()
        DGVListaEquipos = New DataGridView()
        C_Cliente = New DataGridViewTextBoxColumn()
        C_TipoEquipo = New DataGridViewTextBoxColumn()
        C_NroSerie = New DataGridViewTextBoxColumn()
        C_Marca = New DataGridViewTextBoxColumn()
        C_EquipoEnciende = New DataGridViewTextBoxColumn()
        C_InfomacionEquipo = New DataGridViewTextBoxColumn()
        C_Editar = New DataGridViewTextBoxColumn()
        C_Eliminar = New DataGridViewTextBoxColumn()
        BAgregarEquipo = New Button()
        LListaEquipos = New Label()
        PBDevices = New PictureBox()
        PListaEquipos.SuspendLayout()
        CType(DGVListaEquipos, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBDevices, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PListaEquipos
        ' 
        PListaEquipos.BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        PListaEquipos.Controls.Add(DGVListaEquipos)
        PListaEquipos.Location = New Point(12, 106)
        PListaEquipos.Name = "PListaEquipos"
        PListaEquipos.Size = New Size(1059, 795)
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
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(109), CByte(122), CByte(224))
        DataGridViewCellStyle4.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = Color.White
        DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(CByte(109), CByte(122), CByte(224))
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        DGVListaEquipos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        DGVListaEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVListaEquipos.Columns.AddRange(New DataGridViewColumn() {C_Cliente, C_TipoEquipo, C_NroSerie, C_Marca, C_EquipoEnciende, C_InfomacionEquipo, C_Editar, C_Eliminar})
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        DataGridViewCellStyle5.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = Color.White
        DataGridViewCellStyle5.SelectionBackColor = Color.MediumPurple
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        DGVListaEquipos.DefaultCellStyle = DataGridViewCellStyle5
        DGVListaEquipos.EnableHeadersVisualStyles = False
        DGVListaEquipos.GridColor = Color.FromArgb(CByte(109), CByte(122), CByte(224))
        DGVListaEquipos.Location = New Point(0, 0)
        DGVListaEquipos.Name = "DGVListaEquipos"
        DGVListaEquipos.ReadOnly = True
        DGVListaEquipos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DGVListaEquipos.RowHeadersVisible = False
        DGVListaEquipos.RowHeadersWidth = 51
        DataGridViewCellStyle6.ForeColor = Color.White
        DGVListaEquipos.RowsDefaultCellStyle = DataGridViewCellStyle6
        DGVListaEquipos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGVListaEquipos.Size = New Size(1050, 795)
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
        C_InfomacionEquipo.HeaderText = "Info. Equipo"
        C_InfomacionEquipo.MinimumWidth = 6
        C_InfomacionEquipo.Name = "C_InfomacionEquipo"
        C_InfomacionEquipo.ReadOnly = True
        C_InfomacionEquipo.Resizable = DataGridViewTriState.False
        ' 
        ' C_Editar
        ' 
        C_Editar.HeaderText = "Editar"
        C_Editar.MinimumWidth = 6
        C_Editar.Name = "C_Editar"
        C_Editar.ReadOnly = True
        C_Editar.Resizable = DataGridViewTriState.False
        ' 
        ' C_Eliminar
        ' 
        C_Eliminar.HeaderText = "Eliminar"
        C_Eliminar.MinimumWidth = 6
        C_Eliminar.Name = "C_Eliminar"
        C_Eliminar.ReadOnly = True
        C_Eliminar.Resizable = DataGridViewTriState.False
        ' 
        ' BAgregarEquipo
        ' 
        BAgregarEquipo.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BAgregarEquipo.FlatAppearance.BorderSize = 0
        BAgregarEquipo.FlatStyle = FlatStyle.Flat
        BAgregarEquipo.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BAgregarEquipo.ForeColor = Color.White
        BAgregarEquipo.Location = New Point(893, 30)
        BAgregarEquipo.Margin = New Padding(3, 4, 3, 4)
        BAgregarEquipo.Name = "BAgregarEquipo"
        BAgregarEquipo.Size = New Size(178, 39)
        BAgregarEquipo.TabIndex = 5
        BAgregarEquipo.Text = "Agregar equipo"
        BAgregarEquipo.UseVisualStyleBackColor = True
        ' 
        ' LListaEquipos
        ' 
        LListaEquipos.AutoSize = True
        LListaEquipos.BackColor = Color.Transparent
        LListaEquipos.Font = New Font("Bahnschrift Condensed", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LListaEquipos.ForeColor = Color.White
        LListaEquipos.Location = New Point(355, 9)
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
        ' FormListaEquipos
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        ClientSize = New Size(1083, 913)
        Controls.Add(PBDevices)
        Controls.Add(LListaEquipos)
        Controls.Add(BAgregarEquipo)
        Controls.Add(PListaEquipos)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormListaEquipos"
        Text = "FormListaEquipos"
        PListaEquipos.ResumeLayout(False)
        CType(DGVListaEquipos, ComponentModel.ISupportInitialize).EndInit()
        CType(PBDevices, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PListaEquipos As Panel
    Friend WithEvents DGVListaEquipos As DataGridView
    Friend WithEvents BAgregarEquipo As Button
    Friend WithEvents C_Cliente As DataGridViewTextBoxColumn
    Friend WithEvents C_TipoEquipo As DataGridViewTextBoxColumn
    Friend WithEvents C_NroSerie As DataGridViewTextBoxColumn
    Friend WithEvents C_Marca As DataGridViewTextBoxColumn
    Friend WithEvents C_EquipoEnciende As DataGridViewTextBoxColumn
    Friend WithEvents C_InfomacionEquipo As DataGridViewTextBoxColumn
    Friend WithEvents C_Editar As DataGridViewTextBoxColumn
    Friend WithEvents C_Eliminar As DataGridViewTextBoxColumn
    Friend WithEvents LListaEquipos As Label
    Friend WithEvents PBDevices As PictureBox
End Class
