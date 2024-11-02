Imports System.Runtime.InteropServices
Imports TP_Integrador.Equipos
Imports TP_Integrador.Marcas
Imports TP_Integrador.MetodosPago

Public Class FormDevolverEquipo

    Private Reparacion As Reparaciones.Reparacion
    Private _controladorMetodosPago As ControladorMetodosPago = New ControladorMetodosPago()


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


    Public Sub New(reparacion As Reparaciones.Reparacion)


        InitializeComponent()
        Me.Reparacion = reparacion


    End Sub



    Private Sub FormDevolverEquipo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarMetodosPago()
    End Sub


    Private Sub ListarMetodosPago()
        Dim metodosPago = _controladorMetodosPago.ObtenerTodos()

        ComboBMetodosPago.DataSource = metodosPago
        ComboBMetodosPago.DisplayMember = "nombre"
        ComboBMetodosPago.ValueMember = "id"
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

    Private Sub BAgregarMetodoPago_Click(sender As Object, e As EventArgs) Handles BAgregarMetodoPago.Click
        Dim entrega As New Entregas.Entrega
        entrega.Reparacion = Reparacion
        entrega.metodoPago = CType(ComboBMetodosPago.SelectedItem, MetodoPago)

        If Entregas.agregarEntrega(entrega, 14) Then
            Me.Close()
        End If
    End Sub
End Class
