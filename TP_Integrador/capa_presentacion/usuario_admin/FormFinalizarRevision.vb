﻿Imports System.Net
Imports System.Runtime.InteropServices
Imports System.Runtime.InteropServices.JavaScript.JSType
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window

Public Class FormFinalizarRevision

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



    Private Equipo As Equipos.Equipo

    Public Sub New(equipo As Equipos.Equipo)


        InitializeComponent()
        Me.Equipo = equipo


    End Sub

    Private Sub BCargarObservaciones_Click(sender As Object, e As EventArgs) Handles BCargarObservaciones.Click
        Dim revision As New Revisiones.Revision()

        If verificacion(TBObservaciones.Text) Then
            revision.Observaciones = TBObservaciones.Text
            revision.Equipo = Equipo

            If Revisiones.FinalizarRevision(revision, 3) Then
                Me.Close()
            End If

        End If

    End Sub
    Private Function verificacion(observacion As String)
        If (observacion = "") Then
            MessageBox.Show("Debe completar todos los campos", "Falta de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

    Private Sub PBordeSuperior_MouseDown(sender As Object, e As MouseEventArgs) Handles PBordeSuperior.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
        End If
    End Sub

End Class