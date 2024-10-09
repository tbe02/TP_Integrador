Public Class TiposDeEquipo
    Private Shared instancia As TiposDeEquipo = Nothing

    Class TipoDeEquipo
        Public Property idTipoEquipo As Integer
        Public Property nombre As String
    End Class

    Private tiposDeEquipo As List(Of TipoDeEquipo)

    Public Sub Agregar(tipoDeEquipo As TipoDeEquipo)
        tiposDeEquipo.Add(tipoDeEquipo)
    End Sub

    Public Sub New()
        Agregar(New TipoDeEquipo With {
            .idTipoEquipo = 1,
            .nombre = "Computadora"
        })

        Agregar(New TipoDeEquipo With {
            .idTipoEquipo = 2,
            .nombre = "Impresora laser"
        })

        Agregar(New TipoDeEquipo With {
            .idTipoEquipo = 3,
            .nombre = "Impresora tinta"
        })

        Agregar(New TipoDeEquipo With {
            .idTipoEquipo = 4,
            .nombre = "Fotocopiadora"
        })
    End Sub

    Public Function ObtenerTodos() As List(Of TipoDeEquipo)
        Return Me.tiposDeEquipo
    End Function

    Private Shared Function ObtenerInstancia() As TiposDeEquipo
        If instancia Is Nothing Then
            instancia = New TiposDeEquipo()
        End If

        Return instancia
    End Function
End Class
