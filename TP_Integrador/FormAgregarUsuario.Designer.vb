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
        LAgregarCliente = New Label()
        PBAgregarCliente = New PictureBox()
        PAgregarCliente = New Panel()
        Label3 = New Label()
        tNombre = New TextBox()
        ComboBoxTipoUsuario = New ComboBox()
        Label2 = New Label()
        Label1 = New Label()
        tContrasena = New TextBox()
        BAgregarCliente = New Button()
        LApellido = New Label()
        tUsuario = New TextBox()
        CType(PBAgregarCliente, ComponentModel.ISupportInitialize).BeginInit()
        PAgregarCliente.SuspendLayout()
        SuspendLayout()
        ' 
        ' LAgregarCliente
        ' 
        LAgregarCliente.AutoSize = True
        LAgregarCliente.BackColor = Color.Transparent
        LAgregarCliente.Font = New Font("Bahnschrift Condensed", 36.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LAgregarCliente.ForeColor = Color.White
        LAgregarCliente.Location = New Point(327, 166)
        LAgregarCliente.Name = "LAgregarCliente"
        LAgregarCliente.Size = New Size(283, 58)
        LAgregarCliente.TabIndex = 11
        LAgregarCliente.Text = "Agregar Usuario"
        ' 
        ' PBAgregarCliente
        ' 
        PBAgregarCliente.Image = My.Resources.Resources.agregar_cliente
        PBAgregarCliente.Location = New Point(409, 33)
        PBAgregarCliente.Name = "PBAgregarCliente"
        PBAgregarCliente.Size = New Size(151, 130)
        PBAgregarCliente.TabIndex = 0
        PBAgregarCliente.TabStop = False
        ' 
        ' PAgregarCliente
        ' 
        PAgregarCliente.BackColor = Color.FromArgb(CByte(48), CByte(63), CByte(105))
        PAgregarCliente.BorderStyle = BorderStyle.FixedSingle
        PAgregarCliente.Controls.Add(Label3)
        PAgregarCliente.Controls.Add(tNombre)
        PAgregarCliente.Controls.Add(ComboBoxTipoUsuario)
        PAgregarCliente.Controls.Add(Label2)
        PAgregarCliente.Controls.Add(Label1)
        PAgregarCliente.Controls.Add(tContrasena)
        PAgregarCliente.Controls.Add(BAgregarCliente)
        PAgregarCliente.Controls.Add(LAgregarCliente)
        PAgregarCliente.Controls.Add(LApellido)
        PAgregarCliente.Controls.Add(tUsuario)
        PAgregarCliente.Controls.Add(PBAgregarCliente)
        PAgregarCliente.Location = New Point(0, 0)
        PAgregarCliente.Name = "PAgregarCliente"
        PAgregarCliente.Size = New Size(931, 666)
        PAgregarCliente.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Silver
        Label3.Location = New Point(260, 279)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 20)
        Label3.TabIndex = 19
        Label3.Text = "Nombre"
        ' 
        ' tNombre
        ' 
        tNombre.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        tNombre.BorderStyle = BorderStyle.None
        tNombre.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tNombre.ForeColor = Color.Silver
        tNombre.Location = New Point(409, 279)
        tNombre.Margin = New Padding(3, 2, 3, 2)
        tNombre.Name = "tNombre"
        tNombre.Size = New Size(264, 17)
        tNombre.TabIndex = 1
        ' 
        ' ComboBoxTipoUsuario
        ' 
        ComboBoxTipoUsuario.BackColor = Color.White
        ComboBoxTipoUsuario.ForeColor = Color.Black
        ComboBoxTipoUsuario.FormattingEnabled = True
        ComboBoxTipoUsuario.Location = New Point(409, 497)
        ComboBoxTipoUsuario.Name = "ComboBoxTipoUsuario"
        ComboBoxTipoUsuario.Size = New Size(264, 23)
        ComboBoxTipoUsuario.TabIndex = 18
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Silver
        Label2.Location = New Point(260, 497)
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
        Label1.Location = New Point(260, 423)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 20)
        Label1.TabIndex = 13
        Label1.Text = "Contrasena"
        ' 
        ' tContrasena
        ' 
        tContrasena.BackColor = Color.FromArgb(CByte(80), CByte(96), CByte(130))
        tContrasena.BorderStyle = BorderStyle.None
        tContrasena.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tContrasena.ForeColor = Color.Silver
        tContrasena.Location = New Point(409, 423)
        tContrasena.Margin = New Padding(3, 2, 3, 2)
        tContrasena.Name = "tContrasena"
        tContrasena.Size = New Size(264, 17)
        tContrasena.TabIndex = 17
        ' 
        ' BAgregarCliente
        ' 
        BAgregarCliente.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BAgregarCliente.FlatAppearance.BorderSize = 0
        BAgregarCliente.FlatStyle = FlatStyle.Flat
        BAgregarCliente.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BAgregarCliente.ForeColor = Color.White
        BAgregarCliente.Location = New Point(295, 568)
        BAgregarCliente.Margin = New Padding(3, 2, 3, 2)
        BAgregarCliente.Name = "BAgregarCliente"
        BAgregarCliente.Size = New Size(350, 50)
        BAgregarCliente.TabIndex = 19
        BAgregarCliente.Text = "Agregar usuario"
        BAgregarCliente.UseVisualStyleBackColor = False
        ' 
        ' LApellido
        ' 
        LApellido.AutoSize = True
        LApellido.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LApellido.ForeColor = Color.Silver
        LApellido.Location = New Point(260, 355)
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
        tUsuario.Location = New Point(409, 355)
        tUsuario.Margin = New Padding(3, 2, 3, 2)
        tUsuario.Name = "tUsuario"
        tUsuario.Size = New Size(264, 17)
        tUsuario.TabIndex = 12
        ' 
        ' FormAgregarUsuario
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(931, 666)
        Controls.Add(PAgregarCliente)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormAgregarUsuario"
        Text = "FormAgregarUsuario"
        CType(PBAgregarCliente, ComponentModel.ISupportInitialize).EndInit()
        PAgregarCliente.ResumeLayout(False)
        PAgregarCliente.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents LAgregarCliente As Label
    Friend WithEvents PBAgregarCliente As PictureBox
    Friend WithEvents PAgregarCliente As Panel
    Friend WithEvents BAgregarCliente As Button
    Friend WithEvents LApellido As Label
    Friend WithEvents tUsuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tContrasena As TextBox

    Friend WithEvents ComboBoxTipoUsuario As ComboBox

    Friend WithEvents Label3 As Label
    Friend WithEvents tNombre As TextBox

    Private Sub agregarUsuario(sender As Object, e As EventArgs) Handles BAgregarCliente.Click
        Dim nombre = tNombre.Text
        Dim usuario = tUsuario.Text
        Dim contrasena = tContrasena.Text
        Dim tipoUsuario = ComboBoxTipoUsuario.Text

        If nombre = "" Or usuario = "" Or contrasena = "" Or tipoUsuario = "" Then
            MessageBox.Show("Por favor complete los campos", "Agregar usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return
        End If

        MessageBox.Show("Usuario agregado exitosamente", "Agregar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
