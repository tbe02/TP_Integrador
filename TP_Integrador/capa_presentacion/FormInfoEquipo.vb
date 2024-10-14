Imports System.Runtime.InteropServices

Public Class FormInfoEquipo
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

    Dim equipo As Equipos.Equipo

    Public Sub New(equipo As Equipos.Equipo)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.equipo = equipo

        InicializarCampos()
    End Sub

    Private Sub InicializarCampos()
        TBRazonIngreso.Text = equipo.RazonIngreso
        TBObservaciones.Text = equipo.Observaciones
    End Sub

    Private Sub PMenuSuperior_MouseDown(sender As Object, e As MouseEventArgs) Handles PMenuSuperior.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
        End If
    End Sub


    Private Sub IBCerrar_Click(sender As Object, e As EventArgs) Handles IBCerrar.Click
        Close()
    End Sub

    Private Sub IBMinimizar_Click(sender As Object, e As EventArgs) Handles IBMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

End Class