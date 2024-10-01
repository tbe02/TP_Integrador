﻿Imports System.Runtime.InteropServices 'Permite funcionalidades de API de Windows para poder trabajar con la funcion releaseCapture'
Imports TP_Integrador
Imports TP_Integrador.Autenticacion

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
        Dim autenticador As New Autenticador

        Dim usuario, password As String

        usuario = TBUsuario.Text
        password = TBContrasena.Text

        If (usuario = "" Or password = "") Then
            MessageBox.Show("Debe completar todos los campos", "Falta de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If autenticador.autenticarUsuario(usuario, password) Then
                MessageBox.Show("Ingreso exitoso", "Ingreso de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Dim usuarioAutenticado = autenticador.obtenerUsuarioAutenticado(usuario, password)

                If usuarioAutenticado.tipo = "maestro" Then
                    Dim menu = New modelo_menu_user_maestro()

                    menu.Show()

                    Me.Hide()
                ElseIf usuarioAutenticado.tipo = "tecnico" Then
                    Dim menu = New modelo_menu_user_tecnico()

                    menu.Show()

                    Me.Hide()
                ElseIf usuarioAutenticado.tipo = "administrador" Then
                    Dim menu = New modelo_menu_principal()

                    menu.Show()

                    Me.Hide()
                Else
                    MessageBox.Show("Tipo de usuario no encontrado", "Ingreso de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Else
                MessageBox.Show("Ingreso fallido", "Ingreso de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If


    End Sub


    Private Sub PBCerrar_Click(sender As Object, e As EventArgs) Handles PBCerrar.Click
        End
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

