Public Class FormInfoReparacion
    Private Reparacion As Reparaciones.Reparacion
    Public Sub New(reparacion As Reparaciones.Reparacion)


        InitializeComponent()

        Me.Reparacion = reparacion
        TBObservaciones.ReadOnly = True
        TBObservaciones.TabStop = True

    End Sub

    Private Sub FormInfoReparacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TBObservaciones.Text = Reparacion.observaciones
    End Sub
End Class