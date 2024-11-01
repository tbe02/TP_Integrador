Public Class Estadisticas
    Public Class VariacionSemanal
        Public Property Semana As Integer
        Public Property Cantidad As Integer
        Public Property Variacion As Integer
    End Class

    Public Function ObtenerIngresosPorSemana() As List(Of VariacionSemanal)
        Dim ingresos = New List(Of VariacionSemanal)

        Dim conexion = New BaseDeDatos().obtenerConexion()
        Dim comando = New SqlCommand("DECLARE @fechaPrimerIngreso DATE = (SELECT MIN(fechaDeIngreso) FROM Equipos);

WITH EquiposPorSemana AS (
    SELECT 
        DATEDIFF(WEEK, @fechaPrimerIngreso, fechaDeIngreso) + 1 AS Semana,
        COUNT(*) AS CantidadEquipos
    FROM 
        Equipos
    GROUP BY 
        DATEDIFF(WEEK, @fechaPrimerIngreso, fechaDeIngreso) + 1
)
SELECT 
    Semana,
    CantidadEquipos,
    CantidadEquipos - LAG(CantidadEquipos, 1, 0) OVER (ORDER BY Semana) AS Variacion
FROM 
    EquiposPorSemana
ORDER BY 
    Semana;
", conexion)

        Try
            conexion.Open()

            Using lector As SqlDataReader = comando.ExecuteReader()
                If lector.HasRows Then
                    While lector.Read()
                        Dim ingreso As New VariacionSemanal With {
                            .Semana = lector("Semana"),
                            .Cantidad = lector("CantidadEquipos"),
                            .Variacion = lector("Variacion")
                        }

                        ingresos.Add(ingreso)
                    End While
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al obtener los ingresos por semana: " & ex.Message)
        Finally
            conexion.Close()
        End Try

        Return ingresos
    End Function

    Public Function ObtenerRevisionesPorSemana() As List(Of VariacionSemanal)
        Dim revisiones = New List(Of VariacionSemanal)

        Dim conexion = New BaseDeDatos().obtenerConexion()
        Dim comando = New SqlCommand("DECLARE @fechaPrimerFinalizacion DATE = (SELECT MIN(fechaDeFinalizacion) FROM Revisiones);

WITH RevisionesPorSemana AS (
    SELECT 
        DATEDIFF(WEEK, @fechaPrimerFinalizacion, fechaDeFinalizacion) + 1 AS Semana,
        COUNT(*) AS CantidadRevisiones
    FROM 
        Revisiones
    GROUP BY 
        DATEDIFF(WEEK, @fechaPrimerFinalizacion, fechaDeFinalizacion) + 1
)
SELECT 
    Semana,
    CantidadRevisiones,
    CantidadRevisiones - LAG(CantidadRevisiones, 1, 0) OVER (ORDER BY Semana) AS Variacion
FROM 
    RevisionesPorSemana
ORDER BY 
    Semana;
", conexion)

        Try
            conexion.Open()

            Using lector As SqlDataReader = comando.ExecuteReader()
                If lector.HasRows Then
                    While lector.Read()
                        Dim ingreso As New VariacionSemanal With {
                            .Semana = lector("Semana"),
                            .Cantidad = lector("CantidadRevisiones"),
                            .Variacion = lector("Variacion")
                        }

                        revisiones.Add(ingreso)
                    End While
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al obtener revisiones por semana: " & ex.Message)
        Finally
            conexion.Close()
        End Try

        Return revisiones
    End Function

    Public Function ObtenerReparacionesPorSemana() As List(Of VariacionSemanal)
        Dim reparaciones = New List(Of VariacionSemanal)

        Dim conexion = New BaseDeDatos().obtenerConexion()
        Dim comando = New SqlCommand("DECLARE @fechaPrimerFinalizacion DATE = (SELECT MIN(fechaDeFinalizacion) FROM Reparaciones);

WITH ReparacionesPorSemana AS (
    SELECT 
        DATEDIFF(WEEK, @fechaPrimerFinalizacion, fechaDeFinalizacion) + 1 AS Semana,
        COUNT(*) AS CantidadReparaciones
    FROM 
        Reparaciones
    GROUP BY 
        DATEDIFF(WEEK, @fechaPrimerFinalizacion, fechaDeFinalizacion) + 1
)
SELECT 
    Semana,
    CantidadReparaciones,
    CantidadReparaciones - LAG(CantidadReparaciones, 1, 0) OVER (ORDER BY Semana) AS Variacion
FROM 
    ReparacionesPorSemana
ORDER BY 
    Semana;
", conexion)

        Try
            conexion.Open()

            Using lector As SqlDataReader = comando.ExecuteReader()
                If lector.HasRows Then
                    While lector.Read()
                        Dim ingreso As New VariacionSemanal With {
                            .Semana = lector("Semana"),
                            .Cantidad = lector("CantidadReparaciones"),
                            .Variacion = lector("Variacion")
                        }

                        reparaciones.Add(ingreso)
                    End While
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al obtener reparaciones por semana: " & ex.Message)
        Finally
            conexion.Close()
        End Try

        Return reparaciones
    End Function

    Public Function ObtenerEntregasPorSemana() As List(Of VariacionSemanal)
        Dim entregas = New List(Of VariacionSemanal)

        Dim conexion = New BaseDeDatos().obtenerConexion()
        Dim comando = New SqlCommand("DECLARE @fechaPrimerEntrega DATE = (SELECT MIN(fecha) FROM Entregas);

WITH EntregasPorSemana AS (
    SELECT 
        DATEDIFF(WEEK, @fechaPrimerEntrega, fecha) + 1 AS Semana,
        COUNT(*) AS CantidadEntregas
    FROM 
        Entregas
    GROUP BY 
        DATEDIFF(WEEK, @fechaPrimerEntrega, fecha) + 1
)
SELECT 
    Semana,
    CantidadEntregas,
    CantidadEntregas - LAG(CantidadEntregas, 1, 0) OVER (ORDER BY Semana) AS Variacion
FROM 
    EntregasPorSemana
ORDER BY 
    Semana;
", conexion)

        Try
            conexion.Open()

            Using lector As SqlDataReader = comando.ExecuteReader()
                If lector.HasRows Then
                    While lector.Read()
                        Dim ingreso As New VariacionSemanal With {
                            .Semana = lector("Semana"),
                            .Cantidad = lector("CantidadEntregas"),
                            .Variacion = lector("Variacion")
                        }

                        entregas.Add(ingreso)
                    End While
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al obtener entregas por semana: " & ex.Message)
        Finally
            conexion.Close()
        End Try

        Return entregas
    End Function

    Public Class CantidadPorEstado
        Public Property Estado As String
        Public Property Cantidad As Integer
    End Class

    Public Function ObtenerEquiposPorEstado() As List(Of CantidadPorEstado)
        Dim estados = New List(Of CantidadPorEstado)

        Dim conexion = New BaseDeDatos().obtenerConexion()
        Dim comando = New SqlCommand("SELECT 
	estado, 
	COUNT(*) AS cantidad 
FROM (
	SELECT 
		Equipos.idEquipo,
		CASE 
			-- Si no existe una revisión, el equipo está pendiente de revisión
			WHEN Revisiones.idEquipo IS NULL THEN 'Pendiente de revisión'
        
			-- Si la revisión existe pero no ha finalizado, el equipo está en revisión
			WHEN Revisiones.fechaDeFinalizacion IS NULL THEN 'En revisión'
        
			-- Si la revisión está finalizada pero no hay presupuesto, el equipo está pendiente de presupuesto
			WHEN Presupuestos.idPresupuesto IS NULL THEN 'Pendiente de presupuesto'

			-- Si el presupuesto existe pero el cliente aun no decidio si lo aprueba, el equipo está pendiente de aprobacion de presupuesto
			WHEN Presupuestos.aprobado IS NULL THEN 'Pendiente de aprobacion de presupuesto'
        
			-- Si el presupuesto existe pero no está aprobado y no ha sido entregado, el equipo está pendiente de entrega
			WHEN Presupuestos.aprobado = 0 AND Entregas.idReparacion IS NULL THEN 'Pendiente de entrega'
        
			-- Si el presupuesto está aprobado pero no existe reparación, el equipo está pendiente de reparación
			WHEN Reparaciones.idPresupuesto IS NULL THEN 'Pendiente de reparación'
        
			-- Si la reparación existe pero no ha finalizado y no es irreparable, el equipo está en reparación
			WHEN Reparaciones.fechaDeFinalizacion IS NULL THEN 'En reparación'
        
			-- Si la reparación existe, ha finalizado y es irreparable, el equipo está pendiente de entrega
			WHEN Reparaciones.irreparable = 1 AND Entregas.idReparacion IS NULL THEN 'Pendiente de entrega'

			-- Si la reparación está finalizada pero no existe entrega, el equipo está pendiente de entrega
			WHEN Entregas.idReparacion IS NULL THEN 'Pendiente de entrega'
        
			-- Si el equipo ha sido entregado, está en estado entregado
			ELSE 'Entregado'
		END AS estado
	FROM 
		Equipos
		LEFT JOIN Revisiones ON Equipos.idEquipo = Revisiones.idEquipo
		LEFT JOIN Presupuestos ON Revisiones.idEquipo = Presupuestos.idRevision
		LEFT JOIN Reparaciones ON Presupuestos.idPresupuesto = Reparaciones.idPresupuesto
		LEFT JOIN Entregas ON Reparaciones.idPresupuesto = Entregas.idReparacion
) AS estados
GROUP BY estado
ORDER BY cantidad DESC;
", conexion)

        Try
            conexion.Open()

            Using lector As SqlDataReader = comando.ExecuteReader()
                If lector.HasRows Then
                    While lector.Read()
                        Dim ingreso As New CantidadPorEstado With {
                            .Estado = lector("estado"),
                            .Cantidad = lector("cantidad")
                        }

                        estados.Add(ingreso)
                    End While
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al obtener equipos por estado: " & ex.Message)
        Finally
            conexion.Close()
        End Try

        Return estados
    End Function
End Class
