Public Class FormCargarPresupuesto

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
                Me.Close()
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
End Class