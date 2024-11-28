Public Class ControladorEstadisticas
    Private _estadisticas As Estadisticas = New Estadisticas()

    Public Function ObtenerIngresosPorSemana(fechaInicio As String, fechaFin As String) As List(Of Estadisticas.VariacionSemanal)
        Try
            Return _estadisticas.ObtenerIngresosPorSemana(fechaInicio, fechaFin)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ObtenerFechaPrimerIngreso() As String
        Try
            Return _estadisticas.ObtenerFechaPrimerIngreso()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ObtenerRevisionesPorSemana(fechaInicio As String, fechaFin As String) As List(Of Estadisticas.VariacionSemanal)
        Try
            Return _estadisticas.ObtenerRevisionesPorSemana(fechaInicio, fechaFin)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ObtenerReparacionesPorSemana(fechaInicio As String, fechaFin As String) As List(Of Estadisticas.VariacionSemanal)
        Try
            Return _estadisticas.ObtenerReparacionesPorSemana(fechaInicio, fechaFin)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ObtenerEntregasPorSemana(fechaInicio As String, fechaFin As String) As List(Of Estadisticas.VariacionSemanal)
        Try
            Return _estadisticas.ObtenerEntregasPorSemana(fechaInicio, fechaFin)
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

    Public Function ObtenerFacturacionPorSemana(fechaInicio As String, fechaFin As String) As List(Of Estadisticas.VariacionSemanal)
        Try
            Return _estadisticas.ObtenerFacturacionPorSemana(fechaInicio, fechaFin)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
