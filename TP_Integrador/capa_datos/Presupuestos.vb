Imports TP_Integrador.Revisiones
Public Class Presupuestos


    Class Presupuesto
        Public Property IdPresupuesto As Integer
        Public Property Detalles As String
        Public Property Monto As Double
        Public Property Aprobado As Boolean?
        Public Property Revision As Revision

    End Class


    Public Shared Function agregarPresupuesto(presupuesto As Presupuesto, nuevoEstado As Integer)



        Dim conexion = New BaseDeDatos().obtenerConexion()

        Try

            Dim comando = New SqlCommand("INSERT INTO Presupuestos (detalles, monto, aprobado, idRevision) VALUES (@detalles, @monto, @aprobado, @idRevision)", conexion)


            comando.Parameters.AddWithValue("@detalles", presupuesto.Detalles)
            comando.Parameters.AddWithValue("@monto", presupuesto.Monto)

            ' Verificar si presupuesto.Aprobado es Nothing, y si es así, establecer DBNull.Value
            If presupuesto.Aprobado Is Nothing Then
                comando.Parameters.AddWithValue("@aprobado", DBNull.Value)
            Else
                comando.Parameters.AddWithValue("@aprobado", presupuesto.Aprobado)
            End If
            comando.Parameters.AddWithValue("@idRevision", presupuesto.Revision.Equipo.IDEquipo)



            conexion.Open()


            comando.ExecuteNonQuery()


            Equipos.ModificarEstadoEquipo(presupuesto.Revision.Equipo.IDEquipo, nuevoEstado)
            MessageBox.Show("Presupuesto agregado correctamente", "Presupuesto agregado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al insertar el presupuesto: " & ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function


    Public Shared Function obtenerPresupuestoPorID(IDEquipo As Integer)

        Dim conexion = New BaseDeDatos().obtenerConexion()

        Dim presupuesto As Presupuesto = Nothing

        Try

            Dim comando = New SqlCommand("SELECT * FROM Presupuestos WHERE idRevision = @idRevision", conexion)
            comando.Parameters.AddWithValue("@idRevision", IDEquipo)

            conexion.Open()
            Dim reader As SqlDataReader = comando.ExecuteReader()

            If reader.Read() Then
                presupuesto = New Presupuesto()

                presupuesto.IdPresupuesto = reader("idPresupuesto") ' Asegúrate de que 'idPresupuesto' sea una columna en 'Presupuestos'
                presupuesto.Revision = New Revisiones.Revision()
                presupuesto.Revision.Equipo = New Equipos.Equipo()


                presupuesto.Revision.Equipo.IDEquipo = reader("idRevision")
                presupuesto.Detalles = reader("detalles").ToString()
                presupuesto.Monto = reader("monto").ToString()

            End If


        Catch ex As Exception
            MessageBox.Show("Error al obtener la revisión: " & ex.Message)
        Finally
            conexion.Close()
        End Try

        Return presupuesto
    End Function

    Public Shared Function desaprobarPresupuesto(IDEquipo As Integer, nuevoEstado As Integer)


        Dim conexion = New BaseDeDatos().obtenerConexion()

        Dim valor As Boolean? = Nothing
        Dim reparacion As New Reparaciones.Reparacion
        Dim presupuesto As Presupuestos.Presupuesto = Presupuestos.obtenerPresupuestoPorID(IDEquipo)
        reparacion.Presupuesto = presupuesto
        reparacion.observaciones = "El presupuesto del equipo no fue aprobado, por ende no se realizó ninguna reparación"

        Try
            Dim comando As New SqlCommand("UPDATE Presupuestos SET aprobado = 0 WHERE idRevision = @idRevision", conexion)
            comando.Parameters.AddWithValue("@idRevision", IDEquipo)


            conexion.Open()


            comando.ExecuteNonQuery()

            Equipos.ModificarEstadoEquipo(IDEquipo, nuevoEstado)
            Reparaciones.agregarReparacion(reparacion, nuevoEstado, valor)

            MessageBox.Show("Presupuesto desaprobado correctamente", "Presupuesto desaprobado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al desaprobar el presupuesto: " & ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    Public Shared Function aprobarPresupuesto(IDEquipo As Integer, nuevoEstado As Integer)
        Dim conexion = New BaseDeDatos().obtenerConexion()

        Try
            Dim comando As New SqlCommand("UPDATE Presupuestos SET aprobado = 1 WHERE idRevision = @idRevision", conexion)
            comando.Parameters.AddWithValue("@idRevision", IDEquipo)


            conexion.Open()


            comando.ExecuteNonQuery()

            Equipos.ModificarEstadoEquipo(IDEquipo, nuevoEstado)

            MessageBox.Show("Presupuesto aprobado correctamente", "Presupuesto desaprobado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al aprobar el presupuesto: " & ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

End Class
