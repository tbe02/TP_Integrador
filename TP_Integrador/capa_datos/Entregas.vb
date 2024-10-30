Imports TP_Integrador.Presupuestos
Imports TP_Integrador.Reparaciones
Public Class Entregas

    Class Entrega
        Public Property Reparacion As Reparacion
        Public Property fecha As Date
    End Class

    Public Shared Function agregarEntrega(entrega As Entrega, nuevoEstado As Integer) As Boolean
        Dim conexion = New BaseDeDatos().obtenerConexion()


        Try
            Dim comando = New SqlCommand("INSERT INTO Entregas(idReparacion, fecha) VALUES (@idReparacion, @fecha)", conexion)
            comando.Parameters.AddWithValue("@idReparacion", entrega.Reparacion.Presupuesto.IdPresupuesto) ' Asegúrate de que esto sea correcto
            comando.Parameters.AddWithValue("@fecha", DateTime.Now)

            conexion.Open()
            comando.ExecuteNonQuery()

            Equipos.ModificarEstadoEquipo(entrega.Reparacion.Presupuesto.Revision.Equipo.IDEquipo, nuevoEstado)
            Equipos.darDeBajaEquipo(entrega.Reparacion.Presupuesto.Revision.Equipo.IDEquipo)

            MessageBox.Show("Entrega agregada correctamente", "Presupuesto agregado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al insertar la entrega: " & ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function


End Class
