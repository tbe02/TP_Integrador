Imports System.Runtime.InteropServices 'Permite funcionalidades de API de Windows para poder trabajar con la funcion releaseCapture'
Imports TP_Integrador

Public Class FormLogin

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

    Private Sub BIniciarSesion_Click(sender As Object, e As EventArgs) Handles BIniciarSesion.Click
        Dim autenticador As New Autenticacion

        autenticador.autenticarLogin(TBUsuario.Text, TBContrasena.Text)
    End Sub


    Private Sub PBCerrar_Click(sender As Object, e As EventArgs) Handles PBCerrar.Click
        Me.Close()
    End Sub

    Private Sub PBMinimizar_Click(sender As Object, e As EventArgs) Handles PBMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'Funcion que permite poder mover desde la barra de titulo el formulario'
    Private Sub BarraTitulo_MouseDown(sender As Object, e As MouseEventArgs) Handles BarraTitulo.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
        End If
    End Sub

End Class

