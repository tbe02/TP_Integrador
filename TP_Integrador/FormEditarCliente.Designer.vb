<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEditarCliente
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
        PAgregarCliente = New Panel()
        BEditarCliente = New Button()
        LEditarCliente = New Label()
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
        PAgregarCliente.Controls.Add(BEditarCliente)
        PAgregarCliente.Controls.Add(LEditarCliente)
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
        PAgregarCliente.Location = New Point(1, 3)
        PAgregarCliente.Name = "PAgregarCliente"
        PAgregarCliente.Size = New Size(487, 608)
        PAgregarCliente.TabIndex = 4
        ' 
        ' BEditarCliente
        ' 
        BEditarCliente.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BEditarCliente.FlatAppearance.BorderSize = 0
        BEditarCliente.FlatStyle = FlatStyle.Flat
        BEditarCliente.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BEditarCliente.ForeColor = Color.White
        BEditarCliente.Location = New Point(75, 542)
        BEditarCliente.Margin = New Padding(3, 2, 3, 2)
        BEditarCliente.Name = "BEditarCliente"
        BEditarCliente.Size = New Size(350, 50)
        BEditarCliente.TabIndex = 4
        BEditarCliente.Text = "Editar cliente"
        BEditarCliente.UseVisualStyleBackColor = False
        ' 
        ' LEditarCliente
        ' 
        LEditarCliente.AutoSize = True
        LEditarCliente.BackColor = Color.Transparent
        LEditarCliente.Font = New Font("Bahnschrift Condensed", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LEditarCliente.ForeColor = Color.White
        LEditarCliente.Location = New Point(136, 140)
        LEditarCliente.Name = "LEditarCliente"
        LEditarCliente.Size = New Size(242, 58)
        LEditarCliente.TabIndex = 11
        LEditarCliente.Text = "Editar Cliente"
        ' 
        ' LTelefono
        ' 
        LTelefono.AutoSize = True
        LTelefono.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LTelefono.ForeColor = Color.Silver
        LTelefono.Location = New Point(40, 466)
        LTelefono.Name = "LTelefono"
        LTelefono.Size = New Size(77, 18)
        LTelefono.TabIndex = 10
        LTelefono.Text = "Telefono"
        ' 
        ' LCorreo
        ' 
        LCorreo.AutoSize = True
        LCorreo.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LCorreo.ForeColor = Color.Silver
        LCorreo.Location = New Point(40, 406)
        LCorreo.Name = "LCorreo"
        LCorreo.Size = New Size(64, 18)
        LCorreo.TabIndex = 9
        LCorreo.Text = "Correo"
        ' 
        ' LDNI
        ' 
        LDNI.AutoSize = True
        LDNI.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LDNI.ForeColor = Color.Silver
        LDNI.Location = New Point(40, 346)
        LDNI.Name = "LDNI"
        LDNI.Size = New Size(37, 18)
        LDNI.TabIndex = 8
        LDNI.Text = "DNI"
        ' 
        ' LNombre
        ' 
        LNombre.AutoSize = True
        LNombre.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LNombre.ForeColor = Color.Silver
        LNombre.Location = New Point(40, 286)
        LNombre.Name = "LNombre"
        LNombre.Size = New Size(84, 18)
        LNombre.TabIndex = 7
        LNombre.Text = "Nombre/s"
        ' 
        ' LApellido
        ' 
        LApellido.AutoSize = True
        LApellido.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LApellido.ForeColor = Color.Silver
        LApellido.Location = New Point(40, 226)
        LApellido.Name = "LApellido"
        LApellido.Size = New Size(85, 18)
        LApellido.TabIndex = 6
        LApellido.Text = "Apellido/s"
        ' 
        ' TBTelefono
        ' 
        TBTelefono.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBTelefono.BorderStyle = BorderStyle.None
        TBTelefono.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBTelefono.ForeColor = Color.Silver
        TBTelefono.Location = New Point(189, 466)
        TBTelefono.Margin = New Padding(3, 2, 3, 2)
        TBTelefono.Name = "TBTelefono"
        TBTelefono.Size = New Size(264, 17)
        TBTelefono.TabIndex = 5
        ' 
        ' TBCorreo
        ' 
        TBCorreo.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBCorreo.BorderStyle = BorderStyle.None
        TBCorreo.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBCorreo.ForeColor = Color.Silver
        TBCorreo.Location = New Point(189, 406)
        TBCorreo.Margin = New Padding(3, 2, 3, 2)
        TBCorreo.Name = "TBCorreo"
        TBCorreo.Size = New Size(264, 17)
        TBCorreo.TabIndex = 4
        ' 
        ' TBDNI
        ' 
        TBDNI.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBDNI.BorderStyle = BorderStyle.None
        TBDNI.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBDNI.ForeColor = Color.Silver
        TBDNI.Location = New Point(189, 346)
        TBDNI.Margin = New Padding(3, 2, 3, 2)
        TBDNI.Name = "TBDNI"
        TBDNI.Size = New Size(264, 17)
        TBDNI.TabIndex = 3
        ' 
        ' TBNombre
        ' 
        TBNombre.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBNombre.BorderStyle = BorderStyle.None
        TBNombre.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBNombre.ForeColor = Color.Silver
        TBNombre.Location = New Point(189, 286)
        TBNombre.Margin = New Padding(3, 2, 3, 2)
        TBNombre.Name = "TBNombre"
        TBNombre.Size = New Size(264, 17)
        TBNombre.TabIndex = 2
        ' 
        ' TBApellido
        ' 
        TBApellido.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBApellido.BorderStyle = BorderStyle.None
        TBApellido.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBApellido.ForeColor = Color.Silver
        TBApellido.Location = New Point(189, 226)
        TBApellido.Margin = New Padding(3, 2, 3, 2)
        TBApellido.Name = "TBApellido"
        TBApellido.Size = New Size(264, 17)
        TBApellido.TabIndex = 1
        ' 
        ' PBAgregarCliente
        ' 
        PBAgregarCliente.Image = My.Resources.Resources.editar_cliente_128px
        PBAgregarCliente.Location = New Point(189, 7)
        PBAgregarCliente.Name = "PBAgregarCliente"
        PBAgregarCliente.Size = New Size(151, 130)
        PBAgregarCliente.TabIndex = 0
        PBAgregarCliente.TabStop = False
        ' 
        ' FormEditarCliente
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        ClientSize = New Size(500, 614)
        Controls.Add(PAgregarCliente)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "FormEditarCliente"
        Text = "FormAgregarCliente"
        PAgregarCliente.ResumeLayout(False)
        PAgregarCliente.PerformLayout()
        CType(PBAgregarCliente, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PAgregarCliente As Panel
    Friend WithEvents BEditarCliente As Button
    Friend WithEvents LEditarCliente As Label
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
