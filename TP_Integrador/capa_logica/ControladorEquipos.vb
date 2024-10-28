Public Class ControladorEquipos
    Private _equipos As Equipos = Equipos.ObtenerInstancia()

    Public Sub AgregarUno(equipo As Equipos.Equipo)
        Try
            _equipos.Agregar(equipo)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function ObtenerTodos() As List(Of Equipos.Equipo)
        Try
            Return _equipos.ObtenerTodos()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Sub ActualizarUnoPorId(id As Integer, actualizado As Equipos.Equipo)
        Try
            _equipos.editarEquipo(id, actualizado)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub EliminarUnoPorId(id As Integer)
        Try
            _equipos.eliminar(New Equipos.Equipo With {.IDEquipo = id})
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Shared Function ObtenerlosCamposSonValidos(idCliente As Integer, idTipoEquipo As Integer, numeroSerie As String, idMarca As Integer, idModelo As Integer, razon As String, observacion As String, enciende As String, estado As String)
        If (IsNothing(idCliente) OrElse idCliente = 0 OrElse
           IsNothing(idTipoEquipo) OrElse idTipoEquipo = 0 OrElse
           String.IsNullOrWhiteSpace(numeroSerie) OrElse
           IsNothing(idMarca) OrElse idMarca = 0 OrElse
           IsNothing(idModelo) OrElse idModelo = 0 OrElse
           String.IsNullOrWhiteSpace(razon) OrElse
           String.IsNullOrWhiteSpace(observacion) OrElse
           String.IsNullOrWhiteSpace(enciende) OrElse
           String.IsNullOrWhiteSpace(estado)) Then
            MessageBox.Show("Debe completar todos los campos", "Falta de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return False
        End If

        Return True
    End Function
End Class
