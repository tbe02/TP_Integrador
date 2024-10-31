Imports System.Runtime.InteropServices

Public Class FormAgregarModelo


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
    Private Sub BAgregarModelo_Click(sender As Object, e As EventArgs) Handles BAgregarModelo.Click
        Dim modelo As New Modelos.Modelo
        If (verificacion(TBAgregarModelo.Text)) Then
            modelo.nombre = TBAgregarModelo.Text

            If Modelos.agregarModelo(modelo) Then
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

    Private Sub IBCerrar_Click(sender As Object, e As EventArgs) Handles IBCerrar.Click
        Me.Close()
    End Sub
End Class
