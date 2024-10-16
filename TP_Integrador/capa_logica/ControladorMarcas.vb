Public Class ControladorMarcas
    Private marcas As Marcas = Marcas.ObtenerInstancia()

    Public Function ObtenerTodas() As List(Of Marcas.Marca)
        Try
            Return Marcas.ObtenerMarcas()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
