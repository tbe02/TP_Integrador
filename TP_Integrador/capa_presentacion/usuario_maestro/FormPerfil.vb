Imports System.Runtime.InteropServices

Public Class FormPerfil

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




    Private _usuario As Usuarios.Usuario = Sesion.ObtenerInstancia().ObtenerUsuario()



    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        InicializarCampos()
    End Sub

    Private Sub InicializarCampos()
        LApellidoU.Text = _usuario.Apellido
        LNombreU.Text = _usuario.Nombre
        LDNIU.Text = _usuario.DNI
        LCorreoU.Text = _usuario.Correo
        LTelefonoU.Text = _usuario.Telefono
        LUsuarioU.Text = _usuario.NombreUsuario
        LTipoDeUsuarioU.Text = _usuario.Tipo.nombre
    End Sub

    Private Sub BCerrar_Click(sender As Object, e As EventArgs) Handles BCerrar.Click
        Me.Close()
    End Sub

    Private Sub PMenuSuperior_MouseDown(sender As Object, e As MouseEventArgs) Handles PMenuSuperior.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
        End If
    End Sub
End Class
