<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEditarEquipo
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
        PAsociarCliente = New Panel()
        ComboBAsociarCliente = New ComboBox()
        PBAsociarCliente = New PictureBox()
        LEditarCliente = New Label()
        PAgregarEquipo = New Panel()
        ComboBModelo = New ComboBox()
        ComboBMarca = New ComboBox()
        BEditarEquipo = New Button()
        TBObservaciones = New TextBox()
        TBRazonIngreso = New TextBox()
        TBNroSerie = New TextBox()
        LObservaciones = New Label()
        LRazonIngreso = New Label()
        LModelo = New Label()
        LMarca = New Label()
        LNroSerie = New Label()
        CBEquipoEnciende = New CheckBox()
        ComboBTipoEquipo = New ComboBox()
        LTipoEquipo = New Label()
        PictureBox2 = New PictureBox()
        LEditarEquipo = New Label()
        IBMinimizar_EC = New FontAwesome.Sharp.IconButton()
        IBCerrar_EC = New FontAwesome.Sharp.IconButton()
        BEstadoEquipo = New Button()
        PAsociarCliente.SuspendLayout()
        CType(PBAsociarCliente, ComponentModel.ISupportInitialize).BeginInit()
        PAgregarEquipo.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PAsociarCliente
        ' 
        PAsociarCliente.BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        PAsociarCliente.Controls.Add(ComboBAsociarCliente)
        PAsociarCliente.Controls.Add(PBAsociarCliente)
        PAsociarCliente.Controls.Add(LEditarCliente)
        PAsociarCliente.Location = New Point(34, 49)
        PAsociarCliente.Margin = New Padding(3, 4, 3, 4)
        PAsociarCliente.Name = "PAsociarCliente"
        PAsociarCliente.Size = New Size(410, 295)
        PAsociarCliente.TabIndex = 33
        ' 
        ' ComboBAsociarCliente
        ' 
        ComboBAsociarCliente.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        ComboBAsociarCliente.FlatStyle = FlatStyle.Flat
        ComboBAsociarCliente.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBAsociarCliente.ForeColor = Color.Silver
        ComboBAsociarCliente.FormattingEnabled = True
        ComboBAsociarCliente.Location = New Point(53, 179)
        ComboBAsociarCliente.Margin = New Padding(3, 4, 3, 4)
        ComboBAsociarCliente.Name = "ComboBAsociarCliente"
        ComboBAsociarCliente.Size = New Size(301, 30)
        ComboBAsociarCliente.TabIndex = 38
        ' 
        ' PBAsociarCliente
        ' 
        PBAsociarCliente.Image = My.Resources.Resources.cliente
        PBAsociarCliente.Location = New Point(53, 17)
        PBAsociarCliente.Margin = New Padding(3, 4, 3, 4)
        PBAsociarCliente.Name = "PBAsociarCliente"
        PBAsociarCliente.Size = New Size(79, 103)
        PBAsociarCliente.TabIndex = 15
        PBAsociarCliente.TabStop = False
        ' 
        ' LEditarCliente
        ' 
        LEditarCliente.AutoSize = True
        LEditarCliente.BackColor = Color.Transparent
        LEditarCliente.Font = New Font("Bahnschrift Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LEditarCliente.ForeColor = Color.White
        LEditarCliente.Location = New Point(138, 48)
        LEditarCliente.Name = "LEditarCliente"
        LEditarCliente.Size = New Size(225, 48)
        LEditarCliente.TabIndex = 11
        LEditarCliente.Text = "1. Editar cliente"
        ' 
        ' PAgregarEquipo
        ' 
        PAgregarEquipo.BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        PAgregarEquipo.Controls.Add(ComboBModelo)
        PAgregarEquipo.Controls.Add(ComboBMarca)
        PAgregarEquipo.Controls.Add(BEditarEquipo)
        PAgregarEquipo.Controls.Add(TBObservaciones)
        PAgregarEquipo.Controls.Add(TBRazonIngreso)
        PAgregarEquipo.Controls.Add(TBNroSerie)
        PAgregarEquipo.Controls.Add(LObservaciones)
        PAgregarEquipo.Controls.Add(LRazonIngreso)
        PAgregarEquipo.Controls.Add(LModelo)
        PAgregarEquipo.Controls.Add(LMarca)
        PAgregarEquipo.Controls.Add(LNroSerie)
        PAgregarEquipo.Controls.Add(CBEquipoEnciende)
        PAgregarEquipo.Controls.Add(ComboBTipoEquipo)
        PAgregarEquipo.Controls.Add(LTipoEquipo)
        PAgregarEquipo.Controls.Add(PictureBox2)
        PAgregarEquipo.Controls.Add(LEditarEquipo)
        PAgregarEquipo.Location = New Point(475, 49)
        PAgregarEquipo.Margin = New Padding(3, 4, 3, 4)
        PAgregarEquipo.Name = "PAgregarEquipo"
        PAgregarEquipo.Size = New Size(589, 859)
        PAgregarEquipo.TabIndex = 32
        ' 
        ' ComboBModelo
        ' 
        ComboBModelo.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        ComboBModelo.FlatStyle = FlatStyle.Flat
        ComboBModelo.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBModelo.ForeColor = Color.Silver
        ComboBModelo.FormattingEnabled = True
        ComboBModelo.Location = New Point(168, 320)
        ComboBModelo.Margin = New Padding(3, 4, 3, 4)
        ComboBModelo.Name = "ComboBModelo"
        ComboBModelo.Size = New Size(394, 30)
        ComboBModelo.TabIndex = 41
        ' 
        ' ComboBMarca
        ' 
        ComboBMarca.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        ComboBMarca.FlatStyle = FlatStyle.Flat
        ComboBMarca.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBMarca.ForeColor = Color.Silver
        ComboBMarca.FormattingEnabled = True
        ComboBMarca.Location = New Point(168, 272)
        ComboBMarca.Margin = New Padding(3, 4, 3, 4)
        ComboBMarca.Name = "ComboBMarca"
        ComboBMarca.Size = New Size(394, 30)
        ComboBMarca.TabIndex = 40
        ' 
        ' BEditarEquipo
        ' 
        BEditarEquipo.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BEditarEquipo.FlatAppearance.BorderSize = 0
        BEditarEquipo.FlatStyle = FlatStyle.Flat
        BEditarEquipo.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BEditarEquipo.ForeColor = Color.White
        BEditarEquipo.Location = New Point(86, 764)
        BEditarEquipo.Margin = New Padding(3, 4, 3, 4)
        BEditarEquipo.Name = "BEditarEquipo"
        BEditarEquipo.Size = New Size(400, 67)
        BEditarEquipo.TabIndex = 39
        BEditarEquipo.Text = "Editar equipo"
        BEditarEquipo.UseVisualStyleBackColor = True
        ' 
        ' TBObservaciones
        ' 
        TBObservaciones.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBObservaciones.BorderStyle = BorderStyle.None
        TBObservaciones.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBObservaciones.ForeColor = Color.Silver
        TBObservaciones.Location = New Point(168, 540)
        TBObservaciones.Multiline = True
        TBObservaciones.Name = "TBObservaciones"
        TBObservaciones.Size = New Size(394, 123)
        TBObservaciones.TabIndex = 39
        ' 
        ' TBRazonIngreso
        ' 
        TBRazonIngreso.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBRazonIngreso.BorderStyle = BorderStyle.None
        TBRazonIngreso.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBRazonIngreso.ForeColor = Color.Silver
        TBRazonIngreso.Location = New Point(168, 393)
        TBRazonIngreso.Multiline = True
        TBRazonIngreso.Name = "TBRazonIngreso"
        TBRazonIngreso.Size = New Size(394, 120)
        TBRazonIngreso.TabIndex = 38
        ' 
        ' TBNroSerie
        ' 
        TBNroSerie.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBNroSerie.BorderStyle = BorderStyle.None
        TBNroSerie.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBNroSerie.ForeColor = Color.Silver
        TBNroSerie.Location = New Point(168, 219)
        TBNroSerie.Name = "TBNroSerie"
        TBNroSerie.Size = New Size(394, 21)
        TBNroSerie.TabIndex = 37
        ' 
        ' LObservaciones
        ' 
        LObservaciones.AutoSize = True
        LObservaciones.Font = New Font("Microsoft Sans Serif", 9.75F)
        LObservaciones.ForeColor = Color.Silver
        LObservaciones.Location = New Point(11, 587)
        LObservaciones.Name = "LObservaciones"
        LObservaciones.Size = New Size(121, 20)
        LObservaciones.TabIndex = 35
        LObservaciones.Text = "Observaciones"
        ' 
        ' LRazonIngreso
        ' 
        LRazonIngreso.AutoSize = True
        LRazonIngreso.Font = New Font("Microsoft Sans Serif", 9.75F)
        LRazonIngreso.ForeColor = Color.Silver
        LRazonIngreso.Location = New Point(11, 439)
        LRazonIngreso.Name = "LRazonIngreso"
        LRazonIngreso.Size = New Size(140, 20)
        LRazonIngreso.TabIndex = 34
        LRazonIngreso.Text = "Razon de ingreso"
        ' 
        ' LModelo
        ' 
        LModelo.AutoSize = True
        LModelo.Font = New Font("Microsoft Sans Serif", 9.75F)
        LModelo.ForeColor = Color.Silver
        LModelo.Location = New Point(11, 323)
        LModelo.Name = "LModelo"
        LModelo.Size = New Size(63, 20)
        LModelo.TabIndex = 33
        LModelo.Text = "Modelo"
        ' 
        ' LMarca
        ' 
        LMarca.AutoSize = True
        LMarca.Font = New Font("Microsoft Sans Serif", 9.75F)
        LMarca.ForeColor = Color.Silver
        LMarca.Location = New Point(11, 275)
        LMarca.Name = "LMarca"
        LMarca.Size = New Size(56, 20)
        LMarca.TabIndex = 32
        LMarca.Text = "Marca"
        ' 
        ' LNroSerie
        ' 
        LNroSerie.AutoSize = True
        LNroSerie.Font = New Font("Microsoft Sans Serif", 9.75F)
        LNroSerie.ForeColor = Color.Silver
        LNroSerie.Location = New Point(11, 219)
        LNroSerie.Name = "LNroSerie"
        LNroSerie.Size = New Size(105, 20)
        LNroSerie.TabIndex = 31
        LNroSerie.Text = "Nro. de serie"
        ' 
        ' CBEquipoEnciende
        ' 
        CBEquipoEnciende.AutoSize = True
        CBEquipoEnciende.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CBEquipoEnciende.ForeColor = Color.Silver
        CBEquipoEnciende.Location = New Point(11, 699)
        CBEquipoEnciende.Margin = New Padding(3, 4, 3, 4)
        CBEquipoEnciende.Name = "CBEquipoEnciende"
        CBEquipoEnciende.Size = New Size(405, 24)
        CBEquipoEnciende.TabIndex = 30
        CBEquipoEnciende.Text = "Marcar si el equipo enciende a la hora de ingresar"
        CBEquipoEnciende.UseVisualStyleBackColor = True
        ' 
        ' ComboBTipoEquipo
        ' 
        ComboBTipoEquipo.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        ComboBTipoEquipo.FlatStyle = FlatStyle.Flat
        ComboBTipoEquipo.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBTipoEquipo.ForeColor = Color.Silver
        ComboBTipoEquipo.FormattingEnabled = True
        ComboBTipoEquipo.Location = New Point(168, 152)
        ComboBTipoEquipo.Margin = New Padding(3, 4, 3, 4)
        ComboBTipoEquipo.Name = "ComboBTipoEquipo"
        ComboBTipoEquipo.Size = New Size(394, 30)
        ComboBTipoEquipo.TabIndex = 28
        ' 
        ' LTipoEquipo
        ' 
        LTipoEquipo.AutoSize = True
        LTipoEquipo.Font = New Font("Microsoft Sans Serif", 9.75F)
        LTipoEquipo.ForeColor = Color.Silver
        LTipoEquipo.Location = New Point(11, 157)
        LTipoEquipo.Name = "LTipoEquipo"
        LTipoEquipo.Size = New Size(118, 20)
        LTipoEquipo.TabIndex = 7
        LTipoEquipo.Text = "Tipo de equipo"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.agregar_equipo
        PictureBox2.Location = New Point(78, 17)
        PictureBox2.Margin = New Padding(3, 4, 3, 4)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(85, 95)
        PictureBox2.TabIndex = 17
        PictureBox2.TabStop = False
        ' 
        ' LEditarEquipo
        ' 
        LEditarEquipo.AutoSize = True
        LEditarEquipo.BackColor = Color.Transparent
        LEditarEquipo.Font = New Font("Bahnschrift Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LEditarEquipo.ForeColor = Color.White
        LEditarEquipo.Location = New Point(177, 48)
        LEditarEquipo.Name = "LEditarEquipo"
        LEditarEquipo.Size = New Size(225, 48)
        LEditarEquipo.TabIndex = 16
        LEditarEquipo.Text = "2. Editar equipo"
        ' 
        ' IBMinimizar_EC
        ' 
        IBMinimizar_EC.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        IBMinimizar_EC.BackColor = Color.Transparent
        IBMinimizar_EC.FlatAppearance.BorderSize = 0
        IBMinimizar_EC.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        IBMinimizar_EC.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        IBMinimizar_EC.FlatStyle = FlatStyle.Flat
        IBMinimizar_EC.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        IBMinimizar_EC.ForeColor = Color.White
        IBMinimizar_EC.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        IBMinimizar_EC.IconColor = Color.Gray
        IBMinimizar_EC.IconFont = FontAwesome.Sharp.IconFont.Auto
        IBMinimizar_EC.IconSize = 20
        IBMinimizar_EC.Location = New Point(1042, 15)
        IBMinimizar_EC.Name = "IBMinimizar_EC"
        IBMinimizar_EC.Size = New Size(22, 23)
        IBMinimizar_EC.TabIndex = 35
        IBMinimizar_EC.UseVisualStyleBackColor = False
        ' 
        ' IBCerrar_EC
        ' 
        IBCerrar_EC.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        IBCerrar_EC.BackColor = Color.Transparent
        IBCerrar_EC.FlatAppearance.BorderSize = 0
        IBCerrar_EC.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        IBCerrar_EC.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        IBCerrar_EC.FlatStyle = FlatStyle.Flat
        IBCerrar_EC.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        IBCerrar_EC.ForeColor = Color.White
        IBCerrar_EC.IconChar = FontAwesome.Sharp.IconChar.Close
        IBCerrar_EC.IconColor = Color.Gray
        IBCerrar_EC.IconFont = FontAwesome.Sharp.IconFont.Auto
        IBCerrar_EC.IconSize = 20
        IBCerrar_EC.Location = New Point(1069, 15)
        IBCerrar_EC.Name = "IBCerrar_EC"
        IBCerrar_EC.Size = New Size(22, 23)
        IBCerrar_EC.TabIndex = 34
        IBCerrar_EC.UseVisualStyleBackColor = False
        ' 
        ' BEstadoEquipo
        ' 
        BEstadoEquipo.Location = New Point(166, 637)
        BEstadoEquipo.Name = "BEstadoEquipo"
        BEstadoEquipo.Size = New Size(94, 29)
        BEstadoEquipo.TabIndex = 36
        BEstadoEquipo.Text = "Estado"
        BEstadoEquipo.UseVisualStyleBackColor = True
        ' 
        ' FormEditarEquipo
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        ClientSize = New Size(1105, 943)
        Controls.Add(BEstadoEquipo)
        Controls.Add(IBMinimizar_EC)
        Controls.Add(IBCerrar_EC)
        Controls.Add(PAsociarCliente)
        Controls.Add(PAgregarEquipo)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormEditarEquipo"
        Text = "FormAgregarEquipo"
        PAsociarCliente.ResumeLayout(False)
        PAsociarCliente.PerformLayout()
        CType(PBAsociarCliente, ComponentModel.ISupportInitialize).EndInit()
        PAgregarEquipo.ResumeLayout(False)
        PAgregarEquipo.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PAsociarCliente As Panel
    Friend WithEvents ComboBAsociarCliente As ComboBox
    Friend WithEvents PBAsociarCliente As PictureBox
    Friend WithEvents LEditarCliente As Label
    Friend WithEvents PAgregarEquipo As Panel
    Friend WithEvents BEditarEquipo As Button
    Friend WithEvents TBObservaciones As TextBox
    Friend WithEvents TBRazonIngreso As TextBox
    Friend WithEvents TBNroSerie As TextBox
    Friend WithEvents LObservaciones As Label
    Friend WithEvents LRazonIngreso As Label
    Friend WithEvents LModelo As Label
    Friend WithEvents LMarca As Label
    Friend WithEvents LNroSerie As Label
    Friend WithEvents CBEquipoEnciende As CheckBox
    Friend WithEvents ComboBTipoEquipo As ComboBox
    Friend WithEvents LTipoEquipo As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LEditarEquipo As Label
    Friend WithEvents IBMinimizar_EC As FontAwesome.Sharp.IconButton
    Friend WithEvents IBCerrar_EC As FontAwesome.Sharp.IconButton
    Friend WithEvents ComboBModelo As ComboBox
    Friend WithEvents ComboBMarca As ComboBox
    Friend WithEvents BEstadoEquipo As Button
End Class
