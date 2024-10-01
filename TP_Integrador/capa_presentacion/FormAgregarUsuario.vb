Partial Public Class FormAgregarUsuario
    Private Sub FormAgregarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setTiposDeUsuario()
    End Sub

    Private Sub setTiposDeUsuario()
        ComboBoxTipoUsuario.Items.Add("Administrador")
        ComboBoxTipoUsuario.Items.Add("Tecnico")
    End Sub
End Class