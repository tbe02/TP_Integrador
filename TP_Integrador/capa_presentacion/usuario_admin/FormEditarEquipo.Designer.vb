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
        BEditarCliente = New Button()
        ComboBAsociarCliente = New ComboBox()
        PBAsociarCliente = New PictureBox()
        LEditarCliente = New Label()
        LSiNoEstaRegistrado = New Label()
        PAgregarEquipo = New Panel()
        BEditarEquipo = New Button()
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
        LEditarEquipo = New Label()
        IBMinimizar_EC = New FontAwesome.Sharp.IconButton()
        IBCerrar_EC = New FontAwesome.Sharp.IconButton()
        PAsociarCliente.SuspendLayout()
        CType(PBAsociarCliente, ComponentModel.ISupportInitialize).BeginInit()
        PAgregarEquipo.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PAsociarCliente
        ' 
        PAsociarCliente.BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        PAsociarCliente.Controls.Add(BEditarCliente)
        PAsociarCliente.Controls.Add(ComboBAsociarCliente)
        PAsociarCliente.Controls.Add(PBAsociarCliente)
        PAsociarCliente.Controls.Add(LEditarCliente)
        PAsociarCliente.Controls.Add(LSiNoEstaRegistrado)
        PAsociarCliente.Location = New Point(30, 37)
        PAsociarCliente.Name = "PAsociarCliente"
        PAsociarCliente.Size = New Size(359, 321)
        PAsociarCliente.TabIndex = 33
        ' 
        ' BEditarCliente
        ' 
        BEditarCliente.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BEditarCliente.FlatAppearance.BorderSize = 0
        BEditarCliente.FlatStyle = FlatStyle.Flat
        BEditarCliente.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BEditarCliente.ForeColor = Color.White
        BEditarCliente.Location = New Point(192, 219)
        BEditarCliente.Name = "BEditarCliente"
        BEditarCliente.Size = New Size(156, 29)
        BEditarCliente.TabIndex = 4
        BEditarCliente.Text = "Editar cliente"
        BEditarCliente.UseVisualStyleBackColor = True
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
        ' LEditarCliente
        ' 
        LEditarCliente.AutoSize = True
        LEditarCliente.BackColor = Color.Transparent
        LEditarCliente.Font = New Font("Bahnschrift Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LEditarCliente.ForeColor = Color.White
        LEditarCliente.Location = New Point(121, 36)
        LEditarCliente.Name = "LEditarCliente"
        LEditarCliente.Size = New Size(177, 39)
        LEditarCliente.TabIndex = 11
        LEditarCliente.Text = "1. Editar cliente"
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
        PAgregarEquipo.Controls.Add(BEditarEquipo)
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
        PAgregarEquipo.Controls.Add(LEditarEquipo)
        PAgregarEquipo.Location = New Point(416, 37)
        PAgregarEquipo.Name = "PAgregarEquipo"
        PAgregarEquipo.Size = New Size(515, 644)
        PAgregarEquipo.TabIndex = 32
        ' 
        ' BEditarEquipo
        ' 
        BEditarEquipo.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BEditarEquipo.FlatAppearance.BorderSize = 0
        BEditarEquipo.FlatStyle = FlatStyle.Flat
        BEditarEquipo.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BEditarEquipo.ForeColor = Color.White
        BEditarEquipo.Location = New Point(75, 573)
        BEditarEquipo.Name = "BEditarEquipo"
        BEditarEquipo.Size = New Size(350, 50)
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
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.agregar_equipo
        PictureBox2.Location = New Point(68, 13)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(74, 71)
        PictureBox2.TabIndex = 17
        PictureBox2.TabStop = False
        ' 
        ' LEditarEquipo
        ' 
        LEditarEquipo.AutoSize = True
        LEditarEquipo.BackColor = Color.Transparent
        LEditarEquipo.Font = New Font("Bahnschrift Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LEditarEquipo.ForeColor = Color.White
        LEditarEquipo.Location = New Point(155, 36)
        LEditarEquipo.Name = "LEditarEquipo"
        LEditarEquipo.Size = New Size(179, 39)
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
        IBMinimizar_EC.Location = New Point(888, 11)
        IBMinimizar_EC.Margin = New Padding(3, 2, 3, 2)
        IBMinimizar_EC.Name = "IBMinimizar_EC"
        IBMinimizar_EC.Size = New Size(19, 17)
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
        IBCerrar_EC.Location = New Point(912, 11)
        IBCerrar_EC.Margin = New Padding(3, 2, 3, 2)
        IBCerrar_EC.Name = "IBCerrar_EC"
        IBCerrar_EC.Size = New Size(19, 17)
        IBCerrar_EC.TabIndex = 34
        IBCerrar_EC.UseVisualStyleBackColor = False
        ' 
        ' FormEditarEquipo
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        ClientSize = New Size(943, 693)
        Controls.Add(IBMinimizar_EC)
        Controls.Add(IBCerrar_EC)
        Controls.Add(PAsociarCliente)
        Controls.Add(PAgregarEquipo)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
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
    Friend WithEvents BEditarCliente As Button
    Friend WithEvents ComboBAsociarCliente As ComboBox
    Friend WithEvents PBAsociarCliente As PictureBox
    Friend WithEvents LEditarCliente As Label
    Friend WithEvents LSiNoEstaRegistrado As Label
    Friend WithEvents PAgregarEquipo As Panel
    Friend WithEvents BEditarEquipo As Button
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
    Friend WithEvents LEditarEquipo As Label
    Friend WithEvents IBMinimizar_EC As FontAwesome.Sharp.IconButton
    Friend WithEvents IBCerrar_EC As FontAwesome.Sharp.IconButton
End Class
