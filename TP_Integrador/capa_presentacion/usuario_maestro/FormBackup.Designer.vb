<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBackup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBackup))
        BBackup = New Button()
        BRestore = New Button()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BBackup
        ' 
        BBackup.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BBackup.FlatAppearance.BorderSize = 0
        BBackup.FlatStyle = FlatStyle.Flat
        BBackup.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BBackup.ForeColor = Color.White
        BBackup.Location = New Point(94, 146)
        BBackup.Margin = New Padding(3, 2, 3, 2)
        BBackup.Name = "BBackup"
        BBackup.Size = New Size(350, 50)
        BBackup.TabIndex = 20
        BBackup.Text = "Realizar Backup"
        BBackup.UseVisualStyleBackColor = False
        ' 
        ' BRestore
        ' 
        BRestore.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BRestore.FlatAppearance.BorderSize = 0
        BRestore.FlatStyle = FlatStyle.Flat
        BRestore.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BRestore.ForeColor = Color.White
        BRestore.Location = New Point(498, 146)
        BRestore.Margin = New Padding(3, 2, 3, 2)
        BRestore.Name = "BRestore"
        BRestore.Size = New Size(350, 50)
        BRestore.TabIndex = 21
        BRestore.Text = "Realizar Restore"
        BRestore.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(161, 226)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(226, 206)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 22
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(558, 226)
        PictureBox2.Margin = New Padding(3, 2, 3, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(226, 206)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 23
        PictureBox2.TabStop = False
        ' 
        ' FormBackup
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(33), CByte(74))
        ClientSize = New Size(948, 581)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(BRestore)
        Controls.Add(BBackup)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(3, 2, 3, 2)
        Name = "FormBackup"
        Text = "FormBackup"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents BBackup As Button
    Friend WithEvents BRestore As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
