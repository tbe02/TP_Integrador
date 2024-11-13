Public Class Estadisticas
    Public Class VariacionSemanal
        Public Property Semana As String
        Public Property Cantidad As Integer
        Public Property Variacion As Integer
    End Class

    Public Function ObtenerIngresosPorSemana(fechaInicio As String, fechaFin As String) As List(Of VariacionSemanal)
        Dim ingresos = New List(Of VariacionSemanal)

        Dim conexion = New BaseDeDatos().obtenerConexion()
        Dim comando = New SqlCommand($"DECLARE @fechaInicio DATE = '{fechaInicio}';
DECLARE @fechaFin DATE = '{fechaFin}';

WITH EquiposPorSemana AS (
    SELECT 
        @fechaInicio AS Semana,
        COALESCE(COUNT(*), 0) AS CantidadEquipos
    FROM 
        Equipos
    WHERE 
        fechaDeIngreso BETWEEN DATEADD(WEEK, -1, @fechaInicio) AND DATEADD(DAY, -1, @fechaInicio)
    HAVING 
        COUNT(*) > 0 OR COUNT(*) = 0
    
    UNION ALL

    SELECT 
        DATEADD(WEEK, (DATEDIFF(WEEK, @fechaInicio, fechaDeIngreso) + 1), @fechaInicio) AS Semana,
        COUNT(*) AS CantidadEquipos
    FROM 
        Equipos
    WHERE 
        fechaDeIngreso BETWEEN @fechaInicio AND @fechaFin
    GROUP BY 
        DATEDIFF(WEEK, @fechaInicio, fechaDeIngreso) + 1
)
SELECT 
    Semana,
    CantidadEquipos,
    CASE 
        WHEN ROW_NUMBER() OVER (ORDER BY Semana) = 1 THEN 0
        ELSE CantidadEquipos - LAG(CantidadEquipos, 1, 0) OVER (ORDER BY Semana) 
    END AS Variacion
FROM 
    EquiposPorSemana
ORDER BY 
    Semana;", conexion)

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

    Public Function ObtenerFechaPrimerIngreso() As Date
        Dim fecha = DateTime.Now()

        Dim conexion = New BaseDeDatos().obtenerConexion()
        Dim comando = New SqlCommand("SELECT MIN(fechaDeIngreso) FROM Equipos", conexion)

        Try
            conexion.Open()

            Dim primerFechaIngreso As Object = comando.ExecuteScalar()

            ' Verifica que la fecha no sea NULL antes de asignarla
            If primerFechaIngreso IsNot DBNull.Value Then
                fecha = Convert.ToDateTime(primerFechaIngreso)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al obtener revisiones por semana: " & ex.Message)
        Finally
            conexion.Close()
        End Try

        Return fecha
    End Function

    Public Function ObtenerRevisionesPorSemana(fechaInicio As String, fechaFin As String) As List(Of VariacionSemanal)
        Dim revisiones = New List(Of VariacionSemanal)

        Dim conexion = New BaseDeDatos().obtenerConexion()
        Dim comando = New SqlCommand($"DECLARE @fechaInicio DATE = '{fechaInicio}';
    DECLARE @fechaFin DATE = '{fechaFin}';

    WITH RevisionesPorSemana AS (
    -- Primer registro: Revisiones entre fechaInicio y 7 días antes
    SELECT 
        @fechaInicio AS Semana,
        COALESCE(COUNT(*), 0) AS CantidadRevisiones
    FROM 
        Revisiones
    WHERE 
        fechaDeFinalizacion BETWEEN DATEADD(WEEK, -1, @fechaInicio) AND DATEADD(DAY, -1, @fechaInicio)
    HAVING 
        COUNT(*) > 0 OR COUNT(*) = 0
    
    UNION ALL

    -- Revisiones agrupadas por semana entre fechaInicio y fechaFin
    SELECT 
        DATEADD(WEEK, (DATEDIFF(WEEK, @fechaInicio, fechaDeFinalizacion) + 1), @fechaInicio) AS Semana,
        COUNT(*) AS CantidadRevisiones
    FROM 
        Revisiones
    WHERE 
        fechaDeFinalizacion BETWEEN @fechaInicio AND @fechaFin
    GROUP BY 
        DATEDIFF(WEEK, @fechaInicio, fechaDeFinalizacion) + 1
)
SELECT 
    Semana,
    CantidadRevisiones,
    CASE 
        WHEN ROW_NUMBER() OVER (ORDER BY Semana) = 1 THEN 0
        ELSE CantidadRevisiones - LAG(CantidadRevisiones, 1, 0) OVER (ORDER BY Semana) 
    END AS Variacion
FROM 
    RevisionesPorSemana
ORDER BY 
    Semana;", conexion)

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

    Public Function ObtenerReparacionesPorSemana(fechaInicio As String, fechaFin As String) As List(Of VariacionSemanal)
        Dim reparaciones = New List(Of VariacionSemanal)

        Dim conexion = New BaseDeDatos().obtenerConexion()
        Dim comando = New SqlCommand($"DECLARE @fechaInicio DATE = '{fechaInicio}';
DECLARE @fechaFin DATE = '{fechaFin}';

WITH ReparacionesPorSemana AS (
    -- Primer registro: Reparaciones entre fechaInicio y 7 días antes
    SELECT 
        @fechaInicio AS Semana,
        COALESCE(COUNT(*), 0) AS CantidadReparaciones
    FROM 
        Reparaciones
    WHERE 
        fechaDeFinalizacion BETWEEN DATEADD(WEEK, -1, @fechaInicio) AND DATEADD(DAY, -1, @fechaInicio)
    HAVING 
        COUNT(*) > 0 OR COUNT(*) = 0
    
    UNION ALL

    -- Reparaciones agrupadas por semana entre fechaInicio y fechaFin
    SELECT 
        DATEADD(WEEK, (DATEDIFF(WEEK, @fechaInicio, fechaDeFinalizacion) + 1), @fechaInicio) AS Semana,
        COUNT(*) AS CantidadReparaciones
    FROM 
        Reparaciones
    WHERE 
        fechaDeFinalizacion BETWEEN @fechaInicio AND @fechaFin
    GROUP BY 
        DATEDIFF(WEEK, @fechaInicio, fechaDeFinalizacion) + 1
)
SELECT 
    Semana,
    CantidadReparaciones,
    CASE 
        WHEN ROW_NUMBER() OVER (ORDER BY Semana) = 1 THEN 0
        ELSE CantidadReparaciones - LAG(CantidadReparaciones, 1, 0) OVER (ORDER BY Semana) 
    END AS Variacion
FROM 
    ReparacionesPorSemana
ORDER BY 
    Semana;", conexion)

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

    Public Function ObtenerEntregasPorSemana(fechaInicio As String, fechaFin As String) As List(Of VariacionSemanal)
        Dim entregas = New List(Of VariacionSemanal)

        Dim conexion = New BaseDeDatos().obtenerConexion()
        Dim comando = New SqlCommand($"DECLARE @fechaInicio DATE = '{fechaInicio}';
DECLARE @fechaFin DATE = '{fechaFin}';

WITH EntregasPorSemana AS (
    -- Primer registro: Entregas entre fechaInicio y 7 días antes
    SELECT 
        @fechaInicio AS Semana,
        COALESCE(COUNT(*), 0) AS CantidadEntregas
    FROM 
        Entregas
    WHERE 
        fecha BETWEEN DATEADD(WEEK, -1, @fechaInicio) AND DATEADD(DAY, -1, @fechaInicio)
    HAVING 
        COUNT(*) > 0 OR COUNT(*) = 0
    
    UNION ALL

    -- Entregas agrupadas por semana entre fechaInicio y fechaFin
    SELECT 
        DATEADD(WEEK, (DATEDIFF(WEEK, @fechaInicio, fecha) + 1), @fechaInicio) AS Semana,
        COUNT(*) AS CantidadEntregas
    FROM 
        Entregas
    WHERE 
        fecha BETWEEN @fechaInicio AND @fechaFin
    GROUP BY 
        DATEDIFF(WEEK, @fechaInicio, fecha) + 1
)
SELECT 
    Semana,
    CantidadEntregas,
    CASE 
        WHEN ROW_NUMBER() OVER (ORDER BY Semana) = 1 THEN 0
        ELSE CantidadEntregas - LAG(CantidadEntregas, 1, 0) OVER (ORDER BY Semana) 
    END AS Variacion
FROM 
    EntregasPorSemana
ORDER BY 
    Semana;", conexion)

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
        Dim comando = New SqlCommand("-- Tabla derivada con todos los estados posibles
WITH EstadosPosibles AS (
    SELECT 'Pendiente de revisión' AS estado
    UNION ALL
    SELECT 'En revisión'
    UNION ALL
    SELECT 'Pendiente de presupuesto'
    UNION ALL
    SELECT 'Pendiente de aprobacion de presupuesto'
    UNION ALL
    SELECT 'Pendiente de entrega'
    UNION ALL
    SELECT 'Pendiente de reparación'
    UNION ALL
    SELECT 'En reparación'
    UNION ALL
    SELECT 'Entregado'
)

SELECT 
    EstadosPosibles.estado,
    COALESCE(cantidad, 0) AS cantidad
FROM 
    EstadosPosibles
LEFT JOIN (
    SELECT 
        estado, 
        COUNT(*) AS cantidad 
    FROM (
        SELECT 
            Equipos.idEquipo,
            CASE 
                WHEN Revisiones.idEquipo IS NULL THEN 'Pendiente de revisión'
                WHEN Revisiones.fechaDeFinalizacion IS NULL THEN 'En revisión'
                WHEN Presupuestos.idPresupuesto IS NULL THEN 'Pendiente de presupuesto'
                WHEN Presupuestos.aprobado IS NULL THEN 'Pendiente de aprobacion de presupuesto'
                WHEN Presupuestos.aprobado = 0 AND Entregas.idReparacion IS NULL THEN 'Pendiente de entrega'
                WHEN Reparaciones.idPresupuesto IS NULL THEN 'Pendiente de reparación'
                WHEN Reparaciones.fechaDeFinalizacion IS NULL THEN 'En reparación'
                WHEN Reparaciones.irreparable = 1 AND Entregas.idReparacion IS NULL THEN 'Pendiente de entrega'
                WHEN Entregas.idReparacion IS NULL THEN 'Pendiente de entrega'
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
) AS conteo ON EstadosPosibles.estado = conteo.estado
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

    Public Function ObtenerFacturacionPorSemana(fechaInicio As String, fechaFin As String) As List(Of VariacionSemanal)
        Dim facturaciones = New List(Of VariacionSemanal)

        Dim conexion = New BaseDeDatos().obtenerConexion()
        Dim comando = New SqlCommand($"DECLARE @fechaInicio DATE = '{fechaInicio}';
DECLARE @fechaFin DATE = '{fechaFin}';

WITH FacturacionPorSemana AS (
    -- Primer registro: Facturación entre fechaInicio y 7 días antes
    SELECT 
        @fechaInicio AS Semana,
        COALESCE(SUM(monto), 0) AS Facturacion
    FROM 
        Entregas
    JOIN 
        Presupuestos ON Entregas.idReparacion = Presupuestos.idPresupuesto
    WHERE 
        fecha BETWEEN DATEADD(WEEK, -1, @fechaInicio) AND DATEADD(DAY, -1, @fechaInicio)
    
    UNION ALL

    -- Facturación agrupada por semana entre fechaInicio y fechaFin
    SELECT 
        DATEADD(WEEK, (DATEDIFF(WEEK, @fechaInicio, fecha) + 1), @fechaInicio) AS Semana,
        SUM(monto) AS Facturacion
    FROM 
        Entregas
    JOIN 
        Presupuestos ON Entregas.idReparacion = Presupuestos.idPresupuesto
    WHERE 
        fecha BETWEEN @fechaInicio AND @fechaFin
    GROUP BY 
        DATEDIFF(WEEK, @fechaInicio, fecha) + 1
)
SELECT 
    Semana,
    Facturacion,
    CASE 
        WHEN ROW_NUMBER() OVER (ORDER BY Semana) = 1 THEN 0
        ELSE Facturacion - LAG(Facturacion, 1, 0) OVER (ORDER BY Semana) 
    END AS Variacion
FROM 
    FacturacionPorSemana
ORDER BY 
    Semana;", conexion)

        Try
            conexion.Open()

            Using lector As SqlDataReader = comando.ExecuteReader()
                If lector.HasRows Then
                    While lector.Read()
                        Dim facturacion As New VariacionSemanal With {
                            .Semana = lector("Semana"),
                            .Cantidad = lector("Facturacion"),
                            .Variacion = lector("Variacion")
                        }

                        facturaciones.Add(facturacion)
                    End While
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al obtener facturaciones por semana: " & ex.Message)
        Finally
            conexion.Close()
        End Try

        Return facturaciones
    End Function
End Class
