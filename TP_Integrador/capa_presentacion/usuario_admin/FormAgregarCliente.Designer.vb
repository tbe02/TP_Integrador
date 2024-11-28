<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAgregarCliente
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
        PAgregarCliente = New Panel()
        BAgregarCliente = New Button()
        LAgregarCliente = New Label()
        LTelefono = New Label()
        LCorreo = New Label()
        LDNI = New Label()
        LNombre = New Label()
        LApellido = New Label()
        TBTelefono = New TextBox()
        TBCorreo = New TextBox()
        TBDNI = New TextBox()
        TBNombre = New TextBox()
        TBApellido = New TextBox()
        PBAgregarCliente = New PictureBox()
        PAgregarCliente.SuspendLayout()
        CType(PBAgregarCliente, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PAgregarCliente
        ' 
        PAgregarCliente.BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        PAgregarCliente.Controls.Add(BAgregarCliente)
        PAgregarCliente.Controls.Add(LAgregarCliente)
        PAgregarCliente.Controls.Add(LTelefono)
        PAgregarCliente.Controls.Add(LCorreo)
        PAgregarCliente.Controls.Add(LDNI)
        PAgregarCliente.Controls.Add(LNombre)
        PAgregarCliente.Controls.Add(LApellido)
        PAgregarCliente.Controls.Add(TBTelefono)
        PAgregarCliente.Controls.Add(TBCorreo)
        PAgregarCliente.Controls.Add(TBDNI)
        PAgregarCliente.Controls.Add(TBNombre)
        PAgregarCliente.Controls.Add(TBApellido)
        PAgregarCliente.Controls.Add(PBAgregarCliente)
        PAgregarCliente.Location = New Point(1, 4)
        PAgregarCliente.Margin = New Padding(3, 4, 3, 4)
        PAgregarCliente.Name = "PAgregarCliente"
        PAgregarCliente.Size = New Size(567, 811)
        PAgregarCliente.TabIndex = 4
        ' 
        ' BAgregarCliente
        ' 
        BAgregarCliente.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BAgregarCliente.FlatAppearance.BorderSize = 0
        BAgregarCliente.FlatStyle = FlatStyle.Flat
        BAgregarCliente.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BAgregarCliente.ForeColor = Color.White
        BAgregarCliente.Location = New Point(86, 723)
        BAgregarCliente.Name = "BAgregarCliente"
        BAgregarCliente.Size = New Size(400, 67)
        BAgregarCliente.TabIndex = 6
        BAgregarCliente.Text = "Agregar cliente"
        BAgregarCliente.UseVisualStyleBackColor = False
        ' 
        ' LAgregarCliente
        ' 
        LAgregarCliente.AutoSize = True
        LAgregarCliente.BackColor = Color.Transparent
        LAgregarCliente.Font = New Font("Bahnschrift Condensed", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LAgregarCliente.ForeColor = Color.White
        LAgregarCliente.Location = New Point(122, 187)
        LAgregarCliente.Name = "LAgregarCliente"
        LAgregarCliente.Size = New Size(339, 72)
        LAgregarCliente.TabIndex = 11
        LAgregarCliente.Text = "Agregar Cliente"
        ' 
        ' LTelefono
        ' 
        LTelefono.AutoSize = True
        LTelefono.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LTelefono.ForeColor = Color.Silver
        LTelefono.Location = New Point(46, 621)
        LTelefono.Name = "LTelefono"
        LTelefono.Size = New Size(89, 25)
        LTelefono.TabIndex = 10
        LTelefono.Text = "Telefono"
        ' 
        ' LCorreo
        ' 
        LCorreo.AutoSize = True
        LCorreo.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LCorreo.ForeColor = Color.Silver
        LCorreo.Location = New Point(46, 541)
        LCorreo.Name = "LCorreo"
        LCorreo.Size = New Size(72, 25)
        LCorreo.TabIndex = 9
        LCorreo.Text = "Correo"
        ' 
        ' LDNI
        ' 
        LDNI.AutoSize = True
        LDNI.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LDNI.ForeColor = Color.Silver
        LDNI.Location = New Point(46, 461)
        LDNI.Name = "LDNI"
        LDNI.Size = New Size(45, 25)
        LDNI.TabIndex = 8
        LDNI.Text = "DNI"
        ' 
        ' LNombre
        ' 
        LNombre.AutoSize = True
        LNombre.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LNombre.ForeColor = Color.Silver
        LNombre.Location = New Point(46, 381)
        LNombre.Name = "LNombre"
        LNombre.Size = New Size(97, 25)
        LNombre.TabIndex = 7
        LNombre.Text = "Nombre/s"
        ' 
        ' LApellido
        ' 
        LApellido.AutoSize = True
        LApellido.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LApellido.ForeColor = Color.Silver
        LApellido.Location = New Point(46, 301)
        LApellido.Name = "LApellido"
        LApellido.Size = New Size(98, 25)
        LApellido.TabIndex = 6
        LApellido.Text = "Apellido/s"
        ' 
        ' TBTelefono
        ' 
        TBTelefono.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBTelefono.BorderStyle = BorderStyle.None
        TBTelefono.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBTelefono.ForeColor = Color.Silver
        TBTelefono.Location = New Point(216, 621)
        TBTelefono.Name = "TBTelefono"
        TBTelefono.Size = New Size(302, 21)
        TBTelefono.TabIndex = 5
        ' 
        ' TBCorreo
        ' 
        TBCorreo.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBCorreo.BorderStyle = BorderStyle.None
        TBCorreo.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBCorreo.ForeColor = Color.Silver
        TBCorreo.Location = New Point(216, 541)
        TBCorreo.Name = "TBCorreo"
        TBCorreo.Size = New Size(302, 21)
        TBCorreo.TabIndex = 4
        ' 
        ' TBDNI
        ' 
        TBDNI.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBDNI.BorderStyle = BorderStyle.None
        TBDNI.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBDNI.ForeColor = Color.Silver
        TBDNI.Location = New Point(216, 461)
        TBDNI.Name = "TBDNI"
        TBDNI.Size = New Size(302, 21)
        TBDNI.TabIndex = 3
        ' 
        ' TBNombre
        ' 
        TBNombre.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBNombre.BorderStyle = BorderStyle.None
        TBNombre.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBNombre.ForeColor = Color.Silver
        TBNombre.Location = New Point(216, 381)
        TBNombre.Name = "TBNombre"
        TBNombre.Size = New Size(302, 21)
        TBNombre.TabIndex = 2
        ' 
        ' TBApellido
        ' 
        TBApellido.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBApellido.BorderStyle = BorderStyle.None
        TBApellido.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBApellido.ForeColor = Color.Silver
        TBApellido.Location = New Point(216, 301)
        TBApellido.Name = "TBApellido"
        TBApellido.Size = New Size(302, 21)
        TBApellido.TabIndex = 1
        ' 
        ' PBAgregarCliente
        ' 
        PBAgregarCliente.Image = My.Resources.Resources.agregar_cliente
        PBAgregarCliente.Location = New Point(216, 9)
        PBAgregarCliente.Margin = New Padding(3, 4, 3, 4)
        PBAgregarCliente.Name = "PBAgregarCliente"
        PBAgregarCliente.Size = New Size(173, 173)
        PBAgregarCliente.TabIndex = 0
        PBAgregarCliente.TabStop = False
        ' 
        ' FormAgregarCliente
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        ClientSize = New Size(571, 819)
        Controls.Add(PAgregarCliente)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "FormAgregarCliente"
        Text = "FormAgregarCliente"
        PAgregarCliente.ResumeLayout(False)
        PAgregarCliente.PerformLayout()
        CType(PBAgregarCliente, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PAgregarCliente As Panel
    Friend WithEvents BAgregarCliente As Button
    Friend WithEvents LAgregarCliente As Label
    Friend WithEvents LTelefono As Label
    Friend WithEvents LCorreo As Label
    Friend WithEvents LDNI As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents LApellido As Label
    Friend WithEvents TBTelefono As TextBox
    Friend WithEvents TBCorreo As TextBox
    Friend WithEvents TBDNI As TextBox
    Friend WithEvents TBNombre As TextBox
    Friend WithEvents TBApellido As TextBox
    Friend WithEvents PBAgregarCliente As PictureBox
End Class
