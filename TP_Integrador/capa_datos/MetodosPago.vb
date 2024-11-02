Imports TP_Integrador.Modelos

Public Class MetodosPago

    Private Shared instancia As MetodosPago = Nothing
    Class MetodoPago
        Public Property id As Integer

        Public Property nombre As String
    End Class




    Public Function ObtenerMetodosPago() As List(Of MetodoPago)
        Dim metodoPago As New List(Of MetodoPago)()

        Dim conexion = New BaseDeDatos().obtenerConexion()
        Dim comando = New SqlCommand("SELECT * FROM MetodosPago;", conexion)

        conexion.Open()

        Using lector As SqlDataReader = comando.ExecuteReader()
            If lector.HasRows Then
                While lector.Read()
                    metodoPago.Add(
                    New MetodoPago With {
                    .id = lector("id").ToString(),
                    .nombre = lector("nombre").ToString()
                    }
                )
                End While
            End If
        End Using

        Return metodoPago
    End Function

    Public Shared Function ObtenerInstancia() As MetodosPago
        If instancia Is Nothing Then
            instancia = New MetodosPago()
        End If

        Return instancia
    End Function


End Class
