Imports TP_Integrador.Equipos
Public Class Revisiones

    Class Revision
        Public Property Equipo As Equipo
        Public Property Observaciones As String

    End Class


    Public Shared Function RevisarEquipo(equipo As Equipo, nuevoEstado As Integer)
        Dim conexion = New BaseDeDatos().obtenerConexion()

        Try
            Equipos.ModificarEstadoEquipo(equipo.IDEquipo, nuevoEstado)
            MessageBox.Show("Revisión comenzada correctamente", "Confirmación de revisión", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al comenzar la revisión: " & ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try

    End Function

    Public Shared Function FinalizarRevision(revision As Revision, nuevoEstado As Integer)
        Dim conexion = New BaseDeDatos().obtenerConexion()

        Try
            ' Modifica la consulta para incluir "VALUES" correctamente
            Dim comando = New SqlCommand("INSERT INTO Revisiones (idEquipo, observaciones, fechaDeFinalizacion) VALUES (@idEquipo, @observaciones, @fechaDeFinalizacion)", conexion)

            comando.Parameters.AddWithValue("@idEquipo", revision.Equipo.IDEquipo)
            comando.Parameters.AddWithValue("@observaciones", revision.Observaciones)
            comando.Parameters.AddWithValue("@fechaDeFinalizacion", DateTime.Now)

            ' Abre la conexión antes de ejecutar el comando
            conexion.Open()

            ' Ejecuta el comando
            comando.ExecuteNonQuery()

            ' Cambia el estado del equipo después de insertar la revisión
            Equipos.ModificarEstadoEquipo(revision.Equipo.IDEquipo, nuevoEstado)
            MessageBox.Show("Revisión finalizada correctamente", "Confirmación de revisión", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al finalizar la revisión: " & ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    Public Shared Function obtenerRevisionPorID(IDEquipo As Integer)

        Dim conexion = New BaseDeDatos().obtenerConexion()

        Dim revision As Revision = Nothing

        Try

            Dim comando = New SqlCommand("SELECT * FROM Revisiones WHERE idEquipo = @idEquipo", conexion)
            comando.Parameters.AddWithValue("@idEquipo", IDEquipo)

            conexion.Open()
            Dim reader As SqlDataReader = comando.ExecuteReader()

            If reader.Read() Then
                revision = New Revision()

                ' Verifica que 'Equipo' tenga una instancia antes de asignarle el valor
                revision.Equipo = New Equipos.Equipo() ' Crea una instancia de Equipos.Equipo

                revision.Equipo.IDEquipo = reader("idEquipo") ' Asigna el valor al campo IDEquipo
                revision.Observaciones = reader("observaciones").ToString()
                ' Agrega otros campos de la revisión si es necesario
            End If


        Catch ex As Exception
            MessageBox.Show("Error al obtener la revisión: " & ex.Message)
        Finally
            conexion.Close()
        End Try

        Return revision
    End Function

    Public Shared Function obtenerRevisionStringPorID(IDEquipo As Integer) As String

        Dim conexion = New BaseDeDatos().obtenerConexion()

        Dim revision As Revision = Nothing
        Dim observaciones As String = Nothing

        Try

            Dim comando = New SqlCommand("SELECT * FROM Revisiones WHERE idEquipo = @idEquipo", conexion)
            comando.Parameters.AddWithValue("@idEquipo", IDEquipo)

            conexion.Open()
            Dim reader As SqlDataReader = comando.ExecuteReader()

            If reader.Read() Then
                revision = New Revision()


                revision.Equipo = New Equipos.Equipo()

                revision.Equipo.IDEquipo = reader("idEquipo")
                revision.Observaciones = reader("observaciones").ToString()
                observaciones = revision.Observaciones

            End If


        Catch ex As Exception
            MessageBox.Show("Error al traer la revisión: " & ex.Message)
        Finally
            conexion.Close()
        End Try

        Return observaciones
    End Function


End Class

