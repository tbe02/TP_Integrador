Public Class FormEditarCliente

    Private ClienteActual As Cliente

    ' constructor que reciba un cliente
    Public Sub New(cliente As Cliente)
        ' Esta llamada es necesaria para el diseñador.
        InitializeComponent()

        ' Asigna el cliente al formulario
        Me.ClienteActual = cliente
    End Sub

    'le decimos que cargue la info del cliente a los textboxs
    Private Sub FormEditarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TBApellido.Text = ClienteActual.Apellido

        TBNombre.Text = ClienteActual.Nombre

        TBDNI.Text = ClienteActual.Dni

        TBCorreo.Text = ClienteActual.Correo

        TBTelefono.Text = ClienteActual.Telefono
    End Sub

    'le decimos que guarde los cambios que le hicimos al cliente
    Private Sub BEditarCliente_Click(sender As Object, e As EventArgs) Handles BEditarCliente.Click

        ClienteActual.Apellido = TBApellido.Text
        ClienteActual.Nombre = TBNombre.Text
        ClienteActual.Dni = TBDNI.Text
        ClienteActual.Correo = TBCorreo.Text
        ClienteActual.Telefono = TBTelefono.Text


        Me.Close()

    End Sub


End Class