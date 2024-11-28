Public Class ControladorMetodosPago
    Private metodosPago As MetodosPago = MetodosPago.ObtenerInstancia()

    Public Function ObtenerTodos() As List(Of MetodosPago.MetodoPago)
        Try
            Return metodosPago.ObtenerMetodosPago()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class

