Public Class ControladorEstadisticas
    Private _estadisticas As Estadisticas = New Estadisticas()

    Public Function ObtenerIngresosPorSemana() As List(Of Estadisticas.VariacionSemanal)
        Try
            Return _estadisticas.ObtenerIngresosPorSemana()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ObtenerRevisionesPorSemana() As List(Of Estadisticas.VariacionSemanal)
        Try
            Return _estadisticas.ObtenerRevisionesPorSemana()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ObtenerReparacionesPorSemana() As List(Of Estadisticas.VariacionSemanal)
        Try
            Return _estadisticas.ObtenerReparacionesPorSemana()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ObtenerEntregasPorSemana() As List(Of Estadisticas.VariacionSemanal)
        Try
            Return _estadisticas.ObtenerEntregasPorSemana()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ObtenerEquiposPorEstado() As List(Of Estadisticas.CantidadPorEstado)
        Try
            Return _estadisticas.ObtenerEquiposPorEstado()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ObtenerFacturacionPorSemana() As List(Of Estadisticas.VariacionSemanal)
        Try
            Return _estadisticas.ObtenerFacturacionPorSemana()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
