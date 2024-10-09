Public Class BaseDeDatos
    Public Function obtenerConexion() As SqlConnection
        Dim conexion As New SqlConnection("server=THEO-NOTE\SQLEXPRESS; Initial Catalog=gestion_reparacion_equipos; Integrated Security=True")

        Return conexion
    End Function
End Class
