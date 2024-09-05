<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        PictureBox2 = New PictureBox()
        Button1 = New Button()
        TextBox2 = New TextBox()
        PictureBox1 = New PictureBox()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(60))
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(203, 60)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(361, 403)
        Panel1.TabIndex = 0
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = My.Resources.Resources.llave
        PictureBox2.Location = New Point(55, 208)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(30, 34)
        PictureBox2.TabIndex = 5
        PictureBox2.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Arial Rounded MT Bold", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(99, 317)
        Button1.Name = "Button1"
        Button1.Size = New Size(140, 29)
        Button1.TabIndex = 4
        Button1.Text = "Iniciar Sesión"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.Gray
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        TextBox2.Location = New Point(99, 214)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(184, 28)
        TextBox2.TabIndex = 3
        TextBox2.Text = "Contraseña"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.hombre
        PictureBox1.Location = New Point(55, 120)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(30, 34)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Gray
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        TextBox1.Location = New Point(99, 126)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(184, 28)
        TextBox1.TabIndex = 1
        TextBox1.Text = "Usuario"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(144, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 35)
        Label1.TabIndex = 0
        Label1.Text = "Login"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(51), CByte(102))
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(782, 553)
        Controls.Add(Panel1)
        MaximizeBox = False
        MaximumSize = New Size(800, 600)
        MinimizeBox = False
        MinimumSize = New Size(800, 600)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox

End Class
