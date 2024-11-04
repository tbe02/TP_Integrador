Partial Public Class FormAgregarUsuario
    Private _controladorUsuarios As ControladorUsuarios = New ControladorUsuarios()
    Private _controladorTiposDeUsuario As ControladorTiposDeUsuario = New ControladorTiposDeUsuario()

    Private Sub FormAgregarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarTiposDeUsuario()
    End Sub

    Private Sub ListarTiposDeUsuario()
        Dim tiposDeEquipo = _controladorTiposDeUsuario.ObtenerTodos()

        ComboBoxTipoUsuario.DataSource = tiposDeEquipo
        ComboBoxTipoUsuario.DisplayMember = "nombre"
        ComboBoxTipoUsuario.ValueMember = "idTipoUsuario"
    End Sub

    Private Sub BAgregarUsuario_Click(sender As Object, e As EventArgs) Handles BAgregarUsuario.Click
        Dim apellido, nombre, dni, correo, telefono, nombreusuario, contrasenia, tipoUsuario As String

        apellido = TBApellido.Text
        nombre = tNombre.Text
        dni = TBDNI.Text
        correo = TBCorreo.Text
        telefono = TBTelefono.Text
        nombreusuario = tUsuario.Text
        contrasenia = tContrasena.Text

        If ComboBoxTipoUsuario.SelectedItem IsNot Nothing Then
            tipoUsuario = CType(ComboBoxTipoUsuario.SelectedItem, TiposDeUsuario.TipoDeUsuario).idTipoUsuario
        Else
            MessageBox.Show("Por favor, seleccione un tipo de usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Return
        End If

        Try
            _controladorUsuarios.AgregarUno(apellido, nombre, dni, telefono, correo, nombreusuario, contrasenia, tipoUsuario)

            TBApellido.Clear()
            tNombre.Clear()
            TBDNI.Clear()
            TBCorreo.Clear()
            TBTelefono.Clear()
            tUsuario.Clear()
            tContrasena.Clear()
            ComboBoxTipoUsuario.SelectedIndex = -1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
