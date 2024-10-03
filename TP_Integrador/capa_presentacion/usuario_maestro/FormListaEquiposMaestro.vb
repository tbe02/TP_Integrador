Public Class FormListaEquiposMaestro
    Private Sub FormListaEquiposMaestro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DGVListaEquipos.Rows.Add("Theo", "Impresora", "2477", "hp", "si")
        DGVListaEquipos.Rows.Add("Fran", "Computadora", "4325", "Mac", "no")
        DGVListaEquipos.AllowUserToAddRows = False

    End Sub
End Class