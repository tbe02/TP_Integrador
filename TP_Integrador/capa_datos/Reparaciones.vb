﻿Imports TP_Integrador.Equipos
Imports TP_Integrador.Presupuestos
Imports TP_Integrador.Revisiones
Imports TP_Integrador.TiposDeUsuario

Public Class Reparaciones
    Private _sesion As Sesion = Sesion.ObtenerInstancia()

    Class Reparacion
        Public Property Presupuesto As Presupuesto
        Public Property reparado As Boolean?
        Public Property observaciones As String
        Public Property fechaDeFinalizacion As DateTime

    End Class


    Public Function agregarReparacion(reparacion As Reparacion, nuevoEstado As Integer, reparacionExitosa As Boolean?)
        Dim conexion = New BaseDeDatos().obtenerConexion()


        Try
            Dim comando = New SqlCommand("INSERT INTO Reparaciones (idPresupuesto, reparado, observaciones, fechaDeFinalizacion, idUsuario) VALUES (@idPresupuesto, @reparado, @observaciones, @fechaDeFinalizacion, @idUsuario)", conexion)
            comando.Parameters.AddWithValue("@idPresupuesto", reparacion.Presupuesto.IdPresupuesto)
            If reparacionExitosa Is Nothing Then
                comando.Parameters.AddWithValue("@reparado", DBNull.Value)
            Else
                comando.Parameters.AddWithValue("@reparado", reparacionExitosa)
            End If

            comando.Parameters.AddWithValue("@observaciones", reparacion.observaciones)
            comando.Parameters.AddWithValue("@idUsuario", _sesion.ObtenerUsuario().ID)

            comando.Parameters.AddWithValue("@fechaDeFinalizacion", DateTime.Now)

            conexion.Open()

            comando.ExecuteNonQuery()


            Equipos.ModificarEstadoEquipo(reparacion.Presupuesto.Revision.Equipo.IDEquipo, nuevoEstado)

            Return True
        Catch ex As Exception
            MessageBox.Show("Error al finalizar la reparacion: " & ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try

    End Function



    Public Shared Function RepararEquipo(equipo As Equipo, nuevoEstado As Integer) As Boolean


        Dim conexion = New BaseDeDatos().obtenerConexion()

        Try
            Equipos.ModificarEstadoEquipo(equipo.IDEquipo, nuevoEstado)

        Catch ex As Exception
            MessageBox.Show("Error al comenzar la reparacion: " & ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try


        Return True


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

    Public Shared Function reparacionAprobada(IDEquipo As Integer) As Nullable(Of Boolean)
        Dim conexion = New BaseDeDatos().obtenerConexion()

        Try
            Dim comando = New SqlCommand("SELECT r.reparado FROM Reparaciones r JOIN Presupuestos p ON r.idPresupuesto = p.idPresupuesto WHERE p.aprobado = 1 AND p.idRevision = @idEquipo", conexion)
            comando.Parameters.AddWithValue("@idEquipo", IDEquipo)

            conexion.Open()
            Dim reader As SqlDataReader = comando.ExecuteReader()

            If reader.Read() Then
                ' Aquí se obtuvo el valor de reparado
                Dim reparadoValue As Object = reader("reparado")
                If IsDBNull(reparadoValue) Then
                    ' Si el valor es null
                    Return Nothing
                ElseIf CBool(reparadoValue) Then
                    ' Si reparado es 1 (True)
                    Return True
                Else
                    ' Si reparado es 0 (False)
                    Return False
                End If
            Else
                ' No se encontró ninguna reparación aprobada
                Return Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("Error al obtener la reparación: " & ex.Message)
            Return Nothing
        Finally
            conexion.Close()
        End Try
    End Function

    Public Class ReparacionConTecnico
        Inherits Reparacion

        Public Property Tecnico As Usuarios.Usuario
    End Class

    Public Shared Function devolverReparacion(IDEquipo As Integer) As ReparacionConTecnico
        Dim conexion = New BaseDeDatos().obtenerConexion()
        Dim reparacion As ReparacionConTecnico = New ReparacionConTecnico()

        Try
            Dim comando = New SqlCommand("SELECT * FROM Reparaciones r JOIN Presupuestos p ON r.idPresupuesto = p.idPresupuesto JOIN Usuarios ON r.idUsuario = Usuarios.idUsuario WHERE p.idRevision = @idEquipo", conexion)
            comando.Parameters.AddWithValue("@idEquipo", IDEquipo)

            conexion.Open()
            Dim reader As SqlDataReader = comando.ExecuteReader()

            If reader.Read() Then
                reparacion.fechaDeFinalizacion = reader("fechaDeFinalizacion")
                reparacion.observaciones = reader("observaciones")

                Dim usuario As Usuarios.Usuario = New Usuarios.Usuario With {
                    .ID = reader("idUsuario"),
                    .Apellido = reader("apellido"),
                    .Nombre = reader("nombre"),
                    .DNI = reader("DNI"),
                    .Telefono = reader("telefono"),
                    .Correo = reader("correo"),
                    .NombreUsuario = reader("usuario"),
                    .Tipo = New TipoDeUsuario() With {.idTipoUsuario = 3, .nombre = "tecnico"}
                }

                reparacion.Tecnico = usuario

                If reader("reparado") Is DBNull.Value Then
                    reparacion.reparado = Nothing

                Else
                    If reader("reparado") = True Then
                        reparacion.reparado = Convert.ToBoolean(reader("reparado"))
                    Else
                        reparacion.reparado = Convert.ToBoolean(reader("reparado"))
                        reparacion.observaciones = reader("observaciones").ToString()
                    End If
                    reparacion.Presupuesto = New Presupuesto()
                    reparacion.Presupuesto.IdPresupuesto = reader("idPresupuesto")


                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error al obtener la reparación: " & ex.Message)
        Finally
            conexion.Close()
        End Try

        Return reparacion
    End Function

End Class
