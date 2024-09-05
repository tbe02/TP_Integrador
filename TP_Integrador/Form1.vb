﻿Imports System.Runtime.InteropServices 'Permite funcionalidades de API de Windows para poder trabajar con la funcion releaseCapture'

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

    Public Structure Usuario
        Public Nombre As String
        Public Contrasena As String
    End Structure

    Dim usuarios As New List(Of Usuario)

    Sub AgregarUsuarios()
        usuarios.Add(New Usuario With {.Nombre = "admin", .Contrasena = "admin"})
        ' Puedes agregar más usuarios aquí
    End Sub

    Function VerificarPassword(nombre As String, password As String) As Boolean
        For Each usuario In usuarios
            If usuario.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase) Then
                Return usuario.Contrasena.Equals(password)
            End If
        Next
        Return False

    End Function

    Private Sub BIniciarSesion_Click(sender As Object, e As EventArgs) Handles BIniciarSesion.Click
        AgregarUsuarios()

        Dim usuario As String
        Dim password As String

        usuario = TBUsuario.Text 'Aca va el nombre del TextBox de usuario {nombreTextBox}.Text
        password = TBContrasena.Text 'Aca va el nombre del TextBox de password {nombreTextBox}.Text

        If (usuario = "" Or password = "") Then
            MessageBox.Show("Debe completar todos los campos.", "Falta de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If VerificarPassword(usuario, password) Then
                MessageBox.Show("Ingreso exitoso", "Ingreso de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Ingreso fallido", "Ingreso de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
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

