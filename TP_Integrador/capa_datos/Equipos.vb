﻿Imports TP_Integrador.Equipos
Imports TP_Integrador.Marcas
Imports TP_Integrador.Modelos
Imports TP_Integrador.TiposDeEquipo

Public Class Equipos
    Private Shared instancia As Equipos

    Class Equipo

        Public Property IDEquipo As Integer
        Public Property Cliente As Cliente
        Public Property TipoEquipo As TipoDeEquipo
        Public Property NumeroSerie As String
        Public Property Marca As Marca
        Public Property Enciende As String
        Public Property RazonIngreso As String
        Public Property Observaciones As String
        Public Property Modelo As Modelo
        Public Property Estado As Integer

        Public Property fechaIngreso As DateTime

        Public Property Baja As String
    End Class


    Public Function Agregar(equipo As Equipo)

        Dim conexion = New BaseDeDatos().obtenerConexion()

        Dim resultado As DialogResult

        If verificaciones(equipo.Cliente.ID, equipo.TipoEquipo.IdTipoEquipo, equipo.NumeroSerie, equipo.Marca.idMarca, equipo.Modelo.idModelo, equipo.RazonIngreso, equipo.Observaciones, equipo.Enciende, equipo.Estado) Then

            resultado = MessageBox.Show("Esta seguro que desea agregar un nuevo equipo?", "Insercion de equipo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resultado = DialogResult.Yes Then

                Try



                    Dim comando = New SqlCommand("INSERT INTO Equipos (numeroDeSerie, observaciones, razonDeIngreso, enciende, idTipoDeEquipo,  idMarca, idModelo, fechaDeIngreso, estado, idCliente, baja) 
                                  VALUES (@numeroSerie, @observaciones, @razonIngreso, @enciende, @idTipoEquipo, @idMarca, @idModelo, @fechaIngreso, @estado, @idCliente, @baja);", conexion)


                    comando.Parameters.AddWithValue("@idCliente", equipo.Cliente.ID)
                    comando.Parameters.AddWithValue("@idTipoEquipo", equipo.TipoEquipo.IdTipoEquipo)
                    comando.Parameters.AddWithValue("@numeroSerie", equipo.NumeroSerie)
                    comando.Parameters.AddWithValue("@idMarca", equipo.Marca.idMarca)
                    comando.Parameters.AddWithValue("@enciende", equipo.Enciende)
                    comando.Parameters.AddWithValue("@razonIngreso", equipo.RazonIngreso)
                    comando.Parameters.AddWithValue("@observaciones", equipo.Observaciones)
                    comando.Parameters.AddWithValue("@idModelo", equipo.Modelo.idModelo)
                    comando.Parameters.AddWithValue("@fechaIngreso", DateTime.Now)
                    comando.Parameters.AddWithValue("@estado", equipo.Estado)
                    comando.Parameters.AddWithValue("@baja", equipo.Baja)


                    conexion.Open()
                    comando.ExecuteNonQuery()

                    MessageBox.Show("Equipo agregado correctamente", "Confirmacion de equipo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return True


                Catch ex As Exception

                    MessageBox.Show("Error al insertar el equipo: " & ex.Message)
                    Return False
                Finally
                    conexion.Close()
                End Try
            End If
        End If

        Return False
    End Function

    Public Function editarEquipo(IDEquipo As Integer, equipoEditado As Equipo)
        Dim conexion = New BaseDeDatos().obtenerConexion()


        ' Verificar los datos del equipo editado

        Try
            Dim comando = New SqlCommand("UPDATE Equipos SET 
                                                numeroDeSerie = @numeroSerie, 
                                                observaciones = @observaciones, 
                                                razonDeIngreso = @razonIngreso, 
                                                enciende = @enciende, 
                                                idTipoDeEquipo = @idTipoEquipo,  
                                                idMarca = @idMarca, 
                                                idModelo = @idModelo,  
                                                idCliente = @idCliente 
                                              WHERE idEquipo = @idEquipo;", conexion)

            ' Agregar parámetros al comando
            comando.Parameters.AddWithValue("@numeroSerie", equipoEditado.NumeroSerie)
            comando.Parameters.AddWithValue("@observaciones", equipoEditado.Observaciones)
            comando.Parameters.AddWithValue("@razonIngreso", equipoEditado.RazonIngreso)
            comando.Parameters.AddWithValue("@enciende", equipoEditado.Enciende)
            comando.Parameters.AddWithValue("@idTipoEquipo", equipoEditado.TipoEquipo.IdTipoEquipo)
            comando.Parameters.AddWithValue("@idMarca", equipoEditado.Marca.idMarca)
            comando.Parameters.AddWithValue("@idModelo", equipoEditado.Modelo.idModelo)
            comando.Parameters.AddWithValue("@idCliente", equipoEditado.Cliente.ID)
            comando.Parameters.AddWithValue("@idEquipo", IDEquipo) ' Agregar el ID del equipo a editar

            ' Abrir la conexión y ejecutar el comando
            conexion.Open()
            comando.ExecuteNonQuery()

            Return True
        Catch ex As Exception
            MessageBox.Show("Error al editar el equipo: " & ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try

        Return False
    End Function

    Public Shared Function ObtenerDescripcionEstado(estado As Integer) As String
        Dim descripcion As String = String.Empty
        Dim conexion = New BaseDeDatos().obtenerConexion()

        Try
            Dim comando = New SqlCommand("SELECT descripcion FROM Estados WHERE idEstado = @estado", conexion)
            comando.Parameters.AddWithValue("@estado", estado)

            conexion.Open()
            Dim reader As SqlDataReader = comando.ExecuteReader()

            If reader.Read() Then
                descripcion = reader("descripcion").ToString()
            End If

        Catch ex As Exception
            MessageBox.Show("Error al obtener la descripción del estado: " & ex.Message)
        Finally
            conexion.Close()
        End Try

        Return descripcion
    End Function

    Public Shared Function darDeBajaEquipo(IDEquipo As Integer)
        Dim conexion = New BaseDeDatos().obtenerConexion()

        Try
            Dim comando = New SqlCommand("UPDATE Equipos SET 
                                        baja = 'Si' 
                                      WHERE idEquipo = @idEquipo;", conexion)

            ' Añadir el parámetro @idEquipo
            comando.Parameters.AddWithValue("@idEquipo", IDEquipo)

            ' Abrir la conexión y ejecutar el comando
            conexion.Open()
            comando.ExecuteNonQuery()


            Return True
        Catch ex As Exception
            MessageBox.Show("Error al dar de baja el equipo: " & ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function






    Public Function ObtenerTodos() As List(Of Equipo)
        Dim equipos As New List(Of Equipo)()

        Dim conexion = New BaseDeDatos().obtenerConexion()
        Dim comando = New SqlCommand("
    SELECT 
        e.*, 
        c.dni AS ClienteDni,
        c.nombres AS ClienteNombre, 
        m.nombre AS ModeloNombre, 
        t.nombre AS TipoEquipoNombre, 
        b.nombre AS MarcaNombre 
    FROM 
        Equipos e 
    JOIN 
        Clientes c ON e.idCliente = c.idCliente 
    JOIN 
        Modelos m ON e.idModelo = m.idModelo 
    JOIN 
        TiposDeEquipo t ON e.idTipoDeEquipo = t.idTipoDeEquipo 
    JOIN 
        Marcas b ON e.idMarca = b.idMarca;", conexion)



        Try
            conexion.Open()

            Using lector As SqlDataReader = comando.ExecuteReader()
                If lector.HasRows Then
                    While lector.Read()
                        Dim equipo As New Equipo() With {
                        .IDEquipo = lector("idEquipo").ToString(),
                        .Cliente = New Cliente() With {.ID = lector("idCliente").ToString(), .Nombre = lector("ClienteNombre").ToString(), .Dni = lector("ClienteDni").ToString()},
                        .TipoEquipo = New TipoDeEquipo() With {.IdTipoEquipo = lector("idTipoDeEquipo").ToString(), .Nombre = lector("TipoEquipoNombre").ToString()},
                        .NumeroSerie = lector("numeroDeSerie").ToString(),
                        .Marca = New Marca() With {.idMarca = lector("idMarca").ToString(), .nombre = lector("MarcaNombre").ToString()},
                        .Enciende = lector("enciende").ToString(),
                        .RazonIngreso = lector("razonDeIngreso").ToString(),
                        .Observaciones = lector("observaciones").ToString(),
                        .Modelo = New Modelo() With {.idModelo = lector("idModelo").ToString(), .nombre = lector("ModeloNombre").ToString()},
                        .Estado = lector("estado").ToString(),
                        .Baja = lector("baja").ToString(),
                        .fechaIngreso = lector("fechaDeIngreso")
                    }

                        equipos.Add(equipo)
                    End While
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al obtener los equipos: " & ex.Message)
        Finally
            conexion.Close()
        End Try

        Return equipos
    End Function




    Public Shared Function ObtenerInstancia() As Equipos
        If instancia Is Nothing Then
            instancia = New Equipos()

        End If
        Return instancia
    End Function



    Public Function eliminar(equipo As Equipo)

        If equipo IsNot Nothing Then
            Dim conexion = New BaseDeDatos().obtenerConexion()

            Dim comando = New SqlCommand("UPDATE Equipos SET baja = 'Si' WHERE idEquipo = '" & equipo.IDEquipo & "';", conexion)

            conexion.Open()

            comando.ExecuteNonQuery()

            Return True ' indica que se eliminó correctamente
        Else
            Return False ' indica que no se encontró el equipo
        End If


    End Function

    Private Shared Function verificaciones(idCliente As Integer, idTipoEquipo As Integer, numeroSerie As String, idMarca As Integer, idModelo As Integer, razon As String, observacion As String, enciende As String, estado As String)


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

    Public Shared Function ModificarEstadoEquipo(IDEquipo As Integer, IDEstado As Integer)
        Dim conexion = New BaseDeDatos().obtenerConexion()


        Try
            Dim comando = New SqlCommand("UPDATE Equipos SET 
                                                estado = @idEstado
                                              WHERE idEquipo = @idEquipo;", conexion)

            comando.Parameters.AddWithValue("@idEquipo", IDEquipo)
            comando.Parameters.AddWithValue("@idEstado", IDEstado)

            conexion.Open()
            comando.ExecuteNonQuery()


            Return True
        Catch ex As Exception
            MessageBox.Show("Error al editar el estado del equipo: " & ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try

        Return False
    End Function

    Public Function obtenerCliente(IDEquipo As Integer) As Cliente
        Dim cliente As New Cliente()
        Dim conexion = New BaseDeDatos().obtenerConexion()

        Try

            Dim comando As New SqlCommand("SELECT clientes.* FROM Equipos JOIN clientes ON clientes.idcliente = Equipos.idCliente WHERE Equipos.IDEquipo = @idEquipo", conexion)
            comando.Parameters.AddWithValue("@idEquipo", IDEquipo)


            conexion.Open()


            Dim lector As SqlDataReader = comando.ExecuteReader()

            If lector.Read() Then

                cliente.ID = Convert.ToInt32(lector("idCliente"))
                cliente.Nombre = lector("nombres").ToString()
                cliente.Apellido = lector("apellidos").ToString()
                cliente.Telefono = lector("telefono").ToString()
                cliente.Correo = lector("correo").ToString()
                cliente.Dni = lector("DNI").ToString()

            End If

            lector.Close()

        Catch ex As Exception
            MessageBox.Show("Error al obtener el cliente: " & ex.Message)
        Finally
            conexion.Close()
        End Try


        Return cliente
    End Function

    Public Shared Function obtenerEquipo(IDEquipo As Integer) As Equipo
        Dim equipo As New Equipo()
        Dim conexion = New BaseDeDatos().obtenerConexion()

        Try
            Dim comando As New SqlCommand("SELECT * FROM Equipos WHERE Equipos.IDEquipo = @idEquipo", conexion)
            comando.Parameters.AddWithValue("@idEquipo", IDEquipo)

            conexion.Open()

            Dim lector As SqlDataReader = comando.ExecuteReader()

            If lector.Read() Then
                equipo.IDEquipo = Convert.ToInt32(lector("idEquipo"))

                ' Inicializa el objeto Cliente
                Dim cliente As New Cliente()
                cliente.ID = Convert.ToInt32(lector("idCliente"))
                equipo.Cliente = cliente

                equipo.NumeroSerie = lector("numeroDeSerie").ToString()
                equipo.Observaciones = lector("observaciones").ToString()
                equipo.RazonIngreso = lector("razonDeIngreso").ToString()
                equipo.Enciende = lector("enciende").ToString()
                equipo.fechaIngreso = Convert.ToDateTime(lector("fechaDeIngreso"))

                ' Inicializa el objeto TipoEquipo con conexión cerrada
                Dim tipoEquipo As New TipoDeEquipo()
                tipoEquipo.IdTipoEquipo = Convert.ToInt32(lector("idTipoDeEquipo"))
                tipoEquipo.Nombre = ObtenerDescripcionTipoEquipo(tipoEquipo.IdTipoEquipo)
                equipo.TipoEquipo = tipoEquipo

                ' Inicializa el objeto Marca con conexión cerrada
                Dim marca As New Marca()
                marca.idMarca = Convert.ToInt32(lector("idMarca"))
                marca.nombre = ObtenerDescripcionMarca(marca.idMarca)
                equipo.Marca = marca

                ' Inicializa el objeto Modelo con conexión cerrada
                Dim modelo As New Modelo()
                modelo.idModelo = Convert.ToInt32(lector("idModelo"))
                modelo.nombre = ObtenerDescripcionModelo(modelo.idModelo)
                equipo.Modelo = modelo

                equipo.Estado = lector("estado")
                equipo.Baja = lector("baja")
            End If

            lector.Close()

        Catch ex As Exception
            MessageBox.Show("Error al obtener el equipo: " & ex.Message)
        Finally
            conexion.Close()
        End Try

        Return equipo
    End Function






End Class
