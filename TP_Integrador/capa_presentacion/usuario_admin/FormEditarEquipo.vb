Imports System.Net
Imports System.Runtime.InteropServices.JavaScript.JSType

Public Class FormEditarEquipo
    Dim equipo As Equipos.Equipo
    Dim alFinalizar As Action

    ' Constructor que inicializa el formulario con el equipo a editar
    Public Sub New(equipo As Equipos.Equipo, alFinalizar As Action)
        InitializeComponent()
        Me.equipo = equipo
        Me.alFinalizar = alFinalizar


    End Sub

    ' Carga del formulario
    Private Sub FormEditarEquipo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarClientes()
        ListarTiposDeEquipos()
        ListarMarcas()
        ListarModelos()
        InicializarCampos()
    End Sub

    ' Método para listar clientes en el ComboBox
    Private Sub ListarClientes()
        Dim clientes = Cliente.obtenerClientes()
        ComboBAsociarCliente.DataSource = clientes
        ComboBAsociarCliente.DisplayMember = "Nombre"
        ComboBAsociarCliente.ValueMember = "ID"
        ComboBAsociarCliente.Refresh()
    End Sub

    ' Método para listar tipos de equipos
    Private Sub ListarTiposDeEquipos()
        Dim tiposEquipos = TiposDeEquipo.ObtenerTiposDeEquipo()
        ComboBTipoEquipo.DataSource = tiposEquipos
        ComboBTipoEquipo.DisplayMember = "Nombre"
        ComboBTipoEquipo.ValueMember = "IdTipoEquipo"
        ComboBTipoEquipo.Refresh()
    End Sub

    ' Método para listar marcas de equipos
    Private Sub ListarMarcas()
        Dim marcasEquipos = Marcas.ObtenerMarcas()
        ComboBMarca.DataSource = marcasEquipos
        ComboBMarca.DisplayMember = "nombre"
        ComboBMarca.ValueMember = "idMarca"
        ComboBMarca.Refresh()
    End Sub

    ' Método para listar modelos de equipos
    Private Sub ListarModelos()
        Dim modelosEquipos = Modelos.ObtenerModelos()
        ComboBModelo.DataSource = modelosEquipos
        ComboBModelo.DisplayMember = "nombre"
        ComboBModelo.ValueMember = "idModelo"
        ComboBModelo.Refresh()
    End Sub

    ' Inicializa los campos del formulario con los datos del equipo
    Private Sub InicializarCampos()
        ' Cargar el valor seleccionado en ComboBox del tipo de equipo
        ComboBTipoEquipo.SelectedValue = equipo.TipoEquipo.IdTipoEquipo
        TBNroSerie.Text = equipo.NumeroSerie
        ComboBMarca.SelectedValue = equipo.Marca.idMarca
        ComboBModelo.SelectedValue = equipo.Modelo.idModelo
        TBRazonIngreso.Text = equipo.RazonIngreso
        TBObservaciones.Text = equipo.Observaciones
        CBEquipoEnciende.Checked = (equipo.Enciende = "Si")
        ComboBAsociarCliente.SelectedValue = equipo.Cliente.ID


    End Sub


    ' Método para editar el equipo al hacer clic en el botón
    Private Sub BEditarEquipo_Click(sender As Object, e As EventArgs) Handles BEditarEquipo.Click
        ' Validar los campos del formulario
        If Not ValidarCampos() Then
            MessageBox.Show("Por favor complete todos los campos obligatorios", "Editar equipo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Crear un objeto de equipo editado con los nuevos valores
        Dim equipoEditado As New Equipos.Equipo() With {
            .NumeroSerie = TBNroSerie.Text,
            .RazonIngreso = TBRazonIngreso.Text,
            .Observaciones = TBObservaciones.Text,
            .Enciende = If(CBEquipoEnciende.Checked, "Si", "No"),
            .TipoEquipo = New TiposDeEquipo.TipoDeEquipo() With {.IdTipoEquipo = ComboBTipoEquipo.SelectedValue},
            .Marca = New Marcas.Marca() With {.idMarca = ComboBMarca.SelectedValue},
            .Modelo = New Modelos.Modelo() With {.idModelo = ComboBModelo.SelectedValue},
            .Cliente = New Cliente() With {.ID = ComboBAsociarCliente.SelectedValue}
        }

        ' Llamar a la función para editar el equipo
        If Equipos.editarEquipo(equipo.IDEquipo, equipoEditado) Then
            alFinalizar()
            Me.Close()
        End If
    End Sub

    ' Método para validar campos del formulario
    Private Function ValidarCampos() As Boolean
        Return Not String.IsNullOrEmpty(TBNroSerie.Text) AndAlso
           Not String.IsNullOrEmpty(TBRazonIngreso.Text) AndAlso
           Not String.IsNullOrEmpty(TBObservaciones.Text) AndAlso
           ComboBTipoEquipo.SelectedValue IsNot Nothing AndAlso
           ComboBMarca.SelectedValue IsNot Nothing AndAlso
           ComboBModelo.SelectedValue IsNot Nothing AndAlso
           ComboBAsociarCliente.SelectedValue IsNot Nothing
    End Function


    ' Método para cerrar el formulario
    Private Sub IBCerrar_EC_Click(sender As Object, e As EventArgs) Handles IBCerrar_EC.Click
        Me.Close()
    End Sub

    ' Método para minimizar el formulario
    Private Sub IBMinimizar_EC_Click(sender As Object, e As EventArgs) Handles IBMinimizar_EC.Click
        WindowState = FormWindowState.Minimized
    End Sub

End Class
