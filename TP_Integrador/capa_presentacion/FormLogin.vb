Imports System.IO
Imports System.Runtime.InteropServices 'Permite funcionalidades de API de Windows para poder trabajar con la funcion releaseCapture'
Imports System.Text.Json

Public Class FormLogin
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

    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        If File.Exists("usuario.json") Then
            Dim json As String = File.ReadAllText("usuario.json")

            Dim nombreUsuario As String = JsonSerializer.Deserialize(Of String)(json)

            ' Rellenar los controles con los datos guardados
            TBUsuario.Text = nombreUsuario

        End If
    End Sub

    Private Sub BIniciarSesion_Click(sender As Object, e As EventArgs) Handles BIniciarSesion.Click
        Dim autenticacion As New Autenticador()

        Dim usuario, password As String

        usuario = TBUsuario.Text
        password = TBContrasena.Text

        If String.IsNullOrWhiteSpace(usuario) Or String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Debe completar todos los campos", "Falta de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return
        End If

        Try
            autenticacion.Autenticar(usuario, password)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return
        End Try

        Dim usuarios As Usuarios = Usuarios.ObtenerInstancia()
        Dim usuarioAutenticado = usuarios.obtenerUno(usuario)

        Dim sesion As Sesion = Sesion.ObtenerInstancia()

        sesion.GuardarSesion(usuarioAutenticado)



        Select Case usuarioAutenticado.Tipo.nombre
            Case "maestro"
                Dim menu As New modelo_menu_user_maestro()

                menu.Show()

                Me.Hide()
            Case "tecnico"
                Dim menu As New modelo_menu_user_tecnico()

                menu.Show()

                Me.Hide()
            Case "administrador"
                Dim menu As New modelo_menu_principal()

                menu.Show()

                Me.Hide()
            Case Else
                MessageBox.Show("Tipo de usuario no encontrado", "Ingreso de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub

    Private Sub PBCerrar_Click(sender As Object, e As EventArgs) Handles PBCerrar.Click
        End
    End Sub

    Private Sub PBMinimizar_Click(sender As Object, e As EventArgs) Handles PBMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'Funcion que permite poder mover desde la barra de titulo el formulario'
    Private Sub BarraTitulo_MouseDown(sender As Object, e As MouseEventArgs) Handles BarraTitulo.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
        End If
    End Sub
End Class

