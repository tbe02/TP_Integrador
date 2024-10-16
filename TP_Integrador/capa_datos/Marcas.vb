Imports TP_Integrador.TiposDeEquipo

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
End Class
