Public Class ControladorTiposDeEquipo
    Private tiposDeEquipo As TiposDeEquipo = TiposDeEquipo.ObtenerInstancia()

    Public Function ObtenerTodos() As List(Of TiposDeEquipo.TipoDeEquipo)
        Try
            Return TiposDeEquipo.ObtenerTiposDeEquipo()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
