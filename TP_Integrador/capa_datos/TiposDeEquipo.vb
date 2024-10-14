Imports TP_Integrador.Modelos

Public Class TiposDeEquipo
    Private Shared instancia As TiposDeEquipo = Nothing

    Class TipoDeEquipo
        Public Property IdTipoEquipo As Integer
        Public Property Nombre As String
    End Class


    Public Shared Function ObtenerTiposDeEquipo() As List(Of TipoDeEquipo)
        Dim tiposDeEquipo As New List(Of TipoDeEquipo)()

        Dim conexion = New BaseDeDatos().obtenerConexion()

        Dim comando = New SqlCommand("SELECT * FROM TiposDeEquipo;", conexion)

        conexion.Open()

        Using lector As SqlDataReader = comando.ExecuteReader()

            If lector.HasRows Then
                While lector.Read()
                    tiposDeEquipo.Add(
                        New TipoDeEquipo With {
                        .IdTipoEquipo = lector("idTipoDeEquipo").ToString(),
                        .Nombre = lector("nombre").ToString()
                        }
                    )
                End While

            End If
        End Using

        Return tiposDeEquipo


    End Function

    Private Shared Function ObtenerInstancia() As TiposDeEquipo
        If instancia Is Nothing Then
            instancia = New TiposDeEquipo()
        End If

        Return instancia
    End Function
End Class
