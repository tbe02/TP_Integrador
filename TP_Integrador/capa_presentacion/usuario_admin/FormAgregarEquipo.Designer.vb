<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAgregarEquipo
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
        PAsociarCliente = New Panel()
        BAgregarCliente = New Button()
        ComboBAsociarCliente = New ComboBox()
        PBAsociarCliente = New PictureBox()
        LAsociarCliente = New Label()
        LSiNoEstaRegistrado = New Label()
        PAgregarEquipo = New Panel()
        BAgregarEquipo = New Button()
        TBObservaciones = New TextBox()
        TBRazonIngreso = New TextBox()
        TBNroSerie = New TextBox()
        TBModelo = New TextBox()
        LObservaciones = New Label()
        LRazonIngreso = New Label()
        LModelo = New Label()
        LMarca = New Label()
        LNroSerie = New Label()
        CBEquipoEnciende = New CheckBox()
        ComboBTipoEquipo = New ComboBox()
        TBMarca = New TextBox()
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
        PAsociarCliente.Location = New Point(12, 5)
        PAsociarCliente.Name = "PAsociarCliente"
        PAsociarCliente.Size = New Size(359, 321)
        PAsociarCliente.TabIndex = 33
        ' 
        ' BAgregarCliente
        ' 
        BAgregarCliente.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BAgregarCliente.FlatAppearance.BorderSize = 0
        BAgregarCliente.FlatStyle = FlatStyle.Flat
        BAgregarCliente.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BAgregarCliente.ForeColor = Color.White
        BAgregarCliente.Location = New Point(192, 219)
        BAgregarCliente.Name = "BAgregarCliente"
        BAgregarCliente.Size = New Size(156, 29)
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
        ComboBAsociarCliente.Location = New Point(46, 134)
        ComboBAsociarCliente.Name = "ComboBAsociarCliente"
        ComboBAsociarCliente.Size = New Size(264, 25)
        ComboBAsociarCliente.TabIndex = 38
        ' 
        ' PBAsociarCliente
        ' 
        PBAsociarCliente.Image = My.Resources.Resources.cliente
        PBAsociarCliente.Location = New Point(46, 13)
        PBAsociarCliente.Name = "PBAsociarCliente"
        PBAsociarCliente.Size = New Size(69, 77)
        PBAsociarCliente.TabIndex = 15
        PBAsociarCliente.TabStop = False
        ' 
        ' LAsociarCliente
        ' 
        LAsociarCliente.AutoSize = True
        LAsociarCliente.BackColor = Color.Transparent
        LAsociarCliente.Font = New Font("Bahnschrift Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LAsociarCliente.ForeColor = Color.White
        LAsociarCliente.Location = New Point(121, 36)
        LAsociarCliente.Name = "LAsociarCliente"
        LAsociarCliente.Size = New Size(194, 39)
        LAsociarCliente.TabIndex = 11
        LAsociarCliente.Text = "1. Asociar cliente"
        ' 
        ' LSiNoEstaRegistrado
        ' 
        LSiNoEstaRegistrado.AutoSize = True
        LSiNoEstaRegistrado.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LSiNoEstaRegistrado.ForeColor = Color.Silver
        LSiNoEstaRegistrado.Location = New Point(33, 228)
        LSiNoEstaRegistrado.Name = "LSiNoEstaRegistrado"
        LSiNoEstaRegistrado.Size = New Size(128, 16)
        LSiNoEstaRegistrado.TabIndex = 13
        LSiNoEstaRegistrado.Text = "si no esta registrado"
        ' 
        ' PAgregarEquipo
        ' 
        PAgregarEquipo.BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        PAgregarEquipo.Controls.Add(BAgregarEquipo)
        PAgregarEquipo.Controls.Add(TBObservaciones)
        PAgregarEquipo.Controls.Add(TBRazonIngreso)
        PAgregarEquipo.Controls.Add(TBNroSerie)
        PAgregarEquipo.Controls.Add(TBModelo)
        PAgregarEquipo.Controls.Add(LObservaciones)
        PAgregarEquipo.Controls.Add(LRazonIngreso)
        PAgregarEquipo.Controls.Add(LModelo)
        PAgregarEquipo.Controls.Add(LMarca)
        PAgregarEquipo.Controls.Add(LNroSerie)
        PAgregarEquipo.Controls.Add(CBEquipoEnciende)
        PAgregarEquipo.Controls.Add(ComboBTipoEquipo)
        PAgregarEquipo.Controls.Add(TBMarca)
        PAgregarEquipo.Controls.Add(LTipoEquipo)
        PAgregarEquipo.Controls.Add(PBAgregarEquipo)
        PAgregarEquipo.Controls.Add(LAgregarEquipo)
        PAgregarEquipo.Location = New Point(396, 5)
        PAgregarEquipo.Name = "PAgregarEquipo"
        PAgregarEquipo.Size = New Size(537, 644)
        PAgregarEquipo.TabIndex = 32
        ' 
        ' BAgregarEquipo
        ' 
        BAgregarEquipo.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BAgregarEquipo.FlatAppearance.BorderSize = 0
        BAgregarEquipo.FlatStyle = FlatStyle.Flat
        BAgregarEquipo.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BAgregarEquipo.ForeColor = Color.White
        BAgregarEquipo.Location = New Point(75, 573)
        BAgregarEquipo.Name = "BAgregarEquipo"
        BAgregarEquipo.Size = New Size(350, 50)
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
        TBObservaciones.Location = New Point(147, 405)
        TBObservaciones.Margin = New Padding(3, 2, 3, 2)
        TBObservaciones.Multiline = True
        TBObservaciones.Name = "TBObservaciones"
        TBObservaciones.Size = New Size(345, 92)
        TBObservaciones.TabIndex = 39
        ' 
        ' TBRazonIngreso
        ' 
        TBRazonIngreso.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBRazonIngreso.BorderStyle = BorderStyle.None
        TBRazonIngreso.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBRazonIngreso.ForeColor = Color.Silver
        TBRazonIngreso.Location = New Point(147, 295)
        TBRazonIngreso.Margin = New Padding(3, 2, 3, 2)
        TBRazonIngreso.Multiline = True
        TBRazonIngreso.Name = "TBRazonIngreso"
        TBRazonIngreso.Size = New Size(345, 90)
        TBRazonIngreso.TabIndex = 38
        ' 
        ' TBNroSerie
        ' 
        TBNroSerie.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBNroSerie.BorderStyle = BorderStyle.None
        TBNroSerie.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBNroSerie.ForeColor = Color.Silver
        TBNroSerie.Location = New Point(147, 164)
        TBNroSerie.Margin = New Padding(3, 2, 3, 2)
        TBNroSerie.Name = "TBNroSerie"
        TBNroSerie.Size = New Size(345, 17)
        TBNroSerie.TabIndex = 37
        ' 
        ' TBModelo
        ' 
        TBModelo.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBModelo.BorderStyle = BorderStyle.None
        TBModelo.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBModelo.ForeColor = Color.Silver
        TBModelo.Location = New Point(147, 240)
        TBModelo.Margin = New Padding(3, 2, 3, 2)
        TBModelo.Name = "TBModelo"
        TBModelo.Size = New Size(345, 17)
        TBModelo.TabIndex = 36
        ' 
        ' LObservaciones
        ' 
        LObservaciones.AutoSize = True
        LObservaciones.Font = New Font("Microsoft Sans Serif", 9.75F)
        LObservaciones.ForeColor = Color.Silver
        LObservaciones.Location = New Point(10, 440)
        LObservaciones.Name = "LObservaciones"
        LObservaciones.Size = New Size(99, 16)
        LObservaciones.TabIndex = 35
        LObservaciones.Text = "Observaciones"
        ' 
        ' LRazonIngreso
        ' 
        LRazonIngreso.AutoSize = True
        LRazonIngreso.Font = New Font("Microsoft Sans Serif", 9.75F)
        LRazonIngreso.ForeColor = Color.Silver
        LRazonIngreso.Location = New Point(10, 329)
        LRazonIngreso.Name = "LRazonIngreso"
        LRazonIngreso.Size = New Size(113, 16)
        LRazonIngreso.TabIndex = 34
        LRazonIngreso.Text = "Razon de ingreso"
        ' 
        ' LModelo
        ' 
        LModelo.AutoSize = True
        LModelo.Font = New Font("Microsoft Sans Serif", 9.75F)
        LModelo.ForeColor = Color.Silver
        LModelo.Location = New Point(10, 242)
        LModelo.Name = "LModelo"
        LModelo.Size = New Size(53, 16)
        LModelo.TabIndex = 33
        LModelo.Text = "Modelo"
        ' 
        ' LMarca
        ' 
        LMarca.AutoSize = True
        LMarca.Font = New Font("Microsoft Sans Serif", 9.75F)
        LMarca.ForeColor = Color.Silver
        LMarca.Location = New Point(10, 206)
        LMarca.Name = "LMarca"
        LMarca.Size = New Size(45, 16)
        LMarca.TabIndex = 32
        LMarca.Text = "Marca"
        ' 
        ' LNroSerie
        ' 
        LNroSerie.AutoSize = True
        LNroSerie.Font = New Font("Microsoft Sans Serif", 9.75F)
        LNroSerie.ForeColor = Color.Silver
        LNroSerie.Location = New Point(10, 164)
        LNroSerie.Name = "LNroSerie"
        LNroSerie.Size = New Size(84, 16)
        LNroSerie.TabIndex = 31
        LNroSerie.Text = "Nro. de serie"
        ' 
        ' CBEquipoEnciende
        ' 
        CBEquipoEnciende.AutoSize = True
        CBEquipoEnciende.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CBEquipoEnciende.ForeColor = Color.Silver
        CBEquipoEnciende.Location = New Point(10, 524)
        CBEquipoEnciende.Name = "CBEquipoEnciende"
        CBEquipoEnciende.Size = New Size(325, 20)
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
        ComboBTipoEquipo.Location = New Point(147, 114)
        ComboBTipoEquipo.Name = "ComboBTipoEquipo"
        ComboBTipoEquipo.Size = New Size(345, 25)
        ComboBTipoEquipo.TabIndex = 28
        ' 
        ' TBMarca
        ' 
        TBMarca.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBMarca.BorderStyle = BorderStyle.None
        TBMarca.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBMarca.ForeColor = Color.Silver
        TBMarca.Location = New Point(147, 204)
        TBMarca.Margin = New Padding(3, 2, 3, 2)
        TBMarca.Name = "TBMarca"
        TBMarca.Size = New Size(345, 17)
        TBMarca.TabIndex = 5
        ' 
        ' LTipoEquipo
        ' 
        LTipoEquipo.AutoSize = True
        LTipoEquipo.Font = New Font("Microsoft Sans Serif", 9.75F)
        LTipoEquipo.ForeColor = Color.Silver
        LTipoEquipo.Location = New Point(10, 118)
        LTipoEquipo.Name = "LTipoEquipo"
        LTipoEquipo.Size = New Size(99, 16)
        LTipoEquipo.TabIndex = 7
        LTipoEquipo.Text = "Tipo de equipo"
        ' 
        ' PBAgregarEquipo
        ' 
        PBAgregarEquipo.Image = My.Resources.Resources.agregar_equipo
        PBAgregarEquipo.Location = New Point(68, 13)
        PBAgregarEquipo.Name = "PBAgregarEquipo"
        PBAgregarEquipo.Size = New Size(74, 71)
        PBAgregarEquipo.TabIndex = 17
        PBAgregarEquipo.TabStop = False
        ' 
        ' LAgregarEquipo
        ' 
        LAgregarEquipo.AutoSize = True
        LAgregarEquipo.BackColor = Color.Transparent
        LAgregarEquipo.Font = New Font("Bahnschrift Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LAgregarEquipo.ForeColor = Color.White
        LAgregarEquipo.Location = New Point(155, 36)
        LAgregarEquipo.Name = "LAgregarEquipo"
        LAgregarEquipo.Size = New Size(203, 39)
        LAgregarEquipo.TabIndex = 16
        LAgregarEquipo.Text = "2. Agregar equipo"
        ' 
        ' FormAgregarEquipo
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        ClientSize = New Size(951, 658)
        Controls.Add(PAsociarCliente)
        Controls.Add(PAgregarEquipo)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
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
    Friend WithEvents TBModelo As TextBox
    Friend WithEvents LObservaciones As Label
    Friend WithEvents LRazonIngreso As Label
    Friend WithEvents LModelo As Label
    Friend WithEvents LMarca As Label
    Friend WithEvents LNroSerie As Label
    Friend WithEvents CBEquipoEnciende As CheckBox
    Friend WithEvents ComboBTipoEquipo As ComboBox
    Friend WithEvents TBMarca As TextBox
    Friend WithEvents LTipoEquipo As Label
    Friend WithEvents PBAgregarEquipo As PictureBox
    Friend WithEvents LAgregarEquipo As Label
End Class
