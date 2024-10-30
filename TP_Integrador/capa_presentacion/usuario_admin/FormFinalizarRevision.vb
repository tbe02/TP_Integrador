Imports System.Net
Imports System.Runtime.InteropServices.JavaScript.JSType

Public Class FormFinalizarRevision

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
End Class