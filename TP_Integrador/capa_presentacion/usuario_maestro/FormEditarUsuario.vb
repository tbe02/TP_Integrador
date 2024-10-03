Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window

Public Class FormEditarUsuario
    Private usuario As Usuarios.Usuario
    Private usuarios As Usuarios

    ' Constructor
    Public Sub New(usuario As Usuarios.Usuario, usuarios As Usuarios)
        InitializeComponent()
        Me.usuario = usuario
        Me.usuarios = usuarios
        CargarDatosUsuario()
    End Sub


    '-------------------------------------------------------------------------------------------------------------------------'
    'Declaraciones para poder utilizar la funcion releaseCapture, que permite mover el formulario desde el panel superior'
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Sub SendMessage(hWnd As IntPtr, msg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HTCAPTION As Integer = &H2
    '-------------------------------------------------------------------------------------------------------------------------'


    ' Cargar los datos actuales del usuario en los campos del formulario
    Private Sub CargarDatosUsuario()

        ComboBoxTipoUsuario.Items.Clear()
        ComboBoxTipoUsuario.Items.Add("administrador")
        ComboBoxTipoUsuario.Items.Add("tecnico")


        TBApellido.Text = usuario.Apellido
        tNombre.Text = usuario.Nombre
        TBDNI.Text = usuario.DNI
        TBTelefono.Text = usuario.Telefono
        TBCorreo.Text = usuario.Correo
        tUsuario.Text = usuario.NombreUsuario
        tContrasena.Text = usuario.Password


        ComboBoxTipoUsuario.SelectedItem = usuario.Tipo
    End Sub


    ' Devolver el usuario editado
    Public Function ObtenerUsuarioEditado() As Usuarios.Usuario

        usuario.Apellido = TBApellido.Text
        usuario.Nombre = tNombre.Text
        usuario.DNI = TBDNI.Text
        usuario.Telefono = TBTelefono.Text
        usuario.Correo = TBCorreo.Text
        usuario.NombreUsuario = tUsuario.Text
        usuario.Password = tContrasena.Text
        usuario.Tipo = ComboBoxTipoUsuario.SelectedItem.ToString()

        Return usuario
    End Function

    ' Botón para guardar los cambios
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles BEditarUsuario.Click
        Dim usuarioEditado As Usuarios.Usuario = ObtenerUsuarioEditado()

        ' Aquí usamos la instancia de usuarios para llamar a verificaciones
        If usuarios.verificaciones(usuarioEditado.Apellido, usuarioEditado.Nombre, usuarioEditado.DNI, usuarioEditado.Correo, usuarioEditado.Telefono) Then
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub IBCerrar_Click(sender As Object, e As EventArgs) Handles IBCerrar.Click
        Close()
    End Sub

    Private Sub IBMinimizar_Click(sender As Object, e As EventArgs) Handles IBMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PMenuSuperior_MouseDown(sender As Object, e As MouseEventArgs) Handles PMenuSuperior.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
        End If
    End Sub

End Class