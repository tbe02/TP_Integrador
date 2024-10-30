Public Class FormInfoPresupuesto
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
End Class