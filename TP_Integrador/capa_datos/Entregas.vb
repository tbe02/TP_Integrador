Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports TP_Integrador.Presupuestos
Imports TP_Integrador.Reparaciones
Imports TP_Integrador.Revisiones
Public Class Entregas

    Class Entrega
        Public Property Reparacion As Reparacion
        Public Property fecha As Date
        Public Property metodoPago As MetodosPago.MetodoPago
    End Class

    Public Shared Function agregarEntrega(entrega As Entrega, nuevoEstado As Integer) As Boolean
        Dim conexion = New BaseDeDatos().obtenerConexion()
        Dim reparacion As Reparacion = Nothing ' Inicializar a Nothing para evitar errores

        Try
            Dim comando = New SqlCommand("INSERT INTO Entregas(idReparacion, fecha, idMetodoPago) VALUES (@idReparacion, @fecha, @idMetodoPago)", conexion)
            comando.Parameters.AddWithValue("@idReparacion", entrega.Reparacion.Presupuesto.IdPresupuesto)
            comando.Parameters.AddWithValue("@fecha", DateTime.Now)



            reparacion = Reparaciones.obtenerReparacionPorID(entrega.Reparacion.Presupuesto.Revision.Equipo.IDEquipo)



            ' Verifica si reparacion.reparado es Nothing o False
            If reparacion.reparado Is Nothing OrElse reparacion.reparado = False Then
                comando.Parameters.AddWithValue("@idMetodoPago", DBNull.Value)
            Else
                comando.Parameters.AddWithValue("@idMetodoPago", entrega.metodoPago.id)
            End If

            conexion.Open()
            comando.ExecuteNonQuery()

            Equipos.ModificarEstadoEquipo(entrega.Reparacion.Presupuesto.Revision.Equipo.IDEquipo, nuevoEstado)
            Equipos.darDeBajaEquipo(entrega.Reparacion.Presupuesto.Revision.Equipo.IDEquipo)


            Return True
        Catch ex As Exception
            MessageBox.Show("Error al insertar la entrega: " & ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    Public Shared Function devolverEntrega(IDEquipo As Integer) As Entrega
        Dim conexion = New BaseDeDatos().obtenerConexion()
        Dim entrega As New Entrega()
        entrega.metodoPago = New MetodosPago.MetodoPago()

        Try
            ' Asegúrate de que la consulta incluye el nombre del método de pago
            Dim comando = New SqlCommand("SELECT e.idMetodoPago, mp.nombre, e.fecha FROM Entregas e 
                                       JOIN Reparaciones r ON e.idReparacion = r.idPresupuesto 
                                       JOIN Presupuestos p ON r.idPresupuesto = p.idPresupuesto 
                                       JOIN MetodosPago mp ON e.idMetodoPago = mp.id 
                                       WHERE p.idRevision = @idEquipo", conexion)
            comando.Parameters.AddWithValue("@idEquipo", IDEquipo)

            conexion.Open()
            Dim reader As SqlDataReader = comando.ExecuteReader()

            If reader.Read() Then
                entrega.metodoPago.id = reader("idMetodoPago")
                entrega.metodoPago.nombre = reader("nombre") ' Suponiendo que 'nombreMetodoPago' es el campo en la tabla
                entrega.fecha = reader("fecha")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al obtener la entrega: " & ex.Message)
        Finally
            conexion.Close()
        End Try

        Return entrega
    End Function





End Class
