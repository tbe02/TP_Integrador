Public Class FormReparacionEquipo
    Private Presupuesto As Presupuestos.Presupuesto
    Private Reparable As Integer
    Public Sub New(presupuesto As Presupuestos.Presupuesto, reparable As Integer)


        InitializeComponent()
        Me.Presupuesto = presupuesto
        Me.Reparable = reparable


    End Sub

    Private Sub BCargarObservacion_Click(sender As Object, e As EventArgs) Handles BCargarObservacion.Click
        Dim reparacion As New Reparaciones.Reparacion
        If verificacion(TBObservaciones.Text) Then
            reparacion.observaciones = TBObservaciones.Text
            reparacion.reparado = 0
            reparacion.Presupuesto = Presupuesto
            If Reparaciones.agregarReparacion(reparacion, 13, Reparable) Then
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