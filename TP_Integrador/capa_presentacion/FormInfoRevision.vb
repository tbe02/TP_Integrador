Imports System.Runtime.InteropServices

Public Class FormInfoRevision

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


    Private Revision As Revisiones.Revision

    Public Sub New(revision As Revisiones.Revision)


        InitializeComponent()
        Me.Revision = revision
        TBObservaciones.ReadOnly = True
        TBObservaciones.TabStop = False

    End Sub

    Private Sub FormInfoRevision_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TBObservaciones.Text = Revision.Observaciones

    End Sub

    Private Sub IBCerrar_Click(sender As Object, e As EventArgs) Handles IBCerrar.Click
        Me.Close()
    End Sub

    Private Sub PBordeSuperior_MouseDown(sender As Object, e As MouseEventArgs) Handles PBordeSuperior.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
        End If
    End Sub

End Class
