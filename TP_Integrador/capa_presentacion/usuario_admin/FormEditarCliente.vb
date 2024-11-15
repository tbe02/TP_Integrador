Imports System.Runtime.InteropServices 'Permite funcionalidades de API de Windows para poder trabajar con la funcion releaseCapture'

Public Class FormEditarCliente
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

    Private ClienteActual As Cliente
    Private alFinalizar As Action

    ' constructor que reciba un cliente
    Public Sub New(clienteActual As Cliente, alFinalizar As Action)
        ' Esta llamada es necesaria para el diseñador.
        InitializeComponent()
        SetEstados()

        ' Asigna el cliente al formulario
        Me.ClienteActual = clienteActual
        Me.alFinalizar = alFinalizar
    End Sub

    Private Sub SetEstados()
        ComboBoxEstado.Items.Add("inactivo")
        ComboBoxEstado.Items.Add("activo")
    End Sub

    'le decimos que cargue la info del cliente a los textboxs
    Private Sub FormEditarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TBApellido.Text = ClienteActual.Apellido
        TBNombre.Text = ClienteActual.Nombre
        TBDNI.Text = ClienteActual.Dni
        TBCorreo.Text = ClienteActual.Correo
        TBTelefono.Text = ClienteActual.Telefono
        ComboBoxEstado.Text = ClienteActual.Estado
    End Sub

    'le decimos que guarde los cambios que le hicimos al cliente
    Private Sub BEditarCliente_Click(sender As Object, e As EventArgs) Handles BEditarCliente.Click
        Dim apellido = TBApellido.Text
        Dim nombre = TBNombre.Text
        Dim DNI = TBDNI.Text
        Dim correo = TBCorreo.Text
        Dim telefono = TBTelefono.Text
        Dim estado = ComboBoxEstado.Text

        If apellido = "" Or nombre = "" Or DNI = "" Or correo = "" Or telefono = "" Or estado = "" Then
            MessageBox.Show("Por favor complete los campos", "Editar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return
        End If

        ClienteActual.editarCliente(ClienteActual.Dni, New Cliente With {
            .Apellido = apellido,
            .Nombre = nombre,
            .Dni = DNI,
            .Correo = correo,
            .Telefono = telefono,
            .Estado = estado
        })

        Me.alFinalizar()
        Me.Close()
    End Sub

    Private Sub PMenuSuperior_MouseDown(sender As Object, e As MouseEventArgs) Handles PMenuSuperior.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
        End If
    End Sub

    Private Sub IBMinimizar_Click(sender As Object, e As EventArgs) Handles IBMinimizar_EC.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub IBCerrar_Click(sender As Object, e As EventArgs) Handles IBCerrar.Click
        Me.Close()
    End Sub
End Class
