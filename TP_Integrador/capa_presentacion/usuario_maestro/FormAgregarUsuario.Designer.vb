<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAgregarUsuario
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        LAgregarUsuario = New Label()
        PAgregarCliente = New Panel()
        PBAgregarUsuario = New PictureBox()
        LTelefono = New Label()
        LCorreo = New Label()
        LDNI = New Label()
        LNombre = New Label()
        Label3 = New Label()
        TBTelefono = New TextBox()
        TBCorreo = New TextBox()
        TBDNI = New TextBox()
        tNombre = New TextBox()
        TBApellido = New TextBox()
        ComboBoxTipoUsuario = New ComboBox()
        Label2 = New Label()
        Label1 = New Label()
        tContrasena = New TextBox()
        BAgregarUsuario = New Button()
        LApellido = New Label()
        tUsuario = New TextBox()
        PAgregarCliente.SuspendLayout()
        CType(PBAgregarUsuario, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LAgregarUsuario
        ' 
        LAgregarUsuario.AutoSize = True
        LAgregarUsuario.BackColor = Color.Transparent
        LAgregarUsuario.Font = New Font("Bahnschrift Condensed", 36.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LAgregarUsuario.ForeColor = Color.White
        LAgregarUsuario.Location = New Point(140, 12)
        LAgregarUsuario.Name = "LAgregarUsuario"
        LAgregarUsuario.Size = New Size(283, 58)
        LAgregarUsuario.TabIndex = 11
        LAgregarUsuario.Text = "Agregar Usuario"
        ' 
        ' PAgregarCliente
        ' 
        PAgregarCliente.BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        PAgregarCliente.Controls.Add(PBAgregarUsuario)
        PAgregarCliente.Controls.Add(LTelefono)
        PAgregarCliente.Controls.Add(LCorreo)
        PAgregarCliente.Controls.Add(LDNI)
        PAgregarCliente.Controls.Add(LNombre)
        PAgregarCliente.Controls.Add(Label3)
        PAgregarCliente.Controls.Add(TBTelefono)
        PAgregarCliente.Controls.Add(TBCorreo)
        PAgregarCliente.Controls.Add(TBDNI)
        PAgregarCliente.Controls.Add(tNombre)
        PAgregarCliente.Controls.Add(TBApellido)
        PAgregarCliente.Controls.Add(ComboBoxTipoUsuario)
        PAgregarCliente.Controls.Add(Label2)
        PAgregarCliente.Controls.Add(Label1)
        PAgregarCliente.Controls.Add(tContrasena)
        PAgregarCliente.Controls.Add(BAgregarUsuario)
        PAgregarCliente.Controls.Add(LAgregarUsuario)
        PAgregarCliente.Controls.Add(LApellido)
        PAgregarCliente.Controls.Add(tUsuario)
        PAgregarCliente.Location = New Point(0, 0)
        PAgregarCliente.Name = "PAgregarCliente"
        PAgregarCliente.Size = New Size(498, 674)
        PAgregarCliente.TabIndex = 5
        ' 
        ' PBAgregarUsuario
        ' 
        PBAgregarUsuario.Image = My.Resources.Resources.people1
        PBAgregarUsuario.Location = New Point(60, 12)
        PBAgregarUsuario.Name = "PBAgregarUsuario"
        PBAgregarUsuario.Size = New Size(83, 79)
        PBAgregarUsuario.TabIndex = 30
        PBAgregarUsuario.TabStop = False
        ' 
        ' LTelefono
        ' 
        LTelefono.AutoSize = True
        LTelefono.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LTelefono.ForeColor = Color.Silver
        LTelefono.Location = New Point(51, 345)
        LTelefono.Name = "LTelefono"
        LTelefono.Size = New Size(71, 20)
        LTelefono.TabIndex = 29
        LTelefono.Text = "Telefono"
        ' 
        ' LCorreo
        ' 
        LCorreo.AutoSize = True
        LCorreo.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LCorreo.ForeColor = Color.Silver
        LCorreo.Location = New Point(51, 285)
        LCorreo.Name = "LCorreo"
        LCorreo.Size = New Size(57, 20)
        LCorreo.TabIndex = 28
        LCorreo.Text = "Correo"
        ' 
        ' LDNI
        ' 
        LDNI.AutoSize = True
        LDNI.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LDNI.ForeColor = Color.Silver
        LDNI.Location = New Point(51, 225)
        LDNI.Name = "LDNI"
        LDNI.Size = New Size(37, 20)
        LDNI.TabIndex = 27
        LDNI.Text = "DNI"
        ' 
        ' LNombre
        ' 
        LNombre.AutoSize = True
        LNombre.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LNombre.ForeColor = Color.Silver
        LNombre.Location = New Point(51, 165)
        LNombre.Name = "LNombre"
        LNombre.Size = New Size(77, 20)
        LNombre.TabIndex = 26
        LNombre.Text = "Nombre/s"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Silver
        Label3.Location = New Point(51, 105)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 20)
        Label3.TabIndex = 25
        Label3.Text = "Apellido/s"
        ' 
        ' TBTelefono
        ' 
        TBTelefono.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBTelefono.BorderStyle = BorderStyle.None
        TBTelefono.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBTelefono.ForeColor = Color.Silver
        TBTelefono.Location = New Point(200, 345)
        TBTelefono.Margin = New Padding(3, 2, 3, 2)
        TBTelefono.Name = "TBTelefono"
        TBTelefono.Size = New Size(264, 17)
        TBTelefono.TabIndex = 24
        ' 
        ' TBCorreo
        ' 
        TBCorreo.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBCorreo.BorderStyle = BorderStyle.None
        TBCorreo.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBCorreo.ForeColor = Color.Silver
        TBCorreo.Location = New Point(200, 285)
        TBCorreo.Margin = New Padding(3, 2, 3, 2)
        TBCorreo.Name = "TBCorreo"
        TBCorreo.Size = New Size(264, 17)
        TBCorreo.TabIndex = 23
        ' 
        ' TBDNI
        ' 
        TBDNI.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBDNI.BorderStyle = BorderStyle.None
        TBDNI.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBDNI.ForeColor = Color.Silver
        TBDNI.Location = New Point(200, 225)
        TBDNI.Margin = New Padding(3, 2, 3, 2)
        TBDNI.Name = "TBDNI"
        TBDNI.Size = New Size(264, 17)
        TBDNI.TabIndex = 22
        ' 
        ' tNombre
        ' 
        tNombre.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        tNombre.BorderStyle = BorderStyle.None
        tNombre.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tNombre.ForeColor = Color.Silver
        tNombre.Location = New Point(200, 165)
        tNombre.Margin = New Padding(3, 2, 3, 2)
        tNombre.Name = "tNombre"
        tNombre.Size = New Size(264, 17)
        tNombre.TabIndex = 21
        ' 
        ' TBApellido
        ' 
        TBApellido.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        TBApellido.BorderStyle = BorderStyle.None
        TBApellido.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBApellido.ForeColor = Color.Silver
        TBApellido.Location = New Point(200, 105)
        TBApellido.Margin = New Padding(3, 2, 3, 2)
        TBApellido.Name = "TBApellido"
        TBApellido.Size = New Size(264, 17)
        TBApellido.TabIndex = 20
        ' 
        ' ComboBoxTipoUsuario
        ' 
        ComboBoxTipoUsuario.BackColor = Color.White
        ComboBoxTipoUsuario.ForeColor = Color.Black
        ComboBoxTipoUsuario.FormattingEnabled = True
        ComboBoxTipoUsuario.Location = New Point(200, 525)
        ComboBoxTipoUsuario.Name = "ComboBoxTipoUsuario"
        ComboBoxTipoUsuario.Size = New Size(264, 23)
        ComboBoxTipoUsuario.TabIndex = 18
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Silver
        Label2.Location = New Point(51, 525)
        Label2.Name = "Label2"
        Label2.Size = New Size(117, 20)
        Label2.TabIndex = 15
        Label2.Text = "Tipo de usuario"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Silver
        Label1.Location = New Point(51, 465)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 20)
        Label1.TabIndex = 13
        Label1.Text = "Contraseña"
        ' 
        ' tContrasena
        ' 
        tContrasena.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        tContrasena.BorderStyle = BorderStyle.None
        tContrasena.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tContrasena.ForeColor = Color.Silver
        tContrasena.Location = New Point(200, 465)
        tContrasena.Margin = New Padding(3, 2, 3, 2)
        tContrasena.Name = "tContrasena"
        tContrasena.Size = New Size(264, 17)
        tContrasena.TabIndex = 17
        ' 
        ' BAgregarUsuario
        ' 
        BAgregarUsuario.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BAgregarUsuario.FlatAppearance.BorderSize = 0
        BAgregarUsuario.FlatStyle = FlatStyle.Flat
        BAgregarUsuario.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BAgregarUsuario.ForeColor = Color.White
        BAgregarUsuario.Location = New Point(73, 579)
        BAgregarUsuario.Margin = New Padding(3, 2, 3, 2)
        BAgregarUsuario.Name = "BAgregarUsuario"
        BAgregarUsuario.Size = New Size(350, 50)
        BAgregarUsuario.TabIndex = 19
        BAgregarUsuario.Text = "Agregar usuario"
        BAgregarUsuario.UseVisualStyleBackColor = False
        ' 
        ' LApellido
        ' 
        LApellido.AutoSize = True
        LApellido.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LApellido.ForeColor = Color.Silver
        LApellido.Location = New Point(51, 405)
        LApellido.Name = "LApellido"
        LApellido.Size = New Size(64, 20)
        LApellido.TabIndex = 6
        LApellido.Text = "Usuario"
        ' 
        ' tUsuario
        ' 
        tUsuario.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        tUsuario.BorderStyle = BorderStyle.None
        tUsuario.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tUsuario.ForeColor = Color.Silver
        tUsuario.Location = New Point(200, 405)
        tUsuario.Margin = New Padding(3, 2, 3, 2)
        tUsuario.Name = "tUsuario"
        tUsuario.Size = New Size(264, 17)
        tUsuario.TabIndex = 12
        ' 
        ' FormAgregarUsuario
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        ClientSize = New Size(500, 677)
        Controls.Add(PAgregarCliente)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormAgregarUsuario"
        Text = "FormAgregarUsuario"
        PAgregarCliente.ResumeLayout(False)
        PAgregarCliente.PerformLayout()
        CType(PBAgregarUsuario, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents LAgregarUsuario As Label
    Friend WithEvents PAgregarCliente As Panel
    Friend WithEvents BAgregarUsuario As Button
    Friend WithEvents LApellido As Label
    Friend WithEvents tUsuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tContrasena As TextBox

    Friend WithEvents ComboBoxTipoUsuario As ComboBox


    Friend WithEvents LTelefono As Label
    Friend WithEvents LCorreo As Label
    Friend WithEvents LDNI As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TBTelefono As TextBox
    Friend WithEvents TBCorreo As TextBox
    Friend WithEvents TBDNI As TextBox
    Friend WithEvents tNombre As TextBox
    Friend WithEvents TBApellido As TextBox
    Friend WithEvents PBAgregarUsuario As PictureBox
End Class
