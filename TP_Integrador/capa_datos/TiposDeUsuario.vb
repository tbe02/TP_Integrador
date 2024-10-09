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

    Public Sub New()
        Agregar(New TipoDeUsuario With {
            .idTipoUsuario = 1,
            .nombre = "maestro"
        })

        Agregar(New TipoDeUsuario With {
            .idTipoUsuario = 2,
            .nombre = "administrador"
        })

        Agregar(New TipoDeUsuario With {
            .idTipoUsuario = 3,
            .nombre = "tecnico"
        })
    End Sub

    Public Function ObtenerTodos() As List(Of TipoDeUsuario)
        Return Me.tiposDeUsuario
    End Function

    Public Shared Function ObtenerInstancia() As TiposDeUsuario
        If instancia Is Nothing Then
            instancia = New TiposDeUsuario()
        End If

        Return instancia
    End Function
End Class
