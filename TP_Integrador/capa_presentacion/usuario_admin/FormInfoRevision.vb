Public Class FormInfoRevision
    Private Revision As Revisiones.Revision

    Public Sub New(revision As Revisiones.Revision)


        InitializeComponent()
        Me.Revision = revision
        TBObservaciones.ReadOnly = True
        TBObservaciones.TabStop = False

    End Sub

    Private Sub FormInfoRevision_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TBObservaciones.Text = Revision.Observaciones

    End Sub
End Class