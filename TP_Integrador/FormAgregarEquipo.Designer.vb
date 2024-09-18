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
        PictureBox2 = New PictureBox()
        Label2 = New Label()
        PAsociarCliente.SuspendLayout()
        CType(PBAsociarCliente, ComponentModel.ISupportInitialize).BeginInit()
        PAgregarEquipo.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
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
        PAsociarCliente.Location = New Point(53, 7)
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
        BAgregarCliente.Font = New Font("Arial Rounded MT Bold", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BAgregarCliente.ForeColor = Color.White
        BAgregarCliente.Location = New Point(229, 292)
        BAgregarCliente.Margin = New Padding(3, 4, 3, 4)
        BAgregarCliente.Name = "BAgregarCliente"
        BAgregarCliente.Size = New Size(166, 39)
        BAgregarCliente.TabIndex = 4
        BAgregarCliente.Text = "Agregar cliente"
        BAgregarCliente.UseVisualStyleBackColor = True
        ' 
        ' ComboBAsociarCliente
        ' 
        ComboBAsociarCliente.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        ComboBAsociarCliente.FlatStyle = FlatStyle.Flat
        ComboBAsociarCliente.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBAsociarCliente.ForeColor = Color.Silver
        ComboBAsociarCliente.FormattingEnabled = True
        ComboBAsociarCliente.Location = New Point(53, 179)
        ComboBAsociarCliente.Margin = New Padding(3, 4, 3, 4)
        ComboBAsociarCliente.Name = "ComboBAsociarCliente"
        ComboBAsociarCliente.Size = New Size(301, 29)
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
        LAsociarCliente.Font = New Font("Bahnschrift Condensed", 24.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
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
        LSiNoEstaRegistrado.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LSiNoEstaRegistrado.ForeColor = Color.Silver
        LSiNoEstaRegistrado.Location = New Point(53, 303)
        LSiNoEstaRegistrado.Name = "LSiNoEstaRegistrado"
        LSiNoEstaRegistrado.Size = New Size(176, 20)
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
        PAgregarEquipo.Controls.Add(PictureBox2)
        PAgregarEquipo.Controls.Add(Label2)
        PAgregarEquipo.Location = New Point(492, 7)
        PAgregarEquipo.Margin = New Padding(3, 4, 3, 4)
        PAgregarEquipo.Name = "PAgregarEquipo"
        PAgregarEquipo.Size = New Size(571, 858)
        PAgregarEquipo.TabIndex = 32
        ' 
        ' BAgregarEquipo
        ' 
        BAgregarEquipo.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BAgregarEquipo.FlatAppearance.BorderSize = 0
        BAgregarEquipo.FlatStyle = FlatStyle.Flat
        BAgregarEquipo.Font = New Font("Arial Rounded MT Bold", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
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
        TBObservaciones.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBObservaciones.ForeColor = Color.Silver
        TBObservaciones.Location = New Point(153, 540)
        TBObservaciones.Multiline = True
        TBObservaciones.Name = "TBObservaciones"
        TBObservaciones.Size = New Size(394, 123)
        TBObservaciones.TabIndex = 39
        ' 
        ' TBRazonIngreso
        ' 
        TBRazonIngreso.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBRazonIngreso.BorderStyle = BorderStyle.None
        TBRazonIngreso.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBRazonIngreso.ForeColor = Color.Silver
        TBRazonIngreso.Location = New Point(153, 393)
        TBRazonIngreso.Multiline = True
        TBRazonIngreso.Name = "TBRazonIngreso"
        TBRazonIngreso.Size = New Size(394, 120)
        TBRazonIngreso.TabIndex = 38
        ' 
        ' TBNroSerie
        ' 
        TBNroSerie.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBNroSerie.BorderStyle = BorderStyle.None
        TBNroSerie.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBNroSerie.ForeColor = Color.Silver
        TBNroSerie.Location = New Point(153, 219)
        TBNroSerie.Name = "TBNroSerie"
        TBNroSerie.Size = New Size(394, 21)
        TBNroSerie.TabIndex = 37
        ' 
        ' TBModelo
        ' 
        TBModelo.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBModelo.BorderStyle = BorderStyle.None
        TBModelo.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBModelo.ForeColor = Color.Silver
        TBModelo.Location = New Point(153, 320)
        TBModelo.Name = "TBModelo"
        TBModelo.Size = New Size(394, 21)
        TBModelo.TabIndex = 36
        ' 
        ' LObservaciones
        ' 
        LObservaciones.AutoSize = True
        LObservaciones.Font = New Font("Arial Rounded MT Bold", 9.75F)
        LObservaciones.ForeColor = Color.Silver
        LObservaciones.Location = New Point(11, 587)
        LObservaciones.Name = "LObservaciones"
        LObservaciones.Size = New Size(132, 20)
        LObservaciones.TabIndex = 35
        LObservaciones.Text = "Observaciones"
        ' 
        ' LRazonIngreso
        ' 
        LRazonIngreso.AutoSize = True
        LRazonIngreso.Font = New Font("Arial Rounded MT Bold", 9.75F)
        LRazonIngreso.ForeColor = Color.Silver
        LRazonIngreso.Location = New Point(11, 440)
        LRazonIngreso.Name = "LRazonIngreso"
        LRazonIngreso.Size = New Size(151, 20)
        LRazonIngreso.TabIndex = 34
        LRazonIngreso.Text = "Razon de ingreso"
        ' 
        ' LModelo
        ' 
        LModelo.AutoSize = True
        LModelo.Font = New Font("Arial Rounded MT Bold", 9.75F)
        LModelo.ForeColor = Color.Silver
        LModelo.Location = New Point(11, 323)
        LModelo.Name = "LModelo"
        LModelo.Size = New Size(69, 20)
        LModelo.TabIndex = 33
        LModelo.Text = "Modelo"
        ' 
        ' LMarca
        ' 
        LMarca.AutoSize = True
        LMarca.Font = New Font("Arial Rounded MT Bold", 9.75F)
        LMarca.ForeColor = Color.Silver
        LMarca.Location = New Point(11, 275)
        LMarca.Name = "LMarca"
        LMarca.Size = New Size(60, 20)
        LMarca.TabIndex = 32
        LMarca.Text = "Marca"
        ' 
        ' LNroSerie
        ' 
        LNroSerie.AutoSize = True
        LNroSerie.Font = New Font("Arial Rounded MT Bold", 9.75F)
        LNroSerie.ForeColor = Color.Silver
        LNroSerie.Location = New Point(11, 219)
        LNroSerie.Name = "LNroSerie"
        LNroSerie.Size = New Size(114, 20)
        LNroSerie.TabIndex = 31
        LNroSerie.Text = "Nro. de serie"
        ' 
        ' CBEquipoEnciende
        ' 
        CBEquipoEnciende.AutoSize = True
        CBEquipoEnciende.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CBEquipoEnciende.ForeColor = Color.Silver
        CBEquipoEnciende.Location = New Point(11, 699)
        CBEquipoEnciende.Margin = New Padding(3, 4, 3, 4)
        CBEquipoEnciende.Name = "CBEquipoEnciende"
        CBEquipoEnciende.Size = New Size(439, 24)
        CBEquipoEnciende.TabIndex = 30
        CBEquipoEnciende.Text = "Marcar si el equipo enciende a la hora de ingresar"
        CBEquipoEnciende.UseVisualStyleBackColor = True
        ' 
        ' ComboBTipoEquipo
        ' 
        ComboBTipoEquipo.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        ComboBTipoEquipo.FlatStyle = FlatStyle.Flat
        ComboBTipoEquipo.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBTipoEquipo.ForeColor = Color.Silver
        ComboBTipoEquipo.FormattingEnabled = True
        ComboBTipoEquipo.Location = New Point(153, 152)
        ComboBTipoEquipo.Margin = New Padding(3, 4, 3, 4)
        ComboBTipoEquipo.Name = "ComboBTipoEquipo"
        ComboBTipoEquipo.Size = New Size(394, 29)
        ComboBTipoEquipo.TabIndex = 28
        ' 
        ' TBMarca
        ' 
        TBMarca.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBMarca.BorderStyle = BorderStyle.None
        TBMarca.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBMarca.ForeColor = Color.Silver
        TBMarca.Location = New Point(153, 272)
        TBMarca.Name = "TBMarca"
        TBMarca.Size = New Size(394, 21)
        TBMarca.TabIndex = 5
        ' 
        ' LTipoEquipo
        ' 
        LTipoEquipo.AutoSize = True
        LTipoEquipo.Font = New Font("Arial Rounded MT Bold", 9.75F)
        LTipoEquipo.ForeColor = Color.Silver
        LTipoEquipo.Location = New Point(11, 157)
        LTipoEquipo.Name = "LTipoEquipo"
        LTipoEquipo.Size = New Size(132, 20)
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
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Bahnschrift Condensed", 24.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(177, 48)
        Label2.Name = "Label2"
        Label2.Size = New Size(254, 48)
        Label2.TabIndex = 16
        Label2.Text = "2. Agregar equipo"
        ' 
        ' FormAgregarEquipo
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        ClientSize = New Size(1062, 878)
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
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
End Class
