Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions

Public Class FormEditarUsuario
    Private usuario As Usuarios.Usuario
    Private alFinalizar As Action
    Private _controladorTiposDeUsuario As ControladorTiposDeUsuario = New ControladorTiposDeUsuario()

    ' Constructor
    Public Sub New(usuario As Usuarios.Usuario, alFinalizar As Action)
        InitializeComponent()
        Me.usuario = usuario
        Me.alFinalizar = alFinalizar
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

    Private Sub FormEditarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetTiposDeUsuario()
        CargarDatosUsuario()
    End Sub


    Private Sub SetTiposDeUsuario()
        Dim usuarios = _controladorTiposDeUsuario.ObtenerTodos()

        ComboBoxTipoUsuario.DataSource = usuarios
        ComboBoxTipoUsuario.DisplayMember = "nombre"
        ComboBoxTipoUsuario.ValueMember = "idTipoUsuario"
        ComboBoxTipoUsuario.SelectedValue = usuario.Tipo.idTipoUsuario
        ComboBoxTipoUsuario.Refresh()
    End Sub

    ' Cargar los datos actuales del usuario en los campos del formulario
    Private Sub CargarDatosUsuario()


        TBApellido.Text = usuario.Apellido
        tNombre.Text = usuario.Nombre
        TBDNI.Text = usuario.DNI
        TBTelefono.Text = usuario.Telefono
        TBCorreo.Text = usuario.Correo
        tUsuario.Text = usuario.NombreUsuario
        tContrasena.Text = usuario.Password

        ComboBoxTipoUsuario.SelectedValue = usuario.Tipo.idTipoUsuario
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
        usuario.Tipo = New TiposDeUsuario.TipoDeUsuario() With {.idTipoUsuario = ComboBoxTipoUsuario.SelectedValue, .nombre = ComboBoxTipoUsuario.Text}

        Return usuario
    End Function

    ' Botón para guardar los cambios
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles BEditarUsuario.Click
        Dim usuarioEditado As Usuarios.Usuario = ObtenerUsuarioEditado()

        ' Aquí usamos la instancia de usuarios para llamar a verificaciones
        If verificaciones(usuarioEditado.Apellido, usuarioEditado.Nombre, usuarioEditado.DNI, usuarioEditado.Correo, usuarioEditado.Telefono) Then
            Usuarios.editarUsuario(usuarioEditado.Apellido, usuarioEditado.Nombre, usuarioEditado.DNI, usuarioEditado.Telefono, usuarioEditado.Correo, usuarioEditado.NombreUsuario, usuarioEditado.Password, usuarioEditado.Tipo.nombre)
            alFinalizar.Invoke()
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

    Private Function verificaciones(apellido As String, nombre As String, dni As String, correo As String, telefono As String)
        If (apellido = "" Or nombre = "" Or dni = "" Or correo = "" Or telefono = "") Then
            MessageBox.Show("Debe completar todos los campos", "Falta de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Else
            If validarLetra(apellido) = False Then
                MessageBox.Show("Apellido solo acepta letras", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
            If validarLetra(nombre) = False Then
                MessageBox.Show("Nombre solo acepta letras", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
            If Not IsNumeric(dni) Then
                MessageBox.Show("DNI solo acepta numeros", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
            If Not IsNumeric(telefono) Then
                MessageBox.Show("Telefono solo acepta numeros", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
            If Not emailValido(correo) Then
                MessageBox.Show("El correo electrónico no es válido.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        End If

        Return True
    End Function

    Private Function validarLetra(texto As String)
        Dim soloLetras As Boolean = True

        For Each letra As Char In texto
            If Not (Char.IsLetter(letra) OrElse Char.IsWhiteSpace(letra)) Then
                soloLetras = False
                Return False
            End If
        Next

        Return True
    End Function

    Private Function emailValido(email As String) As Boolean
        ' Definir la expresión regular para validar el correo electrónico
        Dim pattern As String = "^[^@\s]+@[^@\s]+\.[^@\s]+$"
        Dim regex As New Regex(pattern)

        Return regex.IsMatch(email)
    End Function

End Class
