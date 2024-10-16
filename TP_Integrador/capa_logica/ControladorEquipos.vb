Public Class ControladorEquipos
    Private equipos As Equipos = Equipos.ObtenerInstancia()

    Public Sub AgregarUno(equipo As Equipos.Equipo)
        Try
            equipos.Agregar(equipo)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function ObtenerTodos() As List(Of Equipos.Equipo)
        Try
            Return equipos.ObtenerTodos()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Sub ActualizarUnoPorId(id As Integer, actualizado As Equipos.Equipo)
        Try
            equipos.editarEquipo(id, actualizado)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub EliminarUnoPorId(id As Integer)
        Try
            equipos.eliminar(New Equipos.Equipo With {.IDEquipo = id})
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class
