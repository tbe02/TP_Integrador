Imports System.Runtime.InteropServices

Public Class FormCargarPresupuesto

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

    End Sub

    Private Sub BCargarPresupuesto_Click(sender As Object, e As EventArgs) Handles BCargarPresupuesto.Click
        Dim presupuesto As New Presupuestos.Presupuesto

        If verificacion(TBDetalles.Text, Convert.ToDouble(TBMonto.Text)) Then

            presupuesto.Detalles = TBDetalles.Text

            presupuesto.Monto = Convert.ToDouble(TBMonto.Text)

            presupuesto.Aprobado = Nothing

            presupuesto.Revision = Revision



            If Presupuestos.agregarPresupuesto(presupuesto, 10) Then
                Close()
            End If

        End If


    End Sub



    Private Function verificacion(detalles As String, monto As Double)

        Dim numero As Double

        If (detalles = "") Then
            MessageBox.Show("Debe completar todos los campos", "Falta de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If Not Double.TryParse(monto, numero) Then

            MessageBox.Show("Solo se aceptan numeros", "Error de tipeo", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
