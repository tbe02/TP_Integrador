Imports TP_Integrador.Equipos
Imports TP_Integrador.Presupuestos
Imports TP_Integrador.Revisiones

Public Class Reparaciones
    Class Reparacion
        Public Property Presupuesto As Presupuesto
        Public Property reparado As Boolean?
        Public Property observaciones As String

    End Class


    Public Shared Function agregarReparacion(reparacion As Reparacion, nuevoEstado As Integer, reparacionExitosa As Boolean?)
        Dim conexion = New BaseDeDatos().obtenerConexion()


        Try
            Dim comando = New SqlCommand("INSERT INTO Reparaciones (idPresupuesto, reparado, observaciones) VALUES (@idPresupuesto, @reparado, @observaciones)", conexion)
            comando.Parameters.AddWithValue("@idPresupuesto", reparacion.Presupuesto.IdPresupuesto)
            If reparacionExitosa Is Nothing Then
                comando.Parameters.AddWithValue("@reparado", DBNull.Value)
            Else
                comando.Parameters.AddWithValue("@reparado", reparacionExitosa)
            End If

            comando.Parameters.AddWithValue("@observaciones", reparacion.observaciones)

            conexion.Open()

            comando.ExecuteNonQuery()


            Equipos.ModificarEstadoEquipo(reparacion.Presupuesto.Revision.Equipo.IDEquipo, nuevoEstado)
            MessageBox.Show("Reparacion finalizada correctamente", "Confirmación de reparacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al finalizar la reparacion: " & ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try

    End Function


    Public Shared Function RepararEquipo(equipo As Equipo, nuevoEstado As Integer)
        Dim conexion = New BaseDeDatos().obtenerConexion()

        Try
            Equipos.ModificarEstadoEquipo(equipo.IDEquipo, nuevoEstado)
            MessageBox.Show("Equipo comenzado a reparar correctamente", "Comienzo de reparación exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al comenzar la reparacion: " & ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try

    End Function

    Public Shared Function obtenerReparacionPorID(IDEquipo As Integer)

        Dim conexion = New BaseDeDatos().obtenerConexion()

        Dim reparacion As Reparacion = Nothing

        Try

            Dim comando = New SqlCommand("SELECT * FROM Reparaciones r JOIN Presupuestos p ON r.idPresupuesto = p.idPresupuesto AND p.idRevision = @idEquipo", conexion)
            comando.Parameters.AddWithValue("@idEquipo", IDEquipo)

            conexion.Open()
            Dim reader As SqlDataReader = comando.ExecuteReader()

            If reader.Read() Then
                reparacion = New Reparacion()
                If Not reader("reparado") Is DBNull.Value Then
                    reparacion.reparado = Convert.ToBoolean(reader("reparado"))
                Else
                    reparacion.reparado = Nothing ' O lo que consideres adecuado en caso de que sea DBNull
                End If
                reparacion.observaciones = reader("observaciones").ToString()
                reparacion.Presupuesto = New Presupuestos.Presupuesto()
                reparacion.Presupuesto.IdPresupuesto = Convert.ToInt32(reader("idPresupuesto")) ' Añade esta línea
                reparacion.Presupuesto.Revision = New Revisiones.Revision()
                reparacion.Presupuesto.Revision.Equipo = New Equipos.Equipo()
                reparacion.Presupuesto.Revision.Equipo.IDEquipo = reader("idRevision")

            End If


        Catch ex As Exception
            MessageBox.Show("Error al obtener la reparación por ID: " & ex.Message)
        Finally
            conexion.Close()
        End Try

        Return reparacion
    End Function

    Public Shared Function reparacionAprobada(IDEquipo As Integer) As Boolean
        Dim conexion = New BaseDeDatos().obtenerConexion()

        Try
            Dim comando = New SqlCommand("SELECT * FROM Reparaciones r JOIN Presupuestos p ON r.idPresupuesto = p.idPresupuesto WHERE p.aprobado = 1 AND p.idRevision = @idEquipo", conexion)
            comando.Parameters.AddWithValue("@idEquipo", IDEquipo)

            conexion.Open()
            Dim reader As SqlDataReader = comando.ExecuteReader()

            If reader.Read() Then
                ' Aquí se encontró una reparación aprobada
                Return True
            Else
                ' No se encontró ninguna reparación aprobada
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Error al obtener la reparación: " & ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function


End Class
