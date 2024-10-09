Public Class Marcas
    Private Shared instancia As Marcas = Nothing

    Class Marca
        Public Property idMarca As Integer
        Public Property nombre As String
    End Class

    Private marcas As New List(Of Marca)

    Public Sub New()
        Agregar(New Marca With {
            .idMarca = 1,
            .nombre = "Canon"
        })

        Agregar(New Marca With {
            .idMarca = 2,
            .nombre = "Toshiba"
        })

        Agregar(New Marca With {
            .idMarca = 3,
            .nombre = "Kyocera"
        })
    End Sub

    Public Sub Agregar(marca As Marca)
        marcas.Add(marca)
    End Sub

    Public Function ObtenerTodas() As List(Of Marca)
        Return Me.marcas
    End Function

    Public Shared Function ObtenerInstancia() As Marcas
        If instancia Is Nothing Then
            instancia = New Marcas()
        End If

        Return instancia
    End Function
End Class
