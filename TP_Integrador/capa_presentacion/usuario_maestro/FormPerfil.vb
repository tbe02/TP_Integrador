Public Class FormPerfil
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
        LTipoDeUsuarioU.Text = _usuario.Tipo
    End Sub

    Private Sub BCerrar_Click(sender As Object, e As EventArgs) Handles BCerrar.Click
        Me.Close()
    End Sub
End Class
