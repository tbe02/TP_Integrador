Imports TP_Integrador.Revisiones

Public Class Marcas
    Private Shared instancia As Marcas = Nothing

    Class Marca
        Public Property idMarca As Integer
        Public Property nombre As String
    End Class


    Public Function ObtenerMarcas() As List(Of Marca)
        Dim marcas As New List(Of Marca)()

        Dim conexion = New BaseDeDatos().obtenerConexion()
        Dim comando = New SqlCommand("SELECT * FROM Marcas;", conexion)

        conexion.Open()

        Using lector As SqlDataReader = comando.ExecuteReader()
            If lector.HasRows Then
                While lector.Read()
                    marcas.Add(
                    New Marca With {
                    .idMarca = lector("idMarca").ToString(),
                    .nombre = lector("nombre").ToString()
                    }
                )
                End While
            End If
        End Using

        Return marcas
    End Function


    Public Shared Function ObtenerInstancia() As Marcas
        If instancia Is Nothing Then
            instancia = New Marcas()
        End If

        Return instancia
    End Function

    Public Shared Function agregarMarca(marca As Marcas.Marca)
        Dim conexion = New BaseDeDatos().obtenerConexion()

        Try
            Dim comando = New SqlCommand("INSERT INTO Marcas (nombre) VALUES (@nombre)", conexion)
            comando.Parameters.AddWithValue("@nombre", marca.nombre)

            ' Abre la conexión antes de ejecutar el comando
            conexion.Open()

            ' Ejecuta el comando
            comando.ExecuteNonQuery()

            ' Cambia el estado del equipo después de insertar la revisión
            MessageBox.Show("Marca agregada correctamente", "Confirmación de agregado de marca", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al agregar marca: " & ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    Public Shared Function ObtenerDescripcionMarca(IDMarca As Integer) As String
        Dim descripcion As String = String.Empty
        Using conexion As SqlConnection = New BaseDeDatos().obtenerConexion()
            Try
                conexion.Open()
                Dim comando As New SqlCommand("SELECT nombre FROM Marcas WHERE idMarca = @idMarca", conexion)
                comando.Parameters.AddWithValue("@idMarca", IDMarca)

                Using lector As SqlDataReader = comando.ExecuteReader()
                    If lector.Read() Then
                        descripcion = lector("nombre").ToString()
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al obtener la marca: " & ex.Message)
            End Try
        End Using
        Return descripcion
    End Function



End Class
