Public Class ControladorTiposDeUsuario
    Private tiposDeUsuario As TiposDeUsuario = TiposDeUsuario.ObtenerInstancia()

    Public Function ObtenerTodos() As List(Of TiposDeUsuario.TipoDeUsuario)
        Try
            Return tiposDeUsuario.ObtenerTodos()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
