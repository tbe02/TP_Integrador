Public Class BaseDeDatos
    Public Function obtenerConexion() As SqlConnection
        Dim conexion As New SqlConnection("Server=192.168.200.49; Database=gestion_reparacion_equipos; User Id=sa; Password=DB_Password")

        ' Fran MacBook: Server=192.168.200.49; Database=gestion_reparacion_equipos; User Id=sa; Password=DB_Password

        Return conexion
    End Function
End Class
