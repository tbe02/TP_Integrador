Public Class FormPerfil
    Dim sesion As Sesion = Sesion.ObtenerInstancia()
    Dim usuario As Usuarios.Usuario = sesion.ObtenerUsuario()

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        InicializarCampos()
    End Sub

    Private Sub InicializarCampos()
        LApellidoU.Text = usuario.Apellido
        LNombreU.Text = usuario.Nombre
        LDNIU.Text = usuario.DNI
        LCorreoU.Text = usuario.Correo
        LTelefonoU.Text = usuario.Telefono
        LUsuarioU.Text = usuario.NombreUsuario
        LTipoDeUsuarioU.Text = usuario.Tipo
    End Sub

    Private Sub BCerrar_Click(sender As Object, e As EventArgs) Handles BCerrar.Click
        Me.Close()
    End Sub
End Class