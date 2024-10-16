Partial Public Class FormAgregarUsuario
    Private _controladorUsuarios As ControladorUsuarios = New ControladorUsuarios()

    Private Sub FormAgregarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetTiposDeUsuario()
    End Sub

    Private Sub SetTiposDeUsuario()
        Dim todosLosTiposDeUsuario As List(Of TiposDeUsuario.TipoDeUsuario) = TiposDeUsuario.ObtenerInstancia().ObtenerTodos()

        ComboBoxTipoUsuario.DisplayMember = "Key"
        ComboBoxTipoUsuario.ValueMember = "Value"

        For Each tipoDeUsuario In todosLosTiposDeUsuario
            ComboBoxTipoUsuario.Items.Add(New DictionaryEntry(tipoDeUsuario.nombre, tipoDeUsuario.idTipoUsuario))
        Next
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
            tipoUsuario = ComboBoxTipoUsuario.SelectedItem.Value.ToString()
        Else
            MessageBox.Show("Por favor, seleccione un tipo de usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Return
        End If

        Dim usuarios = _controladorUsuarios.ObtenerTodos()

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
