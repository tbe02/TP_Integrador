Public Class Modelos
    Private Shared instancia As Modelos = Nothing

    Class Modelo
        Public Property idModelo As Integer
        Public Property nombre As String
    End Class

    Private modelos As List(Of Modelo)

    Public Sub Agregar(modelo As Modelo)
        modelos.Add(modelo)
    End Sub

    Public Function ObtenerTodos() As List(Of Modelo)
        Return Me.modelos
    End Function

    Public Shared Function ObtenerInstancia() As Modelos
        If instancia Is Nothing Then
            instancia = New Modelos()
        End If

        Return instancia
    End Function
End Class
