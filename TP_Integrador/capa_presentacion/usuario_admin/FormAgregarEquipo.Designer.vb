<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAgregarEquipo
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
        BAgregarCliente = New Button()
        ComboBAsociarCliente = New ComboBox()
        PBAsociarCliente = New PictureBox()
        LAsociarCliente = New Label()
        LSiNoEstaRegistrado = New Label()
        PAgregarEquipo = New Panel()
        IBAgregarModelo = New FontAwesome.Sharp.IconButton()
        IBAgregarMarca = New FontAwesome.Sharp.IconButton()
        ComboBModelo = New ComboBox()
        ComboBMarca = New ComboBox()
        BAgregarEquipo = New Button()
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
        PBAgregarEquipo = New PictureBox()
        LAgregarEquipo = New Label()
        PAsociarCliente.SuspendLayout()
        CType(PBAsociarCliente, ComponentModel.ISupportInitialize).BeginInit()
        PAgregarEquipo.SuspendLayout()
        CType(PBAgregarEquipo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PAsociarCliente
        ' 
        PAsociarCliente.BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        PAsociarCliente.Controls.Add(BAgregarCliente)
        PAsociarCliente.Controls.Add(ComboBAsociarCliente)
        PAsociarCliente.Controls.Add(PBAsociarCliente)
        PAsociarCliente.Controls.Add(LAsociarCliente)
        PAsociarCliente.Controls.Add(LSiNoEstaRegistrado)
        PAsociarCliente.Location = New Point(14, 7)
        PAsociarCliente.Margin = New Padding(3, 4, 3, 4)
        PAsociarCliente.Name = "PAsociarCliente"
        PAsociarCliente.Size = New Size(410, 428)
        PAsociarCliente.TabIndex = 33
        ' 
        ' BAgregarCliente
        ' 
        BAgregarCliente.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BAgregarCliente.FlatAppearance.BorderSize = 0
        BAgregarCliente.FlatStyle = FlatStyle.Flat
        BAgregarCliente.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BAgregarCliente.ForeColor = Color.White
        BAgregarCliente.Location = New Point(219, 292)
        BAgregarCliente.Margin = New Padding(3, 4, 3, 4)
        BAgregarCliente.Name = "BAgregarCliente"
        BAgregarCliente.Size = New Size(178, 39)
        BAgregarCliente.TabIndex = 4
        BAgregarCliente.Text = "Agregar cliente"
        BAgregarCliente.UseVisualStyleBackColor = True
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
        ' LAsociarCliente
        ' 
        LAsociarCliente.AutoSize = True
        LAsociarCliente.BackColor = Color.Transparent
        LAsociarCliente.Font = New Font("Bahnschrift Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LAsociarCliente.ForeColor = Color.White
        LAsociarCliente.Location = New Point(138, 48)
        LAsociarCliente.Name = "LAsociarCliente"
        LAsociarCliente.Size = New Size(245, 48)
        LAsociarCliente.TabIndex = 11
        LAsociarCliente.Text = "1. Asociar cliente"
        ' 
        ' LSiNoEstaRegistrado
        ' 
        LSiNoEstaRegistrado.AutoSize = True
        LSiNoEstaRegistrado.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LSiNoEstaRegistrado.ForeColor = Color.Silver
        LSiNoEstaRegistrado.Location = New Point(38, 304)
        LSiNoEstaRegistrado.Name = "LSiNoEstaRegistrado"
        LSiNoEstaRegistrado.Size = New Size(162, 20)
        LSiNoEstaRegistrado.TabIndex = 13
        LSiNoEstaRegistrado.Text = "si no esta registrado"
        ' 
        ' PAgregarEquipo
        ' 
        PAgregarEquipo.BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        PAgregarEquipo.Controls.Add(IBAgregarModelo)
        PAgregarEquipo.Controls.Add(IBAgregarMarca)
        PAgregarEquipo.Controls.Add(ComboBModelo)
        PAgregarEquipo.Controls.Add(ComboBMarca)
        PAgregarEquipo.Controls.Add(BAgregarEquipo)
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
        PAgregarEquipo.Controls.Add(PBAgregarEquipo)
        PAgregarEquipo.Controls.Add(LAgregarEquipo)
        PAgregarEquipo.Location = New Point(453, 7)
        PAgregarEquipo.Margin = New Padding(3, 4, 3, 4)
        PAgregarEquipo.Name = "PAgregarEquipo"
        PAgregarEquipo.Size = New Size(614, 859)
        PAgregarEquipo.TabIndex = 32
        ' 
        ' IBAgregarModelo
        ' 
        IBAgregarModelo.BackColor = Color.FromArgb(CByte(0), CByte(122), CByte(204))
        IBAgregarModelo.FlatAppearance.BorderSize = 0
        IBAgregarModelo.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(87), CByte(153))
        IBAgregarModelo.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(0), CByte(102), CByte(178))
        IBAgregarModelo.FlatStyle = FlatStyle.Flat
        IBAgregarModelo.IconChar = FontAwesome.Sharp.IconChar.Add
        IBAgregarModelo.IconColor = Color.White
        IBAgregarModelo.IconFont = FontAwesome.Sharp.IconFont.Solid
        IBAgregarModelo.IconSize = 30
        IBAgregarModelo.Location = New Point(568, 320)
        IBAgregarModelo.Name = "IBAgregarModelo"
        IBAgregarModelo.Size = New Size(31, 30)
        IBAgregarModelo.TabIndex = 43
        IBAgregarModelo.TextImageRelation = TextImageRelation.ImageAboveText
        IBAgregarModelo.UseVisualStyleBackColor = False
        ' 
        ' IBAgregarMarca
        ' 
        IBAgregarMarca.BackColor = Color.FromArgb(CByte(0), CByte(122), CByte(204))
        IBAgregarMarca.FlatAppearance.BorderSize = 0
        IBAgregarMarca.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(87), CByte(153))
        IBAgregarMarca.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(0), CByte(102), CByte(178))
        IBAgregarMarca.FlatStyle = FlatStyle.Flat
        IBAgregarMarca.IconChar = FontAwesome.Sharp.IconChar.Add
        IBAgregarMarca.IconColor = Color.White
        IBAgregarMarca.IconFont = FontAwesome.Sharp.IconFont.Solid
        IBAgregarMarca.IconSize = 30
        IBAgregarMarca.Location = New Point(568, 270)
        IBAgregarMarca.Name = "IBAgregarMarca"
        IBAgregarMarca.Size = New Size(31, 30)
        IBAgregarMarca.TabIndex = 42
        IBAgregarMarca.TextImageRelation = TextImageRelation.ImageAboveText
        IBAgregarMarca.UseVisualStyleBackColor = False
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
        ComboBMarca.Location = New Point(168, 270)
        ComboBMarca.Margin = New Padding(3, 4, 3, 4)
        ComboBMarca.Name = "ComboBMarca"
        ComboBMarca.Size = New Size(394, 30)
        ComboBMarca.TabIndex = 40
        ' 
        ' BAgregarEquipo
        ' 
        BAgregarEquipo.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BAgregarEquipo.FlatAppearance.BorderSize = 0
        BAgregarEquipo.FlatStyle = FlatStyle.Flat
        BAgregarEquipo.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BAgregarEquipo.ForeColor = Color.White
        BAgregarEquipo.Location = New Point(86, 764)
        BAgregarEquipo.Margin = New Padding(3, 4, 3, 4)
        BAgregarEquipo.Name = "BAgregarEquipo"
        BAgregarEquipo.Size = New Size(400, 67)
        BAgregarEquipo.TabIndex = 39
        BAgregarEquipo.Text = "Agregar equipo"
        BAgregarEquipo.UseVisualStyleBackColor = True
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
        ' PBAgregarEquipo
        ' 
        PBAgregarEquipo.Image = My.Resources.Resources.agregar_equipo
        PBAgregarEquipo.Location = New Point(78, 17)
        PBAgregarEquipo.Margin = New Padding(3, 4, 3, 4)
        PBAgregarEquipo.Name = "PBAgregarEquipo"
        PBAgregarEquipo.Size = New Size(85, 95)
        PBAgregarEquipo.TabIndex = 17
        PBAgregarEquipo.TabStop = False
        ' 
        ' LAgregarEquipo
        ' 
        LAgregarEquipo.AutoSize = True
        LAgregarEquipo.BackColor = Color.Transparent
        LAgregarEquipo.Font = New Font("Bahnschrift Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LAgregarEquipo.ForeColor = Color.White
        LAgregarEquipo.Location = New Point(177, 48)
        LAgregarEquipo.Name = "LAgregarEquipo"
        LAgregarEquipo.Size = New Size(254, 48)
        LAgregarEquipo.TabIndex = 16
        LAgregarEquipo.Text = "2. Agregar equipo"
        ' 
        ' FormAgregarEquipo
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        ClientSize = New Size(1087, 877)
        Controls.Add(PAsociarCliente)
        Controls.Add(PAgregarEquipo)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormAgregarEquipo"
        Text = "FormAgregarEquipo"
        PAsociarCliente.ResumeLayout(False)
        PAsociarCliente.PerformLayout()
        CType(PBAsociarCliente, ComponentModel.ISupportInitialize).EndInit()
        PAgregarEquipo.ResumeLayout(False)
        PAgregarEquipo.PerformLayout()
        CType(PBAgregarEquipo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PAsociarCliente As Panel
    Friend WithEvents BAgregarCliente As Button
    Friend WithEvents ComboBAsociarCliente As ComboBox
    Friend WithEvents PBAsociarCliente As PictureBox
    Friend WithEvents LAsociarCliente As Label
    Friend WithEvents LSiNoEstaRegistrado As Label
    Friend WithEvents PAgregarEquipo As Panel
    Friend WithEvents BAgregarEquipo As Button
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
    Friend WithEvents PBAgregarEquipo As PictureBox
    Friend WithEvents LAgregarEquipo As Label
    Friend WithEvents ComboBModelo As ComboBox
    Friend WithEvents ComboBMarca As ComboBox
    Friend WithEvents IBAgregarMarca As FontAwesome.Sharp.IconButton
    Friend WithEvents IBAgregarModelo As FontAwesome.Sharp.IconButton
End Class
