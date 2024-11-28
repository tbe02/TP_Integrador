Public Class TiposDeUsuario
    Private Shared instancia As TiposDeUsuario = Nothing

    Class TipoDeUsuario
        Public Property idTipoUsuario As Integer
        Public Property nombre As String
    End Class

    Private tiposDeUsuario As List(Of TipoDeUsuario)

    Public Sub Agregar(tipoDeUsuario As TipoDeUsuario)
        tiposDeUsuario.Add(tipoDeUsuario)
    End Sub

    Public Function ObtenerTodos() As List(Of TipoDeUsuario)
        Dim tiposDeUsuario As New List(Of TipoDeUsuario)()

        Dim conexion = New BaseDeDatos().obtenerConexion()

        Dim comando = New SqlCommand("SELECT * FROM TiposDeUsuario;", conexion)

        conexion.Open()

        Using lector As SqlDataReader = comando.ExecuteReader()
            If lector.HasRows Then
                While lector.Read()
                    tiposDeUsuario.Add(
                        New TipoDeUsuario With {
                            .idTipoUsuario = lector("idTipoDeUsuario").ToString(),
                            .nombre = lector("nombre").ToString()
                        }
                    )
                End While
            End If
        End Using

        Return tiposDeUsuario
    End Function

    Public Shared Function ObtenerInstancia() As TiposDeUsuario
        If instancia Is Nothing Then
            instancia = New TiposDeUsuario()
        End If

        Return instancia
    End Function
End Class
