Public Class Modelos
    Private Shared instancia As Modelos = Nothing

    Class Modelo
        Public Property idModelo As Integer
        Public Property nombre As String
    End Class

    Public Sub Agregar(modelo As Modelo)
        Dim conexion = New BaseDeDatos().obtenerConexion()

        Dim comando = New SqlCommand("INSERT INTO Modelos (idModelo, nombre) values ('" & modelo.idModelo & "', '" & modelo.nombre & "')", conexion)

        conexion.Open()

        comando.ExecuteNonQuery()


    End Sub

    Public Function ObtenerModelos() As List(Of Modelo)
        Dim modelos As New List(Of Modelo)()

        Dim conexion = New BaseDeDatos().obtenerConexion()
        Dim comando = New SqlCommand("SELECT * FROM Modelos;", conexion)

        conexion.Open()

        Using lector As SqlDataReader = comando.ExecuteReader()
            If lector.HasRows Then
                While lector.Read()
                    modelos.Add(
                    New Modelo With {
                    .idModelo = lector("idModelo").ToString(),
                    .nombre = lector("nombre").ToString()
                    }
                )
                End While
            End If
        End Using

        Return modelos
    End Function


    Public Shared Function ObtenerInstancia() As Modelos
        If instancia Is Nothing Then
            instancia = New Modelos()
        End If

        Return instancia
    End Function

    Public Shared Function agregarModelo(modelo As Modelos.Modelo)
        Dim conexion = New BaseDeDatos().obtenerConexion()

        Try
            Dim comando = New SqlCommand("INSERT INTO Modelos (nombre) VALUES (@nombre)", conexion)
            comando.Parameters.AddWithValue("@nombre", modelo.nombre)

            ' Abre la conexión antes de ejecutar el comando
            conexion.Open()

            ' Ejecuta el comando
            comando.ExecuteNonQuery()

            ' Cambia el estado del equipo después de insertar la revisión
            MessageBox.Show("Modelo agregado correctamente", "Confirmación de agregado de modelo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al agregar modelo: " & ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

End Class
