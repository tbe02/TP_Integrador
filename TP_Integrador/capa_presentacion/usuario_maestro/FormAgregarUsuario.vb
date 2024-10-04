Partial Public Class FormAgregarUsuario
    Private Sub FormAgregarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setTiposDeUsuario()
    End Sub

    Private Sub setTiposDeUsuario()
        ComboBoxTipoUsuario.Items.Add("administrador")
        ComboBoxTipoUsuario.Items.Add("tecnico")
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
            tipoUsuario = ComboBoxTipoUsuario.SelectedItem.ToString()
        Else
            MessageBox.Show("Por favor, seleccione un tipo de usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Return
        End If

        Dim usuarios As Usuarios = Usuarios.ObtenerInstancia()

        If usuarios.agregarUsuario(apellido, nombre, dni, telefono, correo, nombreusuario, contrasenia, tipoUsuario) Then
            TBApellido.Clear()
            tNombre.Clear()
            TBDNI.Clear()
            TBCorreo.Clear()
            TBTelefono.Clear()
            tUsuario.Clear()
            tContrasena.Clear()
            ComboBoxTipoUsuario.SelectedIndex = -1
        End If
    End Sub


End Class