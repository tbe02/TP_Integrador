Public Class BaseDeDatos
    Public Function obtenerConexion() As SqlConnection
        Dim conexion As New SqlConnection("Server=192.168.1.110; Database=gestion_reparacion_equipos; User Id=sa; Password=DB_Password")

        ' Fran MacBook: Server=192.168.200.49; Database=gestion_reparacion_equipos; User Id=sa; Password=DB_Password
        ' Theo NOTEBOOK: Server=THEO-NOTE\SQLEXPRESS; Initial catalog=gestion_reparacion_equipos; Integrated Security=True
        ' Fran Escritorio: Server=DESKTOP-HAOT1MM\SQLEXPRESS; Initial catalog=gestion_reparacion_equipos; Integrated Security=True

        Return conexion
    End Function
End Class
