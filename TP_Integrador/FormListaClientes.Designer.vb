﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormListaClientes
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
        LListaClientes = New Label()
        PBClientes = New PictureBox()
        C_Apellido = New DataGridViewTextBoxColumn()
        C_Nombre = New DataGridViewTextBoxColumn()
        C_DNI = New DataGridViewTextBoxColumn()
        C_Correo = New DataGridViewTextBoxColumn()
        C_Telefono = New DataGridViewTextBoxColumn()
        C_Editar = New DataGridViewButtonColumn()
        C_Eliminar = New DataGridViewButtonColumn()
        PListaEquipos.SuspendLayout()
        CType(DGVListaEquipos, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBClientes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PListaEquipos
        ' 
        PListaEquipos.BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        PListaEquipos.Controls.Add(DGVListaEquipos)
        PListaEquipos.Location = New Point(12, 147)
        PListaEquipos.Name = "PListaEquipos"
        PListaEquipos.Size = New Size(1059, 754)
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
        DGVListaEquipos.Columns.AddRange(New DataGridViewColumn() {C_Apellido, C_Nombre, C_DNI, C_Correo, C_Telefono, C_Editar, C_Eliminar})
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        DataGridViewCellStyle4.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
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
        DGVListaEquipos.Size = New Size(1054, 751)
        DGVListaEquipos.TabIndex = 0
        ' 
        ' LListaClientes
        ' 
        LListaClientes.AutoSize = True
        LListaClientes.BackColor = Color.Transparent
        LListaClientes.Font = New Font("Bahnschrift Condensed", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LListaClientes.ForeColor = Color.White
        LListaClientes.Location = New Point(350, 9)
        LListaClientes.Name = "LListaClientes"
        LListaClientes.Size = New Size(357, 72)
        LListaClientes.TabIndex = 12
        LListaClientes.Text = "Lista de Clientes"
        ' 
        ' PBClientes
        ' 
        PBClientes.Image = My.Resources.Resources.people
        PBClientes.Location = New Point(257, 3)
        PBClientes.Name = "PBClientes"
        PBClientes.Size = New Size(104, 97)
        PBClientes.TabIndex = 13
        PBClientes.TabStop = False
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
        ' C_Editar
        ' 
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.SkyBlue
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.Transparent
        C_Editar.DefaultCellStyle = DataGridViewCellStyle2
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
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = Color.SkyBlue
        DataGridViewCellStyle3.ForeColor = Color.White
        DataGridViewCellStyle3.SelectionBackColor = Color.Transparent
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
        ' FormListaClientes
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        ClientSize = New Size(1083, 913)
        Controls.Add(PBClientes)
        Controls.Add(LListaClientes)
        Controls.Add(PListaEquipos)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormListaClientes"
        Text = "FormListaEquipos"
        PListaEquipos.ResumeLayout(False)
        CType(DGVListaEquipos, ComponentModel.ISupportInitialize).EndInit()
        CType(PBClientes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PListaEquipos As Panel
    Friend WithEvents DGVListaEquipos As DataGridView
    Friend WithEvents LListaClientes As Label
    Friend WithEvents PBClientes As PictureBox
    Friend WithEvents C_Apellido As DataGridViewTextBoxColumn
    Friend WithEvents C_Nombre As DataGridViewTextBoxColumn
    Friend WithEvents C_DNI As DataGridViewTextBoxColumn
    Friend WithEvents C_Correo As DataGridViewTextBoxColumn
    Friend WithEvents C_Telefono As DataGridViewTextBoxColumn
    Friend WithEvents C_Editar As DataGridViewButtonColumn
    Friend WithEvents C_Eliminar As DataGridViewButtonColumn
End Class
