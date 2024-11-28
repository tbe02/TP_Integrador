Public Class ControladorModelos
    Private modelos As Modelos = Modelos.ObtenerInstancia()

    Public Function ObtenerTodos() As List(Of Modelos.Modelo)
        Try
            Return modelos.ObtenerModelos()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
