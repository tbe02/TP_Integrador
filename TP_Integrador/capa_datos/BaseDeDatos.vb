Public Class BaseDeDatos
    Private nombre = "gestion_reparacion_equipos"

    Public Function obtenerConexion() As SqlConnection
        Dim conexion As New SqlConnection($"Server=192.168.1.110; Database={Me.nombre}; User Id=sa; Password=DB_Password")
        ' Fran MacBook: Server=192.168.200.49; Database=gestion_reparacion_equipos; User Id=sa; Password=DB_Password
        ' Theo NOTEBOOK: Server=THEO-NOTE\SQLEXPRESS; Initial catalog=gestion_reparacion_equipos; Integrated Security=True
        ' Fran Escritorio: Server=DESKTOP-HAOT1MM\SQLEXPRESS; Initial catalog=gestion_reparacion_equipos; Integrated Security=True

        Return conexion
    End Function

    Public Sub Respaldar(direccion As String)
        Dim conexion = Me.obtenerConexion()

        Dim query As String = $"BACKUP DATABASE [{Me.nombre}] TO DISK = '{direccion}'"
        Dim command As New SqlCommand(query, conexion)

        conexion.Open()
        command.ExecuteNonQuery()
        conexion.Close()

        MessageBox.Show("Backup realizado exitosamente.", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub Restaurar(direccion As String)
        Dim conexion = Me.obtenerConexion()

        Dim query As String = $"
            ALTER DATABASE [{Me.nombre}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
            RESTORE DATABASE [{Me.nombre}] FROM DISK = '{direccion}' WITH REPLACE;
            ALTER DATABASE [{Me.nombre}] SET MULTI_USER;"
        Dim command As New SqlCommand(query, conexion)

        conexion.Open()
        command.ExecuteNonQuery()
        conexion.Close()

        MessageBox.Show("Restauración completada exitosamente.", "Restore", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
