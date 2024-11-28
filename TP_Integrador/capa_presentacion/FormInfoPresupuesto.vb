Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window

Public Class FormInfoPresupuesto


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


    Private Presupuesto As Presupuestos.Presupuesto
    Public Sub New(presupuesto As Presupuestos.Presupuesto)


        InitializeComponent()

        Me.Presupuesto = presupuesto

        TBDetalles.ReadOnly = True
        TBDetalles.TabStop = False
        TBMonto.ReadOnly = True
        TBMonto.TabStop = False
    End Sub

    Private Sub FormInfoPresupuesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TBDetalles.Text = Presupuesto.Detalles
        TBMonto.Text = Presupuesto.Monto
    End Sub


    Private Sub PBordeSuperior_MouseDown(sender As Object, e As MouseEventArgs) Handles PBordeSuperior.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
        End If
    End Sub

    Private Sub IBCerrar_Click(sender As Object, e As EventArgs) Handles IBCerrar.Click
        Me.Close()
    End Sub
End Class
