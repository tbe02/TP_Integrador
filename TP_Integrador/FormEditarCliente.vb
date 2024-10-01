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
    Public Sub New(cliente As Cliente, alFinalizar As Action)
        ' Esta llamada es necesaria para el diseñador.
        InitializeComponent()

        ' Asigna el cliente al formulario
        Me.ClienteActual = cliente
        Me.alFinalizar = alFinalizar
    End Sub

    'le decimos que cargue la info del cliente a los textboxs
    Private Sub FormEditarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TBApellido.Text = ClienteActual.Apellido

        TBNombre.Text = ClienteActual.Nombre

        TBDNI.Text = ClienteActual.Dni

        TBCorreo.Text = ClienteActual.Correo

        TBTelefono.Text = ClienteActual.Telefono

        ComboBoxEstado.Text = ClienteActual.Estado

        ComboBoxEstado.Items.Add("inactivo")
        ComboBoxEstado.Items.Add("activo")
    End Sub

    'le decimos que guarde los cambios que le hicimos al cliente
    Private Sub BEditarCliente_Click(sender As Object, e As EventArgs) Handles BEditarCliente.Click

        ClienteActual.editarCliente(TBDNI.Text, New Cliente With {
            .Apellido = TBApellido.Text,
            .Nombre = TBNombre.Text,
            .Dni = TBDNI.Text,
            .Correo = TBCorreo.Text,
            .Telefono = TBTelefono.Text,
            .Estado = ComboBoxEstado.Text
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

    Private Sub IBCerrar_Click(sender As Object, e As EventArgs) Handles IBCerrar_EC.Click
        Close()
    End Sub

    Private Sub IBMinimizar_Click(sender As Object, e As EventArgs) Handles IBMinimizar_EC.Click
        WindowState = FormWindowState.Minimized
    End Sub

End Class