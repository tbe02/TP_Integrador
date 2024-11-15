Public Class ControladorRestauracionYRespaldo
    Private _baseDeDatos As BaseDeDatos = New BaseDeDatos()

    Public Sub Respaldar(direccion As String)
        Try
            _baseDeDatos.Respaldar(direccion)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Restaurar(direccion As String)
        Try
            _baseDeDatos.Restaurar(direccion)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
