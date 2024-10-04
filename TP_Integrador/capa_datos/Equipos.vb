Public Class Equipos
    Private Shared instancia As Equipos = Nothing

    Private equipos As New List(Of Equipo)()
    Public Sub New()
        Agregar(New Equipo With {
            .NombreDelCliente = "Theo",
            .TipoDeEquipo = "Impresora",
            .NroSerie = "2477",
            .Marca = "HP",
            .EnciendeEnIngreso = "Si",
            .RazonDeIngreso = "No tira tinta",
            .Observaciones = "Tiene un golpe en la parte frontal",
            .Modelo = "LaserJet",
            .Estado = "En reparacion"
        })
        Agregar(New Equipo With {
            .NombreDelCliente = "Fran",
            .TipoDeEquipo = "Computadora",
            .NroSerie = "4325",
            .Marca = "Mac",
            .EnciendeEnIngreso = "No",
            .RazonDeIngreso = "No enciende",
            .Observaciones = "No tiene detalles visibles",
            .Modelo = "Air M1",
            .Estado = "En revision"
        })
    End Sub

    Class Equipo
        Public Property NombreDelCliente As String
        Public Property TipoDeEquipo As String
        Public Property NroSerie As String
        Public Property Marca As String
        Public Property EnciendeEnIngreso As String
        Public Property RazonDeIngreso As String
        Public Property Observaciones As String
        Public Property Modelo As String
        Public Property Estado As String
    End Class

    Public Sub Agregar(equipo As Equipo)
        equipos.Add(equipo)
    End Sub

    Public Function ObtenerTodos() As List(Of Equipo)
        Return Me.equipos
    End Function

    Public Shared Function ObtenerInstancia() As Equipos
        If instancia Is Nothing Then
            instancia = New Equipos()
        End If

        Return instancia
    End Function
End Class
