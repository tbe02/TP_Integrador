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

    Public Shared Function ObtenerModelos() As List(Of Modelo)
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
End Class
